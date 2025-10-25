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
     /// Clase Abstracta para  PlanesAlistamientos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PlanesAlistamientosRepository : DataObject , IPlanesAlistamientos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PlanesAlistamientosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PlanesAlistamientosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public PlanesAlistamientos GetById(PlanesAlistamientos pPlanesAlistamientos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@ID",pPlanesAlistamientos.ID);                                    


    				PlanesAlistamientos o = SqlMapper.QueryFirstOrDefault<PlanesAlistamientos>(con, "API.PA_PlanesAlistamientosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  PlanesAlistamientos  ->" + ex.Message);
				}
			}

			public List<PlanesAlistamientos> GetAll()
			{
				try 
                {
                        List<PlanesAlistamientos> l = SqlMapper.Query<PlanesAlistamientos>(con, "API.PA_PlanesAlistamientosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  PlanesAlistamientos  ->" + ex.Message);
				}
			}

			public List<PlanesAlistamientos> GetAllFull()
			{
				try 
				{
                    List<PlanesAlistamientos> l = SqlMapper.Query<PlanesAlistamientos>(con, "API.PA_PlanesAlistamientosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  PlanesAlistamientos  ->" + ex.Message);
				}
			}
			
			public List<PlanesAlistamientos> GetAllByWithRelation()
			{
				try 
                {
                    List<PlanesAlistamientos> l = SqlMapper.Query<PlanesAlistamientos>(con, "API.PA_PlanesAlistamientosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  PlanesAlistamientos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<PlanesAlistamientos> GetByFilter(PlanesAlistamientos pPlanesAlistamientos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ID",(pPlanesAlistamientos.ID== null || pPlanesAlistamientos.ID==0) ? vintNUll :pPlanesAlistamientos.ID);
                    p.Add("@ID_EstadoBodegas",(pPlanesAlistamientos.ID_EstadoBodegas== null || pPlanesAlistamientos.ID_EstadoBodegas==0) ? vintNUll :pPlanesAlistamientos.ID_EstadoBodegas);
                    p.Add("@ID_EstadoDocumentacion",(pPlanesAlistamientos.ID_EstadoDocumentacion== null || pPlanesAlistamientos.ID_EstadoDocumentacion==0) ? vintNUll :pPlanesAlistamientos.ID_EstadoDocumentacion);
                    p.Add("@ID_EstadoMenus",(pPlanesAlistamientos.ID_EstadoMenus== null || pPlanesAlistamientos.ID_EstadoMenus==0) ? vintNUll :pPlanesAlistamientos.ID_EstadoMenus);
                    p.Add("@ID_EstadoRutas",(pPlanesAlistamientos.ID_EstadoRutas== null || pPlanesAlistamientos.ID_EstadoRutas==0) ? vintNUll :pPlanesAlistamientos.ID_EstadoRutas);
                    p.Add("@ID_EstadoActaInicio",(pPlanesAlistamientos.ID_EstadoActaInicio== null || pPlanesAlistamientos.ID_EstadoActaInicio==0) ? vintNUll :pPlanesAlistamientos.ID_EstadoActaInicio);
                    p.Add("@ID_TipoEstadoAlistamiento",(pPlanesAlistamientos.ID_TipoEstadoAlistamiento== null || pPlanesAlistamientos.ID_TipoEstadoAlistamiento==0) ? vintNUll :pPlanesAlistamientos.ID_TipoEstadoAlistamiento);
                    p.Add("@RutasporModeloOperacion",(pPlanesAlistamientos.RutasporModeloOperacion== null) ? vintNUll :pPlanesAlistamientos.RutasporModeloOperacion);
                    p.Add("@id_contrato",(pPlanesAlistamientos.id_contrato== null || pPlanesAlistamientos.id_contrato==0) ? vintNUll :pPlanesAlistamientos.id_contrato);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<PlanesAlistamientos> l = SqlMapper.Query<PlanesAlistamientos>(con, "API.PA_PlanesAlistamientosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  PlanesAlistamientos  ->" + ex.Message);
				}
			}

			public PlanesAlistamientos Add(PlanesAlistamientos pPlanesAlistamientos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ID",pPlanesAlistamientos.ID==null ? 0 : pPlanesAlistamientos.ID);
p.Add("@ID_EstadoBodegas",pPlanesAlistamientos.ID_EstadoBodegas==null ? 0 : pPlanesAlistamientos.ID_EstadoBodegas);
p.Add("@ID_EstadoDocumentacion",pPlanesAlistamientos.ID_EstadoDocumentacion==null ? 0 : pPlanesAlistamientos.ID_EstadoDocumentacion);
p.Add("@ID_EstadoMenus",pPlanesAlistamientos.ID_EstadoMenus==null ? 0 : pPlanesAlistamientos.ID_EstadoMenus);
p.Add("@ID_EstadoRutas",pPlanesAlistamientos.ID_EstadoRutas==null ? 0 : pPlanesAlistamientos.ID_EstadoRutas);
p.Add("@ID_EstadoActaInicio",pPlanesAlistamientos.ID_EstadoActaInicio==null ? 0 : pPlanesAlistamientos.ID_EstadoActaInicio);
p.Add("@ID_TipoEstadoAlistamiento",pPlanesAlistamientos.ID_TipoEstadoAlistamiento==null ? 0 : pPlanesAlistamientos.ID_TipoEstadoAlistamiento);
                    p.Add("@RutasporModeloOperacion", pPlanesAlistamientos.RutasporModeloOperacion);
p.Add("@id_contrato",pPlanesAlistamientos.id_contrato== null ? 0: pPlanesAlistamientos.id_contrato);
                    p.Add("@auditoria", pPlanesAlistamientos.auditoria);

                         


                    PlanesAlistamientos o = SqlMapper.QueryFirstOrDefault<PlanesAlistamientos>(con, "API.PA_PlanesAlistamientosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  PlanesAlistamientos  ->" + ex.Message);
				}
			}

			public PlanesAlistamientos  Update(PlanesAlistamientos pPlanesAlistamientos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ID",pPlanesAlistamientos.ID==null ? 0 : pPlanesAlistamientos.ID);
p.Add("@ID_EstadoBodegas",pPlanesAlistamientos.ID_EstadoBodegas==null ? 0 : pPlanesAlistamientos.ID_EstadoBodegas);
p.Add("@ID_EstadoDocumentacion",pPlanesAlistamientos.ID_EstadoDocumentacion==null ? 0 : pPlanesAlistamientos.ID_EstadoDocumentacion);
p.Add("@ID_EstadoMenus",pPlanesAlistamientos.ID_EstadoMenus==null ? 0 : pPlanesAlistamientos.ID_EstadoMenus);
p.Add("@ID_EstadoRutas",pPlanesAlistamientos.ID_EstadoRutas==null ? 0 : pPlanesAlistamientos.ID_EstadoRutas);
p.Add("@ID_EstadoActaInicio",pPlanesAlistamientos.ID_EstadoActaInicio==null ? 0 : pPlanesAlistamientos.ID_EstadoActaInicio);
p.Add("@ID_TipoEstadoAlistamiento",pPlanesAlistamientos.ID_TipoEstadoAlistamiento==null ? 0 : pPlanesAlistamientos.ID_TipoEstadoAlistamiento);
                    p.Add("@RutasporModeloOperacion", pPlanesAlistamientos.RutasporModeloOperacion);
p.Add("@id_contrato",pPlanesAlistamientos.id_contrato== null ? 0: pPlanesAlistamientos.id_contrato);
                    p.Add("@auditoria", pPlanesAlistamientos.auditoria);

                         


                    PlanesAlistamientos o = SqlMapper.QueryFirstOrDefault<PlanesAlistamientos>(con, "API.PA_PlanesAlistamientosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  PlanesAlistamientos  ->" + ex.Message);
				}
			}

			public bool Delete(PlanesAlistamientos pPlanesAlistamientos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@ID",pPlanesAlistamientos.ID);
                    p.Add("@auditoria", pPlanesAlistamientos.auditoria);

                

 

					PlanesAlistamientos o = SqlMapper.QueryFirstOrDefault<PlanesAlistamientos>(con, "API.PA_PlanesAlistamientosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) PlanesAlistamientos  ->" + ex.Message);
				}
			}

		



            public List<PlanesAlistamientos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<PlanesAlistamientos> PlanesAlistamientosList = new List<PlanesAlistamientos>();

                    PlanesAlistamientosList = SqlMapper.Query<PlanesAlistamientos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PlanesAlistamientosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) PlanesAlistamientos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<PlanesAlistamientos> b)
            {
                DapperPlusManager.Entity<PlanesAlistamientos>().Table("PlanesAlistamientos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}