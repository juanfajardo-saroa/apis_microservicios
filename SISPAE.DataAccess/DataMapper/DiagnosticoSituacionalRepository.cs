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
     /// Clase Abstracta para  DiagnosticoSituacional
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class DiagnosticoSituacionalRepository : DataObject , IDiagnosticoSituacional 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public DiagnosticoSituacionalRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public DiagnosticoSituacionalRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public DiagnosticoSituacional GetById(DiagnosticoSituacional pDiagnosticoSituacional)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pDiagnosticoSituacional.id);                                    


    				DiagnosticoSituacional o = SqlMapper.QueryFirstOrDefault<DiagnosticoSituacional>(con, "API.PA_DiagnosticoSituacionalGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  DiagnosticoSituacional  ->" + ex.Message);
				}
			}

			public List<DiagnosticoSituacional> GetAll()
			{
				try 
                {
                        List<DiagnosticoSituacional> l = SqlMapper.Query<DiagnosticoSituacional>(con, "API.PA_DiagnosticoSituacionalGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  DiagnosticoSituacional  ->" + ex.Message);
				}
			}

			public List<DiagnosticoSituacional> GetAllFull()
			{
				try 
				{
                    List<DiagnosticoSituacional> l = SqlMapper.Query<DiagnosticoSituacional>(con, "API.PA_DiagnosticoSituacionalGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  DiagnosticoSituacional  ->" + ex.Message);
				}
			}
			
			public List<DiagnosticoSituacional> GetAllByWithRelation()
			{
				try 
                {
                    List<DiagnosticoSituacional> l = SqlMapper.Query<DiagnosticoSituacional>(con, "API.PA_DiagnosticoSituacionalGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  DiagnosticoSituacional  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<DiagnosticoSituacional> GetByFilter(DiagnosticoSituacional pDiagnosticoSituacional, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pDiagnosticoSituacional.id== null || pDiagnosticoSituacional.id==0) ? vintNUll :pDiagnosticoSituacional.id);
                    p.Add("@Nombre",(pDiagnosticoSituacional.Nombre== null) ? vintNUll :pDiagnosticoSituacional.Nombre);
                    p.Add("@FechaActualizacion",(pDiagnosticoSituacional.FechaActualizacion== null) ? vintNUll :pDiagnosticoSituacional.FechaActualizacion);
                    p.Add("@DescripcionDiagnostico",(pDiagnosticoSituacional.DescripcionDiagnostico== null) ? vintNUll :pDiagnosticoSituacional.DescripcionDiagnostico);
                    p.Add("@PATHDiasnosticoSituacion",(pDiagnosticoSituacional.PATHDiasnosticoSituacion== null) ? vintNUll :pDiagnosticoSituacional.PATHDiasnosticoSituacion);
                    p.Add("@Id_ETC",(pDiagnosticoSituacional.Id_ETC== null || pDiagnosticoSituacional.Id_ETC==0) ? vintNUll :pDiagnosticoSituacional.Id_ETC);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<DiagnosticoSituacional> l = SqlMapper.Query<DiagnosticoSituacional>(con, "API.PA_DiagnosticoSituacionalGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  DiagnosticoSituacional  ->" + ex.Message);
				}
			}

			public DiagnosticoSituacional Add(DiagnosticoSituacional pDiagnosticoSituacional)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pDiagnosticoSituacional.id==null ? 0 : pDiagnosticoSituacional.id);
                    p.Add("@Nombre", pDiagnosticoSituacional.Nombre);
                    p.Add("@FechaActualizacion", pDiagnosticoSituacional.FechaActualizacion);
                    p.Add("@DescripcionDiagnostico", pDiagnosticoSituacional.DescripcionDiagnostico);
                    p.Add("@PATHDiasnosticoSituacion", pDiagnosticoSituacional.PATHDiasnosticoSituacion);
p.Add("@Id_ETC",pDiagnosticoSituacional.Id_ETC==null ? 0 : pDiagnosticoSituacional.Id_ETC);
                    p.Add("@auditoria", pDiagnosticoSituacional.auditoria);

                         


                    DiagnosticoSituacional o = SqlMapper.QueryFirstOrDefault<DiagnosticoSituacional>(con, "API.PA_DiagnosticoSituacionalAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  DiagnosticoSituacional  ->" + ex.Message);
				}
			}

			public DiagnosticoSituacional  Update(DiagnosticoSituacional pDiagnosticoSituacional)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pDiagnosticoSituacional.id==null ? 0 : pDiagnosticoSituacional.id);
                    p.Add("@Nombre", pDiagnosticoSituacional.Nombre);
                    p.Add("@FechaActualizacion", pDiagnosticoSituacional.FechaActualizacion);
                    p.Add("@DescripcionDiagnostico", pDiagnosticoSituacional.DescripcionDiagnostico);
                    p.Add("@PATHDiasnosticoSituacion", pDiagnosticoSituacional.PATHDiasnosticoSituacion);
p.Add("@Id_ETC",pDiagnosticoSituacional.Id_ETC==null ? 0 : pDiagnosticoSituacional.Id_ETC);
                    p.Add("@auditoria", pDiagnosticoSituacional.auditoria);

                         


                    DiagnosticoSituacional o = SqlMapper.QueryFirstOrDefault<DiagnosticoSituacional>(con, "API.PA_DiagnosticoSituacionalUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  DiagnosticoSituacional  ->" + ex.Message);
				}
			}

			public bool Delete(DiagnosticoSituacional pDiagnosticoSituacional)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pDiagnosticoSituacional.id);
                    p.Add("@auditoria", pDiagnosticoSituacional.auditoria);

                

 

					DiagnosticoSituacional o = SqlMapper.QueryFirstOrDefault<DiagnosticoSituacional>(con, "API.PA_DiagnosticoSituacionalDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) DiagnosticoSituacional  ->" + ex.Message);
				}
			}

		



            public List<DiagnosticoSituacional> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<DiagnosticoSituacional> DiagnosticoSituacionalList = new List<DiagnosticoSituacional>();

                    DiagnosticoSituacionalList = SqlMapper.Query<DiagnosticoSituacional>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return DiagnosticoSituacionalList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) DiagnosticoSituacional  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<DiagnosticoSituacional> b)
            {
                DapperPlusManager.Entity<DiagnosticoSituacional>().Table("DiagnosticoSituacional");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}