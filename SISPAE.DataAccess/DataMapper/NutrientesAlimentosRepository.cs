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
     /// Clase Abstracta para  NutrientesAlimentos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class NutrientesAlimentosRepository : DataObject , INutrientesAlimentos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public NutrientesAlimentosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public NutrientesAlimentosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public NutrientesAlimentos GetById(NutrientesAlimentos pNutrientesAlimentos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pNutrientesAlimentos.id);                                    


    				NutrientesAlimentos o = SqlMapper.QueryFirstOrDefault<NutrientesAlimentos>(con, "API.PA_NutrientesAlimentosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  NutrientesAlimentos  ->" + ex.Message);
				}
			}

			public List<NutrientesAlimentos> GetAll()
			{
				try 
                {
                        List<NutrientesAlimentos> l = SqlMapper.Query<NutrientesAlimentos>(con, "API.PA_NutrientesAlimentosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  NutrientesAlimentos  ->" + ex.Message);
				}
			}

			public List<NutrientesAlimentos> GetAllFull()
			{
				try 
				{
                    List<NutrientesAlimentos> l = SqlMapper.Query<NutrientesAlimentos>(con, "API.PA_NutrientesAlimentosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  NutrientesAlimentos  ->" + ex.Message);
				}
			}
			
			public List<NutrientesAlimentos> GetAllByWithRelation()
			{
				try 
                {
                    List<NutrientesAlimentos> l = SqlMapper.Query<NutrientesAlimentos>(con, "API.PA_NutrientesAlimentosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  NutrientesAlimentos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<NutrientesAlimentos> GetByFilter(NutrientesAlimentos pNutrientesAlimentos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pNutrientesAlimentos.id== null || pNutrientesAlimentos.id==0) ? vintNUll :pNutrientesAlimentos.id);
                    p.Add("@ID_Nutriente",(pNutrientesAlimentos.ID_Nutriente== null || pNutrientesAlimentos.ID_Nutriente==0) ? vintNUll :pNutrientesAlimentos.ID_Nutriente);
                    p.Add("@ID_AlimentosICBF",(pNutrientesAlimentos.ID_AlimentosICBF== null || pNutrientesAlimentos.ID_AlimentosICBF==0) ? vintNUll :pNutrientesAlimentos.ID_AlimentosICBF);
                    p.Add("@Aporte",(pNutrientesAlimentos.Aporte== null) ? vintNUll :pNutrientesAlimentos.Aporte);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<NutrientesAlimentos> l = SqlMapper.Query<NutrientesAlimentos>(con, "API.PA_NutrientesAlimentosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  NutrientesAlimentos  ->" + ex.Message);
				}
			}

			public NutrientesAlimentos Add(NutrientesAlimentos pNutrientesAlimentos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pNutrientesAlimentos.id==null ? 0 : pNutrientesAlimentos.id);
p.Add("@ID_Nutriente",pNutrientesAlimentos.ID_Nutriente==null ? 0 : pNutrientesAlimentos.ID_Nutriente);
p.Add("@ID_AlimentosICBF",pNutrientesAlimentos.ID_AlimentosICBF==null ? 0 : pNutrientesAlimentos.ID_AlimentosICBF);
                    p.Add("@Aporte", pNutrientesAlimentos.Aporte);
                    p.Add("@auditoria", pNutrientesAlimentos.auditoria);

                         


                    NutrientesAlimentos o = SqlMapper.QueryFirstOrDefault<NutrientesAlimentos>(con, "API.PA_NutrientesAlimentosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  NutrientesAlimentos  ->" + ex.Message);
				}
			}

			public NutrientesAlimentos  Update(NutrientesAlimentos pNutrientesAlimentos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pNutrientesAlimentos.id==null ? 0 : pNutrientesAlimentos.id);
p.Add("@ID_Nutriente",pNutrientesAlimentos.ID_Nutriente==null ? 0 : pNutrientesAlimentos.ID_Nutriente);
p.Add("@ID_AlimentosICBF",pNutrientesAlimentos.ID_AlimentosICBF==null ? 0 : pNutrientesAlimentos.ID_AlimentosICBF);
                    p.Add("@Aporte", pNutrientesAlimentos.Aporte);
                    p.Add("@auditoria", pNutrientesAlimentos.auditoria);

                         


                    NutrientesAlimentos o = SqlMapper.QueryFirstOrDefault<NutrientesAlimentos>(con, "API.PA_NutrientesAlimentosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  NutrientesAlimentos  ->" + ex.Message);
				}
			}

			public bool Delete(NutrientesAlimentos pNutrientesAlimentos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pNutrientesAlimentos.id);
                    p.Add("@auditoria", pNutrientesAlimentos.auditoria);

                

 

					NutrientesAlimentos o = SqlMapper.QueryFirstOrDefault<NutrientesAlimentos>(con, "API.PA_NutrientesAlimentosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) NutrientesAlimentos  ->" + ex.Message);
				}
			}

		



            public List<NutrientesAlimentos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<NutrientesAlimentos> NutrientesAlimentosList = new List<NutrientesAlimentos>();

                    NutrientesAlimentosList = SqlMapper.Query<NutrientesAlimentos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return NutrientesAlimentosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) NutrientesAlimentos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<NutrientesAlimentos> b)
            {
                DapperPlusManager.Entity<NutrientesAlimentos>().Table("NutrientesAlimentos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}