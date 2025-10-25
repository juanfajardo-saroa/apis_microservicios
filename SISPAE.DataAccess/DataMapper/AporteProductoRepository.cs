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
     /// Clase Abstracta para  AporteProducto
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AporteProductoRepository : DataObject , IAporteProducto 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AporteProductoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AporteProductoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AporteProducto GetById(AporteProducto pAporteProducto)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAporteProducto.id);                                    


    				AporteProducto o = SqlMapper.QueryFirstOrDefault<AporteProducto>(con, "API.PA_AporteProductoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AporteProducto  ->" + ex.Message);
				}
			}

			public List<AporteProducto> GetAll()
			{
				try 
                {
                        List<AporteProducto> l = SqlMapper.Query<AporteProducto>(con, "API.PA_AporteProductoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AporteProducto  ->" + ex.Message);
				}
			}

			public List<AporteProducto> GetAllFull()
			{
				try 
				{
                    List<AporteProducto> l = SqlMapper.Query<AporteProducto>(con, "API.PA_AporteProductoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AporteProducto  ->" + ex.Message);
				}
			}
			
			public List<AporteProducto> GetAllByWithRelation()
			{
				try 
                {
                    List<AporteProducto> l = SqlMapper.Query<AporteProducto>(con, "API.PA_AporteProductoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AporteProducto  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AporteProducto> GetByFilter(AporteProducto pAporteProducto, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAporteProducto.id== null || pAporteProducto.id==0) ? vintNUll :pAporteProducto.id);
                    p.Add("@ID_Producto",(pAporteProducto.ID_Producto== null || pAporteProducto.ID_Producto==0) ? vintNUll :pAporteProducto.ID_Producto);
                    p.Add("@ID_TipoNivelEducativo",(pAporteProducto.ID_TipoNivelEducativo== null || pAporteProducto.ID_TipoNivelEducativo==0) ? vintNUll :pAporteProducto.ID_TipoNivelEducativo);
                    p.Add("@PesoBruto",(pAporteProducto.PesoBruto== null) ? vintNUll :pAporteProducto.PesoBruto);
                    p.Add("@PesoNeto",(pAporteProducto.PesoNeto== null) ? vintNUll :pAporteProducto.PesoNeto);
                    p.Add("@PorcentajeComestible",(pAporteProducto.PorcentajeComestible== null) ? vintNUll :pAporteProducto.PorcentajeComestible);
                    p.Add("@IntercambioEstandarizado",(pAporteProducto.IntercambioEstandarizado== null) ? vintNUll :pAporteProducto.IntercambioEstandarizado);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AporteProducto> l = SqlMapper.Query<AporteProducto>(con, "API.PA_AporteProductoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AporteProducto  ->" + ex.Message);
				}
			}

			public AporteProducto Add(AporteProducto pAporteProducto)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAporteProducto.id==null ? 0 : pAporteProducto.id);
p.Add("@ID_Producto",pAporteProducto.ID_Producto==null ? 0 : pAporteProducto.ID_Producto);
p.Add("@ID_TipoNivelEducativo",pAporteProducto.ID_TipoNivelEducativo==null ? 0 : pAporteProducto.ID_TipoNivelEducativo);
                    p.Add("@PesoBruto", pAporteProducto.PesoBruto);
                    p.Add("@PesoNeto", pAporteProducto.PesoNeto);
                    p.Add("@PorcentajeComestible", pAporteProducto.PorcentajeComestible);
                    p.Add("@IntercambioEstandarizado", pAporteProducto.IntercambioEstandarizado);
                    p.Add("@auditoria", pAporteProducto.auditoria);

                         


                    AporteProducto o = SqlMapper.QueryFirstOrDefault<AporteProducto>(con, "API.PA_AporteProductoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AporteProducto  ->" + ex.Message);
				}
			}

			public AporteProducto  Update(AporteProducto pAporteProducto)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAporteProducto.id==null ? 0 : pAporteProducto.id);
p.Add("@ID_Producto",pAporteProducto.ID_Producto==null ? 0 : pAporteProducto.ID_Producto);
p.Add("@ID_TipoNivelEducativo",pAporteProducto.ID_TipoNivelEducativo==null ? 0 : pAporteProducto.ID_TipoNivelEducativo);
                    p.Add("@PesoBruto", pAporteProducto.PesoBruto);
                    p.Add("@PesoNeto", pAporteProducto.PesoNeto);
                    p.Add("@PorcentajeComestible", pAporteProducto.PorcentajeComestible);
                    p.Add("@IntercambioEstandarizado", pAporteProducto.IntercambioEstandarizado);
                    p.Add("@auditoria", pAporteProducto.auditoria);

                         


                    AporteProducto o = SqlMapper.QueryFirstOrDefault<AporteProducto>(con, "API.PA_AporteProductoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AporteProducto  ->" + ex.Message);
				}
			}

			public bool Delete(AporteProducto pAporteProducto)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAporteProducto.id);
                    p.Add("@auditoria", pAporteProducto.auditoria);

                

 

					AporteProducto o = SqlMapper.QueryFirstOrDefault<AporteProducto>(con, "API.PA_AporteProductoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AporteProducto  ->" + ex.Message);
				}
			}

		



            public List<AporteProducto> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AporteProducto> AporteProductoList = new List<AporteProducto>();

                    AporteProductoList = SqlMapper.Query<AporteProducto>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AporteProductoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AporteProducto  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AporteProducto> b)
            {
                DapperPlusManager.Entity<AporteProducto>().Table("AporteProducto");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}