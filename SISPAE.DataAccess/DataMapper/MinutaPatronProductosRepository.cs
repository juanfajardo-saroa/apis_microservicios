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
     /// Clase Abstracta para  MinutaPatronProductos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MinutaPatronProductosRepository : DataObject , IMinutaPatronProductos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MinutaPatronProductosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MinutaPatronProductosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MinutaPatronProductos GetById(MinutaPatronProductos pMinutaPatronProductos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@ID",pMinutaPatronProductos.ID);                                    


    				MinutaPatronProductos o = SqlMapper.QueryFirstOrDefault<MinutaPatronProductos>(con, "API.PA_MinutaPatronProductosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MinutaPatronProductos  ->" + ex.Message);
				}
			}

			public List<MinutaPatronProductos> GetAll()
			{
				try 
                {
                        List<MinutaPatronProductos> l = SqlMapper.Query<MinutaPatronProductos>(con, "API.PA_MinutaPatronProductosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MinutaPatronProductos  ->" + ex.Message);
				}
			}

			public List<MinutaPatronProductos> GetAllFull()
			{
				try 
				{
                    List<MinutaPatronProductos> l = SqlMapper.Query<MinutaPatronProductos>(con, "API.PA_MinutaPatronProductosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MinutaPatronProductos  ->" + ex.Message);
				}
			}
			
			public List<MinutaPatronProductos> GetAllByWithRelation()
			{
				try 
                {
                    List<MinutaPatronProductos> l = SqlMapper.Query<MinutaPatronProductos>(con, "API.PA_MinutaPatronProductosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MinutaPatronProductos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MinutaPatronProductos> GetByFilter(MinutaPatronProductos pMinutaPatronProductos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ID",(pMinutaPatronProductos.ID== null || pMinutaPatronProductos.ID==0) ? vintNUll :pMinutaPatronProductos.ID);
                    p.Add("@ID_TipoGrupoEtario",(pMinutaPatronProductos.ID_TipoGrupoEtario== null || pMinutaPatronProductos.ID_TipoGrupoEtario==0) ? vintNUll :pMinutaPatronProductos.ID_TipoGrupoEtario);
                    p.Add("@ID_Nutriente",(pMinutaPatronProductos.ID_Nutriente== null || pMinutaPatronProductos.ID_Nutriente==0) ? vintNUll :pMinutaPatronProductos.ID_Nutriente);
                    p.Add("@Aporte",(pMinutaPatronProductos.Aporte== null) ? vintNUll :pMinutaPatronProductos.Aporte);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MinutaPatronProductos> l = SqlMapper.Query<MinutaPatronProductos>(con, "API.PA_MinutaPatronProductosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MinutaPatronProductos  ->" + ex.Message);
				}
			}

			public MinutaPatronProductos Add(MinutaPatronProductos pMinutaPatronProductos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ID",pMinutaPatronProductos.ID==null ? 0 : pMinutaPatronProductos.ID);
p.Add("@ID_TipoGrupoEtario",pMinutaPatronProductos.ID_TipoGrupoEtario==null ? 0 : pMinutaPatronProductos.ID_TipoGrupoEtario);
p.Add("@ID_Nutriente",pMinutaPatronProductos.ID_Nutriente==null ? 0 : pMinutaPatronProductos.ID_Nutriente);
                    p.Add("@Aporte", pMinutaPatronProductos.Aporte);
                    p.Add("@auditoria", pMinutaPatronProductos.auditoria);

                         


                    MinutaPatronProductos o = SqlMapper.QueryFirstOrDefault<MinutaPatronProductos>(con, "API.PA_MinutaPatronProductosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MinutaPatronProductos  ->" + ex.Message);
				}
			}

			public MinutaPatronProductos  Update(MinutaPatronProductos pMinutaPatronProductos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ID",pMinutaPatronProductos.ID==null ? 0 : pMinutaPatronProductos.ID);
p.Add("@ID_TipoGrupoEtario",pMinutaPatronProductos.ID_TipoGrupoEtario==null ? 0 : pMinutaPatronProductos.ID_TipoGrupoEtario);
p.Add("@ID_Nutriente",pMinutaPatronProductos.ID_Nutriente==null ? 0 : pMinutaPatronProductos.ID_Nutriente);
                    p.Add("@Aporte", pMinutaPatronProductos.Aporte);
                    p.Add("@auditoria", pMinutaPatronProductos.auditoria);

                         


                    MinutaPatronProductos o = SqlMapper.QueryFirstOrDefault<MinutaPatronProductos>(con, "API.PA_MinutaPatronProductosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MinutaPatronProductos  ->" + ex.Message);
				}
			}

			public bool Delete(MinutaPatronProductos pMinutaPatronProductos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@ID",pMinutaPatronProductos.ID);
                    p.Add("@auditoria", pMinutaPatronProductos.auditoria);

                

 

					MinutaPatronProductos o = SqlMapper.QueryFirstOrDefault<MinutaPatronProductos>(con, "API.PA_MinutaPatronProductosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MinutaPatronProductos  ->" + ex.Message);
				}
			}

		



            public List<MinutaPatronProductos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MinutaPatronProductos> MinutaPatronProductosList = new List<MinutaPatronProductos>();

                    MinutaPatronProductosList = SqlMapper.Query<MinutaPatronProductos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MinutaPatronProductosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MinutaPatronProductos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MinutaPatronProductos> b)
            {
                DapperPlusManager.Entity<MinutaPatronProductos>().Table("MinutaPatronProductos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}