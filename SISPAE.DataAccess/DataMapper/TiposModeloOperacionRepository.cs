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
     /// Clase Abstracta para  TiposModeloOperacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposModeloOperacionRepository : DataObject , ITiposModeloOperacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposModeloOperacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposModeloOperacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposModeloOperacion GetById(TiposModeloOperacion pTiposModeloOperacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposModeloOperacion.id);                                    


    				TiposModeloOperacion o = SqlMapper.QueryFirstOrDefault<TiposModeloOperacion>(con, "API.PA_TiposModeloOperacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposModeloOperacion  ->" + ex.Message);
				}
			}

			public List<TiposModeloOperacion> GetAll()
			{
				try 
                {
                        List<TiposModeloOperacion> l = SqlMapper.Query<TiposModeloOperacion>(con, "API.PA_TiposModeloOperacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposModeloOperacion  ->" + ex.Message);
				}
			}

			public List<TiposModeloOperacion> GetAllFull()
			{
				try 
				{
                    List<TiposModeloOperacion> l = SqlMapper.Query<TiposModeloOperacion>(con, "API.PA_TiposModeloOperacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposModeloOperacion  ->" + ex.Message);
				}
			}
			
			public List<TiposModeloOperacion> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposModeloOperacion> l = SqlMapper.Query<TiposModeloOperacion>(con, "API.PA_TiposModeloOperacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposModeloOperacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposModeloOperacion> GetByFilter(TiposModeloOperacion pTiposModeloOperacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposModeloOperacion.id== null || pTiposModeloOperacion.id==0) ? vintNUll :pTiposModeloOperacion.id);
                    p.Add("@Nombre",(pTiposModeloOperacion.Nombre== null) ? vintNUll :pTiposModeloOperacion.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposModeloOperacion> l = SqlMapper.Query<TiposModeloOperacion>(con, "API.PA_TiposModeloOperacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposModeloOperacion  ->" + ex.Message);
				}
			}

			public TiposModeloOperacion Add(TiposModeloOperacion pTiposModeloOperacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposModeloOperacion.id==null ? 0 : pTiposModeloOperacion.id);
                    p.Add("@Nombre", pTiposModeloOperacion.Nombre);
                    p.Add("@auditoria", pTiposModeloOperacion.auditoria);

                         


                    TiposModeloOperacion o = SqlMapper.QueryFirstOrDefault<TiposModeloOperacion>(con, "API.PA_TiposModeloOperacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposModeloOperacion  ->" + ex.Message);
				}
			}

			public TiposModeloOperacion  Update(TiposModeloOperacion pTiposModeloOperacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposModeloOperacion.id==null ? 0 : pTiposModeloOperacion.id);
                    p.Add("@Nombre", pTiposModeloOperacion.Nombre);
                    p.Add("@auditoria", pTiposModeloOperacion.auditoria);

                         


                    TiposModeloOperacion o = SqlMapper.QueryFirstOrDefault<TiposModeloOperacion>(con, "API.PA_TiposModeloOperacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposModeloOperacion  ->" + ex.Message);
				}
			}

			public bool Delete(TiposModeloOperacion pTiposModeloOperacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposModeloOperacion.id);
                    p.Add("@auditoria", pTiposModeloOperacion.auditoria);

                

 

					TiposModeloOperacion o = SqlMapper.QueryFirstOrDefault<TiposModeloOperacion>(con, "API.PA_TiposModeloOperacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposModeloOperacion  ->" + ex.Message);
				}
			}

		



            public List<TiposModeloOperacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposModeloOperacion> TiposModeloOperacionList = new List<TiposModeloOperacion>();

                    TiposModeloOperacionList = SqlMapper.Query<TiposModeloOperacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposModeloOperacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposModeloOperacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposModeloOperacion> b)
            {
                DapperPlusManager.Entity<TiposModeloOperacion>().Table("TiposModeloOperacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}