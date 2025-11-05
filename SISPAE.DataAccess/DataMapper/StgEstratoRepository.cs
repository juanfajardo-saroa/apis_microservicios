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
     /// Clase Abstracta para  StgEstrato
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgEstratoRepository : DataObject , IStgEstrato 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgEstratoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgEstratoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgEstrato GetById(StgEstrato pStgEstrato)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgEstrato.id);                                    


    				StgEstrato o = SqlMapper.QueryFirstOrDefault<StgEstrato>(con, "API.PA_StgEstratoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgEstrato  ->" + ex.Message);
				}
			}

			public List<StgEstrato> GetAll()
			{
				try 
                {
                        List<StgEstrato> l = SqlMapper.Query<StgEstrato>(con, "API.PA_StgEstratoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgEstrato  ->" + ex.Message);
				}
			}

			public List<StgEstrato> GetAllFull()
			{
				try 
				{
                    List<StgEstrato> l = SqlMapper.Query<StgEstrato>(con, "API.PA_StgEstratoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgEstrato  ->" + ex.Message);
				}
			}
			
			public List<StgEstrato> GetAllByWithRelation()
			{
				try 
                {
                    List<StgEstrato> l = SqlMapper.Query<StgEstrato>(con, "API.PA_StgEstratoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgEstrato  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgEstrato> GetByFilter(StgEstrato pStgEstrato, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgEstrato.id== null || pStgEstrato.id==0) ? vintNUll :pStgEstrato.id);
                    p.Add("@IdEstrato",(pStgEstrato.IdEstrato== null) ? vintNUll :pStgEstrato.IdEstrato);
                    p.Add("@Nombre",(pStgEstrato.Nombre== null) ? vintNUll :pStgEstrato.Nombre);
                    p.Add("@FechaCreacion",(pStgEstrato.FechaCreacion== null) ? vintNUll :pStgEstrato.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgEstrato> l = SqlMapper.Query<StgEstrato>(con, "API.PA_StgEstratoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgEstrato  ->" + ex.Message);
				}
			}

			public StgEstrato Add(StgEstrato pStgEstrato)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgEstrato.id==null ? 0 : pStgEstrato.id);
                    p.Add("@IdEstrato", pStgEstrato.IdEstrato);
                    p.Add("@Nombre", pStgEstrato.Nombre);
                    p.Add("@FechaCreacion", pStgEstrato.FechaCreacion);
                    p.Add("@auditoria", pStgEstrato.auditoria);

                         


                    StgEstrato o = SqlMapper.QueryFirstOrDefault<StgEstrato>(con, "API.PA_StgEstratoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgEstrato  ->" + ex.Message);
				}
			}

			public StgEstrato  Update(StgEstrato pStgEstrato)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgEstrato.id==null ? 0 : pStgEstrato.id);
                    p.Add("@IdEstrato", pStgEstrato.IdEstrato);
                    p.Add("@Nombre", pStgEstrato.Nombre);
                    p.Add("@FechaCreacion", pStgEstrato.FechaCreacion);
                    p.Add("@auditoria", pStgEstrato.auditoria);

                         


                    StgEstrato o = SqlMapper.QueryFirstOrDefault<StgEstrato>(con, "API.PA_StgEstratoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgEstrato  ->" + ex.Message);
				}
			}

			public bool Delete(StgEstrato pStgEstrato)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgEstrato.id);
                    p.Add("@auditoria", pStgEstrato.auditoria);

                

 

					StgEstrato o = SqlMapper.QueryFirstOrDefault<StgEstrato>(con, "API.PA_StgEstratoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgEstrato  ->" + ex.Message);
				}
			}

		



            public List<StgEstrato> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgEstrato> StgEstratoList = new List<StgEstrato>();

                    StgEstratoList = SqlMapper.Query<StgEstrato>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgEstratoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgEstrato  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgEstrato> b)
            {
                DapperPlusManager.Entity<StgEstrato>().Table("StgEstrato");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}