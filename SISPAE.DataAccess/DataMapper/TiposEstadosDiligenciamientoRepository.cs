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
     /// Clase Abstracta para  TiposEstadosDiligenciamiento
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposEstadosDiligenciamientoRepository : DataObject , ITiposEstadosDiligenciamiento 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposEstadosDiligenciamientoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposEstadosDiligenciamientoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposEstadosDiligenciamiento GetById(TiposEstadosDiligenciamiento pTiposEstadosDiligenciamiento)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadosDiligenciamiento.id);                                    


    				TiposEstadosDiligenciamiento o = SqlMapper.QueryFirstOrDefault<TiposEstadosDiligenciamiento>(con, "API.PA_TiposEstadosDiligenciamientoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposEstadosDiligenciamiento  ->" + ex.Message);
				}
			}

			public List<TiposEstadosDiligenciamiento> GetAll()
			{
				try 
                {
                        List<TiposEstadosDiligenciamiento> l = SqlMapper.Query<TiposEstadosDiligenciamiento>(con, "API.PA_TiposEstadosDiligenciamientoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposEstadosDiligenciamiento  ->" + ex.Message);
				}
			}

			public List<TiposEstadosDiligenciamiento> GetAllFull()
			{
				try 
				{
                    List<TiposEstadosDiligenciamiento> l = SqlMapper.Query<TiposEstadosDiligenciamiento>(con, "API.PA_TiposEstadosDiligenciamientoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposEstadosDiligenciamiento  ->" + ex.Message);
				}
			}
			
			public List<TiposEstadosDiligenciamiento> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposEstadosDiligenciamiento> l = SqlMapper.Query<TiposEstadosDiligenciamiento>(con, "API.PA_TiposEstadosDiligenciamientoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposEstadosDiligenciamiento  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposEstadosDiligenciamiento> GetByFilter(TiposEstadosDiligenciamiento pTiposEstadosDiligenciamiento, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposEstadosDiligenciamiento.id== null || pTiposEstadosDiligenciamiento.id==0) ? vintNUll :pTiposEstadosDiligenciamiento.id);
                    p.Add("@Nombre",(pTiposEstadosDiligenciamiento.Nombre== null) ? vintNUll :pTiposEstadosDiligenciamiento.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposEstadosDiligenciamiento> l = SqlMapper.Query<TiposEstadosDiligenciamiento>(con, "API.PA_TiposEstadosDiligenciamientoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposEstadosDiligenciamiento  ->" + ex.Message);
				}
			}

			public TiposEstadosDiligenciamiento Add(TiposEstadosDiligenciamiento pTiposEstadosDiligenciamiento)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposEstadosDiligenciamiento.id==null ? 0 : pTiposEstadosDiligenciamiento.id);
                    p.Add("@Nombre", pTiposEstadosDiligenciamiento.Nombre);
                    p.Add("@auditoria", pTiposEstadosDiligenciamiento.auditoria);

                         


                    TiposEstadosDiligenciamiento o = SqlMapper.QueryFirstOrDefault<TiposEstadosDiligenciamiento>(con, "API.PA_TiposEstadosDiligenciamientoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposEstadosDiligenciamiento  ->" + ex.Message);
				}
			}

			public TiposEstadosDiligenciamiento  Update(TiposEstadosDiligenciamiento pTiposEstadosDiligenciamiento)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposEstadosDiligenciamiento.id==null ? 0 : pTiposEstadosDiligenciamiento.id);
                    p.Add("@Nombre", pTiposEstadosDiligenciamiento.Nombre);
                    p.Add("@auditoria", pTiposEstadosDiligenciamiento.auditoria);

                         


                    TiposEstadosDiligenciamiento o = SqlMapper.QueryFirstOrDefault<TiposEstadosDiligenciamiento>(con, "API.PA_TiposEstadosDiligenciamientoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposEstadosDiligenciamiento  ->" + ex.Message);
				}
			}

			public bool Delete(TiposEstadosDiligenciamiento pTiposEstadosDiligenciamiento)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadosDiligenciamiento.id);
                    p.Add("@auditoria", pTiposEstadosDiligenciamiento.auditoria);

                

 

					TiposEstadosDiligenciamiento o = SqlMapper.QueryFirstOrDefault<TiposEstadosDiligenciamiento>(con, "API.PA_TiposEstadosDiligenciamientoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposEstadosDiligenciamiento  ->" + ex.Message);
				}
			}

		



            public List<TiposEstadosDiligenciamiento> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposEstadosDiligenciamiento> TiposEstadosDiligenciamientoList = new List<TiposEstadosDiligenciamiento>();

                    TiposEstadosDiligenciamientoList = SqlMapper.Query<TiposEstadosDiligenciamiento>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposEstadosDiligenciamientoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposEstadosDiligenciamiento  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposEstadosDiligenciamiento> b)
            {
                DapperPlusManager.Entity<TiposEstadosDiligenciamiento>().Table("TiposEstadosDiligenciamiento");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}