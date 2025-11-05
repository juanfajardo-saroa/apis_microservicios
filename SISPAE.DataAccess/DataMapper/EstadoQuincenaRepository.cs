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
     /// Clase Abstracta para  EstadoQuincena
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class EstadoQuincenaRepository : DataObject , IEstadoQuincena 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public EstadoQuincenaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public EstadoQuincenaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public EstadoQuincena GetById(EstadoQuincena pEstadoQuincena)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pEstadoQuincena.id);                                    


    				EstadoQuincena o = SqlMapper.QueryFirstOrDefault<EstadoQuincena>(con, "API.PA_EstadoQuincenaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  EstadoQuincena  ->" + ex.Message);
				}
			}

			public List<EstadoQuincena> GetAll()
			{
				try 
                {
                        List<EstadoQuincena> l = SqlMapper.Query<EstadoQuincena>(con, "API.PA_EstadoQuincenaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  EstadoQuincena  ->" + ex.Message);
				}
			}

			public List<EstadoQuincena> GetAllFull()
			{
				try 
				{
                    List<EstadoQuincena> l = SqlMapper.Query<EstadoQuincena>(con, "API.PA_EstadoQuincenaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  EstadoQuincena  ->" + ex.Message);
				}
			}
			
			public List<EstadoQuincena> GetAllByWithRelation()
			{
				try 
                {
                    List<EstadoQuincena> l = SqlMapper.Query<EstadoQuincena>(con, "API.PA_EstadoQuincenaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  EstadoQuincena  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<EstadoQuincena> GetByFilter(EstadoQuincena pEstadoQuincena, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pEstadoQuincena.id== null || pEstadoQuincena.id==0) ? vintNUll :pEstadoQuincena.id);
                    p.Add("@Nombre",(pEstadoQuincena.Nombre== null) ? vintNUll :pEstadoQuincena.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<EstadoQuincena> l = SqlMapper.Query<EstadoQuincena>(con, "API.PA_EstadoQuincenaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  EstadoQuincena  ->" + ex.Message);
				}
			}

			public EstadoQuincena Add(EstadoQuincena pEstadoQuincena)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pEstadoQuincena.id==null ? 0 : pEstadoQuincena.id);
                    p.Add("@Nombre", pEstadoQuincena.Nombre);
                    p.Add("@auditoria", pEstadoQuincena.auditoria);

                         


                    EstadoQuincena o = SqlMapper.QueryFirstOrDefault<EstadoQuincena>(con, "API.PA_EstadoQuincenaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  EstadoQuincena  ->" + ex.Message);
				}
			}

			public EstadoQuincena  Update(EstadoQuincena pEstadoQuincena)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pEstadoQuincena.id==null ? 0 : pEstadoQuincena.id);
                    p.Add("@Nombre", pEstadoQuincena.Nombre);
                    p.Add("@auditoria", pEstadoQuincena.auditoria);

                         


                    EstadoQuincena o = SqlMapper.QueryFirstOrDefault<EstadoQuincena>(con, "API.PA_EstadoQuincenaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  EstadoQuincena  ->" + ex.Message);
				}
			}

			public bool Delete(EstadoQuincena pEstadoQuincena)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pEstadoQuincena.id);
                    p.Add("@auditoria", pEstadoQuincena.auditoria);

                

 

					EstadoQuincena o = SqlMapper.QueryFirstOrDefault<EstadoQuincena>(con, "API.PA_EstadoQuincenaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) EstadoQuincena  ->" + ex.Message);
				}
			}

		



            public List<EstadoQuincena> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<EstadoQuincena> EstadoQuincenaList = new List<EstadoQuincena>();

                    EstadoQuincenaList = SqlMapper.Query<EstadoQuincena>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return EstadoQuincenaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) EstadoQuincena  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<EstadoQuincena> b)
            {
                DapperPlusManager.Entity<EstadoQuincena>().Table("EstadoQuincena");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}