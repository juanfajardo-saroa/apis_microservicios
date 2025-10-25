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
     /// Clase Abstracta para  ModelosOperacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ModelosOperacionRepository : DataObject , IModelosOperacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ModelosOperacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ModelosOperacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ModelosOperacion GetById(ModelosOperacion pModelosOperacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pModelosOperacion.id);                                    


    				ModelosOperacion o = SqlMapper.QueryFirstOrDefault<ModelosOperacion>(con, "API.PA_ModelosOperacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ModelosOperacion  ->" + ex.Message);
				}
			}

			public List<ModelosOperacion> GetAll()
			{
				try 
                {
                        List<ModelosOperacion> l = SqlMapper.Query<ModelosOperacion>(con, "API.PA_ModelosOperacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ModelosOperacion  ->" + ex.Message);
				}
			}

			public List<ModelosOperacion> GetAllFull()
			{
				try 
				{
                    List<ModelosOperacion> l = SqlMapper.Query<ModelosOperacion>(con, "API.PA_ModelosOperacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ModelosOperacion  ->" + ex.Message);
				}
			}
			
			public List<ModelosOperacion> GetAllByWithRelation()
			{
				try 
                {
                    List<ModelosOperacion> l = SqlMapper.Query<ModelosOperacion>(con, "API.PA_ModelosOperacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ModelosOperacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ModelosOperacion> GetByFilter(ModelosOperacion pModelosOperacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pModelosOperacion.id== null || pModelosOperacion.id==0) ? vintNUll :pModelosOperacion.id);
                    p.Add("@ID_Contrato",(pModelosOperacion.ID_Contrato== null || pModelosOperacion.ID_Contrato==0) ? vintNUll :pModelosOperacion.ID_Contrato);
                    p.Add("@ID_TipoModeloOperacion",(pModelosOperacion.ID_TipoModeloOperacion== null || pModelosOperacion.ID_TipoModeloOperacion==0) ? vintNUll :pModelosOperacion.ID_TipoModeloOperacion);
                    p.Add("@ManejaPreciosporzona",(pModelosOperacion.ManejaPreciosporzona== null) ? vintNUll :pModelosOperacion.ManejaPreciosporzona);
                    p.Add("@ManejaPreciosporNivelEducativo",(pModelosOperacion.ManejaPreciosporNivelEducativo== null) ? vintNUll :pModelosOperacion.ManejaPreciosporNivelEducativo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ModelosOperacion> l = SqlMapper.Query<ModelosOperacion>(con, "API.PA_ModelosOperacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ModelosOperacion  ->" + ex.Message);
				}
			}

			public ModelosOperacion Add(ModelosOperacion pModelosOperacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pModelosOperacion.id==null ? 0 : pModelosOperacion.id);
p.Add("@ID_Contrato",pModelosOperacion.ID_Contrato==null ? 0 : pModelosOperacion.ID_Contrato);
p.Add("@ID_TipoModeloOperacion",pModelosOperacion.ID_TipoModeloOperacion==null ? 0 : pModelosOperacion.ID_TipoModeloOperacion);
                    p.Add("@ManejaPreciosporzona", pModelosOperacion.ManejaPreciosporzona);
                    p.Add("@ManejaPreciosporNivelEducativo", pModelosOperacion.ManejaPreciosporNivelEducativo);
                    p.Add("@auditoria", pModelosOperacion.auditoria);

                         


                    ModelosOperacion o = SqlMapper.QueryFirstOrDefault<ModelosOperacion>(con, "API.PA_ModelosOperacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ModelosOperacion  ->" + ex.Message);
				}
			}

			public ModelosOperacion  Update(ModelosOperacion pModelosOperacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pModelosOperacion.id==null ? 0 : pModelosOperacion.id);
p.Add("@ID_Contrato",pModelosOperacion.ID_Contrato==null ? 0 : pModelosOperacion.ID_Contrato);
p.Add("@ID_TipoModeloOperacion",pModelosOperacion.ID_TipoModeloOperacion==null ? 0 : pModelosOperacion.ID_TipoModeloOperacion);
                    p.Add("@ManejaPreciosporzona", pModelosOperacion.ManejaPreciosporzona);
                    p.Add("@ManejaPreciosporNivelEducativo", pModelosOperacion.ManejaPreciosporNivelEducativo);
                    p.Add("@auditoria", pModelosOperacion.auditoria);

                         


                    ModelosOperacion o = SqlMapper.QueryFirstOrDefault<ModelosOperacion>(con, "API.PA_ModelosOperacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ModelosOperacion  ->" + ex.Message);
				}
			}

			public bool Delete(ModelosOperacion pModelosOperacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pModelosOperacion.id);
                    p.Add("@auditoria", pModelosOperacion.auditoria);

                

 

					ModelosOperacion o = SqlMapper.QueryFirstOrDefault<ModelosOperacion>(con, "API.PA_ModelosOperacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ModelosOperacion  ->" + ex.Message);
				}
			}

		



            public List<ModelosOperacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ModelosOperacion> ModelosOperacionList = new List<ModelosOperacion>();

                    ModelosOperacionList = SqlMapper.Query<ModelosOperacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ModelosOperacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ModelosOperacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ModelosOperacion> b)
            {
                DapperPlusManager.Entity<ModelosOperacion>().Table("ModelosOperacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}