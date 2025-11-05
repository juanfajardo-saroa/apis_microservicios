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
     /// Clase Abstracta para  TipoComponenteGrupoAlimento
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoComponenteGrupoAlimentoRepository : DataObject , ITipoComponenteGrupoAlimento 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoComponenteGrupoAlimentoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoComponenteGrupoAlimentoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoComponenteGrupoAlimento GetById(TipoComponenteGrupoAlimento pTipoComponenteGrupoAlimento)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoComponenteGrupoAlimento.id);                                    


    				TipoComponenteGrupoAlimento o = SqlMapper.QueryFirstOrDefault<TipoComponenteGrupoAlimento>(con, "API.PA_TipoComponenteGrupoAlimentoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoComponenteGrupoAlimento  ->" + ex.Message);
				}
			}

			public List<TipoComponenteGrupoAlimento> GetAll()
			{
				try 
                {
                        List<TipoComponenteGrupoAlimento> l = SqlMapper.Query<TipoComponenteGrupoAlimento>(con, "API.PA_TipoComponenteGrupoAlimentoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoComponenteGrupoAlimento  ->" + ex.Message);
				}
			}

			public List<TipoComponenteGrupoAlimento> GetAllFull()
			{
				try 
				{
                    List<TipoComponenteGrupoAlimento> l = SqlMapper.Query<TipoComponenteGrupoAlimento>(con, "API.PA_TipoComponenteGrupoAlimentoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoComponenteGrupoAlimento  ->" + ex.Message);
				}
			}
			
			public List<TipoComponenteGrupoAlimento> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoComponenteGrupoAlimento> l = SqlMapper.Query<TipoComponenteGrupoAlimento>(con, "API.PA_TipoComponenteGrupoAlimentoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoComponenteGrupoAlimento  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoComponenteGrupoAlimento> GetByFilter(TipoComponenteGrupoAlimento pTipoComponenteGrupoAlimento, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoComponenteGrupoAlimento.id== null || pTipoComponenteGrupoAlimento.id==0) ? vintNUll :pTipoComponenteGrupoAlimento.id);
                    p.Add("@ID_TipoComponente",(pTipoComponenteGrupoAlimento.ID_TipoComponente== null || pTipoComponenteGrupoAlimento.ID_TipoComponente==0) ? vintNUll :pTipoComponenteGrupoAlimento.ID_TipoComponente);
                    p.Add("@ID_GrupoAlimento",(pTipoComponenteGrupoAlimento.ID_GrupoAlimento== null || pTipoComponenteGrupoAlimento.ID_GrupoAlimento==0) ? vintNUll :pTipoComponenteGrupoAlimento.ID_GrupoAlimento);
                    p.Add("@ID_SubGrupoAlimento",(pTipoComponenteGrupoAlimento.ID_SubGrupoAlimento== null || pTipoComponenteGrupoAlimento.ID_SubGrupoAlimento==0) ? vintNUll :pTipoComponenteGrupoAlimento.ID_SubGrupoAlimento);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoComponenteGrupoAlimento> l = SqlMapper.Query<TipoComponenteGrupoAlimento>(con, "API.PA_TipoComponenteGrupoAlimentoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoComponenteGrupoAlimento  ->" + ex.Message);
				}
			}

			public TipoComponenteGrupoAlimento Add(TipoComponenteGrupoAlimento pTipoComponenteGrupoAlimento)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoComponenteGrupoAlimento.id==null ? 0 : pTipoComponenteGrupoAlimento.id);
p.Add("@ID_TipoComponente",pTipoComponenteGrupoAlimento.ID_TipoComponente==null ? 0 : pTipoComponenteGrupoAlimento.ID_TipoComponente);
p.Add("@ID_GrupoAlimento",pTipoComponenteGrupoAlimento.ID_GrupoAlimento==null ? 0 : pTipoComponenteGrupoAlimento.ID_GrupoAlimento);
p.Add("@ID_SubGrupoAlimento",pTipoComponenteGrupoAlimento.ID_SubGrupoAlimento==null ? 0 : pTipoComponenteGrupoAlimento.ID_SubGrupoAlimento);
                    p.Add("@auditoria", pTipoComponenteGrupoAlimento.auditoria);

                         


                    TipoComponenteGrupoAlimento o = SqlMapper.QueryFirstOrDefault<TipoComponenteGrupoAlimento>(con, "API.PA_TipoComponenteGrupoAlimentoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoComponenteGrupoAlimento  ->" + ex.Message);
				}
			}

			public TipoComponenteGrupoAlimento  Update(TipoComponenteGrupoAlimento pTipoComponenteGrupoAlimento)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoComponenteGrupoAlimento.id==null ? 0 : pTipoComponenteGrupoAlimento.id);
p.Add("@ID_TipoComponente",pTipoComponenteGrupoAlimento.ID_TipoComponente==null ? 0 : pTipoComponenteGrupoAlimento.ID_TipoComponente);
p.Add("@ID_GrupoAlimento",pTipoComponenteGrupoAlimento.ID_GrupoAlimento==null ? 0 : pTipoComponenteGrupoAlimento.ID_GrupoAlimento);
p.Add("@ID_SubGrupoAlimento",pTipoComponenteGrupoAlimento.ID_SubGrupoAlimento==null ? 0 : pTipoComponenteGrupoAlimento.ID_SubGrupoAlimento);
                    p.Add("@auditoria", pTipoComponenteGrupoAlimento.auditoria);

                         


                    TipoComponenteGrupoAlimento o = SqlMapper.QueryFirstOrDefault<TipoComponenteGrupoAlimento>(con, "API.PA_TipoComponenteGrupoAlimentoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoComponenteGrupoAlimento  ->" + ex.Message);
				}
			}

			public bool Delete(TipoComponenteGrupoAlimento pTipoComponenteGrupoAlimento)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoComponenteGrupoAlimento.id);
                    p.Add("@auditoria", pTipoComponenteGrupoAlimento.auditoria);

                

 

					TipoComponenteGrupoAlimento o = SqlMapper.QueryFirstOrDefault<TipoComponenteGrupoAlimento>(con, "API.PA_TipoComponenteGrupoAlimentoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoComponenteGrupoAlimento  ->" + ex.Message);
				}
			}

		



            public List<TipoComponenteGrupoAlimento> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoComponenteGrupoAlimento> TipoComponenteGrupoAlimentoList = new List<TipoComponenteGrupoAlimento>();

                    TipoComponenteGrupoAlimentoList = SqlMapper.Query<TipoComponenteGrupoAlimento>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoComponenteGrupoAlimentoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoComponenteGrupoAlimento  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoComponenteGrupoAlimento> b)
            {
                DapperPlusManager.Entity<TipoComponenteGrupoAlimento>().Table("TipoComponenteGrupoAlimento");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}