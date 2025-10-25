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
     /// Clase Abstracta para  TiposVisita
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposVisitaRepository : DataObject , ITiposVisita 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposVisitaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposVisitaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposVisita GetById(TiposVisita pTiposVisita)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposVisita.id);                                    


    				TiposVisita o = SqlMapper.QueryFirstOrDefault<TiposVisita>(con, "API.PA_TiposVisitaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposVisita  ->" + ex.Message);
				}
			}

			public List<TiposVisita> GetAll()
			{
				try 
                {
                        List<TiposVisita> l = SqlMapper.Query<TiposVisita>(con, "API.PA_TiposVisitaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposVisita  ->" + ex.Message);
				}
			}

			public List<TiposVisita> GetAllFull()
			{
				try 
				{
                    List<TiposVisita> l = SqlMapper.Query<TiposVisita>(con, "API.PA_TiposVisitaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposVisita  ->" + ex.Message);
				}
			}
			
			public List<TiposVisita> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposVisita> l = SqlMapper.Query<TiposVisita>(con, "API.PA_TiposVisitaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposVisita  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposVisita> GetByFilter(TiposVisita pTiposVisita, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposVisita.id== null || pTiposVisita.id==0) ? vintNUll :pTiposVisita.id);
                    p.Add("@Nombre",(pTiposVisita.Nombre== null) ? vintNUll :pTiposVisita.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposVisita> l = SqlMapper.Query<TiposVisita>(con, "API.PA_TiposVisitaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposVisita  ->" + ex.Message);
				}
			}

			public TiposVisita Add(TiposVisita pTiposVisita)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposVisita.id==null ? 0 : pTiposVisita.id);
                    p.Add("@Nombre", pTiposVisita.Nombre);
                    p.Add("@auditoria", pTiposVisita.auditoria);

                         


                    TiposVisita o = SqlMapper.QueryFirstOrDefault<TiposVisita>(con, "API.PA_TiposVisitaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposVisita  ->" + ex.Message);
				}
			}

			public TiposVisita  Update(TiposVisita pTiposVisita)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposVisita.id==null ? 0 : pTiposVisita.id);
                    p.Add("@Nombre", pTiposVisita.Nombre);
                    p.Add("@auditoria", pTiposVisita.auditoria);

                         


                    TiposVisita o = SqlMapper.QueryFirstOrDefault<TiposVisita>(con, "API.PA_TiposVisitaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposVisita  ->" + ex.Message);
				}
			}

			public bool Delete(TiposVisita pTiposVisita)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposVisita.id);
                    p.Add("@auditoria", pTiposVisita.auditoria);

                

 

					TiposVisita o = SqlMapper.QueryFirstOrDefault<TiposVisita>(con, "API.PA_TiposVisitaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposVisita  ->" + ex.Message);
				}
			}

		



            public List<TiposVisita> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposVisita> TiposVisitaList = new List<TiposVisita>();

                    TiposVisitaList = SqlMapper.Query<TiposVisita>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposVisitaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposVisita  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposVisita> b)
            {
                DapperPlusManager.Entity<TiposVisita>().Table("TiposVisita");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}