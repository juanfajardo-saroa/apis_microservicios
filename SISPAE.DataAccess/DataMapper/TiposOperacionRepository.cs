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
     /// Clase Abstracta para  TiposOperacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposOperacionRepository : DataObject , ITiposOperacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposOperacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposOperacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposOperacion GetById(TiposOperacion pTiposOperacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposOperacion.id);                                    


    				TiposOperacion o = SqlMapper.QueryFirstOrDefault<TiposOperacion>(con, "API.PA_TiposOperacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposOperacion  ->" + ex.Message);
				}
			}

			public List<TiposOperacion> GetAll()
			{
				try 
                {
                        List<TiposOperacion> l = SqlMapper.Query<TiposOperacion>(con, "API.PA_TiposOperacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposOperacion  ->" + ex.Message);
				}
			}

			public List<TiposOperacion> GetAllFull()
			{
				try 
				{
                    List<TiposOperacion> l = SqlMapper.Query<TiposOperacion>(con, "API.PA_TiposOperacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposOperacion  ->" + ex.Message);
				}
			}
			
			public List<TiposOperacion> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposOperacion> l = SqlMapper.Query<TiposOperacion>(con, "API.PA_TiposOperacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposOperacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposOperacion> GetByFilter(TiposOperacion pTiposOperacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposOperacion.id== null || pTiposOperacion.id==0) ? vintNUll :pTiposOperacion.id);
                    p.Add("@Nombre",(pTiposOperacion.Nombre== null) ? vintNUll :pTiposOperacion.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposOperacion> l = SqlMapper.Query<TiposOperacion>(con, "API.PA_TiposOperacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposOperacion  ->" + ex.Message);
				}
			}

			public TiposOperacion Add(TiposOperacion pTiposOperacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposOperacion.id==null ? 0 : pTiposOperacion.id);
                    p.Add("@Nombre", pTiposOperacion.Nombre);
                    p.Add("@auditoria", pTiposOperacion.auditoria);

                         


                    TiposOperacion o = SqlMapper.QueryFirstOrDefault<TiposOperacion>(con, "API.PA_TiposOperacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposOperacion  ->" + ex.Message);
				}
			}

			public TiposOperacion  Update(TiposOperacion pTiposOperacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposOperacion.id==null ? 0 : pTiposOperacion.id);
                    p.Add("@Nombre", pTiposOperacion.Nombre);
                    p.Add("@auditoria", pTiposOperacion.auditoria);

                         


                    TiposOperacion o = SqlMapper.QueryFirstOrDefault<TiposOperacion>(con, "API.PA_TiposOperacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposOperacion  ->" + ex.Message);
				}
			}

			public bool Delete(TiposOperacion pTiposOperacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposOperacion.id);
                    p.Add("@auditoria", pTiposOperacion.auditoria);

                

 

					TiposOperacion o = SqlMapper.QueryFirstOrDefault<TiposOperacion>(con, "API.PA_TiposOperacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposOperacion  ->" + ex.Message);
				}
			}

		



            public List<TiposOperacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposOperacion> TiposOperacionList = new List<TiposOperacion>();

                    TiposOperacionList = SqlMapper.Query<TiposOperacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposOperacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposOperacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposOperacion> b)
            {
                DapperPlusManager.Entity<TiposOperacion>().Table("TiposOperacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}