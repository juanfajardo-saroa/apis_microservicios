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
     /// Clase Abstracta para  Jornada
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class JornadaRepository : DataObject , IJornada 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public JornadaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public JornadaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Jornada GetById(Jornada pJornada)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pJornada.id);                                    


    				Jornada o = SqlMapper.QueryFirstOrDefault<Jornada>(con, "API.PA_JornadaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Jornada  ->" + ex.Message);
				}
			}

			public List<Jornada> GetAll()
			{
				try 
                {
                        List<Jornada> l = SqlMapper.Query<Jornada>(con, "API.PA_JornadaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Jornada  ->" + ex.Message);
				}
			}

			public List<Jornada> GetAllFull()
			{
				try 
				{
                    List<Jornada> l = SqlMapper.Query<Jornada>(con, "API.PA_JornadaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Jornada  ->" + ex.Message);
				}
			}
			
			public List<Jornada> GetAllByWithRelation()
			{
				try 
                {
                    List<Jornada> l = SqlMapper.Query<Jornada>(con, "API.PA_JornadaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Jornada  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Jornada> GetByFilter(Jornada pJornada, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pJornada.id== null || pJornada.id==0) ? vintNUll :pJornada.id);
                    p.Add("@Nombre",(pJornada.Nombre== null) ? vintNUll :pJornada.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Jornada> l = SqlMapper.Query<Jornada>(con, "API.PA_JornadaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Jornada  ->" + ex.Message);
				}
			}

			public Jornada Add(Jornada pJornada)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pJornada.id==null ? 0 : pJornada.id);
                    p.Add("@Nombre", pJornada.Nombre);
                    p.Add("@auditoria", pJornada.auditoria);

                         


                    Jornada o = SqlMapper.QueryFirstOrDefault<Jornada>(con, "API.PA_JornadaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Jornada  ->" + ex.Message);
				}
			}

			public Jornada  Update(Jornada pJornada)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pJornada.id==null ? 0 : pJornada.id);
                    p.Add("@Nombre", pJornada.Nombre);
                    p.Add("@auditoria", pJornada.auditoria);

                         


                    Jornada o = SqlMapper.QueryFirstOrDefault<Jornada>(con, "API.PA_JornadaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Jornada  ->" + ex.Message);
				}
			}

			public bool Delete(Jornada pJornada)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pJornada.id);
                    p.Add("@auditoria", pJornada.auditoria);

                

 

					Jornada o = SqlMapper.QueryFirstOrDefault<Jornada>(con, "API.PA_JornadaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Jornada  ->" + ex.Message);
				}
			}

		



            public List<Jornada> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Jornada> JornadaList = new List<Jornada>();

                    JornadaList = SqlMapper.Query<Jornada>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return JornadaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Jornada  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Jornada> b)
            {
                DapperPlusManager.Entity<Jornada>().Table("Jornada");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}