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
     /// Clase Abstracta para  ProcesosCargue
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ProcesosCargueRepository : DataObject , IProcesosCargue 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ProcesosCargueRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ProcesosCargueRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ProcesosCargue GetById(ProcesosCargue pProcesosCargue)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pProcesosCargue.id);                                    


    				ProcesosCargue o = SqlMapper.QueryFirstOrDefault<ProcesosCargue>(con, "API.PA_ProcesosCargueGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ProcesosCargue  ->" + ex.Message);
				}
			}

			public List<ProcesosCargue> GetAll()
			{
				try 
                {
                        List<ProcesosCargue> l = SqlMapper.Query<ProcesosCargue>(con, "API.PA_ProcesosCargueGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ProcesosCargue  ->" + ex.Message);
				}
			}

			public List<ProcesosCargue> GetAllFull()
			{
				try 
				{
                    List<ProcesosCargue> l = SqlMapper.Query<ProcesosCargue>(con, "API.PA_ProcesosCargueGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ProcesosCargue  ->" + ex.Message);
				}
			}
			
			public List<ProcesosCargue> GetAllByWithRelation()
			{
				try 
                {
                    List<ProcesosCargue> l = SqlMapper.Query<ProcesosCargue>(con, "API.PA_ProcesosCargueGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ProcesosCargue  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ProcesosCargue> GetByFilter(ProcesosCargue pProcesosCargue, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pProcesosCargue.id== null || pProcesosCargue.id==0) ? vintNUll :pProcesosCargue.id);
                    p.Add("@ID_TipoProcesoCargue",(pProcesosCargue.ID_TipoProcesoCargue== null || pProcesosCargue.ID_TipoProcesoCargue==0) ? vintNUll :pProcesosCargue.ID_TipoProcesoCargue);
                    p.Add("@ID_EstadoProcesoCargue",(pProcesosCargue.ID_EstadoProcesoCargue== null || pProcesosCargue.ID_EstadoProcesoCargue==0) ? vintNUll :pProcesosCargue.ID_EstadoProcesoCargue);
                    p.Add("@FechaCargue",(pProcesosCargue.FechaCargue== null) ? vintNUll :pProcesosCargue.FechaCargue);
                    p.Add("@NombreArchivoProcesado",(pProcesosCargue.NombreArchivoProcesado== null) ? vintNUll :pProcesosCargue.NombreArchivoProcesado);
                    p.Add("@Porcentaje",(pProcesosCargue.Porcentaje== null) ? vintNUll :pProcesosCargue.Porcentaje);
                    p.Add("@Procesados",(pProcesosCargue.Procesados== null) ? vintNUll :pProcesosCargue.Procesados);
                    p.Add("@Errores",(pProcesosCargue.Errores== null) ? vintNUll :pProcesosCargue.Errores);
                    p.Add("@Cargado",(pProcesosCargue.Cargado== null) ? vintNUll :pProcesosCargue.Cargado);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ProcesosCargue> l = SqlMapper.Query<ProcesosCargue>(con, "API.PA_ProcesosCargueGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ProcesosCargue  ->" + ex.Message);
				}
			}

			public ProcesosCargue Add(ProcesosCargue pProcesosCargue)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pProcesosCargue.id==null ? 0 : pProcesosCargue.id);
p.Add("@ID_TipoProcesoCargue",pProcesosCargue.ID_TipoProcesoCargue==null ? 0 : pProcesosCargue.ID_TipoProcesoCargue);
p.Add("@ID_EstadoProcesoCargue",pProcesosCargue.ID_EstadoProcesoCargue==null ? 0 : pProcesosCargue.ID_EstadoProcesoCargue);
                    p.Add("@FechaCargue", pProcesosCargue.FechaCargue);
                    p.Add("@NombreArchivoProcesado", pProcesosCargue.NombreArchivoProcesado);
                    p.Add("@Porcentaje", pProcesosCargue.Porcentaje);
                    p.Add("@Procesados", pProcesosCargue.Procesados);
                    p.Add("@Errores", pProcesosCargue.Errores);
                    p.Add("@Cargado", pProcesosCargue.Cargado);
                    p.Add("@auditoria", pProcesosCargue.auditoria);

                         


                    ProcesosCargue o = SqlMapper.QueryFirstOrDefault<ProcesosCargue>(con, "API.PA_ProcesosCargueAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ProcesosCargue  ->" + ex.Message);
				}
			}

			public ProcesosCargue  Update(ProcesosCargue pProcesosCargue)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pProcesosCargue.id==null ? 0 : pProcesosCargue.id);
p.Add("@ID_TipoProcesoCargue",pProcesosCargue.ID_TipoProcesoCargue==null ? 0 : pProcesosCargue.ID_TipoProcesoCargue);
p.Add("@ID_EstadoProcesoCargue",pProcesosCargue.ID_EstadoProcesoCargue==null ? 0 : pProcesosCargue.ID_EstadoProcesoCargue);
                    p.Add("@FechaCargue", pProcesosCargue.FechaCargue);
                    p.Add("@NombreArchivoProcesado", pProcesosCargue.NombreArchivoProcesado);
                    p.Add("@Porcentaje", pProcesosCargue.Porcentaje);
                    p.Add("@Procesados", pProcesosCargue.Procesados);
                    p.Add("@Errores", pProcesosCargue.Errores);
                    p.Add("@Cargado", pProcesosCargue.Cargado);
                    p.Add("@auditoria", pProcesosCargue.auditoria);

                         


                    ProcesosCargue o = SqlMapper.QueryFirstOrDefault<ProcesosCargue>(con, "API.PA_ProcesosCargueUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ProcesosCargue  ->" + ex.Message);
				}
			}

			public bool Delete(ProcesosCargue pProcesosCargue)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pProcesosCargue.id);
                    p.Add("@auditoria", pProcesosCargue.auditoria);

                

 

					ProcesosCargue o = SqlMapper.QueryFirstOrDefault<ProcesosCargue>(con, "API.PA_ProcesosCargueDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ProcesosCargue  ->" + ex.Message);
				}
			}

		



            public List<ProcesosCargue> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ProcesosCargue> ProcesosCargueList = new List<ProcesosCargue>();

                    ProcesosCargueList = SqlMapper.Query<ProcesosCargue>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ProcesosCargueList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ProcesosCargue  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ProcesosCargue> b)
            {
                DapperPlusManager.Entity<ProcesosCargue>().Table("ProcesosCargue");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}