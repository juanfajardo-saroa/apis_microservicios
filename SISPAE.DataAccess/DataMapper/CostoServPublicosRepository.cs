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
     /// Clase Abstracta para  CostoServPublicos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CostoServPublicosRepository : DataObject , ICostoServPublicos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CostoServPublicosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CostoServPublicosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CostoServPublicos GetById(CostoServPublicos pCostoServPublicos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCostoServPublicos.id);                                    


    				CostoServPublicos o = SqlMapper.QueryFirstOrDefault<CostoServPublicos>(con, "API.PA_CostoServPublicosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CostoServPublicos  ->" + ex.Message);
				}
			}

			public List<CostoServPublicos> GetAll()
			{
				try 
                {
                        List<CostoServPublicos> l = SqlMapper.Query<CostoServPublicos>(con, "API.PA_CostoServPublicosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CostoServPublicos  ->" + ex.Message);
				}
			}

			public List<CostoServPublicos> GetAllFull()
			{
				try 
				{
                    List<CostoServPublicos> l = SqlMapper.Query<CostoServPublicos>(con, "API.PA_CostoServPublicosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CostoServPublicos  ->" + ex.Message);
				}
			}
			
			public List<CostoServPublicos> GetAllByWithRelation()
			{
				try 
                {
                    List<CostoServPublicos> l = SqlMapper.Query<CostoServPublicos>(con, "API.PA_CostoServPublicosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CostoServPublicos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CostoServPublicos> GetByFilter(CostoServPublicos pCostoServPublicos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCostoServPublicos.id== null || pCostoServPublicos.id==0) ? vintNUll :pCostoServPublicos.id);
                    p.Add("@ID_ETC",(pCostoServPublicos.ID_ETC== null || pCostoServPublicos.ID_ETC==0) ? vintNUll :pCostoServPublicos.ID_ETC);
                    p.Add("@Agua",(pCostoServPublicos.Agua== null) ? vintNUll :pCostoServPublicos.Agua);
                    p.Add("@Energia",(pCostoServPublicos.Energia== null) ? vintNUll :pCostoServPublicos.Energia);
                    p.Add("@Gas",(pCostoServPublicos.Gas== null) ? vintNUll :pCostoServPublicos.Gas);
                    p.Add("@AseoBasuras",(pCostoServPublicos.AseoBasuras== null) ? vintNUll :pCostoServPublicos.AseoBasuras);
                    p.Add("@CostoServPublicos",(pCostoServPublicos.CostoServPublicos== null) ? vintNUll :pCostoServPublicos.CostoServPublicos);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CostoServPublicos> l = SqlMapper.Query<CostoServPublicos>(con, "API.PA_CostoServPublicosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CostoServPublicos  ->" + ex.Message);
				}
			}

			public CostoServPublicos Add(CostoServPublicos pCostoServPublicos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCostoServPublicos.id==null ? 0 : pCostoServPublicos.id);
p.Add("@ID_ETC",pCostoServPublicos.ID_ETC==null ? 0 : pCostoServPublicos.ID_ETC);
                    p.Add("@Agua", pCostoServPublicos.Agua);
                    p.Add("@Energia", pCostoServPublicos.Energia);
                    p.Add("@Gas", pCostoServPublicos.Gas);
                    p.Add("@AseoBasuras", pCostoServPublicos.AseoBasuras);
                    p.Add("@CostoServPublicos", pCostoServPublicos.CostoServPublicos);
                    p.Add("@auditoria", pCostoServPublicos.auditoria);

                         


                    CostoServPublicos o = SqlMapper.QueryFirstOrDefault<CostoServPublicos>(con, "API.PA_CostoServPublicosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CostoServPublicos  ->" + ex.Message);
				}
			}

			public CostoServPublicos  Update(CostoServPublicos pCostoServPublicos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCostoServPublicos.id==null ? 0 : pCostoServPublicos.id);
p.Add("@ID_ETC",pCostoServPublicos.ID_ETC==null ? 0 : pCostoServPublicos.ID_ETC);
                    p.Add("@Agua", pCostoServPublicos.Agua);
                    p.Add("@Energia", pCostoServPublicos.Energia);
                    p.Add("@Gas", pCostoServPublicos.Gas);
                    p.Add("@AseoBasuras", pCostoServPublicos.AseoBasuras);
                    p.Add("@CostoServPublicos", pCostoServPublicos.CostoServPublicos);
                    p.Add("@auditoria", pCostoServPublicos.auditoria);

                         


                    CostoServPublicos o = SqlMapper.QueryFirstOrDefault<CostoServPublicos>(con, "API.PA_CostoServPublicosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CostoServPublicos  ->" + ex.Message);
				}
			}

			public bool Delete(CostoServPublicos pCostoServPublicos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCostoServPublicos.id);
                    p.Add("@auditoria", pCostoServPublicos.auditoria);

                

 

					CostoServPublicos o = SqlMapper.QueryFirstOrDefault<CostoServPublicos>(con, "API.PA_CostoServPublicosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CostoServPublicos  ->" + ex.Message);
				}
			}

		



            public List<CostoServPublicos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CostoServPublicos> CostoServPublicosList = new List<CostoServPublicos>();

                    CostoServPublicosList = SqlMapper.Query<CostoServPublicos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CostoServPublicosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CostoServPublicos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CostoServPublicos> b)
            {
                DapperPlusManager.Entity<CostoServPublicos>().Table("CostoServPublicos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}