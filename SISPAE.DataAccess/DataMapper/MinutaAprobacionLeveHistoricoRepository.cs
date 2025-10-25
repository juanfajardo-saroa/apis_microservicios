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
     /// Clase Abstracta para  MinutaAprobacionLeveHistorico
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MinutaAprobacionLeveHistoricoRepository : DataObject , IMinutaAprobacionLeveHistorico 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MinutaAprobacionLeveHistoricoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MinutaAprobacionLeveHistoricoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MinutaAprobacionLeveHistorico GetById(MinutaAprobacionLeveHistorico pMinutaAprobacionLeveHistorico)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMinutaAprobacionLeveHistorico.id);                                    


    				MinutaAprobacionLeveHistorico o = SqlMapper.QueryFirstOrDefault<MinutaAprobacionLeveHistorico>(con, "API.PA_MinutaAprobacionLeveHistoricoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MinutaAprobacionLeveHistorico  ->" + ex.Message);
				}
			}

			public List<MinutaAprobacionLeveHistorico> GetAll()
			{
				try 
                {
                        List<MinutaAprobacionLeveHistorico> l = SqlMapper.Query<MinutaAprobacionLeveHistorico>(con, "API.PA_MinutaAprobacionLeveHistoricoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MinutaAprobacionLeveHistorico  ->" + ex.Message);
				}
			}

			public List<MinutaAprobacionLeveHistorico> GetAllFull()
			{
				try 
				{
                    List<MinutaAprobacionLeveHistorico> l = SqlMapper.Query<MinutaAprobacionLeveHistorico>(con, "API.PA_MinutaAprobacionLeveHistoricoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MinutaAprobacionLeveHistorico  ->" + ex.Message);
				}
			}
			
			public List<MinutaAprobacionLeveHistorico> GetAllByWithRelation()
			{
				try 
                {
                    List<MinutaAprobacionLeveHistorico> l = SqlMapper.Query<MinutaAprobacionLeveHistorico>(con, "API.PA_MinutaAprobacionLeveHistoricoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MinutaAprobacionLeveHistorico  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MinutaAprobacionLeveHistorico> GetByFilter(MinutaAprobacionLeveHistorico pMinutaAprobacionLeveHistorico, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMinutaAprobacionLeveHistorico.id== null || pMinutaAprobacionLeveHistorico.id==0) ? vintNUll :pMinutaAprobacionLeveHistorico.id);
                    p.Add("@ID_MinutaLeve",(pMinutaAprobacionLeveHistorico.ID_MinutaLeve== null || pMinutaAprobacionLeveHistorico.ID_MinutaLeve==0) ? vintNUll :pMinutaAprobacionLeveHistorico.ID_MinutaLeve);
                    p.Add("@FechaAprobacion",(pMinutaAprobacionLeveHistorico.FechaAprobacion== null) ? vintNUll :pMinutaAprobacionLeveHistorico.FechaAprobacion);
                    p.Add("@ID_TipoEstadoMinuta",(pMinutaAprobacionLeveHistorico.ID_TipoEstadoMinuta== null || pMinutaAprobacionLeveHistorico.ID_TipoEstadoMinuta==0) ? vintNUll :pMinutaAprobacionLeveHistorico.ID_TipoEstadoMinuta);
                    p.Add("@Responsable",(pMinutaAprobacionLeveHistorico.Responsable== null) ? vintNUll :pMinutaAprobacionLeveHistorico.Responsable);
                    p.Add("@RolResponsable",(pMinutaAprobacionLeveHistorico.RolResponsable== null) ? vintNUll :pMinutaAprobacionLeveHistorico.RolResponsable);
                    p.Add("@Accion",(pMinutaAprobacionLeveHistorico.Accion== null) ? vintNUll :pMinutaAprobacionLeveHistorico.Accion);
                    p.Add("@Observaciones",(pMinutaAprobacionLeveHistorico.Observaciones== null) ? vintNUll :pMinutaAprobacionLeveHistorico.Observaciones);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MinutaAprobacionLeveHistorico> l = SqlMapper.Query<MinutaAprobacionLeveHistorico>(con, "API.PA_MinutaAprobacionLeveHistoricoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MinutaAprobacionLeveHistorico  ->" + ex.Message);
				}
			}

			public MinutaAprobacionLeveHistorico Add(MinutaAprobacionLeveHistorico pMinutaAprobacionLeveHistorico)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMinutaAprobacionLeveHistorico.id==null ? 0 : pMinutaAprobacionLeveHistorico.id);
p.Add("@ID_MinutaLeve",pMinutaAprobacionLeveHistorico.ID_MinutaLeve==null ? 0 : pMinutaAprobacionLeveHistorico.ID_MinutaLeve);
                    p.Add("@FechaAprobacion", pMinutaAprobacionLeveHistorico.FechaAprobacion);
p.Add("@ID_TipoEstadoMinuta",pMinutaAprobacionLeveHistorico.ID_TipoEstadoMinuta==null ? 0 : pMinutaAprobacionLeveHistorico.ID_TipoEstadoMinuta);
                    p.Add("@Responsable", pMinutaAprobacionLeveHistorico.Responsable);
                    p.Add("@RolResponsable", pMinutaAprobacionLeveHistorico.RolResponsable);
                    p.Add("@Accion", pMinutaAprobacionLeveHistorico.Accion);
                    p.Add("@Observaciones", pMinutaAprobacionLeveHistorico.Observaciones);
                    p.Add("@auditoria", pMinutaAprobacionLeveHistorico.auditoria);

                         


                    MinutaAprobacionLeveHistorico o = SqlMapper.QueryFirstOrDefault<MinutaAprobacionLeveHistorico>(con, "API.PA_MinutaAprobacionLeveHistoricoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MinutaAprobacionLeveHistorico  ->" + ex.Message);
				}
			}

			public MinutaAprobacionLeveHistorico  Update(MinutaAprobacionLeveHistorico pMinutaAprobacionLeveHistorico)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMinutaAprobacionLeveHistorico.id==null ? 0 : pMinutaAprobacionLeveHistorico.id);
p.Add("@ID_MinutaLeve",pMinutaAprobacionLeveHistorico.ID_MinutaLeve==null ? 0 : pMinutaAprobacionLeveHistorico.ID_MinutaLeve);
                    p.Add("@FechaAprobacion", pMinutaAprobacionLeveHistorico.FechaAprobacion);
p.Add("@ID_TipoEstadoMinuta",pMinutaAprobacionLeveHistorico.ID_TipoEstadoMinuta==null ? 0 : pMinutaAprobacionLeveHistorico.ID_TipoEstadoMinuta);
                    p.Add("@Responsable", pMinutaAprobacionLeveHistorico.Responsable);
                    p.Add("@RolResponsable", pMinutaAprobacionLeveHistorico.RolResponsable);
                    p.Add("@Accion", pMinutaAprobacionLeveHistorico.Accion);
                    p.Add("@Observaciones", pMinutaAprobacionLeveHistorico.Observaciones);
                    p.Add("@auditoria", pMinutaAprobacionLeveHistorico.auditoria);

                         


                    MinutaAprobacionLeveHistorico o = SqlMapper.QueryFirstOrDefault<MinutaAprobacionLeveHistorico>(con, "API.PA_MinutaAprobacionLeveHistoricoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MinutaAprobacionLeveHistorico  ->" + ex.Message);
				}
			}

			public bool Delete(MinutaAprobacionLeveHistorico pMinutaAprobacionLeveHistorico)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMinutaAprobacionLeveHistorico.id);
                    p.Add("@auditoria", pMinutaAprobacionLeveHistorico.auditoria);

                

 

					MinutaAprobacionLeveHistorico o = SqlMapper.QueryFirstOrDefault<MinutaAprobacionLeveHistorico>(con, "API.PA_MinutaAprobacionLeveHistoricoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MinutaAprobacionLeveHistorico  ->" + ex.Message);
				}
			}

		



            public List<MinutaAprobacionLeveHistorico> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MinutaAprobacionLeveHistorico> MinutaAprobacionLeveHistoricoList = new List<MinutaAprobacionLeveHistorico>();

                    MinutaAprobacionLeveHistoricoList = SqlMapper.Query<MinutaAprobacionLeveHistorico>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MinutaAprobacionLeveHistoricoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MinutaAprobacionLeveHistorico  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MinutaAprobacionLeveHistorico> b)
            {
                DapperPlusManager.Entity<MinutaAprobacionLeveHistorico>().Table("MinutaAprobacionLeveHistorico");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}