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
     /// Clase Abstracta para  ReportesCiudadano
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ReportesCiudadanoRepository : DataObject , IReportesCiudadano 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ReportesCiudadanoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ReportesCiudadanoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ReportesCiudadano GetById(ReportesCiudadano pReportesCiudadano)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pReportesCiudadano.id);                                    


    				ReportesCiudadano o = SqlMapper.QueryFirstOrDefault<ReportesCiudadano>(con, "API.PA_ReportesCiudadanoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ReportesCiudadano  ->" + ex.Message);
				}
			}

			public List<ReportesCiudadano> GetAll()
			{
				try 
                {
                        List<ReportesCiudadano> l = SqlMapper.Query<ReportesCiudadano>(con, "API.PA_ReportesCiudadanoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ReportesCiudadano  ->" + ex.Message);
				}
			}

			public List<ReportesCiudadano> GetAllFull()
			{
				try 
				{
                    List<ReportesCiudadano> l = SqlMapper.Query<ReportesCiudadano>(con, "API.PA_ReportesCiudadanoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ReportesCiudadano  ->" + ex.Message);
				}
			}
			
			public List<ReportesCiudadano> GetAllByWithRelation()
			{
				try 
                {
                    List<ReportesCiudadano> l = SqlMapper.Query<ReportesCiudadano>(con, "API.PA_ReportesCiudadanoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ReportesCiudadano  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ReportesCiudadano> GetByFilter(ReportesCiudadano pReportesCiudadano, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pReportesCiudadano.id== null || pReportesCiudadano.id==0) ? vintNUll :pReportesCiudadano.id);
                    p.Add("@ID_TipoReporteCiudadano",(pReportesCiudadano.ID_TipoReporteCiudadano== null || pReportesCiudadano.ID_TipoReporteCiudadano==0) ? vintNUll :pReportesCiudadano.ID_TipoReporteCiudadano);
                    p.Add("@ID_Categoria",(pReportesCiudadano.ID_Categoria== null || pReportesCiudadano.ID_Categoria==0) ? vintNUll :pReportesCiudadano.ID_Categoria);
                    p.Add("@ID_Vigencia",(pReportesCiudadano.ID_Vigencia== null || pReportesCiudadano.ID_Vigencia==0) ? vintNUll :pReportesCiudadano.ID_Vigencia);
                    p.Add("@Detalle",(pReportesCiudadano.Detalle== null) ? vintNUll :pReportesCiudadano.Detalle);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ReportesCiudadano> l = SqlMapper.Query<ReportesCiudadano>(con, "API.PA_ReportesCiudadanoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ReportesCiudadano  ->" + ex.Message);
				}
			}

			public ReportesCiudadano Add(ReportesCiudadano pReportesCiudadano)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pReportesCiudadano.id==null ? 0 : pReportesCiudadano.id);
p.Add("@ID_TipoReporteCiudadano",pReportesCiudadano.ID_TipoReporteCiudadano==null ? 0 : pReportesCiudadano.ID_TipoReporteCiudadano);
p.Add("@ID_Categoria",pReportesCiudadano.ID_Categoria==null ? 0 : pReportesCiudadano.ID_Categoria);
p.Add("@ID_Vigencia",pReportesCiudadano.ID_Vigencia==null ? 0 : pReportesCiudadano.ID_Vigencia);
p.Add("@Detalle",pReportesCiudadano.Detalle==null ? 0 : pReportesCiudadano.Detalle);
                    p.Add("@auditoria", pReportesCiudadano.auditoria);

                         


                    ReportesCiudadano o = SqlMapper.QueryFirstOrDefault<ReportesCiudadano>(con, "API.PA_ReportesCiudadanoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ReportesCiudadano  ->" + ex.Message);
				}
			}

			public ReportesCiudadano  Update(ReportesCiudadano pReportesCiudadano)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pReportesCiudadano.id==null ? 0 : pReportesCiudadano.id);
p.Add("@ID_TipoReporteCiudadano",pReportesCiudadano.ID_TipoReporteCiudadano==null ? 0 : pReportesCiudadano.ID_TipoReporteCiudadano);
p.Add("@ID_Categoria",pReportesCiudadano.ID_Categoria==null ? 0 : pReportesCiudadano.ID_Categoria);
p.Add("@ID_Vigencia",pReportesCiudadano.ID_Vigencia==null ? 0 : pReportesCiudadano.ID_Vigencia);
p.Add("@Detalle",pReportesCiudadano.Detalle==null ? 0 : pReportesCiudadano.Detalle);
                    p.Add("@auditoria", pReportesCiudadano.auditoria);

                         


                    ReportesCiudadano o = SqlMapper.QueryFirstOrDefault<ReportesCiudadano>(con, "API.PA_ReportesCiudadanoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ReportesCiudadano  ->" + ex.Message);
				}
			}

			public bool Delete(ReportesCiudadano pReportesCiudadano)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pReportesCiudadano.id);
                    p.Add("@auditoria", pReportesCiudadano.auditoria);

                

 

					ReportesCiudadano o = SqlMapper.QueryFirstOrDefault<ReportesCiudadano>(con, "API.PA_ReportesCiudadanoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ReportesCiudadano  ->" + ex.Message);
				}
			}

		



            public List<ReportesCiudadano> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ReportesCiudadano> ReportesCiudadanoList = new List<ReportesCiudadano>();

                    ReportesCiudadanoList = SqlMapper.Query<ReportesCiudadano>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ReportesCiudadanoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ReportesCiudadano  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ReportesCiudadano> b)
            {
                DapperPlusManager.Entity<ReportesCiudadano>().Table("ReportesCiudadano");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}