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
     /// Clase Abstracta para  Rectores
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class RectoresRepository : DataObject , IRectores 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public RectoresRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public RectoresRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Rectores GetById(Rectores pRectores)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pRectores.id);                                    


    				Rectores o = SqlMapper.QueryFirstOrDefault<Rectores>(con, "API.PA_RectoresGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Rectores  ->" + ex.Message);
				}
			}

			public List<Rectores> GetAll()
			{
				try 
                {
                        List<Rectores> l = SqlMapper.Query<Rectores>(con, "API.PA_RectoresGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Rectores  ->" + ex.Message);
				}
			}

			public List<Rectores> GetAllFull()
			{
				try 
				{
                    List<Rectores> l = SqlMapper.Query<Rectores>(con, "API.PA_RectoresGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Rectores  ->" + ex.Message);
				}
			}
			
			public List<Rectores> GetAllByWithRelation()
			{
				try 
                {
                    List<Rectores> l = SqlMapper.Query<Rectores>(con, "API.PA_RectoresGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Rectores  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Rectores> GetByFilter(Rectores pRectores, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pRectores.id== null || pRectores.id==0) ? vintNUll :pRectores.id);
                    p.Add("@ID_User",(pRectores.ID_User== null) ? vintNUll :pRectores.ID_User);
                    p.Add("@Nombre",(pRectores.Nombre== null) ? vintNUll :pRectores.Nombre);
                    p.Add("@Apellido",(pRectores.Apellido== null) ? vintNUll :pRectores.Apellido);
                    p.Add("@Correo",(pRectores.Correo== null) ? vintNUll :pRectores.Correo);
                    p.Add("@Codigo",(pRectores.Codigo== null) ? vintNUll :pRectores.Codigo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Rectores> l = SqlMapper.Query<Rectores>(con, "API.PA_RectoresGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Rectores  ->" + ex.Message);
				}
			}

			public Rectores Add(Rectores pRectores)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pRectores.id==null ? 0 : pRectores.id);
                    p.Add("@ID_User", pRectores.ID_User);
                    p.Add("@Nombre", pRectores.Nombre);
                    p.Add("@Apellido", pRectores.Apellido);
                    p.Add("@Correo", pRectores.Correo);
                    p.Add("@Codigo", pRectores.Codigo);
                    p.Add("@auditoria", pRectores.auditoria);

                         


                    Rectores o = SqlMapper.QueryFirstOrDefault<Rectores>(con, "API.PA_RectoresAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Rectores  ->" + ex.Message);
				}
			}

			public Rectores  Update(Rectores pRectores)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pRectores.id==null ? 0 : pRectores.id);
                    p.Add("@ID_User", pRectores.ID_User);
                    p.Add("@Nombre", pRectores.Nombre);
                    p.Add("@Apellido", pRectores.Apellido);
                    p.Add("@Correo", pRectores.Correo);
                    p.Add("@Codigo", pRectores.Codigo);
                    p.Add("@auditoria", pRectores.auditoria);

                         


                    Rectores o = SqlMapper.QueryFirstOrDefault<Rectores>(con, "API.PA_RectoresUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Rectores  ->" + ex.Message);
				}
			}

			public bool Delete(Rectores pRectores)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pRectores.id);
                    p.Add("@auditoria", pRectores.auditoria);

                

 

					Rectores o = SqlMapper.QueryFirstOrDefault<Rectores>(con, "API.PA_RectoresDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Rectores  ->" + ex.Message);
				}
			}

		



            public List<Rectores> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Rectores> RectoresList = new List<Rectores>();

                    RectoresList = SqlMapper.Query<Rectores>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return RectoresList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Rectores  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Rectores> b)
            {
                DapperPlusManager.Entity<Rectores>().Table("Rectores");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}