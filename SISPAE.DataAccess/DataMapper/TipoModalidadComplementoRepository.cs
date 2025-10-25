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
     /// Clase Abstracta para  TipoModalidadComplemento
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoModalidadComplementoRepository : DataObject , ITipoModalidadComplemento 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoModalidadComplementoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoModalidadComplementoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoModalidadComplemento GetById(TipoModalidadComplemento pTipoModalidadComplemento)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoModalidadComplemento.id);                                    


    				TipoModalidadComplemento o = SqlMapper.QueryFirstOrDefault<TipoModalidadComplemento>(con, "API.PA_TipoModalidadComplementoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoModalidadComplemento  ->" + ex.Message);
				}
			}

			public List<TipoModalidadComplemento> GetAll()
			{
				try 
                {
                        List<TipoModalidadComplemento> l = SqlMapper.Query<TipoModalidadComplemento>(con, "API.PA_TipoModalidadComplementoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoModalidadComplemento  ->" + ex.Message);
				}
			}

			public List<TipoModalidadComplemento> GetAllFull()
			{
				try 
				{
                    List<TipoModalidadComplemento> l = SqlMapper.Query<TipoModalidadComplemento>(con, "API.PA_TipoModalidadComplementoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoModalidadComplemento  ->" + ex.Message);
				}
			}
			
			public List<TipoModalidadComplemento> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoModalidadComplemento> l = SqlMapper.Query<TipoModalidadComplemento>(con, "API.PA_TipoModalidadComplementoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoModalidadComplemento  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoModalidadComplemento> GetByFilter(TipoModalidadComplemento pTipoModalidadComplemento, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoModalidadComplemento.id== null || pTipoModalidadComplemento.id==0) ? vintNUll :pTipoModalidadComplemento.id);
                    p.Add("@Nombre",(pTipoModalidadComplemento.Nombre== null) ? vintNUll :pTipoModalidadComplemento.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoModalidadComplemento> l = SqlMapper.Query<TipoModalidadComplemento>(con, "API.PA_TipoModalidadComplementoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoModalidadComplemento  ->" + ex.Message);
				}
			}

			public TipoModalidadComplemento Add(TipoModalidadComplemento pTipoModalidadComplemento)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoModalidadComplemento.id==null ? 0 : pTipoModalidadComplemento.id);
                    p.Add("@Nombre", pTipoModalidadComplemento.Nombre);
                    p.Add("@auditoria", pTipoModalidadComplemento.auditoria);

                         


                    TipoModalidadComplemento o = SqlMapper.QueryFirstOrDefault<TipoModalidadComplemento>(con, "API.PA_TipoModalidadComplementoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoModalidadComplemento  ->" + ex.Message);
				}
			}

			public TipoModalidadComplemento  Update(TipoModalidadComplemento pTipoModalidadComplemento)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoModalidadComplemento.id==null ? 0 : pTipoModalidadComplemento.id);
                    p.Add("@Nombre", pTipoModalidadComplemento.Nombre);
                    p.Add("@auditoria", pTipoModalidadComplemento.auditoria);

                         


                    TipoModalidadComplemento o = SqlMapper.QueryFirstOrDefault<TipoModalidadComplemento>(con, "API.PA_TipoModalidadComplementoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoModalidadComplemento  ->" + ex.Message);
				}
			}

			public bool Delete(TipoModalidadComplemento pTipoModalidadComplemento)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoModalidadComplemento.id);
                    p.Add("@auditoria", pTipoModalidadComplemento.auditoria);

                

 

					TipoModalidadComplemento o = SqlMapper.QueryFirstOrDefault<TipoModalidadComplemento>(con, "API.PA_TipoModalidadComplementoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoModalidadComplemento  ->" + ex.Message);
				}
			}

		



            public List<TipoModalidadComplemento> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoModalidadComplemento> TipoModalidadComplementoList = new List<TipoModalidadComplemento>();

                    TipoModalidadComplementoList = SqlMapper.Query<TipoModalidadComplemento>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoModalidadComplementoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoModalidadComplemento  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoModalidadComplemento> b)
            {
                DapperPlusManager.Entity<TipoModalidadComplemento>().Table("TipoModalidadComplemento");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}