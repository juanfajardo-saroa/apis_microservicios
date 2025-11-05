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
     /// Clase Abstracta para  TipoPlantasBodega
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoPlantasBodegaRepository : DataObject , ITipoPlantasBodega 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoPlantasBodegaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoPlantasBodegaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoPlantasBodega GetById(TipoPlantasBodega pTipoPlantasBodega)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoPlantasBodega.id);                                    


    				TipoPlantasBodega o = SqlMapper.QueryFirstOrDefault<TipoPlantasBodega>(con, "API.PA_TipoPlantasBodegaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoPlantasBodega  ->" + ex.Message);
				}
			}

			public List<TipoPlantasBodega> GetAll()
			{
				try 
                {
                        List<TipoPlantasBodega> l = SqlMapper.Query<TipoPlantasBodega>(con, "API.PA_TipoPlantasBodegaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoPlantasBodega  ->" + ex.Message);
				}
			}

			public List<TipoPlantasBodega> GetAllFull()
			{
				try 
				{
                    List<TipoPlantasBodega> l = SqlMapper.Query<TipoPlantasBodega>(con, "API.PA_TipoPlantasBodegaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoPlantasBodega  ->" + ex.Message);
				}
			}
			
			public List<TipoPlantasBodega> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoPlantasBodega> l = SqlMapper.Query<TipoPlantasBodega>(con, "API.PA_TipoPlantasBodegaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoPlantasBodega  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoPlantasBodega> GetByFilter(TipoPlantasBodega pTipoPlantasBodega, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoPlantasBodega.id== null || pTipoPlantasBodega.id==0) ? vintNUll :pTipoPlantasBodega.id);
                    p.Add("@Nombre",(pTipoPlantasBodega.Nombre== null) ? vintNUll :pTipoPlantasBodega.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoPlantasBodega> l = SqlMapper.Query<TipoPlantasBodega>(con, "API.PA_TipoPlantasBodegaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoPlantasBodega  ->" + ex.Message);
				}
			}

			public TipoPlantasBodega Add(TipoPlantasBodega pTipoPlantasBodega)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoPlantasBodega.id==null ? 0 : pTipoPlantasBodega.id);
                    p.Add("@Nombre", pTipoPlantasBodega.Nombre);
                    p.Add("@auditoria", pTipoPlantasBodega.auditoria);

                         


                    TipoPlantasBodega o = SqlMapper.QueryFirstOrDefault<TipoPlantasBodega>(con, "API.PA_TipoPlantasBodegaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoPlantasBodega  ->" + ex.Message);
				}
			}

			public TipoPlantasBodega  Update(TipoPlantasBodega pTipoPlantasBodega)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoPlantasBodega.id==null ? 0 : pTipoPlantasBodega.id);
                    p.Add("@Nombre", pTipoPlantasBodega.Nombre);
                    p.Add("@auditoria", pTipoPlantasBodega.auditoria);

                         


                    TipoPlantasBodega o = SqlMapper.QueryFirstOrDefault<TipoPlantasBodega>(con, "API.PA_TipoPlantasBodegaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoPlantasBodega  ->" + ex.Message);
				}
			}

			public bool Delete(TipoPlantasBodega pTipoPlantasBodega)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoPlantasBodega.id);
                    p.Add("@auditoria", pTipoPlantasBodega.auditoria);

                

 

					TipoPlantasBodega o = SqlMapper.QueryFirstOrDefault<TipoPlantasBodega>(con, "API.PA_TipoPlantasBodegaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoPlantasBodega  ->" + ex.Message);
				}
			}

		



            public List<TipoPlantasBodega> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoPlantasBodega> TipoPlantasBodegaList = new List<TipoPlantasBodega>();

                    TipoPlantasBodegaList = SqlMapper.Query<TipoPlantasBodega>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoPlantasBodegaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoPlantasBodega  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoPlantasBodega> b)
            {
                DapperPlusManager.Entity<TipoPlantasBodega>().Table("TipoPlantasBodega");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}