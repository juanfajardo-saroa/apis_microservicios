/// <Derechos_Reservados>
/// Aplicacion      :SISPAE 
/// Autor           :TiGlobal SAS y SoftManagement
/// Generacion      :Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano             :2022
/// Arquitectura    :Patron MVC .NET FRamework 4.6 Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa            :Business (Business Layer) - Capa Business (BusinessObjects.cs)  Partial Interface 
/// </Derechos_Reservados>


using SISPAE.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SISPAE.Business
{

    /// <Resumen>
    /// Define las propiedades básicas que permiten hacer seguimiento del estado de las instancias de los objetos.
    /// <para>Todas las definiciones de clase del assembly ":nameSpaceSmall.Business" deben heredar de esta clase.</para>
    /// </Resumen>

    public abstract class BusinessObject : IDisposable
    {

        #region Class Declarations

        protected LoggingHandler _loggingHandler;
        protected bool _bDisposed;

        #endregion

        #region Metodos Virtuales

        public abstract SISPAE.Model.ModelObject Add(SISPAE.Model.ModelObject entity);

        public abstract SISPAE.Model.ModelObject GetById(SISPAE.Model.ModelObject entity);

        public abstract List<SISPAE.Model.ModelObject> GetAll();

        public abstract List<SISPAE.Model.ModelObject> GetAllFull();

         public abstract List<SISPAE.Model.ModelObject>      GetAllByWithRelation();

        public abstract SISPAE.Model.ModelObject Update(SISPAE.Model.ModelObject entity);

        public abstract bool Delete(SISPAE.Model.ModelObject entity);

        protected abstract List<SISPAE.Model.ModelObject> execProcedureQuery(List<SqlParameter> sqlparametersvaluesList, string Procedimiento);

        protected abstract Object execProcedureNonQuery(List<SqlParameter> sqlparametersvaluesList, string Procedimiento);

        public abstract List<SISPAE.Model.ModelObject> GetByFilter(SISPAE.Model.ModelObject entityObj, int PageSize, int Page, String Orderby);

        #endregion Metodos Virtuales






        public BusinessObject()
        {
            _loggingHandler = new LoggingHandler();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool bDisposing)
        {
            // Check to see if Dispose has already been called.
            if (!_bDisposed)
            {
                if (bDisposing)
                {
                    // Dispose managed resources.
                    _loggingHandler = null;
                }
            }
            _bDisposed = true;
        }






    }

}
