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
     /// Clase Abstracta para  ComponentesPreparacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ComponentesPreparacionRepository : DataObject , IComponentesPreparacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ComponentesPreparacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ComponentesPreparacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ComponentesPreparacion GetById(ComponentesPreparacion pComponentesPreparacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pComponentesPreparacion.id);                                    


    				ComponentesPreparacion o = SqlMapper.QueryFirstOrDefault<ComponentesPreparacion>(con, "API.PA_ComponentesPreparacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ComponentesPreparacion  ->" + ex.Message);
				}
			}

			public List<ComponentesPreparacion> GetAll()
			{
				try 
                {
                        List<ComponentesPreparacion> l = SqlMapper.Query<ComponentesPreparacion>(con, "API.PA_ComponentesPreparacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ComponentesPreparacion  ->" + ex.Message);
				}
			}

			public List<ComponentesPreparacion> GetAllFull()
			{
				try 
				{
                    List<ComponentesPreparacion> l = SqlMapper.Query<ComponentesPreparacion>(con, "API.PA_ComponentesPreparacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ComponentesPreparacion  ->" + ex.Message);
				}
			}
			
			public List<ComponentesPreparacion> GetAllByWithRelation()
			{
				try 
                {
                    List<ComponentesPreparacion> l = SqlMapper.Query<ComponentesPreparacion>(con, "API.PA_ComponentesPreparacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ComponentesPreparacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ComponentesPreparacion> GetByFilter(ComponentesPreparacion pComponentesPreparacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pComponentesPreparacion.id== null || pComponentesPreparacion.id==0) ? vintNUll :pComponentesPreparacion.id);
                    p.Add("@ID_Preparacion",(pComponentesPreparacion.ID_Preparacion== null || pComponentesPreparacion.ID_Preparacion==0) ? vintNUll :pComponentesPreparacion.ID_Preparacion);
                    p.Add("@ID_TipoComponente",(pComponentesPreparacion.ID_TipoComponente== null || pComponentesPreparacion.ID_TipoComponente==0) ? vintNUll :pComponentesPreparacion.ID_TipoComponente);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ComponentesPreparacion> l = SqlMapper.Query<ComponentesPreparacion>(con, "API.PA_ComponentesPreparacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ComponentesPreparacion  ->" + ex.Message);
				}
			}

			public ComponentesPreparacion Add(ComponentesPreparacion pComponentesPreparacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pComponentesPreparacion.id==null ? 0 : pComponentesPreparacion.id);
p.Add("@ID_Preparacion",pComponentesPreparacion.ID_Preparacion==null ? 0 : pComponentesPreparacion.ID_Preparacion);
p.Add("@ID_TipoComponente",pComponentesPreparacion.ID_TipoComponente==null ? 0 : pComponentesPreparacion.ID_TipoComponente);
                    p.Add("@auditoria", pComponentesPreparacion.auditoria);

                         


                    ComponentesPreparacion o = SqlMapper.QueryFirstOrDefault<ComponentesPreparacion>(con, "API.PA_ComponentesPreparacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ComponentesPreparacion  ->" + ex.Message);
				}
			}

			public ComponentesPreparacion  Update(ComponentesPreparacion pComponentesPreparacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pComponentesPreparacion.id==null ? 0 : pComponentesPreparacion.id);
p.Add("@ID_Preparacion",pComponentesPreparacion.ID_Preparacion==null ? 0 : pComponentesPreparacion.ID_Preparacion);
p.Add("@ID_TipoComponente",pComponentesPreparacion.ID_TipoComponente==null ? 0 : pComponentesPreparacion.ID_TipoComponente);
                    p.Add("@auditoria", pComponentesPreparacion.auditoria);

                         


                    ComponentesPreparacion o = SqlMapper.QueryFirstOrDefault<ComponentesPreparacion>(con, "API.PA_ComponentesPreparacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ComponentesPreparacion  ->" + ex.Message);
				}
			}

			public bool Delete(ComponentesPreparacion pComponentesPreparacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pComponentesPreparacion.id);
                    p.Add("@auditoria", pComponentesPreparacion.auditoria);

                

 

					ComponentesPreparacion o = SqlMapper.QueryFirstOrDefault<ComponentesPreparacion>(con, "API.PA_ComponentesPreparacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ComponentesPreparacion  ->" + ex.Message);
				}
			}

		



            public List<ComponentesPreparacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ComponentesPreparacion> ComponentesPreparacionList = new List<ComponentesPreparacion>();

                    ComponentesPreparacionList = SqlMapper.Query<ComponentesPreparacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ComponentesPreparacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ComponentesPreparacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ComponentesPreparacion> b)
            {
                DapperPlusManager.Entity<ComponentesPreparacion>().Table("ComponentesPreparacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}