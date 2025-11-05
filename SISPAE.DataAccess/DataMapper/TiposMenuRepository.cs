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
     /// Clase Abstracta para  TiposMenu
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposMenuRepository : DataObject , ITiposMenu 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposMenuRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposMenuRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposMenu GetById(TiposMenu pTiposMenu)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposMenu.id);                                    


    				TiposMenu o = SqlMapper.QueryFirstOrDefault<TiposMenu>(con, "API.PA_TiposMenuGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposMenu  ->" + ex.Message);
				}
			}

			public List<TiposMenu> GetAll()
			{
				try 
                {
                        List<TiposMenu> l = SqlMapper.Query<TiposMenu>(con, "API.PA_TiposMenuGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposMenu  ->" + ex.Message);
				}
			}

			public List<TiposMenu> GetAllFull()
			{
				try 
				{
                    List<TiposMenu> l = SqlMapper.Query<TiposMenu>(con, "API.PA_TiposMenuGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposMenu  ->" + ex.Message);
				}
			}
			
			public List<TiposMenu> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposMenu> l = SqlMapper.Query<TiposMenu>(con, "API.PA_TiposMenuGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposMenu  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposMenu> GetByFilter(TiposMenu pTiposMenu, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposMenu.id== null || pTiposMenu.id==0) ? vintNUll :pTiposMenu.id);
                    p.Add("@Nombre",(pTiposMenu.Nombre== null) ? vintNUll :pTiposMenu.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposMenu> l = SqlMapper.Query<TiposMenu>(con, "API.PA_TiposMenuGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposMenu  ->" + ex.Message);
				}
			}

			public TiposMenu Add(TiposMenu pTiposMenu)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposMenu.id==null ? 0 : pTiposMenu.id);
                    p.Add("@Nombre", pTiposMenu.Nombre);
                    p.Add("@auditoria", pTiposMenu.auditoria);

                         


                    TiposMenu o = SqlMapper.QueryFirstOrDefault<TiposMenu>(con, "API.PA_TiposMenuAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposMenu  ->" + ex.Message);
				}
			}

			public TiposMenu  Update(TiposMenu pTiposMenu)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposMenu.id==null ? 0 : pTiposMenu.id);
                    p.Add("@Nombre", pTiposMenu.Nombre);
                    p.Add("@auditoria", pTiposMenu.auditoria);

                         


                    TiposMenu o = SqlMapper.QueryFirstOrDefault<TiposMenu>(con, "API.PA_TiposMenuUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposMenu  ->" + ex.Message);
				}
			}

			public bool Delete(TiposMenu pTiposMenu)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposMenu.id);
                    p.Add("@auditoria", pTiposMenu.auditoria);

                

 

					TiposMenu o = SqlMapper.QueryFirstOrDefault<TiposMenu>(con, "API.PA_TiposMenuDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposMenu  ->" + ex.Message);
				}
			}

		



            public List<TiposMenu> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposMenu> TiposMenuList = new List<TiposMenu>();

                    TiposMenuList = SqlMapper.Query<TiposMenu>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposMenuList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposMenu  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposMenu> b)
            {
                DapperPlusManager.Entity<TiposMenu>().Table("TiposMenu");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}