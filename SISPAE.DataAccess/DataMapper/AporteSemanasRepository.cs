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
     /// Clase Abstracta para  AporteSemanas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AporteSemanasRepository : DataObject , IAporteSemanas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AporteSemanasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AporteSemanasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AporteSemanas GetById(AporteSemanas pAporteSemanas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAporteSemanas.id);                                    


    				AporteSemanas o = SqlMapper.QueryFirstOrDefault<AporteSemanas>(con, "API.PA_AporteSemanasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AporteSemanas  ->" + ex.Message);
				}
			}

			public List<AporteSemanas> GetAll()
			{
				try 
                {
                        List<AporteSemanas> l = SqlMapper.Query<AporteSemanas>(con, "API.PA_AporteSemanasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AporteSemanas  ->" + ex.Message);
				}
			}

			public List<AporteSemanas> GetAllFull()
			{
				try 
				{
                    List<AporteSemanas> l = SqlMapper.Query<AporteSemanas>(con, "API.PA_AporteSemanasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AporteSemanas  ->" + ex.Message);
				}
			}
			
			public List<AporteSemanas> GetAllByWithRelation()
			{
				try 
                {
                    List<AporteSemanas> l = SqlMapper.Query<AporteSemanas>(con, "API.PA_AporteSemanasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AporteSemanas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AporteSemanas> GetByFilter(AporteSemanas pAporteSemanas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAporteSemanas.id== null || pAporteSemanas.id==0) ? vintNUll :pAporteSemanas.id);
                    p.Add("@ID_Semana",(pAporteSemanas.ID_Semana== null || pAporteSemanas.ID_Semana==0) ? vintNUll :pAporteSemanas.ID_Semana);
                    p.Add("@ID_Nutriente",(pAporteSemanas.ID_Nutriente== null || pAporteSemanas.ID_Nutriente==0) ? vintNUll :pAporteSemanas.ID_Nutriente);
                    p.Add("@ID_TipoNivelEducativo",(pAporteSemanas.ID_TipoNivelEducativo== null || pAporteSemanas.ID_TipoNivelEducativo==0) ? vintNUll :pAporteSemanas.ID_TipoNivelEducativo);
                    p.Add("@PorcentajeAdecuacion",(pAporteSemanas.PorcentajeAdecuacion== null) ? vintNUll :pAporteSemanas.PorcentajeAdecuacion);
                    p.Add("@AporteEstimado",(pAporteSemanas.AporteEstimado== null) ? vintNUll :pAporteSemanas.AporteEstimado);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AporteSemanas> l = SqlMapper.Query<AporteSemanas>(con, "API.PA_AporteSemanasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AporteSemanas  ->" + ex.Message);
				}
			}

			public AporteSemanas Add(AporteSemanas pAporteSemanas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAporteSemanas.id==null ? 0 : pAporteSemanas.id);
p.Add("@ID_Semana",pAporteSemanas.ID_Semana==null ? 0 : pAporteSemanas.ID_Semana);
p.Add("@ID_Nutriente",pAporteSemanas.ID_Nutriente==null ? 0 : pAporteSemanas.ID_Nutriente);
p.Add("@ID_TipoNivelEducativo",pAporteSemanas.ID_TipoNivelEducativo==null ? 0 : pAporteSemanas.ID_TipoNivelEducativo);
                    p.Add("@PorcentajeAdecuacion", pAporteSemanas.PorcentajeAdecuacion);
                    p.Add("@AporteEstimado", pAporteSemanas.AporteEstimado);
                    p.Add("@auditoria", pAporteSemanas.auditoria);

                         


                    AporteSemanas o = SqlMapper.QueryFirstOrDefault<AporteSemanas>(con, "API.PA_AporteSemanasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AporteSemanas  ->" + ex.Message);
				}
			}

			public AporteSemanas  Update(AporteSemanas pAporteSemanas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAporteSemanas.id==null ? 0 : pAporteSemanas.id);
p.Add("@ID_Semana",pAporteSemanas.ID_Semana==null ? 0 : pAporteSemanas.ID_Semana);
p.Add("@ID_Nutriente",pAporteSemanas.ID_Nutriente==null ? 0 : pAporteSemanas.ID_Nutriente);
p.Add("@ID_TipoNivelEducativo",pAporteSemanas.ID_TipoNivelEducativo==null ? 0 : pAporteSemanas.ID_TipoNivelEducativo);
                    p.Add("@PorcentajeAdecuacion", pAporteSemanas.PorcentajeAdecuacion);
                    p.Add("@AporteEstimado", pAporteSemanas.AporteEstimado);
                    p.Add("@auditoria", pAporteSemanas.auditoria);

                         


                    AporteSemanas o = SqlMapper.QueryFirstOrDefault<AporteSemanas>(con, "API.PA_AporteSemanasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AporteSemanas  ->" + ex.Message);
				}
			}

			public bool Delete(AporteSemanas pAporteSemanas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAporteSemanas.id);
                    p.Add("@auditoria", pAporteSemanas.auditoria);

                

 

					AporteSemanas o = SqlMapper.QueryFirstOrDefault<AporteSemanas>(con, "API.PA_AporteSemanasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AporteSemanas  ->" + ex.Message);
				}
			}

		



            public List<AporteSemanas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AporteSemanas> AporteSemanasList = new List<AporteSemanas>();

                    AporteSemanasList = SqlMapper.Query<AporteSemanas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AporteSemanasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AporteSemanas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AporteSemanas> b)
            {
                DapperPlusManager.Entity<AporteSemanas>().Table("AporteSemanas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}