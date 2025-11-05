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
     /// Clase Abstracta para  AspNetUserLogins
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AspNetUserLoginsRepository : DataObject , IAspNetUserLogins 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AspNetUserLoginsRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AspNetUserLoginsRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AspNetUserLogins GetById(AspNetUserLogins pAspNetUserLogins)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@LoginProvider",pAspNetUserLogins.LoginProvider);p.Add("@ProviderKey",pAspNetUserLogins.ProviderKey);                                    


    				AspNetUserLogins o = SqlMapper.QueryFirstOrDefault<AspNetUserLogins>(con, "API.PA_AspNetUserLoginsGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AspNetUserLogins  ->" + ex.Message);
				}
			}

			public List<AspNetUserLogins> GetAll()
			{
				try 
                {
                        List<AspNetUserLogins> l = SqlMapper.Query<AspNetUserLogins>(con, "API.PA_AspNetUserLoginsGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AspNetUserLogins  ->" + ex.Message);
				}
			}

			public List<AspNetUserLogins> GetAllFull()
			{
				try 
				{
                    List<AspNetUserLogins> l = SqlMapper.Query<AspNetUserLogins>(con, "API.PA_AspNetUserLoginsGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AspNetUserLogins  ->" + ex.Message);
				}
			}
			
			public List<AspNetUserLogins> GetAllByWithRelation()
			{
				try 
                {
                    List<AspNetUserLogins> l = SqlMapper.Query<AspNetUserLogins>(con, "API.PA_AspNetUserLoginsGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AspNetUserLogins  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AspNetUserLogins> GetByFilter(AspNetUserLogins pAspNetUserLogins, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@LoginProvider",(pAspNetUserLogins.LoginProvider== null) ? vintNUll :pAspNetUserLogins.LoginProvider);
                    p.Add("@ProviderKey",(pAspNetUserLogins.ProviderKey== null) ? vintNUll :pAspNetUserLogins.ProviderKey);
                    p.Add("@ProviderDisplayName",(pAspNetUserLogins.ProviderDisplayName== null) ? vintNUll :pAspNetUserLogins.ProviderDisplayName);
                    p.Add("@UserId",(pAspNetUserLogins.UserId== null) ? vintNUll :pAspNetUserLogins.UserId);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AspNetUserLogins> l = SqlMapper.Query<AspNetUserLogins>(con, "API.PA_AspNetUserLoginsGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AspNetUserLogins  ->" + ex.Message);
				}
			}

			public AspNetUserLogins Add(AspNetUserLogins pAspNetUserLogins)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					                    p.Add("@LoginProvider", pAspNetUserLogins.LoginProvider);
                    p.Add("@ProviderKey", pAspNetUserLogins.ProviderKey);
                    p.Add("@ProviderDisplayName", pAspNetUserLogins.ProviderDisplayName);
                    p.Add("@UserId", pAspNetUserLogins.UserId);                       


                    AspNetUserLogins o = SqlMapper.QueryFirstOrDefault<AspNetUserLogins>(con, "API.PA_AspNetUserLoginsAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AspNetUserLogins  ->" + ex.Message);
				}
			}

			public AspNetUserLogins  Update(AspNetUserLogins pAspNetUserLogins)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					                    p.Add("@LoginProvider", pAspNetUserLogins.LoginProvider);
                    p.Add("@ProviderKey", pAspNetUserLogins.ProviderKey);
                    p.Add("@ProviderDisplayName", pAspNetUserLogins.ProviderDisplayName);
                    p.Add("@UserId", pAspNetUserLogins.UserId);
 
                         


                    AspNetUserLogins o = SqlMapper.QueryFirstOrDefault<AspNetUserLogins>(con, "API.PA_AspNetUserLoginsUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AspNetUserLogins  ->" + ex.Message);
				}
			}

			public bool Delete(AspNetUserLogins pAspNetUserLogins)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@LoginProvider",pAspNetUserLogins.LoginProvider);
p.Add("@ProviderKey",pAspNetUserLogins.ProviderKey);

                

 

					AspNetUserLogins o = SqlMapper.QueryFirstOrDefault<AspNetUserLogins>(con, "API.PA_AspNetUserLoginsDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AspNetUserLogins  ->" + ex.Message);
				}
			}

		



            public List<AspNetUserLogins> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AspNetUserLogins> AspNetUserLoginsList = new List<AspNetUserLogins>();

                    AspNetUserLoginsList = SqlMapper.Query<AspNetUserLogins>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AspNetUserLoginsList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AspNetUserLogins  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AspNetUserLogins> b)
            {
                DapperPlusManager.Entity<AspNetUserLogins>().Table("AspNetUserLogins");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}