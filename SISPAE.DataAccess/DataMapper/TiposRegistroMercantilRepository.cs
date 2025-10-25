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
     /// Clase Abstracta para  TiposRegistroMercantil
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposRegistroMercantilRepository : DataObject , ITiposRegistroMercantil 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposRegistroMercantilRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposRegistroMercantilRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TiposRegistroMercantil GetById(TiposRegistroMercantil pTiposRegistroMercantil)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposRegistroMercantil.id);                                    


    				TiposRegistroMercantil o = SqlMapper.QueryFirstOrDefault<TiposRegistroMercantil>(con, "API.PA_TiposRegistroMercantilGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TiposRegistroMercantil  ->" + ex.Message);
				}
			}

			public List<TiposRegistroMercantil> GetAll()
			{
				try 
                {
                        List<TiposRegistroMercantil> l = SqlMapper.Query<TiposRegistroMercantil>(con, "API.PA_TiposRegistroMercantilGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TiposRegistroMercantil  ->" + ex.Message);
				}
			}

			public List<TiposRegistroMercantil> GetAllFull()
			{
				try 
				{
                    List<TiposRegistroMercantil> l = SqlMapper.Query<TiposRegistroMercantil>(con, "API.PA_TiposRegistroMercantilGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TiposRegistroMercantil  ->" + ex.Message);
				}
			}
			
			public List<TiposRegistroMercantil> GetAllByWithRelation()
			{
				try 
                {
                    List<TiposRegistroMercantil> l = SqlMapper.Query<TiposRegistroMercantil>(con, "API.PA_TiposRegistroMercantilGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TiposRegistroMercantil  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TiposRegistroMercantil> GetByFilter(TiposRegistroMercantil pTiposRegistroMercantil, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposRegistroMercantil.id== null || pTiposRegistroMercantil.id==0) ? vintNUll :pTiposRegistroMercantil.id);
                    p.Add("@Nombre",(pTiposRegistroMercantil.Nombre== null) ? vintNUll :pTiposRegistroMercantil.Nombre);
                    p.Add("@CodigoSHIP",(pTiposRegistroMercantil.CodigoSHIP== null) ? vintNUll :pTiposRegistroMercantil.CodigoSHIP);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TiposRegistroMercantil> l = SqlMapper.Query<TiposRegistroMercantil>(con, "API.PA_TiposRegistroMercantilGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TiposRegistroMercantil  ->" + ex.Message);
				}
			}

			public TiposRegistroMercantil Add(TiposRegistroMercantil pTiposRegistroMercantil)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposRegistroMercantil.id==null ? 0 : pTiposRegistroMercantil.id);
                    p.Add("@Nombre", pTiposRegistroMercantil.Nombre);
p.Add("@CodigoSHIP",pTiposRegistroMercantil.CodigoSHIP==null ? 0 : pTiposRegistroMercantil.CodigoSHIP);
                    p.Add("@auditoria", pTiposRegistroMercantil.auditoria);

                         


                    TiposRegistroMercantil o = SqlMapper.QueryFirstOrDefault<TiposRegistroMercantil>(con, "API.PA_TiposRegistroMercantilAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TiposRegistroMercantil  ->" + ex.Message);
				}
			}

			public TiposRegistroMercantil  Update(TiposRegistroMercantil pTiposRegistroMercantil)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposRegistroMercantil.id==null ? 0 : pTiposRegistroMercantil.id);
                    p.Add("@Nombre", pTiposRegistroMercantil.Nombre);
p.Add("@CodigoSHIP",pTiposRegistroMercantil.CodigoSHIP==null ? 0 : pTiposRegistroMercantil.CodigoSHIP);
                    p.Add("@auditoria", pTiposRegistroMercantil.auditoria);

                         


                    TiposRegistroMercantil o = SqlMapper.QueryFirstOrDefault<TiposRegistroMercantil>(con, "API.PA_TiposRegistroMercantilUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TiposRegistroMercantil  ->" + ex.Message);
				}
			}

			public bool Delete(TiposRegistroMercantil pTiposRegistroMercantil)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposRegistroMercantil.id);
                    p.Add("@auditoria", pTiposRegistroMercantil.auditoria);

                

 

					TiposRegistroMercantil o = SqlMapper.QueryFirstOrDefault<TiposRegistroMercantil>(con, "API.PA_TiposRegistroMercantilDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TiposRegistroMercantil  ->" + ex.Message);
				}
			}

		



            public List<TiposRegistroMercantil> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TiposRegistroMercantil> TiposRegistroMercantilList = new List<TiposRegistroMercantil>();

                    TiposRegistroMercantilList = SqlMapper.Query<TiposRegistroMercantil>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposRegistroMercantilList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TiposRegistroMercantil  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TiposRegistroMercantil> b)
            {
                DapperPlusManager.Entity<TiposRegistroMercantil>().Table("TiposRegistroMercantil");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}