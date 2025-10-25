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
     /// Clase Abstracta para  TiposMinutaPatron
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposMinutaPatronRepository : DataObject , ITiposMinutaPatron 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposMinutaPatronRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposMinutaPatronRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposMinutaPatron GetById(TiposMinutaPatron pTiposMinutaPatron)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposMinutaPatron.id);                                    


    				TiposMinutaPatron o = SqlMapper.QueryFirstOrDefault<TiposMinutaPatron>(con, "API.PA_TiposMinutaPatronGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposMinutaPatron  ->" + ex.Message);
				}
			}

			public List<TiposMinutaPatron> GetAll()
			{
				try 
                {
                        List<TiposMinutaPatron> l = SqlMapper.Query<TiposMinutaPatron>(con, "API.PA_TiposMinutaPatronGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposMinutaPatron  ->" + ex.Message);
				}
			}

			public List<TiposMinutaPatron> GetAllFull()
			{
				try 
				{
                    List<TiposMinutaPatron> l = SqlMapper.Query<TiposMinutaPatron>(con, "API.PA_TiposMinutaPatronGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposMinutaPatron  ->" + ex.Message);
				}
			}
			
			public List<TiposMinutaPatron> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposMinutaPatron> l = SqlMapper.Query<TiposMinutaPatron>(con, "API.PA_TiposMinutaPatronGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposMinutaPatron  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposMinutaPatron> GetByFilter(TiposMinutaPatron pTiposMinutaPatron, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposMinutaPatron.id== null || pTiposMinutaPatron.id==0) ? vintNUll :pTiposMinutaPatron.id);
                    p.Add("@Nombre",(pTiposMinutaPatron.Nombre== null) ? vintNUll :pTiposMinutaPatron.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposMinutaPatron> l = SqlMapper.Query<TiposMinutaPatron>(con, "API.PA_TiposMinutaPatronGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposMinutaPatron  ->" + ex.Message);
				}
			}

			public TiposMinutaPatron Add(TiposMinutaPatron pTiposMinutaPatron)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposMinutaPatron.id==null ? 0 : pTiposMinutaPatron.id);
                    p.Add("@Nombre", pTiposMinutaPatron.Nombre);
                    p.Add("@auditoria", pTiposMinutaPatron.auditoria);

                         


                    TiposMinutaPatron o = SqlMapper.QueryFirstOrDefault<TiposMinutaPatron>(con, "API.PA_TiposMinutaPatronAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposMinutaPatron  ->" + ex.Message);
				}
			}

			public TiposMinutaPatron  Update(TiposMinutaPatron pTiposMinutaPatron)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposMinutaPatron.id==null ? 0 : pTiposMinutaPatron.id);
                    p.Add("@Nombre", pTiposMinutaPatron.Nombre);
                    p.Add("@auditoria", pTiposMinutaPatron.auditoria);

                         


                    TiposMinutaPatron o = SqlMapper.QueryFirstOrDefault<TiposMinutaPatron>(con, "API.PA_TiposMinutaPatronUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposMinutaPatron  ->" + ex.Message);
				}
			}

			public bool Delete(TiposMinutaPatron pTiposMinutaPatron)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposMinutaPatron.id);
                    p.Add("@auditoria", pTiposMinutaPatron.auditoria);

                

 

					TiposMinutaPatron o = SqlMapper.QueryFirstOrDefault<TiposMinutaPatron>(con, "API.PA_TiposMinutaPatronDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposMinutaPatron  ->" + ex.Message);
				}
			}

		



            public List<TiposMinutaPatron> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposMinutaPatron> TiposMinutaPatronList = new List<TiposMinutaPatron>();

                    TiposMinutaPatronList = SqlMapper.Query<TiposMinutaPatron>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposMinutaPatronList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposMinutaPatron  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposMinutaPatron> b)
            {
                DapperPlusManager.Entity<TiposMinutaPatron>().Table("TiposMinutaPatron");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}