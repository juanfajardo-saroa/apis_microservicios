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
     /// Clase Abstracta para  StgEspecialidad
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgEspecialidadRepository : DataObject , IStgEspecialidad 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgEspecialidadRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgEspecialidadRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgEspecialidad GetById(StgEspecialidad pStgEspecialidad)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgEspecialidad.id);                                    


    				StgEspecialidad o = SqlMapper.QueryFirstOrDefault<StgEspecialidad>(con, "API.PA_StgEspecialidadGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgEspecialidad  ->" + ex.Message);
				}
			}

			public List<StgEspecialidad> GetAll()
			{
				try 
                {
                        List<StgEspecialidad> l = SqlMapper.Query<StgEspecialidad>(con, "API.PA_StgEspecialidadGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgEspecialidad  ->" + ex.Message);
				}
			}

			public List<StgEspecialidad> GetAllFull()
			{
				try 
				{
                    List<StgEspecialidad> l = SqlMapper.Query<StgEspecialidad>(con, "API.PA_StgEspecialidadGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgEspecialidad  ->" + ex.Message);
				}
			}
			
			public List<StgEspecialidad> GetAllByWithRelation()
			{
				try 
                {
                    List<StgEspecialidad> l = SqlMapper.Query<StgEspecialidad>(con, "API.PA_StgEspecialidadGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgEspecialidad  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgEspecialidad> GetByFilter(StgEspecialidad pStgEspecialidad, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgEspecialidad.id== null || pStgEspecialidad.id==0) ? vintNUll :pStgEspecialidad.id);
                    p.Add("@IdEspecialidad",(pStgEspecialidad.IdEspecialidad== null) ? vintNUll :pStgEspecialidad.IdEspecialidad);
                    p.Add("@Nombre",(pStgEspecialidad.Nombre== null) ? vintNUll :pStgEspecialidad.Nombre);
                    p.Add("@FechaCreacion",(pStgEspecialidad.FechaCreacion== null) ? vintNUll :pStgEspecialidad.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgEspecialidad> l = SqlMapper.Query<StgEspecialidad>(con, "API.PA_StgEspecialidadGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgEspecialidad  ->" + ex.Message);
				}
			}

			public StgEspecialidad Add(StgEspecialidad pStgEspecialidad)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgEspecialidad.id==null ? 0 : pStgEspecialidad.id);
                    p.Add("@IdEspecialidad", pStgEspecialidad.IdEspecialidad);
                    p.Add("@Nombre", pStgEspecialidad.Nombre);
                    p.Add("@FechaCreacion", pStgEspecialidad.FechaCreacion);
                    p.Add("@auditoria", pStgEspecialidad.auditoria);

                         


                    StgEspecialidad o = SqlMapper.QueryFirstOrDefault<StgEspecialidad>(con, "API.PA_StgEspecialidadAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgEspecialidad  ->" + ex.Message);
				}
			}

			public StgEspecialidad  Update(StgEspecialidad pStgEspecialidad)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgEspecialidad.id==null ? 0 : pStgEspecialidad.id);
                    p.Add("@IdEspecialidad", pStgEspecialidad.IdEspecialidad);
                    p.Add("@Nombre", pStgEspecialidad.Nombre);
                    p.Add("@FechaCreacion", pStgEspecialidad.FechaCreacion);
                    p.Add("@auditoria", pStgEspecialidad.auditoria);

                         


                    StgEspecialidad o = SqlMapper.QueryFirstOrDefault<StgEspecialidad>(con, "API.PA_StgEspecialidadUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgEspecialidad  ->" + ex.Message);
				}
			}

			public bool Delete(StgEspecialidad pStgEspecialidad)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgEspecialidad.id);
                    p.Add("@auditoria", pStgEspecialidad.auditoria);

                

 

					StgEspecialidad o = SqlMapper.QueryFirstOrDefault<StgEspecialidad>(con, "API.PA_StgEspecialidadDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgEspecialidad  ->" + ex.Message);
				}
			}

		



            public List<StgEspecialidad> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgEspecialidad> StgEspecialidadList = new List<StgEspecialidad>();

                    StgEspecialidadList = SqlMapper.Query<StgEspecialidad>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgEspecialidadList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgEspecialidad  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgEspecialidad> b)
            {
                DapperPlusManager.Entity<StgEspecialidad>().Table("StgEspecialidad");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}