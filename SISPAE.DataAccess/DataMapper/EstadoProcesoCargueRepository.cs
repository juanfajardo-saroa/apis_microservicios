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
     /// Clase Abstracta para  EstadoProcesoCargue
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class EstadoProcesoCargueRepository : DataObject , IEstadoProcesoCargue 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public EstadoProcesoCargueRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public EstadoProcesoCargueRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public EstadoProcesoCargue GetById(EstadoProcesoCargue pEstadoProcesoCargue)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pEstadoProcesoCargue.id);                                    


    				EstadoProcesoCargue o = SqlMapper.QueryFirstOrDefault<EstadoProcesoCargue>(con, "API.PA_EstadoProcesoCargueGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  EstadoProcesoCargue  ->" + ex.Message);
				}
			}

			public List<EstadoProcesoCargue> GetAll()
			{
				try 
                {
                        List<EstadoProcesoCargue> l = SqlMapper.Query<EstadoProcesoCargue>(con, "API.PA_EstadoProcesoCargueGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  EstadoProcesoCargue  ->" + ex.Message);
				}
			}

			public List<EstadoProcesoCargue> GetAllFull()
			{
				try 
				{
                    List<EstadoProcesoCargue> l = SqlMapper.Query<EstadoProcesoCargue>(con, "API.PA_EstadoProcesoCargueGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  EstadoProcesoCargue  ->" + ex.Message);
				}
			}
			
			public List<EstadoProcesoCargue> GetAllByWithRelation()
			{
				try 
                {
                    List<EstadoProcesoCargue> l = SqlMapper.Query<EstadoProcesoCargue>(con, "API.PA_EstadoProcesoCargueGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  EstadoProcesoCargue  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<EstadoProcesoCargue> GetByFilter(EstadoProcesoCargue pEstadoProcesoCargue, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pEstadoProcesoCargue.id== null || pEstadoProcesoCargue.id==0) ? vintNUll :pEstadoProcesoCargue.id);
                    p.Add("@Nombre",(pEstadoProcesoCargue.Nombre== null) ? vintNUll :pEstadoProcesoCargue.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<EstadoProcesoCargue> l = SqlMapper.Query<EstadoProcesoCargue>(con, "API.PA_EstadoProcesoCargueGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  EstadoProcesoCargue  ->" + ex.Message);
				}
			}

			public EstadoProcesoCargue Add(EstadoProcesoCargue pEstadoProcesoCargue)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pEstadoProcesoCargue.id==null ? 0 : pEstadoProcesoCargue.id);
                    p.Add("@Nombre", pEstadoProcesoCargue.Nombre);
                    p.Add("@auditoria", pEstadoProcesoCargue.auditoria);

                         


                    EstadoProcesoCargue o = SqlMapper.QueryFirstOrDefault<EstadoProcesoCargue>(con, "API.PA_EstadoProcesoCargueAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  EstadoProcesoCargue  ->" + ex.Message);
				}
			}

			public EstadoProcesoCargue  Update(EstadoProcesoCargue pEstadoProcesoCargue)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pEstadoProcesoCargue.id==null ? 0 : pEstadoProcesoCargue.id);
                    p.Add("@Nombre", pEstadoProcesoCargue.Nombre);
                    p.Add("@auditoria", pEstadoProcesoCargue.auditoria);

                         


                    EstadoProcesoCargue o = SqlMapper.QueryFirstOrDefault<EstadoProcesoCargue>(con, "API.PA_EstadoProcesoCargueUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  EstadoProcesoCargue  ->" + ex.Message);
				}
			}

			public bool Delete(EstadoProcesoCargue pEstadoProcesoCargue)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pEstadoProcesoCargue.id);
                    p.Add("@auditoria", pEstadoProcesoCargue.auditoria);

                

 

					EstadoProcesoCargue o = SqlMapper.QueryFirstOrDefault<EstadoProcesoCargue>(con, "API.PA_EstadoProcesoCargueDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) EstadoProcesoCargue  ->" + ex.Message);
				}
			}

		



            public List<EstadoProcesoCargue> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<EstadoProcesoCargue> EstadoProcesoCargueList = new List<EstadoProcesoCargue>();

                    EstadoProcesoCargueList = SqlMapper.Query<EstadoProcesoCargue>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return EstadoProcesoCargueList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) EstadoProcesoCargue  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<EstadoProcesoCargue> b)
            {
                DapperPlusManager.Entity<EstadoProcesoCargue>().Table("EstadoProcesoCargue");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}