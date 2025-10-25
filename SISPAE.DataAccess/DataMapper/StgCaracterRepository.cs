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
     /// Clase Abstracta para  StgCaracter
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgCaracterRepository : DataObject , IStgCaracter 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgCaracterRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgCaracterRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgCaracter GetById(StgCaracter pStgCaracter)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgCaracter.id);                                    


    				StgCaracter o = SqlMapper.QueryFirstOrDefault<StgCaracter>(con, "API.PA_StgCaracterGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgCaracter  ->" + ex.Message);
				}
			}

			public List<StgCaracter> GetAll()
			{
				try 
                {
                        List<StgCaracter> l = SqlMapper.Query<StgCaracter>(con, "API.PA_StgCaracterGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgCaracter  ->" + ex.Message);
				}
			}

			public List<StgCaracter> GetAllFull()
			{
				try 
				{
                    List<StgCaracter> l = SqlMapper.Query<StgCaracter>(con, "API.PA_StgCaracterGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgCaracter  ->" + ex.Message);
				}
			}
			
			public List<StgCaracter> GetAllByWithRelation()
			{
				try 
                {
                    List<StgCaracter> l = SqlMapper.Query<StgCaracter>(con, "API.PA_StgCaracterGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgCaracter  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgCaracter> GetByFilter(StgCaracter pStgCaracter, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgCaracter.id== null || pStgCaracter.id==0) ? vintNUll :pStgCaracter.id);
                    p.Add("@IdCaracter",(pStgCaracter.IdCaracter== null) ? vintNUll :pStgCaracter.IdCaracter);
                    p.Add("@Nombre",(pStgCaracter.Nombre== null) ? vintNUll :pStgCaracter.Nombre);
                    p.Add("@FechaCreacion",(pStgCaracter.FechaCreacion== null) ? vintNUll :pStgCaracter.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgCaracter> l = SqlMapper.Query<StgCaracter>(con, "API.PA_StgCaracterGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgCaracter  ->" + ex.Message);
				}
			}

			public StgCaracter Add(StgCaracter pStgCaracter)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgCaracter.id==null ? 0 : pStgCaracter.id);
                    p.Add("@IdCaracter", pStgCaracter.IdCaracter);
                    p.Add("@Nombre", pStgCaracter.Nombre);
                    p.Add("@FechaCreacion", pStgCaracter.FechaCreacion);
                    p.Add("@auditoria", pStgCaracter.auditoria);

                         


                    StgCaracter o = SqlMapper.QueryFirstOrDefault<StgCaracter>(con, "API.PA_StgCaracterAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgCaracter  ->" + ex.Message);
				}
			}

			public StgCaracter  Update(StgCaracter pStgCaracter)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgCaracter.id==null ? 0 : pStgCaracter.id);
                    p.Add("@IdCaracter", pStgCaracter.IdCaracter);
                    p.Add("@Nombre", pStgCaracter.Nombre);
                    p.Add("@FechaCreacion", pStgCaracter.FechaCreacion);
                    p.Add("@auditoria", pStgCaracter.auditoria);

                         


                    StgCaracter o = SqlMapper.QueryFirstOrDefault<StgCaracter>(con, "API.PA_StgCaracterUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgCaracter  ->" + ex.Message);
				}
			}

			public bool Delete(StgCaracter pStgCaracter)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgCaracter.id);
                    p.Add("@auditoria", pStgCaracter.auditoria);

                

 

					StgCaracter o = SqlMapper.QueryFirstOrDefault<StgCaracter>(con, "API.PA_StgCaracterDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgCaracter  ->" + ex.Message);
				}
			}

		



            public List<StgCaracter> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgCaracter> StgCaracterList = new List<StgCaracter>();

                    StgCaracterList = SqlMapper.Query<StgCaracter>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgCaracterList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgCaracter  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgCaracter> b)
            {
                DapperPlusManager.Entity<StgCaracter>().Table("StgCaracter");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}