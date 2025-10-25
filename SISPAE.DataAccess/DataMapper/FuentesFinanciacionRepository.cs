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
     /// Clase Abstracta para  FuentesFinanciacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class FuentesFinanciacionRepository : DataObject , IFuentesFinanciacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public FuentesFinanciacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public FuentesFinanciacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public FuentesFinanciacion GetById(FuentesFinanciacion pFuentesFinanciacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pFuentesFinanciacion.id);                                    


    				FuentesFinanciacion o = SqlMapper.QueryFirstOrDefault<FuentesFinanciacion>(con, "API.PA_FuentesFinanciacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  FuentesFinanciacion  ->" + ex.Message);
				}
			}

			public List<FuentesFinanciacion> GetAll()
			{
				try 
                {
                        List<FuentesFinanciacion> l = SqlMapper.Query<FuentesFinanciacion>(con, "API.PA_FuentesFinanciacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  FuentesFinanciacion  ->" + ex.Message);
				}
			}

			public List<FuentesFinanciacion> GetAllFull()
			{
				try 
				{
                    List<FuentesFinanciacion> l = SqlMapper.Query<FuentesFinanciacion>(con, "API.PA_FuentesFinanciacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  FuentesFinanciacion  ->" + ex.Message);
				}
			}
			
			public List<FuentesFinanciacion> GetAllByWithRelation()
			{
				try 
                {
                    List<FuentesFinanciacion> l = SqlMapper.Query<FuentesFinanciacion>(con, "API.PA_FuentesFinanciacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  FuentesFinanciacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<FuentesFinanciacion> GetByFilter(FuentesFinanciacion pFuentesFinanciacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pFuentesFinanciacion.id== null || pFuentesFinanciacion.id==0) ? vintNUll :pFuentesFinanciacion.id);
                    p.Add("@ID_InfomacionPresupuestal",(pFuentesFinanciacion.ID_InfomacionPresupuestal== null || pFuentesFinanciacion.ID_InfomacionPresupuestal==0) ? vintNUll :pFuentesFinanciacion.ID_InfomacionPresupuestal);
                    p.Add("@ID_Modificacion",(pFuentesFinanciacion.ID_Modificacion== null || pFuentesFinanciacion.ID_Modificacion==0) ? vintNUll :pFuentesFinanciacion.ID_Modificacion);
                    p.Add("@ID_Fuentelngreso",(pFuentesFinanciacion.ID_Fuentelngreso== null || pFuentesFinanciacion.ID_Fuentelngreso==0) ? vintNUll :pFuentesFinanciacion.ID_Fuentelngreso);
                    p.Add("@Valor",(pFuentesFinanciacion.Valor== null) ? vintNUll :pFuentesFinanciacion.Valor);
                    p.Add("@Nombre",(pFuentesFinanciacion.Nombre== null) ? vintNUll :pFuentesFinanciacion.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<FuentesFinanciacion> l = SqlMapper.Query<FuentesFinanciacion>(con, "API.PA_FuentesFinanciacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  FuentesFinanciacion  ->" + ex.Message);
				}
			}

			public FuentesFinanciacion Add(FuentesFinanciacion pFuentesFinanciacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pFuentesFinanciacion.id==null ? 0 : pFuentesFinanciacion.id);
p.Add("@ID_InfomacionPresupuestal",pFuentesFinanciacion.ID_InfomacionPresupuestal==null ? 0 : pFuentesFinanciacion.ID_InfomacionPresupuestal);
p.Add("@ID_Modificacion",pFuentesFinanciacion.ID_Modificacion==null ? 0 : pFuentesFinanciacion.ID_Modificacion);
p.Add("@ID_Fuentelngreso",pFuentesFinanciacion.ID_Fuentelngreso==null ? 0 : pFuentesFinanciacion.ID_Fuentelngreso);
                    p.Add("@Valor", pFuentesFinanciacion.Valor);
                    p.Add("@Nombre", pFuentesFinanciacion.Nombre);
                    p.Add("@auditoria", pFuentesFinanciacion.auditoria);

                         


                    FuentesFinanciacion o = SqlMapper.QueryFirstOrDefault<FuentesFinanciacion>(con, "API.PA_FuentesFinanciacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  FuentesFinanciacion  ->" + ex.Message);
				}
			}

			public FuentesFinanciacion  Update(FuentesFinanciacion pFuentesFinanciacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pFuentesFinanciacion.id==null ? 0 : pFuentesFinanciacion.id);
p.Add("@ID_InfomacionPresupuestal",pFuentesFinanciacion.ID_InfomacionPresupuestal==null ? 0 : pFuentesFinanciacion.ID_InfomacionPresupuestal);
p.Add("@ID_Modificacion",pFuentesFinanciacion.ID_Modificacion==null ? 0 : pFuentesFinanciacion.ID_Modificacion);
p.Add("@ID_Fuentelngreso",pFuentesFinanciacion.ID_Fuentelngreso==null ? 0 : pFuentesFinanciacion.ID_Fuentelngreso);
                    p.Add("@Valor", pFuentesFinanciacion.Valor);
                    p.Add("@Nombre", pFuentesFinanciacion.Nombre);
                    p.Add("@auditoria", pFuentesFinanciacion.auditoria);

                         


                    FuentesFinanciacion o = SqlMapper.QueryFirstOrDefault<FuentesFinanciacion>(con, "API.PA_FuentesFinanciacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  FuentesFinanciacion  ->" + ex.Message);
				}
			}

			public bool Delete(FuentesFinanciacion pFuentesFinanciacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pFuentesFinanciacion.id);
                    p.Add("@auditoria", pFuentesFinanciacion.auditoria);

                

 

					FuentesFinanciacion o = SqlMapper.QueryFirstOrDefault<FuentesFinanciacion>(con, "API.PA_FuentesFinanciacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) FuentesFinanciacion  ->" + ex.Message);
				}
			}

		



            public List<FuentesFinanciacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<FuentesFinanciacion> FuentesFinanciacionList = new List<FuentesFinanciacion>();

                    FuentesFinanciacionList = SqlMapper.Query<FuentesFinanciacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return FuentesFinanciacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) FuentesFinanciacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<FuentesFinanciacion> b)
            {
                DapperPlusManager.Entity<FuentesFinanciacion>().Table("FuentesFinanciacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}