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
     /// Clase Abstracta para  TipoFuenteNutricional
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoFuenteNutricionalRepository : DataObject , ITipoFuenteNutricional 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoFuenteNutricionalRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoFuenteNutricionalRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoFuenteNutricional GetById(TipoFuenteNutricional pTipoFuenteNutricional)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoFuenteNutricional.id);                                    


    				TipoFuenteNutricional o = SqlMapper.QueryFirstOrDefault<TipoFuenteNutricional>(con, "API.PA_TipoFuenteNutricionalGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoFuenteNutricional  ->" + ex.Message);
				}
			}

			public List<TipoFuenteNutricional> GetAll()
			{
				try 
                {
                        List<TipoFuenteNutricional> l = SqlMapper.Query<TipoFuenteNutricional>(con, "API.PA_TipoFuenteNutricionalGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoFuenteNutricional  ->" + ex.Message);
				}
			}

			public List<TipoFuenteNutricional> GetAllFull()
			{
				try 
				{
                    List<TipoFuenteNutricional> l = SqlMapper.Query<TipoFuenteNutricional>(con, "API.PA_TipoFuenteNutricionalGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoFuenteNutricional  ->" + ex.Message);
				}
			}
			
			public List<TipoFuenteNutricional> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoFuenteNutricional> l = SqlMapper.Query<TipoFuenteNutricional>(con, "API.PA_TipoFuenteNutricionalGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoFuenteNutricional  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoFuenteNutricional> GetByFilter(TipoFuenteNutricional pTipoFuenteNutricional, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoFuenteNutricional.id== null || pTipoFuenteNutricional.id==0) ? vintNUll :pTipoFuenteNutricional.id);
                    p.Add("@Nombre",(pTipoFuenteNutricional.Nombre== null) ? vintNUll :pTipoFuenteNutricional.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoFuenteNutricional> l = SqlMapper.Query<TipoFuenteNutricional>(con, "API.PA_TipoFuenteNutricionalGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoFuenteNutricional  ->" + ex.Message);
				}
			}

			public TipoFuenteNutricional Add(TipoFuenteNutricional pTipoFuenteNutricional)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoFuenteNutricional.id==null ? 0 : pTipoFuenteNutricional.id);
                    p.Add("@Nombre", pTipoFuenteNutricional.Nombre);
                    p.Add("@auditoria", pTipoFuenteNutricional.auditoria);

                         


                    TipoFuenteNutricional o = SqlMapper.QueryFirstOrDefault<TipoFuenteNutricional>(con, "API.PA_TipoFuenteNutricionalAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoFuenteNutricional  ->" + ex.Message);
				}
			}

			public TipoFuenteNutricional  Update(TipoFuenteNutricional pTipoFuenteNutricional)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoFuenteNutricional.id==null ? 0 : pTipoFuenteNutricional.id);
                    p.Add("@Nombre", pTipoFuenteNutricional.Nombre);
                    p.Add("@auditoria", pTipoFuenteNutricional.auditoria);

                         


                    TipoFuenteNutricional o = SqlMapper.QueryFirstOrDefault<TipoFuenteNutricional>(con, "API.PA_TipoFuenteNutricionalUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoFuenteNutricional  ->" + ex.Message);
				}
			}

			public bool Delete(TipoFuenteNutricional pTipoFuenteNutricional)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoFuenteNutricional.id);
                    p.Add("@auditoria", pTipoFuenteNutricional.auditoria);

                

 

					TipoFuenteNutricional o = SqlMapper.QueryFirstOrDefault<TipoFuenteNutricional>(con, "API.PA_TipoFuenteNutricionalDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoFuenteNutricional  ->" + ex.Message);
				}
			}

		



            public List<TipoFuenteNutricional> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoFuenteNutricional> TipoFuenteNutricionalList = new List<TipoFuenteNutricional>();

                    TipoFuenteNutricionalList = SqlMapper.Query<TipoFuenteNutricional>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoFuenteNutricionalList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoFuenteNutricional  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoFuenteNutricional> b)
            {
                DapperPlusManager.Entity<TipoFuenteNutricional>().Table("TipoFuenteNutricional");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}