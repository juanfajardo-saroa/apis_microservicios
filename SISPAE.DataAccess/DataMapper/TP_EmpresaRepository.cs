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
     /// Clase Abstracta para  TP_Empresa
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TP_EmpresaRepository : DataObject , ITP_Empresa 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TP_EmpresaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TP_EmpresaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TP_Empresa GetById(TP_Empresa pTP_Empresa)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTP_Empresa.id);                                    


    				TP_Empresa o = SqlMapper.QueryFirstOrDefault<TP_Empresa>(con, "API.PA_TP_EmpresaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TP_Empresa  ->" + ex.Message);
				}
			}

			public List<TP_Empresa> GetAll()
			{
				try 
                {
                        List<TP_Empresa> l = SqlMapper.Query<TP_Empresa>(con, "API.PA_TP_EmpresaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TP_Empresa  ->" + ex.Message);
				}
			}

			public List<TP_Empresa> GetAllFull()
			{
				try 
				{
                    List<TP_Empresa> l = SqlMapper.Query<TP_Empresa>(con, "API.PA_TP_EmpresaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TP_Empresa  ->" + ex.Message);
				}
			}
			
			public List<TP_Empresa> GetAllByWithRelation()
			{
				try 
                {
                    List<TP_Empresa> l = SqlMapper.Query<TP_Empresa>(con, "API.PA_TP_EmpresaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TP_Empresa  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TP_Empresa> GetByFilter(TP_Empresa pTP_Empresa, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTP_Empresa.id== null || pTP_Empresa.id==0) ? vintNUll :pTP_Empresa.id);
                    p.Add("@Nombre", pTP_Empresa.Nombre);
                    p.Add("@Slogan", pTP_Empresa.Slogan);
                    p.Add("@Logo", pTP_Empresa.Logo);
p.Add("@ZeroFill",pTP_Empresa.ZeroFill==0 ? vintNUll : pTP_Empresa.ZeroFill);
                    p.Add("@HostMail", pTP_Empresa.HostMail);
                    p.Add("@UserFrom", pTP_Empresa.UserFrom);
                    p.Add("@FromPassword", pTP_Empresa.FromPassword);
                    p.Add("@PuertoMail", pTP_Empresa.PuertoMail);
                    p.Add("@PlantillaAsignacion", pTP_Empresa.PlantillaAsignacion);
                    p.Add("@PlantillaFinProceso", pTP_Empresa.PlantillaFinProceso);
                    p.Add("@PlantillaAlerta", pTP_Empresa.PlantillaAlerta);
                    p.Add("@urlDrive", pTP_Empresa.urlDrive);
                    p.Add("@keyDrive", pTP_Empresa.keyDrive);
                    p.Add("@usrDrive", pTP_Empresa.usrDrive);
                    p.Add("@pwdDrive", pTP_Empresa.pwdDrive);
                    p.Add("@SSLEnabled", pTP_Empresa.SSLEnabled);
                    p.Add("@TieneDoc4us", pTP_Empresa.TieneDoc4us);
                    p.Add("@TieneOpe", pTP_Empresa.TieneOpe);
                    p.Add("@TieneFirma", pTP_Empresa.TieneFirma);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TP_Empresa> l = SqlMapper.Query<TP_Empresa>(con, "API.PA_TP_EmpresaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TP_Empresa  ->" + ex.Message);
				}
			}

			public TP_Empresa Add(TP_Empresa pTP_Empresa)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTP_Empresa.id== null ? 0: pTP_Empresa.id);
                    p.Add("@Nombre", pTP_Empresa.Nombre);
                    p.Add("@Slogan", pTP_Empresa.Slogan);
                    p.Add("@Logo", pTP_Empresa.Logo);
p.Add("@ZeroFill",pTP_Empresa.ZeroFill==null ? 0 : pTP_Empresa.ZeroFill);
                    p.Add("@HostMail", pTP_Empresa.HostMail);
                    p.Add("@UserFrom", pTP_Empresa.UserFrom);
                    p.Add("@FromPassword", pTP_Empresa.FromPassword);
                    p.Add("@PuertoMail", pTP_Empresa.PuertoMail);
                    p.Add("@PlantillaAsignacion", pTP_Empresa.PlantillaAsignacion);
                    p.Add("@PlantillaFinProceso", pTP_Empresa.PlantillaFinProceso);
                    p.Add("@PlantillaAlerta", pTP_Empresa.PlantillaAlerta);
                    p.Add("@urlDrive", pTP_Empresa.urlDrive);
                    p.Add("@keyDrive", pTP_Empresa.keyDrive);
                    p.Add("@usrDrive", pTP_Empresa.usrDrive);
                    p.Add("@pwdDrive", pTP_Empresa.pwdDrive);
                    p.Add("@SSLEnabled", pTP_Empresa.SSLEnabled);
                    p.Add("@TieneDoc4us", pTP_Empresa.TieneDoc4us);
                    p.Add("@TieneOpe", pTP_Empresa.TieneOpe);
                    p.Add("@TieneFirma", pTP_Empresa.TieneFirma);
                    p.Add("@auditoria", pTP_Empresa.auditoria);

                         


                    TP_Empresa o = SqlMapper.QueryFirstOrDefault<TP_Empresa>(con, "API.PA_TP_EmpresaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TP_Empresa  ->" + ex.Message);
				}
			}

			public TP_Empresa  Update(TP_Empresa pTP_Empresa)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTP_Empresa.id== null ? 0: pTP_Empresa.id);
                    p.Add("@Nombre", pTP_Empresa.Nombre);
                    p.Add("@Slogan", pTP_Empresa.Slogan);
                    p.Add("@Logo", pTP_Empresa.Logo);
p.Add("@ZeroFill",pTP_Empresa.ZeroFill==null ? 0 : pTP_Empresa.ZeroFill);
                    p.Add("@HostMail", pTP_Empresa.HostMail);
                    p.Add("@UserFrom", pTP_Empresa.UserFrom);
                    p.Add("@FromPassword", pTP_Empresa.FromPassword);
                    p.Add("@PuertoMail", pTP_Empresa.PuertoMail);
                    p.Add("@PlantillaAsignacion", pTP_Empresa.PlantillaAsignacion);
                    p.Add("@PlantillaFinProceso", pTP_Empresa.PlantillaFinProceso);
                    p.Add("@PlantillaAlerta", pTP_Empresa.PlantillaAlerta);
                    p.Add("@urlDrive", pTP_Empresa.urlDrive);
                    p.Add("@keyDrive", pTP_Empresa.keyDrive);
                    p.Add("@usrDrive", pTP_Empresa.usrDrive);
                    p.Add("@pwdDrive", pTP_Empresa.pwdDrive);
                    p.Add("@SSLEnabled", pTP_Empresa.SSLEnabled);
                    p.Add("@TieneDoc4us", pTP_Empresa.TieneDoc4us);
                    p.Add("@TieneOpe", pTP_Empresa.TieneOpe);
                    p.Add("@TieneFirma", pTP_Empresa.TieneFirma);
                    p.Add("@auditoria", pTP_Empresa.auditoria);

                         


                    TP_Empresa o = SqlMapper.QueryFirstOrDefault<TP_Empresa>(con, "API.PA_TP_EmpresaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TP_Empresa  ->" + ex.Message);
				}
			}

			public bool Delete(TP_Empresa pTP_Empresa)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTP_Empresa.id);
                    p.Add("@auditoria", pTP_Empresa.auditoria);

                

 

					TP_Empresa o = SqlMapper.QueryFirstOrDefault<TP_Empresa>(con, "API.PA_TP_EmpresaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TP_Empresa  ->" + ex.Message);
				}
			}

		



            public List<TP_Empresa> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TP_Empresa> TP_EmpresaList = new List<TP_Empresa>();

                    TP_EmpresaList = SqlMapper.Query<TP_Empresa>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TP_EmpresaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TP_Empresa  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TP_Empresa> b)
            {
                DapperPlusManager.Entity<TP_Empresa>().Table("TP_Empresa");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}