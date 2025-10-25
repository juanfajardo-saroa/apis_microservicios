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
     /// Clase Abstracta para  CategoriaContenido
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CategoriaContenidoRepository : DataObject , ICategoriaContenido 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CategoriaContenidoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CategoriaContenidoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CategoriaContenido GetById(CategoriaContenido pCategoriaContenido)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCategoriaContenido.id);                                    


    				CategoriaContenido o = SqlMapper.QueryFirstOrDefault<CategoriaContenido>(con, "API.PA_CategoriaContenidoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CategoriaContenido  ->" + ex.Message);
				}
			}

			public List<CategoriaContenido> GetAll()
			{
				try 
                {
                        List<CategoriaContenido> l = SqlMapper.Query<CategoriaContenido>(con, "API.PA_CategoriaContenidoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CategoriaContenido  ->" + ex.Message);
				}
			}

			public List<CategoriaContenido> GetAllFull()
			{
				try 
				{
                    List<CategoriaContenido> l = SqlMapper.Query<CategoriaContenido>(con, "API.PA_CategoriaContenidoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CategoriaContenido  ->" + ex.Message);
				}
			}
			
			public List<CategoriaContenido> GetAllByWithRelation()
			{
				try 
                {
                    List<CategoriaContenido> l = SqlMapper.Query<CategoriaContenido>(con, "API.PA_CategoriaContenidoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CategoriaContenido  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CategoriaContenido> GetByFilter(CategoriaContenido pCategoriaContenido, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCategoriaContenido.id== null || pCategoriaContenido.id==0) ? vintNUll :pCategoriaContenido.id);
                    p.Add("@Nombre",(pCategoriaContenido.Nombre== null) ? vintNUll :pCategoriaContenido.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CategoriaContenido> l = SqlMapper.Query<CategoriaContenido>(con, "API.PA_CategoriaContenidoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CategoriaContenido  ->" + ex.Message);
				}
			}

			public CategoriaContenido Add(CategoriaContenido pCategoriaContenido)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCategoriaContenido.id==null ? 0 : pCategoriaContenido.id);
                    p.Add("@Nombre", pCategoriaContenido.Nombre);
                    p.Add("@auditoria", pCategoriaContenido.auditoria);

                         


                    CategoriaContenido o = SqlMapper.QueryFirstOrDefault<CategoriaContenido>(con, "API.PA_CategoriaContenidoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CategoriaContenido  ->" + ex.Message);
				}
			}

			public CategoriaContenido  Update(CategoriaContenido pCategoriaContenido)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCategoriaContenido.id==null ? 0 : pCategoriaContenido.id);
                    p.Add("@Nombre", pCategoriaContenido.Nombre);
                    p.Add("@auditoria", pCategoriaContenido.auditoria);

                         


                    CategoriaContenido o = SqlMapper.QueryFirstOrDefault<CategoriaContenido>(con, "API.PA_CategoriaContenidoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CategoriaContenido  ->" + ex.Message);
				}
			}

			public bool Delete(CategoriaContenido pCategoriaContenido)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCategoriaContenido.id);
                    p.Add("@auditoria", pCategoriaContenido.auditoria);

                

 

					CategoriaContenido o = SqlMapper.QueryFirstOrDefault<CategoriaContenido>(con, "API.PA_CategoriaContenidoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CategoriaContenido  ->" + ex.Message);
				}
			}

		



            public List<CategoriaContenido> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CategoriaContenido> CategoriaContenidoList = new List<CategoriaContenido>();

                    CategoriaContenidoList = SqlMapper.Query<CategoriaContenido>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CategoriaContenidoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CategoriaContenido  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CategoriaContenido> b)
            {
                DapperPlusManager.Entity<CategoriaContenido>().Table("CategoriaContenido");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}