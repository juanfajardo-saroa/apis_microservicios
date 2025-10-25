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
     /// Clase Abstracta para  TiposContratoCHIP
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposContratoCHIPRepository : DataObject , ITiposContratoCHIP 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposContratoCHIPRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposContratoCHIPRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposContratoCHIP GetById(TiposContratoCHIP pTiposContratoCHIP)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposContratoCHIP.id);                                    


    				TiposContratoCHIP o = SqlMapper.QueryFirstOrDefault<TiposContratoCHIP>(con, "API.PA_TiposContratoCHIPGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposContratoCHIP  ->" + ex.Message);
				}
			}

			public List<TiposContratoCHIP> GetAll()
			{
				try 
                {
                        List<TiposContratoCHIP> l = SqlMapper.Query<TiposContratoCHIP>(con, "API.PA_TiposContratoCHIPGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposContratoCHIP  ->" + ex.Message);
				}
			}

			public List<TiposContratoCHIP> GetAllFull()
			{
				try 
				{
                    List<TiposContratoCHIP> l = SqlMapper.Query<TiposContratoCHIP>(con, "API.PA_TiposContratoCHIPGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposContratoCHIP  ->" + ex.Message);
				}
			}
			
			public List<TiposContratoCHIP> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposContratoCHIP> l = SqlMapper.Query<TiposContratoCHIP>(con, "API.PA_TiposContratoCHIPGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposContratoCHIP  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposContratoCHIP> GetByFilter(TiposContratoCHIP pTiposContratoCHIP, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposContratoCHIP.id== null || pTiposContratoCHIP.id==0) ? vintNUll :pTiposContratoCHIP.id);
                    p.Add("@Nombre",(pTiposContratoCHIP.Nombre== null) ? vintNUll :pTiposContratoCHIP.Nombre);
                    p.Add("@CodigoCHIP",(pTiposContratoCHIP.CodigoCHIP== null) ? vintNUll :pTiposContratoCHIP.CodigoCHIP);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposContratoCHIP> l = SqlMapper.Query<TiposContratoCHIP>(con, "API.PA_TiposContratoCHIPGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposContratoCHIP  ->" + ex.Message);
				}
			}

			public TiposContratoCHIP Add(TiposContratoCHIP pTiposContratoCHIP)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposContratoCHIP.id==null ? 0 : pTiposContratoCHIP.id);
                    p.Add("@Nombre", pTiposContratoCHIP.Nombre);
p.Add("@CodigoCHIP",pTiposContratoCHIP.CodigoCHIP==null ? 0 : pTiposContratoCHIP.CodigoCHIP);
                    p.Add("@auditoria", pTiposContratoCHIP.auditoria);

                         


                    TiposContratoCHIP o = SqlMapper.QueryFirstOrDefault<TiposContratoCHIP>(con, "API.PA_TiposContratoCHIPAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposContratoCHIP  ->" + ex.Message);
				}
			}

			public TiposContratoCHIP  Update(TiposContratoCHIP pTiposContratoCHIP)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposContratoCHIP.id==null ? 0 : pTiposContratoCHIP.id);
                    p.Add("@Nombre", pTiposContratoCHIP.Nombre);
p.Add("@CodigoCHIP",pTiposContratoCHIP.CodigoCHIP==null ? 0 : pTiposContratoCHIP.CodigoCHIP);
                    p.Add("@auditoria", pTiposContratoCHIP.auditoria);

                         


                    TiposContratoCHIP o = SqlMapper.QueryFirstOrDefault<TiposContratoCHIP>(con, "API.PA_TiposContratoCHIPUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposContratoCHIP  ->" + ex.Message);
				}
			}

			public bool Delete(TiposContratoCHIP pTiposContratoCHIP)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposContratoCHIP.id);
                    p.Add("@auditoria", pTiposContratoCHIP.auditoria);

                

 

					TiposContratoCHIP o = SqlMapper.QueryFirstOrDefault<TiposContratoCHIP>(con, "API.PA_TiposContratoCHIPDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposContratoCHIP  ->" + ex.Message);
				}
			}

		



            public List<TiposContratoCHIP> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposContratoCHIP> TiposContratoCHIPList = new List<TiposContratoCHIP>();

                    TiposContratoCHIPList = SqlMapper.Query<TiposContratoCHIP>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposContratoCHIPList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposContratoCHIP  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposContratoCHIP> b)
            {
                DapperPlusManager.Entity<TiposContratoCHIP>().Table("TiposContratoCHIP");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}