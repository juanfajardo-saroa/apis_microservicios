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
     /// Clase Abstracta para  EncabezadoMatricula
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class EncabezadoMatriculaRepository : DataObject , IEncabezadoMatricula 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public EncabezadoMatriculaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public EncabezadoMatriculaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public EncabezadoMatricula GetById(EncabezadoMatricula pEncabezadoMatricula)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@ID",pEncabezadoMatricula.ID);                                    


    				EncabezadoMatricula o = SqlMapper.QueryFirstOrDefault<EncabezadoMatricula>(con, "API.PA_EncabezadoMatriculaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  EncabezadoMatricula  ->" + ex.Message);
				}
			}

			public List<EncabezadoMatricula> GetAll()
			{
				try 
                {
                        List<EncabezadoMatricula> l = SqlMapper.Query<EncabezadoMatricula>(con, "API.PA_EncabezadoMatriculaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  EncabezadoMatricula  ->" + ex.Message);
				}
			}

			public List<EncabezadoMatricula> GetAllFull()
			{
				try 
				{
                    List<EncabezadoMatricula> l = SqlMapper.Query<EncabezadoMatricula>(con, "API.PA_EncabezadoMatriculaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  EncabezadoMatricula  ->" + ex.Message);
				}
			}
			
			public List<EncabezadoMatricula> GetAllByWithRelation()
			{
				try 
                {
                    List<EncabezadoMatricula> l = SqlMapper.Query<EncabezadoMatricula>(con, "API.PA_EncabezadoMatriculaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  EncabezadoMatricula  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<EncabezadoMatricula> GetByFilter(EncabezadoMatricula pEncabezadoMatricula, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ID",(pEncabezadoMatricula.ID== null || pEncabezadoMatricula.ID==0) ? vintNUll :pEncabezadoMatricula.ID);
                    p.Add("@ID_ETC",(pEncabezadoMatricula.ID_ETC== null || pEncabezadoMatricula.ID_ETC==0) ? vintNUll :pEncabezadoMatricula.ID_ETC);
                    p.Add("@ID_TipoProcesoCarga",(pEncabezadoMatricula.ID_TipoProcesoCarga== null || pEncabezadoMatricula.ID_TipoProcesoCarga==0) ? vintNUll :pEncabezadoMatricula.ID_TipoProcesoCarga);
                    p.Add("@ID_EstadoCargue",(pEncabezadoMatricula.ID_EstadoCargue== null || pEncabezadoMatricula.ID_EstadoCargue==0) ? vintNUll :pEncabezadoMatricula.ID_EstadoCargue);
                    p.Add("@Fecha",(pEncabezadoMatricula.Fecha== null) ? vintNUll :pEncabezadoMatricula.Fecha);
                    p.Add("@Agno",(pEncabezadoMatricula.Agno== null) ? vintNUll :pEncabezadoMatricula.Agno);
                    p.Add("@Mes",(pEncabezadoMatricula.Mes== null) ? vintNUll :pEncabezadoMatricula.Mes);
                    p.Add("@NombreArchivo",(pEncabezadoMatricula.NombreArchivo== null) ? vintNUll :pEncabezadoMatricula.NombreArchivo);
                    p.Add("@TotalRegistros",(pEncabezadoMatricula.TotalRegistros== null) ? vintNUll :pEncabezadoMatricula.TotalRegistros);
                    p.Add("@TotalRegistroOK",(pEncabezadoMatricula.TotalRegistroOK== null) ? vintNUll :pEncabezadoMatricula.TotalRegistroOK);
                    p.Add("@TotalResgistroError",(pEncabezadoMatricula.TotalResgistroError== null) ? vintNUll :pEncabezadoMatricula.TotalResgistroError);
                    p.Add("@MatriculaSectorOficial",(pEncabezadoMatricula.MatriculaSectorOficial== null) ? vintNUll :pEncabezadoMatricula.MatriculaSectorOficial);
                    p.Add("@json",(pEncabezadoMatricula.json== null) ? vintNUll :pEncabezadoMatricula.json);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<EncabezadoMatricula> l = SqlMapper.Query<EncabezadoMatricula>(con, "API.PA_EncabezadoMatriculaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  EncabezadoMatricula  ->" + ex.Message);
				}
			}

			public EncabezadoMatricula Add(EncabezadoMatricula pEncabezadoMatricula)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ID",pEncabezadoMatricula.ID==null ? 0 : pEncabezadoMatricula.ID);
p.Add("@ID_ETC",pEncabezadoMatricula.ID_ETC==null ? 0 : pEncabezadoMatricula.ID_ETC);
p.Add("@ID_TipoProcesoCarga",pEncabezadoMatricula.ID_TipoProcesoCarga==null ? 0 : pEncabezadoMatricula.ID_TipoProcesoCarga);
p.Add("@ID_EstadoCargue",pEncabezadoMatricula.ID_EstadoCargue==null ? 0 : pEncabezadoMatricula.ID_EstadoCargue);
                    p.Add("@Fecha", pEncabezadoMatricula.Fecha);
p.Add("@Agno",pEncabezadoMatricula.Agno==null ? 0 : pEncabezadoMatricula.Agno);
p.Add("@Mes",pEncabezadoMatricula.Mes==null ? 0 : pEncabezadoMatricula.Mes);
                    p.Add("@NombreArchivo", pEncabezadoMatricula.NombreArchivo);
p.Add("@TotalRegistros",pEncabezadoMatricula.TotalRegistros==null ? 0 : pEncabezadoMatricula.TotalRegistros);
p.Add("@TotalRegistroOK",pEncabezadoMatricula.TotalRegistroOK==null ? 0 : pEncabezadoMatricula.TotalRegistroOK);
p.Add("@TotalResgistroError",pEncabezadoMatricula.TotalResgistroError==null ? 0 : pEncabezadoMatricula.TotalResgistroError);
                    p.Add("@MatriculaSectorOficial", pEncabezadoMatricula.MatriculaSectorOficial);
                    p.Add("@json", pEncabezadoMatricula.json);
                    p.Add("@auditoria", pEncabezadoMatricula.auditoria);

                         


                    EncabezadoMatricula o = SqlMapper.QueryFirstOrDefault<EncabezadoMatricula>(con, "API.PA_EncabezadoMatriculaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  EncabezadoMatricula  ->" + ex.Message);
				}
			}

			public EncabezadoMatricula  Update(EncabezadoMatricula pEncabezadoMatricula)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ID",pEncabezadoMatricula.ID==null ? 0 : pEncabezadoMatricula.ID);
p.Add("@ID_ETC",pEncabezadoMatricula.ID_ETC==null ? 0 : pEncabezadoMatricula.ID_ETC);
p.Add("@ID_TipoProcesoCarga",pEncabezadoMatricula.ID_TipoProcesoCarga==null ? 0 : pEncabezadoMatricula.ID_TipoProcesoCarga);
p.Add("@ID_EstadoCargue",pEncabezadoMatricula.ID_EstadoCargue==null ? 0 : pEncabezadoMatricula.ID_EstadoCargue);
                    p.Add("@Fecha", pEncabezadoMatricula.Fecha);
p.Add("@Agno",pEncabezadoMatricula.Agno==null ? 0 : pEncabezadoMatricula.Agno);
p.Add("@Mes",pEncabezadoMatricula.Mes==null ? 0 : pEncabezadoMatricula.Mes);
                    p.Add("@NombreArchivo", pEncabezadoMatricula.NombreArchivo);
p.Add("@TotalRegistros",pEncabezadoMatricula.TotalRegistros==null ? 0 : pEncabezadoMatricula.TotalRegistros);
p.Add("@TotalRegistroOK",pEncabezadoMatricula.TotalRegistroOK==null ? 0 : pEncabezadoMatricula.TotalRegistroOK);
p.Add("@TotalResgistroError",pEncabezadoMatricula.TotalResgistroError==null ? 0 : pEncabezadoMatricula.TotalResgistroError);
                    p.Add("@MatriculaSectorOficial", pEncabezadoMatricula.MatriculaSectorOficial);
                    p.Add("@json", pEncabezadoMatricula.json);
                    p.Add("@auditoria", pEncabezadoMatricula.auditoria);

                         


                    EncabezadoMatricula o = SqlMapper.QueryFirstOrDefault<EncabezadoMatricula>(con, "API.PA_EncabezadoMatriculaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  EncabezadoMatricula  ->" + ex.Message);
				}
			}

			public bool Delete(EncabezadoMatricula pEncabezadoMatricula)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@ID",pEncabezadoMatricula.ID);
                    p.Add("@auditoria", pEncabezadoMatricula.auditoria);

                

 

					EncabezadoMatricula o = SqlMapper.QueryFirstOrDefault<EncabezadoMatricula>(con, "API.PA_EncabezadoMatriculaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) EncabezadoMatricula  ->" + ex.Message);
				}
			}

		



            public List<EncabezadoMatricula> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<EncabezadoMatricula> EncabezadoMatriculaList = new List<EncabezadoMatricula>();

                    EncabezadoMatriculaList = SqlMapper.Query<EncabezadoMatricula>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return EncabezadoMatriculaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) EncabezadoMatricula  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<EncabezadoMatricula> b)
            {
                DapperPlusManager.Entity<EncabezadoMatricula>().Table("EncabezadoMatricula");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}