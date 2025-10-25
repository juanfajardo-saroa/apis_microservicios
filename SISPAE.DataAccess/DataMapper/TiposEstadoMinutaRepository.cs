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
     /// Clase Abstracta para  TiposEstadoMinuta
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposEstadoMinutaRepository : DataObject , ITiposEstadoMinuta 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposEstadoMinutaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposEstadoMinutaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposEstadoMinuta GetById(TiposEstadoMinuta pTiposEstadoMinuta)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadoMinuta.id);                                    


    				TiposEstadoMinuta o = SqlMapper.QueryFirstOrDefault<TiposEstadoMinuta>(con, "API.PA_TiposEstadoMinutaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposEstadoMinuta  ->" + ex.Message);
				}
			}

			public List<TiposEstadoMinuta> GetAll()
			{
				try 
                {
                        List<TiposEstadoMinuta> l = SqlMapper.Query<TiposEstadoMinuta>(con, "API.PA_TiposEstadoMinutaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposEstadoMinuta  ->" + ex.Message);
				}
			}

			public List<TiposEstadoMinuta> GetAllFull()
			{
				try 
				{
                    List<TiposEstadoMinuta> l = SqlMapper.Query<TiposEstadoMinuta>(con, "API.PA_TiposEstadoMinutaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposEstadoMinuta  ->" + ex.Message);
				}
			}
			
			public List<TiposEstadoMinuta> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposEstadoMinuta> l = SqlMapper.Query<TiposEstadoMinuta>(con, "API.PA_TiposEstadoMinutaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposEstadoMinuta  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposEstadoMinuta> GetByFilter(TiposEstadoMinuta pTiposEstadoMinuta, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposEstadoMinuta.id== null || pTiposEstadoMinuta.id==0) ? vintNUll :pTiposEstadoMinuta.id);
                    p.Add("@Nombre",(pTiposEstadoMinuta.Nombre== null) ? vintNUll :pTiposEstadoMinuta.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposEstadoMinuta> l = SqlMapper.Query<TiposEstadoMinuta>(con, "API.PA_TiposEstadoMinutaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposEstadoMinuta  ->" + ex.Message);
				}
			}

			public TiposEstadoMinuta Add(TiposEstadoMinuta pTiposEstadoMinuta)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposEstadoMinuta.id==null ? 0 : pTiposEstadoMinuta.id);
                    p.Add("@Nombre", pTiposEstadoMinuta.Nombre);
                    p.Add("@auditoria", pTiposEstadoMinuta.auditoria);

                         


                    TiposEstadoMinuta o = SqlMapper.QueryFirstOrDefault<TiposEstadoMinuta>(con, "API.PA_TiposEstadoMinutaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposEstadoMinuta  ->" + ex.Message);
				}
			}

			public TiposEstadoMinuta  Update(TiposEstadoMinuta pTiposEstadoMinuta)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposEstadoMinuta.id==null ? 0 : pTiposEstadoMinuta.id);
                    p.Add("@Nombre", pTiposEstadoMinuta.Nombre);
                    p.Add("@auditoria", pTiposEstadoMinuta.auditoria);

                         


                    TiposEstadoMinuta o = SqlMapper.QueryFirstOrDefault<TiposEstadoMinuta>(con, "API.PA_TiposEstadoMinutaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposEstadoMinuta  ->" + ex.Message);
				}
			}

			public bool Delete(TiposEstadoMinuta pTiposEstadoMinuta)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadoMinuta.id);
                    p.Add("@auditoria", pTiposEstadoMinuta.auditoria);

                

 

					TiposEstadoMinuta o = SqlMapper.QueryFirstOrDefault<TiposEstadoMinuta>(con, "API.PA_TiposEstadoMinutaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposEstadoMinuta  ->" + ex.Message);
				}
			}

		



            public List<TiposEstadoMinuta> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposEstadoMinuta> TiposEstadoMinutaList = new List<TiposEstadoMinuta>();

                    TiposEstadoMinutaList = SqlMapper.Query<TiposEstadoMinuta>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposEstadoMinutaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposEstadoMinuta  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposEstadoMinuta> b)
            {
                DapperPlusManager.Entity<TiposEstadoMinuta>().Table("TiposEstadoMinuta");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}