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
     /// Clase Abstracta para  TipoCategoriasContrato
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TipoCategoriasContratoRepository : DataObject , ITipoCategoriasContrato 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TipoCategoriasContratoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TipoCategoriasContratoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TipoCategoriasContrato GetById(TipoCategoriasContrato pTipoCategoriasContrato)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoCategoriasContrato.id);                                    


    				TipoCategoriasContrato o = SqlMapper.QueryFirstOrDefault<TipoCategoriasContrato>(con, "API.PA_TipoCategoriasContratoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TipoCategoriasContrato  ->" + ex.Message);
				}
			}

			public List<TipoCategoriasContrato> GetAll()
			{
				try 
                {
                        List<TipoCategoriasContrato> l = SqlMapper.Query<TipoCategoriasContrato>(con, "API.PA_TipoCategoriasContratoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TipoCategoriasContrato  ->" + ex.Message);
				}
			}

			public List<TipoCategoriasContrato> GetAllFull()
			{
				try 
				{
                    List<TipoCategoriasContrato> l = SqlMapper.Query<TipoCategoriasContrato>(con, "API.PA_TipoCategoriasContratoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TipoCategoriasContrato  ->" + ex.Message);
				}
			}
			
			public List<TipoCategoriasContrato> GetAllByWithRelation()
			{
				try 
                {
                    List<TipoCategoriasContrato> l = SqlMapper.Query<TipoCategoriasContrato>(con, "API.PA_TipoCategoriasContratoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TipoCategoriasContrato  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TipoCategoriasContrato> GetByFilter(TipoCategoriasContrato pTipoCategoriasContrato, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTipoCategoriasContrato.id== null || pTipoCategoriasContrato.id==0) ? vintNUll :pTipoCategoriasContrato.id);
                    p.Add("@Nombre",(pTipoCategoriasContrato.Nombre== null) ? vintNUll :pTipoCategoriasContrato.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TipoCategoriasContrato> l = SqlMapper.Query<TipoCategoriasContrato>(con, "API.PA_TipoCategoriasContratoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TipoCategoriasContrato  ->" + ex.Message);
				}
			}

			public TipoCategoriasContrato Add(TipoCategoriasContrato pTipoCategoriasContrato)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTipoCategoriasContrato.id==null ? 0 : pTipoCategoriasContrato.id);
                    p.Add("@Nombre", pTipoCategoriasContrato.Nombre);
                    p.Add("@auditoria", pTipoCategoriasContrato.auditoria);

                         


                    TipoCategoriasContrato o = SqlMapper.QueryFirstOrDefault<TipoCategoriasContrato>(con, "API.PA_TipoCategoriasContratoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TipoCategoriasContrato  ->" + ex.Message);
				}
			}

			public TipoCategoriasContrato  Update(TipoCategoriasContrato pTipoCategoriasContrato)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTipoCategoriasContrato.id==null ? 0 : pTipoCategoriasContrato.id);
                    p.Add("@Nombre", pTipoCategoriasContrato.Nombre);
                    p.Add("@auditoria", pTipoCategoriasContrato.auditoria);

                         


                    TipoCategoriasContrato o = SqlMapper.QueryFirstOrDefault<TipoCategoriasContrato>(con, "API.PA_TipoCategoriasContratoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TipoCategoriasContrato  ->" + ex.Message);
				}
			}

			public bool Delete(TipoCategoriasContrato pTipoCategoriasContrato)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTipoCategoriasContrato.id);
                    p.Add("@auditoria", pTipoCategoriasContrato.auditoria);

                

 

					TipoCategoriasContrato o = SqlMapper.QueryFirstOrDefault<TipoCategoriasContrato>(con, "API.PA_TipoCategoriasContratoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TipoCategoriasContrato  ->" + ex.Message);
				}
			}

		



            public List<TipoCategoriasContrato> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TipoCategoriasContrato> TipoCategoriasContratoList = new List<TipoCategoriasContrato>();

                    TipoCategoriasContratoList = SqlMapper.Query<TipoCategoriasContrato>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TipoCategoriasContratoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TipoCategoriasContrato  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TipoCategoriasContrato> b)
            {
                DapperPlusManager.Entity<TipoCategoriasContrato>().Table("TipoCategoriasContrato");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}