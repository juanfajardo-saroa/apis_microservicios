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
     /// Clase Abstracta para  Visitas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class VisitasRepository : DataObject , IVisitas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public VisitasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public VisitasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Visitas GetById(Visitas pVisitas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pVisitas.id);                                    


    				Visitas o = SqlMapper.QueryFirstOrDefault<Visitas>(con, "API.PA_VisitasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Visitas  ->" + ex.Message);
				}
			}

			public List<Visitas> GetAll()
			{
				try 
                {
                        List<Visitas> l = SqlMapper.Query<Visitas>(con, "API.PA_VisitasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Visitas  ->" + ex.Message);
				}
			}

			public List<Visitas> GetAllFull()
			{
				try 
				{
                    List<Visitas> l = SqlMapper.Query<Visitas>(con, "API.PA_VisitasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Visitas  ->" + ex.Message);
				}
			}
			
			public List<Visitas> GetAllByWithRelation()
			{
				try 
                {
                    List<Visitas> l = SqlMapper.Query<Visitas>(con, "API.PA_VisitasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Visitas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Visitas> GetByFilter(Visitas pVisitas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pVisitas.id== null || pVisitas.id==0) ? vintNUll :pVisitas.id);
                    p.Add("@ID_Contrato",(pVisitas.ID_Contrato== null || pVisitas.ID_Contrato==0) ? vintNUll :pVisitas.ID_Contrato);
                    p.Add("@ID_Sede",(pVisitas.ID_Sede== null || pVisitas.ID_Sede==0) ? vintNUll :pVisitas.ID_Sede);
                    p.Add("@ID_TipoModeloOperacion",(pVisitas.ID_TipoModeloOperacion== null || pVisitas.ID_TipoModeloOperacion==0) ? vintNUll :pVisitas.ID_TipoModeloOperacion);
                    p.Add("@ID_UsuarioEntidad",(pVisitas.ID_UsuarioEntidad== null || pVisitas.ID_UsuarioEntidad==0) ? vintNUll :pVisitas.ID_UsuarioEntidad);
                    p.Add("@ID_PlantaBodega",(pVisitas.ID_PlantaBodega== null || pVisitas.ID_PlantaBodega==0) ? vintNUll :pVisitas.ID_PlantaBodega);
                    p.Add("@ID_EstadoVisita",(pVisitas.ID_EstadoVisita== null || pVisitas.ID_EstadoVisita==0) ? vintNUll :pVisitas.ID_EstadoVisita);
                    p.Add("@ID_TipoVisita",(pVisitas.ID_TipoVisita== null || pVisitas.ID_TipoVisita==0) ? vintNUll :pVisitas.ID_TipoVisita);
                    p.Add("@Fecha",(pVisitas.Fecha== null) ? vintNUll :pVisitas.Fecha);
                    p.Add("@Horalnicio",(pVisitas.Horalnicio== null) ? vintNUll :pVisitas.Horalnicio);
                    p.Add("@HoraFin",(pVisitas.HoraFin== null) ? vintNUll :pVisitas.HoraFin);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Visitas> l = SqlMapper.Query<Visitas>(con, "API.PA_VisitasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Visitas  ->" + ex.Message);
				}
			}

			public Visitas Add(Visitas pVisitas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pVisitas.id==null ? 0 : pVisitas.id);
p.Add("@ID_Contrato",pVisitas.ID_Contrato==null ? 0 : pVisitas.ID_Contrato);
p.Add("@ID_Sede",pVisitas.ID_Sede==null ? 0 : pVisitas.ID_Sede);
p.Add("@ID_TipoModeloOperacion",pVisitas.ID_TipoModeloOperacion==null ? 0 : pVisitas.ID_TipoModeloOperacion);
p.Add("@ID_UsuarioEntidad",pVisitas.ID_UsuarioEntidad==null ? 0 : pVisitas.ID_UsuarioEntidad);
p.Add("@ID_PlantaBodega",pVisitas.ID_PlantaBodega==null ? 0 : pVisitas.ID_PlantaBodega);
p.Add("@ID_EstadoVisita",pVisitas.ID_EstadoVisita==null ? 0 : pVisitas.ID_EstadoVisita);
p.Add("@ID_TipoVisita",pVisitas.ID_TipoVisita==null ? 0 : pVisitas.ID_TipoVisita);
                    p.Add("@Fecha", pVisitas.Fecha);
                    p.Add("@Horalnicio", pVisitas.Horalnicio);
                    p.Add("@HoraFin", pVisitas.HoraFin);
                    p.Add("@auditoria", pVisitas.auditoria);

                         


                    Visitas o = SqlMapper.QueryFirstOrDefault<Visitas>(con, "API.PA_VisitasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Visitas  ->" + ex.Message);
				}
			}

			public Visitas  Update(Visitas pVisitas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pVisitas.id==null ? 0 : pVisitas.id);
p.Add("@ID_Contrato",pVisitas.ID_Contrato==null ? 0 : pVisitas.ID_Contrato);
p.Add("@ID_Sede",pVisitas.ID_Sede==null ? 0 : pVisitas.ID_Sede);
p.Add("@ID_TipoModeloOperacion",pVisitas.ID_TipoModeloOperacion==null ? 0 : pVisitas.ID_TipoModeloOperacion);
p.Add("@ID_UsuarioEntidad",pVisitas.ID_UsuarioEntidad==null ? 0 : pVisitas.ID_UsuarioEntidad);
p.Add("@ID_PlantaBodega",pVisitas.ID_PlantaBodega==null ? 0 : pVisitas.ID_PlantaBodega);
p.Add("@ID_EstadoVisita",pVisitas.ID_EstadoVisita==null ? 0 : pVisitas.ID_EstadoVisita);
p.Add("@ID_TipoVisita",pVisitas.ID_TipoVisita==null ? 0 : pVisitas.ID_TipoVisita);
                    p.Add("@Fecha", pVisitas.Fecha);
                    p.Add("@Horalnicio", pVisitas.Horalnicio);
                    p.Add("@HoraFin", pVisitas.HoraFin);
                    p.Add("@auditoria", pVisitas.auditoria);

                         


                    Visitas o = SqlMapper.QueryFirstOrDefault<Visitas>(con, "API.PA_VisitasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Visitas  ->" + ex.Message);
				}
			}

			public bool Delete(Visitas pVisitas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pVisitas.id);
                    p.Add("@auditoria", pVisitas.auditoria);

                

 

					Visitas o = SqlMapper.QueryFirstOrDefault<Visitas>(con, "API.PA_VisitasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Visitas  ->" + ex.Message);
				}
			}

		



            public List<Visitas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Visitas> VisitasList = new List<Visitas>();

                    VisitasList = SqlMapper.Query<Visitas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return VisitasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Visitas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Visitas> b)
            {
                DapperPlusManager.Entity<Visitas>().Table("Visitas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}