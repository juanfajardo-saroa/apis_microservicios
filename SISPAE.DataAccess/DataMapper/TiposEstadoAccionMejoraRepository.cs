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
     /// Clase Abstracta para  TiposEstadoAccionMejora
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposEstadoAccionMejoraRepository : DataObject , ITiposEstadoAccionMejora 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposEstadoAccionMejoraRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposEstadoAccionMejoraRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposEstadoAccionMejora GetById(TiposEstadoAccionMejora pTiposEstadoAccionMejora)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadoAccionMejora.id);                                    


    				TiposEstadoAccionMejora o = SqlMapper.QueryFirstOrDefault<TiposEstadoAccionMejora>(con, "API.PA_TiposEstadoAccionMejoraGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposEstadoAccionMejora  ->" + ex.Message);
				}
			}

			public List<TiposEstadoAccionMejora> GetAll()
			{
				try 
                {
                        List<TiposEstadoAccionMejora> l = SqlMapper.Query<TiposEstadoAccionMejora>(con, "API.PA_TiposEstadoAccionMejoraGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposEstadoAccionMejora  ->" + ex.Message);
				}
			}

			public List<TiposEstadoAccionMejora> GetAllFull()
			{
				try 
				{
                    List<TiposEstadoAccionMejora> l = SqlMapper.Query<TiposEstadoAccionMejora>(con, "API.PA_TiposEstadoAccionMejoraGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposEstadoAccionMejora  ->" + ex.Message);
				}
			}
			
			public List<TiposEstadoAccionMejora> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposEstadoAccionMejora> l = SqlMapper.Query<TiposEstadoAccionMejora>(con, "API.PA_TiposEstadoAccionMejoraGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposEstadoAccionMejora  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposEstadoAccionMejora> GetByFilter(TiposEstadoAccionMejora pTiposEstadoAccionMejora, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposEstadoAccionMejora.id== null || pTiposEstadoAccionMejora.id==0) ? vintNUll :pTiposEstadoAccionMejora.id);
                    p.Add("@nombre",(pTiposEstadoAccionMejora.nombre== null) ? vintNUll :pTiposEstadoAccionMejora.nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposEstadoAccionMejora> l = SqlMapper.Query<TiposEstadoAccionMejora>(con, "API.PA_TiposEstadoAccionMejoraGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposEstadoAccionMejora  ->" + ex.Message);
				}
			}

			public TiposEstadoAccionMejora Add(TiposEstadoAccionMejora pTiposEstadoAccionMejora)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposEstadoAccionMejora.id==null ? 0 : pTiposEstadoAccionMejora.id);
                    p.Add("@nombre", pTiposEstadoAccionMejora.nombre);
                    p.Add("@auditoria", pTiposEstadoAccionMejora.auditoria);

                         


                    TiposEstadoAccionMejora o = SqlMapper.QueryFirstOrDefault<TiposEstadoAccionMejora>(con, "API.PA_TiposEstadoAccionMejoraAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposEstadoAccionMejora  ->" + ex.Message);
				}
			}

			public TiposEstadoAccionMejora  Update(TiposEstadoAccionMejora pTiposEstadoAccionMejora)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposEstadoAccionMejora.id==null ? 0 : pTiposEstadoAccionMejora.id);
                    p.Add("@nombre", pTiposEstadoAccionMejora.nombre);
                    p.Add("@auditoria", pTiposEstadoAccionMejora.auditoria);

                         


                    TiposEstadoAccionMejora o = SqlMapper.QueryFirstOrDefault<TiposEstadoAccionMejora>(con, "API.PA_TiposEstadoAccionMejoraUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposEstadoAccionMejora  ->" + ex.Message);
				}
			}

			public bool Delete(TiposEstadoAccionMejora pTiposEstadoAccionMejora)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadoAccionMejora.id);
                    p.Add("@auditoria", pTiposEstadoAccionMejora.auditoria);

                

 

					TiposEstadoAccionMejora o = SqlMapper.QueryFirstOrDefault<TiposEstadoAccionMejora>(con, "API.PA_TiposEstadoAccionMejoraDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposEstadoAccionMejora  ->" + ex.Message);
				}
			}

		



            public List<TiposEstadoAccionMejora> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposEstadoAccionMejora> TiposEstadoAccionMejoraList = new List<TiposEstadoAccionMejora>();

                    TiposEstadoAccionMejoraList = SqlMapper.Query<TiposEstadoAccionMejora>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposEstadoAccionMejoraList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposEstadoAccionMejora  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposEstadoAccionMejora> b)
            {
                DapperPlusManager.Entity<TiposEstadoAccionMejora>().Table("TiposEstadoAccionMejora");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}