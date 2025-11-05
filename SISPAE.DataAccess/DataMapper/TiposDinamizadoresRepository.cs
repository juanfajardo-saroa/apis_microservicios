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
     /// Clase Abstracta para  TiposDinamizadores
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposDinamizadoresRepository : DataObject , ITiposDinamizadores 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposDinamizadoresRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposDinamizadoresRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposDinamizadores GetById(TiposDinamizadores pTiposDinamizadores)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposDinamizadores.id);                                    


    				TiposDinamizadores o = SqlMapper.QueryFirstOrDefault<TiposDinamizadores>(con, "API.PA_TiposDinamizadoresGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposDinamizadores  ->" + ex.Message);
				}
			}

			public List<TiposDinamizadores> GetAll()
			{
				try 
                {
                        List<TiposDinamizadores> l = SqlMapper.Query<TiposDinamizadores>(con, "API.PA_TiposDinamizadoresGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposDinamizadores  ->" + ex.Message);
				}
			}

			public List<TiposDinamizadores> GetAllFull()
			{
				try 
				{
                    List<TiposDinamizadores> l = SqlMapper.Query<TiposDinamizadores>(con, "API.PA_TiposDinamizadoresGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposDinamizadores  ->" + ex.Message);
				}
			}
			
			public List<TiposDinamizadores> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposDinamizadores> l = SqlMapper.Query<TiposDinamizadores>(con, "API.PA_TiposDinamizadoresGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposDinamizadores  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposDinamizadores> GetByFilter(TiposDinamizadores pTiposDinamizadores, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposDinamizadores.id== null || pTiposDinamizadores.id==0) ? vintNUll :pTiposDinamizadores.id);
                    p.Add("@Nombre",(pTiposDinamizadores.Nombre== null) ? vintNUll :pTiposDinamizadores.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposDinamizadores> l = SqlMapper.Query<TiposDinamizadores>(con, "API.PA_TiposDinamizadoresGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposDinamizadores  ->" + ex.Message);
				}
			}

			public TiposDinamizadores Add(TiposDinamizadores pTiposDinamizadores)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposDinamizadores.id==null ? 0 : pTiposDinamizadores.id);
                    p.Add("@Nombre", pTiposDinamizadores.Nombre);
                    p.Add("@auditoria", pTiposDinamizadores.auditoria);

                         


                    TiposDinamizadores o = SqlMapper.QueryFirstOrDefault<TiposDinamizadores>(con, "API.PA_TiposDinamizadoresAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposDinamizadores  ->" + ex.Message);
				}
			}

			public TiposDinamizadores  Update(TiposDinamizadores pTiposDinamizadores)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposDinamizadores.id==null ? 0 : pTiposDinamizadores.id);
                    p.Add("@Nombre", pTiposDinamizadores.Nombre);
                    p.Add("@auditoria", pTiposDinamizadores.auditoria);

                         


                    TiposDinamizadores o = SqlMapper.QueryFirstOrDefault<TiposDinamizadores>(con, "API.PA_TiposDinamizadoresUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposDinamizadores  ->" + ex.Message);
				}
			}

			public bool Delete(TiposDinamizadores pTiposDinamizadores)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposDinamizadores.id);
                    p.Add("@auditoria", pTiposDinamizadores.auditoria);

                

 

					TiposDinamizadores o = SqlMapper.QueryFirstOrDefault<TiposDinamizadores>(con, "API.PA_TiposDinamizadoresDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposDinamizadores  ->" + ex.Message);
				}
			}

		



            public List<TiposDinamizadores> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposDinamizadores> TiposDinamizadoresList = new List<TiposDinamizadores>();

                    TiposDinamizadoresList = SqlMapper.Query<TiposDinamizadores>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposDinamizadoresList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposDinamizadores  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposDinamizadores> b)
            {
                DapperPlusManager.Entity<TiposDinamizadores>().Table("TiposDinamizadores");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}