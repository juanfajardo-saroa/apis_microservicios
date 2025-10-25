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
     /// Clase Abstracta para  Frecuencia
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class FrecuenciaRepository : DataObject , IFrecuencia 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public FrecuenciaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public FrecuenciaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Frecuencia GetById(Frecuencia pFrecuencia)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pFrecuencia.id);                                    


    				Frecuencia o = SqlMapper.QueryFirstOrDefault<Frecuencia>(con, "API.PA_FrecuenciaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Frecuencia  ->" + ex.Message);
				}
			}

			public List<Frecuencia> GetAll()
			{
				try 
                {
                        List<Frecuencia> l = SqlMapper.Query<Frecuencia>(con, "API.PA_FrecuenciaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Frecuencia  ->" + ex.Message);
				}
			}

			public List<Frecuencia> GetAllFull()
			{
				try 
				{
                    List<Frecuencia> l = SqlMapper.Query<Frecuencia>(con, "API.PA_FrecuenciaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Frecuencia  ->" + ex.Message);
				}
			}
			
			public List<Frecuencia> GetAllByWithRelation()
			{
				try 
                {
                    List<Frecuencia> l = SqlMapper.Query<Frecuencia>(con, "API.PA_FrecuenciaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Frecuencia  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Frecuencia> GetByFilter(Frecuencia pFrecuencia, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pFrecuencia.id== null || pFrecuencia.id==0) ? vintNUll :pFrecuencia.id);
                    p.Add("@Nombre",(pFrecuencia.Nombre== null) ? vintNUll :pFrecuencia.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Frecuencia> l = SqlMapper.Query<Frecuencia>(con, "API.PA_FrecuenciaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Frecuencia  ->" + ex.Message);
				}
			}

			public Frecuencia Add(Frecuencia pFrecuencia)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pFrecuencia.id==null ? 0 : pFrecuencia.id);
                    p.Add("@Nombre", pFrecuencia.Nombre);
                    p.Add("@auditoria", pFrecuencia.auditoria);

                         


                    Frecuencia o = SqlMapper.QueryFirstOrDefault<Frecuencia>(con, "API.PA_FrecuenciaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Frecuencia  ->" + ex.Message);
				}
			}

			public Frecuencia  Update(Frecuencia pFrecuencia)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pFrecuencia.id==null ? 0 : pFrecuencia.id);
                    p.Add("@Nombre", pFrecuencia.Nombre);
                    p.Add("@auditoria", pFrecuencia.auditoria);

                         


                    Frecuencia o = SqlMapper.QueryFirstOrDefault<Frecuencia>(con, "API.PA_FrecuenciaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Frecuencia  ->" + ex.Message);
				}
			}

			public bool Delete(Frecuencia pFrecuencia)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pFrecuencia.id);
                    p.Add("@auditoria", pFrecuencia.auditoria);

                

 

					Frecuencia o = SqlMapper.QueryFirstOrDefault<Frecuencia>(con, "API.PA_FrecuenciaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Frecuencia  ->" + ex.Message);
				}
			}

		



            public List<Frecuencia> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Frecuencia> FrecuenciaList = new List<Frecuencia>();

                    FrecuenciaList = SqlMapper.Query<Frecuencia>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return FrecuenciaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Frecuencia  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Frecuencia> b)
            {
                DapperPlusManager.Entity<Frecuencia>().Table("Frecuencia");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}