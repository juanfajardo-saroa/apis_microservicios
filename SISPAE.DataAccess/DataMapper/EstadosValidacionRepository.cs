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
     /// Clase Abstracta para  EstadosValidacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class EstadosValidacionRepository : DataObject , IEstadosValidacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public EstadosValidacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public EstadosValidacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public EstadosValidacion GetById(EstadosValidacion pEstadosValidacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@ID",pEstadosValidacion.ID);                                    


    				EstadosValidacion o = SqlMapper.QueryFirstOrDefault<EstadosValidacion>(con, "API.PA_EstadosValidacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  EstadosValidacion  ->" + ex.Message);
				}
			}

			public List<EstadosValidacion> GetAll()
			{
				try 
                {
                        List<EstadosValidacion> l = SqlMapper.Query<EstadosValidacion>(con, "API.PA_EstadosValidacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  EstadosValidacion  ->" + ex.Message);
				}
			}

			public List<EstadosValidacion> GetAllFull()
			{
				try 
				{
                    List<EstadosValidacion> l = SqlMapper.Query<EstadosValidacion>(con, "API.PA_EstadosValidacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  EstadosValidacion  ->" + ex.Message);
				}
			}
			
			public List<EstadosValidacion> GetAllByWithRelation()
			{
				try 
                {
                    List<EstadosValidacion> l = SqlMapper.Query<EstadosValidacion>(con, "API.PA_EstadosValidacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  EstadosValidacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<EstadosValidacion> GetByFilter(EstadosValidacion pEstadosValidacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ID",(pEstadosValidacion.ID== null || pEstadosValidacion.ID==0) ? vintNUll :pEstadosValidacion.ID);
                    p.Add("@Nombre",(pEstadosValidacion.Nombre== null) ? vintNUll :pEstadosValidacion.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<EstadosValidacion> l = SqlMapper.Query<EstadosValidacion>(con, "API.PA_EstadosValidacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  EstadosValidacion  ->" + ex.Message);
				}
			}

			public EstadosValidacion Add(EstadosValidacion pEstadosValidacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ID",pEstadosValidacion.ID==null ? 0 : pEstadosValidacion.ID);
                    p.Add("@Nombre", pEstadosValidacion.Nombre);
                    p.Add("@auditoria", pEstadosValidacion.auditoria);

                         


                    EstadosValidacion o = SqlMapper.QueryFirstOrDefault<EstadosValidacion>(con, "API.PA_EstadosValidacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  EstadosValidacion  ->" + ex.Message);
				}
			}

			public EstadosValidacion  Update(EstadosValidacion pEstadosValidacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ID",pEstadosValidacion.ID==null ? 0 : pEstadosValidacion.ID);
                    p.Add("@Nombre", pEstadosValidacion.Nombre);
                    p.Add("@auditoria", pEstadosValidacion.auditoria);

                         


                    EstadosValidacion o = SqlMapper.QueryFirstOrDefault<EstadosValidacion>(con, "API.PA_EstadosValidacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  EstadosValidacion  ->" + ex.Message);
				}
			}

			public bool Delete(EstadosValidacion pEstadosValidacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@ID",pEstadosValidacion.ID);
                    p.Add("@auditoria", pEstadosValidacion.auditoria);

                

 

					EstadosValidacion o = SqlMapper.QueryFirstOrDefault<EstadosValidacion>(con, "API.PA_EstadosValidacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) EstadosValidacion  ->" + ex.Message);
				}
			}

		



            public List<EstadosValidacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<EstadosValidacion> EstadosValidacionList = new List<EstadosValidacion>();

                    EstadosValidacionList = SqlMapper.Query<EstadosValidacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return EstadosValidacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) EstadosValidacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<EstadosValidacion> b)
            {
                DapperPlusManager.Entity<EstadosValidacion>().Table("EstadosValidacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}