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
     /// Clase Abstracta para  Respuestas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class RespuestasRepository : DataObject , IRespuestas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public RespuestasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public RespuestasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Respuestas GetById(Respuestas pRespuestas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pRespuestas.id);                                    


    				Respuestas o = SqlMapper.QueryFirstOrDefault<Respuestas>(con, "API.PA_RespuestasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Respuestas  ->" + ex.Message);
				}
			}

			public List<Respuestas> GetAll()
			{
				try 
                {
                        List<Respuestas> l = SqlMapper.Query<Respuestas>(con, "API.PA_RespuestasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Respuestas  ->" + ex.Message);
				}
			}

			public List<Respuestas> GetAllFull()
			{
				try 
				{
                    List<Respuestas> l = SqlMapper.Query<Respuestas>(con, "API.PA_RespuestasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Respuestas  ->" + ex.Message);
				}
			}
			
			public List<Respuestas> GetAllByWithRelation()
			{
				try 
                {
                    List<Respuestas> l = SqlMapper.Query<Respuestas>(con, "API.PA_RespuestasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Respuestas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Respuestas> GetByFilter(Respuestas pRespuestas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pRespuestas.id== null || pRespuestas.id==0) ? vintNUll :pRespuestas.id);
                    p.Add("@ID_OpcionRespuesta",(pRespuestas.ID_OpcionRespuesta== null || pRespuestas.ID_OpcionRespuesta==0) ? vintNUll :pRespuestas.ID_OpcionRespuesta);
                    p.Add("@ID_Diligenciamiento",(pRespuestas.ID_Diligenciamiento== null || pRespuestas.ID_Diligenciamiento==0) ? vintNUll :pRespuestas.ID_Diligenciamiento);
                    p.Add("@Respuesta",(pRespuestas.Respuesta== null) ? vintNUll :pRespuestas.Respuesta);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Respuestas> l = SqlMapper.Query<Respuestas>(con, "API.PA_RespuestasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Respuestas  ->" + ex.Message);
				}
			}

			public Respuestas Add(Respuestas pRespuestas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pRespuestas.id==null ? 0 : pRespuestas.id);
p.Add("@ID_OpcionRespuesta",pRespuestas.ID_OpcionRespuesta==null ? 0 : pRespuestas.ID_OpcionRespuesta);
p.Add("@ID_Diligenciamiento",pRespuestas.ID_Diligenciamiento==null ? 0 : pRespuestas.ID_Diligenciamiento);
                    p.Add("@Respuesta", pRespuestas.Respuesta);
                    p.Add("@auditoria", pRespuestas.auditoria);

                         


                    Respuestas o = SqlMapper.QueryFirstOrDefault<Respuestas>(con, "API.PA_RespuestasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Respuestas  ->" + ex.Message);
				}
			}

			public Respuestas  Update(Respuestas pRespuestas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pRespuestas.id==null ? 0 : pRespuestas.id);
p.Add("@ID_OpcionRespuesta",pRespuestas.ID_OpcionRespuesta==null ? 0 : pRespuestas.ID_OpcionRespuesta);
p.Add("@ID_Diligenciamiento",pRespuestas.ID_Diligenciamiento==null ? 0 : pRespuestas.ID_Diligenciamiento);
                    p.Add("@Respuesta", pRespuestas.Respuesta);
                    p.Add("@auditoria", pRespuestas.auditoria);

                         


                    Respuestas o = SqlMapper.QueryFirstOrDefault<Respuestas>(con, "API.PA_RespuestasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Respuestas  ->" + ex.Message);
				}
			}

			public bool Delete(Respuestas pRespuestas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pRespuestas.id);
                    p.Add("@auditoria", pRespuestas.auditoria);

                

 

					Respuestas o = SqlMapper.QueryFirstOrDefault<Respuestas>(con, "API.PA_RespuestasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Respuestas  ->" + ex.Message);
				}
			}

		



            public List<Respuestas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Respuestas> RespuestasList = new List<Respuestas>();

                    RespuestasList = SqlMapper.Query<Respuestas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return RespuestasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Respuestas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Respuestas> b)
            {
                DapperPlusManager.Entity<Respuestas>().Table("Respuestas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}