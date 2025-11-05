/// <Derechos_Reservados>
/// Aplicacion      :SISPAE
/// Autor           :Oscar Mauricio Cortes
/// Ano             :2022
/// Arquitectura    :Patron MVC Net Core 6, Repository ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa            :Ulilitarios Transversales  
/// </Derechos_Reservados>

namespace SISPAE.Common
{
    using SISPAE.Model;
    using Rebex.IO.Compression;
    using Rebex.Mime.Headers;
    using Rebex.Net;
    using Rebex.Security.Certificates;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Configuration;
    using Microsoft.Extensions.Configuration;
    using Rebex.Mail;
    using System.IO;
    using Newtonsoft.Json;

    public static class emailSender4us
    {

        public static IConfigurationRoot Configuration;

        public async static Task SendEmail(SimpleMailMessage Mail, TS_SMTP smtp, string obj="")
        {
            await SendEmailAsync(Mail, smtp, obj);
            //return Json(0, JsonRequestBehavior.AllowGet);
        }

        public async static Task SendEmail(SimpleMailMessage Mail, TS_SMTP smtp, string DirectorioVirtual, Rebex.Mail.AttachmentCollection Attachments, bool CertificadoSi, string obj="")
        {
            await SendEmailAsync(Mail, smtp, DirectorioVirtual, Attachments, CertificadoSi, obj);
            //return Json(0, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Envio de correo Electronico
        /// </summary>
        /// <param name="Mail"></param>
        /// <param name="smtp"></param>
        /// <param name="desmtp"></param>
        private async static Task SendEmailAsync(SimpleMailMessage pMail, TS_SMTP pSmtp, string obj = "")
        {
            //Rebex.Licensing.Key = Rebex.Samples.TrialKey.Key;

            try
            {

                // create Mail message
                var Mail = new Rebex.Mail.MailMessage();
                var rebSMTP = new Rebex.Net.Smtp();

                //Mail.From = new Rebex.Mime.Headers.MailAddressCollection(pMail.From);
                Mail.From = new MailAddress(pMail.From, pMail.DisplayName);
                Mail.Subject = pMail.Subject;
                Mail.BodyHtml = pMail.Body;
                Mail.Headers.Add("Disposition-Notification-To", pMail.From);
                Mail.Headers.Add("Identity", pMail.IdGuid.ToString());
                Mail.Headers.Add("Read-Receipt-To", pMail.From);
                Mail.Headers.Add("Retur-Receipt-To", pMail.From);
                Mail.MessageId = new Rebex.Mime.Headers.MessageId();
                Mail.EnvelopeId = Mail.MessageId.Id;
                Mail.Headers.Add("Message-Id", String.Format("<{0}@{1}>", Mail.MessageId.Id.ToString(), pMail.From));
                Mail.Priority = Rebex.Mail.MailPriority.High;
                if (string.IsNullOrEmpty(obj))
                    Mail.Headers.Add("X_TM_Actividad", obj);


                string[] arrayTO = pMail.To.Split(',');
                foreach (var to in arrayTO)
                {
                    Mail.To.Add(to);
                }


                using (Rebex.Net.Smtp smtp = new Rebex.Net.Smtp())
                {
                    smtp.DeliveryStatusNotificationConditions =
                   DeliveryStatusNotificationConditions.Failure |
                   DeliveryStatusNotificationConditions.Success |
                   DeliveryStatusNotificationConditions.Delay;

                    // include full original message to DSN
                    smtp.DeliveryStatusNotificationOriginalMessageMethod = DeliveryStatusNotificationOriginalMessageMethod.FullMessage;

                    // set SSL parameters to accept all server certificates...
                    // do not do this in production code, server certificates should
                    // be verified - use ValidatingCertificate event instead
                    smtp.Settings.SslAcceptAllCertificates = pSmtp.SSL;


                    // connect to the server
                    if (!string.IsNullOrEmpty(pSmtp.CONTRASENA))
                    {
                        smtp.Connect(pSmtp.SMTP, pSmtp.PUERTO, SslMode.Explicit);

                        //Mensaje Cifrado;
                        bool binaryMime = (smtp.SupportedExtensions & SmtpExtensions.BinaryMime) == SmtpExtensions.BinaryMime;
                        // disable command pipelining
                        smtp.EnabledExtensions &= ~SmtpExtensions.Pipelining;


                        if (pSmtp.USUARIO != null && pSmtp.CONTRASENA != null)
                        {
                            smtp.Login(pSmtp.USUARIO, pSmtp.CONTRASENA);
                        }
                    }
                    else
                    {
                        smtp.Connect(pSmtp.SMTP, pSmtp.PUERTO);
                        smtp.Send(Mail);
                    }

                    //TM_ENVIO _ENVIO = _repository_MemoryTM_ENVIORepository.GetByGUID(pMail.IdGuid);
                    //_ENVIO.MESSAGEID = Mail.MessageId.Id.ToString();
                    //_repository_MemoryTM_ENVIORepository.Update(_ENVIO);

                    // send message
                    await smtp.SendAsync(Mail);

                };
            }
            catch (Exception exc)
            {
                throw new InvalidOperationException(exc.Message);
            }
        }
        /// <summary>
        /// Envio de correo Electronico
        /// </summary>
        /// <param name="Mail"></param>
        /// <param name="smtp"></param>
        /// <param name="desmtp"></param>
        private async static Task SendEmailAsync(SimpleMailMessage pMail, TS_SMTP pSmtp, string DirectorioVirtual, Rebex.Mail.AttachmentCollection Attachments, bool CertificadoSi = false, string obj = "")
        {
            var builder = new ConfigurationBuilder();
            Configuration = builder.Build();

            //  IRepositoryContainer _repository = RepositorySesssion.GetRepository(RepositorySize.Medium, "common");
            String ParametrosCertificado = Configuration["ParametrosCertificado"];


            try
            {
                var Mail = new Rebex.Mail.MailMessage();
       
                //Mail.From = new Rebex.Mime.Headers.MailAddressCollection(pMail.From);
                Mail.From = new MailAddress(pMail.From, pMail.DisplayName);
                Mail.Subject = pMail.Subject;
                Mail.BodyHtml = pMail.Body;

                if (string.IsNullOrEmpty(obj))
                    Mail.Headers.Add("X_TM_Actividad", obj);

                Mail.Headers.Add("Disposition-Notification-To", pMail.From);
                Mail.Headers.Add("Identity", pMail.IdGuid.ToString());
                Mail.Headers.Add("Read-Receipt-To", pMail.From);
                Mail.Headers.Add("Retur-Receipt-To", pMail.From);
                Mail.MessageId = new Rebex.Mime.Headers.MessageId();
                Mail.EnvelopeId = Mail.MessageId.Id;
                Mail.Headers.Add("Message-Id", String.Format("<{0}@{1}>", Mail.MessageId.Id.ToString(), pMail.From));
                Mail.Priority = Rebex.Mail.MailPriority.High;

                if (!string.IsNullOrEmpty(pMail.To))
                {
                    if (pMail.To.Split(',').Count() == 1)
                    {
                        Mail.To.Add(pMail.To);
                    }
                    else
                    {
                        string[] arrayTO = pMail.To.Split(',');
                        foreach (var to in arrayTO)
                        {
                            Mail.To.Add(to);
                        }

                    }
                }


                // JCB Esta parte de zip falta por configurar recibir el bool, enviar la ruta y password y el for para leer la ruta de los archivos o enviarlos por la funcion en una lista
                bool ZipiarArchive = false;
                string pwd = "password definir";
                if (ZipiarArchive)
                {
                    string folderZIP = DirectorioVirtual + "\\Attachments.zip";

                    using (var zip = new ZipArchive(@folderZIP, ArchiveOpenMode.Create))
                    {
                        zip.Password = pwd;

                        // add a file to the root of the ZIP archive
                        //for (int i = 0; i < _anexDoc.Count(); i++)
                        //{
                        //    if (!string.IsNullOrEmpty(_anexDoc[i].ArchivoURL))
                        //    {
                        //        if (System.IO.File.Exists(DirectorioVirtual + _anexDoc[i].ArchivoURL))
                        //            zip.AddFile(@DirectorioVirtual + _anexDoc[i].ArchivoURL);
                        //    }
                        //}
                    }

                    Mail.Attachments.Add(new Rebex.Mail.Attachment(folderZIP));
                }
                else
                {
                    if (Attachments != null)
                    {
                        if (Attachments.Count > 0)
                        {
                            for (int i = 0; i < Attachments.Count; i++)
                            {
                                Mail.Attachments.Add(Attachments[i]);
                            }
                        }
                    }
                }



                //Mensaje Cifrado
                if (CertificadoSi)
                {
                    try
                    {
                        var store = new CertificateStore(CertificateStoreName.My, CertificateStoreLocation.LocalMachine);
                        //var store3 = new CertificateStore(CertificateStoreName.AuthRoot, CertificateStoreLocation.LocalMachine);--trae certificados intermedios
                        // find all not-expired certificates from issuer named "TestCA"
                        var dn = new DistinguishedName(ParametrosCertificado);
                        var found = store.FindCertificates(dn, CertificateFindOptions.None);
                        //ExceptionUtility.LogException(new Exception("{0} certificates encontrados." + found.Length), "certificados ");

                        Mail.Sign(found);
                    }
                    catch (Exception exc)
                    {
                        //ExceptionUtility.LogException(ex, "Validación Certificado");
                        throw new InvalidOperationException(exc.Message);
                    }
                }


                //SmtpClient smtp = new SmtpClient(smtp_address, smtp_port);
                //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                //smtp.Credentials = new NetworkCredential(smtp_user, smtp_password);
                //smtp.EnableSsl = smtp_ssl;

                //smtp.Send(mm);


                using (Rebex.Net.Smtp smtp = new Rebex.Net.Smtp())
                {

                    smtp.DeliveryStatusNotificationConditions =
                    DeliveryStatusNotificationConditions.Failure |
                    DeliveryStatusNotificationConditions.Success |
                    DeliveryStatusNotificationConditions.Delay;
                    // include full original message to DSN
                    smtp.DeliveryStatusNotificationOriginalMessageMethod = DeliveryStatusNotificationOriginalMessageMethod.FullMessage;

                    // set SSL parameters to accept all server certificates...
                    // do not do this in production code, server certificates should
                    // be verified - use ValidatingCertificate event instead
                    smtp.Settings.SslAcceptAllCertificates = pSmtp.SSL;


                    // connect to the server
                    if (!string.IsNullOrEmpty(pSmtp.CONTRASENA))
                    {
                        smtp.Connect(pSmtp.SMTP, pSmtp.PUERTO, SslMode.Explicit);

                        //Mensaje Cifrado;
                        bool binaryMime = (smtp.SupportedExtensions & SmtpExtensions.BinaryMime) == SmtpExtensions.BinaryMime;
                        // disable command pipelining
                        smtp.EnabledExtensions &= ~SmtpExtensions.Pipelining;

                        if (pSmtp.USUARIO != null && pSmtp.CONTRASENA != null)
                        {

                            smtp.Login(pSmtp.USUARIO, pSmtp.CONTRASENA);
                        }
                    }
                    else
                    {
                        smtp.Connect(pSmtp.SMTP, pSmtp.PUERTO);
                        smtp.Send(Mail);
                    }
                    //login if username and password was submitted


                    // TM_ENVIO _ENVIO = _repository_MemoryTM_ENVIORepository.GetByGUID(pMail.IdGuid);
                    // _ENVIO.MESSAGEID = Mail.MessageId.Id.ToString();
                    // _repository_MemoryTM_ENVIORepository.Update(_ENVIO);

                    // send message
           
                    await smtp.SendAsync(Mail);


                    //MailMessage mail = smtp.GetMailMessage(id);
                    DeliveryStatus dsn = DeliveryStatus.ParseMessage(Mail);
                    if (dsn != null)
                    {

                    }

                };
            }
            catch (Exception exc)
            {
                //aca va la insercion en la nueva tabla
                throw new InvalidOperationException(exc.Message);
            }
        }

       
    }


    /*********************************************************************************/
    /// <summary>
    /// Simple delivery status parser.
    /// See RFC1894.
    /// </summary>
    public class DeliveryStatus
    {
        private Dictionary<string, string> _values;

        public string FinalRecipient
        {
            get { return GetValue("final-recipient"); }
        }

        public string Disposition
        {
            get { return GetValue("disposition"); }
        }

        public string Action
        {
            get { return GetValue("actions"); }
        }

        public string Status
        {
            get { return GetValue("status"); }
        }

        public string OriginalMessageId
        {
            get { return GetValue("original-message-id"); }
        }

        public string OriginalEnvelopeId
        {
            get { return GetValue("original-envelope-id"); }
        }

        public string ReportingMailTransferAgent
        {
            get { return GetValue("reporting-mta"); }
        }

        private string GetValue(string name)
        {
            string value;
            if (!_values.TryGetValue(name, out value))
                return null;
            return value;
        }

        public static DeliveryStatus ParseMessage(MailMessage message)
        {
            if (message == null)
                throw new ArgumentNullException("message");

            foreach (Attachment att in message.Attachments)
            {
                switch (att.MediaType)
                {
                    case "message/delivery-status":
                    case "message/disposition-notification":
                        using (StreamReader reader = new StreamReader(att.GetContentStream()))
                        {
                            return new DeliveryStatus(reader.ReadToEnd());
                        }
                }
            }

            return null;
        }

        public DeliveryStatus(string message)
        {
            if (message == null)
                throw new ArgumentNullException("message");

            _values = new Dictionary<string, string>();

            message = message.Replace("\r", "");

            string[] lines = message.Split('\n');


            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int p = line.IndexOf(':');
                if (p < 0)
                    continue;

                string name = line.Substring(0, p).ToLowerInvariant();
                string value = line.Substring(p + 1).Trim();

                _values[name] = value;
            }
        }
    }

    /**********************************************************************************************************************************************/




}
