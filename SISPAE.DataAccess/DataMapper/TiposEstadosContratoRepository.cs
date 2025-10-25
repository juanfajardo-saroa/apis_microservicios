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
     /// Clase Abstracta para  TiposEstadosContrato
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposEstadosContratoRepository : DataObject , ITiposEstadosContrato 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposEstadosContratoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposEstadosContratoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposEstadosContrato GetById(TiposEstadosContrato pTiposEstadosContrato)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadosContrato.id);                                    


    				TiposEstadosContrato o = SqlMapper.QueryFirstOrDefault<TiposEstadosContrato>(con, "API.PA_TiposEstadosContratoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposEstadosContrato  ->" + ex.Message);
				}
			}

			public List<TiposEstadosContrato> GetAll()
			{
				try 
                {
                        List<TiposEstadosContrato> l = SqlMapper.Query<TiposEstadosContrato>(con, "API.PA_TiposEstadosContratoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposEstadosContrato  ->" + ex.Message);
				}
			}

			public List<TiposEstadosContrato> GetAllFull()
			{
				try 
				{
                    List<TiposEstadosContrato> l = SqlMapper.Query<TiposEstadosContrato>(con, "API.PA_TiposEstadosContratoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposEstadosContrato  ->" + ex.Message);
				}
			}
			
			public List<TiposEstadosContrato> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposEstadosContrato> l = SqlMapper.Query<TiposEstadosContrato>(con, "API.PA_TiposEstadosContratoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposEstadosContrato  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposEstadosContrato> GetByFilter(TiposEstadosContrato pTiposEstadosContrato, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposEstadosContrato.id== null || pTiposEstadosContrato.id==0) ? vintNUll :pTiposEstadosContrato.id);
                    p.Add("@Nombre",(pTiposEstadosContrato.Nombre== null) ? vintNUll :pTiposEstadosContrato.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposEstadosContrato> l = SqlMapper.Query<TiposEstadosContrato>(con, "API.PA_TiposEstadosContratoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposEstadosContrato  ->" + ex.Message);
				}
			}

			public TiposEstadosContrato Add(TiposEstadosContrato pTiposEstadosContrato)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposEstadosContrato.id==null ? 0 : pTiposEstadosContrato.id);
                    p.Add("@Nombre", pTiposEstadosContrato.Nombre);
                    p.Add("@auditoria", pTiposEstadosContrato.auditoria);

                         


                    TiposEstadosContrato o = SqlMapper.QueryFirstOrDefault<TiposEstadosContrato>(con, "API.PA_TiposEstadosContratoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposEstadosContrato  ->" + ex.Message);
				}
			}

			public TiposEstadosContrato  Update(TiposEstadosContrato pTiposEstadosContrato)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposEstadosContrato.id==null ? 0 : pTiposEstadosContrato.id);
                    p.Add("@Nombre", pTiposEstadosContrato.Nombre);
                    p.Add("@auditoria", pTiposEstadosContrato.auditoria);

                         


                    TiposEstadosContrato o = SqlMapper.QueryFirstOrDefault<TiposEstadosContrato>(con, "API.PA_TiposEstadosContratoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposEstadosContrato  ->" + ex.Message);
				}
			}

			public bool Delete(TiposEstadosContrato pTiposEstadosContrato)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposEstadosContrato.id);
                    p.Add("@auditoria", pTiposEstadosContrato.auditoria);

                

 

					TiposEstadosContrato o = SqlMapper.QueryFirstOrDefault<TiposEstadosContrato>(con, "API.PA_TiposEstadosContratoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposEstadosContrato  ->" + ex.Message);
				}
			}

		



            public List<TiposEstadosContrato> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposEstadosContrato> TiposEstadosContratoList = new List<TiposEstadosContrato>();

                    TiposEstadosContratoList = SqlMapper.Query<TiposEstadosContrato>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposEstadosContratoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposEstadosContrato  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposEstadosContrato> b)
            {
                DapperPlusManager.Entity<TiposEstadosContrato>().Table("TiposEstadosContrato");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}