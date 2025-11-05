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
     /// Clase Abstracta para  TP_Departamento
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TP_DepartamentoRepository : DataObject , ITP_Departamento 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TP_DepartamentoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TP_DepartamentoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TP_Departamento GetById(TP_Departamento pTP_Departamento)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTP_Departamento.id);                                    


    				TP_Departamento o = SqlMapper.QueryFirstOrDefault<TP_Departamento>(con, "API.PA_TP_DepartamentoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TP_Departamento  ->" + ex.Message);
				}
			}

			public List<TP_Departamento> GetAll()
			{
				try 
                {
                        List<TP_Departamento> l = SqlMapper.Query<TP_Departamento>(con, "API.PA_TP_DepartamentoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TP_Departamento  ->" + ex.Message);
				}
			}

			public List<TP_Departamento> GetAllFull()
			{
				try 
				{
                    List<TP_Departamento> l = SqlMapper.Query<TP_Departamento>(con, "API.PA_TP_DepartamentoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TP_Departamento  ->" + ex.Message);
				}
			}
			
			public List<TP_Departamento> GetAllByWithRelation()
			{
				try 
                {
                    List<TP_Departamento> l = SqlMapper.Query<TP_Departamento>(con, "API.PA_TP_DepartamentoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TP_Departamento  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TP_Departamento> GetByFilter(TP_Departamento pTP_Departamento, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTP_Departamento.id== null || pTP_Departamento.id==0) ? vintNUll :pTP_Departamento.id);
                    p.Add("@nombre", pTP_Departamento.nombre);
                    p.Add("@codigo", pTP_Departamento.codigo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TP_Departamento> l = SqlMapper.Query<TP_Departamento>(con, "API.PA_TP_DepartamentoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TP_Departamento  ->" + ex.Message);
				}
			}

			public TP_Departamento Add(TP_Departamento pTP_Departamento)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTP_Departamento.id== null ? 0: pTP_Departamento.id);
                    p.Add("@nombre", pTP_Departamento.nombre);
                    p.Add("@codigo", pTP_Departamento.codigo);
                    p.Add("@auditoria", pTP_Departamento.auditoria);

                         


                    TP_Departamento o = SqlMapper.QueryFirstOrDefault<TP_Departamento>(con, "API.PA_TP_DepartamentoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TP_Departamento  ->" + ex.Message);
				}
			}

			public TP_Departamento  Update(TP_Departamento pTP_Departamento)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTP_Departamento.id== null ? 0: pTP_Departamento.id);
                    p.Add("@nombre", pTP_Departamento.nombre);
                    p.Add("@codigo", pTP_Departamento.codigo);
                    p.Add("@auditoria", pTP_Departamento.auditoria);

                         


                    TP_Departamento o = SqlMapper.QueryFirstOrDefault<TP_Departamento>(con, "API.PA_TP_DepartamentoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TP_Departamento  ->" + ex.Message);
				}
			}

			public bool Delete(TP_Departamento pTP_Departamento)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTP_Departamento.id);
                    p.Add("@auditoria", pTP_Departamento.auditoria);

                

 

					TP_Departamento o = SqlMapper.QueryFirstOrDefault<TP_Departamento>(con, "API.PA_TP_DepartamentoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TP_Departamento  ->" + ex.Message);
				}
			}

		



            public List<TP_Departamento> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TP_Departamento> TP_DepartamentoList = new List<TP_Departamento>();

                    TP_DepartamentoList = SqlMapper.Query<TP_Departamento>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TP_DepartamentoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TP_Departamento  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TP_Departamento> b)
            {
                DapperPlusManager.Entity<TP_Departamento>().Table("TP_Departamento");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}