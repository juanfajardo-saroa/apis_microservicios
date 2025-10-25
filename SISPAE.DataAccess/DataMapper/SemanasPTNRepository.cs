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
     /// Clase Abstracta para  SemanasPTN
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SemanasPTNRepository : DataObject , ISemanasPTN 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SemanasPTNRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SemanasPTNRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public SemanasPTN GetById(SemanasPTN pSemanasPTN)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSemanasPTN.id);                                    


    				SemanasPTN o = SqlMapper.QueryFirstOrDefault<SemanasPTN>(con, "API.PA_SemanasPTNGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  SemanasPTN  ->" + ex.Message);
				}
			}

			public List<SemanasPTN> GetAll()
			{
				try 
                {
                        List<SemanasPTN> l = SqlMapper.Query<SemanasPTN>(con, "API.PA_SemanasPTNGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  SemanasPTN  ->" + ex.Message);
				}
			}

			public List<SemanasPTN> GetAllFull()
			{
				try 
				{
                    List<SemanasPTN> l = SqlMapper.Query<SemanasPTN>(con, "API.PA_SemanasPTNGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  SemanasPTN  ->" + ex.Message);
				}
			}
			
			public List<SemanasPTN> GetAllByWithRelation()
			{
				try 
                {
                    List<SemanasPTN> l = SqlMapper.Query<SemanasPTN>(con, "API.PA_SemanasPTNGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  SemanasPTN  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<SemanasPTN> GetByFilter(SemanasPTN pSemanasPTN, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSemanasPTN.id== null || pSemanasPTN.id==0) ? vintNUll :pSemanasPTN.id);
                    p.Add("@ID_CiclosMenu",(pSemanasPTN.ID_CiclosMenu== null || pSemanasPTN.ID_CiclosMenu==0) ? vintNUll :pSemanasPTN.ID_CiclosMenu);
                    p.Add("@NumeroSemana",(pSemanasPTN.NumeroSemana== null) ? vintNUll :pSemanasPTN.NumeroSemana);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<SemanasPTN> l = SqlMapper.Query<SemanasPTN>(con, "API.PA_SemanasPTNGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  SemanasPTN  ->" + ex.Message);
				}
			}

			public SemanasPTN Add(SemanasPTN pSemanasPTN)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSemanasPTN.id==null ? 0 : pSemanasPTN.id);
p.Add("@ID_CiclosMenu",pSemanasPTN.ID_CiclosMenu==null ? 0 : pSemanasPTN.ID_CiclosMenu);
p.Add("@NumeroSemana",pSemanasPTN.NumeroSemana==null ? 0 : pSemanasPTN.NumeroSemana);
                    p.Add("@auditoria", pSemanasPTN.auditoria);

                         


                    SemanasPTN o = SqlMapper.QueryFirstOrDefault<SemanasPTN>(con, "API.PA_SemanasPTNAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  SemanasPTN  ->" + ex.Message);
				}
			}

			public SemanasPTN  Update(SemanasPTN pSemanasPTN)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSemanasPTN.id==null ? 0 : pSemanasPTN.id);
p.Add("@ID_CiclosMenu",pSemanasPTN.ID_CiclosMenu==null ? 0 : pSemanasPTN.ID_CiclosMenu);
p.Add("@NumeroSemana",pSemanasPTN.NumeroSemana==null ? 0 : pSemanasPTN.NumeroSemana);
                    p.Add("@auditoria", pSemanasPTN.auditoria);

                         


                    SemanasPTN o = SqlMapper.QueryFirstOrDefault<SemanasPTN>(con, "API.PA_SemanasPTNUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  SemanasPTN  ->" + ex.Message);
				}
			}

			public bool Delete(SemanasPTN pSemanasPTN)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSemanasPTN.id);
                    p.Add("@auditoria", pSemanasPTN.auditoria);

                

 

					SemanasPTN o = SqlMapper.QueryFirstOrDefault<SemanasPTN>(con, "API.PA_SemanasPTNDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) SemanasPTN  ->" + ex.Message);
				}
			}

		



            public List<SemanasPTN> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<SemanasPTN> SemanasPTNList = new List<SemanasPTN>();

                    SemanasPTNList = SqlMapper.Query<SemanasPTN>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SemanasPTNList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) SemanasPTN  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<SemanasPTN> b)
            {
                DapperPlusManager.Entity<SemanasPTN>().Table("SemanasPTN");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}