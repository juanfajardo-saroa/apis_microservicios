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
     /// Clase Abstracta para  AporteMenus
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AporteMenusRepository : DataObject , IAporteMenus 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AporteMenusRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AporteMenusRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AporteMenus GetById(AporteMenus pAporteMenus)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAporteMenus.id);                                    


    				AporteMenus o = SqlMapper.QueryFirstOrDefault<AporteMenus>(con, "API.PA_AporteMenusGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AporteMenus  ->" + ex.Message);
				}
			}

			public List<AporteMenus> GetAll()
			{
				try 
                {
                        List<AporteMenus> l = SqlMapper.Query<AporteMenus>(con, "API.PA_AporteMenusGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AporteMenus  ->" + ex.Message);
				}
			}

			public List<AporteMenus> GetAllFull()
			{
				try 
				{
                    List<AporteMenus> l = SqlMapper.Query<AporteMenus>(con, "API.PA_AporteMenusGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AporteMenus  ->" + ex.Message);
				}
			}
			
			public List<AporteMenus> GetAllByWithRelation()
			{
				try 
                {
                    List<AporteMenus> l = SqlMapper.Query<AporteMenus>(con, "API.PA_AporteMenusGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AporteMenus  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AporteMenus> GetByFilter(AporteMenus pAporteMenus, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAporteMenus.id== null || pAporteMenus.id==0) ? vintNUll :pAporteMenus.id);
                    p.Add("@ID_Menu",(pAporteMenus.ID_Menu== null || pAporteMenus.ID_Menu==0) ? vintNUll :pAporteMenus.ID_Menu);
                    p.Add("@ID_Nutriente",(pAporteMenus.ID_Nutriente== null || pAporteMenus.ID_Nutriente==0) ? vintNUll :pAporteMenus.ID_Nutriente);
                    p.Add("@AporteEstimado",(pAporteMenus.AporteEstimado== null) ? vintNUll :pAporteMenus.AporteEstimado);
                    p.Add("@PorcentajeAdecuacion",(pAporteMenus.PorcentajeAdecuacion== null) ? vintNUll :pAporteMenus.PorcentajeAdecuacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AporteMenus> l = SqlMapper.Query<AporteMenus>(con, "API.PA_AporteMenusGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AporteMenus  ->" + ex.Message);
				}
			}

			public AporteMenus Add(AporteMenus pAporteMenus)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAporteMenus.id==null ? 0 : pAporteMenus.id);
p.Add("@ID_Menu",pAporteMenus.ID_Menu==null ? 0 : pAporteMenus.ID_Menu);
p.Add("@ID_Nutriente",pAporteMenus.ID_Nutriente==null ? 0 : pAporteMenus.ID_Nutriente);
                    p.Add("@AporteEstimado", pAporteMenus.AporteEstimado);
                    p.Add("@PorcentajeAdecuacion", pAporteMenus.PorcentajeAdecuacion);
                    p.Add("@auditoria", pAporteMenus.auditoria);

                         


                    AporteMenus o = SqlMapper.QueryFirstOrDefault<AporteMenus>(con, "API.PA_AporteMenusAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AporteMenus  ->" + ex.Message);
				}
			}

			public AporteMenus  Update(AporteMenus pAporteMenus)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAporteMenus.id==null ? 0 : pAporteMenus.id);
p.Add("@ID_Menu",pAporteMenus.ID_Menu==null ? 0 : pAporteMenus.ID_Menu);
p.Add("@ID_Nutriente",pAporteMenus.ID_Nutriente==null ? 0 : pAporteMenus.ID_Nutriente);
                    p.Add("@AporteEstimado", pAporteMenus.AporteEstimado);
                    p.Add("@PorcentajeAdecuacion", pAporteMenus.PorcentajeAdecuacion);
                    p.Add("@auditoria", pAporteMenus.auditoria);

                         


                    AporteMenus o = SqlMapper.QueryFirstOrDefault<AporteMenus>(con, "API.PA_AporteMenusUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AporteMenus  ->" + ex.Message);
				}
			}

			public bool Delete(AporteMenus pAporteMenus)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAporteMenus.id);
                    p.Add("@auditoria", pAporteMenus.auditoria);

                

 

					AporteMenus o = SqlMapper.QueryFirstOrDefault<AporteMenus>(con, "API.PA_AporteMenusDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AporteMenus  ->" + ex.Message);
				}
			}

		



            public List<AporteMenus> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AporteMenus> AporteMenusList = new List<AporteMenus>();

                    AporteMenusList = SqlMapper.Query<AporteMenus>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AporteMenusList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AporteMenus  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AporteMenus> b)
            {
                DapperPlusManager.Entity<AporteMenus>().Table("AporteMenus");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}