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
     /// Clase Abstracta para  StgTipoDocumento
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgTipoDocumentoRepository : DataObject , IStgTipoDocumento 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgTipoDocumentoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgTipoDocumentoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgTipoDocumento GetById(StgTipoDocumento pStgTipoDocumento)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgTipoDocumento.id);                                    


    				StgTipoDocumento o = SqlMapper.QueryFirstOrDefault<StgTipoDocumento>(con, "API.PA_StgTipoDocumentoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgTipoDocumento  ->" + ex.Message);
				}
			}

			public List<StgTipoDocumento> GetAll()
			{
				try 
                {
                        List<StgTipoDocumento> l = SqlMapper.Query<StgTipoDocumento>(con, "API.PA_StgTipoDocumentoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgTipoDocumento  ->" + ex.Message);
				}
			}

			public List<StgTipoDocumento> GetAllFull()
			{
				try 
				{
                    List<StgTipoDocumento> l = SqlMapper.Query<StgTipoDocumento>(con, "API.PA_StgTipoDocumentoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgTipoDocumento  ->" + ex.Message);
				}
			}
			
			public List<StgTipoDocumento> GetAllByWithRelation()
			{
				try 
                {
                    List<StgTipoDocumento> l = SqlMapper.Query<StgTipoDocumento>(con, "API.PA_StgTipoDocumentoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgTipoDocumento  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgTipoDocumento> GetByFilter(StgTipoDocumento pStgTipoDocumento, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgTipoDocumento.id== null || pStgTipoDocumento.id==0) ? vintNUll :pStgTipoDocumento.id);
                    p.Add("@IdTipoDocumento",(pStgTipoDocumento.IdTipoDocumento== null || pStgTipoDocumento.IdTipoDocumento==0) ? vintNUll :pStgTipoDocumento.IdTipoDocumento);
                    p.Add("@Nombre",(pStgTipoDocumento.Nombre== null) ? vintNUll :pStgTipoDocumento.Nombre);
                    p.Add("@FechaCreacion",(pStgTipoDocumento.FechaCreacion== null) ? vintNUll :pStgTipoDocumento.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgTipoDocumento> l = SqlMapper.Query<StgTipoDocumento>(con, "API.PA_StgTipoDocumentoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgTipoDocumento  ->" + ex.Message);
				}
			}

			public StgTipoDocumento Add(StgTipoDocumento pStgTipoDocumento)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgTipoDocumento.id==null ? 0 : pStgTipoDocumento.id);
p.Add("@IdTipoDocumento",pStgTipoDocumento.IdTipoDocumento==null ? 0 : pStgTipoDocumento.IdTipoDocumento);
                    p.Add("@Nombre", pStgTipoDocumento.Nombre);
                    p.Add("@FechaCreacion", pStgTipoDocumento.FechaCreacion);
                    p.Add("@auditoria", pStgTipoDocumento.auditoria);

                         


                    StgTipoDocumento o = SqlMapper.QueryFirstOrDefault<StgTipoDocumento>(con, "API.PA_StgTipoDocumentoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgTipoDocumento  ->" + ex.Message);
				}
			}

			public StgTipoDocumento  Update(StgTipoDocumento pStgTipoDocumento)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgTipoDocumento.id==null ? 0 : pStgTipoDocumento.id);
p.Add("@IdTipoDocumento",pStgTipoDocumento.IdTipoDocumento==null ? 0 : pStgTipoDocumento.IdTipoDocumento);
                    p.Add("@Nombre", pStgTipoDocumento.Nombre);
                    p.Add("@FechaCreacion", pStgTipoDocumento.FechaCreacion);
                    p.Add("@auditoria", pStgTipoDocumento.auditoria);

                         


                    StgTipoDocumento o = SqlMapper.QueryFirstOrDefault<StgTipoDocumento>(con, "API.PA_StgTipoDocumentoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgTipoDocumento  ->" + ex.Message);
				}
			}

			public bool Delete(StgTipoDocumento pStgTipoDocumento)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgTipoDocumento.id);
                    p.Add("@auditoria", pStgTipoDocumento.auditoria);

                

 

					StgTipoDocumento o = SqlMapper.QueryFirstOrDefault<StgTipoDocumento>(con, "API.PA_StgTipoDocumentoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgTipoDocumento  ->" + ex.Message);
				}
			}

		



            public List<StgTipoDocumento> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgTipoDocumento> StgTipoDocumentoList = new List<StgTipoDocumento>();

                    StgTipoDocumentoList = SqlMapper.Query<StgTipoDocumento>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgTipoDocumentoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgTipoDocumento  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgTipoDocumento> b)
            {
                DapperPlusManager.Entity<StgTipoDocumento>().Table("StgTipoDocumento");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}