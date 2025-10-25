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
     /// Clase Abstracta para  StgTipoDiscapacidad
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgTipoDiscapacidadRepository : DataObject , IStgTipoDiscapacidad 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgTipoDiscapacidadRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgTipoDiscapacidadRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgTipoDiscapacidad GetById(StgTipoDiscapacidad pStgTipoDiscapacidad)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgTipoDiscapacidad.id);                                    


    				StgTipoDiscapacidad o = SqlMapper.QueryFirstOrDefault<StgTipoDiscapacidad>(con, "API.PA_StgTipoDiscapacidadGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgTipoDiscapacidad  ->" + ex.Message);
				}
			}

			public List<StgTipoDiscapacidad> GetAll()
			{
				try 
                {
                        List<StgTipoDiscapacidad> l = SqlMapper.Query<StgTipoDiscapacidad>(con, "API.PA_StgTipoDiscapacidadGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgTipoDiscapacidad  ->" + ex.Message);
				}
			}

			public List<StgTipoDiscapacidad> GetAllFull()
			{
				try 
				{
                    List<StgTipoDiscapacidad> l = SqlMapper.Query<StgTipoDiscapacidad>(con, "API.PA_StgTipoDiscapacidadGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgTipoDiscapacidad  ->" + ex.Message);
				}
			}
			
			public List<StgTipoDiscapacidad> GetAllByWithRelation()
			{
				try 
                {
                    List<StgTipoDiscapacidad> l = SqlMapper.Query<StgTipoDiscapacidad>(con, "API.PA_StgTipoDiscapacidadGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgTipoDiscapacidad  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgTipoDiscapacidad> GetByFilter(StgTipoDiscapacidad pStgTipoDiscapacidad, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgTipoDiscapacidad.id== null || pStgTipoDiscapacidad.id==0) ? vintNUll :pStgTipoDiscapacidad.id);
                    p.Add("@IdTipoDiscapacidad",(pStgTipoDiscapacidad.IdTipoDiscapacidad== null) ? vintNUll :pStgTipoDiscapacidad.IdTipoDiscapacidad);
                    p.Add("@Nombre",(pStgTipoDiscapacidad.Nombre== null) ? vintNUll :pStgTipoDiscapacidad.Nombre);
                    p.Add("@FechaCreacion",(pStgTipoDiscapacidad.FechaCreacion== null) ? vintNUll :pStgTipoDiscapacidad.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgTipoDiscapacidad> l = SqlMapper.Query<StgTipoDiscapacidad>(con, "API.PA_StgTipoDiscapacidadGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgTipoDiscapacidad  ->" + ex.Message);
				}
			}

			public StgTipoDiscapacidad Add(StgTipoDiscapacidad pStgTipoDiscapacidad)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgTipoDiscapacidad.id==null ? 0 : pStgTipoDiscapacidad.id);
                    p.Add("@IdTipoDiscapacidad", pStgTipoDiscapacidad.IdTipoDiscapacidad);
                    p.Add("@Nombre", pStgTipoDiscapacidad.Nombre);
                    p.Add("@FechaCreacion", pStgTipoDiscapacidad.FechaCreacion);
                    p.Add("@auditoria", pStgTipoDiscapacidad.auditoria);

                         


                    StgTipoDiscapacidad o = SqlMapper.QueryFirstOrDefault<StgTipoDiscapacidad>(con, "API.PA_StgTipoDiscapacidadAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgTipoDiscapacidad  ->" + ex.Message);
				}
			}

			public StgTipoDiscapacidad  Update(StgTipoDiscapacidad pStgTipoDiscapacidad)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgTipoDiscapacidad.id==null ? 0 : pStgTipoDiscapacidad.id);
                    p.Add("@IdTipoDiscapacidad", pStgTipoDiscapacidad.IdTipoDiscapacidad);
                    p.Add("@Nombre", pStgTipoDiscapacidad.Nombre);
                    p.Add("@FechaCreacion", pStgTipoDiscapacidad.FechaCreacion);
                    p.Add("@auditoria", pStgTipoDiscapacidad.auditoria);

                         


                    StgTipoDiscapacidad o = SqlMapper.QueryFirstOrDefault<StgTipoDiscapacidad>(con, "API.PA_StgTipoDiscapacidadUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgTipoDiscapacidad  ->" + ex.Message);
				}
			}

			public bool Delete(StgTipoDiscapacidad pStgTipoDiscapacidad)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgTipoDiscapacidad.id);
                    p.Add("@auditoria", pStgTipoDiscapacidad.auditoria);

                

 

					StgTipoDiscapacidad o = SqlMapper.QueryFirstOrDefault<StgTipoDiscapacidad>(con, "API.PA_StgTipoDiscapacidadDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgTipoDiscapacidad  ->" + ex.Message);
				}
			}

		



            public List<StgTipoDiscapacidad> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgTipoDiscapacidad> StgTipoDiscapacidadList = new List<StgTipoDiscapacidad>();

                    StgTipoDiscapacidadList = SqlMapper.Query<StgTipoDiscapacidad>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgTipoDiscapacidadList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgTipoDiscapacidad  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgTipoDiscapacidad> b)
            {
                DapperPlusManager.Entity<StgTipoDiscapacidad>().Table("StgTipoDiscapacidad");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}