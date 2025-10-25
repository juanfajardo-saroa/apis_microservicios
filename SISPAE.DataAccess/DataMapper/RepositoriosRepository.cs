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
     /// Clase Abstracta para  Repositorios
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class RepositoriosRepository : DataObject , IRepositorios 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public RepositoriosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public RepositoriosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Repositorios GetById(Repositorios pRepositorios)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pRepositorios.id);                                    


    				Repositorios o = SqlMapper.QueryFirstOrDefault<Repositorios>(con, "API.PA_RepositoriosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Repositorios  ->" + ex.Message);
				}
			}

			public List<Repositorios> GetAll()
			{
				try 
                {
                        List<Repositorios> l = SqlMapper.Query<Repositorios>(con, "API.PA_RepositoriosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Repositorios  ->" + ex.Message);
				}
			}

			public List<Repositorios> GetAllFull()
			{
				try 
				{
                    List<Repositorios> l = SqlMapper.Query<Repositorios>(con, "API.PA_RepositoriosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Repositorios  ->" + ex.Message);
				}
			}
			
			public List<Repositorios> GetAllByWithRelation()
			{
				try 
                {
                    List<Repositorios> l = SqlMapper.Query<Repositorios>(con, "API.PA_RepositoriosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Repositorios  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Repositorios> GetByFilter(Repositorios pRepositorios, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pRepositorios.id== null || pRepositorios.id==0) ? vintNUll :pRepositorios.id);
                    p.Add("@idTipoArchivo",(pRepositorios.idTipoArchivo== null || pRepositorios.idTipoArchivo==0) ? vintNUll :pRepositorios.idTipoArchivo);
                    p.Add("@idCategoria",(pRepositorios.idCategoria== null || pRepositorios.idCategoria==0) ? vintNUll :pRepositorios.idCategoria);
                    p.Add("@idVigencia",(pRepositorios.idVigencia== null || pRepositorios.idVigencia==0) ? vintNUll :pRepositorios.idVigencia);
                    p.Add("@PAHTArchivo",(pRepositorios.PAHTArchivo== null) ? vintNUll :pRepositorios.PAHTArchivo);
                    p.Add("@Nombre",(pRepositorios.Nombre== null) ? vintNUll :pRepositorios.Nombre);
                    p.Add("@Descripcion",(pRepositorios.Descripcion== null) ? vintNUll :pRepositorios.Descripcion);
                    p.Add("@fechaArchivo",(pRepositorios.fechaArchivo== null) ? vintNUll :pRepositorios.fechaArchivo);
                    p.Add("@fechaCarga",(pRepositorios.fechaCarga== null) ? vintNUll :pRepositorios.fechaCarga);
                    p.Add("@id_TipoModeloOperacion",(pRepositorios.id_TipoModeloOperacion== null || pRepositorios.id_TipoModeloOperacion==0) ? vintNUll :pRepositorios.id_TipoModeloOperacion);
                    p.Add("@NombreResolucion",(pRepositorios.NombreResolucion== null) ? vintNUll :pRepositorios.NombreResolucion);
                    p.Add("@tamanoArchivo",(pRepositorios.tamanoArchivo== null) ? vintNUll :pRepositorios.tamanoArchivo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Repositorios> l = SqlMapper.Query<Repositorios>(con, "API.PA_RepositoriosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Repositorios  ->" + ex.Message);
				}
			}

			public Repositorios Add(Repositorios pRepositorios)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pRepositorios.id==null ? 0 : pRepositorios.id);
p.Add("@idTipoArchivo",pRepositorios.idTipoArchivo== null ? 0: pRepositorios.idTipoArchivo);
p.Add("@idCategoria",pRepositorios.idCategoria== null ? 0: pRepositorios.idCategoria);
p.Add("@idVigencia",pRepositorios.idVigencia== null ? 0: pRepositorios.idVigencia);
                    p.Add("@PAHTArchivo", pRepositorios.PAHTArchivo);
                    p.Add("@Nombre", pRepositorios.Nombre);
                    p.Add("@Descripcion", pRepositorios.Descripcion);
                    p.Add("@fechaArchivo", pRepositorios.fechaArchivo);
                    p.Add("@fechaCarga", pRepositorios.fechaCarga);
p.Add("@id_TipoModeloOperacion",pRepositorios.id_TipoModeloOperacion== null ? 0: pRepositorios.id_TipoModeloOperacion);
                    p.Add("@NombreResolucion", pRepositorios.NombreResolucion);
                    p.Add("@tamanoArchivo", pRepositorios.tamanoArchivo);
                    p.Add("@auditoria", pRepositorios.auditoria);

                         


                    Repositorios o = SqlMapper.QueryFirstOrDefault<Repositorios>(con, "API.PA_RepositoriosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Repositorios  ->" + ex.Message);
				}
			}

			public Repositorios  Update(Repositorios pRepositorios)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pRepositorios.id==null ? 0 : pRepositorios.id);
p.Add("@idTipoArchivo",pRepositorios.idTipoArchivo== null ? 0: pRepositorios.idTipoArchivo);
p.Add("@idCategoria",pRepositorios.idCategoria== null ? 0: pRepositorios.idCategoria);
p.Add("@idVigencia",pRepositorios.idVigencia== null ? 0: pRepositorios.idVigencia);
                    p.Add("@PAHTArchivo", pRepositorios.PAHTArchivo);
                    p.Add("@Nombre", pRepositorios.Nombre);
                    p.Add("@Descripcion", pRepositorios.Descripcion);
                    p.Add("@fechaArchivo", pRepositorios.fechaArchivo);
                    p.Add("@fechaCarga", pRepositorios.fechaCarga);
p.Add("@id_TipoModeloOperacion",pRepositorios.id_TipoModeloOperacion== null ? 0: pRepositorios.id_TipoModeloOperacion);
                    p.Add("@NombreResolucion", pRepositorios.NombreResolucion);
                    p.Add("@tamanoArchivo", pRepositorios.tamanoArchivo);
                    p.Add("@auditoria", pRepositorios.auditoria);

                         


                    Repositorios o = SqlMapper.QueryFirstOrDefault<Repositorios>(con, "API.PA_RepositoriosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Repositorios  ->" + ex.Message);
				}
			}

			public bool Delete(Repositorios pRepositorios)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pRepositorios.id);
                    p.Add("@auditoria", pRepositorios.auditoria);

                

 

					Repositorios o = SqlMapper.QueryFirstOrDefault<Repositorios>(con, "API.PA_RepositoriosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Repositorios  ->" + ex.Message);
				}
			}

		



            public List<Repositorios> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Repositorios> RepositoriosList = new List<Repositorios>();

                    RepositoriosList = SqlMapper.Query<Repositorios>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return RepositoriosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Repositorios  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Repositorios> b)
            {
                DapperPlusManager.Entity<Repositorios>().Table("Repositorios");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}