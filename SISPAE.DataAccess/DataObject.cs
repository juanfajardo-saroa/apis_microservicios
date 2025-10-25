/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano			    :2022
/// Arquitectura	:Patron MVC .NET FRamework 4.6 Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa			:DataAccess (Model Entitys Layer) - Capa DataAccess   Partial Interface 
/// </Derechos_Reservados>


using System.ComponentModel;
using System.Text;
using System;
using SISPAE.Model;
using SISPAE.Common;
#pragma warning disable 169
#pragma warning disable 414


namespace SISPAE.DataAccess
{

    /// <Resumen>
    /// Define las propiedades básicas que permiten hacer seguimiento del estado de las instancias de los objetos.
    /// <para>Todas las definiciones de clase del assembly "GeneraApp.Business" deben heredar de esta clase.</para>
    /// </Resumen>

    public class DataObject : IDisposable
    {

        #region Class Declarations

        private LoggingHandler _loggingHandler;
        private DataHandler _dataHandler;
        private ConfigurationHandler _configurationHandler;
        //private DbProviderFactory _dbProviderFactory;
        private string _connectionString;
        private string _connectionProvider;
        private int _errorCode, _rowsAffected;
        private bool _bDisposed;

        #endregion


        #region Class Methods

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool bDisposing)
        {
            // Check to see if Dispose has already been called.
            if (!_bDisposed)
            {
                if (bDisposing)
                {
                    // Dispose managed resources.
                    _configurationHandler = null;
                    _loggingHandler = null;
                    _dataHandler = null;
                    //_dbProviderFactory = null;
                }
            }
            _bDisposed = true;
        }

        #endregion Class Methods



    }


}


