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
     /// Clase Abstracta para  TiposEstadoValidacionEntrega
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposEstadoValidacionEntregaRepository : DataObject , ITiposEstadoValidacionEntrega 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposEstadoValidacionEntregaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposEstadoValidacionEntregaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposEstadoValidacionEntrega GetById(TiposEstadoValidacionEntrega pTiposEstadoValidacionEntrega)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadoValidacionEntrega.id);                                    


    				TiposEstadoValidacionEntrega o = SqlMapper.QueryFirstOrDefault<TiposEstadoValidacionEntrega>(con, "API.PA_TiposEstadoValidacionEntregaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposEstadoValidacionEntrega  ->" + ex.Message);
				}
			}

			public List<TiposEstadoValidacionEntrega> GetAll()
			{
				try 
                {
                        List<TiposEstadoValidacionEntrega> l = SqlMapper.Query<TiposEstadoValidacionEntrega>(con, "API.PA_TiposEstadoValidacionEntregaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposEstadoValidacionEntrega  ->" + ex.Message);
				}
			}

			public List<TiposEstadoValidacionEntrega> GetAllFull()
			{
				try 
				{
                    List<TiposEstadoValidacionEntrega> l = SqlMapper.Query<TiposEstadoValidacionEntrega>(con, "API.PA_TiposEstadoValidacionEntregaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposEstadoValidacionEntrega  ->" + ex.Message);
				}
			}
			
			public List<TiposEstadoValidacionEntrega> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposEstadoValidacionEntrega> l = SqlMapper.Query<TiposEstadoValidacionEntrega>(con, "API.PA_TiposEstadoValidacionEntregaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposEstadoValidacionEntrega  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposEstadoValidacionEntrega> GetByFilter(TiposEstadoValidacionEntrega pTiposEstadoValidacionEntrega, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposEstadoValidacionEntrega.id== null || pTiposEstadoValidacionEntrega.id==0) ? vintNUll :pTiposEstadoValidacionEntrega.id);
                    p.Add("@Nombre",(pTiposEstadoValidacionEntrega.Nombre== null) ? vintNUll :pTiposEstadoValidacionEntrega.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposEstadoValidacionEntrega> l = SqlMapper.Query<TiposEstadoValidacionEntrega>(con, "API.PA_TiposEstadoValidacionEntregaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposEstadoValidacionEntrega  ->" + ex.Message);
				}
			}

			public TiposEstadoValidacionEntrega Add(TiposEstadoValidacionEntrega pTiposEstadoValidacionEntrega)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposEstadoValidacionEntrega.id==null ? 0 : pTiposEstadoValidacionEntrega.id);
                    p.Add("@Nombre", pTiposEstadoValidacionEntrega.Nombre);
                    p.Add("@auditoria", pTiposEstadoValidacionEntrega.auditoria);

                         


                    TiposEstadoValidacionEntrega o = SqlMapper.QueryFirstOrDefault<TiposEstadoValidacionEntrega>(con, "API.PA_TiposEstadoValidacionEntregaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposEstadoValidacionEntrega  ->" + ex.Message);
				}
			}

			public TiposEstadoValidacionEntrega  Update(TiposEstadoValidacionEntrega pTiposEstadoValidacionEntrega)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposEstadoValidacionEntrega.id==null ? 0 : pTiposEstadoValidacionEntrega.id);
                    p.Add("@Nombre", pTiposEstadoValidacionEntrega.Nombre);
                    p.Add("@auditoria", pTiposEstadoValidacionEntrega.auditoria);

                         


                    TiposEstadoValidacionEntrega o = SqlMapper.QueryFirstOrDefault<TiposEstadoValidacionEntrega>(con, "API.PA_TiposEstadoValidacionEntregaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposEstadoValidacionEntrega  ->" + ex.Message);
				}
			}

			public bool Delete(TiposEstadoValidacionEntrega pTiposEstadoValidacionEntrega)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadoValidacionEntrega.id);
                    p.Add("@auditoria", pTiposEstadoValidacionEntrega.auditoria);

                

 

					TiposEstadoValidacionEntrega o = SqlMapper.QueryFirstOrDefault<TiposEstadoValidacionEntrega>(con, "API.PA_TiposEstadoValidacionEntregaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposEstadoValidacionEntrega  ->" + ex.Message);
				}
			}

		



            public List<TiposEstadoValidacionEntrega> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposEstadoValidacionEntrega> TiposEstadoValidacionEntregaList = new List<TiposEstadoValidacionEntrega>();

                    TiposEstadoValidacionEntregaList = SqlMapper.Query<TiposEstadoValidacionEntrega>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposEstadoValidacionEntregaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposEstadoValidacionEntrega  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposEstadoValidacionEntrega> b)
            {
                DapperPlusManager.Entity<TiposEstadoValidacionEntrega>().Table("TiposEstadoValidacionEntrega");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}