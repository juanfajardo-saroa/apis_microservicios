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
     /// Clase Abstracta para  Novedades
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class NovedadesRepository : DataObject , INovedades 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public NovedadesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public NovedadesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Novedades GetById(Novedades pNovedades)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pNovedades.id);                                    


    				Novedades o = SqlMapper.QueryFirstOrDefault<Novedades>(con, "API.PA_NovedadesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Novedades  ->" + ex.Message);
				}
			}

			public List<Novedades> GetAll()
			{
				try 
                {
                        List<Novedades> l = SqlMapper.Query<Novedades>(con, "API.PA_NovedadesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Novedades  ->" + ex.Message);
				}
			}

			public List<Novedades> GetAllFull()
			{
				try 
				{
                    List<Novedades> l = SqlMapper.Query<Novedades>(con, "API.PA_NovedadesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Novedades  ->" + ex.Message);
				}
			}
			
			public List<Novedades> GetAllByWithRelation()
			{
				try 
                {
                    List<Novedades> l = SqlMapper.Query<Novedades>(con, "API.PA_NovedadesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Novedades  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Novedades> GetByFilter(Novedades pNovedades, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pNovedades.id== null || pNovedades.id==0) ? vintNUll :pNovedades.id);
                    p.Add("@ID_Sede",(pNovedades.ID_Sede== null || pNovedades.ID_Sede==0) ? vintNUll :pNovedades.ID_Sede);
                    p.Add("@ID_Vigencia",(pNovedades.ID_Vigencia== null || pNovedades.ID_Vigencia==0) ? vintNUll :pNovedades.ID_Vigencia);
                    p.Add("@Fecha",(pNovedades.Fecha== null) ? vintNUll :pNovedades.Fecha);
                    p.Add("@Descripcion",(pNovedades.Descripcion== null) ? vintNUll :pNovedades.Descripcion);
                    p.Add("@Archivo",(pNovedades.Archivo== null) ? vintNUll :pNovedades.Archivo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Novedades> l = SqlMapper.Query<Novedades>(con, "API.PA_NovedadesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Novedades  ->" + ex.Message);
				}
			}

			public Novedades Add(Novedades pNovedades)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pNovedades.id==null ? 0 : pNovedades.id);
p.Add("@ID_Sede",pNovedades.ID_Sede==null ? 0 : pNovedades.ID_Sede);
p.Add("@ID_Vigencia",pNovedades.ID_Vigencia==null ? 0 : pNovedades.ID_Vigencia);
                    p.Add("@Fecha", pNovedades.Fecha);
                    p.Add("@Descripcion", pNovedades.Descripcion);
                    p.Add("@Archivo", pNovedades.Archivo);
                    p.Add("@auditoria", pNovedades.auditoria);

                         


                    Novedades o = SqlMapper.QueryFirstOrDefault<Novedades>(con, "API.PA_NovedadesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Novedades  ->" + ex.Message);
				}
			}

			public Novedades  Update(Novedades pNovedades)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pNovedades.id==null ? 0 : pNovedades.id);
p.Add("@ID_Sede",pNovedades.ID_Sede==null ? 0 : pNovedades.ID_Sede);
p.Add("@ID_Vigencia",pNovedades.ID_Vigencia==null ? 0 : pNovedades.ID_Vigencia);
                    p.Add("@Fecha", pNovedades.Fecha);
                    p.Add("@Descripcion", pNovedades.Descripcion);
                    p.Add("@Archivo", pNovedades.Archivo);
                    p.Add("@auditoria", pNovedades.auditoria);

                         


                    Novedades o = SqlMapper.QueryFirstOrDefault<Novedades>(con, "API.PA_NovedadesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Novedades  ->" + ex.Message);
				}
			}

			public bool Delete(Novedades pNovedades)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pNovedades.id);
                    p.Add("@auditoria", pNovedades.auditoria);

                

 

					Novedades o = SqlMapper.QueryFirstOrDefault<Novedades>(con, "API.PA_NovedadesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Novedades  ->" + ex.Message);
				}
			}

		



            public List<Novedades> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Novedades> NovedadesList = new List<Novedades>();

                    NovedadesList = SqlMapper.Query<Novedades>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return NovedadesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Novedades  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Novedades> b)
            {
                DapperPlusManager.Entity<Novedades>().Table("Novedades");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}