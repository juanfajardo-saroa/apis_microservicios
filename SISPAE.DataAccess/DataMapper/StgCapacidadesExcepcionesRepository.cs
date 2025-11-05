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
     /// Clase Abstracta para  StgCapacidadesExcepciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgCapacidadesExcepcionesRepository : DataObject , IStgCapacidadesExcepciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgCapacidadesExcepcionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgCapacidadesExcepcionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgCapacidadesExcepciones GetById(StgCapacidadesExcepciones pStgCapacidadesExcepciones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgCapacidadesExcepciones.id);                                    


    				StgCapacidadesExcepciones o = SqlMapper.QueryFirstOrDefault<StgCapacidadesExcepciones>(con, "API.PA_StgCapacidadesExcepcionesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgCapacidadesExcepciones  ->" + ex.Message);
				}
			}

			public List<StgCapacidadesExcepciones> GetAll()
			{
				try 
                {
                        List<StgCapacidadesExcepciones> l = SqlMapper.Query<StgCapacidadesExcepciones>(con, "API.PA_StgCapacidadesExcepcionesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgCapacidadesExcepciones  ->" + ex.Message);
				}
			}

			public List<StgCapacidadesExcepciones> GetAllFull()
			{
				try 
				{
                    List<StgCapacidadesExcepciones> l = SqlMapper.Query<StgCapacidadesExcepciones>(con, "API.PA_StgCapacidadesExcepcionesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgCapacidadesExcepciones  ->" + ex.Message);
				}
			}
			
			public List<StgCapacidadesExcepciones> GetAllByWithRelation()
			{
				try 
                {
                    List<StgCapacidadesExcepciones> l = SqlMapper.Query<StgCapacidadesExcepciones>(con, "API.PA_StgCapacidadesExcepcionesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgCapacidadesExcepciones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgCapacidadesExcepciones> GetByFilter(StgCapacidadesExcepciones pStgCapacidadesExcepciones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgCapacidadesExcepciones.id== null || pStgCapacidadesExcepciones.id==0) ? vintNUll :pStgCapacidadesExcepciones.id);
                    p.Add("@IdCapacidadExcep",(pStgCapacidadesExcepciones.IdCapacidadExcep== null) ? vintNUll :pStgCapacidadesExcepciones.IdCapacidadExcep);
                    p.Add("@Nombre",(pStgCapacidadesExcepciones.Nombre== null) ? vintNUll :pStgCapacidadesExcepciones.Nombre);
                    p.Add("@FechaCreacion",(pStgCapacidadesExcepciones.FechaCreacion== null) ? vintNUll :pStgCapacidadesExcepciones.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgCapacidadesExcepciones> l = SqlMapper.Query<StgCapacidadesExcepciones>(con, "API.PA_StgCapacidadesExcepcionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgCapacidadesExcepciones  ->" + ex.Message);
				}
			}

			public StgCapacidadesExcepciones Add(StgCapacidadesExcepciones pStgCapacidadesExcepciones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgCapacidadesExcepciones.id==null ? 0 : pStgCapacidadesExcepciones.id);
                    p.Add("@IdCapacidadExcep", pStgCapacidadesExcepciones.IdCapacidadExcep);
                    p.Add("@Nombre", pStgCapacidadesExcepciones.Nombre);
                    p.Add("@FechaCreacion", pStgCapacidadesExcepciones.FechaCreacion);
                    p.Add("@auditoria", pStgCapacidadesExcepciones.auditoria);

                         


                    StgCapacidadesExcepciones o = SqlMapper.QueryFirstOrDefault<StgCapacidadesExcepciones>(con, "API.PA_StgCapacidadesExcepcionesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgCapacidadesExcepciones  ->" + ex.Message);
				}
			}

			public StgCapacidadesExcepciones  Update(StgCapacidadesExcepciones pStgCapacidadesExcepciones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgCapacidadesExcepciones.id==null ? 0 : pStgCapacidadesExcepciones.id);
                    p.Add("@IdCapacidadExcep", pStgCapacidadesExcepciones.IdCapacidadExcep);
                    p.Add("@Nombre", pStgCapacidadesExcepciones.Nombre);
                    p.Add("@FechaCreacion", pStgCapacidadesExcepciones.FechaCreacion);
                    p.Add("@auditoria", pStgCapacidadesExcepciones.auditoria);

                         


                    StgCapacidadesExcepciones o = SqlMapper.QueryFirstOrDefault<StgCapacidadesExcepciones>(con, "API.PA_StgCapacidadesExcepcionesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgCapacidadesExcepciones  ->" + ex.Message);
				}
			}

			public bool Delete(StgCapacidadesExcepciones pStgCapacidadesExcepciones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgCapacidadesExcepciones.id);
                    p.Add("@auditoria", pStgCapacidadesExcepciones.auditoria);

                

 

					StgCapacidadesExcepciones o = SqlMapper.QueryFirstOrDefault<StgCapacidadesExcepciones>(con, "API.PA_StgCapacidadesExcepcionesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgCapacidadesExcepciones  ->" + ex.Message);
				}
			}

		



            public List<StgCapacidadesExcepciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgCapacidadesExcepciones> StgCapacidadesExcepcionesList = new List<StgCapacidadesExcepciones>();

                    StgCapacidadesExcepcionesList = SqlMapper.Query<StgCapacidadesExcepciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgCapacidadesExcepcionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgCapacidadesExcepciones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgCapacidadesExcepciones> b)
            {
                DapperPlusManager.Entity<StgCapacidadesExcepciones>().Table("StgCapacidadesExcepciones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}