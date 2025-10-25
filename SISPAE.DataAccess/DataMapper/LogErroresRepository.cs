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
     /// Clase Abstracta para  LogErrores
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class LogErroresRepository : DataObject , ILogErrores 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public LogErroresRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public LogErroresRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public LogErrores GetById(LogErrores pLogErrores)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pLogErrores.id);                                    


    				LogErrores o = SqlMapper.QueryFirstOrDefault<LogErrores>(con, "API.PA_LogErroresGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  LogErrores  ->" + ex.Message);
				}
			}

			public List<LogErrores> GetAll()
			{
				try 
                {
                        List<LogErrores> l = SqlMapper.Query<LogErrores>(con, "API.PA_LogErroresGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  LogErrores  ->" + ex.Message);
				}
			}

			public List<LogErrores> GetAllFull()
			{
				try 
				{
                    List<LogErrores> l = SqlMapper.Query<LogErrores>(con, "API.PA_LogErroresGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  LogErrores  ->" + ex.Message);
				}
			}
			
			public List<LogErrores> GetAllByWithRelation()
			{
				try 
                {
                    List<LogErrores> l = SqlMapper.Query<LogErrores>(con, "API.PA_LogErroresGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  LogErrores  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<LogErrores> GetByFilter(LogErrores pLogErrores, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pLogErrores.id== null || pLogErrores.id==0) ? vintNUll :pLogErrores.id);
                    p.Add("@ID_User",(pLogErrores.ID_User== null) ? vintNUll :pLogErrores.ID_User);
                    p.Add("@Fecha",(pLogErrores.Fecha== null) ? vintNUll :pLogErrores.Fecha);
                    p.Add("@Operacion",(pLogErrores.Operacion== null) ? vintNUll :pLogErrores.Operacion);
                    p.Add("@ParametrosOperacion",(pLogErrores.ParametrosOperacion== null) ? vintNUll :pLogErrores.ParametrosOperacion);
                    p.Add("@DetallesError",(pLogErrores.DetallesError== null) ? vintNUll :pLogErrores.DetallesError);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<LogErrores> l = SqlMapper.Query<LogErrores>(con, "API.PA_LogErroresGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  LogErrores  ->" + ex.Message);
				}
			}

			public LogErrores Add(LogErrores pLogErrores)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pLogErrores.id==null ? 0 : pLogErrores.id);
                    p.Add("@ID_User", pLogErrores.ID_User);
                    p.Add("@Fecha", pLogErrores.Fecha);
                    p.Add("@Operacion", pLogErrores.Operacion);
                    p.Add("@ParametrosOperacion", pLogErrores.ParametrosOperacion);
                    p.Add("@DetallesError", pLogErrores.DetallesError);
                    p.Add("@auditoria", pLogErrores.auditoria);

                         


                    LogErrores o = SqlMapper.QueryFirstOrDefault<LogErrores>(con, "API.PA_LogErroresAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  LogErrores  ->" + ex.Message);
				}
			}

			public LogErrores  Update(LogErrores pLogErrores)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pLogErrores.id==null ? 0 : pLogErrores.id);
                    p.Add("@ID_User", pLogErrores.ID_User);
                    p.Add("@Fecha", pLogErrores.Fecha);
                    p.Add("@Operacion", pLogErrores.Operacion);
                    p.Add("@ParametrosOperacion", pLogErrores.ParametrosOperacion);
                    p.Add("@DetallesError", pLogErrores.DetallesError);
                    p.Add("@auditoria", pLogErrores.auditoria);

                         


                    LogErrores o = SqlMapper.QueryFirstOrDefault<LogErrores>(con, "API.PA_LogErroresUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  LogErrores  ->" + ex.Message);
				}
			}

			public bool Delete(LogErrores pLogErrores)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pLogErrores.id);
                    p.Add("@auditoria", pLogErrores.auditoria);

                

 

					LogErrores o = SqlMapper.QueryFirstOrDefault<LogErrores>(con, "API.PA_LogErroresDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) LogErrores  ->" + ex.Message);
				}
			}

		



            public List<LogErrores> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<LogErrores> LogErroresList = new List<LogErrores>();

                    LogErroresList = SqlMapper.Query<LogErrores>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return LogErroresList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) LogErrores  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<LogErrores> b)
            {
                DapperPlusManager.Entity<LogErrores>().Table("LogErrores");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}