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
     /// Clase Abstracta para  Menus
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MenusRepository : DataObject , IMenus 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MenusRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MenusRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Menus GetById(Menus pMenus)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenus.id);                                    


    				Menus o = SqlMapper.QueryFirstOrDefault<Menus>(con, "API.PA_MenusGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Menus  ->" + ex.Message);
				}
			}

			public List<Menus> GetAll()
			{
				try 
                {
                        List<Menus> l = SqlMapper.Query<Menus>(con, "API.PA_MenusGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Menus  ->" + ex.Message);
				}
			}

			public List<Menus> GetAllFull()
			{
				try 
				{
                    List<Menus> l = SqlMapper.Query<Menus>(con, "API.PA_MenusGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Menus  ->" + ex.Message);
				}
			}
			
			public List<Menus> GetAllByWithRelation()
			{
				try 
                {
                    List<Menus> l = SqlMapper.Query<Menus>(con, "API.PA_MenusGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Menus  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Menus> GetByFilter(Menus pMenus, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMenus.id== null || pMenus.id==0) ? vintNUll :pMenus.id);
                    p.Add("@ID_TipoMenu",(pMenus.ID_TipoMenu== null || pMenus.ID_TipoMenu==0) ? vintNUll :pMenus.ID_TipoMenu);
                    p.Add("@ID_TipoComplemento",(pMenus.ID_TipoComplemento== null || pMenus.ID_TipoComplemento==0) ? vintNUll :pMenus.ID_TipoComplemento);
                    p.Add("@ID_ETC",(pMenus.ID_ETC== null || pMenus.ID_ETC==0) ? vintNUll :pMenus.ID_ETC);
                    p.Add("@TotalCostoMenu",(pMenus.TotalCostoMenu== null) ? vintNUll :pMenus.TotalCostoMenu);
                    p.Add("@CostoTransporte",(pMenus.CostoTransporte== null) ? vintNUll :pMenus.CostoTransporte);
                    p.Add("@CostoAlimentos",(pMenus.CostoAlimentos== null) ? vintNUll :pMenus.CostoAlimentos);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Menus> l = SqlMapper.Query<Menus>(con, "API.PA_MenusGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Menus  ->" + ex.Message);
				}
			}

			public Menus Add(Menus pMenus)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMenus.id==null ? 0 : pMenus.id);
p.Add("@ID_TipoMenu",pMenus.ID_TipoMenu==null ? 0 : pMenus.ID_TipoMenu);
p.Add("@ID_TipoComplemento",pMenus.ID_TipoComplemento==null ? 0 : pMenus.ID_TipoComplemento);
p.Add("@ID_ETC",pMenus.ID_ETC==null ? 0 : pMenus.ID_ETC);
                    p.Add("@TotalCostoMenu", pMenus.TotalCostoMenu);
                    p.Add("@CostoTransporte", pMenus.CostoTransporte);
                    p.Add("@CostoAlimentos", pMenus.CostoAlimentos);
                    p.Add("@auditoria", pMenus.auditoria);

                         


                    Menus o = SqlMapper.QueryFirstOrDefault<Menus>(con, "API.PA_MenusAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Menus  ->" + ex.Message);
				}
			}

			public Menus  Update(Menus pMenus)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMenus.id==null ? 0 : pMenus.id);
p.Add("@ID_TipoMenu",pMenus.ID_TipoMenu==null ? 0 : pMenus.ID_TipoMenu);
p.Add("@ID_TipoComplemento",pMenus.ID_TipoComplemento==null ? 0 : pMenus.ID_TipoComplemento);
p.Add("@ID_ETC",pMenus.ID_ETC==null ? 0 : pMenus.ID_ETC);
                    p.Add("@TotalCostoMenu", pMenus.TotalCostoMenu);
                    p.Add("@CostoTransporte", pMenus.CostoTransporte);
                    p.Add("@CostoAlimentos", pMenus.CostoAlimentos);
                    p.Add("@auditoria", pMenus.auditoria);

                         


                    Menus o = SqlMapper.QueryFirstOrDefault<Menus>(con, "API.PA_MenusUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Menus  ->" + ex.Message);
				}
			}

			public bool Delete(Menus pMenus)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenus.id);
                    p.Add("@auditoria", pMenus.auditoria);

                

 

					Menus o = SqlMapper.QueryFirstOrDefault<Menus>(con, "API.PA_MenusDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Menus  ->" + ex.Message);
				}
			}

		



            public List<Menus> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Menus> MenusList = new List<Menus>();

                    MenusList = SqlMapper.Query<Menus>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MenusList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Menus  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Menus> b)
            {
                DapperPlusManager.Entity<Menus>().Table("Menus");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}