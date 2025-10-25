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
     /// Clase Abstracta para  ConveniosET
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ConveniosETRepository : DataObject , IConveniosET 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ConveniosETRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ConveniosETRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ConveniosET GetById(ConveniosET pConveniosET)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pConveniosET.id);                                    


    				ConveniosET o = SqlMapper.QueryFirstOrDefault<ConveniosET>(con, "API.PA_ConveniosETGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ConveniosET  ->" + ex.Message);
				}
			}

			public List<ConveniosET> GetAll()
			{
				try 
                {
                        List<ConveniosET> l = SqlMapper.Query<ConveniosET>(con, "API.PA_ConveniosETGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ConveniosET  ->" + ex.Message);
				}
			}

			public List<ConveniosET> GetAllFull()
			{
				try 
				{
                    List<ConveniosET> l = SqlMapper.Query<ConveniosET>(con, "API.PA_ConveniosETGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ConveniosET  ->" + ex.Message);
				}
			}
			
			public List<ConveniosET> GetAllByWithRelation()
			{
				try 
                {
                    List<ConveniosET> l = SqlMapper.Query<ConveniosET>(con, "API.PA_ConveniosETGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ConveniosET  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ConveniosET> GetByFilter(ConveniosET pConveniosET, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pConveniosET.id== null || pConveniosET.id==0) ? vintNUll :pConveniosET.id);
                    p.Add("@ID_Contrato",(pConveniosET.ID_Contrato== null || pConveniosET.ID_Contrato==0) ? vintNUll :pConveniosET.ID_Contrato);
                    p.Add("@ID_ET",(pConveniosET.ID_ET== null || pConveniosET.ID_ET==0) ? vintNUll :pConveniosET.ID_ET);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ConveniosET> l = SqlMapper.Query<ConveniosET>(con, "API.PA_ConveniosETGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ConveniosET  ->" + ex.Message);
				}
			}

			public ConveniosET Add(ConveniosET pConveniosET)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pConveniosET.id==null ? 0 : pConveniosET.id);
p.Add("@ID_Contrato",pConveniosET.ID_Contrato==null ? 0 : pConveniosET.ID_Contrato);
p.Add("@ID_ET",pConveniosET.ID_ET==null ? 0 : pConveniosET.ID_ET);
                    p.Add("@auditoria", pConveniosET.auditoria);

                         


                    ConveniosET o = SqlMapper.QueryFirstOrDefault<ConveniosET>(con, "API.PA_ConveniosETAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ConveniosET  ->" + ex.Message);
				}
			}

			public ConveniosET  Update(ConveniosET pConveniosET)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pConveniosET.id==null ? 0 : pConveniosET.id);
p.Add("@ID_Contrato",pConveniosET.ID_Contrato==null ? 0 : pConveniosET.ID_Contrato);
p.Add("@ID_ET",pConveniosET.ID_ET==null ? 0 : pConveniosET.ID_ET);
                    p.Add("@auditoria", pConveniosET.auditoria);

                         


                    ConveniosET o = SqlMapper.QueryFirstOrDefault<ConveniosET>(con, "API.PA_ConveniosETUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ConveniosET  ->" + ex.Message);
				}
			}

			public bool Delete(ConveniosET pConveniosET)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pConveniosET.id);
                    p.Add("@auditoria", pConveniosET.auditoria);

                

 

					ConveniosET o = SqlMapper.QueryFirstOrDefault<ConveniosET>(con, "API.PA_ConveniosETDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ConveniosET  ->" + ex.Message);
				}
			}

		



            public List<ConveniosET> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ConveniosET> ConveniosETList = new List<ConveniosET>();

                    ConveniosETList = SqlMapper.Query<ConveniosET>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ConveniosETList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ConveniosET  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ConveniosET> b)
            {
                DapperPlusManager.Entity<ConveniosET>().Table("ConveniosET");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}