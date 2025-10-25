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
     /// Clase Abstracta para  AlertasUsuario
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AlertasUsuarioRepository : DataObject , IAlertasUsuario 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AlertasUsuarioRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AlertasUsuarioRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AlertasUsuario GetById(AlertasUsuario pAlertasUsuario)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
                                    


    				AlertasUsuario o = SqlMapper.QueryFirstOrDefault<AlertasUsuario>(con, "API.PA_AlertasUsuarioGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AlertasUsuario  ->" + ex.Message);
				}
			}

			public List<AlertasUsuario> GetAll()
			{
				try 
                {
                        List<AlertasUsuario> l = SqlMapper.Query<AlertasUsuario>(con, "API.PA_AlertasUsuarioGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AlertasUsuario  ->" + ex.Message);
				}
			}

			public List<AlertasUsuario> GetAllFull()
			{
				try 
				{
                    List<AlertasUsuario> l = SqlMapper.Query<AlertasUsuario>(con, "API.PA_AlertasUsuarioGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AlertasUsuario  ->" + ex.Message);
				}
			}
			
			public List<AlertasUsuario> GetAllByWithRelation()
			{
				try 
                {
                    List<AlertasUsuario> l = SqlMapper.Query<AlertasUsuario>(con, "API.PA_AlertasUsuarioGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AlertasUsuario  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AlertasUsuario> GetByFilter(AlertasUsuario pAlertasUsuario, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAlertasUsuario.id== null || pAlertasUsuario.id==0) ? vintNUll :pAlertasUsuario.id);
                    p.Add("@ID_Alerta",(pAlertasUsuario.ID_Alerta== null || pAlertasUsuario.ID_Alerta==0) ? vintNUll :pAlertasUsuario.ID_Alerta);
                    p.Add("@ID_User",(pAlertasUsuario.ID_User== null) ? vintNUll :pAlertasUsuario.ID_User);
                    p.Add("@ID_AlertaEstado",(pAlertasUsuario.ID_AlertaEstado== null || pAlertasUsuario.ID_AlertaEstado==0) ? vintNUll :pAlertasUsuario.ID_AlertaEstado);
                    p.Add("@FechaCambio",(pAlertasUsuario.FechaCambio== null) ? vintNUll :pAlertasUsuario.FechaCambio);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AlertasUsuario> l = SqlMapper.Query<AlertasUsuario>(con, "API.PA_AlertasUsuarioGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AlertasUsuario  ->" + ex.Message);
				}
			}

			public AlertasUsuario Add(AlertasUsuario pAlertasUsuario)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAlertasUsuario.id==null ? 0 : pAlertasUsuario.id);
p.Add("@ID_Alerta",pAlertasUsuario.ID_Alerta==null ? 0 : pAlertasUsuario.ID_Alerta);
                    p.Add("@ID_User", pAlertasUsuario.ID_User);
p.Add("@ID_AlertaEstado",pAlertasUsuario.ID_AlertaEstado==null ? 0 : pAlertasUsuario.ID_AlertaEstado);
                    p.Add("@FechaCambio", pAlertasUsuario.FechaCambio);
                    p.Add("@auditoria", pAlertasUsuario.auditoria);

                         


                    AlertasUsuario o = SqlMapper.QueryFirstOrDefault<AlertasUsuario>(con, "API.PA_AlertasUsuarioAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AlertasUsuario  ->" + ex.Message);
				}
			}

			public AlertasUsuario  Update(AlertasUsuario pAlertasUsuario)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAlertasUsuario.id==null ? 0 : pAlertasUsuario.id);
p.Add("@ID_Alerta",pAlertasUsuario.ID_Alerta==null ? 0 : pAlertasUsuario.ID_Alerta);
                    p.Add("@ID_User", pAlertasUsuario.ID_User);
p.Add("@ID_AlertaEstado",pAlertasUsuario.ID_AlertaEstado==null ? 0 : pAlertasUsuario.ID_AlertaEstado);
                    p.Add("@FechaCambio", pAlertasUsuario.FechaCambio);
                    p.Add("@auditoria", pAlertasUsuario.auditoria);

                         


                    AlertasUsuario o = SqlMapper.QueryFirstOrDefault<AlertasUsuario>(con, "API.PA_AlertasUsuarioUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AlertasUsuario  ->" + ex.Message);
				}
			}

			public bool Delete(AlertasUsuario pAlertasUsuario)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
                    p.Add("@auditoria", pAlertasUsuario.auditoria);

                

 

					AlertasUsuario o = SqlMapper.QueryFirstOrDefault<AlertasUsuario>(con, "API.PA_AlertasUsuarioDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AlertasUsuario  ->" + ex.Message);
				}
			}

		



            public List<AlertasUsuario> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AlertasUsuario> AlertasUsuarioList = new List<AlertasUsuario>();

                    AlertasUsuarioList = SqlMapper.Query<AlertasUsuario>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AlertasUsuarioList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AlertasUsuario  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AlertasUsuario> b)
            {
                DapperPlusManager.Entity<AlertasUsuario>().Table("AlertasUsuario");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}