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
     /// Clase Abstracta para  TipoModalidadRacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoModalidadRacionRepository : DataObject , ITipoModalidadRacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoModalidadRacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoModalidadRacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoModalidadRacion GetById(TipoModalidadRacion pTipoModalidadRacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoModalidadRacion.id);                                    


    				TipoModalidadRacion o = SqlMapper.QueryFirstOrDefault<TipoModalidadRacion>(con, "API.PA_TipoModalidadRacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoModalidadRacion  ->" + ex.Message);
				}
			}

			public List<TipoModalidadRacion> GetAll()
			{
				try 
                {
                        List<TipoModalidadRacion> l = SqlMapper.Query<TipoModalidadRacion>(con, "API.PA_TipoModalidadRacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoModalidadRacion  ->" + ex.Message);
				}
			}

			public List<TipoModalidadRacion> GetAllFull()
			{
				try 
				{
                    List<TipoModalidadRacion> l = SqlMapper.Query<TipoModalidadRacion>(con, "API.PA_TipoModalidadRacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoModalidadRacion  ->" + ex.Message);
				}
			}
			
			public List<TipoModalidadRacion> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoModalidadRacion> l = SqlMapper.Query<TipoModalidadRacion>(con, "API.PA_TipoModalidadRacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoModalidadRacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoModalidadRacion> GetByFilter(TipoModalidadRacion pTipoModalidadRacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoModalidadRacion.id== null || pTipoModalidadRacion.id==0) ? vintNUll :pTipoModalidadRacion.id);
                    p.Add("@Nombre",(pTipoModalidadRacion.Nombre== null) ? vintNUll :pTipoModalidadRacion.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoModalidadRacion> l = SqlMapper.Query<TipoModalidadRacion>(con, "API.PA_TipoModalidadRacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoModalidadRacion  ->" + ex.Message);
				}
			}

			public TipoModalidadRacion Add(TipoModalidadRacion pTipoModalidadRacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoModalidadRacion.id==null ? 0 : pTipoModalidadRacion.id);
                    p.Add("@Nombre", pTipoModalidadRacion.Nombre);
                    p.Add("@auditoria", pTipoModalidadRacion.auditoria);

                         


                    TipoModalidadRacion o = SqlMapper.QueryFirstOrDefault<TipoModalidadRacion>(con, "API.PA_TipoModalidadRacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoModalidadRacion  ->" + ex.Message);
				}
			}

			public TipoModalidadRacion  Update(TipoModalidadRacion pTipoModalidadRacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoModalidadRacion.id==null ? 0 : pTipoModalidadRacion.id);
                    p.Add("@Nombre", pTipoModalidadRacion.Nombre);
                    p.Add("@auditoria", pTipoModalidadRacion.auditoria);

                         


                    TipoModalidadRacion o = SqlMapper.QueryFirstOrDefault<TipoModalidadRacion>(con, "API.PA_TipoModalidadRacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoModalidadRacion  ->" + ex.Message);
				}
			}

			public bool Delete(TipoModalidadRacion pTipoModalidadRacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoModalidadRacion.id);
                    p.Add("@auditoria", pTipoModalidadRacion.auditoria);

                

 

					TipoModalidadRacion o = SqlMapper.QueryFirstOrDefault<TipoModalidadRacion>(con, "API.PA_TipoModalidadRacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoModalidadRacion  ->" + ex.Message);
				}
			}

		



            public List<TipoModalidadRacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoModalidadRacion> TipoModalidadRacionList = new List<TipoModalidadRacion>();

                    TipoModalidadRacionList = SqlMapper.Query<TipoModalidadRacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoModalidadRacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoModalidadRacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoModalidadRacion> b)
            {
                DapperPlusManager.Entity<TipoModalidadRacion>().Table("TipoModalidadRacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}