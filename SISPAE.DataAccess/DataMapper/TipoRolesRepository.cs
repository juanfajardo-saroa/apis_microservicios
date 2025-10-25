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
     /// Clase Abstracta para  TipoRoles
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoRolesRepository : DataObject , ITipoRoles 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoRolesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoRolesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoRoles GetById(TipoRoles pTipoRoles)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoRoles.id);                                    


    				TipoRoles o = SqlMapper.QueryFirstOrDefault<TipoRoles>(con, "API.PA_TipoRolesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoRoles  ->" + ex.Message);
				}
			}

			public List<TipoRoles> GetAll()
			{
				try 
                {
                        List<TipoRoles> l = SqlMapper.Query<TipoRoles>(con, "API.PA_TipoRolesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoRoles  ->" + ex.Message);
				}
			}

			public List<TipoRoles> GetAllFull()
			{
				try 
				{
                    List<TipoRoles> l = SqlMapper.Query<TipoRoles>(con, "API.PA_TipoRolesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoRoles  ->" + ex.Message);
				}
			}
			
			public List<TipoRoles> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoRoles> l = SqlMapper.Query<TipoRoles>(con, "API.PA_TipoRolesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoRoles  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoRoles> GetByFilter(TipoRoles pTipoRoles, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoRoles.id== null || pTipoRoles.id==0) ? vintNUll :pTipoRoles.id);
                    p.Add("@Nombre",(pTipoRoles.Nombre== null) ? vintNUll :pTipoRoles.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoRoles> l = SqlMapper.Query<TipoRoles>(con, "API.PA_TipoRolesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoRoles  ->" + ex.Message);
				}
			}

			public TipoRoles Add(TipoRoles pTipoRoles)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoRoles.id==null ? 0 : pTipoRoles.id);
                    p.Add("@Nombre", pTipoRoles.Nombre);
                    p.Add("@auditoria", pTipoRoles.auditoria);

                         


                    TipoRoles o = SqlMapper.QueryFirstOrDefault<TipoRoles>(con, "API.PA_TipoRolesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoRoles  ->" + ex.Message);
				}
			}

			public TipoRoles  Update(TipoRoles pTipoRoles)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoRoles.id==null ? 0 : pTipoRoles.id);
                    p.Add("@Nombre", pTipoRoles.Nombre);
                    p.Add("@auditoria", pTipoRoles.auditoria);

                         


                    TipoRoles o = SqlMapper.QueryFirstOrDefault<TipoRoles>(con, "API.PA_TipoRolesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoRoles  ->" + ex.Message);
				}
			}

			public bool Delete(TipoRoles pTipoRoles)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoRoles.id);
                    p.Add("@auditoria", pTipoRoles.auditoria);

                

 

					TipoRoles o = SqlMapper.QueryFirstOrDefault<TipoRoles>(con, "API.PA_TipoRolesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoRoles  ->" + ex.Message);
				}
			}

		



            public List<TipoRoles> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoRoles> TipoRolesList = new List<TipoRoles>();

                    TipoRolesList = SqlMapper.Query<TipoRoles>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoRolesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoRoles  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoRoles> b)
            {
                DapperPlusManager.Entity<TipoRoles>().Table("TipoRoles");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}