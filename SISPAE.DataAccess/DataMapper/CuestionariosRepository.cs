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
     /// Clase Abstracta para  Cuestionarios
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CuestionariosRepository : DataObject , ICuestionarios 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CuestionariosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CuestionariosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Cuestionarios GetById(Cuestionarios pCuestionarios)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCuestionarios.id);                                    


    				Cuestionarios o = SqlMapper.QueryFirstOrDefault<Cuestionarios>(con, "API.PA_CuestionariosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Cuestionarios  ->" + ex.Message);
				}
			}

			public List<Cuestionarios> GetAll()
			{
				try 
                {
                        List<Cuestionarios> l = SqlMapper.Query<Cuestionarios>(con, "API.PA_CuestionariosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Cuestionarios  ->" + ex.Message);
				}
			}

			public List<Cuestionarios> GetAllFull()
			{
				try 
				{
                    List<Cuestionarios> l = SqlMapper.Query<Cuestionarios>(con, "API.PA_CuestionariosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Cuestionarios  ->" + ex.Message);
				}
			}
			
			public List<Cuestionarios> GetAllByWithRelation()
			{
				try 
                {
                    List<Cuestionarios> l = SqlMapper.Query<Cuestionarios>(con, "API.PA_CuestionariosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Cuestionarios  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Cuestionarios> GetByFilter(Cuestionarios pCuestionarios, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCuestionarios.id== null || pCuestionarios.id==0) ? vintNUll :pCuestionarios.id);
                    p.Add("@Nombre",(pCuestionarios.Nombre== null) ? vintNUll :pCuestionarios.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Cuestionarios> l = SqlMapper.Query<Cuestionarios>(con, "API.PA_CuestionariosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Cuestionarios  ->" + ex.Message);
				}
			}

			public Cuestionarios Add(Cuestionarios pCuestionarios)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCuestionarios.id==null ? 0 : pCuestionarios.id);
                    p.Add("@Nombre", pCuestionarios.Nombre);
                    p.Add("@auditoria", pCuestionarios.auditoria);

                         


                    Cuestionarios o = SqlMapper.QueryFirstOrDefault<Cuestionarios>(con, "API.PA_CuestionariosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Cuestionarios  ->" + ex.Message);
				}
			}

			public Cuestionarios  Update(Cuestionarios pCuestionarios)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCuestionarios.id==null ? 0 : pCuestionarios.id);
                    p.Add("@Nombre", pCuestionarios.Nombre);
                    p.Add("@auditoria", pCuestionarios.auditoria);

                         


                    Cuestionarios o = SqlMapper.QueryFirstOrDefault<Cuestionarios>(con, "API.PA_CuestionariosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Cuestionarios  ->" + ex.Message);
				}
			}

			public bool Delete(Cuestionarios pCuestionarios)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCuestionarios.id);
                    p.Add("@auditoria", pCuestionarios.auditoria);

                

 

					Cuestionarios o = SqlMapper.QueryFirstOrDefault<Cuestionarios>(con, "API.PA_CuestionariosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Cuestionarios  ->" + ex.Message);
				}
			}

		



            public List<Cuestionarios> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Cuestionarios> CuestionariosList = new List<Cuestionarios>();

                    CuestionariosList = SqlMapper.Query<Cuestionarios>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CuestionariosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Cuestionarios  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Cuestionarios> b)
            {
                DapperPlusManager.Entity<Cuestionarios>().Table("Cuestionarios");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}