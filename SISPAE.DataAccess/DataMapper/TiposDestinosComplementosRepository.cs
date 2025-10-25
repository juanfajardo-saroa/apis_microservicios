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
     /// Clase Abstracta para  TiposDestinosComplementos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposDestinosComplementosRepository : DataObject , ITiposDestinosComplementos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposDestinosComplementosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposDestinosComplementosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposDestinosComplementos GetById(TiposDestinosComplementos pTiposDestinosComplementos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposDestinosComplementos.id);                                    


    				TiposDestinosComplementos o = SqlMapper.QueryFirstOrDefault<TiposDestinosComplementos>(con, "API.PA_TiposDestinosComplementosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposDestinosComplementos  ->" + ex.Message);
				}
			}

			public List<TiposDestinosComplementos> GetAll()
			{
				try 
                {
                        List<TiposDestinosComplementos> l = SqlMapper.Query<TiposDestinosComplementos>(con, "API.PA_TiposDestinosComplementosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposDestinosComplementos  ->" + ex.Message);
				}
			}

			public List<TiposDestinosComplementos> GetAllFull()
			{
				try 
				{
                    List<TiposDestinosComplementos> l = SqlMapper.Query<TiposDestinosComplementos>(con, "API.PA_TiposDestinosComplementosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposDestinosComplementos  ->" + ex.Message);
				}
			}
			
			public List<TiposDestinosComplementos> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposDestinosComplementos> l = SqlMapper.Query<TiposDestinosComplementos>(con, "API.PA_TiposDestinosComplementosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposDestinosComplementos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposDestinosComplementos> GetByFilter(TiposDestinosComplementos pTiposDestinosComplementos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposDestinosComplementos.id== null || pTiposDestinosComplementos.id==0) ? vintNUll :pTiposDestinosComplementos.id);
                    p.Add("@Nombre",(pTiposDestinosComplementos.Nombre== null) ? vintNUll :pTiposDestinosComplementos.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposDestinosComplementos> l = SqlMapper.Query<TiposDestinosComplementos>(con, "API.PA_TiposDestinosComplementosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposDestinosComplementos  ->" + ex.Message);
				}
			}

			public TiposDestinosComplementos Add(TiposDestinosComplementos pTiposDestinosComplementos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposDestinosComplementos.id==null ? 0 : pTiposDestinosComplementos.id);
                    p.Add("@Nombre", pTiposDestinosComplementos.Nombre);
                    p.Add("@auditoria", pTiposDestinosComplementos.auditoria);

                         


                    TiposDestinosComplementos o = SqlMapper.QueryFirstOrDefault<TiposDestinosComplementos>(con, "API.PA_TiposDestinosComplementosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposDestinosComplementos  ->" + ex.Message);
				}
			}

			public TiposDestinosComplementos  Update(TiposDestinosComplementos pTiposDestinosComplementos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposDestinosComplementos.id==null ? 0 : pTiposDestinosComplementos.id);
                    p.Add("@Nombre", pTiposDestinosComplementos.Nombre);
                    p.Add("@auditoria", pTiposDestinosComplementos.auditoria);

                         


                    TiposDestinosComplementos o = SqlMapper.QueryFirstOrDefault<TiposDestinosComplementos>(con, "API.PA_TiposDestinosComplementosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposDestinosComplementos  ->" + ex.Message);
				}
			}

			public bool Delete(TiposDestinosComplementos pTiposDestinosComplementos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposDestinosComplementos.id);
                    p.Add("@auditoria", pTiposDestinosComplementos.auditoria);

                

 

					TiposDestinosComplementos o = SqlMapper.QueryFirstOrDefault<TiposDestinosComplementos>(con, "API.PA_TiposDestinosComplementosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposDestinosComplementos  ->" + ex.Message);
				}
			}

		



            public List<TiposDestinosComplementos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposDestinosComplementos> TiposDestinosComplementosList = new List<TiposDestinosComplementos>();

                    TiposDestinosComplementosList = SqlMapper.Query<TiposDestinosComplementos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposDestinosComplementosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposDestinosComplementos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposDestinosComplementos> b)
            {
                DapperPlusManager.Entity<TiposDestinosComplementos>().Table("TiposDestinosComplementos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}