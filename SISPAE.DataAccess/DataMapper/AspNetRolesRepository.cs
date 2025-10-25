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
     /// Clase Abstracta para  AspNetRoles
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AspNetRolesRepository : DataObject , IAspNetRoles 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AspNetRolesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AspNetRolesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AspNetRoles GetById(AspNetRoles pAspNetRoles)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@Id",pAspNetRoles.Id);                                    


    				AspNetRoles o = SqlMapper.QueryFirstOrDefault<AspNetRoles>(con, "API.PA_AspNetRolesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AspNetRoles  ->" + ex.Message);
				}
			}

			public List<AspNetRoles> GetAll()
			{
				try 
                {
                        List<AspNetRoles> l = SqlMapper.Query<AspNetRoles>(con, "API.PA_AspNetRolesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AspNetRoles  ->" + ex.Message);
				}
			}

			public List<AspNetRoles> GetAllFull()
			{
				try 
				{
                    List<AspNetRoles> l = SqlMapper.Query<AspNetRoles>(con, "API.PA_AspNetRolesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AspNetRoles  ->" + ex.Message);
				}
			}
			
			public List<AspNetRoles> GetAllByWithRelation()
			{
				try 
                {
                    List<AspNetRoles> l = SqlMapper.Query<AspNetRoles>(con, "API.PA_AspNetRolesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AspNetRoles  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AspNetRoles> GetByFilter(AspNetRoles pAspNetRoles, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@Id",(pAspNetRoles.Id== null) ? vintNUll :pAspNetRoles.Id);
                    p.Add("@Name",(pAspNetRoles.Name== null) ? vintNUll :pAspNetRoles.Name);
                    p.Add("@NormalizedName",(pAspNetRoles.NormalizedName== null) ? vintNUll :pAspNetRoles.NormalizedName);
                    p.Add("@ConcurrencyStamp",(pAspNetRoles.ConcurrencyStamp== null) ? vintNUll :pAspNetRoles.ConcurrencyStamp);
                    p.Add("@id_TipoRoles",(pAspNetRoles.id_TipoRoles== null || pAspNetRoles.id_TipoRoles==0) ? vintNUll :pAspNetRoles.id_TipoRoles);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AspNetRoles> l = SqlMapper.Query<AspNetRoles>(con, "API.PA_AspNetRolesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AspNetRoles  ->" + ex.Message);
				}
			}

			public AspNetRoles Add(AspNetRoles pAspNetRoles)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					                    p.Add("@Id", pAspNetRoles.Id);
                    p.Add("@Name", pAspNetRoles.Name);
                    p.Add("@NormalizedName", pAspNetRoles.NormalizedName);
                    p.Add("@ConcurrencyStamp", pAspNetRoles.ConcurrencyStamp);
p.Add("@id_TipoRoles",pAspNetRoles.id_TipoRoles== null ? 0: pAspNetRoles.id_TipoRoles);
                    p.Add("@auditoria", pAspNetRoles.auditoria);

                         


                    AspNetRoles o = SqlMapper.QueryFirstOrDefault<AspNetRoles>(con, "API.PA_AspNetRolesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AspNetRoles  ->" + ex.Message);
				}
			}

			public AspNetRoles  Update(AspNetRoles pAspNetRoles)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					                    p.Add("@Id", pAspNetRoles.Id);
                    p.Add("@Name", pAspNetRoles.Name);
                    p.Add("@NormalizedName", pAspNetRoles.NormalizedName);
                    p.Add("@ConcurrencyStamp", pAspNetRoles.ConcurrencyStamp);
p.Add("@id_TipoRoles",pAspNetRoles.id_TipoRoles== null ? 0: pAspNetRoles.id_TipoRoles);
                    p.Add("@auditoria", pAspNetRoles.auditoria);

                         


                    AspNetRoles o = SqlMapper.QueryFirstOrDefault<AspNetRoles>(con, "API.PA_AspNetRolesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AspNetRoles  ->" + ex.Message);
				}
			}

			public bool Delete(AspNetRoles pAspNetRoles)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@Id",pAspNetRoles.Id);
                    p.Add("@auditoria", pAspNetRoles.auditoria);

                

 

					AspNetRoles o = SqlMapper.QueryFirstOrDefault<AspNetRoles>(con, "API.PA_AspNetRolesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AspNetRoles  ->" + ex.Message);
				}
			}

		



            public List<AspNetRoles> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AspNetRoles> AspNetRolesList = new List<AspNetRoles>();

                    AspNetRolesList = SqlMapper.Query<AspNetRoles>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AspNetRolesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AspNetRoles  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AspNetRoles> b)
            {
                DapperPlusManager.Entity<AspNetRoles>().Table("AspNetRoles");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}