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
     /// Clase Abstracta para  StgMetodologia
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgMetodologiaRepository : DataObject , IStgMetodologia 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgMetodologiaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgMetodologiaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgMetodologia GetById(StgMetodologia pStgMetodologia)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgMetodologia.id);                                    


    				StgMetodologia o = SqlMapper.QueryFirstOrDefault<StgMetodologia>(con, "API.PA_StgMetodologiaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgMetodologia  ->" + ex.Message);
				}
			}

			public List<StgMetodologia> GetAll()
			{
				try 
                {
                        List<StgMetodologia> l = SqlMapper.Query<StgMetodologia>(con, "API.PA_StgMetodologiaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgMetodologia  ->" + ex.Message);
				}
			}

			public List<StgMetodologia> GetAllFull()
			{
				try 
				{
                    List<StgMetodologia> l = SqlMapper.Query<StgMetodologia>(con, "API.PA_StgMetodologiaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgMetodologia  ->" + ex.Message);
				}
			}
			
			public List<StgMetodologia> GetAllByWithRelation()
			{
				try 
                {
                    List<StgMetodologia> l = SqlMapper.Query<StgMetodologia>(con, "API.PA_StgMetodologiaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgMetodologia  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgMetodologia> GetByFilter(StgMetodologia pStgMetodologia, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pStgMetodologia.id== null || pStgMetodologia.id==0) ? vintNUll :pStgMetodologia.id);
                    p.Add("@IdMetodologia",(pStgMetodologia.IdMetodologia== null) ? vintNUll :pStgMetodologia.IdMetodologia);
                    p.Add("@Nombre",(pStgMetodologia.Nombre== null) ? vintNUll :pStgMetodologia.Nombre);
                    p.Add("@FechaCreacion",(pStgMetodologia.FechaCreacion== null) ? vintNUll :pStgMetodologia.FechaCreacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgMetodologia> l = SqlMapper.Query<StgMetodologia>(con, "API.PA_StgMetodologiaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgMetodologia  ->" + ex.Message);
				}
			}

			public StgMetodologia Add(StgMetodologia pStgMetodologia)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pStgMetodologia.id==null ? 0 : pStgMetodologia.id);
                    p.Add("@IdMetodologia", pStgMetodologia.IdMetodologia);
                    p.Add("@Nombre", pStgMetodologia.Nombre);
                    p.Add("@FechaCreacion", pStgMetodologia.FechaCreacion);
                    p.Add("@auditoria", pStgMetodologia.auditoria);

                         


                    StgMetodologia o = SqlMapper.QueryFirstOrDefault<StgMetodologia>(con, "API.PA_StgMetodologiaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgMetodologia  ->" + ex.Message);
				}
			}

			public StgMetodologia  Update(StgMetodologia pStgMetodologia)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pStgMetodologia.id==null ? 0 : pStgMetodologia.id);
                    p.Add("@IdMetodologia", pStgMetodologia.IdMetodologia);
                    p.Add("@Nombre", pStgMetodologia.Nombre);
                    p.Add("@FechaCreacion", pStgMetodologia.FechaCreacion);
                    p.Add("@auditoria", pStgMetodologia.auditoria);

                         


                    StgMetodologia o = SqlMapper.QueryFirstOrDefault<StgMetodologia>(con, "API.PA_StgMetodologiaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgMetodologia  ->" + ex.Message);
				}
			}

			public bool Delete(StgMetodologia pStgMetodologia)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgMetodologia.id);
                    p.Add("@auditoria", pStgMetodologia.auditoria);

                

 

					StgMetodologia o = SqlMapper.QueryFirstOrDefault<StgMetodologia>(con, "API.PA_StgMetodologiaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgMetodologia  ->" + ex.Message);
				}
			}

		



            public List<StgMetodologia> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgMetodologia> StgMetodologiaList = new List<StgMetodologia>();

                    StgMetodologiaList = SqlMapper.Query<StgMetodologia>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgMetodologiaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgMetodologia  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgMetodologia> b)
            {
                DapperPlusManager.Entity<StgMetodologia>().Table("StgMetodologia");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}