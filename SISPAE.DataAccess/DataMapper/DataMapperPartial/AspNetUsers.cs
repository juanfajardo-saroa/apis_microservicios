/// <Derechos_Reservados>
/// Aplicacion		:Doc4Us 
/// Autor			:TiGlobal SAS 
/// Generacion		:Este archivo es generado automaticamente mediante generador :GeneraApp.
/// Ano				:2021
/// Arquitectura	:Patron MVC ASP Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa			:DataAccess (Data Access Layer) - Capa del DataMapper, Esta clase implementa la interface presentada,
///     			 aca desarrolla los metodos del CRUD para cada Objeto que representa los metodos que deben ser implementados 
///					(Source: MVC7_DAL_DataMapperPartial.Cs)   clase 
/// </Derechos_Reservados>



using SISPAE.DataAccess.DataProviderHelper;
using SISPAE.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;





namespace SISPAE.DataAccess.DataMapper
{
    /// <Resumen>
    /// Clase Parcial del Data Mapper para  AspNetUsers
    /// haga cambios sobre esta clase,
    /// 
    /// </Resumen>


    public partial class AspNetUsersRepository
    {


        public TA_INGRESO GetByIdLog(Int32 pID)
        {

            TA_INGRESO _Obj = new TA_INGRESO();
            DataTable dtt = new DataTable();
            SqlParameter[] sqlparams =
                    {
        new SqlParameter("@ID",SqlDbType.Int)

                };
            sqlparams[0].Value = pID;


            dtt.Load(SqlHelper.ExecuteReader(_dataSource.cadena, CommandType.StoredProcedure, "gsp_TA_INGRESOGetByID", sqlparams), LoadOption.OverwriteChanges);

            for (int i = 0; i < dtt.Rows.Count; i++)
            {
                _Obj.ID = (Int32)dtt.Rows[0]["ID"];
                _Obj.CODIGOEMPRESA = dtt.Rows[0]["CODIGOEMPRESA"].ToString();
                _Obj.USUARIO = dtt.Rows[0]["USUARIO"].ToString();
                _Obj.FECHA = (DateTime)dtt.Rows[0]["FECHA"];
                _Obj.DireccionIP = dtt.Rows[0]["DireccionIP"] == DBNull.Value ? "" : (String)dtt.Rows[0]["DireccionIP"];
                _Obj.HostNameUsuario = dtt.Rows[0]["HostNameUsuario"] == DBNull.Value ? "" : (String)dtt.Rows[0]["HostNameUsuario"];
                _Obj.IPDetrasProxy = dtt.Rows[0]["IPDetrasProxy"] == DBNull.Value ? "" : (String)dtt.Rows[0]["IPDetrasProxy"];
                _Obj.Browser = dtt.Rows[0]["Browser"] == DBNull.Value ? "" : (String)dtt.Rows[0]["Browser"];
                _Obj.Accion = dtt.Rows[0]["Accion"] == DBNull.Value ? "" : (String)dtt.Rows[0]["Accion"];

            }
            return _Obj;
        }

        public List<TA_INGRESO> GetAllLog()
        {
            DataTable dtt = new DataTable();
            List<TA_INGRESO> _lista = new List<TA_INGRESO>();

            dtt.Load(SqlHelper.ExecuteReader(_dataSource.cadena, CommandType.StoredProcedure, "gsp_TA_INGRESOGetAll"), LoadOption.OverwriteChanges);

            for (int i = 0; i < dtt.Rows.Count; i++)
            {
                _lista.Add(new TA_INGRESO
                {
                    ID = (Int32)dtt.Rows[i]["ID"],
                    CODIGOEMPRESA = (String)dtt.Rows[i]["CODIGOEMPRESA"],
                    USUARIO = dtt.Rows[i]["USUARIO"].ToString(),
                    FECHA = (DateTime)dtt.Rows[i]["FECHA"],
                    DireccionIP = dtt.Rows[0]["DireccionIP"] == DBNull.Value ? "" : (String)dtt.Rows[0]["DireccionIP"],
                    HostNameUsuario = dtt.Rows[0]["HostNameUsuario"] == DBNull.Value ? "" : (String)dtt.Rows[0]["HostNameUsuario"],
                    IPDetrasProxy = dtt.Rows[0]["IPDetrasProxy"] == DBNull.Value ? "" : (String)dtt.Rows[0]["IPDetrasProxy"],
                    Browser = dtt.Rows[0]["Browser"] == DBNull.Value ? "" : (String)dtt.Rows[0]["Browser"],
                    Accion = dtt.Rows[0]["Accion"] == DBNull.Value ? "" : (String)dtt.Rows[0]["Accion"]

                });
            }

            return _lista;
        }

        public TA_INGRESO AddLog(TA_INGRESO pTA_INGRESO)
        {
            TA_INGRESO _Obj = new TA_INGRESO();
            DataTable dtt = new DataTable();

            SqlParameter[] sqlparams = {
            new SqlParameter("@ID",SqlDbType.Int),
            new SqlParameter("@CODIGOEMPRESA",SqlDbType.VarChar),
            new SqlParameter("@USUARIO",SqlDbType.VarChar),
            new SqlParameter("@FECHA",SqlDbType.SmallDateTime),
            new SqlParameter("@DireccionIP",SqlDbType.VarChar),
            new SqlParameter("@HostNameUsuario",SqlDbType.VarChar),
            new SqlParameter("@IPDetrasProxy",SqlDbType.VarChar),
            new SqlParameter("@Browser",SqlDbType.VarChar),
            new SqlParameter("@Accion",SqlDbType.VarChar)

                         };
            sqlparams[0].Value = pTA_INGRESO.ID;
            sqlparams[1].Value = pTA_INGRESO.CODIGOEMPRESA;
            sqlparams[2].Value = pTA_INGRESO.USUARIO;
            sqlparams[3].Value = pTA_INGRESO.FECHA;
            sqlparams[4].Value = pTA_INGRESO.DireccionIP;
            sqlparams[5].Value = pTA_INGRESO.HostNameUsuario;
            sqlparams[6].Value = pTA_INGRESO.IPDetrasProxy;
            sqlparams[7].Value = pTA_INGRESO.Browser;
            sqlparams[8].Value = pTA_INGRESO.Accion;



            dtt.Load(SqlHelper.ExecuteReader(_dataSource.cadena, CommandType.StoredProcedure, "gsp_TA_INGRESOInsert", sqlparams), LoadOption.OverwriteChanges);

            for (int i = 0; i < dtt.Rows.Count; i++)
            {
                _Obj.ID = (Int32)dtt.Rows[0]["ID"];
                _Obj.CODIGOEMPRESA = dtt.Rows[0]["CODIGOEMPRESA"].ToString();
                _Obj.USUARIO = dtt.Rows[0]["USUARIO"].ToString();
                _Obj.FECHA = (DateTime)dtt.Rows[0]["FECHA"];
                _Obj.DireccionIP = (String)dtt.Rows[0]["DireccionIP"];
                _Obj.HostNameUsuario = (String)dtt.Rows[0]["HostNameUsuario"];
                _Obj.IPDetrasProxy = (String)dtt.Rows[0]["IPDetrasProxy"];
                _Obj.Browser = (String)dtt.Rows[0]["Browser"];
                _Obj.Accion = (String)dtt.Rows[0]["Accion"];

            }
            return _Obj;
        }

        public bool UpdateLog(TA_INGRESO pTA_INGRESO)
        {
            try
            {
                SqlParameter[] sqlparams = {
            new SqlParameter("@ID",SqlDbType.Int),
            new SqlParameter("@CODIGOEMPRESA",SqlDbType.VarChar),
            new SqlParameter("@USUARIO",SqlDbType.Int),
            new SqlParameter("@FECHA",SqlDbType.SmallDateTime),
            new SqlParameter("@DireccionIP",SqlDbType.VarChar),
            new SqlParameter("@HostNameUsuario",SqlDbType.VarChar),
            new SqlParameter("@IPDetrasProxy",SqlDbType.VarChar),
            new SqlParameter("@Browser",SqlDbType.VarChar),
            new SqlParameter("@Accion",SqlDbType.VarChar)
                         };
                sqlparams[0].Value = pTA_INGRESO.ID;
                sqlparams[1].Value = pTA_INGRESO.CODIGOEMPRESA;
                sqlparams[2].Value = pTA_INGRESO.USUARIO;
                sqlparams[3].Value = pTA_INGRESO.FECHA;
                sqlparams[4].Value = pTA_INGRESO.DireccionIP;
                sqlparams[5].Value = pTA_INGRESO.HostNameUsuario;
                sqlparams[6].Value = pTA_INGRESO.IPDetrasProxy;
                sqlparams[7].Value = pTA_INGRESO.Browser;
                sqlparams[8].Value = pTA_INGRESO.Accion;



                SqlHelper.ExecuteNonQuery(_dataSource.cadena, CommandType.StoredProcedure, "gsp_TA_INGRESOUpdate", sqlparams);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteLog(Int32 pID)
        {
            try
            {
                SqlParameter[] sqlparams =
                {
                    new SqlParameter("@ID",SqlDbType.Int)

                };

                sqlparams[0].Value = pID;


                SqlHelper.ExecuteNonQuery(_dataSource.cadena, CommandType.StoredProcedure, "gsp_TA_INGRESODelete", sqlparams);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<TA_INGRESO> IngresoGetUsuario(int pID_TB_EMPRESA)
        {
            DataTable dtt = new DataTable();
            List<TA_INGRESO> _lista = new List<TA_INGRESO>();
            SqlParameter[] sqlparams =
            {
                new SqlParameter("@ID_TB_EMPRESA",SqlDbType.Int),
            };
            sqlparams[0].Value = pID_TB_EMPRESA;
            dtt.Load(SqlHelper.ExecuteReader(_dataSource.cadena, CommandType.StoredProcedure, "gsp_TA_INGRESOGetUsuario", sqlparams), LoadOption.OverwriteChanges);

            for (int i = 0; i < dtt.Rows.Count; i++)
            {

                _lista.Add(new TA_INGRESO
                {
                    MES = dtt.Rows[i]["MES"] == DBNull.Value ? string.Empty : (String)dtt.Rows[i]["MES"],
                    FECHA = (DateTime)dtt.Rows[i]["DIA"],
                    USUARIO = dtt.Rows[i]["USUARIO"].ToString(),
                });
            }

            return _lista;
        }




    }
}