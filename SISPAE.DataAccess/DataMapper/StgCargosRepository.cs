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
     /// Clase Abstracta para  StgCargos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgCargosRepository : DataObject , IStgCargos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgCargosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgCargosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgCargos GetById(StgCargos pStgCargos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgCargos.id);                                    


    				StgCargos o = SqlMapper.QueryFirstOrDefault<StgCargos>(con, "API.PA_StgCargosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgCargos  ->" + ex.Message);
				}
			}

			public List<StgCargos> GetAll()
			{
				try 
                {
                        List<StgCargos> l = SqlMapper.Query<StgCargos>(con, "API.PA_StgCargosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgCargos  ->" + ex.Message);
				}
			}

			public List<StgCargos> GetAllFull()
			{
				try 
				{
                    List<StgCargos> l = SqlMapper.Query<StgCargos>(con, "API.PA_StgCargosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgCargos  ->" + ex.Message);
				}
			}
			
			public List<StgCargos> GetAllByWithRelation()
			{
				try 
                {
                    List<StgCargos> l = SqlMapper.Query<StgCargos>(con, "API.PA_StgCargosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgCargos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgCargos> GetByFilter(StgCargos pStgCargos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgCargos.id== null || pStgCargos.id==0) ? vintNUll :pStgCargos.id);
                    p.Add("@IdCargo",(pStgCargos.IdCargo== null || pStgCargos.IdCargo==0) ? vintNUll :pStgCargos.IdCargo);
                    p.Add("@Nombre",(pStgCargos.Nombre== null) ? vintNUll :pStgCargos.Nombre);
                    p.Add("@FechaCreacion",(pStgCargos.FechaCreacion== null) ? vintNUll :pStgCargos.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgCargos> l = SqlMapper.Query<StgCargos>(con, "API.PA_StgCargosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgCargos  ->" + ex.Message);
				}
			}

			public StgCargos Add(StgCargos pStgCargos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgCargos.id==null ? 0 : pStgCargos.id);
p.Add("@IdCargo",pStgCargos.IdCargo==null ? 0 : pStgCargos.IdCargo);
                    p.Add("@Nombre", pStgCargos.Nombre);
                    p.Add("@FechaCreacion", pStgCargos.FechaCreacion);
                    p.Add("@auditoria", pStgCargos.auditoria);

                         


                    StgCargos o = SqlMapper.QueryFirstOrDefault<StgCargos>(con, "API.PA_StgCargosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgCargos  ->" + ex.Message);
				}
			}

			public StgCargos  Update(StgCargos pStgCargos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgCargos.id==null ? 0 : pStgCargos.id);
p.Add("@IdCargo",pStgCargos.IdCargo==null ? 0 : pStgCargos.IdCargo);
                    p.Add("@Nombre", pStgCargos.Nombre);
                    p.Add("@FechaCreacion", pStgCargos.FechaCreacion);
                    p.Add("@auditoria", pStgCargos.auditoria);

                         


                    StgCargos o = SqlMapper.QueryFirstOrDefault<StgCargos>(con, "API.PA_StgCargosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgCargos  ->" + ex.Message);
				}
			}

			public bool Delete(StgCargos pStgCargos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgCargos.id);
                    p.Add("@auditoria", pStgCargos.auditoria);

                

 

					StgCargos o = SqlMapper.QueryFirstOrDefault<StgCargos>(con, "API.PA_StgCargosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgCargos  ->" + ex.Message);
				}
			}

		



            public List<StgCargos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgCargos> StgCargosList = new List<StgCargos>();

                    StgCargosList = SqlMapper.Query<StgCargos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgCargosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgCargos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgCargos> b)
            {
                DapperPlusManager.Entity<StgCargos>().Table("StgCargos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}