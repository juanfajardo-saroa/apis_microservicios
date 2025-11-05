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
     /// Clase Abstracta para  SuministrosDescentralizados
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SuministrosDescentralizadosRepository : DataObject , ISuministrosDescentralizados 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SuministrosDescentralizadosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SuministrosDescentralizadosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public SuministrosDescentralizados GetById(SuministrosDescentralizados pSuministrosDescentralizados)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@Id",pSuministrosDescentralizados.Id);                                    


    				SuministrosDescentralizados o = SqlMapper.QueryFirstOrDefault<SuministrosDescentralizados>(con, "API.PA_SuministrosDescentralizadosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  SuministrosDescentralizados  ->" + ex.Message);
				}
			}

			public List<SuministrosDescentralizados> GetAll()
			{
				try 
                {
                        List<SuministrosDescentralizados> l = SqlMapper.Query<SuministrosDescentralizados>(con, "API.PA_SuministrosDescentralizadosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  SuministrosDescentralizados  ->" + ex.Message);
				}
			}

			public List<SuministrosDescentralizados> GetAllFull()
			{
				try 
				{
                    List<SuministrosDescentralizados> l = SqlMapper.Query<SuministrosDescentralizados>(con, "API.PA_SuministrosDescentralizadosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  SuministrosDescentralizados  ->" + ex.Message);
				}
			}
			
			public List<SuministrosDescentralizados> GetAllByWithRelation()
			{
				try 
                {
                    List<SuministrosDescentralizados> l = SqlMapper.Query<SuministrosDescentralizados>(con, "API.PA_SuministrosDescentralizadosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  SuministrosDescentralizados  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<SuministrosDescentralizados> GetByFilter(SuministrosDescentralizados pSuministrosDescentralizados, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@Id",(pSuministrosDescentralizados.Id== null || pSuministrosDescentralizados.Id==0) ? vintNUll :pSuministrosDescentralizados.Id);
                    p.Add("@Id_Contrato",(pSuministrosDescentralizados.Id_Contrato== null || pSuministrosDescentralizados.Id_Contrato==0) ? vintNUll :pSuministrosDescentralizados.Id_Contrato);
                    p.Add("@Id_ContratoAsociado",(pSuministrosDescentralizados.Id_ContratoAsociado== null || pSuministrosDescentralizados.Id_ContratoAsociado==0) ? vintNUll :pSuministrosDescentralizados.Id_ContratoAsociado);
                    p.Add("@ValorContrato",(pSuministrosDescentralizados.ValorContrato== null) ? vintNUll :pSuministrosDescentralizados.ValorContrato);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<SuministrosDescentralizados> l = SqlMapper.Query<SuministrosDescentralizados>(con, "API.PA_SuministrosDescentralizadosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  SuministrosDescentralizados  ->" + ex.Message);
				}
			}

			public SuministrosDescentralizados Add(SuministrosDescentralizados pSuministrosDescentralizados)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@Id",pSuministrosDescentralizados.Id==null ? 0 : pSuministrosDescentralizados.Id);
p.Add("@Id_Contrato",pSuministrosDescentralizados.Id_Contrato==null ? 0 : pSuministrosDescentralizados.Id_Contrato);
p.Add("@Id_ContratoAsociado",pSuministrosDescentralizados.Id_ContratoAsociado==null ? 0 : pSuministrosDescentralizados.Id_ContratoAsociado);
                    p.Add("@ValorContrato", pSuministrosDescentralizados.ValorContrato);
                    p.Add("@auditoria", pSuministrosDescentralizados.Auditoria);

                         


                    SuministrosDescentralizados o = SqlMapper.QueryFirstOrDefault<SuministrosDescentralizados>(con, "API.PA_SuministrosDescentralizadosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  SuministrosDescentralizados  ->" + ex.Message);
				}
			}

			public SuministrosDescentralizados  Update(SuministrosDescentralizados pSuministrosDescentralizados)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@Id",pSuministrosDescentralizados.Id==null ? 0 : pSuministrosDescentralizados.Id);
p.Add("@Id_Contrato",pSuministrosDescentralizados.Id_Contrato==null ? 0 : pSuministrosDescentralizados.Id_Contrato);
p.Add("@Id_ContratoAsociado",pSuministrosDescentralizados.Id_ContratoAsociado==null ? 0 : pSuministrosDescentralizados.Id_ContratoAsociado);
                    p.Add("@ValorContrato", pSuministrosDescentralizados.ValorContrato);
                    p.Add("@auditoria", pSuministrosDescentralizados.Auditoria);

                         


                    SuministrosDescentralizados o = SqlMapper.QueryFirstOrDefault<SuministrosDescentralizados>(con, "API.PA_SuministrosDescentralizadosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  SuministrosDescentralizados  ->" + ex.Message);
				}
			}

			public bool Delete(SuministrosDescentralizados pSuministrosDescentralizados)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@Id",pSuministrosDescentralizados.Id);
                    p.Add("@auditoria", pSuministrosDescentralizados.Auditoria);

                

 

					SuministrosDescentralizados o = SqlMapper.QueryFirstOrDefault<SuministrosDescentralizados>(con, "API.PA_SuministrosDescentralizadosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) SuministrosDescentralizados  ->" + ex.Message);
				}
			}

		



            public List<SuministrosDescentralizados> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<SuministrosDescentralizados> SuministrosDescentralizadosList = new List<SuministrosDescentralizados>();

                    SuministrosDescentralizadosList = SqlMapper.Query<SuministrosDescentralizados>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SuministrosDescentralizadosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) SuministrosDescentralizados  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<SuministrosDescentralizados> b)
            {
                DapperPlusManager.Entity<SuministrosDescentralizados>().Table("SuministrosDescentralizados");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}