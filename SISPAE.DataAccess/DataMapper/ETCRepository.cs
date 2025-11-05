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
     /// Clase Abstracta para  ETC
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ETCRepository : DataObject , IETC 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ETCRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ETCRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ETC GetById(ETC pETC)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pETC.id);                                    


    				ETC o = SqlMapper.QueryFirstOrDefault<ETC>(con, "API.PA_ETCGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ETC  ->" + ex.Message);
				}
			}

			public List<ETC> GetAll()
			{
				try 
                {
                        List<ETC> l = SqlMapper.Query<ETC>(con, "API.PA_ETCGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ETC  ->" + ex.Message);
				}
			}

			public List<ETC> GetAllFull()
			{
				try 
				{
                    List<ETC> l = SqlMapper.Query<ETC>(con, "API.PA_ETCGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ETC  ->" + ex.Message);
				}
			}
			
			public List<ETC> GetAllByWithRelation()
			{
				try 
                {
                    List<ETC> l = SqlMapper.Query<ETC>(con, "API.PA_ETCGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ETC  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ETC> GetByFilter(ETC pETC, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pETC.id== null || pETC.id==0) ? vintNUll :pETC.id);
                    p.Add("@ID_TipoETC",(pETC.ID_TipoETC== null || pETC.ID_TipoETC==0) ? vintNUll :pETC.ID_TipoETC);
                    p.Add("@Codigo",(pETC.Codigo== null) ? vintNUll :pETC.Codigo);
                    p.Add("@Nombre",(pETC.Nombre== null) ? vintNUll :pETC.Nombre);
                    p.Add("@ID_DiagnosticoSituacional",(pETC.ID_DiagnosticoSituacional== null || pETC.ID_DiagnosticoSituacional==0) ? vintNUll :pETC.ID_DiagnosticoSituacional);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ETC> l = SqlMapper.Query<ETC>(con, "API.PA_ETCGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ETC  ->" + ex.Message);
				}
			}

			public ETC Add(ETC pETC)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pETC.id==null ? 0 : pETC.id);
p.Add("@ID_TipoETC",pETC.ID_TipoETC==null ? 0 : pETC.ID_TipoETC);
                    p.Add("@Codigo", pETC.Codigo);
                    p.Add("@Nombre", pETC.Nombre);
p.Add("@ID_DiagnosticoSituacional",pETC.ID_DiagnosticoSituacional==null ? 0 : pETC.ID_DiagnosticoSituacional);
                    p.Add("@auditoria", pETC.auditoria);

                         


                    ETC o = SqlMapper.QueryFirstOrDefault<ETC>(con, "API.PA_ETCAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ETC  ->" + ex.Message);
				}
			}

			public ETC  Update(ETC pETC)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pETC.id==null ? 0 : pETC.id);
p.Add("@ID_TipoETC",pETC.ID_TipoETC==null ? 0 : pETC.ID_TipoETC);
                    p.Add("@Codigo", pETC.Codigo);
                    p.Add("@Nombre", pETC.Nombre);
p.Add("@ID_DiagnosticoSituacional",pETC.ID_DiagnosticoSituacional==null ? 0 : pETC.ID_DiagnosticoSituacional);
                    p.Add("@auditoria", pETC.auditoria);

                         


                    ETC o = SqlMapper.QueryFirstOrDefault<ETC>(con, "API.PA_ETCUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ETC  ->" + ex.Message);
				}
			}

			public bool Delete(ETC pETC)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pETC.id);
                    p.Add("@auditoria", pETC.auditoria);

                

 

					ETC o = SqlMapper.QueryFirstOrDefault<ETC>(con, "API.PA_ETCDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ETC  ->" + ex.Message);
				}
			}

		



            public List<ETC> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ETC> ETCList = new List<ETC>();

                    ETCList = SqlMapper.Query<ETC>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ETCList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ETC  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ETC> b)
            {
                DapperPlusManager.Entity<ETC>().Table("ETC");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}