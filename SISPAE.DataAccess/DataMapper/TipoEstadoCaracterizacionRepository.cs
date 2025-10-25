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
     /// Clase Abstracta para  TipoEstadoCaracterizacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoEstadoCaracterizacionRepository : DataObject , ITipoEstadoCaracterizacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoEstadoCaracterizacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoEstadoCaracterizacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoEstadoCaracterizacion GetById(TipoEstadoCaracterizacion pTipoEstadoCaracterizacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoEstadoCaracterizacion.id);                                    


    				TipoEstadoCaracterizacion o = SqlMapper.QueryFirstOrDefault<TipoEstadoCaracterizacion>(con, "API.PA_TipoEstadoCaracterizacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoEstadoCaracterizacion  ->" + ex.Message);
				}
			}

			public List<TipoEstadoCaracterizacion> GetAll()
			{
				try 
                {
                        List<TipoEstadoCaracterizacion> l = SqlMapper.Query<TipoEstadoCaracterizacion>(con, "API.PA_TipoEstadoCaracterizacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoEstadoCaracterizacion  ->" + ex.Message);
				}
			}

			public List<TipoEstadoCaracterizacion> GetAllFull()
			{
				try 
				{
                    List<TipoEstadoCaracterizacion> l = SqlMapper.Query<TipoEstadoCaracterizacion>(con, "API.PA_TipoEstadoCaracterizacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoEstadoCaracterizacion  ->" + ex.Message);
				}
			}
			
			public List<TipoEstadoCaracterizacion> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoEstadoCaracterizacion> l = SqlMapper.Query<TipoEstadoCaracterizacion>(con, "API.PA_TipoEstadoCaracterizacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoEstadoCaracterizacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoEstadoCaracterizacion> GetByFilter(TipoEstadoCaracterizacion pTipoEstadoCaracterizacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoEstadoCaracterizacion.id== null || pTipoEstadoCaracterizacion.id==0) ? vintNUll :pTipoEstadoCaracterizacion.id);
                    p.Add("@Nombre",(pTipoEstadoCaracterizacion.Nombre== null) ? vintNUll :pTipoEstadoCaracterizacion.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoEstadoCaracterizacion> l = SqlMapper.Query<TipoEstadoCaracterizacion>(con, "API.PA_TipoEstadoCaracterizacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoEstadoCaracterizacion  ->" + ex.Message);
				}
			}

			public TipoEstadoCaracterizacion Add(TipoEstadoCaracterizacion pTipoEstadoCaracterizacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoEstadoCaracterizacion.id==null ? 0 : pTipoEstadoCaracterizacion.id);
                    p.Add("@Nombre", pTipoEstadoCaracterizacion.Nombre);
                    p.Add("@auditoria", pTipoEstadoCaracterizacion.auditoria);

                         


                    TipoEstadoCaracterizacion o = SqlMapper.QueryFirstOrDefault<TipoEstadoCaracterizacion>(con, "API.PA_TipoEstadoCaracterizacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoEstadoCaracterizacion  ->" + ex.Message);
				}
			}

			public TipoEstadoCaracterizacion  Update(TipoEstadoCaracterizacion pTipoEstadoCaracterizacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoEstadoCaracterizacion.id==null ? 0 : pTipoEstadoCaracterizacion.id);
                    p.Add("@Nombre", pTipoEstadoCaracterizacion.Nombre);
                    p.Add("@auditoria", pTipoEstadoCaracterizacion.auditoria);

                         


                    TipoEstadoCaracterizacion o = SqlMapper.QueryFirstOrDefault<TipoEstadoCaracterizacion>(con, "API.PA_TipoEstadoCaracterizacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoEstadoCaracterizacion  ->" + ex.Message);
				}
			}

			public bool Delete(TipoEstadoCaracterizacion pTipoEstadoCaracterizacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoEstadoCaracterizacion.id);
                    p.Add("@auditoria", pTipoEstadoCaracterizacion.auditoria);

                

 

					TipoEstadoCaracterizacion o = SqlMapper.QueryFirstOrDefault<TipoEstadoCaracterizacion>(con, "API.PA_TipoEstadoCaracterizacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoEstadoCaracterizacion  ->" + ex.Message);
				}
			}

		



            public List<TipoEstadoCaracterizacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoEstadoCaracterizacion> TipoEstadoCaracterizacionList = new List<TipoEstadoCaracterizacion>();

                    TipoEstadoCaracterizacionList = SqlMapper.Query<TipoEstadoCaracterizacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoEstadoCaracterizacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoEstadoCaracterizacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoEstadoCaracterizacion> b)
            {
                DapperPlusManager.Entity<TipoEstadoCaracterizacion>().Table("TipoEstadoCaracterizacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}