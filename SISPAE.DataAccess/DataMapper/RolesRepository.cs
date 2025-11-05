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
     /// Clase Abstracta para  Roles
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class RolesRepository : DataObject , IRoles 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public RolesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public RolesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Roles GetById(Roles pRoles)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pRoles.id);                                    


    				Roles o = SqlMapper.QueryFirstOrDefault<Roles>(con, "API.PA_RolesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Roles  ->" + ex.Message);
				}
			}

			public List<Roles> GetAll()
			{
				try 
                {
                        List<Roles> l = SqlMapper.Query<Roles>(con, "API.PA_RolesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Roles  ->" + ex.Message);
				}
			}

			public List<Roles> GetAllFull()
			{
				try 
				{
                    List<Roles> l = SqlMapper.Query<Roles>(con, "API.PA_RolesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Roles  ->" + ex.Message);
				}
			}
			
			public List<Roles> GetAllByWithRelation()
			{
				try 
                {
                    List<Roles> l = SqlMapper.Query<Roles>(con, "API.PA_RolesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Roles  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Roles> GetByFilter(Roles pRoles, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pRoles.id== null) ? vintNUll :pRoles.id);
                    p.Add("@Name",(pRoles.Name== null) ? vintNUll :pRoles.Name);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Roles> l = SqlMapper.Query<Roles>(con, "API.PA_RolesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Roles  ->" + ex.Message);
				}
			}

			public Roles Add(Roles pRoles)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					                    p.Add("@id", pRoles.id);
                    p.Add("@Name", pRoles.Name);
                    p.Add("@auditoria", pRoles.auditoria);

                         


                    Roles o = SqlMapper.QueryFirstOrDefault<Roles>(con, "API.PA_RolesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Roles  ->" + ex.Message);
				}
			}

			public Roles  Update(Roles pRoles)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					                    p.Add("@id", pRoles.id);
                    p.Add("@Name", pRoles.Name);
                    p.Add("@auditoria", pRoles.auditoria);

                         


                    Roles o = SqlMapper.QueryFirstOrDefault<Roles>(con, "API.PA_RolesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Roles  ->" + ex.Message);
				}
			}

			public bool Delete(Roles pRoles)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pRoles.id);
                    p.Add("@auditoria", pRoles.auditoria);

                

 

					Roles o = SqlMapper.QueryFirstOrDefault<Roles>(con, "API.PA_RolesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Roles  ->" + ex.Message);
				}
			}

		



            public List<Roles> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Roles> RolesList = new List<Roles>();

                    RolesList = SqlMapper.Query<Roles>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return RolesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Roles  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Roles> b)
            {
                DapperPlusManager.Entity<Roles>().Table("Roles");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}