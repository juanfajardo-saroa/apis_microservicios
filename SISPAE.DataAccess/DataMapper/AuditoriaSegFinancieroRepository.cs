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
     /// Clase Abstracta para  AuditoriaSegFinanciero
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AuditoriaSegFinancieroRepository : DataObject , IAuditoriaSegFinanciero 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AuditoriaSegFinancieroRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AuditoriaSegFinancieroRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AuditoriaSegFinanciero GetById(AuditoriaSegFinanciero pAuditoriaSegFinanciero)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaSegFinanciero.id);                                    


    				AuditoriaSegFinanciero o = SqlMapper.QueryFirstOrDefault<AuditoriaSegFinanciero>(con, "API.PA_AuditoriaSegFinancieroGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AuditoriaSegFinanciero  ->" + ex.Message);
				}
			}

			public List<AuditoriaSegFinanciero> GetAll()
			{
				try 
                {
                        List<AuditoriaSegFinanciero> l = SqlMapper.Query<AuditoriaSegFinanciero>(con, "API.PA_AuditoriaSegFinancieroGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AuditoriaSegFinanciero  ->" + ex.Message);
				}
			}

			public List<AuditoriaSegFinanciero> GetAllFull()
			{
				try 
				{
                    List<AuditoriaSegFinanciero> l = SqlMapper.Query<AuditoriaSegFinanciero>(con, "API.PA_AuditoriaSegFinancieroGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AuditoriaSegFinanciero  ->" + ex.Message);
				}
			}
			
			public List<AuditoriaSegFinanciero> GetAllByWithRelation()
			{
				try 
                {
                    List<AuditoriaSegFinanciero> l = SqlMapper.Query<AuditoriaSegFinanciero>(con, "API.PA_AuditoriaSegFinancieroGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AuditoriaSegFinanciero  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AuditoriaSegFinanciero> GetByFilter(AuditoriaSegFinanciero pAuditoriaSegFinanciero, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAuditoriaSegFinanciero.id== null || pAuditoriaSegFinanciero.id==0) ? vintNUll :pAuditoriaSegFinanciero.id);
                    p.Add("@ID_User",(pAuditoriaSegFinanciero.ID_User== null) ? vintNUll :pAuditoriaSegFinanciero.ID_User);
                    p.Add("@ID_AgrupacionMensual",(pAuditoriaSegFinanciero.ID_AgrupacionMensual== null || pAuditoriaSegFinanciero.ID_AgrupacionMensual==0) ? vintNUll :pAuditoriaSegFinanciero.ID_AgrupacionMensual);
                    p.Add("@ID_TipoOperacion",(pAuditoriaSegFinanciero.ID_TipoOperacion== null || pAuditoriaSegFinanciero.ID_TipoOperacion==0) ? vintNUll :pAuditoriaSegFinanciero.ID_TipoOperacion);
                    p.Add("@FechaCambio",(pAuditoriaSegFinanciero.FechaCambio== null) ? vintNUll :pAuditoriaSegFinanciero.FechaCambio);
                    p.Add("@Valor",(pAuditoriaSegFinanciero.Valor== null) ? vintNUll :pAuditoriaSegFinanciero.Valor);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AuditoriaSegFinanciero> l = SqlMapper.Query<AuditoriaSegFinanciero>(con, "API.PA_AuditoriaSegFinancieroGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AuditoriaSegFinanciero  ->" + ex.Message);
				}
			}

			public AuditoriaSegFinanciero Add(AuditoriaSegFinanciero pAuditoriaSegFinanciero)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAuditoriaSegFinanciero.id==null ? 0 : pAuditoriaSegFinanciero.id);
                    p.Add("@ID_User", pAuditoriaSegFinanciero.ID_User);
p.Add("@ID_AgrupacionMensual",pAuditoriaSegFinanciero.ID_AgrupacionMensual==null ? 0 : pAuditoriaSegFinanciero.ID_AgrupacionMensual);
p.Add("@ID_TipoOperacion",pAuditoriaSegFinanciero.ID_TipoOperacion==null ? 0 : pAuditoriaSegFinanciero.ID_TipoOperacion);
                    p.Add("@FechaCambio", pAuditoriaSegFinanciero.FechaCambio);
                    p.Add("@Valor", pAuditoriaSegFinanciero.Valor);
                    p.Add("@auditoria", pAuditoriaSegFinanciero.auditoria);

                         


                    AuditoriaSegFinanciero o = SqlMapper.QueryFirstOrDefault<AuditoriaSegFinanciero>(con, "API.PA_AuditoriaSegFinancieroAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AuditoriaSegFinanciero  ->" + ex.Message);
				}
			}

			public AuditoriaSegFinanciero  Update(AuditoriaSegFinanciero pAuditoriaSegFinanciero)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAuditoriaSegFinanciero.id==null ? 0 : pAuditoriaSegFinanciero.id);
                    p.Add("@ID_User", pAuditoriaSegFinanciero.ID_User);
p.Add("@ID_AgrupacionMensual",pAuditoriaSegFinanciero.ID_AgrupacionMensual==null ? 0 : pAuditoriaSegFinanciero.ID_AgrupacionMensual);
p.Add("@ID_TipoOperacion",pAuditoriaSegFinanciero.ID_TipoOperacion==null ? 0 : pAuditoriaSegFinanciero.ID_TipoOperacion);
                    p.Add("@FechaCambio", pAuditoriaSegFinanciero.FechaCambio);
                    p.Add("@Valor", pAuditoriaSegFinanciero.Valor);
                    p.Add("@auditoria", pAuditoriaSegFinanciero.auditoria);

                         


                    AuditoriaSegFinanciero o = SqlMapper.QueryFirstOrDefault<AuditoriaSegFinanciero>(con, "API.PA_AuditoriaSegFinancieroUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AuditoriaSegFinanciero  ->" + ex.Message);
				}
			}

			public bool Delete(AuditoriaSegFinanciero pAuditoriaSegFinanciero)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaSegFinanciero.id);
                    p.Add("@auditoria", pAuditoriaSegFinanciero.auditoria);

                

 

					AuditoriaSegFinanciero o = SqlMapper.QueryFirstOrDefault<AuditoriaSegFinanciero>(con, "API.PA_AuditoriaSegFinancieroDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AuditoriaSegFinanciero  ->" + ex.Message);
				}
			}

		



            public List<AuditoriaSegFinanciero> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AuditoriaSegFinanciero> AuditoriaSegFinancieroList = new List<AuditoriaSegFinanciero>();

                    AuditoriaSegFinancieroList = SqlMapper.Query<AuditoriaSegFinanciero>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AuditoriaSegFinancieroList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AuditoriaSegFinanciero  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AuditoriaSegFinanciero> b)
            {
                DapperPlusManager.Entity<AuditoriaSegFinanciero>().Table("AuditoriaSegFinanciero");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}