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
     /// Clase Abstracta para  CajaHerramienta
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CajaHerramientaRepository : DataObject , ICajaHerramienta 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CajaHerramientaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CajaHerramientaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CajaHerramienta GetById(CajaHerramienta pCajaHerramienta)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCajaHerramienta.id);                                    


    				CajaHerramienta o = SqlMapper.QueryFirstOrDefault<CajaHerramienta>(con, "API.PA_CajaHerramientaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CajaHerramienta  ->" + ex.Message);
				}
			}

			public List<CajaHerramienta> GetAll()
			{
				try 
                {
                        List<CajaHerramienta> l = SqlMapper.Query<CajaHerramienta>(con, "API.PA_CajaHerramientaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CajaHerramienta  ->" + ex.Message);
				}
			}

			public List<CajaHerramienta> GetAllFull()
			{
				try 
				{
                    List<CajaHerramienta> l = SqlMapper.Query<CajaHerramienta>(con, "API.PA_CajaHerramientaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CajaHerramienta  ->" + ex.Message);
				}
			}
			
			public List<CajaHerramienta> GetAllByWithRelation()
			{
				try 
                {
                    List<CajaHerramienta> l = SqlMapper.Query<CajaHerramienta>(con, "API.PA_CajaHerramientaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CajaHerramienta  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CajaHerramienta> GetByFilter(CajaHerramienta pCajaHerramienta, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCajaHerramienta.id== null || pCajaHerramienta.id==0) ? vintNUll :pCajaHerramienta.id);
                    p.Add("@id_AnexoRecurso",(pCajaHerramienta.id_AnexoRecurso== null || pCajaHerramienta.id_AnexoRecurso==0) ? vintNUll :pCajaHerramienta.id_AnexoRecurso);
                    p.Add("@PATHArchivo",(pCajaHerramienta.PATHArchivo== null) ? vintNUll :pCajaHerramienta.PATHArchivo);
                    p.Add("@Nombre",(pCajaHerramienta.Nombre== null) ? vintNUll :pCajaHerramienta.Nombre);
                    p.Add("@Descripcion",(pCajaHerramienta.Descripcion== null) ? vintNUll :pCajaHerramienta.Descripcion);
                    p.Add("@FechaActualizacion",(pCajaHerramienta.FechaActualizacion== null) ? vintNUll :pCajaHerramienta.FechaActualizacion);
                    p.Add("@TamanoArchivo",(pCajaHerramienta.TamanoArchivo== null) ? vintNUll :pCajaHerramienta.TamanoArchivo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CajaHerramienta> l = SqlMapper.Query<CajaHerramienta>(con, "API.PA_CajaHerramientaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CajaHerramienta  ->" + ex.Message);
				}
			}

			public CajaHerramienta Add(CajaHerramienta pCajaHerramienta)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCajaHerramienta.id==null ? 0 : pCajaHerramienta.id);
p.Add("@id_AnexoRecurso",pCajaHerramienta.id_AnexoRecurso== null ? 0: pCajaHerramienta.id_AnexoRecurso);
                    p.Add("@PATHArchivo", pCajaHerramienta.PATHArchivo);
                    p.Add("@Nombre", pCajaHerramienta.Nombre);
                    p.Add("@Descripcion", pCajaHerramienta.Descripcion);
                    p.Add("@FechaActualizacion", pCajaHerramienta.FechaActualizacion);
                    p.Add("@TamanoArchivo", pCajaHerramienta.TamanoArchivo);
                    p.Add("@auditoria", pCajaHerramienta.auditoria);

                         


                    CajaHerramienta o = SqlMapper.QueryFirstOrDefault<CajaHerramienta>(con, "API.PA_CajaHerramientaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CajaHerramienta  ->" + ex.Message);
				}
			}

			public CajaHerramienta  Update(CajaHerramienta pCajaHerramienta)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCajaHerramienta.id==null ? 0 : pCajaHerramienta.id);
p.Add("@id_AnexoRecurso",pCajaHerramienta.id_AnexoRecurso== null ? 0: pCajaHerramienta.id_AnexoRecurso);
                    p.Add("@PATHArchivo", pCajaHerramienta.PATHArchivo);
                    p.Add("@Nombre", pCajaHerramienta.Nombre);
                    p.Add("@Descripcion", pCajaHerramienta.Descripcion);
                    p.Add("@FechaActualizacion", pCajaHerramienta.FechaActualizacion);
                    p.Add("@TamanoArchivo", pCajaHerramienta.TamanoArchivo);
                    p.Add("@auditoria", pCajaHerramienta.auditoria);

                         


                    CajaHerramienta o = SqlMapper.QueryFirstOrDefault<CajaHerramienta>(con, "API.PA_CajaHerramientaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CajaHerramienta  ->" + ex.Message);
				}
			}

			public bool Delete(CajaHerramienta pCajaHerramienta)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCajaHerramienta.id);
                    p.Add("@auditoria", pCajaHerramienta.auditoria);

                

 

					CajaHerramienta o = SqlMapper.QueryFirstOrDefault<CajaHerramienta>(con, "API.PA_CajaHerramientaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CajaHerramienta  ->" + ex.Message);
				}
			}

		



            public List<CajaHerramienta> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CajaHerramienta> CajaHerramientaList = new List<CajaHerramienta>();

                    CajaHerramientaList = SqlMapper.Query<CajaHerramienta>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CajaHerramientaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CajaHerramienta  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CajaHerramienta> b)
            {
                DapperPlusManager.Entity<CajaHerramienta>().Table("CajaHerramienta");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}