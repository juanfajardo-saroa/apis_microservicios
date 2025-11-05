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
     /// Clase Abstracta para  AlimentosPlan
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AlimentosPlanRepository : DataObject , IAlimentosPlan 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AlimentosPlanRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AlimentosPlanRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AlimentosPlan GetById(AlimentosPlan pAlimentosPlan)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@ID",pAlimentosPlan.ID);                                    


    				AlimentosPlan o = SqlMapper.QueryFirstOrDefault<AlimentosPlan>(con, "API.PA_AlimentosPlanGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AlimentosPlan  ->" + ex.Message);
				}
			}

			public List<AlimentosPlan> GetAll()
			{
				try 
                {
                        List<AlimentosPlan> l = SqlMapper.Query<AlimentosPlan>(con, "API.PA_AlimentosPlanGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AlimentosPlan  ->" + ex.Message);
				}
			}

			public List<AlimentosPlan> GetAllFull()
			{
				try 
				{
                    List<AlimentosPlan> l = SqlMapper.Query<AlimentosPlan>(con, "API.PA_AlimentosPlanGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AlimentosPlan  ->" + ex.Message);
				}
			}
			
			public List<AlimentosPlan> GetAllByWithRelation()
			{
				try 
                {
                    List<AlimentosPlan> l = SqlMapper.Query<AlimentosPlan>(con, "API.PA_AlimentosPlanGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AlimentosPlan  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AlimentosPlan> GetByFilter(AlimentosPlan pAlimentosPlan, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ID",(pAlimentosPlan.ID== null || pAlimentosPlan.ID==0) ? vintNUll :pAlimentosPlan.ID);
                    p.Add("@ID_MenuPlanAlistamiento",(pAlimentosPlan.ID_MenuPlanAlistamiento== null || pAlimentosPlan.ID_MenuPlanAlistamiento==0) ? vintNUll :pAlimentosPlan.ID_MenuPlanAlistamiento);
                    p.Add("@ID_TipoComponente",(pAlimentosPlan.ID_TipoComponente== null || pAlimentosPlan.ID_TipoComponente==0) ? vintNUll :pAlimentosPlan.ID_TipoComponente);
                    p.Add("@ID_Preparacion",(pAlimentosPlan.ID_Preparacion== null || pAlimentosPlan.ID_Preparacion==0) ? vintNUll :pAlimentosPlan.ID_Preparacion);
                    p.Add("@ID_Producto",(pAlimentosPlan.ID_Producto== null || pAlimentosPlan.ID_Producto==0) ? vintNUll :pAlimentosPlan.ID_Producto);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AlimentosPlan> l = SqlMapper.Query<AlimentosPlan>(con, "API.PA_AlimentosPlanGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AlimentosPlan  ->" + ex.Message);
				}
			}

			public AlimentosPlan Add(AlimentosPlan pAlimentosPlan)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ID",pAlimentosPlan.ID==null ? 0 : pAlimentosPlan.ID);
p.Add("@ID_MenuPlanAlistamiento",pAlimentosPlan.ID_MenuPlanAlistamiento==null ? 0 : pAlimentosPlan.ID_MenuPlanAlistamiento);
p.Add("@ID_TipoComponente",pAlimentosPlan.ID_TipoComponente==null ? 0 : pAlimentosPlan.ID_TipoComponente);
p.Add("@ID_Preparacion",pAlimentosPlan.ID_Preparacion==null ? 0 : pAlimentosPlan.ID_Preparacion);
p.Add("@ID_Producto",pAlimentosPlan.ID_Producto==null ? 0 : pAlimentosPlan.ID_Producto);
                    p.Add("@auditoria", pAlimentosPlan.auditoria);

                         


                    AlimentosPlan o = SqlMapper.QueryFirstOrDefault<AlimentosPlan>(con, "API.PA_AlimentosPlanAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AlimentosPlan  ->" + ex.Message);
				}
			}

			public AlimentosPlan  Update(AlimentosPlan pAlimentosPlan)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ID",pAlimentosPlan.ID==null ? 0 : pAlimentosPlan.ID);
p.Add("@ID_MenuPlanAlistamiento",pAlimentosPlan.ID_MenuPlanAlistamiento==null ? 0 : pAlimentosPlan.ID_MenuPlanAlistamiento);
p.Add("@ID_TipoComponente",pAlimentosPlan.ID_TipoComponente==null ? 0 : pAlimentosPlan.ID_TipoComponente);
p.Add("@ID_Preparacion",pAlimentosPlan.ID_Preparacion==null ? 0 : pAlimentosPlan.ID_Preparacion);
p.Add("@ID_Producto",pAlimentosPlan.ID_Producto==null ? 0 : pAlimentosPlan.ID_Producto);
                    p.Add("@auditoria", pAlimentosPlan.auditoria);

                         


                    AlimentosPlan o = SqlMapper.QueryFirstOrDefault<AlimentosPlan>(con, "API.PA_AlimentosPlanUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AlimentosPlan  ->" + ex.Message);
				}
			}

			public bool Delete(AlimentosPlan pAlimentosPlan)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@ID",pAlimentosPlan.ID);
                    p.Add("@auditoria", pAlimentosPlan.auditoria);

                

 

					AlimentosPlan o = SqlMapper.QueryFirstOrDefault<AlimentosPlan>(con, "API.PA_AlimentosPlanDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AlimentosPlan  ->" + ex.Message);
				}
			}

		



            public List<AlimentosPlan> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AlimentosPlan> AlimentosPlanList = new List<AlimentosPlan>();

                    AlimentosPlanList = SqlMapper.Query<AlimentosPlan>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AlimentosPlanList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AlimentosPlan  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AlimentosPlan> b)
            {
                DapperPlusManager.Entity<AlimentosPlan>().Table("AlimentosPlan");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}