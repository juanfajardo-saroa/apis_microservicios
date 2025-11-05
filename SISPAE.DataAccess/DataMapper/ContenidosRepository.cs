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
     /// Clase Abstracta para  Contenidos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ContenidosRepository : DataObject , IContenidos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ContenidosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ContenidosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Contenidos GetById(Contenidos pContenidos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pContenidos.id);                                    


    				Contenidos o = SqlMapper.QueryFirstOrDefault<Contenidos>(con, "API.PA_ContenidosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Contenidos  ->" + ex.Message);
				}
			}

			public List<Contenidos> GetAll()
			{
				try 
                {
                        List<Contenidos> l = SqlMapper.Query<Contenidos>(con, "API.PA_ContenidosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Contenidos  ->" + ex.Message);
				}
			}

			public List<Contenidos> GetAllFull()
			{
				try 
				{
                    List<Contenidos> l = SqlMapper.Query<Contenidos>(con, "API.PA_ContenidosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Contenidos  ->" + ex.Message);
				}
			}
			
			public List<Contenidos> GetAllByWithRelation()
			{
				try 
                {
                    List<Contenidos> l = SqlMapper.Query<Contenidos>(con, "API.PA_ContenidosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Contenidos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Contenidos> GetByFilter(Contenidos pContenidos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pContenidos.id== null || pContenidos.id==0) ? vintNUll :pContenidos.id);
                    p.Add("@ID_ETC",(pContenidos.ID_ETC== null || pContenidos.ID_ETC==0) ? vintNUll :pContenidos.ID_ETC);
                    p.Add("@ID_Categoria",(pContenidos.ID_Categoria== null || pContenidos.ID_Categoria==0) ? vintNUll :pContenidos.ID_Categoria);
                    p.Add("@ID_Multimedia",(pContenidos.ID_Multimedia== null || pContenidos.ID_Multimedia==0) ? vintNUll :pContenidos.ID_Multimedia);
                    p.Add("@Nombre",(pContenidos.Nombre== null) ? vintNUll :pContenidos.Nombre);
                    p.Add("@Fecha",(pContenidos.Fecha== null) ? vintNUll :pContenidos.Fecha);
                    p.Add("@TextoContenido",(pContenidos.TextoContenido== null) ? vintNUll :pContenidos.TextoContenido);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Contenidos> l = SqlMapper.Query<Contenidos>(con, "API.PA_ContenidosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Contenidos  ->" + ex.Message);
				}
			}

			public Contenidos Add(Contenidos pContenidos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pContenidos.id==null ? 0 : pContenidos.id);
p.Add("@ID_ETC",pContenidos.ID_ETC==null ? 0 : pContenidos.ID_ETC);
p.Add("@ID_Categoria",pContenidos.ID_Categoria==null ? 0 : pContenidos.ID_Categoria);
p.Add("@ID_Multimedia",pContenidos.ID_Multimedia==null ? 0 : pContenidos.ID_Multimedia);
                    p.Add("@Nombre", pContenidos.Nombre);
                    p.Add("@Fecha", pContenidos.Fecha);
                    p.Add("@TextoContenido", pContenidos.TextoContenido);
                    p.Add("@auditoria", pContenidos.auditoria);

                         


                    Contenidos o = SqlMapper.QueryFirstOrDefault<Contenidos>(con, "API.PA_ContenidosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Contenidos  ->" + ex.Message);
				}
			}

			public Contenidos  Update(Contenidos pContenidos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pContenidos.id==null ? 0 : pContenidos.id);
p.Add("@ID_ETC",pContenidos.ID_ETC==null ? 0 : pContenidos.ID_ETC);
p.Add("@ID_Categoria",pContenidos.ID_Categoria==null ? 0 : pContenidos.ID_Categoria);
p.Add("@ID_Multimedia",pContenidos.ID_Multimedia==null ? 0 : pContenidos.ID_Multimedia);
                    p.Add("@Nombre", pContenidos.Nombre);
                    p.Add("@Fecha", pContenidos.Fecha);
                    p.Add("@TextoContenido", pContenidos.TextoContenido);
                    p.Add("@auditoria", pContenidos.auditoria);

                         


                    Contenidos o = SqlMapper.QueryFirstOrDefault<Contenidos>(con, "API.PA_ContenidosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Contenidos  ->" + ex.Message);
				}
			}

			public bool Delete(Contenidos pContenidos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pContenidos.id);
                    p.Add("@auditoria", pContenidos.auditoria);

                

 

					Contenidos o = SqlMapper.QueryFirstOrDefault<Contenidos>(con, "API.PA_ContenidosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Contenidos  ->" + ex.Message);
				}
			}

		



            public List<Contenidos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Contenidos> ContenidosList = new List<Contenidos>();

                    ContenidosList = SqlMapper.Query<Contenidos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ContenidosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Contenidos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Contenidos> b)
            {
                DapperPlusManager.Entity<Contenidos>().Table("Contenidos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}