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
     /// Clase Abstracta para  AuditoriaIngreso
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AuditoriaIngresoRepository : DataObject , IAuditoriaIngreso 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AuditoriaIngresoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AuditoriaIngresoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AuditoriaIngreso GetById(AuditoriaIngreso pAuditoriaIngreso)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@ID",pAuditoriaIngreso.ID);                                    


    				AuditoriaIngreso o = SqlMapper.QueryFirstOrDefault<AuditoriaIngreso>(con, "API.PA_AuditoriaIngresoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AuditoriaIngreso  ->" + ex.Message);
				}
			}

			public List<AuditoriaIngreso> GetAll()
			{
				try 
                {
                        List<AuditoriaIngreso> l = SqlMapper.Query<AuditoriaIngreso>(con, "API.PA_AuditoriaIngresoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AuditoriaIngreso  ->" + ex.Message);
				}
			}

			public List<AuditoriaIngreso> GetAllFull()
			{
				try 
				{
                    List<AuditoriaIngreso> l = SqlMapper.Query<AuditoriaIngreso>(con, "API.PA_AuditoriaIngresoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AuditoriaIngreso  ->" + ex.Message);
				}
			}
			
			public List<AuditoriaIngreso> GetAllByWithRelation()
			{
				try 
                {
                    List<AuditoriaIngreso> l = SqlMapper.Query<AuditoriaIngreso>(con, "API.PA_AuditoriaIngresoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AuditoriaIngreso  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AuditoriaIngreso> GetByFilter(AuditoriaIngreso pAuditoriaIngreso, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ID",(pAuditoriaIngreso.ID== null || pAuditoriaIngreso.ID==0) ? vintNUll :pAuditoriaIngreso.ID);
                    p.Add("@Empresa", pAuditoriaIngreso.Empresa);
p.Add("@NombreUsuario",pAuditoriaIngreso.NombreUsuario==0 ? vintNUll : pAuditoriaIngreso.NombreUsuario);
                    p.Add("@Fecha", pAuditoriaIngreso.Fecha);
                    p.Add("@Direccionip", pAuditoriaIngreso.Direccionip);
                    p.Add("@HostNameUsuario", pAuditoriaIngreso.HostNameUsuario);
                    p.Add("@IPDetrasProxy", pAuditoriaIngreso.IPDetrasProxy);
                    p.Add("@Browser", pAuditoriaIngreso.Browser);
                    p.Add("@NombreMaquina", pAuditoriaIngreso.NombreMaquina);
                    p.Add("@Accion", pAuditoriaIngreso.Accion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AuditoriaIngreso> l = SqlMapper.Query<AuditoriaIngreso>(con, "API.PA_AuditoriaIngresoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AuditoriaIngreso  ->" + ex.Message);
				}
			}

			public AuditoriaIngreso Add(AuditoriaIngreso pAuditoriaIngreso)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ID",pAuditoriaIngreso.ID==null ? 0 : pAuditoriaIngreso.ID);
                    p.Add("@Empresa", pAuditoriaIngreso.Empresa);
p.Add("@NombreUsuario",pAuditoriaIngreso.NombreUsuario==null ? 0 : pAuditoriaIngreso.NombreUsuario);
                    p.Add("@Fecha", pAuditoriaIngreso.Fecha);
                    p.Add("@Direccionip", pAuditoriaIngreso.Direccionip);
                    p.Add("@HostNameUsuario", pAuditoriaIngreso.HostNameUsuario);
                    p.Add("@IPDetrasProxy", pAuditoriaIngreso.IPDetrasProxy);
                    p.Add("@Browser", pAuditoriaIngreso.Browser);
                    p.Add("@NombreMaquina", pAuditoriaIngreso.NombreMaquina);
                    p.Add("@Accion", pAuditoriaIngreso.Accion);
                    p.Add("@auditoria", pAuditoriaIngreso.auditoria);

                         


                    AuditoriaIngreso o = SqlMapper.QueryFirstOrDefault<AuditoriaIngreso>(con, "API.PA_AuditoriaIngresoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AuditoriaIngreso  ->" + ex.Message);
				}
			}

			public AuditoriaIngreso  Update(AuditoriaIngreso pAuditoriaIngreso)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ID",pAuditoriaIngreso.ID==null ? 0 : pAuditoriaIngreso.ID);
                    p.Add("@Empresa", pAuditoriaIngreso.Empresa);
p.Add("@NombreUsuario",pAuditoriaIngreso.NombreUsuario==null ? 0 : pAuditoriaIngreso.NombreUsuario);
                    p.Add("@Fecha", pAuditoriaIngreso.Fecha);
                    p.Add("@Direccionip", pAuditoriaIngreso.Direccionip);
                    p.Add("@HostNameUsuario", pAuditoriaIngreso.HostNameUsuario);
                    p.Add("@IPDetrasProxy", pAuditoriaIngreso.IPDetrasProxy);
                    p.Add("@Browser", pAuditoriaIngreso.Browser);
                    p.Add("@NombreMaquina", pAuditoriaIngreso.NombreMaquina);
                    p.Add("@Accion", pAuditoriaIngreso.Accion);
                    p.Add("@auditoria", pAuditoriaIngreso.auditoria);

                         


                    AuditoriaIngreso o = SqlMapper.QueryFirstOrDefault<AuditoriaIngreso>(con, "API.PA_AuditoriaIngresoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AuditoriaIngreso  ->" + ex.Message);
				}
			}

			public bool Delete(AuditoriaIngreso pAuditoriaIngreso)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@ID",pAuditoriaIngreso.ID);
                    p.Add("@auditoria", pAuditoriaIngreso.auditoria);

                

 

					AuditoriaIngreso o = SqlMapper.QueryFirstOrDefault<AuditoriaIngreso>(con, "API.PA_AuditoriaIngresoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AuditoriaIngreso  ->" + ex.Message);
				}
			}

		



            public List<AuditoriaIngreso> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AuditoriaIngreso> AuditoriaIngresoList = new List<AuditoriaIngreso>();

                    AuditoriaIngresoList = SqlMapper.Query<AuditoriaIngreso>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AuditoriaIngresoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AuditoriaIngreso  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AuditoriaIngreso> b)
            {
                DapperPlusManager.Entity<AuditoriaIngreso>().Table("AuditoriaIngreso");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}