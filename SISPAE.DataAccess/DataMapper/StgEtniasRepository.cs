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
     /// Clase Abstracta para  StgEtnias
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgEtniasRepository : DataObject , IStgEtnias 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgEtniasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgEtniasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgEtnias GetById(StgEtnias pStgEtnias)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgEtnias.id);                                    


    				StgEtnias o = SqlMapper.QueryFirstOrDefault<StgEtnias>(con, "API.PA_StgEtniasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgEtnias  ->" + ex.Message);
				}
			}

			public List<StgEtnias> GetAll()
			{
				try 
                {
                        List<StgEtnias> l = SqlMapper.Query<StgEtnias>(con, "API.PA_StgEtniasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgEtnias  ->" + ex.Message);
				}
			}

			public List<StgEtnias> GetAllFull()
			{
				try 
				{
                    List<StgEtnias> l = SqlMapper.Query<StgEtnias>(con, "API.PA_StgEtniasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgEtnias  ->" + ex.Message);
				}
			}
			
			public List<StgEtnias> GetAllByWithRelation()
			{
				try 
                {
                    List<StgEtnias> l = SqlMapper.Query<StgEtnias>(con, "API.PA_StgEtniasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgEtnias  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgEtnias> GetByFilter(StgEtnias pStgEtnias, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgEtnias.id== null || pStgEtnias.id==0) ? vintNUll :pStgEtnias.id);
                    p.Add("@IdEtnias",(pStgEtnias.IdEtnias== null) ? vintNUll :pStgEtnias.IdEtnias);
                    p.Add("@Nombre",(pStgEtnias.Nombre== null) ? vintNUll :pStgEtnias.Nombre);
                    p.Add("@FechaCreacion",(pStgEtnias.FechaCreacion== null) ? vintNUll :pStgEtnias.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgEtnias> l = SqlMapper.Query<StgEtnias>(con, "API.PA_StgEtniasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgEtnias  ->" + ex.Message);
				}
			}

			public StgEtnias Add(StgEtnias pStgEtnias)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgEtnias.id==null ? 0 : pStgEtnias.id);
                    p.Add("@IdEtnias", pStgEtnias.IdEtnias);
                    p.Add("@Nombre", pStgEtnias.Nombre);
                    p.Add("@FechaCreacion", pStgEtnias.FechaCreacion);
                    p.Add("@auditoria", pStgEtnias.auditoria);

                         


                    StgEtnias o = SqlMapper.QueryFirstOrDefault<StgEtnias>(con, "API.PA_StgEtniasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgEtnias  ->" + ex.Message);
				}
			}

			public StgEtnias  Update(StgEtnias pStgEtnias)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgEtnias.id==null ? 0 : pStgEtnias.id);
                    p.Add("@IdEtnias", pStgEtnias.IdEtnias);
                    p.Add("@Nombre", pStgEtnias.Nombre);
                    p.Add("@FechaCreacion", pStgEtnias.FechaCreacion);
                    p.Add("@auditoria", pStgEtnias.auditoria);

                         


                    StgEtnias o = SqlMapper.QueryFirstOrDefault<StgEtnias>(con, "API.PA_StgEtniasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgEtnias  ->" + ex.Message);
				}
			}

			public bool Delete(StgEtnias pStgEtnias)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgEtnias.id);
                    p.Add("@auditoria", pStgEtnias.auditoria);

                

 

					StgEtnias o = SqlMapper.QueryFirstOrDefault<StgEtnias>(con, "API.PA_StgEtniasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgEtnias  ->" + ex.Message);
				}
			}

		



            public List<StgEtnias> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgEtnias> StgEtniasList = new List<StgEtnias>();

                    StgEtniasList = SqlMapper.Query<StgEtnias>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgEtniasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgEtnias  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgEtnias> b)
            {
                DapperPlusManager.Entity<StgEtnias>().Table("StgEtnias");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}