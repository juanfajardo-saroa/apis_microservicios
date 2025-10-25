using SISPAE.Common;
using SISPAE.DataAccess.DataMapper;
using SISPAE.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace SISPAE.Business
{
    public class TH_TransaccionComunesMs : BusinessObject
    {


        public void  AddCustom(TH_TransaccionComunes entity)
        {
            try
            {
                new TH_TransaccionComunesRepository().Add(entity);

            }
            catch (Exception ex)
            {
                //Log exception error
                _loggingHandler.LogEntry(ExceptionHandler.GetExceptionMessageFormatted(ex), true);

                throw new Exception("BusinessLogic:TH_TransaccionComunes::AddCustomError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }
        }

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

        public override List<ModelObject> GetAllByWithRelation()
        {
            throw new NotImplementedException();
        }
    }
}
