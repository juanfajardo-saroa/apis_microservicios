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
     /// Clase Abstracta para  RolesConAcceso
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class RolesConAccesoRepository : DataObject , IRolesConAcceso 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public RolesConAccesoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public RolesConAccesoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public RolesConAcceso GetById(RolesConAcceso pRolesConAcceso)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pRolesConAcceso.id);                                    


    				RolesConAcceso o = SqlMapper.QueryFirstOrDefault<RolesConAcceso>(con, "API.PA_RolesConAccesoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  RolesConAcceso  ->" + ex.Message);
				}
			}

			public List<RolesConAcceso> GetAll()
			{
				try 
                {
                        List<RolesConAcceso> l = SqlMapper.Query<RolesConAcceso>(con, "API.PA_RolesConAccesoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  RolesConAcceso  ->" + ex.Message);
				}
			}

			public List<RolesConAcceso> GetAllFull()
			{
				try 
				{
                    List<RolesConAcceso> l = SqlMapper.Query<RolesConAcceso>(con, "API.PA_RolesConAccesoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  RolesConAcceso  ->" + ex.Message);
				}
			}
			
			public List<RolesConAcceso> GetAllByWithRelation()
			{
				try 
                {
                    List<RolesConAcceso> l = SqlMapper.Query<RolesConAcceso>(con, "API.PA_RolesConAccesoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  RolesConAcceso  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<RolesConAcceso> GetByFilter(RolesConAcceso pRolesConAcceso, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pRolesConAcceso.id== null || pRolesConAcceso.id==0) ? vintNUll :pRolesConAcceso.id);
                    p.Add("@ID_Repositorio",(pRolesConAcceso.ID_Repositorio== null || pRolesConAcceso.ID_Repositorio==0) ? vintNUll :pRolesConAcceso.ID_Repositorio);
                    p.Add("@ID_Rol",(pRolesConAcceso.ID_Rol== null) ? vintNUll :pRolesConAcceso.ID_Rol);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<RolesConAcceso> l = SqlMapper.Query<RolesConAcceso>(con, "API.PA_RolesConAccesoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  RolesConAcceso  ->" + ex.Message);
				}
			}

			public RolesConAcceso Add(RolesConAcceso pRolesConAcceso)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pRolesConAcceso.id==null ? 0 : pRolesConAcceso.id);
p.Add("@ID_Repositorio",pRolesConAcceso.ID_Repositorio==null ? 0 : pRolesConAcceso.ID_Repositorio);
                    p.Add("@ID_Rol", pRolesConAcceso.ID_Rol);
                    p.Add("@auditoria", pRolesConAcceso.auditoria);

                         


                    RolesConAcceso o = SqlMapper.QueryFirstOrDefault<RolesConAcceso>(con, "API.PA_RolesConAccesoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  RolesConAcceso  ->" + ex.Message);
				}
			}

			public RolesConAcceso  Update(RolesConAcceso pRolesConAcceso)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pRolesConAcceso.id==null ? 0 : pRolesConAcceso.id);
p.Add("@ID_Repositorio",pRolesConAcceso.ID_Repositorio==null ? 0 : pRolesConAcceso.ID_Repositorio);
                    p.Add("@ID_Rol", pRolesConAcceso.ID_Rol);
                    p.Add("@auditoria", pRolesConAcceso.auditoria);

                         


                    RolesConAcceso o = SqlMapper.QueryFirstOrDefault<RolesConAcceso>(con, "API.PA_RolesConAccesoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  RolesConAcceso  ->" + ex.Message);
				}
			}

			public bool Delete(RolesConAcceso pRolesConAcceso)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pRolesConAcceso.id);
                    p.Add("@auditoria", pRolesConAcceso.auditoria);

                

 

					RolesConAcceso o = SqlMapper.QueryFirstOrDefault<RolesConAcceso>(con, "API.PA_RolesConAccesoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) RolesConAcceso  ->" + ex.Message);
				}
			}

		



            public List<RolesConAcceso> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<RolesConAcceso> RolesConAccesoList = new List<RolesConAcceso>();

                    RolesConAccesoList = SqlMapper.Query<RolesConAcceso>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return RolesConAccesoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) RolesConAcceso  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<RolesConAcceso> b)
            {
                DapperPlusManager.Entity<RolesConAcceso>().Table("RolesConAcceso");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}