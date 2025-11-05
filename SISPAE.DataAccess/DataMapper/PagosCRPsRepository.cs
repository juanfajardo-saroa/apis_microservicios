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
     /// Clase Abstracta para  PagosCRPs
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PagosCRPsRepository : DataObject , IPagosCRPs 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PagosCRPsRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PagosCRPsRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public PagosCRPs GetById(PagosCRPs pPagosCRPs)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pPagosCRPs.id);                                    


    				PagosCRPs o = SqlMapper.QueryFirstOrDefault<PagosCRPs>(con, "API.PA_PagosCRPsGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  PagosCRPs  ->" + ex.Message);
				}
			}

			public List<PagosCRPs> GetAll()
			{
				try 
                {
                        List<PagosCRPs> l = SqlMapper.Query<PagosCRPs>(con, "API.PA_PagosCRPsGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  PagosCRPs  ->" + ex.Message);
				}
			}

			public List<PagosCRPs> GetAllFull()
			{
				try 
				{
                    List<PagosCRPs> l = SqlMapper.Query<PagosCRPs>(con, "API.PA_PagosCRPsGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  PagosCRPs  ->" + ex.Message);
				}
			}
			
			public List<PagosCRPs> GetAllByWithRelation()
			{
				try 
                {
                    List<PagosCRPs> l = SqlMapper.Query<PagosCRPs>(con, "API.PA_PagosCRPsGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  PagosCRPs  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<PagosCRPs> GetByFilter(PagosCRPs pPagosCRPs, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pPagosCRPs.id== null || pPagosCRPs.id==0) ? vintNUll :pPagosCRPs.id);
                    p.Add("@ID_CRP",(pPagosCRPs.ID_CRP== null || pPagosCRPs.ID_CRP==0) ? vintNUll :pPagosCRPs.ID_CRP);
                    p.Add("@ValorPago",(pPagosCRPs.ValorPago== null) ? vintNUll :pPagosCRPs.ValorPago);
                    p.Add("@ID_Pagos",(pPagosCRPs.ID_Pagos== null || pPagosCRPs.ID_Pagos==0) ? vintNUll :pPagosCRPs.ID_Pagos);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<PagosCRPs> l = SqlMapper.Query<PagosCRPs>(con, "API.PA_PagosCRPsGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  PagosCRPs  ->" + ex.Message);
				}
			}

			public PagosCRPs Add(PagosCRPs pPagosCRPs)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pPagosCRPs.id==null ? 0 : pPagosCRPs.id);
p.Add("@ID_CRP",pPagosCRPs.ID_CRP==null ? 0 : pPagosCRPs.ID_CRP);
                    p.Add("@ValorPago", pPagosCRPs.ValorPago);
p.Add("@ID_Pagos",pPagosCRPs.ID_Pagos==null ? 0 : pPagosCRPs.ID_Pagos);
                    p.Add("@auditoria", pPagosCRPs.auditoria);

                         


                    PagosCRPs o = SqlMapper.QueryFirstOrDefault<PagosCRPs>(con, "API.PA_PagosCRPsAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  PagosCRPs  ->" + ex.Message);
				}
			}

			public PagosCRPs  Update(PagosCRPs pPagosCRPs)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pPagosCRPs.id==null ? 0 : pPagosCRPs.id);
p.Add("@ID_CRP",pPagosCRPs.ID_CRP==null ? 0 : pPagosCRPs.ID_CRP);
                    p.Add("@ValorPago", pPagosCRPs.ValorPago);
p.Add("@ID_Pagos",pPagosCRPs.ID_Pagos==null ? 0 : pPagosCRPs.ID_Pagos);
                    p.Add("@auditoria", pPagosCRPs.auditoria);

                         


                    PagosCRPs o = SqlMapper.QueryFirstOrDefault<PagosCRPs>(con, "API.PA_PagosCRPsUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  PagosCRPs  ->" + ex.Message);
				}
			}

			public bool Delete(PagosCRPs pPagosCRPs)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pPagosCRPs.id);
                    p.Add("@auditoria", pPagosCRPs.auditoria);

                

 

					PagosCRPs o = SqlMapper.QueryFirstOrDefault<PagosCRPs>(con, "API.PA_PagosCRPsDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) PagosCRPs  ->" + ex.Message);
				}
			}

		



            public List<PagosCRPs> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<PagosCRPs> PagosCRPsList = new List<PagosCRPs>();

                    PagosCRPsList = SqlMapper.Query<PagosCRPs>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PagosCRPsList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) PagosCRPs  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<PagosCRPs> b)
            {
                DapperPlusManager.Entity<PagosCRPs>().Table("PagosCRPs");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}