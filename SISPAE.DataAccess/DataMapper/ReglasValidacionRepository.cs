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
     /// Clase Abstracta para  ReglasValidacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ReglasValidacionRepository : DataObject , IReglasValidacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ReglasValidacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ReglasValidacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ReglasValidacion GetById(ReglasValidacion pReglasValidacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pReglasValidacion.id);                                    


    				ReglasValidacion o = SqlMapper.QueryFirstOrDefault<ReglasValidacion>(con, "API.PA_ReglasValidacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ReglasValidacion  ->" + ex.Message);
				}
			}

			public List<ReglasValidacion> GetAll()
			{
				try 
                {
                        List<ReglasValidacion> l = SqlMapper.Query<ReglasValidacion>(con, "API.PA_ReglasValidacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ReglasValidacion  ->" + ex.Message);
				}
			}

			public List<ReglasValidacion> GetAllFull()
			{
				try 
				{
                    List<ReglasValidacion> l = SqlMapper.Query<ReglasValidacion>(con, "API.PA_ReglasValidacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ReglasValidacion  ->" + ex.Message);
				}
			}
			
			public List<ReglasValidacion> GetAllByWithRelation()
			{
				try 
                {
                    List<ReglasValidacion> l = SqlMapper.Query<ReglasValidacion>(con, "API.PA_ReglasValidacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ReglasValidacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ReglasValidacion> GetByFilter(ReglasValidacion pReglasValidacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pReglasValidacion.id== null || pReglasValidacion.id==0) ? vintNUll :pReglasValidacion.id);
                    p.Add("@ID_MinutaPatronAlimento",(pReglasValidacion.ID_MinutaPatronAlimento== null || pReglasValidacion.ID_MinutaPatronAlimento==0) ? vintNUll :pReglasValidacion.ID_MinutaPatronAlimento);
                    p.Add("@Regla",(pReglasValidacion.Regla== null) ? vintNUll :pReglasValidacion.Regla);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ReglasValidacion> l = SqlMapper.Query<ReglasValidacion>(con, "API.PA_ReglasValidacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ReglasValidacion  ->" + ex.Message);
				}
			}

			public ReglasValidacion Add(ReglasValidacion pReglasValidacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pReglasValidacion.id==null ? 0 : pReglasValidacion.id);
p.Add("@ID_MinutaPatronAlimento",pReglasValidacion.ID_MinutaPatronAlimento==null ? 0 : pReglasValidacion.ID_MinutaPatronAlimento);
                    p.Add("@Regla", pReglasValidacion.Regla);
                    p.Add("@auditoria", pReglasValidacion.auditoria);

                         


                    ReglasValidacion o = SqlMapper.QueryFirstOrDefault<ReglasValidacion>(con, "API.PA_ReglasValidacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ReglasValidacion  ->" + ex.Message);
				}
			}

			public ReglasValidacion  Update(ReglasValidacion pReglasValidacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pReglasValidacion.id==null ? 0 : pReglasValidacion.id);
p.Add("@ID_MinutaPatronAlimento",pReglasValidacion.ID_MinutaPatronAlimento==null ? 0 : pReglasValidacion.ID_MinutaPatronAlimento);
                    p.Add("@Regla", pReglasValidacion.Regla);
                    p.Add("@auditoria", pReglasValidacion.auditoria);

                         


                    ReglasValidacion o = SqlMapper.QueryFirstOrDefault<ReglasValidacion>(con, "API.PA_ReglasValidacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ReglasValidacion  ->" + ex.Message);
				}
			}

			public bool Delete(ReglasValidacion pReglasValidacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pReglasValidacion.id);
                    p.Add("@auditoria", pReglasValidacion.auditoria);

                

 

					ReglasValidacion o = SqlMapper.QueryFirstOrDefault<ReglasValidacion>(con, "API.PA_ReglasValidacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ReglasValidacion  ->" + ex.Message);
				}
			}

		



            public List<ReglasValidacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ReglasValidacion> ReglasValidacionList = new List<ReglasValidacion>();

                    ReglasValidacionList = SqlMapper.Query<ReglasValidacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ReglasValidacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ReglasValidacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ReglasValidacion> b)
            {
                DapperPlusManager.Entity<ReglasValidacion>().Table("ReglasValidacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}