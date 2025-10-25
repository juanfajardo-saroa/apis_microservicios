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
     /// Clase Abstracta para  PlanAlistamientoDocumentosPA
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PlanAlistamientoDocumentosPARepository : DataObject , IPlanAlistamientoDocumentosPA 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PlanAlistamientoDocumentosPARepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PlanAlistamientoDocumentosPARepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public PlanAlistamientoDocumentosPA GetById(PlanAlistamientoDocumentosPA pPlanAlistamientoDocumentosPA)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pPlanAlistamientoDocumentosPA.id);                                    


    				PlanAlistamientoDocumentosPA o = SqlMapper.QueryFirstOrDefault<PlanAlistamientoDocumentosPA>(con, "API.PA_PlanAlistamientoDocumentosPAGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  PlanAlistamientoDocumentosPA  ->" + ex.Message);
				}
			}

			public List<PlanAlistamientoDocumentosPA> GetAll()
			{
				try 
                {
                        List<PlanAlistamientoDocumentosPA> l = SqlMapper.Query<PlanAlistamientoDocumentosPA>(con, "API.PA_PlanAlistamientoDocumentosPAGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  PlanAlistamientoDocumentosPA  ->" + ex.Message);
				}
			}

			public List<PlanAlistamientoDocumentosPA> GetAllFull()
			{
				try 
				{
                    List<PlanAlistamientoDocumentosPA> l = SqlMapper.Query<PlanAlistamientoDocumentosPA>(con, "API.PA_PlanAlistamientoDocumentosPAGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  PlanAlistamientoDocumentosPA  ->" + ex.Message);
				}
			}
			
			public List<PlanAlistamientoDocumentosPA> GetAllByWithRelation()
			{
				try 
                {
                    List<PlanAlistamientoDocumentosPA> l = SqlMapper.Query<PlanAlistamientoDocumentosPA>(con, "API.PA_PlanAlistamientoDocumentosPAGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  PlanAlistamientoDocumentosPA  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<PlanAlistamientoDocumentosPA> GetByFilter(PlanAlistamientoDocumentosPA pPlanAlistamientoDocumentosPA, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pPlanAlistamientoDocumentosPA.id== null || pPlanAlistamientoDocumentosPA.id==0) ? vintNUll :pPlanAlistamientoDocumentosPA.id);
                    p.Add("@ID_PlanAlistamiento",(pPlanAlistamientoDocumentosPA.ID_PlanAlistamiento== null || pPlanAlistamientoDocumentosPA.ID_PlanAlistamiento==0) ? vintNUll :pPlanAlistamientoDocumentosPA.ID_PlanAlistamiento);
                    p.Add("@ID_DocumentoPA",(pPlanAlistamientoDocumentosPA.ID_DocumentoPA== null || pPlanAlistamientoDocumentosPA.ID_DocumentoPA==0) ? vintNUll :pPlanAlistamientoDocumentosPA.ID_DocumentoPA);
                    p.Add("@ID_Vigencia",(pPlanAlistamientoDocumentosPA.ID_Vigencia== null || pPlanAlistamientoDocumentosPA.ID_Vigencia==0) ? vintNUll :pPlanAlistamientoDocumentosPA.ID_Vigencia);
                    p.Add("@ID_Estado",(pPlanAlistamientoDocumentosPA.ID_Estado== null || pPlanAlistamientoDocumentosPA.ID_Estado==0) ? vintNUll :pPlanAlistamientoDocumentosPA.ID_Estado);
                    p.Add("@PathDocumento",(pPlanAlistamientoDocumentosPA.PathDocumento== null) ? vintNUll :pPlanAlistamientoDocumentosPA.PathDocumento);
                    p.Add("@FechaVersion",(pPlanAlistamientoDocumentosPA.FechaVersion== null) ? vintNUll :pPlanAlistamientoDocumentosPA.FechaVersion);
                    p.Add("@NombreArchivo",(pPlanAlistamientoDocumentosPA.NombreArchivo== null) ? vintNUll :pPlanAlistamientoDocumentosPA.NombreArchivo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<PlanAlistamientoDocumentosPA> l = SqlMapper.Query<PlanAlistamientoDocumentosPA>(con, "API.PA_PlanAlistamientoDocumentosPAGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  PlanAlistamientoDocumentosPA  ->" + ex.Message);
				}
			}

			public PlanAlistamientoDocumentosPA Add(PlanAlistamientoDocumentosPA pPlanAlistamientoDocumentosPA)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pPlanAlistamientoDocumentosPA.id==null ? 0 : pPlanAlistamientoDocumentosPA.id);
p.Add("@ID_PlanAlistamiento",pPlanAlistamientoDocumentosPA.ID_PlanAlistamiento==null ? 0 : pPlanAlistamientoDocumentosPA.ID_PlanAlistamiento);
p.Add("@ID_DocumentoPA",pPlanAlistamientoDocumentosPA.ID_DocumentoPA==null ? 0 : pPlanAlistamientoDocumentosPA.ID_DocumentoPA);
p.Add("@ID_Vigencia",pPlanAlistamientoDocumentosPA.ID_Vigencia==null ? 0 : pPlanAlistamientoDocumentosPA.ID_Vigencia);
p.Add("@ID_Estado",pPlanAlistamientoDocumentosPA.ID_Estado==null ? 0 : pPlanAlistamientoDocumentosPA.ID_Estado);
                    p.Add("@PathDocumento", pPlanAlistamientoDocumentosPA.PathDocumento);
                    p.Add("@FechaVersion", pPlanAlistamientoDocumentosPA.FechaVersion);
                    p.Add("@NombreArchivo", pPlanAlistamientoDocumentosPA.NombreArchivo);
                    p.Add("@auditoria", pPlanAlistamientoDocumentosPA.auditoria);

                         


                    PlanAlistamientoDocumentosPA o = SqlMapper.QueryFirstOrDefault<PlanAlistamientoDocumentosPA>(con, "API.PA_PlanAlistamientoDocumentosPAAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  PlanAlistamientoDocumentosPA  ->" + ex.Message);
				}
			}

			public PlanAlistamientoDocumentosPA  Update(PlanAlistamientoDocumentosPA pPlanAlistamientoDocumentosPA)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pPlanAlistamientoDocumentosPA.id==null ? 0 : pPlanAlistamientoDocumentosPA.id);
p.Add("@ID_PlanAlistamiento",pPlanAlistamientoDocumentosPA.ID_PlanAlistamiento==null ? 0 : pPlanAlistamientoDocumentosPA.ID_PlanAlistamiento);
p.Add("@ID_DocumentoPA",pPlanAlistamientoDocumentosPA.ID_DocumentoPA==null ? 0 : pPlanAlistamientoDocumentosPA.ID_DocumentoPA);
p.Add("@ID_Vigencia",pPlanAlistamientoDocumentosPA.ID_Vigencia==null ? 0 : pPlanAlistamientoDocumentosPA.ID_Vigencia);
p.Add("@ID_Estado",pPlanAlistamientoDocumentosPA.ID_Estado==null ? 0 : pPlanAlistamientoDocumentosPA.ID_Estado);
                    p.Add("@PathDocumento", pPlanAlistamientoDocumentosPA.PathDocumento);
                    p.Add("@FechaVersion", pPlanAlistamientoDocumentosPA.FechaVersion);
                    p.Add("@NombreArchivo", pPlanAlistamientoDocumentosPA.NombreArchivo);
                    p.Add("@auditoria", pPlanAlistamientoDocumentosPA.auditoria);

                         


                    PlanAlistamientoDocumentosPA o = SqlMapper.QueryFirstOrDefault<PlanAlistamientoDocumentosPA>(con, "API.PA_PlanAlistamientoDocumentosPAUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  PlanAlistamientoDocumentosPA  ->" + ex.Message);
				}
			}

			public bool Delete(PlanAlistamientoDocumentosPA pPlanAlistamientoDocumentosPA)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pPlanAlistamientoDocumentosPA.id);
                    p.Add("@auditoria", pPlanAlistamientoDocumentosPA.auditoria);

                

 

					PlanAlistamientoDocumentosPA o = SqlMapper.QueryFirstOrDefault<PlanAlistamientoDocumentosPA>(con, "API.PA_PlanAlistamientoDocumentosPADelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) PlanAlistamientoDocumentosPA  ->" + ex.Message);
				}
			}

		



            public List<PlanAlistamientoDocumentosPA> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<PlanAlistamientoDocumentosPA> PlanAlistamientoDocumentosPAList = new List<PlanAlistamientoDocumentosPA>();

                    PlanAlistamientoDocumentosPAList = SqlMapper.Query<PlanAlistamientoDocumentosPA>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PlanAlistamientoDocumentosPAList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) PlanAlistamientoDocumentosPA  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<PlanAlistamientoDocumentosPA> b)
            {
                DapperPlusManager.Entity<PlanAlistamientoDocumentosPA>().Table("PlanAlistamientoDocumentosPA");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}