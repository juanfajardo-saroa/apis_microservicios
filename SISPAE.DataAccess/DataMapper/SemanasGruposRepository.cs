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
     /// Clase Abstracta para  SemanasGrupos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SemanasGruposRepository : DataObject , ISemanasGrupos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SemanasGruposRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SemanasGruposRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public SemanasGrupos GetById(SemanasGrupos pSemanasGrupos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSemanasGrupos.id);                                    


    				SemanasGrupos o = SqlMapper.QueryFirstOrDefault<SemanasGrupos>(con, "API.PA_SemanasGruposGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  SemanasGrupos  ->" + ex.Message);
				}
			}

			public List<SemanasGrupos> GetAll()
			{
				try 
                {
                        List<SemanasGrupos> l = SqlMapper.Query<SemanasGrupos>(con, "API.PA_SemanasGruposGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  SemanasGrupos  ->" + ex.Message);
				}
			}

			public List<SemanasGrupos> GetAllFull()
			{
				try 
				{
                    List<SemanasGrupos> l = SqlMapper.Query<SemanasGrupos>(con, "API.PA_SemanasGruposGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  SemanasGrupos  ->" + ex.Message);
				}
			}
			
			public List<SemanasGrupos> GetAllByWithRelation()
			{
				try 
                {
                    List<SemanasGrupos> l = SqlMapper.Query<SemanasGrupos>(con, "API.PA_SemanasGruposGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  SemanasGrupos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<SemanasGrupos> GetByFilter(SemanasGrupos pSemanasGrupos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSemanasGrupos.id== null || pSemanasGrupos.id==0) ? vintNUll :pSemanasGrupos.id);
                    p.Add("@ID_Semana",(pSemanasGrupos.ID_Semana== null || pSemanasGrupos.ID_Semana==0) ? vintNUll :pSemanasGrupos.ID_Semana);
                    p.Add("@ID_GrupoAlimento",(pSemanasGrupos.ID_GrupoAlimento== null || pSemanasGrupos.ID_GrupoAlimento==0) ? vintNUll :pSemanasGrupos.ID_GrupoAlimento);
                    p.Add("@CantidadGrupo",(pSemanasGrupos.CantidadGrupo== null) ? vintNUll :pSemanasGrupos.CantidadGrupo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<SemanasGrupos> l = SqlMapper.Query<SemanasGrupos>(con, "API.PA_SemanasGruposGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  SemanasGrupos  ->" + ex.Message);
				}
			}

			public SemanasGrupos Add(SemanasGrupos pSemanasGrupos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSemanasGrupos.id==null ? 0 : pSemanasGrupos.id);
p.Add("@ID_Semana",pSemanasGrupos.ID_Semana==null ? 0 : pSemanasGrupos.ID_Semana);
p.Add("@ID_GrupoAlimento",pSemanasGrupos.ID_GrupoAlimento==null ? 0 : pSemanasGrupos.ID_GrupoAlimento);
                    p.Add("@CantidadGrupo", pSemanasGrupos.CantidadGrupo);
                    p.Add("@auditoria", pSemanasGrupos.auditoria);

                         


                    SemanasGrupos o = SqlMapper.QueryFirstOrDefault<SemanasGrupos>(con, "API.PA_SemanasGruposAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  SemanasGrupos  ->" + ex.Message);
				}
			}

			public SemanasGrupos  Update(SemanasGrupos pSemanasGrupos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSemanasGrupos.id==null ? 0 : pSemanasGrupos.id);
p.Add("@ID_Semana",pSemanasGrupos.ID_Semana==null ? 0 : pSemanasGrupos.ID_Semana);
p.Add("@ID_GrupoAlimento",pSemanasGrupos.ID_GrupoAlimento==null ? 0 : pSemanasGrupos.ID_GrupoAlimento);
                    p.Add("@CantidadGrupo", pSemanasGrupos.CantidadGrupo);
                    p.Add("@auditoria", pSemanasGrupos.auditoria);

                         


                    SemanasGrupos o = SqlMapper.QueryFirstOrDefault<SemanasGrupos>(con, "API.PA_SemanasGruposUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  SemanasGrupos  ->" + ex.Message);
				}
			}

			public bool Delete(SemanasGrupos pSemanasGrupos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSemanasGrupos.id);
                    p.Add("@auditoria", pSemanasGrupos.auditoria);

                

 

					SemanasGrupos o = SqlMapper.QueryFirstOrDefault<SemanasGrupos>(con, "API.PA_SemanasGruposDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) SemanasGrupos  ->" + ex.Message);
				}
			}

		



            public List<SemanasGrupos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<SemanasGrupos> SemanasGruposList = new List<SemanasGrupos>();

                    SemanasGruposList = SqlMapper.Query<SemanasGrupos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SemanasGruposList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) SemanasGrupos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<SemanasGrupos> b)
            {
                DapperPlusManager.Entity<SemanasGrupos>().Table("SemanasGrupos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}