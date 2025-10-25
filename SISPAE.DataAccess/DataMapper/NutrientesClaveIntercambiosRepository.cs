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
     /// Clase Abstracta para  NutrientesClaveIntercambios
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class NutrientesClaveIntercambiosRepository : DataObject , INutrientesClaveIntercambios 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public NutrientesClaveIntercambiosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public NutrientesClaveIntercambiosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public NutrientesClaveIntercambios GetById(NutrientesClaveIntercambios pNutrientesClaveIntercambios)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pNutrientesClaveIntercambios.id);                                    


    				NutrientesClaveIntercambios o = SqlMapper.QueryFirstOrDefault<NutrientesClaveIntercambios>(con, "API.PA_NutrientesClaveIntercambiosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  NutrientesClaveIntercambios  ->" + ex.Message);
				}
			}

			public List<NutrientesClaveIntercambios> GetAll()
			{
				try 
                {
                        List<NutrientesClaveIntercambios> l = SqlMapper.Query<NutrientesClaveIntercambios>(con, "API.PA_NutrientesClaveIntercambiosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  NutrientesClaveIntercambios  ->" + ex.Message);
				}
			}

			public List<NutrientesClaveIntercambios> GetAllFull()
			{
				try 
				{
                    List<NutrientesClaveIntercambios> l = SqlMapper.Query<NutrientesClaveIntercambios>(con, "API.PA_NutrientesClaveIntercambiosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  NutrientesClaveIntercambios  ->" + ex.Message);
				}
			}
			
			public List<NutrientesClaveIntercambios> GetAllByWithRelation()
			{
				try 
                {
                    List<NutrientesClaveIntercambios> l = SqlMapper.Query<NutrientesClaveIntercambios>(con, "API.PA_NutrientesClaveIntercambiosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  NutrientesClaveIntercambios  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<NutrientesClaveIntercambios> GetByFilter(NutrientesClaveIntercambios pNutrientesClaveIntercambios, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pNutrientesClaveIntercambios.id== null || pNutrientesClaveIntercambios.id==0) ? vintNUll :pNutrientesClaveIntercambios.id);
                    p.Add("@id_SubgrupoAlimentos",(pNutrientesClaveIntercambios.id_SubgrupoAlimentos== null || pNutrientesClaveIntercambios.id_SubgrupoAlimentos==0) ? vintNUll :pNutrientesClaveIntercambios.id_SubgrupoAlimentos);
                    p.Add("@id_Nutriente",(pNutrientesClaveIntercambios.id_Nutriente== null || pNutrientesClaveIntercambios.id_Nutriente==0) ? vintNUll :pNutrientesClaveIntercambios.id_Nutriente);
                    p.Add("@Aporte",(pNutrientesClaveIntercambios.Aporte== null) ? vintNUll :pNutrientesClaveIntercambios.Aporte);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<NutrientesClaveIntercambios> l = SqlMapper.Query<NutrientesClaveIntercambios>(con, "API.PA_NutrientesClaveIntercambiosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  NutrientesClaveIntercambios  ->" + ex.Message);
				}
			}

			public NutrientesClaveIntercambios Add(NutrientesClaveIntercambios pNutrientesClaveIntercambios)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pNutrientesClaveIntercambios.id==null ? 0 : pNutrientesClaveIntercambios.id);
p.Add("@id_SubgrupoAlimentos",pNutrientesClaveIntercambios.id_SubgrupoAlimentos== null ? 0: pNutrientesClaveIntercambios.id_SubgrupoAlimentos);
p.Add("@id_Nutriente",pNutrientesClaveIntercambios.id_Nutriente== null ? 0: pNutrientesClaveIntercambios.id_Nutriente);
                    p.Add("@Aporte", pNutrientesClaveIntercambios.Aporte);
                    p.Add("@auditoria", pNutrientesClaveIntercambios.auditoria);

                         


                    NutrientesClaveIntercambios o = SqlMapper.QueryFirstOrDefault<NutrientesClaveIntercambios>(con, "API.PA_NutrientesClaveIntercambiosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  NutrientesClaveIntercambios  ->" + ex.Message);
				}
			}

			public NutrientesClaveIntercambios  Update(NutrientesClaveIntercambios pNutrientesClaveIntercambios)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pNutrientesClaveIntercambios.id==null ? 0 : pNutrientesClaveIntercambios.id);
p.Add("@id_SubgrupoAlimentos",pNutrientesClaveIntercambios.id_SubgrupoAlimentos== null ? 0: pNutrientesClaveIntercambios.id_SubgrupoAlimentos);
p.Add("@id_Nutriente",pNutrientesClaveIntercambios.id_Nutriente== null ? 0: pNutrientesClaveIntercambios.id_Nutriente);
                    p.Add("@Aporte", pNutrientesClaveIntercambios.Aporte);
                    p.Add("@auditoria", pNutrientesClaveIntercambios.auditoria);

                         


                    NutrientesClaveIntercambios o = SqlMapper.QueryFirstOrDefault<NutrientesClaveIntercambios>(con, "API.PA_NutrientesClaveIntercambiosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  NutrientesClaveIntercambios  ->" + ex.Message);
				}
			}

			public bool Delete(NutrientesClaveIntercambios pNutrientesClaveIntercambios)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pNutrientesClaveIntercambios.id);
                    p.Add("@auditoria", pNutrientesClaveIntercambios.auditoria);

                

 

					NutrientesClaveIntercambios o = SqlMapper.QueryFirstOrDefault<NutrientesClaveIntercambios>(con, "API.PA_NutrientesClaveIntercambiosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) NutrientesClaveIntercambios  ->" + ex.Message);
				}
			}

		



            public List<NutrientesClaveIntercambios> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<NutrientesClaveIntercambios> NutrientesClaveIntercambiosList = new List<NutrientesClaveIntercambios>();

                    NutrientesClaveIntercambiosList = SqlMapper.Query<NutrientesClaveIntercambios>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return NutrientesClaveIntercambiosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) NutrientesClaveIntercambios  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<NutrientesClaveIntercambios> b)
            {
                DapperPlusManager.Entity<NutrientesClaveIntercambios>().Table("NutrientesClaveIntercambios");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}