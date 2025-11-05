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
     /// Clase Abstracta para  AuditoriaMinutas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AuditoriaMinutasRepository : DataObject , IAuditoriaMinutas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AuditoriaMinutasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AuditoriaMinutasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AuditoriaMinutas GetById(AuditoriaMinutas pAuditoriaMinutas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaMinutas.id);                                    


    				AuditoriaMinutas o = SqlMapper.QueryFirstOrDefault<AuditoriaMinutas>(con, "API.PA_AuditoriaMinutasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AuditoriaMinutas  ->" + ex.Message);
				}
			}

			public List<AuditoriaMinutas> GetAll()
			{
				try 
                {
                        List<AuditoriaMinutas> l = SqlMapper.Query<AuditoriaMinutas>(con, "API.PA_AuditoriaMinutasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AuditoriaMinutas  ->" + ex.Message);
				}
			}

			public List<AuditoriaMinutas> GetAllFull()
			{
				try 
				{
                    List<AuditoriaMinutas> l = SqlMapper.Query<AuditoriaMinutas>(con, "API.PA_AuditoriaMinutasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AuditoriaMinutas  ->" + ex.Message);
				}
			}
			
			public List<AuditoriaMinutas> GetAllByWithRelation()
			{
				try 
                {
                    List<AuditoriaMinutas> l = SqlMapper.Query<AuditoriaMinutas>(con, "API.PA_AuditoriaMinutasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AuditoriaMinutas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AuditoriaMinutas> GetByFilter(AuditoriaMinutas pAuditoriaMinutas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAuditoriaMinutas.id== null || pAuditoriaMinutas.id==0) ? vintNUll :pAuditoriaMinutas.id);
                    p.Add("@ID_User",(pAuditoriaMinutas.ID_User== null) ? vintNUll :pAuditoriaMinutas.ID_User);
                    p.Add("@ID_MinutaPatronAlimento",(pAuditoriaMinutas.ID_MinutaPatronAlimento== null || pAuditoriaMinutas.ID_MinutaPatronAlimento==0) ? vintNUll :pAuditoriaMinutas.ID_MinutaPatronAlimento);
                    p.Add("@ID_TipoOperacion",(pAuditoriaMinutas.ID_TipoOperacion== null || pAuditoriaMinutas.ID_TipoOperacion==0) ? vintNUll :pAuditoriaMinutas.ID_TipoOperacion);
                    p.Add("@FechaCambio",(pAuditoriaMinutas.FechaCambio== null) ? vintNUll :pAuditoriaMinutas.FechaCambio);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AuditoriaMinutas> l = SqlMapper.Query<AuditoriaMinutas>(con, "API.PA_AuditoriaMinutasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AuditoriaMinutas  ->" + ex.Message);
				}
			}

			public AuditoriaMinutas Add(AuditoriaMinutas pAuditoriaMinutas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAuditoriaMinutas.id==null ? 0 : pAuditoriaMinutas.id);
                    p.Add("@ID_User", pAuditoriaMinutas.ID_User);
p.Add("@ID_MinutaPatronAlimento",pAuditoriaMinutas.ID_MinutaPatronAlimento==null ? 0 : pAuditoriaMinutas.ID_MinutaPatronAlimento);
p.Add("@ID_TipoOperacion",pAuditoriaMinutas.ID_TipoOperacion==null ? 0 : pAuditoriaMinutas.ID_TipoOperacion);
                    p.Add("@FechaCambio", pAuditoriaMinutas.FechaCambio);
                    p.Add("@auditoria", pAuditoriaMinutas.auditoria);

                         


                    AuditoriaMinutas o = SqlMapper.QueryFirstOrDefault<AuditoriaMinutas>(con, "API.PA_AuditoriaMinutasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AuditoriaMinutas  ->" + ex.Message);
				}
			}

			public AuditoriaMinutas  Update(AuditoriaMinutas pAuditoriaMinutas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAuditoriaMinutas.id==null ? 0 : pAuditoriaMinutas.id);
                    p.Add("@ID_User", pAuditoriaMinutas.ID_User);
p.Add("@ID_MinutaPatronAlimento",pAuditoriaMinutas.ID_MinutaPatronAlimento==null ? 0 : pAuditoriaMinutas.ID_MinutaPatronAlimento);
p.Add("@ID_TipoOperacion",pAuditoriaMinutas.ID_TipoOperacion==null ? 0 : pAuditoriaMinutas.ID_TipoOperacion);
                    p.Add("@FechaCambio", pAuditoriaMinutas.FechaCambio);
                    p.Add("@auditoria", pAuditoriaMinutas.auditoria);

                         


                    AuditoriaMinutas o = SqlMapper.QueryFirstOrDefault<AuditoriaMinutas>(con, "API.PA_AuditoriaMinutasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AuditoriaMinutas  ->" + ex.Message);
				}
			}

			public bool Delete(AuditoriaMinutas pAuditoriaMinutas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaMinutas.id);
                    p.Add("@auditoria", pAuditoriaMinutas.auditoria);

                

 

					AuditoriaMinutas o = SqlMapper.QueryFirstOrDefault<AuditoriaMinutas>(con, "API.PA_AuditoriaMinutasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AuditoriaMinutas  ->" + ex.Message);
				}
			}

		



            public List<AuditoriaMinutas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AuditoriaMinutas> AuditoriaMinutasList = new List<AuditoriaMinutas>();

                    AuditoriaMinutasList = SqlMapper.Query<AuditoriaMinutas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AuditoriaMinutasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AuditoriaMinutas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AuditoriaMinutas> b)
            {
                DapperPlusManager.Entity<AuditoriaMinutas>().Table("AuditoriaMinutas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}