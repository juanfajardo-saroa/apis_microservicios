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
     /// Clase Abstracta para  AspNetUserTokens
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AspNetUserTokensRepository : DataObject , IAspNetUserTokens 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AspNetUserTokensRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AspNetUserTokensRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AspNetUserTokens GetById(AspNetUserTokens pAspNetUserTokens)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@LoginProvider",pAspNetUserTokens.LoginProvider);p.Add("@Name",pAspNetUserTokens.Name);p.Add("@UserId",pAspNetUserTokens.UserId);                                    


    				AspNetUserTokens o = SqlMapper.QueryFirstOrDefault<AspNetUserTokens>(con, "API.PA_AspNetUserTokensGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AspNetUserTokens  ->" + ex.Message);
				}
			}

			public List<AspNetUserTokens> GetAll()
			{
				try 
                {
                        List<AspNetUserTokens> l = SqlMapper.Query<AspNetUserTokens>(con, "API.PA_AspNetUserTokensGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AspNetUserTokens  ->" + ex.Message);
				}
			}

			public List<AspNetUserTokens> GetAllFull()
			{
				try 
				{
                    List<AspNetUserTokens> l = SqlMapper.Query<AspNetUserTokens>(con, "API.PA_AspNetUserTokensGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AspNetUserTokens  ->" + ex.Message);
				}
			}
			
			public List<AspNetUserTokens> GetAllByWithRelation()
			{
				try 
                {
                    List<AspNetUserTokens> l = SqlMapper.Query<AspNetUserTokens>(con, "API.PA_AspNetUserTokensGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AspNetUserTokens  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AspNetUserTokens> GetByFilter(AspNetUserTokens pAspNetUserTokens, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@UserId",(pAspNetUserTokens.UserId== null) ? vintNUll :pAspNetUserTokens.UserId);
                    p.Add("@LoginProvider",(pAspNetUserTokens.LoginProvider== null) ? vintNUll :pAspNetUserTokens.LoginProvider);
                    p.Add("@Name",(pAspNetUserTokens.Name== null) ? vintNUll :pAspNetUserTokens.Name);
                    p.Add("@Value",(pAspNetUserTokens.Value== null) ? vintNUll :pAspNetUserTokens.Value);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AspNetUserTokens> l = SqlMapper.Query<AspNetUserTokens>(con, "API.PA_AspNetUserTokensGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AspNetUserTokens  ->" + ex.Message);
				}
			}

			public AspNetUserTokens Add(AspNetUserTokens pAspNetUserTokens)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					                    p.Add("@UserId", pAspNetUserTokens.UserId);
                    p.Add("@LoginProvider", pAspNetUserTokens.LoginProvider);
                    p.Add("@Name", pAspNetUserTokens.Name);
                    p.Add("@Value", pAspNetUserTokens.Value);
                         


                    AspNetUserTokens o = SqlMapper.QueryFirstOrDefault<AspNetUserTokens>(con, "API.PA_AspNetUserTokensAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AspNetUserTokens  ->" + ex.Message);
				}
			}

			public AspNetUserTokens  Update(AspNetUserTokens pAspNetUserTokens)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					                    p.Add("@UserId", pAspNetUserTokens.UserId);
                    p.Add("@LoginProvider", pAspNetUserTokens.LoginProvider);
                    p.Add("@Name", pAspNetUserTokens.Name);
                    p.Add("@Value", pAspNetUserTokens.Value);
                        


                    AspNetUserTokens o = SqlMapper.QueryFirstOrDefault<AspNetUserTokens>(con, "API.PA_AspNetUserTokensUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AspNetUserTokens  ->" + ex.Message);
				}
			}

			public bool Delete(AspNetUserTokens pAspNetUserTokens)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@LoginProvider",pAspNetUserTokens.LoginProvider);
p.Add("@Name",pAspNetUserTokens.Name);
p.Add("@UserId",pAspNetUserTokens.UserId);

                

 

					AspNetUserTokens o = SqlMapper.QueryFirstOrDefault<AspNetUserTokens>(con, "API.PA_AspNetUserTokensDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AspNetUserTokens  ->" + ex.Message);
				}
			}

		



            public List<AspNetUserTokens> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AspNetUserTokens> AspNetUserTokensList = new List<AspNetUserTokens>();

                    AspNetUserTokensList = SqlMapper.Query<AspNetUserTokens>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AspNetUserTokensList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AspNetUserTokens  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AspNetUserTokens> b)
            {
                DapperPlusManager.Entity<AspNetUserTokens>().Table("AspNetUserTokens");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}