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
     /// Clase Abstracta para  TiposPlantaBodega
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposPlantaBodegaRepository : DataObject , ITiposPlantaBodega 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposPlantaBodegaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposPlantaBodegaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposPlantaBodega GetById(TiposPlantaBodega pTiposPlantaBodega)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposPlantaBodega.id);                                    


    				TiposPlantaBodega o = SqlMapper.QueryFirstOrDefault<TiposPlantaBodega>(con, "API.PA_TiposPlantaBodegaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposPlantaBodega  ->" + ex.Message);
				}
			}

			public List<TiposPlantaBodega> GetAll()
			{
				try 
                {
                        List<TiposPlantaBodega> l = SqlMapper.Query<TiposPlantaBodega>(con, "API.PA_TiposPlantaBodegaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposPlantaBodega  ->" + ex.Message);
				}
			}

			public List<TiposPlantaBodega> GetAllFull()
			{
				try 
				{
                    List<TiposPlantaBodega> l = SqlMapper.Query<TiposPlantaBodega>(con, "API.PA_TiposPlantaBodegaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposPlantaBodega  ->" + ex.Message);
				}
			}
			
			public List<TiposPlantaBodega> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposPlantaBodega> l = SqlMapper.Query<TiposPlantaBodega>(con, "API.PA_TiposPlantaBodegaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposPlantaBodega  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposPlantaBodega> GetByFilter(TiposPlantaBodega pTiposPlantaBodega, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposPlantaBodega.id== null || pTiposPlantaBodega.id==0) ? vintNUll :pTiposPlantaBodega.id);
                    p.Add("@Nombre",(pTiposPlantaBodega.Nombre== null) ? vintNUll :pTiposPlantaBodega.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposPlantaBodega> l = SqlMapper.Query<TiposPlantaBodega>(con, "API.PA_TiposPlantaBodegaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposPlantaBodega  ->" + ex.Message);
				}
			}

			public TiposPlantaBodega Add(TiposPlantaBodega pTiposPlantaBodega)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposPlantaBodega.id==null ? 0 : pTiposPlantaBodega.id);
                    p.Add("@Nombre", pTiposPlantaBodega.Nombre);
                    p.Add("@auditoria", pTiposPlantaBodega.auditoria);

                         


                    TiposPlantaBodega o = SqlMapper.QueryFirstOrDefault<TiposPlantaBodega>(con, "API.PA_TiposPlantaBodegaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposPlantaBodega  ->" + ex.Message);
				}
			}

			public TiposPlantaBodega  Update(TiposPlantaBodega pTiposPlantaBodega)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposPlantaBodega.id==null ? 0 : pTiposPlantaBodega.id);
                    p.Add("@Nombre", pTiposPlantaBodega.Nombre);
                    p.Add("@auditoria", pTiposPlantaBodega.auditoria);

                         


                    TiposPlantaBodega o = SqlMapper.QueryFirstOrDefault<TiposPlantaBodega>(con, "API.PA_TiposPlantaBodegaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposPlantaBodega  ->" + ex.Message);
				}
			}

			public bool Delete(TiposPlantaBodega pTiposPlantaBodega)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposPlantaBodega.id);
                    p.Add("@auditoria", pTiposPlantaBodega.auditoria);

                

 

					TiposPlantaBodega o = SqlMapper.QueryFirstOrDefault<TiposPlantaBodega>(con, "API.PA_TiposPlantaBodegaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposPlantaBodega  ->" + ex.Message);
				}
			}

		



            public List<TiposPlantaBodega> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposPlantaBodega> TiposPlantaBodegaList = new List<TiposPlantaBodega>();

                    TiposPlantaBodegaList = SqlMapper.Query<TiposPlantaBodega>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposPlantaBodegaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposPlantaBodega  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposPlantaBodega> b)
            {
                DapperPlusManager.Entity<TiposPlantaBodega>().Table("TiposPlantaBodega");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}