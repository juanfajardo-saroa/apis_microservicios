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
     /// Clase Abstracta para  Mensajes
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MensajesRepository : DataObject , IMensajes 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MensajesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MensajesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Mensajes GetById(Mensajes pMensajes)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMensajes.id);                                    


    				Mensajes o = SqlMapper.QueryFirstOrDefault<Mensajes>(con, "API.PA_MensajesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Mensajes  ->" + ex.Message);
				}
			}

			public List<Mensajes> GetAll()
			{
				try 
                {
                        List<Mensajes> l = SqlMapper.Query<Mensajes>(con, "API.PA_MensajesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Mensajes  ->" + ex.Message);
				}
			}

			public List<Mensajes> GetAllFull()
			{
				try 
				{
                    List<Mensajes> l = SqlMapper.Query<Mensajes>(con, "API.PA_MensajesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Mensajes  ->" + ex.Message);
				}
			}
			
			public List<Mensajes> GetAllByWithRelation()
			{
				try 
                {
                    List<Mensajes> l = SqlMapper.Query<Mensajes>(con, "API.PA_MensajesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Mensajes  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Mensajes> GetByFilter(Mensajes pMensajes, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMensajes.id== null || pMensajes.id==0) ? vintNUll :pMensajes.id);
                    p.Add("@ID_UserEmisor",(pMensajes.ID_UserEmisor== null) ? vintNUll :pMensajes.ID_UserEmisor);
                    p.Add("@ID_UserReceptor",(pMensajes.ID_UserReceptor== null) ? vintNUll :pMensajes.ID_UserReceptor);
                    p.Add("@Fecha",(pMensajes.Fecha== null) ? vintNUll :pMensajes.Fecha);
                    p.Add("@Mensajes",(pMensajes.Mensajes== null) ? vintNUll :pMensajes.Mensajes);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Mensajes> l = SqlMapper.Query<Mensajes>(con, "API.PA_MensajesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Mensajes  ->" + ex.Message);
				}
			}

			public Mensajes Add(Mensajes pMensajes)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMensajes.id==null ? 0 : pMensajes.id);
                    p.Add("@ID_UserEmisor", pMensajes.ID_UserEmisor);
                    p.Add("@ID_UserReceptor", pMensajes.ID_UserReceptor);
                    p.Add("@Fecha", pMensajes.Fecha);
                    p.Add("@Mensajes", pMensajes.Mensajes);
                    p.Add("@auditoria", pMensajes.auditoria);

                         


                    Mensajes o = SqlMapper.QueryFirstOrDefault<Mensajes>(con, "API.PA_MensajesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Mensajes  ->" + ex.Message);
				}
			}

			public Mensajes  Update(Mensajes pMensajes)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMensajes.id==null ? 0 : pMensajes.id);
                    p.Add("@ID_UserEmisor", pMensajes.ID_UserEmisor);
                    p.Add("@ID_UserReceptor", pMensajes.ID_UserReceptor);
                    p.Add("@Fecha", pMensajes.Fecha);
                    p.Add("@Mensajes", pMensajes.Mensajes);
                    p.Add("@auditoria", pMensajes.auditoria);

                         


                    Mensajes o = SqlMapper.QueryFirstOrDefault<Mensajes>(con, "API.PA_MensajesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Mensajes  ->" + ex.Message);
				}
			}

			public bool Delete(Mensajes pMensajes)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMensajes.id);
                    p.Add("@auditoria", pMensajes.auditoria);

                

 

					Mensajes o = SqlMapper.QueryFirstOrDefault<Mensajes>(con, "API.PA_MensajesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Mensajes  ->" + ex.Message);
				}
			}

		



            public List<Mensajes> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Mensajes> MensajesList = new List<Mensajes>();

                    MensajesList = SqlMapper.Query<Mensajes>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MensajesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Mensajes  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Mensajes> b)
            {
                DapperPlusManager.Entity<Mensajes>().Table("Mensajes");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}