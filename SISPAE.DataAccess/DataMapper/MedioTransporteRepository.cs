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
     /// Clase Abstracta para  MedioTransporte
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MedioTransporteRepository : DataObject , IMedioTransporte 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MedioTransporteRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MedioTransporteRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MedioTransporte GetById(MedioTransporte pMedioTransporte)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@MedioTransporteId",pMedioTransporte.MedioTransporteId);                                    


    				MedioTransporte o = SqlMapper.QueryFirstOrDefault<MedioTransporte>(con, "API.PA_MedioTransporteGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MedioTransporte  ->" + ex.Message);
				}
			}

			public List<MedioTransporte> GetAll()
			{
				try 
                {
                        List<MedioTransporte> l = SqlMapper.Query<MedioTransporte>(con, "API.PA_MedioTransporteGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MedioTransporte  ->" + ex.Message);
				}
			}

			public List<MedioTransporte> GetAllFull()
			{
				try 
				{
                    List<MedioTransporte> l = SqlMapper.Query<MedioTransporte>(con, "API.PA_MedioTransporteGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MedioTransporte  ->" + ex.Message);
				}
			}
			
			public List<MedioTransporte> GetAllByWithRelation()
			{
				try 
                {
                    List<MedioTransporte> l = SqlMapper.Query<MedioTransporte>(con, "API.PA_MedioTransporteGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MedioTransporte  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MedioTransporte> GetByFilter(MedioTransporte pMedioTransporte, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@MedioTransporteId",(pMedioTransporte.MedioTransporteId== null) ? vintNUll :pMedioTransporte.MedioTransporteId);
                    p.Add("@Nombre",(pMedioTransporte.Nombre== null) ? vintNUll :pMedioTransporte.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MedioTransporte> l = SqlMapper.Query<MedioTransporte>(con, "API.PA_MedioTransporteGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MedioTransporte  ->" + ex.Message);
				}
			}

			public MedioTransporte Add(MedioTransporte pMedioTransporte)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@MedioTransporteId",pMedioTransporte.MedioTransporteId==null ? 0 : pMedioTransporte.MedioTransporteId);
                    p.Add("@Nombre", pMedioTransporte.Nombre);
                    p.Add("@auditoria", pMedioTransporte.auditoria);

                         


                    MedioTransporte o = SqlMapper.QueryFirstOrDefault<MedioTransporte>(con, "API.PA_MedioTransporteAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MedioTransporte  ->" + ex.Message);
				}
			}

			public MedioTransporte  Update(MedioTransporte pMedioTransporte)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@MedioTransporteId",pMedioTransporte.MedioTransporteId==null ? 0 : pMedioTransporte.MedioTransporteId);
                    p.Add("@Nombre", pMedioTransporte.Nombre);
                    p.Add("@auditoria", pMedioTransporte.auditoria);

                         


                    MedioTransporte o = SqlMapper.QueryFirstOrDefault<MedioTransporte>(con, "API.PA_MedioTransporteUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MedioTransporte  ->" + ex.Message);
				}
			}

			public bool Delete(MedioTransporte pMedioTransporte)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@MedioTransporteId",pMedioTransporte.MedioTransporteId);
                    p.Add("@auditoria", pMedioTransporte.auditoria);

                

 

					MedioTransporte o = SqlMapper.QueryFirstOrDefault<MedioTransporte>(con, "API.PA_MedioTransporteDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MedioTransporte  ->" + ex.Message);
				}
			}

		



            public List<MedioTransporte> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MedioTransporte> MedioTransporteList = new List<MedioTransporte>();

                    MedioTransporteList = SqlMapper.Query<MedioTransporte>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MedioTransporteList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MedioTransporte  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MedioTransporte> b)
            {
                DapperPlusManager.Entity<MedioTransporte>().Table("MedioTransporte");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}