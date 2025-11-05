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
     /// Clase Abstracta para  VariedadesProducto
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class VariedadesProductoRepository : DataObject , IVariedadesProducto 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public VariedadesProductoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public VariedadesProductoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public VariedadesProducto GetById(VariedadesProducto pVariedadesProducto)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pVariedadesProducto.id);                                    


    				VariedadesProducto o = SqlMapper.QueryFirstOrDefault<VariedadesProducto>(con, "API.PA_VariedadesProductoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  VariedadesProducto  ->" + ex.Message);
				}
			}

			public List<VariedadesProducto> GetAll()
			{
				try 
                {
                        List<VariedadesProducto> l = SqlMapper.Query<VariedadesProducto>(con, "API.PA_VariedadesProductoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  VariedadesProducto  ->" + ex.Message);
				}
			}

			public List<VariedadesProducto> GetAllFull()
			{
				try 
				{
                    List<VariedadesProducto> l = SqlMapper.Query<VariedadesProducto>(con, "API.PA_VariedadesProductoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  VariedadesProducto  ->" + ex.Message);
				}
			}
			
			public List<VariedadesProducto> GetAllByWithRelation()
			{
				try 
                {
                    List<VariedadesProducto> l = SqlMapper.Query<VariedadesProducto>(con, "API.PA_VariedadesProductoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  VariedadesProducto  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<VariedadesProducto> GetByFilter(VariedadesProducto pVariedadesProducto, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pVariedadesProducto.id== null || pVariedadesProducto.id==0) ? vintNUll :pVariedadesProducto.id);
                    p.Add("@ID_Producto",(pVariedadesProducto.ID_Producto== null || pVariedadesProducto.ID_Producto==0) ? vintNUll :pVariedadesProducto.ID_Producto);
                    p.Add("@NombreVariedad",(pVariedadesProducto.NombreVariedad== null) ? vintNUll :pVariedadesProducto.NombreVariedad);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<VariedadesProducto> l = SqlMapper.Query<VariedadesProducto>(con, "API.PA_VariedadesProductoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  VariedadesProducto  ->" + ex.Message);
				}
			}

			public VariedadesProducto Add(VariedadesProducto pVariedadesProducto)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pVariedadesProducto.id==null ? 0 : pVariedadesProducto.id);
p.Add("@ID_Producto",pVariedadesProducto.ID_Producto==null ? 0 : pVariedadesProducto.ID_Producto);
                    p.Add("@NombreVariedad", pVariedadesProducto.NombreVariedad);
                    p.Add("@auditoria", pVariedadesProducto.auditoria);

                         


                    VariedadesProducto o = SqlMapper.QueryFirstOrDefault<VariedadesProducto>(con, "API.PA_VariedadesProductoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  VariedadesProducto  ->" + ex.Message);
				}
			}

			public VariedadesProducto  Update(VariedadesProducto pVariedadesProducto)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pVariedadesProducto.id==null ? 0 : pVariedadesProducto.id);
p.Add("@ID_Producto",pVariedadesProducto.ID_Producto==null ? 0 : pVariedadesProducto.ID_Producto);
                    p.Add("@NombreVariedad", pVariedadesProducto.NombreVariedad);
                    p.Add("@auditoria", pVariedadesProducto.auditoria);

                         


                    VariedadesProducto o = SqlMapper.QueryFirstOrDefault<VariedadesProducto>(con, "API.PA_VariedadesProductoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  VariedadesProducto  ->" + ex.Message);
				}
			}

			public bool Delete(VariedadesProducto pVariedadesProducto)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pVariedadesProducto.id);
                    p.Add("@auditoria", pVariedadesProducto.auditoria);

                

 

					VariedadesProducto o = SqlMapper.QueryFirstOrDefault<VariedadesProducto>(con, "API.PA_VariedadesProductoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) VariedadesProducto  ->" + ex.Message);
				}
			}

		



            public List<VariedadesProducto> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<VariedadesProducto> VariedadesProductoList = new List<VariedadesProducto>();

                    VariedadesProductoList = SqlMapper.Query<VariedadesProducto>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return VariedadesProductoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) VariedadesProducto  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<VariedadesProducto> b)
            {
                DapperPlusManager.Entity<VariedadesProducto>().Table("VariedadesProducto");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}