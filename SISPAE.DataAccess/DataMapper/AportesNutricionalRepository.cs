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
     /// Clase Abstracta para  AportesNutricional
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AportesNutricionalRepository : DataObject , IAportesNutricional 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AportesNutricionalRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AportesNutricionalRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AportesNutricional GetById(AportesNutricional pAportesNutricional)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAportesNutricional.id);                                    


    				AportesNutricional o = SqlMapper.QueryFirstOrDefault<AportesNutricional>(con, "API.PA_AportesNutricionalGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AportesNutricional  ->" + ex.Message);
				}
			}

			public List<AportesNutricional> GetAll()
			{
				try 
                {
                        List<AportesNutricional> l = SqlMapper.Query<AportesNutricional>(con, "API.PA_AportesNutricionalGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AportesNutricional  ->" + ex.Message);
				}
			}

			public List<AportesNutricional> GetAllFull()
			{
				try 
				{
                    List<AportesNutricional> l = SqlMapper.Query<AportesNutricional>(con, "API.PA_AportesNutricionalGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AportesNutricional  ->" + ex.Message);
				}
			}
			
			public List<AportesNutricional> GetAllByWithRelation()
			{
				try 
                {
                    List<AportesNutricional> l = SqlMapper.Query<AportesNutricional>(con, "API.PA_AportesNutricionalGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AportesNutricional  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AportesNutricional> GetByFilter(AportesNutricional pAportesNutricional, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAportesNutricional.id== null || pAportesNutricional.id==0) ? vintNUll :pAportesNutricional.id);
                    p.Add("@ID_MinutaPatronAlimento",(pAportesNutricional.ID_MinutaPatronAlimento== null || pAportesNutricional.ID_MinutaPatronAlimento==0) ? vintNUll :pAportesNutricional.ID_MinutaPatronAlimento);
                    p.Add("@AporteMinimo",(pAportesNutricional.AporteMinimo== null) ? vintNUll :pAportesNutricional.AporteMinimo);
                    p.Add("@PorcentajeAdecuacionMin",(pAportesNutricional.PorcentajeAdecuacionMin== null) ? vintNUll :pAportesNutricional.PorcentajeAdecuacionMin);
                    p.Add("@ID_Nutriente",(pAportesNutricional.ID_Nutriente== null || pAportesNutricional.ID_Nutriente==0) ? vintNUll :pAportesNutricional.ID_Nutriente);
                    p.Add("@AporteRecomendadoMin",(pAportesNutricional.AporteRecomendadoMin== null) ? vintNUll :pAportesNutricional.AporteRecomendadoMin);
                    p.Add("@PorcentajeAdecuacionMax",(pAportesNutricional.PorcentajeAdecuacionMax== null) ? vintNUll :pAportesNutricional.PorcentajeAdecuacionMax);
                    p.Add("@AporteRecomendadoMax",(pAportesNutricional.AporteRecomendadoMax== null) ? vintNUll :pAportesNutricional.AporteRecomendadoMax);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AportesNutricional> l = SqlMapper.Query<AportesNutricional>(con, "API.PA_AportesNutricionalGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AportesNutricional  ->" + ex.Message);
				}
			}

			public AportesNutricional Add(AportesNutricional pAportesNutricional)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAportesNutricional.id==null ? 0 : pAportesNutricional.id);
p.Add("@ID_MinutaPatronAlimento",pAportesNutricional.ID_MinutaPatronAlimento==null ? 0 : pAportesNutricional.ID_MinutaPatronAlimento);
                    p.Add("@AporteMinimo", pAportesNutricional.AporteMinimo);
                    p.Add("@PorcentajeAdecuacionMin", pAportesNutricional.PorcentajeAdecuacionMin);
p.Add("@ID_Nutriente",pAportesNutricional.ID_Nutriente==null ? 0 : pAportesNutricional.ID_Nutriente);
                    p.Add("@AporteRecomendadoMin", pAportesNutricional.AporteRecomendadoMin);
                    p.Add("@PorcentajeAdecuacionMax", pAportesNutricional.PorcentajeAdecuacionMax);
                    p.Add("@AporteRecomendadoMax", pAportesNutricional.AporteRecomendadoMax);
                    p.Add("@auditoria", pAportesNutricional.auditoria);

                         


                    AportesNutricional o = SqlMapper.QueryFirstOrDefault<AportesNutricional>(con, "API.PA_AportesNutricionalAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AportesNutricional  ->" + ex.Message);
				}
			}

			public AportesNutricional  Update(AportesNutricional pAportesNutricional)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAportesNutricional.id==null ? 0 : pAportesNutricional.id);
p.Add("@ID_MinutaPatronAlimento",pAportesNutricional.ID_MinutaPatronAlimento==null ? 0 : pAportesNutricional.ID_MinutaPatronAlimento);
                    p.Add("@AporteMinimo", pAportesNutricional.AporteMinimo);
                    p.Add("@PorcentajeAdecuacionMin", pAportesNutricional.PorcentajeAdecuacionMin);
p.Add("@ID_Nutriente",pAportesNutricional.ID_Nutriente==null ? 0 : pAportesNutricional.ID_Nutriente);
                    p.Add("@AporteRecomendadoMin", pAportesNutricional.AporteRecomendadoMin);
                    p.Add("@PorcentajeAdecuacionMax", pAportesNutricional.PorcentajeAdecuacionMax);
                    p.Add("@AporteRecomendadoMax", pAportesNutricional.AporteRecomendadoMax);
                    p.Add("@auditoria", pAportesNutricional.auditoria);

                         


                    AportesNutricional o = SqlMapper.QueryFirstOrDefault<AportesNutricional>(con, "API.PA_AportesNutricionalUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AportesNutricional  ->" + ex.Message);
				}
			}

			public bool Delete(AportesNutricional pAportesNutricional)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAportesNutricional.id);
                    p.Add("@auditoria", pAportesNutricional.auditoria);

                

 

					AportesNutricional o = SqlMapper.QueryFirstOrDefault<AportesNutricional>(con, "API.PA_AportesNutricionalDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AportesNutricional  ->" + ex.Message);
				}
			}

		



            public List<AportesNutricional> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AportesNutricional> AportesNutricionalList = new List<AportesNutricional>();

                    AportesNutricionalList = SqlMapper.Query<AportesNutricional>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AportesNutricionalList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AportesNutricional  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AportesNutricional> b)
            {
                DapperPlusManager.Entity<AportesNutricional>().Table("AportesNutricional");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}