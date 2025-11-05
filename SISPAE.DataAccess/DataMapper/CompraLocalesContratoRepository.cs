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
     /// Clase Abstracta para  CompraLocalesContrato
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CompraLocalesContratoRepository : DataObject , ICompraLocalesContrato 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CompraLocalesContratoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CompraLocalesContratoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CompraLocalesContrato GetById(CompraLocalesContrato pCompraLocalesContrato)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCompraLocalesContrato.id);                                    


    				CompraLocalesContrato o = SqlMapper.QueryFirstOrDefault<CompraLocalesContrato>(con, "API.PA_CompraLocalesContratoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CompraLocalesContrato  ->" + ex.Message);
				}
			}

			public List<CompraLocalesContrato> GetAll()
			{
				try 
                {
                        List<CompraLocalesContrato> l = SqlMapper.Query<CompraLocalesContrato>(con, "API.PA_CompraLocalesContratoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CompraLocalesContrato  ->" + ex.Message);
				}
			}

			public List<CompraLocalesContrato> GetAllFull()
			{
				try 
				{
                    List<CompraLocalesContrato> l = SqlMapper.Query<CompraLocalesContrato>(con, "API.PA_CompraLocalesContratoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CompraLocalesContrato  ->" + ex.Message);
				}
			}
			
			public List<CompraLocalesContrato> GetAllByWithRelation()
			{
				try 
                {
                    List<CompraLocalesContrato> l = SqlMapper.Query<CompraLocalesContrato>(con, "API.PA_CompraLocalesContratoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CompraLocalesContrato  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CompraLocalesContrato> GetByFilter(CompraLocalesContrato pCompraLocalesContrato, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCompraLocalesContrato.id== null || pCompraLocalesContrato.id==0) ? vintNUll :pCompraLocalesContrato.id);
                    p.Add("@ID_contrato",(pCompraLocalesContrato.ID_contrato== null || pCompraLocalesContrato.ID_contrato==0) ? vintNUll :pCompraLocalesContrato.ID_contrato);
                    p.Add("@ID_TipoReglaCompraLocal",(pCompraLocalesContrato.ID_TipoReglaCompraLocal== null || pCompraLocalesContrato.ID_TipoReglaCompraLocal==0) ? vintNUll :pCompraLocalesContrato.ID_TipoReglaCompraLocal);
                    p.Add("@ID_TipoCriterioEvaluacion",(pCompraLocalesContrato.ID_TipoCriterioEvaluacion== null || pCompraLocalesContrato.ID_TipoCriterioEvaluacion==0) ? vintNUll :pCompraLocalesContrato.ID_TipoCriterioEvaluacion);
                    p.Add("@ID_TipoPeriodicidad",(pCompraLocalesContrato.ID_TipoPeriodicidad== null || pCompraLocalesContrato.ID_TipoPeriodicidad==0) ? vintNUll :pCompraLocalesContrato.ID_TipoPeriodicidad);
                    p.Add("@PorcentajeMinimo",(pCompraLocalesContrato.PorcentajeMinimo== null) ? vintNUll :pCompraLocalesContrato.PorcentajeMinimo);
                    p.Add("@NumeroEmpresasMinimo",(pCompraLocalesContrato.NumeroEmpresasMinimo== null) ? vintNUll :pCompraLocalesContrato.NumeroEmpresasMinimo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CompraLocalesContrato> l = SqlMapper.Query<CompraLocalesContrato>(con, "API.PA_CompraLocalesContratoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CompraLocalesContrato  ->" + ex.Message);
				}
			}

			public CompraLocalesContrato Add(CompraLocalesContrato pCompraLocalesContrato)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCompraLocalesContrato.id==null ? 0 : pCompraLocalesContrato.id);
p.Add("@ID_contrato",pCompraLocalesContrato.ID_contrato==null ? 0 : pCompraLocalesContrato.ID_contrato);
p.Add("@ID_TipoReglaCompraLocal",pCompraLocalesContrato.ID_TipoReglaCompraLocal==null ? 0 : pCompraLocalesContrato.ID_TipoReglaCompraLocal);
p.Add("@ID_TipoCriterioEvaluacion",pCompraLocalesContrato.ID_TipoCriterioEvaluacion==null ? 0 : pCompraLocalesContrato.ID_TipoCriterioEvaluacion);
p.Add("@ID_TipoPeriodicidad",pCompraLocalesContrato.ID_TipoPeriodicidad==null ? 0 : pCompraLocalesContrato.ID_TipoPeriodicidad);
p.Add("@PorcentajeMinimo",pCompraLocalesContrato.PorcentajeMinimo==null ? 0 : pCompraLocalesContrato.PorcentajeMinimo);
p.Add("@NumeroEmpresasMinimo",pCompraLocalesContrato.NumeroEmpresasMinimo==null ? 0 : pCompraLocalesContrato.NumeroEmpresasMinimo);
                    p.Add("@auditoria", pCompraLocalesContrato.auditoria);

                         


                    CompraLocalesContrato o = SqlMapper.QueryFirstOrDefault<CompraLocalesContrato>(con, "API.PA_CompraLocalesContratoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CompraLocalesContrato  ->" + ex.Message);
				}
			}

			public CompraLocalesContrato  Update(CompraLocalesContrato pCompraLocalesContrato)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCompraLocalesContrato.id==null ? 0 : pCompraLocalesContrato.id);
p.Add("@ID_contrato",pCompraLocalesContrato.ID_contrato==null ? 0 : pCompraLocalesContrato.ID_contrato);
p.Add("@ID_TipoReglaCompraLocal",pCompraLocalesContrato.ID_TipoReglaCompraLocal==null ? 0 : pCompraLocalesContrato.ID_TipoReglaCompraLocal);
p.Add("@ID_TipoCriterioEvaluacion",pCompraLocalesContrato.ID_TipoCriterioEvaluacion==null ? 0 : pCompraLocalesContrato.ID_TipoCriterioEvaluacion);
p.Add("@ID_TipoPeriodicidad",pCompraLocalesContrato.ID_TipoPeriodicidad==null ? 0 : pCompraLocalesContrato.ID_TipoPeriodicidad);
p.Add("@PorcentajeMinimo",pCompraLocalesContrato.PorcentajeMinimo==null ? 0 : pCompraLocalesContrato.PorcentajeMinimo);
p.Add("@NumeroEmpresasMinimo",pCompraLocalesContrato.NumeroEmpresasMinimo==null ? 0 : pCompraLocalesContrato.NumeroEmpresasMinimo);
                    p.Add("@auditoria", pCompraLocalesContrato.auditoria);

                         


                    CompraLocalesContrato o = SqlMapper.QueryFirstOrDefault<CompraLocalesContrato>(con, "API.PA_CompraLocalesContratoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CompraLocalesContrato  ->" + ex.Message);
				}
			}

			public bool Delete(CompraLocalesContrato pCompraLocalesContrato)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCompraLocalesContrato.id);
                    p.Add("@auditoria", pCompraLocalesContrato.auditoria);

                

 

					CompraLocalesContrato o = SqlMapper.QueryFirstOrDefault<CompraLocalesContrato>(con, "API.PA_CompraLocalesContratoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CompraLocalesContrato  ->" + ex.Message);
				}
			}

		



            public List<CompraLocalesContrato> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CompraLocalesContrato> CompraLocalesContratoList = new List<CompraLocalesContrato>();

                    CompraLocalesContratoList = SqlMapper.Query<CompraLocalesContrato>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CompraLocalesContratoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CompraLocalesContrato  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CompraLocalesContrato> b)
            {
                DapperPlusManager.Entity<CompraLocalesContrato>().Table("CompraLocalesContrato");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}