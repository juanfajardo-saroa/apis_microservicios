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
     /// Clase Abstracta para  TiposETC
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposETCRepository : DataObject , ITiposETC 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposETCRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposETCRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposETC GetById(TiposETC pTiposETC)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposETC.id);                                    


    				TiposETC o = SqlMapper.QueryFirstOrDefault<TiposETC>(con, "API.PA_TiposETCGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposETC  ->" + ex.Message);
				}
			}

			public List<TiposETC> GetAll()
			{
				try 
                {
                        List<TiposETC> l = SqlMapper.Query<TiposETC>(con, "API.PA_TiposETCGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposETC  ->" + ex.Message);
				}
			}

			public List<TiposETC> GetAllFull()
			{
				try 
				{
                    List<TiposETC> l = SqlMapper.Query<TiposETC>(con, "API.PA_TiposETCGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposETC  ->" + ex.Message);
				}
			}
			
			public List<TiposETC> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposETC> l = SqlMapper.Query<TiposETC>(con, "API.PA_TiposETCGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposETC  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposETC> GetByFilter(TiposETC pTiposETC, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposETC.id== null || pTiposETC.id==0) ? vintNUll :pTiposETC.id);
                    p.Add("@Nombre",(pTiposETC.Nombre== null) ? vintNUll :pTiposETC.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposETC> l = SqlMapper.Query<TiposETC>(con, "API.PA_TiposETCGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposETC  ->" + ex.Message);
				}
			}

			public TiposETC Add(TiposETC pTiposETC)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposETC.id==null ? 0 : pTiposETC.id);
                    p.Add("@Nombre", pTiposETC.Nombre);
                    p.Add("@auditoria", pTiposETC.auditoria);

                         


                    TiposETC o = SqlMapper.QueryFirstOrDefault<TiposETC>(con, "API.PA_TiposETCAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposETC  ->" + ex.Message);
				}
			}

			public TiposETC  Update(TiposETC pTiposETC)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposETC.id==null ? 0 : pTiposETC.id);
                    p.Add("@Nombre", pTiposETC.Nombre);
                    p.Add("@auditoria", pTiposETC.auditoria);

                         


                    TiposETC o = SqlMapper.QueryFirstOrDefault<TiposETC>(con, "API.PA_TiposETCUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposETC  ->" + ex.Message);
				}
			}

			public bool Delete(TiposETC pTiposETC)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposETC.id);
                    p.Add("@auditoria", pTiposETC.auditoria);

                

 

					TiposETC o = SqlMapper.QueryFirstOrDefault<TiposETC>(con, "API.PA_TiposETCDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposETC  ->" + ex.Message);
				}
			}

		



            public List<TiposETC> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposETC> TiposETCList = new List<TiposETC>();

                    TiposETCList = SqlMapper.Query<TiposETC>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposETCList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposETC  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposETC> b)
            {
                DapperPlusManager.Entity<TiposETC>().Table("TiposETC");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}