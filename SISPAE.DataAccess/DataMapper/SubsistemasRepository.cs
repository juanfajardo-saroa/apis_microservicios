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
     /// Clase Abstracta para  Subsistemas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SubsistemasRepository : DataObject , ISubsistemas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SubsistemasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SubsistemasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Subsistemas GetById(Subsistemas pSubsistemas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSubsistemas.id);                                    


    				Subsistemas o = SqlMapper.QueryFirstOrDefault<Subsistemas>(con, "API.PA_SubsistemasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Subsistemas  ->" + ex.Message);
				}
			}

			public List<Subsistemas> GetAll()
			{
				try 
                {
                        List<Subsistemas> l = SqlMapper.Query<Subsistemas>(con, "API.PA_SubsistemasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Subsistemas  ->" + ex.Message);
				}
			}

			public List<Subsistemas> GetAllFull()
			{
				try 
				{
                    List<Subsistemas> l = SqlMapper.Query<Subsistemas>(con, "API.PA_SubsistemasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Subsistemas  ->" + ex.Message);
				}
			}
			
			public List<Subsistemas> GetAllByWithRelation()
			{
				try 
                {
                    List<Subsistemas> l = SqlMapper.Query<Subsistemas>(con, "API.PA_SubsistemasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Subsistemas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Subsistemas> GetByFilter(Subsistemas pSubsistemas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSubsistemas.id== null || pSubsistemas.id==0) ? vintNUll :pSubsistemas.id);
                    p.Add("@Nombre",(pSubsistemas.Nombre== null) ? vintNUll :pSubsistemas.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Subsistemas> l = SqlMapper.Query<Subsistemas>(con, "API.PA_SubsistemasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Subsistemas  ->" + ex.Message);
				}
			}

			public Subsistemas Add(Subsistemas pSubsistemas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSubsistemas.id==null ? 0 : pSubsistemas.id);
                    p.Add("@Nombre", pSubsistemas.Nombre);
                    p.Add("@auditoria", pSubsistemas.auditoria);

                         


                    Subsistemas o = SqlMapper.QueryFirstOrDefault<Subsistemas>(con, "API.PA_SubsistemasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Subsistemas  ->" + ex.Message);
				}
			}

			public Subsistemas  Update(Subsistemas pSubsistemas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSubsistemas.id==null ? 0 : pSubsistemas.id);
                    p.Add("@Nombre", pSubsistemas.Nombre);
                    p.Add("@auditoria", pSubsistemas.auditoria);

                         


                    Subsistemas o = SqlMapper.QueryFirstOrDefault<Subsistemas>(con, "API.PA_SubsistemasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Subsistemas  ->" + ex.Message);
				}
			}

			public bool Delete(Subsistemas pSubsistemas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSubsistemas.id);
                    p.Add("@auditoria", pSubsistemas.auditoria);

                

 

					Subsistemas o = SqlMapper.QueryFirstOrDefault<Subsistemas>(con, "API.PA_SubsistemasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Subsistemas  ->" + ex.Message);
				}
			}

		



            public List<Subsistemas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Subsistemas> SubsistemasList = new List<Subsistemas>();

                    SubsistemasList = SqlMapper.Query<Subsistemas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SubsistemasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Subsistemas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Subsistemas> b)
            {
                DapperPlusManager.Entity<Subsistemas>().Table("Subsistemas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}