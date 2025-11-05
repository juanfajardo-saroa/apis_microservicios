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
     /// Clase Abstracta para  GruposAnalisis
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class GruposAnalisisRepository : DataObject , IGruposAnalisis 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public GruposAnalisisRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public GruposAnalisisRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public GruposAnalisis GetById(GruposAnalisis pGruposAnalisis)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pGruposAnalisis.id);                                    


    				GruposAnalisis o = SqlMapper.QueryFirstOrDefault<GruposAnalisis>(con, "API.PA_GruposAnalisisGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  GruposAnalisis  ->" + ex.Message);
				}
			}

			public List<GruposAnalisis> GetAll()
			{
				try 
                {
                        List<GruposAnalisis> l = SqlMapper.Query<GruposAnalisis>(con, "API.PA_GruposAnalisisGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  GruposAnalisis  ->" + ex.Message);
				}
			}

			public List<GruposAnalisis> GetAllFull()
			{
				try 
				{
                    List<GruposAnalisis> l = SqlMapper.Query<GruposAnalisis>(con, "API.PA_GruposAnalisisGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  GruposAnalisis  ->" + ex.Message);
				}
			}
			
			public List<GruposAnalisis> GetAllByWithRelation()
			{
				try 
                {
                    List<GruposAnalisis> l = SqlMapper.Query<GruposAnalisis>(con, "API.PA_GruposAnalisisGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  GruposAnalisis  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<GruposAnalisis> GetByFilter(GruposAnalisis pGruposAnalisis, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pGruposAnalisis.id== null || pGruposAnalisis.id==0) ? vintNUll :pGruposAnalisis.id);
                    p.Add("@Nombre",(pGruposAnalisis.Nombre== null) ? vintNUll :pGruposAnalisis.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<GruposAnalisis> l = SqlMapper.Query<GruposAnalisis>(con, "API.PA_GruposAnalisisGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  GruposAnalisis  ->" + ex.Message);
				}
			}

			public GruposAnalisis Add(GruposAnalisis pGruposAnalisis)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pGruposAnalisis.id==null ? 0 : pGruposAnalisis.id);
                    p.Add("@Nombre", pGruposAnalisis.Nombre);
                    p.Add("@auditoria", pGruposAnalisis.auditoria);

                         


                    GruposAnalisis o = SqlMapper.QueryFirstOrDefault<GruposAnalisis>(con, "API.PA_GruposAnalisisAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  GruposAnalisis  ->" + ex.Message);
				}
			}

			public GruposAnalisis  Update(GruposAnalisis pGruposAnalisis)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pGruposAnalisis.id==null ? 0 : pGruposAnalisis.id);
                    p.Add("@Nombre", pGruposAnalisis.Nombre);
                    p.Add("@auditoria", pGruposAnalisis.auditoria);

                         


                    GruposAnalisis o = SqlMapper.QueryFirstOrDefault<GruposAnalisis>(con, "API.PA_GruposAnalisisUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  GruposAnalisis  ->" + ex.Message);
				}
			}

			public bool Delete(GruposAnalisis pGruposAnalisis)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pGruposAnalisis.id);
                    p.Add("@auditoria", pGruposAnalisis.auditoria);

                

 

					GruposAnalisis o = SqlMapper.QueryFirstOrDefault<GruposAnalisis>(con, "API.PA_GruposAnalisisDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) GruposAnalisis  ->" + ex.Message);
				}
			}

		



            public List<GruposAnalisis> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<GruposAnalisis> GruposAnalisisList = new List<GruposAnalisis>();

                    GruposAnalisisList = SqlMapper.Query<GruposAnalisis>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return GruposAnalisisList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) GruposAnalisis  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<GruposAnalisis> b)
            {
                DapperPlusManager.Entity<GruposAnalisis>().Table("GruposAnalisis");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}