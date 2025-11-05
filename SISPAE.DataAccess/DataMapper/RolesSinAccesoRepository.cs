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
     /// Clase Abstracta para  RolesSinAcceso
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class RolesSinAccesoRepository : DataObject , IRolesSinAcceso 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public RolesSinAccesoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public RolesSinAccesoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public RolesSinAcceso GetById(RolesSinAcceso pRolesSinAcceso)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pRolesSinAcceso.id);                                    


    				RolesSinAcceso o = SqlMapper.QueryFirstOrDefault<RolesSinAcceso>(con, "API.PA_RolesSinAccesoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  RolesSinAcceso  ->" + ex.Message);
				}
			}

			public List<RolesSinAcceso> GetAll()
			{
				try 
                {
                        List<RolesSinAcceso> l = SqlMapper.Query<RolesSinAcceso>(con, "API.PA_RolesSinAccesoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  RolesSinAcceso  ->" + ex.Message);
				}
			}

			public List<RolesSinAcceso> GetAllFull()
			{
				try 
				{
                    List<RolesSinAcceso> l = SqlMapper.Query<RolesSinAcceso>(con, "API.PA_RolesSinAccesoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  RolesSinAcceso  ->" + ex.Message);
				}
			}
			
			public List<RolesSinAcceso> GetAllByWithRelation()
			{
				try 
                {
                    List<RolesSinAcceso> l = SqlMapper.Query<RolesSinAcceso>(con, "API.PA_RolesSinAccesoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  RolesSinAcceso  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<RolesSinAcceso> GetByFilter(RolesSinAcceso pRolesSinAcceso, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pRolesSinAcceso.id== null || pRolesSinAcceso.id==0) ? vintNUll :pRolesSinAcceso.id);
                    p.Add("@ID_Repositorio",(pRolesSinAcceso.ID_Repositorio== null || pRolesSinAcceso.ID_Repositorio==0) ? vintNUll :pRolesSinAcceso.ID_Repositorio);
                    p.Add("@ID_Rol",(pRolesSinAcceso.ID_Rol== null) ? vintNUll :pRolesSinAcceso.ID_Rol);
                    p.Add("@ID_Usuario",(pRolesSinAcceso.ID_Usuario== null) ? vintNUll :pRolesSinAcceso.ID_Usuario);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<RolesSinAcceso> l = SqlMapper.Query<RolesSinAcceso>(con, "API.PA_RolesSinAccesoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  RolesSinAcceso  ->" + ex.Message);
				}
			}

			public RolesSinAcceso Add(RolesSinAcceso pRolesSinAcceso)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pRolesSinAcceso.id==null ? 0 : pRolesSinAcceso.id);
p.Add("@ID_Repositorio",pRolesSinAcceso.ID_Repositorio==null ? 0 : pRolesSinAcceso.ID_Repositorio);
                    p.Add("@ID_Rol", pRolesSinAcceso.ID_Rol);
                    p.Add("@ID_Usuario", pRolesSinAcceso.ID_Usuario);
                    p.Add("@auditoria", pRolesSinAcceso.auditoria);

                         


                    RolesSinAcceso o = SqlMapper.QueryFirstOrDefault<RolesSinAcceso>(con, "API.PA_RolesSinAccesoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  RolesSinAcceso  ->" + ex.Message);
				}
			}

			public RolesSinAcceso  Update(RolesSinAcceso pRolesSinAcceso)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pRolesSinAcceso.id==null ? 0 : pRolesSinAcceso.id);
p.Add("@ID_Repositorio",pRolesSinAcceso.ID_Repositorio==null ? 0 : pRolesSinAcceso.ID_Repositorio);
                    p.Add("@ID_Rol", pRolesSinAcceso.ID_Rol);
                    p.Add("@ID_Usuario", pRolesSinAcceso.ID_Usuario);
                    p.Add("@auditoria", pRolesSinAcceso.auditoria);

                         


                    RolesSinAcceso o = SqlMapper.QueryFirstOrDefault<RolesSinAcceso>(con, "API.PA_RolesSinAccesoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  RolesSinAcceso  ->" + ex.Message);
				}
			}

			public bool Delete(RolesSinAcceso pRolesSinAcceso)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pRolesSinAcceso.id);
                    p.Add("@auditoria", pRolesSinAcceso.auditoria);

                

 

					RolesSinAcceso o = SqlMapper.QueryFirstOrDefault<RolesSinAcceso>(con, "API.PA_RolesSinAccesoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) RolesSinAcceso  ->" + ex.Message);
				}
			}

		



            public List<RolesSinAcceso> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<RolesSinAcceso> RolesSinAccesoList = new List<RolesSinAcceso>();

                    RolesSinAccesoList = SqlMapper.Query<RolesSinAcceso>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return RolesSinAccesoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) RolesSinAcceso  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<RolesSinAcceso> b)
            {
                DapperPlusManager.Entity<RolesSinAcceso>().Table("RolesSinAcceso");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}