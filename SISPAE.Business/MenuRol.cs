///// <Derechos_Reservados>
///// Aplicacion      :SISPAE 
///// Autor           :TiGlobal SAS y SoftManagement
///// Generacion      :Este archivo es generado automaticamente mediante generador GeneraApp.
///// Ano             :2022
///// Arquitectura    :Patron MVC .NET FRamework 4.6 Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
///// Capa            :Business (Business Layer) - Capa Business (BusinessObjects.cs)  Partial Interface 
///// </Derechos_Reservados>


//using SISPAE.Common;
//using SISPAE.DataAccess;
//using SISPAE.Model;
//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;

//namespace SISPAE.Business
//{

//    /// <Resumen>
//    /// Define las propiedades basicas que permiten hacer seguimiento del estado de las instancias de los objetos.
//    /// <para>Todas las definiciones de clase del assembly ":nameSpaceSmall.Business" deben heredar de esta clase.</para>
//    /// </Resumen>

//    public class MenuRol : BusinessObject
//    {
//        public override ModelObject Add(ModelObject entity)
//        {
//            throw new NotImplementedException();
//        }

//        public override bool Delete(ModelObject entity)
//        {
//            throw new NotImplementedException();
//        }

//        public override List<ModelObject> GetAll()
//        {
//            throw new NotImplementedException();
//        }
//        public override List<ModelObject> GetAllFull()
//            {
//            throw new NotImplementedException();
//            }
//        public List<SISPAE.Model.ModelObject> GetAllByMenu(string menu)
//        {
//            var returnedEntities = new List<SISPAE.Model.ModelObject>();

//            try
//            {
//                using (MenuRolData repository = new MenuRolData())
//                {
//                    foreach (var entity in repository.GetAllByMenu(menu))
//                    {
//                        returnedEntities.Add(entity);
//                    }
//                }

//                return returnedEntities;
//            }
//            catch (Exception ex)
//            {
//                //Log exception error
//                _loggingHandler.LogEntry(ExceptionHandler.GetExceptionMessageFormatted(ex), true);

//                throw new Exception("BusinessLogic:MenuRolBusiness::GetAllMenu::Error occured.", ex);
//            }
//        }

//        public override List<ModelObject> GetByFilter(ModelObject entityObj, int PageSize, int Page, string Orderby)
//        {
//            throw new NotImplementedException();
//        }

//        public override ModelObject GetById(ModelObject entity)
//        {
//            throw new NotImplementedException();
//        }

//        public override ModelObject Update(ModelObject entity)
//        {
//            throw new NotImplementedException();
//        }

//        protected override object execProcedureNonQuery(List<SqlParameter> sqlparametersvaluesList, string Procedimiento)
//        {
//            throw new NotImplementedException();
//        }

//        protected override List<ModelObject> execProcedureQuery(List<SqlParameter> sqlparametersvaluesList, string Procedimiento)
//        {
//            throw new NotImplementedException();
//        }


//         public override List<ModelObject> GetAllByWithRelation()
//            {
//            throw new NotImplementedException();
//            }
//    }

//}
