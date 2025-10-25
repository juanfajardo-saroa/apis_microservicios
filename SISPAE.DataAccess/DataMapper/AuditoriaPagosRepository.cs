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
     /// Clase Abstracta para  AuditoriaPagos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AuditoriaPagosRepository : DataObject , IAuditoriaPagos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AuditoriaPagosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AuditoriaPagosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AuditoriaPagos GetById(AuditoriaPagos pAuditoriaPagos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaPagos.id);                                    


    				AuditoriaPagos o = SqlMapper.QueryFirstOrDefault<AuditoriaPagos>(con, "API.PA_AuditoriaPagosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AuditoriaPagos  ->" + ex.Message);
				}
			}

			public List<AuditoriaPagos> GetAll()
			{
				try 
                {
                        List<AuditoriaPagos> l = SqlMapper.Query<AuditoriaPagos>(con, "API.PA_AuditoriaPagosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AuditoriaPagos  ->" + ex.Message);
				}
			}

			public List<AuditoriaPagos> GetAllFull()
			{
				try 
				{
                    List<AuditoriaPagos> l = SqlMapper.Query<AuditoriaPagos>(con, "API.PA_AuditoriaPagosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AuditoriaPagos  ->" + ex.Message);
				}
			}
			
			public List<AuditoriaPagos> GetAllByWithRelation()
			{
				try 
                {
                    List<AuditoriaPagos> l = SqlMapper.Query<AuditoriaPagos>(con, "API.PA_AuditoriaPagosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AuditoriaPagos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AuditoriaPagos> GetByFilter(AuditoriaPagos pAuditoriaPagos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAuditoriaPagos.id== null || pAuditoriaPagos.id==0) ? vintNUll :pAuditoriaPagos.id);
                    p.Add("@ID_User",(pAuditoriaPagos.ID_User== null) ? vintNUll :pAuditoriaPagos.ID_User);
                    p.Add("@ID_Pago",(pAuditoriaPagos.ID_Pago== null || pAuditoriaPagos.ID_Pago==0) ? vintNUll :pAuditoriaPagos.ID_Pago);
                    p.Add("@ID_TipoOperacion",(pAuditoriaPagos.ID_TipoOperacion== null || pAuditoriaPagos.ID_TipoOperacion==0) ? vintNUll :pAuditoriaPagos.ID_TipoOperacion);
                    p.Add("@FechaCambio",(pAuditoriaPagos.FechaCambio== null) ? vintNUll :pAuditoriaPagos.FechaCambio);
                    p.Add("@Valor",(pAuditoriaPagos.Valor== null) ? vintNUll :pAuditoriaPagos.Valor);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AuditoriaPagos> l = SqlMapper.Query<AuditoriaPagos>(con, "API.PA_AuditoriaPagosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AuditoriaPagos  ->" + ex.Message);
				}
			}

			public AuditoriaPagos Add(AuditoriaPagos pAuditoriaPagos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAuditoriaPagos.id==null ? 0 : pAuditoriaPagos.id);
                    p.Add("@ID_User", pAuditoriaPagos.ID_User);
p.Add("@ID_Pago",pAuditoriaPagos.ID_Pago==null ? 0 : pAuditoriaPagos.ID_Pago);
p.Add("@ID_TipoOperacion",pAuditoriaPagos.ID_TipoOperacion==null ? 0 : pAuditoriaPagos.ID_TipoOperacion);
                    p.Add("@FechaCambio", pAuditoriaPagos.FechaCambio);
                    p.Add("@Valor", pAuditoriaPagos.Valor);
                    p.Add("@auditoria", pAuditoriaPagos.auditoria);

                         


                    AuditoriaPagos o = SqlMapper.QueryFirstOrDefault<AuditoriaPagos>(con, "API.PA_AuditoriaPagosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AuditoriaPagos  ->" + ex.Message);
				}
			}

			public AuditoriaPagos  Update(AuditoriaPagos pAuditoriaPagos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAuditoriaPagos.id==null ? 0 : pAuditoriaPagos.id);
                    p.Add("@ID_User", pAuditoriaPagos.ID_User);
p.Add("@ID_Pago",pAuditoriaPagos.ID_Pago==null ? 0 : pAuditoriaPagos.ID_Pago);
p.Add("@ID_TipoOperacion",pAuditoriaPagos.ID_TipoOperacion==null ? 0 : pAuditoriaPagos.ID_TipoOperacion);
                    p.Add("@FechaCambio", pAuditoriaPagos.FechaCambio);
                    p.Add("@Valor", pAuditoriaPagos.Valor);
                    p.Add("@auditoria", pAuditoriaPagos.auditoria);

                         


                    AuditoriaPagos o = SqlMapper.QueryFirstOrDefault<AuditoriaPagos>(con, "API.PA_AuditoriaPagosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AuditoriaPagos  ->" + ex.Message);
				}
			}

			public bool Delete(AuditoriaPagos pAuditoriaPagos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaPagos.id);
                    p.Add("@auditoria", pAuditoriaPagos.auditoria);

                

 

					AuditoriaPagos o = SqlMapper.QueryFirstOrDefault<AuditoriaPagos>(con, "API.PA_AuditoriaPagosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AuditoriaPagos  ->" + ex.Message);
				}
			}

		



            public List<AuditoriaPagos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AuditoriaPagos> AuditoriaPagosList = new List<AuditoriaPagos>();

                    AuditoriaPagosList = SqlMapper.Query<AuditoriaPagos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AuditoriaPagosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AuditoriaPagos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AuditoriaPagos> b)
            {
                DapperPlusManager.Entity<AuditoriaPagos>().Table("AuditoriaPagos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}