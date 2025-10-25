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
     /// Clase Abstracta para  DetallesSumLogistico
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class DetallesSumLogisticoRepository : DataObject , IDetallesSumLogistico 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public DetallesSumLogisticoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public DetallesSumLogisticoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public DetallesSumLogistico GetById(DetallesSumLogistico pDetallesSumLogistico)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pDetallesSumLogistico.id);                                    


    				DetallesSumLogistico o = SqlMapper.QueryFirstOrDefault<DetallesSumLogistico>(con, "API.PA_DetallesSumLogisticoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  DetallesSumLogistico  ->" + ex.Message);
				}
			}

			public List<DetallesSumLogistico> GetAll()
			{
				try 
                {
                        List<DetallesSumLogistico> l = SqlMapper.Query<DetallesSumLogistico>(con, "API.PA_DetallesSumLogisticoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  DetallesSumLogistico  ->" + ex.Message);
				}
			}

			public List<DetallesSumLogistico> GetAllFull()
			{
				try 
				{
                    List<DetallesSumLogistico> l = SqlMapper.Query<DetallesSumLogistico>(con, "API.PA_DetallesSumLogisticoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  DetallesSumLogistico  ->" + ex.Message);
				}
			}
			
			public List<DetallesSumLogistico> GetAllByWithRelation()
			{
				try 
                {
                    List<DetallesSumLogistico> l = SqlMapper.Query<DetallesSumLogistico>(con, "API.PA_DetallesSumLogisticoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  DetallesSumLogistico  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<DetallesSumLogistico> GetByFilter(DetallesSumLogistico pDetallesSumLogistico, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pDetallesSumLogistico.id== null || pDetallesSumLogistico.id==0) ? vintNUll :pDetallesSumLogistico.id);
                    p.Add("@ID_contrato",(pDetallesSumLogistico.ID_contrato== null || pDetallesSumLogistico.ID_contrato==0) ? vintNUll :pDetallesSumLogistico.ID_contrato);
                    p.Add("@NumeroDiasSuministro",(pDetallesSumLogistico.NumeroDiasSuministro== null) ? vintNUll :pDetallesSumLogistico.NumeroDiasSuministro);
                    p.Add("@TotalComplementosContratadas",(pDetallesSumLogistico.TotalComplementosContratadas== null) ? vintNUll :pDetallesSumLogistico.TotalComplementosContratadas);
                    p.Add("@CostoUnitarioEnsambleOperacion",(pDetallesSumLogistico.CostoUnitarioEnsambleOperacion== null) ? vintNUll :pDetallesSumLogistico.CostoUnitarioEnsambleOperacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<DetallesSumLogistico> l = SqlMapper.Query<DetallesSumLogistico>(con, "API.PA_DetallesSumLogisticoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  DetallesSumLogistico  ->" + ex.Message);
				}
			}

			public DetallesSumLogistico Add(DetallesSumLogistico pDetallesSumLogistico)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pDetallesSumLogistico.id==null ? 0 : pDetallesSumLogistico.id);
p.Add("@ID_contrato",pDetallesSumLogistico.ID_contrato==null ? 0 : pDetallesSumLogistico.ID_contrato);
p.Add("@NumeroDiasSuministro",pDetallesSumLogistico.NumeroDiasSuministro==null ? 0 : pDetallesSumLogistico.NumeroDiasSuministro);
p.Add("@TotalComplementosContratadas",pDetallesSumLogistico.TotalComplementosContratadas==null ? 0 : pDetallesSumLogistico.TotalComplementosContratadas);
                    p.Add("@CostoUnitarioEnsambleOperacion", pDetallesSumLogistico.CostoUnitarioEnsambleOperacion);
                    p.Add("@auditoria", pDetallesSumLogistico.auditoria);

                         


                    DetallesSumLogistico o = SqlMapper.QueryFirstOrDefault<DetallesSumLogistico>(con, "API.PA_DetallesSumLogisticoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  DetallesSumLogistico  ->" + ex.Message);
				}
			}

			public DetallesSumLogistico  Update(DetallesSumLogistico pDetallesSumLogistico)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pDetallesSumLogistico.id==null ? 0 : pDetallesSumLogistico.id);
p.Add("@ID_contrato",pDetallesSumLogistico.ID_contrato==null ? 0 : pDetallesSumLogistico.ID_contrato);
p.Add("@NumeroDiasSuministro",pDetallesSumLogistico.NumeroDiasSuministro==null ? 0 : pDetallesSumLogistico.NumeroDiasSuministro);
p.Add("@TotalComplementosContratadas",pDetallesSumLogistico.TotalComplementosContratadas==null ? 0 : pDetallesSumLogistico.TotalComplementosContratadas);
                    p.Add("@CostoUnitarioEnsambleOperacion", pDetallesSumLogistico.CostoUnitarioEnsambleOperacion);
                    p.Add("@auditoria", pDetallesSumLogistico.auditoria);

                         


                    DetallesSumLogistico o = SqlMapper.QueryFirstOrDefault<DetallesSumLogistico>(con, "API.PA_DetallesSumLogisticoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  DetallesSumLogistico  ->" + ex.Message);
				}
			}

			public bool Delete(DetallesSumLogistico pDetallesSumLogistico)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pDetallesSumLogistico.id);
                    p.Add("@auditoria", pDetallesSumLogistico.auditoria);

                

 

					DetallesSumLogistico o = SqlMapper.QueryFirstOrDefault<DetallesSumLogistico>(con, "API.PA_DetallesSumLogisticoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) DetallesSumLogistico  ->" + ex.Message);
				}
			}

		



            public List<DetallesSumLogistico> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<DetallesSumLogistico> DetallesSumLogisticoList = new List<DetallesSumLogistico>();

                    DetallesSumLogisticoList = SqlMapper.Query<DetallesSumLogistico>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return DetallesSumLogisticoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) DetallesSumLogistico  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<DetallesSumLogistico> b)
            {
                DapperPlusManager.Entity<DetallesSumLogistico>().Table("DetallesSumLogistico");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}