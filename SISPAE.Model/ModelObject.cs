/// <Derechos_Reservados>
/// Aplicacion      :SISPAE 
/// Autor           :TiGlobal SAS y SoftManagement
/// Generacion      :Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano             :2022
/// Arquitectura    :Patron MVC .NET FRamework 4.6 Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa            :MODEL (Model Entitys Layer) - Capa Model (Source: MVC7_DAL_ModelBase.CS)  Partial Interface 
/// </Derechos_Reservados>


using Microsoft.Practices.EnterpriseLibrary.Validation;
using System;
using System.ComponentModel;
using System.Text;

namespace SISPAE.Model
    {

    /// <Resumen>
    /// Define las propiedades básicas que permiten hacer seguimiento del estado de las instancias de los objetos.
    /// <para>Todas las definiciones de clase del assembly "Business" deben heredar de esta clase.</para>
    /// </Resumen>

    public class ModelObject : IDisposable
        {

        #region Interfaces

        /// <summary>
        /// Proposito: Implementa la interfaz IDispose interface PARA EL GARBAGECOLLECTOR.
        /// </summary>
        public void Dispose() => GC.SuppressFinalize(this);

        #endregion


        #region Metodos

        protected System.DateTime createdOn = DateTime.MinValue;
        //private System.Boolean isNew = false;
        //private System.Boolean isPersisted = false;
        //private System.Boolean forDelete = false;
        private System.String validationErrors = System.String.Empty;

        protected System.String ippublica = System.String.Empty;
        protected System.String nombremaquina = System.String.Empty;
        protected System.String usuario = System.String.Empty;
        protected System.String ipdetrasproxy = System.String.Empty;
        protected System.String browser = System.String.Empty;
        protected System.String accion = System.String.Empty;
        protected System.String sessionid = System.String.Empty;


        public String _ippublica { set { ippublica = value; } }
        public String _nombremaquina { set { nombremaquina = value; } }
        public String _usuario { set { usuario = value; } }
        public String _ipdetrasproxy { set { ipdetrasproxy = value; } }
        public String _browser { set { browser = value; } }
        public String _accion { set { accion = value; } }
        public String _sessionid { set { sessionid = value; } }




        public String _XMLAuditoria { get { return XMLConformado(); } }

        [Browsable(false)]
        public System.Boolean IsValid
            {
            get
                {
                if(this.Validate().IsValid == true)
                    {
                    return true;
                    }
                else
                    {
                    return false;
                    }
                }
            }

        private String XMLConformado()
            {
            String cadXML = "";
            //cadXML += "<?xml version=\"1.0\" encoding=\"UTF-16\" ?><Auditoria><IPMAquina>" + ippublica + "</IPMAquina><NombreMaquina>" + nombremaquina + "</NombreMaquina><Usuario>" + usuario + "</Usuario>";
            //cadXML += "<IPDetrasProxy>" + ipdetrasproxy + "</IPDetrasProxy>";
            //cadXML += "<Browser>" + browser + "</Browser>";
            //cadXML += "<Accion>" + accion + "</Accion>";
            //cadXML += "<SessionID>" + sessionid + "</SessionID>";
            //cadXML += "<Fecha>" + DateTime.Now.ToString() + "</Fecha>";
            //cadXML += "</Auditoria>";
            return cadXML;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ValidationResults Validate()
            {
            StringBuilder stringError = new StringBuilder();

            // Validator validator = ValidationFactory.CreateValidator(this.GetType());
            ValidationResults results = new ValidationResults();
            //validator.Validate(this, results);
            if(!results.IsValid)
                {
                stringError.AppendLine("ER:");
                foreach(Microsoft.Practices.EnterpriseLibrary.Validation.ValidationResult result in results)
                    {
                    stringError.AppendLine("Prop '" + result.Key + "' instancia: '" + result.Target.GetType().Name + "' " + result.Message);
                    }
                validationErrors = stringError.ToString();
                }
            else
                {

                stringError.AppendLine("SE: " + this.GetType().ToString());
                validationErrors = stringError.ToString();
                }
            return results;
            }


        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        public System.String ValidationErrors
            {
            get { return validationErrors; }
            }

        #endregion Metodos

        }

    }