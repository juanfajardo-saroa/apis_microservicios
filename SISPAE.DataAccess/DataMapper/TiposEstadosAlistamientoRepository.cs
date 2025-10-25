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
     /// Clase Abstracta para  TiposEstadosAlistamiento
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposEstadosAlistamientoRepository : DataObject , ITiposEstadosAlistamiento 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposEstadosAlistamientoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposEstadosAlistamientoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposEstadosAlistamiento GetById(TiposEstadosAlistamiento pTiposEstadosAlistamiento)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadosAlistamiento.id);                                    


    				TiposEstadosAlistamiento o = SqlMapper.QueryFirstOrDefault<TiposEstadosAlistamiento>(con, "API.PA_TiposEstadosAlistamientoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposEstadosAlistamiento  ->" + ex.Message);
				}
			}

			public List<TiposEstadosAlistamiento> GetAll()
			{
				try 
                {
                        List<TiposEstadosAlistamiento> l = SqlMapper.Query<TiposEstadosAlistamiento>(con, "API.PA_TiposEstadosAlistamientoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposEstadosAlistamiento  ->" + ex.Message);
				}
			}

			public List<TiposEstadosAlistamiento> GetAllFull()
			{
				try 
				{
                    List<TiposEstadosAlistamiento> l = SqlMapper.Query<TiposEstadosAlistamiento>(con, "API.PA_TiposEstadosAlistamientoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposEstadosAlistamiento  ->" + ex.Message);
				}
			}
			
			public List<TiposEstadosAlistamiento> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposEstadosAlistamiento> l = SqlMapper.Query<TiposEstadosAlistamiento>(con, "API.PA_TiposEstadosAlistamientoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposEstadosAlistamiento  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposEstadosAlistamiento> GetByFilter(TiposEstadosAlistamiento pTiposEstadosAlistamiento, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposEstadosAlistamiento.id== null || pTiposEstadosAlistamiento.id==0) ? vintNUll :pTiposEstadosAlistamiento.id);
                    p.Add("@Nombre",(pTiposEstadosAlistamiento.Nombre== null) ? vintNUll :pTiposEstadosAlistamiento.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposEstadosAlistamiento> l = SqlMapper.Query<TiposEstadosAlistamiento>(con, "API.PA_TiposEstadosAlistamientoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposEstadosAlistamiento  ->" + ex.Message);
				}
			}

			public TiposEstadosAlistamiento Add(TiposEstadosAlistamiento pTiposEstadosAlistamiento)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposEstadosAlistamiento.id==null ? 0 : pTiposEstadosAlistamiento.id);
                    p.Add("@Nombre", pTiposEstadosAlistamiento.Nombre);
                    p.Add("@auditoria", pTiposEstadosAlistamiento.auditoria);

                         


                    TiposEstadosAlistamiento o = SqlMapper.QueryFirstOrDefault<TiposEstadosAlistamiento>(con, "API.PA_TiposEstadosAlistamientoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposEstadosAlistamiento  ->" + ex.Message);
				}
			}

			public TiposEstadosAlistamiento  Update(TiposEstadosAlistamiento pTiposEstadosAlistamiento)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposEstadosAlistamiento.id==null ? 0 : pTiposEstadosAlistamiento.id);
                    p.Add("@Nombre", pTiposEstadosAlistamiento.Nombre);
                    p.Add("@auditoria", pTiposEstadosAlistamiento.auditoria);

                         


                    TiposEstadosAlistamiento o = SqlMapper.QueryFirstOrDefault<TiposEstadosAlistamiento>(con, "API.PA_TiposEstadosAlistamientoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposEstadosAlistamiento  ->" + ex.Message);
				}
			}

			public bool Delete(TiposEstadosAlistamiento pTiposEstadosAlistamiento)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadosAlistamiento.id);
                    p.Add("@auditoria", pTiposEstadosAlistamiento.auditoria);

                

 

					TiposEstadosAlistamiento o = SqlMapper.QueryFirstOrDefault<TiposEstadosAlistamiento>(con, "API.PA_TiposEstadosAlistamientoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposEstadosAlistamiento  ->" + ex.Message);
				}
			}

		



            public List<TiposEstadosAlistamiento> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposEstadosAlistamiento> TiposEstadosAlistamientoList = new List<TiposEstadosAlistamiento>();

                    TiposEstadosAlistamientoList = SqlMapper.Query<TiposEstadosAlistamiento>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposEstadosAlistamientoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposEstadosAlistamiento  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposEstadosAlistamiento> b)
            {
                DapperPlusManager.Entity<TiposEstadosAlistamiento>().Table("TiposEstadosAlistamiento");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}