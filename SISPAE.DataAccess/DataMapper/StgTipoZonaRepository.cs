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
     /// Clase Abstracta para  StgTipoZona
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgTipoZonaRepository : DataObject , IStgTipoZona 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgTipoZonaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgTipoZonaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgTipoZona GetById(StgTipoZona pStgTipoZona)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgTipoZona.id);                                    


    				StgTipoZona o = SqlMapper.QueryFirstOrDefault<StgTipoZona>(con, "API.PA_StgTipoZonaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgTipoZona  ->" + ex.Message);
				}
			}

			public List<StgTipoZona> GetAll()
			{
				try 
                {
                        List<StgTipoZona> l = SqlMapper.Query<StgTipoZona>(con, "API.PA_StgTipoZonaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgTipoZona  ->" + ex.Message);
				}
			}

			public List<StgTipoZona> GetAllFull()
			{
				try 
				{
                    List<StgTipoZona> l = SqlMapper.Query<StgTipoZona>(con, "API.PA_StgTipoZonaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgTipoZona  ->" + ex.Message);
				}
			}
			
			public List<StgTipoZona> GetAllByWithRelation()
			{
				try 
                {
                    List<StgTipoZona> l = SqlMapper.Query<StgTipoZona>(con, "API.PA_StgTipoZonaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgTipoZona  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgTipoZona> GetByFilter(StgTipoZona pStgTipoZona, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgTipoZona.id== null || pStgTipoZona.id==0) ? vintNUll :pStgTipoZona.id);
                    p.Add("@IdTipoZona",(pStgTipoZona.IdTipoZona== null) ? vintNUll :pStgTipoZona.IdTipoZona);
                    p.Add("@Nombre",(pStgTipoZona.Nombre== null) ? vintNUll :pStgTipoZona.Nombre);
                    p.Add("@FechaCreacion",(pStgTipoZona.FechaCreacion== null) ? vintNUll :pStgTipoZona.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgTipoZona> l = SqlMapper.Query<StgTipoZona>(con, "API.PA_StgTipoZonaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgTipoZona  ->" + ex.Message);
				}
			}

			public StgTipoZona Add(StgTipoZona pStgTipoZona)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgTipoZona.id==null ? 0 : pStgTipoZona.id);
                    p.Add("@IdTipoZona", pStgTipoZona.IdTipoZona);
                    p.Add("@Nombre", pStgTipoZona.Nombre);
                    p.Add("@FechaCreacion", pStgTipoZona.FechaCreacion);
                    p.Add("@auditoria", pStgTipoZona.auditoria);

                         


                    StgTipoZona o = SqlMapper.QueryFirstOrDefault<StgTipoZona>(con, "API.PA_StgTipoZonaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgTipoZona  ->" + ex.Message);
				}
			}

			public StgTipoZona  Update(StgTipoZona pStgTipoZona)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgTipoZona.id==null ? 0 : pStgTipoZona.id);
                    p.Add("@IdTipoZona", pStgTipoZona.IdTipoZona);
                    p.Add("@Nombre", pStgTipoZona.Nombre);
                    p.Add("@FechaCreacion", pStgTipoZona.FechaCreacion);
                    p.Add("@auditoria", pStgTipoZona.auditoria);

                         


                    StgTipoZona o = SqlMapper.QueryFirstOrDefault<StgTipoZona>(con, "API.PA_StgTipoZonaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgTipoZona  ->" + ex.Message);
				}
			}

			public bool Delete(StgTipoZona pStgTipoZona)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgTipoZona.id);
                    p.Add("@auditoria", pStgTipoZona.auditoria);

                

 

					StgTipoZona o = SqlMapper.QueryFirstOrDefault<StgTipoZona>(con, "API.PA_StgTipoZonaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgTipoZona  ->" + ex.Message);
				}
			}

		



            public List<StgTipoZona> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgTipoZona> StgTipoZonaList = new List<StgTipoZona>();

                    StgTipoZonaList = SqlMapper.Query<StgTipoZona>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgTipoZonaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgTipoZona  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgTipoZona> b)
            {
                DapperPlusManager.Entity<StgTipoZona>().Table("StgTipoZona");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}