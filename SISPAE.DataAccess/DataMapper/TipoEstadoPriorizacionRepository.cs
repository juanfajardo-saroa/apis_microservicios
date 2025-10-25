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
     /// Clase Abstracta para  TipoEstadoPriorizacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoEstadoPriorizacionRepository : DataObject , ITipoEstadoPriorizacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoEstadoPriorizacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoEstadoPriorizacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoEstadoPriorizacion GetById(TipoEstadoPriorizacion pTipoEstadoPriorizacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoEstadoPriorizacion.id);                                    


    				TipoEstadoPriorizacion o = SqlMapper.QueryFirstOrDefault<TipoEstadoPriorizacion>(con, "API.PA_TipoEstadoPriorizacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoEstadoPriorizacion  ->" + ex.Message);
				}
			}

			public List<TipoEstadoPriorizacion> GetAll()
			{
				try 
                {
                        List<TipoEstadoPriorizacion> l = SqlMapper.Query<TipoEstadoPriorizacion>(con, "API.PA_TipoEstadoPriorizacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoEstadoPriorizacion  ->" + ex.Message);
				}
			}

			public List<TipoEstadoPriorizacion> GetAllFull()
			{
				try 
				{
                    List<TipoEstadoPriorizacion> l = SqlMapper.Query<TipoEstadoPriorizacion>(con, "API.PA_TipoEstadoPriorizacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoEstadoPriorizacion  ->" + ex.Message);
				}
			}
			
			public List<TipoEstadoPriorizacion> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoEstadoPriorizacion> l = SqlMapper.Query<TipoEstadoPriorizacion>(con, "API.PA_TipoEstadoPriorizacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoEstadoPriorizacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoEstadoPriorizacion> GetByFilter(TipoEstadoPriorizacion pTipoEstadoPriorizacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoEstadoPriorizacion.id== null || pTipoEstadoPriorizacion.id==0) ? vintNUll :pTipoEstadoPriorizacion.id);
                    p.Add("@Nombre",(pTipoEstadoPriorizacion.Nombre== null) ? vintNUll :pTipoEstadoPriorizacion.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoEstadoPriorizacion> l = SqlMapper.Query<TipoEstadoPriorizacion>(con, "API.PA_TipoEstadoPriorizacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoEstadoPriorizacion  ->" + ex.Message);
				}
			}

			public TipoEstadoPriorizacion Add(TipoEstadoPriorizacion pTipoEstadoPriorizacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoEstadoPriorizacion.id==null ? 0 : pTipoEstadoPriorizacion.id);
                    p.Add("@Nombre", pTipoEstadoPriorizacion.Nombre);
                    p.Add("@auditoria", pTipoEstadoPriorizacion.auditoria);

                         


                    TipoEstadoPriorizacion o = SqlMapper.QueryFirstOrDefault<TipoEstadoPriorizacion>(con, "API.PA_TipoEstadoPriorizacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoEstadoPriorizacion  ->" + ex.Message);
				}
			}

			public TipoEstadoPriorizacion  Update(TipoEstadoPriorizacion pTipoEstadoPriorizacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoEstadoPriorizacion.id==null ? 0 : pTipoEstadoPriorizacion.id);
                    p.Add("@Nombre", pTipoEstadoPriorizacion.Nombre);
                    p.Add("@auditoria", pTipoEstadoPriorizacion.auditoria);

                         


                    TipoEstadoPriorizacion o = SqlMapper.QueryFirstOrDefault<TipoEstadoPriorizacion>(con, "API.PA_TipoEstadoPriorizacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoEstadoPriorizacion  ->" + ex.Message);
				}
			}

			public bool Delete(TipoEstadoPriorizacion pTipoEstadoPriorizacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoEstadoPriorizacion.id);
                    p.Add("@auditoria", pTipoEstadoPriorizacion.auditoria);

                

 

					TipoEstadoPriorizacion o = SqlMapper.QueryFirstOrDefault<TipoEstadoPriorizacion>(con, "API.PA_TipoEstadoPriorizacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoEstadoPriorizacion  ->" + ex.Message);
				}
			}

		



            public List<TipoEstadoPriorizacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoEstadoPriorizacion> TipoEstadoPriorizacionList = new List<TipoEstadoPriorizacion>();

                    TipoEstadoPriorizacionList = SqlMapper.Query<TipoEstadoPriorizacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoEstadoPriorizacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoEstadoPriorizacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoEstadoPriorizacion> b)
            {
                DapperPlusManager.Entity<TipoEstadoPriorizacion>().Table("TipoEstadoPriorizacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}