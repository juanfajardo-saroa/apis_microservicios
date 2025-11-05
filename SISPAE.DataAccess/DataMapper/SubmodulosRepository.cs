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
     /// Clase Abstracta para  Submodulos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SubmodulosRepository : DataObject , ISubmodulos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SubmodulosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SubmodulosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Submodulos GetById(Submodulos pSubmodulos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSubmodulos.id);                                    


    				Submodulos o = SqlMapper.QueryFirstOrDefault<Submodulos>(con, "API.PA_SubmodulosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Submodulos  ->" + ex.Message);
				}
			}

			public List<Submodulos> GetAll()
			{
				try 
                {
                        List<Submodulos> l = SqlMapper.Query<Submodulos>(con, "API.PA_SubmodulosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Submodulos  ->" + ex.Message);
				}
			}

			public List<Submodulos> GetAllFull()
			{
				try 
				{
                    List<Submodulos> l = SqlMapper.Query<Submodulos>(con, "API.PA_SubmodulosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Submodulos  ->" + ex.Message);
				}
			}
			
			public List<Submodulos> GetAllByWithRelation()
			{
				try 
                {
                    List<Submodulos> l = SqlMapper.Query<Submodulos>(con, "API.PA_SubmodulosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Submodulos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Submodulos> GetByFilter(Submodulos pSubmodulos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSubmodulos.id== null || pSubmodulos.id==0) ? vintNUll :pSubmodulos.id);
                    p.Add("@Nombre",(pSubmodulos.Nombre== null) ? vintNUll :pSubmodulos.Nombre);
                    p.Add("@id_Subsistemas",(pSubmodulos.id_Subsistemas== null || pSubmodulos.id_Subsistemas==0) ? vintNUll :pSubmodulos.id_Subsistemas);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Submodulos> l = SqlMapper.Query<Submodulos>(con, "API.PA_SubmodulosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Submodulos  ->" + ex.Message);
				}
			}

			public Submodulos Add(Submodulos pSubmodulos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSubmodulos.id==null ? 0 : pSubmodulos.id);
                    p.Add("@Nombre", pSubmodulos.Nombre);
p.Add("@id_Subsistemas",pSubmodulos.id_Subsistemas== null ? 0: pSubmodulos.id_Subsistemas);
                    p.Add("@auditoria", pSubmodulos.auditoria);

                         


                    Submodulos o = SqlMapper.QueryFirstOrDefault<Submodulos>(con, "API.PA_SubmodulosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Submodulos  ->" + ex.Message);
				}
			}

			public Submodulos  Update(Submodulos pSubmodulos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSubmodulos.id==null ? 0 : pSubmodulos.id);
                    p.Add("@Nombre", pSubmodulos.Nombre);
p.Add("@id_Subsistemas",pSubmodulos.id_Subsistemas== null ? 0: pSubmodulos.id_Subsistemas);
                    p.Add("@auditoria", pSubmodulos.auditoria);

                         


                    Submodulos o = SqlMapper.QueryFirstOrDefault<Submodulos>(con, "API.PA_SubmodulosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Submodulos  ->" + ex.Message);
				}
			}

			public bool Delete(Submodulos pSubmodulos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSubmodulos.id);
                    p.Add("@auditoria", pSubmodulos.auditoria);

                

 

					Submodulos o = SqlMapper.QueryFirstOrDefault<Submodulos>(con, "API.PA_SubmodulosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Submodulos  ->" + ex.Message);
				}
			}

		



            public List<Submodulos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Submodulos> SubmodulosList = new List<Submodulos>();

                    SubmodulosList = SqlMapper.Query<Submodulos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SubmodulosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Submodulos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Submodulos> b)
            {
                DapperPlusManager.Entity<Submodulos>().Table("Submodulos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}