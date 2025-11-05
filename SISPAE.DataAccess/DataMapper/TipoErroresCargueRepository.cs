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
     /// Clase Abstracta para  TipoErroresCargue
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoErroresCargueRepository : DataObject , ITipoErroresCargue 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoErroresCargueRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoErroresCargueRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoErroresCargue GetById(TipoErroresCargue pTipoErroresCargue)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoErroresCargue.id);                                    


    				TipoErroresCargue o = SqlMapper.QueryFirstOrDefault<TipoErroresCargue>(con, "API.PA_TipoErroresCargueGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoErroresCargue  ->" + ex.Message);
				}
			}

			public List<TipoErroresCargue> GetAll()
			{
				try 
                {
                        List<TipoErroresCargue> l = SqlMapper.Query<TipoErroresCargue>(con, "API.PA_TipoErroresCargueGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoErroresCargue  ->" + ex.Message);
				}
			}

			public List<TipoErroresCargue> GetAllFull()
			{
				try 
				{
                    List<TipoErroresCargue> l = SqlMapper.Query<TipoErroresCargue>(con, "API.PA_TipoErroresCargueGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoErroresCargue  ->" + ex.Message);
				}
			}
			
			public List<TipoErroresCargue> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoErroresCargue> l = SqlMapper.Query<TipoErroresCargue>(con, "API.PA_TipoErroresCargueGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoErroresCargue  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoErroresCargue> GetByFilter(TipoErroresCargue pTipoErroresCargue, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoErroresCargue.id== null || pTipoErroresCargue.id==0) ? vintNUll :pTipoErroresCargue.id);
                    p.Add("@Nombre",(pTipoErroresCargue.Nombre== null) ? vintNUll :pTipoErroresCargue.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoErroresCargue> l = SqlMapper.Query<TipoErroresCargue>(con, "API.PA_TipoErroresCargueGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoErroresCargue  ->" + ex.Message);
				}
			}

			public TipoErroresCargue Add(TipoErroresCargue pTipoErroresCargue)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoErroresCargue.id==null ? 0 : pTipoErroresCargue.id);
                    p.Add("@Nombre", pTipoErroresCargue.Nombre);
                    p.Add("@auditoria", pTipoErroresCargue.auditoria);

                         


                    TipoErroresCargue o = SqlMapper.QueryFirstOrDefault<TipoErroresCargue>(con, "API.PA_TipoErroresCargueAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoErroresCargue  ->" + ex.Message);
				}
			}

			public TipoErroresCargue  Update(TipoErroresCargue pTipoErroresCargue)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoErroresCargue.id==null ? 0 : pTipoErroresCargue.id);
                    p.Add("@Nombre", pTipoErroresCargue.Nombre);
                    p.Add("@auditoria", pTipoErroresCargue.auditoria);

                         


                    TipoErroresCargue o = SqlMapper.QueryFirstOrDefault<TipoErroresCargue>(con, "API.PA_TipoErroresCargueUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoErroresCargue  ->" + ex.Message);
				}
			}

			public bool Delete(TipoErroresCargue pTipoErroresCargue)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoErroresCargue.id);
                    p.Add("@auditoria", pTipoErroresCargue.auditoria);

                

 

					TipoErroresCargue o = SqlMapper.QueryFirstOrDefault<TipoErroresCargue>(con, "API.PA_TipoErroresCargueDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoErroresCargue  ->" + ex.Message);
				}
			}

		



            public List<TipoErroresCargue> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoErroresCargue> TipoErroresCargueList = new List<TipoErroresCargue>();

                    TipoErroresCargueList = SqlMapper.Query<TipoErroresCargue>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoErroresCargueList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoErroresCargue  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoErroresCargue> b)
            {
                DapperPlusManager.Entity<TipoErroresCargue>().Table("TipoErroresCargue");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}