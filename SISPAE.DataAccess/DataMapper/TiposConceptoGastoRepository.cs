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
     /// Clase Abstracta para  TiposConceptoGasto
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposConceptoGastoRepository : DataObject , ITiposConceptoGasto 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposConceptoGastoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposConceptoGastoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposConceptoGasto GetById(TiposConceptoGasto pTiposConceptoGasto)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposConceptoGasto.id);                                    


    				TiposConceptoGasto o = SqlMapper.QueryFirstOrDefault<TiposConceptoGasto>(con, "API.PA_TiposConceptoGastoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposConceptoGasto  ->" + ex.Message);
				}
			}

			public List<TiposConceptoGasto> GetAll()
			{
				try 
                {
                        List<TiposConceptoGasto> l = SqlMapper.Query<TiposConceptoGasto>(con, "API.PA_TiposConceptoGastoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposConceptoGasto  ->" + ex.Message);
				}
			}

			public List<TiposConceptoGasto> GetAllFull()
			{
				try 
				{
                    List<TiposConceptoGasto> l = SqlMapper.Query<TiposConceptoGasto>(con, "API.PA_TiposConceptoGastoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposConceptoGasto  ->" + ex.Message);
				}
			}
			
			public List<TiposConceptoGasto> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposConceptoGasto> l = SqlMapper.Query<TiposConceptoGasto>(con, "API.PA_TiposConceptoGastoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposConceptoGasto  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposConceptoGasto> GetByFilter(TiposConceptoGasto pTiposConceptoGasto, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposConceptoGasto.id== null || pTiposConceptoGasto.id==0) ? vintNUll :pTiposConceptoGasto.id);
                    p.Add("@Nombre",(pTiposConceptoGasto.Nombre== null) ? vintNUll :pTiposConceptoGasto.Nombre);
                    p.Add("@CodigoCHIP",(pTiposConceptoGasto.CodigoCHIP== null) ? vintNUll :pTiposConceptoGasto.CodigoCHIP);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposConceptoGasto> l = SqlMapper.Query<TiposConceptoGasto>(con, "API.PA_TiposConceptoGastoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposConceptoGasto  ->" + ex.Message);
				}
			}

			public TiposConceptoGasto Add(TiposConceptoGasto pTiposConceptoGasto)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposConceptoGasto.id==null ? 0 : pTiposConceptoGasto.id);
                    p.Add("@Nombre", pTiposConceptoGasto.Nombre);
                    p.Add("@CodigoCHIP", pTiposConceptoGasto.CodigoCHIP);
                    p.Add("@auditoria", pTiposConceptoGasto.auditoria);

                         


                    TiposConceptoGasto o = SqlMapper.QueryFirstOrDefault<TiposConceptoGasto>(con, "API.PA_TiposConceptoGastoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposConceptoGasto  ->" + ex.Message);
				}
			}

			public TiposConceptoGasto  Update(TiposConceptoGasto pTiposConceptoGasto)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposConceptoGasto.id==null ? 0 : pTiposConceptoGasto.id);
                    p.Add("@Nombre", pTiposConceptoGasto.Nombre);
                    p.Add("@CodigoCHIP", pTiposConceptoGasto.CodigoCHIP);
                    p.Add("@auditoria", pTiposConceptoGasto.auditoria);

                         


                    TiposConceptoGasto o = SqlMapper.QueryFirstOrDefault<TiposConceptoGasto>(con, "API.PA_TiposConceptoGastoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposConceptoGasto  ->" + ex.Message);
				}
			}

			public bool Delete(TiposConceptoGasto pTiposConceptoGasto)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposConceptoGasto.id);
                    p.Add("@auditoria", pTiposConceptoGasto.auditoria);

                

 

					TiposConceptoGasto o = SqlMapper.QueryFirstOrDefault<TiposConceptoGasto>(con, "API.PA_TiposConceptoGastoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposConceptoGasto  ->" + ex.Message);
				}
			}

		



            public List<TiposConceptoGasto> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposConceptoGasto> TiposConceptoGastoList = new List<TiposConceptoGasto>();

                    TiposConceptoGastoList = SqlMapper.Query<TiposConceptoGasto>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposConceptoGastoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposConceptoGasto  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposConceptoGasto> b)
            {
                DapperPlusManager.Entity<TiposConceptoGasto>().Table("TiposConceptoGasto");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}