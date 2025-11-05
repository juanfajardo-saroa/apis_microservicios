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
     /// Clase Abstracta para  DivipolasProveedor
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class DivipolasProveedorRepository : DataObject , IDivipolasProveedor 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public DivipolasProveedorRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public DivipolasProveedorRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public DivipolasProveedor GetById(DivipolasProveedor pDivipolasProveedor)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pDivipolasProveedor.id);                                    


    				DivipolasProveedor o = SqlMapper.QueryFirstOrDefault<DivipolasProveedor>(con, "API.PA_DivipolasProveedorGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  DivipolasProveedor  ->" + ex.Message);
				}
			}

			public List<DivipolasProveedor> GetAll()
			{
				try 
                {
                        List<DivipolasProveedor> l = SqlMapper.Query<DivipolasProveedor>(con, "API.PA_DivipolasProveedorGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  DivipolasProveedor  ->" + ex.Message);
				}
			}

			public List<DivipolasProveedor> GetAllFull()
			{
				try 
				{
                    List<DivipolasProveedor> l = SqlMapper.Query<DivipolasProveedor>(con, "API.PA_DivipolasProveedorGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  DivipolasProveedor  ->" + ex.Message);
				}
			}
			
			public List<DivipolasProveedor> GetAllByWithRelation()
			{
				try 
                {
                    List<DivipolasProveedor> l = SqlMapper.Query<DivipolasProveedor>(con, "API.PA_DivipolasProveedorGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  DivipolasProveedor  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<DivipolasProveedor> GetByFilter(DivipolasProveedor pDivipolasProveedor, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pDivipolasProveedor.id== null || pDivipolasProveedor.id==0) ? vintNUll :pDivipolasProveedor.id);
                    p.Add("@ID_Divipolas",(pDivipolasProveedor.ID_Divipolas== null || pDivipolasProveedor.ID_Divipolas==0) ? vintNUll :pDivipolasProveedor.ID_Divipolas);
                    p.Add("@Nombre",(pDivipolasProveedor.Nombre== null) ? vintNUll :pDivipolasProveedor.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<DivipolasProveedor> l = SqlMapper.Query<DivipolasProveedor>(con, "API.PA_DivipolasProveedorGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  DivipolasProveedor  ->" + ex.Message);
				}
			}

			public DivipolasProveedor Add(DivipolasProveedor pDivipolasProveedor)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pDivipolasProveedor.id==null ? 0 : pDivipolasProveedor.id);
p.Add("@ID_Divipolas",pDivipolasProveedor.ID_Divipolas==null ? 0 : pDivipolasProveedor.ID_Divipolas);
                    p.Add("@Nombre", pDivipolasProveedor.Nombre);
                    p.Add("@auditoria", pDivipolasProveedor.auditoria);

                         


                    DivipolasProveedor o = SqlMapper.QueryFirstOrDefault<DivipolasProveedor>(con, "API.PA_DivipolasProveedorAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  DivipolasProveedor  ->" + ex.Message);
				}
			}

			public DivipolasProveedor  Update(DivipolasProveedor pDivipolasProveedor)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pDivipolasProveedor.id==null ? 0 : pDivipolasProveedor.id);
p.Add("@ID_Divipolas",pDivipolasProveedor.ID_Divipolas==null ? 0 : pDivipolasProveedor.ID_Divipolas);
                    p.Add("@Nombre", pDivipolasProveedor.Nombre);
                    p.Add("@auditoria", pDivipolasProveedor.auditoria);

                         


                    DivipolasProveedor o = SqlMapper.QueryFirstOrDefault<DivipolasProveedor>(con, "API.PA_DivipolasProveedorUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  DivipolasProveedor  ->" + ex.Message);
				}
			}

			public bool Delete(DivipolasProveedor pDivipolasProveedor)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pDivipolasProveedor.id);
                    p.Add("@auditoria", pDivipolasProveedor.auditoria);

                

 

					DivipolasProveedor o = SqlMapper.QueryFirstOrDefault<DivipolasProveedor>(con, "API.PA_DivipolasProveedorDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) DivipolasProveedor  ->" + ex.Message);
				}
			}

		



            public List<DivipolasProveedor> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<DivipolasProveedor> DivipolasProveedorList = new List<DivipolasProveedor>();

                    DivipolasProveedorList = SqlMapper.Query<DivipolasProveedor>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return DivipolasProveedorList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) DivipolasProveedor  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<DivipolasProveedor> b)
            {
                DapperPlusManager.Entity<DivipolasProveedor>().Table("DivipolasProveedor");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}