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
     /// Clase Abstracta para  Sedes
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SedesRepository : DataObject , ISedes 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SedesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SedesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Sedes GetById(Sedes pSedes)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSedes.id);                                    


    				Sedes o = SqlMapper.QueryFirstOrDefault<Sedes>(con, "API.PA_SedesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Sedes  ->" + ex.Message);
				}
			}

			public List<Sedes> GetAll()
			{
				try 
                {
                        List<Sedes> l = SqlMapper.Query<Sedes>(con, "API.PA_SedesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Sedes  ->" + ex.Message);
				}
			}

			public List<Sedes> GetAllFull()
			{
				try 
				{
                    List<Sedes> l = SqlMapper.Query<Sedes>(con, "API.PA_SedesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Sedes  ->" + ex.Message);
				}
			}
			
			public List<Sedes> GetAllByWithRelation()
			{
				try 
                {
                    List<Sedes> l = SqlMapper.Query<Sedes>(con, "API.PA_SedesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Sedes  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Sedes> GetByFilter(Sedes pSedes, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSedes.id== null || pSedes.id==0) ? vintNUll :pSedes.id);
                    p.Add("@ID_lE",(pSedes.ID_lE== null || pSedes.ID_lE==0) ? vintNUll :pSedes.ID_lE);
                    p.Add("@ID_Zona",(pSedes.ID_Zona== null || pSedes.ID_Zona==0) ? vintNUll :pSedes.ID_Zona);
                    p.Add("@ID_GrupoAnalisis",(pSedes.ID_GrupoAnalisis== null || pSedes.ID_GrupoAnalisis==0) ? vintNUll :pSedes.ID_GrupoAnalisis);
                    p.Add("@ID_ETC",(pSedes.ID_ETC== null || pSedes.ID_ETC==0) ? vintNUll :pSedes.ID_ETC);
                    p.Add("@ID_Divipola",(pSedes.ID_Divipola== null || pSedes.ID_Divipola==0) ? vintNUll :pSedes.ID_Divipola);
                    p.Add("@ID_TipoAcceso",(pSedes.ID_TipoAcceso== null || pSedes.ID_TipoAcceso==0) ? vintNUll :pSedes.ID_TipoAcceso);
                    p.Add("@CodigoDane",(pSedes.CodigoDane== null) ? vintNUll :pSedes.CodigoDane);
                    p.Add("@Nombre",(pSedes.Nombre== null) ? vintNUll :pSedes.Nombre);
                    p.Add("@Direccion",(pSedes.Direccion== null) ? vintNUll :pSedes.Direccion);
                    p.Add("@Telefono",(pSedes.Telefono== null) ? vintNUll :pSedes.Telefono);
                    p.Add("@Etnico",(pSedes.Etnico== null) ? vintNUll :pSedes.Etnico);
                    p.Add("@PriorizacionPAE",(pSedes.PriorizacionPAE== null) ? vintNUll :pSedes.PriorizacionPAE);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Sedes> l = SqlMapper.Query<Sedes>(con, "API.PA_SedesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Sedes  ->" + ex.Message);
				}
			}

			public Sedes Add(Sedes pSedes)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSedes.id==null ? 0 : pSedes.id);
p.Add("@ID_lE",pSedes.ID_lE==null ? 0 : pSedes.ID_lE);
p.Add("@ID_Zona",pSedes.ID_Zona==null ? 0 : pSedes.ID_Zona);
p.Add("@ID_GrupoAnalisis",pSedes.ID_GrupoAnalisis==null ? 0 : pSedes.ID_GrupoAnalisis);
p.Add("@ID_ETC",pSedes.ID_ETC==null ? 0 : pSedes.ID_ETC);
p.Add("@ID_Divipola",pSedes.ID_Divipola==null ? 0 : pSedes.ID_Divipola);
p.Add("@ID_TipoAcceso",pSedes.ID_TipoAcceso==null ? 0 : pSedes.ID_TipoAcceso);
                    p.Add("@CodigoDane", pSedes.CodigoDane);
                    p.Add("@Nombre", pSedes.Nombre);
                    p.Add("@Direccion", pSedes.Direccion);
                    p.Add("@Telefono", pSedes.Telefono);
                    p.Add("@Etnico", pSedes.Etnico);
                    p.Add("@PriorizacionPAE", pSedes.PriorizacionPAE);
                    p.Add("@auditoria", pSedes.auditoria);

                         


                    Sedes o = SqlMapper.QueryFirstOrDefault<Sedes>(con, "API.PA_SedesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Sedes  ->" + ex.Message);
				}
			}

			public Sedes  Update(Sedes pSedes)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSedes.id==null ? 0 : pSedes.id);
p.Add("@ID_lE",pSedes.ID_lE==null ? 0 : pSedes.ID_lE);
p.Add("@ID_Zona",pSedes.ID_Zona==null ? 0 : pSedes.ID_Zona);
p.Add("@ID_GrupoAnalisis",pSedes.ID_GrupoAnalisis==null ? 0 : pSedes.ID_GrupoAnalisis);
p.Add("@ID_ETC",pSedes.ID_ETC==null ? 0 : pSedes.ID_ETC);
p.Add("@ID_Divipola",pSedes.ID_Divipola==null ? 0 : pSedes.ID_Divipola);
p.Add("@ID_TipoAcceso",pSedes.ID_TipoAcceso==null ? 0 : pSedes.ID_TipoAcceso);
                    p.Add("@CodigoDane", pSedes.CodigoDane);
                    p.Add("@Nombre", pSedes.Nombre);
                    p.Add("@Direccion", pSedes.Direccion);
                    p.Add("@Telefono", pSedes.Telefono);
                    p.Add("@Etnico", pSedes.Etnico);
                    p.Add("@PriorizacionPAE", pSedes.PriorizacionPAE);
                    p.Add("@auditoria", pSedes.auditoria);

                         


                    Sedes o = SqlMapper.QueryFirstOrDefault<Sedes>(con, "API.PA_SedesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Sedes  ->" + ex.Message);
				}
			}

			public bool Delete(Sedes pSedes)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSedes.id);
                    p.Add("@auditoria", pSedes.auditoria);

                

 

					Sedes o = SqlMapper.QueryFirstOrDefault<Sedes>(con, "API.PA_SedesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Sedes  ->" + ex.Message);
				}
			}

		



            public List<Sedes> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Sedes> SedesList = new List<Sedes>();

                    SedesList = SqlMapper.Query<Sedes>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SedesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Sedes  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Sedes> b)
            {
                DapperPlusManager.Entity<Sedes>().Table("Sedes");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}