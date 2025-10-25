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
     /// Clase Abstracta para  ProductosCompra
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ProductosCompraRepository : DataObject , IProductosCompra 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ProductosCompraRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ProductosCompraRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ProductosCompra GetById(ProductosCompra pProductosCompra)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pProductosCompra.id);                                    


    				ProductosCompra o = SqlMapper.QueryFirstOrDefault<ProductosCompra>(con, "API.PA_ProductosCompraGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ProductosCompra  ->" + ex.Message);
				}
			}

			public List<ProductosCompra> GetAll()
			{
				try 
                {
                        List<ProductosCompra> l = SqlMapper.Query<ProductosCompra>(con, "API.PA_ProductosCompraGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ProductosCompra  ->" + ex.Message);
				}
			}

			public List<ProductosCompra> GetAllFull()
			{
				try 
				{
                    List<ProductosCompra> l = SqlMapper.Query<ProductosCompra>(con, "API.PA_ProductosCompraGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ProductosCompra  ->" + ex.Message);
				}
			}
			
			public List<ProductosCompra> GetAllByWithRelation()
			{
				try 
                {
                    List<ProductosCompra> l = SqlMapper.Query<ProductosCompra>(con, "API.PA_ProductosCompraGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ProductosCompra  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ProductosCompra> GetByFilter(ProductosCompra pProductosCompra, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pProductosCompra.id== null || pProductosCompra.id==0) ? vintNUll :pProductosCompra.id);
                    p.Add("@ID_CompraLocal",(pProductosCompra.ID_CompraLocal== null || pProductosCompra.ID_CompraLocal==0) ? vintNUll :pProductosCompra.ID_CompraLocal);
                    p.Add("@ID_TipoProductoCompraLocal",(pProductosCompra.ID_TipoProductoCompraLocal== null || pProductosCompra.ID_TipoProductoCompraLocal==0) ? vintNUll :pProductosCompra.ID_TipoProductoCompraLocal);
                    p.Add("@ID_Alimento",(pProductosCompra.ID_Alimento== null || pProductosCompra.ID_Alimento==0) ? vintNUll :pProductosCompra.ID_Alimento);
                    p.Add("@ID_TipoAlimento",(pProductosCompra.ID_TipoAlimento== null || pProductosCompra.ID_TipoAlimento==0) ? vintNUll :pProductosCompra.ID_TipoAlimento);
                    p.Add("@ID_SubTipoAlimento",(pProductosCompra.ID_SubTipoAlimento== null || pProductosCompra.ID_SubTipoAlimento==0) ? vintNUll :pProductosCompra.ID_SubTipoAlimento);
                    p.Add("@ID_MunicipioAdquiereServicio",(pProductosCompra.ID_MunicipioAdquiereServicio== null || pProductosCompra.ID_MunicipioAdquiereServicio==0) ? vintNUll :pProductosCompra.ID_MunicipioAdquiereServicio);
                    p.Add("@DescripcionProducto",(pProductosCompra.DescripcionProducto== null) ? vintNUll :pProductosCompra.DescripcionProducto);
                    p.Add("@DescripcionServicio",(pProductosCompra.DescripcionServicio== null) ? vintNUll :pProductosCompra.DescripcionServicio);
                    p.Add("@CantidadComprada",(pProductosCompra.CantidadComprada== null) ? vintNUll :pProductosCompra.CantidadComprada);
                    p.Add("@PrecioUnidad",(pProductosCompra.PrecioUnidad== null) ? vintNUll :pProductosCompra.PrecioUnidad);
                    p.Add("@PrecioTotal",(pProductosCompra.PrecioTotal== null) ? vintNUll :pProductosCompra.PrecioTotal);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ProductosCompra> l = SqlMapper.Query<ProductosCompra>(con, "API.PA_ProductosCompraGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ProductosCompra  ->" + ex.Message);
				}
			}

			public ProductosCompra Add(ProductosCompra pProductosCompra)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pProductosCompra.id==null ? 0 : pProductosCompra.id);
p.Add("@ID_CompraLocal",pProductosCompra.ID_CompraLocal==null ? 0 : pProductosCompra.ID_CompraLocal);
p.Add("@ID_TipoProductoCompraLocal",pProductosCompra.ID_TipoProductoCompraLocal==null ? 0 : pProductosCompra.ID_TipoProductoCompraLocal);
p.Add("@ID_Alimento",pProductosCompra.ID_Alimento==null ? 0 : pProductosCompra.ID_Alimento);
p.Add("@ID_TipoAlimento",pProductosCompra.ID_TipoAlimento==null ? 0 : pProductosCompra.ID_TipoAlimento);
p.Add("@ID_SubTipoAlimento",pProductosCompra.ID_SubTipoAlimento==null ? 0 : pProductosCompra.ID_SubTipoAlimento);
p.Add("@ID_MunicipioAdquiereServicio",pProductosCompra.ID_MunicipioAdquiereServicio==null ? 0 : pProductosCompra.ID_MunicipioAdquiereServicio);
                    p.Add("@DescripcionProducto", pProductosCompra.DescripcionProducto);
                    p.Add("@DescripcionServicio", pProductosCompra.DescripcionServicio);
                    p.Add("@CantidadComprada", pProductosCompra.CantidadComprada);
                    p.Add("@PrecioUnidad", pProductosCompra.PrecioUnidad);
                    p.Add("@PrecioTotal", pProductosCompra.PrecioTotal);
                    p.Add("@auditoria", pProductosCompra.auditoria);

                         


                    ProductosCompra o = SqlMapper.QueryFirstOrDefault<ProductosCompra>(con, "API.PA_ProductosCompraAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ProductosCompra  ->" + ex.Message);
				}
			}

			public ProductosCompra  Update(ProductosCompra pProductosCompra)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pProductosCompra.id==null ? 0 : pProductosCompra.id);
p.Add("@ID_CompraLocal",pProductosCompra.ID_CompraLocal==null ? 0 : pProductosCompra.ID_CompraLocal);
p.Add("@ID_TipoProductoCompraLocal",pProductosCompra.ID_TipoProductoCompraLocal==null ? 0 : pProductosCompra.ID_TipoProductoCompraLocal);
p.Add("@ID_Alimento",pProductosCompra.ID_Alimento==null ? 0 : pProductosCompra.ID_Alimento);
p.Add("@ID_TipoAlimento",pProductosCompra.ID_TipoAlimento==null ? 0 : pProductosCompra.ID_TipoAlimento);
p.Add("@ID_SubTipoAlimento",pProductosCompra.ID_SubTipoAlimento==null ? 0 : pProductosCompra.ID_SubTipoAlimento);
p.Add("@ID_MunicipioAdquiereServicio",pProductosCompra.ID_MunicipioAdquiereServicio==null ? 0 : pProductosCompra.ID_MunicipioAdquiereServicio);
                    p.Add("@DescripcionProducto", pProductosCompra.DescripcionProducto);
                    p.Add("@DescripcionServicio", pProductosCompra.DescripcionServicio);
                    p.Add("@CantidadComprada", pProductosCompra.CantidadComprada);
                    p.Add("@PrecioUnidad", pProductosCompra.PrecioUnidad);
                    p.Add("@PrecioTotal", pProductosCompra.PrecioTotal);
                    p.Add("@auditoria", pProductosCompra.auditoria);

                         


                    ProductosCompra o = SqlMapper.QueryFirstOrDefault<ProductosCompra>(con, "API.PA_ProductosCompraUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ProductosCompra  ->" + ex.Message);
				}
			}

			public bool Delete(ProductosCompra pProductosCompra)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pProductosCompra.id);
                    p.Add("@auditoria", pProductosCompra.auditoria);

                

 

					ProductosCompra o = SqlMapper.QueryFirstOrDefault<ProductosCompra>(con, "API.PA_ProductosCompraDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ProductosCompra  ->" + ex.Message);
				}
			}

		



            public List<ProductosCompra> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ProductosCompra> ProductosCompraList = new List<ProductosCompra>();

                    ProductosCompraList = SqlMapper.Query<ProductosCompra>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ProductosCompraList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ProductosCompra  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ProductosCompra> b)
            {
                DapperPlusManager.Entity<ProductosCompra>().Table("ProductosCompra");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}