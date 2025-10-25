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
     /// Clase Abstracta para  TipoProcesosCargue
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoProcesosCargueRepository : DataObject , ITipoProcesosCargue 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoProcesosCargueRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoProcesosCargueRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoProcesosCargue GetById(TipoProcesosCargue pTipoProcesosCargue)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoProcesosCargue.id);                                    


    				TipoProcesosCargue o = SqlMapper.QueryFirstOrDefault<TipoProcesosCargue>(con, "API.PA_TipoProcesosCargueGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoProcesosCargue  ->" + ex.Message);
				}
			}

			public List<TipoProcesosCargue> GetAll()
			{
				try 
                {
                        List<TipoProcesosCargue> l = SqlMapper.Query<TipoProcesosCargue>(con, "API.PA_TipoProcesosCargueGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoProcesosCargue  ->" + ex.Message);
				}
			}

			public List<TipoProcesosCargue> GetAllFull()
			{
				try 
				{
                    List<TipoProcesosCargue> l = SqlMapper.Query<TipoProcesosCargue>(con, "API.PA_TipoProcesosCargueGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoProcesosCargue  ->" + ex.Message);
				}
			}
			
			public List<TipoProcesosCargue> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoProcesosCargue> l = SqlMapper.Query<TipoProcesosCargue>(con, "API.PA_TipoProcesosCargueGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoProcesosCargue  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoProcesosCargue> GetByFilter(TipoProcesosCargue pTipoProcesosCargue, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoProcesosCargue.id== null || pTipoProcesosCargue.id==0) ? vintNUll :pTipoProcesosCargue.id);
                    p.Add("@Nombre",(pTipoProcesosCargue.Nombre== null) ? vintNUll :pTipoProcesosCargue.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoProcesosCargue> l = SqlMapper.Query<TipoProcesosCargue>(con, "API.PA_TipoProcesosCargueGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoProcesosCargue  ->" + ex.Message);
				}
			}

			public TipoProcesosCargue Add(TipoProcesosCargue pTipoProcesosCargue)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoProcesosCargue.id==null ? 0 : pTipoProcesosCargue.id);
                    p.Add("@Nombre", pTipoProcesosCargue.Nombre);
                    p.Add("@auditoria", pTipoProcesosCargue.auditoria);

                         


                    TipoProcesosCargue o = SqlMapper.QueryFirstOrDefault<TipoProcesosCargue>(con, "API.PA_TipoProcesosCargueAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoProcesosCargue  ->" + ex.Message);
				}
			}

			public TipoProcesosCargue  Update(TipoProcesosCargue pTipoProcesosCargue)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoProcesosCargue.id==null ? 0 : pTipoProcesosCargue.id);
                    p.Add("@Nombre", pTipoProcesosCargue.Nombre);
                    p.Add("@auditoria", pTipoProcesosCargue.auditoria);

                         


                    TipoProcesosCargue o = SqlMapper.QueryFirstOrDefault<TipoProcesosCargue>(con, "API.PA_TipoProcesosCargueUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoProcesosCargue  ->" + ex.Message);
				}
			}

			public bool Delete(TipoProcesosCargue pTipoProcesosCargue)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoProcesosCargue.id);
                    p.Add("@auditoria", pTipoProcesosCargue.auditoria);

                

 

					TipoProcesosCargue o = SqlMapper.QueryFirstOrDefault<TipoProcesosCargue>(con, "API.PA_TipoProcesosCargueDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoProcesosCargue  ->" + ex.Message);
				}
			}

		



            public List<TipoProcesosCargue> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoProcesosCargue> TipoProcesosCargueList = new List<TipoProcesosCargue>();

                    TipoProcesosCargueList = SqlMapper.Query<TipoProcesosCargue>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoProcesosCargueList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoProcesosCargue  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoProcesosCargue> b)
            {
                DapperPlusManager.Entity<TipoProcesosCargue>().Table("TipoProcesosCargue");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}