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
     /// Clase Abstracta para  AsistenciaReunion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AsistenciaReunionRepository : DataObject , IAsistenciaReunion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AsistenciaReunionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AsistenciaReunionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AsistenciaReunion GetById(AsistenciaReunion pAsistenciaReunion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAsistenciaReunion.id);                                    


    				AsistenciaReunion o = SqlMapper.QueryFirstOrDefault<AsistenciaReunion>(con, "API.PA_AsistenciaReunionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AsistenciaReunion  ->" + ex.Message);
				}
			}

			public List<AsistenciaReunion> GetAll()
			{
				try 
                {
                        List<AsistenciaReunion> l = SqlMapper.Query<AsistenciaReunion>(con, "API.PA_AsistenciaReunionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AsistenciaReunion  ->" + ex.Message);
				}
			}

			public List<AsistenciaReunion> GetAllFull()
			{
				try 
				{
                    List<AsistenciaReunion> l = SqlMapper.Query<AsistenciaReunion>(con, "API.PA_AsistenciaReunionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AsistenciaReunion  ->" + ex.Message);
				}
			}
			
			public List<AsistenciaReunion> GetAllByWithRelation()
			{
				try 
                {
                    List<AsistenciaReunion> l = SqlMapper.Query<AsistenciaReunion>(con, "API.PA_AsistenciaReunionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AsistenciaReunion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AsistenciaReunion> GetByFilter(AsistenciaReunion pAsistenciaReunion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAsistenciaReunion.id== null || pAsistenciaReunion.id==0) ? vintNUll :pAsistenciaReunion.id);
                    p.Add("@ID_Participante",(pAsistenciaReunion.ID_Participante== null || pAsistenciaReunion.ID_Participante==0) ? vintNUll :pAsistenciaReunion.ID_Participante);
                    p.Add("@ID_ReunionComite",(pAsistenciaReunion.ID_ReunionComite== null || pAsistenciaReunion.ID_ReunionComite==0) ? vintNUll :pAsistenciaReunion.ID_ReunionComite);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AsistenciaReunion> l = SqlMapper.Query<AsistenciaReunion>(con, "API.PA_AsistenciaReunionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AsistenciaReunion  ->" + ex.Message);
				}
			}

			public AsistenciaReunion Add(AsistenciaReunion pAsistenciaReunion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAsistenciaReunion.id==null ? 0 : pAsistenciaReunion.id);
p.Add("@ID_Participante",pAsistenciaReunion.ID_Participante==null ? 0 : pAsistenciaReunion.ID_Participante);
p.Add("@ID_ReunionComite",pAsistenciaReunion.ID_ReunionComite==null ? 0 : pAsistenciaReunion.ID_ReunionComite);
                    p.Add("@auditoria", pAsistenciaReunion.auditoria);

                         


                    AsistenciaReunion o = SqlMapper.QueryFirstOrDefault<AsistenciaReunion>(con, "API.PA_AsistenciaReunionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AsistenciaReunion  ->" + ex.Message);
				}
			}

			public AsistenciaReunion  Update(AsistenciaReunion pAsistenciaReunion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAsistenciaReunion.id==null ? 0 : pAsistenciaReunion.id);
p.Add("@ID_Participante",pAsistenciaReunion.ID_Participante==null ? 0 : pAsistenciaReunion.ID_Participante);
p.Add("@ID_ReunionComite",pAsistenciaReunion.ID_ReunionComite==null ? 0 : pAsistenciaReunion.ID_ReunionComite);
                    p.Add("@auditoria", pAsistenciaReunion.auditoria);

                         


                    AsistenciaReunion o = SqlMapper.QueryFirstOrDefault<AsistenciaReunion>(con, "API.PA_AsistenciaReunionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AsistenciaReunion  ->" + ex.Message);
				}
			}

			public bool Delete(AsistenciaReunion pAsistenciaReunion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAsistenciaReunion.id);
                    p.Add("@auditoria", pAsistenciaReunion.auditoria);

                

 

					AsistenciaReunion o = SqlMapper.QueryFirstOrDefault<AsistenciaReunion>(con, "API.PA_AsistenciaReunionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AsistenciaReunion  ->" + ex.Message);
				}
			}

		



            public List<AsistenciaReunion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AsistenciaReunion> AsistenciaReunionList = new List<AsistenciaReunion>();

                    AsistenciaReunionList = SqlMapper.Query<AsistenciaReunion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AsistenciaReunionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AsistenciaReunion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AsistenciaReunion> b)
            {
                DapperPlusManager.Entity<AsistenciaReunion>().Table("AsistenciaReunion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}