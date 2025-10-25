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
     /// Clase Abstracta para  Contratos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ContratosRepository : DataObject , IContratos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ContratosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ContratosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Contratos GetById(Contratos pContratos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pContratos.id);                                    


    				Contratos o = SqlMapper.QueryFirstOrDefault<Contratos>(con, "API.PA_ContratosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Contratos  ->" + ex.Message);
				}
			}

			public List<Contratos> GetAll()
			{
				try 
                {
                        List<Contratos> l = SqlMapper.Query<Contratos>(con, "API.PA_ContratosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Contratos  ->" + ex.Message);
				}
			}

			public List<Contratos> GetAllFull()
			{
				try 
				{
                    List<Contratos> l = SqlMapper.Query<Contratos>(con, "API.PA_ContratosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Contratos  ->" + ex.Message);
				}
			}
			
			public List<Contratos> GetAllByWithRelation()
			{
				try 
                {
                    List<Contratos> l = SqlMapper.Query<Contratos>(con, "API.PA_ContratosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Contratos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Contratos> GetByFilter(Contratos pContratos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pContratos.id== null || pContratos.id==0) ? vintNUll :pContratos.id);
                    p.Add("@ID_TipoContratoCHIP",(pContratos.ID_TipoContratoCHIP== null || pContratos.ID_TipoContratoCHIP==0) ? vintNUll :pContratos.ID_TipoContratoCHIP);
                    p.Add("@ID_TipoConceptoGasto",(pContratos.ID_TipoConceptoGasto== null || pContratos.ID_TipoConceptoGasto==0) ? vintNUll :pContratos.ID_TipoConceptoGasto);
                    p.Add("@ID_ETC",(pContratos.ID_ETC== null || pContratos.ID_ETC==0) ? vintNUll :pContratos.ID_ETC);
                    p.Add("@ID_ET",(pContratos.ID_ET== null || pContratos.ID_ET==0) ? vintNUll :pContratos.ID_ET);
                    p.Add("@ID_MinutaPatronAlimento",(pContratos.ID_MinutaPatronAlimento== null || pContratos.ID_MinutaPatronAlimento==0) ? vintNUll :pContratos.ID_MinutaPatronAlimento);
                    p.Add("@ID_Operador",(pContratos.ID_Operador== null || pContratos.ID_Operador==0) ? vintNUll :pContratos.ID_Operador);
                    p.Add("@ID_TipoCategoriaContrato",(pContratos.ID_TipoCategoriaContrato== null || pContratos.ID_TipoCategoriaContrato==0) ? vintNUll :pContratos.ID_TipoCategoriaContrato);
                    p.Add("@ID_EstadoContrato",(pContratos.ID_EstadoContrato== null || pContratos.ID_EstadoContrato==0) ? vintNUll :pContratos.ID_EstadoContrato);
                    p.Add("@ID_UTConsorcio",(pContratos.ID_UTConsorcio== null || pContratos.ID_UTConsorcio==0) ? vintNUll :pContratos.ID_UTConsorcio);
                    p.Add("@ID_PlanAlistamiento",(pContratos.ID_PlanAlistamiento== null || pContratos.ID_PlanAlistamiento==0) ? vintNUll :pContratos.ID_PlanAlistamiento);
                    p.Add("@ID_Vigencia",(pContratos.ID_Vigencia== null || pContratos.ID_Vigencia==0) ? vintNUll :pContratos.ID_Vigencia);
                    p.Add("@NumeroContrato",(pContratos.NumeroContrato== null) ? vintNUll :pContratos.NumeroContrato);
                    p.Add("@ObjetoContrato",(pContratos.ObjetoContrato== null) ? vintNUll :pContratos.ObjetoContrato);
                    p.Add("@ConAnticipo",(pContratos.ConAnticipo== null) ? vintNUll :pContratos.ConAnticipo);
                    p.Add("@FechalnicioContrato",(pContratos.FechalnicioContrato== null) ? vintNUll :pContratos.FechalnicioContrato);
                    p.Add("@FechaFinalContrato",(pContratos.FechaFinalContrato== null) ? vintNUll :pContratos.FechaFinalContrato);
                    p.Add("@ValorTotalContrato",(pContratos.ValorTotalContrato== null) ? vintNUll :pContratos.ValorTotalContrato);
                    p.Add("@TipoContratoId",(pContratos.TipoContratoId== null) ? vintNUll :pContratos.TipoContratoId);
                    p.Add("@SubTipoContratoId",(pContratos.SubTipoContratoId== null) ? vintNUll :pContratos.SubTipoContratoId);
                    p.Add("@SuministroDesentralizadoId",(pContratos.SuministroDesentralizadoId== null) ? vintNUll :pContratos.SuministroDesentralizadoId);
                    p.Add("@ID_TipoModeloOperacion",(pContratos.ID_TipoModeloOperacion== null || pContratos.ID_TipoModeloOperacion==0) ? vintNUll :pContratos.ID_TipoModeloOperacion);
                    p.Add("@ManejaPAEC",(pContratos.ManejaPAEC== null) ? vintNUll :pContratos.ManejaPAEC);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Contratos> l = SqlMapper.Query<Contratos>(con, "API.PA_ContratosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Contratos  ->" + ex.Message);
				}
			}

			public Contratos Add(Contratos pContratos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pContratos.id==null ? 0 : pContratos.id);
p.Add("@ID_TipoContratoCHIP",pContratos.ID_TipoContratoCHIP==null ? 0 : pContratos.ID_TipoContratoCHIP);
p.Add("@ID_TipoConceptoGasto",pContratos.ID_TipoConceptoGasto==null ? 0 : pContratos.ID_TipoConceptoGasto);
p.Add("@ID_ETC",pContratos.ID_ETC==null ? 0 : pContratos.ID_ETC);
p.Add("@ID_ET",pContratos.ID_ET==null ? 0 : pContratos.ID_ET);
p.Add("@ID_MinutaPatronAlimento",pContratos.ID_MinutaPatronAlimento==null ? 0 : pContratos.ID_MinutaPatronAlimento);
p.Add("@ID_Operador",pContratos.ID_Operador==null ? 0 : pContratos.ID_Operador);
p.Add("@ID_TipoCategoriaContrato",pContratos.ID_TipoCategoriaContrato==null ? 0 : pContratos.ID_TipoCategoriaContrato);
p.Add("@ID_EstadoContrato",pContratos.ID_EstadoContrato==null ? 0 : pContratos.ID_EstadoContrato);
p.Add("@ID_UTConsorcio",pContratos.ID_UTConsorcio==null ? 0 : pContratos.ID_UTConsorcio);
p.Add("@ID_PlanAlistamiento",pContratos.ID_PlanAlistamiento==null ? 0 : pContratos.ID_PlanAlistamiento);
p.Add("@ID_Vigencia",pContratos.ID_Vigencia==null ? 0 : pContratos.ID_Vigencia);
                    p.Add("@NumeroContrato", pContratos.NumeroContrato);
                    p.Add("@ObjetoContrato", pContratos.ObjetoContrato);
                    p.Add("@ConAnticipo", pContratos.ConAnticipo);
                    p.Add("@FechalnicioContrato", pContratos.FechalnicioContrato);
                    p.Add("@FechaFinalContrato", pContratos.FechaFinalContrato);
                    p.Add("@ValorTotalContrato", pContratos.ValorTotalContrato);
p.Add("@TipoContratoId",pContratos.TipoContratoId==null ? 0 : pContratos.TipoContratoId);
p.Add("@SubTipoContratoId",pContratos.SubTipoContratoId==null ? 0 : pContratos.SubTipoContratoId);
p.Add("@SuministroDesentralizadoId",pContratos.SuministroDesentralizadoId==null ? 0 : pContratos.SuministroDesentralizadoId);
p.Add("@ID_TipoModeloOperacion",pContratos.ID_TipoModeloOperacion==null ? 0 : pContratos.ID_TipoModeloOperacion);
                    p.Add("@ManejaPAEC", pContratos.ManejaPAEC);
                    p.Add("@auditoria", pContratos.auditoria);

                         


                    Contratos o = SqlMapper.QueryFirstOrDefault<Contratos>(con, "API.PA_ContratosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Contratos  ->" + ex.Message);
				}
			}

			public Contratos  Update(Contratos pContratos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pContratos.id==null ? 0 : pContratos.id);
p.Add("@ID_TipoContratoCHIP",pContratos.ID_TipoContratoCHIP==null ? 0 : pContratos.ID_TipoContratoCHIP);
p.Add("@ID_TipoConceptoGasto",pContratos.ID_TipoConceptoGasto==null ? 0 : pContratos.ID_TipoConceptoGasto);
p.Add("@ID_ETC",pContratos.ID_ETC==null ? 0 : pContratos.ID_ETC);
p.Add("@ID_ET",pContratos.ID_ET==null ? 0 : pContratos.ID_ET);
p.Add("@ID_MinutaPatronAlimento",pContratos.ID_MinutaPatronAlimento==null ? 0 : pContratos.ID_MinutaPatronAlimento);
p.Add("@ID_Operador",pContratos.ID_Operador==null ? 0 : pContratos.ID_Operador);
p.Add("@ID_TipoCategoriaContrato",pContratos.ID_TipoCategoriaContrato==null ? 0 : pContratos.ID_TipoCategoriaContrato);
p.Add("@ID_EstadoContrato",pContratos.ID_EstadoContrato==null ? 0 : pContratos.ID_EstadoContrato);
p.Add("@ID_UTConsorcio",pContratos.ID_UTConsorcio==null ? 0 : pContratos.ID_UTConsorcio);
p.Add("@ID_PlanAlistamiento",pContratos.ID_PlanAlistamiento==null ? 0 : pContratos.ID_PlanAlistamiento);
p.Add("@ID_Vigencia",pContratos.ID_Vigencia==null ? 0 : pContratos.ID_Vigencia);
                    p.Add("@NumeroContrato", pContratos.NumeroContrato);
                    p.Add("@ObjetoContrato", pContratos.ObjetoContrato);
                    p.Add("@ConAnticipo", pContratos.ConAnticipo);
                    p.Add("@FechalnicioContrato", pContratos.FechalnicioContrato);
                    p.Add("@FechaFinalContrato", pContratos.FechaFinalContrato);
                    p.Add("@ValorTotalContrato", pContratos.ValorTotalContrato);
p.Add("@TipoContratoId",pContratos.TipoContratoId==null ? 0 : pContratos.TipoContratoId);
p.Add("@SubTipoContratoId",pContratos.SubTipoContratoId==null ? 0 : pContratos.SubTipoContratoId);
p.Add("@SuministroDesentralizadoId",pContratos.SuministroDesentralizadoId==null ? 0 : pContratos.SuministroDesentralizadoId);
p.Add("@ID_TipoModeloOperacion",pContratos.ID_TipoModeloOperacion==null ? 0 : pContratos.ID_TipoModeloOperacion);
                    p.Add("@ManejaPAEC", pContratos.ManejaPAEC);
                    p.Add("@auditoria", pContratos.auditoria);

                         


                    Contratos o = SqlMapper.QueryFirstOrDefault<Contratos>(con, "API.PA_ContratosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Contratos  ->" + ex.Message);
				}
			}

			public bool Delete(Contratos pContratos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pContratos.id);
                    p.Add("@auditoria", pContratos.auditoria);

                

 

					Contratos o = SqlMapper.QueryFirstOrDefault<Contratos>(con, "API.PA_ContratosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Contratos  ->" + ex.Message);
				}
			}

		



            public List<Contratos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Contratos> ContratosList = new List<Contratos>();

                    ContratosList = SqlMapper.Query<Contratos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ContratosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Contratos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Contratos> b)
            {
                DapperPlusManager.Entity<Contratos>().Table("Contratos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}