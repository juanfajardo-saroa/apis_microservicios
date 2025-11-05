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
     /// Clase Abstracta para  ZonaETC
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ZonaETCRepository : DataObject , IZonaETC 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ZonaETCRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ZonaETCRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ZonaETC GetById(ZonaETC pZonaETC)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pZonaETC.id);                                    


    				ZonaETC o = SqlMapper.QueryFirstOrDefault<ZonaETC>(con, "API.PA_ZonaETCGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ZonaETC  ->" + ex.Message);
				}
			}

			public List<ZonaETC> GetAll()
			{
				try 
                {
                        List<ZonaETC> l = SqlMapper.Query<ZonaETC>(con, "API.PA_ZonaETCGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ZonaETC  ->" + ex.Message);
				}
			}

			public List<ZonaETC> GetAllFull()
			{
				try 
				{
                    List<ZonaETC> l = SqlMapper.Query<ZonaETC>(con, "API.PA_ZonaETCGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ZonaETC  ->" + ex.Message);
				}
			}
			
			public List<ZonaETC> GetAllByWithRelation()
			{
				try 
                {
                    List<ZonaETC> l = SqlMapper.Query<ZonaETC>(con, "API.PA_ZonaETCGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ZonaETC  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ZonaETC> GetByFilter(ZonaETC pZonaETC, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pZonaETC.id== null || pZonaETC.id==0) ? vintNUll :pZonaETC.id);
                    p.Add("@ID_ETC",(pZonaETC.ID_ETC== null || pZonaETC.ID_ETC==0) ? vintNUll :pZonaETC.ID_ETC);
                    p.Add("@ID_Divipola",(pZonaETC.ID_Divipola== null || pZonaETC.ID_Divipola==0) ? vintNUll :pZonaETC.ID_Divipola);
                    p.Add("@Nombre",(pZonaETC.Nombre== null) ? vintNUll :pZonaETC.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ZonaETC> l = SqlMapper.Query<ZonaETC>(con, "API.PA_ZonaETCGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ZonaETC  ->" + ex.Message);
				}
			}

			public ZonaETC Add(ZonaETC pZonaETC)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pZonaETC.id==null ? 0 : pZonaETC.id);
p.Add("@ID_ETC",pZonaETC.ID_ETC==null ? 0 : pZonaETC.ID_ETC);
p.Add("@ID_Divipola",pZonaETC.ID_Divipola==null ? 0 : pZonaETC.ID_Divipola);
                    p.Add("@Nombre", pZonaETC.Nombre);
                    p.Add("@auditoria", pZonaETC.auditoria);

                         


                    ZonaETC o = SqlMapper.QueryFirstOrDefault<ZonaETC>(con, "API.PA_ZonaETCAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ZonaETC  ->" + ex.Message);
				}
			}

			public ZonaETC  Update(ZonaETC pZonaETC)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pZonaETC.id==null ? 0 : pZonaETC.id);
p.Add("@ID_ETC",pZonaETC.ID_ETC==null ? 0 : pZonaETC.ID_ETC);
p.Add("@ID_Divipola",pZonaETC.ID_Divipola==null ? 0 : pZonaETC.ID_Divipola);
                    p.Add("@Nombre", pZonaETC.Nombre);
                    p.Add("@auditoria", pZonaETC.auditoria);

                         


                    ZonaETC o = SqlMapper.QueryFirstOrDefault<ZonaETC>(con, "API.PA_ZonaETCUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ZonaETC  ->" + ex.Message);
				}
			}

			public bool Delete(ZonaETC pZonaETC)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pZonaETC.id);
                    p.Add("@auditoria", pZonaETC.auditoria);

                

 

					ZonaETC o = SqlMapper.QueryFirstOrDefault<ZonaETC>(con, "API.PA_ZonaETCDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ZonaETC  ->" + ex.Message);
				}
			}

		



            public List<ZonaETC> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ZonaETC> ZonaETCList = new List<ZonaETC>();

                    ZonaETCList = SqlMapper.Query<ZonaETC>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ZonaETCList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ZonaETC  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ZonaETC> b)
            {
                DapperPlusManager.Entity<ZonaETC>().Table("ZonaETC");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}