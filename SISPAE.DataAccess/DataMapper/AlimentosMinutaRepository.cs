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
     /// Clase Abstracta para  AlimentosMinuta
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AlimentosMinutaRepository : DataObject , IAlimentosMinuta 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AlimentosMinutaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AlimentosMinutaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AlimentosMinuta GetById(AlimentosMinuta pAlimentosMinuta)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAlimentosMinuta.id);                                    


    				AlimentosMinuta o = SqlMapper.QueryFirstOrDefault<AlimentosMinuta>(con, "API.PA_AlimentosMinutaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AlimentosMinuta  ->" + ex.Message);
				}
			}

			public List<AlimentosMinuta> GetAll()
			{
				try 
                {
                        List<AlimentosMinuta> l = SqlMapper.Query<AlimentosMinuta>(con, "API.PA_AlimentosMinutaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AlimentosMinuta  ->" + ex.Message);
				}
			}

			public List<AlimentosMinuta> GetAllFull()
			{
				try 
				{
                    List<AlimentosMinuta> l = SqlMapper.Query<AlimentosMinuta>(con, "API.PA_AlimentosMinutaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AlimentosMinuta  ->" + ex.Message);
				}
			}
			
			public List<AlimentosMinuta> GetAllByWithRelation()
			{
				try 
                {
                    List<AlimentosMinuta> l = SqlMapper.Query<AlimentosMinuta>(con, "API.PA_AlimentosMinutaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AlimentosMinuta  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AlimentosMinuta> GetByFilter(AlimentosMinuta pAlimentosMinuta, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAlimentosMinuta.id== null || pAlimentosMinuta.id==0) ? vintNUll :pAlimentosMinuta.id);
                    p.Add("@ID_MinutaPatronAlimento",(pAlimentosMinuta.ID_MinutaPatronAlimento== null || pAlimentosMinuta.ID_MinutaPatronAlimento==0) ? vintNUll :pAlimentosMinuta.ID_MinutaPatronAlimento);
                    p.Add("@ID_TipoComponente",(pAlimentosMinuta.ID_TipoComponente== null || pAlimentosMinuta.ID_TipoComponente==0) ? vintNUll :pAlimentosMinuta.ID_TipoComponente);
                    p.Add("@ID_GrupoAlimento",(pAlimentosMinuta.ID_GrupoAlimento== null || pAlimentosMinuta.ID_GrupoAlimento==0) ? vintNUll :pAlimentosMinuta.ID_GrupoAlimento);
                    p.Add("@frecuencia",(pAlimentosMinuta.frecuencia== null) ? vintNUll :pAlimentosMinuta.frecuencia);
                    p.Add("@MingramoPesoBruto",(pAlimentosMinuta.MingramoPesoBruto== null) ? vintNUll :pAlimentosMinuta.MingramoPesoBruto);
                    p.Add("@MaxgramoPesoBruto",(pAlimentosMinuta.MaxgramoPesoBruto== null) ? vintNUll :pAlimentosMinuta.MaxgramoPesoBruto);
                    p.Add("@MingramoPesoNeto",(pAlimentosMinuta.MingramoPesoNeto== null) ? vintNUll :pAlimentosMinuta.MingramoPesoNeto);
                    p.Add("@MaxgramoPesoNeto",(pAlimentosMinuta.MaxgramoPesoNeto== null) ? vintNUll :pAlimentosMinuta.MaxgramoPesoNeto);
                    p.Add("@MingramoPesoPorcionServida",(pAlimentosMinuta.MingramoPesoPorcionServida== null) ? vintNUll :pAlimentosMinuta.MingramoPesoPorcionServida);
                    p.Add("@MaxgramoPesoPorcionServida",(pAlimentosMinuta.MaxgramoPesoPorcionServida== null) ? vintNUll :pAlimentosMinuta.MaxgramoPesoPorcionServida);
                    p.Add("@normativa",(pAlimentosMinuta.normativa== null) ? vintNUll :pAlimentosMinuta.normativa);
                    p.Add("@ID_SubGrupoAlimento",(pAlimentosMinuta.ID_SubGrupoAlimento== null || pAlimentosMinuta.ID_SubGrupoAlimento==0) ? vintNUll :pAlimentosMinuta.ID_SubGrupoAlimento);
                    p.Add("@NumIntercambios",(pAlimentosMinuta.NumIntercambios== null) ? vintNUll :pAlimentosMinuta.NumIntercambios);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AlimentosMinuta> l = SqlMapper.Query<AlimentosMinuta>(con, "API.PA_AlimentosMinutaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AlimentosMinuta  ->" + ex.Message);
				}
			}

			public AlimentosMinuta Add(AlimentosMinuta pAlimentosMinuta)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAlimentosMinuta.id==null ? 0 : pAlimentosMinuta.id);
p.Add("@ID_MinutaPatronAlimento",pAlimentosMinuta.ID_MinutaPatronAlimento==null ? 0 : pAlimentosMinuta.ID_MinutaPatronAlimento);
p.Add("@ID_TipoComponente",pAlimentosMinuta.ID_TipoComponente==null ? 0 : pAlimentosMinuta.ID_TipoComponente);
p.Add("@ID_GrupoAlimento",pAlimentosMinuta.ID_GrupoAlimento==null ? 0 : pAlimentosMinuta.ID_GrupoAlimento);
p.Add("@frecuencia",pAlimentosMinuta.frecuencia==null ? 0 : pAlimentosMinuta.frecuencia);
p.Add("@MingramoPesoBruto",pAlimentosMinuta.MingramoPesoBruto==null ? 0 : pAlimentosMinuta.MingramoPesoBruto);
p.Add("@MaxgramoPesoBruto",pAlimentosMinuta.MaxgramoPesoBruto==null ? 0 : pAlimentosMinuta.MaxgramoPesoBruto);
p.Add("@MingramoPesoNeto",pAlimentosMinuta.MingramoPesoNeto==null ? 0 : pAlimentosMinuta.MingramoPesoNeto);
p.Add("@MaxgramoPesoNeto",pAlimentosMinuta.MaxgramoPesoNeto==null ? 0 : pAlimentosMinuta.MaxgramoPesoNeto);
p.Add("@MingramoPesoPorcionServida",pAlimentosMinuta.MingramoPesoPorcionServida==null ? 0 : pAlimentosMinuta.MingramoPesoPorcionServida);
p.Add("@MaxgramoPesoPorcionServida",pAlimentosMinuta.MaxgramoPesoPorcionServida==null ? 0 : pAlimentosMinuta.MaxgramoPesoPorcionServida);
                    p.Add("@normativa", pAlimentosMinuta.normativa);
p.Add("@ID_SubGrupoAlimento",pAlimentosMinuta.ID_SubGrupoAlimento==null ? 0 : pAlimentosMinuta.ID_SubGrupoAlimento);
                    p.Add("@NumIntercambios", pAlimentosMinuta.NumIntercambios);
                    p.Add("@auditoria", pAlimentosMinuta.auditoria);

                         


                    AlimentosMinuta o = SqlMapper.QueryFirstOrDefault<AlimentosMinuta>(con, "API.PA_AlimentosMinutaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AlimentosMinuta  ->" + ex.Message);
				}
			}

			public AlimentosMinuta  Update(AlimentosMinuta pAlimentosMinuta)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAlimentosMinuta.id==null ? 0 : pAlimentosMinuta.id);
p.Add("@ID_MinutaPatronAlimento",pAlimentosMinuta.ID_MinutaPatronAlimento==null ? 0 : pAlimentosMinuta.ID_MinutaPatronAlimento);
p.Add("@ID_TipoComponente",pAlimentosMinuta.ID_TipoComponente==null ? 0 : pAlimentosMinuta.ID_TipoComponente);
p.Add("@ID_GrupoAlimento",pAlimentosMinuta.ID_GrupoAlimento==null ? 0 : pAlimentosMinuta.ID_GrupoAlimento);
p.Add("@frecuencia",pAlimentosMinuta.frecuencia==null ? 0 : pAlimentosMinuta.frecuencia);
p.Add("@MingramoPesoBruto",pAlimentosMinuta.MingramoPesoBruto==null ? 0 : pAlimentosMinuta.MingramoPesoBruto);
p.Add("@MaxgramoPesoBruto",pAlimentosMinuta.MaxgramoPesoBruto==null ? 0 : pAlimentosMinuta.MaxgramoPesoBruto);
p.Add("@MingramoPesoNeto",pAlimentosMinuta.MingramoPesoNeto==null ? 0 : pAlimentosMinuta.MingramoPesoNeto);
p.Add("@MaxgramoPesoNeto",pAlimentosMinuta.MaxgramoPesoNeto==null ? 0 : pAlimentosMinuta.MaxgramoPesoNeto);
p.Add("@MingramoPesoPorcionServida",pAlimentosMinuta.MingramoPesoPorcionServida==null ? 0 : pAlimentosMinuta.MingramoPesoPorcionServida);
p.Add("@MaxgramoPesoPorcionServida",pAlimentosMinuta.MaxgramoPesoPorcionServida==null ? 0 : pAlimentosMinuta.MaxgramoPesoPorcionServida);
                    p.Add("@normativa", pAlimentosMinuta.normativa);
p.Add("@ID_SubGrupoAlimento",pAlimentosMinuta.ID_SubGrupoAlimento==null ? 0 : pAlimentosMinuta.ID_SubGrupoAlimento);
                    p.Add("@NumIntercambios", pAlimentosMinuta.NumIntercambios);
                    p.Add("@auditoria", pAlimentosMinuta.auditoria);

                         


                    AlimentosMinuta o = SqlMapper.QueryFirstOrDefault<AlimentosMinuta>(con, "API.PA_AlimentosMinutaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AlimentosMinuta  ->" + ex.Message);
				}
			}

			public bool Delete(AlimentosMinuta pAlimentosMinuta)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAlimentosMinuta.id);
                    p.Add("@auditoria", pAlimentosMinuta.auditoria);

                

 

					AlimentosMinuta o = SqlMapper.QueryFirstOrDefault<AlimentosMinuta>(con, "API.PA_AlimentosMinutaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AlimentosMinuta  ->" + ex.Message);
				}
			}

		



            public List<AlimentosMinuta> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AlimentosMinuta> AlimentosMinutaList = new List<AlimentosMinuta>();

                    AlimentosMinutaList = SqlMapper.Query<AlimentosMinuta>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AlimentosMinutaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AlimentosMinuta  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AlimentosMinuta> b)
            {
                DapperPlusManager.Entity<AlimentosMinuta>().Table("AlimentosMinuta");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}