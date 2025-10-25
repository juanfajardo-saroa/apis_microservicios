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
     /// Clase Abstracta para  TiposAcceso
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposAccesoRepository : DataObject , ITiposAcceso 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposAccesoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposAccesoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposAcceso GetById(TiposAcceso pTiposAcceso)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposAcceso.id);p.Add("@TipoAccesoId",pTiposAcceso.TipoAccesoId);                                    


    				TiposAcceso o = SqlMapper.QueryFirstOrDefault<TiposAcceso>(con, "API.PA_TiposAccesoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposAcceso  ->" + ex.Message);
				}
			}

			public List<TiposAcceso> GetAll()
			{
				try 
                {
                        List<TiposAcceso> l = SqlMapper.Query<TiposAcceso>(con, "API.PA_TiposAccesoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposAcceso  ->" + ex.Message);
				}
			}

			public List<TiposAcceso> GetAllFull()
			{
				try 
				{
                    List<TiposAcceso> l = SqlMapper.Query<TiposAcceso>(con, "API.PA_TiposAccesoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposAcceso  ->" + ex.Message);
				}
			}
			
			public List<TiposAcceso> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposAcceso> l = SqlMapper.Query<TiposAcceso>(con, "API.PA_TiposAccesoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposAcceso  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposAcceso> GetByFilter(TiposAcceso pTiposAcceso, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposAcceso.id== null || pTiposAcceso.id==0) ? vintNUll :pTiposAcceso.id);
                    p.Add("@TipoAccesoId",(pTiposAcceso.TipoAccesoId== null) ? vintNUll :pTiposAcceso.TipoAccesoId);
                    p.Add("@Nombre",(pTiposAcceso.Nombre== null) ? vintNUll :pTiposAcceso.Nombre);
                    p.Add("@Nombre",(pTiposAcceso.Nombre== null) ? vintNUll :pTiposAcceso.Nombre);
                    p.Add("@Valor",(pTiposAcceso.Valor== null) ? vintNUll :pTiposAcceso.Valor);
                    p.Add("@Valor",(pTiposAcceso.Valor== null) ? vintNUll :pTiposAcceso.Valor);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposAcceso> l = SqlMapper.Query<TiposAcceso>(con, "API.PA_TiposAccesoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposAcceso  ->" + ex.Message);
				}
			}

			public TiposAcceso Add(TiposAcceso pTiposAcceso)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposAcceso.id==null ? 0 : pTiposAcceso.id);
p.Add("@TipoAccesoId",pTiposAcceso.TipoAccesoId==null ? 0 : pTiposAcceso.TipoAccesoId);
                    p.Add("@Nombre", pTiposAcceso.Nombre);
                    p.Add("@Nombre", pTiposAcceso.Nombre);
p.Add("@Valor",pTiposAcceso.Valor==null ? 0 : pTiposAcceso.Valor);
p.Add("@Valor",pTiposAcceso.Valor==null ? 0 : pTiposAcceso.Valor);
                    p.Add("@auditoria", pTiposAcceso.auditoria);

                         


                    TiposAcceso o = SqlMapper.QueryFirstOrDefault<TiposAcceso>(con, "API.PA_TiposAccesoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposAcceso  ->" + ex.Message);
				}
			}

			public TiposAcceso  Update(TiposAcceso pTiposAcceso)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposAcceso.id==null ? 0 : pTiposAcceso.id);
p.Add("@TipoAccesoId",pTiposAcceso.TipoAccesoId==null ? 0 : pTiposAcceso.TipoAccesoId);
                    p.Add("@Nombre", pTiposAcceso.Nombre);
                    p.Add("@Nombre", pTiposAcceso.Nombre);
p.Add("@Valor",pTiposAcceso.Valor==null ? 0 : pTiposAcceso.Valor);
p.Add("@Valor",pTiposAcceso.Valor==null ? 0 : pTiposAcceso.Valor);
                    p.Add("@auditoria", pTiposAcceso.auditoria);

                         


                    TiposAcceso o = SqlMapper.QueryFirstOrDefault<TiposAcceso>(con, "API.PA_TiposAccesoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposAcceso  ->" + ex.Message);
				}
			}

			public bool Delete(TiposAcceso pTiposAcceso)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposAcceso.id);
p.Add("@TipoAccesoId",pTiposAcceso.TipoAccesoId);
                    p.Add("@auditoria", pTiposAcceso.auditoria);

                

 

					TiposAcceso o = SqlMapper.QueryFirstOrDefault<TiposAcceso>(con, "API.PA_TiposAccesoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposAcceso  ->" + ex.Message);
				}
			}

		



            public List<TiposAcceso> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposAcceso> TiposAccesoList = new List<TiposAcceso>();

                    TiposAccesoList = SqlMapper.Query<TiposAcceso>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposAccesoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposAcceso  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposAcceso> b)
            {
                DapperPlusManager.Entity<TiposAcceso>().Table("TiposAcceso");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}