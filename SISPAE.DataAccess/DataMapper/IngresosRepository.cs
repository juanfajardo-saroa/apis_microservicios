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
     /// Clase Abstracta para  Ingresos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class IngresosRepository : DataObject , IIngresos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public IngresosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public IngresosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Ingresos GetById(Ingresos pIngresos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pIngresos.id);                                    


    				Ingresos o = SqlMapper.QueryFirstOrDefault<Ingresos>(con, "API.PA_IngresosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Ingresos  ->" + ex.Message);
				}
			}

			public List<Ingresos> GetAll()
			{
				try 
                {
                        List<Ingresos> l = SqlMapper.Query<Ingresos>(con, "API.PA_IngresosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Ingresos  ->" + ex.Message);
				}
			}

			public List<Ingresos> GetAllFull()
			{
				try 
				{
                    List<Ingresos> l = SqlMapper.Query<Ingresos>(con, "API.PA_IngresosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Ingresos  ->" + ex.Message);
				}
			}
			
			public List<Ingresos> GetAllByWithRelation()
			{
				try 
                {
                    List<Ingresos> l = SqlMapper.Query<Ingresos>(con, "API.PA_IngresosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Ingresos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Ingresos> GetByFilter(Ingresos pIngresos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pIngresos.id== null || pIngresos.id==0) ? vintNUll :pIngresos.id);
                    p.Add("@ID_ETC",(pIngresos.ID_ETC== null || pIngresos.ID_ETC==0) ? vintNUll :pIngresos.ID_ETC);
                    p.Add("@ID_TipoIngreso",(pIngresos.ID_TipoIngreso== null || pIngresos.ID_TipoIngreso==0) ? vintNUll :pIngresos.ID_TipoIngreso);
                    p.Add("@ID_FuenteIngreso",(pIngresos.ID_FuenteIngreso== null || pIngresos.ID_FuenteIngreso==0) ? vintNUll :pIngresos.ID_FuenteIngreso);
                    p.Add("@ID_TipoModeloOperacion",(pIngresos.ID_TipoModeloOperacion== null || pIngresos.ID_TipoModeloOperacion==0) ? vintNUll :pIngresos.ID_TipoModeloOperacion);
                    p.Add("@ID_Vigencia",(pIngresos.ID_Vigencia== null || pIngresos.ID_Vigencia==0) ? vintNUll :pIngresos.ID_Vigencia);
                    p.Add("@Valor",(pIngresos.Valor== null) ? vintNUll :pIngresos.Valor);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Ingresos> l = SqlMapper.Query<Ingresos>(con, "API.PA_IngresosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Ingresos  ->" + ex.Message);
				}
			}

			public Ingresos Add(Ingresos pIngresos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pIngresos.id==null ? 0 : pIngresos.id);
p.Add("@ID_ETC",pIngresos.ID_ETC==null ? 0 : pIngresos.ID_ETC);
p.Add("@ID_TipoIngreso",pIngresos.ID_TipoIngreso==null ? 0 : pIngresos.ID_TipoIngreso);
p.Add("@ID_FuenteIngreso",pIngresos.ID_FuenteIngreso==null ? 0 : pIngresos.ID_FuenteIngreso);
p.Add("@ID_TipoModeloOperacion",pIngresos.ID_TipoModeloOperacion==null ? 0 : pIngresos.ID_TipoModeloOperacion);
p.Add("@ID_Vigencia",pIngresos.ID_Vigencia==null ? 0 : pIngresos.ID_Vigencia);
                    p.Add("@Valor", pIngresos.Valor);
                    p.Add("@auditoria", pIngresos.auditoria);

                         


                    Ingresos o = SqlMapper.QueryFirstOrDefault<Ingresos>(con, "API.PA_IngresosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Ingresos  ->" + ex.Message);
				}
			}

			public Ingresos  Update(Ingresos pIngresos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pIngresos.id==null ? 0 : pIngresos.id);
p.Add("@ID_ETC",pIngresos.ID_ETC==null ? 0 : pIngresos.ID_ETC);
p.Add("@ID_TipoIngreso",pIngresos.ID_TipoIngreso==null ? 0 : pIngresos.ID_TipoIngreso);
p.Add("@ID_FuenteIngreso",pIngresos.ID_FuenteIngreso==null ? 0 : pIngresos.ID_FuenteIngreso);
p.Add("@ID_TipoModeloOperacion",pIngresos.ID_TipoModeloOperacion==null ? 0 : pIngresos.ID_TipoModeloOperacion);
p.Add("@ID_Vigencia",pIngresos.ID_Vigencia==null ? 0 : pIngresos.ID_Vigencia);
                    p.Add("@Valor", pIngresos.Valor);
                    p.Add("@auditoria", pIngresos.auditoria);

                         


                    Ingresos o = SqlMapper.QueryFirstOrDefault<Ingresos>(con, "API.PA_IngresosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Ingresos  ->" + ex.Message);
				}
			}

			public bool Delete(Ingresos pIngresos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pIngresos.id);
                    p.Add("@auditoria", pIngresos.auditoria);

                

 

					Ingresos o = SqlMapper.QueryFirstOrDefault<Ingresos>(con, "API.PA_IngresosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Ingresos  ->" + ex.Message);
				}
			}

		



            public List<Ingresos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Ingresos> IngresosList = new List<Ingresos>();

                    IngresosList = SqlMapper.Query<Ingresos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return IngresosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Ingresos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Ingresos> b)
            {
                DapperPlusManager.Entity<Ingresos>().Table("Ingresos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}