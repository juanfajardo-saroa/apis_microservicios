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
     /// Clase Abstracta para  StgInternado
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgInternadoRepository : DataObject , IStgInternado 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgInternadoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgInternadoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgInternado GetById(StgInternado pStgInternado)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgInternado.id);                                    


    				StgInternado o = SqlMapper.QueryFirstOrDefault<StgInternado>(con, "API.PA_StgInternadoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgInternado  ->" + ex.Message);
				}
			}

			public List<StgInternado> GetAll()
			{
				try 
                {
                        List<StgInternado> l = SqlMapper.Query<StgInternado>(con, "API.PA_StgInternadoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgInternado  ->" + ex.Message);
				}
			}

			public List<StgInternado> GetAllFull()
			{
				try 
				{
                    List<StgInternado> l = SqlMapper.Query<StgInternado>(con, "API.PA_StgInternadoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgInternado  ->" + ex.Message);
				}
			}
			
			public List<StgInternado> GetAllByWithRelation()
			{
				try 
                {
                    List<StgInternado> l = SqlMapper.Query<StgInternado>(con, "API.PA_StgInternadoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgInternado  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgInternado> GetByFilter(StgInternado pStgInternado, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgInternado.id== null || pStgInternado.id==0) ? vintNUll :pStgInternado.id);
                    p.Add("@IdInternado",(pStgInternado.IdInternado== null) ? vintNUll :pStgInternado.IdInternado);
                    p.Add("@Nombre",(pStgInternado.Nombre== null) ? vintNUll :pStgInternado.Nombre);
                    p.Add("@FechaCreacion",(pStgInternado.FechaCreacion== null) ? vintNUll :pStgInternado.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgInternado> l = SqlMapper.Query<StgInternado>(con, "API.PA_StgInternadoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgInternado  ->" + ex.Message);
				}
			}

			public StgInternado Add(StgInternado pStgInternado)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgInternado.id==null ? 0 : pStgInternado.id);
                    p.Add("@IdInternado", pStgInternado.IdInternado);
                    p.Add("@Nombre", pStgInternado.Nombre);
                    p.Add("@FechaCreacion", pStgInternado.FechaCreacion);
                    p.Add("@auditoria", pStgInternado.auditoria);

                         


                    StgInternado o = SqlMapper.QueryFirstOrDefault<StgInternado>(con, "API.PA_StgInternadoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgInternado  ->" + ex.Message);
				}
			}

			public StgInternado  Update(StgInternado pStgInternado)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgInternado.id==null ? 0 : pStgInternado.id);
                    p.Add("@IdInternado", pStgInternado.IdInternado);
                    p.Add("@Nombre", pStgInternado.Nombre);
                    p.Add("@FechaCreacion", pStgInternado.FechaCreacion);
                    p.Add("@auditoria", pStgInternado.auditoria);

                         


                    StgInternado o = SqlMapper.QueryFirstOrDefault<StgInternado>(con, "API.PA_StgInternadoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgInternado  ->" + ex.Message);
				}
			}

			public bool Delete(StgInternado pStgInternado)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgInternado.id);
                    p.Add("@auditoria", pStgInternado.auditoria);

                

 

					StgInternado o = SqlMapper.QueryFirstOrDefault<StgInternado>(con, "API.PA_StgInternadoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgInternado  ->" + ex.Message);
				}
			}

		



            public List<StgInternado> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgInternado> StgInternadoList = new List<StgInternado>();

                    StgInternadoList = SqlMapper.Query<StgInternado>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgInternadoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgInternado  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgInternado> b)
            {
                DapperPlusManager.Entity<StgInternado>().Table("StgInternado");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}