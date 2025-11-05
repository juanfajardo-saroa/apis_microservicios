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
     /// Clase Abstracta para  TiposIngreso
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposIngresoRepository : DataObject , ITiposIngreso 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposIngresoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposIngresoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposIngreso GetById(TiposIngreso pTiposIngreso)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposIngreso.id);                                    


    				TiposIngreso o = SqlMapper.QueryFirstOrDefault<TiposIngreso>(con, "API.PA_TiposIngresoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposIngreso  ->" + ex.Message);
				}
			}

			public List<TiposIngreso> GetAll()
			{
				try 
                {
                        List<TiposIngreso> l = SqlMapper.Query<TiposIngreso>(con, "API.PA_TiposIngresoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposIngreso  ->" + ex.Message);
				}
			}

			public List<TiposIngreso> GetAllFull()
			{
				try 
				{
                    List<TiposIngreso> l = SqlMapper.Query<TiposIngreso>(con, "API.PA_TiposIngresoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposIngreso  ->" + ex.Message);
				}
			}
			
			public List<TiposIngreso> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposIngreso> l = SqlMapper.Query<TiposIngreso>(con, "API.PA_TiposIngresoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposIngreso  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposIngreso> GetByFilter(TiposIngreso pTiposIngreso, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposIngreso.id== null || pTiposIngreso.id==0) ? vintNUll :pTiposIngreso.id);
                    p.Add("@Nombre",(pTiposIngreso.Nombre== null) ? vintNUll :pTiposIngreso.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposIngreso> l = SqlMapper.Query<TiposIngreso>(con, "API.PA_TiposIngresoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposIngreso  ->" + ex.Message);
				}
			}

			public TiposIngreso Add(TiposIngreso pTiposIngreso)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposIngreso.id==null ? 0 : pTiposIngreso.id);
                    p.Add("@Nombre", pTiposIngreso.Nombre);
                    p.Add("@auditoria", pTiposIngreso.auditoria);

                         


                    TiposIngreso o = SqlMapper.QueryFirstOrDefault<TiposIngreso>(con, "API.PA_TiposIngresoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposIngreso  ->" + ex.Message);
				}
			}

			public TiposIngreso  Update(TiposIngreso pTiposIngreso)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposIngreso.id==null ? 0 : pTiposIngreso.id);
                    p.Add("@Nombre", pTiposIngreso.Nombre);
                    p.Add("@auditoria", pTiposIngreso.auditoria);

                         


                    TiposIngreso o = SqlMapper.QueryFirstOrDefault<TiposIngreso>(con, "API.PA_TiposIngresoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposIngreso  ->" + ex.Message);
				}
			}

			public bool Delete(TiposIngreso pTiposIngreso)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposIngreso.id);
                    p.Add("@auditoria", pTiposIngreso.auditoria);

                

 

					TiposIngreso o = SqlMapper.QueryFirstOrDefault<TiposIngreso>(con, "API.PA_TiposIngresoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposIngreso  ->" + ex.Message);
				}
			}

		



            public List<TiposIngreso> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposIngreso> TiposIngresoList = new List<TiposIngreso>();

                    TiposIngresoList = SqlMapper.Query<TiposIngreso>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposIngresoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposIngreso  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposIngreso> b)
            {
                DapperPlusManager.Entity<TiposIngreso>().Table("TiposIngreso");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}