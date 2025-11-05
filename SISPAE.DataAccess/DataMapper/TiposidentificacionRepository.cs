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
     /// Clase Abstracta para  Tiposidentificacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposidentificacionRepository : DataObject , ITiposidentificacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposidentificacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposidentificacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Tiposidentificacion GetById(Tiposidentificacion pTiposidentificacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposidentificacion.id);                                    


    				Tiposidentificacion o = SqlMapper.QueryFirstOrDefault<Tiposidentificacion>(con, "API.PA_TiposidentificacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Tiposidentificacion  ->" + ex.Message);
				}
			}

			public List<Tiposidentificacion> GetAll()
			{
				try 
                {
                        List<Tiposidentificacion> l = SqlMapper.Query<Tiposidentificacion>(con, "API.PA_TiposidentificacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Tiposidentificacion  ->" + ex.Message);
				}
			}

			public List<Tiposidentificacion> GetAllFull()
			{
				try 
				{
                    List<Tiposidentificacion> l = SqlMapper.Query<Tiposidentificacion>(con, "API.PA_TiposidentificacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Tiposidentificacion  ->" + ex.Message);
				}
			}
			
			public List<Tiposidentificacion> GetAllByWithRelation()
			{
				try 
                {
                    List<Tiposidentificacion> l = SqlMapper.Query<Tiposidentificacion>(con, "API.PA_TiposidentificacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Tiposidentificacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Tiposidentificacion> GetByFilter(Tiposidentificacion pTiposidentificacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposidentificacion.id== null || pTiposidentificacion.id==0) ? vintNUll :pTiposidentificacion.id);
                    p.Add("@Nombre",(pTiposidentificacion.Nombre== null) ? vintNUll :pTiposidentificacion.Nombre);
                    p.Add("@CodigoCHIP",(pTiposidentificacion.CodigoCHIP== null) ? vintNUll :pTiposidentificacion.CodigoCHIP);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Tiposidentificacion> l = SqlMapper.Query<Tiposidentificacion>(con, "API.PA_TiposidentificacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Tiposidentificacion  ->" + ex.Message);
				}
			}

			public Tiposidentificacion Add(Tiposidentificacion pTiposidentificacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposidentificacion.id==null ? 0 : pTiposidentificacion.id);
                    p.Add("@Nombre", pTiposidentificacion.Nombre);
p.Add("@CodigoCHIP",pTiposidentificacion.CodigoCHIP==null ? 0 : pTiposidentificacion.CodigoCHIP);
                    p.Add("@auditoria", pTiposidentificacion.auditoria);

                         


                    Tiposidentificacion o = SqlMapper.QueryFirstOrDefault<Tiposidentificacion>(con, "API.PA_TiposidentificacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Tiposidentificacion  ->" + ex.Message);
				}
			}

			public Tiposidentificacion  Update(Tiposidentificacion pTiposidentificacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposidentificacion.id==null ? 0 : pTiposidentificacion.id);
                    p.Add("@Nombre", pTiposidentificacion.Nombre);
p.Add("@CodigoCHIP",pTiposidentificacion.CodigoCHIP==null ? 0 : pTiposidentificacion.CodigoCHIP);
                    p.Add("@auditoria", pTiposidentificacion.auditoria);

                         


                    Tiposidentificacion o = SqlMapper.QueryFirstOrDefault<Tiposidentificacion>(con, "API.PA_TiposidentificacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Tiposidentificacion  ->" + ex.Message);
				}
			}

			public bool Delete(Tiposidentificacion pTiposidentificacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposidentificacion.id);
                    p.Add("@auditoria", pTiposidentificacion.auditoria);

                

 

					Tiposidentificacion o = SqlMapper.QueryFirstOrDefault<Tiposidentificacion>(con, "API.PA_TiposidentificacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Tiposidentificacion  ->" + ex.Message);
				}
			}

		



            public List<Tiposidentificacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Tiposidentificacion> TiposidentificacionList = new List<Tiposidentificacion>();

                    TiposidentificacionList = SqlMapper.Query<Tiposidentificacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposidentificacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Tiposidentificacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Tiposidentificacion> b)
            {
                DapperPlusManager.Entity<Tiposidentificacion>().Table("Tiposidentificacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}