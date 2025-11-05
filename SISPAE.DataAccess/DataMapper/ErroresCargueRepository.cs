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
     /// Clase Abstracta para  ErroresCargue
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ErroresCargueRepository : DataObject , IErroresCargue 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ErroresCargueRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ErroresCargueRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ErroresCargue GetById(ErroresCargue pErroresCargue)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pErroresCargue.id);                                    


    				ErroresCargue o = SqlMapper.QueryFirstOrDefault<ErroresCargue>(con, "API.PA_ErroresCargueGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ErroresCargue  ->" + ex.Message);
				}
			}

			public List<ErroresCargue> GetAll()
			{
				try 
                {
                        List<ErroresCargue> l = SqlMapper.Query<ErroresCargue>(con, "API.PA_ErroresCargueGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ErroresCargue  ->" + ex.Message);
				}
			}

			public List<ErroresCargue> GetAllFull()
			{
				try 
				{
                    List<ErroresCargue> l = SqlMapper.Query<ErroresCargue>(con, "API.PA_ErroresCargueGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ErroresCargue  ->" + ex.Message);
				}
			}
			
			public List<ErroresCargue> GetAllByWithRelation()
			{
				try 
                {
                    List<ErroresCargue> l = SqlMapper.Query<ErroresCargue>(con, "API.PA_ErroresCargueGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ErroresCargue  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ErroresCargue> GetByFilter(ErroresCargue pErroresCargue, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pErroresCargue.id== null || pErroresCargue.id==0) ? vintNUll :pErroresCargue.id);
                    p.Add("@ID_ProcesosCargue",(pErroresCargue.ID_ProcesosCargue== null || pErroresCargue.ID_ProcesosCargue==0) ? vintNUll :pErroresCargue.ID_ProcesosCargue);
                    p.Add("@ID_TipoProcesoCargue",(pErroresCargue.ID_TipoProcesoCargue== null || pErroresCargue.ID_TipoProcesoCargue==0) ? vintNUll :pErroresCargue.ID_TipoProcesoCargue);
                    p.Add("@ID_TipoErroresCargue",(pErroresCargue.ID_TipoErroresCargue== null || pErroresCargue.ID_TipoErroresCargue==0) ? vintNUll :pErroresCargue.ID_TipoErroresCargue);
                    p.Add("@PER_ID",(pErroresCargue.PER_ID== null) ? vintNUll :pErroresCargue.PER_ID);
                    p.Add("@Fila",(pErroresCargue.Fila== null) ? vintNUll :pErroresCargue.Fila);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ErroresCargue> l = SqlMapper.Query<ErroresCargue>(con, "API.PA_ErroresCargueGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ErroresCargue  ->" + ex.Message);
				}
			}

			public ErroresCargue Add(ErroresCargue pErroresCargue)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pErroresCargue.id==null ? 0 : pErroresCargue.id);
p.Add("@ID_ProcesosCargue",pErroresCargue.ID_ProcesosCargue==null ? 0 : pErroresCargue.ID_ProcesosCargue);
p.Add("@ID_TipoProcesoCargue",pErroresCargue.ID_TipoProcesoCargue==null ? 0 : pErroresCargue.ID_TipoProcesoCargue);
p.Add("@ID_TipoErroresCargue",pErroresCargue.ID_TipoErroresCargue==null ? 0 : pErroresCargue.ID_TipoErroresCargue);
                    p.Add("@PER_ID", pErroresCargue.PER_ID);
p.Add("@Fila",pErroresCargue.Fila==null ? 0 : pErroresCargue.Fila);
                    p.Add("@auditoria", pErroresCargue.auditoria);

                         


                    ErroresCargue o = SqlMapper.QueryFirstOrDefault<ErroresCargue>(con, "API.PA_ErroresCargueAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ErroresCargue  ->" + ex.Message);
				}
			}

			public ErroresCargue  Update(ErroresCargue pErroresCargue)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pErroresCargue.id==null ? 0 : pErroresCargue.id);
p.Add("@ID_ProcesosCargue",pErroresCargue.ID_ProcesosCargue==null ? 0 : pErroresCargue.ID_ProcesosCargue);
p.Add("@ID_TipoProcesoCargue",pErroresCargue.ID_TipoProcesoCargue==null ? 0 : pErroresCargue.ID_TipoProcesoCargue);
p.Add("@ID_TipoErroresCargue",pErroresCargue.ID_TipoErroresCargue==null ? 0 : pErroresCargue.ID_TipoErroresCargue);
                    p.Add("@PER_ID", pErroresCargue.PER_ID);
p.Add("@Fila",pErroresCargue.Fila==null ? 0 : pErroresCargue.Fila);
                    p.Add("@auditoria", pErroresCargue.auditoria);

                         


                    ErroresCargue o = SqlMapper.QueryFirstOrDefault<ErroresCargue>(con, "API.PA_ErroresCargueUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ErroresCargue  ->" + ex.Message);
				}
			}

			public bool Delete(ErroresCargue pErroresCargue)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pErroresCargue.id);
                    p.Add("@auditoria", pErroresCargue.auditoria);

                

 

					ErroresCargue o = SqlMapper.QueryFirstOrDefault<ErroresCargue>(con, "API.PA_ErroresCargueDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ErroresCargue  ->" + ex.Message);
				}
			}

		



            public List<ErroresCargue> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ErroresCargue> ErroresCargueList = new List<ErroresCargue>();

                    ErroresCargueList = SqlMapper.Query<ErroresCargue>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ErroresCargueList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ErroresCargue  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ErroresCargue> b)
            {
                DapperPlusManager.Entity<ErroresCargue>().Table("ErroresCargue");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}