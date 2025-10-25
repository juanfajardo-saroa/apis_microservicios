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
     /// Clase Abstracta para  MenuGrupos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MenuGruposRepository : DataObject , IMenuGrupos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MenuGruposRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MenuGruposRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MenuGrupos GetById(MenuGrupos pMenuGrupos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenuGrupos.id);                                    


    				MenuGrupos o = SqlMapper.QueryFirstOrDefault<MenuGrupos>(con, "API.PA_MenuGruposGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MenuGrupos  ->" + ex.Message);
				}
			}

			public List<MenuGrupos> GetAll()
			{
				try 
                {
                        List<MenuGrupos> l = SqlMapper.Query<MenuGrupos>(con, "API.PA_MenuGruposGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MenuGrupos  ->" + ex.Message);
				}
			}

			public List<MenuGrupos> GetAllFull()
			{
				try 
				{
                    List<MenuGrupos> l = SqlMapper.Query<MenuGrupos>(con, "API.PA_MenuGruposGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MenuGrupos  ->" + ex.Message);
				}
			}
			
			public List<MenuGrupos> GetAllByWithRelation()
			{
				try 
                {
                    List<MenuGrupos> l = SqlMapper.Query<MenuGrupos>(con, "API.PA_MenuGruposGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MenuGrupos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MenuGrupos> GetByFilter(MenuGrupos pMenuGrupos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMenuGrupos.id== null || pMenuGrupos.id==0) ? vintNUll :pMenuGrupos.id);
                    p.Add("@ID_Menu",(pMenuGrupos.ID_Menu== null || pMenuGrupos.ID_Menu==0) ? vintNUll :pMenuGrupos.ID_Menu);
                    p.Add("@ID_GrupoAlimentos",(pMenuGrupos.ID_GrupoAlimentos== null || pMenuGrupos.ID_GrupoAlimentos==0) ? vintNUll :pMenuGrupos.ID_GrupoAlimentos);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MenuGrupos> l = SqlMapper.Query<MenuGrupos>(con, "API.PA_MenuGruposGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MenuGrupos  ->" + ex.Message);
				}
			}

			public MenuGrupos Add(MenuGrupos pMenuGrupos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMenuGrupos.id==null ? 0 : pMenuGrupos.id);
p.Add("@ID_Menu",pMenuGrupos.ID_Menu==null ? 0 : pMenuGrupos.ID_Menu);
p.Add("@ID_GrupoAlimentos",pMenuGrupos.ID_GrupoAlimentos==null ? 0 : pMenuGrupos.ID_GrupoAlimentos);
                    p.Add("@auditoria", pMenuGrupos.auditoria);

                         


                    MenuGrupos o = SqlMapper.QueryFirstOrDefault<MenuGrupos>(con, "API.PA_MenuGruposAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MenuGrupos  ->" + ex.Message);
				}
			}

			public MenuGrupos  Update(MenuGrupos pMenuGrupos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMenuGrupos.id==null ? 0 : pMenuGrupos.id);
p.Add("@ID_Menu",pMenuGrupos.ID_Menu==null ? 0 : pMenuGrupos.ID_Menu);
p.Add("@ID_GrupoAlimentos",pMenuGrupos.ID_GrupoAlimentos==null ? 0 : pMenuGrupos.ID_GrupoAlimentos);
                    p.Add("@auditoria", pMenuGrupos.auditoria);

                         


                    MenuGrupos o = SqlMapper.QueryFirstOrDefault<MenuGrupos>(con, "API.PA_MenuGruposUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MenuGrupos  ->" + ex.Message);
				}
			}

			public bool Delete(MenuGrupos pMenuGrupos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenuGrupos.id);
                    p.Add("@auditoria", pMenuGrupos.auditoria);

                

 

					MenuGrupos o = SqlMapper.QueryFirstOrDefault<MenuGrupos>(con, "API.PA_MenuGruposDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MenuGrupos  ->" + ex.Message);
				}
			}

		



            public List<MenuGrupos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MenuGrupos> MenuGruposList = new List<MenuGrupos>();

                    MenuGruposList = SqlMapper.Query<MenuGrupos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MenuGruposList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MenuGrupos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MenuGrupos> b)
            {
                DapperPlusManager.Entity<MenuGrupos>().Table("MenuGrupos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}