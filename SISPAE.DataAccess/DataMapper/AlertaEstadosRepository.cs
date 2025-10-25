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
     /// Clase Abstracta para  AlertaEstados
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AlertaEstadosRepository : DataObject , IAlertaEstados 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AlertaEstadosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AlertaEstadosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AlertaEstados GetById(AlertaEstados pAlertaEstados)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAlertaEstados.id);                                    


    				AlertaEstados o = SqlMapper.QueryFirstOrDefault<AlertaEstados>(con, "API.PA_AlertaEstadosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AlertaEstados  ->" + ex.Message);
				}
			}

			public List<AlertaEstados> GetAll()
			{
				try 
                {
                        List<AlertaEstados> l = SqlMapper.Query<AlertaEstados>(con, "API.PA_AlertaEstadosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AlertaEstados  ->" + ex.Message);
				}
			}

			public List<AlertaEstados> GetAllFull()
			{
				try 
				{
                    List<AlertaEstados> l = SqlMapper.Query<AlertaEstados>(con, "API.PA_AlertaEstadosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AlertaEstados  ->" + ex.Message);
				}
			}
			
			public List<AlertaEstados> GetAllByWithRelation()
			{
				try 
                {
                    List<AlertaEstados> l = SqlMapper.Query<AlertaEstados>(con, "API.PA_AlertaEstadosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AlertaEstados  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AlertaEstados> GetByFilter(AlertaEstados pAlertaEstados, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAlertaEstados.id== null || pAlertaEstados.id==0) ? vintNUll :pAlertaEstados.id);
                    p.Add("@Nombre",(pAlertaEstados.Nombre== null) ? vintNUll :pAlertaEstados.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AlertaEstados> l = SqlMapper.Query<AlertaEstados>(con, "API.PA_AlertaEstadosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AlertaEstados  ->" + ex.Message);
				}
			}

			public AlertaEstados Add(AlertaEstados pAlertaEstados)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAlertaEstados.id==null ? 0 : pAlertaEstados.id);
                    p.Add("@Nombre", pAlertaEstados.Nombre);
                    p.Add("@auditoria", pAlertaEstados.auditoria);

                         


                    AlertaEstados o = SqlMapper.QueryFirstOrDefault<AlertaEstados>(con, "API.PA_AlertaEstadosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AlertaEstados  ->" + ex.Message);
				}
			}

			public AlertaEstados  Update(AlertaEstados pAlertaEstados)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAlertaEstados.id==null ? 0 : pAlertaEstados.id);
                    p.Add("@Nombre", pAlertaEstados.Nombre);
                    p.Add("@auditoria", pAlertaEstados.auditoria);

                         


                    AlertaEstados o = SqlMapper.QueryFirstOrDefault<AlertaEstados>(con, "API.PA_AlertaEstadosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AlertaEstados  ->" + ex.Message);
				}
			}

			public bool Delete(AlertaEstados pAlertaEstados)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAlertaEstados.id);
                    p.Add("@auditoria", pAlertaEstados.auditoria);

                

 

					AlertaEstados o = SqlMapper.QueryFirstOrDefault<AlertaEstados>(con, "API.PA_AlertaEstadosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AlertaEstados  ->" + ex.Message);
				}
			}

		



            public List<AlertaEstados> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AlertaEstados> AlertaEstadosList = new List<AlertaEstados>();

                    AlertaEstadosList = SqlMapper.Query<AlertaEstados>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AlertaEstadosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AlertaEstados  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AlertaEstados> b)
            {
                DapperPlusManager.Entity<AlertaEstados>().Table("AlertaEstados");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}