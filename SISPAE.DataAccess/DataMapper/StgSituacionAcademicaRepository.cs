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
     /// Clase Abstracta para  StgSituacionAcademica
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgSituacionAcademicaRepository : DataObject , IStgSituacionAcademica 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgSituacionAcademicaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgSituacionAcademicaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgSituacionAcademica GetById(StgSituacionAcademica pStgSituacionAcademica)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgSituacionAcademica.id);                                    


    				StgSituacionAcademica o = SqlMapper.QueryFirstOrDefault<StgSituacionAcademica>(con, "API.PA_StgSituacionAcademicaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgSituacionAcademica  ->" + ex.Message);
				}
			}

			public List<StgSituacionAcademica> GetAll()
			{
				try 
                {
                        List<StgSituacionAcademica> l = SqlMapper.Query<StgSituacionAcademica>(con, "API.PA_StgSituacionAcademicaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgSituacionAcademica  ->" + ex.Message);
				}
			}

			public List<StgSituacionAcademica> GetAllFull()
			{
				try 
				{
                    List<StgSituacionAcademica> l = SqlMapper.Query<StgSituacionAcademica>(con, "API.PA_StgSituacionAcademicaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgSituacionAcademica  ->" + ex.Message);
				}
			}
			
			public List<StgSituacionAcademica> GetAllByWithRelation()
			{
				try 
                {
                    List<StgSituacionAcademica> l = SqlMapper.Query<StgSituacionAcademica>(con, "API.PA_StgSituacionAcademicaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgSituacionAcademica  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgSituacionAcademica> GetByFilter(StgSituacionAcademica pStgSituacionAcademica, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgSituacionAcademica.id== null || pStgSituacionAcademica.id==0) ? vintNUll :pStgSituacionAcademica.id);
                    p.Add("@IdSituacionAcademica",(pStgSituacionAcademica.IdSituacionAcademica== null) ? vintNUll :pStgSituacionAcademica.IdSituacionAcademica);
                    p.Add("@Nombre",(pStgSituacionAcademica.Nombre== null) ? vintNUll :pStgSituacionAcademica.Nombre);
                    p.Add("@FechaCreacion",(pStgSituacionAcademica.FechaCreacion== null) ? vintNUll :pStgSituacionAcademica.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgSituacionAcademica> l = SqlMapper.Query<StgSituacionAcademica>(con, "API.PA_StgSituacionAcademicaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgSituacionAcademica  ->" + ex.Message);
				}
			}

			public StgSituacionAcademica Add(StgSituacionAcademica pStgSituacionAcademica)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgSituacionAcademica.id==null ? 0 : pStgSituacionAcademica.id);
                    p.Add("@IdSituacionAcademica", pStgSituacionAcademica.IdSituacionAcademica);
                    p.Add("@Nombre", pStgSituacionAcademica.Nombre);
                    p.Add("@FechaCreacion", pStgSituacionAcademica.FechaCreacion);
                    p.Add("@auditoria", pStgSituacionAcademica.auditoria);

                         


                    StgSituacionAcademica o = SqlMapper.QueryFirstOrDefault<StgSituacionAcademica>(con, "API.PA_StgSituacionAcademicaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgSituacionAcademica  ->" + ex.Message);
				}
			}

			public StgSituacionAcademica  Update(StgSituacionAcademica pStgSituacionAcademica)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgSituacionAcademica.id==null ? 0 : pStgSituacionAcademica.id);
                    p.Add("@IdSituacionAcademica", pStgSituacionAcademica.IdSituacionAcademica);
                    p.Add("@Nombre", pStgSituacionAcademica.Nombre);
                    p.Add("@FechaCreacion", pStgSituacionAcademica.FechaCreacion);
                    p.Add("@auditoria", pStgSituacionAcademica.auditoria);

                         


                    StgSituacionAcademica o = SqlMapper.QueryFirstOrDefault<StgSituacionAcademica>(con, "API.PA_StgSituacionAcademicaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgSituacionAcademica  ->" + ex.Message);
				}
			}

			public bool Delete(StgSituacionAcademica pStgSituacionAcademica)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgSituacionAcademica.id);
                    p.Add("@auditoria", pStgSituacionAcademica.auditoria);

                

 

					StgSituacionAcademica o = SqlMapper.QueryFirstOrDefault<StgSituacionAcademica>(con, "API.PA_StgSituacionAcademicaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgSituacionAcademica  ->" + ex.Message);
				}
			}

		



            public List<StgSituacionAcademica> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgSituacionAcademica> StgSituacionAcademicaList = new List<StgSituacionAcademica>();

                    StgSituacionAcademicaList = SqlMapper.Query<StgSituacionAcademica>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgSituacionAcademicaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgSituacionAcademica  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgSituacionAcademica> b)
            {
                DapperPlusManager.Entity<StgSituacionAcademica>().Table("StgSituacionAcademica");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}