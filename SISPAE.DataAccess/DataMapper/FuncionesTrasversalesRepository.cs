

using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using SISPAE.DataAccess.DataProviderHelper;
using SISPAE.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SISPAE.DataAccess.DataMapper
    {
    public class FuncionesTrasversalesRepository : DataObject
        {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlDatabase ITDataDatabase;

        public FuncionesTrasversalesRepository()
            {
            _dataSource = new DataMapperSource();
            ITDataDatabase = new SqlDatabase(_dataSource.cadena);
            }

        public FuncionesTrasversalesRepository(DataAccess.DataMapper.DataMapperSource dataSource)
            {
            _dataSource = dataSource;
            }

        #endregion Class Declarations
        #region Class Methods

        public List<AspNetRoles> GetAllByMenu(string menu)
            {
            try
                {

                SqlParameter[] sqlparams =
                    {
                        new SqlParameter("@Menu",SqlDbType.NVarChar)
                    };

                sqlparams[0].Value = menu;

                DataTable dtt = new DataTable();
                List<AspNetRoles> _lista = new List<AspNetRoles>();

                dtt.Load(SqlHelper.ExecuteReader(_dataSource.cadena, CommandType.StoredProcedure, "API.PA_AspNetRolesAllByMenu", sqlparams), LoadOption.OverwriteChanges);

                for(int i = 0; i < dtt.Rows.Count; i++)
                    {
                    _lista.Add(new AspNetRoles
                        {
                        Id = dtt.Rows[i]["Id"] == DBNull.Value ? "" : dtt.Rows[i]["Id"].ToString(),
                        Name = dtt.Rows[i]["Name"] == DBNull.Value ? "" : dtt.Rows[i]["Name"].ToString(),
                        NormalizedName = dtt.Rows[i]["NormalizedName"] == DBNull.Value ? "" : dtt.Rows[i]["NormalizedName"].ToString(),
                        ConcurrencyStamp = dtt.Rows[i]["ConcurrencyStamp"] == DBNull.Value ? "" : dtt.Rows[i]["ConcurrencyStamp"].ToString()

                        });
                    }

                return _lista;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetAll)  AspNetRoles  ->" + ex.Message);
                }
            }
        #endregion


        }
    }
