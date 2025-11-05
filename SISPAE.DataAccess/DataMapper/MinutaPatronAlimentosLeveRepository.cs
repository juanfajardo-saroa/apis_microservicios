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
     /// Clase Abstracta para  MinutaPatronAlimentosLeve
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MinutaPatronAlimentosLeveRepository : DataObject , IMinutaPatronAlimentosLeve 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MinutaPatronAlimentosLeveRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MinutaPatronAlimentosLeveRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MinutaPatronAlimentosLeve GetById(MinutaPatronAlimentosLeve pMinutaPatronAlimentosLeve)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMinutaPatronAlimentosLeve.id);                                    


    				MinutaPatronAlimentosLeve o = SqlMapper.QueryFirstOrDefault<MinutaPatronAlimentosLeve>(con, "API.PA_MinutaPatronAlimentosLeveGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MinutaPatronAlimentosLeve  ->" + ex.Message);
				}
			}

			public List<MinutaPatronAlimentosLeve> GetAll()
			{
				try 
                {
                        List<MinutaPatronAlimentosLeve> l = SqlMapper.Query<MinutaPatronAlimentosLeve>(con, "API.PA_MinutaPatronAlimentosLeveGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MinutaPatronAlimentosLeve  ->" + ex.Message);
				}
			}

			public List<MinutaPatronAlimentosLeve> GetAllFull()
			{
				try 
				{
                    List<MinutaPatronAlimentosLeve> l = SqlMapper.Query<MinutaPatronAlimentosLeve>(con, "API.PA_MinutaPatronAlimentosLeveGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MinutaPatronAlimentosLeve  ->" + ex.Message);
				}
			}
			
			public List<MinutaPatronAlimentosLeve> GetAllByWithRelation()
			{
				try 
                {
                    List<MinutaPatronAlimentosLeve> l = SqlMapper.Query<MinutaPatronAlimentosLeve>(con, "API.PA_MinutaPatronAlimentosLeveGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MinutaPatronAlimentosLeve  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MinutaPatronAlimentosLeve> GetByFilter(MinutaPatronAlimentosLeve pMinutaPatronAlimentosLeve, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMinutaPatronAlimentosLeve.id== null || pMinutaPatronAlimentosLeve.id==0) ? vintNUll :pMinutaPatronAlimentosLeve.id);
                    p.Add("@ID_ETC",(pMinutaPatronAlimentosLeve.ID_ETC== null || pMinutaPatronAlimentosLeve.ID_ETC==0) ? vintNUll :pMinutaPatronAlimentosLeve.ID_ETC);
                    p.Add("@ID_TipoModeloOperacion",(pMinutaPatronAlimentosLeve.ID_TipoModeloOperacion== null || pMinutaPatronAlimentosLeve.ID_TipoModeloOperacion==0) ? vintNUll :pMinutaPatronAlimentosLeve.ID_TipoModeloOperacion);
                    p.Add("@ID_TipoEstadoMinuta",(pMinutaPatronAlimentosLeve.ID_TipoEstadoMinuta== null || pMinutaPatronAlimentosLeve.ID_TipoEstadoMinuta==0) ? vintNUll :pMinutaPatronAlimentosLeve.ID_TipoEstadoMinuta);
                    p.Add("@TipoActividadFisicaId",(pMinutaPatronAlimentosLeve.TipoActividadFisicaId== null) ? vintNUll :pMinutaPatronAlimentosLeve.TipoActividadFisicaId);
                    p.Add("@Justificacion",(pMinutaPatronAlimentosLeve.Justificacion== null) ? vintNUll :pMinutaPatronAlimentosLeve.Justificacion);
                    p.Add("@AdjuntoJustificacionPATH",(pMinutaPatronAlimentosLeve.AdjuntoJustificacionPATH== null) ? vintNUll :pMinutaPatronAlimentosLeve.AdjuntoJustificacionPATH);
                    p.Add("@Rechazado",(pMinutaPatronAlimentosLeve.Rechazado== null) ? vintNUll :pMinutaPatronAlimentosLeve.Rechazado);
                    p.Add("@FechaSolicitud",(pMinutaPatronAlimentosLeve.FechaSolicitud== null) ? vintNUll :pMinutaPatronAlimentosLeve.FechaSolicitud);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MinutaPatronAlimentosLeve> l = SqlMapper.Query<MinutaPatronAlimentosLeve>(con, "API.PA_MinutaPatronAlimentosLeveGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MinutaPatronAlimentosLeve  ->" + ex.Message);
				}
			}

			public MinutaPatronAlimentosLeve Add(MinutaPatronAlimentosLeve pMinutaPatronAlimentosLeve)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMinutaPatronAlimentosLeve.id==null ? 0 : pMinutaPatronAlimentosLeve.id);
p.Add("@ID_ETC",pMinutaPatronAlimentosLeve.ID_ETC==null ? 0 : pMinutaPatronAlimentosLeve.ID_ETC);
p.Add("@ID_TipoModeloOperacion",pMinutaPatronAlimentosLeve.ID_TipoModeloOperacion==null ? 0 : pMinutaPatronAlimentosLeve.ID_TipoModeloOperacion);
p.Add("@ID_TipoEstadoMinuta",pMinutaPatronAlimentosLeve.ID_TipoEstadoMinuta==null ? 0 : pMinutaPatronAlimentosLeve.ID_TipoEstadoMinuta);
p.Add("@TipoActividadFisicaId",pMinutaPatronAlimentosLeve.TipoActividadFisicaId==null ? 0 : pMinutaPatronAlimentosLeve.TipoActividadFisicaId);
                    p.Add("@Justificacion", pMinutaPatronAlimentosLeve.Justificacion);
                    p.Add("@AdjuntoJustificacionPATH", pMinutaPatronAlimentosLeve.AdjuntoJustificacionPATH);
                    p.Add("@Rechazado", pMinutaPatronAlimentosLeve.Rechazado);
                    p.Add("@FechaSolicitud", pMinutaPatronAlimentosLeve.FechaSolicitud);
                    p.Add("@auditoria", pMinutaPatronAlimentosLeve.auditoria);

                         


                    MinutaPatronAlimentosLeve o = SqlMapper.QueryFirstOrDefault<MinutaPatronAlimentosLeve>(con, "API.PA_MinutaPatronAlimentosLeveAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MinutaPatronAlimentosLeve  ->" + ex.Message);
				}
			}

			public MinutaPatronAlimentosLeve  Update(MinutaPatronAlimentosLeve pMinutaPatronAlimentosLeve)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMinutaPatronAlimentosLeve.id==null ? 0 : pMinutaPatronAlimentosLeve.id);
p.Add("@ID_ETC",pMinutaPatronAlimentosLeve.ID_ETC==null ? 0 : pMinutaPatronAlimentosLeve.ID_ETC);
p.Add("@ID_TipoModeloOperacion",pMinutaPatronAlimentosLeve.ID_TipoModeloOperacion==null ? 0 : pMinutaPatronAlimentosLeve.ID_TipoModeloOperacion);
p.Add("@ID_TipoEstadoMinuta",pMinutaPatronAlimentosLeve.ID_TipoEstadoMinuta==null ? 0 : pMinutaPatronAlimentosLeve.ID_TipoEstadoMinuta);
p.Add("@TipoActividadFisicaId",pMinutaPatronAlimentosLeve.TipoActividadFisicaId==null ? 0 : pMinutaPatronAlimentosLeve.TipoActividadFisicaId);
                    p.Add("@Justificacion", pMinutaPatronAlimentosLeve.Justificacion);
                    p.Add("@AdjuntoJustificacionPATH", pMinutaPatronAlimentosLeve.AdjuntoJustificacionPATH);
                    p.Add("@Rechazado", pMinutaPatronAlimentosLeve.Rechazado);
                    p.Add("@FechaSolicitud", pMinutaPatronAlimentosLeve.FechaSolicitud);
                    p.Add("@auditoria", pMinutaPatronAlimentosLeve.auditoria);

                         


                    MinutaPatronAlimentosLeve o = SqlMapper.QueryFirstOrDefault<MinutaPatronAlimentosLeve>(con, "API.PA_MinutaPatronAlimentosLeveUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MinutaPatronAlimentosLeve  ->" + ex.Message);
				}
			}

			public bool Delete(MinutaPatronAlimentosLeve pMinutaPatronAlimentosLeve)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMinutaPatronAlimentosLeve.id);
                    p.Add("@auditoria", pMinutaPatronAlimentosLeve.auditoria);

                

 

					MinutaPatronAlimentosLeve o = SqlMapper.QueryFirstOrDefault<MinutaPatronAlimentosLeve>(con, "API.PA_MinutaPatronAlimentosLeveDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MinutaPatronAlimentosLeve  ->" + ex.Message);
				}
			}

		



            public List<MinutaPatronAlimentosLeve> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MinutaPatronAlimentosLeve> MinutaPatronAlimentosLeveList = new List<MinutaPatronAlimentosLeve>();

                    MinutaPatronAlimentosLeveList = SqlMapper.Query<MinutaPatronAlimentosLeve>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MinutaPatronAlimentosLeveList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MinutaPatronAlimentosLeve  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MinutaPatronAlimentosLeve> b)
            {
                DapperPlusManager.Entity<MinutaPatronAlimentosLeve>().Table("MinutaPatronAlimentosLeve");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}