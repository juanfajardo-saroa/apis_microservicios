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
     /// Clase Abstracta para  ConsolidadoErroresCargue
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ConsolidadoErroresCargueRepository : DataObject , IConsolidadoErroresCargue 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ConsolidadoErroresCargueRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ConsolidadoErroresCargueRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ConsolidadoErroresCargue GetById(ConsolidadoErroresCargue pConsolidadoErroresCargue)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pConsolidadoErroresCargue.id);                                    


    				ConsolidadoErroresCargue o = SqlMapper.QueryFirstOrDefault<ConsolidadoErroresCargue>(con, "API.PA_ConsolidadoErroresCargueGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ConsolidadoErroresCargue  ->" + ex.Message);
				}
			}

			public List<ConsolidadoErroresCargue> GetAll()
			{
				try 
                {
                        List<ConsolidadoErroresCargue> l = SqlMapper.Query<ConsolidadoErroresCargue>(con, "API.PA_ConsolidadoErroresCargueGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ConsolidadoErroresCargue  ->" + ex.Message);
				}
			}

			public List<ConsolidadoErroresCargue> GetAllFull()
			{
				try 
				{
                    List<ConsolidadoErroresCargue> l = SqlMapper.Query<ConsolidadoErroresCargue>(con, "API.PA_ConsolidadoErroresCargueGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ConsolidadoErroresCargue  ->" + ex.Message);
				}
			}
			
			public List<ConsolidadoErroresCargue> GetAllByWithRelation()
			{
				try 
                {
                    List<ConsolidadoErroresCargue> l = SqlMapper.Query<ConsolidadoErroresCargue>(con, "API.PA_ConsolidadoErroresCargueGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ConsolidadoErroresCargue  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ConsolidadoErroresCargue> GetByFilter(ConsolidadoErroresCargue pConsolidadoErroresCargue, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pConsolidadoErroresCargue.id== null || pConsolidadoErroresCargue.id==0) ? vintNUll :pConsolidadoErroresCargue.id);
                    p.Add("@ID_ProcesoCargue",(pConsolidadoErroresCargue.ID_ProcesoCargue== null || pConsolidadoErroresCargue.ID_ProcesoCargue==0) ? vintNUll :pConsolidadoErroresCargue.ID_ProcesoCargue);
                    p.Add("@TipoProcesoCargue",(pConsolidadoErroresCargue.TipoProcesoCargue== null) ? vintNUll :pConsolidadoErroresCargue.TipoProcesoCargue);
                    p.Add("@ID_TipoErrorCargue",(pConsolidadoErroresCargue.ID_TipoErrorCargue== null || pConsolidadoErroresCargue.ID_TipoErrorCargue==0) ? vintNUll :pConsolidadoErroresCargue.ID_TipoErrorCargue);
                    p.Add("@NombreError",(pConsolidadoErroresCargue.NombreError== null) ? vintNUll :pConsolidadoErroresCargue.NombreError);
                    p.Add("@NombreArchivoProcesado",(pConsolidadoErroresCargue.NombreArchivoProcesado== null) ? vintNUll :pConsolidadoErroresCargue.NombreArchivoProcesado);
                    p.Add("@TotalErrores",(pConsolidadoErroresCargue.TotalErrores== null) ? vintNUll :pConsolidadoErroresCargue.TotalErrores);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ConsolidadoErroresCargue> l = SqlMapper.Query<ConsolidadoErroresCargue>(con, "API.PA_ConsolidadoErroresCargueGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ConsolidadoErroresCargue  ->" + ex.Message);
				}
			}

			public ConsolidadoErroresCargue Add(ConsolidadoErroresCargue pConsolidadoErroresCargue)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pConsolidadoErroresCargue.id==null ? 0 : pConsolidadoErroresCargue.id);
p.Add("@ID_ProcesoCargue",pConsolidadoErroresCargue.ID_ProcesoCargue==null ? 0 : pConsolidadoErroresCargue.ID_ProcesoCargue);
                    p.Add("@TipoProcesoCargue", pConsolidadoErroresCargue.TipoProcesoCargue);
p.Add("@ID_TipoErrorCargue",pConsolidadoErroresCargue.ID_TipoErrorCargue==null ? 0 : pConsolidadoErroresCargue.ID_TipoErrorCargue);
                    p.Add("@NombreError", pConsolidadoErroresCargue.NombreError);
                    p.Add("@NombreArchivoProcesado", pConsolidadoErroresCargue.NombreArchivoProcesado);
                    p.Add("@TotalErrores", pConsolidadoErroresCargue.TotalErrores);
                    p.Add("@auditoria", pConsolidadoErroresCargue.auditoria);

                         


                    ConsolidadoErroresCargue o = SqlMapper.QueryFirstOrDefault<ConsolidadoErroresCargue>(con, "API.PA_ConsolidadoErroresCargueAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ConsolidadoErroresCargue  ->" + ex.Message);
				}
			}

			public ConsolidadoErroresCargue  Update(ConsolidadoErroresCargue pConsolidadoErroresCargue)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pConsolidadoErroresCargue.id==null ? 0 : pConsolidadoErroresCargue.id);
p.Add("@ID_ProcesoCargue",pConsolidadoErroresCargue.ID_ProcesoCargue==null ? 0 : pConsolidadoErroresCargue.ID_ProcesoCargue);
                    p.Add("@TipoProcesoCargue", pConsolidadoErroresCargue.TipoProcesoCargue);
p.Add("@ID_TipoErrorCargue",pConsolidadoErroresCargue.ID_TipoErrorCargue==null ? 0 : pConsolidadoErroresCargue.ID_TipoErrorCargue);
                    p.Add("@NombreError", pConsolidadoErroresCargue.NombreError);
                    p.Add("@NombreArchivoProcesado", pConsolidadoErroresCargue.NombreArchivoProcesado);
                    p.Add("@TotalErrores", pConsolidadoErroresCargue.TotalErrores);
                    p.Add("@auditoria", pConsolidadoErroresCargue.auditoria);

                         


                    ConsolidadoErroresCargue o = SqlMapper.QueryFirstOrDefault<ConsolidadoErroresCargue>(con, "API.PA_ConsolidadoErroresCargueUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ConsolidadoErroresCargue  ->" + ex.Message);
				}
			}

			public bool Delete(ConsolidadoErroresCargue pConsolidadoErroresCargue)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pConsolidadoErroresCargue.id);
                    p.Add("@auditoria", pConsolidadoErroresCargue.auditoria);

                

 

					ConsolidadoErroresCargue o = SqlMapper.QueryFirstOrDefault<ConsolidadoErroresCargue>(con, "API.PA_ConsolidadoErroresCargueDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ConsolidadoErroresCargue  ->" + ex.Message);
				}
			}

		



            public List<ConsolidadoErroresCargue> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ConsolidadoErroresCargue> ConsolidadoErroresCargueList = new List<ConsolidadoErroresCargue>();

                    ConsolidadoErroresCargueList = SqlMapper.Query<ConsolidadoErroresCargue>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ConsolidadoErroresCargueList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ConsolidadoErroresCargue  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ConsolidadoErroresCargue> b)
            {
                DapperPlusManager.Entity<ConsolidadoErroresCargue>().Table("ConsolidadoErroresCargue");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}