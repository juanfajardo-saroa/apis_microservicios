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
     /// Clase Abstracta para  MenuPreparaciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MenuPreparacionesRepository : DataObject , IMenuPreparaciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MenuPreparacionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MenuPreparacionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MenuPreparaciones GetById(MenuPreparaciones pMenuPreparaciones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenuPreparaciones.id);                                    


    				MenuPreparaciones o = SqlMapper.QueryFirstOrDefault<MenuPreparaciones>(con, "API.PA_MenuPreparacionesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MenuPreparaciones  ->" + ex.Message);
				}
			}

			public List<MenuPreparaciones> GetAll()
			{
				try 
                {
                        List<MenuPreparaciones> l = SqlMapper.Query<MenuPreparaciones>(con, "API.PA_MenuPreparacionesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MenuPreparaciones  ->" + ex.Message);
				}
			}

			public List<MenuPreparaciones> GetAllFull()
			{
				try 
				{
                    List<MenuPreparaciones> l = SqlMapper.Query<MenuPreparaciones>(con, "API.PA_MenuPreparacionesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MenuPreparaciones  ->" + ex.Message);
				}
			}
			
			public List<MenuPreparaciones> GetAllByWithRelation()
			{
				try 
                {
                    List<MenuPreparaciones> l = SqlMapper.Query<MenuPreparaciones>(con, "API.PA_MenuPreparacionesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MenuPreparaciones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MenuPreparaciones> GetByFilter(MenuPreparaciones pMenuPreparaciones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMenuPreparaciones.id== null || pMenuPreparaciones.id==0) ? vintNUll :pMenuPreparaciones.id);
                    p.Add("@ID_Preparacion",(pMenuPreparaciones.ID_Preparacion== null || pMenuPreparaciones.ID_Preparacion==0) ? vintNUll :pMenuPreparaciones.ID_Preparacion);
                    p.Add("@ID_Menu",(pMenuPreparaciones.ID_Menu== null || pMenuPreparaciones.ID_Menu==0) ? vintNUll :pMenuPreparaciones.ID_Menu);
                    p.Add("@Nombre",(pMenuPreparaciones.Nombre== null) ? vintNUll :pMenuPreparaciones.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MenuPreparaciones> l = SqlMapper.Query<MenuPreparaciones>(con, "API.PA_MenuPreparacionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MenuPreparaciones  ->" + ex.Message);
				}
			}

			public MenuPreparaciones Add(MenuPreparaciones pMenuPreparaciones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMenuPreparaciones.id==null ? 0 : pMenuPreparaciones.id);
p.Add("@ID_Preparacion",pMenuPreparaciones.ID_Preparacion==null ? 0 : pMenuPreparaciones.ID_Preparacion);
p.Add("@ID_Menu",pMenuPreparaciones.ID_Menu==null ? 0 : pMenuPreparaciones.ID_Menu);
                    p.Add("@Nombre", pMenuPreparaciones.Nombre);
                    p.Add("@auditoria", pMenuPreparaciones.auditoria);

                         


                    MenuPreparaciones o = SqlMapper.QueryFirstOrDefault<MenuPreparaciones>(con, "API.PA_MenuPreparacionesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MenuPreparaciones  ->" + ex.Message);
				}
			}

			public MenuPreparaciones  Update(MenuPreparaciones pMenuPreparaciones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMenuPreparaciones.id==null ? 0 : pMenuPreparaciones.id);
p.Add("@ID_Preparacion",pMenuPreparaciones.ID_Preparacion==null ? 0 : pMenuPreparaciones.ID_Preparacion);
p.Add("@ID_Menu",pMenuPreparaciones.ID_Menu==null ? 0 : pMenuPreparaciones.ID_Menu);
                    p.Add("@Nombre", pMenuPreparaciones.Nombre);
                    p.Add("@auditoria", pMenuPreparaciones.auditoria);

                         


                    MenuPreparaciones o = SqlMapper.QueryFirstOrDefault<MenuPreparaciones>(con, "API.PA_MenuPreparacionesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MenuPreparaciones  ->" + ex.Message);
				}
			}

			public bool Delete(MenuPreparaciones pMenuPreparaciones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenuPreparaciones.id);
                    p.Add("@auditoria", pMenuPreparaciones.auditoria);

                

 

					MenuPreparaciones o = SqlMapper.QueryFirstOrDefault<MenuPreparaciones>(con, "API.PA_MenuPreparacionesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MenuPreparaciones  ->" + ex.Message);
				}
			}

		



            public List<MenuPreparaciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MenuPreparaciones> MenuPreparacionesList = new List<MenuPreparaciones>();

                    MenuPreparacionesList = SqlMapper.Query<MenuPreparaciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MenuPreparacionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MenuPreparaciones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MenuPreparaciones> b)
            {
                DapperPlusManager.Entity<MenuPreparaciones>().Table("MenuPreparaciones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}