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
     /// Clase Abstracta para  CDPs
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CDPsRepository : DataObject , ICDPs 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CDPsRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CDPsRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CDPs GetById(CDPs pCDPs)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCDPs.id);                                    


    				CDPs o = SqlMapper.QueryFirstOrDefault<CDPs>(con, "API.PA_CDPsGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CDPs  ->" + ex.Message);
				}
			}

			public List<CDPs> GetAll()
			{
				try 
                {
                        List<CDPs> l = SqlMapper.Query<CDPs>(con, "API.PA_CDPsGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CDPs  ->" + ex.Message);
				}
			}

			public List<CDPs> GetAllFull()
			{
				try 
				{
                    List<CDPs> l = SqlMapper.Query<CDPs>(con, "API.PA_CDPsGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CDPs  ->" + ex.Message);
				}
			}
			
			public List<CDPs> GetAllByWithRelation()
			{
				try 
                {
                    List<CDPs> l = SqlMapper.Query<CDPs>(con, "API.PA_CDPsGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CDPs  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CDPs> GetByFilter(CDPs pCDPs, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCDPs.id== null || pCDPs.id==0) ? vintNUll :pCDPs.id);
                    p.Add("@ID_FuenteFinanciacion",(pCDPs.ID_FuenteFinanciacion== null || pCDPs.ID_FuenteFinanciacion==0) ? vintNUll :pCDPs.ID_FuenteFinanciacion);
                    p.Add("@NumeroCDP",(pCDPs.NumeroCDP== null) ? vintNUll :pCDPs.NumeroCDP);
                    p.Add("@FechaCDP",(pCDPs.FechaCDP== null) ? vintNUll :pCDPs.FechaCDP);
                    p.Add("@PAHTArchivoCDP",(pCDPs.PAHTArchivoCDP== null) ? vintNUll :pCDPs.PAHTArchivoCDP);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CDPs> l = SqlMapper.Query<CDPs>(con, "API.PA_CDPsGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CDPs  ->" + ex.Message);
				}
			}

			public CDPs Add(CDPs pCDPs)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCDPs.id==null ? 0 : pCDPs.id);
p.Add("@ID_FuenteFinanciacion",pCDPs.ID_FuenteFinanciacion==null ? 0 : pCDPs.ID_FuenteFinanciacion);
p.Add("@NumeroCDP",pCDPs.NumeroCDP==null ? 0 : pCDPs.NumeroCDP);
                    p.Add("@FechaCDP", pCDPs.FechaCDP);
                    p.Add("@PAHTArchivoCDP", pCDPs.PAHTArchivoCDP);
                    p.Add("@auditoria", pCDPs.auditoria);

                         


                    CDPs o = SqlMapper.QueryFirstOrDefault<CDPs>(con, "API.PA_CDPsAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CDPs  ->" + ex.Message);
				}
			}

			public CDPs  Update(CDPs pCDPs)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCDPs.id==null ? 0 : pCDPs.id);
p.Add("@ID_FuenteFinanciacion",pCDPs.ID_FuenteFinanciacion==null ? 0 : pCDPs.ID_FuenteFinanciacion);
p.Add("@NumeroCDP",pCDPs.NumeroCDP==null ? 0 : pCDPs.NumeroCDP);
                    p.Add("@FechaCDP", pCDPs.FechaCDP);
                    p.Add("@PAHTArchivoCDP", pCDPs.PAHTArchivoCDP);
                    p.Add("@auditoria", pCDPs.auditoria);

                         


                    CDPs o = SqlMapper.QueryFirstOrDefault<CDPs>(con, "API.PA_CDPsUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CDPs  ->" + ex.Message);
				}
			}

			public bool Delete(CDPs pCDPs)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCDPs.id);
                    p.Add("@auditoria", pCDPs.auditoria);

                

 

					CDPs o = SqlMapper.QueryFirstOrDefault<CDPs>(con, "API.PA_CDPsDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CDPs  ->" + ex.Message);
				}
			}

		



            public List<CDPs> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CDPs> CDPsList = new List<CDPs>();

                    CDPsList = SqlMapper.Query<CDPs>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CDPsList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CDPs  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CDPs> b)
            {
                DapperPlusManager.Entity<CDPs>().Table("CDPs");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}