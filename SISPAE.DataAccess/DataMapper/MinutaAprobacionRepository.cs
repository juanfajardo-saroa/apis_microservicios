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
     /// Clase Abstracta para  MinutaAprobacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MinutaAprobacionRepository : DataObject , IMinutaAprobacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MinutaAprobacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MinutaAprobacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MinutaAprobacion GetById(MinutaAprobacion pMinutaAprobacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMinutaAprobacion.id);                                    


    				MinutaAprobacion o = SqlMapper.QueryFirstOrDefault<MinutaAprobacion>(con, "API.PA_MinutaAprobacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MinutaAprobacion  ->" + ex.Message);
				}
			}

			public List<MinutaAprobacion> GetAll()
			{
				try 
                {
                        List<MinutaAprobacion> l = SqlMapper.Query<MinutaAprobacion>(con, "API.PA_MinutaAprobacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MinutaAprobacion  ->" + ex.Message);
				}
			}

			public List<MinutaAprobacion> GetAllFull()
			{
				try 
				{
                    List<MinutaAprobacion> l = SqlMapper.Query<MinutaAprobacion>(con, "API.PA_MinutaAprobacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MinutaAprobacion  ->" + ex.Message);
				}
			}
			
			public List<MinutaAprobacion> GetAllByWithRelation()
			{
				try 
                {
                    List<MinutaAprobacion> l = SqlMapper.Query<MinutaAprobacion>(con, "API.PA_MinutaAprobacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MinutaAprobacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MinutaAprobacion> GetByFilter(MinutaAprobacion pMinutaAprobacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMinutaAprobacion.id== null || pMinutaAprobacion.id==0) ? vintNUll :pMinutaAprobacion.id);
                    p.Add("@ID_TipoEstadoMinuta",(pMinutaAprobacion.ID_TipoEstadoMinuta== null || pMinutaAprobacion.ID_TipoEstadoMinuta==0) ? vintNUll :pMinutaAprobacion.ID_TipoEstadoMinuta);
                    p.Add("@Recomendaciones",(pMinutaAprobacion.Recomendaciones== null) ? vintNUll :pMinutaAprobacion.Recomendaciones);
                    p.Add("@Justificacion",(pMinutaAprobacion.Justificacion== null) ? vintNUll :pMinutaAprobacion.Justificacion);
                    p.Add("@AdjuntoJustificacionPATH",(pMinutaAprobacion.AdjuntoJustificacionPATH== null) ? vintNUll :pMinutaAprobacion.AdjuntoJustificacionPATH);
                    p.Add("@Rechazado",(pMinutaAprobacion.Rechazado== null) ? vintNUll :pMinutaAprobacion.Rechazado);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MinutaAprobacion> l = SqlMapper.Query<MinutaAprobacion>(con, "API.PA_MinutaAprobacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MinutaAprobacion  ->" + ex.Message);
				}
			}

			public MinutaAprobacion Add(MinutaAprobacion pMinutaAprobacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMinutaAprobacion.id==null ? 0 : pMinutaAprobacion.id);
p.Add("@ID_TipoEstadoMinuta",pMinutaAprobacion.ID_TipoEstadoMinuta==null ? 0 : pMinutaAprobacion.ID_TipoEstadoMinuta);
                    p.Add("@Recomendaciones", pMinutaAprobacion.Recomendaciones);
                    p.Add("@Justificacion", pMinutaAprobacion.Justificacion);
                    p.Add("@AdjuntoJustificacionPATH", pMinutaAprobacion.AdjuntoJustificacionPATH);
                    p.Add("@Rechazado", pMinutaAprobacion.Rechazado);
                    p.Add("@auditoria", pMinutaAprobacion.auditoria);

                         


                    MinutaAprobacion o = SqlMapper.QueryFirstOrDefault<MinutaAprobacion>(con, "API.PA_MinutaAprobacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MinutaAprobacion  ->" + ex.Message);
				}
			}

			public MinutaAprobacion  Update(MinutaAprobacion pMinutaAprobacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMinutaAprobacion.id==null ? 0 : pMinutaAprobacion.id);
p.Add("@ID_TipoEstadoMinuta",pMinutaAprobacion.ID_TipoEstadoMinuta==null ? 0 : pMinutaAprobacion.ID_TipoEstadoMinuta);
                    p.Add("@Recomendaciones", pMinutaAprobacion.Recomendaciones);
                    p.Add("@Justificacion", pMinutaAprobacion.Justificacion);
                    p.Add("@AdjuntoJustificacionPATH", pMinutaAprobacion.AdjuntoJustificacionPATH);
                    p.Add("@Rechazado", pMinutaAprobacion.Rechazado);
                    p.Add("@auditoria", pMinutaAprobacion.auditoria);

                         


                    MinutaAprobacion o = SqlMapper.QueryFirstOrDefault<MinutaAprobacion>(con, "API.PA_MinutaAprobacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MinutaAprobacion  ->" + ex.Message);
				}
			}

			public bool Delete(MinutaAprobacion pMinutaAprobacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMinutaAprobacion.id);
                    p.Add("@auditoria", pMinutaAprobacion.auditoria);

                

 

					MinutaAprobacion o = SqlMapper.QueryFirstOrDefault<MinutaAprobacion>(con, "API.PA_MinutaAprobacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MinutaAprobacion  ->" + ex.Message);
				}
			}

		



            public List<MinutaAprobacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MinutaAprobacion> MinutaAprobacionList = new List<MinutaAprobacion>();

                    MinutaAprobacionList = SqlMapper.Query<MinutaAprobacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MinutaAprobacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MinutaAprobacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MinutaAprobacion> b)
            {
                DapperPlusManager.Entity<MinutaAprobacion>().Table("MinutaAprobacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}