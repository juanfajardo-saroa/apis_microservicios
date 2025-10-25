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
     /// Clase Abstracta para  DocumentosPA
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class DocumentosPARepository : DataObject , IDocumentosPA 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public DocumentosPARepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public DocumentosPARepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public DocumentosPA GetById(DocumentosPA pDocumentosPA)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pDocumentosPA.id);                                    


    				DocumentosPA o = SqlMapper.QueryFirstOrDefault<DocumentosPA>(con, "API.PA_DocumentosPAGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  DocumentosPA  ->" + ex.Message);
				}
			}

			public List<DocumentosPA> GetAll()
			{
				try 
                {
                        List<DocumentosPA> l = SqlMapper.Query<DocumentosPA>(con, "API.PA_DocumentosPAGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  DocumentosPA  ->" + ex.Message);
				}
			}

			public List<DocumentosPA> GetAllFull()
			{
				try 
				{
                    List<DocumentosPA> l = SqlMapper.Query<DocumentosPA>(con, "API.PA_DocumentosPAGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  DocumentosPA  ->" + ex.Message);
				}
			}
			
			public List<DocumentosPA> GetAllByWithRelation()
			{
				try 
                {
                    List<DocumentosPA> l = SqlMapper.Query<DocumentosPA>(con, "API.PA_DocumentosPAGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  DocumentosPA  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<DocumentosPA> GetByFilter(DocumentosPA pDocumentosPA, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pDocumentosPA.id== null || pDocumentosPA.id==0) ? vintNUll :pDocumentosPA.id);
                    p.Add("@ID_TipoDocumentoPA",(pDocumentosPA.ID_TipoDocumentoPA== null || pDocumentosPA.ID_TipoDocumentoPA==0) ? vintNUll :pDocumentosPA.ID_TipoDocumentoPA);
                    p.Add("@ID_Estado",(pDocumentosPA.ID_Estado== null || pDocumentosPA.ID_Estado==0) ? vintNUll :pDocumentosPA.ID_Estado);
                    p.Add("@Nombre",(pDocumentosPA.Nombre== null) ? vintNUll :pDocumentosPA.Nombre);
                    p.Add("@ID_TipoModeloOperacion",(pDocumentosPA.ID_TipoModeloOperacion== null || pDocumentosPA.ID_TipoModeloOperacion==0) ? vintNUll :pDocumentosPA.ID_TipoModeloOperacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<DocumentosPA> l = SqlMapper.Query<DocumentosPA>(con, "API.PA_DocumentosPAGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  DocumentosPA  ->" + ex.Message);
				}
			}

			public DocumentosPA Add(DocumentosPA pDocumentosPA)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pDocumentosPA.id==null ? 0 : pDocumentosPA.id);
p.Add("@ID_TipoDocumentoPA",pDocumentosPA.ID_TipoDocumentoPA==null ? 0 : pDocumentosPA.ID_TipoDocumentoPA);
p.Add("@ID_Estado",pDocumentosPA.ID_Estado==null ? 0 : pDocumentosPA.ID_Estado);
                    p.Add("@Nombre", pDocumentosPA.Nombre);
p.Add("@ID_TipoModeloOperacion",pDocumentosPA.ID_TipoModeloOperacion==null ? 0 : pDocumentosPA.ID_TipoModeloOperacion);
                    p.Add("@auditoria", pDocumentosPA.auditoria);

                         


                    DocumentosPA o = SqlMapper.QueryFirstOrDefault<DocumentosPA>(con, "API.PA_DocumentosPAAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  DocumentosPA  ->" + ex.Message);
				}
			}

			public DocumentosPA  Update(DocumentosPA pDocumentosPA)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pDocumentosPA.id==null ? 0 : pDocumentosPA.id);
p.Add("@ID_TipoDocumentoPA",pDocumentosPA.ID_TipoDocumentoPA==null ? 0 : pDocumentosPA.ID_TipoDocumentoPA);
p.Add("@ID_Estado",pDocumentosPA.ID_Estado==null ? 0 : pDocumentosPA.ID_Estado);
                    p.Add("@Nombre", pDocumentosPA.Nombre);
p.Add("@ID_TipoModeloOperacion",pDocumentosPA.ID_TipoModeloOperacion==null ? 0 : pDocumentosPA.ID_TipoModeloOperacion);
                    p.Add("@auditoria", pDocumentosPA.auditoria);

                         


                    DocumentosPA o = SqlMapper.QueryFirstOrDefault<DocumentosPA>(con, "API.PA_DocumentosPAUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  DocumentosPA  ->" + ex.Message);
				}
			}

			public bool Delete(DocumentosPA pDocumentosPA)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pDocumentosPA.id);
                    p.Add("@auditoria", pDocumentosPA.auditoria);

                

 

					DocumentosPA o = SqlMapper.QueryFirstOrDefault<DocumentosPA>(con, "API.PA_DocumentosPADelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) DocumentosPA  ->" + ex.Message);
				}
			}

		



            public List<DocumentosPA> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<DocumentosPA> DocumentosPAList = new List<DocumentosPA>();

                    DocumentosPAList = SqlMapper.Query<DocumentosPA>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return DocumentosPAList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) DocumentosPA  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<DocumentosPA> b)
            {
                DapperPlusManager.Entity<DocumentosPA>().Table("DocumentosPA");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}