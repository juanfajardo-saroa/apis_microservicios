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
     /// Clase Abstracta para  TiposContratos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposContratosRepository : DataObject , ITiposContratos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposContratosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposContratosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposContratos GetById(TiposContratos pTiposContratos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposContratos.id);                                    


    				TiposContratos o = SqlMapper.QueryFirstOrDefault<TiposContratos>(con, "API.PA_TiposContratosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposContratos  ->" + ex.Message);
				}
			}

			public List<TiposContratos> GetAll()
			{
				try 
                {
                        List<TiposContratos> l = SqlMapper.Query<TiposContratos>(con, "API.PA_TiposContratosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposContratos  ->" + ex.Message);
				}
			}

			public List<TiposContratos> GetAllFull()
			{
				try 
				{
                    List<TiposContratos> l = SqlMapper.Query<TiposContratos>(con, "API.PA_TiposContratosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposContratos  ->" + ex.Message);
				}
			}
			
			public List<TiposContratos> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposContratos> l = SqlMapper.Query<TiposContratos>(con, "API.PA_TiposContratosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposContratos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposContratos> GetByFilter(TiposContratos pTiposContratos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposContratos.id== null || pTiposContratos.id==0) ? vintNUll :pTiposContratos.id);
                    p.Add("@Nombre",(pTiposContratos.Nombre== null) ? vintNUll :pTiposContratos.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposContratos> l = SqlMapper.Query<TiposContratos>(con, "API.PA_TiposContratosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposContratos  ->" + ex.Message);
				}
			}

			public TiposContratos Add(TiposContratos pTiposContratos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposContratos.id==null ? 0 : pTiposContratos.id);
                    p.Add("@Nombre", pTiposContratos.Nombre);
                    p.Add("@auditoria", pTiposContratos.auditoria);

                         


                    TiposContratos o = SqlMapper.QueryFirstOrDefault<TiposContratos>(con, "API.PA_TiposContratosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposContratos  ->" + ex.Message);
				}
			}

			public TiposContratos  Update(TiposContratos pTiposContratos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposContratos.id==null ? 0 : pTiposContratos.id);
                    p.Add("@Nombre", pTiposContratos.Nombre);
                    p.Add("@auditoria", pTiposContratos.auditoria);

                         


                    TiposContratos o = SqlMapper.QueryFirstOrDefault<TiposContratos>(con, "API.PA_TiposContratosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposContratos  ->" + ex.Message);
				}
			}

			public bool Delete(TiposContratos pTiposContratos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposContratos.id);
                    p.Add("@auditoria", pTiposContratos.auditoria);

                

 

					TiposContratos o = SqlMapper.QueryFirstOrDefault<TiposContratos>(con, "API.PA_TiposContratosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposContratos  ->" + ex.Message);
				}
			}

		



            public List<TiposContratos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposContratos> TiposContratosList = new List<TiposContratos>();

                    TiposContratosList = SqlMapper.Query<TiposContratos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposContratosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposContratos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposContratos> b)
            {
                DapperPlusManager.Entity<TiposContratos>().Table("TiposContratos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}