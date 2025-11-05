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
     /// Clase Abstracta para  SubGrupoAlimentos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SubGrupoAlimentosRepository : DataObject , ISubGrupoAlimentos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SubGrupoAlimentosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SubGrupoAlimentosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public SubGrupoAlimentos GetById(SubGrupoAlimentos pSubGrupoAlimentos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSubGrupoAlimentos.id);                                    


    				SubGrupoAlimentos o = SqlMapper.QueryFirstOrDefault<SubGrupoAlimentos>(con, "API.PA_SubGrupoAlimentosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  SubGrupoAlimentos  ->" + ex.Message);
				}
			}

			public List<SubGrupoAlimentos> GetAll()
			{
				try 
                {
                        List<SubGrupoAlimentos> l = SqlMapper.Query<SubGrupoAlimentos>(con, "API.PA_SubGrupoAlimentosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  SubGrupoAlimentos  ->" + ex.Message);
				}
			}

			public List<SubGrupoAlimentos> GetAllFull()
			{
				try 
				{
                    List<SubGrupoAlimentos> l = SqlMapper.Query<SubGrupoAlimentos>(con, "API.PA_SubGrupoAlimentosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  SubGrupoAlimentos  ->" + ex.Message);
				}
			}
			
			public List<SubGrupoAlimentos> GetAllByWithRelation()
			{
				try 
                {
                    List<SubGrupoAlimentos> l = SqlMapper.Query<SubGrupoAlimentos>(con, "API.PA_SubGrupoAlimentosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  SubGrupoAlimentos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<SubGrupoAlimentos> GetByFilter(SubGrupoAlimentos pSubGrupoAlimentos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSubGrupoAlimentos.id== null || pSubGrupoAlimentos.id==0) ? vintNUll :pSubGrupoAlimentos.id);
                    p.Add("@Nombre",(pSubGrupoAlimentos.Nombre== null) ? vintNUll :pSubGrupoAlimentos.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<SubGrupoAlimentos> l = SqlMapper.Query<SubGrupoAlimentos>(con, "API.PA_SubGrupoAlimentosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  SubGrupoAlimentos  ->" + ex.Message);
				}
			}

			public SubGrupoAlimentos Add(SubGrupoAlimentos pSubGrupoAlimentos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSubGrupoAlimentos.id==null ? 0 : pSubGrupoAlimentos.id);
                    p.Add("@Nombre", pSubGrupoAlimentos.Nombre);
                    p.Add("@auditoria", pSubGrupoAlimentos.auditoria);

                         


                    SubGrupoAlimentos o = SqlMapper.QueryFirstOrDefault<SubGrupoAlimentos>(con, "API.PA_SubGrupoAlimentosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  SubGrupoAlimentos  ->" + ex.Message);
				}
			}

			public SubGrupoAlimentos  Update(SubGrupoAlimentos pSubGrupoAlimentos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSubGrupoAlimentos.id==null ? 0 : pSubGrupoAlimentos.id);
                    p.Add("@Nombre", pSubGrupoAlimentos.Nombre);
                    p.Add("@auditoria", pSubGrupoAlimentos.auditoria);

                         


                    SubGrupoAlimentos o = SqlMapper.QueryFirstOrDefault<SubGrupoAlimentos>(con, "API.PA_SubGrupoAlimentosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  SubGrupoAlimentos  ->" + ex.Message);
				}
			}

			public bool Delete(SubGrupoAlimentos pSubGrupoAlimentos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSubGrupoAlimentos.id);
                    p.Add("@auditoria", pSubGrupoAlimentos.auditoria);

                

 

					SubGrupoAlimentos o = SqlMapper.QueryFirstOrDefault<SubGrupoAlimentos>(con, "API.PA_SubGrupoAlimentosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) SubGrupoAlimentos  ->" + ex.Message);
				}
			}

		



            public List<SubGrupoAlimentos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<SubGrupoAlimentos> SubGrupoAlimentosList = new List<SubGrupoAlimentos>();

                    SubGrupoAlimentosList = SqlMapper.Query<SubGrupoAlimentos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SubGrupoAlimentosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) SubGrupoAlimentos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<SubGrupoAlimentos> b)
            {
                DapperPlusManager.Entity<SubGrupoAlimentos>().Table("SubGrupoAlimentos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}