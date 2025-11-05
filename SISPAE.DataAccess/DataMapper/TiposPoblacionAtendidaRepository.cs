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
     /// Clase Abstracta para  TiposPoblacionAtendida
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposPoblacionAtendidaRepository : DataObject , ITiposPoblacionAtendida 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposPoblacionAtendidaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposPoblacionAtendidaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposPoblacionAtendida GetById(TiposPoblacionAtendida pTiposPoblacionAtendida)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposPoblacionAtendida.id);                                    


    				TiposPoblacionAtendida o = SqlMapper.QueryFirstOrDefault<TiposPoblacionAtendida>(con, "API.PA_TiposPoblacionAtendidaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposPoblacionAtendida  ->" + ex.Message);
				}
			}

			public List<TiposPoblacionAtendida> GetAll()
			{
				try 
                {
                        List<TiposPoblacionAtendida> l = SqlMapper.Query<TiposPoblacionAtendida>(con, "API.PA_TiposPoblacionAtendidaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposPoblacionAtendida  ->" + ex.Message);
				}
			}

			public List<TiposPoblacionAtendida> GetAllFull()
			{
				try 
				{
                    List<TiposPoblacionAtendida> l = SqlMapper.Query<TiposPoblacionAtendida>(con, "API.PA_TiposPoblacionAtendidaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposPoblacionAtendida  ->" + ex.Message);
				}
			}
			
			public List<TiposPoblacionAtendida> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposPoblacionAtendida> l = SqlMapper.Query<TiposPoblacionAtendida>(con, "API.PA_TiposPoblacionAtendidaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposPoblacionAtendida  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposPoblacionAtendida> GetByFilter(TiposPoblacionAtendida pTiposPoblacionAtendida, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposPoblacionAtendida.id== null || pTiposPoblacionAtendida.id==0) ? vintNUll :pTiposPoblacionAtendida.id);
                    p.Add("@Nombre",(pTiposPoblacionAtendida.Nombre== null) ? vintNUll :pTiposPoblacionAtendida.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposPoblacionAtendida> l = SqlMapper.Query<TiposPoblacionAtendida>(con, "API.PA_TiposPoblacionAtendidaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposPoblacionAtendida  ->" + ex.Message);
				}
			}

			public TiposPoblacionAtendida Add(TiposPoblacionAtendida pTiposPoblacionAtendida)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposPoblacionAtendida.id==null ? 0 : pTiposPoblacionAtendida.id);
                    p.Add("@Nombre", pTiposPoblacionAtendida.Nombre);
                    p.Add("@auditoria", pTiposPoblacionAtendida.auditoria);

                         


                    TiposPoblacionAtendida o = SqlMapper.QueryFirstOrDefault<TiposPoblacionAtendida>(con, "API.PA_TiposPoblacionAtendidaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposPoblacionAtendida  ->" + ex.Message);
				}
			}

			public TiposPoblacionAtendida  Update(TiposPoblacionAtendida pTiposPoblacionAtendida)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposPoblacionAtendida.id==null ? 0 : pTiposPoblacionAtendida.id);
                    p.Add("@Nombre", pTiposPoblacionAtendida.Nombre);
                    p.Add("@auditoria", pTiposPoblacionAtendida.auditoria);

                         


                    TiposPoblacionAtendida o = SqlMapper.QueryFirstOrDefault<TiposPoblacionAtendida>(con, "API.PA_TiposPoblacionAtendidaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposPoblacionAtendida  ->" + ex.Message);
				}
			}

			public bool Delete(TiposPoblacionAtendida pTiposPoblacionAtendida)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposPoblacionAtendida.id);
                    p.Add("@auditoria", pTiposPoblacionAtendida.auditoria);

                

 

					TiposPoblacionAtendida o = SqlMapper.QueryFirstOrDefault<TiposPoblacionAtendida>(con, "API.PA_TiposPoblacionAtendidaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposPoblacionAtendida  ->" + ex.Message);
				}
			}

		



            public List<TiposPoblacionAtendida> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposPoblacionAtendida> TiposPoblacionAtendidaList = new List<TiposPoblacionAtendida>();

                    TiposPoblacionAtendidaList = SqlMapper.Query<TiposPoblacionAtendida>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposPoblacionAtendidaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposPoblacionAtendida  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposPoblacionAtendida> b)
            {
                DapperPlusManager.Entity<TiposPoblacionAtendida>().Table("TiposPoblacionAtendida");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}