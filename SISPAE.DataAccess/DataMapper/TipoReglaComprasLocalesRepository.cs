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
     /// Clase Abstracta para  TipoReglaComprasLocales
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoReglaComprasLocalesRepository : DataObject , ITipoReglaComprasLocales 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoReglaComprasLocalesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoReglaComprasLocalesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoReglaComprasLocales GetById(TipoReglaComprasLocales pTipoReglaComprasLocales)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoReglaComprasLocales.id);                                    


    				TipoReglaComprasLocales o = SqlMapper.QueryFirstOrDefault<TipoReglaComprasLocales>(con, "API.PA_TipoReglaComprasLocalesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoReglaComprasLocales  ->" + ex.Message);
				}
			}

			public List<TipoReglaComprasLocales> GetAll()
			{
				try 
                {
                        List<TipoReglaComprasLocales> l = SqlMapper.Query<TipoReglaComprasLocales>(con, "API.PA_TipoReglaComprasLocalesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoReglaComprasLocales  ->" + ex.Message);
				}
			}

			public List<TipoReglaComprasLocales> GetAllFull()
			{
				try 
				{
                    List<TipoReglaComprasLocales> l = SqlMapper.Query<TipoReglaComprasLocales>(con, "API.PA_TipoReglaComprasLocalesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoReglaComprasLocales  ->" + ex.Message);
				}
			}
			
			public List<TipoReglaComprasLocales> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoReglaComprasLocales> l = SqlMapper.Query<TipoReglaComprasLocales>(con, "API.PA_TipoReglaComprasLocalesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoReglaComprasLocales  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoReglaComprasLocales> GetByFilter(TipoReglaComprasLocales pTipoReglaComprasLocales, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoReglaComprasLocales.id== null || pTipoReglaComprasLocales.id==0) ? vintNUll :pTipoReglaComprasLocales.id);
                    p.Add("@Nombre",(pTipoReglaComprasLocales.Nombre== null) ? vintNUll :pTipoReglaComprasLocales.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoReglaComprasLocales> l = SqlMapper.Query<TipoReglaComprasLocales>(con, "API.PA_TipoReglaComprasLocalesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoReglaComprasLocales  ->" + ex.Message);
				}
			}

			public TipoReglaComprasLocales Add(TipoReglaComprasLocales pTipoReglaComprasLocales)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoReglaComprasLocales.id==null ? 0 : pTipoReglaComprasLocales.id);
                    p.Add("@Nombre", pTipoReglaComprasLocales.Nombre);
                    p.Add("@auditoria", pTipoReglaComprasLocales.auditoria);

                         


                    TipoReglaComprasLocales o = SqlMapper.QueryFirstOrDefault<TipoReglaComprasLocales>(con, "API.PA_TipoReglaComprasLocalesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoReglaComprasLocales  ->" + ex.Message);
				}
			}

			public TipoReglaComprasLocales  Update(TipoReglaComprasLocales pTipoReglaComprasLocales)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoReglaComprasLocales.id==null ? 0 : pTipoReglaComprasLocales.id);
                    p.Add("@Nombre", pTipoReglaComprasLocales.Nombre);
                    p.Add("@auditoria", pTipoReglaComprasLocales.auditoria);

                         


                    TipoReglaComprasLocales o = SqlMapper.QueryFirstOrDefault<TipoReglaComprasLocales>(con, "API.PA_TipoReglaComprasLocalesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoReglaComprasLocales  ->" + ex.Message);
				}
			}

			public bool Delete(TipoReglaComprasLocales pTipoReglaComprasLocales)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoReglaComprasLocales.id);
                    p.Add("@auditoria", pTipoReglaComprasLocales.auditoria);

                

 

					TipoReglaComprasLocales o = SqlMapper.QueryFirstOrDefault<TipoReglaComprasLocales>(con, "API.PA_TipoReglaComprasLocalesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoReglaComprasLocales  ->" + ex.Message);
				}
			}

		



            public List<TipoReglaComprasLocales> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoReglaComprasLocales> TipoReglaComprasLocalesList = new List<TipoReglaComprasLocales>();

                    TipoReglaComprasLocalesList = SqlMapper.Query<TipoReglaComprasLocales>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoReglaComprasLocalesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoReglaComprasLocales  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoReglaComprasLocales> b)
            {
                DapperPlusManager.Entity<TipoReglaComprasLocales>().Table("TipoReglaComprasLocales");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}