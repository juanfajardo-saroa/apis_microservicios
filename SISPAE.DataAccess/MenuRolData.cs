/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano			    :2022
/// Arquitectura	:Patron MVC .NET FRamework 4.6 Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa			:DataAccess (Model Entitys Layer) - Capa DataAccess   Partial Interface 
/// </Derechos_Reservados>


using SISPAE.DataAccess.DataMapper;
using SISPAE.DataAccess.DataProviderHelper;
using SISPAE.Model;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;




namespace SISPAE.DataAccess
{

    /// <Resumen>
    /// Define las propiedades basicas que permiten hacer seguimiento del estado de las instancias de los objetos.
    /// <para>Todas las definiciones de clase del assembly "GeneraApp.Business" deben heredar de esta clase.</para>
    /// </Resumen>

    public class MenuRolData : DataObject
    {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlDatabase ITDataDatabase;

        public MenuRolData()
        {
            _dataSource = new DataMapperSource();
            ITDataDatabase = new SqlDatabase(_dataSource.cadena);
        }

        public MenuRolData(DataAccess.DataMapper.DataMapperSource dataSource)
        {
            _dataSource = dataSource;
        }

        #endregion Class Declarations


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

                for (int i = 0; i < dtt.Rows.Count; i++)
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
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetAllMenu)  MenuRolData  ->" + ex.Message + ex);
            }
        }



    }


}
