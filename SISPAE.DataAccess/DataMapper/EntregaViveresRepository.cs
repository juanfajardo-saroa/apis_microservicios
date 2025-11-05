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
     /// Clase Abstracta para  EntregaViveres
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class EntregaViveresRepository : DataObject , IEntregaViveres 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public EntregaViveresRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public EntregaViveresRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public EntregaViveres GetById(EntregaViveres pEntregaViveres)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pEntregaViveres.id);                                    


    				EntregaViveres o = SqlMapper.QueryFirstOrDefault<EntregaViveres>(con, "API.PA_EntregaViveresGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  EntregaViveres  ->" + ex.Message);
				}
			}

			public List<EntregaViveres> GetAll()
			{
				try 
                {
                        List<EntregaViveres> l = SqlMapper.Query<EntregaViveres>(con, "API.PA_EntregaViveresGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  EntregaViveres  ->" + ex.Message);
				}
			}

			public List<EntregaViveres> GetAllFull()
			{
				try 
				{
                    List<EntregaViveres> l = SqlMapper.Query<EntregaViveres>(con, "API.PA_EntregaViveresGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  EntregaViveres  ->" + ex.Message);
				}
			}
			
			public List<EntregaViveres> GetAllByWithRelation()
			{
				try 
                {
                    List<EntregaViveres> l = SqlMapper.Query<EntregaViveres>(con, "API.PA_EntregaViveresGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  EntregaViveres  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<EntregaViveres> GetByFilter(EntregaViveres pEntregaViveres, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pEntregaViveres.id== null || pEntregaViveres.id==0) ? vintNUll :pEntregaViveres.id);
                    p.Add("@ID_AgrupacionMensual",(pEntregaViveres.ID_AgrupacionMensual== null || pEntregaViveres.ID_AgrupacionMensual==0) ? vintNUll :pEntregaViveres.ID_AgrupacionMensual);
                    p.Add("@ID_Producto",(pEntregaViveres.ID_Producto== null || pEntregaViveres.ID_Producto==0) ? vintNUll :pEntregaViveres.ID_Producto);
                    p.Add("@ID_EstadoEntrega",(pEntregaViveres.ID_EstadoEntrega== null || pEntregaViveres.ID_EstadoEntrega==0) ? vintNUll :pEntregaViveres.ID_EstadoEntrega);
                    p.Add("@ID_TipoTiempoEntrega",(pEntregaViveres.ID_TipoTiempoEntrega== null || pEntregaViveres.ID_TipoTiempoEntrega==0) ? vintNUll :pEntregaViveres.ID_TipoTiempoEntrega);
                    p.Add("@ID_AlimentoPlan",(pEntregaViveres.ID_AlimentoPlan== null || pEntregaViveres.ID_AlimentoPlan==0) ? vintNUll :pEntregaViveres.ID_AlimentoPlan);
                    p.Add("@CantidadRecibir",(pEntregaViveres.CantidadRecibir== null) ? vintNUll :pEntregaViveres.CantidadRecibir);
                    p.Add("@FechaEntrega",(pEntregaViveres.FechaEntrega== null) ? vintNUll :pEntregaViveres.FechaEntrega);
                    p.Add("@AlimentoPlanld",(pEntregaViveres.AlimentoPlanld== null) ? vintNUll :pEntregaViveres.AlimentoPlanld);
                    p.Add("@ID_FaltanteIntercambio",(pEntregaViveres.ID_FaltanteIntercambio== null || pEntregaViveres.ID_FaltanteIntercambio==0) ? vintNUll :pEntregaViveres.ID_FaltanteIntercambio);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<EntregaViveres> l = SqlMapper.Query<EntregaViveres>(con, "API.PA_EntregaViveresGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  EntregaViveres  ->" + ex.Message);
				}
			}

			public EntregaViveres Add(EntregaViveres pEntregaViveres)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pEntregaViveres.id==null ? 0 : pEntregaViveres.id);
p.Add("@ID_AgrupacionMensual",pEntregaViveres.ID_AgrupacionMensual==null ? 0 : pEntregaViveres.ID_AgrupacionMensual);
p.Add("@ID_Producto",pEntregaViveres.ID_Producto==null ? 0 : pEntregaViveres.ID_Producto);
p.Add("@ID_EstadoEntrega",pEntregaViveres.ID_EstadoEntrega==null ? 0 : pEntregaViveres.ID_EstadoEntrega);
p.Add("@ID_TipoTiempoEntrega",pEntregaViveres.ID_TipoTiempoEntrega==null ? 0 : pEntregaViveres.ID_TipoTiempoEntrega);
p.Add("@ID_AlimentoPlan",pEntregaViveres.ID_AlimentoPlan==null ? 0 : pEntregaViveres.ID_AlimentoPlan);
p.Add("@CantidadRecibir",pEntregaViveres.CantidadRecibir==null ? 0 : pEntregaViveres.CantidadRecibir);
                    p.Add("@FechaEntrega", pEntregaViveres.FechaEntrega);
p.Add("@AlimentoPlanld",pEntregaViveres.AlimentoPlanld==null ? 0 : pEntregaViveres.AlimentoPlanld);
p.Add("@ID_FaltanteIntercambio",pEntregaViveres.ID_FaltanteIntercambio==null ? 0 : pEntregaViveres.ID_FaltanteIntercambio);
                    p.Add("@auditoria", pEntregaViveres.auditoria);

                         


                    EntregaViveres o = SqlMapper.QueryFirstOrDefault<EntregaViveres>(con, "API.PA_EntregaViveresAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  EntregaViveres  ->" + ex.Message);
				}
			}

			public EntregaViveres  Update(EntregaViveres pEntregaViveres)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pEntregaViveres.id==null ? 0 : pEntregaViveres.id);
p.Add("@ID_AgrupacionMensual",pEntregaViveres.ID_AgrupacionMensual==null ? 0 : pEntregaViveres.ID_AgrupacionMensual);
p.Add("@ID_Producto",pEntregaViveres.ID_Producto==null ? 0 : pEntregaViveres.ID_Producto);
p.Add("@ID_EstadoEntrega",pEntregaViveres.ID_EstadoEntrega==null ? 0 : pEntregaViveres.ID_EstadoEntrega);
p.Add("@ID_TipoTiempoEntrega",pEntregaViveres.ID_TipoTiempoEntrega==null ? 0 : pEntregaViveres.ID_TipoTiempoEntrega);
p.Add("@ID_AlimentoPlan",pEntregaViveres.ID_AlimentoPlan==null ? 0 : pEntregaViveres.ID_AlimentoPlan);
p.Add("@CantidadRecibir",pEntregaViveres.CantidadRecibir==null ? 0 : pEntregaViveres.CantidadRecibir);
                    p.Add("@FechaEntrega", pEntregaViveres.FechaEntrega);
p.Add("@AlimentoPlanld",pEntregaViveres.AlimentoPlanld==null ? 0 : pEntregaViveres.AlimentoPlanld);
p.Add("@ID_FaltanteIntercambio",pEntregaViveres.ID_FaltanteIntercambio==null ? 0 : pEntregaViveres.ID_FaltanteIntercambio);
                    p.Add("@auditoria", pEntregaViveres.auditoria);

                         


                    EntregaViveres o = SqlMapper.QueryFirstOrDefault<EntregaViveres>(con, "API.PA_EntregaViveresUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  EntregaViveres  ->" + ex.Message);
				}
			}

			public bool Delete(EntregaViveres pEntregaViveres)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pEntregaViveres.id);
                    p.Add("@auditoria", pEntregaViveres.auditoria);

                

 

					EntregaViveres o = SqlMapper.QueryFirstOrDefault<EntregaViveres>(con, "API.PA_EntregaViveresDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) EntregaViveres  ->" + ex.Message);
				}
			}

		



            public List<EntregaViveres> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<EntregaViveres> EntregaViveresList = new List<EntregaViveres>();

                    EntregaViveresList = SqlMapper.Query<EntregaViveres>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return EntregaViveresList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) EntregaViveres  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<EntregaViveres> b)
            {
                DapperPlusManager.Entity<EntregaViveres>().Table("EntregaViveres");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}