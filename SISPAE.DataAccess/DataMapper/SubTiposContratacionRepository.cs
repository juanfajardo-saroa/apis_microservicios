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
     /// Clase Abstracta para  SubTiposContratacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SubTiposContratacionRepository : DataObject , ISubTiposContratacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SubTiposContratacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SubTiposContratacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public SubTiposContratacion GetById(SubTiposContratacion pSubTiposContratacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSubTiposContratacion.id);                                    


    				SubTiposContratacion o = SqlMapper.QueryFirstOrDefault<SubTiposContratacion>(con, "API.PA_SubTiposContratacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  SubTiposContratacion  ->" + ex.Message);
				}
			}

			public List<SubTiposContratacion> GetAll()
			{
				try 
                {
                        List<SubTiposContratacion> l = SqlMapper.Query<SubTiposContratacion>(con, "API.PA_SubTiposContratacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  SubTiposContratacion  ->" + ex.Message);
				}
			}

			public List<SubTiposContratacion> GetAllFull()
			{
				try 
				{
                    List<SubTiposContratacion> l = SqlMapper.Query<SubTiposContratacion>(con, "API.PA_SubTiposContratacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  SubTiposContratacion  ->" + ex.Message);
				}
			}
			
			public List<SubTiposContratacion> GetAllByWithRelation()
			{
				try 
                {
                    List<SubTiposContratacion> l = SqlMapper.Query<SubTiposContratacion>(con, "API.PA_SubTiposContratacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  SubTiposContratacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<SubTiposContratacion> GetByFilter(SubTiposContratacion pSubTiposContratacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSubTiposContratacion.id== null || pSubTiposContratacion.id==0) ? vintNUll :pSubTiposContratacion.id);
                    p.Add("@Nombre",(pSubTiposContratacion.Nombre== null) ? vintNUll :pSubTiposContratacion.Nombre);
                    p.Add("@TipoContratoId",(pSubTiposContratacion.TipoContratoId== null) ? vintNUll :pSubTiposContratacion.TipoContratoId);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<SubTiposContratacion> l = SqlMapper.Query<SubTiposContratacion>(con, "API.PA_SubTiposContratacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  SubTiposContratacion  ->" + ex.Message);
				}
			}

			public SubTiposContratacion Add(SubTiposContratacion pSubTiposContratacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSubTiposContratacion.id==null ? 0 : pSubTiposContratacion.id);
                    p.Add("@Nombre", pSubTiposContratacion.Nombre);
p.Add("@TipoContratoId",pSubTiposContratacion.TipoContratoId==null ? 0 : pSubTiposContratacion.TipoContratoId);
                    p.Add("@auditoria", pSubTiposContratacion.auditoria);

                         


                    SubTiposContratacion o = SqlMapper.QueryFirstOrDefault<SubTiposContratacion>(con, "API.PA_SubTiposContratacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  SubTiposContratacion  ->" + ex.Message);
				}
			}

			public SubTiposContratacion  Update(SubTiposContratacion pSubTiposContratacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSubTiposContratacion.id==null ? 0 : pSubTiposContratacion.id);
                    p.Add("@Nombre", pSubTiposContratacion.Nombre);
p.Add("@TipoContratoId",pSubTiposContratacion.TipoContratoId==null ? 0 : pSubTiposContratacion.TipoContratoId);
                    p.Add("@auditoria", pSubTiposContratacion.auditoria);

                         


                    SubTiposContratacion o = SqlMapper.QueryFirstOrDefault<SubTiposContratacion>(con, "API.PA_SubTiposContratacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  SubTiposContratacion  ->" + ex.Message);
				}
			}

			public bool Delete(SubTiposContratacion pSubTiposContratacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSubTiposContratacion.id);
                    p.Add("@auditoria", pSubTiposContratacion.auditoria);

                

 

					SubTiposContratacion o = SqlMapper.QueryFirstOrDefault<SubTiposContratacion>(con, "API.PA_SubTiposContratacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) SubTiposContratacion  ->" + ex.Message);
				}
			}

		



            public List<SubTiposContratacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<SubTiposContratacion> SubTiposContratacionList = new List<SubTiposContratacion>();

                    SubTiposContratacionList = SqlMapper.Query<SubTiposContratacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SubTiposContratacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) SubTiposContratacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<SubTiposContratacion> b)
            {
                DapperPlusManager.Entity<SubTiposContratacion>().Table("SubTiposContratacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}