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
     /// Clase Abstracta para  CostosImplementos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CostosImplementosRepository : DataObject , ICostosImplementos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CostosImplementosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CostosImplementosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CostosImplementos GetById(CostosImplementos pCostosImplementos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCostosImplementos.id);                                    


    				CostosImplementos o = SqlMapper.QueryFirstOrDefault<CostosImplementos>(con, "API.PA_CostosImplementosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CostosImplementos  ->" + ex.Message);
				}
			}

			public List<CostosImplementos> GetAll()
			{
				try 
                {
                        List<CostosImplementos> l = SqlMapper.Query<CostosImplementos>(con, "API.PA_CostosImplementosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CostosImplementos  ->" + ex.Message);
				}
			}

			public List<CostosImplementos> GetAllFull()
			{
				try 
				{
                    List<CostosImplementos> l = SqlMapper.Query<CostosImplementos>(con, "API.PA_CostosImplementosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CostosImplementos  ->" + ex.Message);
				}
			}
			
			public List<CostosImplementos> GetAllByWithRelation()
			{
				try 
                {
                    List<CostosImplementos> l = SqlMapper.Query<CostosImplementos>(con, "API.PA_CostosImplementosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CostosImplementos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CostosImplementos> GetByFilter(CostosImplementos pCostosImplementos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCostosImplementos.id== null || pCostosImplementos.id==0) ? vintNUll :pCostosImplementos.id);
                    p.Add("@ID_ETC",(pCostosImplementos.ID_ETC== null || pCostosImplementos.ID_ETC==0) ? vintNUll :pCostosImplementos.ID_ETC);
                    p.Add("@MenajeCocina",(pCostosImplementos.MenajeCocina== null) ? vintNUll :pCostosImplementos.MenajeCocina);
                    p.Add("@MenajeComedor",(pCostosImplementos.MenajeComedor== null) ? vintNUll :pCostosImplementos.MenajeComedor);
                    p.Add("@DotacionComedor",(pCostosImplementos.DotacionComedor== null) ? vintNUll :pCostosImplementos.DotacionComedor);
                    p.Add("@ProductosLimpieza",(pCostosImplementos.ProductosLimpieza== null) ? vintNUll :pCostosImplementos.ProductosLimpieza);
                    p.Add("@ImplementosAseo",(pCostosImplementos.ImplementosAseo== null) ? vintNUll :pCostosImplementos.ImplementosAseo);
                    p.Add("@CostoImplementos",(pCostosImplementos.CostoImplementos== null) ? vintNUll :pCostosImplementos.CostoImplementos);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CostosImplementos> l = SqlMapper.Query<CostosImplementos>(con, "API.PA_CostosImplementosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CostosImplementos  ->" + ex.Message);
				}
			}

			public CostosImplementos Add(CostosImplementos pCostosImplementos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCostosImplementos.id==null ? 0 : pCostosImplementos.id);
p.Add("@ID_ETC",pCostosImplementos.ID_ETC==null ? 0 : pCostosImplementos.ID_ETC);
                    p.Add("@MenajeCocina", pCostosImplementos.MenajeCocina);
                    p.Add("@MenajeComedor", pCostosImplementos.MenajeComedor);
                    p.Add("@DotacionComedor", pCostosImplementos.DotacionComedor);
                    p.Add("@ProductosLimpieza", pCostosImplementos.ProductosLimpieza);
                    p.Add("@ImplementosAseo", pCostosImplementos.ImplementosAseo);
                    p.Add("@CostoImplementos", pCostosImplementos.CostoImplementos);
                    p.Add("@auditoria", pCostosImplementos.auditoria);

                         


                    CostosImplementos o = SqlMapper.QueryFirstOrDefault<CostosImplementos>(con, "API.PA_CostosImplementosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CostosImplementos  ->" + ex.Message);
				}
			}

			public CostosImplementos  Update(CostosImplementos pCostosImplementos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCostosImplementos.id==null ? 0 : pCostosImplementos.id);
p.Add("@ID_ETC",pCostosImplementos.ID_ETC==null ? 0 : pCostosImplementos.ID_ETC);
                    p.Add("@MenajeCocina", pCostosImplementos.MenajeCocina);
                    p.Add("@MenajeComedor", pCostosImplementos.MenajeComedor);
                    p.Add("@DotacionComedor", pCostosImplementos.DotacionComedor);
                    p.Add("@ProductosLimpieza", pCostosImplementos.ProductosLimpieza);
                    p.Add("@ImplementosAseo", pCostosImplementos.ImplementosAseo);
                    p.Add("@CostoImplementos", pCostosImplementos.CostoImplementos);
                    p.Add("@auditoria", pCostosImplementos.auditoria);

                         


                    CostosImplementos o = SqlMapper.QueryFirstOrDefault<CostosImplementos>(con, "API.PA_CostosImplementosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CostosImplementos  ->" + ex.Message);
				}
			}

			public bool Delete(CostosImplementos pCostosImplementos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCostosImplementos.id);
                    p.Add("@auditoria", pCostosImplementos.auditoria);

                

 

					CostosImplementos o = SqlMapper.QueryFirstOrDefault<CostosImplementos>(con, "API.PA_CostosImplementosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CostosImplementos  ->" + ex.Message);
				}
			}

		



            public List<CostosImplementos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CostosImplementos> CostosImplementosList = new List<CostosImplementos>();

                    CostosImplementosList = SqlMapper.Query<CostosImplementos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CostosImplementosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CostosImplementos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CostosImplementos> b)
            {
                DapperPlusManager.Entity<CostosImplementos>().Table("CostosImplementos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}