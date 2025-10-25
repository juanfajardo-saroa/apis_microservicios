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
     /// Clase Abstracta para  TiposModalidadMesa
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposModalidadMesaRepository : DataObject , ITiposModalidadMesa 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposModalidadMesaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposModalidadMesaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposModalidadMesa GetById(TiposModalidadMesa pTiposModalidadMesa)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposModalidadMesa.id);                                    


    				TiposModalidadMesa o = SqlMapper.QueryFirstOrDefault<TiposModalidadMesa>(con, "API.PA_TiposModalidadMesaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposModalidadMesa  ->" + ex.Message);
				}
			}

			public List<TiposModalidadMesa> GetAll()
			{
				try 
                {
                        List<TiposModalidadMesa> l = SqlMapper.Query<TiposModalidadMesa>(con, "API.PA_TiposModalidadMesaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposModalidadMesa  ->" + ex.Message);
				}
			}

			public List<TiposModalidadMesa> GetAllFull()
			{
				try 
				{
                    List<TiposModalidadMesa> l = SqlMapper.Query<TiposModalidadMesa>(con, "API.PA_TiposModalidadMesaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposModalidadMesa  ->" + ex.Message);
				}
			}
			
			public List<TiposModalidadMesa> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposModalidadMesa> l = SqlMapper.Query<TiposModalidadMesa>(con, "API.PA_TiposModalidadMesaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposModalidadMesa  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposModalidadMesa> GetByFilter(TiposModalidadMesa pTiposModalidadMesa, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposModalidadMesa.id== null || pTiposModalidadMesa.id==0) ? vintNUll :pTiposModalidadMesa.id);
                    p.Add("@Nombre",(pTiposModalidadMesa.Nombre== null) ? vintNUll :pTiposModalidadMesa.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposModalidadMesa> l = SqlMapper.Query<TiposModalidadMesa>(con, "API.PA_TiposModalidadMesaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposModalidadMesa  ->" + ex.Message);
				}
			}

			public TiposModalidadMesa Add(TiposModalidadMesa pTiposModalidadMesa)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposModalidadMesa.id==null ? 0 : pTiposModalidadMesa.id);
                    p.Add("@Nombre", pTiposModalidadMesa.Nombre);
                    p.Add("@auditoria", pTiposModalidadMesa.auditoria);

                         


                    TiposModalidadMesa o = SqlMapper.QueryFirstOrDefault<TiposModalidadMesa>(con, "API.PA_TiposModalidadMesaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposModalidadMesa  ->" + ex.Message);
				}
			}

			public TiposModalidadMesa  Update(TiposModalidadMesa pTiposModalidadMesa)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposModalidadMesa.id==null ? 0 : pTiposModalidadMesa.id);
                    p.Add("@Nombre", pTiposModalidadMesa.Nombre);
                    p.Add("@auditoria", pTiposModalidadMesa.auditoria);

                         


                    TiposModalidadMesa o = SqlMapper.QueryFirstOrDefault<TiposModalidadMesa>(con, "API.PA_TiposModalidadMesaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposModalidadMesa  ->" + ex.Message);
				}
			}

			public bool Delete(TiposModalidadMesa pTiposModalidadMesa)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposModalidadMesa.id);
                    p.Add("@auditoria", pTiposModalidadMesa.auditoria);

                

 

					TiposModalidadMesa o = SqlMapper.QueryFirstOrDefault<TiposModalidadMesa>(con, "API.PA_TiposModalidadMesaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposModalidadMesa  ->" + ex.Message);
				}
			}

		



            public List<TiposModalidadMesa> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposModalidadMesa> TiposModalidadMesaList = new List<TiposModalidadMesa>();

                    TiposModalidadMesaList = SqlMapper.Query<TiposModalidadMesa>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposModalidadMesaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposModalidadMesa  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposModalidadMesa> b)
            {
                DapperPlusManager.Entity<TiposModalidadMesa>().Table("TiposModalidadMesa");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}