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
     /// Clase Abstracta para  StgPaises
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgPaisesRepository : DataObject , IStgPaises 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgPaisesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgPaisesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgPaises GetById(StgPaises pStgPaises)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgPaises.id);                                    


    				StgPaises o = SqlMapper.QueryFirstOrDefault<StgPaises>(con, "API.PA_StgPaisesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgPaises  ->" + ex.Message);
				}
			}

			public List<StgPaises> GetAll()
			{
				try 
                {
                        List<StgPaises> l = SqlMapper.Query<StgPaises>(con, "API.PA_StgPaisesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgPaises  ->" + ex.Message);
				}
			}

			public List<StgPaises> GetAllFull()
			{
				try 
				{
                    List<StgPaises> l = SqlMapper.Query<StgPaises>(con, "API.PA_StgPaisesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgPaises  ->" + ex.Message);
				}
			}
			
			public List<StgPaises> GetAllByWithRelation()
			{
				try 
                {
                    List<StgPaises> l = SqlMapper.Query<StgPaises>(con, "API.PA_StgPaisesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgPaises  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgPaises> GetByFilter(StgPaises pStgPaises, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgPaises.id== null || pStgPaises.id==0) ? vintNUll :pStgPaises.id);
                    p.Add("@IdPais",(pStgPaises.IdPais== null || pStgPaises.IdPais==0) ? vintNUll :pStgPaises.IdPais);
                    p.Add("@Nombre",(pStgPaises.Nombre== null) ? vintNUll :pStgPaises.Nombre);
                    p.Add("@Cod",(pStgPaises.Cod== null) ? vintNUll :pStgPaises.Cod);
                    p.Add("@FechaCreacion",(pStgPaises.FechaCreacion== null) ? vintNUll :pStgPaises.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgPaises> l = SqlMapper.Query<StgPaises>(con, "API.PA_StgPaisesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgPaises  ->" + ex.Message);
				}
			}

			public StgPaises Add(StgPaises pStgPaises)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgPaises.id==null ? 0 : pStgPaises.id);
p.Add("@IdPais",pStgPaises.IdPais==null ? 0 : pStgPaises.IdPais);
                    p.Add("@Nombre", pStgPaises.Nombre);
                    p.Add("@Cod", pStgPaises.Cod);
                    p.Add("@FechaCreacion", pStgPaises.FechaCreacion);
                    p.Add("@auditoria", pStgPaises.auditoria);

                         


                    StgPaises o = SqlMapper.QueryFirstOrDefault<StgPaises>(con, "API.PA_StgPaisesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgPaises  ->" + ex.Message);
				}
			}

			public StgPaises  Update(StgPaises pStgPaises)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgPaises.id==null ? 0 : pStgPaises.id);
p.Add("@IdPais",pStgPaises.IdPais==null ? 0 : pStgPaises.IdPais);
                    p.Add("@Nombre", pStgPaises.Nombre);
                    p.Add("@Cod", pStgPaises.Cod);
                    p.Add("@FechaCreacion", pStgPaises.FechaCreacion);
                    p.Add("@auditoria", pStgPaises.auditoria);

                         


                    StgPaises o = SqlMapper.QueryFirstOrDefault<StgPaises>(con, "API.PA_StgPaisesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgPaises  ->" + ex.Message);
				}
			}

			public bool Delete(StgPaises pStgPaises)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgPaises.id);
                    p.Add("@auditoria", pStgPaises.auditoria);

                

 

					StgPaises o = SqlMapper.QueryFirstOrDefault<StgPaises>(con, "API.PA_StgPaisesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgPaises  ->" + ex.Message);
				}
			}

		



            public List<StgPaises> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgPaises> StgPaisesList = new List<StgPaises>();

                    StgPaisesList = SqlMapper.Query<StgPaises>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgPaisesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgPaises  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgPaises> b)
            {
                DapperPlusManager.Entity<StgPaises>().Table("StgPaises");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}