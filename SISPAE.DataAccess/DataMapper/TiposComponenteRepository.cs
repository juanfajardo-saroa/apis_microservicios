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
     /// Clase Abstracta para  TiposComponente
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposComponenteRepository : DataObject , ITiposComponente 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposComponenteRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposComponenteRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposComponente GetById(TiposComponente pTiposComponente)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposComponente.id);                                    


    				TiposComponente o = SqlMapper.QueryFirstOrDefault<TiposComponente>(con, "API.PA_TiposComponenteGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposComponente  ->" + ex.Message);
				}
			}

			public List<TiposComponente> GetAll()
			{
				try 
                {
                        List<TiposComponente> l = SqlMapper.Query<TiposComponente>(con, "API.PA_TiposComponenteGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposComponente  ->" + ex.Message);
				}
			}

			public List<TiposComponente> GetAllFull()
			{
				try 
				{
                    List<TiposComponente> l = SqlMapper.Query<TiposComponente>(con, "API.PA_TiposComponenteGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposComponente  ->" + ex.Message);
				}
			}
			
			public List<TiposComponente> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposComponente> l = SqlMapper.Query<TiposComponente>(con, "API.PA_TiposComponenteGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposComponente  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposComponente> GetByFilter(TiposComponente pTiposComponente, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposComponente.id== null || pTiposComponente.id==0) ? vintNUll :pTiposComponente.id);
                    p.Add("@Nombre",(pTiposComponente.Nombre== null) ? vintNUll :pTiposComponente.Nombre);
                    p.Add("@UnidadMedida",(pTiposComponente.UnidadMedida== null) ? vintNUll :pTiposComponente.UnidadMedida);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposComponente> l = SqlMapper.Query<TiposComponente>(con, "API.PA_TiposComponenteGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposComponente  ->" + ex.Message);
				}
			}

			public TiposComponente Add(TiposComponente pTiposComponente)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposComponente.id==null ? 0 : pTiposComponente.id);
                    p.Add("@Nombre", pTiposComponente.Nombre);
                    p.Add("@UnidadMedida", pTiposComponente.UnidadMedida);
                    p.Add("@auditoria", pTiposComponente.auditoria);

                         


                    TiposComponente o = SqlMapper.QueryFirstOrDefault<TiposComponente>(con, "API.PA_TiposComponenteAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposComponente  ->" + ex.Message);
				}
			}

			public TiposComponente  Update(TiposComponente pTiposComponente)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposComponente.id==null ? 0 : pTiposComponente.id);
                    p.Add("@Nombre", pTiposComponente.Nombre);
                    p.Add("@UnidadMedida", pTiposComponente.UnidadMedida);
                    p.Add("@auditoria", pTiposComponente.auditoria);

                         


                    TiposComponente o = SqlMapper.QueryFirstOrDefault<TiposComponente>(con, "API.PA_TiposComponenteUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposComponente  ->" + ex.Message);
				}
			}

			public bool Delete(TiposComponente pTiposComponente)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposComponente.id);
                    p.Add("@auditoria", pTiposComponente.auditoria);

                

 

					TiposComponente o = SqlMapper.QueryFirstOrDefault<TiposComponente>(con, "API.PA_TiposComponenteDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposComponente  ->" + ex.Message);
				}
			}

		



            public List<TiposComponente> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposComponente> TiposComponenteList = new List<TiposComponente>();

                    TiposComponenteList = SqlMapper.Query<TiposComponente>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposComponenteList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposComponente  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposComponente> b)
            {
                DapperPlusManager.Entity<TiposComponente>().Table("TiposComponente");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}