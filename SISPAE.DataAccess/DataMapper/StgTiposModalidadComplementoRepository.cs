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
     /// Clase Abstracta para  StgTiposModalidadComplemento
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgTiposModalidadComplementoRepository : DataObject , IStgTiposModalidadComplemento 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgTiposModalidadComplementoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgTiposModalidadComplementoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgTiposModalidadComplemento GetById(StgTiposModalidadComplemento pStgTiposModalidadComplemento)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
                                    


    				StgTiposModalidadComplemento o = SqlMapper.QueryFirstOrDefault<StgTiposModalidadComplemento>(con, "API.PA_StgTiposModalidadComplementoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgTiposModalidadComplemento  ->" + ex.Message);
				}
			}

			public List<StgTiposModalidadComplemento> GetAll()
			{
				try 
                {
                        List<StgTiposModalidadComplemento> l = SqlMapper.Query<StgTiposModalidadComplemento>(con, "API.PA_StgTiposModalidadComplementoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgTiposModalidadComplemento  ->" + ex.Message);
				}
			}

			public List<StgTiposModalidadComplemento> GetAllFull()
			{
				try 
				{
                    List<StgTiposModalidadComplemento> l = SqlMapper.Query<StgTiposModalidadComplemento>(con, "API.PA_StgTiposModalidadComplementoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgTiposModalidadComplemento  ->" + ex.Message);
				}
			}
			
			public List<StgTiposModalidadComplemento> GetAllByWithRelation()
			{
				try 
                {
                    List<StgTiposModalidadComplemento> l = SqlMapper.Query<StgTiposModalidadComplemento>(con, "API.PA_StgTiposModalidadComplementoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgTiposModalidadComplemento  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgTiposModalidadComplemento> GetByFilter(StgTiposModalidadComplemento pStgTiposModalidadComplemento, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgTiposModalidadComplemento.id== null || pStgTiposModalidadComplemento.id==0) ? vintNUll :pStgTiposModalidadComplemento.id);
                    p.Add("@Nuevo",(pStgTiposModalidadComplemento.Nuevo== null) ? vintNUll :pStgTiposModalidadComplemento.Nuevo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgTiposModalidadComplemento> l = SqlMapper.Query<StgTiposModalidadComplemento>(con, "API.PA_StgTiposModalidadComplementoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgTiposModalidadComplemento  ->" + ex.Message);
				}
			}

			public StgTiposModalidadComplemento Add(StgTiposModalidadComplemento pStgTiposModalidadComplemento)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgTiposModalidadComplemento.id==null ? 0 : pStgTiposModalidadComplemento.id);
                    p.Add("@Nuevo", pStgTiposModalidadComplemento.Nuevo);
                    p.Add("@auditoria", pStgTiposModalidadComplemento.auditoria);

                         


                    StgTiposModalidadComplemento o = SqlMapper.QueryFirstOrDefault<StgTiposModalidadComplemento>(con, "API.PA_StgTiposModalidadComplementoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgTiposModalidadComplemento  ->" + ex.Message);
				}
			}

			public StgTiposModalidadComplemento  Update(StgTiposModalidadComplemento pStgTiposModalidadComplemento)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgTiposModalidadComplemento.id==null ? 0 : pStgTiposModalidadComplemento.id);
                    p.Add("@Nuevo", pStgTiposModalidadComplemento.Nuevo);
                    p.Add("@auditoria", pStgTiposModalidadComplemento.auditoria);

                         


                    StgTiposModalidadComplemento o = SqlMapper.QueryFirstOrDefault<StgTiposModalidadComplemento>(con, "API.PA_StgTiposModalidadComplementoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgTiposModalidadComplemento  ->" + ex.Message);
				}
			}

			public bool Delete(StgTiposModalidadComplemento pStgTiposModalidadComplemento)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
                    p.Add("@auditoria", pStgTiposModalidadComplemento.auditoria);

                

 

					StgTiposModalidadComplemento o = SqlMapper.QueryFirstOrDefault<StgTiposModalidadComplemento>(con, "API.PA_StgTiposModalidadComplementoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgTiposModalidadComplemento  ->" + ex.Message);
				}
			}

		



            public List<StgTiposModalidadComplemento> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgTiposModalidadComplemento> StgTiposModalidadComplementoList = new List<StgTiposModalidadComplemento>();

                    StgTiposModalidadComplementoList = SqlMapper.Query<StgTiposModalidadComplemento>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgTiposModalidadComplementoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgTiposModalidadComplemento  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgTiposModalidadComplemento> b)
            {
                DapperPlusManager.Entity<StgTiposModalidadComplemento>().Table("StgTiposModalidadComplemento");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}