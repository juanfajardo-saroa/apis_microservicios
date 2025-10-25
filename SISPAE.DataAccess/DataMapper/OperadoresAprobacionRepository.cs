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
     /// Clase Abstracta para  OperadoresAprobacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class OperadoresAprobacionRepository : DataObject , IOperadoresAprobacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public OperadoresAprobacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public OperadoresAprobacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public OperadoresAprobacion GetById(OperadoresAprobacion pOperadoresAprobacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@ID_OperadorAprobacion",pOperadoresAprobacion.ID_OperadorAprobacion);                                    


    				OperadoresAprobacion o = SqlMapper.QueryFirstOrDefault<OperadoresAprobacion>(con, "API.PA_OperadoresAprobacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  OperadoresAprobacion  ->" + ex.Message);
				}
			}

			public List<OperadoresAprobacion> GetAll()
			{
				try 
                {
                        List<OperadoresAprobacion> l = SqlMapper.Query<OperadoresAprobacion>(con, "API.PA_OperadoresAprobacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  OperadoresAprobacion  ->" + ex.Message);
				}
			}

			public List<OperadoresAprobacion> GetAllFull()
			{
				try 
				{
                    List<OperadoresAprobacion> l = SqlMapper.Query<OperadoresAprobacion>(con, "API.PA_OperadoresAprobacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  OperadoresAprobacion  ->" + ex.Message);
				}
			}
			
			public List<OperadoresAprobacion> GetAllByWithRelation()
			{
				try 
                {
                    List<OperadoresAprobacion> l = SqlMapper.Query<OperadoresAprobacion>(con, "API.PA_OperadoresAprobacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  OperadoresAprobacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<OperadoresAprobacion> GetByFilter(OperadoresAprobacion pOperadoresAprobacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ID_OperadorAprobacion",(pOperadoresAprobacion.ID_OperadorAprobacion== null || pOperadoresAprobacion.ID_OperadorAprobacion==0) ? vintNUll :pOperadoresAprobacion.ID_OperadorAprobacion);
                    p.Add("@ID_Operador",(pOperadoresAprobacion.ID_Operador== null || pOperadoresAprobacion.ID_Operador==0) ? vintNUll :pOperadoresAprobacion.ID_Operador);
                    p.Add("@FechaAprobacion",(pOperadoresAprobacion.FechaAprobacion== null) ? vintNUll :pOperadoresAprobacion.FechaAprobacion);
                    p.Add("@ID_TipoEstadoOperador",(pOperadoresAprobacion.ID_TipoEstadoOperador== null || pOperadoresAprobacion.ID_TipoEstadoOperador==0) ? vintNUll :pOperadoresAprobacion.ID_TipoEstadoOperador);
                    p.Add("@Responsable",(pOperadoresAprobacion.Responsable== null) ? vintNUll :pOperadoresAprobacion.Responsable);
                    p.Add("@RolResponsable",(pOperadoresAprobacion.RolResponsable== null) ? vintNUll :pOperadoresAprobacion.RolResponsable);
                    p.Add("@Accion",(pOperadoresAprobacion.Accion== null) ? vintNUll :pOperadoresAprobacion.Accion);
                    p.Add("@Observaciones",(pOperadoresAprobacion.Observaciones== null) ? vintNUll :pOperadoresAprobacion.Observaciones);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<OperadoresAprobacion> l = SqlMapper.Query<OperadoresAprobacion>(con, "API.PA_OperadoresAprobacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  OperadoresAprobacion  ->" + ex.Message);
				}
			}

			public OperadoresAprobacion Add(OperadoresAprobacion pOperadoresAprobacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ID_OperadorAprobacion",pOperadoresAprobacion.ID_OperadorAprobacion==null ? 0 : pOperadoresAprobacion.ID_OperadorAprobacion);
p.Add("@ID_Operador",pOperadoresAprobacion.ID_Operador==null ? 0 : pOperadoresAprobacion.ID_Operador);
                    p.Add("@FechaAprobacion", pOperadoresAprobacion.FechaAprobacion);
p.Add("@ID_TipoEstadoOperador",pOperadoresAprobacion.ID_TipoEstadoOperador==null ? 0 : pOperadoresAprobacion.ID_TipoEstadoOperador);
                    p.Add("@Responsable", pOperadoresAprobacion.Responsable);
                    p.Add("@RolResponsable", pOperadoresAprobacion.RolResponsable);
                    p.Add("@Accion", pOperadoresAprobacion.Accion);
                    p.Add("@Observaciones", pOperadoresAprobacion.Observaciones);
                    p.Add("@auditoria", pOperadoresAprobacion.auditoria);

                         


                    OperadoresAprobacion o = SqlMapper.QueryFirstOrDefault<OperadoresAprobacion>(con, "API.PA_OperadoresAprobacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  OperadoresAprobacion  ->" + ex.Message);
				}
			}

			public OperadoresAprobacion  Update(OperadoresAprobacion pOperadoresAprobacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ID_OperadorAprobacion",pOperadoresAprobacion.ID_OperadorAprobacion==null ? 0 : pOperadoresAprobacion.ID_OperadorAprobacion);
p.Add("@ID_Operador",pOperadoresAprobacion.ID_Operador==null ? 0 : pOperadoresAprobacion.ID_Operador);
                    p.Add("@FechaAprobacion", pOperadoresAprobacion.FechaAprobacion);
p.Add("@ID_TipoEstadoOperador",pOperadoresAprobacion.ID_TipoEstadoOperador==null ? 0 : pOperadoresAprobacion.ID_TipoEstadoOperador);
                    p.Add("@Responsable", pOperadoresAprobacion.Responsable);
                    p.Add("@RolResponsable", pOperadoresAprobacion.RolResponsable);
                    p.Add("@Accion", pOperadoresAprobacion.Accion);
                    p.Add("@Observaciones", pOperadoresAprobacion.Observaciones);
                    p.Add("@auditoria", pOperadoresAprobacion.auditoria);

                         


                    OperadoresAprobacion o = SqlMapper.QueryFirstOrDefault<OperadoresAprobacion>(con, "API.PA_OperadoresAprobacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  OperadoresAprobacion  ->" + ex.Message);
				}
			}

			public bool Delete(OperadoresAprobacion pOperadoresAprobacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@ID_OperadorAprobacion",pOperadoresAprobacion.ID_OperadorAprobacion);
                    p.Add("@auditoria", pOperadoresAprobacion.auditoria);

                

 

					OperadoresAprobacion o = SqlMapper.QueryFirstOrDefault<OperadoresAprobacion>(con, "API.PA_OperadoresAprobacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) OperadoresAprobacion  ->" + ex.Message);
				}
			}

		



            public List<OperadoresAprobacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<OperadoresAprobacion> OperadoresAprobacionList = new List<OperadoresAprobacion>();

                    OperadoresAprobacionList = SqlMapper.Query<OperadoresAprobacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return OperadoresAprobacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) OperadoresAprobacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<OperadoresAprobacion> b)
            {
                DapperPlusManager.Entity<OperadoresAprobacion>().Table("OperadoresAprobacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}