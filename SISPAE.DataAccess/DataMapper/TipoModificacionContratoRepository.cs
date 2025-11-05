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
     /// Clase Abstracta para  TipoModificacionContrato
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoModificacionContratoRepository : DataObject , ITipoModificacionContrato 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoModificacionContratoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoModificacionContratoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoModificacionContrato GetById(TipoModificacionContrato pTipoModificacionContrato)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoModificacionContrato.id);                                    


    				TipoModificacionContrato o = SqlMapper.QueryFirstOrDefault<TipoModificacionContrato>(con, "API.PA_TipoModificacionContratoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoModificacionContrato  ->" + ex.Message);
				}
			}

			public List<TipoModificacionContrato> GetAll()
			{
				try 
                {
                        List<TipoModificacionContrato> l = SqlMapper.Query<TipoModificacionContrato>(con, "API.PA_TipoModificacionContratoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoModificacionContrato  ->" + ex.Message);
				}
			}

			public List<TipoModificacionContrato> GetAllFull()
			{
				try 
				{
                    List<TipoModificacionContrato> l = SqlMapper.Query<TipoModificacionContrato>(con, "API.PA_TipoModificacionContratoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoModificacionContrato  ->" + ex.Message);
				}
			}
			
			public List<TipoModificacionContrato> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoModificacionContrato> l = SqlMapper.Query<TipoModificacionContrato>(con, "API.PA_TipoModificacionContratoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoModificacionContrato  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoModificacionContrato> GetByFilter(TipoModificacionContrato pTipoModificacionContrato, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoModificacionContrato.id== null || pTipoModificacionContrato.id==0) ? vintNUll :pTipoModificacionContrato.id);
                    p.Add("@Nombre",(pTipoModificacionContrato.Nombre== null) ? vintNUll :pTipoModificacionContrato.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoModificacionContrato> l = SqlMapper.Query<TipoModificacionContrato>(con, "API.PA_TipoModificacionContratoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoModificacionContrato  ->" + ex.Message);
				}
			}

			public TipoModificacionContrato Add(TipoModificacionContrato pTipoModificacionContrato)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoModificacionContrato.id==null ? 0 : pTipoModificacionContrato.id);
                    p.Add("@Nombre", pTipoModificacionContrato.Nombre);
                    p.Add("@auditoria", pTipoModificacionContrato.auditoria);

                         


                    TipoModificacionContrato o = SqlMapper.QueryFirstOrDefault<TipoModificacionContrato>(con, "API.PA_TipoModificacionContratoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoModificacionContrato  ->" + ex.Message);
				}
			}

			public TipoModificacionContrato  Update(TipoModificacionContrato pTipoModificacionContrato)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoModificacionContrato.id==null ? 0 : pTipoModificacionContrato.id);
                    p.Add("@Nombre", pTipoModificacionContrato.Nombre);
                    p.Add("@auditoria", pTipoModificacionContrato.auditoria);

                         


                    TipoModificacionContrato o = SqlMapper.QueryFirstOrDefault<TipoModificacionContrato>(con, "API.PA_TipoModificacionContratoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoModificacionContrato  ->" + ex.Message);
				}
			}

			public bool Delete(TipoModificacionContrato pTipoModificacionContrato)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoModificacionContrato.id);
                    p.Add("@auditoria", pTipoModificacionContrato.auditoria);

                

 

					TipoModificacionContrato o = SqlMapper.QueryFirstOrDefault<TipoModificacionContrato>(con, "API.PA_TipoModificacionContratoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoModificacionContrato  ->" + ex.Message);
				}
			}

		



            public List<TipoModificacionContrato> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoModificacionContrato> TipoModificacionContratoList = new List<TipoModificacionContrato>();

                    TipoModificacionContratoList = SqlMapper.Query<TipoModificacionContrato>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoModificacionContratoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoModificacionContrato  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoModificacionContrato> b)
            {
                DapperPlusManager.Entity<TipoModificacionContrato>().Table("TipoModificacionContrato");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}