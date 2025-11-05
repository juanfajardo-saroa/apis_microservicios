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
     /// Clase Abstracta para  DivipolasComprasLocales
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class DivipolasComprasLocalesRepository : DataObject , IDivipolasComprasLocales 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public DivipolasComprasLocalesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public DivipolasComprasLocalesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public DivipolasComprasLocales GetById(DivipolasComprasLocales pDivipolasComprasLocales)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pDivipolasComprasLocales.id);                                    


    				DivipolasComprasLocales o = SqlMapper.QueryFirstOrDefault<DivipolasComprasLocales>(con, "API.PA_DivipolasComprasLocalesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  DivipolasComprasLocales  ->" + ex.Message);
				}
			}

			public List<DivipolasComprasLocales> GetAll()
			{
				try 
                {
                        List<DivipolasComprasLocales> l = SqlMapper.Query<DivipolasComprasLocales>(con, "API.PA_DivipolasComprasLocalesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  DivipolasComprasLocales  ->" + ex.Message);
				}
			}

			public List<DivipolasComprasLocales> GetAllFull()
			{
				try 
				{
                    List<DivipolasComprasLocales> l = SqlMapper.Query<DivipolasComprasLocales>(con, "API.PA_DivipolasComprasLocalesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  DivipolasComprasLocales  ->" + ex.Message);
				}
			}
			
			public List<DivipolasComprasLocales> GetAllByWithRelation()
			{
				try 
                {
                    List<DivipolasComprasLocales> l = SqlMapper.Query<DivipolasComprasLocales>(con, "API.PA_DivipolasComprasLocalesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  DivipolasComprasLocales  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<DivipolasComprasLocales> GetByFilter(DivipolasComprasLocales pDivipolasComprasLocales, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pDivipolasComprasLocales.id== null || pDivipolasComprasLocales.id==0) ? vintNUll :pDivipolasComprasLocales.id);
                    p.Add("@ID_ComprasLocales",(pDivipolasComprasLocales.ID_ComprasLocales== null || pDivipolasComprasLocales.ID_ComprasLocales==0) ? vintNUll :pDivipolasComprasLocales.ID_ComprasLocales);
                    p.Add("@ID_divipola",(pDivipolasComprasLocales.ID_divipola== null || pDivipolasComprasLocales.ID_divipola==0) ? vintNUll :pDivipolasComprasLocales.ID_divipola);
                    p.Add("@Nombre",(pDivipolasComprasLocales.Nombre== null) ? vintNUll :pDivipolasComprasLocales.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<DivipolasComprasLocales> l = SqlMapper.Query<DivipolasComprasLocales>(con, "API.PA_DivipolasComprasLocalesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  DivipolasComprasLocales  ->" + ex.Message);
				}
			}

			public DivipolasComprasLocales Add(DivipolasComprasLocales pDivipolasComprasLocales)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pDivipolasComprasLocales.id==null ? 0 : pDivipolasComprasLocales.id);
p.Add("@ID_ComprasLocales",pDivipolasComprasLocales.ID_ComprasLocales==null ? 0 : pDivipolasComprasLocales.ID_ComprasLocales);
p.Add("@ID_divipola",pDivipolasComprasLocales.ID_divipola==null ? 0 : pDivipolasComprasLocales.ID_divipola);
                    p.Add("@Nombre", pDivipolasComprasLocales.Nombre);
                    p.Add("@auditoria", pDivipolasComprasLocales.auditoria);

                         


                    DivipolasComprasLocales o = SqlMapper.QueryFirstOrDefault<DivipolasComprasLocales>(con, "API.PA_DivipolasComprasLocalesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  DivipolasComprasLocales  ->" + ex.Message);
				}
			}

			public DivipolasComprasLocales  Update(DivipolasComprasLocales pDivipolasComprasLocales)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pDivipolasComprasLocales.id==null ? 0 : pDivipolasComprasLocales.id);
p.Add("@ID_ComprasLocales",pDivipolasComprasLocales.ID_ComprasLocales==null ? 0 : pDivipolasComprasLocales.ID_ComprasLocales);
p.Add("@ID_divipola",pDivipolasComprasLocales.ID_divipola==null ? 0 : pDivipolasComprasLocales.ID_divipola);
                    p.Add("@Nombre", pDivipolasComprasLocales.Nombre);
                    p.Add("@auditoria", pDivipolasComprasLocales.auditoria);

                         


                    DivipolasComprasLocales o = SqlMapper.QueryFirstOrDefault<DivipolasComprasLocales>(con, "API.PA_DivipolasComprasLocalesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  DivipolasComprasLocales  ->" + ex.Message);
				}
			}

			public bool Delete(DivipolasComprasLocales pDivipolasComprasLocales)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pDivipolasComprasLocales.id);
                    p.Add("@auditoria", pDivipolasComprasLocales.auditoria);

                

 

					DivipolasComprasLocales o = SqlMapper.QueryFirstOrDefault<DivipolasComprasLocales>(con, "API.PA_DivipolasComprasLocalesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) DivipolasComprasLocales  ->" + ex.Message);
				}
			}

		



            public List<DivipolasComprasLocales> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<DivipolasComprasLocales> DivipolasComprasLocalesList = new List<DivipolasComprasLocales>();

                    DivipolasComprasLocalesList = SqlMapper.Query<DivipolasComprasLocales>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return DivipolasComprasLocalesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) DivipolasComprasLocales  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<DivipolasComprasLocales> b)
            {
                DapperPlusManager.Entity<DivipolasComprasLocales>().Table("DivipolasComprasLocales");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}