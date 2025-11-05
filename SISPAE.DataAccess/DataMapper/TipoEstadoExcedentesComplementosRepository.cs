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
     /// Clase Abstracta para  TipoEstadoExcedentesComplementos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoEstadoExcedentesComplementosRepository : DataObject , ITipoEstadoExcedentesComplementos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoEstadoExcedentesComplementosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoEstadoExcedentesComplementosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoEstadoExcedentesComplementos GetById(TipoEstadoExcedentesComplementos pTipoEstadoExcedentesComplementos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoEstadoExcedentesComplementos.id);                                    


    				TipoEstadoExcedentesComplementos o = SqlMapper.QueryFirstOrDefault<TipoEstadoExcedentesComplementos>(con, "API.PA_TipoEstadoExcedentesComplementosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoEstadoExcedentesComplementos  ->" + ex.Message);
				}
			}

			public List<TipoEstadoExcedentesComplementos> GetAll()
			{
				try 
                {
                        List<TipoEstadoExcedentesComplementos> l = SqlMapper.Query<TipoEstadoExcedentesComplementos>(con, "API.PA_TipoEstadoExcedentesComplementosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoEstadoExcedentesComplementos  ->" + ex.Message);
				}
			}

			public List<TipoEstadoExcedentesComplementos> GetAllFull()
			{
				try 
				{
                    List<TipoEstadoExcedentesComplementos> l = SqlMapper.Query<TipoEstadoExcedentesComplementos>(con, "API.PA_TipoEstadoExcedentesComplementosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoEstadoExcedentesComplementos  ->" + ex.Message);
				}
			}
			
			public List<TipoEstadoExcedentesComplementos> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoEstadoExcedentesComplementos> l = SqlMapper.Query<TipoEstadoExcedentesComplementos>(con, "API.PA_TipoEstadoExcedentesComplementosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoEstadoExcedentesComplementos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoEstadoExcedentesComplementos> GetByFilter(TipoEstadoExcedentesComplementos pTipoEstadoExcedentesComplementos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoEstadoExcedentesComplementos.id== null || pTipoEstadoExcedentesComplementos.id==0) ? vintNUll :pTipoEstadoExcedentesComplementos.id);
                    p.Add("@Nombre",(pTipoEstadoExcedentesComplementos.Nombre== null) ? vintNUll :pTipoEstadoExcedentesComplementos.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoEstadoExcedentesComplementos> l = SqlMapper.Query<TipoEstadoExcedentesComplementos>(con, "API.PA_TipoEstadoExcedentesComplementosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoEstadoExcedentesComplementos  ->" + ex.Message);
				}
			}

			public TipoEstadoExcedentesComplementos Add(TipoEstadoExcedentesComplementos pTipoEstadoExcedentesComplementos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoEstadoExcedentesComplementos.id==null ? 0 : pTipoEstadoExcedentesComplementos.id);
                    p.Add("@Nombre", pTipoEstadoExcedentesComplementos.Nombre);
                    p.Add("@auditoria", pTipoEstadoExcedentesComplementos.auditoria);

                         


                    TipoEstadoExcedentesComplementos o = SqlMapper.QueryFirstOrDefault<TipoEstadoExcedentesComplementos>(con, "API.PA_TipoEstadoExcedentesComplementosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoEstadoExcedentesComplementos  ->" + ex.Message);
				}
			}

			public TipoEstadoExcedentesComplementos  Update(TipoEstadoExcedentesComplementos pTipoEstadoExcedentesComplementos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoEstadoExcedentesComplementos.id==null ? 0 : pTipoEstadoExcedentesComplementos.id);
                    p.Add("@Nombre", pTipoEstadoExcedentesComplementos.Nombre);
                    p.Add("@auditoria", pTipoEstadoExcedentesComplementos.auditoria);

                         


                    TipoEstadoExcedentesComplementos o = SqlMapper.QueryFirstOrDefault<TipoEstadoExcedentesComplementos>(con, "API.PA_TipoEstadoExcedentesComplementosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoEstadoExcedentesComplementos  ->" + ex.Message);
				}
			}

			public bool Delete(TipoEstadoExcedentesComplementos pTipoEstadoExcedentesComplementos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoEstadoExcedentesComplementos.id);
                    p.Add("@auditoria", pTipoEstadoExcedentesComplementos.auditoria);

                

 

					TipoEstadoExcedentesComplementos o = SqlMapper.QueryFirstOrDefault<TipoEstadoExcedentesComplementos>(con, "API.PA_TipoEstadoExcedentesComplementosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoEstadoExcedentesComplementos  ->" + ex.Message);
				}
			}

		



            public List<TipoEstadoExcedentesComplementos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoEstadoExcedentesComplementos> TipoEstadoExcedentesComplementosList = new List<TipoEstadoExcedentesComplementos>();

                    TipoEstadoExcedentesComplementosList = SqlMapper.Query<TipoEstadoExcedentesComplementos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoEstadoExcedentesComplementosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoEstadoExcedentesComplementos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoEstadoExcedentesComplementos> b)
            {
                DapperPlusManager.Entity<TipoEstadoExcedentesComplementos>().Table("TipoEstadoExcedentesComplementos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}