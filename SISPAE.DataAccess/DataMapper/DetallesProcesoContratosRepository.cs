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
     /// Clase Abstracta para  DetallesProcesoContratos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class DetallesProcesoContratosRepository : DataObject , IDetallesProcesoContratos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public DetallesProcesoContratosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public DetallesProcesoContratosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public DetallesProcesoContratos GetById(DetallesProcesoContratos pDetallesProcesoContratos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pDetallesProcesoContratos.id);                                    


    				DetallesProcesoContratos o = SqlMapper.QueryFirstOrDefault<DetallesProcesoContratos>(con, "API.PA_DetallesProcesoContratosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  DetallesProcesoContratos  ->" + ex.Message);
				}
			}

			public List<DetallesProcesoContratos> GetAll()
			{
				try 
                {
                        List<DetallesProcesoContratos> l = SqlMapper.Query<DetallesProcesoContratos>(con, "API.PA_DetallesProcesoContratosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  DetallesProcesoContratos  ->" + ex.Message);
				}
			}

			public List<DetallesProcesoContratos> GetAllFull()
			{
				try 
				{
                    List<DetallesProcesoContratos> l = SqlMapper.Query<DetallesProcesoContratos>(con, "API.PA_DetallesProcesoContratosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  DetallesProcesoContratos  ->" + ex.Message);
				}
			}
			
			public List<DetallesProcesoContratos> GetAllByWithRelation()
			{
				try 
                {
                    List<DetallesProcesoContratos> l = SqlMapper.Query<DetallesProcesoContratos>(con, "API.PA_DetallesProcesoContratosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  DetallesProcesoContratos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<DetallesProcesoContratos> GetByFilter(DetallesProcesoContratos pDetallesProcesoContratos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pDetallesProcesoContratos.id== null || pDetallesProcesoContratos.id==0) ? vintNUll :pDetallesProcesoContratos.id);
                    p.Add("@ID_Contrato",(pDetallesProcesoContratos.ID_Contrato== null || pDetallesProcesoContratos.ID_Contrato==0) ? vintNUll :pDetallesProcesoContratos.ID_Contrato);
                    p.Add("@ID_TipoContratacion",(pDetallesProcesoContratos.ID_TipoContratacion== null || pDetallesProcesoContratos.ID_TipoContratacion==0) ? vintNUll :pDetallesProcesoContratos.ID_TipoContratacion);
                    p.Add("@ID_PlataformaContrato",(pDetallesProcesoContratos.ID_PlataformaContrato== null || pDetallesProcesoContratos.ID_PlataformaContrato==0) ? vintNUll :pDetallesProcesoContratos.ID_PlataformaContrato);
                    p.Add("@PublicadorSECOP",(pDetallesProcesoContratos.PublicadorSECOP== null) ? vintNUll :pDetallesProcesoContratos.PublicadorSECOP);
                    p.Add("@NumeroProcesoRegistradoSECOP",(pDetallesProcesoContratos.NumeroProcesoRegistradoSECOP== null) ? vintNUll :pDetallesProcesoContratos.NumeroProcesoRegistradoSECOP);
                    p.Add("@LinkContratoSECOP",(pDetallesProcesoContratos.LinkContratoSECOP== null) ? vintNUll :pDetallesProcesoContratos.LinkContratoSECOP);
                    p.Add("@FechaAdjudicacion",(pDetallesProcesoContratos.FechaAdjudicacion== null) ? vintNUll :pDetallesProcesoContratos.FechaAdjudicacion);
                    p.Add("@FechaSuscripcion",(pDetallesProcesoContratos.FechaSuscripcion== null) ? vintNUll :pDetallesProcesoContratos.FechaSuscripcion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<DetallesProcesoContratos> l = SqlMapper.Query<DetallesProcesoContratos>(con, "API.PA_DetallesProcesoContratosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  DetallesProcesoContratos  ->" + ex.Message);
				}
			}

			public DetallesProcesoContratos Add(DetallesProcesoContratos pDetallesProcesoContratos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pDetallesProcesoContratos.id==null ? 0 : pDetallesProcesoContratos.id);
p.Add("@ID_Contrato",pDetallesProcesoContratos.ID_Contrato==null ? 0 : pDetallesProcesoContratos.ID_Contrato);
p.Add("@ID_TipoContratacion",pDetallesProcesoContratos.ID_TipoContratacion==null ? 0 : pDetallesProcesoContratos.ID_TipoContratacion);
p.Add("@ID_PlataformaContrato",pDetallesProcesoContratos.ID_PlataformaContrato==null ? 0 : pDetallesProcesoContratos.ID_PlataformaContrato);
                    p.Add("@PublicadorSECOP", pDetallesProcesoContratos.PublicadorSECOP);
                    p.Add("@NumeroProcesoRegistradoSECOP", pDetallesProcesoContratos.NumeroProcesoRegistradoSECOP);
                    p.Add("@LinkContratoSECOP", pDetallesProcesoContratos.LinkContratoSECOP);
                    p.Add("@FechaAdjudicacion", pDetallesProcesoContratos.FechaAdjudicacion);
                    p.Add("@FechaSuscripcion", pDetallesProcesoContratos.FechaSuscripcion);
                    p.Add("@auditoria", pDetallesProcesoContratos.auditoria);

                         


                    DetallesProcesoContratos o = SqlMapper.QueryFirstOrDefault<DetallesProcesoContratos>(con, "API.PA_DetallesProcesoContratosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  DetallesProcesoContratos  ->" + ex.Message);
				}
			}

			public DetallesProcesoContratos  Update(DetallesProcesoContratos pDetallesProcesoContratos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pDetallesProcesoContratos.id==null ? 0 : pDetallesProcesoContratos.id);
p.Add("@ID_Contrato",pDetallesProcesoContratos.ID_Contrato==null ? 0 : pDetallesProcesoContratos.ID_Contrato);
p.Add("@ID_TipoContratacion",pDetallesProcesoContratos.ID_TipoContratacion==null ? 0 : pDetallesProcesoContratos.ID_TipoContratacion);
p.Add("@ID_PlataformaContrato",pDetallesProcesoContratos.ID_PlataformaContrato==null ? 0 : pDetallesProcesoContratos.ID_PlataformaContrato);
                    p.Add("@PublicadorSECOP", pDetallesProcesoContratos.PublicadorSECOP);
                    p.Add("@NumeroProcesoRegistradoSECOP", pDetallesProcesoContratos.NumeroProcesoRegistradoSECOP);
                    p.Add("@LinkContratoSECOP", pDetallesProcesoContratos.LinkContratoSECOP);
                    p.Add("@FechaAdjudicacion", pDetallesProcesoContratos.FechaAdjudicacion);
                    p.Add("@FechaSuscripcion", pDetallesProcesoContratos.FechaSuscripcion);
                    p.Add("@auditoria", pDetallesProcesoContratos.auditoria);

                         


                    DetallesProcesoContratos o = SqlMapper.QueryFirstOrDefault<DetallesProcesoContratos>(con, "API.PA_DetallesProcesoContratosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  DetallesProcesoContratos  ->" + ex.Message);
				}
			}

			public bool Delete(DetallesProcesoContratos pDetallesProcesoContratos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pDetallesProcesoContratos.id);
                    p.Add("@auditoria", pDetallesProcesoContratos.auditoria);

                

 

					DetallesProcesoContratos o = SqlMapper.QueryFirstOrDefault<DetallesProcesoContratos>(con, "API.PA_DetallesProcesoContratosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) DetallesProcesoContratos  ->" + ex.Message);
				}
			}

		



            public List<DetallesProcesoContratos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<DetallesProcesoContratos> DetallesProcesoContratosList = new List<DetallesProcesoContratos>();

                    DetallesProcesoContratosList = SqlMapper.Query<DetallesProcesoContratos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return DetallesProcesoContratosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) DetallesProcesoContratos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<DetallesProcesoContratos> b)
            {
                DapperPlusManager.Entity<DetallesProcesoContratos>().Table("DetallesProcesoContratos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}