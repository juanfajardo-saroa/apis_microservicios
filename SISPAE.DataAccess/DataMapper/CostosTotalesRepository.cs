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
     /// Clase Abstracta para  CostosTotales
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CostosTotalesRepository : DataObject , ICostosTotales 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CostosTotalesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CostosTotalesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CostosTotales GetById(CostosTotales pCostosTotales)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCostosTotales.id);                                    


    				CostosTotales o = SqlMapper.QueryFirstOrDefault<CostosTotales>(con, "API.PA_CostosTotalesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CostosTotales  ->" + ex.Message);
				}
			}

			public List<CostosTotales> GetAll()
			{
				try 
                {
                        List<CostosTotales> l = SqlMapper.Query<CostosTotales>(con, "API.PA_CostosTotalesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CostosTotales  ->" + ex.Message);
				}
			}

			public List<CostosTotales> GetAllFull()
			{
				try 
				{
                    List<CostosTotales> l = SqlMapper.Query<CostosTotales>(con, "API.PA_CostosTotalesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CostosTotales  ->" + ex.Message);
				}
			}
			
			public List<CostosTotales> GetAllByWithRelation()
			{
				try 
                {
                    List<CostosTotales> l = SqlMapper.Query<CostosTotales>(con, "API.PA_CostosTotalesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CostosTotales  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CostosTotales> GetByFilter(CostosTotales pCostosTotales, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCostosTotales.id== null || pCostosTotales.id==0) ? vintNUll :pCostosTotales.id);
                    p.Add("@ID_ETC",(pCostosTotales.ID_ETC== null || pCostosTotales.ID_ETC==0) ? vintNUll :pCostosTotales.ID_ETC);
                    p.Add("@ID_TipoModeloOperacion",(pCostosTotales.ID_TipoModeloOperacion== null || pCostosTotales.ID_TipoModeloOperacion==0) ? vintNUll :pCostosTotales.ID_TipoModeloOperacion);
                    p.Add("@CostoTotalOtros",(pCostosTotales.CostoTotalOtros== null) ? vintNUll :pCostosTotales.CostoTotalOtros);
                    p.Add("@CostoTotalComplementos",(pCostosTotales.CostoTotalComplementos== null) ? vintNUll :pCostosTotales.CostoTotalComplementos);
                    p.Add("@CostoTotal",(pCostosTotales.CostoTotal== null) ? vintNUll :pCostosTotales.CostoTotal);
                    p.Add("@CoberturaRecaudados",(pCostosTotales.CoberturaRecaudados== null) ? vintNUll :pCostosTotales.CoberturaRecaudados);
                    p.Add("@CoberturaRecaudadosReconocidos",(pCostosTotales.CoberturaRecaudadosReconocidos== null) ? vintNUll :pCostosTotales.CoberturaRecaudadosReconocidos);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CostosTotales> l = SqlMapper.Query<CostosTotales>(con, "API.PA_CostosTotalesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CostosTotales  ->" + ex.Message);
				}
			}

			public CostosTotales Add(CostosTotales pCostosTotales)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCostosTotales.id==null ? 0 : pCostosTotales.id);
p.Add("@ID_ETC",pCostosTotales.ID_ETC==null ? 0 : pCostosTotales.ID_ETC);
p.Add("@ID_TipoModeloOperacion",pCostosTotales.ID_TipoModeloOperacion==null ? 0 : pCostosTotales.ID_TipoModeloOperacion);
                    p.Add("@CostoTotalOtros", pCostosTotales.CostoTotalOtros);
                    p.Add("@CostoTotalComplementos", pCostosTotales.CostoTotalComplementos);
                    p.Add("@CostoTotal", pCostosTotales.CostoTotal);
                    p.Add("@CoberturaRecaudados", pCostosTotales.CoberturaRecaudados);
                    p.Add("@CoberturaRecaudadosReconocidos", pCostosTotales.CoberturaRecaudadosReconocidos);
                    p.Add("@auditoria", pCostosTotales.auditoria);

                         


                    CostosTotales o = SqlMapper.QueryFirstOrDefault<CostosTotales>(con, "API.PA_CostosTotalesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CostosTotales  ->" + ex.Message);
				}
			}

			public CostosTotales  Update(CostosTotales pCostosTotales)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCostosTotales.id==null ? 0 : pCostosTotales.id);
p.Add("@ID_ETC",pCostosTotales.ID_ETC==null ? 0 : pCostosTotales.ID_ETC);
p.Add("@ID_TipoModeloOperacion",pCostosTotales.ID_TipoModeloOperacion==null ? 0 : pCostosTotales.ID_TipoModeloOperacion);
                    p.Add("@CostoTotalOtros", pCostosTotales.CostoTotalOtros);
                    p.Add("@CostoTotalComplementos", pCostosTotales.CostoTotalComplementos);
                    p.Add("@CostoTotal", pCostosTotales.CostoTotal);
                    p.Add("@CoberturaRecaudados", pCostosTotales.CoberturaRecaudados);
                    p.Add("@CoberturaRecaudadosReconocidos", pCostosTotales.CoberturaRecaudadosReconocidos);
                    p.Add("@auditoria", pCostosTotales.auditoria);

                         


                    CostosTotales o = SqlMapper.QueryFirstOrDefault<CostosTotales>(con, "API.PA_CostosTotalesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CostosTotales  ->" + ex.Message);
				}
			}

			public bool Delete(CostosTotales pCostosTotales)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCostosTotales.id);
                    p.Add("@auditoria", pCostosTotales.auditoria);

                

 

					CostosTotales o = SqlMapper.QueryFirstOrDefault<CostosTotales>(con, "API.PA_CostosTotalesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CostosTotales  ->" + ex.Message);
				}
			}

		



            public List<CostosTotales> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CostosTotales> CostosTotalesList = new List<CostosTotales>();

                    CostosTotalesList = SqlMapper.Query<CostosTotales>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CostosTotalesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CostosTotales  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CostosTotales> b)
            {
                DapperPlusManager.Entity<CostosTotales>().Table("CostosTotales");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}