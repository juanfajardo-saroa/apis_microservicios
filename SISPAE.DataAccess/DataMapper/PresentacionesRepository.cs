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
     /// Clase Abstracta para  Presentaciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PresentacionesRepository : DataObject , IPresentaciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PresentacionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PresentacionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Presentaciones GetById(Presentaciones pPresentaciones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pPresentaciones.id);                                    


    				Presentaciones o = SqlMapper.QueryFirstOrDefault<Presentaciones>(con, "API.PA_PresentacionesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Presentaciones  ->" + ex.Message);
				}
			}

			public List<Presentaciones> GetAll()
			{
				try 
                {
                        List<Presentaciones> l = SqlMapper.Query<Presentaciones>(con, "API.PA_PresentacionesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Presentaciones  ->" + ex.Message);
				}
			}

			public List<Presentaciones> GetAllFull()
			{
				try 
				{
                    List<Presentaciones> l = SqlMapper.Query<Presentaciones>(con, "API.PA_PresentacionesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Presentaciones  ->" + ex.Message);
				}
			}
			
			public List<Presentaciones> GetAllByWithRelation()
			{
				try 
                {
                    List<Presentaciones> l = SqlMapper.Query<Presentaciones>(con, "API.PA_PresentacionesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Presentaciones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Presentaciones> GetByFilter(Presentaciones pPresentaciones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pPresentaciones.id== null || pPresentaciones.id==0) ? vintNUll :pPresentaciones.id);
                    p.Add("@ID_Producto",(pPresentaciones.ID_Producto== null || pPresentaciones.ID_Producto==0) ? vintNUll :pPresentaciones.ID_Producto);
                    p.Add("@ID_TipoGrupoEtareo",(pPresentaciones.ID_TipoGrupoEtareo== null || pPresentaciones.ID_TipoGrupoEtareo==0) ? vintNUll :pPresentaciones.ID_TipoGrupoEtareo);
                    p.Add("@PesoNeto",(pPresentaciones.PesoNeto== null) ? vintNUll :pPresentaciones.PesoNeto);
                    p.Add("@PesoBruto",(pPresentaciones.PesoBruto== null) ? vintNUll :pPresentaciones.PesoBruto);
                    p.Add("@PesoServido",(pPresentaciones.PesoServido== null) ? vintNUll :pPresentaciones.PesoServido);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Presentaciones> l = SqlMapper.Query<Presentaciones>(con, "API.PA_PresentacionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Presentaciones  ->" + ex.Message);
				}
			}

			public Presentaciones Add(Presentaciones pPresentaciones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pPresentaciones.id==null ? 0 : pPresentaciones.id);
p.Add("@ID_Producto",pPresentaciones.ID_Producto==null ? 0 : pPresentaciones.ID_Producto);
p.Add("@ID_TipoGrupoEtareo",pPresentaciones.ID_TipoGrupoEtareo==null ? 0 : pPresentaciones.ID_TipoGrupoEtareo);
p.Add("@PesoNeto",pPresentaciones.PesoNeto==null ? 0 : pPresentaciones.PesoNeto);
p.Add("@PesoBruto",pPresentaciones.PesoBruto==null ? 0 : pPresentaciones.PesoBruto);
p.Add("@PesoServido",pPresentaciones.PesoServido==null ? 0 : pPresentaciones.PesoServido);
                    p.Add("@auditoria", pPresentaciones.auditoria);

                         


                    Presentaciones o = SqlMapper.QueryFirstOrDefault<Presentaciones>(con, "API.PA_PresentacionesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Presentaciones  ->" + ex.Message);
				}
			}

			public Presentaciones  Update(Presentaciones pPresentaciones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pPresentaciones.id==null ? 0 : pPresentaciones.id);
p.Add("@ID_Producto",pPresentaciones.ID_Producto==null ? 0 : pPresentaciones.ID_Producto);
p.Add("@ID_TipoGrupoEtareo",pPresentaciones.ID_TipoGrupoEtareo==null ? 0 : pPresentaciones.ID_TipoGrupoEtareo);
p.Add("@PesoNeto",pPresentaciones.PesoNeto==null ? 0 : pPresentaciones.PesoNeto);
p.Add("@PesoBruto",pPresentaciones.PesoBruto==null ? 0 : pPresentaciones.PesoBruto);
p.Add("@PesoServido",pPresentaciones.PesoServido==null ? 0 : pPresentaciones.PesoServido);
                    p.Add("@auditoria", pPresentaciones.auditoria);

                         


                    Presentaciones o = SqlMapper.QueryFirstOrDefault<Presentaciones>(con, "API.PA_PresentacionesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Presentaciones  ->" + ex.Message);
				}
			}

			public bool Delete(Presentaciones pPresentaciones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pPresentaciones.id);
                    p.Add("@auditoria", pPresentaciones.auditoria);

                

 

					Presentaciones o = SqlMapper.QueryFirstOrDefault<Presentaciones>(con, "API.PA_PresentacionesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Presentaciones  ->" + ex.Message);
				}
			}

		



            public List<Presentaciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Presentaciones> PresentacionesList = new List<Presentaciones>();

                    PresentacionesList = SqlMapper.Query<Presentaciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PresentacionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Presentaciones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Presentaciones> b)
            {
                DapperPlusManager.Entity<Presentaciones>().Table("Presentaciones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}