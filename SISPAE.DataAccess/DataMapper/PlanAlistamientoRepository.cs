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
     /// Clase Abstracta para  PlanAlistamiento
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PlanAlistamientoRepository : DataObject , IPlanAlistamiento 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PlanAlistamientoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PlanAlistamientoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public PlanAlistamiento GetById(PlanAlistamiento pPlanAlistamiento)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@ID",pPlanAlistamiento.ID);                                    


    				PlanAlistamiento o = SqlMapper.QueryFirstOrDefault<PlanAlistamiento>(con, "API.PA_PlanAlistamientoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  PlanAlistamiento  ->" + ex.Message);
				}
			}

			public List<PlanAlistamiento> GetAll()
			{
				try 
                {
                        List<PlanAlistamiento> l = SqlMapper.Query<PlanAlistamiento>(con, "API.PA_PlanAlistamientoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  PlanAlistamiento  ->" + ex.Message);
				}
			}

			public List<PlanAlistamiento> GetAllFull()
			{
				try 
				{
                    List<PlanAlistamiento> l = SqlMapper.Query<PlanAlistamiento>(con, "API.PA_PlanAlistamientoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  PlanAlistamiento  ->" + ex.Message);
				}
			}
			
			public List<PlanAlistamiento> GetAllByWithRelation()
			{
				try 
                {
                    List<PlanAlistamiento> l = SqlMapper.Query<PlanAlistamiento>(con, "API.PA_PlanAlistamientoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  PlanAlistamiento  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<PlanAlistamiento> GetByFilter(PlanAlistamiento pPlanAlistamiento, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ID",(pPlanAlistamiento.ID== null || pPlanAlistamiento.ID==0) ? vintNUll :pPlanAlistamiento.ID);
                    p.Add("@Nombre",(pPlanAlistamiento.Nombre== null) ? vintNUll :pPlanAlistamiento.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<PlanAlistamiento> l = SqlMapper.Query<PlanAlistamiento>(con, "API.PA_PlanAlistamientoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  PlanAlistamiento  ->" + ex.Message);
				}
			}

			public PlanAlistamiento Add(PlanAlistamiento pPlanAlistamiento)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ID",pPlanAlistamiento.ID==null ? 0 : pPlanAlistamiento.ID);
                    p.Add("@Nombre", pPlanAlistamiento.Nombre);
                    p.Add("@auditoria", pPlanAlistamiento.auditoria);

                         


                    PlanAlistamiento o = SqlMapper.QueryFirstOrDefault<PlanAlistamiento>(con, "API.PA_PlanAlistamientoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  PlanAlistamiento  ->" + ex.Message);
				}
			}

			public PlanAlistamiento  Update(PlanAlistamiento pPlanAlistamiento)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ID",pPlanAlistamiento.ID==null ? 0 : pPlanAlistamiento.ID);
                    p.Add("@Nombre", pPlanAlistamiento.Nombre);
                    p.Add("@auditoria", pPlanAlistamiento.auditoria);

                         


                    PlanAlistamiento o = SqlMapper.QueryFirstOrDefault<PlanAlistamiento>(con, "API.PA_PlanAlistamientoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  PlanAlistamiento  ->" + ex.Message);
				}
			}

			public bool Delete(PlanAlistamiento pPlanAlistamiento)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@ID",pPlanAlistamiento.ID);
                    p.Add("@auditoria", pPlanAlistamiento.auditoria);

                

 

					PlanAlistamiento o = SqlMapper.QueryFirstOrDefault<PlanAlistamiento>(con, "API.PA_PlanAlistamientoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) PlanAlistamiento  ->" + ex.Message);
				}
			}

		



            public List<PlanAlistamiento> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<PlanAlistamiento> PlanAlistamientoList = new List<PlanAlistamiento>();

                    PlanAlistamientoList = SqlMapper.Query<PlanAlistamiento>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PlanAlistamientoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) PlanAlistamiento  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<PlanAlistamiento> b)
            {
                DapperPlusManager.Entity<PlanAlistamiento>().Table("PlanAlistamiento");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}