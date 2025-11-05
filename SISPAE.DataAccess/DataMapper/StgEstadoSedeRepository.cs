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
     /// Clase Abstracta para  StgEstadoSede
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgEstadoSedeRepository : DataObject , IStgEstadoSede 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgEstadoSedeRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgEstadoSedeRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgEstadoSede GetById(StgEstadoSede pStgEstadoSede)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgEstadoSede.id);                                    


    				StgEstadoSede o = SqlMapper.QueryFirstOrDefault<StgEstadoSede>(con, "API.PA_StgEstadoSedeGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgEstadoSede  ->" + ex.Message);
				}
			}

			public List<StgEstadoSede> GetAll()
			{
				try 
                {
                        List<StgEstadoSede> l = SqlMapper.Query<StgEstadoSede>(con, "API.PA_StgEstadoSedeGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgEstadoSede  ->" + ex.Message);
				}
			}

			public List<StgEstadoSede> GetAllFull()
			{
				try 
				{
                    List<StgEstadoSede> l = SqlMapper.Query<StgEstadoSede>(con, "API.PA_StgEstadoSedeGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgEstadoSede  ->" + ex.Message);
				}
			}
			
			public List<StgEstadoSede> GetAllByWithRelation()
			{
				try 
                {
                    List<StgEstadoSede> l = SqlMapper.Query<StgEstadoSede>(con, "API.PA_StgEstadoSedeGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgEstadoSede  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgEstadoSede> GetByFilter(StgEstadoSede pStgEstadoSede, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgEstadoSede.id== null || pStgEstadoSede.id==0) ? vintNUll :pStgEstadoSede.id);
                    p.Add("@IdEstadoSede",(pStgEstadoSede.IdEstadoSede== null || pStgEstadoSede.IdEstadoSede==0) ? vintNUll :pStgEstadoSede.IdEstadoSede);
                    p.Add("@Nombre",(pStgEstadoSede.Nombre== null) ? vintNUll :pStgEstadoSede.Nombre);
                    p.Add("@FechaCreacion",(pStgEstadoSede.FechaCreacion== null) ? vintNUll :pStgEstadoSede.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgEstadoSede> l = SqlMapper.Query<StgEstadoSede>(con, "API.PA_StgEstadoSedeGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgEstadoSede  ->" + ex.Message);
				}
			}

			public StgEstadoSede Add(StgEstadoSede pStgEstadoSede)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgEstadoSede.id==null ? 0 : pStgEstadoSede.id);
p.Add("@IdEstadoSede",pStgEstadoSede.IdEstadoSede==null ? 0 : pStgEstadoSede.IdEstadoSede);
                    p.Add("@Nombre", pStgEstadoSede.Nombre);
                    p.Add("@FechaCreacion", pStgEstadoSede.FechaCreacion);
                    p.Add("@auditoria", pStgEstadoSede.auditoria);

                         


                    StgEstadoSede o = SqlMapper.QueryFirstOrDefault<StgEstadoSede>(con, "API.PA_StgEstadoSedeAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgEstadoSede  ->" + ex.Message);
				}
			}

			public StgEstadoSede  Update(StgEstadoSede pStgEstadoSede)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgEstadoSede.id==null ? 0 : pStgEstadoSede.id);
p.Add("@IdEstadoSede",pStgEstadoSede.IdEstadoSede==null ? 0 : pStgEstadoSede.IdEstadoSede);
                    p.Add("@Nombre", pStgEstadoSede.Nombre);
                    p.Add("@FechaCreacion", pStgEstadoSede.FechaCreacion);
                    p.Add("@auditoria", pStgEstadoSede.auditoria);

                         


                    StgEstadoSede o = SqlMapper.QueryFirstOrDefault<StgEstadoSede>(con, "API.PA_StgEstadoSedeUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgEstadoSede  ->" + ex.Message);
				}
			}

			public bool Delete(StgEstadoSede pStgEstadoSede)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgEstadoSede.id);
                    p.Add("@auditoria", pStgEstadoSede.auditoria);

                

 

					StgEstadoSede o = SqlMapper.QueryFirstOrDefault<StgEstadoSede>(con, "API.PA_StgEstadoSedeDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgEstadoSede  ->" + ex.Message);
				}
			}

		



            public List<StgEstadoSede> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgEstadoSede> StgEstadoSedeList = new List<StgEstadoSede>();

                    StgEstadoSedeList = SqlMapper.Query<StgEstadoSede>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgEstadoSedeList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgEstadoSede  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgEstadoSede> b)
            {
                DapperPlusManager.Entity<StgEstadoSede>().Table("StgEstadoSede");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}