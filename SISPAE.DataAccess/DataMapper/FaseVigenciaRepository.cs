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
     /// Clase Abstracta para  FaseVigencia
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class FaseVigenciaRepository : DataObject , IFaseVigencia 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public FaseVigenciaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public FaseVigenciaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public FaseVigencia GetById(FaseVigencia pFaseVigencia)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pFaseVigencia.id);                                    


    				FaseVigencia o = SqlMapper.QueryFirstOrDefault<FaseVigencia>(con, "API.PA_FaseVigenciaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  FaseVigencia  ->" + ex.Message);
				}
			}

			public List<FaseVigencia> GetAll()
			{
				try 
                {
                        List<FaseVigencia> l = SqlMapper.Query<FaseVigencia>(con, "API.PA_FaseVigenciaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  FaseVigencia  ->" + ex.Message);
				}
			}

			public List<FaseVigencia> GetAllFull()
			{
				try 
				{
                    List<FaseVigencia> l = SqlMapper.Query<FaseVigencia>(con, "API.PA_FaseVigenciaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  FaseVigencia  ->" + ex.Message);
				}
			}
			
			public List<FaseVigencia> GetAllByWithRelation()
			{
				try 
                {
                    List<FaseVigencia> l = SqlMapper.Query<FaseVigencia>(con, "API.PA_FaseVigenciaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  FaseVigencia  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<FaseVigencia> GetByFilter(FaseVigencia pFaseVigencia, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pFaseVigencia.id== null || pFaseVigencia.id==0) ? vintNUll :pFaseVigencia.id);
                    p.Add("@Nombre",(pFaseVigencia.Nombre== null) ? vintNUll :pFaseVigencia.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<FaseVigencia> l = SqlMapper.Query<FaseVigencia>(con, "API.PA_FaseVigenciaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  FaseVigencia  ->" + ex.Message);
				}
			}

			public FaseVigencia Add(FaseVigencia pFaseVigencia)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pFaseVigencia.id==null ? 0 : pFaseVigencia.id);
                    p.Add("@Nombre", pFaseVigencia.Nombre);
                    p.Add("@auditoria", pFaseVigencia.auditoria);

                         


                    FaseVigencia o = SqlMapper.QueryFirstOrDefault<FaseVigencia>(con, "API.PA_FaseVigenciaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  FaseVigencia  ->" + ex.Message);
				}
			}

			public FaseVigencia  Update(FaseVigencia pFaseVigencia)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pFaseVigencia.id==null ? 0 : pFaseVigencia.id);
                    p.Add("@Nombre", pFaseVigencia.Nombre);
                    p.Add("@auditoria", pFaseVigencia.auditoria);

                         


                    FaseVigencia o = SqlMapper.QueryFirstOrDefault<FaseVigencia>(con, "API.PA_FaseVigenciaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  FaseVigencia  ->" + ex.Message);
				}
			}

			public bool Delete(FaseVigencia pFaseVigencia)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pFaseVigencia.id);
                    p.Add("@auditoria", pFaseVigencia.auditoria);

                

 

					FaseVigencia o = SqlMapper.QueryFirstOrDefault<FaseVigencia>(con, "API.PA_FaseVigenciaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) FaseVigencia  ->" + ex.Message);
				}
			}

		



            public List<FaseVigencia> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<FaseVigencia> FaseVigenciaList = new List<FaseVigencia>();

                    FaseVigenciaList = SqlMapper.Query<FaseVigencia>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return FaseVigenciaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) FaseVigencia  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<FaseVigencia> b)
            {
                DapperPlusManager.Entity<FaseVigencia>().Table("FaseVigencia");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}