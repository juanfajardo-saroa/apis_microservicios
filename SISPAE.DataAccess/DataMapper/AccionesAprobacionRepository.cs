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
     /// Clase Abstracta para  AccionesAprobacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AccionesAprobacionRepository : DataObject , IAccionesAprobacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AccionesAprobacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AccionesAprobacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AccionesAprobacion GetById(AccionesAprobacion pAccionesAprobacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAccionesAprobacion.id);                                    


    				AccionesAprobacion o = SqlMapper.QueryFirstOrDefault<AccionesAprobacion>(con, "API.PA_AccionesAprobacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AccionesAprobacion  ->" + ex.Message);
				}
			}

			public List<AccionesAprobacion> GetAll()
			{
				try 
                {
                        List<AccionesAprobacion> l = SqlMapper.Query<AccionesAprobacion>(con, "API.PA_AccionesAprobacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AccionesAprobacion  ->" + ex.Message);
				}
			}

			public List<AccionesAprobacion> GetAllFull()
			{
				try 
				{
                    List<AccionesAprobacion> l = SqlMapper.Query<AccionesAprobacion>(con, "API.PA_AccionesAprobacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AccionesAprobacion  ->" + ex.Message);
				}
			}
			
			public List<AccionesAprobacion> GetAllByWithRelation()
			{
				try 
                {
                    List<AccionesAprobacion> l = SqlMapper.Query<AccionesAprobacion>(con, "API.PA_AccionesAprobacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AccionesAprobacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AccionesAprobacion> GetByFilter(AccionesAprobacion pAccionesAprobacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAccionesAprobacion.id== null || pAccionesAprobacion.id==0) ? vintNUll :pAccionesAprobacion.id);
                    p.Add("@Nombre",(pAccionesAprobacion.Nombre== null) ? vintNUll :pAccionesAprobacion.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AccionesAprobacion> l = SqlMapper.Query<AccionesAprobacion>(con, "API.PA_AccionesAprobacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AccionesAprobacion  ->" + ex.Message);
				}
			}

			public AccionesAprobacion Add(AccionesAprobacion pAccionesAprobacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAccionesAprobacion.id==null ? 0 : pAccionesAprobacion.id);
                    p.Add("@Nombre", pAccionesAprobacion.Nombre);
                    p.Add("@auditoria", pAccionesAprobacion.auditoria);

                         


                    AccionesAprobacion o = SqlMapper.QueryFirstOrDefault<AccionesAprobacion>(con, "API.PA_AccionesAprobacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AccionesAprobacion  ->" + ex.Message);
				}
			}

			public AccionesAprobacion  Update(AccionesAprobacion pAccionesAprobacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAccionesAprobacion.id==null ? 0 : pAccionesAprobacion.id);
                    p.Add("@Nombre", pAccionesAprobacion.Nombre);
                    p.Add("@auditoria", pAccionesAprobacion.auditoria);

                         


                    AccionesAprobacion o = SqlMapper.QueryFirstOrDefault<AccionesAprobacion>(con, "API.PA_AccionesAprobacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AccionesAprobacion  ->" + ex.Message);
				}
			}

			public bool Delete(AccionesAprobacion pAccionesAprobacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAccionesAprobacion.id);
                    p.Add("@auditoria", pAccionesAprobacion.auditoria);

                

 

					AccionesAprobacion o = SqlMapper.QueryFirstOrDefault<AccionesAprobacion>(con, "API.PA_AccionesAprobacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AccionesAprobacion  ->" + ex.Message);
				}
			}

		



            public List<AccionesAprobacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AccionesAprobacion> AccionesAprobacionList = new List<AccionesAprobacion>();

                    AccionesAprobacionList = SqlMapper.Query<AccionesAprobacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AccionesAprobacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AccionesAprobacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AccionesAprobacion> b)
            {
                DapperPlusManager.Entity<AccionesAprobacion>().Table("AccionesAprobacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}