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
     /// Clase Abstracta para  TiposProductoRutas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposProductoRutasRepository : DataObject , ITiposProductoRutas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposProductoRutasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposProductoRutasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposProductoRutas GetById(TiposProductoRutas pTiposProductoRutas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposProductoRutas.id);                                    


    				TiposProductoRutas o = SqlMapper.QueryFirstOrDefault<TiposProductoRutas>(con, "API.PA_TiposProductoRutasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposProductoRutas  ->" + ex.Message);
				}
			}

			public List<TiposProductoRutas> GetAll()
			{
				try 
                {
                        List<TiposProductoRutas> l = SqlMapper.Query<TiposProductoRutas>(con, "API.PA_TiposProductoRutasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposProductoRutas  ->" + ex.Message);
				}
			}

			public List<TiposProductoRutas> GetAllFull()
			{
				try 
				{
                    List<TiposProductoRutas> l = SqlMapper.Query<TiposProductoRutas>(con, "API.PA_TiposProductoRutasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposProductoRutas  ->" + ex.Message);
				}
			}
			
			public List<TiposProductoRutas> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposProductoRutas> l = SqlMapper.Query<TiposProductoRutas>(con, "API.PA_TiposProductoRutasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposProductoRutas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposProductoRutas> GetByFilter(TiposProductoRutas pTiposProductoRutas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposProductoRutas.id== null || pTiposProductoRutas.id==0) ? vintNUll :pTiposProductoRutas.id);
                    p.Add("@Nombre",(pTiposProductoRutas.Nombre== null) ? vintNUll :pTiposProductoRutas.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposProductoRutas> l = SqlMapper.Query<TiposProductoRutas>(con, "API.PA_TiposProductoRutasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposProductoRutas  ->" + ex.Message);
				}
			}

			public TiposProductoRutas Add(TiposProductoRutas pTiposProductoRutas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposProductoRutas.id==null ? 0 : pTiposProductoRutas.id);
                    p.Add("@Nombre", pTiposProductoRutas.Nombre);
                    p.Add("@auditoria", pTiposProductoRutas.auditoria);

                         


                    TiposProductoRutas o = SqlMapper.QueryFirstOrDefault<TiposProductoRutas>(con, "API.PA_TiposProductoRutasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposProductoRutas  ->" + ex.Message);
				}
			}

			public TiposProductoRutas  Update(TiposProductoRutas pTiposProductoRutas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposProductoRutas.id==null ? 0 : pTiposProductoRutas.id);
                    p.Add("@Nombre", pTiposProductoRutas.Nombre);
                    p.Add("@auditoria", pTiposProductoRutas.auditoria);

                         


                    TiposProductoRutas o = SqlMapper.QueryFirstOrDefault<TiposProductoRutas>(con, "API.PA_TiposProductoRutasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposProductoRutas  ->" + ex.Message);
				}
			}

			public bool Delete(TiposProductoRutas pTiposProductoRutas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposProductoRutas.id);
                    p.Add("@auditoria", pTiposProductoRutas.auditoria);

                

 

					TiposProductoRutas o = SqlMapper.QueryFirstOrDefault<TiposProductoRutas>(con, "API.PA_TiposProductoRutasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposProductoRutas  ->" + ex.Message);
				}
			}

		



            public List<TiposProductoRutas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposProductoRutas> TiposProductoRutasList = new List<TiposProductoRutas>();

                    TiposProductoRutasList = SqlMapper.Query<TiposProductoRutas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposProductoRutasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposProductoRutas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposProductoRutas> b)
            {
                DapperPlusManager.Entity<TiposProductoRutas>().Table("TiposProductoRutas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}