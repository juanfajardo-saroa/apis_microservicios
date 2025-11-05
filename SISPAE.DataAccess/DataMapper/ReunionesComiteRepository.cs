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
     /// Clase Abstracta para  ReunionesComite
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ReunionesComiteRepository : DataObject , IReunionesComite 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ReunionesComiteRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ReunionesComiteRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ReunionesComite GetById(ReunionesComite pReunionesComite)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pReunionesComite.id);                                    


    				ReunionesComite o = SqlMapper.QueryFirstOrDefault<ReunionesComite>(con, "API.PA_ReunionesComiteGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ReunionesComite  ->" + ex.Message);
				}
			}

			public List<ReunionesComite> GetAll()
			{
				try 
                {
                        List<ReunionesComite> l = SqlMapper.Query<ReunionesComite>(con, "API.PA_ReunionesComiteGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ReunionesComite  ->" + ex.Message);
				}
			}

			public List<ReunionesComite> GetAllFull()
			{
				try 
				{
                    List<ReunionesComite> l = SqlMapper.Query<ReunionesComite>(con, "API.PA_ReunionesComiteGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ReunionesComite  ->" + ex.Message);
				}
			}
			
			public List<ReunionesComite> GetAllByWithRelation()
			{
				try 
                {
                    List<ReunionesComite> l = SqlMapper.Query<ReunionesComite>(con, "API.PA_ReunionesComiteGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ReunionesComite  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ReunionesComite> GetByFilter(ReunionesComite pReunionesComite, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pReunionesComite.id== null || pReunionesComite.id==0) ? vintNUll :pReunionesComite.id);
                    p.Add("@ID_Comite",(pReunionesComite.ID_Comite== null || pReunionesComite.ID_Comite==0) ? vintNUll :pReunionesComite.ID_Comite);
                    p.Add("@FechaReunion",(pReunionesComite.FechaReunion== null) ? vintNUll :pReunionesComite.FechaReunion);
                    p.Add("@TemaTrabajo",(pReunionesComite.TemaTrabajo== null) ? vintNUll :pReunionesComite.TemaTrabajo);
                    p.Add("@DecisionesAcordadas",(pReunionesComite.DecisionesAcordadas== null) ? vintNUll :pReunionesComite.DecisionesAcordadas);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ReunionesComite> l = SqlMapper.Query<ReunionesComite>(con, "API.PA_ReunionesComiteGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ReunionesComite  ->" + ex.Message);
				}
			}

			public ReunionesComite Add(ReunionesComite pReunionesComite)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pReunionesComite.id==null ? 0 : pReunionesComite.id);
p.Add("@ID_Comite",pReunionesComite.ID_Comite==null ? 0 : pReunionesComite.ID_Comite);
                    p.Add("@FechaReunion", pReunionesComite.FechaReunion);
                    p.Add("@TemaTrabajo", pReunionesComite.TemaTrabajo);
                    p.Add("@DecisionesAcordadas", pReunionesComite.DecisionesAcordadas);
                    p.Add("@auditoria", pReunionesComite.auditoria);

                         


                    ReunionesComite o = SqlMapper.QueryFirstOrDefault<ReunionesComite>(con, "API.PA_ReunionesComiteAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ReunionesComite  ->" + ex.Message);
				}
			}

			public ReunionesComite  Update(ReunionesComite pReunionesComite)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pReunionesComite.id==null ? 0 : pReunionesComite.id);
p.Add("@ID_Comite",pReunionesComite.ID_Comite==null ? 0 : pReunionesComite.ID_Comite);
                    p.Add("@FechaReunion", pReunionesComite.FechaReunion);
                    p.Add("@TemaTrabajo", pReunionesComite.TemaTrabajo);
                    p.Add("@DecisionesAcordadas", pReunionesComite.DecisionesAcordadas);
                    p.Add("@auditoria", pReunionesComite.auditoria);

                         


                    ReunionesComite o = SqlMapper.QueryFirstOrDefault<ReunionesComite>(con, "API.PA_ReunionesComiteUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ReunionesComite  ->" + ex.Message);
				}
			}

			public bool Delete(ReunionesComite pReunionesComite)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pReunionesComite.id);
                    p.Add("@auditoria", pReunionesComite.auditoria);

                

 

					ReunionesComite o = SqlMapper.QueryFirstOrDefault<ReunionesComite>(con, "API.PA_ReunionesComiteDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ReunionesComite  ->" + ex.Message);
				}
			}

		



            public List<ReunionesComite> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ReunionesComite> ReunionesComiteList = new List<ReunionesComite>();

                    ReunionesComiteList = SqlMapper.Query<ReunionesComite>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ReunionesComiteList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ReunionesComite  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ReunionesComite> b)
            {
                DapperPlusManager.Entity<ReunionesComite>().Table("ReunionesComite");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}