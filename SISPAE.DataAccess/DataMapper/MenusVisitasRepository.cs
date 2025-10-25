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
     /// Clase Abstracta para  MenusVisitas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MenusVisitasRepository : DataObject , IMenusVisitas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MenusVisitasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MenusVisitasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MenusVisitas GetById(MenusVisitas pMenusVisitas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenusVisitas.id);                                    


    				MenusVisitas o = SqlMapper.QueryFirstOrDefault<MenusVisitas>(con, "API.PA_MenusVisitasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MenusVisitas  ->" + ex.Message);
				}
			}

			public List<MenusVisitas> GetAll()
			{
				try 
                {
                        List<MenusVisitas> l = SqlMapper.Query<MenusVisitas>(con, "API.PA_MenusVisitasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MenusVisitas  ->" + ex.Message);
				}
			}

			public List<MenusVisitas> GetAllFull()
			{
				try 
				{
                    List<MenusVisitas> l = SqlMapper.Query<MenusVisitas>(con, "API.PA_MenusVisitasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MenusVisitas  ->" + ex.Message);
				}
			}
			
			public List<MenusVisitas> GetAllByWithRelation()
			{
				try 
                {
                    List<MenusVisitas> l = SqlMapper.Query<MenusVisitas>(con, "API.PA_MenusVisitasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MenusVisitas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MenusVisitas> GetByFilter(MenusVisitas pMenusVisitas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMenusVisitas.id== null || pMenusVisitas.id==0) ? vintNUll :pMenusVisitas.id);
                    p.Add("@ID_MenuPlanAlistamiento",(pMenusVisitas.ID_MenuPlanAlistamiento== null || pMenusVisitas.ID_MenuPlanAlistamiento==0) ? vintNUll :pMenusVisitas.ID_MenuPlanAlistamiento);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MenusVisitas> l = SqlMapper.Query<MenusVisitas>(con, "API.PA_MenusVisitasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MenusVisitas  ->" + ex.Message);
				}
			}

			public MenusVisitas Add(MenusVisitas pMenusVisitas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMenusVisitas.id==null ? 0 : pMenusVisitas.id);
p.Add("@ID_MenuPlanAlistamiento",pMenusVisitas.ID_MenuPlanAlistamiento==null ? 0 : pMenusVisitas.ID_MenuPlanAlistamiento);
                    p.Add("@auditoria", pMenusVisitas.auditoria);

                         


                    MenusVisitas o = SqlMapper.QueryFirstOrDefault<MenusVisitas>(con, "API.PA_MenusVisitasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MenusVisitas  ->" + ex.Message);
				}
			}

			public MenusVisitas  Update(MenusVisitas pMenusVisitas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMenusVisitas.id==null ? 0 : pMenusVisitas.id);
p.Add("@ID_MenuPlanAlistamiento",pMenusVisitas.ID_MenuPlanAlistamiento==null ? 0 : pMenusVisitas.ID_MenuPlanAlistamiento);
                    p.Add("@auditoria", pMenusVisitas.auditoria);

                         


                    MenusVisitas o = SqlMapper.QueryFirstOrDefault<MenusVisitas>(con, "API.PA_MenusVisitasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MenusVisitas  ->" + ex.Message);
				}
			}

			public bool Delete(MenusVisitas pMenusVisitas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenusVisitas.id);
                    p.Add("@auditoria", pMenusVisitas.auditoria);

                

 

					MenusVisitas o = SqlMapper.QueryFirstOrDefault<MenusVisitas>(con, "API.PA_MenusVisitasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MenusVisitas  ->" + ex.Message);
				}
			}

		



            public List<MenusVisitas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MenusVisitas> MenusVisitasList = new List<MenusVisitas>();

                    MenusVisitasList = SqlMapper.Query<MenusVisitas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MenusVisitasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MenusVisitas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MenusVisitas> b)
            {
                DapperPlusManager.Entity<MenusVisitas>().Table("MenusVisitas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}