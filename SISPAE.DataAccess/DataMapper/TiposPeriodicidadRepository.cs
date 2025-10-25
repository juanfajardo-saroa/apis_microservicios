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
     /// Clase Abstracta para  TiposPeriodicidad
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposPeriodicidadRepository : DataObject , ITiposPeriodicidad 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposPeriodicidadRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposPeriodicidadRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposPeriodicidad GetById(TiposPeriodicidad pTiposPeriodicidad)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposPeriodicidad.id);                                    


    				TiposPeriodicidad o = SqlMapper.QueryFirstOrDefault<TiposPeriodicidad>(con, "API.PA_TiposPeriodicidadGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposPeriodicidad  ->" + ex.Message);
				}
			}

			public List<TiposPeriodicidad> GetAll()
			{
				try 
                {
                        List<TiposPeriodicidad> l = SqlMapper.Query<TiposPeriodicidad>(con, "API.PA_TiposPeriodicidadGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposPeriodicidad  ->" + ex.Message);
				}
			}

			public List<TiposPeriodicidad> GetAllFull()
			{
				try 
				{
                    List<TiposPeriodicidad> l = SqlMapper.Query<TiposPeriodicidad>(con, "API.PA_TiposPeriodicidadGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposPeriodicidad  ->" + ex.Message);
				}
			}
			
			public List<TiposPeriodicidad> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposPeriodicidad> l = SqlMapper.Query<TiposPeriodicidad>(con, "API.PA_TiposPeriodicidadGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposPeriodicidad  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposPeriodicidad> GetByFilter(TiposPeriodicidad pTiposPeriodicidad, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposPeriodicidad.id== null || pTiposPeriodicidad.id==0) ? vintNUll :pTiposPeriodicidad.id);
                    p.Add("@Nombre",(pTiposPeriodicidad.Nombre== null) ? vintNUll :pTiposPeriodicidad.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposPeriodicidad> l = SqlMapper.Query<TiposPeriodicidad>(con, "API.PA_TiposPeriodicidadGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposPeriodicidad  ->" + ex.Message);
				}
			}

			public TiposPeriodicidad Add(TiposPeriodicidad pTiposPeriodicidad)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposPeriodicidad.id==null ? 0 : pTiposPeriodicidad.id);
                    p.Add("@Nombre", pTiposPeriodicidad.Nombre);
                    p.Add("@auditoria", pTiposPeriodicidad.auditoria);

                         


                    TiposPeriodicidad o = SqlMapper.QueryFirstOrDefault<TiposPeriodicidad>(con, "API.PA_TiposPeriodicidadAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposPeriodicidad  ->" + ex.Message);
				}
			}

			public TiposPeriodicidad  Update(TiposPeriodicidad pTiposPeriodicidad)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposPeriodicidad.id==null ? 0 : pTiposPeriodicidad.id);
                    p.Add("@Nombre", pTiposPeriodicidad.Nombre);
                    p.Add("@auditoria", pTiposPeriodicidad.auditoria);

                         


                    TiposPeriodicidad o = SqlMapper.QueryFirstOrDefault<TiposPeriodicidad>(con, "API.PA_TiposPeriodicidadUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposPeriodicidad  ->" + ex.Message);
				}
			}

			public bool Delete(TiposPeriodicidad pTiposPeriodicidad)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposPeriodicidad.id);
                    p.Add("@auditoria", pTiposPeriodicidad.auditoria);

                

 

					TiposPeriodicidad o = SqlMapper.QueryFirstOrDefault<TiposPeriodicidad>(con, "API.PA_TiposPeriodicidadDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposPeriodicidad  ->" + ex.Message);
				}
			}

		



            public List<TiposPeriodicidad> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposPeriodicidad> TiposPeriodicidadList = new List<TiposPeriodicidad>();

                    TiposPeriodicidadList = SqlMapper.Query<TiposPeriodicidad>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposPeriodicidadList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposPeriodicidad  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposPeriodicidad> b)
            {
                DapperPlusManager.Entity<TiposPeriodicidad>().Table("TiposPeriodicidad");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}