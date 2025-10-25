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
     /// Clase Abstracta para  AuditoriaPriorizaciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AuditoriaPriorizacionesRepository : DataObject , IAuditoriaPriorizaciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AuditoriaPriorizacionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AuditoriaPriorizacionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AuditoriaPriorizaciones GetById(AuditoriaPriorizaciones pAuditoriaPriorizaciones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaPriorizaciones.id);                                    


    				AuditoriaPriorizaciones o = SqlMapper.QueryFirstOrDefault<AuditoriaPriorizaciones>(con, "API.PA_AuditoriaPriorizacionesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AuditoriaPriorizaciones  ->" + ex.Message);
				}
			}

			public List<AuditoriaPriorizaciones> GetAll()
			{
				try 
                {
                        List<AuditoriaPriorizaciones> l = SqlMapper.Query<AuditoriaPriorizaciones>(con, "API.PA_AuditoriaPriorizacionesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AuditoriaPriorizaciones  ->" + ex.Message);
				}
			}

			public List<AuditoriaPriorizaciones> GetAllFull()
			{
				try 
				{
                    List<AuditoriaPriorizaciones> l = SqlMapper.Query<AuditoriaPriorizaciones>(con, "API.PA_AuditoriaPriorizacionesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AuditoriaPriorizaciones  ->" + ex.Message);
				}
			}
			
			public List<AuditoriaPriorizaciones> GetAllByWithRelation()
			{
				try 
                {
                    List<AuditoriaPriorizaciones> l = SqlMapper.Query<AuditoriaPriorizaciones>(con, "API.PA_AuditoriaPriorizacionesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AuditoriaPriorizaciones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AuditoriaPriorizaciones> GetByFilter(AuditoriaPriorizaciones pAuditoriaPriorizaciones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAuditoriaPriorizaciones.id== null || pAuditoriaPriorizaciones.id==0) ? vintNUll :pAuditoriaPriorizaciones.id);
                    p.Add("@ID_User",(pAuditoriaPriorizaciones.ID_User== null) ? vintNUll :pAuditoriaPriorizaciones.ID_User);
                    p.Add("@ID_Priorizacion",(pAuditoriaPriorizaciones.ID_Priorizacion== null || pAuditoriaPriorizaciones.ID_Priorizacion==0) ? vintNUll :pAuditoriaPriorizaciones.ID_Priorizacion);
                    p.Add("@ID_TipoOperacion",(pAuditoriaPriorizaciones.ID_TipoOperacion== null || pAuditoriaPriorizaciones.ID_TipoOperacion==0) ? vintNUll :pAuditoriaPriorizaciones.ID_TipoOperacion);
                    p.Add("@FechaCambio",(pAuditoriaPriorizaciones.FechaCambio== null) ? vintNUll :pAuditoriaPriorizaciones.FechaCambio);
                    p.Add("@Valor",(pAuditoriaPriorizaciones.Valor== null) ? vintNUll :pAuditoriaPriorizaciones.Valor);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AuditoriaPriorizaciones> l = SqlMapper.Query<AuditoriaPriorizaciones>(con, "API.PA_AuditoriaPriorizacionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AuditoriaPriorizaciones  ->" + ex.Message);
				}
			}

			public AuditoriaPriorizaciones Add(AuditoriaPriorizaciones pAuditoriaPriorizaciones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAuditoriaPriorizaciones.id==null ? 0 : pAuditoriaPriorizaciones.id);
                    p.Add("@ID_User", pAuditoriaPriorizaciones.ID_User);
p.Add("@ID_Priorizacion",pAuditoriaPriorizaciones.ID_Priorizacion==null ? 0 : pAuditoriaPriorizaciones.ID_Priorizacion);
p.Add("@ID_TipoOperacion",pAuditoriaPriorizaciones.ID_TipoOperacion==null ? 0 : pAuditoriaPriorizaciones.ID_TipoOperacion);
                    p.Add("@FechaCambio", pAuditoriaPriorizaciones.FechaCambio);
                    p.Add("@Valor", pAuditoriaPriorizaciones.Valor);
                    p.Add("@auditoria", pAuditoriaPriorizaciones.auditoria);

                         


                    AuditoriaPriorizaciones o = SqlMapper.QueryFirstOrDefault<AuditoriaPriorizaciones>(con, "API.PA_AuditoriaPriorizacionesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AuditoriaPriorizaciones  ->" + ex.Message);
				}
			}

			public AuditoriaPriorizaciones  Update(AuditoriaPriorizaciones pAuditoriaPriorizaciones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAuditoriaPriorizaciones.id==null ? 0 : pAuditoriaPriorizaciones.id);
                    p.Add("@ID_User", pAuditoriaPriorizaciones.ID_User);
p.Add("@ID_Priorizacion",pAuditoriaPriorizaciones.ID_Priorizacion==null ? 0 : pAuditoriaPriorizaciones.ID_Priorizacion);
p.Add("@ID_TipoOperacion",pAuditoriaPriorizaciones.ID_TipoOperacion==null ? 0 : pAuditoriaPriorizaciones.ID_TipoOperacion);
                    p.Add("@FechaCambio", pAuditoriaPriorizaciones.FechaCambio);
                    p.Add("@Valor", pAuditoriaPriorizaciones.Valor);
                    p.Add("@auditoria", pAuditoriaPriorizaciones.auditoria);

                         


                    AuditoriaPriorizaciones o = SqlMapper.QueryFirstOrDefault<AuditoriaPriorizaciones>(con, "API.PA_AuditoriaPriorizacionesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AuditoriaPriorizaciones  ->" + ex.Message);
				}
			}

			public bool Delete(AuditoriaPriorizaciones pAuditoriaPriorizaciones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaPriorizaciones.id);
                    p.Add("@auditoria", pAuditoriaPriorizaciones.auditoria);

                

 

					AuditoriaPriorizaciones o = SqlMapper.QueryFirstOrDefault<AuditoriaPriorizaciones>(con, "API.PA_AuditoriaPriorizacionesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AuditoriaPriorizaciones  ->" + ex.Message);
				}
			}

		



            public List<AuditoriaPriorizaciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AuditoriaPriorizaciones> AuditoriaPriorizacionesList = new List<AuditoriaPriorizaciones>();

                    AuditoriaPriorizacionesList = SqlMapper.Query<AuditoriaPriorizaciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AuditoriaPriorizacionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AuditoriaPriorizaciones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AuditoriaPriorizaciones> b)
            {
                DapperPlusManager.Entity<AuditoriaPriorizaciones>().Table("AuditoriaPriorizaciones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}