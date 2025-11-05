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
     /// Clase Abstracta para  TiposCriterioEvaluacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposCriterioEvaluacionRepository : DataObject , ITiposCriterioEvaluacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposCriterioEvaluacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposCriterioEvaluacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposCriterioEvaluacion GetById(TiposCriterioEvaluacion pTiposCriterioEvaluacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposCriterioEvaluacion.id);                                    


    				TiposCriterioEvaluacion o = SqlMapper.QueryFirstOrDefault<TiposCriterioEvaluacion>(con, "API.PA_TiposCriterioEvaluacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposCriterioEvaluacion  ->" + ex.Message);
				}
			}

			public List<TiposCriterioEvaluacion> GetAll()
			{
				try 
                {
                        List<TiposCriterioEvaluacion> l = SqlMapper.Query<TiposCriterioEvaluacion>(con, "API.PA_TiposCriterioEvaluacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposCriterioEvaluacion  ->" + ex.Message);
				}
			}

			public List<TiposCriterioEvaluacion> GetAllFull()
			{
				try 
				{
                    List<TiposCriterioEvaluacion> l = SqlMapper.Query<TiposCriterioEvaluacion>(con, "API.PA_TiposCriterioEvaluacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposCriterioEvaluacion  ->" + ex.Message);
				}
			}
			
			public List<TiposCriterioEvaluacion> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposCriterioEvaluacion> l = SqlMapper.Query<TiposCriterioEvaluacion>(con, "API.PA_TiposCriterioEvaluacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposCriterioEvaluacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposCriterioEvaluacion> GetByFilter(TiposCriterioEvaluacion pTiposCriterioEvaluacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposCriterioEvaluacion.id== null || pTiposCriterioEvaluacion.id==0) ? vintNUll :pTiposCriterioEvaluacion.id);
                    p.Add("@Nombre",(pTiposCriterioEvaluacion.Nombre== null) ? vintNUll :pTiposCriterioEvaluacion.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposCriterioEvaluacion> l = SqlMapper.Query<TiposCriterioEvaluacion>(con, "API.PA_TiposCriterioEvaluacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposCriterioEvaluacion  ->" + ex.Message);
				}
			}

			public TiposCriterioEvaluacion Add(TiposCriterioEvaluacion pTiposCriterioEvaluacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposCriterioEvaluacion.id==null ? 0 : pTiposCriterioEvaluacion.id);
                    p.Add("@Nombre", pTiposCriterioEvaluacion.Nombre);
                    p.Add("@auditoria", pTiposCriterioEvaluacion.auditoria);

                         


                    TiposCriterioEvaluacion o = SqlMapper.QueryFirstOrDefault<TiposCriterioEvaluacion>(con, "API.PA_TiposCriterioEvaluacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposCriterioEvaluacion  ->" + ex.Message);
				}
			}

			public TiposCriterioEvaluacion  Update(TiposCriterioEvaluacion pTiposCriterioEvaluacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposCriterioEvaluacion.id==null ? 0 : pTiposCriterioEvaluacion.id);
                    p.Add("@Nombre", pTiposCriterioEvaluacion.Nombre);
                    p.Add("@auditoria", pTiposCriterioEvaluacion.auditoria);

                         


                    TiposCriterioEvaluacion o = SqlMapper.QueryFirstOrDefault<TiposCriterioEvaluacion>(con, "API.PA_TiposCriterioEvaluacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposCriterioEvaluacion  ->" + ex.Message);
				}
			}

			public bool Delete(TiposCriterioEvaluacion pTiposCriterioEvaluacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposCriterioEvaluacion.id);
                    p.Add("@auditoria", pTiposCriterioEvaluacion.auditoria);

                

 

					TiposCriterioEvaluacion o = SqlMapper.QueryFirstOrDefault<TiposCriterioEvaluacion>(con, "API.PA_TiposCriterioEvaluacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposCriterioEvaluacion  ->" + ex.Message);
				}
			}

		



            public List<TiposCriterioEvaluacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposCriterioEvaluacion> TiposCriterioEvaluacionList = new List<TiposCriterioEvaluacion>();

                    TiposCriterioEvaluacionList = SqlMapper.Query<TiposCriterioEvaluacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposCriterioEvaluacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposCriterioEvaluacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposCriterioEvaluacion> b)
            {
                DapperPlusManager.Entity<TiposCriterioEvaluacion>().Table("TiposCriterioEvaluacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}