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
     /// Clase Abstracta para  TipoDocumentoIden
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoDocumentoIdenRepository : DataObject , ITipoDocumentoIden 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoDocumentoIdenRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoDocumentoIdenRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoDocumentoIden GetById(TipoDocumentoIden pTipoDocumentoIden)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoDocumentoIden.id);                                    


    				TipoDocumentoIden o = SqlMapper.QueryFirstOrDefault<TipoDocumentoIden>(con, "API.PA_TipoDocumentoIdenGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoDocumentoIden  ->" + ex.Message);
				}
			}

			public List<TipoDocumentoIden> GetAll()
			{
				try 
                {
                        List<TipoDocumentoIden> l = SqlMapper.Query<TipoDocumentoIden>(con, "API.PA_TipoDocumentoIdenGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoDocumentoIden  ->" + ex.Message);
				}
			}

			public List<TipoDocumentoIden> GetAllFull()
			{
				try 
				{
                    List<TipoDocumentoIden> l = SqlMapper.Query<TipoDocumentoIden>(con, "API.PA_TipoDocumentoIdenGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoDocumentoIden  ->" + ex.Message);
				}
			}
			
			public List<TipoDocumentoIden> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoDocumentoIden> l = SqlMapper.Query<TipoDocumentoIden>(con, "API.PA_TipoDocumentoIdenGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoDocumentoIden  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoDocumentoIden> GetByFilter(TipoDocumentoIden pTipoDocumentoIden, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoDocumentoIden.id== null || pTipoDocumentoIden.id==0) ? vintNUll :pTipoDocumentoIden.id);
                    p.Add("@Nombre",(pTipoDocumentoIden.Nombre== null) ? vintNUll :pTipoDocumentoIden.Nombre);
                    p.Add("@FechaCreacion",(pTipoDocumentoIden.FechaCreacion== null) ? vintNUll :pTipoDocumentoIden.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoDocumentoIden> l = SqlMapper.Query<TipoDocumentoIden>(con, "API.PA_TipoDocumentoIdenGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoDocumentoIden  ->" + ex.Message);
				}
			}

			public TipoDocumentoIden Add(TipoDocumentoIden pTipoDocumentoIden)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoDocumentoIden.id==null ? 0 : pTipoDocumentoIden.id);
                    p.Add("@Nombre", pTipoDocumentoIden.Nombre);
                    p.Add("@FechaCreacion", pTipoDocumentoIden.FechaCreacion);
                    p.Add("@auditoria", pTipoDocumentoIden.auditoria);

                         


                    TipoDocumentoIden o = SqlMapper.QueryFirstOrDefault<TipoDocumentoIden>(con, "API.PA_TipoDocumentoIdenAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoDocumentoIden  ->" + ex.Message);
				}
			}

			public TipoDocumentoIden  Update(TipoDocumentoIden pTipoDocumentoIden)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoDocumentoIden.id==null ? 0 : pTipoDocumentoIden.id);
                    p.Add("@Nombre", pTipoDocumentoIden.Nombre);
                    p.Add("@FechaCreacion", pTipoDocumentoIden.FechaCreacion);
                    p.Add("@auditoria", pTipoDocumentoIden.auditoria);

                         


                    TipoDocumentoIden o = SqlMapper.QueryFirstOrDefault<TipoDocumentoIden>(con, "API.PA_TipoDocumentoIdenUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoDocumentoIden  ->" + ex.Message);
				}
			}

			public bool Delete(TipoDocumentoIden pTipoDocumentoIden)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoDocumentoIden.id);
                    p.Add("@auditoria", pTipoDocumentoIden.auditoria);

                

 

					TipoDocumentoIden o = SqlMapper.QueryFirstOrDefault<TipoDocumentoIden>(con, "API.PA_TipoDocumentoIdenDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoDocumentoIden  ->" + ex.Message);
				}
			}

		



            public List<TipoDocumentoIden> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoDocumentoIden> TipoDocumentoIdenList = new List<TipoDocumentoIden>();

                    TipoDocumentoIdenList = SqlMapper.Query<TipoDocumentoIden>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoDocumentoIdenList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoDocumentoIden  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoDocumentoIden> b)
            {
                DapperPlusManager.Entity<TipoDocumentoIden>().Table("TipoDocumentoIden");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}