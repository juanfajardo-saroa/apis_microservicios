/// <Derechos_Reservados>
/// Aplicacion		:Doc4Us 
/// Autor			:TiGlobal SAS 
/// Generacion		:Este archivo es generado automaticamente mediante generador :GeneraApp.
/// Ano				:2021
/// Arquitectura	:Patron MVC ASP Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa			:Business (Business Access Layer) - Capa del DataMapper, Esta clase implementa la interface presentada, 
///                  aca desarrolla los metodos del CRUD para cada Objeto que representa los metodos que deben ser implementados 
///                  (Source: MVC7_Business_Partial.Cs)   clase 
/// </Derechos_Reservados>


using SISPAE.Common;
using SISPAE.DataAccess.DataMapper;
using SISPAE.Model;
using System;




namespace SISPAE.Business
/// <Resumen>
/// Clase del Business  para  AspNetUsers
/// 
/// </Resumen>


{

    public partial class AspNetUsersMs
    {
        #region Metodos de negocio
        public void LogSingIn(TA_INGRESO l)
        {

            try
            {
                using (var repository = new AspNetUsersRepository())
                {
                    repository.AddLog(l);
                }

            }
            catch (Exception ex)
            {
                //Log exception error
                _loggingHandler.LogEntry(ExceptionHandler.GetExceptionMessageFormatted(ex), true);
                throw new Exception("BusinessLogic:AspNetUsersBusiness::InsertAspNetUsersError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }

        }


        #endregion Metodos de negocio
    }
}



