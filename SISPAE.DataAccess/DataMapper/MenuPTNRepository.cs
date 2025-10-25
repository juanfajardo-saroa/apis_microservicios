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
     /// Clase Abstracta para  MenuPTN
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MenuPTNRepository : DataObject , IMenuPTN 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MenuPTNRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MenuPTNRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MenuPTN GetById(MenuPTN pMenuPTN)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenuPTN.id);                                    


    				MenuPTN o = SqlMapper.QueryFirstOrDefault<MenuPTN>(con, "API.PA_MenuPTNGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MenuPTN  ->" + ex.Message);
				}
			}

			public List<MenuPTN> GetAll()
			{
				try 
                {
                        List<MenuPTN> l = SqlMapper.Query<MenuPTN>(con, "API.PA_MenuPTNGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MenuPTN  ->" + ex.Message);
				}
			}

			public List<MenuPTN> GetAllFull()
			{
				try 
				{
                    List<MenuPTN> l = SqlMapper.Query<MenuPTN>(con, "API.PA_MenuPTNGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MenuPTN  ->" + ex.Message);
				}
			}
			
			public List<MenuPTN> GetAllByWithRelation()
			{
				try 
                {
                    List<MenuPTN> l = SqlMapper.Query<MenuPTN>(con, "API.PA_MenuPTNGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MenuPTN  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MenuPTN> GetByFilter(MenuPTN pMenuPTN, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();    

                                        p.Add("@id",(pMenuPTN.id== null || pMenuPTN.id==0) ? vintNUll :pMenuPTN.id);
                    p.Add("@ID_Semana",(pMenuPTN.ID_Semana== null || pMenuPTN.ID_Semana==0) ? vintNUll :pMenuPTN.ID_Semana);
                    p.Add("@ID_TipoNivelEducativo",(pMenuPTN.ID_TipoNivelEducativo== null || pMenuPTN.ID_TipoNivelEducativo==0) ? vintNUll :pMenuPTN.ID_TipoNivelEducativo);
                    p.Add("@NumeroDia",(pMenuPTN.NumeroDia== null) ? vintNUll :pMenuPTN.NumeroDia);
                    p.Add("@Nombre",(pMenuPTN.Nombre== null) ? vintNUll :pMenuPTN.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MenuPTN> l = SqlMapper.Query<MenuPTN>(con, "API.PA_MenuPTNGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MenuPTN  ->" + ex.Message);
				}
			}

			public MenuPTN Add(MenuPTN pMenuPTN)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMenuPTN.id==null ? 0 : pMenuPTN.id);
p.Add("@ID_Semana",pMenuPTN.ID_Semana==null ? 0 : pMenuPTN.ID_Semana);
p.Add("@ID_TipoNivelEducativo",pMenuPTN.ID_TipoNivelEducativo==null ? vintNUll : pMenuPTN.ID_TipoNivelEducativo);
p.Add("@NumeroDia",pMenuPTN.NumeroDia==null ? 0 : pMenuPTN.NumeroDia);
                    p.Add("@Nombre", pMenuPTN.Nombre);
                    p.Add("@auditoria", pMenuPTN.auditoria);

                         


                    MenuPTN o = SqlMapper.QueryFirstOrDefault<MenuPTN>(con, "API.PA_MenuPTNAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MenuPTN  ->" + ex.Message);
				}
			}

			public MenuPTN  Update(MenuPTN pMenuPTN)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMenuPTN.id==null ? 0 : pMenuPTN.id);
p.Add("@ID_Semana",pMenuPTN.ID_Semana==null ? 0 : pMenuPTN.ID_Semana);
p.Add("@ID_TipoNivelEducativo",pMenuPTN.ID_TipoNivelEducativo==null ? vintNUll : pMenuPTN.ID_TipoNivelEducativo);
p.Add("@NumeroDia",pMenuPTN.NumeroDia==null ? 0 : pMenuPTN.NumeroDia);
                    p.Add("@Nombre", pMenuPTN.Nombre);
                    p.Add("@auditoria", pMenuPTN.auditoria);

                         


                    MenuPTN o = SqlMapper.QueryFirstOrDefault<MenuPTN>(con, "API.PA_MenuPTNUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MenuPTN  ->" + ex.Message);
				}
			}

			public bool Delete(MenuPTN pMenuPTN)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMenuPTN.id);
                    p.Add("@auditoria", pMenuPTN.auditoria);

                

 

					MenuPTN o = SqlMapper.QueryFirstOrDefault<MenuPTN>(con, "API.PA_MenuPTNDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MenuPTN  ->" + ex.Message);
				}
			}

		



            public List<MenuPTN> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MenuPTN> MenuPTNList = new List<MenuPTN>();

                    MenuPTNList = SqlMapper.Query<MenuPTN>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MenuPTNList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MenuPTN  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MenuPTN> b)
            {
                DapperPlusManager.Entity<MenuPTN>().Table("MenuPTN");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}