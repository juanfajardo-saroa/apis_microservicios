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
     /// Clase Abstracta para  NutrientesAdiciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class NutrientesAdicionesRepository : DataObject , INutrientesAdiciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public NutrientesAdicionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public NutrientesAdicionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public NutrientesAdiciones GetById(NutrientesAdiciones pNutrientesAdiciones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pNutrientesAdiciones.id);                                    


    				NutrientesAdiciones o = SqlMapper.QueryFirstOrDefault<NutrientesAdiciones>(con, "API.PA_NutrientesAdicionesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  NutrientesAdiciones  ->" + ex.Message);
				}
			}

			public List<NutrientesAdiciones> GetAll()
			{
				try 
                {
                        List<NutrientesAdiciones> l = SqlMapper.Query<NutrientesAdiciones>(con, "API.PA_NutrientesAdicionesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  NutrientesAdiciones  ->" + ex.Message);
				}
			}

			public List<NutrientesAdiciones> GetAllFull()
			{
				try 
				{
                    List<NutrientesAdiciones> l = SqlMapper.Query<NutrientesAdiciones>(con, "API.PA_NutrientesAdicionesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  NutrientesAdiciones  ->" + ex.Message);
				}
			}
			
			public List<NutrientesAdiciones> GetAllByWithRelation()
			{
				try 
                {
                    List<NutrientesAdiciones> l = SqlMapper.Query<NutrientesAdiciones>(con, "API.PA_NutrientesAdicionesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  NutrientesAdiciones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<NutrientesAdiciones> GetByFilter(NutrientesAdiciones pNutrientesAdiciones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pNutrientesAdiciones.id== null || pNutrientesAdiciones.id==0) ? vintNUll :pNutrientesAdiciones.id);
                    p.Add("@ID_Nutriente",(pNutrientesAdiciones.ID_Nutriente== null || pNutrientesAdiciones.ID_Nutriente==0) ? vintNUll :pNutrientesAdiciones.ID_Nutriente);
                    p.Add("@Aporte",(pNutrientesAdiciones.Aporte== null) ? vintNUll :pNutrientesAdiciones.Aporte);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<NutrientesAdiciones> l = SqlMapper.Query<NutrientesAdiciones>(con, "API.PA_NutrientesAdicionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  NutrientesAdiciones  ->" + ex.Message);
				}
			}

			public NutrientesAdiciones Add(NutrientesAdiciones pNutrientesAdiciones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pNutrientesAdiciones.id==null ? 0 : pNutrientesAdiciones.id);
p.Add("@ID_Nutriente",pNutrientesAdiciones.ID_Nutriente==null ? 0 : pNutrientesAdiciones.ID_Nutriente);
p.Add("@Aporte",pNutrientesAdiciones.Aporte==null ? 0 : pNutrientesAdiciones.Aporte);
                    p.Add("@auditoria", pNutrientesAdiciones.auditoria);

                         


                    NutrientesAdiciones o = SqlMapper.QueryFirstOrDefault<NutrientesAdiciones>(con, "API.PA_NutrientesAdicionesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  NutrientesAdiciones  ->" + ex.Message);
				}
			}

			public NutrientesAdiciones  Update(NutrientesAdiciones pNutrientesAdiciones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pNutrientesAdiciones.id==null ? 0 : pNutrientesAdiciones.id);
p.Add("@ID_Nutriente",pNutrientesAdiciones.ID_Nutriente==null ? 0 : pNutrientesAdiciones.ID_Nutriente);
p.Add("@Aporte",pNutrientesAdiciones.Aporte==null ? 0 : pNutrientesAdiciones.Aporte);
                    p.Add("@auditoria", pNutrientesAdiciones.auditoria);

                         


                    NutrientesAdiciones o = SqlMapper.QueryFirstOrDefault<NutrientesAdiciones>(con, "API.PA_NutrientesAdicionesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  NutrientesAdiciones  ->" + ex.Message);
				}
			}

			public bool Delete(NutrientesAdiciones pNutrientesAdiciones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pNutrientesAdiciones.id);
                    p.Add("@auditoria", pNutrientesAdiciones.auditoria);

                

 

					NutrientesAdiciones o = SqlMapper.QueryFirstOrDefault<NutrientesAdiciones>(con, "API.PA_NutrientesAdicionesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) NutrientesAdiciones  ->" + ex.Message);
				}
			}

		



            public List<NutrientesAdiciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<NutrientesAdiciones> NutrientesAdicionesList = new List<NutrientesAdiciones>();

                    NutrientesAdicionesList = SqlMapper.Query<NutrientesAdiciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return NutrientesAdicionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) NutrientesAdiciones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<NutrientesAdiciones> b)
            {
                DapperPlusManager.Entity<NutrientesAdiciones>().Table("NutrientesAdiciones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}