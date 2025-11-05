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
     /// Clase Abstracta para  RutasSedes
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class RutasSedesRepository : DataObject , IRutasSedes 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public RutasSedesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public RutasSedesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public RutasSedes GetById(RutasSedes pRutasSedes)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pRutasSedes.id);                                    


    				RutasSedes o = SqlMapper.QueryFirstOrDefault<RutasSedes>(con, "API.PA_RutasSedesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  RutasSedes  ->" + ex.Message);
				}
			}

			public List<RutasSedes> GetAll()
			{
				try 
                {
                        List<RutasSedes> l = SqlMapper.Query<RutasSedes>(con, "API.PA_RutasSedesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  RutasSedes  ->" + ex.Message);
				}
			}

			public List<RutasSedes> GetAllFull()
			{
				try 
				{
                    List<RutasSedes> l = SqlMapper.Query<RutasSedes>(con, "API.PA_RutasSedesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  RutasSedes  ->" + ex.Message);
				}
			}
			
			public List<RutasSedes> GetAllByWithRelation()
			{
				try 
                {
                    List<RutasSedes> l = SqlMapper.Query<RutasSedes>(con, "API.PA_RutasSedesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  RutasSedes  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<RutasSedes> GetByFilter(RutasSedes pRutasSedes, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pRutasSedes.id== null || pRutasSedes.id==0) ? vintNUll :pRutasSedes.id);
                    p.Add("@ID_Ruta",(pRutasSedes.ID_Ruta== null || pRutasSedes.ID_Ruta==0) ? vintNUll :pRutasSedes.ID_Ruta);
                    p.Add("@ID_Sede",(pRutasSedes.ID_Sede== null || pRutasSedes.ID_Sede==0) ? vintNUll :pRutasSedes.ID_Sede);
                    p.Add("@Numeracion",(pRutasSedes.Numeracion== null) ? vintNUll :pRutasSedes.Numeracion);
                    p.Add("@RecibeGas",(pRutasSedes.RecibeGas== null) ? vintNUll :pRutasSedes.RecibeGas);
                    p.Add("@RecibeAgua",(pRutasSedes.RecibeAgua== null) ? vintNUll :pRutasSedes.RecibeAgua);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<RutasSedes> l = SqlMapper.Query<RutasSedes>(con, "API.PA_RutasSedesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  RutasSedes  ->" + ex.Message);
				}
			}

			public RutasSedes Add(RutasSedes pRutasSedes)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pRutasSedes.id==null ? 0 : pRutasSedes.id);
p.Add("@ID_Ruta",pRutasSedes.ID_Ruta==null ? 0 : pRutasSedes.ID_Ruta);
p.Add("@ID_Sede",pRutasSedes.ID_Sede==null ? 0 : pRutasSedes.ID_Sede);
p.Add("@Numeracion",pRutasSedes.Numeracion==null ? 0 : pRutasSedes.Numeracion);
                    p.Add("@RecibeGas", pRutasSedes.RecibeGas);
                    p.Add("@RecibeAgua", pRutasSedes.RecibeAgua);
                    p.Add("@auditoria", pRutasSedes.auditoria);

                         


                    RutasSedes o = SqlMapper.QueryFirstOrDefault<RutasSedes>(con, "API.PA_RutasSedesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  RutasSedes  ->" + ex.Message);
				}
			}

			public RutasSedes  Update(RutasSedes pRutasSedes)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pRutasSedes.id==null ? 0 : pRutasSedes.id);
p.Add("@ID_Ruta",pRutasSedes.ID_Ruta==null ? 0 : pRutasSedes.ID_Ruta);
p.Add("@ID_Sede",pRutasSedes.ID_Sede==null ? 0 : pRutasSedes.ID_Sede);
p.Add("@Numeracion",pRutasSedes.Numeracion==null ? 0 : pRutasSedes.Numeracion);
                    p.Add("@RecibeGas", pRutasSedes.RecibeGas);
                    p.Add("@RecibeAgua", pRutasSedes.RecibeAgua);
                    p.Add("@auditoria", pRutasSedes.auditoria);

                         


                    RutasSedes o = SqlMapper.QueryFirstOrDefault<RutasSedes>(con, "API.PA_RutasSedesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  RutasSedes  ->" + ex.Message);
				}
			}

			public bool Delete(RutasSedes pRutasSedes)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pRutasSedes.id);
                    p.Add("@auditoria", pRutasSedes.auditoria);

                

 

					RutasSedes o = SqlMapper.QueryFirstOrDefault<RutasSedes>(con, "API.PA_RutasSedesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) RutasSedes  ->" + ex.Message);
				}
			}

		



            public List<RutasSedes> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<RutasSedes> RutasSedesList = new List<RutasSedes>();

                    RutasSedesList = SqlMapper.Query<RutasSedes>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return RutasSedesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) RutasSedes  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<RutasSedes> b)
            {
                DapperPlusManager.Entity<RutasSedes>().Table("RutasSedes");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}