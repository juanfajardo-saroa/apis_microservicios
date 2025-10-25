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
     /// Clase Abstracta para  Adiciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AdicionesRepository : DataObject , IAdiciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AdicionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AdicionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Adiciones GetById(Adiciones pAdiciones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAdiciones.id);                                    


    				Adiciones o = SqlMapper.QueryFirstOrDefault<Adiciones>(con, "API.PA_AdicionesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Adiciones  ->" + ex.Message);
				}
			}

			public List<Adiciones> GetAll()
			{
				try 
                {
                        List<Adiciones> l = SqlMapper.Query<Adiciones>(con, "API.PA_AdicionesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Adiciones  ->" + ex.Message);
				}
			}

			public List<Adiciones> GetAllFull()
			{
				try 
				{
                    List<Adiciones> l = SqlMapper.Query<Adiciones>(con, "API.PA_AdicionesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Adiciones  ->" + ex.Message);
				}
			}
			
			public List<Adiciones> GetAllByWithRelation()
			{
				try 
                {
                    List<Adiciones> l = SqlMapper.Query<Adiciones>(con, "API.PA_AdicionesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Adiciones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Adiciones> GetByFilter(Adiciones pAdiciones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAdiciones.id== null || pAdiciones.id==0) ? vintNUll :pAdiciones.id);
                    p.Add("@Nombre",(pAdiciones.Nombre== null) ? vintNUll :pAdiciones.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Adiciones> l = SqlMapper.Query<Adiciones>(con, "API.PA_AdicionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Adiciones  ->" + ex.Message);
				}
			}

			public Adiciones Add(Adiciones pAdiciones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAdiciones.id==null ? 0 : pAdiciones.id);
                    p.Add("@Nombre", pAdiciones.Nombre);
                    p.Add("@auditoria", pAdiciones.auditoria);

                         


                    Adiciones o = SqlMapper.QueryFirstOrDefault<Adiciones>(con, "API.PA_AdicionesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Adiciones  ->" + ex.Message);
				}
			}

			public Adiciones  Update(Adiciones pAdiciones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAdiciones.id==null ? 0 : pAdiciones.id);
                    p.Add("@Nombre", pAdiciones.Nombre);
                    p.Add("@auditoria", pAdiciones.auditoria);

                         


                    Adiciones o = SqlMapper.QueryFirstOrDefault<Adiciones>(con, "API.PA_AdicionesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Adiciones  ->" + ex.Message);
				}
			}

			public bool Delete(Adiciones pAdiciones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAdiciones.id);
                    p.Add("@auditoria", pAdiciones.auditoria);

                

 

					Adiciones o = SqlMapper.QueryFirstOrDefault<Adiciones>(con, "API.PA_AdicionesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Adiciones  ->" + ex.Message);
				}
			}

		



            public List<Adiciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Adiciones> AdicionesList = new List<Adiciones>();

                    AdicionesList = SqlMapper.Query<Adiciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AdicionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Adiciones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Adiciones> b)
            {
                DapperPlusManager.Entity<Adiciones>().Table("Adiciones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}