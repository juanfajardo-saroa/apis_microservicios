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
     /// Clase Abstracta para  Categorias
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CategoriasRepository : DataObject , ICategorias 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CategoriasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CategoriasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Categorias GetById(Categorias pCategorias)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCategorias.id);                                    


    				Categorias o = SqlMapper.QueryFirstOrDefault<Categorias>(con, "API.PA_CategoriasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Categorias  ->" + ex.Message);
				}
			}

			public List<Categorias> GetAll()
			{
				try 
                {
                        List<Categorias> l = SqlMapper.Query<Categorias>(con, "API.PA_CategoriasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Categorias  ->" + ex.Message);
				}
			}

			public List<Categorias> GetAllFull()
			{
				try 
				{
                    List<Categorias> l = SqlMapper.Query<Categorias>(con, "API.PA_CategoriasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Categorias  ->" + ex.Message);
				}
			}
			
			public List<Categorias> GetAllByWithRelation()
			{
				try 
                {
                    List<Categorias> l = SqlMapper.Query<Categorias>(con, "API.PA_CategoriasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Categorias  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Categorias> GetByFilter(Categorias pCategorias, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCategorias.id== null || pCategorias.id==0) ? vintNUll :pCategorias.id);
                    p.Add("@Nombre",(pCategorias.Nombre== null) ? vintNUll :pCategorias.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Categorias> l = SqlMapper.Query<Categorias>(con, "API.PA_CategoriasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Categorias  ->" + ex.Message);
				}
			}

			public Categorias Add(Categorias pCategorias)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCategorias.id==null ? 0 : pCategorias.id);
                    p.Add("@Nombre", pCategorias.Nombre);
                    p.Add("@auditoria", pCategorias.auditoria);

                         


                    Categorias o = SqlMapper.QueryFirstOrDefault<Categorias>(con, "API.PA_CategoriasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Categorias  ->" + ex.Message);
				}
			}

			public Categorias  Update(Categorias pCategorias)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCategorias.id==null ? 0 : pCategorias.id);
                    p.Add("@Nombre", pCategorias.Nombre);
                    p.Add("@auditoria", pCategorias.auditoria);

                         


                    Categorias o = SqlMapper.QueryFirstOrDefault<Categorias>(con, "API.PA_CategoriasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Categorias  ->" + ex.Message);
				}
			}

			public bool Delete(Categorias pCategorias)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCategorias.id);
                    p.Add("@auditoria", pCategorias.auditoria);

                

 

					Categorias o = SqlMapper.QueryFirstOrDefault<Categorias>(con, "API.PA_CategoriasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Categorias  ->" + ex.Message);
				}
			}

		



            public List<Categorias> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Categorias> CategoriasList = new List<Categorias>();

                    CategoriasList = SqlMapper.Query<Categorias>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CategoriasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Categorias  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Categorias> b)
            {
                DapperPlusManager.Entity<Categorias>().Table("Categorias");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}