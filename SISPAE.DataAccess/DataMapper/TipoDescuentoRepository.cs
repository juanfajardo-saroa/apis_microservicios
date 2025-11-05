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
     /// Clase Abstracta para  TipoDescuento
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoDescuentoRepository : DataObject , ITipoDescuento 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoDescuentoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoDescuentoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoDescuento GetById(TipoDescuento pTipoDescuento)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoDescuento.id);                                    


    				TipoDescuento o = SqlMapper.QueryFirstOrDefault<TipoDescuento>(con, "API.PA_TipoDescuentoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoDescuento  ->" + ex.Message);
				}
			}

			public List<TipoDescuento> GetAll()
			{
				try 
                {
                        List<TipoDescuento> l = SqlMapper.Query<TipoDescuento>(con, "API.PA_TipoDescuentoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoDescuento  ->" + ex.Message);
				}
			}

			public List<TipoDescuento> GetAllFull()
			{
				try 
				{
                    List<TipoDescuento> l = SqlMapper.Query<TipoDescuento>(con, "API.PA_TipoDescuentoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoDescuento  ->" + ex.Message);
				}
			}
			
			public List<TipoDescuento> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoDescuento> l = SqlMapper.Query<TipoDescuento>(con, "API.PA_TipoDescuentoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoDescuento  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoDescuento> GetByFilter(TipoDescuento pTipoDescuento, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoDescuento.id== null || pTipoDescuento.id==0) ? vintNUll :pTipoDescuento.id);
                    p.Add("@Nombre",(pTipoDescuento.Nombre== null) ? vintNUll :pTipoDescuento.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoDescuento> l = SqlMapper.Query<TipoDescuento>(con, "API.PA_TipoDescuentoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoDescuento  ->" + ex.Message);
				}
			}

			public TipoDescuento Add(TipoDescuento pTipoDescuento)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoDescuento.id==null ? 0 : pTipoDescuento.id);
                    p.Add("@Nombre", pTipoDescuento.Nombre);
                    p.Add("@auditoria", pTipoDescuento.auditoria);

                         


                    TipoDescuento o = SqlMapper.QueryFirstOrDefault<TipoDescuento>(con, "API.PA_TipoDescuentoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoDescuento  ->" + ex.Message);
				}
			}

			public TipoDescuento  Update(TipoDescuento pTipoDescuento)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoDescuento.id==null ? 0 : pTipoDescuento.id);
                    p.Add("@Nombre", pTipoDescuento.Nombre);
                    p.Add("@auditoria", pTipoDescuento.auditoria);

                         


                    TipoDescuento o = SqlMapper.QueryFirstOrDefault<TipoDescuento>(con, "API.PA_TipoDescuentoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoDescuento  ->" + ex.Message);
				}
			}

			public bool Delete(TipoDescuento pTipoDescuento)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoDescuento.id);
                    p.Add("@auditoria", pTipoDescuento.auditoria);

                

 

					TipoDescuento o = SqlMapper.QueryFirstOrDefault<TipoDescuento>(con, "API.PA_TipoDescuentoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoDescuento  ->" + ex.Message);
				}
			}

		



            public List<TipoDescuento> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoDescuento> TipoDescuentoList = new List<TipoDescuento>();

                    TipoDescuentoList = SqlMapper.Query<TipoDescuento>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoDescuentoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoDescuento  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoDescuento> b)
            {
                DapperPlusManager.Entity<TipoDescuento>().Table("TipoDescuento");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}