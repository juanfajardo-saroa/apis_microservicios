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
     /// Clase Abstracta para  AgrupacionesMensual
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AgrupacionesMensualRepository : DataObject , IAgrupacionesMensual 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AgrupacionesMensualRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AgrupacionesMensualRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AgrupacionesMensual GetById(AgrupacionesMensual pAgrupacionesMensual)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAgrupacionesMensual.id);                                    


    				AgrupacionesMensual o = SqlMapper.QueryFirstOrDefault<AgrupacionesMensual>(con, "API.PA_AgrupacionesMensualGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AgrupacionesMensual  ->" + ex.Message);
				}
			}

			public List<AgrupacionesMensual> GetAll()
			{
				try 
                {
                        List<AgrupacionesMensual> l = SqlMapper.Query<AgrupacionesMensual>(con, "API.PA_AgrupacionesMensualGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AgrupacionesMensual  ->" + ex.Message);
				}
			}

			public List<AgrupacionesMensual> GetAllFull()
			{
				try 
				{
                    List<AgrupacionesMensual> l = SqlMapper.Query<AgrupacionesMensual>(con, "API.PA_AgrupacionesMensualGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AgrupacionesMensual  ->" + ex.Message);
				}
			}
			
			public List<AgrupacionesMensual> GetAllByWithRelation()
			{
				try 
                {
                    List<AgrupacionesMensual> l = SqlMapper.Query<AgrupacionesMensual>(con, "API.PA_AgrupacionesMensualGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AgrupacionesMensual  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AgrupacionesMensual> GetByFilter(AgrupacionesMensual pAgrupacionesMensual, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAgrupacionesMensual.id== null || pAgrupacionesMensual.id==0) ? vintNUll :pAgrupacionesMensual.id);
                    p.Add("@ID_TipoEstadoValidacionEntrega",(pAgrupacionesMensual.ID_TipoEstadoValidacionEntrega== null || pAgrupacionesMensual.ID_TipoEstadoValidacionEntrega==0) ? vintNUll :pAgrupacionesMensual.ID_TipoEstadoValidacionEntrega);
                    p.Add("@ID_Rector",(pAgrupacionesMensual.ID_Rector== null || pAgrupacionesMensual.ID_Rector==0) ? vintNUll :pAgrupacionesMensual.ID_Rector);
                    p.Add("@ID_SedeJornada",(pAgrupacionesMensual.ID_SedeJornada== null || pAgrupacionesMensual.ID_SedeJornada==0) ? vintNUll :pAgrupacionesMensual.ID_SedeJornada);
                    p.Add("@ID_Operador",(pAgrupacionesMensual.ID_Operador== null || pAgrupacionesMensual.ID_Operador==0) ? vintNUll :pAgrupacionesMensual.ID_Operador);
                    p.Add("@ID_Contrato",(pAgrupacionesMensual.ID_Contrato== null || pAgrupacionesMensual.ID_Contrato==0) ? vintNUll :pAgrupacionesMensual.ID_Contrato);
                    p.Add("@Mes",(pAgrupacionesMensual.Mes== null) ? vintNUll :pAgrupacionesMensual.Mes);
                    p.Add("@SoporteEntrega",(pAgrupacionesMensual.SoporteEntrega== null) ? vintNUll :pAgrupacionesMensual.SoporteEntrega);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AgrupacionesMensual> l = SqlMapper.Query<AgrupacionesMensual>(con, "API.PA_AgrupacionesMensualGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AgrupacionesMensual  ->" + ex.Message);
				}
			}

			public AgrupacionesMensual Add(AgrupacionesMensual pAgrupacionesMensual)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAgrupacionesMensual.id==null ? 0 : pAgrupacionesMensual.id);
p.Add("@ID_TipoEstadoValidacionEntrega",pAgrupacionesMensual.ID_TipoEstadoValidacionEntrega==null ? 0 : pAgrupacionesMensual.ID_TipoEstadoValidacionEntrega);
p.Add("@ID_Rector",pAgrupacionesMensual.ID_Rector==null ? 0 : pAgrupacionesMensual.ID_Rector);
p.Add("@ID_SedeJornada",pAgrupacionesMensual.ID_SedeJornada==null ? 0 : pAgrupacionesMensual.ID_SedeJornada);
p.Add("@ID_Operador",pAgrupacionesMensual.ID_Operador==null ? 0 : pAgrupacionesMensual.ID_Operador);
p.Add("@ID_Contrato",pAgrupacionesMensual.ID_Contrato==null ? 0 : pAgrupacionesMensual.ID_Contrato);
                    p.Add("@Mes", pAgrupacionesMensual.Mes);
                    p.Add("@SoporteEntrega", pAgrupacionesMensual.SoporteEntrega);
                    p.Add("@auditoria", pAgrupacionesMensual.auditoria);

                         


                    AgrupacionesMensual o = SqlMapper.QueryFirstOrDefault<AgrupacionesMensual>(con, "API.PA_AgrupacionesMensualAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AgrupacionesMensual  ->" + ex.Message);
				}
			}

			public AgrupacionesMensual  Update(AgrupacionesMensual pAgrupacionesMensual)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAgrupacionesMensual.id==null ? 0 : pAgrupacionesMensual.id);
p.Add("@ID_TipoEstadoValidacionEntrega",pAgrupacionesMensual.ID_TipoEstadoValidacionEntrega==null ? 0 : pAgrupacionesMensual.ID_TipoEstadoValidacionEntrega);
p.Add("@ID_Rector",pAgrupacionesMensual.ID_Rector==null ? 0 : pAgrupacionesMensual.ID_Rector);
p.Add("@ID_SedeJornada",pAgrupacionesMensual.ID_SedeJornada==null ? 0 : pAgrupacionesMensual.ID_SedeJornada);
p.Add("@ID_Operador",pAgrupacionesMensual.ID_Operador==null ? 0 : pAgrupacionesMensual.ID_Operador);
p.Add("@ID_Contrato",pAgrupacionesMensual.ID_Contrato==null ? 0 : pAgrupacionesMensual.ID_Contrato);
                    p.Add("@Mes", pAgrupacionesMensual.Mes);
                    p.Add("@SoporteEntrega", pAgrupacionesMensual.SoporteEntrega);
                    p.Add("@auditoria", pAgrupacionesMensual.auditoria);

                         


                    AgrupacionesMensual o = SqlMapper.QueryFirstOrDefault<AgrupacionesMensual>(con, "API.PA_AgrupacionesMensualUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AgrupacionesMensual  ->" + ex.Message);
				}
			}

			public bool Delete(AgrupacionesMensual pAgrupacionesMensual)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAgrupacionesMensual.id);
                    p.Add("@auditoria", pAgrupacionesMensual.auditoria);

                

 

					AgrupacionesMensual o = SqlMapper.QueryFirstOrDefault<AgrupacionesMensual>(con, "API.PA_AgrupacionesMensualDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AgrupacionesMensual  ->" + ex.Message);
				}
			}

		



            public List<AgrupacionesMensual> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AgrupacionesMensual> AgrupacionesMensualList = new List<AgrupacionesMensual>();

                    AgrupacionesMensualList = SqlMapper.Query<AgrupacionesMensual>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AgrupacionesMensualList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AgrupacionesMensual  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AgrupacionesMensual> b)
            {
                DapperPlusManager.Entity<AgrupacionesMensual>().Table("AgrupacionesMensual");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}