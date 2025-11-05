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
     /// Clase Abstracta para  TipoMunicipio
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoMunicipioRepository : DataObject , ITipoMunicipio 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoMunicipioRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoMunicipioRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoMunicipio GetById(TipoMunicipio pTipoMunicipio)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoMunicipio.id);                                    


    				TipoMunicipio o = SqlMapper.QueryFirstOrDefault<TipoMunicipio>(con, "API.PA_TipoMunicipioGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoMunicipio  ->" + ex.Message);
				}
			}

			public List<TipoMunicipio> GetAll()
			{
				try 
                {
                        List<TipoMunicipio> l = SqlMapper.Query<TipoMunicipio>(con, "API.PA_TipoMunicipioGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoMunicipio  ->" + ex.Message);
				}
			}

			public List<TipoMunicipio> GetAllFull()
			{
				try 
				{
                    List<TipoMunicipio> l = SqlMapper.Query<TipoMunicipio>(con, "API.PA_TipoMunicipioGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoMunicipio  ->" + ex.Message);
				}
			}
			
			public List<TipoMunicipio> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoMunicipio> l = SqlMapper.Query<TipoMunicipio>(con, "API.PA_TipoMunicipioGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoMunicipio  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoMunicipio> GetByFilter(TipoMunicipio pTipoMunicipio, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoMunicipio.id== null || pTipoMunicipio.id==0) ? vintNUll :pTipoMunicipio.id);
                    p.Add("@Nombre",(pTipoMunicipio.Nombre== null) ? vintNUll :pTipoMunicipio.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoMunicipio> l = SqlMapper.Query<TipoMunicipio>(con, "API.PA_TipoMunicipioGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoMunicipio  ->" + ex.Message);
				}
			}

			public TipoMunicipio Add(TipoMunicipio pTipoMunicipio)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoMunicipio.id==null ? 0 : pTipoMunicipio.id);
                    p.Add("@Nombre", pTipoMunicipio.Nombre);
                    p.Add("@auditoria", pTipoMunicipio.auditoria);

                         


                    TipoMunicipio o = SqlMapper.QueryFirstOrDefault<TipoMunicipio>(con, "API.PA_TipoMunicipioAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoMunicipio  ->" + ex.Message);
				}
			}

			public TipoMunicipio  Update(TipoMunicipio pTipoMunicipio)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoMunicipio.id==null ? 0 : pTipoMunicipio.id);
                    p.Add("@Nombre", pTipoMunicipio.Nombre);
                    p.Add("@auditoria", pTipoMunicipio.auditoria);

                         


                    TipoMunicipio o = SqlMapper.QueryFirstOrDefault<TipoMunicipio>(con, "API.PA_TipoMunicipioUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoMunicipio  ->" + ex.Message);
				}
			}

			public bool Delete(TipoMunicipio pTipoMunicipio)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoMunicipio.id);
                    p.Add("@auditoria", pTipoMunicipio.auditoria);

                

 

					TipoMunicipio o = SqlMapper.QueryFirstOrDefault<TipoMunicipio>(con, "API.PA_TipoMunicipioDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoMunicipio  ->" + ex.Message);
				}
			}

		



            public List<TipoMunicipio> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoMunicipio> TipoMunicipioList = new List<TipoMunicipio>();

                    TipoMunicipioList = SqlMapper.Query<TipoMunicipio>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoMunicipioList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoMunicipio  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoMunicipio> b)
            {
                DapperPlusManager.Entity<TipoMunicipio>().Table("TipoMunicipio");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}