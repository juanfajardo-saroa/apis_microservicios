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
     /// Clase Abstracta para  AprobacionPriorizaciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AprobacionPriorizacionesRepository : DataObject , IAprobacionPriorizaciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AprobacionPriorizacionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AprobacionPriorizacionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AprobacionPriorizaciones GetById(AprobacionPriorizaciones pAprobacionPriorizaciones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAprobacionPriorizaciones.id);                                    


    				AprobacionPriorizaciones o = SqlMapper.QueryFirstOrDefault<AprobacionPriorizaciones>(con, "API.PA_AprobacionPriorizacionesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AprobacionPriorizaciones  ->" + ex.Message);
				}
			}

			public List<AprobacionPriorizaciones> GetAll()
			{
				try 
                {
                        List<AprobacionPriorizaciones> l = SqlMapper.Query<AprobacionPriorizaciones>(con, "API.PA_AprobacionPriorizacionesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AprobacionPriorizaciones  ->" + ex.Message);
				}
			}

			public List<AprobacionPriorizaciones> GetAllFull()
			{
				try 
				{
                    List<AprobacionPriorizaciones> l = SqlMapper.Query<AprobacionPriorizaciones>(con, "API.PA_AprobacionPriorizacionesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AprobacionPriorizaciones  ->" + ex.Message);
				}
			}
			
			public List<AprobacionPriorizaciones> GetAllByWithRelation()
			{
				try 
                {
                    List<AprobacionPriorizaciones> l = SqlMapper.Query<AprobacionPriorizaciones>(con, "API.PA_AprobacionPriorizacionesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AprobacionPriorizaciones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AprobacionPriorizaciones> GetByFilter(AprobacionPriorizaciones pAprobacionPriorizaciones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAprobacionPriorizaciones.id== null || pAprobacionPriorizaciones.id==0) ? vintNUll :pAprobacionPriorizaciones.id);
                    p.Add("@ID_Aprobacion",(pAprobacionPriorizaciones.ID_Aprobacion== null || pAprobacionPriorizaciones.ID_Aprobacion==0) ? vintNUll :pAprobacionPriorizaciones.ID_Aprobacion);
                    p.Add("@ID_Priorizacion",(pAprobacionPriorizaciones.ID_Priorizacion== null || pAprobacionPriorizaciones.ID_Priorizacion==0) ? vintNUll :pAprobacionPriorizaciones.ID_Priorizacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AprobacionPriorizaciones> l = SqlMapper.Query<AprobacionPriorizaciones>(con, "API.PA_AprobacionPriorizacionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AprobacionPriorizaciones  ->" + ex.Message);
				}
			}

			public AprobacionPriorizaciones Add(AprobacionPriorizaciones pAprobacionPriorizaciones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAprobacionPriorizaciones.id==null ? 0 : pAprobacionPriorizaciones.id);
p.Add("@ID_Aprobacion",pAprobacionPriorizaciones.ID_Aprobacion==null ? 0 : pAprobacionPriorizaciones.ID_Aprobacion);
p.Add("@ID_Priorizacion",pAprobacionPriorizaciones.ID_Priorizacion==null ? 0 : pAprobacionPriorizaciones.ID_Priorizacion);
                    p.Add("@auditoria", pAprobacionPriorizaciones.auditoria);

                         


                    AprobacionPriorizaciones o = SqlMapper.QueryFirstOrDefault<AprobacionPriorizaciones>(con, "API.PA_AprobacionPriorizacionesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AprobacionPriorizaciones  ->" + ex.Message);
				}
			}

			public AprobacionPriorizaciones  Update(AprobacionPriorizaciones pAprobacionPriorizaciones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAprobacionPriorizaciones.id==null ? 0 : pAprobacionPriorizaciones.id);
p.Add("@ID_Aprobacion",pAprobacionPriorizaciones.ID_Aprobacion==null ? 0 : pAprobacionPriorizaciones.ID_Aprobacion);
p.Add("@ID_Priorizacion",pAprobacionPriorizaciones.ID_Priorizacion==null ? 0 : pAprobacionPriorizaciones.ID_Priorizacion);
                    p.Add("@auditoria", pAprobacionPriorizaciones.auditoria);

                         


                    AprobacionPriorizaciones o = SqlMapper.QueryFirstOrDefault<AprobacionPriorizaciones>(con, "API.PA_AprobacionPriorizacionesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AprobacionPriorizaciones  ->" + ex.Message);
				}
			}

			public bool Delete(AprobacionPriorizaciones pAprobacionPriorizaciones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAprobacionPriorizaciones.id);
                    p.Add("@auditoria", pAprobacionPriorizaciones.auditoria);

                

 

					AprobacionPriorizaciones o = SqlMapper.QueryFirstOrDefault<AprobacionPriorizaciones>(con, "API.PA_AprobacionPriorizacionesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AprobacionPriorizaciones  ->" + ex.Message);
				}
			}

		



            public List<AprobacionPriorizaciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AprobacionPriorizaciones> AprobacionPriorizacionesList = new List<AprobacionPriorizaciones>();

                    AprobacionPriorizacionesList = SqlMapper.Query<AprobacionPriorizaciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AprobacionPriorizacionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AprobacionPriorizaciones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AprobacionPriorizaciones> b)
            {
                DapperPlusManager.Entity<AprobacionPriorizaciones>().Table("AprobacionPriorizaciones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}