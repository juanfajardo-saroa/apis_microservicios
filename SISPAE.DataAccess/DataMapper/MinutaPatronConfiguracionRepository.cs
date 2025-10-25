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
     /// Clase Abstracta para  MinutaPatronConfiguracion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MinutaPatronConfiguracionRepository : DataObject , IMinutaPatronConfiguracion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MinutaPatronConfiguracionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MinutaPatronConfiguracionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MinutaPatronConfiguracion GetById(MinutaPatronConfiguracion pMinutaPatronConfiguracion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMinutaPatronConfiguracion.id);                                    


    				MinutaPatronConfiguracion o = SqlMapper.QueryFirstOrDefault<MinutaPatronConfiguracion>(con, "API.PA_MinutaPatronConfiguracionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MinutaPatronConfiguracion  ->" + ex.Message);
				}
			}

			public List<MinutaPatronConfiguracion> GetAll()
			{
				try 
                {
                        List<MinutaPatronConfiguracion> l = SqlMapper.Query<MinutaPatronConfiguracion>(con, "API.PA_MinutaPatronConfiguracionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MinutaPatronConfiguracion  ->" + ex.Message);
				}
			}

			public List<MinutaPatronConfiguracion> GetAllFull()
			{
				try 
				{
                    List<MinutaPatronConfiguracion> l = SqlMapper.Query<MinutaPatronConfiguracion>(con, "API.PA_MinutaPatronConfiguracionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MinutaPatronConfiguracion  ->" + ex.Message);
				}
			}
			
			public List<MinutaPatronConfiguracion> GetAllByWithRelation()
			{
				try 
                {
                    List<MinutaPatronConfiguracion> l = SqlMapper.Query<MinutaPatronConfiguracion>(con, "API.PA_MinutaPatronConfiguracionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MinutaPatronConfiguracion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MinutaPatronConfiguracion> GetByFilter(MinutaPatronConfiguracion pMinutaPatronConfiguracion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMinutaPatronConfiguracion.id== null || pMinutaPatronConfiguracion.id==0) ? vintNUll :pMinutaPatronConfiguracion.id);
                    p.Add("@ID_TipoModeloOperacion",(pMinutaPatronConfiguracion.ID_TipoModeloOperacion== null || pMinutaPatronConfiguracion.ID_TipoModeloOperacion==0) ? vintNUll :pMinutaPatronConfiguracion.ID_TipoModeloOperacion);
                    p.Add("@ModalidadComplementoId",(pMinutaPatronConfiguracion.ModalidadComplementoId== null) ? vintNUll :pMinutaPatronConfiguracion.ModalidadComplementoId);
                    p.Add("@TipoComplementoId",(pMinutaPatronConfiguracion.TipoComplementoId== null) ? vintNUll :pMinutaPatronConfiguracion.TipoComplementoId);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MinutaPatronConfiguracion> l = SqlMapper.Query<MinutaPatronConfiguracion>(con, "API.PA_MinutaPatronConfiguracionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MinutaPatronConfiguracion  ->" + ex.Message);
				}
			}

			public MinutaPatronConfiguracion Add(MinutaPatronConfiguracion pMinutaPatronConfiguracion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMinutaPatronConfiguracion.id==null ? 0 : pMinutaPatronConfiguracion.id);
p.Add("@ID_TipoModeloOperacion",pMinutaPatronConfiguracion.ID_TipoModeloOperacion==null ? 0 : pMinutaPatronConfiguracion.ID_TipoModeloOperacion);
p.Add("@ModalidadComplementoId",pMinutaPatronConfiguracion.ModalidadComplementoId==null ? 0 : pMinutaPatronConfiguracion.ModalidadComplementoId);
p.Add("@TipoComplementoId",pMinutaPatronConfiguracion.TipoComplementoId==null ? 0 : pMinutaPatronConfiguracion.TipoComplementoId);
                    p.Add("@auditoria", pMinutaPatronConfiguracion.auditoria);

                         


                    MinutaPatronConfiguracion o = SqlMapper.QueryFirstOrDefault<MinutaPatronConfiguracion>(con, "API.PA_MinutaPatronConfiguracionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MinutaPatronConfiguracion  ->" + ex.Message);
				}
			}

			public MinutaPatronConfiguracion  Update(MinutaPatronConfiguracion pMinutaPatronConfiguracion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMinutaPatronConfiguracion.id==null ? 0 : pMinutaPatronConfiguracion.id);
p.Add("@ID_TipoModeloOperacion",pMinutaPatronConfiguracion.ID_TipoModeloOperacion==null ? 0 : pMinutaPatronConfiguracion.ID_TipoModeloOperacion);
p.Add("@ModalidadComplementoId",pMinutaPatronConfiguracion.ModalidadComplementoId==null ? 0 : pMinutaPatronConfiguracion.ModalidadComplementoId);
p.Add("@TipoComplementoId",pMinutaPatronConfiguracion.TipoComplementoId==null ? 0 : pMinutaPatronConfiguracion.TipoComplementoId);
                    p.Add("@auditoria", pMinutaPatronConfiguracion.auditoria);

                         


                    MinutaPatronConfiguracion o = SqlMapper.QueryFirstOrDefault<MinutaPatronConfiguracion>(con, "API.PA_MinutaPatronConfiguracionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MinutaPatronConfiguracion  ->" + ex.Message);
				}
			}

			public bool Delete(MinutaPatronConfiguracion pMinutaPatronConfiguracion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMinutaPatronConfiguracion.id);
                    p.Add("@auditoria", pMinutaPatronConfiguracion.auditoria);

                

 

					MinutaPatronConfiguracion o = SqlMapper.QueryFirstOrDefault<MinutaPatronConfiguracion>(con, "API.PA_MinutaPatronConfiguracionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MinutaPatronConfiguracion  ->" + ex.Message);
				}
			}

		



            public List<MinutaPatronConfiguracion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MinutaPatronConfiguracion> MinutaPatronConfiguracionList = new List<MinutaPatronConfiguracion>();

                    MinutaPatronConfiguracionList = SqlMapper.Query<MinutaPatronConfiguracion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MinutaPatronConfiguracionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MinutaPatronConfiguracion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MinutaPatronConfiguracion> b)
            {
                DapperPlusManager.Entity<MinutaPatronConfiguracion>().Table("MinutaPatronConfiguracion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}