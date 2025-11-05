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
     /// Clase Abstracta para  TiposParticipante
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposParticipanteRepository : DataObject , ITiposParticipante 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposParticipanteRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposParticipanteRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposParticipante GetById(TiposParticipante pTiposParticipante)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposParticipante.id);                                    


    				TiposParticipante o = SqlMapper.QueryFirstOrDefault<TiposParticipante>(con, "API.PA_TiposParticipanteGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposParticipante  ->" + ex.Message);
				}
			}

			public List<TiposParticipante> GetAll()
			{
				try 
                {
                        List<TiposParticipante> l = SqlMapper.Query<TiposParticipante>(con, "API.PA_TiposParticipanteGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposParticipante  ->" + ex.Message);
				}
			}

			public List<TiposParticipante> GetAllFull()
			{
				try 
				{
                    List<TiposParticipante> l = SqlMapper.Query<TiposParticipante>(con, "API.PA_TiposParticipanteGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposParticipante  ->" + ex.Message);
				}
			}
			
			public List<TiposParticipante> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposParticipante> l = SqlMapper.Query<TiposParticipante>(con, "API.PA_TiposParticipanteGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposParticipante  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposParticipante> GetByFilter(TiposParticipante pTiposParticipante, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposParticipante.id== null || pTiposParticipante.id==0) ? vintNUll :pTiposParticipante.id);
                    p.Add("@ID_TipoDinamizador",(pTiposParticipante.ID_TipoDinamizador== null || pTiposParticipante.ID_TipoDinamizador==0) ? vintNUll :pTiposParticipante.ID_TipoDinamizador);
                    p.Add("@Nombre",(pTiposParticipante.Nombre== null) ? vintNUll :pTiposParticipante.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposParticipante> l = SqlMapper.Query<TiposParticipante>(con, "API.PA_TiposParticipanteGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposParticipante  ->" + ex.Message);
				}
			}

			public TiposParticipante Add(TiposParticipante pTiposParticipante)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposParticipante.id==null ? 0 : pTiposParticipante.id);
p.Add("@ID_TipoDinamizador",pTiposParticipante.ID_TipoDinamizador==null ? 0 : pTiposParticipante.ID_TipoDinamizador);
                    p.Add("@Nombre", pTiposParticipante.Nombre);
                    p.Add("@auditoria", pTiposParticipante.auditoria);

                         


                    TiposParticipante o = SqlMapper.QueryFirstOrDefault<TiposParticipante>(con, "API.PA_TiposParticipanteAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposParticipante  ->" + ex.Message);
				}
			}

			public TiposParticipante  Update(TiposParticipante pTiposParticipante)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposParticipante.id==null ? 0 : pTiposParticipante.id);
p.Add("@ID_TipoDinamizador",pTiposParticipante.ID_TipoDinamizador==null ? 0 : pTiposParticipante.ID_TipoDinamizador);
                    p.Add("@Nombre", pTiposParticipante.Nombre);
                    p.Add("@auditoria", pTiposParticipante.auditoria);

                         


                    TiposParticipante o = SqlMapper.QueryFirstOrDefault<TiposParticipante>(con, "API.PA_TiposParticipanteUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposParticipante  ->" + ex.Message);
				}
			}

			public bool Delete(TiposParticipante pTiposParticipante)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposParticipante.id);
                    p.Add("@auditoria", pTiposParticipante.auditoria);

                

 

					TiposParticipante o = SqlMapper.QueryFirstOrDefault<TiposParticipante>(con, "API.PA_TiposParticipanteDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposParticipante  ->" + ex.Message);
				}
			}

		



            public List<TiposParticipante> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposParticipante> TiposParticipanteList = new List<TiposParticipante>();

                    TiposParticipanteList = SqlMapper.Query<TiposParticipante>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposParticipanteList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposParticipante  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposParticipante> b)
            {
                DapperPlusManager.Entity<TiposParticipante>().Table("TiposParticipante");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}