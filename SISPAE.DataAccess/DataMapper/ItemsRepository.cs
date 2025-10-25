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
     /// Clase Abstracta para  Items
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ItemsRepository : DataObject , IItems 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ItemsRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ItemsRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Items GetById(Items pItems)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pItems.id);                                    


    				Items o = SqlMapper.QueryFirstOrDefault<Items>(con, "API.PA_ItemsGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Items  ->" + ex.Message);
				}
			}

			public List<Items> GetAll()
			{
				try 
                {
                        List<Items> l = SqlMapper.Query<Items>(con, "API.PA_ItemsGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Items  ->" + ex.Message);
				}
			}

			public List<Items> GetAllFull()
			{
				try 
				{
                    List<Items> l = SqlMapper.Query<Items>(con, "API.PA_ItemsGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Items  ->" + ex.Message);
				}
			}
			
			public List<Items> GetAllByWithRelation()
			{
				try 
                {
                    List<Items> l = SqlMapper.Query<Items>(con, "API.PA_ItemsGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Items  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Items> GetByFilter(Items pItems, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pItems.id== null || pItems.id==0) ? vintNUll :pItems.id);
                    p.Add("@ID_TipoItems",(pItems.ID_TipoItems== null || pItems.ID_TipoItems==0) ? vintNUll :pItems.ID_TipoItems);
                    p.Add("@ID_PlanAlistamiento",(pItems.ID_PlanAlistamiento== null || pItems.ID_PlanAlistamiento==0) ? vintNUll :pItems.ID_PlanAlistamiento);
                    p.Add("@ID_DocumentoPA",(pItems.ID_DocumentoPA== null || pItems.ID_DocumentoPA==0) ? vintNUll :pItems.ID_DocumentoPA);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Items> l = SqlMapper.Query<Items>(con, "API.PA_ItemsGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Items  ->" + ex.Message);
				}
			}

			public Items Add(Items pItems)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pItems.id==null ? 0 : pItems.id);
p.Add("@ID_TipoItems",pItems.ID_TipoItems==null ? 0 : pItems.ID_TipoItems);
p.Add("@ID_PlanAlistamiento",pItems.ID_PlanAlistamiento==null ? 0 : pItems.ID_PlanAlistamiento);
p.Add("@ID_DocumentoPA",pItems.ID_DocumentoPA==null ? 0 : pItems.ID_DocumentoPA);
                    p.Add("@auditoria", pItems.auditoria);

                         


                    Items o = SqlMapper.QueryFirstOrDefault<Items>(con, "API.PA_ItemsAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Items  ->" + ex.Message);
				}
			}

			public Items  Update(Items pItems)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pItems.id==null ? 0 : pItems.id);
p.Add("@ID_TipoItems",pItems.ID_TipoItems==null ? 0 : pItems.ID_TipoItems);
p.Add("@ID_PlanAlistamiento",pItems.ID_PlanAlistamiento==null ? 0 : pItems.ID_PlanAlistamiento);
p.Add("@ID_DocumentoPA",pItems.ID_DocumentoPA==null ? 0 : pItems.ID_DocumentoPA);
                    p.Add("@auditoria", pItems.auditoria);

                         


                    Items o = SqlMapper.QueryFirstOrDefault<Items>(con, "API.PA_ItemsUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Items  ->" + ex.Message);
				}
			}

			public bool Delete(Items pItems)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pItems.id);
                    p.Add("@auditoria", pItems.auditoria);

                

 

					Items o = SqlMapper.QueryFirstOrDefault<Items>(con, "API.PA_ItemsDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Items  ->" + ex.Message);
				}
			}

		



            public List<Items> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Items> ItemsList = new List<Items>();

                    ItemsList = SqlMapper.Query<Items>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ItemsList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Items  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Items> b)
            {
                DapperPlusManager.Entity<Items>().Table("Items");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}