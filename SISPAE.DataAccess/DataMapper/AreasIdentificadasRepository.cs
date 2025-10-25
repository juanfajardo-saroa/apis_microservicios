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
     /// Clase Abstracta para  AreasIdentificadas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AreasIdentificadasRepository : DataObject , IAreasIdentificadas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AreasIdentificadasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AreasIdentificadasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AreasIdentificadas GetById(AreasIdentificadas pAreasIdentificadas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAreasIdentificadas.id);                                    


    				AreasIdentificadas o = SqlMapper.QueryFirstOrDefault<AreasIdentificadas>(con, "API.PA_AreasIdentificadasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AreasIdentificadas  ->" + ex.Message);
				}
			}

			public List<AreasIdentificadas> GetAll()
			{
				try 
                {
                        List<AreasIdentificadas> l = SqlMapper.Query<AreasIdentificadas>(con, "API.PA_AreasIdentificadasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AreasIdentificadas  ->" + ex.Message);
				}
			}

			public List<AreasIdentificadas> GetAllFull()
			{
				try 
				{
                    List<AreasIdentificadas> l = SqlMapper.Query<AreasIdentificadas>(con, "API.PA_AreasIdentificadasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AreasIdentificadas  ->" + ex.Message);
				}
			}
			
			public List<AreasIdentificadas> GetAllByWithRelation()
			{
				try 
                {
                    List<AreasIdentificadas> l = SqlMapper.Query<AreasIdentificadas>(con, "API.PA_AreasIdentificadasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AreasIdentificadas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AreasIdentificadas> GetByFilter(AreasIdentificadas pAreasIdentificadas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAreasIdentificadas.id== null || pAreasIdentificadas.id==0) ? vintNUll :pAreasIdentificadas.id);
                    p.Add("@ID_Dimension",(pAreasIdentificadas.ID_Dimension== null || pAreasIdentificadas.ID_Dimension==0) ? vintNUll :pAreasIdentificadas.ID_Dimension);
                    p.Add("@Nombre",(pAreasIdentificadas.Nombre== null) ? vintNUll :pAreasIdentificadas.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AreasIdentificadas> l = SqlMapper.Query<AreasIdentificadas>(con, "API.PA_AreasIdentificadasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AreasIdentificadas  ->" + ex.Message);
				}
			}

			public AreasIdentificadas Add(AreasIdentificadas pAreasIdentificadas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAreasIdentificadas.id==null ? 0 : pAreasIdentificadas.id);
p.Add("@ID_Dimension",pAreasIdentificadas.ID_Dimension==null ? 0 : pAreasIdentificadas.ID_Dimension);
                    p.Add("@Nombre", pAreasIdentificadas.Nombre);
                    p.Add("@auditoria", pAreasIdentificadas.auditoria);

                         


                    AreasIdentificadas o = SqlMapper.QueryFirstOrDefault<AreasIdentificadas>(con, "API.PA_AreasIdentificadasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AreasIdentificadas  ->" + ex.Message);
				}
			}

			public AreasIdentificadas  Update(AreasIdentificadas pAreasIdentificadas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAreasIdentificadas.id==null ? 0 : pAreasIdentificadas.id);
p.Add("@ID_Dimension",pAreasIdentificadas.ID_Dimension==null ? 0 : pAreasIdentificadas.ID_Dimension);
                    p.Add("@Nombre", pAreasIdentificadas.Nombre);
                    p.Add("@auditoria", pAreasIdentificadas.auditoria);

                         


                    AreasIdentificadas o = SqlMapper.QueryFirstOrDefault<AreasIdentificadas>(con, "API.PA_AreasIdentificadasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AreasIdentificadas  ->" + ex.Message);
				}
			}

			public bool Delete(AreasIdentificadas pAreasIdentificadas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAreasIdentificadas.id);
                    p.Add("@auditoria", pAreasIdentificadas.auditoria);

                

 

					AreasIdentificadas o = SqlMapper.QueryFirstOrDefault<AreasIdentificadas>(con, "API.PA_AreasIdentificadasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AreasIdentificadas  ->" + ex.Message);
				}
			}

		



            public List<AreasIdentificadas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AreasIdentificadas> AreasIdentificadasList = new List<AreasIdentificadas>();

                    AreasIdentificadasList = SqlMapper.Query<AreasIdentificadas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AreasIdentificadasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AreasIdentificadas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AreasIdentificadas> b)
            {
                DapperPlusManager.Entity<AreasIdentificadas>().Table("AreasIdentificadas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}