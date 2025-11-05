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
     /// Clase Abstracta para  UTConsorcios
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class UTConsorciosRepository : DataObject , IUTConsorcios 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public UTConsorciosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public UTConsorciosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public UTConsorcios GetById(UTConsorcios pUTConsorcios)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pUTConsorcios.id);                                    


    				UTConsorcios o = SqlMapper.QueryFirstOrDefault<UTConsorcios>(con, "API.PA_UTConsorciosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  UTConsorcios  ->" + ex.Message);
				}
			}

			public List<UTConsorcios> GetAll()
			{
				try 
                {
                        List<UTConsorcios> l = SqlMapper.Query<UTConsorcios>(con, "API.PA_UTConsorciosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  UTConsorcios  ->" + ex.Message);
				}
			}

			public List<UTConsorcios> GetAllFull()
			{
				try 
				{
                    List<UTConsorcios> l = SqlMapper.Query<UTConsorcios>(con, "API.PA_UTConsorciosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  UTConsorcios  ->" + ex.Message);
				}
			}
			
			public List<UTConsorcios> GetAllByWithRelation()
			{
				try 
                {
                    List<UTConsorcios> l = SqlMapper.Query<UTConsorcios>(con, "API.PA_UTConsorciosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  UTConsorcios  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<UTConsorcios> GetByFilter(UTConsorcios pUTConsorcios, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pUTConsorcios.id== null || pUTConsorcios.id==0) ? vintNUll :pUTConsorcios.id);
                    p.Add("@Nombre",(pUTConsorcios.Nombre== null) ? vintNUll :pUTConsorcios.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<UTConsorcios> l = SqlMapper.Query<UTConsorcios>(con, "API.PA_UTConsorciosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  UTConsorcios  ->" + ex.Message);
				}
			}

			public UTConsorcios Add(UTConsorcios pUTConsorcios)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pUTConsorcios.id==null ? 0 : pUTConsorcios.id);
                    p.Add("@Nombre", pUTConsorcios.Nombre);
                    p.Add("@auditoria", pUTConsorcios.auditoria);

                         


                    UTConsorcios o = SqlMapper.QueryFirstOrDefault<UTConsorcios>(con, "API.PA_UTConsorciosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  UTConsorcios  ->" + ex.Message);
				}
			}

			public UTConsorcios  Update(UTConsorcios pUTConsorcios)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pUTConsorcios.id==null ? 0 : pUTConsorcios.id);
                    p.Add("@Nombre", pUTConsorcios.Nombre);
                    p.Add("@auditoria", pUTConsorcios.auditoria);

                         


                    UTConsorcios o = SqlMapper.QueryFirstOrDefault<UTConsorcios>(con, "API.PA_UTConsorciosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  UTConsorcios  ->" + ex.Message);
				}
			}

			public bool Delete(UTConsorcios pUTConsorcios)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pUTConsorcios.id);
                    p.Add("@auditoria", pUTConsorcios.auditoria);

                

 

					UTConsorcios o = SqlMapper.QueryFirstOrDefault<UTConsorcios>(con, "API.PA_UTConsorciosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) UTConsorcios  ->" + ex.Message);
				}
			}

		



            public List<UTConsorcios> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<UTConsorcios> UTConsorciosList = new List<UTConsorcios>();

                    UTConsorciosList = SqlMapper.Query<UTConsorcios>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return UTConsorciosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) UTConsorcios  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<UTConsorcios> b)
            {
                DapperPlusManager.Entity<UTConsorcios>().Table("UTConsorcios");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}