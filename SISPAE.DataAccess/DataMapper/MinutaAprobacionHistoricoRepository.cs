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
     /// Clase Abstracta para  MinutaAprobacionHistorico
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MinutaAprobacionHistoricoRepository : DataObject , IMinutaAprobacionHistorico 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MinutaAprobacionHistoricoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MinutaAprobacionHistoricoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MinutaAprobacionHistorico GetById(MinutaAprobacionHistorico pMinutaAprobacionHistorico)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMinutaAprobacionHistorico.id);                                    


    				MinutaAprobacionHistorico o = SqlMapper.QueryFirstOrDefault<MinutaAprobacionHistorico>(con, "API.PA_MinutaAprobacionHistoricoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MinutaAprobacionHistorico  ->" + ex.Message);
				}
			}

			public List<MinutaAprobacionHistorico> GetAll()
			{
				try 
                {
                        List<MinutaAprobacionHistorico> l = SqlMapper.Query<MinutaAprobacionHistorico>(con, "API.PA_MinutaAprobacionHistoricoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MinutaAprobacionHistorico  ->" + ex.Message);
				}
			}

			public List<MinutaAprobacionHistorico> GetAllFull()
			{
				try 
				{
                    List<MinutaAprobacionHistorico> l = SqlMapper.Query<MinutaAprobacionHistorico>(con, "API.PA_MinutaAprobacionHistoricoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MinutaAprobacionHistorico  ->" + ex.Message);
				}
			}
			
			public List<MinutaAprobacionHistorico> GetAllByWithRelation()
			{
				try 
                {
                    List<MinutaAprobacionHistorico> l = SqlMapper.Query<MinutaAprobacionHistorico>(con, "API.PA_MinutaAprobacionHistoricoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MinutaAprobacionHistorico  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MinutaAprobacionHistorico> GetByFilter(MinutaAprobacionHistorico pMinutaAprobacionHistorico, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMinutaAprobacionHistorico.id== null || pMinutaAprobacionHistorico.id==0) ? vintNUll :pMinutaAprobacionHistorico.id);
                    p.Add("@ID_MinutaAprobacion",(pMinutaAprobacionHistorico.ID_MinutaAprobacion== null || pMinutaAprobacionHistorico.ID_MinutaAprobacion==0) ? vintNUll :pMinutaAprobacionHistorico.ID_MinutaAprobacion);
                    p.Add("@FechaAprobacion",(pMinutaAprobacionHistorico.FechaAprobacion== null) ? vintNUll :pMinutaAprobacionHistorico.FechaAprobacion);
                    p.Add("@ID_TipoEstadoMinuta",(pMinutaAprobacionHistorico.ID_TipoEstadoMinuta== null || pMinutaAprobacionHistorico.ID_TipoEstadoMinuta==0) ? vintNUll :pMinutaAprobacionHistorico.ID_TipoEstadoMinuta);
                    p.Add("@Responsable",(pMinutaAprobacionHistorico.Responsable== null) ? vintNUll :pMinutaAprobacionHistorico.Responsable);
                    p.Add("@RolResponsable",(pMinutaAprobacionHistorico.RolResponsable== null) ? vintNUll :pMinutaAprobacionHistorico.RolResponsable);
                    p.Add("@Accion",(pMinutaAprobacionHistorico.Accion== null) ? vintNUll :pMinutaAprobacionHistorico.Accion);
                    p.Add("@Observaciones",(pMinutaAprobacionHistorico.Observaciones== null) ? vintNUll :pMinutaAprobacionHistorico.Observaciones);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MinutaAprobacionHistorico> l = SqlMapper.Query<MinutaAprobacionHistorico>(con, "API.PA_MinutaAprobacionHistoricoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MinutaAprobacionHistorico  ->" + ex.Message);
				}
			}

			public MinutaAprobacionHistorico Add(MinutaAprobacionHistorico pMinutaAprobacionHistorico)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMinutaAprobacionHistorico.id==null ? 0 : pMinutaAprobacionHistorico.id);
p.Add("@ID_MinutaAprobacion",pMinutaAprobacionHistorico.ID_MinutaAprobacion==null ? 0 : pMinutaAprobacionHistorico.ID_MinutaAprobacion);
                    p.Add("@FechaAprobacion", pMinutaAprobacionHistorico.FechaAprobacion);
p.Add("@ID_TipoEstadoMinuta",pMinutaAprobacionHistorico.ID_TipoEstadoMinuta==null ? 0 : pMinutaAprobacionHistorico.ID_TipoEstadoMinuta);
                    p.Add("@Responsable", pMinutaAprobacionHistorico.Responsable);
                    p.Add("@RolResponsable", pMinutaAprobacionHistorico.RolResponsable);
                    p.Add("@Accion", pMinutaAprobacionHistorico.Accion);
                    p.Add("@Observaciones", pMinutaAprobacionHistorico.Observaciones);
                    p.Add("@auditoria", pMinutaAprobacionHistorico.auditoria);

                         


                    MinutaAprobacionHistorico o = SqlMapper.QueryFirstOrDefault<MinutaAprobacionHistorico>(con, "API.PA_MinutaAprobacionHistoricoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MinutaAprobacionHistorico  ->" + ex.Message);
				}
			}

			public MinutaAprobacionHistorico  Update(MinutaAprobacionHistorico pMinutaAprobacionHistorico)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMinutaAprobacionHistorico.id==null ? 0 : pMinutaAprobacionHistorico.id);
p.Add("@ID_MinutaAprobacion",pMinutaAprobacionHistorico.ID_MinutaAprobacion==null ? 0 : pMinutaAprobacionHistorico.ID_MinutaAprobacion);
                    p.Add("@FechaAprobacion", pMinutaAprobacionHistorico.FechaAprobacion);
p.Add("@ID_TipoEstadoMinuta",pMinutaAprobacionHistorico.ID_TipoEstadoMinuta==null ? 0 : pMinutaAprobacionHistorico.ID_TipoEstadoMinuta);
                    p.Add("@Responsable", pMinutaAprobacionHistorico.Responsable);
                    p.Add("@RolResponsable", pMinutaAprobacionHistorico.RolResponsable);
                    p.Add("@Accion", pMinutaAprobacionHistorico.Accion);
                    p.Add("@Observaciones", pMinutaAprobacionHistorico.Observaciones);
                    p.Add("@auditoria", pMinutaAprobacionHistorico.auditoria);

                         


                    MinutaAprobacionHistorico o = SqlMapper.QueryFirstOrDefault<MinutaAprobacionHistorico>(con, "API.PA_MinutaAprobacionHistoricoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MinutaAprobacionHistorico  ->" + ex.Message);
				}
			}

			public bool Delete(MinutaAprobacionHistorico pMinutaAprobacionHistorico)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMinutaAprobacionHistorico.id);
                    p.Add("@auditoria", pMinutaAprobacionHistorico.auditoria);

                

 

					MinutaAprobacionHistorico o = SqlMapper.QueryFirstOrDefault<MinutaAprobacionHistorico>(con, "API.PA_MinutaAprobacionHistoricoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MinutaAprobacionHistorico  ->" + ex.Message);
				}
			}

		



            public List<MinutaAprobacionHistorico> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MinutaAprobacionHistorico> MinutaAprobacionHistoricoList = new List<MinutaAprobacionHistorico>();

                    MinutaAprobacionHistoricoList = SqlMapper.Query<MinutaAprobacionHistorico>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MinutaAprobacionHistoricoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MinutaAprobacionHistorico  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MinutaAprobacionHistorico> b)
            {
                DapperPlusManager.Entity<MinutaAprobacionHistorico>().Table("MinutaAprobacionHistorico");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}