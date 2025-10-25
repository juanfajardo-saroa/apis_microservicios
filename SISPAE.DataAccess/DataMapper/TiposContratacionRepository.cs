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
     /// Clase Abstracta para  TiposContratacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposContratacionRepository : DataObject , ITiposContratacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposContratacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposContratacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposContratacion GetById(TiposContratacion pTiposContratacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposContratacion.id);                                    


    				TiposContratacion o = SqlMapper.QueryFirstOrDefault<TiposContratacion>(con, "API.PA_TiposContratacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposContratacion  ->" + ex.Message);
				}
			}

			public List<TiposContratacion> GetAll()
			{
				try 
                {
                        List<TiposContratacion> l = SqlMapper.Query<TiposContratacion>(con, "API.PA_TiposContratacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposContratacion  ->" + ex.Message);
				}
			}

			public List<TiposContratacion> GetAllFull()
			{
				try 
				{
                    List<TiposContratacion> l = SqlMapper.Query<TiposContratacion>(con, "API.PA_TiposContratacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposContratacion  ->" + ex.Message);
				}
			}
			
			public List<TiposContratacion> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposContratacion> l = SqlMapper.Query<TiposContratacion>(con, "API.PA_TiposContratacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposContratacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposContratacion> GetByFilter(TiposContratacion pTiposContratacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposContratacion.id== null || pTiposContratacion.id==0) ? vintNUll :pTiposContratacion.id);
                    p.Add("@Nombre",(pTiposContratacion.Nombre== null) ? vintNUll :pTiposContratacion.Nombre);
                    p.Add("@CodigoCHIP",(pTiposContratacion.CodigoCHIP== null) ? vintNUll :pTiposContratacion.CodigoCHIP);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposContratacion> l = SqlMapper.Query<TiposContratacion>(con, "API.PA_TiposContratacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposContratacion  ->" + ex.Message);
				}
			}

			public TiposContratacion Add(TiposContratacion pTiposContratacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposContratacion.id==null ? 0 : pTiposContratacion.id);
                    p.Add("@Nombre", pTiposContratacion.Nombre);
p.Add("@CodigoCHIP",pTiposContratacion.CodigoCHIP==null ? 0 : pTiposContratacion.CodigoCHIP);
                    p.Add("@auditoria", pTiposContratacion.auditoria);

                         


                    TiposContratacion o = SqlMapper.QueryFirstOrDefault<TiposContratacion>(con, "API.PA_TiposContratacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposContratacion  ->" + ex.Message);
				}
			}

			public TiposContratacion  Update(TiposContratacion pTiposContratacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposContratacion.id==null ? 0 : pTiposContratacion.id);
                    p.Add("@Nombre", pTiposContratacion.Nombre);
p.Add("@CodigoCHIP",pTiposContratacion.CodigoCHIP==null ? 0 : pTiposContratacion.CodigoCHIP);
                    p.Add("@auditoria", pTiposContratacion.auditoria);

                         


                    TiposContratacion o = SqlMapper.QueryFirstOrDefault<TiposContratacion>(con, "API.PA_TiposContratacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposContratacion  ->" + ex.Message);
				}
			}

			public bool Delete(TiposContratacion pTiposContratacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposContratacion.id);
                    p.Add("@auditoria", pTiposContratacion.auditoria);

                

 

					TiposContratacion o = SqlMapper.QueryFirstOrDefault<TiposContratacion>(con, "API.PA_TiposContratacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposContratacion  ->" + ex.Message);
				}
			}

		



            public List<TiposContratacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposContratacion> TiposContratacionList = new List<TiposContratacion>();

                    TiposContratacionList = SqlMapper.Query<TiposContratacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposContratacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposContratacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposContratacion> b)
            {
                DapperPlusManager.Entity<TiposContratacion>().Table("TiposContratacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}