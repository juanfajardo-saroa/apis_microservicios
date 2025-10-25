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
     /// Clase Abstracta para  TiposTransporte
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposTransporteRepository : DataObject , ITiposTransporte 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposTransporteRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposTransporteRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposTransporte GetById(TiposTransporte pTiposTransporte)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@TipoTransporteId",pTiposTransporte.TipoTransporteId);                                    


    				TiposTransporte o = SqlMapper.QueryFirstOrDefault<TiposTransporte>(con, "API.PA_TiposTransporteGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposTransporte  ->" + ex.Message);
				}
			}

			public List<TiposTransporte> GetAll()
			{
				try 
                {
                        List<TiposTransporte> l = SqlMapper.Query<TiposTransporte>(con, "API.PA_TiposTransporteGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposTransporte  ->" + ex.Message);
				}
			}

			public List<TiposTransporte> GetAllFull()
			{
				try 
				{
                    List<TiposTransporte> l = SqlMapper.Query<TiposTransporte>(con, "API.PA_TiposTransporteGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposTransporte  ->" + ex.Message);
				}
			}
			
			public List<TiposTransporte> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposTransporte> l = SqlMapper.Query<TiposTransporte>(con, "API.PA_TiposTransporteGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposTransporte  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposTransporte> GetByFilter(TiposTransporte pTiposTransporte, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@TipoTransporteId",(pTiposTransporte.TipoTransporteId== null) ? vintNUll :pTiposTransporte.TipoTransporteId);
                    p.Add("@Nombre",(pTiposTransporte.Nombre== null) ? vintNUll :pTiposTransporte.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposTransporte> l = SqlMapper.Query<TiposTransporte>(con, "API.PA_TiposTransporteGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposTransporte  ->" + ex.Message);
				}
			}

			public TiposTransporte Add(TiposTransporte pTiposTransporte)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@TipoTransporteId",pTiposTransporte.TipoTransporteId==null ? 0 : pTiposTransporte.TipoTransporteId);
                    p.Add("@Nombre", pTiposTransporte.Nombre);
                    p.Add("@auditoria", pTiposTransporte.auditoria);

                         


                    TiposTransporte o = SqlMapper.QueryFirstOrDefault<TiposTransporte>(con, "API.PA_TiposTransporteAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposTransporte  ->" + ex.Message);
				}
			}

			public TiposTransporte  Update(TiposTransporte pTiposTransporte)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@TipoTransporteId",pTiposTransporte.TipoTransporteId==null ? 0 : pTiposTransporte.TipoTransporteId);
                    p.Add("@Nombre", pTiposTransporte.Nombre);
                    p.Add("@auditoria", pTiposTransporte.auditoria);

                         


                    TiposTransporte o = SqlMapper.QueryFirstOrDefault<TiposTransporte>(con, "API.PA_TiposTransporteUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposTransporte  ->" + ex.Message);
				}
			}

			public bool Delete(TiposTransporte pTiposTransporte)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@TipoTransporteId",pTiposTransporte.TipoTransporteId);
                    p.Add("@auditoria", pTiposTransporte.auditoria);

                

 

					TiposTransporte o = SqlMapper.QueryFirstOrDefault<TiposTransporte>(con, "API.PA_TiposTransporteDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposTransporte  ->" + ex.Message);
				}
			}

		



            public List<TiposTransporte> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposTransporte> TiposTransporteList = new List<TiposTransporte>();

                    TiposTransporteList = SqlMapper.Query<TiposTransporte>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposTransporteList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposTransporte  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposTransporte> b)
            {
                DapperPlusManager.Entity<TiposTransporte>().Table("TiposTransporte");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}