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
     /// Clase Abstracta para  TiposProductosCompraLocal
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposProductosCompraLocalRepository : DataObject , ITiposProductosCompraLocal 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposProductosCompraLocalRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposProductosCompraLocalRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposProductosCompraLocal GetById(TiposProductosCompraLocal pTiposProductosCompraLocal)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposProductosCompraLocal.id);                                    


    				TiposProductosCompraLocal o = SqlMapper.QueryFirstOrDefault<TiposProductosCompraLocal>(con, "API.PA_TiposProductosCompraLocalGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposProductosCompraLocal  ->" + ex.Message);
				}
			}

			public List<TiposProductosCompraLocal> GetAll()
			{
				try 
                {
                        List<TiposProductosCompraLocal> l = SqlMapper.Query<TiposProductosCompraLocal>(con, "API.PA_TiposProductosCompraLocalGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposProductosCompraLocal  ->" + ex.Message);
				}
			}

			public List<TiposProductosCompraLocal> GetAllFull()
			{
				try 
				{
                    List<TiposProductosCompraLocal> l = SqlMapper.Query<TiposProductosCompraLocal>(con, "API.PA_TiposProductosCompraLocalGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposProductosCompraLocal  ->" + ex.Message);
				}
			}
			
			public List<TiposProductosCompraLocal> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposProductosCompraLocal> l = SqlMapper.Query<TiposProductosCompraLocal>(con, "API.PA_TiposProductosCompraLocalGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposProductosCompraLocal  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposProductosCompraLocal> GetByFilter(TiposProductosCompraLocal pTiposProductosCompraLocal, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposProductosCompraLocal.id== null || pTiposProductosCompraLocal.id==0) ? vintNUll :pTiposProductosCompraLocal.id);
                    p.Add("@Nombre",(pTiposProductosCompraLocal.Nombre== null) ? vintNUll :pTiposProductosCompraLocal.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposProductosCompraLocal> l = SqlMapper.Query<TiposProductosCompraLocal>(con, "API.PA_TiposProductosCompraLocalGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposProductosCompraLocal  ->" + ex.Message);
				}
			}

			public TiposProductosCompraLocal Add(TiposProductosCompraLocal pTiposProductosCompraLocal)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposProductosCompraLocal.id==null ? 0 : pTiposProductosCompraLocal.id);
                    p.Add("@Nombre", pTiposProductosCompraLocal.Nombre);
                    p.Add("@auditoria", pTiposProductosCompraLocal.auditoria);

                         


                    TiposProductosCompraLocal o = SqlMapper.QueryFirstOrDefault<TiposProductosCompraLocal>(con, "API.PA_TiposProductosCompraLocalAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposProductosCompraLocal  ->" + ex.Message);
				}
			}

			public TiposProductosCompraLocal  Update(TiposProductosCompraLocal pTiposProductosCompraLocal)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposProductosCompraLocal.id==null ? 0 : pTiposProductosCompraLocal.id);
                    p.Add("@Nombre", pTiposProductosCompraLocal.Nombre);
                    p.Add("@auditoria", pTiposProductosCompraLocal.auditoria);

                         


                    TiposProductosCompraLocal o = SqlMapper.QueryFirstOrDefault<TiposProductosCompraLocal>(con, "API.PA_TiposProductosCompraLocalUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposProductosCompraLocal  ->" + ex.Message);
				}
			}

			public bool Delete(TiposProductosCompraLocal pTiposProductosCompraLocal)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposProductosCompraLocal.id);
                    p.Add("@auditoria", pTiposProductosCompraLocal.auditoria);

                

 

					TiposProductosCompraLocal o = SqlMapper.QueryFirstOrDefault<TiposProductosCompraLocal>(con, "API.PA_TiposProductosCompraLocalDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposProductosCompraLocal  ->" + ex.Message);
				}
			}

		



            public List<TiposProductosCompraLocal> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposProductosCompraLocal> TiposProductosCompraLocalList = new List<TiposProductosCompraLocal>();

                    TiposProductosCompraLocalList = SqlMapper.Query<TiposProductosCompraLocal>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposProductosCompraLocalList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposProductosCompraLocal  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposProductosCompraLocal> b)
            {
                DapperPlusManager.Entity<TiposProductosCompraLocal>().Table("TiposProductosCompraLocal");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}