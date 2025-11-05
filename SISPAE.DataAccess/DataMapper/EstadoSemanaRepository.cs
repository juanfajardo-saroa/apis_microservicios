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
     /// Clase Abstracta para  EstadoSemana
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class EstadoSemanaRepository : DataObject , IEstadoSemana 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public EstadoSemanaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public EstadoSemanaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public EstadoSemana GetById(EstadoSemana pEstadoSemana)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pEstadoSemana.id);                                    


    				EstadoSemana o = SqlMapper.QueryFirstOrDefault<EstadoSemana>(con, "API.PA_EstadoSemanaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  EstadoSemana  ->" + ex.Message);
				}
			}

			public List<EstadoSemana> GetAll()
			{
				try 
                {
                        List<EstadoSemana> l = SqlMapper.Query<EstadoSemana>(con, "API.PA_EstadoSemanaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  EstadoSemana  ->" + ex.Message);
				}
			}

			public List<EstadoSemana> GetAllFull()
			{
				try 
				{
                    List<EstadoSemana> l = SqlMapper.Query<EstadoSemana>(con, "API.PA_EstadoSemanaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  EstadoSemana  ->" + ex.Message);
				}
			}
			
			public List<EstadoSemana> GetAllByWithRelation()
			{
				try 
                {
                    List<EstadoSemana> l = SqlMapper.Query<EstadoSemana>(con, "API.PA_EstadoSemanaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  EstadoSemana  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<EstadoSemana> GetByFilter(EstadoSemana pEstadoSemana, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pEstadoSemana.id== null || pEstadoSemana.id==0) ? vintNUll :pEstadoSemana.id);
                    p.Add("@Nombre",(pEstadoSemana.Nombre== null) ? vintNUll :pEstadoSemana.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<EstadoSemana> l = SqlMapper.Query<EstadoSemana>(con, "API.PA_EstadoSemanaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  EstadoSemana  ->" + ex.Message);
				}
			}

			public EstadoSemana Add(EstadoSemana pEstadoSemana)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pEstadoSemana.id==null ? 0 : pEstadoSemana.id);
                    p.Add("@Nombre", pEstadoSemana.Nombre);
                    p.Add("@auditoria", pEstadoSemana.auditoria);

                         


                    EstadoSemana o = SqlMapper.QueryFirstOrDefault<EstadoSemana>(con, "API.PA_EstadoSemanaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  EstadoSemana  ->" + ex.Message);
				}
			}

			public EstadoSemana  Update(EstadoSemana pEstadoSemana)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pEstadoSemana.id==null ? 0 : pEstadoSemana.id);
                    p.Add("@Nombre", pEstadoSemana.Nombre);
                    p.Add("@auditoria", pEstadoSemana.auditoria);

                         


                    EstadoSemana o = SqlMapper.QueryFirstOrDefault<EstadoSemana>(con, "API.PA_EstadoSemanaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  EstadoSemana  ->" + ex.Message);
				}
			}

			public bool Delete(EstadoSemana pEstadoSemana)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pEstadoSemana.id);
                    p.Add("@auditoria", pEstadoSemana.auditoria);

                

 

					EstadoSemana o = SqlMapper.QueryFirstOrDefault<EstadoSemana>(con, "API.PA_EstadoSemanaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) EstadoSemana  ->" + ex.Message);
				}
			}

		



            public List<EstadoSemana> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<EstadoSemana> EstadoSemanaList = new List<EstadoSemana>();

                    EstadoSemanaList = SqlMapper.Query<EstadoSemana>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return EstadoSemanaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) EstadoSemana  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<EstadoSemana> b)
            {
                DapperPlusManager.Entity<EstadoSemana>().Table("EstadoSemana");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}