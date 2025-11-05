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
     /// Clase Abstracta para  UsuariosEntidades
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class UsuariosEntidadesRepository : DataObject , IUsuariosEntidades 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public UsuariosEntidadesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public UsuariosEntidadesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public UsuariosEntidades GetById(UsuariosEntidades pUsuariosEntidades)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pUsuariosEntidades.id);                                    


    				UsuariosEntidades o = SqlMapper.QueryFirstOrDefault<UsuariosEntidades>(con, "API.PA_UsuariosEntidadesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  UsuariosEntidades  ->" + ex.Message);
				}
			}

			public List<UsuariosEntidades> GetAll()
			{
				try 
                {
                        List<UsuariosEntidades> l = SqlMapper.Query<UsuariosEntidades>(con, "API.PA_UsuariosEntidadesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  UsuariosEntidades  ->" + ex.Message);
				}
			}

			public List<UsuariosEntidades> GetAllFull()
			{
				try 
				{
                    List<UsuariosEntidades> l = SqlMapper.Query<UsuariosEntidades>(con, "API.PA_UsuariosEntidadesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  UsuariosEntidades  ->" + ex.Message);
				}
			}
			
			public List<UsuariosEntidades> GetAllByWithRelation()
			{
				try 
                {
                    List<UsuariosEntidades> l = SqlMapper.Query<UsuariosEntidades>(con, "API.PA_UsuariosEntidadesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  UsuariosEntidades  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<UsuariosEntidades> GetByFilter(UsuariosEntidades pUsuariosEntidades, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pUsuariosEntidades.id== null || pUsuariosEntidades.id==0) ? vintNUll :pUsuariosEntidades.id);
                    p.Add("@ID_TipoEstadoUsuario",(pUsuariosEntidades.ID_TipoEstadoUsuario== null || pUsuariosEntidades.ID_TipoEstadoUsuario==0) ? vintNUll :pUsuariosEntidades.ID_TipoEstadoUsuario);
                    p.Add("@ID_User",(pUsuariosEntidades.ID_User== null) ? vintNUll :pUsuariosEntidades.ID_User);
                    p.Add("@ID_Roles",(pUsuariosEntidades.ID_Roles== null) ? vintNUll :pUsuariosEntidades.ID_Roles);
                    p.Add("@ID_ETC",(pUsuariosEntidades.ID_ETC== null || pUsuariosEntidades.ID_ETC==0) ? vintNUll :pUsuariosEntidades.ID_ETC);
                    p.Add("@ID_ET",(pUsuariosEntidades.ID_ET== null || pUsuariosEntidades.ID_ET==0) ? vintNUll :pUsuariosEntidades.ID_ET);
                    p.Add("@Nombre",(pUsuariosEntidades.Nombre== null) ? vintNUll :pUsuariosEntidades.Nombre);
                    p.Add("@Apellido",(pUsuariosEntidades.Apellido== null) ? vintNUll :pUsuariosEntidades.Apellido);
                    p.Add("@Cedula",(pUsuariosEntidades.Cedula== null) ? vintNUll :pUsuariosEntidades.Cedula);
                    p.Add("@Celular",(pUsuariosEntidades.Celular== null) ? vintNUll :pUsuariosEntidades.Celular);
                    p.Add("@Correo",(pUsuariosEntidades.Correo== null) ? vintNUll :pUsuariosEntidades.Correo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<UsuariosEntidades> l = SqlMapper.Query<UsuariosEntidades>(con, "API.PA_UsuariosEntidadesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  UsuariosEntidades  ->" + ex.Message);
				}
			}

			public UsuariosEntidades Add(UsuariosEntidades pUsuariosEntidades)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pUsuariosEntidades.id==null ? 0 : pUsuariosEntidades.id);
p.Add("@ID_TipoEstadoUsuario",pUsuariosEntidades.ID_TipoEstadoUsuario==null ? 0 : pUsuariosEntidades.ID_TipoEstadoUsuario);
                    p.Add("@ID_User", pUsuariosEntidades.ID_User);
                    p.Add("@ID_Roles", pUsuariosEntidades.ID_Roles);
p.Add("@ID_ETC",pUsuariosEntidades.ID_ETC==null ? 0 : pUsuariosEntidades.ID_ETC);
p.Add("@ID_ET",pUsuariosEntidades.ID_ET==null ? 0 : pUsuariosEntidades.ID_ET);
                    p.Add("@Nombre", pUsuariosEntidades.Nombre);
                    p.Add("@Apellido", pUsuariosEntidades.Apellido);
                    p.Add("@Cedula", pUsuariosEntidades.Cedula);
                    p.Add("@Celular", pUsuariosEntidades.Celular);
                    p.Add("@Correo", pUsuariosEntidades.Correo);
                    p.Add("@auditoria", pUsuariosEntidades.auditoria);

                         


                    UsuariosEntidades o = SqlMapper.QueryFirstOrDefault<UsuariosEntidades>(con, "API.PA_UsuariosEntidadesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  UsuariosEntidades  ->" + ex.Message);
				}
			}

			public UsuariosEntidades  Update(UsuariosEntidades pUsuariosEntidades)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pUsuariosEntidades.id==null ? 0 : pUsuariosEntidades.id);
p.Add("@ID_TipoEstadoUsuario",pUsuariosEntidades.ID_TipoEstadoUsuario==null ? 0 : pUsuariosEntidades.ID_TipoEstadoUsuario);
                    p.Add("@ID_User", pUsuariosEntidades.ID_User);
                    p.Add("@ID_Roles", pUsuariosEntidades.ID_Roles);
p.Add("@ID_ETC",pUsuariosEntidades.ID_ETC==null ? 0 : pUsuariosEntidades.ID_ETC);
p.Add("@ID_ET",pUsuariosEntidades.ID_ET==null ? 0 : pUsuariosEntidades.ID_ET);
                    p.Add("@Nombre", pUsuariosEntidades.Nombre);
                    p.Add("@Apellido", pUsuariosEntidades.Apellido);
                    p.Add("@Cedula", pUsuariosEntidades.Cedula);
                    p.Add("@Celular", pUsuariosEntidades.Celular);
                    p.Add("@Correo", pUsuariosEntidades.Correo);
                    p.Add("@auditoria", pUsuariosEntidades.auditoria);

                         


                    UsuariosEntidades o = SqlMapper.QueryFirstOrDefault<UsuariosEntidades>(con, "API.PA_UsuariosEntidadesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  UsuariosEntidades  ->" + ex.Message);
				}
			}

			public bool Delete(UsuariosEntidades pUsuariosEntidades)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pUsuariosEntidades.id);
                    p.Add("@auditoria", pUsuariosEntidades.auditoria);

                

 

					UsuariosEntidades o = SqlMapper.QueryFirstOrDefault<UsuariosEntidades>(con, "API.PA_UsuariosEntidadesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) UsuariosEntidades  ->" + ex.Message);
				}
			}

		



            public List<UsuariosEntidades> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<UsuariosEntidades> UsuariosEntidadesList = new List<UsuariosEntidades>();

                    UsuariosEntidadesList = SqlMapper.Query<UsuariosEntidades>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return UsuariosEntidadesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) UsuariosEntidades  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<UsuariosEntidades> b)
            {
                DapperPlusManager.Entity<UsuariosEntidades>().Table("UsuariosEntidades");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}