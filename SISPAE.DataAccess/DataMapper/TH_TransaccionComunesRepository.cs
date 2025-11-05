using SISPAE.DataAccess.DataProviderHelper;
using SISPAE.Model;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace SISPAE.DataAccess.DataMapper
{
    public class TH_TransaccionComunesRepository
    {

        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlDatabase ITDataDatabase;

        public TH_TransaccionComunesRepository()
        {
            _dataSource = new DataMapperSource();
            ITDataDatabase = new SqlDatabase(_dataSource.cadena);
        }

        public TH_TransaccionComunesRepository(DataAccess.DataMapper.DataMapperSource dataSource)
        {
            _dataSource = dataSource;
        }

        #endregion Class Declarations

        public void Add(TH_TransaccionComunes t)
        {
            try
            {
                TH_TransaccionComunes _Obj = new TH_TransaccionComunes();
                DataTable dtt = new DataTable();


                SqlParameter[] sqlparams = {
                        //new SqlParameter("@id",SqlDbType.Int),
                        new SqlParameter("@Fecha",SqlDbType.DateTime),
                        new SqlParameter("@TipoOPeracion",SqlDbType.NVarChar),
                        new SqlParameter("@status",SqlDbType.Int),
                        new SqlParameter("@Transaccion",SqlDbType.VarChar),
                        new SqlParameter("@idExterno",SqlDbType.Int)

                         };
                //sqlparams[0].Value = t.id;
                sqlparams[0].Value = t.fecha;
                sqlparams[1].Value = t.TipoOperacion;
                sqlparams[2].Value = t.status;
                sqlparams[3].Value = t.Transaccion;
                sqlparams[4].Value = t.idExterno;



                 dtt.Load(SqlHelper.ExecuteReader(_dataSource.cadena, CommandType.StoredProcedure, "casos.PA_TH_TransaccionComunesAdd", sqlparams), LoadOption.OverwriteChanges);


            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(Add)  TH_TransaccionComunes  ->" + ex.Message);
            }
        }
    }
}
