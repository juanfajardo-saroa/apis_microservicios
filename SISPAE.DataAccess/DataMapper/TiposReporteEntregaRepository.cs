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
     /// Clase Abstracta para  TiposReporteEntrega
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposReporteEntregaRepository : DataObject , ITiposReporteEntrega 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposReporteEntregaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposReporteEntregaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposReporteEntrega GetById(TiposReporteEntrega pTiposReporteEntrega)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposReporteEntrega.id);                                    


    				TiposReporteEntrega o = SqlMapper.QueryFirstOrDefault<TiposReporteEntrega>(con, "API.PA_TiposReporteEntregaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposReporteEntrega  ->" + ex.Message);
				}
			}

			public List<TiposReporteEntrega> GetAll()
			{
				try 
                {
                        List<TiposReporteEntrega> l = SqlMapper.Query<TiposReporteEntrega>(con, "API.PA_TiposReporteEntregaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposReporteEntrega  ->" + ex.Message);
				}
			}

			public List<TiposReporteEntrega> GetAllFull()
			{
				try 
				{
                    List<TiposReporteEntrega> l = SqlMapper.Query<TiposReporteEntrega>(con, "API.PA_TiposReporteEntregaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposReporteEntrega  ->" + ex.Message);
				}
			}
			
			public List<TiposReporteEntrega> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposReporteEntrega> l = SqlMapper.Query<TiposReporteEntrega>(con, "API.PA_TiposReporteEntregaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposReporteEntrega  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposReporteEntrega> GetByFilter(TiposReporteEntrega pTiposReporteEntrega, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposReporteEntrega.id== null || pTiposReporteEntrega.id==0) ? vintNUll :pTiposReporteEntrega.id);
                    p.Add("@Nombre",(pTiposReporteEntrega.Nombre== null) ? vintNUll :pTiposReporteEntrega.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposReporteEntrega> l = SqlMapper.Query<TiposReporteEntrega>(con, "API.PA_TiposReporteEntregaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposReporteEntrega  ->" + ex.Message);
				}
			}

			public TiposReporteEntrega Add(TiposReporteEntrega pTiposReporteEntrega)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposReporteEntrega.id==null ? 0 : pTiposReporteEntrega.id);
                    p.Add("@Nombre", pTiposReporteEntrega.Nombre);
                    p.Add("@auditoria", pTiposReporteEntrega.auditoria);

                         


                    TiposReporteEntrega o = SqlMapper.QueryFirstOrDefault<TiposReporteEntrega>(con, "API.PA_TiposReporteEntregaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposReporteEntrega  ->" + ex.Message);
				}
			}

			public TiposReporteEntrega  Update(TiposReporteEntrega pTiposReporteEntrega)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposReporteEntrega.id==null ? 0 : pTiposReporteEntrega.id);
                    p.Add("@Nombre", pTiposReporteEntrega.Nombre);
                    p.Add("@auditoria", pTiposReporteEntrega.auditoria);

                         


                    TiposReporteEntrega o = SqlMapper.QueryFirstOrDefault<TiposReporteEntrega>(con, "API.PA_TiposReporteEntregaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposReporteEntrega  ->" + ex.Message);
				}
			}

			public bool Delete(TiposReporteEntrega pTiposReporteEntrega)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposReporteEntrega.id);
                    p.Add("@auditoria", pTiposReporteEntrega.auditoria);

                

 

					TiposReporteEntrega o = SqlMapper.QueryFirstOrDefault<TiposReporteEntrega>(con, "API.PA_TiposReporteEntregaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposReporteEntrega  ->" + ex.Message);
				}
			}

		



            public List<TiposReporteEntrega> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposReporteEntrega> TiposReporteEntregaList = new List<TiposReporteEntrega>();

                    TiposReporteEntregaList = SqlMapper.Query<TiposReporteEntrega>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposReporteEntregaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposReporteEntrega  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposReporteEntrega> b)
            {
                DapperPlusManager.Entity<TiposReporteEntrega>().Table("TiposReporteEntrega");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}