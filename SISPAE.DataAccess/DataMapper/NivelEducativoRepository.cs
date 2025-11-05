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
     /// Clase Abstracta para  NivelEducativo
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class NivelEducativoRepository : DataObject , INivelEducativo 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public NivelEducativoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public NivelEducativoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public NivelEducativo GetById(NivelEducativo pNivelEducativo)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pNivelEducativo.id);                                    


    				NivelEducativo o = SqlMapper.QueryFirstOrDefault<NivelEducativo>(con, "API.PA_NivelEducativoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  NivelEducativo  ->" + ex.Message);
				}
			}

			public List<NivelEducativo> GetAll()
			{
				try 
                {
                        List<NivelEducativo> l = SqlMapper.Query<NivelEducativo>(con, "API.PA_NivelEducativoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  NivelEducativo  ->" + ex.Message);
				}
			}

			public List<NivelEducativo> GetAllFull()
			{
				try 
				{
                    List<NivelEducativo> l = SqlMapper.Query<NivelEducativo>(con, "API.PA_NivelEducativoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  NivelEducativo  ->" + ex.Message);
				}
			}
			
			public List<NivelEducativo> GetAllByWithRelation()
			{
				try 
                {
                    List<NivelEducativo> l = SqlMapper.Query<NivelEducativo>(con, "API.PA_NivelEducativoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  NivelEducativo  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<NivelEducativo> GetByFilter(NivelEducativo pNivelEducativo, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pNivelEducativo.id== null || pNivelEducativo.id==0) ? vintNUll :pNivelEducativo.id);
                    p.Add("@Nombre",(pNivelEducativo.Nombre== null) ? vintNUll :pNivelEducativo.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<NivelEducativo> l = SqlMapper.Query<NivelEducativo>(con, "API.PA_NivelEducativoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  NivelEducativo  ->" + ex.Message);
				}
			}

			public NivelEducativo Add(NivelEducativo pNivelEducativo)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pNivelEducativo.id==null ? 0 : pNivelEducativo.id);
                    p.Add("@Nombre", pNivelEducativo.Nombre);
                    p.Add("@auditoria", pNivelEducativo.auditoria);

                         


                    NivelEducativo o = SqlMapper.QueryFirstOrDefault<NivelEducativo>(con, "API.PA_NivelEducativoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  NivelEducativo  ->" + ex.Message);
				}
			}

			public NivelEducativo  Update(NivelEducativo pNivelEducativo)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pNivelEducativo.id==null ? 0 : pNivelEducativo.id);
                    p.Add("@Nombre", pNivelEducativo.Nombre);
                    p.Add("@auditoria", pNivelEducativo.auditoria);

                         


                    NivelEducativo o = SqlMapper.QueryFirstOrDefault<NivelEducativo>(con, "API.PA_NivelEducativoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  NivelEducativo  ->" + ex.Message);
				}
			}

			public bool Delete(NivelEducativo pNivelEducativo)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pNivelEducativo.id);
                    p.Add("@auditoria", pNivelEducativo.auditoria);

                

 

					NivelEducativo o = SqlMapper.QueryFirstOrDefault<NivelEducativo>(con, "API.PA_NivelEducativoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) NivelEducativo  ->" + ex.Message);
				}
			}

		



            public List<NivelEducativo> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<NivelEducativo> NivelEducativoList = new List<NivelEducativo>();

                    NivelEducativoList = SqlMapper.Query<NivelEducativo>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return NivelEducativoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) NivelEducativo  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<NivelEducativo> b)
            {
                DapperPlusManager.Entity<NivelEducativo>().Table("NivelEducativo");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}