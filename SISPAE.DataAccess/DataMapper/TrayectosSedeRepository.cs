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
     /// Clase Abstracta para  TrayectosSede
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TrayectosSedeRepository : DataObject , ITrayectosSede 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TrayectosSedeRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TrayectosSedeRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TrayectosSede GetById(TrayectosSede pTrayectosSede)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTrayectosSede.id);                                    


    				TrayectosSede o = SqlMapper.QueryFirstOrDefault<TrayectosSede>(con, "API.PA_TrayectosSedeGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TrayectosSede  ->" + ex.Message);
				}
			}

			public List<TrayectosSede> GetAll()
			{
				try 
                {
                        List<TrayectosSede> l = SqlMapper.Query<TrayectosSede>(con, "API.PA_TrayectosSedeGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TrayectosSede  ->" + ex.Message);
				}
			}

			public List<TrayectosSede> GetAllFull()
			{
				try 
				{
                    List<TrayectosSede> l = SqlMapper.Query<TrayectosSede>(con, "API.PA_TrayectosSedeGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TrayectosSede  ->" + ex.Message);
				}
			}
			
			public List<TrayectosSede> GetAllByWithRelation()
			{
				try 
                {
                    List<TrayectosSede> l = SqlMapper.Query<TrayectosSede>(con, "API.PA_TrayectosSedeGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TrayectosSede  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TrayectosSede> GetByFilter(TrayectosSede pTrayectosSede, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTrayectosSede.id== null || pTrayectosSede.id==0) ? vintNUll :pTrayectosSede.id);
                    p.Add("@ID_Trayecto",(pTrayectosSede.ID_Trayecto== null || pTrayectosSede.ID_Trayecto==0) ? vintNUll :pTrayectosSede.ID_Trayecto);
                    p.Add("@ID_AnalisisAcceso",(pTrayectosSede.ID_AnalisisAcceso== null || pTrayectosSede.ID_AnalisisAcceso==0) ? vintNUll :pTrayectosSede.ID_AnalisisAcceso);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TrayectosSede> l = SqlMapper.Query<TrayectosSede>(con, "API.PA_TrayectosSedeGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TrayectosSede  ->" + ex.Message);
				}
			}

			public TrayectosSede Add(TrayectosSede pTrayectosSede)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTrayectosSede.id==null ? 0 : pTrayectosSede.id);
p.Add("@ID_Trayecto",pTrayectosSede.ID_Trayecto==null ? 0 : pTrayectosSede.ID_Trayecto);
p.Add("@ID_AnalisisAcceso",pTrayectosSede.ID_AnalisisAcceso==null ? 0 : pTrayectosSede.ID_AnalisisAcceso);
                    p.Add("@auditoria", pTrayectosSede.auditoria);

                         


                    TrayectosSede o = SqlMapper.QueryFirstOrDefault<TrayectosSede>(con, "API.PA_TrayectosSedeAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TrayectosSede  ->" + ex.Message);
				}
			}

			public TrayectosSede  Update(TrayectosSede pTrayectosSede)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTrayectosSede.id==null ? 0 : pTrayectosSede.id);
p.Add("@ID_Trayecto",pTrayectosSede.ID_Trayecto==null ? 0 : pTrayectosSede.ID_Trayecto);
p.Add("@ID_AnalisisAcceso",pTrayectosSede.ID_AnalisisAcceso==null ? 0 : pTrayectosSede.ID_AnalisisAcceso);
                    p.Add("@auditoria", pTrayectosSede.auditoria);

                         


                    TrayectosSede o = SqlMapper.QueryFirstOrDefault<TrayectosSede>(con, "API.PA_TrayectosSedeUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TrayectosSede  ->" + ex.Message);
				}
			}

			public bool Delete(TrayectosSede pTrayectosSede)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTrayectosSede.id);
                    p.Add("@auditoria", pTrayectosSede.auditoria);

                

 

					TrayectosSede o = SqlMapper.QueryFirstOrDefault<TrayectosSede>(con, "API.PA_TrayectosSedeDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TrayectosSede  ->" + ex.Message);
				}
			}

		



            public List<TrayectosSede> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TrayectosSede> TrayectosSedeList = new List<TrayectosSede>();

                    TrayectosSedeList = SqlMapper.Query<TrayectosSede>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TrayectosSedeList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TrayectosSede  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TrayectosSede> b)
            {
                DapperPlusManager.Entity<TrayectosSede>().Table("TrayectosSede");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}