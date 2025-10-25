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
     /// Clase Abstracta para  ContratosAprobacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ContratosAprobacionRepository : DataObject , IContratosAprobacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ContratosAprobacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ContratosAprobacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ContratosAprobacion GetById(ContratosAprobacion pContratosAprobacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pContratosAprobacion.id);                                    


    				ContratosAprobacion o = SqlMapper.QueryFirstOrDefault<ContratosAprobacion>(con, "API.PA_ContratosAprobacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ContratosAprobacion  ->" + ex.Message);
				}
			}

			public List<ContratosAprobacion> GetAll()
			{
				try 
                {
                        List<ContratosAprobacion> l = SqlMapper.Query<ContratosAprobacion>(con, "API.PA_ContratosAprobacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ContratosAprobacion  ->" + ex.Message);
				}
			}

			public List<ContratosAprobacion> GetAllFull()
			{
				try 
				{
                    List<ContratosAprobacion> l = SqlMapper.Query<ContratosAprobacion>(con, "API.PA_ContratosAprobacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ContratosAprobacion  ->" + ex.Message);
				}
			}
			
			public List<ContratosAprobacion> GetAllByWithRelation()
			{
				try 
                {
                    List<ContratosAprobacion> l = SqlMapper.Query<ContratosAprobacion>(con, "API.PA_ContratosAprobacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ContratosAprobacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ContratosAprobacion> GetByFilter(ContratosAprobacion pContratosAprobacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pContratosAprobacion.id== null || pContratosAprobacion.id==0) ? vintNUll :pContratosAprobacion.id);
                    p.Add("@ID_Contrato",(pContratosAprobacion.ID_Contrato== null || pContratosAprobacion.ID_Contrato==0) ? vintNUll :pContratosAprobacion.ID_Contrato);
                    p.Add("@FechaAprobacion",(pContratosAprobacion.FechaAprobacion== null) ? vintNUll :pContratosAprobacion.FechaAprobacion);
                    p.Add("@ID_TipoEstadoContrato",(pContratosAprobacion.ID_TipoEstadoContrato== null || pContratosAprobacion.ID_TipoEstadoContrato==0) ? vintNUll :pContratosAprobacion.ID_TipoEstadoContrato);
                    p.Add("@Responsable",(pContratosAprobacion.Responsable== null) ? vintNUll :pContratosAprobacion.Responsable);
                    p.Add("@RolResponsable",(pContratosAprobacion.RolResponsable== null) ? vintNUll :pContratosAprobacion.RolResponsable);
                    p.Add("@Accion",(pContratosAprobacion.Accion== null) ? vintNUll :pContratosAprobacion.Accion);
                    p.Add("@Observaciones",(pContratosAprobacion.Observaciones== null) ? vintNUll :pContratosAprobacion.Observaciones);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ContratosAprobacion> l = SqlMapper.Query<ContratosAprobacion>(con, "API.PA_ContratosAprobacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ContratosAprobacion  ->" + ex.Message);
				}
			}

			public ContratosAprobacion Add(ContratosAprobacion pContratosAprobacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pContratosAprobacion.id==null ? 0 : pContratosAprobacion.id);
p.Add("@ID_Contrato",pContratosAprobacion.ID_Contrato==null ? 0 : pContratosAprobacion.ID_Contrato);
                    p.Add("@FechaAprobacion", pContratosAprobacion.FechaAprobacion);
p.Add("@ID_TipoEstadoContrato",pContratosAprobacion.ID_TipoEstadoContrato==null ? 0 : pContratosAprobacion.ID_TipoEstadoContrato);
                    p.Add("@Responsable", pContratosAprobacion.Responsable);
                    p.Add("@RolResponsable", pContratosAprobacion.RolResponsable);
                    p.Add("@Accion", pContratosAprobacion.Accion);
                    p.Add("@Observaciones", pContratosAprobacion.Observaciones);
                    p.Add("@auditoria", pContratosAprobacion.auditoria);

                         


                    ContratosAprobacion o = SqlMapper.QueryFirstOrDefault<ContratosAprobacion>(con, "API.PA_ContratosAprobacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ContratosAprobacion  ->" + ex.Message);
				}
			}

			public ContratosAprobacion  Update(ContratosAprobacion pContratosAprobacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pContratosAprobacion.id==null ? 0 : pContratosAprobacion.id);
p.Add("@ID_Contrato",pContratosAprobacion.ID_Contrato==null ? 0 : pContratosAprobacion.ID_Contrato);
                    p.Add("@FechaAprobacion", pContratosAprobacion.FechaAprobacion);
p.Add("@ID_TipoEstadoContrato",pContratosAprobacion.ID_TipoEstadoContrato==null ? 0 : pContratosAprobacion.ID_TipoEstadoContrato);
                    p.Add("@Responsable", pContratosAprobacion.Responsable);
                    p.Add("@RolResponsable", pContratosAprobacion.RolResponsable);
                    p.Add("@Accion", pContratosAprobacion.Accion);
                    p.Add("@Observaciones", pContratosAprobacion.Observaciones);
                    p.Add("@auditoria", pContratosAprobacion.auditoria);

                         


                    ContratosAprobacion o = SqlMapper.QueryFirstOrDefault<ContratosAprobacion>(con, "API.PA_ContratosAprobacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ContratosAprobacion  ->" + ex.Message);
				}
			}

			public bool Delete(ContratosAprobacion pContratosAprobacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pContratosAprobacion.id);
                    p.Add("@auditoria", pContratosAprobacion.auditoria);

                

 

					ContratosAprobacion o = SqlMapper.QueryFirstOrDefault<ContratosAprobacion>(con, "API.PA_ContratosAprobacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ContratosAprobacion  ->" + ex.Message);
				}
			}

		



            public List<ContratosAprobacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ContratosAprobacion> ContratosAprobacionList = new List<ContratosAprobacion>();

                    ContratosAprobacionList = SqlMapper.Query<ContratosAprobacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ContratosAprobacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ContratosAprobacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ContratosAprobacion> b)
            {
                DapperPlusManager.Entity<ContratosAprobacion>().Table("ContratosAprobacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}