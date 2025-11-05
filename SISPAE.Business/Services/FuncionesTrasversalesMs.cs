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
using SISPAE.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SISPAE.Business
    {
    public class FuncionesTrasversalesMs : BusinessObject
        {
        public override ModelObject Add(ModelObject entity)
            {
            throw new NotImplementedException();
            }

        public override bool Delete(ModelObject entity)
            {
            throw new NotImplementedException();
            }

        public override List<ModelObject> GetAll()
            {
            throw new NotImplementedException();
            }

        public override List<ModelObject> GetAllFull()
            {
            throw new NotImplementedException();
            }

        public override List<ModelObject> GetAllByWithRelation()
            {
            throw new NotImplementedException();
            }
        public List<SISPAE.Model.ModelObject> GetAllByMenu(string menu)
            {
            var returnedEntities = new List<SISPAE.Model.ModelObject>();

            try
                {
                using(var repository = new FuncionesTrasversalesRepository())
                    {
                    foreach(var entity in repository.GetAllByMenu(menu))
                        {
                        returnedEntities.Add(entity);
                        }
                    }

                return returnedEntities;
                }
            catch(Exception ex)
                {
                //Log exception error
                _loggingHandler.LogEntry(ExceptionHandler.GetExceptionMessageFormatted(ex), true);

                throw new Exception("BusinessLogic:AspNetRolesBusiness::GetAllAspNetRolesError occured.::Error occured. "+ ex.Message.ToString(), ex);
                }
            }



        public override List<ModelObject> GetByFilter(ModelObject entityObj, int PageSize, int Page, string Orderby)
            {
            throw new NotImplementedException();
            }

        public override ModelObject GetById(ModelObject entity)
            {
            throw new NotImplementedException();
            }

        public override ModelObject Update(ModelObject entity)
            {
            throw new NotImplementedException();
            }

        protected override object execProcedureNonQuery(List<SqlParameter> sqlparametersvaluesList, string Procedimiento)
            {
            throw new NotImplementedException();
            }

        protected override List<ModelObject> execProcedureQuery(List<SqlParameter> sqlparametersvaluesList, string Procedimiento)
            {
            throw new NotImplementedException();
            }
        }
    }
