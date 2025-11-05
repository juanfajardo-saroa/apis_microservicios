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
     /// Clase Abstracta para  PlanGiros
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PlanGirosRepository : DataObject , IPlanGiros 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PlanGirosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PlanGirosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public PlanGiros GetById(PlanGiros pPlanGiros)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pPlanGiros.id);                                    


    				PlanGiros o = SqlMapper.QueryFirstOrDefault<PlanGiros>(con, "API.PA_PlanGirosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  PlanGiros  ->" + ex.Message);
				}
			}

			public List<PlanGiros> GetAll()
			{
				try 
                {
                        List<PlanGiros> l = SqlMapper.Query<PlanGiros>(con, "API.PA_PlanGirosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  PlanGiros  ->" + ex.Message);
				}
			}

			public List<PlanGiros> GetAllFull()
			{
				try 
				{
                    List<PlanGiros> l = SqlMapper.Query<PlanGiros>(con, "API.PA_PlanGirosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  PlanGiros  ->" + ex.Message);
				}
			}
			
			public List<PlanGiros> GetAllByWithRelation()
			{
				try 
                {
                    List<PlanGiros> l = SqlMapper.Query<PlanGiros>(con, "API.PA_PlanGirosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  PlanGiros  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<PlanGiros> GetByFilter(PlanGiros pPlanGiros, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pPlanGiros.id== null || pPlanGiros.id==0) ? vintNUll :pPlanGiros.id);
                    p.Add("@ID_ETC",(pPlanGiros.ID_ETC== null || pPlanGiros.ID_ETC==0) ? vintNUll :pPlanGiros.ID_ETC);
                    p.Add("@Mes",(pPlanGiros.Mes== null) ? vintNUll :pPlanGiros.Mes);
                    p.Add("@GiroProyectado",(pPlanGiros.GiroProyectado== null) ? vintNUll :pPlanGiros.GiroProyectado);
                    p.Add("@GiroConfirmado",(pPlanGiros.GiroConfirmado== null) ? vintNUll :pPlanGiros.GiroConfirmado);
                    p.Add("@PATHSoporteGiro",(pPlanGiros.PATHSoporteGiro== null) ? vintNUll :pPlanGiros.PATHSoporteGiro);
                    p.Add("@idVigencia",(pPlanGiros.idVigencia== null || pPlanGiros.idVigencia==0) ? vintNUll :pPlanGiros.idVigencia);
                    p.Add("@FechaTransferencia",(pPlanGiros.FechaTransferencia== null) ? vintNUll :pPlanGiros.FechaTransferencia);
                    p.Add("@NumeroOrden",(pPlanGiros.NumeroOrden== null) ? vintNUll :pPlanGiros.NumeroOrden);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<PlanGiros> l = SqlMapper.Query<PlanGiros>(con, "API.PA_PlanGirosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  PlanGiros  ->" + ex.Message);
				}
			}

			public PlanGiros Add(PlanGiros pPlanGiros)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pPlanGiros.id==null ? 0 : pPlanGiros.id);
p.Add("@ID_ETC",pPlanGiros.ID_ETC==null ? 0 : pPlanGiros.ID_ETC);
p.Add("@Mes",pPlanGiros.Mes==null ? 0 : pPlanGiros.Mes);
                    p.Add("@GiroProyectado", pPlanGiros.GiroProyectado);
                    p.Add("@GiroConfirmado", pPlanGiros.GiroConfirmado);
                    p.Add("@PATHSoporteGiro", pPlanGiros.PATHSoporteGiro);
p.Add("@idVigencia",pPlanGiros.idVigencia== null ? 0: pPlanGiros.idVigencia);
                    p.Add("@FechaTransferencia", pPlanGiros.FechaTransferencia);
                    p.Add("@NumeroOrden", pPlanGiros.NumeroOrden);
                    p.Add("@auditoria", pPlanGiros.auditoria);

                         


                    PlanGiros o = SqlMapper.QueryFirstOrDefault<PlanGiros>(con, "API.PA_PlanGirosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  PlanGiros  ->" + ex.Message);
				}
			}

			public PlanGiros  Update(PlanGiros pPlanGiros)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pPlanGiros.id==null ? 0 : pPlanGiros.id);
p.Add("@ID_ETC",pPlanGiros.ID_ETC==null ? 0 : pPlanGiros.ID_ETC);
p.Add("@Mes",pPlanGiros.Mes==null ? 0 : pPlanGiros.Mes);
                    p.Add("@GiroProyectado", pPlanGiros.GiroProyectado);
                    p.Add("@GiroConfirmado", pPlanGiros.GiroConfirmado);
                    p.Add("@PATHSoporteGiro", pPlanGiros.PATHSoporteGiro);
p.Add("@idVigencia",pPlanGiros.idVigencia== null ? 0: pPlanGiros.idVigencia);
                    p.Add("@FechaTransferencia", pPlanGiros.FechaTransferencia);
                    p.Add("@NumeroOrden", pPlanGiros.NumeroOrden);
                    p.Add("@auditoria", pPlanGiros.auditoria);

                         


                    PlanGiros o = SqlMapper.QueryFirstOrDefault<PlanGiros>(con, "API.PA_PlanGirosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  PlanGiros  ->" + ex.Message);
				}
			}

			public bool Delete(PlanGiros pPlanGiros)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pPlanGiros.id);
                    p.Add("@auditoria", pPlanGiros.auditoria);

                

 

					PlanGiros o = SqlMapper.QueryFirstOrDefault<PlanGiros>(con, "API.PA_PlanGirosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) PlanGiros  ->" + ex.Message);
				}
			}

		



            public List<PlanGiros> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<PlanGiros> PlanGirosList = new List<PlanGiros>();

                    PlanGirosList = SqlMapper.Query<PlanGiros>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PlanGirosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) PlanGiros  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<PlanGiros> b)
            {
                DapperPlusManager.Entity<PlanGiros>().Table("PlanGiros");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}