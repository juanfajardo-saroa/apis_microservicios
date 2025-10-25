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
     /// Clase Abstracta para  StgGrados
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgGradosRepository : DataObject , IStgGrados 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgGradosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgGradosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgGrados GetById(StgGrados pStgGrados)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgGrados.id);                                    


    				StgGrados o = SqlMapper.QueryFirstOrDefault<StgGrados>(con, "API.PA_StgGradosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgGrados  ->" + ex.Message);
				}
			}

			public List<StgGrados> GetAll()
			{
				try 
                {
                        List<StgGrados> l = SqlMapper.Query<StgGrados>(con, "API.PA_StgGradosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgGrados  ->" + ex.Message);
				}
			}

			public List<StgGrados> GetAllFull()
			{
				try 
				{
                    List<StgGrados> l = SqlMapper.Query<StgGrados>(con, "API.PA_StgGradosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgGrados  ->" + ex.Message);
				}
			}
			
			public List<StgGrados> GetAllByWithRelation()
			{
				try 
                {
                    List<StgGrados> l = SqlMapper.Query<StgGrados>(con, "API.PA_StgGradosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgGrados  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgGrados> GetByFilter(StgGrados pStgGrados, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgGrados.id== null || pStgGrados.id==0) ? vintNUll :pStgGrados.id);
                    p.Add("@IdGrado",(pStgGrados.IdGrado== null || pStgGrados.IdGrado==0) ? vintNUll :pStgGrados.IdGrado);
                    p.Add("@Grado",(pStgGrados.Grado== null) ? vintNUll :pStgGrados.Grado);
                    p.Add("@LimiteEdad",(pStgGrados.LimiteEdad== null) ? vintNUll :pStgGrados.LimiteEdad);
                    p.Add("@IdNivel",(pStgGrados.IdNivel== null || pStgGrados.IdNivel==0) ? vintNUll :pStgGrados.IdNivel);
                    p.Add("@IdNivelMediaTotal",(pStgGrados.IdNivelMediaTotal== null || pStgGrados.IdNivelMediaTotal==0) ? vintNUll :pStgGrados.IdNivelMediaTotal);
                    p.Add("@IdNivelCine",(pStgGrados.IdNivelCine== null || pStgGrados.IdNivelCine==0) ? vintNUll :pStgGrados.IdNivelCine);
                    p.Add("@created_at",(pStgGrados.created_at== null) ? vintNUll :pStgGrados.created_at);
                    p.Add("@updated_at",(pStgGrados.updated_at== null) ? vintNUll :pStgGrados.updated_at);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgGrados> l = SqlMapper.Query<StgGrados>(con, "API.PA_StgGradosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgGrados  ->" + ex.Message);
				}
			}

			public StgGrados Add(StgGrados pStgGrados)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgGrados.id==null ? 0 : pStgGrados.id);
p.Add("@IdGrado",pStgGrados.IdGrado==null ? 0 : pStgGrados.IdGrado);
                    p.Add("@Grado", pStgGrados.Grado);
p.Add("@LimiteEdad",pStgGrados.LimiteEdad==null ? 0 : pStgGrados.LimiteEdad);
p.Add("@IdNivel",pStgGrados.IdNivel==null ? 0 : pStgGrados.IdNivel);
p.Add("@IdNivelMediaTotal",pStgGrados.IdNivelMediaTotal==null ? 0 : pStgGrados.IdNivelMediaTotal);
p.Add("@IdNivelCine",pStgGrados.IdNivelCine==null ? 0 : pStgGrados.IdNivelCine);
                    p.Add("@created_at", pStgGrados.created_at);
                    p.Add("@updated_at", pStgGrados.updated_at);
                    p.Add("@auditoria", pStgGrados.auditoria);

                         


                    StgGrados o = SqlMapper.QueryFirstOrDefault<StgGrados>(con, "API.PA_StgGradosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgGrados  ->" + ex.Message);
				}
			}

			public StgGrados  Update(StgGrados pStgGrados)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgGrados.id==null ? 0 : pStgGrados.id);
p.Add("@IdGrado",pStgGrados.IdGrado==null ? 0 : pStgGrados.IdGrado);
                    p.Add("@Grado", pStgGrados.Grado);
p.Add("@LimiteEdad",pStgGrados.LimiteEdad==null ? 0 : pStgGrados.LimiteEdad);
p.Add("@IdNivel",pStgGrados.IdNivel==null ? 0 : pStgGrados.IdNivel);
p.Add("@IdNivelMediaTotal",pStgGrados.IdNivelMediaTotal==null ? 0 : pStgGrados.IdNivelMediaTotal);
p.Add("@IdNivelCine",pStgGrados.IdNivelCine==null ? 0 : pStgGrados.IdNivelCine);
                    p.Add("@created_at", pStgGrados.created_at);
                    p.Add("@updated_at", pStgGrados.updated_at);
                    p.Add("@auditoria", pStgGrados.auditoria);

                         


                    StgGrados o = SqlMapper.QueryFirstOrDefault<StgGrados>(con, "API.PA_StgGradosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgGrados  ->" + ex.Message);
				}
			}

			public bool Delete(StgGrados pStgGrados)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgGrados.id);
                    p.Add("@auditoria", pStgGrados.auditoria);

                

 

					StgGrados o = SqlMapper.QueryFirstOrDefault<StgGrados>(con, "API.PA_StgGradosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgGrados  ->" + ex.Message);
				}
			}

		



            public List<StgGrados> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgGrados> StgGradosList = new List<StgGrados>();

                    StgGradosList = SqlMapper.Query<StgGrados>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgGradosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgGrados  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgGrados> b)
            {
                DapperPlusManager.Entity<StgGrados>().Table("StgGrados");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}