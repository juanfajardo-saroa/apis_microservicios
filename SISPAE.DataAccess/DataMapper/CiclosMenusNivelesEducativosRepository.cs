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
     /// Clase Abstracta para  CiclosMenusNivelesEducativos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CiclosMenusNivelesEducativosRepository : DataObject , ICiclosMenusNivelesEducativos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CiclosMenusNivelesEducativosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CiclosMenusNivelesEducativosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CiclosMenusNivelesEducativos GetById(CiclosMenusNivelesEducativos pCiclosMenusNivelesEducativos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCiclosMenusNivelesEducativos.id);                                    


    				CiclosMenusNivelesEducativos o = SqlMapper.QueryFirstOrDefault<CiclosMenusNivelesEducativos>(con, "API.PA_CiclosMenusNivelesEducativosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CiclosMenusNivelesEducativos  ->" + ex.Message);
				}
			}

			public List<CiclosMenusNivelesEducativos> GetAll()
			{
				try 
                {
                        List<CiclosMenusNivelesEducativos> l = SqlMapper.Query<CiclosMenusNivelesEducativos>(con, "API.PA_CiclosMenusNivelesEducativosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CiclosMenusNivelesEducativos  ->" + ex.Message);
				}
			}

			public List<CiclosMenusNivelesEducativos> GetAllFull()
			{
				try 
				{
                    List<CiclosMenusNivelesEducativos> l = SqlMapper.Query<CiclosMenusNivelesEducativos>(con, "API.PA_CiclosMenusNivelesEducativosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CiclosMenusNivelesEducativos  ->" + ex.Message);
				}
			}
			
			public List<CiclosMenusNivelesEducativos> GetAllByWithRelation()
			{
				try 
                {
                    List<CiclosMenusNivelesEducativos> l = SqlMapper.Query<CiclosMenusNivelesEducativos>(con, "API.PA_CiclosMenusNivelesEducativosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CiclosMenusNivelesEducativos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CiclosMenusNivelesEducativos> GetByFilter(CiclosMenusNivelesEducativos pCiclosMenusNivelesEducativos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCiclosMenusNivelesEducativos.id== null || pCiclosMenusNivelesEducativos.id==0) ? vintNUll :pCiclosMenusNivelesEducativos.id);
                    p.Add("@ID_CiclosMenu",(pCiclosMenusNivelesEducativos.ID_CiclosMenu== null || pCiclosMenusNivelesEducativos.ID_CiclosMenu==0) ? vintNUll :pCiclosMenusNivelesEducativos.ID_CiclosMenu);
                    p.Add("@ID_TipoNivelEducativo",(pCiclosMenusNivelesEducativos.ID_TipoNivelEducativo== null || pCiclosMenusNivelesEducativos.ID_TipoNivelEducativo==0) ? vintNUll :pCiclosMenusNivelesEducativos.ID_TipoNivelEducativo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CiclosMenusNivelesEducativos> l = SqlMapper.Query<CiclosMenusNivelesEducativos>(con, "API.PA_CiclosMenusNivelesEducativosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CiclosMenusNivelesEducativos  ->" + ex.Message);
				}
			}

			public CiclosMenusNivelesEducativos Add(CiclosMenusNivelesEducativos pCiclosMenusNivelesEducativos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCiclosMenusNivelesEducativos.id==null ? 0 : pCiclosMenusNivelesEducativos.id);
p.Add("@ID_CiclosMenu",pCiclosMenusNivelesEducativos.ID_CiclosMenu==null ? 0 : pCiclosMenusNivelesEducativos.ID_CiclosMenu);
p.Add("@ID_TipoNivelEducativo",pCiclosMenusNivelesEducativos.ID_TipoNivelEducativo==null ? 0 : pCiclosMenusNivelesEducativos.ID_TipoNivelEducativo);
                    p.Add("@auditoria", pCiclosMenusNivelesEducativos.auditoria);

                         


                    CiclosMenusNivelesEducativos o = SqlMapper.QueryFirstOrDefault<CiclosMenusNivelesEducativos>(con, "API.PA_CiclosMenusNivelesEducativosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CiclosMenusNivelesEducativos  ->" + ex.Message);
				}
			}

			public CiclosMenusNivelesEducativos  Update(CiclosMenusNivelesEducativos pCiclosMenusNivelesEducativos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCiclosMenusNivelesEducativos.id==null ? 0 : pCiclosMenusNivelesEducativos.id);
p.Add("@ID_CiclosMenu",pCiclosMenusNivelesEducativos.ID_CiclosMenu==null ? 0 : pCiclosMenusNivelesEducativos.ID_CiclosMenu);
p.Add("@ID_TipoNivelEducativo",pCiclosMenusNivelesEducativos.ID_TipoNivelEducativo==null ? 0 : pCiclosMenusNivelesEducativos.ID_TipoNivelEducativo);
                    p.Add("@auditoria", pCiclosMenusNivelesEducativos.auditoria);

                         


                    CiclosMenusNivelesEducativos o = SqlMapper.QueryFirstOrDefault<CiclosMenusNivelesEducativos>(con, "API.PA_CiclosMenusNivelesEducativosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CiclosMenusNivelesEducativos  ->" + ex.Message);
				}
			}

			public bool Delete(CiclosMenusNivelesEducativos pCiclosMenusNivelesEducativos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCiclosMenusNivelesEducativos.id);
                    p.Add("@auditoria", pCiclosMenusNivelesEducativos.auditoria);

                

 

					CiclosMenusNivelesEducativos o = SqlMapper.QueryFirstOrDefault<CiclosMenusNivelesEducativos>(con, "API.PA_CiclosMenusNivelesEducativosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CiclosMenusNivelesEducativos  ->" + ex.Message);
				}
			}

		



            public List<CiclosMenusNivelesEducativos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CiclosMenusNivelesEducativos> CiclosMenusNivelesEducativosList = new List<CiclosMenusNivelesEducativos>();

                    CiclosMenusNivelesEducativosList = SqlMapper.Query<CiclosMenusNivelesEducativos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CiclosMenusNivelesEducativosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CiclosMenusNivelesEducativos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CiclosMenusNivelesEducativos> b)
            {
                DapperPlusManager.Entity<CiclosMenusNivelesEducativos>().Table("CiclosMenusNivelesEducativos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}