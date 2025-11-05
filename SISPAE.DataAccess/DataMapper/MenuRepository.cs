/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador :GeneraApp.
/// Ano				:2022
/// Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa			:DataAccess (DataAccess Access Layer) - Capa del DataMapper, Esta clase implementa la interface presentada, 
///                  aca desarrolla los metodos del CRUD para cada Objeto que representa los metodos que deben ser implementados 
///                  (Source: MVC7_DAL_DataMapperBase.Cs)   clase 
/// </Derechos_Reservados>


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SISPAE.Model;
using SISPAE.DataAccess.DataInterfaces;
using Dapper;
using static Dapper.SqlMapper;
using Z.Dapper.Plus;



namespace SISPAE.DataAccess.DataMapper
{
     /// <Resumen>
     /// Clase Abstracta para  Menu
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MenuRepository : DataObject , IMenu 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MenuRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MenuRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Menu GetById(Menu pMenu)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenu.id);                                    


    				Menu o = SqlMapper.QueryFirstOrDefault<Menu>(con, "API.PA_MenuGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Menu  ->" + ex.Message);
				}
			}

			public List<Menu> GetAll()
			{
				try 
                {
                        List<Menu> l = SqlMapper.Query<Menu>(con, "API.PA_MenuGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Menu  ->" + ex.Message);
				}
			}

			public List<Menu> GetAllFull()
			{
				try 
				{
                    List<Menu> l = SqlMapper.Query<Menu>(con, "API.PA_MenuGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Menu  ->" + ex.Message);
				}
			}
			
			public List<Menu> GetAllByWithRelation()
			{
				try 
                {
                    List<Menu> l = SqlMapper.Query<Menu>(con, "API.PA_MenuGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Menu  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Menu> GetByFilter(Menu pMenu, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMenu.id== null || pMenu.id==0) ? vintNUll :pMenu.id);
                    p.Add("@Nombre",(pMenu.Nombre== null) ? vintNUll :pMenu.Nombre);
                    p.Add("@Controlador",(pMenu.Controlador== null) ? vintNUll :pMenu.Controlador);
                    p.Add("@Accion",(pMenu.Accion== null) ? vintNUll :pMenu.Accion);
                    p.Add("@GrupoEsquema",(pMenu.GrupoEsquema== null) ? vintNUll :pMenu.GrupoEsquema);
                    p.Add("@Link",(pMenu.Link== null) ? vintNUll :pMenu.Link);
                    p.Add("@Orden",(pMenu.Orden== null) ? vintNUll :pMenu.Orden);
                    p.Add("@OrdenPadre",(pMenu.OrdenPadre== null) ? vintNUll :pMenu.OrdenPadre);
                    p.Add("@Padre",(pMenu.Padre== null) ? vintNUll :pMenu.Padre);
                    p.Add("@Icono",(pMenu.Icono== null) ? vintNUll :pMenu.Icono);
                    p.Add("@IconoPAE",(pMenu.IconoPAE== null) ? vintNUll :pMenu.IconoPAE);
                    p.Add("@EstadoMenu",(pMenu.EstadoMenu== null) ? vintNUll :pMenu.EstadoMenu);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Menu> l = SqlMapper.Query<Menu>(con, "API.PA_MenuGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Menu  ->" + ex.Message);
				}
			}

			public Menu Add(Menu pMenu)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMenu.id==null ? 0 : pMenu.id);
                    p.Add("@Nombre", pMenu.Nombre);
                    p.Add("@Controlador", pMenu.Controlador);
                    p.Add("@Accion", pMenu.Accion);
                    p.Add("@GrupoEsquema", pMenu.GrupoEsquema);
                    p.Add("@Link", pMenu.Link);
p.Add("@Orden",pMenu.Orden==null ? 0 : pMenu.Orden);
p.Add("@OrdenPadre",pMenu.OrdenPadre==null ? 0 : pMenu.OrdenPadre);
p.Add("@Padre",pMenu.Padre==null ? 0 : pMenu.Padre);
                    p.Add("@Icono", pMenu.Icono);
                    p.Add("@IconoPAE", pMenu.IconoPAE);
                    p.Add("@EstadoMenu", pMenu.EstadoMenu);
                    p.Add("@auditoria", pMenu.auditoria);

                         


                    Menu o = SqlMapper.QueryFirstOrDefault<Menu>(con, "API.PA_MenuAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Menu  ->" + ex.Message);
				}
			}

			public Menu  Update(Menu pMenu)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMenu.id==null ? 0 : pMenu.id);
                    p.Add("@Nombre", pMenu.Nombre);
                    p.Add("@Controlador", pMenu.Controlador);
                    p.Add("@Accion", pMenu.Accion);
                    p.Add("@GrupoEsquema", pMenu.GrupoEsquema);
                    p.Add("@Link", pMenu.Link);
p.Add("@Orden",pMenu.Orden==null ? 0 : pMenu.Orden);
p.Add("@OrdenPadre",pMenu.OrdenPadre==null ? 0 : pMenu.OrdenPadre);
p.Add("@Padre",pMenu.Padre==null ? 0 : pMenu.Padre);
                    p.Add("@Icono", pMenu.Icono);
                    p.Add("@IconoPAE", pMenu.IconoPAE);
                    p.Add("@EstadoMenu", pMenu.EstadoMenu);
                    p.Add("@auditoria", pMenu.auditoria);

                         


                    Menu o = SqlMapper.QueryFirstOrDefault<Menu>(con, "API.PA_MenuUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Menu  ->" + ex.Message);
				}
			}

			public bool Delete(Menu pMenu)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenu.id);
                    p.Add("@auditoria", pMenu.auditoria);

                

 

					Menu o = SqlMapper.QueryFirstOrDefault<Menu>(con, "API.PA_MenuDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Menu  ->" + ex.Message);
				}
			}

		



            public List<Menu> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Menu> MenuList = new List<Menu>();

                    MenuList = SqlMapper.Query<Menu>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MenuList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Menu  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Menu> b)
            {
                DapperPlusManager.Entity<Menu>().Table("Menu");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}