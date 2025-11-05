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
     /// Clase Abstracta para  TiposPlataformaContratacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposPlataformaContratacionRepository : DataObject , ITiposPlataformaContratacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposPlataformaContratacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposPlataformaContratacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposPlataformaContratacion GetById(TiposPlataformaContratacion pTiposPlataformaContratacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposPlataformaContratacion.id);                                    


    				TiposPlataformaContratacion o = SqlMapper.QueryFirstOrDefault<TiposPlataformaContratacion>(con, "API.PA_TiposPlataformaContratacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposPlataformaContratacion  ->" + ex.Message);
				}
			}

			public List<TiposPlataformaContratacion> GetAll()
			{
				try 
                {
                        List<TiposPlataformaContratacion> l = SqlMapper.Query<TiposPlataformaContratacion>(con, "API.PA_TiposPlataformaContratacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposPlataformaContratacion  ->" + ex.Message);
				}
			}

			public List<TiposPlataformaContratacion> GetAllFull()
			{
				try 
				{
                    List<TiposPlataformaContratacion> l = SqlMapper.Query<TiposPlataformaContratacion>(con, "API.PA_TiposPlataformaContratacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposPlataformaContratacion  ->" + ex.Message);
				}
			}
			
			public List<TiposPlataformaContratacion> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposPlataformaContratacion> l = SqlMapper.Query<TiposPlataformaContratacion>(con, "API.PA_TiposPlataformaContratacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposPlataformaContratacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposPlataformaContratacion> GetByFilter(TiposPlataformaContratacion pTiposPlataformaContratacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposPlataformaContratacion.id== null || pTiposPlataformaContratacion.id==0) ? vintNUll :pTiposPlataformaContratacion.id);
                    p.Add("@Nombre",(pTiposPlataformaContratacion.Nombre== null) ? vintNUll :pTiposPlataformaContratacion.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposPlataformaContratacion> l = SqlMapper.Query<TiposPlataformaContratacion>(con, "API.PA_TiposPlataformaContratacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposPlataformaContratacion  ->" + ex.Message);
				}
			}

			public TiposPlataformaContratacion Add(TiposPlataformaContratacion pTiposPlataformaContratacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposPlataformaContratacion.id==null ? 0 : pTiposPlataformaContratacion.id);
                    p.Add("@Nombre", pTiposPlataformaContratacion.Nombre);
                    p.Add("@auditoria", pTiposPlataformaContratacion.auditoria);

                         


                    TiposPlataformaContratacion o = SqlMapper.QueryFirstOrDefault<TiposPlataformaContratacion>(con, "API.PA_TiposPlataformaContratacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposPlataformaContratacion  ->" + ex.Message);
				}
			}

			public TiposPlataformaContratacion  Update(TiposPlataformaContratacion pTiposPlataformaContratacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposPlataformaContratacion.id==null ? 0 : pTiposPlataformaContratacion.id);
                    p.Add("@Nombre", pTiposPlataformaContratacion.Nombre);
                    p.Add("@auditoria", pTiposPlataformaContratacion.auditoria);

                         


                    TiposPlataformaContratacion o = SqlMapper.QueryFirstOrDefault<TiposPlataformaContratacion>(con, "API.PA_TiposPlataformaContratacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposPlataformaContratacion  ->" + ex.Message);
				}
			}

			public bool Delete(TiposPlataformaContratacion pTiposPlataformaContratacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposPlataformaContratacion.id);
                    p.Add("@auditoria", pTiposPlataformaContratacion.auditoria);

                

 

					TiposPlataformaContratacion o = SqlMapper.QueryFirstOrDefault<TiposPlataformaContratacion>(con, "API.PA_TiposPlataformaContratacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposPlataformaContratacion  ->" + ex.Message);
				}
			}

		



            public List<TiposPlataformaContratacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposPlataformaContratacion> TiposPlataformaContratacionList = new List<TiposPlataformaContratacion>();

                    TiposPlataformaContratacionList = SqlMapper.Query<TiposPlataformaContratacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposPlataformaContratacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposPlataformaContratacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposPlataformaContratacion> b)
            {
                DapperPlusManager.Entity<TiposPlataformaContratacion>().Table("TiposPlataformaContratacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}