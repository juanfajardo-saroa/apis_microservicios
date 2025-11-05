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
     /// Clase Abstracta para  DiasPAE
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class DiasPAERepository : DataObject , IDiasPAE 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public DiasPAERepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public DiasPAERepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public DiasPAE GetById(DiasPAE pDiasPAE)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pDiasPAE.id);                                    


    				DiasPAE o = SqlMapper.QueryFirstOrDefault<DiasPAE>(con, "API.PA_DiasPAEGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  DiasPAE  ->" + ex.Message);
				}
			}

			public List<DiasPAE> GetAll()
			{
				try 
                {
                        List<DiasPAE> l = SqlMapper.Query<DiasPAE>(con, "API.PA_DiasPAEGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  DiasPAE  ->" + ex.Message);
				}
			}

			public List<DiasPAE> GetAllFull()
			{
				try 
				{
                    List<DiasPAE> l = SqlMapper.Query<DiasPAE>(con, "API.PA_DiasPAEGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  DiasPAE  ->" + ex.Message);
				}
			}
			
			public List<DiasPAE> GetAllByWithRelation()
			{
				try 
                {
                    List<DiasPAE> l = SqlMapper.Query<DiasPAE>(con, "API.PA_DiasPAEGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  DiasPAE  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<DiasPAE> GetByFilter(DiasPAE pDiasPAE, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pDiasPAE.id== null || pDiasPAE.id==0) ? vintNUll :pDiasPAE.id);
                    p.Add("@ID_ETC",(pDiasPAE.ID_ETC== null || pDiasPAE.ID_ETC==0) ? vintNUll :pDiasPAE.ID_ETC);
                    p.Add("@ID_TipoModeloOperacion",(pDiasPAE.ID_TipoModeloOperacion== null || pDiasPAE.ID_TipoModeloOperacion==0) ? vintNUll :pDiasPAE.ID_TipoModeloOperacion);
                    p.Add("@Fecha",(pDiasPAE.Fecha== null) ? vintNUll :pDiasPAE.Fecha);
                    p.Add("@vigencia",(pDiasPAE.vigencia== null) ? vintNUll :pDiasPAE.vigencia);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<DiasPAE> l = SqlMapper.Query<DiasPAE>(con, "API.PA_DiasPAEGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  DiasPAE  ->" + ex.Message);
				}
			}

			public DiasPAE Add(DiasPAE pDiasPAE)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pDiasPAE.id==null ? 0 : pDiasPAE.id);
p.Add("@ID_ETC",pDiasPAE.ID_ETC==null ? 0 : pDiasPAE.ID_ETC);
p.Add("@ID_TipoModeloOperacion",pDiasPAE.ID_TipoModeloOperacion==null ? 0 : pDiasPAE.ID_TipoModeloOperacion);
                    p.Add("@Fecha", pDiasPAE.Fecha);
p.Add("@vigencia",pDiasPAE.vigencia==null ? 0 : pDiasPAE.vigencia);
                    p.Add("@auditoria", pDiasPAE.auditoria);

                         


                    DiasPAE o = SqlMapper.QueryFirstOrDefault<DiasPAE>(con, "API.PA_DiasPAEAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  DiasPAE  ->" + ex.Message);
				}
			}

			public DiasPAE  Update(DiasPAE pDiasPAE)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pDiasPAE.id==null ? 0 : pDiasPAE.id);
p.Add("@ID_ETC",pDiasPAE.ID_ETC==null ? 0 : pDiasPAE.ID_ETC);
p.Add("@ID_TipoModeloOperacion",pDiasPAE.ID_TipoModeloOperacion==null ? 0 : pDiasPAE.ID_TipoModeloOperacion);
                    p.Add("@Fecha", pDiasPAE.Fecha);
p.Add("@vigencia",pDiasPAE.vigencia==null ? 0 : pDiasPAE.vigencia);
                    p.Add("@auditoria", pDiasPAE.auditoria);

                         


                    DiasPAE o = SqlMapper.QueryFirstOrDefault<DiasPAE>(con, "API.PA_DiasPAEUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  DiasPAE  ->" + ex.Message);
				}
			}

			public bool Delete(DiasPAE pDiasPAE)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pDiasPAE.id);
                    p.Add("@auditoria", pDiasPAE.auditoria);

                

 

					DiasPAE o = SqlMapper.QueryFirstOrDefault<DiasPAE>(con, "API.PA_DiasPAEDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) DiasPAE  ->" + ex.Message);
				}
			}

		



            public List<DiasPAE> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<DiasPAE> DiasPAEList = new List<DiasPAE>();

                    DiasPAEList = SqlMapper.Query<DiasPAE>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return DiasPAEList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) DiasPAE  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<DiasPAE> b)
            {
                DapperPlusManager.Entity<DiasPAE>().Table("DiasPAE");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}