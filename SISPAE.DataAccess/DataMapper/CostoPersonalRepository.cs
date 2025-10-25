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
     /// Clase Abstracta para  CostoPersonal
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CostoPersonalRepository : DataObject , ICostoPersonal 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CostoPersonalRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CostoPersonalRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CostoPersonal GetById(CostoPersonal pCostoPersonal)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCostoPersonal.id);                                    


    				CostoPersonal o = SqlMapper.QueryFirstOrDefault<CostoPersonal>(con, "API.PA_CostoPersonalGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CostoPersonal  ->" + ex.Message);
				}
			}

			public List<CostoPersonal> GetAll()
			{
				try 
                {
                        List<CostoPersonal> l = SqlMapper.Query<CostoPersonal>(con, "API.PA_CostoPersonalGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CostoPersonal  ->" + ex.Message);
				}
			}

			public List<CostoPersonal> GetAllFull()
			{
				try 
				{
                    List<CostoPersonal> l = SqlMapper.Query<CostoPersonal>(con, "API.PA_CostoPersonalGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CostoPersonal  ->" + ex.Message);
				}
			}
			
			public List<CostoPersonal> GetAllByWithRelation()
			{
				try 
                {
                    List<CostoPersonal> l = SqlMapper.Query<CostoPersonal>(con, "API.PA_CostoPersonalGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CostoPersonal  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CostoPersonal> GetByFilter(CostoPersonal pCostoPersonal, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCostoPersonal.id== null || pCostoPersonal.id==0) ? vintNUll :pCostoPersonal.id);
                    p.Add("@ID_etc",(pCostoPersonal.ID_etc== null || pCostoPersonal.ID_etc==0) ? vintNUll :pCostoPersonal.ID_etc);
                    p.Add("@NumCoordinadores",(pCostoPersonal.NumCoordinadores== null) ? vintNUll :pCostoPersonal.NumCoordinadores);
                    p.Add("@SalarioCoordinador",(pCostoPersonal.SalarioCoordinador== null) ? vintNUll :pCostoPersonal.SalarioCoordinador);
                    p.Add("@ID_TipoRemunManipuladoras",(pCostoPersonal.ID_TipoRemunManipuladoras== null || pCostoPersonal.ID_TipoRemunManipuladoras==0) ? vintNUll :pCostoPersonal.ID_TipoRemunManipuladoras);
                    p.Add("@RemunComplemento",(pCostoPersonal.RemunComplemento== null) ? vintNUll :pCostoPersonal.RemunComplemento);
                    p.Add("@RemunAlmuerzo",(pCostoPersonal.RemunAlmuerzo== null) ? vintNUll :pCostoPersonal.RemunAlmuerzo);
                    p.Add("@CostoPersonal",(pCostoPersonal.CostoPersonal== null) ? vintNUll :pCostoPersonal.CostoPersonal);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CostoPersonal> l = SqlMapper.Query<CostoPersonal>(con, "API.PA_CostoPersonalGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CostoPersonal  ->" + ex.Message);
				}
			}

			public CostoPersonal Add(CostoPersonal pCostoPersonal)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCostoPersonal.id==null ? 0 : pCostoPersonal.id);
p.Add("@ID_etc",pCostoPersonal.ID_etc==null ? 0 : pCostoPersonal.ID_etc);
p.Add("@NumCoordinadores",pCostoPersonal.NumCoordinadores==null ? 0 : pCostoPersonal.NumCoordinadores);
                    p.Add("@SalarioCoordinador", pCostoPersonal.SalarioCoordinador);
p.Add("@ID_TipoRemunManipuladoras",pCostoPersonal.ID_TipoRemunManipuladoras==null ? 0 : pCostoPersonal.ID_TipoRemunManipuladoras);
                    p.Add("@RemunComplemento", pCostoPersonal.RemunComplemento);
                    p.Add("@RemunAlmuerzo", pCostoPersonal.RemunAlmuerzo);
                    p.Add("@CostoPersonal", pCostoPersonal.CostoPersonal);
                    p.Add("@auditoria", pCostoPersonal.auditoria);

                         


                    CostoPersonal o = SqlMapper.QueryFirstOrDefault<CostoPersonal>(con, "API.PA_CostoPersonalAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CostoPersonal  ->" + ex.Message);
				}
			}

			public CostoPersonal  Update(CostoPersonal pCostoPersonal)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCostoPersonal.id==null ? 0 : pCostoPersonal.id);
p.Add("@ID_etc",pCostoPersonal.ID_etc==null ? 0 : pCostoPersonal.ID_etc);
p.Add("@NumCoordinadores",pCostoPersonal.NumCoordinadores==null ? 0 : pCostoPersonal.NumCoordinadores);
                    p.Add("@SalarioCoordinador", pCostoPersonal.SalarioCoordinador);
p.Add("@ID_TipoRemunManipuladoras",pCostoPersonal.ID_TipoRemunManipuladoras==null ? 0 : pCostoPersonal.ID_TipoRemunManipuladoras);
                    p.Add("@RemunComplemento", pCostoPersonal.RemunComplemento);
                    p.Add("@RemunAlmuerzo", pCostoPersonal.RemunAlmuerzo);
                    p.Add("@CostoPersonal", pCostoPersonal.CostoPersonal);
                    p.Add("@auditoria", pCostoPersonal.auditoria);

                         


                    CostoPersonal o = SqlMapper.QueryFirstOrDefault<CostoPersonal>(con, "API.PA_CostoPersonalUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CostoPersonal  ->" + ex.Message);
				}
			}

			public bool Delete(CostoPersonal pCostoPersonal)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCostoPersonal.id);
                    p.Add("@auditoria", pCostoPersonal.auditoria);

                

 

					CostoPersonal o = SqlMapper.QueryFirstOrDefault<CostoPersonal>(con, "API.PA_CostoPersonalDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CostoPersonal  ->" + ex.Message);
				}
			}

		



            public List<CostoPersonal> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CostoPersonal> CostoPersonalList = new List<CostoPersonal>();

                    CostoPersonalList = SqlMapper.Query<CostoPersonal>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CostoPersonalList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CostoPersonal  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CostoPersonal> b)
            {
                DapperPlusManager.Entity<CostoPersonal>().Table("CostoPersonal");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}