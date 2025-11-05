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
     /// Clase Abstracta para  TiposComplemento
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposComplementoRepository : DataObject , ITiposComplemento 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposComplementoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposComplementoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposComplemento GetById(TiposComplemento pTiposComplemento)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposComplemento.id);                                    


    				TiposComplemento o = SqlMapper.QueryFirstOrDefault<TiposComplemento>(con, "API.PA_TiposComplementoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposComplemento  ->" + ex.Message);
				}
			}

			public List<TiposComplemento> GetAll()
			{
				try 
                {
                        List<TiposComplemento> l = SqlMapper.Query<TiposComplemento>(con, "API.PA_TiposComplementoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposComplemento  ->" + ex.Message);
				}
			}

			public List<TiposComplemento> GetAllFull()
			{
				try 
				{
                    List<TiposComplemento> l = SqlMapper.Query<TiposComplemento>(con, "API.PA_TiposComplementoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposComplemento  ->" + ex.Message);
				}
			}
			
			public List<TiposComplemento> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposComplemento> l = SqlMapper.Query<TiposComplemento>(con, "API.PA_TiposComplementoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposComplemento  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposComplemento> GetByFilter(TiposComplemento pTiposComplemento, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposComplemento.id== null || pTiposComplemento.id==0) ? vintNUll :pTiposComplemento.id);
                    p.Add("@Nombre",(pTiposComplemento.Nombre== null) ? vintNUll :pTiposComplemento.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposComplemento> l = SqlMapper.Query<TiposComplemento>(con, "API.PA_TiposComplementoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposComplemento  ->" + ex.Message);
				}
			}

			public TiposComplemento Add(TiposComplemento pTiposComplemento)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposComplemento.id==null ? 0 : pTiposComplemento.id);
                    p.Add("@Nombre", pTiposComplemento.Nombre);
                    p.Add("@auditoria", pTiposComplemento.auditoria);

                         


                    TiposComplemento o = SqlMapper.QueryFirstOrDefault<TiposComplemento>(con, "API.PA_TiposComplementoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposComplemento  ->" + ex.Message);
				}
			}

			public TiposComplemento  Update(TiposComplemento pTiposComplemento)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposComplemento.id==null ? 0 : pTiposComplemento.id);
                    p.Add("@Nombre", pTiposComplemento.Nombre);
                    p.Add("@auditoria", pTiposComplemento.auditoria);

                         


                    TiposComplemento o = SqlMapper.QueryFirstOrDefault<TiposComplemento>(con, "API.PA_TiposComplementoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposComplemento  ->" + ex.Message);
				}
			}

			public bool Delete(TiposComplemento pTiposComplemento)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposComplemento.id);
                    p.Add("@auditoria", pTiposComplemento.auditoria);

                

 

					TiposComplemento o = SqlMapper.QueryFirstOrDefault<TiposComplemento>(con, "API.PA_TiposComplementoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposComplemento  ->" + ex.Message);
				}
			}

		



            public List<TiposComplemento> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposComplemento> TiposComplementoList = new List<TiposComplemento>();

                    TiposComplementoList = SqlMapper.Query<TiposComplemento>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposComplementoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposComplemento  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposComplemento> b)
            {
                DapperPlusManager.Entity<TiposComplemento>().Table("TiposComplemento");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}