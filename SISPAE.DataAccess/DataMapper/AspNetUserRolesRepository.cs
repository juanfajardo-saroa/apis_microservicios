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
     /// Clase Abstracta para  AspNetUserRoles
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AspNetUserRolesRepository : DataObject , IAspNetUserRoles 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AspNetUserRolesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AspNetUserRolesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AspNetUserRoles GetById(AspNetUserRoles pAspNetUserRoles)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAspNetUserRoles.id);                                    


    				AspNetUserRoles o = SqlMapper.QueryFirstOrDefault<AspNetUserRoles>(con, "API.PA_AspNetUserRolesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AspNetUserRoles  ->" + ex.Message);
				}
			}

			public List<AspNetUserRoles> GetAll()
			{
				try 
                {
                        List<AspNetUserRoles> l = SqlMapper.Query<AspNetUserRoles>(con, "API.PA_AspNetUserRolesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AspNetUserRoles  ->" + ex.Message);
				}
			}

			public List<AspNetUserRoles> GetAllFull()
			{
				try 
				{
                    List<AspNetUserRoles> l = SqlMapper.Query<AspNetUserRoles>(con, "API.PA_AspNetUserRolesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AspNetUserRoles  ->" + ex.Message);
				}
			}
			
			public List<AspNetUserRoles> GetAllByWithRelation()
			{
				try 
                {
                    List<AspNetUserRoles> l = SqlMapper.Query<AspNetUserRoles>(con, "API.PA_AspNetUserRolesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AspNetUserRoles  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AspNetUserRoles> GetByFilter(AspNetUserRoles pAspNetUserRoles, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAspNetUserRoles.id== null || pAspNetUserRoles.id==0) ? vintNUll :pAspNetUserRoles.id);
                    p.Add("@UserId",(pAspNetUserRoles.UserId== null) ? vintNUll :pAspNetUserRoles.UserId);
                    p.Add("@RoleId",(pAspNetUserRoles.RoleId== null) ? vintNUll :pAspNetUserRoles.RoleId);
                    p.Add("@FechaCaducidad",(pAspNetUserRoles.FechaCaducidad== null) ? vintNUll :pAspNetUserRoles.FechaCaducidad);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AspNetUserRoles> l = SqlMapper.Query<AspNetUserRoles>(con, "API.PA_AspNetUserRolesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AspNetUserRoles  ->" + ex.Message);
				}
			}

			public AspNetUserRoles Add(AspNetUserRoles pAspNetUserRoles)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAspNetUserRoles.id==null ? 0 : pAspNetUserRoles.id);
                    p.Add("@UserId", pAspNetUserRoles.UserId);
                    p.Add("@RoleId", pAspNetUserRoles.RoleId);
                    p.Add("@FechaCaducidad", pAspNetUserRoles.FechaCaducidad);
                    p.Add("@auditoria", pAspNetUserRoles.auditoria);

                         


                    AspNetUserRoles o = SqlMapper.QueryFirstOrDefault<AspNetUserRoles>(con, "API.PA_AspNetUserRolesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AspNetUserRoles  ->" + ex.Message);
				}
			}

			public AspNetUserRoles  Update(AspNetUserRoles pAspNetUserRoles)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAspNetUserRoles.id==null ? 0 : pAspNetUserRoles.id);
                    p.Add("@UserId", pAspNetUserRoles.UserId);
                    p.Add("@RoleId", pAspNetUserRoles.RoleId);
                    p.Add("@FechaCaducidad", pAspNetUserRoles.FechaCaducidad);
                    p.Add("@auditoria", pAspNetUserRoles.auditoria);

                         


                    AspNetUserRoles o = SqlMapper.QueryFirstOrDefault<AspNetUserRoles>(con, "API.PA_AspNetUserRolesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AspNetUserRoles  ->" + ex.Message);
				}
			}

			public bool Delete(AspNetUserRoles pAspNetUserRoles)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAspNetUserRoles.id);
                    p.Add("@auditoria", pAspNetUserRoles.auditoria);

                

 

					AspNetUserRoles o = SqlMapper.QueryFirstOrDefault<AspNetUserRoles>(con, "API.PA_AspNetUserRolesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AspNetUserRoles  ->" + ex.Message);
				}
			}

		



            public List<AspNetUserRoles> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AspNetUserRoles> AspNetUserRolesList = new List<AspNetUserRoles>();

                    AspNetUserRolesList = SqlMapper.Query<AspNetUserRoles>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AspNetUserRolesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AspNetUserRoles  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AspNetUserRoles> b)
            {
                DapperPlusManager.Entity<AspNetUserRoles>().Table("AspNetUserRoles");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}