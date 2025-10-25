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
     /// Clase Abstracta para  CriteriosPriorizacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CriteriosPriorizacionRepository : DataObject , ICriteriosPriorizacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CriteriosPriorizacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CriteriosPriorizacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CriteriosPriorizacion GetById(CriteriosPriorizacion pCriteriosPriorizacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCriteriosPriorizacion.id);                                    


    				CriteriosPriorizacion o = SqlMapper.QueryFirstOrDefault<CriteriosPriorizacion>(con, "API.PA_CriteriosPriorizacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CriteriosPriorizacion  ->" + ex.Message);
				}
			}

			public List<CriteriosPriorizacion> GetAll()
			{
				try 
                {
                        List<CriteriosPriorizacion> l = SqlMapper.Query<CriteriosPriorizacion>(con, "API.PA_CriteriosPriorizacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CriteriosPriorizacion  ->" + ex.Message);
				}
			}

			public List<CriteriosPriorizacion> GetAllFull()
			{
				try 
				{
                    List<CriteriosPriorizacion> l = SqlMapper.Query<CriteriosPriorizacion>(con, "API.PA_CriteriosPriorizacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CriteriosPriorizacion  ->" + ex.Message);
				}
			}
			
			public List<CriteriosPriorizacion> GetAllByWithRelation()
			{
				try 
                {
                    List<CriteriosPriorizacion> l = SqlMapper.Query<CriteriosPriorizacion>(con, "API.PA_CriteriosPriorizacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CriteriosPriorizacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CriteriosPriorizacion> GetByFilter(CriteriosPriorizacion pCriteriosPriorizacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCriteriosPriorizacion.id== null || pCriteriosPriorizacion.id==0) ? vintNUll :pCriteriosPriorizacion.id);
                    p.Add("@Prioridad",(pCriteriosPriorizacion.Prioridad== null) ? vintNUll :pCriteriosPriorizacion.Prioridad);
                    p.Add("@Nombre",(pCriteriosPriorizacion.Nombre== null) ? vintNUll :pCriteriosPriorizacion.Nombre);
                    p.Add("@Activo",(pCriteriosPriorizacion.Activo== null) ? vintNUll :pCriteriosPriorizacion.Activo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CriteriosPriorizacion> l = SqlMapper.Query<CriteriosPriorizacion>(con, "API.PA_CriteriosPriorizacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CriteriosPriorizacion  ->" + ex.Message);
				}
			}

			public CriteriosPriorizacion Add(CriteriosPriorizacion pCriteriosPriorizacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCriteriosPriorizacion.id==null ? 0 : pCriteriosPriorizacion.id);
p.Add("@Prioridad",pCriteriosPriorizacion.Prioridad==null ? 0 : pCriteriosPriorizacion.Prioridad);
                    p.Add("@Nombre", pCriteriosPriorizacion.Nombre);
                    p.Add("@Activo", pCriteriosPriorizacion.Activo);
                    p.Add("@auditoria", pCriteriosPriorizacion.auditoria);

                         


                    CriteriosPriorizacion o = SqlMapper.QueryFirstOrDefault<CriteriosPriorizacion>(con, "API.PA_CriteriosPriorizacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CriteriosPriorizacion  ->" + ex.Message);
				}
			}

			public CriteriosPriorizacion  Update(CriteriosPriorizacion pCriteriosPriorizacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCriteriosPriorizacion.id==null ? 0 : pCriteriosPriorizacion.id);
p.Add("@Prioridad",pCriteriosPriorizacion.Prioridad==null ? 0 : pCriteriosPriorizacion.Prioridad);
                    p.Add("@Nombre", pCriteriosPriorizacion.Nombre);
                    p.Add("@Activo", pCriteriosPriorizacion.Activo);
                    p.Add("@auditoria", pCriteriosPriorizacion.auditoria);

                         


                    CriteriosPriorizacion o = SqlMapper.QueryFirstOrDefault<CriteriosPriorizacion>(con, "API.PA_CriteriosPriorizacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CriteriosPriorizacion  ->" + ex.Message);
				}
			}

			public bool Delete(CriteriosPriorizacion pCriteriosPriorizacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCriteriosPriorizacion.id);
                    p.Add("@auditoria", pCriteriosPriorizacion.auditoria);

                

 

					CriteriosPriorizacion o = SqlMapper.QueryFirstOrDefault<CriteriosPriorizacion>(con, "API.PA_CriteriosPriorizacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CriteriosPriorizacion  ->" + ex.Message);
				}
			}

		



            public List<CriteriosPriorizacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CriteriosPriorizacion> CriteriosPriorizacionList = new List<CriteriosPriorizacion>();

                    CriteriosPriorizacionList = SqlMapper.Query<CriteriosPriorizacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CriteriosPriorizacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CriteriosPriorizacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CriteriosPriorizacion> b)
            {
                DapperPlusManager.Entity<CriteriosPriorizacion>().Table("CriteriosPriorizacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}