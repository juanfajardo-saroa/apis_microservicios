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
     /// Clase Abstracta para  TiposActividadFisica
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposActividadFisicaRepository : DataObject , ITiposActividadFisica 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposActividadFisicaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposActividadFisicaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposActividadFisica GetById(TiposActividadFisica pTiposActividadFisica)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposActividadFisica.id);                                    


    				TiposActividadFisica o = SqlMapper.QueryFirstOrDefault<TiposActividadFisica>(con, "API.PA_TiposActividadFisicaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposActividadFisica  ->" + ex.Message);
				}
			}

			public List<TiposActividadFisica> GetAll()
			{
				try 
                {
                        List<TiposActividadFisica> l = SqlMapper.Query<TiposActividadFisica>(con, "API.PA_TiposActividadFisicaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposActividadFisica  ->" + ex.Message);
				}
			}

			public List<TiposActividadFisica> GetAllFull()
			{
				try 
				{
                    List<TiposActividadFisica> l = SqlMapper.Query<TiposActividadFisica>(con, "API.PA_TiposActividadFisicaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposActividadFisica  ->" + ex.Message);
				}
			}
			
			public List<TiposActividadFisica> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposActividadFisica> l = SqlMapper.Query<TiposActividadFisica>(con, "API.PA_TiposActividadFisicaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposActividadFisica  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposActividadFisica> GetByFilter(TiposActividadFisica pTiposActividadFisica, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposActividadFisica.id== null || pTiposActividadFisica.id==0) ? vintNUll :pTiposActividadFisica.id);
                    p.Add("@Nombre",(pTiposActividadFisica.Nombre== null) ? vintNUll :pTiposActividadFisica.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposActividadFisica> l = SqlMapper.Query<TiposActividadFisica>(con, "API.PA_TiposActividadFisicaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposActividadFisica  ->" + ex.Message);
				}
			}

			public TiposActividadFisica Add(TiposActividadFisica pTiposActividadFisica)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposActividadFisica.id==null ? 0 : pTiposActividadFisica.id);
                    p.Add("@Nombre", pTiposActividadFisica.Nombre);
                    p.Add("@auditoria", pTiposActividadFisica.auditoria);

                         


                    TiposActividadFisica o = SqlMapper.QueryFirstOrDefault<TiposActividadFisica>(con, "API.PA_TiposActividadFisicaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposActividadFisica  ->" + ex.Message);
				}
			}

			public TiposActividadFisica  Update(TiposActividadFisica pTiposActividadFisica)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposActividadFisica.id==null ? 0 : pTiposActividadFisica.id);
                    p.Add("@Nombre", pTiposActividadFisica.Nombre);
                    p.Add("@auditoria", pTiposActividadFisica.auditoria);

                         


                    TiposActividadFisica o = SqlMapper.QueryFirstOrDefault<TiposActividadFisica>(con, "API.PA_TiposActividadFisicaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposActividadFisica  ->" + ex.Message);
				}
			}

			public bool Delete(TiposActividadFisica pTiposActividadFisica)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposActividadFisica.id);
                    p.Add("@auditoria", pTiposActividadFisica.auditoria);

                

 

					TiposActividadFisica o = SqlMapper.QueryFirstOrDefault<TiposActividadFisica>(con, "API.PA_TiposActividadFisicaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposActividadFisica  ->" + ex.Message);
				}
			}

		



            public List<TiposActividadFisica> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposActividadFisica> TiposActividadFisicaList = new List<TiposActividadFisica>();

                    TiposActividadFisicaList = SqlMapper.Query<TiposActividadFisica>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposActividadFisicaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposActividadFisica  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposActividadFisica> b)
            {
                DapperPlusManager.Entity<TiposActividadFisica>().Table("TiposActividadFisica");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}