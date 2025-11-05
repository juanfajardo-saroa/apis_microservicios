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
     /// Clase Abstracta para  TiposRacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposRacionRepository : DataObject , ITiposRacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposRacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposRacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposRacion GetById(TiposRacion pTiposRacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposRacion.id);                                    


    				TiposRacion o = SqlMapper.QueryFirstOrDefault<TiposRacion>(con, "API.PA_TiposComplementoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposRacion  ->" + ex.Message);
				}
			}

			public List<TiposRacion> GetAll()
			{
				try 
                {
                        List<TiposRacion> l = SqlMapper.Query<TiposRacion>(con, "API.PA_TiposComplementoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposRacion  ->" + ex.Message);
				}
			}

			public List<TiposRacion> GetAllFull()
			{
				try 
				{
                    List<TiposRacion> l = SqlMapper.Query<TiposRacion>(con, "API.PA_TiposComplementoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposRacion  ->" + ex.Message);
				}
			}
			
			public List<TiposRacion> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposRacion> l = SqlMapper.Query<TiposRacion>(con, "API.PA_TiposComplementoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposRacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposRacion> GetByFilter(TiposRacion pTiposRacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposRacion.id== null || pTiposRacion.id==0) ? vintNUll :pTiposRacion.id);
                    p.Add("@Nombre",(pTiposRacion.Nombre== null) ? vintNUll :pTiposRacion.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposRacion> l = SqlMapper.Query<TiposRacion>(con, "API.PA_TiposComplementoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposRacion  ->" + ex.Message);
				}
			}

			public TiposRacion Add(TiposRacion pTiposRacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposRacion.id==null ? 0 : pTiposRacion.id);
                    p.Add("@Nombre", pTiposRacion.Nombre);
                    p.Add("@auditoria", pTiposRacion.auditoria);

                         


                    TiposRacion o = SqlMapper.QueryFirstOrDefault<TiposRacion>(con, "API.PA_TiposComplementoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposRacion  ->" + ex.Message);
				}
			}

			public TiposRacion  Update(TiposRacion pTiposRacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposRacion.id==null ? 0 : pTiposRacion.id);
                    p.Add("@Nombre", pTiposRacion.Nombre);
                    p.Add("@auditoria", pTiposRacion.auditoria);

                         


                    TiposRacion o = SqlMapper.QueryFirstOrDefault<TiposRacion>(con, "API.PA_TiposComplementoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposRacion  ->" + ex.Message);
				}
			}

			public bool Delete(TiposRacion pTiposRacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposRacion.id);
                    p.Add("@auditoria", pTiposRacion.auditoria);

                

 

					TiposRacion o = SqlMapper.QueryFirstOrDefault<TiposRacion>(con, "API.PA_TiposComplementoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposRacion  ->" + ex.Message);
				}
			}

		



            public List<TiposRacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposRacion> TiposRacionList = new List<TiposRacion>();

                    TiposRacionList = SqlMapper.Query<TiposRacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposRacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposRacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposRacion> b)
            {
                DapperPlusManager.Entity<TiposRacion>().Table("TiposRacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}