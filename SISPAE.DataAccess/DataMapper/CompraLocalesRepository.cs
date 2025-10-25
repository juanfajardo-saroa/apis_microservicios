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
     /// Clase Abstracta para  CompraLocales
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CompraLocalesRepository : DataObject , ICompraLocales 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CompraLocalesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CompraLocalesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CompraLocales GetById(CompraLocales pCompraLocales)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCompraLocales.id);                                    


    				CompraLocales o = SqlMapper.QueryFirstOrDefault<CompraLocales>(con, "API.PA_CompraLocalesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CompraLocales  ->" + ex.Message);
				}
			}

			public List<CompraLocales> GetAll()
			{
				try 
                {
                        List<CompraLocales> l = SqlMapper.Query<CompraLocales>(con, "API.PA_CompraLocalesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CompraLocales  ->" + ex.Message);
				}
			}

			public List<CompraLocales> GetAllFull()
			{
				try 
				{
                    List<CompraLocales> l = SqlMapper.Query<CompraLocales>(con, "API.PA_CompraLocalesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CompraLocales  ->" + ex.Message);
				}
			}
			
			public List<CompraLocales> GetAllByWithRelation()
			{
				try 
                {
                    List<CompraLocales> l = SqlMapper.Query<CompraLocales>(con, "API.PA_CompraLocalesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CompraLocales  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CompraLocales> GetByFilter(CompraLocales pCompraLocales, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCompraLocales.id== null || pCompraLocales.id==0) ? vintNUll :pCompraLocales.id);
                    p.Add("@ID_Proveedor",(pCompraLocales.ID_Proveedor== null || pCompraLocales.ID_Proveedor==0) ? vintNUll :pCompraLocales.ID_Proveedor);
                    p.Add("@ID_Operador",(pCompraLocales.ID_Operador== null || pCompraLocales.ID_Operador==0) ? vintNUll :pCompraLocales.ID_Operador);
                    p.Add("@ID_Contrato",(pCompraLocales.ID_Contrato== null || pCompraLocales.ID_Contrato==0) ? vintNUll :pCompraLocales.ID_Contrato);
                    p.Add("@ID_AgrupacionMensual",(pCompraLocales.ID_AgrupacionMensual== null || pCompraLocales.ID_AgrupacionMensual==0) ? vintNUll :pCompraLocales.ID_AgrupacionMensual);
                    p.Add("@TotalKg",(pCompraLocales.TotalKg== null) ? vintNUll :pCompraLocales.TotalKg);
                    p.Add("@TotalProductos",(pCompraLocales.TotalProductos== null) ? vintNUll :pCompraLocales.TotalProductos);
                    p.Add("@ValorFactura",(pCompraLocales.ValorFactura== null) ? vintNUll :pCompraLocales.ValorFactura);
                    p.Add("@FacturaPDFPATH",(pCompraLocales.FacturaPDFPATH== null) ? vintNUll :pCompraLocales.FacturaPDFPATH);
                    p.Add("@CumpleCriterio",(pCompraLocales.CumpleCriterio== null) ? vintNUll :pCompraLocales.CumpleCriterio);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CompraLocales> l = SqlMapper.Query<CompraLocales>(con, "API.PA_CompraLocalesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CompraLocales  ->" + ex.Message);
				}
			}

			public CompraLocales Add(CompraLocales pCompraLocales)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCompraLocales.id==null ? 0 : pCompraLocales.id);
p.Add("@ID_Proveedor",pCompraLocales.ID_Proveedor==null ? 0 : pCompraLocales.ID_Proveedor);
p.Add("@ID_Operador",pCompraLocales.ID_Operador==null ? 0 : pCompraLocales.ID_Operador);
p.Add("@ID_Contrato",pCompraLocales.ID_Contrato==null ? 0 : pCompraLocales.ID_Contrato);
p.Add("@ID_AgrupacionMensual",pCompraLocales.ID_AgrupacionMensual==null ? 0 : pCompraLocales.ID_AgrupacionMensual);
p.Add("@TotalKg",pCompraLocales.TotalKg==null ? 0 : pCompraLocales.TotalKg);
p.Add("@TotalProductos",pCompraLocales.TotalProductos==null ? 0 : pCompraLocales.TotalProductos);
p.Add("@ValorFactura",pCompraLocales.ValorFactura==null ? 0 : pCompraLocales.ValorFactura);
p.Add("@FacturaPDFPATH",pCompraLocales.FacturaPDFPATH==null ? 0 : pCompraLocales.FacturaPDFPATH);
p.Add("@CumpleCriterio",pCompraLocales.CumpleCriterio==null ? 0 : pCompraLocales.CumpleCriterio);
                    p.Add("@auditoria", pCompraLocales.auditoria);

                         


                    CompraLocales o = SqlMapper.QueryFirstOrDefault<CompraLocales>(con, "API.PA_CompraLocalesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CompraLocales  ->" + ex.Message);
				}
			}

			public CompraLocales  Update(CompraLocales pCompraLocales)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCompraLocales.id==null ? 0 : pCompraLocales.id);
p.Add("@ID_Proveedor",pCompraLocales.ID_Proveedor==null ? 0 : pCompraLocales.ID_Proveedor);
p.Add("@ID_Operador",pCompraLocales.ID_Operador==null ? 0 : pCompraLocales.ID_Operador);
p.Add("@ID_Contrato",pCompraLocales.ID_Contrato==null ? 0 : pCompraLocales.ID_Contrato);
p.Add("@ID_AgrupacionMensual",pCompraLocales.ID_AgrupacionMensual==null ? 0 : pCompraLocales.ID_AgrupacionMensual);
p.Add("@TotalKg",pCompraLocales.TotalKg==null ? 0 : pCompraLocales.TotalKg);
p.Add("@TotalProductos",pCompraLocales.TotalProductos==null ? 0 : pCompraLocales.TotalProductos);
p.Add("@ValorFactura",pCompraLocales.ValorFactura==null ? 0 : pCompraLocales.ValorFactura);
p.Add("@FacturaPDFPATH",pCompraLocales.FacturaPDFPATH==null ? 0 : pCompraLocales.FacturaPDFPATH);
p.Add("@CumpleCriterio",pCompraLocales.CumpleCriterio==null ? 0 : pCompraLocales.CumpleCriterio);
                    p.Add("@auditoria", pCompraLocales.auditoria);

                         


                    CompraLocales o = SqlMapper.QueryFirstOrDefault<CompraLocales>(con, "API.PA_CompraLocalesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CompraLocales  ->" + ex.Message);
				}
			}

			public bool Delete(CompraLocales pCompraLocales)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCompraLocales.id);
                    p.Add("@auditoria", pCompraLocales.auditoria);

                

 

					CompraLocales o = SqlMapper.QueryFirstOrDefault<CompraLocales>(con, "API.PA_CompraLocalesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CompraLocales  ->" + ex.Message);
				}
			}

		



            public List<CompraLocales> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CompraLocales> CompraLocalesList = new List<CompraLocales>();

                    CompraLocalesList = SqlMapper.Query<CompraLocales>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CompraLocalesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CompraLocales  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CompraLocales> b)
            {
                DapperPlusManager.Entity<CompraLocales>().Table("CompraLocales");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}