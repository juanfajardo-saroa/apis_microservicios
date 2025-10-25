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
     /// Clase Abstracta para  MenuRol
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MenuRolRepository : DataObject , IMenuRol 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MenuRolRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MenuRolRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MenuRol GetById(MenuRol pMenuRol)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenuRol.id);                                    


    				MenuRol o = SqlMapper.QueryFirstOrDefault<MenuRol>(con, "API.PA_MenuRolGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MenuRol  ->" + ex.Message);
				}
			}

			public List<MenuRol> GetAll()
			{
				try 
                {
                        List<MenuRol> l = SqlMapper.Query<MenuRol>(con, "API.PA_MenuRolGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MenuRol  ->" + ex.Message);
				}
			}

			public List<MenuRol> GetAllFull()
			{
				try 
				{
                    List<MenuRol> l = SqlMapper.Query<MenuRol>(con, "API.PA_MenuRolGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MenuRol  ->" + ex.Message);
				}
			}
			
			public List<MenuRol> GetAllByWithRelation()
			{
				try 
                {
                    List<MenuRol> l = SqlMapper.Query<MenuRol>(con, "API.PA_MenuRolGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MenuRol  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MenuRol> GetByFilter(MenuRol pMenuRol, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMenuRol.id== null || pMenuRol.id==0) ? vintNUll :pMenuRol.id);
                    p.Add("@Id_Menu",(pMenuRol.Id_Menu== null || pMenuRol.Id_Menu==0) ? vintNUll :pMenuRol.Id_Menu);
                    p.Add("@AspNetRoles",(pMenuRol.AspNetRoles== null) ? vintNUll :pMenuRol.AspNetRoles);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MenuRol> l = SqlMapper.Query<MenuRol>(con, "API.PA_MenuRolGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MenuRol  ->" + ex.Message);
				}
			}

			public MenuRol Add(MenuRol pMenuRol)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMenuRol.id==null ? 0 : pMenuRol.id);
p.Add("@Id_Menu",pMenuRol.Id_Menu==null ? 0 : pMenuRol.Id_Menu);
                    p.Add("@AspNetRoles", pMenuRol.AspNetRoles);
                    p.Add("@auditoria", pMenuRol.auditoria);

                         


                    MenuRol o = SqlMapper.QueryFirstOrDefault<MenuRol>(con, "API.PA_MenuRolAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MenuRol  ->" + ex.Message);
				}
			}

			public MenuRol  Update(MenuRol pMenuRol)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMenuRol.id==null ? 0 : pMenuRol.id);
p.Add("@Id_Menu",pMenuRol.Id_Menu==null ? 0 : pMenuRol.Id_Menu);
                    p.Add("@AspNetRoles", pMenuRol.AspNetRoles);
                    p.Add("@auditoria", pMenuRol.auditoria);

                         


                    MenuRol o = SqlMapper.QueryFirstOrDefault<MenuRol>(con, "API.PA_MenuRolUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MenuRol  ->" + ex.Message);
				}
			}

			public bool Delete(MenuRol pMenuRol)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenuRol.id);
                    p.Add("@auditoria", pMenuRol.auditoria);

                

 

					MenuRol o = SqlMapper.QueryFirstOrDefault<MenuRol>(con, "API.PA_MenuRolDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MenuRol  ->" + ex.Message);
				}
			}

		



            public List<MenuRol> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MenuRol> MenuRolList = new List<MenuRol>();

                    MenuRolList = SqlMapper.Query<MenuRol>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MenuRolList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MenuRol  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MenuRol> b)
            {
                DapperPlusManager.Entity<MenuRol>().Table("MenuRol");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}