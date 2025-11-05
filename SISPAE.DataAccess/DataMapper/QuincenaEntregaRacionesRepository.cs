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
     /// Clase Abstracta para  QuincenaEntregaRaciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class QuincenaEntregaRacionesRepository : DataObject , IQuincenaEntregaRaciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public QuincenaEntregaRacionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public QuincenaEntregaRacionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public QuincenaEntregaRaciones GetById(QuincenaEntregaRaciones pQuincenaEntregaRaciones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pQuincenaEntregaRaciones.id);                                    


    				QuincenaEntregaRaciones o = SqlMapper.QueryFirstOrDefault<QuincenaEntregaRaciones>(con, "API.PA_QuincenaEntregaRacionesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  QuincenaEntregaRaciones  ->" + ex.Message);
				}
			}

			public List<QuincenaEntregaRaciones> GetAll()
			{
				try 
                {
                        List<QuincenaEntregaRaciones> l = SqlMapper.Query<QuincenaEntregaRaciones>(con, "API.PA_QuincenaEntregaRacionesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  QuincenaEntregaRaciones  ->" + ex.Message);
				}
			}

			public List<QuincenaEntregaRaciones> GetAllFull()
			{
				try 
				{
                    List<QuincenaEntregaRaciones> l = SqlMapper.Query<QuincenaEntregaRaciones>(con, "API.PA_QuincenaEntregaRacionesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  QuincenaEntregaRaciones  ->" + ex.Message);
				}
			}
			
			public List<QuincenaEntregaRaciones> GetAllByWithRelation()
			{
				try 
                {
                    List<QuincenaEntregaRaciones> l = SqlMapper.Query<QuincenaEntregaRaciones>(con, "API.PA_QuincenaEntregaRacionesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  QuincenaEntregaRaciones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<QuincenaEntregaRaciones> GetByFilter(QuincenaEntregaRaciones pQuincenaEntregaRaciones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pQuincenaEntregaRaciones.id== null || pQuincenaEntregaRaciones.id==0) ? vintNUll :pQuincenaEntregaRaciones.id);
                    p.Add("@ID_EstadoQuincena",(pQuincenaEntregaRaciones.ID_EstadoQuincena== null || pQuincenaEntregaRaciones.ID_EstadoQuincena==0) ? vintNUll :pQuincenaEntregaRaciones.ID_EstadoQuincena);
                    p.Add("@ID_Contrato",(pQuincenaEntregaRaciones.ID_Contrato== null || pQuincenaEntregaRaciones.ID_Contrato==0) ? vintNUll :pQuincenaEntregaRaciones.ID_Contrato);
                    p.Add("@ID_GradoSedeJornada",(pQuincenaEntregaRaciones.ID_GradoSedeJornada== null || pQuincenaEntregaRaciones.ID_GradoSedeJornada==0) ? vintNUll :pQuincenaEntregaRaciones.ID_GradoSedeJornada);
                    p.Add("@pathReporteQuincenal", pQuincenaEntregaRaciones.pathReporteQuincenal);
                    p.Add("@fechaCarga", pQuincenaEntregaRaciones.fechaCarga);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<QuincenaEntregaRaciones> l = SqlMapper.Query<QuincenaEntregaRaciones>(con, "API.PA_QuincenaEntregaRacionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  QuincenaEntregaRaciones  ->" + ex.Message);
				}
			}

			public QuincenaEntregaRaciones Add(QuincenaEntregaRaciones pQuincenaEntregaRaciones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pQuincenaEntregaRaciones.id== null ? 0: pQuincenaEntregaRaciones.id);
p.Add("@ID_EstadoQuincena",pQuincenaEntregaRaciones.ID_EstadoQuincena==null ? 0 : pQuincenaEntregaRaciones.ID_EstadoQuincena);
p.Add("@ID_Contrato",pQuincenaEntregaRaciones.ID_Contrato==null ? 0 : pQuincenaEntregaRaciones.ID_Contrato);
p.Add("@ID_GradoSedeJornada",pQuincenaEntregaRaciones.ID_GradoSedeJornada==null ? 0 : pQuincenaEntregaRaciones.ID_GradoSedeJornada);
                    p.Add("@pathReporteQuincenal", pQuincenaEntregaRaciones.pathReporteQuincenal);
                    p.Add("@fechaCarga", pQuincenaEntregaRaciones.fechaCarga);
                    p.Add("@auditoria", pQuincenaEntregaRaciones.auditoria);

                         


                    QuincenaEntregaRaciones o = SqlMapper.QueryFirstOrDefault<QuincenaEntregaRaciones>(con, "API.PA_QuincenaEntregaRacionesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  QuincenaEntregaRaciones  ->" + ex.Message);
				}
			}

			public QuincenaEntregaRaciones  Update(QuincenaEntregaRaciones pQuincenaEntregaRaciones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pQuincenaEntregaRaciones.id== null ? 0: pQuincenaEntregaRaciones.id);
p.Add("@ID_EstadoQuincena",pQuincenaEntregaRaciones.ID_EstadoQuincena==null ? 0 : pQuincenaEntregaRaciones.ID_EstadoQuincena);
p.Add("@ID_Contrato",pQuincenaEntregaRaciones.ID_Contrato==null ? 0 : pQuincenaEntregaRaciones.ID_Contrato);
p.Add("@ID_GradoSedeJornada",pQuincenaEntregaRaciones.ID_GradoSedeJornada==null ? 0 : pQuincenaEntregaRaciones.ID_GradoSedeJornada);
                    p.Add("@pathReporteQuincenal", pQuincenaEntregaRaciones.pathReporteQuincenal);
                    p.Add("@fechaCarga", pQuincenaEntregaRaciones.fechaCarga);
                    p.Add("@auditoria", pQuincenaEntregaRaciones.auditoria);

                         


                    QuincenaEntregaRaciones o = SqlMapper.QueryFirstOrDefault<QuincenaEntregaRaciones>(con, "API.PA_QuincenaEntregaRacionesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  QuincenaEntregaRaciones  ->" + ex.Message);
				}
			}

			public bool Delete(QuincenaEntregaRaciones pQuincenaEntregaRaciones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pQuincenaEntregaRaciones.id);
                    p.Add("@auditoria", pQuincenaEntregaRaciones.auditoria);

                

 

					QuincenaEntregaRaciones o = SqlMapper.QueryFirstOrDefault<QuincenaEntregaRaciones>(con, "API.PA_QuincenaEntregaRacionesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) QuincenaEntregaRaciones  ->" + ex.Message);
				}
			}

		



            public List<QuincenaEntregaRaciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<QuincenaEntregaRaciones> QuincenaEntregaRacionesList = new List<QuincenaEntregaRaciones>();

                    QuincenaEntregaRacionesList = SqlMapper.Query<QuincenaEntregaRaciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return QuincenaEntregaRacionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) QuincenaEntregaRaciones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<QuincenaEntregaRaciones> b)
            {
                DapperPlusManager.Entity<QuincenaEntregaRaciones>().Table("QuincenaEntregaRaciones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}