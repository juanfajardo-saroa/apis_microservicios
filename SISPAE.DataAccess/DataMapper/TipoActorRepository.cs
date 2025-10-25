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
     /// Clase Abstracta para  TipoActor
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoActorRepository : DataObject , ITipoActor 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoActorRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoActorRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoActor GetById(TipoActor pTipoActor)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoActor.id);                                    


    				TipoActor o = SqlMapper.QueryFirstOrDefault<TipoActor>(con, "API.PA_TipoActorGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoActor  ->" + ex.Message);
				}
			}

			public List<TipoActor> GetAll()
			{
				try 
                {
                        List<TipoActor> l = SqlMapper.Query<TipoActor>(con, "API.PA_TipoActorGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoActor  ->" + ex.Message);
				}
			}

			public List<TipoActor> GetAllFull()
			{
				try 
				{
                    List<TipoActor> l = SqlMapper.Query<TipoActor>(con, "API.PA_TipoActorGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoActor  ->" + ex.Message);
				}
			}
			
			public List<TipoActor> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoActor> l = SqlMapper.Query<TipoActor>(con, "API.PA_TipoActorGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoActor  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoActor> GetByFilter(TipoActor pTipoActor, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoActor.id== null || pTipoActor.id==0) ? vintNUll :pTipoActor.id);
                    p.Add("@Nombre",(pTipoActor.Nombre== null) ? vintNUll :pTipoActor.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoActor> l = SqlMapper.Query<TipoActor>(con, "API.PA_TipoActorGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoActor  ->" + ex.Message);
				}
			}

			public TipoActor Add(TipoActor pTipoActor)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoActor.id==null ? 0 : pTipoActor.id);
                    p.Add("@Nombre", pTipoActor.Nombre);
                    p.Add("@auditoria", pTipoActor.auditoria);

                         


                    TipoActor o = SqlMapper.QueryFirstOrDefault<TipoActor>(con, "API.PA_TipoActorAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoActor  ->" + ex.Message);
				}
			}

			public TipoActor  Update(TipoActor pTipoActor)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoActor.id==null ? 0 : pTipoActor.id);
                    p.Add("@Nombre", pTipoActor.Nombre);
                    p.Add("@auditoria", pTipoActor.auditoria);

                         


                    TipoActor o = SqlMapper.QueryFirstOrDefault<TipoActor>(con, "API.PA_TipoActorUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoActor  ->" + ex.Message);
				}
			}

			public bool Delete(TipoActor pTipoActor)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoActor.id);
                    p.Add("@auditoria", pTipoActor.auditoria);

                

 

					TipoActor o = SqlMapper.QueryFirstOrDefault<TipoActor>(con, "API.PA_TipoActorDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoActor  ->" + ex.Message);
				}
			}

		



            public List<TipoActor> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoActor> TipoActorList = new List<TipoActor>();

                    TipoActorList = SqlMapper.Query<TipoActor>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoActorList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoActor  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoActor> b)
            {
                DapperPlusManager.Entity<TipoActor>().Table("TipoActor");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}