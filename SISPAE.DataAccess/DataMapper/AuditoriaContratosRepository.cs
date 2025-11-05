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
     /// Clase Abstracta para  AuditoriaContratos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AuditoriaContratosRepository : DataObject , IAuditoriaContratos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AuditoriaContratosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AuditoriaContratosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AuditoriaContratos GetById(AuditoriaContratos pAuditoriaContratos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaContratos.id);                                    


    				AuditoriaContratos o = SqlMapper.QueryFirstOrDefault<AuditoriaContratos>(con, "API.PA_AuditoriaContratosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AuditoriaContratos  ->" + ex.Message);
				}
			}

			public List<AuditoriaContratos> GetAll()
			{
				try 
                {
                        List<AuditoriaContratos> l = SqlMapper.Query<AuditoriaContratos>(con, "API.PA_AuditoriaContratosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AuditoriaContratos  ->" + ex.Message);
				}
			}

			public List<AuditoriaContratos> GetAllFull()
			{
				try 
				{
                    List<AuditoriaContratos> l = SqlMapper.Query<AuditoriaContratos>(con, "API.PA_AuditoriaContratosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AuditoriaContratos  ->" + ex.Message);
				}
			}
			
			public List<AuditoriaContratos> GetAllByWithRelation()
			{
				try 
                {
                    List<AuditoriaContratos> l = SqlMapper.Query<AuditoriaContratos>(con, "API.PA_AuditoriaContratosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AuditoriaContratos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AuditoriaContratos> GetByFilter(AuditoriaContratos pAuditoriaContratos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAuditoriaContratos.id== null || pAuditoriaContratos.id==0) ? vintNUll :pAuditoriaContratos.id);
                    p.Add("@ID_User",(pAuditoriaContratos.ID_User== null) ? vintNUll :pAuditoriaContratos.ID_User);
                    p.Add("@ID_Contrato",(pAuditoriaContratos.ID_Contrato== null || pAuditoriaContratos.ID_Contrato==0) ? vintNUll :pAuditoriaContratos.ID_Contrato);
                    p.Add("@FechaCambio",(pAuditoriaContratos.FechaCambio== null) ? vintNUll :pAuditoriaContratos.FechaCambio);
                    p.Add("@ID_TipoOperacion",(pAuditoriaContratos.ID_TipoOperacion== null || pAuditoriaContratos.ID_TipoOperacion==0) ? vintNUll :pAuditoriaContratos.ID_TipoOperacion);
                    p.Add("@valor",(pAuditoriaContratos.valor== null) ? vintNUll :pAuditoriaContratos.valor);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AuditoriaContratos> l = SqlMapper.Query<AuditoriaContratos>(con, "API.PA_AuditoriaContratosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AuditoriaContratos  ->" + ex.Message);
				}
			}

			public AuditoriaContratos Add(AuditoriaContratos pAuditoriaContratos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAuditoriaContratos.id==null ? 0 : pAuditoriaContratos.id);
                    p.Add("@ID_User", pAuditoriaContratos.ID_User);
p.Add("@ID_Contrato",pAuditoriaContratos.ID_Contrato==null ? 0 : pAuditoriaContratos.ID_Contrato);
                    p.Add("@FechaCambio", pAuditoriaContratos.FechaCambio);
p.Add("@ID_TipoOperacion",pAuditoriaContratos.ID_TipoOperacion==null ? 0 : pAuditoriaContratos.ID_TipoOperacion);
                    p.Add("@valor", pAuditoriaContratos.valor);
                    p.Add("@auditoria", pAuditoriaContratos.auditoria);

                         


                    AuditoriaContratos o = SqlMapper.QueryFirstOrDefault<AuditoriaContratos>(con, "API.PA_AuditoriaContratosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AuditoriaContratos  ->" + ex.Message);
				}
			}

			public AuditoriaContratos  Update(AuditoriaContratos pAuditoriaContratos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAuditoriaContratos.id==null ? 0 : pAuditoriaContratos.id);
                    p.Add("@ID_User", pAuditoriaContratos.ID_User);
p.Add("@ID_Contrato",pAuditoriaContratos.ID_Contrato==null ? 0 : pAuditoriaContratos.ID_Contrato);
                    p.Add("@FechaCambio", pAuditoriaContratos.FechaCambio);
p.Add("@ID_TipoOperacion",pAuditoriaContratos.ID_TipoOperacion==null ? 0 : pAuditoriaContratos.ID_TipoOperacion);
                    p.Add("@valor", pAuditoriaContratos.valor);
                    p.Add("@auditoria", pAuditoriaContratos.auditoria);

                         


                    AuditoriaContratos o = SqlMapper.QueryFirstOrDefault<AuditoriaContratos>(con, "API.PA_AuditoriaContratosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AuditoriaContratos  ->" + ex.Message);
				}
			}

			public bool Delete(AuditoriaContratos pAuditoriaContratos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaContratos.id);
                    p.Add("@auditoria", pAuditoriaContratos.auditoria);

                

 

					AuditoriaContratos o = SqlMapper.QueryFirstOrDefault<AuditoriaContratos>(con, "API.PA_AuditoriaContratosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AuditoriaContratos  ->" + ex.Message);
				}
			}

		



            public List<AuditoriaContratos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AuditoriaContratos> AuditoriaContratosList = new List<AuditoriaContratos>();

                    AuditoriaContratosList = SqlMapper.Query<AuditoriaContratos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AuditoriaContratosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AuditoriaContratos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AuditoriaContratos> b)
            {
                DapperPlusManager.Entity<AuditoriaContratos>().Table("AuditoriaContratos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}