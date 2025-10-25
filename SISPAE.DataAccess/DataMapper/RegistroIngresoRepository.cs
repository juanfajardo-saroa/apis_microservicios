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
     /// Clase Abstracta para  RegistroIngreso
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class RegistroIngresoRepository : DataObject , IRegistroIngreso 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public RegistroIngresoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public RegistroIngresoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public RegistroIngreso GetById(RegistroIngreso pRegistroIngreso)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@ID",pRegistroIngreso.ID);                                    


    				RegistroIngreso o = SqlMapper.QueryFirstOrDefault<RegistroIngreso>(con, "API.PA_RegistroIngresoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  RegistroIngreso  ->" + ex.Message);
				}
			}

			public List<RegistroIngreso> GetAll()
			{
				try 
                {
                        List<RegistroIngreso> l = SqlMapper.Query<RegistroIngreso>(con, "API.PA_RegistroIngresoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  RegistroIngreso  ->" + ex.Message);
				}
			}

			public List<RegistroIngreso> GetAllFull()
			{
				try 
				{
                    List<RegistroIngreso> l = SqlMapper.Query<RegistroIngreso>(con, "API.PA_RegistroIngresoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  RegistroIngreso  ->" + ex.Message);
				}
			}
			
			public List<RegistroIngreso> GetAllByWithRelation()
			{
				try 
                {
                    List<RegistroIngreso> l = SqlMapper.Query<RegistroIngreso>(con, "API.PA_RegistroIngresoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  RegistroIngreso  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<RegistroIngreso> GetByFilter(RegistroIngreso pRegistroIngreso, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ID",(pRegistroIngreso.ID== null || pRegistroIngreso.ID==0) ? vintNUll :pRegistroIngreso.ID);
                    p.Add("@Aplicacion",(pRegistroIngreso.Aplicacion== null) ? vintNUll :pRegistroIngreso.Aplicacion);
                    p.Add("@UserId",(pRegistroIngreso.UserId== null) ? vintNUll :pRegistroIngreso.UserId);
                    p.Add("@Fecha",(pRegistroIngreso.Fecha== null) ? vintNUll :pRegistroIngreso.Fecha);
                    p.Add("@Direccionip",(pRegistroIngreso.Direccionip== null) ? vintNUll :pRegistroIngreso.Direccionip);
                    p.Add("@HostNameUsuario",(pRegistroIngreso.HostNameUsuario== null) ? vintNUll :pRegistroIngreso.HostNameUsuario);
                    p.Add("@IPDetrasProxy",(pRegistroIngreso.IPDetrasProxy== null) ? vintNUll :pRegistroIngreso.IPDetrasProxy);
                    p.Add("@Browser",(pRegistroIngreso.Browser== null) ? vintNUll :pRegistroIngreso.Browser);
                    p.Add("@Accion",(pRegistroIngreso.Accion== null) ? vintNUll :pRegistroIngreso.Accion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<RegistroIngreso> l = SqlMapper.Query<RegistroIngreso>(con, "API.PA_RegistroIngresoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  RegistroIngreso  ->" + ex.Message);
				}
			}

			public RegistroIngreso Add(RegistroIngreso pRegistroIngreso)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ID",pRegistroIngreso.ID==null ? 0 : pRegistroIngreso.ID);
                    p.Add("@Aplicacion", pRegistroIngreso.Aplicacion);
                    p.Add("@UserId", pRegistroIngreso.UserId);
                    p.Add("@Fecha", pRegistroIngreso.Fecha);
                    p.Add("@Direccionip", pRegistroIngreso.Direccionip);
                    p.Add("@HostNameUsuario", pRegistroIngreso.HostNameUsuario);
                    p.Add("@IPDetrasProxy", pRegistroIngreso.IPDetrasProxy);
                    p.Add("@Browser", pRegistroIngreso.Browser);
                    p.Add("@Accion", pRegistroIngreso.Accion);
                    p.Add("@auditoria", pRegistroIngreso.auditoria);

                         


                    RegistroIngreso o = SqlMapper.QueryFirstOrDefault<RegistroIngreso>(con, "API.PA_RegistroIngresoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  RegistroIngreso  ->" + ex.Message);
				}
			}

			public RegistroIngreso  Update(RegistroIngreso pRegistroIngreso)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ID",pRegistroIngreso.ID==null ? 0 : pRegistroIngreso.ID);
                    p.Add("@Aplicacion", pRegistroIngreso.Aplicacion);
                    p.Add("@UserId", pRegistroIngreso.UserId);
                    p.Add("@Fecha", pRegistroIngreso.Fecha);
                    p.Add("@Direccionip", pRegistroIngreso.Direccionip);
                    p.Add("@HostNameUsuario", pRegistroIngreso.HostNameUsuario);
                    p.Add("@IPDetrasProxy", pRegistroIngreso.IPDetrasProxy);
                    p.Add("@Browser", pRegistroIngreso.Browser);
                    p.Add("@Accion", pRegistroIngreso.Accion);
                    p.Add("@auditoria", pRegistroIngreso.auditoria);

                         


                    RegistroIngreso o = SqlMapper.QueryFirstOrDefault<RegistroIngreso>(con, "API.PA_RegistroIngresoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  RegistroIngreso  ->" + ex.Message);
				}
			}

			public bool Delete(RegistroIngreso pRegistroIngreso)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@ID",pRegistroIngreso.ID);
                    p.Add("@auditoria", pRegistroIngreso.auditoria);

                

 

					RegistroIngreso o = SqlMapper.QueryFirstOrDefault<RegistroIngreso>(con, "API.PA_RegistroIngresoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) RegistroIngreso  ->" + ex.Message);
				}
			}

		



            public List<RegistroIngreso> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<RegistroIngreso> RegistroIngresoList = new List<RegistroIngreso>();

                    RegistroIngresoList = SqlMapper.Query<RegistroIngreso>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return RegistroIngresoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) RegistroIngreso  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<RegistroIngreso> b)
            {
                DapperPlusManager.Entity<RegistroIngreso>().Table("RegistroIngreso");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}