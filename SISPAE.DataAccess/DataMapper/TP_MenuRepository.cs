/// <Derechos_Reservados>
/// Aplicacion      :Doc4Us 
/// Autor           :Oscar Mauricio Cortes Pinzon
/// Generacion      :Este archivo es generado automaticamente mediante generador :GeneraApp.
/// Ano             :2018
/// Arquitectura    :Patron MVC ASP Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa            :DataAccess (DataAccess Access Layer) - Capa del DataMapper, Esta clase implementa la interface presentada, 
///                  aca desarrolla los metodos del CRUD para cada Objeto que representa los metodos que deben ser implementados 
///                  (Source: MVC7_DAL_DataMapperBase.Cs)   clase 
/// </Derechos_Reservados>


using System;
using System.Xml;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using SISPAE.Model;
using SISPAE.DataAccess;
using SISPAE.DataAccess.DataProviderHelper;
using SISPAE.DataAccess.DataInterfaces;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;




namespace SISPAE.DataAccess.DataMapper
    {
    /// <Resumen>
    /// Clase Abstracta para  TP_Menu
    /// No haga cambios sobre esta clase,
    /// 
    /// </Resumen>
    public partial class TP_MenuRepository : DataObject, ITP_Menu
        {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlDatabase ITDataDatabase;

        public TP_MenuRepository()
            {
            _dataSource = new DataMapperSource();
            ITDataDatabase = new SqlDatabase(_dataSource.cadena);
            }

        public TP_MenuRepository(DataAccess.DataMapper.DataMapperSource dataSource)
            {
            _dataSource = dataSource;
            }

        #endregion Class Declarations

        #region Class Methods

        public TP_Menu GetById(TP_Menu pTP_Menu)
            {

            try
                {
                TP_Menu _Obj = new TP_Menu();
                DataTable dtt = new DataTable();
                SqlParameter[] sqlparams =
                {
                        new SqlParameter("@Id",SqlDbType.Int)

                    };
                sqlparams[0].Value = pTP_Menu.Id;


                dtt.Load(SqlHelper.ExecuteReader(_dataSource.cadena, CommandType.StoredProcedure, "API.PA_TP_MenuGetByKey", sqlparams), LoadOption.OverwriteChanges);

                for(int i = 0; i < dtt.Rows.Count; i++)
                    {
                    _Obj.Id = dtt.Rows[0]["Id"] == DBNull.Value ? 0 : (int)dtt.Rows[0]["Id"];
                    _Obj.Nombre = dtt.Rows[0]["Nombre"] == DBNull.Value ? "" : dtt.Rows[0]["Nombre"].ToString();
                    _Obj.Controlador = dtt.Rows[0]["Controlador"] == DBNull.Value ? "" : dtt.Rows[0]["Controlador"].ToString();
                    _Obj.Accion = dtt.Rows[0]["Accion"] == DBNull.Value ? "" : dtt.Rows[0]["Accion"].ToString();
                    _Obj.GrupoEsquema = dtt.Rows[0]["GrupoEsquema"] == DBNull.Value ? "" : dtt.Rows[0]["GrupoEsquema"].ToString();
                    _Obj.Link = dtt.Rows[0]["Link"] == DBNull.Value ? "" : dtt.Rows[0]["Link"].ToString();
                    _Obj.Orden = dtt.Rows[0]["Orden"] == DBNull.Value ? 0 : (int)dtt.Rows[0]["Orden"];
                    _Obj.OrdenPadre = dtt.Rows[0]["OrdenPadre"] == DBNull.Value ? 0 : (int)dtt.Rows[0]["OrdenPadre"];
                    _Obj.Padre = dtt.Rows[0]["Padre"] == DBNull.Value ? 0 : (int)dtt.Rows[0]["Padre"];
                    _Obj.Icono = dtt.Rows[0]["Icono"] == DBNull.Value ? "" : dtt.Rows[0]["Icono"].ToString();
                    _Obj.MenuRol = dtt.Rows[0]["MenuRol"] == DBNull.Value ? "" : dtt.Rows[0]["MenuRol"].ToString();
                    _Obj.EstadoMenu = dtt.Rows[0]["EstadoMenu"] == DBNull.Value ? false : (Boolean)dtt.Rows[0]["EstadoMenu"];
                    
                    //_Obj.auditoria = dtt.Rows[0]["auditoria"] == DBNull.Value ? "": dtt.Rows[0]["auditoria"].ToString();


                    }
                return _Obj;

                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetById)  TP_Menu  ->" + ex.Message);
                }
            }

        public List<TP_Menu> GetAll()
            {
            try
                {
                DataTable dtt = new DataTable();
                List<TP_Menu> _lista = new List<TP_Menu>();

                dtt.Load(SqlHelper.ExecuteReader(_dataSource.cadena, CommandType.StoredProcedure, "API.PA_TP_MenuAll"), LoadOption.OverwriteChanges);

                for(int i = 0; i < dtt.Rows.Count; i++)
                    {
                    _lista.Add(new TP_Menu
                        {
                        Id = dtt.Rows[i]["Id"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["Id"].ToString()),
                        Nombre = dtt.Rows[i]["Nombre"] == DBNull.Value ? "" : dtt.Rows[i]["Nombre"].ToString(),
                        Controlador = dtt.Rows[i]["Controlador"] == DBNull.Value ? "" : dtt.Rows[i]["Controlador"].ToString(),
                        Accion = dtt.Rows[i]["Accion"] == DBNull.Value ? "" : dtt.Rows[i]["Accion"].ToString(),
                        GrupoEsquema = dtt.Rows[i]["GrupoEsquema"] == DBNull.Value ? "" : dtt.Rows[i]["GrupoEsquema"].ToString(),
                        Link = dtt.Rows[i]["Link"] == DBNull.Value ? "" : dtt.Rows[i]["Link"].ToString(),
                        Orden = dtt.Rows[i]["Orden"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["Orden"].ToString()),
                        OrdenPadre = dtt.Rows[i]["OrdenPadre"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["OrdenPadre"].ToString()),
                        Padre = dtt.Rows[i]["Padre"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["Padre"].ToString()),
                        Icono = dtt.Rows[i]["Icono"] == DBNull.Value ? "" : dtt.Rows[i]["Icono"].ToString(),
                        MenuRol = dtt.Rows[i]["MenuRol"] == DBNull.Value ? "" : dtt.Rows[i]["MenuRol"].ToString(),
                        EstadoMenu = dtt.Rows[i]["EstadoMenu"] == DBNull.Value ? false : (Boolean)dtt.Rows[i]["EstadoMenu"]

                        });
                    }

                return _lista;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetAll)  TP_Menu  ->" + ex.Message);
                }
            }



        public List<TP_Menu> GetAllFull()
            {
            try
                {
                DataTable dtt = new DataTable();
                List<TP_Menu> _lista = new List<TP_Menu>();

                dtt.Load(SqlHelper.ExecuteReader(_dataSource.cadena, CommandType.StoredProcedure, "API.PA_TP_MenuAllFull"), LoadOption.OverwriteChanges);

                for (int i = 0; i < dtt.Rows.Count; i++)
                    {
                    _lista.Add(new TP_Menu
                        {
                        Id = dtt.Rows[i]["Id"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["Id"].ToString()),
                        Nombre = dtt.Rows[i]["Nombre"] == DBNull.Value ? "" : dtt.Rows[i]["Nombre"].ToString(),
                        Controlador = dtt.Rows[i]["Controlador"] == DBNull.Value ? "" : dtt.Rows[i]["Controlador"].ToString(),
                        Accion = dtt.Rows[i]["Accion"] == DBNull.Value ? "" : dtt.Rows[i]["Accion"].ToString(),
                        GrupoEsquema = dtt.Rows[i]["GrupoEsquema"] == DBNull.Value ? "" : dtt.Rows[i]["GrupoEsquema"].ToString(),
                        Link = dtt.Rows[i]["Link"] == DBNull.Value ? "" : dtt.Rows[i]["Link"].ToString(),
                        Orden = dtt.Rows[i]["Orden"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["Orden"].ToString()),
                        OrdenPadre = dtt.Rows[i]["OrdenPadre"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["OrdenPadre"].ToString()),
                        Padre = dtt.Rows[i]["Padre"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["Padre"].ToString()),
                        Icono = dtt.Rows[i]["Icono"] == DBNull.Value ? "" : dtt.Rows[i]["Icono"].ToString(),
                        MenuRol = dtt.Rows[i]["MenuRol"] == DBNull.Value ? "" : dtt.Rows[i]["MenuRol"].ToString(),
                        EstadoMenu = dtt.Rows[i]["EstadoMenu"] == DBNull.Value ? false : (Boolean)dtt.Rows[i]["EstadoMenu"]
                     //   auditoria= dtt.Rows[i]["auditoria"] == DBNull.Value ? "": dtt.Rows[i]["auditoria"].ToString()

                        });
                    }

                return _lista;
                }
            catch (Exception ex)
                {
                throw new Exception("DataMapper:(GetAll)  TP_Menu  ->" + ex.Message);
                }
            }


	        public List<TP_Menu> GetAllByWithRelation()
			{
				try 
					{
					DataTable dtt = new DataTable();
					List<TP_Menu> _lista = new List<TP_Menu>();
					
					dtt.Load(SqlHelper.ExecuteReader(_dataSource.cadena, CommandType.StoredProcedure, "API.PA_TP_MenuGetAllWithRelation"), LoadOption.OverwriteChanges);

					for (int i = 0; i < dtt.Rows.Count; i++) 
                    {
                      _lista.Add(new TP_Menu
                    {
                        Id= dtt.Rows[i]["Id"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["Id"].ToString()),
                        Nombre= dtt.Rows[i]["Nombre"] == DBNull.Value ? "": dtt.Rows[i]["Nombre"].ToString(),
                        Controlador= dtt.Rows[i]["Controlador"] == DBNull.Value ? "": dtt.Rows[i]["Controlador"].ToString(),
                        Accion= dtt.Rows[i]["Accion"] == DBNull.Value ? "": dtt.Rows[i]["Accion"].ToString(),
                        GrupoEsquema= dtt.Rows[i]["GrupoEsquema"] == DBNull.Value ? "": dtt.Rows[i]["GrupoEsquema"].ToString(),
                        Link= dtt.Rows[i]["Link"] == DBNull.Value ? "": dtt.Rows[i]["Link"].ToString(),
                        Orden= dtt.Rows[i]["Orden"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["Orden"].ToString()),
                        OrdenPadre= dtt.Rows[i]["OrdenPadre"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["OrdenPadre"].ToString()),
                        Padre= dtt.Rows[i]["Padre"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["Padre"].ToString()),
                        Icono= dtt.Rows[i]["Icono"] == DBNull.Value ? "": dtt.Rows[i]["Icono"].ToString(),
                        MenuRol= dtt.Rows[i]["MenuRol"] == DBNull.Value ? "": dtt.Rows[i]["MenuRol"].ToString(),
                        EstadoMenu = dtt.Rows[i]["EstadoMenu"] == DBNull.Value ? false : (Boolean)dtt.Rows[i]["EstadoMenu"]
                       // auditoria= dtt.Rows[i]["auditoria"] == DBNull.Value ? "": dtt.Rows[i]["auditoria"].ToString()

                        });
                    }            

					return _lista;
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TP_Menu  ->" + ex.Message);
				}
			}

        public List<TP_Menu> GetAllByUser(string idUser)

            {

            try
                {
                DataTable dtt = new DataTable();
                List<TP_Menu> _lista = new List<TP_Menu>();
                SqlParameter[] sqlparams =
                {
                         new SqlParameter("@Id",SqlDbType.VarChar)                    };
                sqlparams[0].Value = idUser;
                dtt.Load(SqlHelper.ExecuteReader(_dataSource.cadena, CommandType.StoredProcedure, "API.PA_TP_MenuAllByAspNetUser", sqlparams), LoadOption.OverwriteChanges);
                for(int i = 0; i < dtt.Rows.Count; i++)
                    {
                    _lista.Add(new TP_Menu
                        {
                        Id = dtt.Rows[i]["Id"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["Id"].ToString()),
                        Nombre = dtt.Rows[i]["Nombre"] == DBNull.Value ? "" : dtt.Rows[i]["Nombre"].ToString(),
                        Controlador = dtt.Rows[i]["Controlador"] == DBNull.Value ? "" : dtt.Rows[i]["Controlador"].ToString(),
                        Accion = dtt.Rows[i]["Accion"] == DBNull.Value ? "" : dtt.Rows[i]["Accion"].ToString(),
                        GrupoEsquema = dtt.Rows[i]["GrupoEsquema"] == DBNull.Value ? "" : dtt.Rows[i]["GrupoEsquema"].ToString(),
                        Link = dtt.Rows[i]["Link"] == DBNull.Value ? "" : dtt.Rows[i]["Link"].ToString(),
                        Orden = dtt.Rows[i]["Orden"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["Orden"].ToString()),
                        OrdenPadre = dtt.Rows[i]["OrdenPadre"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["OrdenPadre"].ToString()),
                        Padre = dtt.Rows[i]["Padre"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["Padre"].ToString()),
                        Icono = dtt.Rows[i]["Icono"] == DBNull.Value ? "" : dtt.Rows[i]["Icono"].ToString(),
                        MenuRol = dtt.Rows[i]["MenuRol"] == DBNull.Value ? "" : dtt.Rows[i]["MenuRol"].ToString(),
                        EstadoMenu = dtt.Rows[i]["EstadoMenu"] == DBNull.Value ? false : (Boolean)dtt.Rows[i]["EstadoMenu"]
                       // auditoria= dtt.Rows[i]["auditoria"] == DBNull.Value ? "": dtt.Rows[i]["auditoria"].ToString()

                        });
                    }
                return _lista;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetAll)  TP_Menu  ->" + ex.Message);
                }
            }



        public List<TP_Menu> GetByFilter(TP_Menu pTP_Menu, int pageSize, int Page, string OrderByC)
            {
            try
                {
                DataTable dtt = new DataTable();
                List<TP_Menu> _lista = new List<TP_Menu>();
                #pragma warning disable CS0219 // Variable is assigned but its value is never used
                int? vintNUll = null;
                #pragma warning restore CS0219 // Variable is assigned but its value is never used

                SqlParameter[] sqlparams = {
                        new SqlParameter("@Id",SqlDbType.Int),
                        new SqlParameter("@Nombre",SqlDbType.VarChar),
                        new SqlParameter("@Controlador",SqlDbType.VarChar),
                        new SqlParameter("@Accion",SqlDbType.VarChar),
                        new SqlParameter("@GrupoEsquema",SqlDbType.VarChar),
                        new SqlParameter("@Link",SqlDbType.VarChar),
                        new SqlParameter("@Orden",SqlDbType.Int),
                        new SqlParameter("@OrdenPadre",SqlDbType.Int),
                        new SqlParameter("@Padre",SqlDbType.Int),
                        new SqlParameter("@Icono",SqlDbType.VarChar),
                        new SqlParameter("@MenuRol",SqlDbType.VarChar),
                        new SqlParameter("@EstadoMenu",SqlDbType.Bit),
                        new SqlParameter("@TamPag",SqlDbType.Int),
                        new SqlParameter("@pag",SqlDbType.Int),
                        new SqlParameter("@auditoria",SqlDbType.VarChar),
                        new SqlParameter("@OrdenBy",SqlDbType.NVarChar)

                         };
                sqlparams[0].Value = pTP_Menu.Id;
                sqlparams[1].Value = pTP_Menu.Nombre;
                sqlparams[2].Value = pTP_Menu.Controlador;
                sqlparams[3].Value = pTP_Menu.Accion;
                sqlparams[4].Value = pTP_Menu.GrupoEsquema;
                sqlparams[5].Value = pTP_Menu.Link;
                sqlparams[6].Value = pTP_Menu.Orden;
                sqlparams[7].Value = pTP_Menu.OrdenPadre;
                sqlparams[8].Value = pTP_Menu.Padre;
                sqlparams[9].Value = pTP_Menu.Icono;
                sqlparams[10].Value = pTP_Menu.MenuRol;
                sqlparams[11].Value = pTP_Menu.EstadoMenu;
                sqlparams[12].Value = pageSize;
                sqlparams[14].Value = "";
                sqlparams[14].Value = Page;
                sqlparams[15].Value = OrderByC;


                dtt.Load(SqlHelper.ExecuteReader(_dataSource.cadena, CommandType.StoredProcedure, "API.PA_TP_MenuGetByFilter", sqlparams), LoadOption.OverwriteChanges);

                for(int i = 0; i < dtt.Rows.Count; i++)
                    {
                    _lista.Add(new TP_Menu
                        {
                        Id = dtt.Rows[i]["Id"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["Id"].ToString()),
                        Nombre = dtt.Rows[i]["Nombre"] == DBNull.Value ? "" : dtt.Rows[i]["Nombre"].ToString(),
                        Controlador = dtt.Rows[i]["Controlador"] == DBNull.Value ? "" : dtt.Rows[i]["Controlador"].ToString(),
                        Accion = dtt.Rows[i]["Accion"] == DBNull.Value ? "" : dtt.Rows[i]["Accion"].ToString(),
                        GrupoEsquema = dtt.Rows[i]["GrupoEsquema"] == DBNull.Value ? "" : dtt.Rows[i]["GrupoEsquema"].ToString(),
                        Link = dtt.Rows[i]["Link"] == DBNull.Value ? "" : dtt.Rows[i]["Link"].ToString(),
                        Orden = dtt.Rows[i]["Orden"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["Orden"].ToString()),
                        OrdenPadre = dtt.Rows[i]["OrdenPadre"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["OrdenPadre"].ToString()),
                        Padre = dtt.Rows[i]["Padre"] == DBNull.Value ? 0 : int.Parse(dtt.Rows[i]["Padre"].ToString()),
                        Icono = dtt.Rows[i]["Icono"] == DBNull.Value ? "" : dtt.Rows[i]["Icono"].ToString(),
                        MenuRol = dtt.Rows[i]["MenuRol"] == DBNull.Value ? "" : dtt.Rows[i]["MenuRol"].ToString(),
                        EstadoMenu = dtt.Rows[i]["EstadoMenu"] == DBNull.Value ? false : (Boolean)dtt.Rows[i]["EstadoMenu"]

                        });
                    }

                return _lista;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetByFilter)  TP_Menu  ->" + ex.Message);
                }
            }

        public TP_Menu Add(TP_Menu pTP_Menu)
            {
            try
                {
                TP_Menu _Obj = new TP_Menu();
                DataTable dtt = new DataTable();
#pragma warning disable CS0219 // Variable is assigned but its value is never used
                int? vintNUll = null;
#pragma warning restore CS0219 // Variable is assigned but its value is never used


                SqlParameter[] sqlparams = {
                        new SqlParameter("@Id",SqlDbType.Int),
                        new SqlParameter("@Nombre",SqlDbType.VarChar),
                        new SqlParameter("@Controlador",SqlDbType.VarChar),
                        new SqlParameter("@Accion",SqlDbType.VarChar),
                        new SqlParameter("@GrupoEsquema",SqlDbType.VarChar),
                        new SqlParameter("@Link",SqlDbType.VarChar),
                        new SqlParameter("@Orden",SqlDbType.Int),
                        new SqlParameter("@OrdenPadre",SqlDbType.Int),
                        new SqlParameter("@Padre",SqlDbType.Int),
                        new SqlParameter("@Icono",SqlDbType.VarChar),
                        new SqlParameter("@MenuRol",SqlDbType.VarChar),
                        new SqlParameter("@EstadoMenu",SqlDbType.Bit),
                        new SqlParameter("@auditoria",SqlDbType.NVarChar)

                         };
                sqlparams[0].Value = pTP_Menu.Id;
                sqlparams[1].Value = pTP_Menu.Nombre;
                sqlparams[2].Value = pTP_Menu.Controlador;
                sqlparams[3].Value = pTP_Menu.Accion;
                sqlparams[4].Value = pTP_Menu.GrupoEsquema;
                sqlparams[5].Value = pTP_Menu.Link;
                sqlparams[6].Value = pTP_Menu.Orden;
                sqlparams[7].Value = pTP_Menu.OrdenPadre;
                sqlparams[8].Value = pTP_Menu.Padre;
                sqlparams[9].Value = pTP_Menu.Icono;
                sqlparams[10].Value = pTP_Menu.MenuRol;
                sqlparams[11].Value = pTP_Menu.EstadoMenu;
                sqlparams[12].Value = pTP_Menu._XMLAuditoria;


                dtt.Load(SqlHelper.ExecuteReader(_dataSource.cadena, CommandType.StoredProcedure, "API.PA_TP_MenuAdd", sqlparams), LoadOption.OverwriteChanges);

                for(int i = 0; i < dtt.Rows.Count; i++)
                    {
                    _Obj.Id = dtt.Rows[0]["Id"] == DBNull.Value ? 0 : (int)dtt.Rows[0]["Id"];
                    _Obj.Nombre = dtt.Rows[0]["Nombre"] == DBNull.Value ? "" : dtt.Rows[0]["Nombre"].ToString();
                    _Obj.Controlador = dtt.Rows[0]["Controlador"] == DBNull.Value ? "" : dtt.Rows[0]["Controlador"].ToString();
                    _Obj.Accion = dtt.Rows[0]["Accion"] == DBNull.Value ? "" : dtt.Rows[0]["Accion"].ToString();
                    _Obj.GrupoEsquema = dtt.Rows[0]["GrupoEsquema"] == DBNull.Value ? "" : dtt.Rows[0]["GrupoEsquema"].ToString();
                    _Obj.Link = dtt.Rows[0]["Link"] == DBNull.Value ? "" : dtt.Rows[0]["Link"].ToString();
                    _Obj.Orden = dtt.Rows[0]["Orden"] == DBNull.Value ? 0 : (int)dtt.Rows[0]["Orden"];
                    _Obj.OrdenPadre = dtt.Rows[0]["OrdenPadre"] == DBNull.Value ? 0 : (int)dtt.Rows[0]["OrdenPadre"];
                    _Obj.Padre = dtt.Rows[0]["Padre"] == DBNull.Value ? 0 : (int)dtt.Rows[0]["Padre"];
                    _Obj.Icono = dtt.Rows[0]["Icono"] == DBNull.Value ? "" : dtt.Rows[0]["Icono"].ToString();
                    _Obj.MenuRol = dtt.Rows[0]["MenuRol"] == DBNull.Value ? "" : dtt.Rows[0]["MenuRol"].ToString();
                    _Obj.EstadoMenu = dtt.Rows[0]["EstadoMenu"] == DBNull.Value ? false : (Boolean)dtt.Rows[0]["EstadoMenu"];
                   // _Obj.auditoria = dtt.Rows[0]["auditoria"] == DBNull.Value ? "": dtt.Rows[0]["auditoria"].ToString();

                    }
                return _Obj;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(Add)  TP_Menu  ->" + ex.Message);
                }
            }

        public TP_Menu Update(TP_Menu pTP_Menu)
            {
            try
                {
#pragma warning disable CS0219 // Variable is assigned but its value is never used
                int? vintNUll = null;
#pragma warning restore CS0219 // Variable is assigned but its value is never used


                SqlParameter[] sqlparams = {
                        new SqlParameter("@Id",SqlDbType.Int),
                        new SqlParameter("@Nombre",SqlDbType.VarChar),
                        new SqlParameter("@Controlador",SqlDbType.VarChar),
                        new SqlParameter("@Accion",SqlDbType.VarChar),
                        new SqlParameter("@GrupoEsquema",SqlDbType.VarChar),
                        new SqlParameter("@Link",SqlDbType.VarChar),
                        new SqlParameter("@Orden",SqlDbType.Int),
                        new SqlParameter("@OrdenPadre",SqlDbType.Int),
                        new SqlParameter("@Padre",SqlDbType.Int),
                        new SqlParameter("@Icono",SqlDbType.VarChar),
                        new SqlParameter("@MenuRol",SqlDbType.VarChar),
                        new SqlParameter("@EstadoMenu",SqlDbType.Bit)
                        ,new SqlParameter("@auditoria",SqlDbType.NVarChar)

                         };
                sqlparams[0].Value = pTP_Menu.Id;
                sqlparams[1].Value = pTP_Menu.Nombre;
                sqlparams[2].Value = pTP_Menu.Controlador;
                sqlparams[3].Value = pTP_Menu.Accion;
                sqlparams[4].Value = pTP_Menu.GrupoEsquema;
                sqlparams[5].Value = pTP_Menu.Link;
                sqlparams[6].Value = pTP_Menu.Orden;
                sqlparams[7].Value = pTP_Menu.OrdenPadre;
                sqlparams[8].Value = pTP_Menu.Padre;
                sqlparams[9].Value = pTP_Menu.Icono;
                sqlparams[10].Value = pTP_Menu.MenuRol;
                sqlparams[11].Value = pTP_Menu.EstadoMenu;
                sqlparams[12].Value = pTP_Menu._XMLAuditoria;



                SqlHelper.ExecuteNonQuery(_dataSource.cadena, CommandType.StoredProcedure, "API.PA_TP_MenuUpdate", sqlparams);
                return this.GetById(pTP_Menu); ;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(Update)  TP_Menu  ->" + ex.Message);
                }
            }

        public bool Delete(TP_Menu pTP_Menu)
            {
            try
                {
                SqlParameter[] sqlparams =
                {
                    new SqlParameter("@Id",SqlDbType.Int)
                    ,new SqlParameter("@auditoria",SqlDbType.NVarChar)

                };

                sqlparams[0].Value = pTP_Menu.Id;
                sqlparams[1].Value = pTP_Menu._XMLAuditoria;


                SqlHelper.ExecuteNonQuery(_dataSource.cadena, CommandType.StoredProcedure, "API.PA_TP_MenuDelete", sqlparams);
                return true;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper: (Delete) TP_Menu  ->" + ex.Message);
                }
            }




        public IList<TP_Menu> execProcedureQuery(IList<SqlParameter> sqlparametersvaluesList, string Procedimiento)
            {
            try
                {

                IList<TP_Menu> TP_MenuList = new List<TP_Menu>();
                string StoreProcedureName = Procedimiento;
                string sqlCommand = string.Empty;
                sqlCommand = StoreProcedureName;
                DbCommand dbCommand = ITDataDatabase.GetStoredProcCommand(sqlCommand);
                dbCommand.CommandTimeout = 0;
                ITDataDatabase.AddInParameter(dbCommand, "@", SqlDbType.SmallInt, Convert.ToInt16(sqlparametersvaluesList[0].Value.ToString()));

                using(IDataReader dataReader = ITDataDatabase.ExecuteReader(dbCommand))
                    {
                    if(dataReader.Read())
                        {
                        //TP_MenuList.Add(dataReader);                          
                        }
                    }
                return TP_MenuList;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(ExecProcedureQuery) TP_Menu  ->" + ex.Message);
                }
            }

        public object execProcedureNonQuery(IList<SqlParameter> sqlparametersvaluesList, string Procedimiento)
            {
            try
                {

                IList<TP_Menu> TP_MenuList = new List<TP_Menu>();
                string StoreProcedureName = Procedimiento;
                string sqlCommand = string.Empty;
                sqlCommand = StoreProcedureName;
                DbCommand dbCommand = ITDataDatabase.GetStoredProcCommand(sqlCommand);
                dbCommand.CommandTimeout = 0;
                ITDataDatabase.AddInParameter(dbCommand, "@", SqlDbType.SmallInt, Convert.ToInt16(sqlparametersvaluesList[0].Value.ToString()));
                using(IDataReader dataReader = ITDataDatabase.ExecuteReader(dbCommand))
                    {
                    if(dataReader.Read())
                        {
                        //TP_MenuList.Add(dataReader);                          
                        }
                    }
                return TP_MenuList;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(ExecProcedureNonQuery) TP_Menu  ->" + ex.Message);
                }
            }
        }
    #endregion Class Methods

    }
