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
     /// Clase Abstracta para  TiposPolizas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposPolizasRepository : DataObject , ITiposPolizas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposPolizasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposPolizasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposPolizas GetById(TiposPolizas pTiposPolizas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposPolizas.id);                                    


    				TiposPolizas o = SqlMapper.QueryFirstOrDefault<TiposPolizas>(con, "API.PA_TiposPolizasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposPolizas  ->" + ex.Message);
				}
			}

			public List<TiposPolizas> GetAll()
			{
				try 
                {
                        List<TiposPolizas> l = SqlMapper.Query<TiposPolizas>(con, "API.PA_TiposPolizasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposPolizas  ->" + ex.Message);
				}
			}

			public List<TiposPolizas> GetAllFull()
			{
				try 
				{
                    List<TiposPolizas> l = SqlMapper.Query<TiposPolizas>(con, "API.PA_TiposPolizasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposPolizas  ->" + ex.Message);
				}
			}
			
			public List<TiposPolizas> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposPolizas> l = SqlMapper.Query<TiposPolizas>(con, "API.PA_TiposPolizasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposPolizas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposPolizas> GetByFilter(TiposPolizas pTiposPolizas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposPolizas.id== null || pTiposPolizas.id==0) ? vintNUll :pTiposPolizas.id);
                    p.Add("@Nombre",(pTiposPolizas.Nombre== null) ? vintNUll :pTiposPolizas.Nombre);
                    p.Add("@CodigoCHIP",(pTiposPolizas.CodigoCHIP== null) ? vintNUll :pTiposPolizas.CodigoCHIP);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposPolizas> l = SqlMapper.Query<TiposPolizas>(con, "API.PA_TiposPolizasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposPolizas  ->" + ex.Message);
				}
			}

			public TiposPolizas Add(TiposPolizas pTiposPolizas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposPolizas.id==null ? 0 : pTiposPolizas.id);
                    p.Add("@Nombre", pTiposPolizas.Nombre);
                    p.Add("@CodigoCHIP", pTiposPolizas.CodigoCHIP);
                    p.Add("@auditoria", pTiposPolizas.auditoria);

                         


                    TiposPolizas o = SqlMapper.QueryFirstOrDefault<TiposPolizas>(con, "API.PA_TiposPolizasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposPolizas  ->" + ex.Message);
				}
			}

			public TiposPolizas  Update(TiposPolizas pTiposPolizas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposPolizas.id==null ? 0 : pTiposPolizas.id);
                    p.Add("@Nombre", pTiposPolizas.Nombre);
                    p.Add("@CodigoCHIP", pTiposPolizas.CodigoCHIP);
                    p.Add("@auditoria", pTiposPolizas.auditoria);

                         


                    TiposPolizas o = SqlMapper.QueryFirstOrDefault<TiposPolizas>(con, "API.PA_TiposPolizasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposPolizas  ->" + ex.Message);
				}
			}

			public bool Delete(TiposPolizas pTiposPolizas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposPolizas.id);
                    p.Add("@auditoria", pTiposPolizas.auditoria);

                

 

					TiposPolizas o = SqlMapper.QueryFirstOrDefault<TiposPolizas>(con, "API.PA_TiposPolizasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposPolizas  ->" + ex.Message);
				}
			}

		



            public List<TiposPolizas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposPolizas> TiposPolizasList = new List<TiposPolizas>();

                    TiposPolizasList = SqlMapper.Query<TiposPolizas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposPolizasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposPolizas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposPolizas> b)
            {
                DapperPlusManager.Entity<TiposPolizas>().Table("TiposPolizas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}