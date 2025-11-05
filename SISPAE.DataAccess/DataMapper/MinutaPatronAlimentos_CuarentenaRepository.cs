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
     /// Clase Abstracta para  MinutaPatronAlimentos_Cuarentena
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MinutaPatronAlimentos_CuarentenaRepository : DataObject , IMinutaPatronAlimentos_Cuarentena 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MinutaPatronAlimentos_CuarentenaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MinutaPatronAlimentos_CuarentenaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MinutaPatronAlimentos_Cuarentena GetById(MinutaPatronAlimentos_Cuarentena pMinutaPatronAlimentos_Cuarentena)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMinutaPatronAlimentos_Cuarentena.id);                                    


    				MinutaPatronAlimentos_Cuarentena o = SqlMapper.QueryFirstOrDefault<MinutaPatronAlimentos_Cuarentena>(con, "API.PA_MinutaPatronAlimentos_CuarentenaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MinutaPatronAlimentos_Cuarentena  ->" + ex.Message);
				}
			}

			public List<MinutaPatronAlimentos_Cuarentena> GetAll()
			{
				try 
                {
                        List<MinutaPatronAlimentos_Cuarentena> l = SqlMapper.Query<MinutaPatronAlimentos_Cuarentena>(con, "API.PA_MinutaPatronAlimentos_CuarentenaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MinutaPatronAlimentos_Cuarentena  ->" + ex.Message);
				}
			}

			public List<MinutaPatronAlimentos_Cuarentena> GetAllFull()
			{
				try 
				{
                    List<MinutaPatronAlimentos_Cuarentena> l = SqlMapper.Query<MinutaPatronAlimentos_Cuarentena>(con, "API.PA_MinutaPatronAlimentos_CuarentenaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MinutaPatronAlimentos_Cuarentena  ->" + ex.Message);
				}
			}
			
			public List<MinutaPatronAlimentos_Cuarentena> GetAllByWithRelation()
			{
				try 
                {
                    List<MinutaPatronAlimentos_Cuarentena> l = SqlMapper.Query<MinutaPatronAlimentos_Cuarentena>(con, "API.PA_MinutaPatronAlimentos_CuarentenaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MinutaPatronAlimentos_Cuarentena  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MinutaPatronAlimentos_Cuarentena> GetByFilter(MinutaPatronAlimentos_Cuarentena pMinutaPatronAlimentos_Cuarentena, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMinutaPatronAlimentos_Cuarentena.id== null || pMinutaPatronAlimentos_Cuarentena.id==0) ? vintNUll :pMinutaPatronAlimentos_Cuarentena.id);
                    p.Add("@Nombre",(pMinutaPatronAlimentos_Cuarentena.Nombre== null) ? vintNUll :pMinutaPatronAlimentos_Cuarentena.Nombre);
                    p.Add("@ID_TipoMinutaPatron",(pMinutaPatronAlimentos_Cuarentena.ID_TipoMinutaPatron== null || pMinutaPatronAlimentos_Cuarentena.ID_TipoMinutaPatron==0) ? vintNUll :pMinutaPatronAlimentos_Cuarentena.ID_TipoMinutaPatron);
                    p.Add("@ID_TipoEstadoMinuta",(pMinutaPatronAlimentos_Cuarentena.ID_TipoEstadoMinuta== null || pMinutaPatronAlimentos_Cuarentena.ID_TipoEstadoMinuta==0) ? vintNUll :pMinutaPatronAlimentos_Cuarentena.ID_TipoEstadoMinuta);
                    p.Add("@ID_UsuarioEntidad",(pMinutaPatronAlimentos_Cuarentena.ID_UsuarioEntidad== null || pMinutaPatronAlimentos_Cuarentena.ID_UsuarioEntidad==0) ? vintNUll :pMinutaPatronAlimentos_Cuarentena.ID_UsuarioEntidad);
                    p.Add("@ID_TipoModeloOperacion",(pMinutaPatronAlimentos_Cuarentena.ID_TipoModeloOperacion== null || pMinutaPatronAlimentos_Cuarentena.ID_TipoModeloOperacion==0) ? vintNUll :pMinutaPatronAlimentos_Cuarentena.ID_TipoModeloOperacion);
                    p.Add("@ID_ETC",(pMinutaPatronAlimentos_Cuarentena.ID_ETC== null || pMinutaPatronAlimentos_Cuarentena.ID_ETC==0) ? vintNUll :pMinutaPatronAlimentos_Cuarentena.ID_ETC);
                    p.Add("@ID_TipoGrupoEtario",(pMinutaPatronAlimentos_Cuarentena.ID_TipoGrupoEtario== null || pMinutaPatronAlimentos_Cuarentena.ID_TipoGrupoEtario==0) ? vintNUll :pMinutaPatronAlimentos_Cuarentena.ID_TipoGrupoEtario);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MinutaPatronAlimentos_Cuarentena> l = SqlMapper.Query<MinutaPatronAlimentos_Cuarentena>(con, "API.PA_MinutaPatronAlimentos_CuarentenaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MinutaPatronAlimentos_Cuarentena  ->" + ex.Message);
				}
			}

			public MinutaPatronAlimentos_Cuarentena Add(MinutaPatronAlimentos_Cuarentena pMinutaPatronAlimentos_Cuarentena)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMinutaPatronAlimentos_Cuarentena.id==null ? 0 : pMinutaPatronAlimentos_Cuarentena.id);
                    p.Add("@Nombre", pMinutaPatronAlimentos_Cuarentena.Nombre);
p.Add("@ID_TipoMinutaPatron",pMinutaPatronAlimentos_Cuarentena.ID_TipoMinutaPatron==null ? 0 : pMinutaPatronAlimentos_Cuarentena.ID_TipoMinutaPatron);
p.Add("@ID_TipoEstadoMinuta",pMinutaPatronAlimentos_Cuarentena.ID_TipoEstadoMinuta==null ? 0 : pMinutaPatronAlimentos_Cuarentena.ID_TipoEstadoMinuta);
p.Add("@ID_UsuarioEntidad",pMinutaPatronAlimentos_Cuarentena.ID_UsuarioEntidad==null ? 0 : pMinutaPatronAlimentos_Cuarentena.ID_UsuarioEntidad);
p.Add("@ID_TipoModeloOperacion",pMinutaPatronAlimentos_Cuarentena.ID_TipoModeloOperacion==null ? 0 : pMinutaPatronAlimentos_Cuarentena.ID_TipoModeloOperacion);
p.Add("@ID_ETC",pMinutaPatronAlimentos_Cuarentena.ID_ETC==null ? 0 : pMinutaPatronAlimentos_Cuarentena.ID_ETC);
p.Add("@ID_TipoGrupoEtario",pMinutaPatronAlimentos_Cuarentena.ID_TipoGrupoEtario==null ? 0 : pMinutaPatronAlimentos_Cuarentena.ID_TipoGrupoEtario);
                    p.Add("@auditoria", pMinutaPatronAlimentos_Cuarentena.auditoria);

                         


                    MinutaPatronAlimentos_Cuarentena o = SqlMapper.QueryFirstOrDefault<MinutaPatronAlimentos_Cuarentena>(con, "API.PA_MinutaPatronAlimentos_CuarentenaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MinutaPatronAlimentos_Cuarentena  ->" + ex.Message);
				}
			}

			public MinutaPatronAlimentos_Cuarentena  Update(MinutaPatronAlimentos_Cuarentena pMinutaPatronAlimentos_Cuarentena)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMinutaPatronAlimentos_Cuarentena.id==null ? 0 : pMinutaPatronAlimentos_Cuarentena.id);
                    p.Add("@Nombre", pMinutaPatronAlimentos_Cuarentena.Nombre);
p.Add("@ID_TipoMinutaPatron",pMinutaPatronAlimentos_Cuarentena.ID_TipoMinutaPatron==null ? 0 : pMinutaPatronAlimentos_Cuarentena.ID_TipoMinutaPatron);
p.Add("@ID_TipoEstadoMinuta",pMinutaPatronAlimentos_Cuarentena.ID_TipoEstadoMinuta==null ? 0 : pMinutaPatronAlimentos_Cuarentena.ID_TipoEstadoMinuta);
p.Add("@ID_UsuarioEntidad",pMinutaPatronAlimentos_Cuarentena.ID_UsuarioEntidad==null ? 0 : pMinutaPatronAlimentos_Cuarentena.ID_UsuarioEntidad);
p.Add("@ID_TipoModeloOperacion",pMinutaPatronAlimentos_Cuarentena.ID_TipoModeloOperacion==null ? 0 : pMinutaPatronAlimentos_Cuarentena.ID_TipoModeloOperacion);
p.Add("@ID_ETC",pMinutaPatronAlimentos_Cuarentena.ID_ETC==null ? 0 : pMinutaPatronAlimentos_Cuarentena.ID_ETC);
p.Add("@ID_TipoGrupoEtario",pMinutaPatronAlimentos_Cuarentena.ID_TipoGrupoEtario==null ? 0 : pMinutaPatronAlimentos_Cuarentena.ID_TipoGrupoEtario);
                    p.Add("@auditoria", pMinutaPatronAlimentos_Cuarentena.auditoria);

                         


                    MinutaPatronAlimentos_Cuarentena o = SqlMapper.QueryFirstOrDefault<MinutaPatronAlimentos_Cuarentena>(con, "API.PA_MinutaPatronAlimentos_CuarentenaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MinutaPatronAlimentos_Cuarentena  ->" + ex.Message);
				}
			}

			public bool Delete(MinutaPatronAlimentos_Cuarentena pMinutaPatronAlimentos_Cuarentena)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMinutaPatronAlimentos_Cuarentena.id);
                    p.Add("@auditoria", pMinutaPatronAlimentos_Cuarentena.auditoria);

                

 

					MinutaPatronAlimentos_Cuarentena o = SqlMapper.QueryFirstOrDefault<MinutaPatronAlimentos_Cuarentena>(con, "API.PA_MinutaPatronAlimentos_CuarentenaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MinutaPatronAlimentos_Cuarentena  ->" + ex.Message);
				}
			}

		



            public List<MinutaPatronAlimentos_Cuarentena> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MinutaPatronAlimentos_Cuarentena> MinutaPatronAlimentos_CuarentenaList = new List<MinutaPatronAlimentos_Cuarentena>();

                    MinutaPatronAlimentos_CuarentenaList = SqlMapper.Query<MinutaPatronAlimentos_Cuarentena>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MinutaPatronAlimentos_CuarentenaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MinutaPatronAlimentos_Cuarentena  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MinutaPatronAlimentos_Cuarentena> b)
            {
                DapperPlusManager.Entity<MinutaPatronAlimentos_Cuarentena>().Table("MinutaPatronAlimentos_Cuarentena");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}