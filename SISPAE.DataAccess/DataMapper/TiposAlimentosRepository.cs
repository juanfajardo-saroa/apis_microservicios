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
     /// Clase Abstracta para  TiposAlimentos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposAlimentosRepository : DataObject , ITiposAlimentos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposAlimentosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposAlimentosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposAlimentos GetById(TiposAlimentos pTiposAlimentos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposAlimentos.id);                                    


    				TiposAlimentos o = SqlMapper.QueryFirstOrDefault<TiposAlimentos>(con, "API.PA_TiposAlimentosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposAlimentos  ->" + ex.Message);
				}
			}

			public List<TiposAlimentos> GetAll()
			{
				try 
                {
                        List<TiposAlimentos> l = SqlMapper.Query<TiposAlimentos>(con, "API.PA_TiposAlimentosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposAlimentos  ->" + ex.Message);
				}
			}

			public List<TiposAlimentos> GetAllFull()
			{
				try 
				{
                    List<TiposAlimentos> l = SqlMapper.Query<TiposAlimentos>(con, "API.PA_TiposAlimentosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposAlimentos  ->" + ex.Message);
				}
			}
			
			public List<TiposAlimentos> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposAlimentos> l = SqlMapper.Query<TiposAlimentos>(con, "API.PA_TiposAlimentosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposAlimentos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposAlimentos> GetByFilter(TiposAlimentos pTiposAlimentos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposAlimentos.id== null || pTiposAlimentos.id==0) ? vintNUll :pTiposAlimentos.id);
                    p.Add("@Nombre",(pTiposAlimentos.Nombre== null) ? vintNUll :pTiposAlimentos.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposAlimentos> l = SqlMapper.Query<TiposAlimentos>(con, "API.PA_TiposAlimentosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposAlimentos  ->" + ex.Message);
				}
			}

			public TiposAlimentos Add(TiposAlimentos pTiposAlimentos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposAlimentos.id==null ? 0 : pTiposAlimentos.id);
                    p.Add("@Nombre", pTiposAlimentos.Nombre);
                    p.Add("@auditoria", pTiposAlimentos.auditoria);

                         


                    TiposAlimentos o = SqlMapper.QueryFirstOrDefault<TiposAlimentos>(con, "API.PA_TiposAlimentosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposAlimentos  ->" + ex.Message);
				}
			}

			public TiposAlimentos  Update(TiposAlimentos pTiposAlimentos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposAlimentos.id==null ? 0 : pTiposAlimentos.id);
                    p.Add("@Nombre", pTiposAlimentos.Nombre);
                    p.Add("@auditoria", pTiposAlimentos.auditoria);

                         


                    TiposAlimentos o = SqlMapper.QueryFirstOrDefault<TiposAlimentos>(con, "API.PA_TiposAlimentosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposAlimentos  ->" + ex.Message);
				}
			}

			public bool Delete(TiposAlimentos pTiposAlimentos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposAlimentos.id);
                    p.Add("@auditoria", pTiposAlimentos.auditoria);

                

 

					TiposAlimentos o = SqlMapper.QueryFirstOrDefault<TiposAlimentos>(con, "API.PA_TiposAlimentosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposAlimentos  ->" + ex.Message);
				}
			}

		



            public List<TiposAlimentos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposAlimentos> TiposAlimentosList = new List<TiposAlimentos>();

                    TiposAlimentosList = SqlMapper.Query<TiposAlimentos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposAlimentosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposAlimentos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposAlimentos> b)
            {
                DapperPlusManager.Entity<TiposAlimentos>().Table("TiposAlimentos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}