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
     /// Clase Abstracta para  Users
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class UsersRepository : DataObject , IUsers 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public UsersRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public UsersRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Users GetById(Users pUsers)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pUsers.id);                                    


    				Users o = SqlMapper.QueryFirstOrDefault<Users>(con, "API.PA_UsersGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Users  ->" + ex.Message);
				}
			}

			public List<Users> GetAll()
			{
				try 
                {
                        List<Users> l = SqlMapper.Query<Users>(con, "API.PA_UsersGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Users  ->" + ex.Message);
				}
			}

			public List<Users> GetAllFull()
			{
				try 
				{
                    List<Users> l = SqlMapper.Query<Users>(con, "API.PA_UsersGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Users  ->" + ex.Message);
				}
			}
			
			public List<Users> GetAllByWithRelation()
			{
				try 
                {
                    List<Users> l = SqlMapper.Query<Users>(con, "API.PA_UsersGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Users  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Users> GetByFilter(Users pUsers, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pUsers.id== null) ? vintNUll :pUsers.id);
                    p.Add("@Email",(pUsers.Email== null) ? vintNUll :pUsers.Email);
                    p.Add("@Passwordhash",(pUsers.Passwordhash== null) ? vintNUll :pUsers.Passwordhash);
                    p.Add("@SegurityStamp",(pUsers.SegurityStamp== null) ? vintNUll :pUsers.SegurityStamp);
                    p.Add("@UserName",(pUsers.UserName== null) ? vintNUll :pUsers.UserName);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Users> l = SqlMapper.Query<Users>(con, "API.PA_UsersGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Users  ->" + ex.Message);
				}
			}

			public Users Add(Users pUsers)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					                    p.Add("@id", pUsers.id);
                    p.Add("@Email", pUsers.Email);
                    p.Add("@Passwordhash", pUsers.Passwordhash);
                    p.Add("@SegurityStamp", pUsers.SegurityStamp);
                    p.Add("@UserName", pUsers.UserName);
                    p.Add("@auditoria", pUsers.auditoria);

                         


                    Users o = SqlMapper.QueryFirstOrDefault<Users>(con, "API.PA_UsersAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Users  ->" + ex.Message);
				}
			}

			public Users  Update(Users pUsers)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					                    p.Add("@id", pUsers.id);
                    p.Add("@Email", pUsers.Email);
                    p.Add("@Passwordhash", pUsers.Passwordhash);
                    p.Add("@SegurityStamp", pUsers.SegurityStamp);
                    p.Add("@UserName", pUsers.UserName);
                    p.Add("@auditoria", pUsers.auditoria);

                         


                    Users o = SqlMapper.QueryFirstOrDefault<Users>(con, "API.PA_UsersUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Users  ->" + ex.Message);
				}
			}

			public bool Delete(Users pUsers)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pUsers.id);
                    p.Add("@auditoria", pUsers.auditoria);

                

 

					Users o = SqlMapper.QueryFirstOrDefault<Users>(con, "API.PA_UsersDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Users  ->" + ex.Message);
				}
			}

		



            public List<Users> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Users> UsersList = new List<Users>();

                    UsersList = SqlMapper.Query<Users>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return UsersList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Users  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Users> b)
            {
                DapperPlusManager.Entity<Users>().Table("Users");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}