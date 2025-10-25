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
     /// Clase Abstracta para  TiposDestinosRaciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposDestinosRacionesRepository : DataObject , ITiposDestinosRaciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposDestinosRacionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposDestinosRacionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposDestinosRaciones GetById(TiposDestinosRaciones pTiposDestinosRaciones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposDestinosRaciones.id);                                    


    				TiposDestinosRaciones o = SqlMapper.QueryFirstOrDefault<TiposDestinosRaciones>(con, "API.PA_TiposDestinosComplementosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposDestinosRaciones  ->" + ex.Message);
				}
			}

			public List<TiposDestinosRaciones> GetAll()
			{
				try 
                {
                        List<TiposDestinosRaciones> l = SqlMapper.Query<TiposDestinosRaciones>(con, "API.PA_TiposDestinosComplementosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposDestinosRaciones  ->" + ex.Message);
				}
			}

			public List<TiposDestinosRaciones> GetAllFull()
			{
				try 
				{
                    List<TiposDestinosRaciones> l = SqlMapper.Query<TiposDestinosRaciones>(con, "API.PA_TiposDestinosComplementosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposDestinosRaciones  ->" + ex.Message);
				}
			}
			
			public List<TiposDestinosRaciones> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposDestinosRaciones> l = SqlMapper.Query<TiposDestinosRaciones>(con, "API.PA_TiposDestinosComplementosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposDestinosRaciones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposDestinosRaciones> GetByFilter(TiposDestinosRaciones pTiposDestinosRaciones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposDestinosRaciones.id== null || pTiposDestinosRaciones.id==0) ? vintNUll :pTiposDestinosRaciones.id);
                    p.Add("@Nombre",(pTiposDestinosRaciones.Nombre== null) ? vintNUll :pTiposDestinosRaciones.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposDestinosRaciones> l = SqlMapper.Query<TiposDestinosRaciones>(con, "API.PA_TiposDestinosComplementosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposDestinosRaciones  ->" + ex.Message);
				}
			}

			public TiposDestinosRaciones Add(TiposDestinosRaciones pTiposDestinosRaciones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposDestinosRaciones.id==null ? 0 : pTiposDestinosRaciones.id);
                    p.Add("@Nombre", pTiposDestinosRaciones.Nombre);
                    p.Add("@auditoria", pTiposDestinosRaciones.auditoria);

                         


                    TiposDestinosRaciones o = SqlMapper.QueryFirstOrDefault<TiposDestinosRaciones>(con, "API.PA_TiposDestinosComplementosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposDestinosRaciones  ->" + ex.Message);
				}
			}

			public TiposDestinosRaciones  Update(TiposDestinosRaciones pTiposDestinosRaciones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposDestinosRaciones.id==null ? 0 : pTiposDestinosRaciones.id);
                    p.Add("@Nombre", pTiposDestinosRaciones.Nombre);
                    p.Add("@auditoria", pTiposDestinosRaciones.auditoria);

                         


                    TiposDestinosRaciones o = SqlMapper.QueryFirstOrDefault<TiposDestinosRaciones>(con, "API.PA_TiposDestinosComplementosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposDestinosRaciones  ->" + ex.Message);
				}
			}

			public bool Delete(TiposDestinosRaciones pTiposDestinosRaciones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposDestinosRaciones.id);
                    p.Add("@auditoria", pTiposDestinosRaciones.auditoria);

                

 

					TiposDestinosRaciones o = SqlMapper.QueryFirstOrDefault<TiposDestinosRaciones>(con, "API.PA_TiposDestinosComplementosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposDestinosRaciones  ->" + ex.Message);
				}
			}

		



            public List<TiposDestinosRaciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposDestinosRaciones> TiposDestinosRacionesList = new List<TiposDestinosRaciones>();

                    TiposDestinosRacionesList = SqlMapper.Query<TiposDestinosRaciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposDestinosRacionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposDestinosRaciones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposDestinosRaciones> b)
            {
                DapperPlusManager.Entity<TiposDestinosRaciones>().Table("TiposDestinosRaciones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}