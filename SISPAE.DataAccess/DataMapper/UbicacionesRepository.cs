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
     /// Clase Abstracta para  Ubicaciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class UbicacionesRepository : DataObject , IUbicaciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public UbicacionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public UbicacionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Ubicaciones GetById(Ubicaciones pUbicaciones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pUbicaciones.id);                                    


    				Ubicaciones o = SqlMapper.QueryFirstOrDefault<Ubicaciones>(con, "API.PA_UbicacionesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Ubicaciones  ->" + ex.Message);
				}
			}

			public List<Ubicaciones> GetAll()
			{
				try 
                {
                        List<Ubicaciones> l = SqlMapper.Query<Ubicaciones>(con, "API.PA_UbicacionesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Ubicaciones  ->" + ex.Message);
				}
			}

			public List<Ubicaciones> GetAllFull()
			{
				try 
				{
                    List<Ubicaciones> l = SqlMapper.Query<Ubicaciones>(con, "API.PA_UbicacionesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Ubicaciones  ->" + ex.Message);
				}
			}
			
			public List<Ubicaciones> GetAllByWithRelation()
			{
				try 
                {
                    List<Ubicaciones> l = SqlMapper.Query<Ubicaciones>(con, "API.PA_UbicacionesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Ubicaciones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Ubicaciones> GetByFilter(Ubicaciones pUbicaciones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pUbicaciones.id== null || pUbicaciones.id==0) ? vintNUll :pUbicaciones.id);
                    p.Add("@Nombre",(pUbicaciones.Nombre== null) ? vintNUll :pUbicaciones.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Ubicaciones> l = SqlMapper.Query<Ubicaciones>(con, "API.PA_UbicacionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Ubicaciones  ->" + ex.Message);
				}
			}

			public Ubicaciones Add(Ubicaciones pUbicaciones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pUbicaciones.id==null ? 0 : pUbicaciones.id);
                    p.Add("@Nombre", pUbicaciones.Nombre);
                    p.Add("@auditoria", pUbicaciones.auditoria);

                         


                    Ubicaciones o = SqlMapper.QueryFirstOrDefault<Ubicaciones>(con, "API.PA_UbicacionesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Ubicaciones  ->" + ex.Message);
				}
			}

			public Ubicaciones  Update(Ubicaciones pUbicaciones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pUbicaciones.id==null ? 0 : pUbicaciones.id);
                    p.Add("@Nombre", pUbicaciones.Nombre);
                    p.Add("@auditoria", pUbicaciones.auditoria);

                         


                    Ubicaciones o = SqlMapper.QueryFirstOrDefault<Ubicaciones>(con, "API.PA_UbicacionesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Ubicaciones  ->" + ex.Message);
				}
			}

			public bool Delete(Ubicaciones pUbicaciones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pUbicaciones.id);
                    p.Add("@auditoria", pUbicaciones.auditoria);

                

 

					Ubicaciones o = SqlMapper.QueryFirstOrDefault<Ubicaciones>(con, "API.PA_UbicacionesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Ubicaciones  ->" + ex.Message);
				}
			}

		



            public List<Ubicaciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Ubicaciones> UbicacionesList = new List<Ubicaciones>();

                    UbicacionesList = SqlMapper.Query<Ubicaciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return UbicacionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Ubicaciones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Ubicaciones> b)
            {
                DapperPlusManager.Entity<Ubicaciones>().Table("Ubicaciones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}