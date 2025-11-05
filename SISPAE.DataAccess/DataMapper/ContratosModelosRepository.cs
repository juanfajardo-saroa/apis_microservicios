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
     /// Clase Abstracta para  ContratosModelos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ContratosModelosRepository : DataObject , IContratosModelos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ContratosModelosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ContratosModelosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ContratosModelos GetById(ContratosModelos pContratosModelos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@ContratoId",pContratosModelos.ContratoId);p.Add("@TipoModeloOperacionId",pContratosModelos.TipoModeloOperacionId);                                    


    				ContratosModelos o = SqlMapper.QueryFirstOrDefault<ContratosModelos>(con, "API.PA_ContratosModelosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ContratosModelos  ->" + ex.Message);
				}
			}

			public List<ContratosModelos> GetAll()
			{
				try 
                {
                        List<ContratosModelos> l = SqlMapper.Query<ContratosModelos>(con, "API.PA_ContratosModelosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ContratosModelos  ->" + ex.Message);
				}
			}

			public List<ContratosModelos> GetAllFull()
			{
				try 
				{
                    List<ContratosModelos> l = SqlMapper.Query<ContratosModelos>(con, "API.PA_ContratosModelosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ContratosModelos  ->" + ex.Message);
				}
			}
			
			public List<ContratosModelos> GetAllByWithRelation()
			{
				try 
                {
                    List<ContratosModelos> l = SqlMapper.Query<ContratosModelos>(con, "API.PA_ContratosModelosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ContratosModelos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ContratosModelos> GetByFilter(ContratosModelos pContratosModelos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ContratoId",(pContratosModelos.ContratoId== null) ? vintNUll :pContratosModelos.ContratoId);
                    p.Add("@TipoModeloOperacionId",(pContratosModelos.TipoModeloOperacionId== null) ? vintNUll :pContratosModelos.TipoModeloOperacionId);
                    p.Add("@PreciosZona",(pContratosModelos.PreciosZona== null) ? vintNUll :pContratosModelos.PreciosZona);
                    p.Add("@PreciosNivelEducativo",(pContratosModelos.PreciosNivelEducativo== null) ? vintNUll :pContratosModelos.PreciosNivelEducativo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ContratosModelos> l = SqlMapper.Query<ContratosModelos>(con, "API.PA_ContratosModelosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ContratosModelos  ->" + ex.Message);
				}
			}

			public ContratosModelos Add(ContratosModelos pContratosModelos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ContratoId",pContratosModelos.ContratoId==null ? 0 : pContratosModelos.ContratoId);
p.Add("@TipoModeloOperacionId",pContratosModelos.TipoModeloOperacionId==null ? 0 : pContratosModelos.TipoModeloOperacionId);
                    p.Add("@PreciosZona", pContratosModelos.PreciosZona);
                    p.Add("@PreciosNivelEducativo", pContratosModelos.PreciosNivelEducativo);
                    p.Add("@auditoria", pContratosModelos.Auditoria);

                         


                    ContratosModelos o = SqlMapper.QueryFirstOrDefault<ContratosModelos>(con, "API.PA_ContratosModelosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ContratosModelos  ->" + ex.Message);
				}
			}

			public ContratosModelos  Update(ContratosModelos pContratosModelos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ContratoId",pContratosModelos.ContratoId==null ? 0 : pContratosModelos.ContratoId);
p.Add("@TipoModeloOperacionId",pContratosModelos.TipoModeloOperacionId==null ? 0 : pContratosModelos.TipoModeloOperacionId);
                    p.Add("@PreciosZona", pContratosModelos.PreciosZona);
                    p.Add("@PreciosNivelEducativo", pContratosModelos.PreciosNivelEducativo);
                    p.Add("@auditoria", pContratosModelos.Auditoria);

                         


                    ContratosModelos o = SqlMapper.QueryFirstOrDefault<ContratosModelos>(con, "API.PA_ContratosModelosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ContratosModelos  ->" + ex.Message);
				}
			}

			public bool Delete(ContratosModelos pContratosModelos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@ContratoId",pContratosModelos.ContratoId);
p.Add("@TipoModeloOperacionId",pContratosModelos.TipoModeloOperacionId);
                    p.Add("@auditoria", pContratosModelos.Auditoria);

                

 

					ContratosModelos o = SqlMapper.QueryFirstOrDefault<ContratosModelos>(con, "API.PA_ContratosModelosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ContratosModelos  ->" + ex.Message);
				}
			}

		



            public List<ContratosModelos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ContratosModelos> ContratosModelosList = new List<ContratosModelos>();

                    ContratosModelosList = SqlMapper.Query<ContratosModelos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ContratosModelosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ContratosModelos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ContratosModelos> b)
            {
                DapperPlusManager.Entity<ContratosModelos>().Table("ContratosModelos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}