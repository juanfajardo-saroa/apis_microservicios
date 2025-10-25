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
     /// Clase Abstracta para  AuditoriaPlanesAlistamiento
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AuditoriaPlanesAlistamientoRepository : DataObject , IAuditoriaPlanesAlistamiento 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AuditoriaPlanesAlistamientoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AuditoriaPlanesAlistamientoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AuditoriaPlanesAlistamiento GetById(AuditoriaPlanesAlistamiento pAuditoriaPlanesAlistamiento)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaPlanesAlistamiento.id);                                    


    				AuditoriaPlanesAlistamiento o = SqlMapper.QueryFirstOrDefault<AuditoriaPlanesAlistamiento>(con, "API.PA_AuditoriaPlanesAlistamientoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AuditoriaPlanesAlistamiento  ->" + ex.Message);
				}
			}

			public List<AuditoriaPlanesAlistamiento> GetAll()
			{
				try 
                {
                        List<AuditoriaPlanesAlistamiento> l = SqlMapper.Query<AuditoriaPlanesAlistamiento>(con, "API.PA_AuditoriaPlanesAlistamientoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AuditoriaPlanesAlistamiento  ->" + ex.Message);
				}
			}

			public List<AuditoriaPlanesAlistamiento> GetAllFull()
			{
				try 
				{
                    List<AuditoriaPlanesAlistamiento> l = SqlMapper.Query<AuditoriaPlanesAlistamiento>(con, "API.PA_AuditoriaPlanesAlistamientoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AuditoriaPlanesAlistamiento  ->" + ex.Message);
				}
			}
			
			public List<AuditoriaPlanesAlistamiento> GetAllByWithRelation()
			{
				try 
                {
                    List<AuditoriaPlanesAlistamiento> l = SqlMapper.Query<AuditoriaPlanesAlistamiento>(con, "API.PA_AuditoriaPlanesAlistamientoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AuditoriaPlanesAlistamiento  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AuditoriaPlanesAlistamiento> GetByFilter(AuditoriaPlanesAlistamiento pAuditoriaPlanesAlistamiento, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAuditoriaPlanesAlistamiento.id== null || pAuditoriaPlanesAlistamiento.id==0) ? vintNUll :pAuditoriaPlanesAlistamiento.id);
                    p.Add("@ID_User",(pAuditoriaPlanesAlistamiento.ID_User== null) ? vintNUll :pAuditoriaPlanesAlistamiento.ID_User);
                    p.Add("@ID_PlanAlistamiento",(pAuditoriaPlanesAlistamiento.ID_PlanAlistamiento== null || pAuditoriaPlanesAlistamiento.ID_PlanAlistamiento==0) ? vintNUll :pAuditoriaPlanesAlistamiento.ID_PlanAlistamiento);
                    p.Add("@FechaCambio",(pAuditoriaPlanesAlistamiento.FechaCambio== null) ? vintNUll :pAuditoriaPlanesAlistamiento.FechaCambio);
                    p.Add("@ID_TipoOperacion",(pAuditoriaPlanesAlistamiento.ID_TipoOperacion== null || pAuditoriaPlanesAlistamiento.ID_TipoOperacion==0) ? vintNUll :pAuditoriaPlanesAlistamiento.ID_TipoOperacion);
                    p.Add("@Valor",(pAuditoriaPlanesAlistamiento.Valor== null) ? vintNUll :pAuditoriaPlanesAlistamiento.Valor);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AuditoriaPlanesAlistamiento> l = SqlMapper.Query<AuditoriaPlanesAlistamiento>(con, "API.PA_AuditoriaPlanesAlistamientoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AuditoriaPlanesAlistamiento  ->" + ex.Message);
				}
			}

			public AuditoriaPlanesAlistamiento Add(AuditoriaPlanesAlistamiento pAuditoriaPlanesAlistamiento)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAuditoriaPlanesAlistamiento.id==null ? 0 : pAuditoriaPlanesAlistamiento.id);
                    p.Add("@ID_User", pAuditoriaPlanesAlistamiento.ID_User);
p.Add("@ID_PlanAlistamiento",pAuditoriaPlanesAlistamiento.ID_PlanAlistamiento==null ? 0 : pAuditoriaPlanesAlistamiento.ID_PlanAlistamiento);
                    p.Add("@FechaCambio", pAuditoriaPlanesAlistamiento.FechaCambio);
p.Add("@ID_TipoOperacion",pAuditoriaPlanesAlistamiento.ID_TipoOperacion==null ? 0 : pAuditoriaPlanesAlistamiento.ID_TipoOperacion);
                    p.Add("@Valor", pAuditoriaPlanesAlistamiento.Valor);
                    p.Add("@auditoria", pAuditoriaPlanesAlistamiento.auditoria);

                         


                    AuditoriaPlanesAlistamiento o = SqlMapper.QueryFirstOrDefault<AuditoriaPlanesAlistamiento>(con, "API.PA_AuditoriaPlanesAlistamientoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AuditoriaPlanesAlistamiento  ->" + ex.Message);
				}
			}

			public AuditoriaPlanesAlistamiento  Update(AuditoriaPlanesAlistamiento pAuditoriaPlanesAlistamiento)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAuditoriaPlanesAlistamiento.id==null ? 0 : pAuditoriaPlanesAlistamiento.id);
                    p.Add("@ID_User", pAuditoriaPlanesAlistamiento.ID_User);
p.Add("@ID_PlanAlistamiento",pAuditoriaPlanesAlistamiento.ID_PlanAlistamiento==null ? 0 : pAuditoriaPlanesAlistamiento.ID_PlanAlistamiento);
                    p.Add("@FechaCambio", pAuditoriaPlanesAlistamiento.FechaCambio);
p.Add("@ID_TipoOperacion",pAuditoriaPlanesAlistamiento.ID_TipoOperacion==null ? 0 : pAuditoriaPlanesAlistamiento.ID_TipoOperacion);
                    p.Add("@Valor", pAuditoriaPlanesAlistamiento.Valor);
                    p.Add("@auditoria", pAuditoriaPlanesAlistamiento.auditoria);

                         


                    AuditoriaPlanesAlistamiento o = SqlMapper.QueryFirstOrDefault<AuditoriaPlanesAlistamiento>(con, "API.PA_AuditoriaPlanesAlistamientoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AuditoriaPlanesAlistamiento  ->" + ex.Message);
				}
			}

			public bool Delete(AuditoriaPlanesAlistamiento pAuditoriaPlanesAlistamiento)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaPlanesAlistamiento.id);
                    p.Add("@auditoria", pAuditoriaPlanesAlistamiento.auditoria);

                

 

					AuditoriaPlanesAlistamiento o = SqlMapper.QueryFirstOrDefault<AuditoriaPlanesAlistamiento>(con, "API.PA_AuditoriaPlanesAlistamientoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AuditoriaPlanesAlistamiento  ->" + ex.Message);
				}
			}

		



            public List<AuditoriaPlanesAlistamiento> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AuditoriaPlanesAlistamiento> AuditoriaPlanesAlistamientoList = new List<AuditoriaPlanesAlistamiento>();

                    AuditoriaPlanesAlistamientoList = SqlMapper.Query<AuditoriaPlanesAlistamiento>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AuditoriaPlanesAlistamientoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AuditoriaPlanesAlistamiento  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AuditoriaPlanesAlistamiento> b)
            {
                DapperPlusManager.Entity<AuditoriaPlanesAlistamiento>().Table("AuditoriaPlanesAlistamiento");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}