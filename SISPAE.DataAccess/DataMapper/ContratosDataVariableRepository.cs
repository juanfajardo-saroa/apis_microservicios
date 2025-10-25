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
     /// Clase Abstracta para  ContratosDataVariable
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ContratosDataVariableRepository : DataObject , IContratosDataVariable 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ContratosDataVariableRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ContratosDataVariableRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ContratosDataVariable GetById(ContratosDataVariable pContratosDataVariable)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pContratosDataVariable.id);                                    


    				ContratosDataVariable o = SqlMapper.QueryFirstOrDefault<ContratosDataVariable>(con, "API.PA_ContratosDataVariableGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ContratosDataVariable  ->" + ex.Message);
				}
			}

			public List<ContratosDataVariable> GetAll()
			{
				try 
                {
                        List<ContratosDataVariable> l = SqlMapper.Query<ContratosDataVariable>(con, "API.PA_ContratosDataVariableGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ContratosDataVariable  ->" + ex.Message);
				}
			}

			public List<ContratosDataVariable> GetAllFull()
			{
				try 
				{
                    List<ContratosDataVariable> l = SqlMapper.Query<ContratosDataVariable>(con, "API.PA_ContratosDataVariableGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ContratosDataVariable  ->" + ex.Message);
				}
			}
			
			public List<ContratosDataVariable> GetAllByWithRelation()
			{
				try 
                {
                    List<ContratosDataVariable> l = SqlMapper.Query<ContratosDataVariable>(con, "API.PA_ContratosDataVariableGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ContratosDataVariable  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ContratosDataVariable> GetByFilter(ContratosDataVariable pContratosDataVariable, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pContratosDataVariable.id== null || pContratosDataVariable.id==0) ? vintNUll :pContratosDataVariable.id);
                    p.Add("@ID_Contrato",(pContratosDataVariable.ID_Contrato== null || pContratosDataVariable.ID_Contrato==0) ? vintNUll :pContratosDataVariable.ID_Contrato);
                    p.Add("@ID_Modificacion",(pContratosDataVariable.ID_Modificacion== null || pContratosDataVariable.ID_Modificacion==0) ? vintNUll :pContratosDataVariable.ID_Modificacion);
                    p.Add("@Actual",(pContratosDataVariable.Actual== null) ? vintNUll :pContratosDataVariable.Actual);
                    p.Add("@FechaTerminacionContrato",(pContratosDataVariable.FechaTerminacionContrato== null) ? vintNUll :pContratosDataVariable.FechaTerminacionContrato);
                    p.Add("@ValorTotalContrato",(pContratosDataVariable.ValorTotalContrato== null) ? vintNUll :pContratosDataVariable.ValorTotalContrato);
                    p.Add("@NumeroDiasSuministro",(pContratosDataVariable.NumeroDiasSuministro== null) ? vintNUll :pContratosDataVariable.NumeroDiasSuministro);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ContratosDataVariable> l = SqlMapper.Query<ContratosDataVariable>(con, "API.PA_ContratosDataVariableGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ContratosDataVariable  ->" + ex.Message);
				}
			}

			public ContratosDataVariable Add(ContratosDataVariable pContratosDataVariable)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pContratosDataVariable.id==null ? 0 : pContratosDataVariable.id);
p.Add("@ID_Contrato",pContratosDataVariable.ID_Contrato==null ? 0 : pContratosDataVariable.ID_Contrato);
p.Add("@ID_Modificacion",pContratosDataVariable.ID_Modificacion==null ? 0 : pContratosDataVariable.ID_Modificacion);
p.Add("@Actual",pContratosDataVariable.Actual==null ? 0 : pContratosDataVariable.Actual);
                    p.Add("@FechaTerminacionContrato", pContratosDataVariable.FechaTerminacionContrato);
p.Add("@ValorTotalContrato",pContratosDataVariable.ValorTotalContrato==null ? 0 : pContratosDataVariable.ValorTotalContrato);
p.Add("@NumeroDiasSuministro",pContratosDataVariable.NumeroDiasSuministro==null ? 0 : pContratosDataVariable.NumeroDiasSuministro);
                    p.Add("@auditoria", pContratosDataVariable.auditoria);

                         


                    ContratosDataVariable o = SqlMapper.QueryFirstOrDefault<ContratosDataVariable>(con, "API.PA_ContratosDataVariableAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ContratosDataVariable  ->" + ex.Message);
				}
			}

			public ContratosDataVariable  Update(ContratosDataVariable pContratosDataVariable)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pContratosDataVariable.id==null ? 0 : pContratosDataVariable.id);
p.Add("@ID_Contrato",pContratosDataVariable.ID_Contrato==null ? 0 : pContratosDataVariable.ID_Contrato);
p.Add("@ID_Modificacion",pContratosDataVariable.ID_Modificacion==null ? 0 : pContratosDataVariable.ID_Modificacion);
p.Add("@Actual",pContratosDataVariable.Actual==null ? 0 : pContratosDataVariable.Actual);
                    p.Add("@FechaTerminacionContrato", pContratosDataVariable.FechaTerminacionContrato);
p.Add("@ValorTotalContrato",pContratosDataVariable.ValorTotalContrato==null ? 0 : pContratosDataVariable.ValorTotalContrato);
p.Add("@NumeroDiasSuministro",pContratosDataVariable.NumeroDiasSuministro==null ? 0 : pContratosDataVariable.NumeroDiasSuministro);
                    p.Add("@auditoria", pContratosDataVariable.auditoria);

                         


                    ContratosDataVariable o = SqlMapper.QueryFirstOrDefault<ContratosDataVariable>(con, "API.PA_ContratosDataVariableUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ContratosDataVariable  ->" + ex.Message);
				}
			}

			public bool Delete(ContratosDataVariable pContratosDataVariable)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pContratosDataVariable.id);
                    p.Add("@auditoria", pContratosDataVariable.auditoria);

                

 

					ContratosDataVariable o = SqlMapper.QueryFirstOrDefault<ContratosDataVariable>(con, "API.PA_ContratosDataVariableDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ContratosDataVariable  ->" + ex.Message);
				}
			}

		



            public List<ContratosDataVariable> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ContratosDataVariable> ContratosDataVariableList = new List<ContratosDataVariable>();

                    ContratosDataVariableList = SqlMapper.Query<ContratosDataVariable>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ContratosDataVariableList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ContratosDataVariable  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ContratosDataVariable> b)
            {
                DapperPlusManager.Entity<ContratosDataVariable>().Table("ContratosDataVariable");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}