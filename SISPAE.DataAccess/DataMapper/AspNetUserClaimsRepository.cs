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
     /// Clase Abstracta para  AspNetUserClaims
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AspNetUserClaimsRepository : DataObject , IAspNetUserClaims 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AspNetUserClaimsRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AspNetUserClaimsRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AspNetUserClaims GetById(AspNetUserClaims pAspNetUserClaims)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@Id",pAspNetUserClaims.Id);                                    


    				AspNetUserClaims o = SqlMapper.QueryFirstOrDefault<AspNetUserClaims>(con, "API.PA_AspNetUserClaimsGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AspNetUserClaims  ->" + ex.Message);
				}
			}

			public List<AspNetUserClaims> GetAll()
			{
				try 
                {
                        List<AspNetUserClaims> l = SqlMapper.Query<AspNetUserClaims>(con, "API.PA_AspNetUserClaimsGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AspNetUserClaims  ->" + ex.Message);
				}
			}

			public List<AspNetUserClaims> GetAllFull()
			{
				try 
				{
                    List<AspNetUserClaims> l = SqlMapper.Query<AspNetUserClaims>(con, "API.PA_AspNetUserClaimsGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AspNetUserClaims  ->" + ex.Message);
				}
			}
			
			public List<AspNetUserClaims> GetAllByWithRelation()
			{
				try 
                {
                    List<AspNetUserClaims> l = SqlMapper.Query<AspNetUserClaims>(con, "API.PA_AspNetUserClaimsGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AspNetUserClaims  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AspNetUserClaims> GetByFilter(AspNetUserClaims pAspNetUserClaims, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@Id",(pAspNetUserClaims.Id== null || pAspNetUserClaims.Id==0) ? vintNUll :pAspNetUserClaims.Id);
                    p.Add("@UserId",(pAspNetUserClaims.UserId== null) ? vintNUll :pAspNetUserClaims.UserId);
                    p.Add("@ClaimType",(pAspNetUserClaims.ClaimType== null) ? vintNUll :pAspNetUserClaims.ClaimType);
                    p.Add("@ClaimValue",(pAspNetUserClaims.ClaimValue== null) ? vintNUll :pAspNetUserClaims.ClaimValue);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AspNetUserClaims> l = SqlMapper.Query<AspNetUserClaims>(con, "API.PA_AspNetUserClaimsGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AspNetUserClaims  ->" + ex.Message);
				}
			}

			public AspNetUserClaims Add(AspNetUserClaims pAspNetUserClaims)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@Id",pAspNetUserClaims.Id==null ? 0 : pAspNetUserClaims.Id);
                    p.Add("@UserId", pAspNetUserClaims.UserId);
                    p.Add("@ClaimType", pAspNetUserClaims.ClaimType);
                    p.Add("@ClaimValue", pAspNetUserClaims.ClaimValue);
                        


                    AspNetUserClaims o = SqlMapper.QueryFirstOrDefault<AspNetUserClaims>(con, "API.PA_AspNetUserClaimsAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AspNetUserClaims  ->" + ex.Message);
				}
			}

			public AspNetUserClaims  Update(AspNetUserClaims pAspNetUserClaims)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@Id",pAspNetUserClaims.Id==null ? 0 : pAspNetUserClaims.Id);
                    p.Add("@UserId", pAspNetUserClaims.UserId);
                    p.Add("@ClaimType", pAspNetUserClaims.ClaimType);
                    p.Add("@ClaimValue", pAspNetUserClaims.ClaimValue);
   
                         


                    AspNetUserClaims o = SqlMapper.QueryFirstOrDefault<AspNetUserClaims>(con, "API.PA_AspNetUserClaimsUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AspNetUserClaims  ->" + ex.Message);
				}
			}

			public bool Delete(AspNetUserClaims pAspNetUserClaims)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@Id",pAspNetUserClaims.Id);
                

 

					AspNetUserClaims o = SqlMapper.QueryFirstOrDefault<AspNetUserClaims>(con, "API.PA_AspNetUserClaimsDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AspNetUserClaims  ->" + ex.Message);
				}
			}

		



            public List<AspNetUserClaims> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AspNetUserClaims> AspNetUserClaimsList = new List<AspNetUserClaims>();

                    AspNetUserClaimsList = SqlMapper.Query<AspNetUserClaims>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AspNetUserClaimsList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AspNetUserClaims  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AspNetUserClaims> b)
            {
                DapperPlusManager.Entity<AspNetUserClaims>().Table("AspNetUserClaims");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}