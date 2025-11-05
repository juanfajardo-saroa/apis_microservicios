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
     /// Clase Abstracta para  StgAnexoEstructuraFamiliar
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgAnexoEstructuraFamiliarRepository : DataObject , IStgAnexoEstructuraFamiliar 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgAnexoEstructuraFamiliarRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgAnexoEstructuraFamiliarRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgAnexoEstructuraFamiliar GetById(StgAnexoEstructuraFamiliar pStgAnexoEstructuraFamiliar)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgAnexoEstructuraFamiliar.id);                                    


    				StgAnexoEstructuraFamiliar o = SqlMapper.QueryFirstOrDefault<StgAnexoEstructuraFamiliar>(con, "API.PA_StgAnexoEstructuraFamiliarGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgAnexoEstructuraFamiliar  ->" + ex.Message);
				}
			}

			public List<StgAnexoEstructuraFamiliar> GetAll()
			{
				try 
                {
                        List<StgAnexoEstructuraFamiliar> l = SqlMapper.Query<StgAnexoEstructuraFamiliar>(con, "API.PA_StgAnexoEstructuraFamiliarGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgAnexoEstructuraFamiliar  ->" + ex.Message);
				}
			}

			public List<StgAnexoEstructuraFamiliar> GetAllFull()
			{
				try 
				{
                    List<StgAnexoEstructuraFamiliar> l = SqlMapper.Query<StgAnexoEstructuraFamiliar>(con, "API.PA_StgAnexoEstructuraFamiliarGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgAnexoEstructuraFamiliar  ->" + ex.Message);
				}
			}
			
			public List<StgAnexoEstructuraFamiliar> GetAllByWithRelation()
			{
				try 
                {
                    List<StgAnexoEstructuraFamiliar> l = SqlMapper.Query<StgAnexoEstructuraFamiliar>(con, "API.PA_StgAnexoEstructuraFamiliarGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgAnexoEstructuraFamiliar  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgAnexoEstructuraFamiliar> GetByFilter(StgAnexoEstructuraFamiliar pStgAnexoEstructuraFamiliar, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@PER_ID",(pStgAnexoEstructuraFamiliar.PER_ID== null) ? vintNUll :pStgAnexoEstructuraFamiliar.PER_ID);
                    p.Add("@APELLIDO1",(pStgAnexoEstructuraFamiliar.APELLIDO1== null) ? vintNUll :pStgAnexoEstructuraFamiliar.APELLIDO1);
                    p.Add("@APELLIDO2",(pStgAnexoEstructuraFamiliar.APELLIDO2== null) ? vintNUll :pStgAnexoEstructuraFamiliar.APELLIDO2);
                    p.Add("@NOMBRE1",(pStgAnexoEstructuraFamiliar.NOMBRE1== null) ? vintNUll :pStgAnexoEstructuraFamiliar.NOMBRE1);
                    p.Add("@NOMBRE2",(pStgAnexoEstructuraFamiliar.NOMBRE2== null) ? vintNUll :pStgAnexoEstructuraFamiliar.NOMBRE2);
                    p.Add("@TIPO_DOCUMENTO",(pStgAnexoEstructuraFamiliar.TIPO_DOCUMENTO== null) ? vintNUll :pStgAnexoEstructuraFamiliar.TIPO_DOCUMENTO);
                    p.Add("@NRO_DOCUMENTO",(pStgAnexoEstructuraFamiliar.NRO_DOCUMENTO== null) ? vintNUll :pStgAnexoEstructuraFamiliar.NRO_DOCUMENTO);
                    p.Add("@PARENTESCO",(pStgAnexoEstructuraFamiliar.PARENTESCO== null) ? vintNUll :pStgAnexoEstructuraFamiliar.PARENTESCO);
                    p.Add("@CORREO",(pStgAnexoEstructuraFamiliar.CORREO== null) ? vintNUll :pStgAnexoEstructuraFamiliar.CORREO);
                    p.Add("@TELEFONO",(pStgAnexoEstructuraFamiliar.TELEFONO== null) ? vintNUll :pStgAnexoEstructuraFamiliar.TELEFONO);
                    p.Add("@CODIGO_DANE",(pStgAnexoEstructuraFamiliar.CODIGO_DANE== null) ? vintNUll :pStgAnexoEstructuraFamiliar.CODIGO_DANE);
                    p.Add("@CODIGO_DANE_SEDE",(pStgAnexoEstructuraFamiliar.CODIGO_DANE_SEDE== null) ? vintNUll :pStgAnexoEstructuraFamiliar.CODIGO_DANE_SEDE);
                    p.Add("@id",(pStgAnexoEstructuraFamiliar.id== null || pStgAnexoEstructuraFamiliar.id==0) ? vintNUll :pStgAnexoEstructuraFamiliar.id);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgAnexoEstructuraFamiliar> l = SqlMapper.Query<StgAnexoEstructuraFamiliar>(con, "API.PA_StgAnexoEstructuraFamiliarGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgAnexoEstructuraFamiliar  ->" + ex.Message);
				}
			}

			public StgAnexoEstructuraFamiliar Add(StgAnexoEstructuraFamiliar pStgAnexoEstructuraFamiliar)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@PER_ID",pStgAnexoEstructuraFamiliar.PER_ID==null ? 0 : pStgAnexoEstructuraFamiliar.PER_ID);
                    p.Add("@APELLIDO1", pStgAnexoEstructuraFamiliar.APELLIDO1);
                    p.Add("@APELLIDO2", pStgAnexoEstructuraFamiliar.APELLIDO2);
                    p.Add("@NOMBRE1", pStgAnexoEstructuraFamiliar.NOMBRE1);
                    p.Add("@NOMBRE2", pStgAnexoEstructuraFamiliar.NOMBRE2);
p.Add("@TIPO_DOCUMENTO",pStgAnexoEstructuraFamiliar.TIPO_DOCUMENTO==null ? 0 : pStgAnexoEstructuraFamiliar.TIPO_DOCUMENTO);
                    p.Add("@NRO_DOCUMENTO", pStgAnexoEstructuraFamiliar.NRO_DOCUMENTO);
                    p.Add("@PARENTESCO", pStgAnexoEstructuraFamiliar.PARENTESCO);
                    p.Add("@CORREO", pStgAnexoEstructuraFamiliar.CORREO);
                    p.Add("@TELEFONO", pStgAnexoEstructuraFamiliar.TELEFONO);
                    p.Add("@CODIGO_DANE", pStgAnexoEstructuraFamiliar.CODIGO_DANE);
                    p.Add("@CODIGO_DANE_SEDE", pStgAnexoEstructuraFamiliar.CODIGO_DANE_SEDE);
p.Add("@id",pStgAnexoEstructuraFamiliar.id==null ? 0 : pStgAnexoEstructuraFamiliar.id);
                    p.Add("@auditoria", pStgAnexoEstructuraFamiliar.auditoria);

                         


                    StgAnexoEstructuraFamiliar o = SqlMapper.QueryFirstOrDefault<StgAnexoEstructuraFamiliar>(con, "API.PA_StgAnexoEstructuraFamiliarAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgAnexoEstructuraFamiliar  ->" + ex.Message);
				}
			}

			public StgAnexoEstructuraFamiliar  Update(StgAnexoEstructuraFamiliar pStgAnexoEstructuraFamiliar)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@PER_ID",pStgAnexoEstructuraFamiliar.PER_ID==null ? 0 : pStgAnexoEstructuraFamiliar.PER_ID);
                    p.Add("@APELLIDO1", pStgAnexoEstructuraFamiliar.APELLIDO1);
                    p.Add("@APELLIDO2", pStgAnexoEstructuraFamiliar.APELLIDO2);
                    p.Add("@NOMBRE1", pStgAnexoEstructuraFamiliar.NOMBRE1);
                    p.Add("@NOMBRE2", pStgAnexoEstructuraFamiliar.NOMBRE2);
p.Add("@TIPO_DOCUMENTO",pStgAnexoEstructuraFamiliar.TIPO_DOCUMENTO==null ? 0 : pStgAnexoEstructuraFamiliar.TIPO_DOCUMENTO);
                    p.Add("@NRO_DOCUMENTO", pStgAnexoEstructuraFamiliar.NRO_DOCUMENTO);
                    p.Add("@PARENTESCO", pStgAnexoEstructuraFamiliar.PARENTESCO);
                    p.Add("@CORREO", pStgAnexoEstructuraFamiliar.CORREO);
                    p.Add("@TELEFONO", pStgAnexoEstructuraFamiliar.TELEFONO);
                    p.Add("@CODIGO_DANE", pStgAnexoEstructuraFamiliar.CODIGO_DANE);
                    p.Add("@CODIGO_DANE_SEDE", pStgAnexoEstructuraFamiliar.CODIGO_DANE_SEDE);
p.Add("@id",pStgAnexoEstructuraFamiliar.id==null ? 0 : pStgAnexoEstructuraFamiliar.id);
                    p.Add("@auditoria", pStgAnexoEstructuraFamiliar.auditoria);

                         


                    StgAnexoEstructuraFamiliar o = SqlMapper.QueryFirstOrDefault<StgAnexoEstructuraFamiliar>(con, "API.PA_StgAnexoEstructuraFamiliarUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgAnexoEstructuraFamiliar  ->" + ex.Message);
				}
			}

			public bool Delete(StgAnexoEstructuraFamiliar pStgAnexoEstructuraFamiliar)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgAnexoEstructuraFamiliar.id);
                    p.Add("@auditoria", pStgAnexoEstructuraFamiliar.auditoria);

                

 

					StgAnexoEstructuraFamiliar o = SqlMapper.QueryFirstOrDefault<StgAnexoEstructuraFamiliar>(con, "API.PA_StgAnexoEstructuraFamiliarDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgAnexoEstructuraFamiliar  ->" + ex.Message);
				}
			}

		



            public List<StgAnexoEstructuraFamiliar> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgAnexoEstructuraFamiliar> StgAnexoEstructuraFamiliarList = new List<StgAnexoEstructuraFamiliar>();

                    StgAnexoEstructuraFamiliarList = SqlMapper.Query<StgAnexoEstructuraFamiliar>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgAnexoEstructuraFamiliarList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgAnexoEstructuraFamiliar  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgAnexoEstructuraFamiliar> b)
            {
                DapperPlusManager.Entity<StgAnexoEstructuraFamiliar>().Table("StgAnexoEstructuraFamiliar");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}