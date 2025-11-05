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
     /// Clase Abstracta para  TiposEstadosVisitas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposEstadosVisitasRepository : DataObject , ITiposEstadosVisitas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposEstadosVisitasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposEstadosVisitasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposEstadosVisitas GetById(TiposEstadosVisitas pTiposEstadosVisitas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadosVisitas.id);                                    


    				TiposEstadosVisitas o = SqlMapper.QueryFirstOrDefault<TiposEstadosVisitas>(con, "API.PA_TiposEstadosVisitasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposEstadosVisitas  ->" + ex.Message);
				}
			}

			public List<TiposEstadosVisitas> GetAll()
			{
				try 
                {
                        List<TiposEstadosVisitas> l = SqlMapper.Query<TiposEstadosVisitas>(con, "API.PA_TiposEstadosVisitasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposEstadosVisitas  ->" + ex.Message);
				}
			}

			public List<TiposEstadosVisitas> GetAllFull()
			{
				try 
				{
                    List<TiposEstadosVisitas> l = SqlMapper.Query<TiposEstadosVisitas>(con, "API.PA_TiposEstadosVisitasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposEstadosVisitas  ->" + ex.Message);
				}
			}
			
			public List<TiposEstadosVisitas> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposEstadosVisitas> l = SqlMapper.Query<TiposEstadosVisitas>(con, "API.PA_TiposEstadosVisitasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposEstadosVisitas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposEstadosVisitas> GetByFilter(TiposEstadosVisitas pTiposEstadosVisitas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposEstadosVisitas.id== null || pTiposEstadosVisitas.id==0) ? vintNUll :pTiposEstadosVisitas.id);
                    p.Add("@Nombre",(pTiposEstadosVisitas.Nombre== null) ? vintNUll :pTiposEstadosVisitas.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposEstadosVisitas> l = SqlMapper.Query<TiposEstadosVisitas>(con, "API.PA_TiposEstadosVisitasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposEstadosVisitas  ->" + ex.Message);
				}
			}

			public TiposEstadosVisitas Add(TiposEstadosVisitas pTiposEstadosVisitas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposEstadosVisitas.id==null ? 0 : pTiposEstadosVisitas.id);
                    p.Add("@Nombre", pTiposEstadosVisitas.Nombre);
                    p.Add("@auditoria", pTiposEstadosVisitas.auditoria);

                         


                    TiposEstadosVisitas o = SqlMapper.QueryFirstOrDefault<TiposEstadosVisitas>(con, "API.PA_TiposEstadosVisitasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposEstadosVisitas  ->" + ex.Message);
				}
			}

			public TiposEstadosVisitas  Update(TiposEstadosVisitas pTiposEstadosVisitas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposEstadosVisitas.id==null ? 0 : pTiposEstadosVisitas.id);
                    p.Add("@Nombre", pTiposEstadosVisitas.Nombre);
                    p.Add("@auditoria", pTiposEstadosVisitas.auditoria);

                         


                    TiposEstadosVisitas o = SqlMapper.QueryFirstOrDefault<TiposEstadosVisitas>(con, "API.PA_TiposEstadosVisitasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposEstadosVisitas  ->" + ex.Message);
				}
			}

			public bool Delete(TiposEstadosVisitas pTiposEstadosVisitas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadosVisitas.id);
                    p.Add("@auditoria", pTiposEstadosVisitas.auditoria);

                

 

					TiposEstadosVisitas o = SqlMapper.QueryFirstOrDefault<TiposEstadosVisitas>(con, "API.PA_TiposEstadosVisitasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposEstadosVisitas  ->" + ex.Message);
				}
			}

		



            public List<TiposEstadosVisitas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposEstadosVisitas> TiposEstadosVisitasList = new List<TiposEstadosVisitas>();

                    TiposEstadosVisitasList = SqlMapper.Query<TiposEstadosVisitas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposEstadosVisitasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposEstadosVisitas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposEstadosVisitas> b)
            {
                DapperPlusManager.Entity<TiposEstadosVisitas>().Table("TiposEstadosVisitas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}