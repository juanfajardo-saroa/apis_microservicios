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
     /// Clase Abstracta para  TiposRemuManipuladoras
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposRemuManipuladorasRepository : DataObject , ITiposRemuManipuladoras 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposRemuManipuladorasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposRemuManipuladorasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposRemuManipuladoras GetById(TiposRemuManipuladoras pTiposRemuManipuladoras)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposRemuManipuladoras.id);                                    


    				TiposRemuManipuladoras o = SqlMapper.QueryFirstOrDefault<TiposRemuManipuladoras>(con, "API.PA_TiposRemuManipuladorasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposRemuManipuladoras  ->" + ex.Message);
				}
			}

			public List<TiposRemuManipuladoras> GetAll()
			{
				try 
                {
                        List<TiposRemuManipuladoras> l = SqlMapper.Query<TiposRemuManipuladoras>(con, "API.PA_TiposRemuManipuladorasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposRemuManipuladoras  ->" + ex.Message);
				}
			}

			public List<TiposRemuManipuladoras> GetAllFull()
			{
				try 
				{
                    List<TiposRemuManipuladoras> l = SqlMapper.Query<TiposRemuManipuladoras>(con, "API.PA_TiposRemuManipuladorasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposRemuManipuladoras  ->" + ex.Message);
				}
			}
			
			public List<TiposRemuManipuladoras> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposRemuManipuladoras> l = SqlMapper.Query<TiposRemuManipuladoras>(con, "API.PA_TiposRemuManipuladorasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposRemuManipuladoras  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposRemuManipuladoras> GetByFilter(TiposRemuManipuladoras pTiposRemuManipuladoras, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposRemuManipuladoras.id== null || pTiposRemuManipuladoras.id==0) ? vintNUll :pTiposRemuManipuladoras.id);
                    p.Add("@Nombre",(pTiposRemuManipuladoras.Nombre== null) ? vintNUll :pTiposRemuManipuladoras.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposRemuManipuladoras> l = SqlMapper.Query<TiposRemuManipuladoras>(con, "API.PA_TiposRemuManipuladorasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposRemuManipuladoras  ->" + ex.Message);
				}
			}

			public TiposRemuManipuladoras Add(TiposRemuManipuladoras pTiposRemuManipuladoras)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposRemuManipuladoras.id==null ? 0 : pTiposRemuManipuladoras.id);
                    p.Add("@Nombre", pTiposRemuManipuladoras.Nombre);
                    p.Add("@auditoria", pTiposRemuManipuladoras.auditoria);

                         


                    TiposRemuManipuladoras o = SqlMapper.QueryFirstOrDefault<TiposRemuManipuladoras>(con, "API.PA_TiposRemuManipuladorasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposRemuManipuladoras  ->" + ex.Message);
				}
			}

			public TiposRemuManipuladoras  Update(TiposRemuManipuladoras pTiposRemuManipuladoras)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposRemuManipuladoras.id==null ? 0 : pTiposRemuManipuladoras.id);
                    p.Add("@Nombre", pTiposRemuManipuladoras.Nombre);
                    p.Add("@auditoria", pTiposRemuManipuladoras.auditoria);

                         


                    TiposRemuManipuladoras o = SqlMapper.QueryFirstOrDefault<TiposRemuManipuladoras>(con, "API.PA_TiposRemuManipuladorasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposRemuManipuladoras  ->" + ex.Message);
				}
			}

			public bool Delete(TiposRemuManipuladoras pTiposRemuManipuladoras)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposRemuManipuladoras.id);
                    p.Add("@auditoria", pTiposRemuManipuladoras.auditoria);

                

 

					TiposRemuManipuladoras o = SqlMapper.QueryFirstOrDefault<TiposRemuManipuladoras>(con, "API.PA_TiposRemuManipuladorasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposRemuManipuladoras  ->" + ex.Message);
				}
			}

		



            public List<TiposRemuManipuladoras> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposRemuManipuladoras> TiposRemuManipuladorasList = new List<TiposRemuManipuladoras>();

                    TiposRemuManipuladorasList = SqlMapper.Query<TiposRemuManipuladoras>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposRemuManipuladorasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposRemuManipuladoras  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposRemuManipuladoras> b)
            {
                DapperPlusManager.Entity<TiposRemuManipuladoras>().Table("TiposRemuManipuladoras");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}