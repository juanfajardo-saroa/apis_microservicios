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
     /// Clase Abstracta para  NutrientesProducto
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class NutrientesProductoRepository : DataObject , INutrientesProducto 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public NutrientesProductoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public NutrientesProductoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public NutrientesProducto GetById(NutrientesProducto pNutrientesProducto)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pNutrientesProducto.id);                                    


    				NutrientesProducto o = SqlMapper.QueryFirstOrDefault<NutrientesProducto>(con, "API.PA_NutrientesProductoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  NutrientesProducto  ->" + ex.Message);
				}
			}

			public List<NutrientesProducto> GetAll()
			{
				try 
                {
                        List<NutrientesProducto> l = SqlMapper.Query<NutrientesProducto>(con, "API.PA_NutrientesProductoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  NutrientesProducto  ->" + ex.Message);
				}
			}

			public List<NutrientesProducto> GetAllFull()
			{
				try 
				{
                    List<NutrientesProducto> l = SqlMapper.Query<NutrientesProducto>(con, "API.PA_NutrientesProductoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  NutrientesProducto  ->" + ex.Message);
				}
			}
			
			public List<NutrientesProducto> GetAllByWithRelation()
			{
				try 
                {
                    List<NutrientesProducto> l = SqlMapper.Query<NutrientesProducto>(con, "API.PA_NutrientesProductoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  NutrientesProducto  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<NutrientesProducto> GetByFilter(NutrientesProducto pNutrientesProducto, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pNutrientesProducto.id== null || pNutrientesProducto.id==0) ? vintNUll :pNutrientesProducto.id);
                    p.Add("@ID_Nutriente",(pNutrientesProducto.ID_Nutriente== null || pNutrientesProducto.ID_Nutriente==0) ? vintNUll :pNutrientesProducto.ID_Nutriente);
                    p.Add("@ID_AporteProducto",(pNutrientesProducto.ID_AporteProducto== null || pNutrientesProducto.ID_AporteProducto==0) ? vintNUll :pNutrientesProducto.ID_AporteProducto);
                    p.Add("@Aporte",(pNutrientesProducto.Aporte== null) ? vintNUll :pNutrientesProducto.Aporte);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<NutrientesProducto> l = SqlMapper.Query<NutrientesProducto>(con, "API.PA_NutrientesProductoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  NutrientesProducto  ->" + ex.Message);
				}
			}

			public NutrientesProducto Add(NutrientesProducto pNutrientesProducto)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pNutrientesProducto.id==null ? 0 : pNutrientesProducto.id);
p.Add("@ID_Nutriente",pNutrientesProducto.ID_Nutriente==null ? 0 : pNutrientesProducto.ID_Nutriente);
p.Add("@ID_AporteProducto",pNutrientesProducto.ID_AporteProducto==null ? 0 : pNutrientesProducto.ID_AporteProducto);
                    p.Add("@Aporte", pNutrientesProducto.Aporte);
                    p.Add("@auditoria", pNutrientesProducto.auditoria);

                         


                    NutrientesProducto o = SqlMapper.QueryFirstOrDefault<NutrientesProducto>(con, "API.PA_NutrientesProductoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  NutrientesProducto  ->" + ex.Message);
				}
			}

			public NutrientesProducto  Update(NutrientesProducto pNutrientesProducto)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pNutrientesProducto.id==null ? 0 : pNutrientesProducto.id);
p.Add("@ID_Nutriente",pNutrientesProducto.ID_Nutriente==null ? 0 : pNutrientesProducto.ID_Nutriente);
p.Add("@ID_AporteProducto",pNutrientesProducto.ID_AporteProducto==null ? 0 : pNutrientesProducto.ID_AporteProducto);
                    p.Add("@Aporte", pNutrientesProducto.Aporte);
                    p.Add("@auditoria", pNutrientesProducto.auditoria);

                         


                    NutrientesProducto o = SqlMapper.QueryFirstOrDefault<NutrientesProducto>(con, "API.PA_NutrientesProductoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  NutrientesProducto  ->" + ex.Message);
				}
			}

			public bool Delete(NutrientesProducto pNutrientesProducto)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pNutrientesProducto.id);
                    p.Add("@auditoria", pNutrientesProducto.auditoria);

                

 

					NutrientesProducto o = SqlMapper.QueryFirstOrDefault<NutrientesProducto>(con, "API.PA_NutrientesProductoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) NutrientesProducto  ->" + ex.Message);
				}
			}

		



            public List<NutrientesProducto> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<NutrientesProducto> NutrientesProductoList = new List<NutrientesProducto>();

                    NutrientesProductoList = SqlMapper.Query<NutrientesProducto>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return NutrientesProductoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) NutrientesProducto  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<NutrientesProducto> b)
            {
                DapperPlusManager.Entity<NutrientesProducto>().Table("NutrientesProducto");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}