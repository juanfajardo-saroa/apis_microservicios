using System;
using System.Collections.Generic;
using SISPAE.Model;
using SISPAE.DataAccess;
using SISPAE.DataAccess.DataMapper;
using System.Data.SqlClient;
using SISPAE.Common;

namespace SISPAE.Business.Services
{
    public  class PA_PriorizaUpdateEstadoPrioMs
    {

        public int GetPA_PriorizaUpdateEstadoPrio(int id_Sede, int id_Vigencia, int ID_TipoEstadoPriorizacion, string auditoria)
        {
           
            try
            {
                return new PA_PriorizaUpdateEstadoPrioRepository().PA_PriorizaUpdateEstadoPrio(id_Sede, id_Vigencia, ID_TipoEstadoPriorizacion, auditoria);

            }
            catch (Exception ex)
            {
                throw new Exception("BusinessLogic:PA_PriorizaUpdateEstadoPrio::PA_PriorizaUpdateEstadoPrioError occured.::Error occured. "+ ex.Message.ToString(), ex);
            }
        }

    }
}
