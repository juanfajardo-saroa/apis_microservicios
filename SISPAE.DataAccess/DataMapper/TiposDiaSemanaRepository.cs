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
     /// Clase Abstracta para  TiposDiaSemana
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposDiaSemanaRepository : DataObject , ITiposDiaSemana 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposDiaSemanaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposDiaSemanaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposDiaSemana GetById(TiposDiaSemana pTiposDiaSemana)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposDiaSemana.id);                                    


    				TiposDiaSemana o = SqlMapper.QueryFirstOrDefault<TiposDiaSemana>(con, "API.PA_TiposDiaSemanaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposDiaSemana  ->" + ex.Message);
				}
			}

			public List<TiposDiaSemana> GetAll()
			{
				try 
                {
                        List<TiposDiaSemana> l = SqlMapper.Query<TiposDiaSemana>(con, "API.PA_TiposDiaSemanaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposDiaSemana  ->" + ex.Message);
				}
			}

			public List<TiposDiaSemana> GetAllFull()
			{
				try 
				{
                    List<TiposDiaSemana> l = SqlMapper.Query<TiposDiaSemana>(con, "API.PA_TiposDiaSemanaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposDiaSemana  ->" + ex.Message);
				}
			}
			
			public List<TiposDiaSemana> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposDiaSemana> l = SqlMapper.Query<TiposDiaSemana>(con, "API.PA_TiposDiaSemanaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposDiaSemana  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposDiaSemana> GetByFilter(TiposDiaSemana pTiposDiaSemana, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposDiaSemana.id== null || pTiposDiaSemana.id==0) ? vintNUll :pTiposDiaSemana.id);
                    p.Add("@Nombre",(pTiposDiaSemana.Nombre== null) ? vintNUll :pTiposDiaSemana.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposDiaSemana> l = SqlMapper.Query<TiposDiaSemana>(con, "API.PA_TiposDiaSemanaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposDiaSemana  ->" + ex.Message);
				}
			}

			public TiposDiaSemana Add(TiposDiaSemana pTiposDiaSemana)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposDiaSemana.id==null ? 0 : pTiposDiaSemana.id);
                    p.Add("@Nombre", pTiposDiaSemana.Nombre);
                    p.Add("@auditoria", pTiposDiaSemana.auditoria);

                         


                    TiposDiaSemana o = SqlMapper.QueryFirstOrDefault<TiposDiaSemana>(con, "API.PA_TiposDiaSemanaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposDiaSemana  ->" + ex.Message);
				}
			}

			public TiposDiaSemana  Update(TiposDiaSemana pTiposDiaSemana)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposDiaSemana.id==null ? 0 : pTiposDiaSemana.id);
                    p.Add("@Nombre", pTiposDiaSemana.Nombre);
                    p.Add("@auditoria", pTiposDiaSemana.auditoria);

                         


                    TiposDiaSemana o = SqlMapper.QueryFirstOrDefault<TiposDiaSemana>(con, "API.PA_TiposDiaSemanaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposDiaSemana  ->" + ex.Message);
				}
			}

			public bool Delete(TiposDiaSemana pTiposDiaSemana)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposDiaSemana.id);
                    p.Add("@auditoria", pTiposDiaSemana.auditoria);

                

 

					TiposDiaSemana o = SqlMapper.QueryFirstOrDefault<TiposDiaSemana>(con, "API.PA_TiposDiaSemanaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposDiaSemana  ->" + ex.Message);
				}
			}

		



            public List<TiposDiaSemana> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposDiaSemana> TiposDiaSemanaList = new List<TiposDiaSemana>();

                    TiposDiaSemanaList = SqlMapper.Query<TiposDiaSemana>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposDiaSemanaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposDiaSemana  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposDiaSemana> b)
            {
                DapperPlusManager.Entity<TiposDiaSemana>().Table("TiposDiaSemana");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}