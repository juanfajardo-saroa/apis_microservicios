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
     /// Clase Abstracta para  StgFuenteRecurso
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgFuenteRecursoRepository : DataObject , IStgFuenteRecurso 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgFuenteRecursoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgFuenteRecursoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgFuenteRecurso GetById(StgFuenteRecurso pStgFuenteRecurso)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgFuenteRecurso.id);                                    


    				StgFuenteRecurso o = SqlMapper.QueryFirstOrDefault<StgFuenteRecurso>(con, "API.PA_StgFuenteRecursoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgFuenteRecurso  ->" + ex.Message);
				}
			}

			public List<StgFuenteRecurso> GetAll()
			{
				try 
                {
                        List<StgFuenteRecurso> l = SqlMapper.Query<StgFuenteRecurso>(con, "API.PA_StgFuenteRecursoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgFuenteRecurso  ->" + ex.Message);
				}
			}

			public List<StgFuenteRecurso> GetAllFull()
			{
				try 
				{
                    List<StgFuenteRecurso> l = SqlMapper.Query<StgFuenteRecurso>(con, "API.PA_StgFuenteRecursoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgFuenteRecurso  ->" + ex.Message);
				}
			}
			
			public List<StgFuenteRecurso> GetAllByWithRelation()
			{
				try 
                {
                    List<StgFuenteRecurso> l = SqlMapper.Query<StgFuenteRecurso>(con, "API.PA_StgFuenteRecursoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgFuenteRecurso  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgFuenteRecurso> GetByFilter(StgFuenteRecurso pStgFuenteRecurso, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgFuenteRecurso.id== null || pStgFuenteRecurso.id==0) ? vintNUll :pStgFuenteRecurso.id);
                    p.Add("@IdFuenteRecurso",(pStgFuenteRecurso.IdFuenteRecurso== null) ? vintNUll :pStgFuenteRecurso.IdFuenteRecurso);
                    p.Add("@Nombre",(pStgFuenteRecurso.Nombre== null) ? vintNUll :pStgFuenteRecurso.Nombre);
                    p.Add("@FechaCreacion",(pStgFuenteRecurso.FechaCreacion== null) ? vintNUll :pStgFuenteRecurso.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgFuenteRecurso> l = SqlMapper.Query<StgFuenteRecurso>(con, "API.PA_StgFuenteRecursoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgFuenteRecurso  ->" + ex.Message);
				}
			}

			public StgFuenteRecurso Add(StgFuenteRecurso pStgFuenteRecurso)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgFuenteRecurso.id==null ? 0 : pStgFuenteRecurso.id);
                    p.Add("@IdFuenteRecurso", pStgFuenteRecurso.IdFuenteRecurso);
                    p.Add("@Nombre", pStgFuenteRecurso.Nombre);
                    p.Add("@FechaCreacion", pStgFuenteRecurso.FechaCreacion);
                    p.Add("@auditoria", pStgFuenteRecurso.auditoria);

                         


                    StgFuenteRecurso o = SqlMapper.QueryFirstOrDefault<StgFuenteRecurso>(con, "API.PA_StgFuenteRecursoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgFuenteRecurso  ->" + ex.Message);
				}
			}

			public StgFuenteRecurso  Update(StgFuenteRecurso pStgFuenteRecurso)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgFuenteRecurso.id==null ? 0 : pStgFuenteRecurso.id);
                    p.Add("@IdFuenteRecurso", pStgFuenteRecurso.IdFuenteRecurso);
                    p.Add("@Nombre", pStgFuenteRecurso.Nombre);
                    p.Add("@FechaCreacion", pStgFuenteRecurso.FechaCreacion);
                    p.Add("@auditoria", pStgFuenteRecurso.auditoria);

                         


                    StgFuenteRecurso o = SqlMapper.QueryFirstOrDefault<StgFuenteRecurso>(con, "API.PA_StgFuenteRecursoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgFuenteRecurso  ->" + ex.Message);
				}
			}

			public bool Delete(StgFuenteRecurso pStgFuenteRecurso)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgFuenteRecurso.id);
                    p.Add("@auditoria", pStgFuenteRecurso.auditoria);

                

 

					StgFuenteRecurso o = SqlMapper.QueryFirstOrDefault<StgFuenteRecurso>(con, "API.PA_StgFuenteRecursoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgFuenteRecurso  ->" + ex.Message);
				}
			}

		



            public List<StgFuenteRecurso> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgFuenteRecurso> StgFuenteRecursoList = new List<StgFuenteRecurso>();

                    StgFuenteRecursoList = SqlMapper.Query<StgFuenteRecurso>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgFuenteRecursoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgFuenteRecurso  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgFuenteRecurso> b)
            {
                DapperPlusManager.Entity<StgFuenteRecurso>().Table("StgFuenteRecurso");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}