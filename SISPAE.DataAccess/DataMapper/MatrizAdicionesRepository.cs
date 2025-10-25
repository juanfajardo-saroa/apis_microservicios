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
     /// Clase Abstracta para  MatrizAdiciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MatrizAdicionesRepository : DataObject , IMatrizAdiciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MatrizAdicionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MatrizAdicionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MatrizAdiciones GetById(MatrizAdiciones pMatrizAdiciones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMatrizAdiciones.id);                                    


    				MatrizAdiciones o = SqlMapper.QueryFirstOrDefault<MatrizAdiciones>(con, "API.PA_MatrizAdicionesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MatrizAdiciones  ->" + ex.Message);
				}
			}

			public List<MatrizAdiciones> GetAll()
			{
				try 
                {
                        List<MatrizAdiciones> l = SqlMapper.Query<MatrizAdiciones>(con, "API.PA_MatrizAdicionesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MatrizAdiciones  ->" + ex.Message);
				}
			}

			public List<MatrizAdiciones> GetAllFull()
			{
				try 
				{
                    List<MatrizAdiciones> l = SqlMapper.Query<MatrizAdiciones>(con, "API.PA_MatrizAdicionesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MatrizAdiciones  ->" + ex.Message);
				}
			}
			
			public List<MatrizAdiciones> GetAllByWithRelation()
			{
				try 
                {
                    List<MatrizAdiciones> l = SqlMapper.Query<MatrizAdiciones>(con, "API.PA_MatrizAdicionesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MatrizAdiciones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MatrizAdiciones> GetByFilter(MatrizAdiciones pMatrizAdiciones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMatrizAdiciones.id== null || pMatrizAdiciones.id==0) ? vintNUll :pMatrizAdiciones.id);
                    p.Add("@ID_TipoComplemento",(pMatrizAdiciones.ID_TipoComplemento== null || pMatrizAdiciones.ID_TipoComplemento==0) ? vintNUll :pMatrizAdiciones.ID_TipoComplemento);
                    p.Add("@ID_AlimentolCBF",(pMatrizAdiciones.ID_AlimentolCBF== null || pMatrizAdiciones.ID_AlimentolCBF==0) ? vintNUll :pMatrizAdiciones.ID_AlimentolCBF);
                    p.Add("@ID_Adicion",(pMatrizAdiciones.ID_Adicion== null || pMatrizAdiciones.ID_Adicion==0) ? vintNUll :pMatrizAdiciones.ID_Adicion);
                    p.Add("@ID_ComponentesAdicion",(pMatrizAdiciones.ID_ComponentesAdicion== null || pMatrizAdiciones.ID_ComponentesAdicion==0) ? vintNUll :pMatrizAdiciones.ID_ComponentesAdicion);
                    p.Add("@ID_TipoGrupoEtario",(pMatrizAdiciones.ID_TipoGrupoEtario== null || pMatrizAdiciones.ID_TipoGrupoEtario==0) ? vintNUll :pMatrizAdiciones.ID_TipoGrupoEtario);
                    p.Add("@CodigoSIPSA",(pMatrizAdiciones.CodigoSIPSA== null) ? vintNUll :pMatrizAdiciones.CodigoSIPSA);
                    p.Add("@PesoNeto",(pMatrizAdiciones.PesoNeto== null) ? vintNUll :pMatrizAdiciones.PesoNeto);
                    p.Add("@PesoBruto",(pMatrizAdiciones.PesoBruto== null) ? vintNUll :pMatrizAdiciones.PesoBruto);
                    p.Add("@PesoServido",(pMatrizAdiciones.PesoServido== null) ? vintNUll :pMatrizAdiciones.PesoServido);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MatrizAdiciones> l = SqlMapper.Query<MatrizAdiciones>(con, "API.PA_MatrizAdicionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MatrizAdiciones  ->" + ex.Message);
				}
			}

			public MatrizAdiciones Add(MatrizAdiciones pMatrizAdiciones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMatrizAdiciones.id==null ? 0 : pMatrizAdiciones.id);
p.Add("@ID_TipoComplemento",pMatrizAdiciones.ID_TipoComplemento==null ? 0 : pMatrizAdiciones.ID_TipoComplemento);
p.Add("@ID_AlimentolCBF",pMatrizAdiciones.ID_AlimentolCBF==null ? 0 : pMatrizAdiciones.ID_AlimentolCBF);
p.Add("@ID_Adicion",pMatrizAdiciones.ID_Adicion==null ? 0 : pMatrizAdiciones.ID_Adicion);
p.Add("@ID_ComponentesAdicion",pMatrizAdiciones.ID_ComponentesAdicion==null ? 0 : pMatrizAdiciones.ID_ComponentesAdicion);
p.Add("@ID_TipoGrupoEtario",pMatrizAdiciones.ID_TipoGrupoEtario==null ? 0 : pMatrizAdiciones.ID_TipoGrupoEtario);
p.Add("@CodigoSIPSA",pMatrizAdiciones.CodigoSIPSA==null ? 0 : pMatrizAdiciones.CodigoSIPSA);
p.Add("@PesoNeto",pMatrizAdiciones.PesoNeto==null ? 0 : pMatrizAdiciones.PesoNeto);
p.Add("@PesoBruto",pMatrizAdiciones.PesoBruto==null ? 0 : pMatrizAdiciones.PesoBruto);
p.Add("@PesoServido",pMatrizAdiciones.PesoServido==null ? 0 : pMatrizAdiciones.PesoServido);
                    p.Add("@auditoria", pMatrizAdiciones.auditoria);

                         


                    MatrizAdiciones o = SqlMapper.QueryFirstOrDefault<MatrizAdiciones>(con, "API.PA_MatrizAdicionesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MatrizAdiciones  ->" + ex.Message);
				}
			}

			public MatrizAdiciones  Update(MatrizAdiciones pMatrizAdiciones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMatrizAdiciones.id==null ? 0 : pMatrizAdiciones.id);
p.Add("@ID_TipoComplemento",pMatrizAdiciones.ID_TipoComplemento==null ? 0 : pMatrizAdiciones.ID_TipoComplemento);
p.Add("@ID_AlimentolCBF",pMatrizAdiciones.ID_AlimentolCBF==null ? 0 : pMatrizAdiciones.ID_AlimentolCBF);
p.Add("@ID_Adicion",pMatrizAdiciones.ID_Adicion==null ? 0 : pMatrizAdiciones.ID_Adicion);
p.Add("@ID_ComponentesAdicion",pMatrizAdiciones.ID_ComponentesAdicion==null ? 0 : pMatrizAdiciones.ID_ComponentesAdicion);
p.Add("@ID_TipoGrupoEtario",pMatrizAdiciones.ID_TipoGrupoEtario==null ? 0 : pMatrizAdiciones.ID_TipoGrupoEtario);
p.Add("@CodigoSIPSA",pMatrizAdiciones.CodigoSIPSA==null ? 0 : pMatrizAdiciones.CodigoSIPSA);
p.Add("@PesoNeto",pMatrizAdiciones.PesoNeto==null ? 0 : pMatrizAdiciones.PesoNeto);
p.Add("@PesoBruto",pMatrizAdiciones.PesoBruto==null ? 0 : pMatrizAdiciones.PesoBruto);
p.Add("@PesoServido",pMatrizAdiciones.PesoServido==null ? 0 : pMatrizAdiciones.PesoServido);
                    p.Add("@auditoria", pMatrizAdiciones.auditoria);

                         


                    MatrizAdiciones o = SqlMapper.QueryFirstOrDefault<MatrizAdiciones>(con, "API.PA_MatrizAdicionesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MatrizAdiciones  ->" + ex.Message);
				}
			}

			public bool Delete(MatrizAdiciones pMatrizAdiciones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMatrizAdiciones.id);
                    p.Add("@auditoria", pMatrizAdiciones.auditoria);

                

 

					MatrizAdiciones o = SqlMapper.QueryFirstOrDefault<MatrizAdiciones>(con, "API.PA_MatrizAdicionesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MatrizAdiciones  ->" + ex.Message);
				}
			}

		



            public List<MatrizAdiciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MatrizAdiciones> MatrizAdicionesList = new List<MatrizAdiciones>();

                    MatrizAdicionesList = SqlMapper.Query<MatrizAdiciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MatrizAdicionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MatrizAdiciones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MatrizAdiciones> b)
            {
                DapperPlusManager.Entity<MatrizAdiciones>().Table("MatrizAdiciones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}