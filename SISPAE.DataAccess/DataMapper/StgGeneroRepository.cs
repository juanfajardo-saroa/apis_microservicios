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
     /// Clase Abstracta para  StgGenero
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgGeneroRepository : DataObject , IStgGenero 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgGeneroRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgGeneroRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgGenero GetById(StgGenero pStgGenero)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgGenero.id);                                    


    				StgGenero o = SqlMapper.QueryFirstOrDefault<StgGenero>(con, "API.PA_StgGeneroGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgGenero  ->" + ex.Message);
				}
			}

			public List<StgGenero> GetAll()
			{
				try 
                {
                        List<StgGenero> l = SqlMapper.Query<StgGenero>(con, "API.PA_StgGeneroGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgGenero  ->" + ex.Message);
				}
			}

			public List<StgGenero> GetAllFull()
			{
				try 
				{
                    List<StgGenero> l = SqlMapper.Query<StgGenero>(con, "API.PA_StgGeneroGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgGenero  ->" + ex.Message);
				}
			}
			
			public List<StgGenero> GetAllByWithRelation()
			{
				try 
                {
                    List<StgGenero> l = SqlMapper.Query<StgGenero>(con, "API.PA_StgGeneroGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgGenero  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgGenero> GetByFilter(StgGenero pStgGenero, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgGenero.id== null || pStgGenero.id==0) ? vintNUll :pStgGenero.id);
                    p.Add("@IdGenero",(pStgGenero.IdGenero== null) ? vintNUll :pStgGenero.IdGenero);
                    p.Add("@Nombre",(pStgGenero.Nombre== null) ? vintNUll :pStgGenero.Nombre);
                    p.Add("@FechaCreacion",(pStgGenero.FechaCreacion== null) ? vintNUll :pStgGenero.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgGenero> l = SqlMapper.Query<StgGenero>(con, "API.PA_StgGeneroGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgGenero  ->" + ex.Message);
				}
			}

			public StgGenero Add(StgGenero pStgGenero)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgGenero.id==null ? 0 : pStgGenero.id);
                    p.Add("@IdGenero", pStgGenero.IdGenero);
                    p.Add("@Nombre", pStgGenero.Nombre);
                    p.Add("@FechaCreacion", pStgGenero.FechaCreacion);
                    p.Add("@auditoria", pStgGenero.auditoria);

                         


                    StgGenero o = SqlMapper.QueryFirstOrDefault<StgGenero>(con, "API.PA_StgGeneroAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgGenero  ->" + ex.Message);
				}
			}

			public StgGenero  Update(StgGenero pStgGenero)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgGenero.id==null ? 0 : pStgGenero.id);
                    p.Add("@IdGenero", pStgGenero.IdGenero);
                    p.Add("@Nombre", pStgGenero.Nombre);
                    p.Add("@FechaCreacion", pStgGenero.FechaCreacion);
                    p.Add("@auditoria", pStgGenero.auditoria);

                         


                    StgGenero o = SqlMapper.QueryFirstOrDefault<StgGenero>(con, "API.PA_StgGeneroUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgGenero  ->" + ex.Message);
				}
			}

			public bool Delete(StgGenero pStgGenero)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgGenero.id);
                    p.Add("@auditoria", pStgGenero.auditoria);

                

 

					StgGenero o = SqlMapper.QueryFirstOrDefault<StgGenero>(con, "API.PA_StgGeneroDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgGenero  ->" + ex.Message);
				}
			}

		



            public List<StgGenero> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgGenero> StgGeneroList = new List<StgGenero>();

                    StgGeneroList = SqlMapper.Query<StgGenero>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgGeneroList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgGenero  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgGenero> b)
            {
                DapperPlusManager.Entity<StgGenero>().Table("StgGenero");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}