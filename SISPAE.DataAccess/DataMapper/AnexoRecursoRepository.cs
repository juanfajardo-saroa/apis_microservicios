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
     /// Clase Abstracta para  AnexoRecurso
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AnexoRecursoRepository : DataObject , IAnexoRecurso 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AnexoRecursoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AnexoRecursoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AnexoRecurso GetById(AnexoRecurso pAnexoRecurso)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAnexoRecurso.id);                                    


    				AnexoRecurso o = SqlMapper.QueryFirstOrDefault<AnexoRecurso>(con, "API.PA_AnexoRecursoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AnexoRecurso  ->" + ex.Message);
				}
			}

			public List<AnexoRecurso> GetAll()
			{
				try 
                {
                        List<AnexoRecurso> l = SqlMapper.Query<AnexoRecurso>(con, "API.PA_AnexoRecursoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AnexoRecurso  ->" + ex.Message);
				}
			}

			public List<AnexoRecurso> GetAllFull()
			{
				try 
				{
                    List<AnexoRecurso> l = SqlMapper.Query<AnexoRecurso>(con, "API.PA_AnexoRecursoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AnexoRecurso  ->" + ex.Message);
				}
			}
			
			public List<AnexoRecurso> GetAllByWithRelation()
			{
				try 
                {
                    List<AnexoRecurso> l = SqlMapper.Query<AnexoRecurso>(con, "API.PA_AnexoRecursoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AnexoRecurso  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AnexoRecurso> GetByFilter(AnexoRecurso pAnexoRecurso, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAnexoRecurso.id== null || pAnexoRecurso.id==0) ? vintNUll :pAnexoRecurso.id);
                    p.Add("@id_Repositorio",(pAnexoRecurso.id_Repositorio== null || pAnexoRecurso.id_Repositorio==0) ? vintNUll :pAnexoRecurso.id_Repositorio);
                    p.Add("@PATHArchivo",(pAnexoRecurso.PATHArchivo== null) ? vintNUll :pAnexoRecurso.PATHArchivo);
                    p.Add("@Nombre",(pAnexoRecurso.Nombre== null) ? vintNUll :pAnexoRecurso.Nombre);
                    p.Add("@Descripcion",(pAnexoRecurso.Descripcion== null) ? vintNUll :pAnexoRecurso.Descripcion);
                    p.Add("@FechaActualizacion",(pAnexoRecurso.FechaActualizacion== null) ? vintNUll :pAnexoRecurso.FechaActualizacion);
                    p.Add("@TamanoArchivo",(pAnexoRecurso.TamanoArchivo== null) ? vintNUll :pAnexoRecurso.TamanoArchivo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AnexoRecurso> l = SqlMapper.Query<AnexoRecurso>(con, "API.PA_AnexoRecursoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AnexoRecurso  ->" + ex.Message);
				}
			}

			public AnexoRecurso Add(AnexoRecurso pAnexoRecurso)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAnexoRecurso.id==null ? 0 : pAnexoRecurso.id);
p.Add("@id_Repositorio",pAnexoRecurso.id_Repositorio== null ? 0: pAnexoRecurso.id_Repositorio);
                    p.Add("@PATHArchivo", pAnexoRecurso.PATHArchivo);
                    p.Add("@Nombre", pAnexoRecurso.Nombre);
                    p.Add("@Descripcion", pAnexoRecurso.Descripcion);
                    p.Add("@FechaActualizacion", pAnexoRecurso.FechaActualizacion);
                    p.Add("@TamanoArchivo", pAnexoRecurso.TamanoArchivo);
                    p.Add("@auditoria", pAnexoRecurso.auditoria);

                         


                    AnexoRecurso o = SqlMapper.QueryFirstOrDefault<AnexoRecurso>(con, "API.PA_AnexoRecursoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AnexoRecurso  ->" + ex.Message);
				}
			}

			public AnexoRecurso  Update(AnexoRecurso pAnexoRecurso)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAnexoRecurso.id==null ? 0 : pAnexoRecurso.id);
p.Add("@id_Repositorio",pAnexoRecurso.id_Repositorio== null ? 0: pAnexoRecurso.id_Repositorio);
                    p.Add("@PATHArchivo", pAnexoRecurso.PATHArchivo);
                    p.Add("@Nombre", pAnexoRecurso.Nombre);
                    p.Add("@Descripcion", pAnexoRecurso.Descripcion);
                    p.Add("@FechaActualizacion", pAnexoRecurso.FechaActualizacion);
                    p.Add("@TamanoArchivo", pAnexoRecurso.TamanoArchivo);
                    p.Add("@auditoria", pAnexoRecurso.auditoria);

                         


                    AnexoRecurso o = SqlMapper.QueryFirstOrDefault<AnexoRecurso>(con, "API.PA_AnexoRecursoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AnexoRecurso  ->" + ex.Message);
				}
			}

			public bool Delete(AnexoRecurso pAnexoRecurso)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAnexoRecurso.id);
                    p.Add("@auditoria", pAnexoRecurso.auditoria);

                

 

					AnexoRecurso o = SqlMapper.QueryFirstOrDefault<AnexoRecurso>(con, "API.PA_AnexoRecursoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AnexoRecurso  ->" + ex.Message);
				}
			}

		



            public List<AnexoRecurso> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AnexoRecurso> AnexoRecursoList = new List<AnexoRecurso>();

                    AnexoRecursoList = SqlMapper.Query<AnexoRecurso>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AnexoRecursoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AnexoRecurso  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AnexoRecurso> b)
            {
                DapperPlusManager.Entity<AnexoRecurso>().Table("AnexoRecurso");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}