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
     /// Clase Abstracta para  PreparacionComplementos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PreparacionComplementosRepository : DataObject , IPreparacionComplementos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PreparacionComplementosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PreparacionComplementosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public PreparacionComplementos GetById(PreparacionComplementos pPreparacionComplementos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pPreparacionComplementos.id);                                    


    				PreparacionComplementos o = SqlMapper.QueryFirstOrDefault<PreparacionComplementos>(con, "API.PA_PreparacionComplementosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  PreparacionComplementos  ->" + ex.Message);
				}
			}

			public List<PreparacionComplementos> GetAll()
			{
				try 
                {
                        List<PreparacionComplementos> l = SqlMapper.Query<PreparacionComplementos>(con, "API.PA_PreparacionComplementosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  PreparacionComplementos  ->" + ex.Message);
				}
			}

			public List<PreparacionComplementos> GetAllFull()
			{
				try 
				{
                    List<PreparacionComplementos> l = SqlMapper.Query<PreparacionComplementos>(con, "API.PA_PreparacionComplementosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  PreparacionComplementos  ->" + ex.Message);
				}
			}
			
			public List<PreparacionComplementos> GetAllByWithRelation()
			{
				try 
                {
                    List<PreparacionComplementos> l = SqlMapper.Query<PreparacionComplementos>(con, "API.PA_PreparacionComplementosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  PreparacionComplementos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<PreparacionComplementos> GetByFilter(PreparacionComplementos pPreparacionComplementos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pPreparacionComplementos.id== null || pPreparacionComplementos.id==0) ? vintNUll :pPreparacionComplementos.id);
                    p.Add("@ID_Preparacion",(pPreparacionComplementos.ID_Preparacion== null || pPreparacionComplementos.ID_Preparacion==0) ? vintNUll :pPreparacionComplementos.ID_Preparacion);
                    p.Add("@ID_TipoComplemento",(pPreparacionComplementos.ID_TipoComplemento== null || pPreparacionComplementos.ID_TipoComplemento==0) ? vintNUll :pPreparacionComplementos.ID_TipoComplemento);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<PreparacionComplementos> l = SqlMapper.Query<PreparacionComplementos>(con, "API.PA_PreparacionComplementosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  PreparacionComplementos  ->" + ex.Message);
				}
			}

			public PreparacionComplementos Add(PreparacionComplementos pPreparacionComplementos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pPreparacionComplementos.id==null ? 0 : pPreparacionComplementos.id);
p.Add("@ID_Preparacion",pPreparacionComplementos.ID_Preparacion==null ? 0 : pPreparacionComplementos.ID_Preparacion);
p.Add("@ID_TipoComplemento",pPreparacionComplementos.ID_TipoComplemento==null ? 0 : pPreparacionComplementos.ID_TipoComplemento);
                    p.Add("@auditoria", pPreparacionComplementos.auditoria);

                         


                    PreparacionComplementos o = SqlMapper.QueryFirstOrDefault<PreparacionComplementos>(con, "API.PA_PreparacionComplementosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  PreparacionComplementos  ->" + ex.Message);
				}
			}

			public PreparacionComplementos  Update(PreparacionComplementos pPreparacionComplementos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pPreparacionComplementos.id==null ? 0 : pPreparacionComplementos.id);
p.Add("@ID_Preparacion",pPreparacionComplementos.ID_Preparacion==null ? 0 : pPreparacionComplementos.ID_Preparacion);
p.Add("@ID_TipoComplemento",pPreparacionComplementos.ID_TipoComplemento==null ? 0 : pPreparacionComplementos.ID_TipoComplemento);
                    p.Add("@auditoria", pPreparacionComplementos.auditoria);

                         


                    PreparacionComplementos o = SqlMapper.QueryFirstOrDefault<PreparacionComplementos>(con, "API.PA_PreparacionComplementosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  PreparacionComplementos  ->" + ex.Message);
				}
			}

			public bool Delete(PreparacionComplementos pPreparacionComplementos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pPreparacionComplementos.id);
                    p.Add("@auditoria", pPreparacionComplementos.auditoria);

                

 

					PreparacionComplementos o = SqlMapper.QueryFirstOrDefault<PreparacionComplementos>(con, "API.PA_PreparacionComplementosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) PreparacionComplementos  ->" + ex.Message);
				}
			}

		



            public List<PreparacionComplementos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<PreparacionComplementos> PreparacionComplementosList = new List<PreparacionComplementos>();

                    PreparacionComplementosList = SqlMapper.Query<PreparacionComplementos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PreparacionComplementosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) PreparacionComplementos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<PreparacionComplementos> b)
            {
                DapperPlusManager.Entity<PreparacionComplementos>().Table("PreparacionComplementos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}