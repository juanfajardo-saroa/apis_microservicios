/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador :GeneraApp.
/// Ano				:2022
/// Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa			:Business (Business Access Layer) - Capa del DataMapper, Esta clase implementa la interface presentada, 
///                  aca desarrolla los metodos del CRUD para cada Objeto que representa los metodos que deben ser implementados 
///                  (Source: MVC7_Business_Base.Cs)   clase 
/// </Derechos_Reservados>


using System;
using System.Collections.Generic;
using SISPAE.Model;
using SISPAE.DataAccess;
using SISPAE.DataAccess.DataMapper;
using System.Data.SqlClient;
using SISPAE.Common;





namespace SISPAE.Business
     /// <Resumen>
     /// Clase del Business  para  ConfiguracionVistas
     /// 
     /// </Resumen>
	 
	 
{	 

	

	#region Metodos de negocio

    
	public partial class ConfiguracionVistasMs : BusinessObject
	{
        
		#region Implementacion Metodos


		public override  SISPAE.Model.ModelObject Add(SISPAE.Model.ModelObject entity)
        {
            try
            {
                Model.ModelObject bOpDoneSuccessfully;
                using (var repository = new ConfiguracionVistasRepository())
                {
                    bOpDoneSuccessfully = repository.Add((ConfiguracionVistas) entity);
                }

                return bOpDoneSuccessfully;
            }
            catch (Exception ex)
            {
                //Log exception error
                _loggingHandler.LogEntry(ExceptionHandler.GetExceptionMessageFormatted(ex), true);

                throw new Exception("BusinessLogic:ConfiguracionVistasBusiness::InsertConfiguracionVistasError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }
        }

	  		
		
        public override SISPAE.Model.ModelObject Update(SISPAE.Model.ModelObject entity)
        {
            try
            {
                Model.ModelObject bOpDoneSuccessfully;
                using (var repository = new ConfiguracionVistasRepository())
                {
                    bOpDoneSuccessfully = repository.Update((ConfiguracionVistas) entity);
                }

                return bOpDoneSuccessfully;
            }
            catch (Exception ex)
            {
                //Log exception error
                _loggingHandler.LogEntry(ExceptionHandler.GetExceptionMessageFormatted(ex), true);

                throw new Exception("BusinessLogic:ConfiguracionVistasBusiness::UpdateConfiguracionVistasError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }
        }

        public override bool Delete(SISPAE.Model.ModelObject entity)
        {
			try
            {
                using (var repository = new ConfiguracionVistasRepository())
                {
                    return repository.Delete((ConfiguracionVistas) entity);
                }
            }
            catch (Exception ex)
            {
                //Log exception error
                _loggingHandler.LogEntry(ExceptionHandler.GetExceptionMessageFormatted(ex), true);

                throw new Exception("BusinessLogic:ConfiguracionVistasBusiness::DeleteConfiguracionVistasByIdError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }
        }

        public override SISPAE.Model.ModelObject GetById(SISPAE.Model.ModelObject entity)
        {
			try
            {
                ConfiguracionVistas returnedEntity;
                using (var repository = new ConfiguracionVistasRepository())
                {
                    returnedEntity = repository.GetById((ConfiguracionVistas) entity);
                    
                }

                return returnedEntity;
            }
            catch (Exception ex)
            {
                //Log exception error
                _loggingHandler.LogEntry(ExceptionHandler.GetExceptionMessageFormatted(ex), true);

                throw new Exception("BusinessLogic:ConfiguracionVistasBusiness::SelectConfiguracionVistasByIdError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }
        }


		
 




        public override List<SISPAE.Model.ModelObject> GetAll()
        {
            var returnedEntities = new List<SISPAE.Model.ModelObject>();

            try
            {
                using (var repository = new ConfiguracionVistasRepository())
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

                throw new Exception("BusinessLogic:ConfiguracionVistasBusiness::GetAllConfiguracionVistasError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }
        }

        public override List<SISPAE.Model.ModelObject> GetAllFull()
        {
            var returnedEntities = new List<SISPAE.Model.ModelObject>();

            try
            {
                using (var repository = new ConfiguracionVistasRepository())
                {
                    foreach (var entity in repository.GetAllFull())
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

                throw new Exception("BusinessLogic:ConfiguracionVistasBusiness::GetAllFullConfiguracionVistasError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }
        }

        
        public override List<SISPAE.Model.ModelObject> GetAllByWithRelation()
        {
            var returnedEntities = new List<SISPAE.Model.ModelObject>();

            try
            {
                using (var repository = new ConfiguracionVistasRepository())
                {
                    foreach (var entity in repository.GetAllByWithRelation())
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

                throw new Exception("BusinessLogic:ConfiguracionVistasBusiness::GetAllByWithRelationConfiguracionVistasError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }
        }
        

		public override List<SISPAE.Model.ModelObject> GetByFilter(SISPAE.Model.ModelObject entityObj, int PageSize, int Page, String Orderby)
        {
            var returnedEntities = new List<SISPAE.Model.ModelObject>();
            try
            {
                using (var repository = new ConfiguracionVistasRepository())
                {
                    foreach (var entity in repository.GetByFilter((ConfiguracionVistas)entityObj, PageSize, Page, Orderby))
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
                throw new Exception("BusinessLogic:ConfiguracionVistasBusiness::GetAllConfiguracionVistasError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }
        }
		

      
		
		
		protected override List<SISPAE.Model.ModelObject> execProcedureQuery(List<SqlParameter>  sqlparametersvaluesList,  string Procedimiento)
		{
			try 
			{
			
		 
		           return new List<SISPAE.Model.ModelObject>();

			}
            catch (Exception ex)
            {
                throw new Exception("DataBusiness:(ExecProcedure) ConfiguracionVistas  ->" + ex.Message + ex);
            }
		}
		
		protected override object execProcedureNonQuery(List<SqlParameter>  sqlparametersvaluesList,  string Procedimiento)
		{
			try 
			{
				  return (object)new  ConfiguracionVistas();
		         
			}
            catch (Exception ex)
            {
                throw new Exception("DataBusiness:(ExecProcedure) ConfiguracionVistas  ->" + ex.Message + ex);
            }
		}
		
		#endregion Implementacion Metodos


    }
	#endregion Metodos de Negocio

}