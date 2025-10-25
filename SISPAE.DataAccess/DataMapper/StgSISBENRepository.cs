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
     /// Clase Abstracta para  StgSISBEN
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgSISBENRepository : DataObject , IStgSISBEN 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgSISBENRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgSISBENRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgSISBEN GetById(StgSISBEN pStgSISBEN)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgSISBEN.id);                                    


    				StgSISBEN o = SqlMapper.QueryFirstOrDefault<StgSISBEN>(con, "API.PA_StgSISBENGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgSISBEN  ->" + ex.Message);
				}
			}

			public List<StgSISBEN> GetAll()
			{
				try 
                {
                        List<StgSISBEN> l = SqlMapper.Query<StgSISBEN>(con, "API.PA_StgSISBENGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgSISBEN  ->" + ex.Message);
				}
			}

			public List<StgSISBEN> GetAllFull()
			{
				try 
				{
                    List<StgSISBEN> l = SqlMapper.Query<StgSISBEN>(con, "API.PA_StgSISBENGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgSISBEN  ->" + ex.Message);
				}
			}
			
			public List<StgSISBEN> GetAllByWithRelation()
			{
				try 
                {
                    List<StgSISBEN> l = SqlMapper.Query<StgSISBEN>(con, "API.PA_StgSISBENGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgSISBEN  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgSISBEN> GetByFilter(StgSISBEN pStgSISBEN, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgSISBEN.id== null || pStgSISBEN.id==0) ? vintNUll :pStgSISBEN.id);
                    p.Add("@IdSISBEN",(pStgSISBEN.IdSISBEN== null) ? vintNUll :pStgSISBEN.IdSISBEN);
                    p.Add("@Nombre",(pStgSISBEN.Nombre== null) ? vintNUll :pStgSISBEN.Nombre);
                    p.Add("@FechaCreacion",(pStgSISBEN.FechaCreacion== null) ? vintNUll :pStgSISBEN.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgSISBEN> l = SqlMapper.Query<StgSISBEN>(con, "API.PA_StgSISBENGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgSISBEN  ->" + ex.Message);
				}
			}

			public StgSISBEN Add(StgSISBEN pStgSISBEN)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgSISBEN.id==null ? 0 : pStgSISBEN.id);
                    p.Add("@IdSISBEN", pStgSISBEN.IdSISBEN);
                    p.Add("@Nombre", pStgSISBEN.Nombre);
                    p.Add("@FechaCreacion", pStgSISBEN.FechaCreacion);
                    p.Add("@auditoria", pStgSISBEN.auditoria);

                         


                    StgSISBEN o = SqlMapper.QueryFirstOrDefault<StgSISBEN>(con, "API.PA_StgSISBENAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgSISBEN  ->" + ex.Message);
				}
			}

			public StgSISBEN  Update(StgSISBEN pStgSISBEN)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgSISBEN.id==null ? 0 : pStgSISBEN.id);
                    p.Add("@IdSISBEN", pStgSISBEN.IdSISBEN);
                    p.Add("@Nombre", pStgSISBEN.Nombre);
                    p.Add("@FechaCreacion", pStgSISBEN.FechaCreacion);
                    p.Add("@auditoria", pStgSISBEN.auditoria);

                         


                    StgSISBEN o = SqlMapper.QueryFirstOrDefault<StgSISBEN>(con, "API.PA_StgSISBENUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgSISBEN  ->" + ex.Message);
				}
			}

			public bool Delete(StgSISBEN pStgSISBEN)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgSISBEN.id);
                    p.Add("@auditoria", pStgSISBEN.auditoria);

                

 

					StgSISBEN o = SqlMapper.QueryFirstOrDefault<StgSISBEN>(con, "API.PA_StgSISBENDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgSISBEN  ->" + ex.Message);
				}
			}

		



            public List<StgSISBEN> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgSISBEN> StgSISBENList = new List<StgSISBEN>();

                    StgSISBENList = SqlMapper.Query<StgSISBEN>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgSISBENList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgSISBEN  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgSISBEN> b)
            {
                DapperPlusManager.Entity<StgSISBEN>().Table("StgSISBEN");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}