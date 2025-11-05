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
     /// Clase Abstracta para  ConveniosETC
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ConveniosETCRepository : DataObject , IConveniosETC 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ConveniosETCRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ConveniosETCRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ConveniosETC GetById(ConveniosETC pConveniosETC)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pConveniosETC.id);                                    


    				ConveniosETC o = SqlMapper.QueryFirstOrDefault<ConveniosETC>(con, "API.PA_ConveniosETCGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ConveniosETC  ->" + ex.Message);
				}
			}

			public List<ConveniosETC> GetAll()
			{
				try 
                {
                        List<ConveniosETC> l = SqlMapper.Query<ConveniosETC>(con, "API.PA_ConveniosETCGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ConveniosETC  ->" + ex.Message);
				}
			}

			public List<ConveniosETC> GetAllFull()
			{
				try 
				{
                    List<ConveniosETC> l = SqlMapper.Query<ConveniosETC>(con, "API.PA_ConveniosETCGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ConveniosETC  ->" + ex.Message);
				}
			}
			
			public List<ConveniosETC> GetAllByWithRelation()
			{
				try 
                {
                    List<ConveniosETC> l = SqlMapper.Query<ConveniosETC>(con, "API.PA_ConveniosETCGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ConveniosETC  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ConveniosETC> GetByFilter(ConveniosETC pConveniosETC, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pConveniosETC.id== null || pConveniosETC.id==0) ? vintNUll :pConveniosETC.id);
                    p.Add("@ID_Contrato",(pConveniosETC.ID_Contrato== null || pConveniosETC.ID_Contrato==0) ? vintNUll :pConveniosETC.ID_Contrato);
                    p.Add("@ID_ETC",(pConveniosETC.ID_ETC== null || pConveniosETC.ID_ETC==0) ? vintNUll :pConveniosETC.ID_ETC);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ConveniosETC> l = SqlMapper.Query<ConveniosETC>(con, "API.PA_ConveniosETCGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ConveniosETC  ->" + ex.Message);
				}
			}

			public ConveniosETC Add(ConveniosETC pConveniosETC)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pConveniosETC.id==null ? 0 : pConveniosETC.id);
p.Add("@ID_Contrato",pConveniosETC.ID_Contrato==null ? 0 : pConveniosETC.ID_Contrato);
p.Add("@ID_ETC",pConveniosETC.ID_ETC==null ? 0 : pConveniosETC.ID_ETC);
                    p.Add("@auditoria", pConveniosETC.auditoria);

                         


                    ConveniosETC o = SqlMapper.QueryFirstOrDefault<ConveniosETC>(con, "API.PA_ConveniosETCAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ConveniosETC  ->" + ex.Message);
				}
			}

			public ConveniosETC  Update(ConveniosETC pConveniosETC)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pConveniosETC.id==null ? 0 : pConveniosETC.id);
p.Add("@ID_Contrato",pConveniosETC.ID_Contrato==null ? 0 : pConveniosETC.ID_Contrato);
p.Add("@ID_ETC",pConveniosETC.ID_ETC==null ? 0 : pConveniosETC.ID_ETC);
                    p.Add("@auditoria", pConveniosETC.auditoria);

                         


                    ConveniosETC o = SqlMapper.QueryFirstOrDefault<ConveniosETC>(con, "API.PA_ConveniosETCUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ConveniosETC  ->" + ex.Message);
				}
			}

			public bool Delete(ConveniosETC pConveniosETC)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pConveniosETC.id);
                    p.Add("@auditoria", pConveniosETC.auditoria);

                

 

					ConveniosETC o = SqlMapper.QueryFirstOrDefault<ConveniosETC>(con, "API.PA_ConveniosETCDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ConveniosETC  ->" + ex.Message);
				}
			}

		



            public List<ConveniosETC> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ConveniosETC> ConveniosETCList = new List<ConveniosETC>();

                    ConveniosETCList = SqlMapper.Query<ConveniosETC>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ConveniosETCList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ConveniosETC  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ConveniosETC> b)
            {
                DapperPlusManager.Entity<ConveniosETC>().Table("ConveniosETC");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}