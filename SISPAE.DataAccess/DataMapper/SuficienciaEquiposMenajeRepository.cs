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
     /// Clase Abstracta para  SuficienciaEquiposMenaje
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SuficienciaEquiposMenajeRepository : DataObject , ISuficienciaEquiposMenaje 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SuficienciaEquiposMenajeRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SuficienciaEquiposMenajeRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public SuficienciaEquiposMenaje GetById(SuficienciaEquiposMenaje pSuficienciaEquiposMenaje)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSuficienciaEquiposMenaje.id);                                    


    				SuficienciaEquiposMenaje o = SqlMapper.QueryFirstOrDefault<SuficienciaEquiposMenaje>(con, "API.PA_SuficienciaEquiposMenajeGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  SuficienciaEquiposMenaje  ->" + ex.Message);
				}
			}

			public List<SuficienciaEquiposMenaje> GetAll()
			{
				try 
                {
                        List<SuficienciaEquiposMenaje> l = SqlMapper.Query<SuficienciaEquiposMenaje>(con, "API.PA_SuficienciaEquiposMenajeGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  SuficienciaEquiposMenaje  ->" + ex.Message);
				}
			}

			public List<SuficienciaEquiposMenaje> GetAllFull()
			{
				try 
				{
                    List<SuficienciaEquiposMenaje> l = SqlMapper.Query<SuficienciaEquiposMenaje>(con, "API.PA_SuficienciaEquiposMenajeGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  SuficienciaEquiposMenaje  ->" + ex.Message);
				}
			}
			
			public List<SuficienciaEquiposMenaje> GetAllByWithRelation()
			{
				try 
                {
                    List<SuficienciaEquiposMenaje> l = SqlMapper.Query<SuficienciaEquiposMenaje>(con, "API.PA_SuficienciaEquiposMenajeGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  SuficienciaEquiposMenaje  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<SuficienciaEquiposMenaje> GetByFilter(SuficienciaEquiposMenaje pSuficienciaEquiposMenaje, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSuficienciaEquiposMenaje.id== null || pSuficienciaEquiposMenaje.id==0) ? vintNUll :pSuficienciaEquiposMenaje.id);
                    p.Add("@elemento",(pSuficienciaEquiposMenaje.elemento== null) ? vintNUll :pSuficienciaEquiposMenaje.elemento);
                    p.Add("@id_caracteristica",(pSuficienciaEquiposMenaje.id_caracteristica== null) ? vintNUll :pSuficienciaEquiposMenaje.id_caracteristica);
                    p.Add("@CantidadInicial",(pSuficienciaEquiposMenaje.CantidadInicial== null) ? vintNUll :pSuficienciaEquiposMenaje.CantidadInicial);
                    p.Add("@CantidadFinal",(pSuficienciaEquiposMenaje.CantidadFinal== null) ? vintNUll :pSuficienciaEquiposMenaje.CantidadFinal);
                    p.Add("@ComplementoInicalInsuficiente",(pSuficienciaEquiposMenaje.ComplementoInicalInsuficiente== null) ? vintNUll :pSuficienciaEquiposMenaje.ComplementoInicalInsuficiente);
                    p.Add("@ComplementoIncialAceptable",(pSuficienciaEquiposMenaje.ComplementoIncialAceptable== null) ? vintNUll :pSuficienciaEquiposMenaje.ComplementoIncialAceptable);
                    p.Add("@ComplementoFinalAceptable",(pSuficienciaEquiposMenaje.ComplementoFinalAceptable== null) ? vintNUll :pSuficienciaEquiposMenaje.ComplementoFinalAceptable);
                    p.Add("@ComplementoInicialSuficiente",(pSuficienciaEquiposMenaje.ComplementoInicialSuficiente== null) ? vintNUll :pSuficienciaEquiposMenaje.ComplementoInicialSuficiente);
                    p.Add("@ComplementoFinalSuficiente",(pSuficienciaEquiposMenaje.ComplementoFinalSuficiente== null) ? vintNUll :pSuficienciaEquiposMenaje.ComplementoFinalSuficiente);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<SuficienciaEquiposMenaje> l = SqlMapper.Query<SuficienciaEquiposMenaje>(con, "API.PA_SuficienciaEquiposMenajeGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  SuficienciaEquiposMenaje  ->" + ex.Message);
				}
			}

			public SuficienciaEquiposMenaje Add(SuficienciaEquiposMenaje pSuficienciaEquiposMenaje)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSuficienciaEquiposMenaje.id==null ? 0 : pSuficienciaEquiposMenaje.id);
                    p.Add("@elemento", pSuficienciaEquiposMenaje.elemento);
p.Add("@id_caracteristica",pSuficienciaEquiposMenaje.id_caracteristica== null ? 0: pSuficienciaEquiposMenaje.id_caracteristica);
                    p.Add("@CantidadInicial", pSuficienciaEquiposMenaje.CantidadInicial);
                    p.Add("@CantidadFinal", pSuficienciaEquiposMenaje.CantidadFinal);
                    p.Add("@ComplementoInicalInsuficiente", pSuficienciaEquiposMenaje.ComplementoInicalInsuficiente);
                    p.Add("@ComplementoIncialAceptable", pSuficienciaEquiposMenaje.ComplementoIncialAceptable);
                    p.Add("@ComplementoFinalAceptable", pSuficienciaEquiposMenaje.ComplementoFinalAceptable);
                    p.Add("@ComplementoInicialSuficiente", pSuficienciaEquiposMenaje.ComplementoInicialSuficiente);
                    p.Add("@ComplementoFinalSuficiente", pSuficienciaEquiposMenaje.ComplementoFinalSuficiente);
                    p.Add("@auditoria", pSuficienciaEquiposMenaje.Auditoria);

                         


                    SuficienciaEquiposMenaje o = SqlMapper.QueryFirstOrDefault<SuficienciaEquiposMenaje>(con, "API.PA_SuficienciaEquiposMenajeAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  SuficienciaEquiposMenaje  ->" + ex.Message);
				}
			}

			public SuficienciaEquiposMenaje  Update(SuficienciaEquiposMenaje pSuficienciaEquiposMenaje)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSuficienciaEquiposMenaje.id==null ? 0 : pSuficienciaEquiposMenaje.id);
                    p.Add("@elemento", pSuficienciaEquiposMenaje.elemento);
p.Add("@id_caracteristica",pSuficienciaEquiposMenaje.id_caracteristica== null ? 0: pSuficienciaEquiposMenaje.id_caracteristica);
                    p.Add("@CantidadInicial", pSuficienciaEquiposMenaje.CantidadInicial);
                    p.Add("@CantidadFinal", pSuficienciaEquiposMenaje.CantidadFinal);
                    p.Add("@ComplementoInicalInsuficiente", pSuficienciaEquiposMenaje.ComplementoInicalInsuficiente);
                    p.Add("@ComplementoIncialAceptable", pSuficienciaEquiposMenaje.ComplementoIncialAceptable);
                    p.Add("@ComplementoFinalAceptable", pSuficienciaEquiposMenaje.ComplementoFinalAceptable);
                    p.Add("@ComplementoInicialSuficiente", pSuficienciaEquiposMenaje.ComplementoInicialSuficiente);
                    p.Add("@ComplementoFinalSuficiente", pSuficienciaEquiposMenaje.ComplementoFinalSuficiente);
                    p.Add("@auditoria", pSuficienciaEquiposMenaje.Auditoria);

                         


                    SuficienciaEquiposMenaje o = SqlMapper.QueryFirstOrDefault<SuficienciaEquiposMenaje>(con, "API.PA_SuficienciaEquiposMenajeUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  SuficienciaEquiposMenaje  ->" + ex.Message);
				}
			}

			public bool Delete(SuficienciaEquiposMenaje pSuficienciaEquiposMenaje)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSuficienciaEquiposMenaje.id);
                    p.Add("@auditoria", pSuficienciaEquiposMenaje.Auditoria);

                

 

					SuficienciaEquiposMenaje o = SqlMapper.QueryFirstOrDefault<SuficienciaEquiposMenaje>(con, "API.PA_SuficienciaEquiposMenajeDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) SuficienciaEquiposMenaje  ->" + ex.Message);
				}
			}

		



            public List<SuficienciaEquiposMenaje> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<SuficienciaEquiposMenaje> SuficienciaEquiposMenajeList = new List<SuficienciaEquiposMenaje>();

                    SuficienciaEquiposMenajeList = SqlMapper.Query<SuficienciaEquiposMenaje>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SuficienciaEquiposMenajeList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) SuficienciaEquiposMenaje  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<SuficienciaEquiposMenaje> b)
            {
                DapperPlusManager.Entity<SuficienciaEquiposMenaje>().Table("SuficienciaEquiposMenaje");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}