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
     /// Clase Abstracta para  TablasAuditoria
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TablasAuditoriaRepository : DataObject , ITablasAuditoria 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TablasAuditoriaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TablasAuditoriaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TablasAuditoria GetById(TablasAuditoria pTablasAuditoria)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@Id",pTablasAuditoria.Id);                                    


    				TablasAuditoria o = SqlMapper.QueryFirstOrDefault<TablasAuditoria>(con, "API.PA_TablasAuditoriaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TablasAuditoria  ->" + ex.Message);
				}
			}

			public List<TablasAuditoria> GetAll()
			{
				try 
                {
                        List<TablasAuditoria> l = SqlMapper.Query<TablasAuditoria>(con, "API.PA_TablasAuditoriaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TablasAuditoria  ->" + ex.Message);
				}
			}

			public List<TablasAuditoria> GetAllFull()
			{
				try 
				{
                    List<TablasAuditoria> l = SqlMapper.Query<TablasAuditoria>(con, "API.PA_TablasAuditoriaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TablasAuditoria  ->" + ex.Message);
				}
			}
			
			public List<TablasAuditoria> GetAllByWithRelation()
			{
				try 
                {
                    List<TablasAuditoria> l = SqlMapper.Query<TablasAuditoria>(con, "API.PA_TablasAuditoriaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TablasAuditoria  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TablasAuditoria> GetByFilter(TablasAuditoria pTablasAuditoria, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@Id",(pTablasAuditoria.Id== null || pTablasAuditoria.Id==0) ? vintNUll :pTablasAuditoria.Id);
                    p.Add("@Esquema",(pTablasAuditoria.Esquema== null) ? vintNUll :pTablasAuditoria.Esquema);
                    p.Add("@Table_Name",(pTablasAuditoria.Table_Name== null) ? vintNUll :pTablasAuditoria.Table_Name);
                    p.Add("@Nombre",(pTablasAuditoria.Nombre== null) ? vintNUll :pTablasAuditoria.Nombre);
                    p.Add("@AuditCampo",(pTablasAuditoria.AuditCampo== null) ? vintNUll :pTablasAuditoria.AuditCampo);
                    p.Add("@AuditTabla",(pTablasAuditoria.AuditTabla== null) ? vintNUll :pTablasAuditoria.AuditTabla);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TablasAuditoria> l = SqlMapper.Query<TablasAuditoria>(con, "API.PA_TablasAuditoriaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TablasAuditoria  ->" + ex.Message);
				}
			}

			public TablasAuditoria Add(TablasAuditoria pTablasAuditoria)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@Id",pTablasAuditoria.Id==null ? 0 : pTablasAuditoria.Id);
                    p.Add("@Esquema", pTablasAuditoria.Esquema);
                    p.Add("@Table_Name", pTablasAuditoria.Table_Name);
                    p.Add("@Nombre", pTablasAuditoria.Nombre);
                    p.Add("@AuditCampo", pTablasAuditoria.AuditCampo);
                    p.Add("@AuditTabla", pTablasAuditoria.AuditTabla);
                    p.Add("@auditoria", pTablasAuditoria.auditoria);

                         


                    TablasAuditoria o = SqlMapper.QueryFirstOrDefault<TablasAuditoria>(con, "API.PA_TablasAuditoriaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TablasAuditoria  ->" + ex.Message);
				}
			}

			public TablasAuditoria  Update(TablasAuditoria pTablasAuditoria)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@Id",pTablasAuditoria.Id==null ? 0 : pTablasAuditoria.Id);
                    p.Add("@Esquema", pTablasAuditoria.Esquema);
                    p.Add("@Table_Name", pTablasAuditoria.Table_Name);
                    p.Add("@Nombre", pTablasAuditoria.Nombre);
                    p.Add("@AuditCampo", pTablasAuditoria.AuditCampo);
                    p.Add("@AuditTabla", pTablasAuditoria.AuditTabla);
                    p.Add("@auditoria", pTablasAuditoria.auditoria);

                         


                    TablasAuditoria o = SqlMapper.QueryFirstOrDefault<TablasAuditoria>(con, "API.PA_TablasAuditoriaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TablasAuditoria  ->" + ex.Message);
				}
			}

			public bool Delete(TablasAuditoria pTablasAuditoria)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@Id",pTablasAuditoria.Id);
                    p.Add("@auditoria", pTablasAuditoria.auditoria);

                

 

					TablasAuditoria o = SqlMapper.QueryFirstOrDefault<TablasAuditoria>(con, "API.PA_TablasAuditoriaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TablasAuditoria  ->" + ex.Message);
				}
			}

		



            public List<TablasAuditoria> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TablasAuditoria> TablasAuditoriaList = new List<TablasAuditoria>();

                    TablasAuditoriaList = SqlMapper.Query<TablasAuditoria>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TablasAuditoriaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TablasAuditoria  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TablasAuditoria> b)
            {
                DapperPlusManager.Entity<TablasAuditoria>().Table("TablasAuditoria");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}