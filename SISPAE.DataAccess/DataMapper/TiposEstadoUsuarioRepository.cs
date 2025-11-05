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
     /// Clase Abstracta para  TiposEstadoUsuario
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposEstadoUsuarioRepository : DataObject , ITiposEstadoUsuario 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposEstadoUsuarioRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposEstadoUsuarioRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposEstadoUsuario GetById(TiposEstadoUsuario pTiposEstadoUsuario)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadoUsuario.id);                                    


    				TiposEstadoUsuario o = SqlMapper.QueryFirstOrDefault<TiposEstadoUsuario>(con, "API.PA_TiposEstadoUsuarioGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposEstadoUsuario  ->" + ex.Message);
				}
			}

			public List<TiposEstadoUsuario> GetAll()
			{
				try 
                {
                        List<TiposEstadoUsuario> l = SqlMapper.Query<TiposEstadoUsuario>(con, "API.PA_TiposEstadoUsuarioGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposEstadoUsuario  ->" + ex.Message);
				}
			}

			public List<TiposEstadoUsuario> GetAllFull()
			{
				try 
				{
                    List<TiposEstadoUsuario> l = SqlMapper.Query<TiposEstadoUsuario>(con, "API.PA_TiposEstadoUsuarioGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposEstadoUsuario  ->" + ex.Message);
				}
			}
			
			public List<TiposEstadoUsuario> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposEstadoUsuario> l = SqlMapper.Query<TiposEstadoUsuario>(con, "API.PA_TiposEstadoUsuarioGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposEstadoUsuario  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposEstadoUsuario> GetByFilter(TiposEstadoUsuario pTiposEstadoUsuario, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposEstadoUsuario.id== null || pTiposEstadoUsuario.id==0) ? vintNUll :pTiposEstadoUsuario.id);
                    p.Add("@Nombre",(pTiposEstadoUsuario.Nombre== null) ? vintNUll :pTiposEstadoUsuario.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposEstadoUsuario> l = SqlMapper.Query<TiposEstadoUsuario>(con, "API.PA_TiposEstadoUsuarioGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposEstadoUsuario  ->" + ex.Message);
				}
			}

			public TiposEstadoUsuario Add(TiposEstadoUsuario pTiposEstadoUsuario)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposEstadoUsuario.id==null ? 0 : pTiposEstadoUsuario.id);
                    p.Add("@Nombre", pTiposEstadoUsuario.Nombre);
                    p.Add("@auditoria", pTiposEstadoUsuario.auditoria);

                         


                    TiposEstadoUsuario o = SqlMapper.QueryFirstOrDefault<TiposEstadoUsuario>(con, "API.PA_TiposEstadoUsuarioAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposEstadoUsuario  ->" + ex.Message);
				}
			}

			public TiposEstadoUsuario  Update(TiposEstadoUsuario pTiposEstadoUsuario)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposEstadoUsuario.id==null ? 0 : pTiposEstadoUsuario.id);
                    p.Add("@Nombre", pTiposEstadoUsuario.Nombre);
                    p.Add("@auditoria", pTiposEstadoUsuario.auditoria);

                         


                    TiposEstadoUsuario o = SqlMapper.QueryFirstOrDefault<TiposEstadoUsuario>(con, "API.PA_TiposEstadoUsuarioUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposEstadoUsuario  ->" + ex.Message);
				}
			}

			public bool Delete(TiposEstadoUsuario pTiposEstadoUsuario)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadoUsuario.id);
                    p.Add("@auditoria", pTiposEstadoUsuario.auditoria);

                

 

					TiposEstadoUsuario o = SqlMapper.QueryFirstOrDefault<TiposEstadoUsuario>(con, "API.PA_TiposEstadoUsuarioDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposEstadoUsuario  ->" + ex.Message);
				}
			}

		



            public List<TiposEstadoUsuario> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposEstadoUsuario> TiposEstadoUsuarioList = new List<TiposEstadoUsuario>();

                    TiposEstadoUsuarioList = SqlMapper.Query<TiposEstadoUsuario>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposEstadoUsuarioList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposEstadoUsuario  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposEstadoUsuario> b)
            {
                DapperPlusManager.Entity<TiposEstadoUsuario>().Table("TiposEstadoUsuario");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}