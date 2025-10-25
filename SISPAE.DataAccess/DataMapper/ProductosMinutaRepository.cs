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
     /// Clase Abstracta para  ProductosMinuta
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ProductosMinutaRepository : DataObject , IProductosMinuta 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ProductosMinutaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ProductosMinutaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ProductosMinuta GetById(ProductosMinuta pProductosMinuta)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pProductosMinuta.id);                                    


    				ProductosMinuta o = SqlMapper.QueryFirstOrDefault<ProductosMinuta>(con, "API.PA_ProductosMinutaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ProductosMinuta  ->" + ex.Message);
				}
			}

			public List<ProductosMinuta> GetAll()
			{
				try 
                {
                        List<ProductosMinuta> l = SqlMapper.Query<ProductosMinuta>(con, "API.PA_ProductosMinutaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ProductosMinuta  ->" + ex.Message);
				}
			}

			public List<ProductosMinuta> GetAllFull()
			{
				try 
				{
                    List<ProductosMinuta> l = SqlMapper.Query<ProductosMinuta>(con, "API.PA_ProductosMinutaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ProductosMinuta  ->" + ex.Message);
				}
			}
			
			public List<ProductosMinuta> GetAllByWithRelation()
			{
				try 
                {
                    List<ProductosMinuta> l = SqlMapper.Query<ProductosMinuta>(con, "API.PA_ProductosMinutaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ProductosMinuta  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ProductosMinuta> GetByFilter(ProductosMinuta pProductosMinuta, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pProductosMinuta.id== null || pProductosMinuta.id==0) ? vintNUll :pProductosMinuta.id);
                    p.Add("@ID_MinutaPatronProducto",(pProductosMinuta.ID_MinutaPatronProducto== null || pProductosMinuta.ID_MinutaPatronProducto==0) ? vintNUll :pProductosMinuta.ID_MinutaPatronProducto);
                    p.Add("@ID_TipoComponente",(pProductosMinuta.ID_TipoComponente== null || pProductosMinuta.ID_TipoComponente==0) ? vintNUll :pProductosMinuta.ID_TipoComponente);
                    p.Add("@ID_GrupoAlimento",(pProductosMinuta.ID_GrupoAlimento== null || pProductosMinuta.ID_GrupoAlimento==0) ? vintNUll :pProductosMinuta.ID_GrupoAlimento);
                    p.Add("@frecuencia",(pProductosMinuta.frecuencia== null) ? vintNUll :pProductosMinuta.frecuencia);
                    p.Add("@gramoPesoNeto",(pProductosMinuta.gramoPesoNeto== null) ? vintNUll :pProductosMinuta.gramoPesoNeto);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ProductosMinuta> l = SqlMapper.Query<ProductosMinuta>(con, "API.PA_ProductosMinutaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ProductosMinuta  ->" + ex.Message);
				}
			}

			public ProductosMinuta Add(ProductosMinuta pProductosMinuta)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pProductosMinuta.id==null ? 0 : pProductosMinuta.id);
p.Add("@ID_MinutaPatronProducto",pProductosMinuta.ID_MinutaPatronProducto==null ? 0 : pProductosMinuta.ID_MinutaPatronProducto);
p.Add("@ID_TipoComponente",pProductosMinuta.ID_TipoComponente==null ? 0 : pProductosMinuta.ID_TipoComponente);
p.Add("@ID_GrupoAlimento",pProductosMinuta.ID_GrupoAlimento==null ? 0 : pProductosMinuta.ID_GrupoAlimento);
p.Add("@frecuencia",pProductosMinuta.frecuencia==null ? 0 : pProductosMinuta.frecuencia);
p.Add("@gramoPesoNeto",pProductosMinuta.gramoPesoNeto==null ? 0 : pProductosMinuta.gramoPesoNeto);
                    p.Add("@auditoria", pProductosMinuta.auditoria);

                         


                    ProductosMinuta o = SqlMapper.QueryFirstOrDefault<ProductosMinuta>(con, "API.PA_ProductosMinutaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ProductosMinuta  ->" + ex.Message);
				}
			}

			public ProductosMinuta  Update(ProductosMinuta pProductosMinuta)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pProductosMinuta.id==null ? 0 : pProductosMinuta.id);
p.Add("@ID_MinutaPatronProducto",pProductosMinuta.ID_MinutaPatronProducto==null ? 0 : pProductosMinuta.ID_MinutaPatronProducto);
p.Add("@ID_TipoComponente",pProductosMinuta.ID_TipoComponente==null ? 0 : pProductosMinuta.ID_TipoComponente);
p.Add("@ID_GrupoAlimento",pProductosMinuta.ID_GrupoAlimento==null ? 0 : pProductosMinuta.ID_GrupoAlimento);
p.Add("@frecuencia",pProductosMinuta.frecuencia==null ? 0 : pProductosMinuta.frecuencia);
p.Add("@gramoPesoNeto",pProductosMinuta.gramoPesoNeto==null ? 0 : pProductosMinuta.gramoPesoNeto);
                    p.Add("@auditoria", pProductosMinuta.auditoria);

                         


                    ProductosMinuta o = SqlMapper.QueryFirstOrDefault<ProductosMinuta>(con, "API.PA_ProductosMinutaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ProductosMinuta  ->" + ex.Message);
				}
			}

			public bool Delete(ProductosMinuta pProductosMinuta)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pProductosMinuta.id);
                    p.Add("@auditoria", pProductosMinuta.auditoria);

                

 

					ProductosMinuta o = SqlMapper.QueryFirstOrDefault<ProductosMinuta>(con, "API.PA_ProductosMinutaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ProductosMinuta  ->" + ex.Message);
				}
			}

		



            public List<ProductosMinuta> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ProductosMinuta> ProductosMinutaList = new List<ProductosMinuta>();

                    ProductosMinutaList = SqlMapper.Query<ProductosMinuta>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ProductosMinutaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ProductosMinuta  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ProductosMinuta> b)
            {
                DapperPlusManager.Entity<ProductosMinuta>().Table("ProductosMinuta");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}