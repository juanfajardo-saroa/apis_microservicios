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
     /// Clase Abstracta para  Sistema
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SistemaRepository : DataObject , ISistema 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SistemaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SistemaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Sistema GetById(Sistema pSistema)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSistema.id);                                    


    				Sistema o = SqlMapper.QueryFirstOrDefault<Sistema>(con, "API.PA_SistemaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Sistema  ->" + ex.Message);
				}
			}

			public List<Sistema> GetAll()
			{
				try 
                {
                        List<Sistema> l = SqlMapper.Query<Sistema>(con, "API.PA_SistemaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Sistema  ->" + ex.Message);
				}
			}

			public List<Sistema> GetAllFull()
			{
				try 
				{
                    List<Sistema> l = SqlMapper.Query<Sistema>(con, "API.PA_SistemaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Sistema  ->" + ex.Message);
				}
			}
			
			public List<Sistema> GetAllByWithRelation()
			{
				try 
                {
                    List<Sistema> l = SqlMapper.Query<Sistema>(con, "API.PA_SistemaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Sistema  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Sistema> GetByFilter(Sistema pSistema, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSistema.id== null || pSistema.id==0) ? vintNUll :pSistema.id);
                    p.Add("@Nombre",(pSistema.Nombre== null) ? vintNUll :pSistema.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Sistema> l = SqlMapper.Query<Sistema>(con, "API.PA_SistemaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Sistema  ->" + ex.Message);
				}
			}

			public Sistema Add(Sistema pSistema)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSistema.id==null ? 0 : pSistema.id);
                    p.Add("@Nombre", pSistema.Nombre);
                    p.Add("@auditoria", pSistema.auditoria);

                         


                    Sistema o = SqlMapper.QueryFirstOrDefault<Sistema>(con, "API.PA_SistemaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Sistema  ->" + ex.Message);
				}
			}

			public Sistema  Update(Sistema pSistema)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSistema.id==null ? 0 : pSistema.id);
                    p.Add("@Nombre", pSistema.Nombre);
                    p.Add("@auditoria", pSistema.auditoria);

                         


                    Sistema o = SqlMapper.QueryFirstOrDefault<Sistema>(con, "API.PA_SistemaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Sistema  ->" + ex.Message);
				}
			}

			public bool Delete(Sistema pSistema)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSistema.id);
                    p.Add("@auditoria", pSistema.auditoria);

                

 

					Sistema o = SqlMapper.QueryFirstOrDefault<Sistema>(con, "API.PA_SistemaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Sistema  ->" + ex.Message);
				}
			}

		



            public List<Sistema> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Sistema> SistemaList = new List<Sistema>();

                    SistemaList = SqlMapper.Query<Sistema>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SistemaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Sistema  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Sistema> b)
            {
                DapperPlusManager.Entity<Sistema>().Table("Sistema");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}