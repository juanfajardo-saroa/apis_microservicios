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
     /// Clase Abstracta para  CRPs
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CRPsRepository : DataObject , ICRPs 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CRPsRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CRPsRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CRPs GetById(CRPs pCRPs)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCRPs.id);                                    


    				CRPs o = SqlMapper.QueryFirstOrDefault<CRPs>(con, "API.PA_CRPsGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CRPs  ->" + ex.Message);
				}
			}

			public List<CRPs> GetAll()
			{
				try 
                {
                        List<CRPs> l = SqlMapper.Query<CRPs>(con, "API.PA_CRPsGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CRPs  ->" + ex.Message);
				}
			}

			public List<CRPs> GetAllFull()
			{
				try 
				{
                    List<CRPs> l = SqlMapper.Query<CRPs>(con, "API.PA_CRPsGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CRPs  ->" + ex.Message);
				}
			}
			
			public List<CRPs> GetAllByWithRelation()
			{
				try 
                {
                    List<CRPs> l = SqlMapper.Query<CRPs>(con, "API.PA_CRPsGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CRPs  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CRPs> GetByFilter(CRPs pCRPs, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCRPs.id== null || pCRPs.id==0) ? vintNUll :pCRPs.id);
                    p.Add("@ID_CDP",(pCRPs.ID_CDP== null || pCRPs.ID_CDP==0) ? vintNUll :pCRPs.ID_CDP);
                    p.Add("@NumeroCRP",(pCRPs.NumeroCRP== null) ? vintNUll :pCRPs.NumeroCRP);
                    p.Add("@FechaCRP",(pCRPs.FechaCRP== null) ? vintNUll :pCRPs.FechaCRP);
                    p.Add("@ValorCRP",(pCRPs.ValorCRP== null) ? vintNUll :pCRPs.ValorCRP);
                    p.Add("@PathArchivoCRP",(pCRPs.PathArchivoCRP== null) ? vintNUll :pCRPs.PathArchivoCRP);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CRPs> l = SqlMapper.Query<CRPs>(con, "API.PA_CRPsGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CRPs  ->" + ex.Message);
				}
			}

			public CRPs Add(CRPs pCRPs)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCRPs.id==null ? 0 : pCRPs.id);
p.Add("@ID_CDP",pCRPs.ID_CDP==null ? 0 : pCRPs.ID_CDP);
p.Add("@NumeroCRP",pCRPs.NumeroCRP==null ? 0 : pCRPs.NumeroCRP);
                    p.Add("@FechaCRP", pCRPs.FechaCRP);
                    p.Add("@ValorCRP", pCRPs.ValorCRP);
                    p.Add("@PathArchivoCRP", pCRPs.PathArchivoCRP);
                    p.Add("@auditoria", pCRPs.auditoria);

                         


                    CRPs o = SqlMapper.QueryFirstOrDefault<CRPs>(con, "API.PA_CRPsAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CRPs  ->" + ex.Message);
				}
			}

			public CRPs  Update(CRPs pCRPs)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCRPs.id==null ? 0 : pCRPs.id);
p.Add("@ID_CDP",pCRPs.ID_CDP==null ? 0 : pCRPs.ID_CDP);
p.Add("@NumeroCRP",pCRPs.NumeroCRP==null ? 0 : pCRPs.NumeroCRP);
                    p.Add("@FechaCRP", pCRPs.FechaCRP);
                    p.Add("@ValorCRP", pCRPs.ValorCRP);
                    p.Add("@PathArchivoCRP", pCRPs.PathArchivoCRP);
                    p.Add("@auditoria", pCRPs.auditoria);

                         


                    CRPs o = SqlMapper.QueryFirstOrDefault<CRPs>(con, "API.PA_CRPsUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CRPs  ->" + ex.Message);
				}
			}

			public bool Delete(CRPs pCRPs)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCRPs.id);
                    p.Add("@auditoria", pCRPs.auditoria);

                

 

					CRPs o = SqlMapper.QueryFirstOrDefault<CRPs>(con, "API.PA_CRPsDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CRPs  ->" + ex.Message);
				}
			}

		



            public List<CRPs> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CRPs> CRPsList = new List<CRPs>();

                    CRPsList = SqlMapper.Query<CRPs>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CRPsList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CRPs  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CRPs> b)
            {
                DapperPlusManager.Entity<CRPs>().Table("CRPs");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}