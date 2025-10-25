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
     /// Clase Abstracta para  Trayectos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TrayectosRepository : DataObject , ITrayectos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TrayectosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TrayectosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Trayectos GetById(Trayectos pTrayectos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@TrayectoId",pTrayectos.TrayectoId);                                    


    				Trayectos o = SqlMapper.QueryFirstOrDefault<Trayectos>(con, "API.PA_TrayectosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Trayectos  ->" + ex.Message);
				}
			}

			public List<Trayectos> GetAll()
			{
				try 
                {
                        List<Trayectos> l = SqlMapper.Query<Trayectos>(con, "API.PA_TrayectosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Trayectos  ->" + ex.Message);
				}
			}

			public List<Trayectos> GetAllFull()
			{
				try 
				{
                    List<Trayectos> l = SqlMapper.Query<Trayectos>(con, "API.PA_TrayectosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Trayectos  ->" + ex.Message);
				}
			}
			
			public List<Trayectos> GetAllByWithRelation()
			{
				try 
                {
                    List<Trayectos> l = SqlMapper.Query<Trayectos>(con, "API.PA_TrayectosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Trayectos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Trayectos> GetByFilter(Trayectos pTrayectos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@TrayectoId",(pTrayectos.TrayectoId== null) ? vintNUll :pTrayectos.TrayectoId);
                    p.Add("@TipoTransporteId",(pTrayectos.TipoTransporteId== null) ? vintNUll :pTrayectos.TipoTransporteId);
                    p.Add("@MedioTransporteId",(pTrayectos.MedioTransporteId== null) ? vintNUll :pTrayectos.MedioTransporteId);
                    p.Add("@SedeId",(pTrayectos.SedeId== null) ? vintNUll :pTrayectos.SedeId);
                    p.Add("@NumPosicion",(pTrayectos.NumPosicion== null) ? vintNUll :pTrayectos.NumPosicion);
                    p.Add("@Costo",(pTrayectos.Costo== null) ? vintNUll :pTrayectos.Costo);
                    p.Add("@Kilometros",(pTrayectos.Kilometros== null) ? vintNUll :pTrayectos.Kilometros);
                    p.Add("@Horas",(pTrayectos.Horas== null) ? vintNUll :pTrayectos.Horas);
                    p.Add("@Destino",(pTrayectos.Destino== null) ? vintNUll :pTrayectos.Destino);
                    p.Add("@CabeceraMunicipal",(pTrayectos.CabeceraMunicipal== null) ? vintNUll :pTrayectos.CabeceraMunicipal);
                    p.Add("@CentroAcopio",(pTrayectos.CentroAcopio== null) ? vintNUll :pTrayectos.CentroAcopio);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Trayectos> l = SqlMapper.Query<Trayectos>(con, "API.PA_TrayectosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Trayectos  ->" + ex.Message);
				}
			}

			public Trayectos Add(Trayectos pTrayectos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@TrayectoId",pTrayectos.TrayectoId==null ? 0 : pTrayectos.TrayectoId);
p.Add("@TipoTransporteId",pTrayectos.TipoTransporteId==null ? 0 : pTrayectos.TipoTransporteId);
p.Add("@MedioTransporteId",pTrayectos.MedioTransporteId==null ? 0 : pTrayectos.MedioTransporteId);
p.Add("@SedeId",pTrayectos.SedeId==null ? 0 : pTrayectos.SedeId);
p.Add("@NumPosicion",pTrayectos.NumPosicion==null ? 0 : pTrayectos.NumPosicion);
p.Add("@Costo",pTrayectos.Costo==null ? 0 : pTrayectos.Costo);
p.Add("@Kilometros",pTrayectos.Kilometros==null ? 0 : pTrayectos.Kilometros);
p.Add("@Horas",pTrayectos.Horas==null ? 0 : pTrayectos.Horas);
                    p.Add("@Destino", pTrayectos.Destino);
                    p.Add("@CabeceraMunicipal", pTrayectos.CabeceraMunicipal);
                    p.Add("@CentroAcopio", pTrayectos.CentroAcopio);
                    p.Add("@auditoria", pTrayectos.auditoria);

                         


                    Trayectos o = SqlMapper.QueryFirstOrDefault<Trayectos>(con, "API.PA_TrayectosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Trayectos  ->" + ex.Message);
				}
			}

			public Trayectos  Update(Trayectos pTrayectos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@TrayectoId",pTrayectos.TrayectoId==null ? 0 : pTrayectos.TrayectoId);
p.Add("@TipoTransporteId",pTrayectos.TipoTransporteId==null ? 0 : pTrayectos.TipoTransporteId);
p.Add("@MedioTransporteId",pTrayectos.MedioTransporteId==null ? 0 : pTrayectos.MedioTransporteId);
p.Add("@SedeId",pTrayectos.SedeId==null ? 0 : pTrayectos.SedeId);
p.Add("@NumPosicion",pTrayectos.NumPosicion==null ? 0 : pTrayectos.NumPosicion);
p.Add("@Costo",pTrayectos.Costo==null ? 0 : pTrayectos.Costo);
p.Add("@Kilometros",pTrayectos.Kilometros==null ? 0 : pTrayectos.Kilometros);
p.Add("@Horas",pTrayectos.Horas==null ? 0 : pTrayectos.Horas);
                    p.Add("@Destino", pTrayectos.Destino);
                    p.Add("@CabeceraMunicipal", pTrayectos.CabeceraMunicipal);
                    p.Add("@CentroAcopio", pTrayectos.CentroAcopio);
                    p.Add("@auditoria", pTrayectos.auditoria);

                         


                    Trayectos o = SqlMapper.QueryFirstOrDefault<Trayectos>(con, "API.PA_TrayectosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Trayectos  ->" + ex.Message);
				}
			}

			public bool Delete(Trayectos pTrayectos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@TrayectoId",pTrayectos.TrayectoId);
                    p.Add("@auditoria", pTrayectos.auditoria);

                

 

					Trayectos o = SqlMapper.QueryFirstOrDefault<Trayectos>(con, "API.PA_TrayectosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Trayectos  ->" + ex.Message);
				}
			}

		



            public List<Trayectos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Trayectos> TrayectosList = new List<Trayectos>();

                    TrayectosList = SqlMapper.Query<Trayectos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TrayectosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Trayectos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Trayectos> b)
            {
                DapperPlusManager.Entity<Trayectos>().Table("Trayectos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}