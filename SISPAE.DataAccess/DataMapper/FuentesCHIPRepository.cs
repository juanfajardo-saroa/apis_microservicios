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
     /// Clase Abstracta para  FuentesCHIP
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class FuentesCHIPRepository : DataObject , IFuentesCHIP 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public FuentesCHIPRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public FuentesCHIPRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public FuentesCHIP GetById(FuentesCHIP pFuentesCHIP)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pFuentesCHIP.id);                                    


    				FuentesCHIP o = SqlMapper.QueryFirstOrDefault<FuentesCHIP>(con, "API.PA_FuentesCHIPGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  FuentesCHIP  ->" + ex.Message);
				}
			}

			public List<FuentesCHIP> GetAll()
			{
				try 
                {
                        List<FuentesCHIP> l = SqlMapper.Query<FuentesCHIP>(con, "API.PA_FuentesCHIPGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  FuentesCHIP  ->" + ex.Message);
				}
			}

			public List<FuentesCHIP> GetAllFull()
			{
				try 
				{
                    List<FuentesCHIP> l = SqlMapper.Query<FuentesCHIP>(con, "API.PA_FuentesCHIPGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  FuentesCHIP  ->" + ex.Message);
				}
			}
			
			public List<FuentesCHIP> GetAllByWithRelation()
			{
				try 
                {
                    List<FuentesCHIP> l = SqlMapper.Query<FuentesCHIP>(con, "API.PA_FuentesCHIPGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  FuentesCHIP  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<FuentesCHIP> GetByFilter(FuentesCHIP pFuentesCHIP, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pFuentesCHIP.id== null || pFuentesCHIP.id==0) ? vintNUll :pFuentesCHIP.id);
                    p.Add("@TipoFuenteSIGEPAE",(pFuentesCHIP.TipoFuenteSIGEPAE== null) ? vintNUll :pFuentesCHIP.TipoFuenteSIGEPAE);
                    p.Add("@NombreCHIP",(pFuentesCHIP.NombreCHIP== null) ? vintNUll :pFuentesCHIP.NombreCHIP);
                    p.Add("@CodigoCHIP",(pFuentesCHIP.CodigoCHIP== null) ? vintNUll :pFuentesCHIP.CodigoCHIP);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<FuentesCHIP> l = SqlMapper.Query<FuentesCHIP>(con, "API.PA_FuentesCHIPGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  FuentesCHIP  ->" + ex.Message);
				}
			}

			public FuentesCHIP Add(FuentesCHIP pFuentesCHIP)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pFuentesCHIP.id==null ? 0 : pFuentesCHIP.id);
                    p.Add("@TipoFuenteSIGEPAE", pFuentesCHIP.TipoFuenteSIGEPAE);
                    p.Add("@NombreCHIP", pFuentesCHIP.NombreCHIP);
                    p.Add("@CodigoCHIP", pFuentesCHIP.CodigoCHIP);
                    p.Add("@auditoria", pFuentesCHIP.auditoria);

                         


                    FuentesCHIP o = SqlMapper.QueryFirstOrDefault<FuentesCHIP>(con, "API.PA_FuentesCHIPAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  FuentesCHIP  ->" + ex.Message);
				}
			}

			public FuentesCHIP  Update(FuentesCHIP pFuentesCHIP)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pFuentesCHIP.id==null ? 0 : pFuentesCHIP.id);
                    p.Add("@TipoFuenteSIGEPAE", pFuentesCHIP.TipoFuenteSIGEPAE);
                    p.Add("@NombreCHIP", pFuentesCHIP.NombreCHIP);
                    p.Add("@CodigoCHIP", pFuentesCHIP.CodigoCHIP);
                    p.Add("@auditoria", pFuentesCHIP.auditoria);

                         


                    FuentesCHIP o = SqlMapper.QueryFirstOrDefault<FuentesCHIP>(con, "API.PA_FuentesCHIPUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  FuentesCHIP  ->" + ex.Message);
				}
			}

			public bool Delete(FuentesCHIP pFuentesCHIP)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pFuentesCHIP.id);
                    p.Add("@auditoria", pFuentesCHIP.auditoria);

                

 

					FuentesCHIP o = SqlMapper.QueryFirstOrDefault<FuentesCHIP>(con, "API.PA_FuentesCHIPDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) FuentesCHIP  ->" + ex.Message);
				}
			}

		



            public List<FuentesCHIP> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<FuentesCHIP> FuentesCHIPList = new List<FuentesCHIP>();

                    FuentesCHIPList = SqlMapper.Query<FuentesCHIP>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return FuentesCHIPList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) FuentesCHIP  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<FuentesCHIP> b)
            {
                DapperPlusManager.Entity<FuentesCHIP>().Table("FuentesCHIP");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}