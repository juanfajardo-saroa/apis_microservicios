/// <Derechos_Reservados>
/// Aplicacion      :SISPAE
/// Autor           :Oscar Mauricio Cortes
/// Ano             :2022
/// Arquitectura    :Patron MVC Net Core 6, Repository ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa            :Ulilitarios Transversales  
/// </Derechos_Reservados>
///  
///    Rebex Sample Code License



using SISPAE.Model;
using Newtonsoft.Json;
using Rebex.Mail;
using Rebex.Mime;
using Rebex.Mime.Headers;
using Rebex.Net;
using System;
using System.Collections;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading;



namespace SISPAE.Common
{
    /// <summary>
    /// Background worker class. Implements all non-GUI functionality.
    /// Invokes the main form's methods to update the GUI.
    /// </summary>
    public class IMAPWorker
    {
        private readonly IMAPConfiguration _config;
        private readonly Imap _imap;
        private readonly Hashtable _knownMessages;
        private ImapMessageCollection _messageList;
        private volatile bool _aborting;
        private string _folder;
        private object _sync = new object();
        private volatile bool _newMessage;
        private volatile bool _disposed;
        public readonly string _Filter;
        public readonly string _Exclusion;

        /// <summary>
        /// Initializes the instance of the worker process.
        /// </summary>
        /// <param name="owner">Owner form of this worker object.</param>
        /// <param name="config">Configuration object.</param>
        public IMAPWorker(IMAPConfiguration config)
        {
            _config = config;
            _knownMessages = new Hashtable();
            _imap = new Imap();
            _imap.Notification += imap_Notification;
            //_imap.ValidatingCertificate += delegate (object sender, SslCertificateValidationEventArgs e)
            //{
            //    //_owner.SafeInvoke((EventHandler<SslCertificateValidationEventArgs>)Verifier.ValidatingCertificate, sender, e);
            //};
        }



        public void ClearCachedMessages()
        {
            _messageList = null;
        }

        /// <summary>
        /// Gets the object that represents the IMAP session.
        /// </summary>
        public Imap Client
        {
            get
            {
                return _imap;
            }
        }

        /// <summary>
        /// Gets or sets whether CheckForUpdates is enabled.
        /// </summary>
        public bool CheckForUpdatesEnabled
        {
            get { return _checkForUpdatesEnabled; }
            set { _checkForUpdatesEnabled = value; }
        }
        private volatile bool _checkForUpdatesEnabled;


        /// <summary>
        /// Aborts the current IMAP operation.
        /// </summary>
        public void Abort()
        {
            _aborting = true;

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        public void Dispose()
        {
            _imap.Dispose();
            _disposed = true;
        }

        /// <summary>
        /// Gets the message list from the IMAP connection.
        /// </summary>
        //private void GetMessageList()
        //{
        //    if (_messageList == null)
        //        _messageList = _imap.GetMessageList(ImapListFields.UniqueId);
        //}


        public ImapMessageCollection GetMessageList()
        {
            _messageList = _imap.GetMessageList(ImapListFields.UniqueId);
            
            if (_messageList == null)
            return new ImapMessageCollection();

            return _messageList;

        }

        /// <summary>
        /// Invokes the main form's method to add a message info to the list.
        /// </summary>
        /// <param name="message">Message info.</param>
        /// <param name="error">True if message was unparsable.</param>
        private void AddMessage(ImapMessageInfo message, bool error)
        {
            //_owner.SafeInvoke(new AddMessageDelegate(_owner.AddMessage), new object[] { message, error });

            lock (_knownMessages.SyncRoot)
            {
                _knownMessages.Add(message.UniqueId, message.UniqueId);
            }
        }

        /// <summary>
        /// Invokes the main form's method to remove a message from the list.
        /// </summary>
        /// <param name="uniqueId">Message unique ID.</param>
        private void RemoveMessage(string uniqueId)
        {
            //_owner.SafeInvoke(new MessageDelegate(_owner.RemoveMessage), new object[] { uniqueId });
            ForgetMessage(uniqueId);
        }



        /// <summary>
        /// Determines whether the message unique ID is known.
        /// </summary>
        /// <param name="uniqueId">Unique ID.</param>
        public bool IsKnownMessage(string uniqueId)
        {
            lock (_knownMessages.SyncRoot)
            {
                return _knownMessages.ContainsKey(uniqueId);
            }
        }

        /// <summary>
        /// Forgets the specified message unique IDs.
        /// </summary>
        /// <param name="uniqueId">Unique ID.</param>
        public void ForgetMessage(string uniqueId)
        {
            lock (_knownMessages.SyncRoot)
            {
                _knownMessages.Remove(uniqueId);
            }
        }

        /// <summary>
        /// Forgets all known message unique IDs.
        /// </summary>
        public void ForgetMessages()
        {
            lock (_knownMessages.SyncRoot)
            {
                _knownMessages.Clear();
            }
        }




        /// <summary>
        /// Starts the requested asynchronous operation.
        /// </summary>
        /// <param name="method">Background method.</param>
        /// <param name="parameter">Background method argument.</param>
        /// <param name="callback">Callback method to be called when the operation ends.</param>
        public void Start()
        {
            // Initialize fields required by the background method.
            _aborting = false;
            _folder = "Inbox";
        }

        /// <summary>
        /// Common background operation stub. Connects, logs in and executes the desired background operation.
        /// </summary>
        public void DoMethod()
        {
            bool connecting = false;
            Exception error;
            try
            {
                if (_imap.State == ImapState.Disconnected)
                {
                    connecting = true;

                    // Get configuration.
                    string server = _config.GetString("server");
                    int port = _config.GetInt32("port");
                    bool singleSignOn = _config.GetBoolean("singleSignOn", false);
                    string userName = _config.GetString("userName");
                    string password = _config.GetString("password");
                    SslMode security;
                    switch (_config.GetInt32("security", 0))
                    {
                        case 1:
                            security = SslMode.Explicit;
                            break;
                        case 2:
                            security = SslMode.Implicit;
                            break;
                        default:
                            security = SslMode.None;
                            break;
                    }

                    _imap.Settings.SslAllowedVersions = (TlsVersion)_config.GetValue("protocol", typeof(TlsVersion));
                    _imap.Settings.SslAllowedSuites = (TlsCipherSuite)_config.GetValue("suite", typeof(TlsCipherSuite));

                    //SetStatus(string.Format("Connecting to {0}...", server));

                    // Forget the old message list.
                    _messageList = null;

                    // Connect to the server with the specified security.
                    _imap.Connect(server, port, security);

                    if (singleSignOn)
                        _imap.Login(ImapAuthentication.Auto);
                    else
                        _imap.Login(userName, password);

                    connecting = false;
                }

                if (_folder != null)
                    _imap.SelectFolder(_folder);

                //GetMessageList();


                error = null;
            }
            catch (Exception x)
            {

                ImapException px = x as ImapException;
                if (px != null && px.Status == ImapExceptionStatus.OperationAborted)
                {
                    // If the operation is a result of an abort, don't report it as error.
                    error = null;
                    _imap.Disconnect();
                }
                else
                {
                    error = x;

                    // If this is a failed connection attempt, disconnect.
                    if (connecting)
                        _imap.Disconnect();
                }
            }

            if (_disposed)
                return;
        }


        public string GetMessageInfo(ImapMessageInfo message) 
        {

            MimeMessage m = _imap.GetMimeMessage(message.UniqueId).ToMessage();
            return  JsonConvert.SerializeObject(m);
       }

        public void DoRetrieveMessageList()
        {
            //SetStatus(string.Format("Getting message IDs from folder {0}...", _imap.CurrentFolder.Name));

            //JCB Obtenemos el Id de la carpeta
            //get the "next unique ID" of the target folder 
            string pUniqueId = string.Empty;
            string pPara = string.Empty;
            string pDe = string.Empty;
            string pAsunto = string.Empty;
            string pContenido = string.Empty;
            string pattern = @"^\s*""?|""?\s*$";
            Regex rgx = new Regex(pattern);
            string Filtros = _config.GetString("Filtros").ToString();
            string Exclusiones = _config.GetString("Exclusiones").ToString();
            string userName = _config.GetString("userName").ToString();
            bool mDelivered = false;
            bool mRelayed = false;
            bool mRead = false;
            bool mFailed = false;
            bool mDelayed = false;



            for (int i = _messageList.Count - 1; i >= 0; i--)
            {
                if (_aborting)
                    break;

                ImapMessageInfo message = _messageList[i];

                if (!IsKnownMessage(message.UniqueId))
                {
                    //SetStatus(string.Format("Getting message ({0}) from folder {1}...", message.UniqueId, _imap.CurrentFolder.Name));
                    try
                    {
                        ImapMessageInfo m = _imap.GetMessageInfo(message.UniqueId, ImapListFields.Envelope);
                        MailMessage mValidate = _imap.GetMailMessage(message.UniqueId);

                        AddMessage(m, false);
                        if (_imap.CurrentFolder.Name.ToLower() == "inbox")
                        {

                            // Validamos que el correo no contenga la misma direccion de envio
                            bool validateYourself = false, validateSubject = false;

                            for (int t = 0; t < m.To.Count; t++)
                            {
                                for (int f = 0; f < m.From.Count; f++)
                                {
                                    if (m.To[t].Address == m.From[f].Address)
                                        validateYourself = true;
                                    if (m.From[f].Address.ToLower().Contains(userName.ToLower()))
                                        validateYourself = true;

                                }
                            }

                            //Validamos las palabras que coincidan con la busqueda
                            string[] arrayFilter = Filtros.Split(',');

                            string text = m.Subject.ToString();
                            byte[] bytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(text);
                            string cleanText = System.Text.Encoding.UTF8.GetString(bytes);

                            foreach (var filter in arrayFilter)
                            {
                                if (cleanText.ToLower().Contains(filter.ToLower()))
                                    validateSubject = true;
                            }


                            for (int k = 0; k < mValidate.Attachments.Count; k++)
                            {
                                Attachment attachment = mValidate.Attachments[k];

                                if (attachment.MediaType.ToLower() == "message/delivery-status")
                                {
                                    validateSubject = false; mDelivered = true;
                                }
                                //if (attachment.MediaType.ToLower() == "message/notification-status")
                                //{
                                //    validateSubject = false; mDelivered = true;
                                //}

                                if (attachment.MediaType.ToLower() == "message/disposition-notification")
                                {
                                    validateSubject = false; mRead = true;
                                }
                            }


                            if (cleanText.ToLower().Contains("delivered:") || cleanText.ToLower().Contains("entregado:"))
                            {
                                validateSubject = false; mDelivered = true;
                            }

                            if (cleanText.ToLower().Contains("relayed:") || cleanText.ToLower().Contains("retransmitido:"))
                            {
                                validateSubject = false; mDelivered = true;
                            }

                            if (cleanText.ToLower().Contains("leido:") || cleanText.ToLower().Contains("read:"))
                            {
                                validateSubject = false; mRead = true;
                            }

                            if (cleanText.ToLower().Contains("no se puede entregar:") || cleanText.ToLower().Contains("mail delivery failed:"))
                            {
                                validateSubject = false; mFailed = true;
                            }

                            if (cleanText.ToLower().Contains("demorado:") || cleanText.ToLower().Contains("delayed:"))
                            {
                                validateSubject = false; mDelayed = true;
                            }


                            //JCB PROCESO DE RADICACION 
                            if (!validateYourself && validateSubject)
                            {
                                if (!m.IsSeen)
                                {
                                    //Marcamos el mensaje como Leido para iniciar el proceso
                                    _imap.SetMessageFlags(message.UniqueId, ImapFlagAction.Add, ImapMessageFlags.Seen);

                                    //Si se pudo procesar copiamos el mensaje a la carpeta de radicados
                                    _imap.CopyMessage(m.UniqueId, "Radicados4US");

                                    string mCuerpo = _imap.GetMailMessage(m.UniqueId).BodyText;

                                    //RADICACION DEL CORREO
                                    string resultDef;

                                    using (var client = new HttpClient())
                                    {
                                        //client.BaseAddress = new Uri("http://localhost:1056");
                                        //client.BaseAddress = new Uri("http://200.31.22.11:8095/");
                                        client.BaseAddress = new Uri("http://presentacionesdoc4uswebservices.doc4us.com/");

                                        client.DefaultRequestHeaders.Accept.Clear();
                                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                                        pUniqueId = m.UniqueId;
                                        pPara = m.From.ToString();
                                        pDe = m.To.ToString();
                                        pAsunto = m.Subject.ToString();
                                        pContenido = mCuerpo == string.Empty ? "n/a" : mCuerpo.ToString();
                                        string sCadena = "api/CadApi/Recibir?usuario=E-Ventanilla&clave=ventanillaElectronica&empresa=1&paraMail=" +
                                            pPara + "&demAIL=" +
                                            pDe + "&ClaseDocumento=2&ventanilla=12&tipoDocumento=165&tramite=10&medioDocumento=2&gradoReserva=3&prioridad=3&soporte=2&tema=10&expedienteNumero=0&asunto=" +
                                            pAsunto + "&contenido=" +
                                            pContenido + "&numeroExterno=0" +
                                            //pUniqueId+ // se pone  0 para no generar el error en el api recibir, que toma este numero como entero para ibpm
                                            "&ibpm4us=false";


                                        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, sCadena);
                                        HttpResponseMessage result = client.SendAsync(request).Result;
                                        string resultContent = result.Content.ReadAsStringAsync().Result;

                                        resultDef = rgx.Replace(resultContent, "");
                                    }


                                    //Respondemos el mensaje
                                    // an e-mail we just received
                                    MailMessage original = _imap.GetMailMessage(message.UniqueId);

                                    // create the reply
                                    MailMessage reply = new MailMessage();

                                    // if the original mail had a message ID,
                                    // reference it using the InReplyTo field
                                    if (original.MessageId != null)
                                        reply.InReplyTo.Add(original.MessageId);

                                    // and compose the reply
                                    reply.To = original.From;
                                    reply.CC = original.CC;
                                    reply.From = _config.GetString("userName").ToString();
                                    reply.MessageId = new MessageId();
                                    reply.Subject = "Confirmación recibido mensajería postal electrónica - RE:" + original.Subject;
                                    //reply.BodyText = "<!DOCTYPE html>  <html>  <head>   <meta http-equiv='Content-Type' content='text/html; charset=UTF-8' />   <meta name='viewport' content='width=device-width, initial-scale=1.0'>   <meta http-equiv='X-UA-Compatible' content='IE=edge'>   <title>Entrega Especial</title>      <link rel='stylesheet' href='http://www.doc4us.com/postal/postal.css'>  </head>  <body leftmargin='0' marginwidth='0' topmargin='0' marginheight='0' offset='0'>   <center>    <table border='0' cellpadding='0' cellspacing='0' height='100%' width='100%' id='backgroundTable'>     <tr>      <td align='center' valign='top' class='innerPadding'>       <table border='0' cellpadding='10' cellspacing='0' width='100%' id='templatePreheader'>        <tr>         <td valign='top' class='preheaderContent'>          <table border='0' cellpadding='10' cellspacing='0' width='100%'>           <tr>            <td valign='top' align='center'>             <div>              No puedes ver este correo correctamente? <a href='#' target='_blank'>Visualízalo desde tu navegador</a>.             </div>            </td>           </tr>          </table>                  </td>        </tr>       </table>       <table border='0' cellpadding='0' cellspacing='0' width='100%' id='templateContainer'>               <tr>         <td align='center' valign='top'>                   <table border='0' cellpadding='0' cellspacing='0' width='100%'>           <tr>            <td width='27' class='corner-top-left' style='background:url('http://www.doc4us.com/postal/images/bg_cornes.jpg');height: 27px;'></td>            <td class='middle top' style='background:url('http://www.doc4us.com/postal/images/bg_top.gif'); height: 27px; background-repeat: repeat-x;'  ></td>            <td width='27' class='corner-top-right' style='background:url('http://www.doc4us.com/postal/images/bg_cornes.jpg');height: 27px;background-position: 27px 0;'></td>           </tr>          </table>          <table border='0' cellpadding='0' cellspacing='0' width='100%' id='templateBody'>                    <tr>            <td>             <table border='0' cellpadding='0' cellspacing='0' width='100%' id='templateBody'>                       <tr>               <td valign='top' class='side left' style='background:url('http://www.doc4us.com/postal/images/bg_sides.jpg'); background-repeat: repeat-y;width: 5%;'></td>               <td valign='top' class='content center' style='width: 90%; padding: 5px;'>  <table border='0' cellpadding='0' cellspacing='0' width='100%'>   <tr>    <td valign='top' class='leftColumnContent headerPadding' style='background-color:#FFFFFF; padding-bottom: 15px;' colspan='2' width='100%'>     <div class='logoLeft'  style='float: left; width: 50%;'>               <table border='0' cellpadding='0' cellspacing='0' width='100%' class='logo-left'>       <tr>        <td valign='top'>         <img src='http://www.doc4us.com/postal/images/002.jpg' />        </td>       </tr>      </table>                     </div>    </td>    <td valign='top' class='leftColumnContent headerPadding' style='background-color:#FFFFFF; padding-bottom: 15px;' colspan='2' width='100%'>     <div class='logoRight' style='float: right; width: 50%;'>              <table border='0' cellpadding='0' cellspacing='0' width='100%' class='logo-left'>       <tr>        <td valign='top'>         <img src='http://www.doc4us.com/postal/images/postal.jpg' />        </td>       </tr>       <tr>        <td valign='top' class='radicacion' style='padding-top: 15px; '>         <h2 style=' color:#06377a;display:block;font-family:Arial;font-size:16px;font-weight:bold;line-height:100%;margin-top:0;margin-right:0;margin-bottom:10px;margin-left:0;'>No. Radicación:</h2>         <span class='texto' style='color:#06377a; font-size: 14px; font-family: Arial, Helvetica, sans-serif;  display: block;'><a href='http://192.168.3.66/Account/LogOn' target='_blank'>#|registro|#</a></span>        </td>       </tr>      </table>     </div>                     </td>   </tr>   <tr>    <td valign='top' class='leftColumnContent' >          <div class='entrega-especial'>      <img src='http://www.doc4us.com/postal/images/entrega_especial.jpg' />      <h3>ORIGINAL</h3>     </div>    </td>    <td valign='top' class='leftColumnContent'>       <div class='datos' style='color:#06377a;display:block;font-family:Arial;font-size:18px;font-weight:bold;line-height:100%;margin-top:0;margin-right:0;margin-bottom:10px;margin-left:0;' >                        <h1>Destinatario</h1><span class='texto textoPadding' style='color:#06377a; font-size: 14px; font-family: Arial, Helvetica, sans-serif;  display: block;'>#|destino|#</span>      <h2>Asunto</h2><span class='texto textoPadding' style='color:#06377a; font-size: 14px; font-family: Arial, Helvetica, sans-serif;  display: block;'>#|asunto|#.</span>     </div>    </td>   </tr>  </table>  <table border='0' cellpadding='0' cellspacing='0' width='100%'>    <tr>     <td valign='top' class='leftColumnContent'>           <table border='0' cellpadding='0' cellspacing='0' width='100%' class='remitente'>       <tr>       <br>        <td valign='middle' width='70%'>         <h2 style=' color:#06377a;display:block;font-family:Arial;font-size:16px;font-weight:bold;line-height:100%;margin-top:0;margin-right:0;margin-bottom:10px;margin-left:0;'>Remitente:</h2>         <span class='texto' style='color:#06377a; font-size: 14px; font-family: Arial, Helvetica, sans-serif;  display: block;'>#|remite|#</span>        </td>          <td valign='middle' width='30%'>         <h2 style=' color:#06377a;display:block;font-family:Arial;font-size:16px;font-weight:bold;line-height:100%;margin-top:0;margin-right:0;margin-bottom:10px;margin-left:0;'>Fecha y Hora:</h2>         <span class='texto' style='color:#06377a; font-size: 14px; font-family: Arial, Helvetica, sans-serif;  display: block;'>#|fecha|#</span>        </td>       </tr>      </table>                    </td>    </tr>   </table>               </td>               <td valign='top' class='side right' style='background:url('http://www.doc4us.com/postal/images/bg_sides.jpg'); background-repeat: repeat-y;width: 5%;background-position-x: 100%;'></td>              </tr>             </table>            </td>           </tr>          </table>                   <table border='0' cellpadding='0' cellspacing='0' width='100%'>           <tr>            <td width='27' class='corner-bottom-left' style='background:url('http://www.doc4us.com/postal/images/bg_cornes.jpg');height: 27px;background-position: 0 27px;'></td>            <td class='middle bottom' style='background:url('http://www.doc4us.com/postal/images/bg_top.gif'); height: 27px; background-repeat: repeat-x; background-position: 0 bottom;'></td>            <td width='27' class='corner-bottom-right' style='background:url('http://www.doc4us.com/postal/images/bg_cornes.jpg');height: 27px;background-position: 27px 27px;'></td>           </tr>          </table>         </td>                 <table border='0' cellpadding='10' cellspacing='0' width='100%'>          <tr>          <td valign='top' align='center'  >           <div class='texto'>            Todos los Derechos Reservados &copy;<a href='http://www.doc4Us.com' target='_blank'>Doc4Us</a>            <br>             Este correo ha sido enviado a través de la Oficina Postal Electr&oacute;nica de Doc4Us            <br> Por favor no RESPONDER este correo.            Toda comunicación referente al documento radicado, deber&aacute; ser consultada en Doc4Us           </div>          </td>          </tr>         </table>        </tr>       </table>       <br>      </td>     </tr>    </table>   </center>  </body>  </html>";
                                    reply.Headers.Add("Disposition-Notification-To", userName);

                                    LinkedResource lrEmpresa = new LinkedResource(@"C:\Proyectos\OPE\OPE4US-master\ImapBrowser_CS\img\logoEmpresa.png", "image/png");
                                    LinkedResource lrbg_cornes = new LinkedResource(@"C:\Proyectos\OPE\OPE4US-master\ImapBrowser_CS\img\bg_cornes.jpg", "image/jpeg");
                                    LinkedResource lrbg_sides = new LinkedResource(@"C:\Proyectos\OPE\OPE4US-master\ImapBrowser_CS\img\bg_sides.jpg", "image/jpeg");
                                    LinkedResource lrbg_top = new LinkedResource(@"C:\Proyectos\OPE\OPE4US-master\ImapBrowser_CS\img\bg_top.jpg", "image/jpeg");
                                    LinkedResource lrentrega_especial = new LinkedResource(@"C:\Proyectos\OPE\OPE4US-master\ImapBrowser_CS\img\entrega_especial.jpg", "image/jpeg");
                                    LinkedResource lrLogoEmpresa = new LinkedResource(@"C:\Proyectos\OPE\OPE4US-master\ImapBrowser_CS\img\logoEmpresa.png", "image/png");
                                    LinkedResource lrPostal = new LinkedResource(@"C:\Proyectos\OPE\OPE4US-master\ImapBrowser_CS\img\postal.jpg", "image/jpeg");
                                    lrEmpresa.ContentId = "0123456789@rebex.net"; // a unique ID
                                    lrbg_cornes.ContentId = "1123456789@rebex.net"; // a unique ID
                                    lrbg_sides.ContentId = "2123456789@rebex.net"; // a unique ID
                                    lrbg_top.ContentId = "3123456789@rebex.net"; // a unique ID
                                    lrentrega_especial.ContentId = "4123456789@rebex.net"; // a unique ID
                                    lrLogoEmpresa.ContentId = "5123456789@rebex.net"; // a unique ID
                                    lrPostal.ContentId = "6123456789@rebex.net"; // a unique ID


                                    string sbody = "<!DOCTYPE html><html><head><meta http-equiv='Content-Type' content='text/html; charset=UTF-8' />   <meta name='viewport' content='width=device-width, initial-scale=1.0'> ";
                                    sbody += "  <meta http-equiv='X-UA-Compatible' content='IE=edge'>   <title>OPE Oficina Postal Electrónica</title>      <link rel='stylesheet' href='http://www.doc4us.com/postal/postal.css'>  </head>  <body leftmargin='0' marginwidth='0' topmargin='0' marginheight='0' offset='0'>   <center>    <table border='0' cellpadding='0' cellspacing='0' height='100%' width='100%' id='backgroundTable'>     <tr>      <td align='center' valign='top' class='innerPadding'>   ";
                                    //sbody += "  <table border='0' cellpadding='10' cellspacing='0' width='100%' id='templatePreheader'>        <tr>         <td valign='top' class='preheaderContent'>          <table border='0' cellpadding='10' cellspacing='0' width='100%'>           <tr>  <td valign='top' align='center'>             <div>              No puedes ver este correo correctamente? <a href='#' target='_blank'>Visualízalo desde tu navegador</a>.             </div>            </td>      </tr>          </table>                  </td>        </tr>       </table>   ";
                                    sbody += "    <table border='4' bordercolor='gray' cellpadding='0' cellspacing='0' width='100%' id='templateContainer'>               <tr>         <td align='center' valign='top'>                   <table border='0' cellpadding='0' cellspacing='0' width='100%'>           <tr>        ";
                                    sbody += "  <td width='27' class='corner-top-left' style='background:url(cid:1123456789@rebex.net);height: 27px;'></td>          ";
                                    sbody += "  <td class='middle top' style='background:url(cid:3123456789@rebex.net); height: 27px; background-repeat: repeat-x;'  ></td>         ";
                                    sbody += "  <td width='27' class='corner-top-right' style='background:url(cid:1123456789@rebex.net);height: 27px;background-position: 27px 0;'></td>           </tr>          </table>          <table border='0' cellpadding='0' cellspacing='0' width='100%' id='templateBody'>                    <tr>            <td>             <table border='0' cellpadding='0' cellspacing='0' width='100%' id='templateBody'>                       <tr>       ";
                                    sbody += "  <td valign='top' class='side left' style='background:url(cid:2123456789@rebex.net); background-repeat: repeat-y;width: 5%;'></td>               <td valign='top' class='content center' style='width: 90%; '>  <table border='0' cellpadding='0' cellspacing='0' width='90%'>   <tr>    <td valign='top' class='leftColumnContent headerPadding' style='background-color:#FFFFFF; padding-bottom: 15px;' colspan='2' width='100%'>     <div class='logoLeft'  style='float: left; width: 50%;'>               <table border='0' cellpadding='0' cellspacing='0' width='100%' class='logo-left'>       <tr>        <td valign='top'>  ";
                                    sbody += "  <img src='cid:5123456789@rebex.net' />        </td>       </tr>      </table>                     </div>    </td>    <td valign='top' class='leftColumnContent headerPadding' style='background-color:#FFFFFF; padding-bottom: 15px;' colspan='2' width='100%'>     <div class='logoRight' style='float: right; width: 50%;'>              <table border='0' cellpadding='0' cellspacing='0' width='100%' class='logo-left'>       <tr>        <td valign='top'>   ";
                                    sbody += "  <img src='cid:6123456789@rebex.net' />        </td>       </tr>       <tr>        <td valign='top' class='radicacion' style='padding-top: 15px; '>         <h2 style=' color:#06377a;display:block;font-family:Arial;font-size:16px;font-weight:bold;line-height:100%;margin-top:0;margin-right:0;margin-bottom:10px;margin-left:0;'>No. Radicación:</h2>         <span class='texto' style='color:#06377a; font-size: 14px; font-family: Arial, Helvetica, sans-serif;  display: block;'>";
                                    sbody += "  <a href='mailto:correspondencia@aon.com?Subject=Radicado:" + resultDef.ToString() + "%20Solicitud%20:&body=Solicitud%20de%20Información' target='_blank'>";
                                    sbody += resultDef.ToString() + "</a>";  // Número de Radicado
                                    sbody += "  </span>        </td>       </tr>      </table>     </div>                     </td>   </tr>   <tr>    <td valign='top' class='leftColumnContent' >          <div class='entrega-especial'>  ";
                                    sbody += "  <img src='cid:4123456789@rebex.net' />      <h3>ORIGINAL</h3>     </div>    </td>    <td valign='top' class='leftColumnContent'>       <div class='datos2' style='color:#06377a;display:block;font-family:Arial;font-size:18px;line-height:100%;margin-top:0;margin-right:0;margin-bottom:10px;margin-left:0;' >                        <h1>Destinatario</h1><span class='texto textoPadding' style='color:#06377a; font-size: 14px; font-family: Arial, Helvetica, sans-serif;  display: block;'>";
                                    sbody += original.From; //"#|destino|#";  // Destinatario
                                    sbody += " </span>      <h2>Asunto</h2><span class='texto textoPadding' style='color:#06377a; font-size: 12px; font-family: Arial, Helvetica, sans-serif;  display: block;'>";
                                    sbody += "En acuse de recibido a su comunicación, le informamos que su email enviado a correspondencia @aon.com fue radicado y le fue asignado el número arriba mencionado";//"#|asunto|#."; //Asunto
                                    sbody += "</span>     </div>    </td>   </tr>  </table>  <table border='0' cellpadding='0' cellspacing='0' width='100%'>    <tr>     <td valign='top' class='leftColumnContent'>           <table border='0' cellpadding='0' cellspacing='0' width='100%' class='remitente'>       <tr>       <br>        <td valign='middle' width='70%'>         <h2 style=' color:#06377a;display:block;font-family:Arial;font-size:16px;font-weight:bold;line-height:100%;margin-top:0;margin-right:0;margin-bottom:10px;margin-left:0;'>Remitente:</h2>         <span class='texto' style='color:#06377a; font-size: 14px; font-family: Arial, Helvetica, sans-serif;  display: block;'>";
                                    sbody += "  <a href='mailto:correspondencia@aon.com?Subject=Radicado:" + resultDef.ToString() + "%20Solicitud%2:&body=Solicitud%20de%20Información' target='_blank'>correspondencia@aon.com</a>";//"#|remite|#";  // Remitente
                                    sbody += "</span>        </td>          <td valign='middle' width='30%'>         <h2 style=' color:#06377a;display:block;font-family:Arial;font-size:16px;font-weight:bold;line-height:100%;margin-top:0;margin-right:0;margin-bottom:10px;margin-left:0;'>Fecha y Hora:</h2>         <span class='texto' style='color:#06377a; font-size: 14px; font-family: Arial, Helvetica, sans-serif;  display: block;'>";
                                    sbody += original.ReceivedDate.LocalTime.ToString("yyyy-MM-dd HH:mm:ss").PadRight(32);//"#|fecha|#";   //Fecha
                                    sbody += "</span>        </td>       </tr>      </table>                    </td>    </tr>   </table>               </td>      ";
                                    sbody += "  <td valign='top' align='right' class='side right' style='background:url(cid:2123456789@rebex.net); background-repeat: repeat-y;width: 5%;background-position-x: 100%;'></td>              </tr>             </table>            </td>           </tr>          </table>                   <table border='0' cellpadding='0' cellspacing='0' width='100%'>           <tr>    ";
                                    sbody += "  <td width='27' class='corner-bottom-left' style='background:url(cid:1123456789@rebex.net);height: 27px;background-position: 0 27px;'></td>      ";
                                    sbody += "  <td class='middle bottom' style='background:url(cid:3123456789@rebex.net); height: 27px; background-repeat: repeat-x; background-position: 0 bottom;'></td>    ";
                                    sbody += "  <td width='27' class='corner-bottom-right' style='background:url(cid:1123456789@rebex.net);height: 27px;background-position: 27px 27px;'></td>           </tr>          </table>                          <table border='0' cellpadding='10' cellspacing='0' width='100%'>          <tr>          <td valign='top' align='center'  >           <div class='texto'>            Todos los Derechos Reservados &copy; <br> Este correo ha sido enviado a través de la Oficina Postal Electr&oacute;nica de AON<br> Por favor no RESPONDER este correo.  Toda comunicación referente al documento radicado, deber&aacute; ser consultada en AON           </div>          </td>          </tr>         </table>     </td>   </tr>       </table>       <br>      </td>     </tr>    </table>   </center>  </body>  </html>";


                                    AlternateView htmlView = new AlternateView();
                                    htmlView.SetContent(sbody,
                                        MediaTypeNames.Text.Html);

                                    reply.AlternateViews.Add(htmlView);
                                    reply.Resources.Add(lrEmpresa);
                                    reply.Resources.Add(lrbg_cornes);
                                    reply.Resources.Add(lrbg_sides);
                                    reply.Resources.Add(lrbg_top);
                                    reply.Resources.Add(lrentrega_especial);
                                    reply.Resources.Add(lrLogoEmpresa);
                                    reply.Resources.Add(lrPostal);


                                    //reply.BodyHtml = sbody;

                                    using (var smtp = new Rebex.Net.Smtp())
                                    {
                                        // connect to Gmail SMTP server
                                        smtp.Connect(_imap.ServerName, SslMode.Explicit);
                                        // authenticate with your email address and password
                                        smtp.Login(_imap.UserName, _config.GetString("password").ToString());

                                        smtp.DeliveryStatusNotificationConditions = DeliveryStatusNotificationConditions.Failure | DeliveryStatusNotificationConditions.Success | DeliveryStatusNotificationConditions.Delay;
                                        //send mail
                                        smtp.Send(reply);
                                        //smtp.Send(reply.From.ToString(), reply.ToString(), reply.Subject, reply.BodyHtml);
                                        // disconnect (not required, but polite)
                                        smtp.Disconnect();
                                    }

                                    //Volvemos a la carpeta inbox para eliminar le mesanje copiado
                                    _imap.SelectFolder("Inbox");
                                    //Eliminamos el mensaje de la bandeja de entrada
                                    _imap.DeleteMessage(m.UniqueId);
                                    ImapMessageInfo info = _messageList.Find(m.UniqueId);
                                    if (info != null)
                                        _messageList.Remove(info);
                                    RemoveMessage(m.UniqueId);
                                    _imap.Purge();

                                    //select the Radicados4US folder and search for all messages whose unique ID is equal to "next unique ID" or larger
                                    //_imap.SelectFolder("Radicados4US");
                                    //ImapMessageSet newSet = new ImapMessageSet();
                                    //newSet.AddRange(nextUniqueId, ImapMessageSet.BuildUniqueId(_imap.CurrentFolder.ValidityId, UInt32.MaxValue));

                                    //ImapMessageCollection list = _imap.Search(ImapListFields.UniqueId, ImapSearchParameter.MessageSet(newSet));
                                }
                            }
                            else
                            {

                                //Marcamos el mensaje como Leido para iniciar el proceso
                                _imap.SetMessageFlags(message.UniqueId, ImapFlagAction.Add, ImapMessageFlags.Seen);

                                //Si NO se pudo procesar copiamos el mensaje a la carpeta de NO radicados

                                if (mDelivered || mRelayed)
                                    _imap.CopyMessage(m.UniqueId, "Confirmacion Entregado");
                                else if (mRead)
                                    _imap.CopyMessage(m.UniqueId, "Confirmacion Leido");
                                else if (mFailed)
                                    _imap.CopyMessage(m.UniqueId, "Confirmacion Fallido");
                                else if (mDelayed)
                                    _imap.CopyMessage(m.UniqueId, "Confirmacion Demorada");
                                else
                                    _imap.CopyMessage(m.UniqueId, "NO Radicados");

                                //Volvemos a la carpeta inbox para eliminar le mesanje copiado
                                _imap.SelectFolder("Inbox");
                                //Eliminamos el mensaje de la bandeja de entrada
                                _imap.DeleteMessage(m.UniqueId);
                                ImapMessageInfo info = _messageList.Find(m.UniqueId);
                                if (info != null)
                                    _messageList.Remove(info);
                                RemoveMessage(m.UniqueId);
                                _imap.Purge();

                            }
                        }


                    }
                    catch (MimeException)
                    {
                        AddMessage(message, true);
                    }
                }
            }


        }


        public TH_TransaccionComunes DoRetrieveMessage(ImapMessageInfo message)
        {
            //SetStatus(string.Format("Getting message IDs from folder {0}...", _imap.CurrentFolder.Name));

            //JCB Obtenemos el Id de la carpeta
            //get the "next unique ID" of the target folder 

            TH_TransaccionComunes tc = new TH_TransaccionComunes();
            tc.fecha = DateTime.Now;

            string pattern = @"^\s*""?|""?\s*$";
            Regex rgx = new Regex(pattern);
            string userName = _config.GetString("userName").ToString();
            bool mDelivered = false;
            bool mRelayed = false;
            bool mRead = false;
            bool mFailed = false;
            bool mDelayed = false;


            if (!IsKnownMessage(message.UniqueId))
            {
                //SetStatus(string.Format("Getting message ({0}) from folder {1}...", message.UniqueId, _imap.CurrentFolder.Name));
                try
                {
                    ImapMessageInfo m = _imap.GetMessageInfo(message.UniqueId, ImapListFields.Envelope);
                    MailMessage mValidate = _imap.GetMailMessage(message.UniqueId);

                    AddMessage(m, false);
                    if (_imap.CurrentFolder.Name.ToLower() == "inbox")
                    {

                        // Validamos que el correo no contenga la misma direccion de envio
                        bool validateYourself = false, validateSubject = false;

                        for (int t = 0; t < m.To.Count; t++)
                        {
                            for (int f = 0; f < m.From.Count; f++)
                            {
                                if (m.To[t].Address == m.From[f].Address)
                                    validateYourself = true;
                                if (m.From[f].Address.ToLower().Contains(userName.ToLower()))
                                    validateYourself = true;

                            }
                        }


                        string text = m.Subject.ToString();
                        byte[] bytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(text);
                        string cleanText = System.Text.Encoding.UTF8.GetString(bytes);


                        for (int k = 0; k < mValidate.Attachments.Count; k++)
                        {
                            Attachment attachment = mValidate.Attachments[k];

                            if (attachment.MediaType.ToLower() == "message/delivery-status")
                            {
                                validateSubject = false; mDelivered = true;
                            }
                            //if (attachment.MediaType.ToLower() == "message/notification-status")
                            //{
                            //    validateSubject = false; mDelivered = true;
                            //}

                            if (attachment.MediaType.ToLower() == "message/disposition-notification")
                            {
                                validateSubject = false; mRead = true;
                            }
                        }


                        if (cleanText.ToLower().Contains("delivered:") || cleanText.ToLower().Contains("entregado:"))
                        {
                            validateSubject = false; mDelivered = true; tc.TipoOperacion += "delivered";
                        }

                        if (cleanText.ToLower().Contains("relayed:") || cleanText.ToLower().Contains("retransmitido:"))
                        {
                            validateSubject = false; mDelivered = true; tc.TipoOperacion += "relayed";
                        }

                        if (cleanText.ToLower().Contains("leido:") || cleanText.ToLower().Contains("read:"))
                        {
                            validateSubject = false; mRead = true; tc.TipoOperacion += "read";
                        }

                        if (cleanText.ToLower().Contains("no se puede entregar:") || cleanText.ToLower().Contains("mail delivery failed:"))
                        {
                            validateSubject = false; mFailed = true; tc.TipoOperacion += "failed";
                        }

                        if (cleanText.ToLower().Contains("demorado:") || cleanText.ToLower().Contains("delayed:"))
                        {
                            validateSubject = false; mDelayed = true; tc.TipoOperacion += "delayed";
                        }


                        //Marcamos el mensaje como Leido para iniciar el proceso
                        _imap.SetMessageFlags(message.UniqueId, ImapFlagAction.Add, ImapMessageFlags.Seen);

                        //Si NO se pudo procesar copiamos el mensaje a la carpeta de NO radicados

                        if (mDelivered || mRelayed)
                            _imap.CopyMessage(m.UniqueId, "Confirmacion Entregado");
                        else if (mRead)
                            _imap.CopyMessage(m.UniqueId, "Confirmacion Leido");
                        else if (mFailed)
                            _imap.CopyMessage(m.UniqueId, "Confirmacion Fallido");
                        else if (mDelayed)
                            _imap.CopyMessage(m.UniqueId, "Confirmacion Demorada");
                        else
                            _imap.CopyMessage(m.UniqueId, "NO Radicados");

                        //Volvemos a la carpeta inbox para eliminar le mesanje copiado
                        _imap.SelectFolder("Inbox");
                        //Eliminamos el mensaje de la bandeja de entrada
                        _imap.DeleteMessage(m.UniqueId);
                        ImapMessageInfo info = _messageList.Find(m.UniqueId);
                        if (info != null)
                            _messageList.Remove(info);
                        RemoveMessage(m.UniqueId);
                        _imap.Purge();

                    }

                    tc.Transaccion = JsonConvert.SerializeObject(m);
                
                    return tc;
                }
                catch (MimeException mex)
                {
                    AddMessage(message, true);
                    tc.Transaccion = mex.Message;
                    return tc;
                }
            }


            return tc;
        }
        /// <summary>
        /// Deletes specified messages.
        /// </summary>
        private void DoDeleteMessages(string[] uniqueIds)
        {

            GetMessageList();

            for (int i = 0; i < uniqueIds.Length; i++)
            {
                string uniqueId = uniqueIds[i];
                _imap.DeleteMessage(uniqueId);
                ImapMessageInfo info = _messageList.Find(uniqueId);
                if (info != null)
                    _messageList.Remove(info);
                RemoveMessage(uniqueId);
            }

            _imap.Purge();
        }



        /// <summary>
        /// Saves the message into the supplied stream.
        /// </summary>
        private void DoSaveMessage(string uniqueId)
        {
            //Falta definir la ruta
            string filePath = (string)(uniqueId);

            GetMessageList();

            string extension = Path.GetExtension(filePath);
            if (string.Equals(extension, ".msg", StringComparison.OrdinalIgnoreCase))
            {
                // get message from IMAP (and parse it)
                MailMessage message = _imap.GetMailMessage(uniqueId);

                // save message in MSG format
                message.Save(filePath, MailFormat.OutlookMsg);
            }
            else
            {
                // get message from IMAP directly into file in MIME format (without parsing)
                _imap.GetMessage(uniqueId, filePath);
            }
        }


        private void imap_Notification(object sender, ImapNotificationEventArgs e)
        {
            _newMessage = true;
            _imap.Abort();
        }
    }
}
