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
     /// Clase Abstracta para  TiposNutrientes
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposNutrientesRepository : DataObject , ITiposNutrientes 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposNutrientesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposNutrientesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposNutrientes GetById(TiposNutrientes pTiposNutrientes)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposNutrientes.id);                                    


    				TiposNutrientes o = SqlMapper.QueryFirstOrDefault<TiposNutrientes>(con, "API.PA_TiposNutrientesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposNutrientes  ->" + ex.Message);
				}
			}

			public List<TiposNutrientes> GetAll()
			{
				try 
                {
                        List<TiposNutrientes> l = SqlMapper.Query<TiposNutrientes>(con, "API.PA_TiposNutrientesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposNutrientes  ->" + ex.Message);
				}
			}

			public List<TiposNutrientes> GetAllFull()
			{
				try 
				{
                    List<TiposNutrientes> l = SqlMapper.Query<TiposNutrientes>(con, "API.PA_TiposNutrientesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposNutrientes  ->" + ex.Message);
				}
			}
			
			public List<TiposNutrientes> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposNutrientes> l = SqlMapper.Query<TiposNutrientes>(con, "API.PA_TiposNutrientesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposNutrientes  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposNutrientes> GetByFilter(TiposNutrientes pTiposNutrientes, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposNutrientes.id== null || pTiposNutrientes.id==0) ? vintNUll :pTiposNutrientes.id);
                    p.Add("@Nombre",(pTiposNutrientes.Nombre== null) ? vintNUll :pTiposNutrientes.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposNutrientes> l = SqlMapper.Query<TiposNutrientes>(con, "API.PA_TiposNutrientesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposNutrientes  ->" + ex.Message);
				}
			}

			public TiposNutrientes Add(TiposNutrientes pTiposNutrientes)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposNutrientes.id==null ? 0 : pTiposNutrientes.id);
                    p.Add("@Nombre", pTiposNutrientes.Nombre);
                    p.Add("@auditoria", pTiposNutrientes.auditoria);

                         


                    TiposNutrientes o = SqlMapper.QueryFirstOrDefault<TiposNutrientes>(con, "API.PA_TiposNutrientesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposNutrientes  ->" + ex.Message);
				}
			}

			public TiposNutrientes  Update(TiposNutrientes pTiposNutrientes)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposNutrientes.id==null ? 0 : pTiposNutrientes.id);
                    p.Add("@Nombre", pTiposNutrientes.Nombre);
                    p.Add("@auditoria", pTiposNutrientes.auditoria);

                         


                    TiposNutrientes o = SqlMapper.QueryFirstOrDefault<TiposNutrientes>(con, "API.PA_TiposNutrientesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposNutrientes  ->" + ex.Message);
				}
			}

			public bool Delete(TiposNutrientes pTiposNutrientes)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposNutrientes.id);
                    p.Add("@auditoria", pTiposNutrientes.auditoria);

                

 

					TiposNutrientes o = SqlMapper.QueryFirstOrDefault<TiposNutrientes>(con, "API.PA_TiposNutrientesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposNutrientes  ->" + ex.Message);
				}
			}

		



            public List<TiposNutrientes> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposNutrientes> TiposNutrientesList = new List<TiposNutrientes>();

                    TiposNutrientesList = SqlMapper.Query<TiposNutrientes>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposNutrientesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposNutrientes  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposNutrientes> b)
            {
                DapperPlusManager.Entity<TiposNutrientes>().Table("TiposNutrientes");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}