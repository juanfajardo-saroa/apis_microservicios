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
     /// Clase Abstracta para  PlanAnticipos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PlanAnticiposRepository : DataObject , IPlanAnticipos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PlanAnticiposRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PlanAnticiposRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public PlanAnticipos GetById(PlanAnticipos pPlanAnticipos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pPlanAnticipos.id);                                    


    				PlanAnticipos o = SqlMapper.QueryFirstOrDefault<PlanAnticipos>(con, "API.PA_PlanAnticiposGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  PlanAnticipos  ->" + ex.Message);
				}
			}

			public List<PlanAnticipos> GetAll()
			{
				try 
                {
                        List<PlanAnticipos> l = SqlMapper.Query<PlanAnticipos>(con, "API.PA_PlanAnticiposGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  PlanAnticipos  ->" + ex.Message);
				}
			}

			public List<PlanAnticipos> GetAllFull()
			{
				try 
				{
                    List<PlanAnticipos> l = SqlMapper.Query<PlanAnticipos>(con, "API.PA_PlanAnticiposGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  PlanAnticipos  ->" + ex.Message);
				}
			}
			
			public List<PlanAnticipos> GetAllByWithRelation()
			{
				try 
                {
                    List<PlanAnticipos> l = SqlMapper.Query<PlanAnticipos>(con, "API.PA_PlanAnticiposGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  PlanAnticipos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<PlanAnticipos> GetByFilter(PlanAnticipos pPlanAnticipos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pPlanAnticipos.id== null || pPlanAnticipos.id==0) ? vintNUll :pPlanAnticipos.id);
                    p.Add("@ID_AnticipoContrato",(pPlanAnticipos.ID_AnticipoContrato== null || pPlanAnticipos.ID_AnticipoContrato==0) ? vintNUll :pPlanAnticipos.ID_AnticipoContrato);
                    p.Add("@Periodo",(pPlanAnticipos.Periodo== null) ? vintNUll :pPlanAnticipos.Periodo);
                    p.Add("@Valor",(pPlanAnticipos.Valor== null) ? vintNUll :pPlanAnticipos.Valor);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<PlanAnticipos> l = SqlMapper.Query<PlanAnticipos>(con, "API.PA_PlanAnticiposGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  PlanAnticipos  ->" + ex.Message);
				}
			}

			public PlanAnticipos Add(PlanAnticipos pPlanAnticipos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pPlanAnticipos.id==null ? 0 : pPlanAnticipos.id);
p.Add("@ID_AnticipoContrato",pPlanAnticipos.ID_AnticipoContrato==null ? 0 : pPlanAnticipos.ID_AnticipoContrato);
                    p.Add("@Periodo", pPlanAnticipos.Periodo);
                    p.Add("@Valor", pPlanAnticipos.Valor);
                    p.Add("@auditoria", pPlanAnticipos.auditoria);

                         


                    PlanAnticipos o = SqlMapper.QueryFirstOrDefault<PlanAnticipos>(con, "API.PA_PlanAnticiposAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  PlanAnticipos  ->" + ex.Message);
				}
			}

			public PlanAnticipos  Update(PlanAnticipos pPlanAnticipos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pPlanAnticipos.id==null ? 0 : pPlanAnticipos.id);
p.Add("@ID_AnticipoContrato",pPlanAnticipos.ID_AnticipoContrato==null ? 0 : pPlanAnticipos.ID_AnticipoContrato);
                    p.Add("@Periodo", pPlanAnticipos.Periodo);
                    p.Add("@Valor", pPlanAnticipos.Valor);
                    p.Add("@auditoria", pPlanAnticipos.auditoria);

                         


                    PlanAnticipos o = SqlMapper.QueryFirstOrDefault<PlanAnticipos>(con, "API.PA_PlanAnticiposUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  PlanAnticipos  ->" + ex.Message);
				}
			}

			public bool Delete(PlanAnticipos pPlanAnticipos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pPlanAnticipos.id);
                    p.Add("@auditoria", pPlanAnticipos.auditoria);

                

 

					PlanAnticipos o = SqlMapper.QueryFirstOrDefault<PlanAnticipos>(con, "API.PA_PlanAnticiposDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) PlanAnticipos  ->" + ex.Message);
				}
			}

		



            public List<PlanAnticipos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<PlanAnticipos> PlanAnticiposList = new List<PlanAnticipos>();

                    PlanAnticiposList = SqlMapper.Query<PlanAnticipos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PlanAnticiposList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) PlanAnticipos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<PlanAnticipos> b)
            {
                DapperPlusManager.Entity<PlanAnticipos>().Table("PlanAnticipos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}