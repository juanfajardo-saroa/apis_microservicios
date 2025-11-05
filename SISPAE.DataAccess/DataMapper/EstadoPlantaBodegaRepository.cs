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
     /// Clase Abstracta para  EstadoPlantaBodega
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class EstadoPlantaBodegaRepository : DataObject , IEstadoPlantaBodega 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public EstadoPlantaBodegaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public EstadoPlantaBodegaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public EstadoPlantaBodega GetById(EstadoPlantaBodega pEstadoPlantaBodega)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@ID",pEstadoPlantaBodega.ID);                                    


    				EstadoPlantaBodega o = SqlMapper.QueryFirstOrDefault<EstadoPlantaBodega>(con, "API.PA_EstadoPlantaBodegaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  EstadoPlantaBodega  ->" + ex.Message);
				}
			}

			public List<EstadoPlantaBodega> GetAll()
			{
				try 
                {
                        List<EstadoPlantaBodega> l = SqlMapper.Query<EstadoPlantaBodega>(con, "API.PA_EstadoPlantaBodegaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  EstadoPlantaBodega  ->" + ex.Message);
				}
			}

			public List<EstadoPlantaBodega> GetAllFull()
			{
				try 
				{
                    List<EstadoPlantaBodega> l = SqlMapper.Query<EstadoPlantaBodega>(con, "API.PA_EstadoPlantaBodegaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  EstadoPlantaBodega  ->" + ex.Message);
				}
			}
			
			public List<EstadoPlantaBodega> GetAllByWithRelation()
			{
				try 
                {
                    List<EstadoPlantaBodega> l = SqlMapper.Query<EstadoPlantaBodega>(con, "API.PA_EstadoPlantaBodegaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  EstadoPlantaBodega  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<EstadoPlantaBodega> GetByFilter(EstadoPlantaBodega pEstadoPlantaBodega, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ID",(pEstadoPlantaBodega.ID== null || pEstadoPlantaBodega.ID==0) ? vintNUll :pEstadoPlantaBodega.ID);
                    p.Add("@Nombre",(pEstadoPlantaBodega.Nombre== null) ? vintNUll :pEstadoPlantaBodega.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<EstadoPlantaBodega> l = SqlMapper.Query<EstadoPlantaBodega>(con, "API.PA_EstadoPlantaBodegaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  EstadoPlantaBodega  ->" + ex.Message);
				}
			}

			public EstadoPlantaBodega Add(EstadoPlantaBodega pEstadoPlantaBodega)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ID",pEstadoPlantaBodega.ID==null ? 0 : pEstadoPlantaBodega.ID);
                    p.Add("@Nombre", pEstadoPlantaBodega.Nombre);
                    p.Add("@auditoria", pEstadoPlantaBodega.auditoria);

                         


                    EstadoPlantaBodega o = SqlMapper.QueryFirstOrDefault<EstadoPlantaBodega>(con, "API.PA_EstadoPlantaBodegaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  EstadoPlantaBodega  ->" + ex.Message);
				}
			}

			public EstadoPlantaBodega  Update(EstadoPlantaBodega pEstadoPlantaBodega)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ID",pEstadoPlantaBodega.ID==null ? 0 : pEstadoPlantaBodega.ID);
                    p.Add("@Nombre", pEstadoPlantaBodega.Nombre);
                    p.Add("@auditoria", pEstadoPlantaBodega.auditoria);

                         


                    EstadoPlantaBodega o = SqlMapper.QueryFirstOrDefault<EstadoPlantaBodega>(con, "API.PA_EstadoPlantaBodegaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  EstadoPlantaBodega  ->" + ex.Message);
				}
			}

			public bool Delete(EstadoPlantaBodega pEstadoPlantaBodega)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@ID",pEstadoPlantaBodega.ID);
                    p.Add("@auditoria", pEstadoPlantaBodega.auditoria);

                

 

					EstadoPlantaBodega o = SqlMapper.QueryFirstOrDefault<EstadoPlantaBodega>(con, "API.PA_EstadoPlantaBodegaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) EstadoPlantaBodega  ->" + ex.Message);
				}
			}

		



            public List<EstadoPlantaBodega> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<EstadoPlantaBodega> EstadoPlantaBodegaList = new List<EstadoPlantaBodega>();

                    EstadoPlantaBodegaList = SqlMapper.Query<EstadoPlantaBodega>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return EstadoPlantaBodegaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) EstadoPlantaBodega  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<EstadoPlantaBodega> b)
            {
                DapperPlusManager.Entity<EstadoPlantaBodega>().Table("EstadoPlantaBodega");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}