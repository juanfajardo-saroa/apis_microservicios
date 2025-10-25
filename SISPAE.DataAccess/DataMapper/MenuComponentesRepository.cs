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
     /// Clase Abstracta para  MenuComponentes
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MenuComponentesRepository : DataObject , IMenuComponentes 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MenuComponentesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MenuComponentesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MenuComponentes GetById(MenuComponentes pMenuComponentes)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenuComponentes.id);                                    


    				MenuComponentes o = SqlMapper.QueryFirstOrDefault<MenuComponentes>(con, "API.PA_MenuComponentesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MenuComponentes  ->" + ex.Message);
				}
			}

			public List<MenuComponentes> GetAll()
			{
				try 
                {
                        List<MenuComponentes> l = SqlMapper.Query<MenuComponentes>(con, "API.PA_MenuComponentesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MenuComponentes  ->" + ex.Message);
				}
			}

			public List<MenuComponentes> GetAllFull()
			{
				try 
				{
                    List<MenuComponentes> l = SqlMapper.Query<MenuComponentes>(con, "API.PA_MenuComponentesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MenuComponentes  ->" + ex.Message);
				}
			}
			
			public List<MenuComponentes> GetAllByWithRelation()
			{
				try 
                {
                    List<MenuComponentes> l = SqlMapper.Query<MenuComponentes>(con, "API.PA_MenuComponentesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MenuComponentes  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MenuComponentes> GetByFilter(MenuComponentes pMenuComponentes, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMenuComponentes.id== null || pMenuComponentes.id==0) ? vintNUll :pMenuComponentes.id);
                    p.Add("@ID_Menu",(pMenuComponentes.ID_Menu== null || pMenuComponentes.ID_Menu==0) ? vintNUll :pMenuComponentes.ID_Menu);
                    p.Add("@ID_TipoComponente",(pMenuComponentes.ID_TipoComponente== null || pMenuComponentes.ID_TipoComponente==0) ? vintNUll :pMenuComponentes.ID_TipoComponente);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MenuComponentes> l = SqlMapper.Query<MenuComponentes>(con, "API.PA_MenuComponentesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MenuComponentes  ->" + ex.Message);
				}
			}

			public MenuComponentes Add(MenuComponentes pMenuComponentes)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMenuComponentes.id==null ? 0 : pMenuComponentes.id);
p.Add("@ID_Menu",pMenuComponentes.ID_Menu==null ? 0 : pMenuComponentes.ID_Menu);
p.Add("@ID_TipoComponente",pMenuComponentes.ID_TipoComponente==null ? 0 : pMenuComponentes.ID_TipoComponente);
                    p.Add("@auditoria", pMenuComponentes.auditoria);

                         


                    MenuComponentes o = SqlMapper.QueryFirstOrDefault<MenuComponentes>(con, "API.PA_MenuComponentesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MenuComponentes  ->" + ex.Message);
				}
			}

			public MenuComponentes  Update(MenuComponentes pMenuComponentes)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMenuComponentes.id==null ? 0 : pMenuComponentes.id);
p.Add("@ID_Menu",pMenuComponentes.ID_Menu==null ? 0 : pMenuComponentes.ID_Menu);
p.Add("@ID_TipoComponente",pMenuComponentes.ID_TipoComponente==null ? 0 : pMenuComponentes.ID_TipoComponente);
                    p.Add("@auditoria", pMenuComponentes.auditoria);

                         


                    MenuComponentes o = SqlMapper.QueryFirstOrDefault<MenuComponentes>(con, "API.PA_MenuComponentesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MenuComponentes  ->" + ex.Message);
				}
			}

			public bool Delete(MenuComponentes pMenuComponentes)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenuComponentes.id);
                    p.Add("@auditoria", pMenuComponentes.auditoria);

                

 

					MenuComponentes o = SqlMapper.QueryFirstOrDefault<MenuComponentes>(con, "API.PA_MenuComponentesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MenuComponentes  ->" + ex.Message);
				}
			}

		



            public List<MenuComponentes> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MenuComponentes> MenuComponentesList = new List<MenuComponentes>();

                    MenuComponentesList = SqlMapper.Query<MenuComponentes>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MenuComponentesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MenuComponentes  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MenuComponentes> b)
            {
                DapperPlusManager.Entity<MenuComponentes>().Table("MenuComponentes");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}