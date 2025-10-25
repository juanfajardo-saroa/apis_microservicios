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
     /// Clase Abstracta para  EstadosRegistroInvima
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class EstadosRegistroInvimaRepository : DataObject , IEstadosRegistroInvima 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public EstadosRegistroInvimaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public EstadosRegistroInvimaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public EstadosRegistroInvima GetById(EstadosRegistroInvima pEstadosRegistroInvima)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pEstadosRegistroInvima.id);                                    


    				EstadosRegistroInvima o = SqlMapper.QueryFirstOrDefault<EstadosRegistroInvima>(con, "API.PA_EstadosRegistroInvimaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  EstadosRegistroInvima  ->" + ex.Message);
				}
			}

			public List<EstadosRegistroInvima> GetAll()
			{
				try 
                {
                        List<EstadosRegistroInvima> l = SqlMapper.Query<EstadosRegistroInvima>(con, "API.PA_EstadosRegistroInvimaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  EstadosRegistroInvima  ->" + ex.Message);
				}
			}

			public List<EstadosRegistroInvima> GetAllFull()
			{
				try 
				{
                    List<EstadosRegistroInvima> l = SqlMapper.Query<EstadosRegistroInvima>(con, "API.PA_EstadosRegistroInvimaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  EstadosRegistroInvima  ->" + ex.Message);
				}
			}
			
			public List<EstadosRegistroInvima> GetAllByWithRelation()
			{
				try 
                {
                    List<EstadosRegistroInvima> l = SqlMapper.Query<EstadosRegistroInvima>(con, "API.PA_EstadosRegistroInvimaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  EstadosRegistroInvima  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<EstadosRegistroInvima> GetByFilter(EstadosRegistroInvima pEstadosRegistroInvima, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pEstadosRegistroInvima.id== null || pEstadosRegistroInvima.id==0) ? vintNUll :pEstadosRegistroInvima.id);
                    p.Add("@Nombre",(pEstadosRegistroInvima.Nombre== null) ? vintNUll :pEstadosRegistroInvima.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<EstadosRegistroInvima> l = SqlMapper.Query<EstadosRegistroInvima>(con, "API.PA_EstadosRegistroInvimaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  EstadosRegistroInvima  ->" + ex.Message);
				}
			}

			public EstadosRegistroInvima Add(EstadosRegistroInvima pEstadosRegistroInvima)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pEstadosRegistroInvima.id==null ? 0 : pEstadosRegistroInvima.id);
                    p.Add("@Nombre", pEstadosRegistroInvima.Nombre);
                    p.Add("@auditoria", pEstadosRegistroInvima.auditoria);

                         


                    EstadosRegistroInvima o = SqlMapper.QueryFirstOrDefault<EstadosRegistroInvima>(con, "API.PA_EstadosRegistroInvimaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  EstadosRegistroInvima  ->" + ex.Message);
				}
			}

			public EstadosRegistroInvima  Update(EstadosRegistroInvima pEstadosRegistroInvima)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pEstadosRegistroInvima.id==null ? 0 : pEstadosRegistroInvima.id);
                    p.Add("@Nombre", pEstadosRegistroInvima.Nombre);
                    p.Add("@auditoria", pEstadosRegistroInvima.auditoria);

                         


                    EstadosRegistroInvima o = SqlMapper.QueryFirstOrDefault<EstadosRegistroInvima>(con, "API.PA_EstadosRegistroInvimaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  EstadosRegistroInvima  ->" + ex.Message);
				}
			}

			public bool Delete(EstadosRegistroInvima pEstadosRegistroInvima)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pEstadosRegistroInvima.id);
                    p.Add("@auditoria", pEstadosRegistroInvima.auditoria);

                

 

					EstadosRegistroInvima o = SqlMapper.QueryFirstOrDefault<EstadosRegistroInvima>(con, "API.PA_EstadosRegistroInvimaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) EstadosRegistroInvima  ->" + ex.Message);
				}
			}

		



            public List<EstadosRegistroInvima> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<EstadosRegistroInvima> EstadosRegistroInvimaList = new List<EstadosRegistroInvima>();

                    EstadosRegistroInvimaList = SqlMapper.Query<EstadosRegistroInvima>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return EstadosRegistroInvimaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) EstadosRegistroInvima  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<EstadosRegistroInvima> b)
            {
                DapperPlusManager.Entity<EstadosRegistroInvima>().Table("EstadosRegistroInvima");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}