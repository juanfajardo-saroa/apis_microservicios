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
     /// Clase Abstracta para  FaltantesIntercambios
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class FaltantesIntercambiosRepository : DataObject , IFaltantesIntercambios 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public FaltantesIntercambiosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public FaltantesIntercambiosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public FaltantesIntercambios GetById(FaltantesIntercambios pFaltantesIntercambios)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pFaltantesIntercambios.id);                                    


    				FaltantesIntercambios o = SqlMapper.QueryFirstOrDefault<FaltantesIntercambios>(con, "API.PA_FaltantesIntercambiosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  FaltantesIntercambios  ->" + ex.Message);
				}
			}

			public List<FaltantesIntercambios> GetAll()
			{
				try 
                {
                        List<FaltantesIntercambios> l = SqlMapper.Query<FaltantesIntercambios>(con, "API.PA_FaltantesIntercambiosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  FaltantesIntercambios  ->" + ex.Message);
				}
			}

			public List<FaltantesIntercambios> GetAllFull()
			{
				try 
				{
                    List<FaltantesIntercambios> l = SqlMapper.Query<FaltantesIntercambios>(con, "API.PA_FaltantesIntercambiosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  FaltantesIntercambios  ->" + ex.Message);
				}
			}
			
			public List<FaltantesIntercambios> GetAllByWithRelation()
			{
				try 
                {
                    List<FaltantesIntercambios> l = SqlMapper.Query<FaltantesIntercambios>(con, "API.PA_FaltantesIntercambiosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  FaltantesIntercambios  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<FaltantesIntercambios> GetByFilter(FaltantesIntercambios pFaltantesIntercambios, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pFaltantesIntercambios.id== null || pFaltantesIntercambios.id==0) ? vintNUll :pFaltantesIntercambios.id);
                    p.Add("@ID_ProductoIntercambio",(pFaltantesIntercambios.ID_ProductoIntercambio== null || pFaltantesIntercambios.ID_ProductoIntercambio==0) ? vintNUll :pFaltantesIntercambios.ID_ProductoIntercambio);
                    p.Add("@ID_EntregaViveres",(pFaltantesIntercambios.ID_EntregaViveres== null || pFaltantesIntercambios.ID_EntregaViveres==0) ? vintNUll :pFaltantesIntercambios.ID_EntregaViveres);
                    p.Add("@CantidadRecibida",(pFaltantesIntercambios.CantidadRecibida== null) ? vintNUll :pFaltantesIntercambios.CantidadRecibida);
                    p.Add("@CantidadNoCoincidePor",(pFaltantesIntercambios.CantidadNoCoincidePor== null) ? vintNUll :pFaltantesIntercambios.CantidadNoCoincidePor);
                    p.Add("@CantidadFaltante",(pFaltantesIntercambios.CantidadFaltante== null) ? vintNUll :pFaltantesIntercambios.CantidadFaltante);
                    p.Add("@CantidadDevuelta",(pFaltantesIntercambios.CantidadDevuelta== null) ? vintNUll :pFaltantesIntercambios.CantidadDevuelta);
                    p.Add("@FechaEntregaFaltante",(pFaltantesIntercambios.FechaEntregaFaltante== null) ? vintNUll :pFaltantesIntercambios.FechaEntregaFaltante);
                    p.Add("@BuenEstado",(pFaltantesIntercambios.BuenEstado== null) ? vintNUll :pFaltantesIntercambios.BuenEstado);
                    p.Add("@BuenEmpacado",(pFaltantesIntercambios.BuenEmpacado== null) ? vintNUll :pFaltantesIntercambios.BuenEmpacado);
                    p.Add("@SinContaminacion",(pFaltantesIntercambios.SinContaminacion== null) ? vintNUll :pFaltantesIntercambios.SinContaminacion);
                    p.Add("@SinExpirar",(pFaltantesIntercambios.SinExpirar== null) ? vintNUll :pFaltantesIntercambios.SinExpirar);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<FaltantesIntercambios> l = SqlMapper.Query<FaltantesIntercambios>(con, "API.PA_FaltantesIntercambiosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  FaltantesIntercambios  ->" + ex.Message);
				}
			}

			public FaltantesIntercambios Add(FaltantesIntercambios pFaltantesIntercambios)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pFaltantesIntercambios.id==null ? 0 : pFaltantesIntercambios.id);
p.Add("@ID_ProductoIntercambio",pFaltantesIntercambios.ID_ProductoIntercambio==null ? 0 : pFaltantesIntercambios.ID_ProductoIntercambio);
p.Add("@ID_EntregaViveres",pFaltantesIntercambios.ID_EntregaViveres==null ? 0 : pFaltantesIntercambios.ID_EntregaViveres);
                    p.Add("@CantidadRecibida", pFaltantesIntercambios.CantidadRecibida);
                    p.Add("@CantidadNoCoincidePor", pFaltantesIntercambios.CantidadNoCoincidePor);
                    p.Add("@CantidadFaltante", pFaltantesIntercambios.CantidadFaltante);
                    p.Add("@CantidadDevuelta", pFaltantesIntercambios.CantidadDevuelta);
                    p.Add("@FechaEntregaFaltante", pFaltantesIntercambios.FechaEntregaFaltante);
                    p.Add("@BuenEstado", pFaltantesIntercambios.BuenEstado);
                    p.Add("@BuenEmpacado", pFaltantesIntercambios.BuenEmpacado);
                    p.Add("@SinContaminacion", pFaltantesIntercambios.SinContaminacion);
                    p.Add("@SinExpirar", pFaltantesIntercambios.SinExpirar);
                    p.Add("@auditoria", pFaltantesIntercambios.auditoria);

                         


                    FaltantesIntercambios o = SqlMapper.QueryFirstOrDefault<FaltantesIntercambios>(con, "API.PA_FaltantesIntercambiosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  FaltantesIntercambios  ->" + ex.Message);
				}
			}

			public FaltantesIntercambios  Update(FaltantesIntercambios pFaltantesIntercambios)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pFaltantesIntercambios.id==null ? 0 : pFaltantesIntercambios.id);
p.Add("@ID_ProductoIntercambio",pFaltantesIntercambios.ID_ProductoIntercambio==null ? 0 : pFaltantesIntercambios.ID_ProductoIntercambio);
p.Add("@ID_EntregaViveres",pFaltantesIntercambios.ID_EntregaViveres==null ? 0 : pFaltantesIntercambios.ID_EntregaViveres);
                    p.Add("@CantidadRecibida", pFaltantesIntercambios.CantidadRecibida);
                    p.Add("@CantidadNoCoincidePor", pFaltantesIntercambios.CantidadNoCoincidePor);
                    p.Add("@CantidadFaltante", pFaltantesIntercambios.CantidadFaltante);
                    p.Add("@CantidadDevuelta", pFaltantesIntercambios.CantidadDevuelta);
                    p.Add("@FechaEntregaFaltante", pFaltantesIntercambios.FechaEntregaFaltante);
                    p.Add("@BuenEstado", pFaltantesIntercambios.BuenEstado);
                    p.Add("@BuenEmpacado", pFaltantesIntercambios.BuenEmpacado);
                    p.Add("@SinContaminacion", pFaltantesIntercambios.SinContaminacion);
                    p.Add("@SinExpirar", pFaltantesIntercambios.SinExpirar);
                    p.Add("@auditoria", pFaltantesIntercambios.auditoria);

                         


                    FaltantesIntercambios o = SqlMapper.QueryFirstOrDefault<FaltantesIntercambios>(con, "API.PA_FaltantesIntercambiosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  FaltantesIntercambios  ->" + ex.Message);
				}
			}

			public bool Delete(FaltantesIntercambios pFaltantesIntercambios)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pFaltantesIntercambios.id);
                    p.Add("@auditoria", pFaltantesIntercambios.auditoria);

                

 

					FaltantesIntercambios o = SqlMapper.QueryFirstOrDefault<FaltantesIntercambios>(con, "API.PA_FaltantesIntercambiosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) FaltantesIntercambios  ->" + ex.Message);
				}
			}

		



            public List<FaltantesIntercambios> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<FaltantesIntercambios> FaltantesIntercambiosList = new List<FaltantesIntercambios>();

                    FaltantesIntercambiosList = SqlMapper.Query<FaltantesIntercambios>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return FaltantesIntercambiosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) FaltantesIntercambios  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<FaltantesIntercambios> b)
            {
                DapperPlusManager.Entity<FaltantesIntercambios>().Table("FaltantesIntercambios");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}