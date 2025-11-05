/// <Derechos_Reservados>
/// Aplicacion      :Doc4Us 
/// Autor           :Oscar Mauricio Cortes Pinzon
/// Generacion      :Este archivo es generado automaticamente mediante generador :GeneraApp.
/// Ano             :2018
/// Arquitectura    :Patron MVC ASP Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa            :Business (Business Access Layer) - Capa del DataMapper, Esta clase implementa la interface presentada, 
///                  aca desarrolla los metodos del CRUD para cada Objeto que representa los metodos que deben ser implementados 
///                  (Source: MVC7_Business_Base.Cs)   clase 
/// </Derechos_Reservados>


using SISPAE.Common;
using SISPAE.DataAccess.DataMapper;
using SISPAE.DataAccess;
using SISPAE.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;





namespace SISPAE.Business
/// <Resumen>
/// Clase del Business  para  TP_Menu
/// 
/// </Resumen>


{



    #region Metodos de negocio


    public partial class TP_MenuMs : BusinessObject
    {

        #region Implementacion Metodos


        public override SISPAE.Model.ModelObject Add(SISPAE.Model.ModelObject entity)
        {
            try
            {
                Model.ModelObject bOpDoneSuccessfully;
                using (var repository = new TP_MenuRepository())
                {
                    bOpDoneSuccessfully = repository.Add((TP_Menu)entity);
                }

                return bOpDoneSuccessfully;
            }
            catch (Exception ex)
            {
                //Log exception error
                _loggingHandler.LogEntry(ExceptionHandler.GetExceptionMessageFormatted(ex), true);

                throw new Exception("BusinessLogic:TP_MenuBusiness::InsertTP_MenuError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }
        }



        public override SISPAE.Model.ModelObject Update(SISPAE.Model.ModelObject entity)
        {
            try
            {
                Model.ModelObject bOpDoneSuccessfully;
                using (var repository = new TP_MenuRepository())
                {
                    bOpDoneSuccessfully = repository.Update((TP_Menu)entity);
                }

                return bOpDoneSuccessfully;
            }
            catch (Exception ex)
            {
                //Log exception error
                _loggingHandler.LogEntry(ExceptionHandler.GetExceptionMessageFormatted(ex), true);

                throw new Exception("BusinessLogic:TP_MenuBusiness::UpdateTP_MenuError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }
        }

        public override bool Delete(SISPAE.Model.ModelObject entity)
        {
            try
            {
                using (var repository = new TP_MenuRepository())
                {
                    return repository.Delete((TP_Menu)entity);
                }
            }
            catch (Exception ex)
            {
                //Log exception error
                _loggingHandler.LogEntry(ExceptionHandler.GetExceptionMessageFormatted(ex), true);

                throw new Exception("BusinessLogic:TP_MenuBusiness::DeleteTP_MenuByIdError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }
        }

        public override SISPAE.Model.ModelObject GetById(SISPAE.Model.ModelObject entity)
        {
            try
            {
                TP_Menu returnedEntity;
                using (var repository = new TP_MenuRepository())
                {
                    returnedEntity = repository.GetById((TP_Menu)entity);

                }

                return returnedEntity;
            }
            catch (Exception ex)
            {
                //Log exception error
                _loggingHandler.LogEntry(ExceptionHandler.GetExceptionMessageFormatted(ex), true);

                throw new Exception("BusinessLogic:TP_MenuBusiness::SelectTP_MenuByIdError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }
        }



        public List<SISPAE.Model.ModelObject> GetAllByUser(string IdUser)
        {

            var returnedEntities = new List<SISPAE.Model.ModelObject>();
            try
            {
                using (var repository = new TP_MenuRepository())
                {
                    foreach (var entity in repository.GetAllByUser(IdUser))
                    {
                        returnedEntities.Add(entity);
                    }
                }
                return returnedEntities;
            }
            catch (Exception ex)
            {
                _loggingHandler.LogEntry(ExceptionHandler.GetExceptionMessageFormatted(ex), true);
                throw new Exception("BusinessLogic:TP_MenuBusiness::GetAllTP_MenuError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }
        }





        public override List<SISPAE.Model.ModelObject> GetAll()
        {
            var returnedEntities = new List<SISPAE.Model.ModelObject>();

            try
            {
                using (var repository = new TP_MenuRepository())
                {
                    foreach (var entity in repository.GetAll())
                    {

                        returnedEntities.Add(entity);
                    }
                }

                return returnedEntities;
            }
            catch (Exception ex)
            {
                //Log exception error
                _loggingHandler.LogEntry(ExceptionHandler.GetExceptionMessageFormatted(ex), true);

                throw new Exception("BusinessLogic:TP_MenuBusiness::GetAllTP_MenuError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }
        }

        public override List<SISPAE.Model.ModelObject> GetByFilter(SISPAE.Model.ModelObject entityObj, int PageSize, int Page, String Orderby)
        {
            var returnedEntities = new List<SISPAE.Model.ModelObject>();
            try
            {
                using (var repository = new TP_MenuRepository())
                {
                    foreach (var entity in repository.GetByFilter((TP_Menu)entityObj, PageSize, Page, Orderby))
                    {
                        returnedEntities.Add(entity);
                    }
                }
                return returnedEntities;
            }
            catch (Exception ex)
            {
                //Log exception error
                _loggingHandler.LogEntry(ExceptionHandler.GetExceptionMessageFormatted(ex), true);
                throw new Exception("BusinessLogic:TP_MenuBusiness::GetAllTP_MenuError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }
        }





        protected override List<SISPAE.Model.ModelObject> execProcedureQuery(List<SqlParameter> sqlparametersvaluesList, string Procedimiento)
        {
            try
            {


                return new List<SISPAE.Model.ModelObject>();

            }
            catch (Exception ex)
            {
                throw new Exception("DataBusiness:(ExecProcedure) TP_Menu  ->" + ex.Message + ex);
            }
        }

        protected override object execProcedureNonQuery(List<SqlParameter> sqlparametersvaluesList, string Procedimiento)
        {
            try
            {
                return (object)new TP_Menu();

            }
            catch (Exception ex)
            {
                throw new Exception("DataBusiness:(ExecProcedure) TP_Menu  ->" + ex.Message + ex);
            }
        }

        public override List<ModelObject> GetAllFull()
        {
            throw new NotImplementedException();
        }

        public override List<ModelObject> GetAllByWithRelation()
        {
            throw new NotImplementedException();
        }

        #endregion Implementacion Metodos


    }
    #endregion Metodos de Negocio

}
