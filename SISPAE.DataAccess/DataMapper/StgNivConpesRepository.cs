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
     /// Clase Abstracta para  StgNivConpes
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgNivConpesRepository : DataObject , IStgNivConpes 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgNivConpesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgNivConpesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgNivConpes GetById(StgNivConpes pStgNivConpes)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgNivConpes.id);                                    


    				StgNivConpes o = SqlMapper.QueryFirstOrDefault<StgNivConpes>(con, "API.PA_StgNivConpesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgNivConpes  ->" + ex.Message);
				}
			}

			public List<StgNivConpes> GetAll()
			{
				try 
                {
                        List<StgNivConpes> l = SqlMapper.Query<StgNivConpes>(con, "API.PA_StgNivConpesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgNivConpes  ->" + ex.Message);
				}
			}

			public List<StgNivConpes> GetAllFull()
			{
				try 
				{
                    List<StgNivConpes> l = SqlMapper.Query<StgNivConpes>(con, "API.PA_StgNivConpesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgNivConpes  ->" + ex.Message);
				}
			}
			
			public List<StgNivConpes> GetAllByWithRelation()
			{
				try 
                {
                    List<StgNivConpes> l = SqlMapper.Query<StgNivConpes>(con, "API.PA_StgNivConpesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgNivConpes  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgNivConpes> GetByFilter(StgNivConpes pStgNivConpes, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgNivConpes.id== null || pStgNivConpes.id==0) ? vintNUll :pStgNivConpes.id);
                    p.Add("@IdNivelConpes",(pStgNivConpes.IdNivelConpes== null || pStgNivConpes.IdNivelConpes==0) ? vintNUll :pStgNivConpes.IdNivelConpes);
                    p.Add("@Nombre",(pStgNivConpes.Nombre== null) ? vintNUll :pStgNivConpes.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgNivConpes> l = SqlMapper.Query<StgNivConpes>(con, "API.PA_StgNivConpesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgNivConpes  ->" + ex.Message);
				}
			}

			public StgNivConpes Add(StgNivConpes pStgNivConpes)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgNivConpes.id==null ? 0 : pStgNivConpes.id);
p.Add("@IdNivelConpes",pStgNivConpes.IdNivelConpes==null ? 0 : pStgNivConpes.IdNivelConpes);
                    p.Add("@Nombre", pStgNivConpes.Nombre);
                    p.Add("@auditoria", pStgNivConpes.auditoria);

                         


                    StgNivConpes o = SqlMapper.QueryFirstOrDefault<StgNivConpes>(con, "API.PA_StgNivConpesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgNivConpes  ->" + ex.Message);
				}
			}

			public StgNivConpes  Update(StgNivConpes pStgNivConpes)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgNivConpes.id==null ? 0 : pStgNivConpes.id);
p.Add("@IdNivelConpes",pStgNivConpes.IdNivelConpes==null ? 0 : pStgNivConpes.IdNivelConpes);
                    p.Add("@Nombre", pStgNivConpes.Nombre);
                    p.Add("@auditoria", pStgNivConpes.auditoria);

                         


                    StgNivConpes o = SqlMapper.QueryFirstOrDefault<StgNivConpes>(con, "API.PA_StgNivConpesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgNivConpes  ->" + ex.Message);
				}
			}

			public bool Delete(StgNivConpes pStgNivConpes)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgNivConpes.id);
                    p.Add("@auditoria", pStgNivConpes.auditoria);

                

 

					StgNivConpes o = SqlMapper.QueryFirstOrDefault<StgNivConpes>(con, "API.PA_StgNivConpesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgNivConpes  ->" + ex.Message);
				}
			}

		



            public List<StgNivConpes> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgNivConpes> StgNivConpesList = new List<StgNivConpes>();

                    StgNivConpesList = SqlMapper.Query<StgNivConpes>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgNivConpesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgNivConpes  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgNivConpes> b)
            {
                DapperPlusManager.Entity<StgNivConpes>().Table("StgNivConpes");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}