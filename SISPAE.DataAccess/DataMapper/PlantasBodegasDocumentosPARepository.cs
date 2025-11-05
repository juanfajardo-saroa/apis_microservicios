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
     /// Clase Abstracta para  PlantasBodegasDocumentosPA
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PlantasBodegasDocumentosPARepository : DataObject , IPlantasBodegasDocumentosPA 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PlantasBodegasDocumentosPARepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PlantasBodegasDocumentosPARepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public PlantasBodegasDocumentosPA GetById(PlantasBodegasDocumentosPA pPlantasBodegasDocumentosPA)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pPlantasBodegasDocumentosPA.id);                                    


    				PlantasBodegasDocumentosPA o = SqlMapper.QueryFirstOrDefault<PlantasBodegasDocumentosPA>(con, "API.PA_PlantasBodegasDocumentosPAGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  PlantasBodegasDocumentosPA  ->" + ex.Message);
				}
			}

			public List<PlantasBodegasDocumentosPA> GetAll()
			{
				try 
                {
                        List<PlantasBodegasDocumentosPA> l = SqlMapper.Query<PlantasBodegasDocumentosPA>(con, "API.PA_PlantasBodegasDocumentosPAGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  PlantasBodegasDocumentosPA  ->" + ex.Message);
				}
			}

			public List<PlantasBodegasDocumentosPA> GetAllFull()
			{
				try 
				{
                    List<PlantasBodegasDocumentosPA> l = SqlMapper.Query<PlantasBodegasDocumentosPA>(con, "API.PA_PlantasBodegasDocumentosPAGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  PlantasBodegasDocumentosPA  ->" + ex.Message);
				}
			}
			
			public List<PlantasBodegasDocumentosPA> GetAllByWithRelation()
			{
				try 
                {
                    List<PlantasBodegasDocumentosPA> l = SqlMapper.Query<PlantasBodegasDocumentosPA>(con, "API.PA_PlantasBodegasDocumentosPAGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  PlantasBodegasDocumentosPA  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<PlantasBodegasDocumentosPA> GetByFilter(PlantasBodegasDocumentosPA pPlantasBodegasDocumentosPA, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pPlantasBodegasDocumentosPA.id== null || pPlantasBodegasDocumentosPA.id==0) ? vintNUll :pPlantasBodegasDocumentosPA.id);
                    p.Add("@ID_PlantaBodegas",(pPlantasBodegasDocumentosPA.ID_PlantaBodegas== null || pPlantasBodegasDocumentosPA.ID_PlantaBodegas==0) ? vintNUll :pPlantasBodegasDocumentosPA.ID_PlantaBodegas);
                    p.Add("@ID_DocumentoPA",(pPlantasBodegasDocumentosPA.ID_DocumentoPA== null || pPlantasBodegasDocumentosPA.ID_DocumentoPA==0) ? vintNUll :pPlantasBodegasDocumentosPA.ID_DocumentoPA);
                    p.Add("@ID_Estado",(pPlantasBodegasDocumentosPA.ID_Estado== null || pPlantasBodegasDocumentosPA.ID_Estado==0) ? vintNUll :pPlantasBodegasDocumentosPA.ID_Estado);
                    p.Add("@idVigencia",(pPlantasBodegasDocumentosPA.idVigencia== null || pPlantasBodegasDocumentosPA.idVigencia==0) ? vintNUll :pPlantasBodegasDocumentosPA.idVigencia);
                    p.Add("@PathDocumento",(pPlantasBodegasDocumentosPA.PathDocumento== null) ? vintNUll :pPlantasBodegasDocumentosPA.PathDocumento);
                    p.Add("@FechaVersion",(pPlantasBodegasDocumentosPA.FechaVersion== null) ? vintNUll :pPlantasBodegasDocumentosPA.FechaVersion);
                    p.Add("@NombreArchivo",(pPlantasBodegasDocumentosPA.NombreArchivo== null) ? vintNUll :pPlantasBodegasDocumentosPA.NombreArchivo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<PlantasBodegasDocumentosPA> l = SqlMapper.Query<PlantasBodegasDocumentosPA>(con, "API.PA_PlantasBodegasDocumentosPAGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  PlantasBodegasDocumentosPA  ->" + ex.Message);
				}
			}

			public PlantasBodegasDocumentosPA Add(PlantasBodegasDocumentosPA pPlantasBodegasDocumentosPA)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pPlantasBodegasDocumentosPA.id==null ? 0 : pPlantasBodegasDocumentosPA.id);
p.Add("@ID_PlantaBodegas",pPlantasBodegasDocumentosPA.ID_PlantaBodegas==null ? 0 : pPlantasBodegasDocumentosPA.ID_PlantaBodegas);
p.Add("@ID_DocumentoPA",pPlantasBodegasDocumentosPA.ID_DocumentoPA==null ? 0 : pPlantasBodegasDocumentosPA.ID_DocumentoPA);
p.Add("@ID_Estado",pPlantasBodegasDocumentosPA.ID_Estado==null ? 0 : pPlantasBodegasDocumentosPA.ID_Estado);
p.Add("@idVigencia",pPlantasBodegasDocumentosPA.idVigencia== null ? 0: pPlantasBodegasDocumentosPA.idVigencia);
                    p.Add("@PathDocumento", pPlantasBodegasDocumentosPA.PathDocumento);
                    p.Add("@FechaVersion", pPlantasBodegasDocumentosPA.FechaVersion);
                    p.Add("@NombreArchivo", pPlantasBodegasDocumentosPA.NombreArchivo);
                    p.Add("@auditoria", pPlantasBodegasDocumentosPA.auditoria);

                         


                    PlantasBodegasDocumentosPA o = SqlMapper.QueryFirstOrDefault<PlantasBodegasDocumentosPA>(con, "API.PA_PlantasBodegasDocumentosPAAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  PlantasBodegasDocumentosPA  ->" + ex.Message);
				}
			}

			public PlantasBodegasDocumentosPA  Update(PlantasBodegasDocumentosPA pPlantasBodegasDocumentosPA)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pPlantasBodegasDocumentosPA.id==null ? 0 : pPlantasBodegasDocumentosPA.id);
p.Add("@ID_PlantaBodegas",pPlantasBodegasDocumentosPA.ID_PlantaBodegas==null ? 0 : pPlantasBodegasDocumentosPA.ID_PlantaBodegas);
p.Add("@ID_DocumentoPA",pPlantasBodegasDocumentosPA.ID_DocumentoPA==null ? 0 : pPlantasBodegasDocumentosPA.ID_DocumentoPA);
p.Add("@ID_Estado",pPlantasBodegasDocumentosPA.ID_Estado==null ? 0 : pPlantasBodegasDocumentosPA.ID_Estado);
p.Add("@idVigencia",pPlantasBodegasDocumentosPA.idVigencia== null ? 0: pPlantasBodegasDocumentosPA.idVigencia);
                    p.Add("@PathDocumento", pPlantasBodegasDocumentosPA.PathDocumento);
                    p.Add("@FechaVersion", pPlantasBodegasDocumentosPA.FechaVersion);
                    p.Add("@NombreArchivo", pPlantasBodegasDocumentosPA.NombreArchivo);
                    p.Add("@auditoria", pPlantasBodegasDocumentosPA.auditoria);

                         


                    PlantasBodegasDocumentosPA o = SqlMapper.QueryFirstOrDefault<PlantasBodegasDocumentosPA>(con, "API.PA_PlantasBodegasDocumentosPAUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  PlantasBodegasDocumentosPA  ->" + ex.Message);
				}
			}

			public bool Delete(PlantasBodegasDocumentosPA pPlantasBodegasDocumentosPA)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pPlantasBodegasDocumentosPA.id);
                    p.Add("@auditoria", pPlantasBodegasDocumentosPA.auditoria);

                

 

					PlantasBodegasDocumentosPA o = SqlMapper.QueryFirstOrDefault<PlantasBodegasDocumentosPA>(con, "API.PA_PlantasBodegasDocumentosPADelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) PlantasBodegasDocumentosPA  ->" + ex.Message);
				}
			}

		



            public List<PlantasBodegasDocumentosPA> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<PlantasBodegasDocumentosPA> PlantasBodegasDocumentosPAList = new List<PlantasBodegasDocumentosPA>();

                    PlantasBodegasDocumentosPAList = SqlMapper.Query<PlantasBodegasDocumentosPA>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PlantasBodegasDocumentosPAList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) PlantasBodegasDocumentosPA  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<PlantasBodegasDocumentosPA> b)
            {
                DapperPlusManager.Entity<PlantasBodegasDocumentosPA>().Table("PlantasBodegasDocumentosPA");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}