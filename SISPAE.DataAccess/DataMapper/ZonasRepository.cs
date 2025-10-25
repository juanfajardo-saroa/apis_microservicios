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
     /// Clase Abstracta para  Zonas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ZonasRepository : DataObject , IZonas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ZonasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ZonasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Zonas GetById(Zonas pZonas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pZonas.id);                                    


    				Zonas o = SqlMapper.QueryFirstOrDefault<Zonas>(con, "API.PA_ZonasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Zonas  ->" + ex.Message);
				}
			}

			public List<Zonas> GetAll()
			{
				try 
                {
                        List<Zonas> l = SqlMapper.Query<Zonas>(con, "API.PA_ZonasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Zonas  ->" + ex.Message);
				}
			}

			public List<Zonas> GetAllFull()
			{
				try 
				{
                    List<Zonas> l = SqlMapper.Query<Zonas>(con, "API.PA_ZonasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Zonas  ->" + ex.Message);
				}
			}
			
			public List<Zonas> GetAllByWithRelation()
			{
				try 
                {
                    List<Zonas> l = SqlMapper.Query<Zonas>(con, "API.PA_ZonasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Zonas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Zonas> GetByFilter(Zonas pZonas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pZonas.id== null || pZonas.id==0) ? vintNUll :pZonas.id);
                    p.Add("@Nombre",(pZonas.Nombre== null) ? vintNUll :pZonas.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Zonas> l = SqlMapper.Query<Zonas>(con, "API.PA_ZonasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Zonas  ->" + ex.Message);
				}
			}

			public Zonas Add(Zonas pZonas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pZonas.id==null ? 0 : pZonas.id);
                    p.Add("@Nombre", pZonas.Nombre);
                    p.Add("@auditoria", pZonas.auditoria);

                         


                    Zonas o = SqlMapper.QueryFirstOrDefault<Zonas>(con, "API.PA_ZonasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Zonas  ->" + ex.Message);
				}
			}

			public Zonas  Update(Zonas pZonas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pZonas.id==null ? 0 : pZonas.id);
                    p.Add("@Nombre", pZonas.Nombre);
                    p.Add("@auditoria", pZonas.auditoria);

                         


                    Zonas o = SqlMapper.QueryFirstOrDefault<Zonas>(con, "API.PA_ZonasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Zonas  ->" + ex.Message);
				}
			}

			public bool Delete(Zonas pZonas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pZonas.id);
                    p.Add("@auditoria", pZonas.auditoria);

                

 

					Zonas o = SqlMapper.QueryFirstOrDefault<Zonas>(con, "API.PA_ZonasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Zonas  ->" + ex.Message);
				}
			}

		



            public List<Zonas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Zonas> ZonasList = new List<Zonas>();

                    ZonasList = SqlMapper.Query<Zonas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ZonasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Zonas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Zonas> b)
            {
                DapperPlusManager.Entity<Zonas>().Table("Zonas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}