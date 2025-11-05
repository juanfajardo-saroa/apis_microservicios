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
     /// Clase Abstracta para  IndicadoresMeta
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class IndicadoresMetaRepository : DataObject , IIndicadoresMeta 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public IndicadoresMetaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public IndicadoresMetaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public IndicadoresMeta GetById(IndicadoresMeta pIndicadoresMeta)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pIndicadoresMeta.id);                                    


    				IndicadoresMeta o = SqlMapper.QueryFirstOrDefault<IndicadoresMeta>(con, "API.PA_IndicadoresMetaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  IndicadoresMeta  ->" + ex.Message);
				}
			}

			public List<IndicadoresMeta> GetAll()
			{
				try 
                {
                        List<IndicadoresMeta> l = SqlMapper.Query<IndicadoresMeta>(con, "API.PA_IndicadoresMetaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  IndicadoresMeta  ->" + ex.Message);
				}
			}

			public List<IndicadoresMeta> GetAllFull()
			{
				try 
				{
                    List<IndicadoresMeta> l = SqlMapper.Query<IndicadoresMeta>(con, "API.PA_IndicadoresMetaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  IndicadoresMeta  ->" + ex.Message);
				}
			}
			
			public List<IndicadoresMeta> GetAllByWithRelation()
			{
				try 
                {
                    List<IndicadoresMeta> l = SqlMapper.Query<IndicadoresMeta>(con, "API.PA_IndicadoresMetaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  IndicadoresMeta  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<IndicadoresMeta> GetByFilter(IndicadoresMeta pIndicadoresMeta, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pIndicadoresMeta.id== null || pIndicadoresMeta.id==0) ? vintNUll :pIndicadoresMeta.id);
                    p.Add("@ID_Meta",(pIndicadoresMeta.ID_Meta== null || pIndicadoresMeta.ID_Meta==0) ? vintNUll :pIndicadoresMeta.ID_Meta);
                    p.Add("@Definicion",(pIndicadoresMeta.Definicion== null) ? vintNUll :pIndicadoresMeta.Definicion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<IndicadoresMeta> l = SqlMapper.Query<IndicadoresMeta>(con, "API.PA_IndicadoresMetaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  IndicadoresMeta  ->" + ex.Message);
				}
			}

			public IndicadoresMeta Add(IndicadoresMeta pIndicadoresMeta)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pIndicadoresMeta.id==null ? 0 : pIndicadoresMeta.id);
p.Add("@ID_Meta",pIndicadoresMeta.ID_Meta==null ? 0 : pIndicadoresMeta.ID_Meta);
                    p.Add("@Definicion", pIndicadoresMeta.Definicion);
                    p.Add("@auditoria", pIndicadoresMeta.auditoria);

                         


                    IndicadoresMeta o = SqlMapper.QueryFirstOrDefault<IndicadoresMeta>(con, "API.PA_IndicadoresMetaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  IndicadoresMeta  ->" + ex.Message);
				}
			}

			public IndicadoresMeta  Update(IndicadoresMeta pIndicadoresMeta)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pIndicadoresMeta.id==null ? 0 : pIndicadoresMeta.id);
p.Add("@ID_Meta",pIndicadoresMeta.ID_Meta==null ? 0 : pIndicadoresMeta.ID_Meta);
                    p.Add("@Definicion", pIndicadoresMeta.Definicion);
                    p.Add("@auditoria", pIndicadoresMeta.auditoria);

                         


                    IndicadoresMeta o = SqlMapper.QueryFirstOrDefault<IndicadoresMeta>(con, "API.PA_IndicadoresMetaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  IndicadoresMeta  ->" + ex.Message);
				}
			}

			public bool Delete(IndicadoresMeta pIndicadoresMeta)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pIndicadoresMeta.id);
                    p.Add("@auditoria", pIndicadoresMeta.auditoria);

                

 

					IndicadoresMeta o = SqlMapper.QueryFirstOrDefault<IndicadoresMeta>(con, "API.PA_IndicadoresMetaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) IndicadoresMeta  ->" + ex.Message);
				}
			}

		



            public List<IndicadoresMeta> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<IndicadoresMeta> IndicadoresMetaList = new List<IndicadoresMeta>();

                    IndicadoresMetaList = SqlMapper.Query<IndicadoresMeta>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return IndicadoresMetaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) IndicadoresMeta  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<IndicadoresMeta> b)
            {
                DapperPlusManager.Entity<IndicadoresMeta>().Table("IndicadoresMeta");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}