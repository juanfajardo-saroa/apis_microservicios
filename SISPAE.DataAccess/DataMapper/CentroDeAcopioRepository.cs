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
     /// Clase Abstracta para  CentroDeAcopio
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CentroDeAcopioRepository : DataObject , ICentroDeAcopio 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CentroDeAcopioRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CentroDeAcopioRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CentroDeAcopio GetById(CentroDeAcopio pCentroDeAcopio)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCentroDeAcopio.id);                                    


    				CentroDeAcopio o = SqlMapper.QueryFirstOrDefault<CentroDeAcopio>(con, "API.PA_CentroDeAcopioGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CentroDeAcopio  ->" + ex.Message);
				}
			}

			public List<CentroDeAcopio> GetAll()
			{
				try 
                {
                        List<CentroDeAcopio> l = SqlMapper.Query<CentroDeAcopio>(con, "API.PA_CentroDeAcopioGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CentroDeAcopio  ->" + ex.Message);
				}
			}

			public List<CentroDeAcopio> GetAllFull()
			{
				try 
				{
                    List<CentroDeAcopio> l = SqlMapper.Query<CentroDeAcopio>(con, "API.PA_CentroDeAcopioGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CentroDeAcopio  ->" + ex.Message);
				}
			}
			
			public List<CentroDeAcopio> GetAllByWithRelation()
			{
				try 
                {
                    List<CentroDeAcopio> l = SqlMapper.Query<CentroDeAcopio>(con, "API.PA_CentroDeAcopioGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CentroDeAcopio  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CentroDeAcopio> GetByFilter(CentroDeAcopio pCentroDeAcopio, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCentroDeAcopio.id== null || pCentroDeAcopio.id==0) ? vintNUll :pCentroDeAcopio.id);
                    p.Add("@ID_CPobladosZona",(pCentroDeAcopio.ID_CPobladosZona== null || pCentroDeAcopio.ID_CPobladosZona==0) ? vintNUll :pCentroDeAcopio.ID_CPobladosZona);
                    p.Add("@Nombre",(pCentroDeAcopio.Nombre== null) ? vintNUll :pCentroDeAcopio.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CentroDeAcopio> l = SqlMapper.Query<CentroDeAcopio>(con, "API.PA_CentroDeAcopioGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CentroDeAcopio  ->" + ex.Message);
				}
			}

			public CentroDeAcopio Add(CentroDeAcopio pCentroDeAcopio)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCentroDeAcopio.id==null ? 0 : pCentroDeAcopio.id);
p.Add("@ID_CPobladosZona",pCentroDeAcopio.ID_CPobladosZona==null ? 0 : pCentroDeAcopio.ID_CPobladosZona);
                    p.Add("@Nombre", pCentroDeAcopio.Nombre);
                    p.Add("@auditoria", pCentroDeAcopio.auditoria);

                         


                    CentroDeAcopio o = SqlMapper.QueryFirstOrDefault<CentroDeAcopio>(con, "API.PA_CentroDeAcopioAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CentroDeAcopio  ->" + ex.Message);
				}
			}

			public CentroDeAcopio  Update(CentroDeAcopio pCentroDeAcopio)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCentroDeAcopio.id==null ? 0 : pCentroDeAcopio.id);
p.Add("@ID_CPobladosZona",pCentroDeAcopio.ID_CPobladosZona==null ? 0 : pCentroDeAcopio.ID_CPobladosZona);
                    p.Add("@Nombre", pCentroDeAcopio.Nombre);
                    p.Add("@auditoria", pCentroDeAcopio.auditoria);

                         


                    CentroDeAcopio o = SqlMapper.QueryFirstOrDefault<CentroDeAcopio>(con, "API.PA_CentroDeAcopioUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CentroDeAcopio  ->" + ex.Message);
				}
			}

			public bool Delete(CentroDeAcopio pCentroDeAcopio)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCentroDeAcopio.id);
                    p.Add("@auditoria", pCentroDeAcopio.auditoria);

                

 

					CentroDeAcopio o = SqlMapper.QueryFirstOrDefault<CentroDeAcopio>(con, "API.PA_CentroDeAcopioDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CentroDeAcopio  ->" + ex.Message);
				}
			}

		



            public List<CentroDeAcopio> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CentroDeAcopio> CentroDeAcopioList = new List<CentroDeAcopio>();

                    CentroDeAcopioList = SqlMapper.Query<CentroDeAcopio>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CentroDeAcopioList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CentroDeAcopio  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CentroDeAcopio> b)
            {
                DapperPlusManager.Entity<CentroDeAcopio>().Table("CentroDeAcopio");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}