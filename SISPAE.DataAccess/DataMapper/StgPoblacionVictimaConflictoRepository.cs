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
     /// Clase Abstracta para  StgPoblacionVictimaConflicto
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgPoblacionVictimaConflictoRepository : DataObject , IStgPoblacionVictimaConflicto 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgPoblacionVictimaConflictoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgPoblacionVictimaConflictoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgPoblacionVictimaConflicto GetById(StgPoblacionVictimaConflicto pStgPoblacionVictimaConflicto)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgPoblacionVictimaConflicto.id);                                    


    				StgPoblacionVictimaConflicto o = SqlMapper.QueryFirstOrDefault<StgPoblacionVictimaConflicto>(con, "API.PA_StgPoblacionVictimaConflictoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgPoblacionVictimaConflicto  ->" + ex.Message);
				}
			}

			public List<StgPoblacionVictimaConflicto> GetAll()
			{
				try 
                {
                        List<StgPoblacionVictimaConflicto> l = SqlMapper.Query<StgPoblacionVictimaConflicto>(con, "API.PA_StgPoblacionVictimaConflictoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgPoblacionVictimaConflicto  ->" + ex.Message);
				}
			}

			public List<StgPoblacionVictimaConflicto> GetAllFull()
			{
				try 
				{
                    List<StgPoblacionVictimaConflicto> l = SqlMapper.Query<StgPoblacionVictimaConflicto>(con, "API.PA_StgPoblacionVictimaConflictoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgPoblacionVictimaConflicto  ->" + ex.Message);
				}
			}
			
			public List<StgPoblacionVictimaConflicto> GetAllByWithRelation()
			{
				try 
                {
                    List<StgPoblacionVictimaConflicto> l = SqlMapper.Query<StgPoblacionVictimaConflicto>(con, "API.PA_StgPoblacionVictimaConflictoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgPoblacionVictimaConflicto  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgPoblacionVictimaConflicto> GetByFilter(StgPoblacionVictimaConflicto pStgPoblacionVictimaConflicto, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgPoblacionVictimaConflicto.id== null || pStgPoblacionVictimaConflicto.id==0) ? vintNUll :pStgPoblacionVictimaConflicto.id);
                    p.Add("@IdPoblVictiConf",(pStgPoblacionVictimaConflicto.IdPoblVictiConf== null) ? vintNUll :pStgPoblacionVictimaConflicto.IdPoblVictiConf);
                    p.Add("@Nombre",(pStgPoblacionVictimaConflicto.Nombre== null) ? vintNUll :pStgPoblacionVictimaConflicto.Nombre);
                    p.Add("@FechaCreacion",(pStgPoblacionVictimaConflicto.FechaCreacion== null) ? vintNUll :pStgPoblacionVictimaConflicto.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgPoblacionVictimaConflicto> l = SqlMapper.Query<StgPoblacionVictimaConflicto>(con, "API.PA_StgPoblacionVictimaConflictoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgPoblacionVictimaConflicto  ->" + ex.Message);
				}
			}

			public StgPoblacionVictimaConflicto Add(StgPoblacionVictimaConflicto pStgPoblacionVictimaConflicto)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgPoblacionVictimaConflicto.id==null ? 0 : pStgPoblacionVictimaConflicto.id);
                    p.Add("@IdPoblVictiConf", pStgPoblacionVictimaConflicto.IdPoblVictiConf);
                    p.Add("@Nombre", pStgPoblacionVictimaConflicto.Nombre);
                    p.Add("@FechaCreacion", pStgPoblacionVictimaConflicto.FechaCreacion);
                    p.Add("@auditoria", pStgPoblacionVictimaConflicto.auditoria);

                         


                    StgPoblacionVictimaConflicto o = SqlMapper.QueryFirstOrDefault<StgPoblacionVictimaConflicto>(con, "API.PA_StgPoblacionVictimaConflictoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgPoblacionVictimaConflicto  ->" + ex.Message);
				}
			}

			public StgPoblacionVictimaConflicto  Update(StgPoblacionVictimaConflicto pStgPoblacionVictimaConflicto)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgPoblacionVictimaConflicto.id==null ? 0 : pStgPoblacionVictimaConflicto.id);
                    p.Add("@IdPoblVictiConf", pStgPoblacionVictimaConflicto.IdPoblVictiConf);
                    p.Add("@Nombre", pStgPoblacionVictimaConflicto.Nombre);
                    p.Add("@FechaCreacion", pStgPoblacionVictimaConflicto.FechaCreacion);
                    p.Add("@auditoria", pStgPoblacionVictimaConflicto.auditoria);

                         


                    StgPoblacionVictimaConflicto o = SqlMapper.QueryFirstOrDefault<StgPoblacionVictimaConflicto>(con, "API.PA_StgPoblacionVictimaConflictoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgPoblacionVictimaConflicto  ->" + ex.Message);
				}
			}

			public bool Delete(StgPoblacionVictimaConflicto pStgPoblacionVictimaConflicto)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgPoblacionVictimaConflicto.id);
                    p.Add("@auditoria", pStgPoblacionVictimaConflicto.auditoria);

                

 

					StgPoblacionVictimaConflicto o = SqlMapper.QueryFirstOrDefault<StgPoblacionVictimaConflicto>(con, "API.PA_StgPoblacionVictimaConflictoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgPoblacionVictimaConflicto  ->" + ex.Message);
				}
			}

		



            public List<StgPoblacionVictimaConflicto> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgPoblacionVictimaConflicto> StgPoblacionVictimaConflictoList = new List<StgPoblacionVictimaConflicto>();

                    StgPoblacionVictimaConflictoList = SqlMapper.Query<StgPoblacionVictimaConflicto>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgPoblacionVictimaConflictoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgPoblacionVictimaConflicto  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgPoblacionVictimaConflicto> b)
            {
                DapperPlusManager.Entity<StgPoblacionVictimaConflicto>().Table("StgPoblacionVictimaConflicto");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}