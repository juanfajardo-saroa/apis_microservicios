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
     /// Clase Abstracta para  ActaInicio
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ActaInicioRepository : DataObject , IActaInicio 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ActaInicioRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ActaInicioRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ActaInicio GetById(ActaInicio pActaInicio)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pActaInicio.id);                                    


    				ActaInicio o = SqlMapper.QueryFirstOrDefault<ActaInicio>(con, "API.PA_ActaInicioGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ActaInicio  ->" + ex.Message);
				}
			}

			public List<ActaInicio> GetAll()
			{
				try 
                {
                        List<ActaInicio> l = SqlMapper.Query<ActaInicio>(con, "API.PA_ActaInicioGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ActaInicio  ->" + ex.Message);
				}
			}

			public List<ActaInicio> GetAllFull()
			{
				try 
				{
                    List<ActaInicio> l = SqlMapper.Query<ActaInicio>(con, "API.PA_ActaInicioGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ActaInicio  ->" + ex.Message);
				}
			}
			
			public List<ActaInicio> GetAllByWithRelation()
			{
				try 
                {
                    List<ActaInicio> l = SqlMapper.Query<ActaInicio>(con, "API.PA_ActaInicioGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ActaInicio  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ActaInicio> GetByFilter(ActaInicio pActaInicio, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pActaInicio.id== null || pActaInicio.id==0) ? vintNUll :pActaInicio.id);
                    p.Add("@ID_PlanAlistamiento",(pActaInicio.ID_PlanAlistamiento== null || pActaInicio.ID_PlanAlistamiento==0) ? vintNUll :pActaInicio.ID_PlanAlistamiento);
                    p.Add("@ID_Contrato",(pActaInicio.ID_Contrato== null || pActaInicio.ID_Contrato==0) ? vintNUll :pActaInicio.ID_Contrato);
                    p.Add("@ID_CicloMenu",(pActaInicio.ID_CicloMenu== null || pActaInicio.ID_CicloMenu==0) ? vintNUll :pActaInicio.ID_CicloMenu);
                    p.Add("@FechaActa",(pActaInicio.FechaActa== null) ? vintNUll :pActaInicio.FechaActa);
                    p.Add("@NombreSupervisor",(pActaInicio.NombreSupervisor== null) ? vintNUll :pActaInicio.NombreSupervisor);
                    p.Add("@CedulaSupervisor",(pActaInicio.CedulaSupervisor== null) ? vintNUll :pActaInicio.CedulaSupervisor);
                    p.Add("@LugarCedulaSupervisor",(pActaInicio.LugarCedulaSupervisor== null) ? vintNUll :pActaInicio.LugarCedulaSupervisor);
                    p.Add("@NombreRepresentanteLegalOperador",(pActaInicio.NombreRepresentanteLegalOperador== null) ? vintNUll :pActaInicio.NombreRepresentanteLegalOperador);
                    p.Add("@CedulaRepresentanteOperador",(pActaInicio.CedulaRepresentanteOperador== null) ? vintNUll :pActaInicio.CedulaRepresentanteOperador);
                    p.Add("@LugarCedulaRepresentante",(pActaInicio.LugarCedulaRepresentante== null) ? vintNUll :pActaInicio.LugarCedulaRepresentante);
                    p.Add("@FechaInicioOPeracionAutorizada",(pActaInicio.FechaInicioOPeracionAutorizada== null) ? vintNUll :pActaInicio.FechaInicioOPeracionAutorizada);
                    p.Add("@EstadoInicioOperacion",(pActaInicio.EstadoInicioOperacion== null) ? vintNUll :pActaInicio.EstadoInicioOperacion);
                    p.Add("@Menu1",(pActaInicio.Menu1== null) ? vintNUll :pActaInicio.Menu1);
                    p.Add("@Menu2",(pActaInicio.Menu2== null) ? vintNUll :pActaInicio.Menu2);
                    p.Add("@Menu3",(pActaInicio.Menu3== null) ? vintNUll :pActaInicio.Menu3);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ActaInicio> l = SqlMapper.Query<ActaInicio>(con, "API.PA_ActaInicioGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ActaInicio  ->" + ex.Message);
				}
			}

			public ActaInicio Add(ActaInicio pActaInicio)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pActaInicio.id==null ? 0 : pActaInicio.id);
p.Add("@ID_PlanAlistamiento",pActaInicio.ID_PlanAlistamiento==null ? 0 : pActaInicio.ID_PlanAlistamiento);
p.Add("@ID_Contrato",pActaInicio.ID_Contrato==null ? 0 : pActaInicio.ID_Contrato);
p.Add("@ID_CicloMenu",pActaInicio.ID_CicloMenu==null ? 0 : pActaInicio.ID_CicloMenu);
                    p.Add("@FechaActa", pActaInicio.FechaActa);
                    p.Add("@NombreSupervisor", pActaInicio.NombreSupervisor);
                    p.Add("@CedulaSupervisor", pActaInicio.CedulaSupervisor);
                    p.Add("@LugarCedulaSupervisor", pActaInicio.LugarCedulaSupervisor);
                    p.Add("@NombreRepresentanteLegalOperador", pActaInicio.NombreRepresentanteLegalOperador);
                    p.Add("@CedulaRepresentanteOperador", pActaInicio.CedulaRepresentanteOperador);
                    p.Add("@LugarCedulaRepresentante", pActaInicio.LugarCedulaRepresentante);
                    p.Add("@FechaInicioOPeracionAutorizada", pActaInicio.FechaInicioOPeracionAutorizada);
                    p.Add("@EstadoInicioOperacion", pActaInicio.EstadoInicioOperacion);
p.Add("@Menu1",pActaInicio.Menu1==null ? 0 : pActaInicio.Menu1);
p.Add("@Menu2",pActaInicio.Menu2==null ? 0 : pActaInicio.Menu2);
p.Add("@Menu3",pActaInicio.Menu3==null ? 0 : pActaInicio.Menu3);
                    p.Add("@auditoria", pActaInicio.auditoria);

                         


                    ActaInicio o = SqlMapper.QueryFirstOrDefault<ActaInicio>(con, "API.PA_ActaInicioAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ActaInicio  ->" + ex.Message);
				}
			}

			public ActaInicio  Update(ActaInicio pActaInicio)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pActaInicio.id==null ? 0 : pActaInicio.id);
p.Add("@ID_PlanAlistamiento",pActaInicio.ID_PlanAlistamiento==null ? 0 : pActaInicio.ID_PlanAlistamiento);
p.Add("@ID_Contrato",pActaInicio.ID_Contrato==null ? 0 : pActaInicio.ID_Contrato);
p.Add("@ID_CicloMenu",pActaInicio.ID_CicloMenu==null ? 0 : pActaInicio.ID_CicloMenu);
                    p.Add("@FechaActa", pActaInicio.FechaActa);
                    p.Add("@NombreSupervisor", pActaInicio.NombreSupervisor);
                    p.Add("@CedulaSupervisor", pActaInicio.CedulaSupervisor);
                    p.Add("@LugarCedulaSupervisor", pActaInicio.LugarCedulaSupervisor);
                    p.Add("@NombreRepresentanteLegalOperador", pActaInicio.NombreRepresentanteLegalOperador);
                    p.Add("@CedulaRepresentanteOperador", pActaInicio.CedulaRepresentanteOperador);
                    p.Add("@LugarCedulaRepresentante", pActaInicio.LugarCedulaRepresentante);
                    p.Add("@FechaInicioOPeracionAutorizada", pActaInicio.FechaInicioOPeracionAutorizada);
                    p.Add("@EstadoInicioOperacion", pActaInicio.EstadoInicioOperacion);
p.Add("@Menu1",pActaInicio.Menu1==null ? 0 : pActaInicio.Menu1);
p.Add("@Menu2",pActaInicio.Menu2==null ? 0 : pActaInicio.Menu2);
p.Add("@Menu3",pActaInicio.Menu3==null ? 0 : pActaInicio.Menu3);
                    p.Add("@auditoria", pActaInicio.auditoria);

                         


                    ActaInicio o = SqlMapper.QueryFirstOrDefault<ActaInicio>(con, "API.PA_ActaInicioUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ActaInicio  ->" + ex.Message);
				}
			}

			public bool Delete(ActaInicio pActaInicio)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pActaInicio.id);
                    p.Add("@auditoria", pActaInicio.auditoria);

                

 

					ActaInicio o = SqlMapper.QueryFirstOrDefault<ActaInicio>(con, "API.PA_ActaInicioDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ActaInicio  ->" + ex.Message);
				}
			}

		



            public List<ActaInicio> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ActaInicio> ActaInicioList = new List<ActaInicio>();

                    ActaInicioList = SqlMapper.Query<ActaInicio>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ActaInicioList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ActaInicio  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ActaInicio> b)
            {
                DapperPlusManager.Entity<ActaInicio>().Table("ActaInicio");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}