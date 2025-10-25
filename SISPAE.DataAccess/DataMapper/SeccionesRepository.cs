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
     /// Clase Abstracta para  Secciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SeccionesRepository : DataObject , ISecciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SeccionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SeccionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Secciones GetById(Secciones pSecciones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSecciones.id);                                    


    				Secciones o = SqlMapper.QueryFirstOrDefault<Secciones>(con, "API.PA_SeccionesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Secciones  ->" + ex.Message);
				}
			}

			public List<Secciones> GetAll()
			{
				try 
                {
                        List<Secciones> l = SqlMapper.Query<Secciones>(con, "API.PA_SeccionesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Secciones  ->" + ex.Message);
				}
			}

			public List<Secciones> GetAllFull()
			{
				try 
				{
                    List<Secciones> l = SqlMapper.Query<Secciones>(con, "API.PA_SeccionesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Secciones  ->" + ex.Message);
				}
			}
			
			public List<Secciones> GetAllByWithRelation()
			{
				try 
                {
                    List<Secciones> l = SqlMapper.Query<Secciones>(con, "API.PA_SeccionesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Secciones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Secciones> GetByFilter(Secciones pSecciones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSecciones.id== null || pSecciones.id==0) ? vintNUll :pSecciones.id);
                    p.Add("@Nombre",(pSecciones.Nombre== null) ? vintNUll :pSecciones.Nombre);
                    p.Add("@id_Submodulos",(pSecciones.id_Submodulos== null || pSecciones.id_Submodulos==0) ? vintNUll :pSecciones.id_Submodulos);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Secciones> l = SqlMapper.Query<Secciones>(con, "API.PA_SeccionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Secciones  ->" + ex.Message);
				}
			}

			public Secciones Add(Secciones pSecciones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSecciones.id==null ? 0 : pSecciones.id);
                    p.Add("@Nombre", pSecciones.Nombre);
p.Add("@id_Submodulos",pSecciones.id_Submodulos== null ? 0: pSecciones.id_Submodulos);
                    p.Add("@auditoria", pSecciones.auditoria);

                         


                    Secciones o = SqlMapper.QueryFirstOrDefault<Secciones>(con, "API.PA_SeccionesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Secciones  ->" + ex.Message);
				}
			}

			public Secciones  Update(Secciones pSecciones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSecciones.id==null ? 0 : pSecciones.id);
                    p.Add("@Nombre", pSecciones.Nombre);
p.Add("@id_Submodulos",pSecciones.id_Submodulos== null ? 0: pSecciones.id_Submodulos);
                    p.Add("@auditoria", pSecciones.auditoria);

                         


                    Secciones o = SqlMapper.QueryFirstOrDefault<Secciones>(con, "API.PA_SeccionesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Secciones  ->" + ex.Message);
				}
			}

			public bool Delete(Secciones pSecciones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSecciones.id);
                    p.Add("@auditoria", pSecciones.auditoria);

                

 

					Secciones o = SqlMapper.QueryFirstOrDefault<Secciones>(con, "API.PA_SeccionesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Secciones  ->" + ex.Message);
				}
			}

		



            public List<Secciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Secciones> SeccionesList = new List<Secciones>();

                    SeccionesList = SqlMapper.Query<Secciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SeccionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Secciones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Secciones> b)
            {
                DapperPlusManager.Entity<Secciones>().Table("Secciones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}