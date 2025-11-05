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
     /// Clase Abstracta para  EnvioCorreo
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class EnvioCorreoRepository : DataObject , IEnvioCorreo 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public EnvioCorreoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public EnvioCorreoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public EnvioCorreo GetById(EnvioCorreo pEnvioCorreo)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pEnvioCorreo.id);                                    


    				EnvioCorreo o = SqlMapper.QueryFirstOrDefault<EnvioCorreo>(con, "API.PA_EnvioCorreoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  EnvioCorreo  ->" + ex.Message);
				}
			}

			public List<EnvioCorreo> GetAll()
			{
				try 
                {
                        List<EnvioCorreo> l = SqlMapper.Query<EnvioCorreo>(con, "API.PA_EnvioCorreoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  EnvioCorreo  ->" + ex.Message);
				}
			}

			public List<EnvioCorreo> GetAllFull()
			{
				try 
				{
                    List<EnvioCorreo> l = SqlMapper.Query<EnvioCorreo>(con, "API.PA_EnvioCorreoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  EnvioCorreo  ->" + ex.Message);
				}
			}
			
			public List<EnvioCorreo> GetAllByWithRelation()
			{
				try 
                {
                    List<EnvioCorreo> l = SqlMapper.Query<EnvioCorreo>(con, "API.PA_EnvioCorreoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  EnvioCorreo  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<EnvioCorreo> GetByFilter(EnvioCorreo pEnvioCorreo, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pEnvioCorreo.id== null || pEnvioCorreo.id==0) ? vintNUll :pEnvioCorreo.id);
                    p.Add("@fecha",(pEnvioCorreo.fecha== null) ? vintNUll :pEnvioCorreo.fecha);
                    p.Add("@remitente",(pEnvioCorreo.remitente== null) ? vintNUll :pEnvioCorreo.remitente);
                    p.Add("@destinatario",(pEnvioCorreo.destinatario== null) ? vintNUll :pEnvioCorreo.destinatario);
                    p.Add("@asunto",(pEnvioCorreo.asunto== null) ? vintNUll :pEnvioCorreo.asunto);
                    p.Add("@cuerpo",(pEnvioCorreo.cuerpo== null) ? vintNUll :pEnvioCorreo.cuerpo);
                    p.Add("@status",(pEnvioCorreo.status== null) ? vintNUll :pEnvioCorreo.status);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<EnvioCorreo> l = SqlMapper.Query<EnvioCorreo>(con, "API.PA_EnvioCorreoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  EnvioCorreo  ->" + ex.Message);
				}
			}

			public EnvioCorreo Add(EnvioCorreo pEnvioCorreo)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pEnvioCorreo.id==null ? 0 : pEnvioCorreo.id);
                    p.Add("@fecha", pEnvioCorreo.fecha);
                    p.Add("@remitente", pEnvioCorreo.remitente);
                    p.Add("@destinatario", pEnvioCorreo.destinatario);
                    p.Add("@asunto", pEnvioCorreo.asunto);
                    p.Add("@cuerpo", pEnvioCorreo.cuerpo);
                    p.Add("@status", pEnvioCorreo.status);
                    p.Add("@auditoria", pEnvioCorreo.auditoria);

                         


                    EnvioCorreo o = SqlMapper.QueryFirstOrDefault<EnvioCorreo>(con, "API.PA_EnvioCorreoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  EnvioCorreo  ->" + ex.Message);
				}
			}

			public EnvioCorreo  Update(EnvioCorreo pEnvioCorreo)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pEnvioCorreo.id==null ? 0 : pEnvioCorreo.id);
                    p.Add("@fecha", pEnvioCorreo.fecha);
                    p.Add("@remitente", pEnvioCorreo.remitente);
                    p.Add("@destinatario", pEnvioCorreo.destinatario);
                    p.Add("@asunto", pEnvioCorreo.asunto);
                    p.Add("@cuerpo", pEnvioCorreo.cuerpo);
                    p.Add("@status", pEnvioCorreo.status);
                    p.Add("@auditoria", pEnvioCorreo.auditoria);

                         


                    EnvioCorreo o = SqlMapper.QueryFirstOrDefault<EnvioCorreo>(con, "API.PA_EnvioCorreoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  EnvioCorreo  ->" + ex.Message);
				}
			}

			public bool Delete(EnvioCorreo pEnvioCorreo)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pEnvioCorreo.id);
                    p.Add("@auditoria", pEnvioCorreo.auditoria);

                

 

					EnvioCorreo o = SqlMapper.QueryFirstOrDefault<EnvioCorreo>(con, "API.PA_EnvioCorreoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) EnvioCorreo  ->" + ex.Message);
				}
			}

		



            public List<EnvioCorreo> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<EnvioCorreo> EnvioCorreoList = new List<EnvioCorreo>();

                    EnvioCorreoList = SqlMapper.Query<EnvioCorreo>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return EnvioCorreoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) EnvioCorreo  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<EnvioCorreo> b)
            {
                DapperPlusManager.Entity<EnvioCorreo>().Table("EnvioCorreo");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}