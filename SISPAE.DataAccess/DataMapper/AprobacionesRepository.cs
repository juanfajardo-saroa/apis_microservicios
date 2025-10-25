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
     /// Clase Abstracta para  Aprobaciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AprobacionesRepository : DataObject , IAprobaciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AprobacionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AprobacionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Aprobaciones GetById(Aprobaciones pAprobaciones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAprobaciones.id);                                    


    				Aprobaciones o = SqlMapper.QueryFirstOrDefault<Aprobaciones>(con, "API.PA_AprobacionesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Aprobaciones  ->" + ex.Message);
				}
			}

			public List<Aprobaciones> GetAll()
			{
				try 
                {
                        List<Aprobaciones> l = SqlMapper.Query<Aprobaciones>(con, "API.PA_AprobacionesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Aprobaciones  ->" + ex.Message);
				}
			}

			public List<Aprobaciones> GetAllFull()
			{
				try 
				{
                    List<Aprobaciones> l = SqlMapper.Query<Aprobaciones>(con, "API.PA_AprobacionesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Aprobaciones  ->" + ex.Message);
				}
			}
			
			public List<Aprobaciones> GetAllByWithRelation()
			{
				try 
                {
                    List<Aprobaciones> l = SqlMapper.Query<Aprobaciones>(con, "API.PA_AprobacionesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Aprobaciones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Aprobaciones> GetByFilter(Aprobaciones pAprobaciones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAprobaciones.id== null || pAprobaciones.id==0) ? vintNUll :pAprobaciones.id);
                    p.Add("@ID_ETC",(pAprobaciones.ID_ETC== null || pAprobaciones.ID_ETC==0) ? vintNUll :pAprobaciones.ID_ETC);
                    p.Add("@ID_User",(pAprobaciones.ID_User== null) ? vintNUll :pAprobaciones.ID_User);
                    p.Add("@ID_AccionAprobacion",(pAprobaciones.ID_AccionAprobacion== null || pAprobaciones.ID_AccionAprobacion==0) ? vintNUll :pAprobaciones.ID_AccionAprobacion);
                    p.Add("@Id_Secciones",(pAprobaciones.Id_Secciones== null || pAprobaciones.Id_Secciones==0) ? vintNUll :pAprobaciones.Id_Secciones);
                    p.Add("@DocumentoParaAprobar",(pAprobaciones.DocumentoParaAprobar== null) ? vintNUll :pAprobaciones.DocumentoParaAprobar);
                    p.Add("@FechaAprobacion",(pAprobaciones.FechaAprobacion== null) ? vintNUll :pAprobaciones.FechaAprobacion);
                    p.Add("@Fecha",(pAprobaciones.Fecha== null) ? vintNUll :pAprobaciones.Fecha);
                    p.Add("@Accion",(pAprobaciones.Accion== null) ? vintNUll :pAprobaciones.Accion);
                    p.Add("@Observaciones",(pAprobaciones.Observaciones== null) ? vintNUll :pAprobaciones.Observaciones);
                    p.Add("@Id_Ubicacion",(pAprobaciones.Id_Ubicacion== null || pAprobaciones.Id_Ubicacion==0) ? vintNUll :pAprobaciones.Id_Ubicacion);
                    p.Add("@UbicacionOrigen",(pAprobaciones.UbicacionOrigen== null) ? vintNUll :pAprobaciones.UbicacionOrigen);
                    p.Add("@plazoPorAprobar",(pAprobaciones.plazoPorAprobar== null) ? vintNUll :pAprobaciones.plazoPorAprobar);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Aprobaciones> l = SqlMapper.Query<Aprobaciones>(con, "API.PA_AprobacionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Aprobaciones  ->" + ex.Message);
				}
			}

			public Aprobaciones Add(Aprobaciones pAprobaciones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAprobaciones.id==null ? 0 : pAprobaciones.id);
p.Add("@ID_ETC",pAprobaciones.ID_ETC==null ? 0 : pAprobaciones.ID_ETC);
                    p.Add("@ID_User", pAprobaciones.ID_User);
p.Add("@ID_AccionAprobacion",pAprobaciones.ID_AccionAprobacion==null ? 0 : pAprobaciones.ID_AccionAprobacion);
p.Add("@Id_Secciones",pAprobaciones.Id_Secciones==null ? 0 : pAprobaciones.Id_Secciones);
                    p.Add("@DocumentoParaAprobar", pAprobaciones.DocumentoParaAprobar);
                    p.Add("@FechaAprobacion", pAprobaciones.FechaAprobacion);
                    p.Add("@Fecha", pAprobaciones.Fecha);
                    p.Add("@Accion", pAprobaciones.Accion);
                    p.Add("@Observaciones", pAprobaciones.Observaciones);
p.Add("@Id_Ubicacion",pAprobaciones.Id_Ubicacion==null ? 0 : pAprobaciones.Id_Ubicacion);
                    p.Add("@UbicacionOrigen", pAprobaciones.UbicacionOrigen);
                    p.Add("@plazoPorAprobar", pAprobaciones.plazoPorAprobar);
                    p.Add("@auditoria", pAprobaciones.auditoria);

                         


                    Aprobaciones o = SqlMapper.QueryFirstOrDefault<Aprobaciones>(con, "API.PA_AprobacionesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Aprobaciones  ->" + ex.Message);
				}
			}

			public Aprobaciones  Update(Aprobaciones pAprobaciones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAprobaciones.id==null ? 0 : pAprobaciones.id);
p.Add("@ID_ETC",pAprobaciones.ID_ETC==null ? 0 : pAprobaciones.ID_ETC);
                    p.Add("@ID_User", pAprobaciones.ID_User);
p.Add("@ID_AccionAprobacion",pAprobaciones.ID_AccionAprobacion==null ? 0 : pAprobaciones.ID_AccionAprobacion);
p.Add("@Id_Secciones",pAprobaciones.Id_Secciones==null ? 0 : pAprobaciones.Id_Secciones);
                    p.Add("@DocumentoParaAprobar", pAprobaciones.DocumentoParaAprobar);
                    p.Add("@FechaAprobacion", pAprobaciones.FechaAprobacion);
                    p.Add("@Fecha", pAprobaciones.Fecha);
                    p.Add("@Accion", pAprobaciones.Accion);
                    p.Add("@Observaciones", pAprobaciones.Observaciones);
p.Add("@Id_Ubicacion",pAprobaciones.Id_Ubicacion==null ? 0 : pAprobaciones.Id_Ubicacion);
                    p.Add("@UbicacionOrigen", pAprobaciones.UbicacionOrigen);
                    p.Add("@plazoPorAprobar", pAprobaciones.plazoPorAprobar);
                    p.Add("@auditoria", pAprobaciones.auditoria);

                         


                    Aprobaciones o = SqlMapper.QueryFirstOrDefault<Aprobaciones>(con, "API.PA_AprobacionesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Aprobaciones  ->" + ex.Message);
				}
			}

			public bool Delete(Aprobaciones pAprobaciones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAprobaciones.id);
                    p.Add("@auditoria", pAprobaciones.auditoria);

                

 

					Aprobaciones o = SqlMapper.QueryFirstOrDefault<Aprobaciones>(con, "API.PA_AprobacionesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Aprobaciones  ->" + ex.Message);
				}
			}

		



            public List<Aprobaciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Aprobaciones> AprobacionesList = new List<Aprobaciones>();

                    AprobacionesList = SqlMapper.Query<Aprobaciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AprobacionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Aprobaciones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Aprobaciones> b)
            {
                DapperPlusManager.Entity<Aprobaciones>().Table("Aprobaciones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}