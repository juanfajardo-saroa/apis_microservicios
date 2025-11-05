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
     /// Clase Abstracta para  CaracterizacionSede
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CaracterizacionSedeRepository : DataObject , ICaracterizacionSede 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CaracterizacionSedeRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CaracterizacionSedeRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CaracterizacionSede GetById(CaracterizacionSede pCaracterizacionSede)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@ID",pCaracterizacionSede.ID);                                    


    				CaracterizacionSede o = SqlMapper.QueryFirstOrDefault<CaracterizacionSede>(con, "API.PA_CaracterizacionSedeGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CaracterizacionSede  ->" + ex.Message);
				}
			}

			public List<CaracterizacionSede> GetAll()
			{
				try 
                {
                        List<CaracterizacionSede> l = SqlMapper.Query<CaracterizacionSede>(con, "API.PA_CaracterizacionSedeGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CaracterizacionSede  ->" + ex.Message);
				}
			}

			public List<CaracterizacionSede> GetAllFull()
			{
				try 
				{
                    List<CaracterizacionSede> l = SqlMapper.Query<CaracterizacionSede>(con, "API.PA_CaracterizacionSedeGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CaracterizacionSede  ->" + ex.Message);
				}
			}
			
			public List<CaracterizacionSede> GetAllByWithRelation()
			{
				try 
                {
                    List<CaracterizacionSede> l = SqlMapper.Query<CaracterizacionSede>(con, "API.PA_CaracterizacionSedeGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CaracterizacionSede  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CaracterizacionSede> GetByFilter(CaracterizacionSede pCaracterizacionSede, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ID",(pCaracterizacionSede.ID== null || pCaracterizacionSede.ID==0) ? vintNUll :pCaracterizacionSede.ID);
                    p.Add("@ID_Sede",(pCaracterizacionSede.ID_Sede== null || pCaracterizacionSede.ID_Sede==0) ? vintNUll :pCaracterizacionSede.ID_Sede);
                    p.Add("@ID_DiagnosticoSituacional",(pCaracterizacionSede.ID_DiagnosticoSituacional== null || pCaracterizacionSede.ID_DiagnosticoSituacional==0) ? vintNUll :pCaracterizacionSede.ID_DiagnosticoSituacional);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CaracterizacionSede> l = SqlMapper.Query<CaracterizacionSede>(con, "API.PA_CaracterizacionSedeGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CaracterizacionSede  ->" + ex.Message);
				}
			}

			public CaracterizacionSede Add(CaracterizacionSede pCaracterizacionSede)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ID",pCaracterizacionSede.ID==null ? 0 : pCaracterizacionSede.ID);
p.Add("@ID_Sede",pCaracterizacionSede.ID_Sede==null ? 0 : pCaracterizacionSede.ID_Sede);
p.Add("@ID_DiagnosticoSituacional",pCaracterizacionSede.ID_DiagnosticoSituacional==null ? 0 : pCaracterizacionSede.ID_DiagnosticoSituacional);
                    p.Add("@auditoria", pCaracterizacionSede.auditoria);

                         


                    CaracterizacionSede o = SqlMapper.QueryFirstOrDefault<CaracterizacionSede>(con, "API.PA_CaracterizacionSedeAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CaracterizacionSede  ->" + ex.Message);
				}
			}

			public CaracterizacionSede  Update(CaracterizacionSede pCaracterizacionSede)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ID",pCaracterizacionSede.ID==null ? 0 : pCaracterizacionSede.ID);
p.Add("@ID_Sede",pCaracterizacionSede.ID_Sede==null ? 0 : pCaracterizacionSede.ID_Sede);
p.Add("@ID_DiagnosticoSituacional",pCaracterizacionSede.ID_DiagnosticoSituacional==null ? 0 : pCaracterizacionSede.ID_DiagnosticoSituacional);
                    p.Add("@auditoria", pCaracterizacionSede.auditoria);

                         


                    CaracterizacionSede o = SqlMapper.QueryFirstOrDefault<CaracterizacionSede>(con, "API.PA_CaracterizacionSedeUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CaracterizacionSede  ->" + ex.Message);
				}
			}

			public bool Delete(CaracterizacionSede pCaracterizacionSede)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@ID",pCaracterizacionSede.ID);
                    p.Add("@auditoria", pCaracterizacionSede.auditoria);

                

 

					CaracterizacionSede o = SqlMapper.QueryFirstOrDefault<CaracterizacionSede>(con, "API.PA_CaracterizacionSedeDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CaracterizacionSede  ->" + ex.Message);
				}
			}

		



            public List<CaracterizacionSede> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CaracterizacionSede> CaracterizacionSedeList = new List<CaracterizacionSede>();

                    CaracterizacionSedeList = SqlMapper.Query<CaracterizacionSede>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CaracterizacionSedeList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CaracterizacionSede  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CaracterizacionSede> b)
            {
                DapperPlusManager.Entity<CaracterizacionSede>().Table("CaracterizacionSede");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}