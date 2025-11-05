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
     /// Clase Abstracta para  Productos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ProductosRepository : DataObject , IProductos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ProductosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ProductosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Productos GetById(Productos pProductos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pProductos.id);                                    


    				Productos o = SqlMapper.QueryFirstOrDefault<Productos>(con, "API.PA_ProductosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Productos  ->" + ex.Message);
				}
			}

			public List<Productos> GetAll()
			{
				try 
                {
                        List<Productos> l = SqlMapper.Query<Productos>(con, "API.PA_ProductosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Productos  ->" + ex.Message);
				}
			}

			public List<Productos> GetAllFull()
			{
				try 
				{
                    List<Productos> l = SqlMapper.Query<Productos>(con, "API.PA_ProductosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Productos  ->" + ex.Message);
				}
			}
			
			public List<Productos> GetAllByWithRelation()
			{
				try 
                {
                    List<Productos> l = SqlMapper.Query<Productos>(con, "API.PA_ProductosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Productos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Productos> GetByFilter(Productos pProductos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pProductos.id== null || pProductos.id==0) ? vintNUll :pProductos.id);
                    p.Add("@ID_SubGrupoAlimentos",(pProductos.ID_SubGrupoAlimentos== null || pProductos.ID_SubGrupoAlimentos==0) ? vintNUll :pProductos.ID_SubGrupoAlimentos);
                    p.Add("@ID_ETC",(pProductos.ID_ETC== null || pProductos.ID_ETC==0) ? vintNUll :pProductos.ID_ETC);
                    p.Add("@ID_TiposAlimentos",(pProductos.ID_TiposAlimentos== null || pProductos.ID_TiposAlimentos==0) ? vintNUll :pProductos.ID_TiposAlimentos);
                    p.Add("@ID_TiposUnidad",(pProductos.ID_TiposUnidad== null || pProductos.ID_TiposUnidad==0) ? vintNUll :pProductos.ID_TiposUnidad);
                    p.Add("@ID_EstadoRegistro",(pProductos.ID_EstadoRegistro== null || pProductos.ID_EstadoRegistro==0) ? vintNUll :pProductos.ID_EstadoRegistro);
                    p.Add("@ID_RegistroINVIMA",(pProductos.ID_RegistroINVIMA== null || pProductos.ID_RegistroINVIMA==0) ? vintNUll :pProductos.ID_RegistroINVIMA);
                    p.Add("@Nombre",(pProductos.Nombre== null) ? vintNUll :pProductos.Nombre);
                    p.Add("@NumeroRegistroInvima",(pProductos.NumeroRegistroInvima== null) ? vintNUll :pProductos.NumeroRegistroInvima);
                    p.Add("@PathlmagenProducto",(pProductos.PathlmagenProducto== null) ? vintNUll :pProductos.PathlmagenProducto);
                    p.Add("@PathlmagenRegistroSanitario",(pProductos.PathlmagenRegistroSanitario== null) ? vintNUll :pProductos.PathlmagenRegistroSanitario);
                    p.Add("@BaseFruta",(pProductos.BaseFruta== null) ? vintNUll :pProductos.BaseFruta);
                    p.Add("@PathImagenInformacionNutricional",(pProductos.PathImagenInformacionNutricional== null) ? vintNUll :pProductos.PathImagenInformacionNutricional);
                    p.Add("@FechaRegistro",(pProductos.FechaRegistro== null) ? vintNUll :pProductos.FechaRegistro);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Productos> l = SqlMapper.Query<Productos>(con, "API.PA_ProductosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Productos  ->" + ex.Message);
				}
			}

			public Productos Add(Productos pProductos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pProductos.id==null ? 0 : pProductos.id);
p.Add("@ID_SubGrupoAlimentos",pProductos.ID_SubGrupoAlimentos==null ? 0 : pProductos.ID_SubGrupoAlimentos);
p.Add("@ID_ETC",pProductos.ID_ETC==null ? 0 : pProductos.ID_ETC);
p.Add("@ID_TiposAlimentos",pProductos.ID_TiposAlimentos==null ? 0 : pProductos.ID_TiposAlimentos);
p.Add("@ID_TiposUnidad",pProductos.ID_TiposUnidad==null ? 0 : pProductos.ID_TiposUnidad);
p.Add("@ID_EstadoRegistro",pProductos.ID_EstadoRegistro==null ? 0 : pProductos.ID_EstadoRegistro);
p.Add("@ID_RegistroINVIMA",pProductos.ID_RegistroINVIMA==null ? 0 : pProductos.ID_RegistroINVIMA);
                    p.Add("@Nombre", pProductos.Nombre);
                    p.Add("@NumeroRegistroInvima", pProductos.NumeroRegistroInvima);
                    p.Add("@PathlmagenProducto", pProductos.PathlmagenProducto);
                    p.Add("@PathlmagenRegistroSanitario", pProductos.PathlmagenRegistroSanitario);
                    p.Add("@BaseFruta", pProductos.BaseFruta);
                    p.Add("@PathImagenInformacionNutricional", pProductos.PathImagenInformacionNutricional);
                    p.Add("@FechaRegistro", pProductos.FechaRegistro);
                    p.Add("@auditoria", pProductos.auditoria);

                         


                    Productos o = SqlMapper.QueryFirstOrDefault<Productos>(con, "API.PA_ProductosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Productos  ->" + ex.Message);
				}
			}

			public Productos  Update(Productos pProductos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pProductos.id==null ? 0 : pProductos.id);
p.Add("@ID_SubGrupoAlimentos",pProductos.ID_SubGrupoAlimentos==null ? 0 : pProductos.ID_SubGrupoAlimentos);
p.Add("@ID_ETC",pProductos.ID_ETC==null ? 0 : pProductos.ID_ETC);
p.Add("@ID_TiposAlimentos",pProductos.ID_TiposAlimentos==null ? 0 : pProductos.ID_TiposAlimentos);
p.Add("@ID_TiposUnidad",pProductos.ID_TiposUnidad==null ? 0 : pProductos.ID_TiposUnidad);
p.Add("@ID_EstadoRegistro",pProductos.ID_EstadoRegistro==null ? 0 : pProductos.ID_EstadoRegistro);
p.Add("@ID_RegistroINVIMA",pProductos.ID_RegistroINVIMA==null ? 0 : pProductos.ID_RegistroINVIMA);
                    p.Add("@Nombre", pProductos.Nombre);
                    p.Add("@NumeroRegistroInvima", pProductos.NumeroRegistroInvima);
                    p.Add("@PathlmagenProducto", pProductos.PathlmagenProducto);
                    p.Add("@PathlmagenRegistroSanitario", pProductos.PathlmagenRegistroSanitario);
                    p.Add("@BaseFruta", pProductos.BaseFruta);
                    p.Add("@PathImagenInformacionNutricional", pProductos.PathImagenInformacionNutricional);
                    p.Add("@FechaRegistro", pProductos.FechaRegistro);
                    p.Add("@auditoria", pProductos.auditoria);

                         


                    Productos o = SqlMapper.QueryFirstOrDefault<Productos>(con, "API.PA_ProductosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Productos  ->" + ex.Message);
				}
			}

			public bool Delete(Productos pProductos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pProductos.id);
                    p.Add("@auditoria", pProductos.auditoria);

                

 

					Productos o = SqlMapper.QueryFirstOrDefault<Productos>(con, "API.PA_ProductosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Productos  ->" + ex.Message);
				}
			}

		



            public List<Productos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Productos> ProductosList = new List<Productos>();

                    ProductosList = SqlMapper.Query<Productos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ProductosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Productos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Productos> b)
            {
                DapperPlusManager.Entity<Productos>().Table("Productos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}