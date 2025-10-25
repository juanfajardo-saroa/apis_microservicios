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
     /// Clase Abstracta para  TiposEstadoPagos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposEstadoPagosRepository : DataObject , ITiposEstadoPagos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposEstadoPagosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposEstadoPagosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposEstadoPagos GetById(TiposEstadoPagos pTiposEstadoPagos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadoPagos.id);                                    


    				TiposEstadoPagos o = SqlMapper.QueryFirstOrDefault<TiposEstadoPagos>(con, "API.PA_TiposEstadoPagosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposEstadoPagos  ->" + ex.Message);
				}
			}

			public List<TiposEstadoPagos> GetAll()
			{
				try 
                {
                        List<TiposEstadoPagos> l = SqlMapper.Query<TiposEstadoPagos>(con, "API.PA_TiposEstadoPagosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposEstadoPagos  ->" + ex.Message);
				}
			}

			public List<TiposEstadoPagos> GetAllFull()
			{
				try 
				{
                    List<TiposEstadoPagos> l = SqlMapper.Query<TiposEstadoPagos>(con, "API.PA_TiposEstadoPagosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposEstadoPagos  ->" + ex.Message);
				}
			}
			
			public List<TiposEstadoPagos> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposEstadoPagos> l = SqlMapper.Query<TiposEstadoPagos>(con, "API.PA_TiposEstadoPagosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposEstadoPagos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposEstadoPagos> GetByFilter(TiposEstadoPagos pTiposEstadoPagos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposEstadoPagos.id== null || pTiposEstadoPagos.id==0) ? vintNUll :pTiposEstadoPagos.id);
                    p.Add("@Nombre",(pTiposEstadoPagos.Nombre== null) ? vintNUll :pTiposEstadoPagos.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposEstadoPagos> l = SqlMapper.Query<TiposEstadoPagos>(con, "API.PA_TiposEstadoPagosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposEstadoPagos  ->" + ex.Message);
				}
			}

			public TiposEstadoPagos Add(TiposEstadoPagos pTiposEstadoPagos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposEstadoPagos.id==null ? 0 : pTiposEstadoPagos.id);
                    p.Add("@Nombre", pTiposEstadoPagos.Nombre);
                    p.Add("@auditoria", pTiposEstadoPagos.auditoria);

                         


                    TiposEstadoPagos o = SqlMapper.QueryFirstOrDefault<TiposEstadoPagos>(con, "API.PA_TiposEstadoPagosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposEstadoPagos  ->" + ex.Message);
				}
			}

			public TiposEstadoPagos  Update(TiposEstadoPagos pTiposEstadoPagos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposEstadoPagos.id==null ? 0 : pTiposEstadoPagos.id);
                    p.Add("@Nombre", pTiposEstadoPagos.Nombre);
                    p.Add("@auditoria", pTiposEstadoPagos.auditoria);

                         


                    TiposEstadoPagos o = SqlMapper.QueryFirstOrDefault<TiposEstadoPagos>(con, "API.PA_TiposEstadoPagosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposEstadoPagos  ->" + ex.Message);
				}
			}

			public bool Delete(TiposEstadoPagos pTiposEstadoPagos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadoPagos.id);
                    p.Add("@auditoria", pTiposEstadoPagos.auditoria);

                

 

					TiposEstadoPagos o = SqlMapper.QueryFirstOrDefault<TiposEstadoPagos>(con, "API.PA_TiposEstadoPagosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposEstadoPagos  ->" + ex.Message);
				}
			}

		



            public List<TiposEstadoPagos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposEstadoPagos> TiposEstadoPagosList = new List<TiposEstadoPagos>();

                    TiposEstadoPagosList = SqlMapper.Query<TiposEstadoPagos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposEstadoPagosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposEstadoPagos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposEstadoPagos> b)
            {
                DapperPlusManager.Entity<TiposEstadoPagos>().Table("TiposEstadoPagos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}