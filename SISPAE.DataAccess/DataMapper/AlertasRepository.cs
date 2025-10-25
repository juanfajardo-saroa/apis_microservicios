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
     /// Clase Abstracta para  Alertas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AlertasRepository : DataObject , IAlertas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AlertasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AlertasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Alertas GetById(Alertas pAlertas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAlertas.id);                                    


    				Alertas o = SqlMapper.QueryFirstOrDefault<Alertas>(con, "API.PA_AlertasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Alertas  ->" + ex.Message);
				}
			}

			public List<Alertas> GetAll()
			{
				try 
                {
                        List<Alertas> l = SqlMapper.Query<Alertas>(con, "API.PA_AlertasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Alertas  ->" + ex.Message);
				}
			}

			public List<Alertas> GetAllFull()
			{
				try 
				{
                    List<Alertas> l = SqlMapper.Query<Alertas>(con, "API.PA_AlertasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Alertas  ->" + ex.Message);
				}
			}
			
			public List<Alertas> GetAllByWithRelation()
			{
				try 
                {
                    List<Alertas> l = SqlMapper.Query<Alertas>(con, "API.PA_AlertasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Alertas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Alertas> GetByFilter(Alertas pAlertas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAlertas.id== null || pAlertas.id==0) ? vintNUll :pAlertas.id);
                    p.Add("@EsNotificacion",(pAlertas.EsNotificacion== null) ? vintNUll :pAlertas.EsNotificacion);
                    p.Add("@Valor",(pAlertas.Valor== null) ? vintNUll :pAlertas.Valor);
                    p.Add("@URL",(pAlertas.URL== null) ? vintNUll :pAlertas.URL);
                    p.Add("@FechaCreado",(pAlertas.FechaCreado== null) ? vintNUll :pAlertas.FechaCreado);
                    p.Add("@idModulo",(pAlertas.idModulo== null || pAlertas.idModulo==0) ? vintNUll :pAlertas.idModulo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Alertas> l = SqlMapper.Query<Alertas>(con, "API.PA_AlertasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Alertas  ->" + ex.Message);
				}
			}

			public Alertas Add(Alertas pAlertas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAlertas.id==null ? 0 : pAlertas.id);
                    p.Add("@EsNotificacion", pAlertas.EsNotificacion);
                    p.Add("@Valor", pAlertas.Valor);
                    p.Add("@URL", pAlertas.URL);
                    p.Add("@FechaCreado", pAlertas.FechaCreado);
p.Add("@idModulo",pAlertas.idModulo== null ? 0: pAlertas.idModulo);
                    p.Add("@auditoria", pAlertas.auditoria);

                         


                    Alertas o = SqlMapper.QueryFirstOrDefault<Alertas>(con, "API.PA_AlertasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Alertas  ->" + ex.Message);
				}
			}

			public Alertas  Update(Alertas pAlertas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAlertas.id==null ? 0 : pAlertas.id);
                    p.Add("@EsNotificacion", pAlertas.EsNotificacion);
                    p.Add("@Valor", pAlertas.Valor);
                    p.Add("@URL", pAlertas.URL);
                    p.Add("@FechaCreado", pAlertas.FechaCreado);
p.Add("@idModulo",pAlertas.idModulo== null ? 0: pAlertas.idModulo);
                    p.Add("@auditoria", pAlertas.auditoria);

                         


                    Alertas o = SqlMapper.QueryFirstOrDefault<Alertas>(con, "API.PA_AlertasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Alertas  ->" + ex.Message);
				}
			}

			public bool Delete(Alertas pAlertas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAlertas.id);
                    p.Add("@auditoria", pAlertas.auditoria);

                

 

					Alertas o = SqlMapper.QueryFirstOrDefault<Alertas>(con, "API.PA_AlertasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Alertas  ->" + ex.Message);
				}
			}

		



            public List<Alertas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Alertas> AlertasList = new List<Alertas>();

                    AlertasList = SqlMapper.Query<Alertas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AlertasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Alertas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Alertas> b)
            {
                DapperPlusManager.Entity<Alertas>().Table("Alertas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}