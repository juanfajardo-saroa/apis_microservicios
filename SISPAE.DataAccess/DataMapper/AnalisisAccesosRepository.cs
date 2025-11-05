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
     /// Clase Abstracta para  AnalisisAccesos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AnalisisAccesosRepository : DataObject , IAnalisisAccesos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AnalisisAccesosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AnalisisAccesosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AnalisisAccesos GetById(AnalisisAccesos pAnalisisAccesos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAnalisisAccesos.id);                                    


    				AnalisisAccesos o = SqlMapper.QueryFirstOrDefault<AnalisisAccesos>(con, "API.PA_AnalisisAccesosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AnalisisAccesos  ->" + ex.Message);
				}
			}

			public List<AnalisisAccesos> GetAll()
			{
				try 
                {
                        List<AnalisisAccesos> l = SqlMapper.Query<AnalisisAccesos>(con, "API.PA_AnalisisAccesosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AnalisisAccesos  ->" + ex.Message);
				}
			}

			public List<AnalisisAccesos> GetAllFull()
			{
				try 
				{
                    List<AnalisisAccesos> l = SqlMapper.Query<AnalisisAccesos>(con, "API.PA_AnalisisAccesosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AnalisisAccesos  ->" + ex.Message);
				}
			}
			
			public List<AnalisisAccesos> GetAllByWithRelation()
			{
				try 
                {
                    List<AnalisisAccesos> l = SqlMapper.Query<AnalisisAccesos>(con, "API.PA_AnalisisAccesosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AnalisisAccesos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AnalisisAccesos> GetByFilter(AnalisisAccesos pAnalisisAccesos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAnalisisAccesos.id== null || pAnalisisAccesos.id==0) ? vintNUll :pAnalisisAccesos.id);
                    p.Add("@ID_CaracteristicasSede",(pAnalisisAccesos.ID_CaracteristicasSede== null || pAnalisisAccesos.ID_CaracteristicasSede==0) ? vintNUll :pAnalisisAccesos.ID_CaracteristicasSede);
                    p.Add("@ID_TipoAcceso",(pAnalisisAccesos.ID_TipoAcceso== null || pAnalisisAccesos.ID_TipoAcceso==0) ? vintNUll :pAnalisisAccesos.ID_TipoAcceso);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AnalisisAccesos> l = SqlMapper.Query<AnalisisAccesos>(con, "API.PA_AnalisisAccesosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AnalisisAccesos  ->" + ex.Message);
				}
			}

			public AnalisisAccesos Add(AnalisisAccesos pAnalisisAccesos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAnalisisAccesos.id==null ? 0 : pAnalisisAccesos.id);
p.Add("@ID_CaracteristicasSede",pAnalisisAccesos.ID_CaracteristicasSede==null ? 0 : pAnalisisAccesos.ID_CaracteristicasSede);
p.Add("@ID_TipoAcceso",pAnalisisAccesos.ID_TipoAcceso==null ? 0 : pAnalisisAccesos.ID_TipoAcceso);
                    p.Add("@auditoria", pAnalisisAccesos.auditoria);

                         


                    AnalisisAccesos o = SqlMapper.QueryFirstOrDefault<AnalisisAccesos>(con, "API.PA_AnalisisAccesosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AnalisisAccesos  ->" + ex.Message);
				}
			}

			public AnalisisAccesos  Update(AnalisisAccesos pAnalisisAccesos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAnalisisAccesos.id==null ? 0 : pAnalisisAccesos.id);
p.Add("@ID_CaracteristicasSede",pAnalisisAccesos.ID_CaracteristicasSede==null ? 0 : pAnalisisAccesos.ID_CaracteristicasSede);
p.Add("@ID_TipoAcceso",pAnalisisAccesos.ID_TipoAcceso==null ? 0 : pAnalisisAccesos.ID_TipoAcceso);
                    p.Add("@auditoria", pAnalisisAccesos.auditoria);

                         


                    AnalisisAccesos o = SqlMapper.QueryFirstOrDefault<AnalisisAccesos>(con, "API.PA_AnalisisAccesosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AnalisisAccesos  ->" + ex.Message);
				}
			}

			public bool Delete(AnalisisAccesos pAnalisisAccesos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAnalisisAccesos.id);
                    p.Add("@auditoria", pAnalisisAccesos.auditoria);

                

 

					AnalisisAccesos o = SqlMapper.QueryFirstOrDefault<AnalisisAccesos>(con, "API.PA_AnalisisAccesosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AnalisisAccesos  ->" + ex.Message);
				}
			}

		



            public List<AnalisisAccesos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AnalisisAccesos> AnalisisAccesosList = new List<AnalisisAccesos>();

                    AnalisisAccesosList = SqlMapper.Query<AnalisisAccesos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AnalisisAccesosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AnalisisAccesos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AnalisisAccesos> b)
            {
                DapperPlusManager.Entity<AnalisisAccesos>().Table("AnalisisAccesos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}