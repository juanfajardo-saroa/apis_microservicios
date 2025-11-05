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
     /// Clase Abstracta para  TiposTiemposEntrega
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposTiemposEntregaRepository : DataObject , ITiposTiemposEntrega 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposTiemposEntregaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposTiemposEntregaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposTiemposEntrega GetById(TiposTiemposEntrega pTiposTiemposEntrega)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposTiemposEntrega.id);                                    


    				TiposTiemposEntrega o = SqlMapper.QueryFirstOrDefault<TiposTiemposEntrega>(con, "API.PA_TiposTiemposEntregaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposTiemposEntrega  ->" + ex.Message);
				}
			}

			public List<TiposTiemposEntrega> GetAll()
			{
				try 
                {
                        List<TiposTiemposEntrega> l = SqlMapper.Query<TiposTiemposEntrega>(con, "API.PA_TiposTiemposEntregaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposTiemposEntrega  ->" + ex.Message);
				}
			}

			public List<TiposTiemposEntrega> GetAllFull()
			{
				try 
				{
                    List<TiposTiemposEntrega> l = SqlMapper.Query<TiposTiemposEntrega>(con, "API.PA_TiposTiemposEntregaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposTiemposEntrega  ->" + ex.Message);
				}
			}
			
			public List<TiposTiemposEntrega> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposTiemposEntrega> l = SqlMapper.Query<TiposTiemposEntrega>(con, "API.PA_TiposTiemposEntregaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposTiemposEntrega  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposTiemposEntrega> GetByFilter(TiposTiemposEntrega pTiposTiemposEntrega, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposTiemposEntrega.id== null || pTiposTiemposEntrega.id==0) ? vintNUll :pTiposTiemposEntrega.id);
                    p.Add("@Nombre",(pTiposTiemposEntrega.Nombre== null) ? vintNUll :pTiposTiemposEntrega.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposTiemposEntrega> l = SqlMapper.Query<TiposTiemposEntrega>(con, "API.PA_TiposTiemposEntregaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposTiemposEntrega  ->" + ex.Message);
				}
			}

			public TiposTiemposEntrega Add(TiposTiemposEntrega pTiposTiemposEntrega)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposTiemposEntrega.id==null ? 0 : pTiposTiemposEntrega.id);
                    p.Add("@Nombre", pTiposTiemposEntrega.Nombre);
                    p.Add("@auditoria", pTiposTiemposEntrega.auditoria);

                         


                    TiposTiemposEntrega o = SqlMapper.QueryFirstOrDefault<TiposTiemposEntrega>(con, "API.PA_TiposTiemposEntregaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposTiemposEntrega  ->" + ex.Message);
				}
			}

			public TiposTiemposEntrega  Update(TiposTiemposEntrega pTiposTiemposEntrega)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposTiemposEntrega.id==null ? 0 : pTiposTiemposEntrega.id);
                    p.Add("@Nombre", pTiposTiemposEntrega.Nombre);
                    p.Add("@auditoria", pTiposTiemposEntrega.auditoria);

                         


                    TiposTiemposEntrega o = SqlMapper.QueryFirstOrDefault<TiposTiemposEntrega>(con, "API.PA_TiposTiemposEntregaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposTiemposEntrega  ->" + ex.Message);
				}
			}

			public bool Delete(TiposTiemposEntrega pTiposTiemposEntrega)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposTiemposEntrega.id);
                    p.Add("@auditoria", pTiposTiemposEntrega.auditoria);

                

 

					TiposTiemposEntrega o = SqlMapper.QueryFirstOrDefault<TiposTiemposEntrega>(con, "API.PA_TiposTiemposEntregaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposTiemposEntrega  ->" + ex.Message);
				}
			}

		



            public List<TiposTiemposEntrega> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposTiemposEntrega> TiposTiemposEntregaList = new List<TiposTiemposEntrega>();

                    TiposTiemposEntregaList = SqlMapper.Query<TiposTiemposEntrega>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposTiemposEntregaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposTiemposEntrega  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposTiemposEntrega> b)
            {
                DapperPlusManager.Entity<TiposTiemposEntrega>().Table("TiposTiemposEntrega");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}