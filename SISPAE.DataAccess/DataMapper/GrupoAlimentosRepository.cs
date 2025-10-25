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
     /// Clase Abstracta para  GrupoAlimentos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class GrupoAlimentosRepository : DataObject , IGrupoAlimentos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public GrupoAlimentosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public GrupoAlimentosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public GrupoAlimentos GetById(GrupoAlimentos pGrupoAlimentos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pGrupoAlimentos.id);                                    


    				GrupoAlimentos o = SqlMapper.QueryFirstOrDefault<GrupoAlimentos>(con, "API.PA_GrupoAlimentosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  GrupoAlimentos  ->" + ex.Message);
				}
			}

			public List<GrupoAlimentos> GetAll()
			{
				try 
                {
                        List<GrupoAlimentos> l = SqlMapper.Query<GrupoAlimentos>(con, "API.PA_GrupoAlimentosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  GrupoAlimentos  ->" + ex.Message);
				}
			}

			public List<GrupoAlimentos> GetAllFull()
			{
				try 
				{
                    List<GrupoAlimentos> l = SqlMapper.Query<GrupoAlimentos>(con, "API.PA_GrupoAlimentosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  GrupoAlimentos  ->" + ex.Message);
				}
			}
			
			public List<GrupoAlimentos> GetAllByWithRelation()
			{
				try 
                {
                    List<GrupoAlimentos> l = SqlMapper.Query<GrupoAlimentos>(con, "API.PA_GrupoAlimentosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  GrupoAlimentos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<GrupoAlimentos> GetByFilter(GrupoAlimentos pGrupoAlimentos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pGrupoAlimentos.id== null || pGrupoAlimentos.id==0) ? vintNUll :pGrupoAlimentos.id);
                  
                    p.Add("@Nombre",(pGrupoAlimentos.Nombre== null) ? vintNUll :pGrupoAlimentos.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<GrupoAlimentos> l = SqlMapper.Query<GrupoAlimentos>(con, "API.PA_GrupoAlimentosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  GrupoAlimentos  ->" + ex.Message);
				}
			}

			public GrupoAlimentos Add(GrupoAlimentos pGrupoAlimentos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pGrupoAlimentos.id==null ? 0 : pGrupoAlimentos.id);
                    p.Add("@Nombre", pGrupoAlimentos.Nombre);
                    p.Add("@auditoria", pGrupoAlimentos.auditoria);

                         


                    GrupoAlimentos o = SqlMapper.QueryFirstOrDefault<GrupoAlimentos>(con, "API.PA_GrupoAlimentosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  GrupoAlimentos  ->" + ex.Message);
				}
			}

			public GrupoAlimentos  Update(GrupoAlimentos pGrupoAlimentos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pGrupoAlimentos.id==null ? 0 : pGrupoAlimentos.id);
                    p.Add("@Nombre", pGrupoAlimentos.Nombre);
                    p.Add("@auditoria", pGrupoAlimentos.auditoria);

                         


                    GrupoAlimentos o = SqlMapper.QueryFirstOrDefault<GrupoAlimentos>(con, "API.PA_GrupoAlimentosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  GrupoAlimentos  ->" + ex.Message);
				}
			}

			public bool Delete(GrupoAlimentos pGrupoAlimentos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pGrupoAlimentos.id);
                    p.Add("@auditoria", pGrupoAlimentos.auditoria);

                

 

					GrupoAlimentos o = SqlMapper.QueryFirstOrDefault<GrupoAlimentos>(con, "API.PA_GrupoAlimentosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) GrupoAlimentos  ->" + ex.Message);
				}
			}

		



            public List<GrupoAlimentos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<GrupoAlimentos> GrupoAlimentosList = new List<GrupoAlimentos>();

                    GrupoAlimentosList = SqlMapper.Query<GrupoAlimentos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return GrupoAlimentosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) GrupoAlimentos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<GrupoAlimentos> b)
            {
                DapperPlusManager.Entity<GrupoAlimentos>().Table("GrupoAlimentos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}