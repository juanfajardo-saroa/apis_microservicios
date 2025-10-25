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
     /// Clase Abstracta para  TiposGrupoEtario
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposGrupoEtarioRepository : DataObject , ITiposGrupoEtario 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposGrupoEtarioRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposGrupoEtarioRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposGrupoEtario GetById(TiposGrupoEtario pTiposGrupoEtario)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposGrupoEtario.id);                                    


    				TiposGrupoEtario o = SqlMapper.QueryFirstOrDefault<TiposGrupoEtario>(con, "API.PA_TiposGrupoEtarioGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposGrupoEtario  ->" + ex.Message);
				}
			}

			public List<TiposGrupoEtario> GetAll()
			{
				try 
                {
                        List<TiposGrupoEtario> l = SqlMapper.Query<TiposGrupoEtario>(con, "API.PA_TiposGrupoEtarioGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposGrupoEtario  ->" + ex.Message);
				}
			}

			public List<TiposGrupoEtario> GetAllFull()
			{
				try 
				{
                    List<TiposGrupoEtario> l = SqlMapper.Query<TiposGrupoEtario>(con, "API.PA_TiposGrupoEtarioGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposGrupoEtario  ->" + ex.Message);
				}
			}
			
			public List<TiposGrupoEtario> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposGrupoEtario> l = SqlMapper.Query<TiposGrupoEtario>(con, "API.PA_TiposGrupoEtarioGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposGrupoEtario  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposGrupoEtario> GetByFilter(TiposGrupoEtario pTiposGrupoEtario, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposGrupoEtario.id== null || pTiposGrupoEtario.id==0) ? vintNUll :pTiposGrupoEtario.id);
                    p.Add("@Nombre",(pTiposGrupoEtario.Nombre== null) ? vintNUll :pTiposGrupoEtario.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposGrupoEtario> l = SqlMapper.Query<TiposGrupoEtario>(con, "API.PA_TiposGrupoEtarioGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposGrupoEtario  ->" + ex.Message);
				}
			}

			public TiposGrupoEtario Add(TiposGrupoEtario pTiposGrupoEtario)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposGrupoEtario.id==null ? 0 : pTiposGrupoEtario.id);
                    p.Add("@Nombre", pTiposGrupoEtario.Nombre);
                    p.Add("@auditoria", pTiposGrupoEtario.auditoria);

                         


                    TiposGrupoEtario o = SqlMapper.QueryFirstOrDefault<TiposGrupoEtario>(con, "API.PA_TiposGrupoEtarioAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposGrupoEtario  ->" + ex.Message);
				}
			}

			public TiposGrupoEtario  Update(TiposGrupoEtario pTiposGrupoEtario)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposGrupoEtario.id==null ? 0 : pTiposGrupoEtario.id);
                    p.Add("@Nombre", pTiposGrupoEtario.Nombre);
                    p.Add("@auditoria", pTiposGrupoEtario.auditoria);

                         


                    TiposGrupoEtario o = SqlMapper.QueryFirstOrDefault<TiposGrupoEtario>(con, "API.PA_TiposGrupoEtarioUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposGrupoEtario  ->" + ex.Message);
				}
			}

			public bool Delete(TiposGrupoEtario pTiposGrupoEtario)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposGrupoEtario.id);
                    p.Add("@auditoria", pTiposGrupoEtario.auditoria);

                

 

					TiposGrupoEtario o = SqlMapper.QueryFirstOrDefault<TiposGrupoEtario>(con, "API.PA_TiposGrupoEtarioDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposGrupoEtario  ->" + ex.Message);
				}
			}

		



            public List<TiposGrupoEtario> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposGrupoEtario> TiposGrupoEtarioList = new List<TiposGrupoEtario>();

                    TiposGrupoEtarioList = SqlMapper.Query<TiposGrupoEtario>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposGrupoEtarioList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposGrupoEtario  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposGrupoEtario> b)
            {
                DapperPlusManager.Entity<TiposGrupoEtario>().Table("TiposGrupoEtario");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}