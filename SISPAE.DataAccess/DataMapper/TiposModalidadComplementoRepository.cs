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
     /// Clase Abstracta para  TiposModalidadComplemento
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposModalidadComplementoRepository : DataObject , ITiposModalidadComplemento 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposModalidadComplementoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposModalidadComplementoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposModalidadComplemento GetById(TiposModalidadComplemento pTiposModalidadComplemento)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposModalidadComplemento.id);                                    


    				TiposModalidadComplemento o = SqlMapper.QueryFirstOrDefault<TiposModalidadComplemento>(con, "API.PA_TiposModalidadComplementoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposModalidadComplemento  ->" + ex.Message);
				}
			}

			public List<TiposModalidadComplemento> GetAll()
			{
				try 
                {
                        List<TiposModalidadComplemento> l = SqlMapper.Query<TiposModalidadComplemento>(con, "API.PA_TiposModalidadComplementoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposModalidadComplemento  ->" + ex.Message);
				}
			}

			public List<TiposModalidadComplemento> GetAllFull()
			{
				try 
				{
                    List<TiposModalidadComplemento> l = SqlMapper.Query<TiposModalidadComplemento>(con, "API.PA_TiposModalidadComplementoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposModalidadComplemento  ->" + ex.Message);
				}
			}
			
			public List<TiposModalidadComplemento> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposModalidadComplemento> l = SqlMapper.Query<TiposModalidadComplemento>(con, "API.PA_TiposModalidadComplementoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposModalidadComplemento  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposModalidadComplemento> GetByFilter(TiposModalidadComplemento pTiposModalidadComplemento, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposModalidadComplemento.id== null || pTiposModalidadComplemento.id==0) ? vintNUll :pTiposModalidadComplemento.id);
                    p.Add("@Nombre",(pTiposModalidadComplemento.Nombre== null) ? vintNUll :pTiposModalidadComplemento.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposModalidadComplemento> l = SqlMapper.Query<TiposModalidadComplemento>(con, "API.PA_TiposModalidadComplementoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposModalidadComplemento  ->" + ex.Message);
				}
			}

			public TiposModalidadComplemento Add(TiposModalidadComplemento pTiposModalidadComplemento)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposModalidadComplemento.id==null ? 0 : pTiposModalidadComplemento.id);
                    p.Add("@Nombre", pTiposModalidadComplemento.Nombre);
                    p.Add("@auditoria", pTiposModalidadComplemento.auditoria);

                         


                    TiposModalidadComplemento o = SqlMapper.QueryFirstOrDefault<TiposModalidadComplemento>(con, "API.PA_TiposModalidadComplementoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposModalidadComplemento  ->" + ex.Message);
				}
			}

			public TiposModalidadComplemento  Update(TiposModalidadComplemento pTiposModalidadComplemento)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposModalidadComplemento.id==null ? 0 : pTiposModalidadComplemento.id);
                    p.Add("@Nombre", pTiposModalidadComplemento.Nombre);
                    p.Add("@auditoria", pTiposModalidadComplemento.auditoria);

                         


                    TiposModalidadComplemento o = SqlMapper.QueryFirstOrDefault<TiposModalidadComplemento>(con, "API.PA_TiposModalidadComplementoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposModalidadComplemento  ->" + ex.Message);
				}
			}

			public bool Delete(TiposModalidadComplemento pTiposModalidadComplemento)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposModalidadComplemento.id);
                    p.Add("@auditoria", pTiposModalidadComplemento.auditoria);

                

 

					TiposModalidadComplemento o = SqlMapper.QueryFirstOrDefault<TiposModalidadComplemento>(con, "API.PA_TiposModalidadComplementoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposModalidadComplemento  ->" + ex.Message);
				}
			}

		



            public List<TiposModalidadComplemento> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposModalidadComplemento> TiposModalidadComplementoList = new List<TiposModalidadComplemento>();

                    TiposModalidadComplementoList = SqlMapper.Query<TiposModalidadComplemento>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposModalidadComplementoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposModalidadComplemento  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposModalidadComplemento> b)
            {
                DapperPlusManager.Entity<TiposModalidadComplemento>().Table("TiposModalidadComplemento");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}