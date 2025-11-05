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
     /// Clase Abstracta para  CostoTransporteETC
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CostoTransporteETCRepository : DataObject , ICostoTransporteETC 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CostoTransporteETCRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CostoTransporteETCRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CostoTransporteETC GetById(CostoTransporteETC pCostoTransporteETC)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCostoTransporteETC.id);                                    


    				CostoTransporteETC o = SqlMapper.QueryFirstOrDefault<CostoTransporteETC>(con, "API.PA_CostoTransporteETCGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CostoTransporteETC  ->" + ex.Message);
				}
			}

			public List<CostoTransporteETC> GetAll()
			{
				try 
                {
                        List<CostoTransporteETC> l = SqlMapper.Query<CostoTransporteETC>(con, "API.PA_CostoTransporteETCGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CostoTransporteETC  ->" + ex.Message);
				}
			}

			public List<CostoTransporteETC> GetAllFull()
			{
				try 
				{
                    List<CostoTransporteETC> l = SqlMapper.Query<CostoTransporteETC>(con, "API.PA_CostoTransporteETCGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CostoTransporteETC  ->" + ex.Message);
				}
			}
			
			public List<CostoTransporteETC> GetAllByWithRelation()
			{
				try 
                {
                    List<CostoTransporteETC> l = SqlMapper.Query<CostoTransporteETC>(con, "API.PA_CostoTransporteETCGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CostoTransporteETC  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CostoTransporteETC> GetByFilter(CostoTransporteETC pCostoTransporteETC, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCostoTransporteETC.id== null || pCostoTransporteETC.id==0) ? vintNUll :pCostoTransporteETC.id);
                    p.Add("@ID_ETC",(pCostoTransporteETC.ID_ETC== null || pCostoTransporteETC.ID_ETC==0) ? vintNUll :pCostoTransporteETC.ID_ETC);
                    p.Add("@ID_TipoComplemento",(pCostoTransporteETC.ID_TipoComplemento== null || pCostoTransporteETC.ID_TipoComplemento==0) ? vintNUll :pCostoTransporteETC.ID_TipoComplemento);
                    p.Add("@CostoTransporte",(pCostoTransporteETC.CostoTransporte== null) ? vintNUll :pCostoTransporteETC.CostoTransporte);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CostoTransporteETC> l = SqlMapper.Query<CostoTransporteETC>(con, "API.PA_CostoTransporteETCGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CostoTransporteETC  ->" + ex.Message);
				}
			}

			public CostoTransporteETC Add(CostoTransporteETC pCostoTransporteETC)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCostoTransporteETC.id==null ? 0 : pCostoTransporteETC.id);
p.Add("@ID_ETC",pCostoTransporteETC.ID_ETC==null ? 0 : pCostoTransporteETC.ID_ETC);
p.Add("@ID_TipoComplemento",pCostoTransporteETC.ID_TipoComplemento==null ? 0 : pCostoTransporteETC.ID_TipoComplemento);
                    p.Add("@CostoTransporte", pCostoTransporteETC.CostoTransporte);
                    p.Add("@auditoria", pCostoTransporteETC.auditoria);

                         


                    CostoTransporteETC o = SqlMapper.QueryFirstOrDefault<CostoTransporteETC>(con, "API.PA_CostoTransporteETCAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CostoTransporteETC  ->" + ex.Message);
				}
			}

			public CostoTransporteETC  Update(CostoTransporteETC pCostoTransporteETC)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCostoTransporteETC.id==null ? 0 : pCostoTransporteETC.id);
p.Add("@ID_ETC",pCostoTransporteETC.ID_ETC==null ? 0 : pCostoTransporteETC.ID_ETC);
p.Add("@ID_TipoComplemento",pCostoTransporteETC.ID_TipoComplemento==null ? 0 : pCostoTransporteETC.ID_TipoComplemento);
                    p.Add("@CostoTransporte", pCostoTransporteETC.CostoTransporte);
                    p.Add("@auditoria", pCostoTransporteETC.auditoria);

                         


                    CostoTransporteETC o = SqlMapper.QueryFirstOrDefault<CostoTransporteETC>(con, "API.PA_CostoTransporteETCUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CostoTransporteETC  ->" + ex.Message);
				}
			}

			public bool Delete(CostoTransporteETC pCostoTransporteETC)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCostoTransporteETC.id);
                    p.Add("@auditoria", pCostoTransporteETC.auditoria);

                

 

					CostoTransporteETC o = SqlMapper.QueryFirstOrDefault<CostoTransporteETC>(con, "API.PA_CostoTransporteETCDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CostoTransporteETC  ->" + ex.Message);
				}
			}

		



            public List<CostoTransporteETC> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CostoTransporteETC> CostoTransporteETCList = new List<CostoTransporteETC>();

                    CostoTransporteETCList = SqlMapper.Query<CostoTransporteETC>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CostoTransporteETCList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CostoTransporteETC  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CostoTransporteETC> b)
            {
                DapperPlusManager.Entity<CostoTransporteETC>().Table("CostoTransporteETC");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}