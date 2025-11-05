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
     /// Clase Abstracta para  Pagos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PagosRepository : DataObject , IPagos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PagosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PagosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Pagos GetById(Pagos pPagos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pPagos.id);                                    


    				Pagos o = SqlMapper.QueryFirstOrDefault<Pagos>(con, "API.PA_PagosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Pagos  ->" + ex.Message);
				}
			}

			public List<Pagos> GetAll()
			{
				try 
                {
                        List<Pagos> l = SqlMapper.Query<Pagos>(con, "API.PA_PagosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Pagos  ->" + ex.Message);
				}
			}

			public List<Pagos> GetAllFull()
			{
				try 
				{
                    List<Pagos> l = SqlMapper.Query<Pagos>(con, "API.PA_PagosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Pagos  ->" + ex.Message);
				}
			}
			
			public List<Pagos> GetAllByWithRelation()
			{
				try 
                {
                    List<Pagos> l = SqlMapper.Query<Pagos>(con, "API.PA_PagosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Pagos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Pagos> GetByFilter(Pagos pPagos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pPagos.id== null || pPagos.id==0) ? vintNUll :pPagos.id);
                    p.Add("@ID_Contrato",(pPagos.ID_Contrato== null || pPagos.ID_Contrato==0) ? vintNUll :pPagos.ID_Contrato);
                    p.Add("@FechaPago",(pPagos.FechaPago== null) ? vintNUll :pPagos.FechaPago);
                    p.Add("@PATHSoportePago",(pPagos.PATHSoportePago== null) ? vintNUll :pPagos.PATHSoportePago);
                    p.Add("@ValorTotalPago",(pPagos.ValorTotalPago== null) ? vintNUll :pPagos.ValorTotalPago);
                    p.Add("@JustificacionTardio",(pPagos.JustificacionTardio== null) ? vintNUll :pPagos.JustificacionTardio);
                    p.Add("@MesPago",(pPagos.MesPago== null) ? vintNUll :pPagos.MesPago);
                    p.Add("@ID_TiposEstadosPago",(pPagos.ID_TiposEstadosPago== null || pPagos.ID_TiposEstadosPago==0) ? vintNUll :pPagos.ID_TiposEstadosPago);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Pagos> l = SqlMapper.Query<Pagos>(con, "API.PA_PagosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Pagos  ->" + ex.Message);
				}
			}

			public Pagos Add(Pagos pPagos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pPagos.id==null ? 0 : pPagos.id);
p.Add("@ID_Contrato",pPagos.ID_Contrato==null ? 0 : pPagos.ID_Contrato);
                    p.Add("@FechaPago", pPagos.FechaPago);
                    p.Add("@PATHSoportePago", pPagos.PATHSoportePago);
                    p.Add("@ValorTotalPago", pPagos.ValorTotalPago);
                    p.Add("@JustificacionTardio", pPagos.JustificacionTardio);
                    p.Add("@MesPago", pPagos.MesPago);
p.Add("@ID_TiposEstadosPago",pPagos.ID_TiposEstadosPago==null ? 0 : pPagos.ID_TiposEstadosPago);
                    p.Add("@auditoria", pPagos.auditoria);

                         


                    Pagos o = SqlMapper.QueryFirstOrDefault<Pagos>(con, "API.PA_PagosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Pagos  ->" + ex.Message);
				}
			}

			public Pagos  Update(Pagos pPagos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pPagos.id==null ? 0 : pPagos.id);
p.Add("@ID_Contrato",pPagos.ID_Contrato==null ? 0 : pPagos.ID_Contrato);
                    p.Add("@FechaPago", pPagos.FechaPago);
                    p.Add("@PATHSoportePago", pPagos.PATHSoportePago);
                    p.Add("@ValorTotalPago", pPagos.ValorTotalPago);
                    p.Add("@JustificacionTardio", pPagos.JustificacionTardio);
                    p.Add("@MesPago", pPagos.MesPago);
p.Add("@ID_TiposEstadosPago",pPagos.ID_TiposEstadosPago==null ? 0 : pPagos.ID_TiposEstadosPago);
                    p.Add("@auditoria", pPagos.auditoria);

                         


                    Pagos o = SqlMapper.QueryFirstOrDefault<Pagos>(con, "API.PA_PagosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Pagos  ->" + ex.Message);
				}
			}

			public bool Delete(Pagos pPagos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pPagos.id);
                    p.Add("@auditoria", pPagos.auditoria);

                

 

					Pagos o = SqlMapper.QueryFirstOrDefault<Pagos>(con, "API.PA_PagosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Pagos  ->" + ex.Message);
				}
			}

		



            public List<Pagos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Pagos> PagosList = new List<Pagos>();

                    PagosList = SqlMapper.Query<Pagos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PagosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Pagos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Pagos> b)
            {
                DapperPlusManager.Entity<Pagos>().Table("Pagos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}