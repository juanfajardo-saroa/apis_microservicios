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
     /// Clase Abstracta para  SedesJornada
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SedesJornadaRepository : DataObject , ISedesJornada 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SedesJornadaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SedesJornadaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public SedesJornada GetById(SedesJornada pSedesJornada)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSedesJornada.id);                                    


    				SedesJornada o = SqlMapper.QueryFirstOrDefault<SedesJornada>(con, "API.PA_SedesJornadaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  SedesJornada  ->" + ex.Message);
				}
			}

			public List<SedesJornada> GetAll()
			{
				try 
                {
                        List<SedesJornada> l = SqlMapper.Query<SedesJornada>(con, "API.PA_SedesJornadaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  SedesJornada  ->" + ex.Message);
				}
			}

			public List<SedesJornada> GetAllFull()
			{
				try 
				{
                    List<SedesJornada> l = SqlMapper.Query<SedesJornada>(con, "API.PA_SedesJornadaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  SedesJornada  ->" + ex.Message);
				}
			}
			
			public List<SedesJornada> GetAllByWithRelation()
			{
				try 
                {
                    List<SedesJornada> l = SqlMapper.Query<SedesJornada>(con, "API.PA_SedesJornadaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  SedesJornada  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<SedesJornada> GetByFilter(SedesJornada pSedesJornada, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSedesJornada.id== null || pSedesJornada.id==0) ? vintNUll :pSedesJornada.id);
                    p.Add("@ID_Sede",(pSedesJornada.ID_Sede== null || pSedesJornada.ID_Sede==0) ? vintNUll :pSedesJornada.ID_Sede);
                    p.Add("@ID_Jornada",(pSedesJornada.ID_Jornada== null || pSedesJornada.ID_Jornada==0) ? vintNUll :pSedesJornada.ID_Jornada);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<SedesJornada> l = SqlMapper.Query<SedesJornada>(con, "API.PA_SedesJornadaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  SedesJornada  ->" + ex.Message);
				}
			}

			public SedesJornada Add(SedesJornada pSedesJornada)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSedesJornada.id==null ? 0 : pSedesJornada.id);
p.Add("@ID_Sede",pSedesJornada.ID_Sede==null ? 0 : pSedesJornada.ID_Sede);
p.Add("@ID_Jornada",pSedesJornada.ID_Jornada==null ? 0 : pSedesJornada.ID_Jornada);
                    p.Add("@auditoria", pSedesJornada.auditoria);

                         


                    SedesJornada o = SqlMapper.QueryFirstOrDefault<SedesJornada>(con, "API.PA_SedesJornadaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  SedesJornada  ->" + ex.Message);
				}
			}

			public SedesJornada  Update(SedesJornada pSedesJornada)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSedesJornada.id==null ? 0 : pSedesJornada.id);
p.Add("@ID_Sede",pSedesJornada.ID_Sede==null ? 0 : pSedesJornada.ID_Sede);
p.Add("@ID_Jornada",pSedesJornada.ID_Jornada==null ? 0 : pSedesJornada.ID_Jornada);
                    p.Add("@auditoria", pSedesJornada.auditoria);

                         


                    SedesJornada o = SqlMapper.QueryFirstOrDefault<SedesJornada>(con, "API.PA_SedesJornadaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  SedesJornada  ->" + ex.Message);
				}
			}

			public bool Delete(SedesJornada pSedesJornada)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSedesJornada.id);
                    p.Add("@auditoria", pSedesJornada.auditoria);

                

 

					SedesJornada o = SqlMapper.QueryFirstOrDefault<SedesJornada>(con, "API.PA_SedesJornadaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) SedesJornada  ->" + ex.Message);
				}
			}

		



            public List<SedesJornada> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<SedesJornada> SedesJornadaList = new List<SedesJornada>();

                    SedesJornadaList = SqlMapper.Query<SedesJornada>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SedesJornadaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) SedesJornada  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<SedesJornada> b)
            {
                DapperPlusManager.Entity<SedesJornada>().Table("SedesJornada");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}