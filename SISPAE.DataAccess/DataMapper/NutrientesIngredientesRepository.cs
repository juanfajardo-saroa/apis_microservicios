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
     /// Clase Abstracta para  NutrientesIngredientes
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class NutrientesIngredientesRepository : DataObject , INutrientesIngredientes 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public NutrientesIngredientesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public NutrientesIngredientesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public NutrientesIngredientes GetById(NutrientesIngredientes pNutrientesIngredientes)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pNutrientesIngredientes.id);                                    


    				NutrientesIngredientes o = SqlMapper.QueryFirstOrDefault<NutrientesIngredientes>(con, "API.PA_NutrientesIngredientesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  NutrientesIngredientes  ->" + ex.Message);
				}
			}

			public List<NutrientesIngredientes> GetAll()
			{
				try 
                {
                        List<NutrientesIngredientes> l = SqlMapper.Query<NutrientesIngredientes>(con, "API.PA_NutrientesIngredientesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  NutrientesIngredientes  ->" + ex.Message);
				}
			}

			public List<NutrientesIngredientes> GetAllFull()
			{
				try 
				{
                    List<NutrientesIngredientes> l = SqlMapper.Query<NutrientesIngredientes>(con, "API.PA_NutrientesIngredientesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  NutrientesIngredientes  ->" + ex.Message);
				}
			}
			
			public List<NutrientesIngredientes> GetAllByWithRelation()
			{
				try 
                {
                    List<NutrientesIngredientes> l = SqlMapper.Query<NutrientesIngredientes>(con, "API.PA_NutrientesIngredientesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  NutrientesIngredientes  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<NutrientesIngredientes> GetByFilter(NutrientesIngredientes pNutrientesIngredientes, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pNutrientesIngredientes.id== null || pNutrientesIngredientes.id==0) ? vintNUll :pNutrientesIngredientes.id);
                    p.Add("@ID_Ingrediente",(pNutrientesIngredientes.ID_Ingrediente== null || pNutrientesIngredientes.ID_Ingrediente==0) ? vintNUll :pNutrientesIngredientes.ID_Ingrediente);
                    p.Add("@ID_Nutriente",(pNutrientesIngredientes.ID_Nutriente== null || pNutrientesIngredientes.ID_Nutriente==0) ? vintNUll :pNutrientesIngredientes.ID_Nutriente);
                    p.Add("@Aporte",(pNutrientesIngredientes.Aporte== null) ? vintNUll :pNutrientesIngredientes.Aporte);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<NutrientesIngredientes> l = SqlMapper.Query<NutrientesIngredientes>(con, "API.PA_NutrientesIngredientesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  NutrientesIngredientes  ->" + ex.Message);
				}
			}

			public NutrientesIngredientes Add(NutrientesIngredientes pNutrientesIngredientes)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pNutrientesIngredientes.id==null ? 0 : pNutrientesIngredientes.id);
p.Add("@ID_Ingrediente",pNutrientesIngredientes.ID_Ingrediente==null ? 0 : pNutrientesIngredientes.ID_Ingrediente);
p.Add("@ID_Nutriente",pNutrientesIngredientes.ID_Nutriente==null ? 0 : pNutrientesIngredientes.ID_Nutriente);
                    p.Add("@Aporte", pNutrientesIngredientes.Aporte);
                    p.Add("@auditoria", pNutrientesIngredientes.auditoria);

                         


                    NutrientesIngredientes o = SqlMapper.QueryFirstOrDefault<NutrientesIngredientes>(con, "API.PA_NutrientesIngredientesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  NutrientesIngredientes  ->" + ex.Message);
				}
			}

			public NutrientesIngredientes  Update(NutrientesIngredientes pNutrientesIngredientes)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pNutrientesIngredientes.id==null ? 0 : pNutrientesIngredientes.id);
p.Add("@ID_Ingrediente",pNutrientesIngredientes.ID_Ingrediente==null ? 0 : pNutrientesIngredientes.ID_Ingrediente);
p.Add("@ID_Nutriente",pNutrientesIngredientes.ID_Nutriente==null ? 0 : pNutrientesIngredientes.ID_Nutriente);
                    p.Add("@Aporte", pNutrientesIngredientes.Aporte);
                    p.Add("@auditoria", pNutrientesIngredientes.auditoria);

                         


                    NutrientesIngredientes o = SqlMapper.QueryFirstOrDefault<NutrientesIngredientes>(con, "API.PA_NutrientesIngredientesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  NutrientesIngredientes  ->" + ex.Message);
				}
			}

			public bool Delete(NutrientesIngredientes pNutrientesIngredientes)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pNutrientesIngredientes.id);
                    p.Add("@auditoria", pNutrientesIngredientes.auditoria);

                

 

					NutrientesIngredientes o = SqlMapper.QueryFirstOrDefault<NutrientesIngredientes>(con, "API.PA_NutrientesIngredientesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) NutrientesIngredientes  ->" + ex.Message);
				}
			}

		



            public List<NutrientesIngredientes> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<NutrientesIngredientes> NutrientesIngredientesList = new List<NutrientesIngredientes>();

                    NutrientesIngredientesList = SqlMapper.Query<NutrientesIngredientes>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return NutrientesIngredientesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) NutrientesIngredientes  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<NutrientesIngredientes> b)
            {
                DapperPlusManager.Entity<NutrientesIngredientes>().Table("NutrientesIngredientes");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}