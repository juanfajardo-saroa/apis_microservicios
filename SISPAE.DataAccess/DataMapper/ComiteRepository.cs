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
     /// Clase Abstracta para  Comite
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ComiteRepository : DataObject , IComite 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ComiteRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ComiteRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Comite GetById(Comite pComite)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pComite.id);                                    


    				Comite o = SqlMapper.QueryFirstOrDefault<Comite>(con, "API.PA_ComiteGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Comite  ->" + ex.Message);
				}
			}

			public List<Comite> GetAll()
			{
				try 
                {
                        List<Comite> l = SqlMapper.Query<Comite>(con, "API.PA_ComiteGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Comite  ->" + ex.Message);
				}
			}

			public List<Comite> GetAllFull()
			{
				try 
				{
                    List<Comite> l = SqlMapper.Query<Comite>(con, "API.PA_ComiteGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Comite  ->" + ex.Message);
				}
			}
			
			public List<Comite> GetAllByWithRelation()
			{
				try 
                {
                    List<Comite> l = SqlMapper.Query<Comite>(con, "API.PA_ComiteGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Comite  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Comite> GetByFilter(Comite pComite, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pComite.id== null || pComite.id==0) ? vintNUll :pComite.id);
                    p.Add("@ID_lE",(pComite.ID_lE== null || pComite.ID_lE==0) ? vintNUll :pComite.ID_lE);
                    p.Add("@ID_Rector",(pComite.ID_Rector== null || pComite.ID_Rector==0) ? vintNUll :pComite.ID_Rector);
                    p.Add("@NombreComite",(pComite.NombreComite== null) ? vintNUll :pComite.NombreComite);
                    p.Add("@Fecha",(pComite.Fecha== null) ? vintNUll :pComite.Fecha);
                    p.Add("@DecisionesTomadas",(pComite.DecisionesTomadas== null) ? vintNUll :pComite.DecisionesTomadas);
                    p.Add("@ActaFormalizacionPath",(pComite.ActaFormalizacionPath== null) ? vintNUll :pComite.ActaFormalizacionPath);
                    p.Add("@PlanTrabajoPath",(pComite.PlanTrabajoPath== null) ? vintNUll :pComite.PlanTrabajoPath);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Comite> l = SqlMapper.Query<Comite>(con, "API.PA_ComiteGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Comite  ->" + ex.Message);
				}
			}

			public Comite Add(Comite pComite)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pComite.id==null ? 0 : pComite.id);
p.Add("@ID_lE",pComite.ID_lE==null ? 0 : pComite.ID_lE);
p.Add("@ID_Rector",pComite.ID_Rector==null ? 0 : pComite.ID_Rector);
                    p.Add("@NombreComite", pComite.NombreComite);
                    p.Add("@Fecha", pComite.Fecha);
p.Add("@DecisionesTomadas",pComite.DecisionesTomadas==null ? 0 : pComite.DecisionesTomadas);
p.Add("@ActaFormalizacionPath",pComite.ActaFormalizacionPath==null ? 0 : pComite.ActaFormalizacionPath);
p.Add("@PlanTrabajoPath",pComite.PlanTrabajoPath==null ? 0 : pComite.PlanTrabajoPath);
                    p.Add("@auditoria", pComite.auditoria);

                         


                    Comite o = SqlMapper.QueryFirstOrDefault<Comite>(con, "API.PA_ComiteAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Comite  ->" + ex.Message);
				}
			}

			public Comite  Update(Comite pComite)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pComite.id==null ? 0 : pComite.id);
p.Add("@ID_lE",pComite.ID_lE==null ? 0 : pComite.ID_lE);
p.Add("@ID_Rector",pComite.ID_Rector==null ? 0 : pComite.ID_Rector);
                    p.Add("@NombreComite", pComite.NombreComite);
                    p.Add("@Fecha", pComite.Fecha);
p.Add("@DecisionesTomadas",pComite.DecisionesTomadas==null ? 0 : pComite.DecisionesTomadas);
p.Add("@ActaFormalizacionPath",pComite.ActaFormalizacionPath==null ? 0 : pComite.ActaFormalizacionPath);
p.Add("@PlanTrabajoPath",pComite.PlanTrabajoPath==null ? 0 : pComite.PlanTrabajoPath);
                    p.Add("@auditoria", pComite.auditoria);

                         


                    Comite o = SqlMapper.QueryFirstOrDefault<Comite>(con, "API.PA_ComiteUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Comite  ->" + ex.Message);
				}
			}

			public bool Delete(Comite pComite)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pComite.id);
                    p.Add("@auditoria", pComite.auditoria);

                

 

					Comite o = SqlMapper.QueryFirstOrDefault<Comite>(con, "API.PA_ComiteDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Comite  ->" + ex.Message);
				}
			}

		



            public List<Comite> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Comite> ComiteList = new List<Comite>();

                    ComiteList = SqlMapper.Query<Comite>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ComiteList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Comite  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Comite> b)
            {
                DapperPlusManager.Entity<Comite>().Table("Comite");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}