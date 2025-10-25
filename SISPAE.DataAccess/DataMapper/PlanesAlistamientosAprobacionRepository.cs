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
     /// Clase Abstracta para  PlanesAlistamientosAprobacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PlanesAlistamientosAprobacionRepository : DataObject , IPlanesAlistamientosAprobacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PlanesAlistamientosAprobacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PlanesAlistamientosAprobacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public PlanesAlistamientosAprobacion GetById(PlanesAlistamientosAprobacion pPlanesAlistamientosAprobacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pPlanesAlistamientosAprobacion.id);                                    


    				PlanesAlistamientosAprobacion o = SqlMapper.QueryFirstOrDefault<PlanesAlistamientosAprobacion>(con, "API.PA_PlanesAlistamientosAprobacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  PlanesAlistamientosAprobacion  ->" + ex.Message);
				}
			}

			public List<PlanesAlistamientosAprobacion> GetAll()
			{
				try 
                {
                        List<PlanesAlistamientosAprobacion> l = SqlMapper.Query<PlanesAlistamientosAprobacion>(con, "API.PA_PlanesAlistamientosAprobacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  PlanesAlistamientosAprobacion  ->" + ex.Message);
				}
			}

			public List<PlanesAlistamientosAprobacion> GetAllFull()
			{
				try 
				{
                    List<PlanesAlistamientosAprobacion> l = SqlMapper.Query<PlanesAlistamientosAprobacion>(con, "API.PA_PlanesAlistamientosAprobacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  PlanesAlistamientosAprobacion  ->" + ex.Message);
				}
			}
			
			public List<PlanesAlistamientosAprobacion> GetAllByWithRelation()
			{
				try 
                {
                    List<PlanesAlistamientosAprobacion> l = SqlMapper.Query<PlanesAlistamientosAprobacion>(con, "API.PA_PlanesAlistamientosAprobacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  PlanesAlistamientosAprobacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<PlanesAlistamientosAprobacion> GetByFilter(PlanesAlistamientosAprobacion pPlanesAlistamientosAprobacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pPlanesAlistamientosAprobacion.id== null || pPlanesAlistamientosAprobacion.id==0) ? vintNUll :pPlanesAlistamientosAprobacion.id);
                    p.Add("@ID_PlanAlistamiento",(pPlanesAlistamientosAprobacion.ID_PlanAlistamiento== null || pPlanesAlistamientosAprobacion.ID_PlanAlistamiento==0) ? vintNUll :pPlanesAlistamientosAprobacion.ID_PlanAlistamiento);
                    p.Add("@ID_EstadoAlistamiento",(pPlanesAlistamientosAprobacion.ID_EstadoAlistamiento== null || pPlanesAlistamientosAprobacion.ID_EstadoAlistamiento==0) ? vintNUll :pPlanesAlistamientosAprobacion.ID_EstadoAlistamiento);
                    p.Add("@FechaAprobacion",(pPlanesAlistamientosAprobacion.FechaAprobacion== null) ? vintNUll :pPlanesAlistamientosAprobacion.FechaAprobacion);
                    p.Add("@ID_EstadoDocumento",(pPlanesAlistamientosAprobacion.ID_EstadoDocumento== null || pPlanesAlistamientosAprobacion.ID_EstadoDocumento==0) ? vintNUll :pPlanesAlistamientosAprobacion.ID_EstadoDocumento);
                    p.Add("@Responsable",(pPlanesAlistamientosAprobacion.Responsable== null) ? vintNUll :pPlanesAlistamientosAprobacion.Responsable);
                    p.Add("@RolResponsable",(pPlanesAlistamientosAprobacion.RolResponsable== null) ? vintNUll :pPlanesAlistamientosAprobacion.RolResponsable);
                    p.Add("@Accion",(pPlanesAlistamientosAprobacion.Accion== null) ? vintNUll :pPlanesAlistamientosAprobacion.Accion);
                    p.Add("@Observaciones",(pPlanesAlistamientosAprobacion.Observaciones== null) ? vintNUll :pPlanesAlistamientosAprobacion.Observaciones);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<PlanesAlistamientosAprobacion> l = SqlMapper.Query<PlanesAlistamientosAprobacion>(con, "API.PA_PlanesAlistamientosAprobacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  PlanesAlistamientosAprobacion  ->" + ex.Message);
				}
			}

			public PlanesAlistamientosAprobacion Add(PlanesAlistamientosAprobacion pPlanesAlistamientosAprobacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pPlanesAlistamientosAprobacion.id==null ? 0 : pPlanesAlistamientosAprobacion.id);
p.Add("@ID_PlanAlistamiento",pPlanesAlistamientosAprobacion.ID_PlanAlistamiento==null ? 0 : pPlanesAlistamientosAprobacion.ID_PlanAlistamiento);
p.Add("@ID_EstadoAlistamiento",pPlanesAlistamientosAprobacion.ID_EstadoAlistamiento==null ? 0 : pPlanesAlistamientosAprobacion.ID_EstadoAlistamiento);
                    p.Add("@FechaAprobacion", pPlanesAlistamientosAprobacion.FechaAprobacion);
p.Add("@ID_EstadoDocumento",pPlanesAlistamientosAprobacion.ID_EstadoDocumento==null ? 0 : pPlanesAlistamientosAprobacion.ID_EstadoDocumento);
                    p.Add("@Responsable", pPlanesAlistamientosAprobacion.Responsable);
                    p.Add("@RolResponsable", pPlanesAlistamientosAprobacion.RolResponsable);
                    p.Add("@Accion", pPlanesAlistamientosAprobacion.Accion);
                    p.Add("@Observaciones", pPlanesAlistamientosAprobacion.Observaciones);
                    p.Add("@auditoria", pPlanesAlistamientosAprobacion.auditoria);

                         


                    PlanesAlistamientosAprobacion o = SqlMapper.QueryFirstOrDefault<PlanesAlistamientosAprobacion>(con, "API.PA_PlanesAlistamientosAprobacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  PlanesAlistamientosAprobacion  ->" + ex.Message);
				}
			}

			public PlanesAlistamientosAprobacion  Update(PlanesAlistamientosAprobacion pPlanesAlistamientosAprobacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pPlanesAlistamientosAprobacion.id==null ? 0 : pPlanesAlistamientosAprobacion.id);
p.Add("@ID_PlanAlistamiento",pPlanesAlistamientosAprobacion.ID_PlanAlistamiento==null ? 0 : pPlanesAlistamientosAprobacion.ID_PlanAlistamiento);
p.Add("@ID_EstadoAlistamiento",pPlanesAlistamientosAprobacion.ID_EstadoAlistamiento==null ? 0 : pPlanesAlistamientosAprobacion.ID_EstadoAlistamiento);
                    p.Add("@FechaAprobacion", pPlanesAlistamientosAprobacion.FechaAprobacion);
p.Add("@ID_EstadoDocumento",pPlanesAlistamientosAprobacion.ID_EstadoDocumento==null ? 0 : pPlanesAlistamientosAprobacion.ID_EstadoDocumento);
                    p.Add("@Responsable", pPlanesAlistamientosAprobacion.Responsable);
                    p.Add("@RolResponsable", pPlanesAlistamientosAprobacion.RolResponsable);
                    p.Add("@Accion", pPlanesAlistamientosAprobacion.Accion);
                    p.Add("@Observaciones", pPlanesAlistamientosAprobacion.Observaciones);
                    p.Add("@auditoria", pPlanesAlistamientosAprobacion.auditoria);

                         


                    PlanesAlistamientosAprobacion o = SqlMapper.QueryFirstOrDefault<PlanesAlistamientosAprobacion>(con, "API.PA_PlanesAlistamientosAprobacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  PlanesAlistamientosAprobacion  ->" + ex.Message);
				}
			}

			public bool Delete(PlanesAlistamientosAprobacion pPlanesAlistamientosAprobacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pPlanesAlistamientosAprobacion.id);
                    p.Add("@auditoria", pPlanesAlistamientosAprobacion.auditoria);

                

 

					PlanesAlistamientosAprobacion o = SqlMapper.QueryFirstOrDefault<PlanesAlistamientosAprobacion>(con, "API.PA_PlanesAlistamientosAprobacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) PlanesAlistamientosAprobacion  ->" + ex.Message);
				}
			}

		



            public List<PlanesAlistamientosAprobacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<PlanesAlistamientosAprobacion> PlanesAlistamientosAprobacionList = new List<PlanesAlistamientosAprobacion>();

                    PlanesAlistamientosAprobacionList = SqlMapper.Query<PlanesAlistamientosAprobacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PlanesAlistamientosAprobacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) PlanesAlistamientosAprobacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<PlanesAlistamientosAprobacion> b)
            {
                DapperPlusManager.Entity<PlanesAlistamientosAprobacion>().Table("PlanesAlistamientosAprobacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}