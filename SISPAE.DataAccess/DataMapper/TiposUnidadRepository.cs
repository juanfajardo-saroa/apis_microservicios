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
     /// Clase Abstracta para  TiposUnidad
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposUnidadRepository : DataObject , ITiposUnidad 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposUnidadRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposUnidadRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposUnidad GetById(TiposUnidad pTiposUnidad)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposUnidad.id);                                    


    				TiposUnidad o = SqlMapper.QueryFirstOrDefault<TiposUnidad>(con, "API.PA_TiposUnidadGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposUnidad  ->" + ex.Message);
				}
			}

			public List<TiposUnidad> GetAll()
			{
				try 
                {
                        List<TiposUnidad> l = SqlMapper.Query<TiposUnidad>(con, "API.PA_TiposUnidadGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposUnidad  ->" + ex.Message);
				}
			}

			public List<TiposUnidad> GetAllFull()
			{
				try 
				{
                    List<TiposUnidad> l = SqlMapper.Query<TiposUnidad>(con, "API.PA_TiposUnidadGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposUnidad  ->" + ex.Message);
				}
			}
			
			public List<TiposUnidad> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposUnidad> l = SqlMapper.Query<TiposUnidad>(con, "API.PA_TiposUnidadGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposUnidad  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposUnidad> GetByFilter(TiposUnidad pTiposUnidad, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposUnidad.id== null || pTiposUnidad.id==0) ? vintNUll :pTiposUnidad.id);
                    p.Add("@Nombre",(pTiposUnidad.Nombre== null) ? vintNUll :pTiposUnidad.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposUnidad> l = SqlMapper.Query<TiposUnidad>(con, "API.PA_TiposUnidadGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposUnidad  ->" + ex.Message);
				}
			}

			public TiposUnidad Add(TiposUnidad pTiposUnidad)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposUnidad.id==null ? 0 : pTiposUnidad.id);
                    p.Add("@Nombre", pTiposUnidad.Nombre);
                    p.Add("@auditoria", pTiposUnidad.auditoria);

                         


                    TiposUnidad o = SqlMapper.QueryFirstOrDefault<TiposUnidad>(con, "API.PA_TiposUnidadAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposUnidad  ->" + ex.Message);
				}
			}

			public TiposUnidad  Update(TiposUnidad pTiposUnidad)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposUnidad.id==null ? 0 : pTiposUnidad.id);
                    p.Add("@Nombre", pTiposUnidad.Nombre);
                    p.Add("@auditoria", pTiposUnidad.auditoria);

                         


                    TiposUnidad o = SqlMapper.QueryFirstOrDefault<TiposUnidad>(con, "API.PA_TiposUnidadUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposUnidad  ->" + ex.Message);
				}
			}

			public bool Delete(TiposUnidad pTiposUnidad)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposUnidad.id);
                    p.Add("@auditoria", pTiposUnidad.auditoria);

                

 

					TiposUnidad o = SqlMapper.QueryFirstOrDefault<TiposUnidad>(con, "API.PA_TiposUnidadDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposUnidad  ->" + ex.Message);
				}
			}

		



            public List<TiposUnidad> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposUnidad> TiposUnidadList = new List<TiposUnidad>();

                    TiposUnidadList = SqlMapper.Query<TiposUnidad>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposUnidadList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposUnidad  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposUnidad> b)
            {
                DapperPlusManager.Entity<TiposUnidad>().Table("TiposUnidad");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}