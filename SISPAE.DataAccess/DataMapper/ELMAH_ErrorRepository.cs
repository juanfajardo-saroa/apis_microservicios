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
     /// Clase Abstracta para  ELMAH_Error
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ELMAH_ErrorRepository : DataObject , IELMAH_Error 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ELMAH_ErrorRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ELMAH_ErrorRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ELMAH_Error GetById(ELMAH_Error pELMAH_Error)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@ErrorId",pELMAH_Error.ErrorId);                                    


    				ELMAH_Error o = SqlMapper.QueryFirstOrDefault<ELMAH_Error>(con, "API.PA_ELMAH_ErrorGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ELMAH_Error  ->" + ex.Message);
				}
			}

			public List<ELMAH_Error> GetAll()
			{
				try 
                {
                        List<ELMAH_Error> l = SqlMapper.Query<ELMAH_Error>(con, "API.PA_ELMAH_ErrorGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ELMAH_Error  ->" + ex.Message );
				}
			}

			public List<ELMAH_Error> GetAllFull()
			{
				try 
				{
                    List<ELMAH_Error> l = SqlMapper.Query<ELMAH_Error>(con, "API.PA_ELMAH_ErrorGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ELMAH_Error  ->" + ex.Message);
				}
			}
			
			public List<ELMAH_Error> GetAllByWithRelation()
			{
				try 
                {
                    List<ELMAH_Error> l = SqlMapper.Query<ELMAH_Error>(con, "API.PA_ELMAH_ErrorGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ELMAH_Error  ->" + ex.Message );
				}
			}
			
 
						
			
			public List<ELMAH_Error> GetByFilter(ELMAH_Error pELMAH_Error, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@Application",(pELMAH_Error.Application== null) ? vintNUll :pELMAH_Error.Application);
                    p.Add("@Host",(pELMAH_Error.Host== null) ? vintNUll :pELMAH_Error.Host);
                    p.Add("@Type",(pELMAH_Error.Type== null) ? vintNUll :pELMAH_Error.Type);
                    p.Add("@Source",(pELMAH_Error.Source== null) ? vintNUll :pELMAH_Error.Source);
                    p.Add("@Message",(pELMAH_Error.Message== null) ? vintNUll :pELMAH_Error.Message);
                    p.Add("@User",(pELMAH_Error.User== null) ? vintNUll :pELMAH_Error.User);
                    p.Add("@StatusCode",(pELMAH_Error.StatusCode== null) ? vintNUll :pELMAH_Error.StatusCode);
                    p.Add("@TimeUtc",(pELMAH_Error.TimeUtc== null) ? vintNUll :pELMAH_Error.TimeUtc);
                    p.Add("@Sequence",(pELMAH_Error.Sequence== null) ? vintNUll :pELMAH_Error.Sequence);
                    p.Add("@AllXml",(pELMAH_Error.AllXml== null) ? vintNUll :pELMAH_Error.AllXml);
                    p.Add("@Data",(pELMAH_Error.Data== null) ? vintNUll :pELMAH_Error.Data);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ELMAH_Error> l = SqlMapper.Query<ELMAH_Error>(con, "API.PA_ELMAH_ErrorGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ELMAH_Error  ->" + ex.Message );
				}
			}

			public ELMAH_Error Add(ELMAH_Error pELMAH_Error)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					                    p.Add("@Application", pELMAH_Error.Application);
                    p.Add("@Host", pELMAH_Error.Host);
                    p.Add("@Type", pELMAH_Error.Type);
                    p.Add("@Source", pELMAH_Error.Source);
                    p.Add("@Message", pELMAH_Error.Message);
                    p.Add("@User", pELMAH_Error.User);
p.Add("@StatusCode",pELMAH_Error.StatusCode==null ? 0 : pELMAH_Error.StatusCode);
                    p.Add("@TimeUtc", pELMAH_Error.TimeUtc);
p.Add("@Sequence",pELMAH_Error.Sequence==null ? 0 : pELMAH_Error.Sequence);
                    p.Add("@AllXml", pELMAH_Error.AllXml);
                    p.Add("@Data", pELMAH_Error.Data);
                    p.Add("@auditoria", pELMAH_Error._XMLAuditoria);

                         


                    ELMAH_Error o = SqlMapper.QueryFirstOrDefault<ELMAH_Error>(con, "API.PA_ELMAH_ErrorAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ELMAH_Error  ->" + ex.Message );
				}
			}

			public ELMAH_Error  Update(ELMAH_Error pELMAH_Error)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					                    p.Add("@Application", pELMAH_Error.Application);
                    p.Add("@Host", pELMAH_Error.Host);
                    p.Add("@Type", pELMAH_Error.Type);
                    p.Add("@Source", pELMAH_Error.Source);
                    p.Add("@Message", pELMAH_Error.Message);
                    p.Add("@User", pELMAH_Error.User);
p.Add("@StatusCode",pELMAH_Error.StatusCode==null ? 0 : pELMAH_Error.StatusCode);
                    p.Add("@TimeUtc", pELMAH_Error.TimeUtc);
p.Add("@Sequence",pELMAH_Error.Sequence==null ? 0 : pELMAH_Error.Sequence);
                    p.Add("@AllXml", pELMAH_Error.AllXml);
                    p.Add("@Data", pELMAH_Error.Data);
                    p.Add("@auditoria", pELMAH_Error._XMLAuditoria);

                         


                    ELMAH_Error o = SqlMapper.QueryFirstOrDefault<ELMAH_Error>(con, "API.PA_ELMAH_ErrorUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ELMAH_Error  ->" + ex.Message );
				}
			}

			public bool Delete(ELMAH_Error pELMAH_Error)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@ErrorId",pELMAH_Error.ErrorId);
                    p.Add("@auditoria", pELMAH_Error._XMLAuditoria);

                

 

					ELMAH_Error o = SqlMapper.QueryFirstOrDefault<ELMAH_Error>(con, "API.PA_ELMAH_ErrorDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ELMAH_Error  ->" + ex.Message );
				}
			}

		



            public List<ELMAH_Error> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ELMAH_Error> ELMAH_ErrorList = new List<ELMAH_Error>();

                    ELMAH_ErrorList = SqlMapper.Query<ELMAH_Error>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ELMAH_ErrorList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ELMAH_Error  ->" + ex.Message );
                }
            }


            public void BulkInsert(List<ELMAH_Error> b)
            {
                DapperPlusManager.Entity<ELMAH_Error>().Table("ELMAH_Error");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}