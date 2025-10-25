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
     /// Clase Abstracta para  StgValoracion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgValoracionRepository : DataObject , IStgValoracion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgValoracionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgValoracionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgValoracion GetById(StgValoracion pStgValoracion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgValoracion.id);                                    


    				StgValoracion o = SqlMapper.QueryFirstOrDefault<StgValoracion>(con, "API.PA_StgValoracionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgValoracion  ->" + ex.Message);
				}
			}

			public List<StgValoracion> GetAll()
			{
				try 
                {
                        List<StgValoracion> l = SqlMapper.Query<StgValoracion>(con, "API.PA_StgValoracionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgValoracion  ->" + ex.Message);
				}
			}

			public List<StgValoracion> GetAllFull()
			{
				try 
				{
                    List<StgValoracion> l = SqlMapper.Query<StgValoracion>(con, "API.PA_StgValoracionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgValoracion  ->" + ex.Message);
				}
			}
			
			public List<StgValoracion> GetAllByWithRelation()
			{
				try 
                {
                    List<StgValoracion> l = SqlMapper.Query<StgValoracion>(con, "API.PA_StgValoracionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgValoracion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgValoracion> GetByFilter(StgValoracion pStgValoracion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgValoracion.id== null || pStgValoracion.id==0) ? vintNUll :pStgValoracion.id);
                    p.Add("@IdValoracion",(pStgValoracion.IdValoracion== null) ? vintNUll :pStgValoracion.IdValoracion);
                    p.Add("@Nombre",(pStgValoracion.Nombre== null) ? vintNUll :pStgValoracion.Nombre);
                    p.Add("@FechaCreacion",(pStgValoracion.FechaCreacion== null) ? vintNUll :pStgValoracion.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgValoracion> l = SqlMapper.Query<StgValoracion>(con, "API.PA_StgValoracionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgValoracion  ->" + ex.Message);
				}
			}

			public StgValoracion Add(StgValoracion pStgValoracion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgValoracion.id==null ? 0 : pStgValoracion.id);
                    p.Add("@IdValoracion", pStgValoracion.IdValoracion);
                    p.Add("@Nombre", pStgValoracion.Nombre);
                    p.Add("@FechaCreacion", pStgValoracion.FechaCreacion);
                    p.Add("@auditoria", pStgValoracion.auditoria);

                         


                    StgValoracion o = SqlMapper.QueryFirstOrDefault<StgValoracion>(con, "API.PA_StgValoracionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgValoracion  ->" + ex.Message);
				}
			}

			public StgValoracion  Update(StgValoracion pStgValoracion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgValoracion.id==null ? 0 : pStgValoracion.id);
                    p.Add("@IdValoracion", pStgValoracion.IdValoracion);
                    p.Add("@Nombre", pStgValoracion.Nombre);
                    p.Add("@FechaCreacion", pStgValoracion.FechaCreacion);
                    p.Add("@auditoria", pStgValoracion.auditoria);

                         


                    StgValoracion o = SqlMapper.QueryFirstOrDefault<StgValoracion>(con, "API.PA_StgValoracionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgValoracion  ->" + ex.Message);
				}
			}

			public bool Delete(StgValoracion pStgValoracion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgValoracion.id);
                    p.Add("@auditoria", pStgValoracion.auditoria);

                

 

					StgValoracion o = SqlMapper.QueryFirstOrDefault<StgValoracion>(con, "API.PA_StgValoracionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgValoracion  ->" + ex.Message);
				}
			}

		



            public List<StgValoracion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgValoracion> StgValoracionList = new List<StgValoracion>();

                    StgValoracionList = SqlMapper.Query<StgValoracion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgValoracionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgValoracion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgValoracion> b)
            {
                DapperPlusManager.Entity<StgValoracion>().Table("StgValoracion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}