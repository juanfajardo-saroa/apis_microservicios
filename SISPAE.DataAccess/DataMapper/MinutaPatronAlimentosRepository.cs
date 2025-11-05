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
     /// Clase Abstracta para  MinutaPatronAlimentos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MinutaPatronAlimentosRepository : DataObject , IMinutaPatronAlimentos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MinutaPatronAlimentosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MinutaPatronAlimentosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MinutaPatronAlimentos GetById(MinutaPatronAlimentos pMinutaPatronAlimentos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMinutaPatronAlimentos.id);                                    


    				MinutaPatronAlimentos o = SqlMapper.QueryFirstOrDefault<MinutaPatronAlimentos>(con, "API.PA_MinutaPatronAlimentosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MinutaPatronAlimentos  ->" + ex.Message);
				}
			}

			public List<MinutaPatronAlimentos> GetAll()
			{
				try 
                {
                        List<MinutaPatronAlimentos> l = SqlMapper.Query<MinutaPatronAlimentos>(con, "API.PA_MinutaPatronAlimentosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MinutaPatronAlimentos  ->" + ex.Message);
				}
			}

			public List<MinutaPatronAlimentos> GetAllFull()
			{
				try 
				{
                    List<MinutaPatronAlimentos> l = SqlMapper.Query<MinutaPatronAlimentos>(con, "API.PA_MinutaPatronAlimentosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MinutaPatronAlimentos  ->" + ex.Message);
				}
			}
			
			public List<MinutaPatronAlimentos> GetAllByWithRelation()
			{
				try 
                {
                    List<MinutaPatronAlimentos> l = SqlMapper.Query<MinutaPatronAlimentos>(con, "API.PA_MinutaPatronAlimentosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MinutaPatronAlimentos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MinutaPatronAlimentos> GetByFilter(MinutaPatronAlimentos pMinutaPatronAlimentos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMinutaPatronAlimentos.id== null || pMinutaPatronAlimentos.id==0) ? vintNUll :pMinutaPatronAlimentos.id);
                    p.Add("@ID_ETC",(pMinutaPatronAlimentos.ID_ETC== null || pMinutaPatronAlimentos.ID_ETC==0) ? vintNUll :pMinutaPatronAlimentos.ID_ETC);
                    p.Add("@Nombre",(pMinutaPatronAlimentos.Nombre== null) ? vintNUll :pMinutaPatronAlimentos.Nombre);
                    p.Add("@ID_TipoMinutaPatron",(pMinutaPatronAlimentos.ID_TipoMinutaPatron== null || pMinutaPatronAlimentos.ID_TipoMinutaPatron==0) ? vintNUll :pMinutaPatronAlimentos.ID_TipoMinutaPatron);
                    p.Add("@ID_TipoEstadoMinuta",(pMinutaPatronAlimentos.ID_TipoEstadoMinuta== null || pMinutaPatronAlimentos.ID_TipoEstadoMinuta==0) ? vintNUll :pMinutaPatronAlimentos.ID_TipoEstadoMinuta);
                    p.Add("@ModalidadComplementoId",(pMinutaPatronAlimentos.ModalidadComplementoId== null) ? vintNUll :pMinutaPatronAlimentos.ModalidadComplementoId);
                    p.Add("@TipoComplementoId",(pMinutaPatronAlimentos.TipoComplementoId== null) ? vintNUll :pMinutaPatronAlimentos.TipoComplementoId);
                    p.Add("@TipoNivelEducativoId",(pMinutaPatronAlimentos.TipoNivelEducativoId== null) ? vintNUll :pMinutaPatronAlimentos.TipoNivelEducativoId);
                    p.Add("@TipoActividadFisicaId",(pMinutaPatronAlimentos.TipoActividadFisicaId== null) ? vintNUll :pMinutaPatronAlimentos.TipoActividadFisicaId);
                    p.Add("@Recomendaciones",(pMinutaPatronAlimentos.Recomendaciones== null) ? vintNUll :pMinutaPatronAlimentos.Recomendaciones);
                    p.Add("@Justificacion",(pMinutaPatronAlimentos.Justificacion== null) ? vintNUll :pMinutaPatronAlimentos.Justificacion);
                    p.Add("@AdjuntoJustificacionPATH",(pMinutaPatronAlimentos.AdjuntoJustificacionPATH== null) ? vintNUll :pMinutaPatronAlimentos.AdjuntoJustificacionPATH);
                    p.Add("@Rechazado",(pMinutaPatronAlimentos.Rechazado== null) ? vintNUll :pMinutaPatronAlimentos.Rechazado);
                    p.Add("@Id_Vigencia",(pMinutaPatronAlimentos.Id_Vigencia== null || pMinutaPatronAlimentos.Id_Vigencia==0) ? vintNUll :pMinutaPatronAlimentos.Id_Vigencia);
                    p.Add("@ID_MinutaAprobacion",(pMinutaPatronAlimentos.ID_MinutaAprobacion== null || pMinutaPatronAlimentos.ID_MinutaAprobacion==0) ? vintNUll :pMinutaPatronAlimentos.ID_MinutaAprobacion);
                    p.Add("@ID_TipoModeloOperacion",(pMinutaPatronAlimentos.ID_TipoModeloOperacion== null || pMinutaPatronAlimentos.ID_TipoModeloOperacion==0) ? vintNUll :pMinutaPatronAlimentos.ID_TipoModeloOperacion);
                    p.Add("@ID_TipoModeloOperacionBase",(pMinutaPatronAlimentos.ID_TipoModeloOperacionBase== null || pMinutaPatronAlimentos.ID_TipoModeloOperacionBase==0) ? vintNUll :pMinutaPatronAlimentos.ID_TipoModeloOperacionBase);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MinutaPatronAlimentos> l = SqlMapper.Query<MinutaPatronAlimentos>(con, "API.PA_MinutaPatronAlimentosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MinutaPatronAlimentos  ->" + ex.Message);
				}
			}

			public MinutaPatronAlimentos Add(MinutaPatronAlimentos pMinutaPatronAlimentos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMinutaPatronAlimentos.id==null ? 0 : pMinutaPatronAlimentos.id);
p.Add("@ID_ETC",pMinutaPatronAlimentos.ID_ETC==null ? 0 : pMinutaPatronAlimentos.ID_ETC);
                    p.Add("@Nombre", pMinutaPatronAlimentos.Nombre);
p.Add("@ID_TipoMinutaPatron",pMinutaPatronAlimentos.ID_TipoMinutaPatron==null ? 0 : pMinutaPatronAlimentos.ID_TipoMinutaPatron);
p.Add("@ID_TipoEstadoMinuta",pMinutaPatronAlimentos.ID_TipoEstadoMinuta==null ? 0 : pMinutaPatronAlimentos.ID_TipoEstadoMinuta);
p.Add("@ModalidadComplementoId",pMinutaPatronAlimentos.ModalidadComplementoId==null ? 0 : pMinutaPatronAlimentos.ModalidadComplementoId);
p.Add("@TipoComplementoId",pMinutaPatronAlimentos.TipoComplementoId==null ? 0 : pMinutaPatronAlimentos.TipoComplementoId);
p.Add("@TipoNivelEducativoId",pMinutaPatronAlimentos.TipoNivelEducativoId==null ? 0 : pMinutaPatronAlimentos.TipoNivelEducativoId);
p.Add("@TipoActividadFisicaId",pMinutaPatronAlimentos.TipoActividadFisicaId==null ? 0 : pMinutaPatronAlimentos.TipoActividadFisicaId);
                    p.Add("@Recomendaciones", pMinutaPatronAlimentos.Recomendaciones);
                    p.Add("@Justificacion", pMinutaPatronAlimentos.Justificacion);
                    p.Add("@AdjuntoJustificacionPATH", pMinutaPatronAlimentos.AdjuntoJustificacionPATH);
                    p.Add("@Rechazado", pMinutaPatronAlimentos.Rechazado);
p.Add("@Id_Vigencia",pMinutaPatronAlimentos.Id_Vigencia==null ? 0 : pMinutaPatronAlimentos.Id_Vigencia);
p.Add("@ID_MinutaAprobacion",pMinutaPatronAlimentos.ID_MinutaAprobacion==null ? 0 : pMinutaPatronAlimentos.ID_MinutaAprobacion);
p.Add("@ID_TipoModeloOperacion",pMinutaPatronAlimentos.ID_TipoModeloOperacion==null ? 0 : pMinutaPatronAlimentos.ID_TipoModeloOperacion);
p.Add("@ID_TipoModeloOperacionBase",pMinutaPatronAlimentos.ID_TipoModeloOperacionBase==null ? 0 : pMinutaPatronAlimentos.ID_TipoModeloOperacionBase);
                    p.Add("@auditoria", pMinutaPatronAlimentos.auditoria);

                         


                    MinutaPatronAlimentos o = SqlMapper.QueryFirstOrDefault<MinutaPatronAlimentos>(con, "API.PA_MinutaPatronAlimentosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MinutaPatronAlimentos  ->" + ex.Message);
				}
			}

			public MinutaPatronAlimentos  Update(MinutaPatronAlimentos pMinutaPatronAlimentos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMinutaPatronAlimentos.id==null ? 0 : pMinutaPatronAlimentos.id);
p.Add("@ID_ETC",pMinutaPatronAlimentos.ID_ETC==null ? 0 : pMinutaPatronAlimentos.ID_ETC);
                    p.Add("@Nombre", pMinutaPatronAlimentos.Nombre);
p.Add("@ID_TipoMinutaPatron",pMinutaPatronAlimentos.ID_TipoMinutaPatron==null ? 0 : pMinutaPatronAlimentos.ID_TipoMinutaPatron);
p.Add("@ID_TipoEstadoMinuta",pMinutaPatronAlimentos.ID_TipoEstadoMinuta==null ? 0 : pMinutaPatronAlimentos.ID_TipoEstadoMinuta);
p.Add("@ModalidadComplementoId",pMinutaPatronAlimentos.ModalidadComplementoId==null ? 0 : pMinutaPatronAlimentos.ModalidadComplementoId);
p.Add("@TipoComplementoId",pMinutaPatronAlimentos.TipoComplementoId==null ? 0 : pMinutaPatronAlimentos.TipoComplementoId);
p.Add("@TipoNivelEducativoId",pMinutaPatronAlimentos.TipoNivelEducativoId==null ? 0 : pMinutaPatronAlimentos.TipoNivelEducativoId);
p.Add("@TipoActividadFisicaId",pMinutaPatronAlimentos.TipoActividadFisicaId==null ? 0 : pMinutaPatronAlimentos.TipoActividadFisicaId);
                    p.Add("@Recomendaciones", pMinutaPatronAlimentos.Recomendaciones);
                    p.Add("@Justificacion", pMinutaPatronAlimentos.Justificacion);
                    p.Add("@AdjuntoJustificacionPATH", pMinutaPatronAlimentos.AdjuntoJustificacionPATH);
                    p.Add("@Rechazado", pMinutaPatronAlimentos.Rechazado);
p.Add("@Id_Vigencia",pMinutaPatronAlimentos.Id_Vigencia==null ? 0 : pMinutaPatronAlimentos.Id_Vigencia);
p.Add("@ID_MinutaAprobacion",pMinutaPatronAlimentos.ID_MinutaAprobacion==null ? 0 : pMinutaPatronAlimentos.ID_MinutaAprobacion);
p.Add("@ID_TipoModeloOperacion",pMinutaPatronAlimentos.ID_TipoModeloOperacion==null ? 0 : pMinutaPatronAlimentos.ID_TipoModeloOperacion);
p.Add("@ID_TipoModeloOperacionBase",pMinutaPatronAlimentos.ID_TipoModeloOperacionBase==null ? 0 : pMinutaPatronAlimentos.ID_TipoModeloOperacionBase);
                    p.Add("@auditoria", pMinutaPatronAlimentos.auditoria);

                         


                    MinutaPatronAlimentos o = SqlMapper.QueryFirstOrDefault<MinutaPatronAlimentos>(con, "API.PA_MinutaPatronAlimentosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MinutaPatronAlimentos  ->" + ex.Message);
				}
			}

			public bool Delete(MinutaPatronAlimentos pMinutaPatronAlimentos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMinutaPatronAlimentos.id);
                    p.Add("@auditoria", pMinutaPatronAlimentos.auditoria);

                

 

					MinutaPatronAlimentos o = SqlMapper.QueryFirstOrDefault<MinutaPatronAlimentos>(con, "API.PA_MinutaPatronAlimentosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MinutaPatronAlimentos  ->" + ex.Message);
				}
			}

		



            public List<MinutaPatronAlimentos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MinutaPatronAlimentos> MinutaPatronAlimentosList = new List<MinutaPatronAlimentos>();

                    MinutaPatronAlimentosList = SqlMapper.Query<MinutaPatronAlimentos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MinutaPatronAlimentosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MinutaPatronAlimentos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MinutaPatronAlimentos> b)
            {
                DapperPlusManager.Entity<MinutaPatronAlimentos>().Table("MinutaPatronAlimentos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}