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
     /// Clase Abstracta para  TipoArchivo
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoArchivoRepository : DataObject , ITipoArchivo 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoArchivoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoArchivoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoArchivo GetById(TipoArchivo pTipoArchivo)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoArchivo.id);                                    


    				TipoArchivo o = SqlMapper.QueryFirstOrDefault<TipoArchivo>(con, "API.PA_TipoArchivoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoArchivo  ->" + ex.Message);
				}
			}

			public List<TipoArchivo> GetAll()
			{
				try 
                {
                        List<TipoArchivo> l = SqlMapper.Query<TipoArchivo>(con, "API.PA_TipoArchivoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoArchivo  ->" + ex.Message);
				}
			}

			public List<TipoArchivo> GetAllFull()
			{
				try 
				{
                    List<TipoArchivo> l = SqlMapper.Query<TipoArchivo>(con, "API.PA_TipoArchivoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoArchivo  ->" + ex.Message);
				}
			}
			
			public List<TipoArchivo> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoArchivo> l = SqlMapper.Query<TipoArchivo>(con, "API.PA_TipoArchivoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoArchivo  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoArchivo> GetByFilter(TipoArchivo pTipoArchivo, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoArchivo.id== null || pTipoArchivo.id==0) ? vintNUll :pTipoArchivo.id);
                    p.Add("@Nombre",(pTipoArchivo.Nombre== null) ? vintNUll :pTipoArchivo.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoArchivo> l = SqlMapper.Query<TipoArchivo>(con, "API.PA_TipoArchivoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoArchivo  ->" + ex.Message);
				}
			}

			public TipoArchivo Add(TipoArchivo pTipoArchivo)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoArchivo.id==null ? 0 : pTipoArchivo.id);
                    p.Add("@Nombre", pTipoArchivo.Nombre);
                    p.Add("@auditoria", pTipoArchivo.auditoria);

                         


                    TipoArchivo o = SqlMapper.QueryFirstOrDefault<TipoArchivo>(con, "API.PA_TipoArchivoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoArchivo  ->" + ex.Message);
				}
			}

			public TipoArchivo  Update(TipoArchivo pTipoArchivo)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoArchivo.id==null ? 0 : pTipoArchivo.id);
                    p.Add("@Nombre", pTipoArchivo.Nombre);
                    p.Add("@auditoria", pTipoArchivo.auditoria);

                         


                    TipoArchivo o = SqlMapper.QueryFirstOrDefault<TipoArchivo>(con, "API.PA_TipoArchivoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoArchivo  ->" + ex.Message);
				}
			}

			public bool Delete(TipoArchivo pTipoArchivo)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoArchivo.id);
                    p.Add("@auditoria", pTipoArchivo.auditoria);

                

 

					TipoArchivo o = SqlMapper.QueryFirstOrDefault<TipoArchivo>(con, "API.PA_TipoArchivoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoArchivo  ->" + ex.Message);
				}
			}

		



            public List<TipoArchivo> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoArchivo> TipoArchivoList = new List<TipoArchivo>();

                    TipoArchivoList = SqlMapper.Query<TipoArchivo>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoArchivoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoArchivo  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoArchivo> b)
            {
                DapperPlusManager.Entity<TipoArchivo>().Table("TipoArchivo");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}