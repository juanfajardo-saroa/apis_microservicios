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
     /// Clase Abstracta para  AuditoriaSegRaciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AuditoriaSegRacionesRepository : DataObject , IAuditoriaSegRaciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AuditoriaSegRacionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AuditoriaSegRacionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AuditoriaSegRaciones GetById(AuditoriaSegRaciones pAuditoriaSegRaciones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaSegRaciones.id);                                    


    				AuditoriaSegRaciones o = SqlMapper.QueryFirstOrDefault<AuditoriaSegRaciones>(con, "API.PA_AuditoriaSegRacionesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AuditoriaSegRaciones  ->" + ex.Message);
				}
			}

			public List<AuditoriaSegRaciones> GetAll()
			{
				try 
                {
                        List<AuditoriaSegRaciones> l = SqlMapper.Query<AuditoriaSegRaciones>(con, "API.PA_AuditoriaSegRacionesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AuditoriaSegRaciones  ->" + ex.Message);
				}
			}

			public List<AuditoriaSegRaciones> GetAllFull()
			{
				try 
				{
                    List<AuditoriaSegRaciones> l = SqlMapper.Query<AuditoriaSegRaciones>(con, "API.PA_AuditoriaSegRacionesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AuditoriaSegRaciones  ->" + ex.Message);
				}
			}
			
			public List<AuditoriaSegRaciones> GetAllByWithRelation()
			{
				try 
                {
                    List<AuditoriaSegRaciones> l = SqlMapper.Query<AuditoriaSegRaciones>(con, "API.PA_AuditoriaSegRacionesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AuditoriaSegRaciones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AuditoriaSegRaciones> GetByFilter(AuditoriaSegRaciones pAuditoriaSegRaciones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAuditoriaSegRaciones.id== null || pAuditoriaSegRaciones.id==0) ? vintNUll :pAuditoriaSegRaciones.id);
                    p.Add("@ID_User",(pAuditoriaSegRaciones.ID_User== null) ? vintNUll :pAuditoriaSegRaciones.ID_User);
                    p.Add("@ID_QuincenaEntregaRacion",(pAuditoriaSegRaciones.ID_QuincenaEntregaRacion== null || pAuditoriaSegRaciones.ID_QuincenaEntregaRacion==0) ? vintNUll :pAuditoriaSegRaciones.ID_QuincenaEntregaRacion);
                    p.Add("@ID_TipoOperacion",(pAuditoriaSegRaciones.ID_TipoOperacion== null || pAuditoriaSegRaciones.ID_TipoOperacion==0) ? vintNUll :pAuditoriaSegRaciones.ID_TipoOperacion);
                    p.Add("@FechaCambio",(pAuditoriaSegRaciones.FechaCambio== null) ? vintNUll :pAuditoriaSegRaciones.FechaCambio);
                    p.Add("@Valor",(pAuditoriaSegRaciones.Valor== null) ? vintNUll :pAuditoriaSegRaciones.Valor);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AuditoriaSegRaciones> l = SqlMapper.Query<AuditoriaSegRaciones>(con, "API.PA_AuditoriaSegRacionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AuditoriaSegRaciones  ->" + ex.Message);
				}
			}

			public AuditoriaSegRaciones Add(AuditoriaSegRaciones pAuditoriaSegRaciones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAuditoriaSegRaciones.id==null ? 0 : pAuditoriaSegRaciones.id);
                    p.Add("@ID_User", pAuditoriaSegRaciones.ID_User);
p.Add("@ID_QuincenaEntregaRacion",pAuditoriaSegRaciones.ID_QuincenaEntregaRacion==null ? 0 : pAuditoriaSegRaciones.ID_QuincenaEntregaRacion);
p.Add("@ID_TipoOperacion",pAuditoriaSegRaciones.ID_TipoOperacion==null ? 0 : pAuditoriaSegRaciones.ID_TipoOperacion);
                    p.Add("@FechaCambio", pAuditoriaSegRaciones.FechaCambio);
                    p.Add("@Valor", pAuditoriaSegRaciones.Valor);
                    p.Add("@auditoria", pAuditoriaSegRaciones.auditoria);

                         


                    AuditoriaSegRaciones o = SqlMapper.QueryFirstOrDefault<AuditoriaSegRaciones>(con, "API.PA_AuditoriaSegRacionesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AuditoriaSegRaciones  ->" + ex.Message);
				}
			}

			public AuditoriaSegRaciones  Update(AuditoriaSegRaciones pAuditoriaSegRaciones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAuditoriaSegRaciones.id==null ? 0 : pAuditoriaSegRaciones.id);
                    p.Add("@ID_User", pAuditoriaSegRaciones.ID_User);
p.Add("@ID_QuincenaEntregaRacion",pAuditoriaSegRaciones.ID_QuincenaEntregaRacion==null ? 0 : pAuditoriaSegRaciones.ID_QuincenaEntregaRacion);
p.Add("@ID_TipoOperacion",pAuditoriaSegRaciones.ID_TipoOperacion==null ? 0 : pAuditoriaSegRaciones.ID_TipoOperacion);
                    p.Add("@FechaCambio", pAuditoriaSegRaciones.FechaCambio);
                    p.Add("@Valor", pAuditoriaSegRaciones.Valor);
                    p.Add("@auditoria", pAuditoriaSegRaciones.auditoria);

                         


                    AuditoriaSegRaciones o = SqlMapper.QueryFirstOrDefault<AuditoriaSegRaciones>(con, "API.PA_AuditoriaSegRacionesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AuditoriaSegRaciones  ->" + ex.Message);
				}
			}

			public bool Delete(AuditoriaSegRaciones pAuditoriaSegRaciones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaSegRaciones.id);
                    p.Add("@auditoria", pAuditoriaSegRaciones.auditoria);

                

 

					AuditoriaSegRaciones o = SqlMapper.QueryFirstOrDefault<AuditoriaSegRaciones>(con, "API.PA_AuditoriaSegRacionesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AuditoriaSegRaciones  ->" + ex.Message);
				}
			}

		



            public List<AuditoriaSegRaciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AuditoriaSegRaciones> AuditoriaSegRacionesList = new List<AuditoriaSegRaciones>();

                    AuditoriaSegRacionesList = SqlMapper.Query<AuditoriaSegRaciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AuditoriaSegRacionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AuditoriaSegRaciones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AuditoriaSegRaciones> b)
            {
                DapperPlusManager.Entity<AuditoriaSegRaciones>().Table("AuditoriaSegRaciones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}