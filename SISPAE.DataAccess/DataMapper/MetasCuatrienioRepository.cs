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
     /// Clase Abstracta para  MetasCuatrienio
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MetasCuatrienioRepository : DataObject , IMetasCuatrienio 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MetasCuatrienioRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MetasCuatrienioRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MetasCuatrienio GetById(MetasCuatrienio pMetasCuatrienio)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMetasCuatrienio.id);                                    


    				MetasCuatrienio o = SqlMapper.QueryFirstOrDefault<MetasCuatrienio>(con, "API.PA_MetasCuatrienioGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MetasCuatrienio  ->" + ex.Message);
				}
			}

			public List<MetasCuatrienio> GetAll()
			{
				try 
                {
                        List<MetasCuatrienio> l = SqlMapper.Query<MetasCuatrienio>(con, "API.PA_MetasCuatrienioGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MetasCuatrienio  ->" + ex.Message);
				}
			}

			public List<MetasCuatrienio> GetAllFull()
			{
				try 
				{
                    List<MetasCuatrienio> l = SqlMapper.Query<MetasCuatrienio>(con, "API.PA_MetasCuatrienioGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MetasCuatrienio  ->" + ex.Message);
				}
			}
			
			public List<MetasCuatrienio> GetAllByWithRelation()
			{
				try 
                {
                    List<MetasCuatrienio> l = SqlMapper.Query<MetasCuatrienio>(con, "API.PA_MetasCuatrienioGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MetasCuatrienio  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MetasCuatrienio> GetByFilter(MetasCuatrienio pMetasCuatrienio, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMetasCuatrienio.id== null || pMetasCuatrienio.id==0) ? vintNUll :pMetasCuatrienio.id);
                    p.Add("@Definicion",(pMetasCuatrienio.Definicion== null) ? vintNUll :pMetasCuatrienio.Definicion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MetasCuatrienio> l = SqlMapper.Query<MetasCuatrienio>(con, "API.PA_MetasCuatrienioGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MetasCuatrienio  ->" + ex.Message);
				}
			}

			public MetasCuatrienio Add(MetasCuatrienio pMetasCuatrienio)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMetasCuatrienio.id==null ? 0 : pMetasCuatrienio.id);
                    p.Add("@Definicion", pMetasCuatrienio.Definicion);
                    p.Add("@auditoria", pMetasCuatrienio.auditoria);

                         


                    MetasCuatrienio o = SqlMapper.QueryFirstOrDefault<MetasCuatrienio>(con, "API.PA_MetasCuatrienioAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MetasCuatrienio  ->" + ex.Message);
				}
			}

			public MetasCuatrienio  Update(MetasCuatrienio pMetasCuatrienio)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMetasCuatrienio.id==null ? 0 : pMetasCuatrienio.id);
                    p.Add("@Definicion", pMetasCuatrienio.Definicion);
                    p.Add("@auditoria", pMetasCuatrienio.auditoria);

                         


                    MetasCuatrienio o = SqlMapper.QueryFirstOrDefault<MetasCuatrienio>(con, "API.PA_MetasCuatrienioUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MetasCuatrienio  ->" + ex.Message);
				}
			}

			public bool Delete(MetasCuatrienio pMetasCuatrienio)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMetasCuatrienio.id);
                    p.Add("@auditoria", pMetasCuatrienio.auditoria);

                

 

					MetasCuatrienio o = SqlMapper.QueryFirstOrDefault<MetasCuatrienio>(con, "API.PA_MetasCuatrienioDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MetasCuatrienio  ->" + ex.Message);
				}
			}

		



            public List<MetasCuatrienio> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MetasCuatrienio> MetasCuatrienioList = new List<MetasCuatrienio>();

                    MetasCuatrienioList = SqlMapper.Query<MetasCuatrienio>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MetasCuatrienioList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MetasCuatrienio  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MetasCuatrienio> b)
            {
                DapperPlusManager.Entity<MetasCuatrienio>().Table("MetasCuatrienio");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}