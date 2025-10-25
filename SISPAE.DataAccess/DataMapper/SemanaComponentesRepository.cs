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
     /// Clase Abstracta para  SemanaComponentes
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SemanaComponentesRepository : DataObject , ISemanaComponentes 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SemanaComponentesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SemanaComponentesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public SemanaComponentes GetById(SemanaComponentes pSemanaComponentes)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSemanaComponentes.id);                                    


    				SemanaComponentes o = SqlMapper.QueryFirstOrDefault<SemanaComponentes>(con, "API.PA_SemanaComponentesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  SemanaComponentes  ->" + ex.Message);
				}
			}

			public List<SemanaComponentes> GetAll()
			{
				try 
                {
                        List<SemanaComponentes> l = SqlMapper.Query<SemanaComponentes>(con, "API.PA_SemanaComponentesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  SemanaComponentes  ->" + ex.Message);
				}
			}

			public List<SemanaComponentes> GetAllFull()
			{
				try 
				{
                    List<SemanaComponentes> l = SqlMapper.Query<SemanaComponentes>(con, "API.PA_SemanaComponentesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  SemanaComponentes  ->" + ex.Message);
				}
			}
			
			public List<SemanaComponentes> GetAllByWithRelation()
			{
				try 
                {
                    List<SemanaComponentes> l = SqlMapper.Query<SemanaComponentes>(con, "API.PA_SemanaComponentesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  SemanaComponentes  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<SemanaComponentes> GetByFilter(SemanaComponentes pSemanaComponentes, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSemanaComponentes.id== null || pSemanaComponentes.id==0) ? vintNUll :pSemanaComponentes.id);
                    p.Add("@ID_Semana",(pSemanaComponentes.ID_Semana== null || pSemanaComponentes.ID_Semana==0) ? vintNUll :pSemanaComponentes.ID_Semana);
                    p.Add("@ID_TipoComponente",(pSemanaComponentes.ID_TipoComponente== null || pSemanaComponentes.ID_TipoComponente==0) ? vintNUll :pSemanaComponentes.ID_TipoComponente);
                    p.Add("@ID_TipoNivelEducativo",(pSemanaComponentes.ID_TipoNivelEducativo== null || pSemanaComponentes.ID_TipoNivelEducativo==0) ? vintNUll :pSemanaComponentes.ID_TipoNivelEducativo);
                    p.Add("@CantidadComponente",(pSemanaComponentes.CantidadComponente== null) ? vintNUll :pSemanaComponentes.CantidadComponente);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<SemanaComponentes> l = SqlMapper.Query<SemanaComponentes>(con, "API.PA_SemanaComponentesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  SemanaComponentes  ->" + ex.Message);
				}
			}

			public SemanaComponentes Add(SemanaComponentes pSemanaComponentes)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSemanaComponentes.id==null ? 0 : pSemanaComponentes.id);
p.Add("@ID_Semana",pSemanaComponentes.ID_Semana==null ? 0 : pSemanaComponentes.ID_Semana);
p.Add("@ID_TipoComponente",pSemanaComponentes.ID_TipoComponente==null ? 0 : pSemanaComponentes.ID_TipoComponente);
p.Add("@ID_TipoNivelEducativo",pSemanaComponentes.ID_TipoNivelEducativo==null ? 0 : pSemanaComponentes.ID_TipoNivelEducativo);
p.Add("@CantidadComponente",pSemanaComponentes.CantidadComponente==null ? 0 : pSemanaComponentes.CantidadComponente);
                    p.Add("@auditoria", pSemanaComponentes.auditoria);

                         


                    SemanaComponentes o = SqlMapper.QueryFirstOrDefault<SemanaComponentes>(con, "API.PA_SemanaComponentesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  SemanaComponentes  ->" + ex.Message);
				}
			}

			public SemanaComponentes  Update(SemanaComponentes pSemanaComponentes)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSemanaComponentes.id==null ? 0 : pSemanaComponentes.id);
p.Add("@ID_Semana",pSemanaComponentes.ID_Semana==null ? 0 : pSemanaComponentes.ID_Semana);
p.Add("@ID_TipoComponente",pSemanaComponentes.ID_TipoComponente==null ? 0 : pSemanaComponentes.ID_TipoComponente);
p.Add("@ID_TipoNivelEducativo",pSemanaComponentes.ID_TipoNivelEducativo==null ? 0 : pSemanaComponentes.ID_TipoNivelEducativo);
p.Add("@CantidadComponente",pSemanaComponentes.CantidadComponente==null ? 0 : pSemanaComponentes.CantidadComponente);
                    p.Add("@auditoria", pSemanaComponentes.auditoria);

                         


                    SemanaComponentes o = SqlMapper.QueryFirstOrDefault<SemanaComponentes>(con, "API.PA_SemanaComponentesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  SemanaComponentes  ->" + ex.Message);
				}
			}

			public bool Delete(SemanaComponentes pSemanaComponentes)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSemanaComponentes.id);
                    p.Add("@auditoria", pSemanaComponentes.auditoria);

                

 

					SemanaComponentes o = SqlMapper.QueryFirstOrDefault<SemanaComponentes>(con, "API.PA_SemanaComponentesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) SemanaComponentes  ->" + ex.Message);
				}
			}

		



            public List<SemanaComponentes> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<SemanaComponentes> SemanaComponentesList = new List<SemanaComponentes>();

                    SemanaComponentesList = SqlMapper.Query<SemanaComponentes>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SemanaComponentesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) SemanaComponentes  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<SemanaComponentes> b)
            {
                DapperPlusManager.Entity<SemanaComponentes>().Table("SemanaComponentes");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}