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
     /// Clase Abstracta para  OtrosCostos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class OtrosCostosRepository : DataObject , IOtrosCostos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public OtrosCostosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public OtrosCostosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public OtrosCostos GetById(OtrosCostos pOtrosCostos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pOtrosCostos.id);                                    


    				OtrosCostos o = SqlMapper.QueryFirstOrDefault<OtrosCostos>(con, "API.PA_OtrosCostosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  OtrosCostos  ->" + ex.Message);
				}
			}

			public List<OtrosCostos> GetAll()
			{
				try 
                {
                        List<OtrosCostos> l = SqlMapper.Query<OtrosCostos>(con, "API.PA_OtrosCostosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  OtrosCostos  ->" + ex.Message);
				}
			}

			public List<OtrosCostos> GetAllFull()
			{
				try 
				{
                    List<OtrosCostos> l = SqlMapper.Query<OtrosCostos>(con, "API.PA_OtrosCostosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  OtrosCostos  ->" + ex.Message);
				}
			}
			
			public List<OtrosCostos> GetAllByWithRelation()
			{
				try 
                {
                    List<OtrosCostos> l = SqlMapper.Query<OtrosCostos>(con, "API.PA_OtrosCostosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  OtrosCostos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<OtrosCostos> GetByFilter(OtrosCostos pOtrosCostos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pOtrosCostos.id== null || pOtrosCostos.id==0) ? vintNUll :pOtrosCostos.id);
                    p.Add("@ID_ETC",(pOtrosCostos.ID_ETC== null || pOtrosCostos.ID_ETC==0) ? vintNUll :pOtrosCostos.ID_ETC);
                    p.Add("@ID_TipoModeloOperacion",(pOtrosCostos.ID_TipoModeloOperacion== null || pOtrosCostos.ID_TipoModeloOperacion==0) ? vintNUll :pOtrosCostos.ID_TipoModeloOperacion);
                    p.Add("@Concepto",(pOtrosCostos.Concepto== null) ? vintNUll :pOtrosCostos.Concepto);
                    p.Add("@ValorAnual",(pOtrosCostos.ValorAnual== null) ? vintNUll :pOtrosCostos.ValorAnual);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<OtrosCostos> l = SqlMapper.Query<OtrosCostos>(con, "API.PA_OtrosCostosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  OtrosCostos  ->" + ex.Message);
				}
			}

			public OtrosCostos Add(OtrosCostos pOtrosCostos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pOtrosCostos.id==null ? 0 : pOtrosCostos.id);
p.Add("@ID_ETC",pOtrosCostos.ID_ETC==null ? 0 : pOtrosCostos.ID_ETC);
p.Add("@ID_TipoModeloOperacion",pOtrosCostos.ID_TipoModeloOperacion==null ? 0 : pOtrosCostos.ID_TipoModeloOperacion);
                    p.Add("@Concepto", pOtrosCostos.Concepto);
                    p.Add("@ValorAnual", pOtrosCostos.ValorAnual);
                    p.Add("@auditoria", pOtrosCostos.auditoria);

                         


                    OtrosCostos o = SqlMapper.QueryFirstOrDefault<OtrosCostos>(con, "API.PA_OtrosCostosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  OtrosCostos  ->" + ex.Message);
				}
			}

			public OtrosCostos  Update(OtrosCostos pOtrosCostos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pOtrosCostos.id==null ? 0 : pOtrosCostos.id);
p.Add("@ID_ETC",pOtrosCostos.ID_ETC==null ? 0 : pOtrosCostos.ID_ETC);
p.Add("@ID_TipoModeloOperacion",pOtrosCostos.ID_TipoModeloOperacion==null ? 0 : pOtrosCostos.ID_TipoModeloOperacion);
                    p.Add("@Concepto", pOtrosCostos.Concepto);
                    p.Add("@ValorAnual", pOtrosCostos.ValorAnual);
                    p.Add("@auditoria", pOtrosCostos.auditoria);

                         


                    OtrosCostos o = SqlMapper.QueryFirstOrDefault<OtrosCostos>(con, "API.PA_OtrosCostosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  OtrosCostos  ->" + ex.Message);
				}
			}

			public bool Delete(OtrosCostos pOtrosCostos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pOtrosCostos.id);
                    p.Add("@auditoria", pOtrosCostos.auditoria);

                

 

					OtrosCostos o = SqlMapper.QueryFirstOrDefault<OtrosCostos>(con, "API.PA_OtrosCostosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) OtrosCostos  ->" + ex.Message);
				}
			}

		



            public List<OtrosCostos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<OtrosCostos> OtrosCostosList = new List<OtrosCostos>();

                    OtrosCostosList = SqlMapper.Query<OtrosCostos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return OtrosCostosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) OtrosCostos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<OtrosCostos> b)
            {
                DapperPlusManager.Entity<OtrosCostos>().Table("OtrosCostos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}