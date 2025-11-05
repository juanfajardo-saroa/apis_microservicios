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
     /// Clase Abstracta para  AlimentosPorGrupo
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AlimentosPorGrupoRepository : DataObject , IAlimentosPorGrupo 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AlimentosPorGrupoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AlimentosPorGrupoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AlimentosPorGrupo GetById(AlimentosPorGrupo pAlimentosPorGrupo)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAlimentosPorGrupo.id);                                    


    				AlimentosPorGrupo o = SqlMapper.QueryFirstOrDefault<AlimentosPorGrupo>(con, "API.PA_AlimentosPorGrupoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AlimentosPorGrupo  ->" + ex.Message);
				}
			}

			public List<AlimentosPorGrupo> GetAll()
			{
				try 
                {
                        List<AlimentosPorGrupo> l = SqlMapper.Query<AlimentosPorGrupo>(con, "API.PA_AlimentosPorGrupoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AlimentosPorGrupo  ->" + ex.Message);
				}
			}

			public List<AlimentosPorGrupo> GetAllFull()
			{
				try 
				{
                    List<AlimentosPorGrupo> l = SqlMapper.Query<AlimentosPorGrupo>(con, "API.PA_AlimentosPorGrupoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AlimentosPorGrupo  ->" + ex.Message);
				}
			}
			
			public List<AlimentosPorGrupo> GetAllByWithRelation()
			{
				try 
                {
                    List<AlimentosPorGrupo> l = SqlMapper.Query<AlimentosPorGrupo>(con, "API.PA_AlimentosPorGrupoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AlimentosPorGrupo  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AlimentosPorGrupo> GetByFilter(AlimentosPorGrupo pAlimentosPorGrupo, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAlimentosPorGrupo.id== null || pAlimentosPorGrupo.id==0) ? vintNUll :pAlimentosPorGrupo.id);
                    p.Add("@ID_TipoComponente",(pAlimentosPorGrupo.ID_TipoComponente== null || pAlimentosPorGrupo.ID_TipoComponente==0) ? vintNUll :pAlimentosPorGrupo.ID_TipoComponente);
                    p.Add("@ID_Menu",(pAlimentosPorGrupo.ID_Menu== null || pAlimentosPorGrupo.ID_Menu==0) ? vintNUll :pAlimentosPorGrupo.ID_Menu);
                    p.Add("@ID_AlimentosBase",(pAlimentosPorGrupo.ID_AlimentosBase== null || pAlimentosPorGrupo.ID_AlimentosBase==0) ? vintNUll :pAlimentosPorGrupo.ID_AlimentosBase);
                    p.Add("@ID_Preparacion",(pAlimentosPorGrupo.ID_Preparacion== null || pAlimentosPorGrupo.ID_Preparacion==0) ? vintNUll :pAlimentosPorGrupo.ID_Preparacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AlimentosPorGrupo> l = SqlMapper.Query<AlimentosPorGrupo>(con, "API.PA_AlimentosPorGrupoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AlimentosPorGrupo  ->" + ex.Message);
				}
			}

			public AlimentosPorGrupo Add(AlimentosPorGrupo pAlimentosPorGrupo)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAlimentosPorGrupo.id==null ? 0 : pAlimentosPorGrupo.id);
p.Add("@ID_TipoComponente",pAlimentosPorGrupo.ID_TipoComponente==null ? 0 : pAlimentosPorGrupo.ID_TipoComponente);
p.Add("@ID_Menu",pAlimentosPorGrupo.ID_Menu==null ? 0 : pAlimentosPorGrupo.ID_Menu);
p.Add("@ID_AlimentosBase",pAlimentosPorGrupo.ID_AlimentosBase==null ? 0 : pAlimentosPorGrupo.ID_AlimentosBase);
p.Add("@ID_Preparacion",pAlimentosPorGrupo.ID_Preparacion==null ? 0 : pAlimentosPorGrupo.ID_Preparacion);
                    p.Add("@auditoria", pAlimentosPorGrupo.auditoria);

                         


                    AlimentosPorGrupo o = SqlMapper.QueryFirstOrDefault<AlimentosPorGrupo>(con, "API.PA_AlimentosPorGrupoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AlimentosPorGrupo  ->" + ex.Message);
				}
			}

			public AlimentosPorGrupo  Update(AlimentosPorGrupo pAlimentosPorGrupo)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAlimentosPorGrupo.id==null ? 0 : pAlimentosPorGrupo.id);
p.Add("@ID_TipoComponente",pAlimentosPorGrupo.ID_TipoComponente==null ? 0 : pAlimentosPorGrupo.ID_TipoComponente);
p.Add("@ID_Menu",pAlimentosPorGrupo.ID_Menu==null ? 0 : pAlimentosPorGrupo.ID_Menu);
p.Add("@ID_AlimentosBase",pAlimentosPorGrupo.ID_AlimentosBase==null ? 0 : pAlimentosPorGrupo.ID_AlimentosBase);
p.Add("@ID_Preparacion",pAlimentosPorGrupo.ID_Preparacion==null ? 0 : pAlimentosPorGrupo.ID_Preparacion);
                    p.Add("@auditoria", pAlimentosPorGrupo.auditoria);

                         


                    AlimentosPorGrupo o = SqlMapper.QueryFirstOrDefault<AlimentosPorGrupo>(con, "API.PA_AlimentosPorGrupoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AlimentosPorGrupo  ->" + ex.Message);
				}
			}

			public bool Delete(AlimentosPorGrupo pAlimentosPorGrupo)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAlimentosPorGrupo.id);
                    p.Add("@auditoria", pAlimentosPorGrupo.auditoria);

                

 

					AlimentosPorGrupo o = SqlMapper.QueryFirstOrDefault<AlimentosPorGrupo>(con, "API.PA_AlimentosPorGrupoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AlimentosPorGrupo  ->" + ex.Message);
				}
			}

		



            public List<AlimentosPorGrupo> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AlimentosPorGrupo> AlimentosPorGrupoList = new List<AlimentosPorGrupo>();

                    AlimentosPorGrupoList = SqlMapper.Query<AlimentosPorGrupo>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AlimentosPorGrupoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AlimentosPorGrupo  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AlimentosPorGrupo> b)
            {
                DapperPlusManager.Entity<AlimentosPorGrupo>().Table("AlimentosPorGrupo");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}