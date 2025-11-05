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
     /// Clase Abstracta para  SedesModelosOperacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SedesModelosOperacionRepository : DataObject , ISedesModelosOperacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SedesModelosOperacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SedesModelosOperacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public SedesModelosOperacion GetById(SedesModelosOperacion pSedesModelosOperacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSedesModelosOperacion.id);                                    


    				SedesModelosOperacion o = SqlMapper.QueryFirstOrDefault<SedesModelosOperacion>(con, "API.PA_SedesModelosOperacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  SedesModelosOperacion  ->" + ex.Message);
				}
			}

			public List<SedesModelosOperacion> GetAll()
			{
				try 
                {
                        List<SedesModelosOperacion> l = SqlMapper.Query<SedesModelosOperacion>(con, "API.PA_SedesModelosOperacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  SedesModelosOperacion  ->" + ex.Message);
				}
			}

			public List<SedesModelosOperacion> GetAllFull()
			{
				try 
				{
                    List<SedesModelosOperacion> l = SqlMapper.Query<SedesModelosOperacion>(con, "API.PA_SedesModelosOperacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  SedesModelosOperacion  ->" + ex.Message);
				}
			}
			
			public List<SedesModelosOperacion> GetAllByWithRelation()
			{
				try 
                {
                    List<SedesModelosOperacion> l = SqlMapper.Query<SedesModelosOperacion>(con, "API.PA_SedesModelosOperacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  SedesModelosOperacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<SedesModelosOperacion> GetByFilter(SedesModelosOperacion pSedesModelosOperacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSedesModelosOperacion.id== null || pSedesModelosOperacion.id==0) ? vintNUll :pSedesModelosOperacion.id);
                    p.Add("@ID_sede",(pSedesModelosOperacion.ID_sede== null || pSedesModelosOperacion.ID_sede==0) ? vintNUll :pSedesModelosOperacion.ID_sede);
                    p.Add("@ID_TipoModeloOperacion",(pSedesModelosOperacion.ID_TipoModeloOperacion== null || pSedesModelosOperacion.ID_TipoModeloOperacion==0) ? vintNUll :pSedesModelosOperacion.ID_TipoModeloOperacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<SedesModelosOperacion> l = SqlMapper.Query<SedesModelosOperacion>(con, "API.PA_SedesModelosOperacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  SedesModelosOperacion  ->" + ex.Message);
				}
			}

			public SedesModelosOperacion Add(SedesModelosOperacion pSedesModelosOperacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSedesModelosOperacion.id==null ? 0 : pSedesModelosOperacion.id);
p.Add("@ID_sede",pSedesModelosOperacion.ID_sede==null ? 0 : pSedesModelosOperacion.ID_sede);
p.Add("@ID_TipoModeloOperacion",pSedesModelosOperacion.ID_TipoModeloOperacion==null ? 0 : pSedesModelosOperacion.ID_TipoModeloOperacion);
                    p.Add("@auditoria", pSedesModelosOperacion.auditoria);

                         


                    SedesModelosOperacion o = SqlMapper.QueryFirstOrDefault<SedesModelosOperacion>(con, "API.PA_SedesModelosOperacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  SedesModelosOperacion  ->" + ex.Message);
				}
			}

			public SedesModelosOperacion  Update(SedesModelosOperacion pSedesModelosOperacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSedesModelosOperacion.id==null ? 0 : pSedesModelosOperacion.id);
p.Add("@ID_sede",pSedesModelosOperacion.ID_sede==null ? 0 : pSedesModelosOperacion.ID_sede);
p.Add("@ID_TipoModeloOperacion",pSedesModelosOperacion.ID_TipoModeloOperacion==null ? 0 : pSedesModelosOperacion.ID_TipoModeloOperacion);
                    p.Add("@auditoria", pSedesModelosOperacion.auditoria);

                         


                    SedesModelosOperacion o = SqlMapper.QueryFirstOrDefault<SedesModelosOperacion>(con, "API.PA_SedesModelosOperacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  SedesModelosOperacion  ->" + ex.Message);
				}
			}

			public bool Delete(SedesModelosOperacion pSedesModelosOperacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSedesModelosOperacion.id);
                    p.Add("@auditoria", pSedesModelosOperacion.auditoria);

                

 

					SedesModelosOperacion o = SqlMapper.QueryFirstOrDefault<SedesModelosOperacion>(con, "API.PA_SedesModelosOperacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) SedesModelosOperacion  ->" + ex.Message);
				}
			}

		



            public List<SedesModelosOperacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<SedesModelosOperacion> SedesModelosOperacionList = new List<SedesModelosOperacion>();

                    SedesModelosOperacionList = SqlMapper.Query<SedesModelosOperacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SedesModelosOperacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) SedesModelosOperacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<SedesModelosOperacion> b)
            {
                DapperPlusManager.Entity<SedesModelosOperacion>().Table("SedesModelosOperacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}