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
     /// Clase Abstracta para  OpcionesRespuesta
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class OpcionesRespuestaRepository : DataObject , IOpcionesRespuesta 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public OpcionesRespuestaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public OpcionesRespuestaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public OpcionesRespuesta GetById(OpcionesRespuesta pOpcionesRespuesta)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pOpcionesRespuesta.id);                                    


    				OpcionesRespuesta o = SqlMapper.QueryFirstOrDefault<OpcionesRespuesta>(con, "API.PA_OpcionesRespuestaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  OpcionesRespuesta  ->" + ex.Message);
				}
			}

			public List<OpcionesRespuesta> GetAll()
			{
				try 
                {
                        List<OpcionesRespuesta> l = SqlMapper.Query<OpcionesRespuesta>(con, "API.PA_OpcionesRespuestaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  OpcionesRespuesta  ->" + ex.Message);
				}
			}

			public List<OpcionesRespuesta> GetAllFull()
			{
				try 
				{
                    List<OpcionesRespuesta> l = SqlMapper.Query<OpcionesRespuesta>(con, "API.PA_OpcionesRespuestaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  OpcionesRespuesta  ->" + ex.Message);
				}
			}
			
			public List<OpcionesRespuesta> GetAllByWithRelation()
			{
				try 
                {
                    List<OpcionesRespuesta> l = SqlMapper.Query<OpcionesRespuesta>(con, "API.PA_OpcionesRespuestaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  OpcionesRespuesta  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<OpcionesRespuesta> GetByFilter(OpcionesRespuesta pOpcionesRespuesta, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pOpcionesRespuesta.id== null || pOpcionesRespuesta.id==0) ? vintNUll :pOpcionesRespuesta.id);
                    p.Add("@ID_lndicador",(pOpcionesRespuesta.ID_lndicador== null || pOpcionesRespuesta.ID_lndicador==0) ? vintNUll :pOpcionesRespuesta.ID_lndicador);
                    p.Add("@ID_Pregunta",(pOpcionesRespuesta.ID_Pregunta== null || pOpcionesRespuesta.ID_Pregunta==0) ? vintNUll :pOpcionesRespuesta.ID_Pregunta);
                    p.Add("@Opcion",(pOpcionesRespuesta.Opcion== null) ? vintNUll :pOpcionesRespuesta.Opcion);
                    p.Add("@ValorPorcentrual",(pOpcionesRespuesta.ValorPorcentrual== null) ? vintNUll :pOpcionesRespuesta.ValorPorcentrual);
                    p.Add("@RespuestaPositiva",(pOpcionesRespuesta.RespuestaPositiva== null) ? vintNUll :pOpcionesRespuesta.RespuestaPositiva);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<OpcionesRespuesta> l = SqlMapper.Query<OpcionesRespuesta>(con, "API.PA_OpcionesRespuestaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  OpcionesRespuesta  ->" + ex.Message);
				}
			}

			public OpcionesRespuesta Add(OpcionesRespuesta pOpcionesRespuesta)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pOpcionesRespuesta.id==null ? 0 : pOpcionesRespuesta.id);
p.Add("@ID_lndicador",pOpcionesRespuesta.ID_lndicador==null ? 0 : pOpcionesRespuesta.ID_lndicador);
p.Add("@ID_Pregunta",pOpcionesRespuesta.ID_Pregunta==null ? 0 : pOpcionesRespuesta.ID_Pregunta);
                    p.Add("@Opcion", pOpcionesRespuesta.Opcion);
                    p.Add("@ValorPorcentrual", pOpcionesRespuesta.ValorPorcentrual);
                    p.Add("@RespuestaPositiva", pOpcionesRespuesta.RespuestaPositiva);
                    p.Add("@auditoria", pOpcionesRespuesta.auditoria);

                         


                    OpcionesRespuesta o = SqlMapper.QueryFirstOrDefault<OpcionesRespuesta>(con, "API.PA_OpcionesRespuestaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  OpcionesRespuesta  ->" + ex.Message);
				}
			}

			public OpcionesRespuesta  Update(OpcionesRespuesta pOpcionesRespuesta)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pOpcionesRespuesta.id==null ? 0 : pOpcionesRespuesta.id);
p.Add("@ID_lndicador",pOpcionesRespuesta.ID_lndicador==null ? 0 : pOpcionesRespuesta.ID_lndicador);
p.Add("@ID_Pregunta",pOpcionesRespuesta.ID_Pregunta==null ? 0 : pOpcionesRespuesta.ID_Pregunta);
                    p.Add("@Opcion", pOpcionesRespuesta.Opcion);
                    p.Add("@ValorPorcentrual", pOpcionesRespuesta.ValorPorcentrual);
                    p.Add("@RespuestaPositiva", pOpcionesRespuesta.RespuestaPositiva);
                    p.Add("@auditoria", pOpcionesRespuesta.auditoria);

                         


                    OpcionesRespuesta o = SqlMapper.QueryFirstOrDefault<OpcionesRespuesta>(con, "API.PA_OpcionesRespuestaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  OpcionesRespuesta  ->" + ex.Message);
				}
			}

			public bool Delete(OpcionesRespuesta pOpcionesRespuesta)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pOpcionesRespuesta.id);
                    p.Add("@auditoria", pOpcionesRespuesta.auditoria);

                

 

					OpcionesRespuesta o = SqlMapper.QueryFirstOrDefault<OpcionesRespuesta>(con, "API.PA_OpcionesRespuestaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) OpcionesRespuesta  ->" + ex.Message);
				}
			}

		



            public List<OpcionesRespuesta> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<OpcionesRespuesta> OpcionesRespuestaList = new List<OpcionesRespuesta>();

                    OpcionesRespuestaList = SqlMapper.Query<OpcionesRespuesta>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return OpcionesRespuestaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) OpcionesRespuesta  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<OpcionesRespuesta> b)
            {
                DapperPlusManager.Entity<OpcionesRespuesta>().Table("OpcionesRespuesta");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}