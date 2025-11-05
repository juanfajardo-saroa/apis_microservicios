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
     /// Clase Abstracta para  AuditoriaExcedentes
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AuditoriaExcedentesRepository : DataObject , IAuditoriaExcedentes 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AuditoriaExcedentesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AuditoriaExcedentesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AuditoriaExcedentes GetById(AuditoriaExcedentes pAuditoriaExcedentes)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaExcedentes.id);                                    


    				AuditoriaExcedentes o = SqlMapper.QueryFirstOrDefault<AuditoriaExcedentes>(con, "API.PA_AuditoriaExcedentesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AuditoriaExcedentes  ->" + ex.Message);
				}
			}

			public List<AuditoriaExcedentes> GetAll()
			{
				try 
                {
                        List<AuditoriaExcedentes> l = SqlMapper.Query<AuditoriaExcedentes>(con, "API.PA_AuditoriaExcedentesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AuditoriaExcedentes  ->" + ex.Message);
				}
			}

			public List<AuditoriaExcedentes> GetAllFull()
			{
				try 
				{
                    List<AuditoriaExcedentes> l = SqlMapper.Query<AuditoriaExcedentes>(con, "API.PA_AuditoriaExcedentesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AuditoriaExcedentes  ->" + ex.Message);
				}
			}
			
			public List<AuditoriaExcedentes> GetAllByWithRelation()
			{
				try 
                {
                    List<AuditoriaExcedentes> l = SqlMapper.Query<AuditoriaExcedentes>(con, "API.PA_AuditoriaExcedentesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AuditoriaExcedentes  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AuditoriaExcedentes> GetByFilter(AuditoriaExcedentes pAuditoriaExcedentes, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAuditoriaExcedentes.id== null || pAuditoriaExcedentes.id==0) ? vintNUll :pAuditoriaExcedentes.id);
                    p.Add("@ID_User",(pAuditoriaExcedentes.ID_User== null) ? vintNUll :pAuditoriaExcedentes.ID_User);
                    p.Add("@ID_ExcedenteComplemento",(pAuditoriaExcedentes.ID_ExcedenteComplemento== null || pAuditoriaExcedentes.ID_ExcedenteComplemento==0) ? vintNUll :pAuditoriaExcedentes.ID_ExcedenteComplemento);
                    p.Add("@ID_TipoOperacion",(pAuditoriaExcedentes.ID_TipoOperacion== null || pAuditoriaExcedentes.ID_TipoOperacion==0) ? vintNUll :pAuditoriaExcedentes.ID_TipoOperacion);
                    p.Add("@FechaCambio",(pAuditoriaExcedentes.FechaCambio== null) ? vintNUll :pAuditoriaExcedentes.FechaCambio);
                    p.Add("@Valor",(pAuditoriaExcedentes.Valor== null) ? vintNUll :pAuditoriaExcedentes.Valor);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AuditoriaExcedentes> l = SqlMapper.Query<AuditoriaExcedentes>(con, "API.PA_AuditoriaExcedentesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AuditoriaExcedentes  ->" + ex.Message);
				}
			}

			public AuditoriaExcedentes Add(AuditoriaExcedentes pAuditoriaExcedentes)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAuditoriaExcedentes.id==null ? 0 : pAuditoriaExcedentes.id);
                    p.Add("@ID_User", pAuditoriaExcedentes.ID_User);
p.Add("@ID_ExcedenteComplemento",pAuditoriaExcedentes.ID_ExcedenteComplemento==null ? 0 : pAuditoriaExcedentes.ID_ExcedenteComplemento);
p.Add("@ID_TipoOperacion",pAuditoriaExcedentes.ID_TipoOperacion==null ? 0 : pAuditoriaExcedentes.ID_TipoOperacion);
                    p.Add("@FechaCambio", pAuditoriaExcedentes.FechaCambio);
                    p.Add("@Valor", pAuditoriaExcedentes.Valor);
                    p.Add("@auditoria", pAuditoriaExcedentes.auditoria);

                         


                    AuditoriaExcedentes o = SqlMapper.QueryFirstOrDefault<AuditoriaExcedentes>(con, "API.PA_AuditoriaExcedentesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AuditoriaExcedentes  ->" + ex.Message);
				}
			}

			public AuditoriaExcedentes  Update(AuditoriaExcedentes pAuditoriaExcedentes)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAuditoriaExcedentes.id==null ? 0 : pAuditoriaExcedentes.id);
                    p.Add("@ID_User", pAuditoriaExcedentes.ID_User);
p.Add("@ID_ExcedenteComplemento",pAuditoriaExcedentes.ID_ExcedenteComplemento==null ? 0 : pAuditoriaExcedentes.ID_ExcedenteComplemento);
p.Add("@ID_TipoOperacion",pAuditoriaExcedentes.ID_TipoOperacion==null ? 0 : pAuditoriaExcedentes.ID_TipoOperacion);
                    p.Add("@FechaCambio", pAuditoriaExcedentes.FechaCambio);
                    p.Add("@Valor", pAuditoriaExcedentes.Valor);
                    p.Add("@auditoria", pAuditoriaExcedentes.auditoria);

                         


                    AuditoriaExcedentes o = SqlMapper.QueryFirstOrDefault<AuditoriaExcedentes>(con, "API.PA_AuditoriaExcedentesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AuditoriaExcedentes  ->" + ex.Message);
				}
			}

			public bool Delete(AuditoriaExcedentes pAuditoriaExcedentes)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAuditoriaExcedentes.id);
                    p.Add("@auditoria", pAuditoriaExcedentes.auditoria);

                

 

					AuditoriaExcedentes o = SqlMapper.QueryFirstOrDefault<AuditoriaExcedentes>(con, "API.PA_AuditoriaExcedentesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AuditoriaExcedentes  ->" + ex.Message);
				}
			}

		



            public List<AuditoriaExcedentes> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AuditoriaExcedentes> AuditoriaExcedentesList = new List<AuditoriaExcedentes>();

                    AuditoriaExcedentesList = SqlMapper.Query<AuditoriaExcedentes>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AuditoriaExcedentesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AuditoriaExcedentes  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AuditoriaExcedentes> b)
            {
                DapperPlusManager.Entity<AuditoriaExcedentes>().Table("AuditoriaExcedentes");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}