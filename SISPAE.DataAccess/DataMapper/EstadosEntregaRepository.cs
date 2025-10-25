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
     /// Clase Abstracta para  EstadosEntrega
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class EstadosEntregaRepository : DataObject , IEstadosEntrega 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public EstadosEntregaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public EstadosEntregaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public EstadosEntrega GetById(EstadosEntrega pEstadosEntrega)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pEstadosEntrega.id);                                    


    				EstadosEntrega o = SqlMapper.QueryFirstOrDefault<EstadosEntrega>(con, "API.PA_EstadosEntregaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  EstadosEntrega  ->" + ex.Message);
				}
			}

			public List<EstadosEntrega> GetAll()
			{
				try 
                {
                        List<EstadosEntrega> l = SqlMapper.Query<EstadosEntrega>(con, "API.PA_EstadosEntregaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  EstadosEntrega  ->" + ex.Message);
				}
			}

			public List<EstadosEntrega> GetAllFull()
			{
				try 
				{
                    List<EstadosEntrega> l = SqlMapper.Query<EstadosEntrega>(con, "API.PA_EstadosEntregaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  EstadosEntrega  ->" + ex.Message);
				}
			}
			
			public List<EstadosEntrega> GetAllByWithRelation()
			{
				try 
                {
                    List<EstadosEntrega> l = SqlMapper.Query<EstadosEntrega>(con, "API.PA_EstadosEntregaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  EstadosEntrega  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<EstadosEntrega> GetByFilter(EstadosEntrega pEstadosEntrega, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pEstadosEntrega.id== null || pEstadosEntrega.id==0) ? vintNUll :pEstadosEntrega.id);
                    p.Add("@Nombre",(pEstadosEntrega.Nombre== null) ? vintNUll :pEstadosEntrega.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<EstadosEntrega> l = SqlMapper.Query<EstadosEntrega>(con, "API.PA_EstadosEntregaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  EstadosEntrega  ->" + ex.Message);
				}
			}

			public EstadosEntrega Add(EstadosEntrega pEstadosEntrega)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pEstadosEntrega.id==null ? 0 : pEstadosEntrega.id);
                    p.Add("@Nombre", pEstadosEntrega.Nombre);
                    p.Add("@auditoria", pEstadosEntrega.auditoria);

                         


                    EstadosEntrega o = SqlMapper.QueryFirstOrDefault<EstadosEntrega>(con, "API.PA_EstadosEntregaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  EstadosEntrega  ->" + ex.Message);
				}
			}

			public EstadosEntrega  Update(EstadosEntrega pEstadosEntrega)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pEstadosEntrega.id==null ? 0 : pEstadosEntrega.id);
                    p.Add("@Nombre", pEstadosEntrega.Nombre);
                    p.Add("@auditoria", pEstadosEntrega.auditoria);

                         


                    EstadosEntrega o = SqlMapper.QueryFirstOrDefault<EstadosEntrega>(con, "API.PA_EstadosEntregaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  EstadosEntrega  ->" + ex.Message);
				}
			}

			public bool Delete(EstadosEntrega pEstadosEntrega)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pEstadosEntrega.id);
                    p.Add("@auditoria", pEstadosEntrega.auditoria);

                

 

					EstadosEntrega o = SqlMapper.QueryFirstOrDefault<EstadosEntrega>(con, "API.PA_EstadosEntregaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) EstadosEntrega  ->" + ex.Message);
				}
			}

		



            public List<EstadosEntrega> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<EstadosEntrega> EstadosEntregaList = new List<EstadosEntrega>();

                    EstadosEntregaList = SqlMapper.Query<EstadosEntrega>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return EstadosEntregaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) EstadosEntrega  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<EstadosEntrega> b)
            {
                DapperPlusManager.Entity<EstadosEntrega>().Table("EstadosEntrega");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}