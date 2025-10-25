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
     /// Clase Abstracta para  AuditoriaSegComplementos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AuditoriaSegComplementosRepository : DataObject , IAuditoriaSegComplementos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AuditoriaSegComplementosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AuditoriaSegComplementosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AuditoriaSegComplementos GetById(AuditoriaSegComplementos pAuditoriaSegComplementos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaSegComplementos.id);                                    


    				AuditoriaSegComplementos o = SqlMapper.QueryFirstOrDefault<AuditoriaSegComplementos>(con, "API.PA_AuditoriaSegComplementosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AuditoriaSegComplementos  ->" + ex.Message);
				}
			}

			public List<AuditoriaSegComplementos> GetAll()
			{
				try 
                {
                        List<AuditoriaSegComplementos> l = SqlMapper.Query<AuditoriaSegComplementos>(con, "API.PA_AuditoriaSegComplementosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AuditoriaSegComplementos  ->" + ex.Message);
				}
			}

			public List<AuditoriaSegComplementos> GetAllFull()
			{
				try 
				{
                    List<AuditoriaSegComplementos> l = SqlMapper.Query<AuditoriaSegComplementos>(con, "API.PA_AuditoriaSegComplementosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AuditoriaSegComplementos  ->" + ex.Message);
				}
			}
			
			public List<AuditoriaSegComplementos> GetAllByWithRelation()
			{
				try 
                {
                    List<AuditoriaSegComplementos> l = SqlMapper.Query<AuditoriaSegComplementos>(con, "API.PA_AuditoriaSegComplementosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AuditoriaSegComplementos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AuditoriaSegComplementos> GetByFilter(AuditoriaSegComplementos pAuditoriaSegComplementos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAuditoriaSegComplementos.id== null || pAuditoriaSegComplementos.id==0) ? vintNUll :pAuditoriaSegComplementos.id);
                    p.Add("@ID_User",(pAuditoriaSegComplementos.ID_User== null) ? vintNUll :pAuditoriaSegComplementos.ID_User);
                    p.Add("@ID_SemanaEntregaComplemento",(pAuditoriaSegComplementos.ID_SemanaEntregaComplemento== null || pAuditoriaSegComplementos.ID_SemanaEntregaComplemento==0) ? vintNUll :pAuditoriaSegComplementos.ID_SemanaEntregaComplemento);
                    p.Add("@ID_TipoOperacion",(pAuditoriaSegComplementos.ID_TipoOperacion== null || pAuditoriaSegComplementos.ID_TipoOperacion==0) ? vintNUll :pAuditoriaSegComplementos.ID_TipoOperacion);
                    p.Add("@FechaCambio",(pAuditoriaSegComplementos.FechaCambio== null) ? vintNUll :pAuditoriaSegComplementos.FechaCambio);
                    p.Add("@Valor",(pAuditoriaSegComplementos.Valor== null) ? vintNUll :pAuditoriaSegComplementos.Valor);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AuditoriaSegComplementos> l = SqlMapper.Query<AuditoriaSegComplementos>(con, "API.PA_AuditoriaSegComplementosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AuditoriaSegComplementos  ->" + ex.Message);
				}
			}

			public AuditoriaSegComplementos Add(AuditoriaSegComplementos pAuditoriaSegComplementos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAuditoriaSegComplementos.id==null ? 0 : pAuditoriaSegComplementos.id);
                    p.Add("@ID_User", pAuditoriaSegComplementos.ID_User);
p.Add("@ID_SemanaEntregaComplemento",pAuditoriaSegComplementos.ID_SemanaEntregaComplemento==null ? 0 : pAuditoriaSegComplementos.ID_SemanaEntregaComplemento);
p.Add("@ID_TipoOperacion",pAuditoriaSegComplementos.ID_TipoOperacion==null ? 0 : pAuditoriaSegComplementos.ID_TipoOperacion);
                    p.Add("@FechaCambio", pAuditoriaSegComplementos.FechaCambio);
                    p.Add("@Valor", pAuditoriaSegComplementos.Valor);
                    p.Add("@auditoria", pAuditoriaSegComplementos.auditoria);

                         


                    AuditoriaSegComplementos o = SqlMapper.QueryFirstOrDefault<AuditoriaSegComplementos>(con, "API.PA_AuditoriaSegComplementosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AuditoriaSegComplementos  ->" + ex.Message);
				}
			}

			public AuditoriaSegComplementos  Update(AuditoriaSegComplementos pAuditoriaSegComplementos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAuditoriaSegComplementos.id==null ? 0 : pAuditoriaSegComplementos.id);
                    p.Add("@ID_User", pAuditoriaSegComplementos.ID_User);
p.Add("@ID_SemanaEntregaComplemento",pAuditoriaSegComplementos.ID_SemanaEntregaComplemento==null ? 0 : pAuditoriaSegComplementos.ID_SemanaEntregaComplemento);
p.Add("@ID_TipoOperacion",pAuditoriaSegComplementos.ID_TipoOperacion==null ? 0 : pAuditoriaSegComplementos.ID_TipoOperacion);
                    p.Add("@FechaCambio", pAuditoriaSegComplementos.FechaCambio);
                    p.Add("@Valor", pAuditoriaSegComplementos.Valor);
                    p.Add("@auditoria", pAuditoriaSegComplementos.auditoria);

                         


                    AuditoriaSegComplementos o = SqlMapper.QueryFirstOrDefault<AuditoriaSegComplementos>(con, "API.PA_AuditoriaSegComplementosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AuditoriaSegComplementos  ->" + ex.Message);
				}
			}

			public bool Delete(AuditoriaSegComplementos pAuditoriaSegComplementos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaSegComplementos.id);
                    p.Add("@auditoria", pAuditoriaSegComplementos.auditoria);

                

 

					AuditoriaSegComplementos o = SqlMapper.QueryFirstOrDefault<AuditoriaSegComplementos>(con, "API.PA_AuditoriaSegComplementosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AuditoriaSegComplementos  ->" + ex.Message);
				}
			}

		



            public List<AuditoriaSegComplementos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AuditoriaSegComplementos> AuditoriaSegComplementosList = new List<AuditoriaSegComplementos>();

                    AuditoriaSegComplementosList = SqlMapper.Query<AuditoriaSegComplementos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AuditoriaSegComplementosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AuditoriaSegComplementos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AuditoriaSegComplementos> b)
            {
                DapperPlusManager.Entity<AuditoriaSegComplementos>().Table("AuditoriaSegComplementos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}