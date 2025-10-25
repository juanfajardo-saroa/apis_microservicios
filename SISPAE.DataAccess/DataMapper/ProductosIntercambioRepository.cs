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
     /// Clase Abstracta para  ProductosIntercambio
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ProductosIntercambioRepository : DataObject , IProductosIntercambio 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ProductosIntercambioRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ProductosIntercambioRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ProductosIntercambio GetById(ProductosIntercambio pProductosIntercambio)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pProductosIntercambio.id);                                    


    				ProductosIntercambio o = SqlMapper.QueryFirstOrDefault<ProductosIntercambio>(con, "API.PA_ProductosIntercambioGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ProductosIntercambio  ->" + ex.Message);
				}
			}

			public List<ProductosIntercambio> GetAll()
			{
				try 
                {
                        List<ProductosIntercambio> l = SqlMapper.Query<ProductosIntercambio>(con, "API.PA_ProductosIntercambioGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ProductosIntercambio  ->" + ex.Message);
				}
			}

			public List<ProductosIntercambio> GetAllFull()
			{
				try 
				{
                    List<ProductosIntercambio> l = SqlMapper.Query<ProductosIntercambio>(con, "API.PA_ProductosIntercambioGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ProductosIntercambio  ->" + ex.Message);
				}
			}
			
			public List<ProductosIntercambio> GetAllByWithRelation()
			{
				try 
                {
                    List<ProductosIntercambio> l = SqlMapper.Query<ProductosIntercambio>(con, "API.PA_ProductosIntercambioGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ProductosIntercambio  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ProductosIntercambio> GetByFilter(ProductosIntercambio pProductosIntercambio, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pProductosIntercambio.id== null || pProductosIntercambio.id==0) ? vintNUll :pProductosIntercambio.id);
                    p.Add("@ID_ProductoBase",(pProductosIntercambio.ID_ProductoBase== null || pProductosIntercambio.ID_ProductoBase==0) ? vintNUll :pProductosIntercambio.ID_ProductoBase);
                    p.Add("@ID_Productolntercambio",(pProductosIntercambio.ID_Productolntercambio== null || pProductosIntercambio.ID_Productolntercambio==0) ? vintNUll :pProductosIntercambio.ID_Productolntercambio);
                    p.Add("@CantBase",(pProductosIntercambio.CantBase== null) ? vintNUll :pProductosIntercambio.CantBase);
                    p.Add("@Cantintercambio",(pProductosIntercambio.Cantintercambio== null) ? vintNUll :pProductosIntercambio.Cantintercambio);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ProductosIntercambio> l = SqlMapper.Query<ProductosIntercambio>(con, "API.PA_ProductosIntercambioGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ProductosIntercambio  ->" + ex.Message);
				}
			}

			public ProductosIntercambio Add(ProductosIntercambio pProductosIntercambio)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pProductosIntercambio.id==null ? 0 : pProductosIntercambio.id);
p.Add("@ID_ProductoBase",pProductosIntercambio.ID_ProductoBase==null ? 0 : pProductosIntercambio.ID_ProductoBase);
p.Add("@ID_Productolntercambio",pProductosIntercambio.ID_Productolntercambio==null ? 0 : pProductosIntercambio.ID_Productolntercambio);
p.Add("@CantBase",pProductosIntercambio.CantBase==null ? 0 : pProductosIntercambio.CantBase);
p.Add("@Cantintercambio",pProductosIntercambio.Cantintercambio==null ? 0 : pProductosIntercambio.Cantintercambio);
                    p.Add("@auditoria", pProductosIntercambio.auditoria);

                         


                    ProductosIntercambio o = SqlMapper.QueryFirstOrDefault<ProductosIntercambio>(con, "API.PA_ProductosIntercambioAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ProductosIntercambio  ->" + ex.Message);
				}
			}

			public ProductosIntercambio  Update(ProductosIntercambio pProductosIntercambio)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pProductosIntercambio.id==null ? 0 : pProductosIntercambio.id);
p.Add("@ID_ProductoBase",pProductosIntercambio.ID_ProductoBase==null ? 0 : pProductosIntercambio.ID_ProductoBase);
p.Add("@ID_Productolntercambio",pProductosIntercambio.ID_Productolntercambio==null ? 0 : pProductosIntercambio.ID_Productolntercambio);
p.Add("@CantBase",pProductosIntercambio.CantBase==null ? 0 : pProductosIntercambio.CantBase);
p.Add("@Cantintercambio",pProductosIntercambio.Cantintercambio==null ? 0 : pProductosIntercambio.Cantintercambio);
                    p.Add("@auditoria", pProductosIntercambio.auditoria);

                         


                    ProductosIntercambio o = SqlMapper.QueryFirstOrDefault<ProductosIntercambio>(con, "API.PA_ProductosIntercambioUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ProductosIntercambio  ->" + ex.Message);
				}
			}

			public bool Delete(ProductosIntercambio pProductosIntercambio)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pProductosIntercambio.id);
                    p.Add("@auditoria", pProductosIntercambio.auditoria);

                

 

					ProductosIntercambio o = SqlMapper.QueryFirstOrDefault<ProductosIntercambio>(con, "API.PA_ProductosIntercambioDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ProductosIntercambio  ->" + ex.Message);
				}
			}

		



            public List<ProductosIntercambio> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ProductosIntercambio> ProductosIntercambioList = new List<ProductosIntercambio>();

                    ProductosIntercambioList = SqlMapper.Query<ProductosIntercambio>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ProductosIntercambioList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ProductosIntercambio  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ProductosIntercambio> b)
            {
                DapperPlusManager.Entity<ProductosIntercambio>().Table("ProductosIntercambio");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}