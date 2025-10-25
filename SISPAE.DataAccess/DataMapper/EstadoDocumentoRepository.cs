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
     /// Clase Abstracta para  EstadoDocumento
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class EstadoDocumentoRepository : DataObject , IEstadoDocumento 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public EstadoDocumentoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public EstadoDocumentoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public EstadoDocumento GetById(EstadoDocumento pEstadoDocumento)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@ID",pEstadoDocumento.ID);                                    


    				EstadoDocumento o = SqlMapper.QueryFirstOrDefault<EstadoDocumento>(con, "API.PA_EstadoDocumentoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  EstadoDocumento  ->" + ex.Message);
				}
			}

			public List<EstadoDocumento> GetAll()
			{
				try 
                {
                        List<EstadoDocumento> l = SqlMapper.Query<EstadoDocumento>(con, "API.PA_EstadoDocumentoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  EstadoDocumento  ->" + ex.Message);
				}
			}

			public List<EstadoDocumento> GetAllFull()
			{
				try 
				{
                    List<EstadoDocumento> l = SqlMapper.Query<EstadoDocumento>(con, "API.PA_EstadoDocumentoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  EstadoDocumento  ->" + ex.Message);
				}
			}
			
			public List<EstadoDocumento> GetAllByWithRelation()
			{
				try 
                {
                    List<EstadoDocumento> l = SqlMapper.Query<EstadoDocumento>(con, "API.PA_EstadoDocumentoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  EstadoDocumento  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<EstadoDocumento> GetByFilter(EstadoDocumento pEstadoDocumento, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ID",(pEstadoDocumento.ID== null || pEstadoDocumento.ID==0) ? vintNUll :pEstadoDocumento.ID);
                    p.Add("@Nombre",(pEstadoDocumento.Nombre== null) ? vintNUll :pEstadoDocumento.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<EstadoDocumento> l = SqlMapper.Query<EstadoDocumento>(con, "API.PA_EstadoDocumentoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  EstadoDocumento  ->" + ex.Message);
				}
			}

			public EstadoDocumento Add(EstadoDocumento pEstadoDocumento)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ID",pEstadoDocumento.ID==null ? 0 : pEstadoDocumento.ID);
                    p.Add("@Nombre", pEstadoDocumento.Nombre);
                    p.Add("@auditoria", pEstadoDocumento.auditoria);

                         


                    EstadoDocumento o = SqlMapper.QueryFirstOrDefault<EstadoDocumento>(con, "API.PA_EstadoDocumentoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  EstadoDocumento  ->" + ex.Message);
				}
			}

			public EstadoDocumento  Update(EstadoDocumento pEstadoDocumento)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ID",pEstadoDocumento.ID==null ? 0 : pEstadoDocumento.ID);
                    p.Add("@Nombre", pEstadoDocumento.Nombre);
                    p.Add("@auditoria", pEstadoDocumento.auditoria);

                         


                    EstadoDocumento o = SqlMapper.QueryFirstOrDefault<EstadoDocumento>(con, "API.PA_EstadoDocumentoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  EstadoDocumento  ->" + ex.Message);
				}
			}

			public bool Delete(EstadoDocumento pEstadoDocumento)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@ID",pEstadoDocumento.ID);
                    p.Add("@auditoria", pEstadoDocumento.auditoria);

                

 

					EstadoDocumento o = SqlMapper.QueryFirstOrDefault<EstadoDocumento>(con, "API.PA_EstadoDocumentoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) EstadoDocumento  ->" + ex.Message);
				}
			}

		



            public List<EstadoDocumento> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<EstadoDocumento> EstadoDocumentoList = new List<EstadoDocumento>();

                    EstadoDocumentoList = SqlMapper.Query<EstadoDocumento>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return EstadoDocumentoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) EstadoDocumento  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<EstadoDocumento> b)
            {
                DapperPlusManager.Entity<EstadoDocumento>().Table("EstadoDocumento");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}