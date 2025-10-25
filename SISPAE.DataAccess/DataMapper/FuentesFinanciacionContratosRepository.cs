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
     /// Clase Abstracta para  FuentesFinanciacionContratos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class FuentesFinanciacionContratosRepository : DataObject , IFuentesFinanciacionContratos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public FuentesFinanciacionContratosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public FuentesFinanciacionContratosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public FuentesFinanciacionContratos GetById(FuentesFinanciacionContratos pFuentesFinanciacionContratos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pFuentesFinanciacionContratos.id);                                    


    				FuentesFinanciacionContratos o = SqlMapper.QueryFirstOrDefault<FuentesFinanciacionContratos>(con, "API.PA_FuentesFinanciacionContratosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  FuentesFinanciacionContratos  ->" + ex.Message);
				}
			}

			public List<FuentesFinanciacionContratos> GetAll()
			{
				try 
                {
                        List<FuentesFinanciacionContratos> l = SqlMapper.Query<FuentesFinanciacionContratos>(con, "API.PA_FuentesFinanciacionContratosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  FuentesFinanciacionContratos  ->" + ex.Message);
				}
			}

			public List<FuentesFinanciacionContratos> GetAllFull()
			{
				try 
				{
                    List<FuentesFinanciacionContratos> l = SqlMapper.Query<FuentesFinanciacionContratos>(con, "API.PA_FuentesFinanciacionContratosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  FuentesFinanciacionContratos  ->" + ex.Message);
				}
			}
			
			public List<FuentesFinanciacionContratos> GetAllByWithRelation()
			{
				try 
                {
                    List<FuentesFinanciacionContratos> l = SqlMapper.Query<FuentesFinanciacionContratos>(con, "API.PA_FuentesFinanciacionContratosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  FuentesFinanciacionContratos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<FuentesFinanciacionContratos> GetByFilter(FuentesFinanciacionContratos pFuentesFinanciacionContratos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pFuentesFinanciacionContratos.id== null || pFuentesFinanciacionContratos.id==0) ? vintNUll :pFuentesFinanciacionContratos.id);
                    p.Add("@ID_Contrato",(pFuentesFinanciacionContratos.ID_Contrato== null || pFuentesFinanciacionContratos.ID_Contrato==0) ? vintNUll :pFuentesFinanciacionContratos.ID_Contrato);
                    p.Add("@ID_FuenteFinanciacion",(pFuentesFinanciacionContratos.ID_FuenteFinanciacion== null || pFuentesFinanciacionContratos.ID_FuenteFinanciacion==0) ? vintNUll :pFuentesFinanciacionContratos.ID_FuenteFinanciacion);
                    p.Add("@ID_FuenteIngresos",(pFuentesFinanciacionContratos.ID_FuenteIngresos== null || pFuentesFinanciacionContratos.ID_FuenteIngresos==0) ? vintNUll :pFuentesFinanciacionContratos.ID_FuenteIngresos);
                    p.Add("@Valor",(pFuentesFinanciacionContratos.Valor== null) ? vintNUll :pFuentesFinanciacionContratos.Valor);
                    p.Add("@Id_Modificacion",(pFuentesFinanciacionContratos.Id_Modificacion== null || pFuentesFinanciacionContratos.Id_Modificacion==0) ? vintNUll :pFuentesFinanciacionContratos.Id_Modificacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<FuentesFinanciacionContratos> l = SqlMapper.Query<FuentesFinanciacionContratos>(con, "API.PA_FuentesFinanciacionContratosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  FuentesFinanciacionContratos  ->" + ex.Message);
				}
			}

			public FuentesFinanciacionContratos Add(FuentesFinanciacionContratos pFuentesFinanciacionContratos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pFuentesFinanciacionContratos.id==null ? 0 : pFuentesFinanciacionContratos.id);
p.Add("@ID_Contrato",pFuentesFinanciacionContratos.ID_Contrato==null ? 0 : pFuentesFinanciacionContratos.ID_Contrato);
p.Add("@ID_FuenteFinanciacion",pFuentesFinanciacionContratos.ID_FuenteFinanciacion==null ? 0 : pFuentesFinanciacionContratos.ID_FuenteFinanciacion);
p.Add("@ID_FuenteIngresos",pFuentesFinanciacionContratos.ID_FuenteIngresos==null ? 0 : pFuentesFinanciacionContratos.ID_FuenteIngresos);
                    p.Add("@Valor", pFuentesFinanciacionContratos.Valor);
p.Add("@Id_Modificacion",pFuentesFinanciacionContratos.Id_Modificacion==null ? 0 : pFuentesFinanciacionContratos.Id_Modificacion);
                    p.Add("@auditoria", pFuentesFinanciacionContratos.auditoria);

                         


                    FuentesFinanciacionContratos o = SqlMapper.QueryFirstOrDefault<FuentesFinanciacionContratos>(con, "API.PA_FuentesFinanciacionContratosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  FuentesFinanciacionContratos  ->" + ex.Message);
				}
			}

			public FuentesFinanciacionContratos  Update(FuentesFinanciacionContratos pFuentesFinanciacionContratos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pFuentesFinanciacionContratos.id==null ? 0 : pFuentesFinanciacionContratos.id);
p.Add("@ID_Contrato",pFuentesFinanciacionContratos.ID_Contrato==null ? 0 : pFuentesFinanciacionContratos.ID_Contrato);
p.Add("@ID_FuenteFinanciacion",pFuentesFinanciacionContratos.ID_FuenteFinanciacion==null ? 0 : pFuentesFinanciacionContratos.ID_FuenteFinanciacion);
p.Add("@ID_FuenteIngresos",pFuentesFinanciacionContratos.ID_FuenteIngresos==null ? 0 : pFuentesFinanciacionContratos.ID_FuenteIngresos);
                    p.Add("@Valor", pFuentesFinanciacionContratos.Valor);
p.Add("@Id_Modificacion",pFuentesFinanciacionContratos.Id_Modificacion==null ? 0 : pFuentesFinanciacionContratos.Id_Modificacion);
                    p.Add("@auditoria", pFuentesFinanciacionContratos.auditoria);

                         


                    FuentesFinanciacionContratos o = SqlMapper.QueryFirstOrDefault<FuentesFinanciacionContratos>(con, "API.PA_FuentesFinanciacionContratosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  FuentesFinanciacionContratos  ->" + ex.Message);
				}
			}

			public bool Delete(FuentesFinanciacionContratos pFuentesFinanciacionContratos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pFuentesFinanciacionContratos.id);
                    p.Add("@auditoria", pFuentesFinanciacionContratos.auditoria);

                

 

					FuentesFinanciacionContratos o = SqlMapper.QueryFirstOrDefault<FuentesFinanciacionContratos>(con, "API.PA_FuentesFinanciacionContratosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) FuentesFinanciacionContratos  ->" + ex.Message);
				}
			}

		



            public List<FuentesFinanciacionContratos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<FuentesFinanciacionContratos> FuentesFinanciacionContratosList = new List<FuentesFinanciacionContratos>();

                    FuentesFinanciacionContratosList = SqlMapper.Query<FuentesFinanciacionContratos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return FuentesFinanciacionContratosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) FuentesFinanciacionContratos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<FuentesFinanciacionContratos> b)
            {
                DapperPlusManager.Entity<FuentesFinanciacionContratos>().Table("FuentesFinanciacionContratos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}