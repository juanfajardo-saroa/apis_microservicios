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
     /// Clase Abstracta para  TP_Municipio
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TP_MunicipioRepository : DataObject , ITP_Municipio 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TP_MunicipioRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TP_MunicipioRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TP_Municipio GetById(TP_Municipio pTP_Municipio)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTP_Municipio.id);                                    


    				TP_Municipio o = SqlMapper.QueryFirstOrDefault<TP_Municipio>(con, "API.PA_TP_MunicipioGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TP_Municipio  ->" + ex.Message);
				}
			}

			public List<TP_Municipio> GetAll()
			{
				try 
                {
                        List<TP_Municipio> l = SqlMapper.Query<TP_Municipio>(con, "API.PA_TP_MunicipioGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TP_Municipio  ->" + ex.Message);
				}
			}

			public List<TP_Municipio> GetAllFull()
			{
				try 
				{
                    List<TP_Municipio> l = SqlMapper.Query<TP_Municipio>(con, "API.PA_TP_MunicipioGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TP_Municipio  ->" + ex.Message);
				}
			}
			
			public List<TP_Municipio> GetAllByWithRelation()
			{
				try 
                {
                    List<TP_Municipio> l = SqlMapper.Query<TP_Municipio>(con, "API.PA_TP_MunicipioGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TP_Municipio  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TP_Municipio> GetByFilter(TP_Municipio pTP_Municipio, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTP_Municipio.id== null || pTP_Municipio.id==0) ? vintNUll :pTP_Municipio.id);
                    p.Add("@id_TP_departamento",(pTP_Municipio.id_TP_departamento== null || pTP_Municipio.id_TP_departamento==0) ? vintNUll :pTP_Municipio.id_TP_departamento);
                    p.Add("@codigo", pTP_Municipio.codigo);
                    p.Add("@nombre", pTP_Municipio.nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TP_Municipio> l = SqlMapper.Query<TP_Municipio>(con, "API.PA_TP_MunicipioGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TP_Municipio  ->" + ex.Message);
				}
			}

			public TP_Municipio Add(TP_Municipio pTP_Municipio)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTP_Municipio.id== null ? 0: pTP_Municipio.id);
p.Add("@id_TP_departamento",pTP_Municipio.id_TP_departamento== null ? 0: pTP_Municipio.id_TP_departamento);
                    p.Add("@codigo", pTP_Municipio.codigo);
                    p.Add("@nombre", pTP_Municipio.nombre);
                    p.Add("@auditoria", pTP_Municipio.auditoria);

                         


                    TP_Municipio o = SqlMapper.QueryFirstOrDefault<TP_Municipio>(con, "API.PA_TP_MunicipioAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TP_Municipio  ->" + ex.Message);
				}
			}

			public TP_Municipio  Update(TP_Municipio pTP_Municipio)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTP_Municipio.id== null ? 0: pTP_Municipio.id);
p.Add("@id_TP_departamento",pTP_Municipio.id_TP_departamento== null ? 0: pTP_Municipio.id_TP_departamento);
                    p.Add("@codigo", pTP_Municipio.codigo);
                    p.Add("@nombre", pTP_Municipio.nombre);
                    p.Add("@auditoria", pTP_Municipio.auditoria);

                         


                    TP_Municipio o = SqlMapper.QueryFirstOrDefault<TP_Municipio>(con, "API.PA_TP_MunicipioUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TP_Municipio  ->" + ex.Message);
				}
			}

			public bool Delete(TP_Municipio pTP_Municipio)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTP_Municipio.id);
                    p.Add("@auditoria", pTP_Municipio.auditoria);

                

 

					TP_Municipio o = SqlMapper.QueryFirstOrDefault<TP_Municipio>(con, "API.PA_TP_MunicipioDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TP_Municipio  ->" + ex.Message);
				}
			}

		



            public List<TP_Municipio> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TP_Municipio> TP_MunicipioList = new List<TP_Municipio>();

                    TP_MunicipioList = SqlMapper.Query<TP_Municipio>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TP_MunicipioList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TP_Municipio  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TP_Municipio> b)
            {
                DapperPlusManager.Entity<TP_Municipio>().Table("TP_Municipio");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}