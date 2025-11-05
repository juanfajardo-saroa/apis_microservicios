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
     /// Clase Abstracta para  RolPermisos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class RolPermisosRepository : DataObject , IRolPermisos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public RolPermisosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public RolPermisosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public RolPermisos GetById(RolPermisos pRolPermisos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pRolPermisos.id);                                    


    				RolPermisos o = SqlMapper.QueryFirstOrDefault<RolPermisos>(con, "API.PA_RolPermisosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  RolPermisos  ->" + ex.Message);
				}
			}

			public List<RolPermisos> GetAll()
			{
				try 
                {
                        List<RolPermisos> l = SqlMapper.Query<RolPermisos>(con, "API.PA_RolPermisosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  RolPermisos  ->" + ex.Message);
				}
			}

			public List<RolPermisos> GetAllFull()
			{
				try 
				{
                    List<RolPermisos> l = SqlMapper.Query<RolPermisos>(con, "API.PA_RolPermisosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  RolPermisos  ->" + ex.Message);
				}
			}
			
			public List<RolPermisos> GetAllByWithRelation()
			{
				try 
                {
                    List<RolPermisos> l = SqlMapper.Query<RolPermisos>(con, "API.PA_RolPermisosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  RolPermisos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<RolPermisos> GetByFilter(RolPermisos pRolPermisos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pRolPermisos.id== null || pRolPermisos.id==0) ? vintNUll :pRolPermisos.id);
                    p.Add("@id_Rol",(pRolPermisos.id_Rol== null) ? vintNUll :pRolPermisos.id_Rol);
                    p.Add("@id_Modulo",(pRolPermisos.id_Modulo== null || pRolPermisos.id_Modulo==0) ? vintNUll :pRolPermisos.id_Modulo);
                    p.Add("@Ver",(pRolPermisos.Ver== null) ? vintNUll :pRolPermisos.Ver);
                    p.Add("@Crear",(pRolPermisos.Crear== null) ? vintNUll :pRolPermisos.Crear);
                    p.Add("@Editar",(pRolPermisos.Editar== null) ? vintNUll :pRolPermisos.Editar);
                    p.Add("@Eliminar",(pRolPermisos.Eliminar== null) ? vintNUll :pRolPermisos.Eliminar);
                    p.Add("@Aprobar",(pRolPermisos.Aprobar== null) ? vintNUll :pRolPermisos.Aprobar);
                    p.Add("@Imprimir",(pRolPermisos.Imprimir== null) ? vintNUll :pRolPermisos.Imprimir);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<RolPermisos> l = SqlMapper.Query<RolPermisos>(con, "API.PA_RolPermisosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  RolPermisos  ->" + ex.Message);
				}
			}

			public RolPermisos Add(RolPermisos pRolPermisos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pRolPermisos.id==null ? 0 : pRolPermisos.id);
p.Add("@id_Rol",pRolPermisos.id_Rol== null ? 0: pRolPermisos.id_Rol);
p.Add("@id_Modulo",pRolPermisos.id_Modulo== null ? 0: pRolPermisos.id_Modulo);
                    p.Add("@Ver", pRolPermisos.Ver);
                    p.Add("@Crear", pRolPermisos.Crear);
                    p.Add("@Editar", pRolPermisos.Editar);
                    p.Add("@Eliminar", pRolPermisos.Eliminar);
                    p.Add("@Aprobar", pRolPermisos.Aprobar);
                    p.Add("@Imprimir", pRolPermisos.Imprimir);
                    p.Add("@auditoria", pRolPermisos.auditoria);

                         


                    RolPermisos o = SqlMapper.QueryFirstOrDefault<RolPermisos>(con, "API.PA_RolPermisosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  RolPermisos  ->" + ex.Message);
				}
			}

			public RolPermisos  Update(RolPermisos pRolPermisos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pRolPermisos.id==null ? 0 : pRolPermisos.id);
p.Add("@id_Rol",pRolPermisos.id_Rol== null ? 0: pRolPermisos.id_Rol);
p.Add("@id_Modulo",pRolPermisos.id_Modulo== null ? 0: pRolPermisos.id_Modulo);
                    p.Add("@Ver", pRolPermisos.Ver);
                    p.Add("@Crear", pRolPermisos.Crear);
                    p.Add("@Editar", pRolPermisos.Editar);
                    p.Add("@Eliminar", pRolPermisos.Eliminar);
                    p.Add("@Aprobar", pRolPermisos.Aprobar);
                    p.Add("@Imprimir", pRolPermisos.Imprimir);
                    p.Add("@auditoria", pRolPermisos.auditoria);

                         


                    RolPermisos o = SqlMapper.QueryFirstOrDefault<RolPermisos>(con, "API.PA_RolPermisosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  RolPermisos  ->" + ex.Message);
				}
			}

			public bool Delete(RolPermisos pRolPermisos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pRolPermisos.id);
                    p.Add("@auditoria", pRolPermisos.auditoria);

                

 

					RolPermisos o = SqlMapper.QueryFirstOrDefault<RolPermisos>(con, "API.PA_RolPermisosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) RolPermisos  ->" + ex.Message);
				}
			}

		



            public List<RolPermisos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<RolPermisos> RolPermisosList = new List<RolPermisos>();

                    RolPermisosList = SqlMapper.Query<RolPermisos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return RolPermisosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) RolPermisos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<RolPermisos> b)
            {
                DapperPlusManager.Entity<RolPermisos>().Table("RolPermisos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}