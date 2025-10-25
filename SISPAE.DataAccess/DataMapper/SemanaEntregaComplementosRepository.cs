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
     /// Clase Abstracta para  SemanaEntregaComplementos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SemanaEntregaComplementosRepository : DataObject , ISemanaEntregaComplementos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SemanaEntregaComplementosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SemanaEntregaComplementosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public SemanaEntregaComplementos GetById(SemanaEntregaComplementos pSemanaEntregaComplementos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSemanaEntregaComplementos.id);                                    


    				SemanaEntregaComplementos o = SqlMapper.QueryFirstOrDefault<SemanaEntregaComplementos>(con, "API.PA_SemanaEntregaComplementosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  SemanaEntregaComplementos  ->" + ex.Message);
				}
			}

			public List<SemanaEntregaComplementos> GetAll()
			{
				try 
                {
                        List<SemanaEntregaComplementos> l = SqlMapper.Query<SemanaEntregaComplementos>(con, "API.PA_SemanaEntregaComplementosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  SemanaEntregaComplementos  ->" + ex.Message);
				}
			}

			public List<SemanaEntregaComplementos> GetAllFull()
			{
				try 
				{
                    List<SemanaEntregaComplementos> l = SqlMapper.Query<SemanaEntregaComplementos>(con, "API.PA_SemanaEntregaComplementosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  SemanaEntregaComplementos  ->" + ex.Message);
				}
			}
			
			public List<SemanaEntregaComplementos> GetAllByWithRelation()
			{
				try 
                {
                    List<SemanaEntregaComplementos> l = SqlMapper.Query<SemanaEntregaComplementos>(con, "API.PA_SemanaEntregaComplementosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  SemanaEntregaComplementos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<SemanaEntregaComplementos> GetByFilter(SemanaEntregaComplementos pSemanaEntregaComplementos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSemanaEntregaComplementos.id== null || pSemanaEntregaComplementos.id==0) ? vintNUll :pSemanaEntregaComplementos.id);
                    p.Add("@ID_EstadoSemana",(pSemanaEntregaComplementos.ID_EstadoSemana== null || pSemanaEntregaComplementos.ID_EstadoSemana==0) ? vintNUll :pSemanaEntregaComplementos.ID_EstadoSemana);
                    p.Add("@ID_Contrato",(pSemanaEntregaComplementos.ID_Contrato== null || pSemanaEntregaComplementos.ID_Contrato==0) ? vintNUll :pSemanaEntregaComplementos.ID_Contrato);
                    p.Add("@ID_GradoSedeJornada",(pSemanaEntregaComplementos.ID_GradoSedeJornada== null || pSemanaEntregaComplementos.ID_GradoSedeJornada==0) ? vintNUll :pSemanaEntregaComplementos.ID_GradoSedeJornada);
                    p.Add("@Mes",(pSemanaEntregaComplementos.Mes== null) ? vintNUll :pSemanaEntregaComplementos.Mes);
                    p.Add("@Semana",(pSemanaEntregaComplementos.Semana== null) ? vintNUll :pSemanaEntregaComplementos.Semana);
                    p.Add("@pathReporteSemanal",(pSemanaEntregaComplementos.pathReporteSemanal== null) ? vintNUll :pSemanaEntregaComplementos.pathReporteSemanal);
                    p.Add("@fechaCarga",(pSemanaEntregaComplementos.fechaCarga== null) ? vintNUll :pSemanaEntregaComplementos.fechaCarga);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<SemanaEntregaComplementos> l = SqlMapper.Query<SemanaEntregaComplementos>(con, "API.PA_SemanaEntregaComplementosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  SemanaEntregaComplementos  ->" + ex.Message);
				}
			}

			public SemanaEntregaComplementos Add(SemanaEntregaComplementos pSemanaEntregaComplementos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSemanaEntregaComplementos.id==null ? 0 : pSemanaEntregaComplementos.id);
p.Add("@ID_EstadoSemana",pSemanaEntregaComplementos.ID_EstadoSemana==null ? 0 : pSemanaEntregaComplementos.ID_EstadoSemana);
p.Add("@ID_Contrato",pSemanaEntregaComplementos.ID_Contrato==null ? 0 : pSemanaEntregaComplementos.ID_Contrato);
p.Add("@ID_GradoSedeJornada",pSemanaEntregaComplementos.ID_GradoSedeJornada==null ? 0 : pSemanaEntregaComplementos.ID_GradoSedeJornada);
                    p.Add("@Mes", pSemanaEntregaComplementos.Mes);
p.Add("@Semana",pSemanaEntregaComplementos.Semana==null ? 0 : pSemanaEntregaComplementos.Semana);
                    p.Add("@pathReporteSemanal", pSemanaEntregaComplementos.pathReporteSemanal);
                    p.Add("@fechaCarga", pSemanaEntregaComplementos.fechaCarga);
                    p.Add("@auditoria", pSemanaEntregaComplementos.auditoria);

                         


                    SemanaEntregaComplementos o = SqlMapper.QueryFirstOrDefault<SemanaEntregaComplementos>(con, "API.PA_SemanaEntregaComplementosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  SemanaEntregaComplementos  ->" + ex.Message);
				}
			}

			public SemanaEntregaComplementos  Update(SemanaEntregaComplementos pSemanaEntregaComplementos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSemanaEntregaComplementos.id==null ? 0 : pSemanaEntregaComplementos.id);
p.Add("@ID_EstadoSemana",pSemanaEntregaComplementos.ID_EstadoSemana==null ? 0 : pSemanaEntregaComplementos.ID_EstadoSemana);
p.Add("@ID_Contrato",pSemanaEntregaComplementos.ID_Contrato==null ? 0 : pSemanaEntregaComplementos.ID_Contrato);
p.Add("@ID_GradoSedeJornada",pSemanaEntregaComplementos.ID_GradoSedeJornada==null ? 0 : pSemanaEntregaComplementos.ID_GradoSedeJornada);
                    p.Add("@Mes", pSemanaEntregaComplementos.Mes);
p.Add("@Semana",pSemanaEntregaComplementos.Semana==null ? 0 : pSemanaEntregaComplementos.Semana);
                    p.Add("@pathReporteSemanal", pSemanaEntregaComplementos.pathReporteSemanal);
                    p.Add("@fechaCarga", pSemanaEntregaComplementos.fechaCarga);
                    p.Add("@auditoria", pSemanaEntregaComplementos.auditoria);

                         


                    SemanaEntregaComplementos o = SqlMapper.QueryFirstOrDefault<SemanaEntregaComplementos>(con, "API.PA_SemanaEntregaComplementosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  SemanaEntregaComplementos  ->" + ex.Message);
				}
			}

			public bool Delete(SemanaEntregaComplementos pSemanaEntregaComplementos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSemanaEntregaComplementos.id);
                    p.Add("@auditoria", pSemanaEntregaComplementos.auditoria);

                

 

					SemanaEntregaComplementos o = SqlMapper.QueryFirstOrDefault<SemanaEntregaComplementos>(con, "API.PA_SemanaEntregaComplementosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) SemanaEntregaComplementos  ->" + ex.Message);
				}
			}

		



            public List<SemanaEntregaComplementos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<SemanaEntregaComplementos> SemanaEntregaComplementosList = new List<SemanaEntregaComplementos>();

                    SemanaEntregaComplementosList = SqlMapper.Query<SemanaEntregaComplementos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SemanaEntregaComplementosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) SemanaEntregaComplementos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<SemanaEntregaComplementos> b)
            {
                DapperPlusManager.Entity<SemanaEntregaComplementos>().Table("SemanaEntregaComplementos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}