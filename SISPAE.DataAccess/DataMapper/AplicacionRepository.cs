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
     /// Clase Abstracta para  Aplicacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AplicacionRepository : DataObject , IAplicacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AplicacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AplicacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Aplicacion GetById(Aplicacion pAplicacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@Id",pAplicacion.Id);                                    


    				Aplicacion o = SqlMapper.QueryFirstOrDefault<Aplicacion>(con, "API.PA_AplicacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Aplicacion  ->" + ex.Message);
				}
			}

			public List<Aplicacion> GetAll()
			{
				try 
                {
                        List<Aplicacion> l = SqlMapper.Query<Aplicacion>(con, "API.PA_AplicacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Aplicacion  ->" + ex.Message);
				}
			}

			public List<Aplicacion> GetAllFull()
			{
				try 
				{
                    List<Aplicacion> l = SqlMapper.Query<Aplicacion>(con, "API.PA_AplicacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Aplicacion  ->" + ex.Message);
				}
			}
			
			public List<Aplicacion> GetAllByWithRelation()
			{
				try 
                {
                    List<Aplicacion> l = SqlMapper.Query<Aplicacion>(con, "API.PA_AplicacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Aplicacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Aplicacion> GetByFilter(Aplicacion pAplicacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@Id",(pAplicacion.Id== null || pAplicacion.Id==0) ? vintNUll :pAplicacion.Id);
                    p.Add("@Aplicacion",(pAplicacion.Aplicacion== null) ? vintNUll :pAplicacion.Aplicacion);
                    p.Add("@Password",(pAplicacion.Password== null) ? vintNUll :pAplicacion.Password);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Aplicacion> l = SqlMapper.Query<Aplicacion>(con, "API.PA_AplicacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Aplicacion  ->" + ex.Message);
				}
			}

			public Aplicacion Add(Aplicacion pAplicacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@Id",pAplicacion.Id==null ? 0 : pAplicacion.Id);
                    p.Add("@Aplicacion", pAplicacion.Aplicacion);
                    p.Add("@Password", pAplicacion.Password);
                    p.Add("@auditoria", pAplicacion.auditoria);

                         


                    Aplicacion o = SqlMapper.QueryFirstOrDefault<Aplicacion>(con, "API.PA_AplicacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Aplicacion  ->" + ex.Message);
				}
			}

			public Aplicacion  Update(Aplicacion pAplicacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@Id",pAplicacion.Id==null ? 0 : pAplicacion.Id);
                    p.Add("@Aplicacion", pAplicacion.Aplicacion);
                    p.Add("@Password", pAplicacion.Password);
                    p.Add("@auditoria", pAplicacion.auditoria);

                         


                    Aplicacion o = SqlMapper.QueryFirstOrDefault<Aplicacion>(con, "API.PA_AplicacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Aplicacion  ->" + ex.Message);
				}
			}

			public bool Delete(Aplicacion pAplicacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@Id",pAplicacion.Id);
                    p.Add("@auditoria", pAplicacion.auditoria);

                

 

					Aplicacion o = SqlMapper.QueryFirstOrDefault<Aplicacion>(con, "API.PA_AplicacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Aplicacion  ->" + ex.Message);
				}
			}

		



            public List<Aplicacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Aplicacion> AplicacionList = new List<Aplicacion>();

                    AplicacionList = SqlMapper.Query<Aplicacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AplicacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Aplicacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Aplicacion> b)
            {
                DapperPlusManager.Entity<Aplicacion>().Table("Aplicacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}