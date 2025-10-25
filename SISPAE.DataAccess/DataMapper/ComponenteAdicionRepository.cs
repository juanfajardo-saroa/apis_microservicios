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
     /// Clase Abstracta para  ComponenteAdicion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ComponenteAdicionRepository : DataObject , IComponenteAdicion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ComponenteAdicionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ComponenteAdicionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ComponenteAdicion GetById(ComponenteAdicion pComponenteAdicion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pComponenteAdicion.id);                                    


    				ComponenteAdicion o = SqlMapper.QueryFirstOrDefault<ComponenteAdicion>(con, "API.PA_ComponenteAdicionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ComponenteAdicion  ->" + ex.Message);
				}
			}

			public List<ComponenteAdicion> GetAll()
			{
				try 
                {
                        List<ComponenteAdicion> l = SqlMapper.Query<ComponenteAdicion>(con, "API.PA_ComponenteAdicionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ComponenteAdicion  ->" + ex.Message);
				}
			}

			public List<ComponenteAdicion> GetAllFull()
			{
				try 
				{
                    List<ComponenteAdicion> l = SqlMapper.Query<ComponenteAdicion>(con, "API.PA_ComponenteAdicionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ComponenteAdicion  ->" + ex.Message);
				}
			}
			
			public List<ComponenteAdicion> GetAllByWithRelation()
			{
				try 
                {
                    List<ComponenteAdicion> l = SqlMapper.Query<ComponenteAdicion>(con, "API.PA_ComponenteAdicionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ComponenteAdicion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ComponenteAdicion> GetByFilter(ComponenteAdicion pComponenteAdicion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pComponenteAdicion.id== null || pComponenteAdicion.id==0) ? vintNUll :pComponenteAdicion.id);
                    p.Add("@ID_Adicion",(pComponenteAdicion.ID_Adicion== null || pComponenteAdicion.ID_Adicion==0) ? vintNUll :pComponenteAdicion.ID_Adicion);
                    p.Add("@ID_AlimentoSIPSA",(pComponenteAdicion.ID_AlimentoSIPSA== null || pComponenteAdicion.ID_AlimentoSIPSA==0) ? vintNUll :pComponenteAdicion.ID_AlimentoSIPSA);
                    p.Add("@ID_AlimentoNoSIPSA",(pComponenteAdicion.ID_AlimentoNoSIPSA== null || pComponenteAdicion.ID_AlimentoNoSIPSA==0) ? vintNUll :pComponenteAdicion.ID_AlimentoNoSIPSA);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ComponenteAdicion> l = SqlMapper.Query<ComponenteAdicion>(con, "API.PA_ComponenteAdicionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ComponenteAdicion  ->" + ex.Message);
				}
			}

			public ComponenteAdicion Add(ComponenteAdicion pComponenteAdicion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pComponenteAdicion.id==null ? 0 : pComponenteAdicion.id);
p.Add("@ID_Adicion",pComponenteAdicion.ID_Adicion==null ? 0 : pComponenteAdicion.ID_Adicion);
p.Add("@ID_AlimentoSIPSA",pComponenteAdicion.ID_AlimentoSIPSA==null ? 0 : pComponenteAdicion.ID_AlimentoSIPSA);
p.Add("@ID_AlimentoNoSIPSA",pComponenteAdicion.ID_AlimentoNoSIPSA==null ? 0 : pComponenteAdicion.ID_AlimentoNoSIPSA);
                    p.Add("@auditoria", pComponenteAdicion.auditoria);

                         


                    ComponenteAdicion o = SqlMapper.QueryFirstOrDefault<ComponenteAdicion>(con, "API.PA_ComponenteAdicionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ComponenteAdicion  ->" + ex.Message);
				}
			}

			public ComponenteAdicion  Update(ComponenteAdicion pComponenteAdicion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pComponenteAdicion.id==null ? 0 : pComponenteAdicion.id);
p.Add("@ID_Adicion",pComponenteAdicion.ID_Adicion==null ? 0 : pComponenteAdicion.ID_Adicion);
p.Add("@ID_AlimentoSIPSA",pComponenteAdicion.ID_AlimentoSIPSA==null ? 0 : pComponenteAdicion.ID_AlimentoSIPSA);
p.Add("@ID_AlimentoNoSIPSA",pComponenteAdicion.ID_AlimentoNoSIPSA==null ? 0 : pComponenteAdicion.ID_AlimentoNoSIPSA);
                    p.Add("@auditoria", pComponenteAdicion.auditoria);

                         


                    ComponenteAdicion o = SqlMapper.QueryFirstOrDefault<ComponenteAdicion>(con, "API.PA_ComponenteAdicionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ComponenteAdicion  ->" + ex.Message);
				}
			}

			public bool Delete(ComponenteAdicion pComponenteAdicion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pComponenteAdicion.id);
                    p.Add("@auditoria", pComponenteAdicion.auditoria);

                

 

					ComponenteAdicion o = SqlMapper.QueryFirstOrDefault<ComponenteAdicion>(con, "API.PA_ComponenteAdicionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ComponenteAdicion  ->" + ex.Message);
				}
			}

		



            public List<ComponenteAdicion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ComponenteAdicion> ComponenteAdicionList = new List<ComponenteAdicion>();

                    ComponenteAdicionList = SqlMapper.Query<ComponenteAdicion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ComponenteAdicionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ComponenteAdicion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ComponenteAdicion> b)
            {
                DapperPlusManager.Entity<ComponenteAdicion>().Table("ComponenteAdicion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}