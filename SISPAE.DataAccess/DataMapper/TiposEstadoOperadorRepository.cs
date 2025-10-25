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
     /// Clase Abstracta para  TiposEstadoOperador
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposEstadoOperadorRepository : DataObject , ITiposEstadoOperador 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposEstadoOperadorRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposEstadoOperadorRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposEstadoOperador GetById(TiposEstadoOperador pTiposEstadoOperador)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadoOperador.id);                                    


    				TiposEstadoOperador o = SqlMapper.QueryFirstOrDefault<TiposEstadoOperador>(con, "API.PA_TiposEstadoOperadorGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposEstadoOperador  ->" + ex.Message);
				}
			}

			public List<TiposEstadoOperador> GetAll()
			{
				try 
                {
                        List<TiposEstadoOperador> l = SqlMapper.Query<TiposEstadoOperador>(con, "API.PA_TiposEstadoOperadorGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposEstadoOperador  ->" + ex.Message);
				}
			}

			public List<TiposEstadoOperador> GetAllFull()
			{
				try 
				{
                    List<TiposEstadoOperador> l = SqlMapper.Query<TiposEstadoOperador>(con, "API.PA_TiposEstadoOperadorGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposEstadoOperador  ->" + ex.Message);
				}
			}
			
			public List<TiposEstadoOperador> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposEstadoOperador> l = SqlMapper.Query<TiposEstadoOperador>(con, "API.PA_TiposEstadoOperadorGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposEstadoOperador  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposEstadoOperador> GetByFilter(TiposEstadoOperador pTiposEstadoOperador, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposEstadoOperador.id== null || pTiposEstadoOperador.id==0) ? vintNUll :pTiposEstadoOperador.id);
                    p.Add("@id",(pTiposEstadoOperador.id== null || pTiposEstadoOperador.id==0) ? vintNUll :pTiposEstadoOperador.id);
                    p.Add("@Nombre",(pTiposEstadoOperador.Nombre== null) ? vintNUll :pTiposEstadoOperador.Nombre);
                    p.Add("@Nombre",(pTiposEstadoOperador.Nombre== null) ? vintNUll :pTiposEstadoOperador.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposEstadoOperador> l = SqlMapper.Query<TiposEstadoOperador>(con, "API.PA_TiposEstadoOperadorGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposEstadoOperador  ->" + ex.Message);
				}
			}

			public TiposEstadoOperador Add(TiposEstadoOperador pTiposEstadoOperador)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposEstadoOperador.id==null ? 0 : pTiposEstadoOperador.id);
p.Add("@id",pTiposEstadoOperador.id==null ? 0 : pTiposEstadoOperador.id);
                    p.Add("@Nombre", pTiposEstadoOperador.Nombre);
                    p.Add("@Nombre", pTiposEstadoOperador.Nombre);
                    p.Add("@auditoria", pTiposEstadoOperador.auditoria);

                         


                    TiposEstadoOperador o = SqlMapper.QueryFirstOrDefault<TiposEstadoOperador>(con, "API.PA_TiposEstadoOperadorAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposEstadoOperador  ->" + ex.Message);
				}
			}

			public TiposEstadoOperador  Update(TiposEstadoOperador pTiposEstadoOperador)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposEstadoOperador.id==null ? 0 : pTiposEstadoOperador.id);
p.Add("@id",pTiposEstadoOperador.id==null ? 0 : pTiposEstadoOperador.id);
                    p.Add("@Nombre", pTiposEstadoOperador.Nombre);
                    p.Add("@Nombre", pTiposEstadoOperador.Nombre);
                    p.Add("@auditoria", pTiposEstadoOperador.auditoria);

                         


                    TiposEstadoOperador o = SqlMapper.QueryFirstOrDefault<TiposEstadoOperador>(con, "API.PA_TiposEstadoOperadorUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposEstadoOperador  ->" + ex.Message);
				}
			}

			public bool Delete(TiposEstadoOperador pTiposEstadoOperador)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadoOperador.id);
                    p.Add("@auditoria", pTiposEstadoOperador.auditoria);

                

 

					TiposEstadoOperador o = SqlMapper.QueryFirstOrDefault<TiposEstadoOperador>(con, "API.PA_TiposEstadoOperadorDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposEstadoOperador  ->" + ex.Message);
				}
			}

		



            public List<TiposEstadoOperador> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposEstadoOperador> TiposEstadoOperadorList = new List<TiposEstadoOperador>();

                    TiposEstadoOperadorList = SqlMapper.Query<TiposEstadoOperador>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposEstadoOperadorList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposEstadoOperador  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposEstadoOperador> b)
            {
                DapperPlusManager.Entity<TiposEstadoOperador>().Table("TiposEstadoOperador");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}