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
     /// Clase Abstracta para  AuditoriaOperadores
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AuditoriaOperadoresRepository : DataObject , IAuditoriaOperadores 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AuditoriaOperadoresRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AuditoriaOperadoresRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AuditoriaOperadores GetById(AuditoriaOperadores pAuditoriaOperadores)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaOperadores.id);                                    


    				AuditoriaOperadores o = SqlMapper.QueryFirstOrDefault<AuditoriaOperadores>(con, "API.PA_AuditoriaOperadoresGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AuditoriaOperadores  ->" + ex.Message);
				}
			}

			public List<AuditoriaOperadores> GetAll()
			{
				try 
                {
                        List<AuditoriaOperadores> l = SqlMapper.Query<AuditoriaOperadores>(con, "API.PA_AuditoriaOperadoresGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AuditoriaOperadores  ->" + ex.Message);
				}
			}

			public List<AuditoriaOperadores> GetAllFull()
			{
				try 
				{
                    List<AuditoriaOperadores> l = SqlMapper.Query<AuditoriaOperadores>(con, "API.PA_AuditoriaOperadoresGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AuditoriaOperadores  ->" + ex.Message);
				}
			}
			
			public List<AuditoriaOperadores> GetAllByWithRelation()
			{
				try 
                {
                    List<AuditoriaOperadores> l = SqlMapper.Query<AuditoriaOperadores>(con, "API.PA_AuditoriaOperadoresGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AuditoriaOperadores  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AuditoriaOperadores> GetByFilter(AuditoriaOperadores pAuditoriaOperadores, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAuditoriaOperadores.id== null || pAuditoriaOperadores.id==0) ? vintNUll :pAuditoriaOperadores.id);
                    p.Add("@ID_User",(pAuditoriaOperadores.ID_User== null) ? vintNUll :pAuditoriaOperadores.ID_User);
                    p.Add("@ID_Operador",(pAuditoriaOperadores.ID_Operador== null || pAuditoriaOperadores.ID_Operador==0) ? vintNUll :pAuditoriaOperadores.ID_Operador);
                    p.Add("@ID_TipoOperacion",(pAuditoriaOperadores.ID_TipoOperacion== null || pAuditoriaOperadores.ID_TipoOperacion==0) ? vintNUll :pAuditoriaOperadores.ID_TipoOperacion);
                    p.Add("@FechaCambio",(pAuditoriaOperadores.FechaCambio== null) ? vintNUll :pAuditoriaOperadores.FechaCambio);
                    p.Add("@Valor",(pAuditoriaOperadores.Valor== null) ? vintNUll :pAuditoriaOperadores.Valor);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AuditoriaOperadores> l = SqlMapper.Query<AuditoriaOperadores>(con, "API.PA_AuditoriaOperadoresGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AuditoriaOperadores  ->" + ex.Message);
				}
			}

			public AuditoriaOperadores Add(AuditoriaOperadores pAuditoriaOperadores)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAuditoriaOperadores.id==null ? 0 : pAuditoriaOperadores.id);
                    p.Add("@ID_User", pAuditoriaOperadores.ID_User);
p.Add("@ID_Operador",pAuditoriaOperadores.ID_Operador==null ? 0 : pAuditoriaOperadores.ID_Operador);
p.Add("@ID_TipoOperacion",pAuditoriaOperadores.ID_TipoOperacion==null ? 0 : pAuditoriaOperadores.ID_TipoOperacion);
                    p.Add("@FechaCambio", pAuditoriaOperadores.FechaCambio);
                    p.Add("@Valor", pAuditoriaOperadores.Valor);
                    p.Add("@auditoria", pAuditoriaOperadores.auditoria);

                         


                    AuditoriaOperadores o = SqlMapper.QueryFirstOrDefault<AuditoriaOperadores>(con, "API.PA_AuditoriaOperadoresAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AuditoriaOperadores  ->" + ex.Message);
				}
			}

			public AuditoriaOperadores  Update(AuditoriaOperadores pAuditoriaOperadores)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAuditoriaOperadores.id==null ? 0 : pAuditoriaOperadores.id);
                    p.Add("@ID_User", pAuditoriaOperadores.ID_User);
p.Add("@ID_Operador",pAuditoriaOperadores.ID_Operador==null ? 0 : pAuditoriaOperadores.ID_Operador);
p.Add("@ID_TipoOperacion",pAuditoriaOperadores.ID_TipoOperacion==null ? 0 : pAuditoriaOperadores.ID_TipoOperacion);
                    p.Add("@FechaCambio", pAuditoriaOperadores.FechaCambio);
                    p.Add("@Valor", pAuditoriaOperadores.Valor);
                    p.Add("@auditoria", pAuditoriaOperadores.auditoria);

                         


                    AuditoriaOperadores o = SqlMapper.QueryFirstOrDefault<AuditoriaOperadores>(con, "API.PA_AuditoriaOperadoresUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AuditoriaOperadores  ->" + ex.Message);
				}
			}

			public bool Delete(AuditoriaOperadores pAuditoriaOperadores)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaOperadores.id);
                    p.Add("@auditoria", pAuditoriaOperadores.auditoria);

                

 

					AuditoriaOperadores o = SqlMapper.QueryFirstOrDefault<AuditoriaOperadores>(con, "API.PA_AuditoriaOperadoresDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AuditoriaOperadores  ->" + ex.Message);
				}
			}

		



            public List<AuditoriaOperadores> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AuditoriaOperadores> AuditoriaOperadoresList = new List<AuditoriaOperadores>();

                    AuditoriaOperadoresList = SqlMapper.Query<AuditoriaOperadores>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AuditoriaOperadoresList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AuditoriaOperadores  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AuditoriaOperadores> b)
            {
                DapperPlusManager.Entity<AuditoriaOperadores>().Table("AuditoriaOperadores");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}