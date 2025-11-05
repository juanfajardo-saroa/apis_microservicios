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
     /// Clase Abstracta para  ZonaETCSedes
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ZonaETCSedesRepository : DataObject , IZonaETCSedes 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ZonaETCSedesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ZonaETCSedesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ZonaETCSedes GetById(ZonaETCSedes pZonaETCSedes)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pZonaETCSedes.id);                                    


    				ZonaETCSedes o = SqlMapper.QueryFirstOrDefault<ZonaETCSedes>(con, "API.PA_ZonaETCSedesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ZonaETCSedes  ->" + ex.Message);
				}
			}

			public List<ZonaETCSedes> GetAll()
			{
				try 
                {
                        List<ZonaETCSedes> l = SqlMapper.Query<ZonaETCSedes>(con, "API.PA_ZonaETCSedesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ZonaETCSedes  ->" + ex.Message);
				}
			}

			public List<ZonaETCSedes> GetAllFull()
			{
				try 
				{
                    List<ZonaETCSedes> l = SqlMapper.Query<ZonaETCSedes>(con, "API.PA_ZonaETCSedesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ZonaETCSedes  ->" + ex.Message);
				}
			}
			
			public List<ZonaETCSedes> GetAllByWithRelation()
			{
				try 
                {
                    List<ZonaETCSedes> l = SqlMapper.Query<ZonaETCSedes>(con, "API.PA_ZonaETCSedesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ZonaETCSedes  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ZonaETCSedes> GetByFilter(ZonaETCSedes pZonaETCSedes, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pZonaETCSedes.id== null || pZonaETCSedes.id==0) ? vintNUll :pZonaETCSedes.id);
                    p.Add("@ID_ZonaETC",(pZonaETCSedes.ID_ZonaETC== null || pZonaETCSedes.ID_ZonaETC==0) ? vintNUll :pZonaETCSedes.ID_ZonaETC);
                    p.Add("@ID_Sedes",(pZonaETCSedes.ID_Sedes== null || pZonaETCSedes.ID_Sedes==0) ? vintNUll :pZonaETCSedes.ID_Sedes);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ZonaETCSedes> l = SqlMapper.Query<ZonaETCSedes>(con, "API.PA_ZonaETCSedesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ZonaETCSedes  ->" + ex.Message);
				}
			}

			public ZonaETCSedes Add(ZonaETCSedes pZonaETCSedes)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pZonaETCSedes.id==null ? 0 : pZonaETCSedes.id);
p.Add("@ID_ZonaETC",pZonaETCSedes.ID_ZonaETC==null ? 0 : pZonaETCSedes.ID_ZonaETC);
p.Add("@ID_Sedes",pZonaETCSedes.ID_Sedes==null ? 0 : pZonaETCSedes.ID_Sedes);
                    p.Add("@auditoria", pZonaETCSedes.auditoria);

                         


                    ZonaETCSedes o = SqlMapper.QueryFirstOrDefault<ZonaETCSedes>(con, "API.PA_ZonaETCSedesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ZonaETCSedes  ->" + ex.Message);
				}
			}

			public ZonaETCSedes  Update(ZonaETCSedes pZonaETCSedes)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pZonaETCSedes.id==null ? 0 : pZonaETCSedes.id);
p.Add("@ID_ZonaETC",pZonaETCSedes.ID_ZonaETC==null ? 0 : pZonaETCSedes.ID_ZonaETC);
p.Add("@ID_Sedes",pZonaETCSedes.ID_Sedes==null ? 0 : pZonaETCSedes.ID_Sedes);
                    p.Add("@auditoria", pZonaETCSedes.auditoria);

                         


                    ZonaETCSedes o = SqlMapper.QueryFirstOrDefault<ZonaETCSedes>(con, "API.PA_ZonaETCSedesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ZonaETCSedes  ->" + ex.Message);
				}
			}

			public bool Delete(ZonaETCSedes pZonaETCSedes)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pZonaETCSedes.id);
                    p.Add("@auditoria", pZonaETCSedes.auditoria);

                

 

					ZonaETCSedes o = SqlMapper.QueryFirstOrDefault<ZonaETCSedes>(con, "API.PA_ZonaETCSedesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ZonaETCSedes  ->" + ex.Message);
				}
			}

		



            public List<ZonaETCSedes> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ZonaETCSedes> ZonaETCSedesList = new List<ZonaETCSedes>();

                    ZonaETCSedesList = SqlMapper.Query<ZonaETCSedes>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ZonaETCSedesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ZonaETCSedes  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ZonaETCSedes> b)
            {
                DapperPlusManager.Entity<ZonaETCSedes>().Table("ZonaETCSedes");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}