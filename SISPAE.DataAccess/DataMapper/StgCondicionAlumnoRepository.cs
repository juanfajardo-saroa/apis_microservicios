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
     /// Clase Abstracta para  StgCondicionAlumno
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgCondicionAlumnoRepository : DataObject , IStgCondicionAlumno 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgCondicionAlumnoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgCondicionAlumnoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgCondicionAlumno GetById(StgCondicionAlumno pStgCondicionAlumno)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgCondicionAlumno.id);                                    


    				StgCondicionAlumno o = SqlMapper.QueryFirstOrDefault<StgCondicionAlumno>(con, "API.PA_StgCondicionAlumnoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgCondicionAlumno  ->" + ex.Message);
				}
			}

			public List<StgCondicionAlumno> GetAll()
			{
				try 
                {
                        List<StgCondicionAlumno> l = SqlMapper.Query<StgCondicionAlumno>(con, "API.PA_StgCondicionAlumnoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgCondicionAlumno  ->" + ex.Message);
				}
			}

			public List<StgCondicionAlumno> GetAllFull()
			{
				try 
				{
                    List<StgCondicionAlumno> l = SqlMapper.Query<StgCondicionAlumno>(con, "API.PA_StgCondicionAlumnoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgCondicionAlumno  ->" + ex.Message);
				}
			}
			
			public List<StgCondicionAlumno> GetAllByWithRelation()
			{
				try 
                {
                    List<StgCondicionAlumno> l = SqlMapper.Query<StgCondicionAlumno>(con, "API.PA_StgCondicionAlumnoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgCondicionAlumno  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgCondicionAlumno> GetByFilter(StgCondicionAlumno pStgCondicionAlumno, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgCondicionAlumno.id== null || pStgCondicionAlumno.id==0) ? vintNUll :pStgCondicionAlumno.id);
                    p.Add("@IdCondicionAlumno",(pStgCondicionAlumno.IdCondicionAlumno== null) ? vintNUll :pStgCondicionAlumno.IdCondicionAlumno);
                    p.Add("@Nombre",(pStgCondicionAlumno.Nombre== null) ? vintNUll :pStgCondicionAlumno.Nombre);
                    p.Add("@FechaCreacion",(pStgCondicionAlumno.FechaCreacion== null) ? vintNUll :pStgCondicionAlumno.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgCondicionAlumno> l = SqlMapper.Query<StgCondicionAlumno>(con, "API.PA_StgCondicionAlumnoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgCondicionAlumno  ->" + ex.Message);
				}
			}

			public StgCondicionAlumno Add(StgCondicionAlumno pStgCondicionAlumno)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgCondicionAlumno.id==null ? 0 : pStgCondicionAlumno.id);
                    p.Add("@IdCondicionAlumno", pStgCondicionAlumno.IdCondicionAlumno);
                    p.Add("@Nombre", pStgCondicionAlumno.Nombre);
                    p.Add("@FechaCreacion", pStgCondicionAlumno.FechaCreacion);
                    p.Add("@auditoria", pStgCondicionAlumno.auditoria);

                         


                    StgCondicionAlumno o = SqlMapper.QueryFirstOrDefault<StgCondicionAlumno>(con, "API.PA_StgCondicionAlumnoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgCondicionAlumno  ->" + ex.Message);
				}
			}

			public StgCondicionAlumno  Update(StgCondicionAlumno pStgCondicionAlumno)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgCondicionAlumno.id==null ? 0 : pStgCondicionAlumno.id);
                    p.Add("@IdCondicionAlumno", pStgCondicionAlumno.IdCondicionAlumno);
                    p.Add("@Nombre", pStgCondicionAlumno.Nombre);
                    p.Add("@FechaCreacion", pStgCondicionAlumno.FechaCreacion);
                    p.Add("@auditoria", pStgCondicionAlumno.auditoria);

                         


                    StgCondicionAlumno o = SqlMapper.QueryFirstOrDefault<StgCondicionAlumno>(con, "API.PA_StgCondicionAlumnoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgCondicionAlumno  ->" + ex.Message);
				}
			}

			public bool Delete(StgCondicionAlumno pStgCondicionAlumno)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgCondicionAlumno.id);
                    p.Add("@auditoria", pStgCondicionAlumno.auditoria);

                

 

					StgCondicionAlumno o = SqlMapper.QueryFirstOrDefault<StgCondicionAlumno>(con, "API.PA_StgCondicionAlumnoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgCondicionAlumno  ->" + ex.Message);
				}
			}

		



            public List<StgCondicionAlumno> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgCondicionAlumno> StgCondicionAlumnoList = new List<StgCondicionAlumno>();

                    StgCondicionAlumnoList = SqlMapper.Query<StgCondicionAlumno>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgCondicionAlumnoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgCondicionAlumno  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgCondicionAlumno> b)
            {
                DapperPlusManager.Entity<StgCondicionAlumno>().Table("StgCondicionAlumno");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}