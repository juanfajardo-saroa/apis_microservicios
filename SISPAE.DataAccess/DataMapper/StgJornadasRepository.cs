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
     /// Clase Abstracta para  StgJornadas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgJornadasRepository : DataObject , IStgJornadas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgJornadasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgJornadasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgJornadas GetById(StgJornadas pStgJornadas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgJornadas.id);                                    


    				StgJornadas o = SqlMapper.QueryFirstOrDefault<StgJornadas>(con, "API.PA_StgJornadasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgJornadas  ->" + ex.Message);
				}
			}

			public List<StgJornadas> GetAll()
			{
				try 
                {
                        List<StgJornadas> l = SqlMapper.Query<StgJornadas>(con, "API.PA_StgJornadasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgJornadas  ->" + ex.Message);
				}
			}

			public List<StgJornadas> GetAllFull()
			{
				try 
				{
                    List<StgJornadas> l = SqlMapper.Query<StgJornadas>(con, "API.PA_StgJornadasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgJornadas  ->" + ex.Message);
				}
			}
			
			public List<StgJornadas> GetAllByWithRelation()
			{
				try 
                {
                    List<StgJornadas> l = SqlMapper.Query<StgJornadas>(con, "API.PA_StgJornadasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgJornadas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgJornadas> GetByFilter(StgJornadas pStgJornadas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgJornadas.id== null || pStgJornadas.id==0) ? vintNUll :pStgJornadas.id);
                    p.Add("@IdJornada",(pStgJornadas.IdJornada== null) ? vintNUll :pStgJornadas.IdJornada);
                    p.Add("@Nombre",(pStgJornadas.Nombre== null) ? vintNUll :pStgJornadas.Nombre);
                    p.Add("@FechaCreacion",(pStgJornadas.FechaCreacion== null) ? vintNUll :pStgJornadas.FechaCreacion);
                    p.Add("@IdJornadaPae",(pStgJornadas.IdJornadaPae== null || pStgJornadas.IdJornadaPae==0) ? vintNUll :pStgJornadas.IdJornadaPae);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgJornadas> l = SqlMapper.Query<StgJornadas>(con, "API.PA_StgJornadasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgJornadas  ->" + ex.Message);
				}
			}

			public StgJornadas Add(StgJornadas pStgJornadas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgJornadas.id==null ? 0 : pStgJornadas.id);
                    p.Add("@IdJornada", pStgJornadas.IdJornada);
                    p.Add("@Nombre", pStgJornadas.Nombre);
                    p.Add("@FechaCreacion", pStgJornadas.FechaCreacion);
p.Add("@IdJornadaPae",pStgJornadas.IdJornadaPae==null ? 0 : pStgJornadas.IdJornadaPae);
                    p.Add("@auditoria", pStgJornadas.auditoria);

                         


                    StgJornadas o = SqlMapper.QueryFirstOrDefault<StgJornadas>(con, "API.PA_StgJornadasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgJornadas  ->" + ex.Message);
				}
			}

			public StgJornadas  Update(StgJornadas pStgJornadas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgJornadas.id==null ? 0 : pStgJornadas.id);
                    p.Add("@IdJornada", pStgJornadas.IdJornada);
                    p.Add("@Nombre", pStgJornadas.Nombre);
                    p.Add("@FechaCreacion", pStgJornadas.FechaCreacion);
p.Add("@IdJornadaPae",pStgJornadas.IdJornadaPae==null ? 0 : pStgJornadas.IdJornadaPae);
                    p.Add("@auditoria", pStgJornadas.auditoria);

                         


                    StgJornadas o = SqlMapper.QueryFirstOrDefault<StgJornadas>(con, "API.PA_StgJornadasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgJornadas  ->" + ex.Message);
				}
			}

			public bool Delete(StgJornadas pStgJornadas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgJornadas.id);
                    p.Add("@auditoria", pStgJornadas.auditoria);

                

 

					StgJornadas o = SqlMapper.QueryFirstOrDefault<StgJornadas>(con, "API.PA_StgJornadasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgJornadas  ->" + ex.Message);
				}
			}

		



            public List<StgJornadas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgJornadas> StgJornadasList = new List<StgJornadas>();

                    StgJornadasList = SqlMapper.Query<StgJornadas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgJornadasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgJornadas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgJornadas> b)
            {
                DapperPlusManager.Entity<StgJornadas>().Table("StgJornadas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}