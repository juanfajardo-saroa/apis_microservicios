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
     /// Clase Abstracta para  TiposPoblacionEtnica
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposPoblacionEtnicaRepository : DataObject , ITiposPoblacionEtnica 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposPoblacionEtnicaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposPoblacionEtnicaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposPoblacionEtnica GetById(TiposPoblacionEtnica pTiposPoblacionEtnica)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposPoblacionEtnica.id);                                    


    				TiposPoblacionEtnica o = SqlMapper.QueryFirstOrDefault<TiposPoblacionEtnica>(con, "API.PA_TiposPoblacionEtnicaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposPoblacionEtnica  ->" + ex.Message);
				}
			}

			public List<TiposPoblacionEtnica> GetAll()
			{
				try 
                {
                        List<TiposPoblacionEtnica> l = SqlMapper.Query<TiposPoblacionEtnica>(con, "API.PA_TiposPoblacionEtnicaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposPoblacionEtnica  ->" + ex.Message);
				}
			}

			public List<TiposPoblacionEtnica> GetAllFull()
			{
				try 
				{
                    List<TiposPoblacionEtnica> l = SqlMapper.Query<TiposPoblacionEtnica>(con, "API.PA_TiposPoblacionEtnicaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposPoblacionEtnica  ->" + ex.Message);
				}
			}
			
			public List<TiposPoblacionEtnica> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposPoblacionEtnica> l = SqlMapper.Query<TiposPoblacionEtnica>(con, "API.PA_TiposPoblacionEtnicaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposPoblacionEtnica  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposPoblacionEtnica> GetByFilter(TiposPoblacionEtnica pTiposPoblacionEtnica, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposPoblacionEtnica.id== null || pTiposPoblacionEtnica.id==0) ? vintNUll :pTiposPoblacionEtnica.id);
                    p.Add("@Nombre",(pTiposPoblacionEtnica.Nombre== null) ? vintNUll :pTiposPoblacionEtnica.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposPoblacionEtnica> l = SqlMapper.Query<TiposPoblacionEtnica>(con, "API.PA_TiposPoblacionEtnicaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposPoblacionEtnica  ->" + ex.Message);
				}
			}

			public TiposPoblacionEtnica Add(TiposPoblacionEtnica pTiposPoblacionEtnica)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposPoblacionEtnica.id==null ? 0 : pTiposPoblacionEtnica.id);
                    p.Add("@Nombre", pTiposPoblacionEtnica.Nombre);
                    p.Add("@auditoria", pTiposPoblacionEtnica.auditoria);

                         


                    TiposPoblacionEtnica o = SqlMapper.QueryFirstOrDefault<TiposPoblacionEtnica>(con, "API.PA_TiposPoblacionEtnicaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposPoblacionEtnica  ->" + ex.Message);
				}
			}

			public TiposPoblacionEtnica  Update(TiposPoblacionEtnica pTiposPoblacionEtnica)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposPoblacionEtnica.id==null ? 0 : pTiposPoblacionEtnica.id);
                    p.Add("@Nombre", pTiposPoblacionEtnica.Nombre);
                    p.Add("@auditoria", pTiposPoblacionEtnica.auditoria);

                         


                    TiposPoblacionEtnica o = SqlMapper.QueryFirstOrDefault<TiposPoblacionEtnica>(con, "API.PA_TiposPoblacionEtnicaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposPoblacionEtnica  ->" + ex.Message);
				}
			}

			public bool Delete(TiposPoblacionEtnica pTiposPoblacionEtnica)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposPoblacionEtnica.id);
                    p.Add("@auditoria", pTiposPoblacionEtnica.auditoria);

                

 

					TiposPoblacionEtnica o = SqlMapper.QueryFirstOrDefault<TiposPoblacionEtnica>(con, "API.PA_TiposPoblacionEtnicaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposPoblacionEtnica  ->" + ex.Message);
				}
			}

		



            public List<TiposPoblacionEtnica> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposPoblacionEtnica> TiposPoblacionEtnicaList = new List<TiposPoblacionEtnica>();

                    TiposPoblacionEtnicaList = SqlMapper.Query<TiposPoblacionEtnica>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposPoblacionEtnicaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposPoblacionEtnica  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposPoblacionEtnica> b)
            {
                DapperPlusManager.Entity<TiposPoblacionEtnica>().Table("TiposPoblacionEtnica");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}