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
     /// Clase Abstracta para  TipoCompGrupoSubgrupoAli
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoCompGrupoSubgrupoAliRepository : DataObject , ITipoCompGrupoSubgrupoAli 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoCompGrupoSubgrupoAliRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoCompGrupoSubgrupoAliRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoCompGrupoSubgrupoAli GetById(TipoCompGrupoSubgrupoAli pTipoCompGrupoSubgrupoAli)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoCompGrupoSubgrupoAli.id);                                    


    				TipoCompGrupoSubgrupoAli o = SqlMapper.QueryFirstOrDefault<TipoCompGrupoSubgrupoAli>(con, "API.PA_TipoCompGrupoSubgrupoAliGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoCompGrupoSubgrupoAli  ->" + ex.Message);
				}
			}

			public List<TipoCompGrupoSubgrupoAli> GetAll()
			{
				try 
                {
                        List<TipoCompGrupoSubgrupoAli> l = SqlMapper.Query<TipoCompGrupoSubgrupoAli>(con, "API.PA_TipoCompGrupoSubgrupoAliGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoCompGrupoSubgrupoAli  ->" + ex.Message );
				}
			}

			public List<TipoCompGrupoSubgrupoAli> GetAllFull()
			{
				try 
				{
                    List<TipoCompGrupoSubgrupoAli> l = SqlMapper.Query<TipoCompGrupoSubgrupoAli>(con, "API.PA_TipoCompGrupoSubgrupoAliGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoCompGrupoSubgrupoAli  ->" + ex.Message);
				}
			}
			
			public List<TipoCompGrupoSubgrupoAli> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoCompGrupoSubgrupoAli> l = SqlMapper.Query<TipoCompGrupoSubgrupoAli>(con, "API.PA_TipoCompGrupoSubgrupoAliGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoCompGrupoSubgrupoAli  ->" + ex.Message );
				}
			}
			
 
						
			
			public List<TipoCompGrupoSubgrupoAli> GetByFilter(TipoCompGrupoSubgrupoAli pTipoCompGrupoSubgrupoAli, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoCompGrupoSubgrupoAli.id== null || pTipoCompGrupoSubgrupoAli.id==0) ? vintNUll :pTipoCompGrupoSubgrupoAli.id);
                    p.Add("@ID_TipoModeloOperacion",(pTipoCompGrupoSubgrupoAli.ID_TipoModeloOperacion== null || pTipoCompGrupoSubgrupoAli.ID_TipoModeloOperacion==0) ? vintNUll :pTipoCompGrupoSubgrupoAli.ID_TipoModeloOperacion);
                    p.Add("@ID_TipoComponente",(pTipoCompGrupoSubgrupoAli.ID_TipoComponente== null || pTipoCompGrupoSubgrupoAli.ID_TipoComponente==0) ? vintNUll :pTipoCompGrupoSubgrupoAli.ID_TipoComponente);
                    p.Add("@ID_GrupoAlimento",(pTipoCompGrupoSubgrupoAli.ID_GrupoAlimento== null || pTipoCompGrupoSubgrupoAli.ID_GrupoAlimento==0) ? vintNUll :pTipoCompGrupoSubgrupoAli.ID_GrupoAlimento);
                    p.Add("@ID_SubGrupoAlimento",(pTipoCompGrupoSubgrupoAli.ID_SubGrupoAlimento== null || pTipoCompGrupoSubgrupoAli.ID_SubGrupoAlimento==0) ? vintNUll :pTipoCompGrupoSubgrupoAli.ID_SubGrupoAlimento);
                    p.Add("@MinVisible",(pTipoCompGrupoSubgrupoAli.MinVisible== null) ? vintNUll :pTipoCompGrupoSubgrupoAli.MinVisible);
                    p.Add("@MaxVisible",(pTipoCompGrupoSubgrupoAli.MaxVisible== null) ? vintNUll :pTipoCompGrupoSubgrupoAli.MaxVisible);
                    p.Add("@SubgrupoManejaValor",(pTipoCompGrupoSubgrupoAli.SubgrupoManejaValor== null) ? vintNUll :pTipoCompGrupoSubgrupoAli.SubgrupoManejaValor);
                    p.Add("@SubgrupoFrecuencia",(pTipoCompGrupoSubgrupoAli.SubgrupoFrecuencia== null) ? vintNUll :pTipoCompGrupoSubgrupoAli.SubgrupoFrecuencia);
                    p.Add("@UnidadMedida",(pTipoCompGrupoSubgrupoAli.UnidadMedida== null) ? vintNUll :pTipoCompGrupoSubgrupoAli.UnidadMedida);
                    p.Add("@ID_TipoComplemento",(pTipoCompGrupoSubgrupoAli.ID_TipoComplemento== null || pTipoCompGrupoSubgrupoAli.ID_TipoComplemento==0) ? vintNUll :pTipoCompGrupoSubgrupoAli.ID_TipoComplemento);
                    p.Add("@ID_ModalidadComplemento",(pTipoCompGrupoSubgrupoAli.ID_ModalidadComplemento== null || pTipoCompGrupoSubgrupoAli.ID_ModalidadComplemento==0) ? vintNUll :pTipoCompGrupoSubgrupoAli.ID_ModalidadComplemento);
                    p.Add("@TextoMsg",(pTipoCompGrupoSubgrupoAli.TextoMsg== null) ? vintNUll :pTipoCompGrupoSubgrupoAli.TextoMsg);
                    p.Add("@ID_TipoSentidoValidacion",(pTipoCompGrupoSubgrupoAli.ID_TipoSentidoValidacion== null || pTipoCompGrupoSubgrupoAli.ID_TipoSentidoValidacion==0) ? vintNUll :pTipoCompGrupoSubgrupoAli.ID_TipoSentidoValidacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoCompGrupoSubgrupoAli> l = SqlMapper.Query<TipoCompGrupoSubgrupoAli>(con, "API.PA_TipoCompGrupoSubgrupoAliGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoCompGrupoSubgrupoAli  ->" + ex.Message );
				}
			}

			public TipoCompGrupoSubgrupoAli Add(TipoCompGrupoSubgrupoAli pTipoCompGrupoSubgrupoAli)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoCompGrupoSubgrupoAli.id==null ? 0 : pTipoCompGrupoSubgrupoAli.id);
p.Add("@ID_TipoModeloOperacion",pTipoCompGrupoSubgrupoAli.ID_TipoModeloOperacion==null ? 0 : pTipoCompGrupoSubgrupoAli.ID_TipoModeloOperacion);
p.Add("@ID_TipoComponente",pTipoCompGrupoSubgrupoAli.ID_TipoComponente==null ? 0 : pTipoCompGrupoSubgrupoAli.ID_TipoComponente);
p.Add("@ID_GrupoAlimento",pTipoCompGrupoSubgrupoAli.ID_GrupoAlimento==null ? 0 : pTipoCompGrupoSubgrupoAli.ID_GrupoAlimento);
p.Add("@ID_SubGrupoAlimento",pTipoCompGrupoSubgrupoAli.ID_SubGrupoAlimento==null ? 0 : pTipoCompGrupoSubgrupoAli.ID_SubGrupoAlimento);
                    p.Add("@MinVisible", pTipoCompGrupoSubgrupoAli.MinVisible);
                    p.Add("@MaxVisible", pTipoCompGrupoSubgrupoAli.MaxVisible);
                    p.Add("@SubgrupoManejaValor", pTipoCompGrupoSubgrupoAli.SubgrupoManejaValor);
                    p.Add("@SubgrupoFrecuencia", pTipoCompGrupoSubgrupoAli.SubgrupoFrecuencia);
                    p.Add("@UnidadMedida", pTipoCompGrupoSubgrupoAli.UnidadMedida);
p.Add("@ID_TipoComplemento",pTipoCompGrupoSubgrupoAli.ID_TipoComplemento==null ? 0 : pTipoCompGrupoSubgrupoAli.ID_TipoComplemento);
p.Add("@ID_ModalidadComplemento",pTipoCompGrupoSubgrupoAli.ID_ModalidadComplemento==null ? 0 : pTipoCompGrupoSubgrupoAli.ID_ModalidadComplemento);
                    p.Add("@TextoMsg", pTipoCompGrupoSubgrupoAli.TextoMsg);
p.Add("@ID_TipoSentidoValidacion",pTipoCompGrupoSubgrupoAli.ID_TipoSentidoValidacion==null ? 0 : pTipoCompGrupoSubgrupoAli.ID_TipoSentidoValidacion);
                    p.Add("@auditoria", pTipoCompGrupoSubgrupoAli.Auditoria);

                         


                    TipoCompGrupoSubgrupoAli o = SqlMapper.QueryFirstOrDefault<TipoCompGrupoSubgrupoAli>(con, "API.PA_TipoCompGrupoSubgrupoAliAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoCompGrupoSubgrupoAli  ->" + ex.Message );
				}
			}

			public TipoCompGrupoSubgrupoAli  Update(TipoCompGrupoSubgrupoAli pTipoCompGrupoSubgrupoAli)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoCompGrupoSubgrupoAli.id==null ? 0 : pTipoCompGrupoSubgrupoAli.id);
p.Add("@ID_TipoModeloOperacion",pTipoCompGrupoSubgrupoAli.ID_TipoModeloOperacion==null ? 0 : pTipoCompGrupoSubgrupoAli.ID_TipoModeloOperacion);
p.Add("@ID_TipoComponente",pTipoCompGrupoSubgrupoAli.ID_TipoComponente==null ? 0 : pTipoCompGrupoSubgrupoAli.ID_TipoComponente);
p.Add("@ID_GrupoAlimento",pTipoCompGrupoSubgrupoAli.ID_GrupoAlimento==null ? 0 : pTipoCompGrupoSubgrupoAli.ID_GrupoAlimento);
p.Add("@ID_SubGrupoAlimento",pTipoCompGrupoSubgrupoAli.ID_SubGrupoAlimento==null ? 0 : pTipoCompGrupoSubgrupoAli.ID_SubGrupoAlimento);
                    p.Add("@MinVisible", pTipoCompGrupoSubgrupoAli.MinVisible);
                    p.Add("@MaxVisible", pTipoCompGrupoSubgrupoAli.MaxVisible);
                    p.Add("@SubgrupoManejaValor", pTipoCompGrupoSubgrupoAli.SubgrupoManejaValor);
                    p.Add("@SubgrupoFrecuencia", pTipoCompGrupoSubgrupoAli.SubgrupoFrecuencia);
                    p.Add("@UnidadMedida", pTipoCompGrupoSubgrupoAli.UnidadMedida);
p.Add("@ID_TipoComplemento",pTipoCompGrupoSubgrupoAli.ID_TipoComplemento==null ? 0 : pTipoCompGrupoSubgrupoAli.ID_TipoComplemento);
p.Add("@ID_ModalidadComplemento",pTipoCompGrupoSubgrupoAli.ID_ModalidadComplemento==null ? 0 : pTipoCompGrupoSubgrupoAli.ID_ModalidadComplemento);
                    p.Add("@TextoMsg", pTipoCompGrupoSubgrupoAli.TextoMsg);
p.Add("@ID_TipoSentidoValidacion",pTipoCompGrupoSubgrupoAli.ID_TipoSentidoValidacion==null ? 0 : pTipoCompGrupoSubgrupoAli.ID_TipoSentidoValidacion);
                    p.Add("@auditoria", pTipoCompGrupoSubgrupoAli.Auditoria);

                         


                    TipoCompGrupoSubgrupoAli o = SqlMapper.QueryFirstOrDefault<TipoCompGrupoSubgrupoAli>(con, "API.PA_TipoCompGrupoSubgrupoAliUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoCompGrupoSubgrupoAli  ->" + ex.Message );
				}
			}

			public bool Delete(TipoCompGrupoSubgrupoAli pTipoCompGrupoSubgrupoAli)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoCompGrupoSubgrupoAli.id);
                    p.Add("@auditoria", pTipoCompGrupoSubgrupoAli.Auditoria);

                

 

					TipoCompGrupoSubgrupoAli o = SqlMapper.QueryFirstOrDefault<TipoCompGrupoSubgrupoAli>(con, "API.PA_TipoCompGrupoSubgrupoAliDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoCompGrupoSubgrupoAli  ->" + ex.Message );
				}
			}

		



            public List<TipoCompGrupoSubgrupoAli> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoCompGrupoSubgrupoAli> TipoCompGrupoSubgrupoAliList = new List<TipoCompGrupoSubgrupoAli>();

                    TipoCompGrupoSubgrupoAliList = SqlMapper.Query<TipoCompGrupoSubgrupoAli>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoCompGrupoSubgrupoAliList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoCompGrupoSubgrupoAli  ->" + ex.Message );
                }
            }


            public void BulkInsert(List<TipoCompGrupoSubgrupoAli> b)
            {
                DapperPlusManager.Entity<TipoCompGrupoSubgrupoAli>().Table("TipoCompGrupoSubgrupoAli");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}