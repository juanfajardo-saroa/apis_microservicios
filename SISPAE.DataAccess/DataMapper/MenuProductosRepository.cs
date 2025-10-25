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
     /// Clase Abstracta para  MenuProductos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MenuProductosRepository : DataObject , IMenuProductos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MenuProductosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MenuProductosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MenuProductos GetById(MenuProductos pMenuProductos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenuProductos.id);                                    


    				MenuProductos o = SqlMapper.QueryFirstOrDefault<MenuProductos>(con, "API.PA_MenuProductosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MenuProductos  ->" + ex.Message);
				}
			}

			public List<MenuProductos> GetAll()
			{
				try 
                {
                        List<MenuProductos> l = SqlMapper.Query<MenuProductos>(con, "API.PA_MenuProductosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MenuProductos  ->" + ex.Message);
				}
			}

			public List<MenuProductos> GetAllFull()
			{
				try 
				{
                    List<MenuProductos> l = SqlMapper.Query<MenuProductos>(con, "API.PA_MenuProductosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MenuProductos  ->" + ex.Message);
				}
			}
			
			public List<MenuProductos> GetAllByWithRelation()
			{
				try 
                {
                    List<MenuProductos> l = SqlMapper.Query<MenuProductos>(con, "API.PA_MenuProductosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MenuProductos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MenuProductos> GetByFilter(MenuProductos pMenuProductos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMenuProductos.id== null || pMenuProductos.id==0) ? vintNUll :pMenuProductos.id);
                    p.Add("@ID_Menu",(pMenuProductos.ID_Menu== null || pMenuProductos.ID_Menu==0) ? vintNUll :pMenuProductos.ID_Menu);
                    p.Add("@ID_Producto",(pMenuProductos.ID_Producto== null || pMenuProductos.ID_Producto==0) ? vintNUll :pMenuProductos.ID_Producto);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MenuProductos> l = SqlMapper.Query<MenuProductos>(con, "API.PA_MenuProductosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MenuProductos  ->" + ex.Message);
				}
			}

			public MenuProductos Add(MenuProductos pMenuProductos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMenuProductos.id==null ? 0 : pMenuProductos.id);
p.Add("@ID_Menu",pMenuProductos.ID_Menu==null ? 0 : pMenuProductos.ID_Menu);
p.Add("@ID_Producto",pMenuProductos.ID_Producto==null ? 0 : pMenuProductos.ID_Producto);
                    p.Add("@auditoria", pMenuProductos.auditoria);

                         


                    MenuProductos o = SqlMapper.QueryFirstOrDefault<MenuProductos>(con, "API.PA_MenuProductosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MenuProductos  ->" + ex.Message);
				}
			}

			public MenuProductos  Update(MenuProductos pMenuProductos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMenuProductos.id==null ? 0 : pMenuProductos.id);
p.Add("@ID_Menu",pMenuProductos.ID_Menu==null ? 0 : pMenuProductos.ID_Menu);
p.Add("@ID_Producto",pMenuProductos.ID_Producto==null ? 0 : pMenuProductos.ID_Producto);
                    p.Add("@auditoria", pMenuProductos.auditoria);

                         


                    MenuProductos o = SqlMapper.QueryFirstOrDefault<MenuProductos>(con, "API.PA_MenuProductosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MenuProductos  ->" + ex.Message);
				}
			}

			public bool Delete(MenuProductos pMenuProductos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenuProductos.id);
                    p.Add("@auditoria", pMenuProductos.auditoria);

                

 

					MenuProductos o = SqlMapper.QueryFirstOrDefault<MenuProductos>(con, "API.PA_MenuProductosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MenuProductos  ->" + ex.Message);
				}
			}

		



            public List<MenuProductos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MenuProductos> MenuProductosList = new List<MenuProductos>();

                    MenuProductosList = SqlMapper.Query<MenuProductos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MenuProductosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MenuProductos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MenuProductos> b)
            {
                DapperPlusManager.Entity<MenuProductos>().Table("MenuProductos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}