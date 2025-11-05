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
     /// Clase Abstracta para  RegistroINVIMA
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class RegistroINVIMARepository : DataObject , IRegistroINVIMA 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public RegistroINVIMARepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public RegistroINVIMARepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public RegistroINVIMA GetById(RegistroINVIMA pRegistroINVIMA)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pRegistroINVIMA.id);                                    


    				RegistroINVIMA o = SqlMapper.QueryFirstOrDefault<RegistroINVIMA>(con, "API.PA_RegistroINVIMAGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  RegistroINVIMA  ->" + ex.Message);
				}
			}

			public List<RegistroINVIMA> GetAll()
			{
				try 
                {
                        List<RegistroINVIMA> l = SqlMapper.Query<RegistroINVIMA>(con, "API.PA_RegistroINVIMAGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  RegistroINVIMA  ->" + ex.Message);
				}
			}

			public List<RegistroINVIMA> GetAllFull()
			{
				try 
				{
                    List<RegistroINVIMA> l = SqlMapper.Query<RegistroINVIMA>(con, "API.PA_RegistroINVIMAGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  RegistroINVIMA  ->" + ex.Message);
				}
			}
			
			public List<RegistroINVIMA> GetAllByWithRelation()
			{
				try 
                {
                    List<RegistroINVIMA> l = SqlMapper.Query<RegistroINVIMA>(con, "API.PA_RegistroINVIMAGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  RegistroINVIMA  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<RegistroINVIMA> GetByFilter(RegistroINVIMA pRegistroINVIMA, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pRegistroINVIMA.id== null || pRegistroINVIMA.id==0) ? vintNUll :pRegistroINVIMA.id);
                    p.Add("@NumeroRegistro",(pRegistroINVIMA.NumeroRegistro== null) ? vintNUll :pRegistroINVIMA.NumeroRegistro);
                    p.Add("@ExpedienteSanitario",(pRegistroINVIMA.ExpedienteSanitario== null) ? vintNUll :pRegistroINVIMA.ExpedienteSanitario);
                    p.Add("@NitFabricante",(pRegistroINVIMA.NitFabricante== null) ? vintNUll :pRegistroINVIMA.NitFabricante);
                    p.Add("@FechaVencimiento",(pRegistroINVIMA.FechaVencimiento== null) ? vintNUll :pRegistroINVIMA.FechaVencimiento);
                    p.Add("@ID_EstadoRegistro",(pRegistroINVIMA.ID_EstadoRegistro== null || pRegistroINVIMA.ID_EstadoRegistro==0) ? vintNUll :pRegistroINVIMA.ID_EstadoRegistro);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<RegistroINVIMA> l = SqlMapper.Query<RegistroINVIMA>(con, "API.PA_RegistroINVIMAGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  RegistroINVIMA  ->" + ex.Message);
				}
			}

			public RegistroINVIMA Add(RegistroINVIMA pRegistroINVIMA)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pRegistroINVIMA.id==null ? 0 : pRegistroINVIMA.id);
                    p.Add("@NumeroRegistro", pRegistroINVIMA.NumeroRegistro);
                    p.Add("@ExpedienteSanitario", pRegistroINVIMA.ExpedienteSanitario);
                    p.Add("@NitFabricante", pRegistroINVIMA.NitFabricante);
                    p.Add("@FechaVencimiento", pRegistroINVIMA.FechaVencimiento);
p.Add("@ID_EstadoRegistro",pRegistroINVIMA.ID_EstadoRegistro==null ? 0 : pRegistroINVIMA.ID_EstadoRegistro);
                    p.Add("@auditoria", pRegistroINVIMA.auditoria);

                         


                    RegistroINVIMA o = SqlMapper.QueryFirstOrDefault<RegistroINVIMA>(con, "API.PA_RegistroINVIMAAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  RegistroINVIMA  ->" + ex.Message);
				}
			}

			public RegistroINVIMA  Update(RegistroINVIMA pRegistroINVIMA)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pRegistroINVIMA.id==null ? 0 : pRegistroINVIMA.id);
                    p.Add("@NumeroRegistro", pRegistroINVIMA.NumeroRegistro);
                    p.Add("@ExpedienteSanitario", pRegistroINVIMA.ExpedienteSanitario);
                    p.Add("@NitFabricante", pRegistroINVIMA.NitFabricante);
                    p.Add("@FechaVencimiento", pRegistroINVIMA.FechaVencimiento);
p.Add("@ID_EstadoRegistro",pRegistroINVIMA.ID_EstadoRegistro==null ? 0 : pRegistroINVIMA.ID_EstadoRegistro);
                    p.Add("@auditoria", pRegistroINVIMA.auditoria);

                         


                    RegistroINVIMA o = SqlMapper.QueryFirstOrDefault<RegistroINVIMA>(con, "API.PA_RegistroINVIMAUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  RegistroINVIMA  ->" + ex.Message);
				}
			}

			public bool Delete(RegistroINVIMA pRegistroINVIMA)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pRegistroINVIMA.id);
                    p.Add("@auditoria", pRegistroINVIMA.auditoria);

                

 

					RegistroINVIMA o = SqlMapper.QueryFirstOrDefault<RegistroINVIMA>(con, "API.PA_RegistroINVIMADelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) RegistroINVIMA  ->" + ex.Message);
				}
			}

		



            public List<RegistroINVIMA> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<RegistroINVIMA> RegistroINVIMAList = new List<RegistroINVIMA>();

                    RegistroINVIMAList = SqlMapper.Query<RegistroINVIMA>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return RegistroINVIMAList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) RegistroINVIMA  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<RegistroINVIMA> b)
            {
                DapperPlusManager.Entity<RegistroINVIMA>().Table("RegistroINVIMA");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}