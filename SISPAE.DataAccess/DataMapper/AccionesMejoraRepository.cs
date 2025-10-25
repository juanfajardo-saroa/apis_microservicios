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
     /// Clase Abstracta para  AccionesMejora
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AccionesMejoraRepository : DataObject , IAccionesMejora 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AccionesMejoraRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AccionesMejoraRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AccionesMejora GetById(AccionesMejora pAccionesMejora)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@ID",pAccionesMejora.ID);                                    


    				AccionesMejora o = SqlMapper.QueryFirstOrDefault<AccionesMejora>(con, "API.PA_AccionesMejoraGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AccionesMejora  ->" + ex.Message);
				}
			}

			public List<AccionesMejora> GetAll()
			{
				try 
                {
                        List<AccionesMejora> l = SqlMapper.Query<AccionesMejora>(con, "API.PA_AccionesMejoraGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AccionesMejora  ->" + ex.Message);
				}
			}

			public List<AccionesMejora> GetAllFull()
			{
				try 
				{
                    List<AccionesMejora> l = SqlMapper.Query<AccionesMejora>(con, "API.PA_AccionesMejoraGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AccionesMejora  ->" + ex.Message);
				}
			}
			
			public List<AccionesMejora> GetAllByWithRelation()
			{
				try 
                {
                    List<AccionesMejora> l = SqlMapper.Query<AccionesMejora>(con, "API.PA_AccionesMejoraGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AccionesMejora  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AccionesMejora> GetByFilter(AccionesMejora pAccionesMejora, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ID",(pAccionesMejora.ID== null || pAccionesMejora.ID==0) ? vintNUll :pAccionesMejora.ID);
                    p.Add("@ID_Area",(pAccionesMejora.ID_Area== null || pAccionesMejora.ID_Area==0) ? vintNUll :pAccionesMejora.ID_Area);
                    p.Add("@ID_Visita",(pAccionesMejora.ID_Visita== null || pAccionesMejora.ID_Visita==0) ? vintNUll :pAccionesMejora.ID_Visita);
                    p.Add("@ID_TipoEstadoAccionMejora",(pAccionesMejora.ID_TipoEstadoAccionMejora== null || pAccionesMejora.ID_TipoEstadoAccionMejora==0) ? vintNUll :pAccionesMejora.ID_TipoEstadoAccionMejora);
                    p.Add("@FechaLimite",(pAccionesMejora.FechaLimite== null) ? vintNUll :pAccionesMejora.FechaLimite);
                    p.Add("@Acciones",(pAccionesMejora.Acciones== null) ? vintNUll :pAccionesMejora.Acciones);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AccionesMejora> l = SqlMapper.Query<AccionesMejora>(con, "API.PA_AccionesMejoraGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AccionesMejora  ->" + ex.Message);
				}
			}

			public AccionesMejora Add(AccionesMejora pAccionesMejora)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ID",pAccionesMejora.ID==null ? 0 : pAccionesMejora.ID);
p.Add("@ID_Area",pAccionesMejora.ID_Area==null ? 0 : pAccionesMejora.ID_Area);
p.Add("@ID_Visita",pAccionesMejora.ID_Visita==null ? 0 : pAccionesMejora.ID_Visita);
p.Add("@ID_TipoEstadoAccionMejora",pAccionesMejora.ID_TipoEstadoAccionMejora==null ? 0 : pAccionesMejora.ID_TipoEstadoAccionMejora);
                    p.Add("@FechaLimite", pAccionesMejora.FechaLimite);
                    p.Add("@Acciones", pAccionesMejora.Acciones);
                    p.Add("@auditoria", pAccionesMejora.auditoria);

                         


                    AccionesMejora o = SqlMapper.QueryFirstOrDefault<AccionesMejora>(con, "API.PA_AccionesMejoraAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AccionesMejora  ->" + ex.Message);
				}
			}

			public AccionesMejora  Update(AccionesMejora pAccionesMejora)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ID",pAccionesMejora.ID==null ? 0 : pAccionesMejora.ID);
p.Add("@ID_Area",pAccionesMejora.ID_Area==null ? 0 : pAccionesMejora.ID_Area);
p.Add("@ID_Visita",pAccionesMejora.ID_Visita==null ? 0 : pAccionesMejora.ID_Visita);
p.Add("@ID_TipoEstadoAccionMejora",pAccionesMejora.ID_TipoEstadoAccionMejora==null ? 0 : pAccionesMejora.ID_TipoEstadoAccionMejora);
                    p.Add("@FechaLimite", pAccionesMejora.FechaLimite);
                    p.Add("@Acciones", pAccionesMejora.Acciones);
                    p.Add("@auditoria", pAccionesMejora.auditoria);

                         


                    AccionesMejora o = SqlMapper.QueryFirstOrDefault<AccionesMejora>(con, "API.PA_AccionesMejoraUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AccionesMejora  ->" + ex.Message);
				}
			}

			public bool Delete(AccionesMejora pAccionesMejora)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@ID",pAccionesMejora.ID);
                    p.Add("@auditoria", pAccionesMejora.auditoria);

                

 

					AccionesMejora o = SqlMapper.QueryFirstOrDefault<AccionesMejora>(con, "API.PA_AccionesMejoraDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AccionesMejora  ->" + ex.Message);
				}
			}

		



            public List<AccionesMejora> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AccionesMejora> AccionesMejoraList = new List<AccionesMejora>();

                    AccionesMejoraList = SqlMapper.Query<AccionesMejora>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AccionesMejoraList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AccionesMejora  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AccionesMejora> b)
            {
                DapperPlusManager.Entity<AccionesMejora>().Table("AccionesMejora");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}