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
     /// Clase Abstracta para  ET
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ETRepository : DataObject , IET 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ETRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ETRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ET GetById(ET pET)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pET.id);                                    


    				ET o = SqlMapper.QueryFirstOrDefault<ET>(con, "API.PA_ETGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ET  ->" + ex.Message);
				}
			}

			public List<ET> GetAll()
			{
				try 
                {
                        List<ET> l = SqlMapper.Query<ET>(con, "API.PA_ETGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ET  ->" + ex.Message);
				}
			}

			public List<ET> GetAllFull()
			{
				try 
				{
                    List<ET> l = SqlMapper.Query<ET>(con, "API.PA_ETGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ET  ->" + ex.Message);
				}
			}
			
			public List<ET> GetAllByWithRelation()
			{
				try 
                {
                    List<ET> l = SqlMapper.Query<ET>(con, "API.PA_ETGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ET  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ET> GetByFilter(ET pET, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pET.id== null || pET.id==0) ? vintNUll :pET.id);
                    p.Add("@ID_ETC",(pET.ID_ETC== null || pET.ID_ETC==0) ? vintNUll :pET.ID_ETC);
                    p.Add("@Codigo",(pET.Codigo== null) ? vintNUll :pET.Codigo);
                    p.Add("@Nombre",(pET.Nombre== null) ? vintNUll :pET.Nombre);
                    p.Add("@ID_DiagnosticoSituacional",(pET.ID_DiagnosticoSituacional== null || pET.ID_DiagnosticoSituacional==0) ? vintNUll :pET.ID_DiagnosticoSituacional);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ET> l = SqlMapper.Query<ET>(con, "API.PA_ETGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ET  ->" + ex.Message);
				}
			}

			public ET Add(ET pET)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pET.id==null ? 0 : pET.id);
p.Add("@ID_ETC",pET.ID_ETC==null ? 0 : pET.ID_ETC);
                    p.Add("@Codigo", pET.Codigo);
                    p.Add("@Nombre", pET.Nombre);
p.Add("@ID_DiagnosticoSituacional",pET.ID_DiagnosticoSituacional==null ? 0 : pET.ID_DiagnosticoSituacional);
                    p.Add("@auditoria", pET.auditoria);

                         


                    ET o = SqlMapper.QueryFirstOrDefault<ET>(con, "API.PA_ETAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ET  ->" + ex.Message);
				}
			}

			public ET  Update(ET pET)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pET.id==null ? 0 : pET.id);
p.Add("@ID_ETC",pET.ID_ETC==null ? 0 : pET.ID_ETC);
                    p.Add("@Codigo", pET.Codigo);
                    p.Add("@Nombre", pET.Nombre);
p.Add("@ID_DiagnosticoSituacional",pET.ID_DiagnosticoSituacional==null ? 0 : pET.ID_DiagnosticoSituacional);
                    p.Add("@auditoria", pET.auditoria);

                         


                    ET o = SqlMapper.QueryFirstOrDefault<ET>(con, "API.PA_ETUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ET  ->" + ex.Message);
				}
			}

			public bool Delete(ET pET)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pET.id);
                    p.Add("@auditoria", pET.auditoria);

                

 

					ET o = SqlMapper.QueryFirstOrDefault<ET>(con, "API.PA_ETDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ET  ->" + ex.Message);
				}
			}

		



            public List<ET> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ET> ETList = new List<ET>();

                    ETList = SqlMapper.Query<ET>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ETList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ET  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ET> b)
            {
                DapperPlusManager.Entity<ET>().Table("ET");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}