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
     /// Clase Abstracta para  TiposDocumentosPA
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposDocumentosPARepository : DataObject , ITiposDocumentosPA 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposDocumentosPARepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposDocumentosPARepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposDocumentosPA GetById(TiposDocumentosPA pTiposDocumentosPA)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposDocumentosPA.id);                                    


    				TiposDocumentosPA o = SqlMapper.QueryFirstOrDefault<TiposDocumentosPA>(con, "API.PA_TiposDocumentosPAGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposDocumentosPA  ->" + ex.Message);
				}
			}

			public List<TiposDocumentosPA> GetAll()
			{
				try 
                {
                        List<TiposDocumentosPA> l = SqlMapper.Query<TiposDocumentosPA>(con, "API.PA_TiposDocumentosPAGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposDocumentosPA  ->" + ex.Message);
				}
			}

			public List<TiposDocumentosPA> GetAllFull()
			{
				try 
				{
                    List<TiposDocumentosPA> l = SqlMapper.Query<TiposDocumentosPA>(con, "API.PA_TiposDocumentosPAGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposDocumentosPA  ->" + ex.Message);
				}
			}
			
			public List<TiposDocumentosPA> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposDocumentosPA> l = SqlMapper.Query<TiposDocumentosPA>(con, "API.PA_TiposDocumentosPAGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposDocumentosPA  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposDocumentosPA> GetByFilter(TiposDocumentosPA pTiposDocumentosPA, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposDocumentosPA.id== null || pTiposDocumentosPA.id==0) ? vintNUll :pTiposDocumentosPA.id);
                    p.Add("@Nombre",(pTiposDocumentosPA.Nombre== null) ? vintNUll :pTiposDocumentosPA.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposDocumentosPA> l = SqlMapper.Query<TiposDocumentosPA>(con, "API.PA_TiposDocumentosPAGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposDocumentosPA  ->" + ex.Message);
				}
			}

			public TiposDocumentosPA Add(TiposDocumentosPA pTiposDocumentosPA)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposDocumentosPA.id==null ? 0 : pTiposDocumentosPA.id);
                    p.Add("@Nombre", pTiposDocumentosPA.Nombre);
                    p.Add("@auditoria", pTiposDocumentosPA.auditoria);

                         


                    TiposDocumentosPA o = SqlMapper.QueryFirstOrDefault<TiposDocumentosPA>(con, "API.PA_TiposDocumentosPAAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposDocumentosPA  ->" + ex.Message);
				}
			}

			public TiposDocumentosPA  Update(TiposDocumentosPA pTiposDocumentosPA)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposDocumentosPA.id==null ? 0 : pTiposDocumentosPA.id);
                    p.Add("@Nombre", pTiposDocumentosPA.Nombre);
                    p.Add("@auditoria", pTiposDocumentosPA.auditoria);

                         


                    TiposDocumentosPA o = SqlMapper.QueryFirstOrDefault<TiposDocumentosPA>(con, "API.PA_TiposDocumentosPAUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposDocumentosPA  ->" + ex.Message);
				}
			}

			public bool Delete(TiposDocumentosPA pTiposDocumentosPA)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposDocumentosPA.id);
                    p.Add("@auditoria", pTiposDocumentosPA.auditoria);

                

 

					TiposDocumentosPA o = SqlMapper.QueryFirstOrDefault<TiposDocumentosPA>(con, "API.PA_TiposDocumentosPADelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposDocumentosPA  ->" + ex.Message);
				}
			}

		



            public List<TiposDocumentosPA> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposDocumentosPA> TiposDocumentosPAList = new List<TiposDocumentosPA>();

                    TiposDocumentosPAList = SqlMapper.Query<TiposDocumentosPA>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposDocumentosPAList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposDocumentosPA  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposDocumentosPA> b)
            {
                DapperPlusManager.Entity<TiposDocumentosPA>().Table("TiposDocumentosPA");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}