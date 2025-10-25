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
     /// Clase Abstracta para  InformacionPresupuestal
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class InformacionPresupuestalRepository : DataObject , IInformacionPresupuestal 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public InformacionPresupuestalRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public InformacionPresupuestalRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public InformacionPresupuestal GetById(InformacionPresupuestal pInformacionPresupuestal)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pInformacionPresupuestal.id);                                    


    				InformacionPresupuestal o = SqlMapper.QueryFirstOrDefault<InformacionPresupuestal>(con, "API.PA_InformacionPresupuestalGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  InformacionPresupuestal  ->" + ex.Message);
				}
			}

			public List<InformacionPresupuestal> GetAll()
			{
				try 
                {
                        List<InformacionPresupuestal> l = SqlMapper.Query<InformacionPresupuestal>(con, "API.PA_InformacionPresupuestalGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  InformacionPresupuestal  ->" + ex.Message);
				}
			}

			public List<InformacionPresupuestal> GetAllFull()
			{
				try 
				{
                    List<InformacionPresupuestal> l = SqlMapper.Query<InformacionPresupuestal>(con, "API.PA_InformacionPresupuestalGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  InformacionPresupuestal  ->" + ex.Message);
				}
			}
			
			public List<InformacionPresupuestal> GetAllByWithRelation()
			{
				try 
                {
                    List<InformacionPresupuestal> l = SqlMapper.Query<InformacionPresupuestal>(con, "API.PA_InformacionPresupuestalGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  InformacionPresupuestal  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<InformacionPresupuestal> GetByFilter(InformacionPresupuestal pInformacionPresupuestal, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pInformacionPresupuestal.id== null || pInformacionPresupuestal.id==0) ? vintNUll :pInformacionPresupuestal.id);
                    p.Add("@ID_contrato",(pInformacionPresupuestal.ID_contrato== null || pInformacionPresupuestal.ID_contrato==0) ? vintNUll :pInformacionPresupuestal.ID_contrato);
                    p.Add("@TotalFuentesFinanciacion",(pInformacionPresupuestal.TotalFuentesFinanciacion== null) ? vintNUll :pInformacionPresupuestal.TotalFuentesFinanciacion);
                    p.Add("@PathPDFContrato",(pInformacionPresupuestal.PathPDFContrato== null) ? vintNUll :pInformacionPresupuestal.PathPDFContrato);
                    p.Add("@ValorTotalContrato",(pInformacionPresupuestal.ValorTotalContrato== null) ? vintNUll :pInformacionPresupuestal.ValorTotalContrato);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<InformacionPresupuestal> l = SqlMapper.Query<InformacionPresupuestal>(con, "API.PA_InformacionPresupuestalGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  InformacionPresupuestal  ->" + ex.Message);
				}
			}

			public InformacionPresupuestal Add(InformacionPresupuestal pInformacionPresupuestal)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pInformacionPresupuestal.id==null ? 0 : pInformacionPresupuestal.id);
p.Add("@ID_contrato",pInformacionPresupuestal.ID_contrato==null ? 0 : pInformacionPresupuestal.ID_contrato);
                    p.Add("@TotalFuentesFinanciacion", pInformacionPresupuestal.TotalFuentesFinanciacion);
                    p.Add("@PathPDFContrato", pInformacionPresupuestal.PathPDFContrato);
                    p.Add("@ValorTotalContrato", pInformacionPresupuestal.ValorTotalContrato);
                    p.Add("@auditoria", pInformacionPresupuestal.auditoria);

                         


                    InformacionPresupuestal o = SqlMapper.QueryFirstOrDefault<InformacionPresupuestal>(con, "API.PA_InformacionPresupuestalAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  InformacionPresupuestal  ->" + ex.Message);
				}
			}

			public InformacionPresupuestal  Update(InformacionPresupuestal pInformacionPresupuestal)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pInformacionPresupuestal.id==null ? 0 : pInformacionPresupuestal.id);
p.Add("@ID_contrato",pInformacionPresupuestal.ID_contrato==null ? 0 : pInformacionPresupuestal.ID_contrato);
                    p.Add("@TotalFuentesFinanciacion", pInformacionPresupuestal.TotalFuentesFinanciacion);
                    p.Add("@PathPDFContrato", pInformacionPresupuestal.PathPDFContrato);
                    p.Add("@ValorTotalContrato", pInformacionPresupuestal.ValorTotalContrato);
                    p.Add("@auditoria", pInformacionPresupuestal.auditoria);

                         


                    InformacionPresupuestal o = SqlMapper.QueryFirstOrDefault<InformacionPresupuestal>(con, "API.PA_InformacionPresupuestalUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  InformacionPresupuestal  ->" + ex.Message);
				}
			}

			public bool Delete(InformacionPresupuestal pInformacionPresupuestal)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pInformacionPresupuestal.id);
                    p.Add("@auditoria", pInformacionPresupuestal.auditoria);

                

 

					InformacionPresupuestal o = SqlMapper.QueryFirstOrDefault<InformacionPresupuestal>(con, "API.PA_InformacionPresupuestalDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) InformacionPresupuestal  ->" + ex.Message);
				}
			}

		



            public List<InformacionPresupuestal> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<InformacionPresupuestal> InformacionPresupuestalList = new List<InformacionPresupuestal>();

                    InformacionPresupuestalList = SqlMapper.Query<InformacionPresupuestal>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return InformacionPresupuestalList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) InformacionPresupuestal  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<InformacionPresupuestal> b)
            {
                DapperPlusManager.Entity<InformacionPresupuestal>().Table("InformacionPresupuestal");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}