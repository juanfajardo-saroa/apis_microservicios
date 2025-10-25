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
     /// Clase Abstracta para  Rutas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class RutasRepository : DataObject , IRutas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public RutasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public RutasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Rutas GetById(Rutas pRutas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pRutas.id);                                    


    				Rutas o = SqlMapper.QueryFirstOrDefault<Rutas>(con, "API.PA_RutasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Rutas  ->" + ex.Message);
				}
			}

			public List<Rutas> GetAll()
			{
				try 
                {
                        List<Rutas> l = SqlMapper.Query<Rutas>(con, "API.PA_RutasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Rutas  ->" + ex.Message);
				}
			}

			public List<Rutas> GetAllFull()
			{
				try 
				{
                    List<Rutas> l = SqlMapper.Query<Rutas>(con, "API.PA_RutasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Rutas  ->" + ex.Message);
				}
			}
			
			public List<Rutas> GetAllByWithRelation()
			{
				try 
                {
                    List<Rutas> l = SqlMapper.Query<Rutas>(con, "API.PA_RutasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Rutas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Rutas> GetByFilter(Rutas pRutas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pRutas.id== null || pRutas.id==0) ? vintNUll :pRutas.id);
                    p.Add("@ID_PlanAlistamiento",(pRutas.ID_PlanAlistamiento== null || pRutas.ID_PlanAlistamiento==0) ? vintNUll :pRutas.ID_PlanAlistamiento);
                    p.Add("@ID_UsuarioEntidad",(pRutas.ID_UsuarioEntidad== null || pRutas.ID_UsuarioEntidad==0) ? vintNUll :pRutas.ID_UsuarioEntidad);
                    p.Add("@ID_EstadoValidacion",(pRutas.ID_EstadoValidacion== null || pRutas.ID_EstadoValidacion==0) ? vintNUll :pRutas.ID_EstadoValidacion);
                    p.Add("@ID_TipoModeloOperacion",(pRutas.ID_TipoModeloOperacion== null || pRutas.ID_TipoModeloOperacion==0) ? vintNUll :pRutas.ID_TipoModeloOperacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Rutas> l = SqlMapper.Query<Rutas>(con, "API.PA_RutasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Rutas  ->" + ex.Message);
				}
			}

			public Rutas Add(Rutas pRutas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pRutas.id==null ? 0 : pRutas.id);
p.Add("@ID_PlanAlistamiento",pRutas.ID_PlanAlistamiento==null ? 0 : pRutas.ID_PlanAlistamiento);
p.Add("@ID_UsuarioEntidad",pRutas.ID_UsuarioEntidad==null ? 0 : pRutas.ID_UsuarioEntidad);
p.Add("@ID_EstadoValidacion",pRutas.ID_EstadoValidacion==null ? 0 : pRutas.ID_EstadoValidacion);
p.Add("@ID_TipoModeloOperacion",pRutas.ID_TipoModeloOperacion==null ? 0 : pRutas.ID_TipoModeloOperacion);
                    p.Add("@auditoria", pRutas.auditoria);

                         


                    Rutas o = SqlMapper.QueryFirstOrDefault<Rutas>(con, "API.PA_RutasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Rutas  ->" + ex.Message);
				}
			}

			public Rutas  Update(Rutas pRutas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pRutas.id==null ? 0 : pRutas.id);
p.Add("@ID_PlanAlistamiento",pRutas.ID_PlanAlistamiento==null ? 0 : pRutas.ID_PlanAlistamiento);
p.Add("@ID_UsuarioEntidad",pRutas.ID_UsuarioEntidad==null ? 0 : pRutas.ID_UsuarioEntidad);
p.Add("@ID_EstadoValidacion",pRutas.ID_EstadoValidacion==null ? 0 : pRutas.ID_EstadoValidacion);
p.Add("@ID_TipoModeloOperacion",pRutas.ID_TipoModeloOperacion==null ? 0 : pRutas.ID_TipoModeloOperacion);
                    p.Add("@auditoria", pRutas.auditoria);

                         


                    Rutas o = SqlMapper.QueryFirstOrDefault<Rutas>(con, "API.PA_RutasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Rutas  ->" + ex.Message);
				}
			}

			public bool Delete(Rutas pRutas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pRutas.id);
                    p.Add("@auditoria", pRutas.auditoria);

                

 

					Rutas o = SqlMapper.QueryFirstOrDefault<Rutas>(con, "API.PA_RutasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Rutas  ->" + ex.Message);
				}
			}

		



            public List<Rutas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Rutas> RutasList = new List<Rutas>();

                    RutasList = SqlMapper.Query<Rutas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return RutasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Rutas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Rutas> b)
            {
                DapperPlusManager.Entity<Rutas>().Table("Rutas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}