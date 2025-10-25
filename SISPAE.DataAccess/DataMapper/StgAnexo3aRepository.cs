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
     /// Clase Abstracta para  StgAnexo3a
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgAnexo3aRepository : DataObject , IStgAnexo3a 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgAnexo3aRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgAnexo3aRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgAnexo3a GetById(StgAnexo3a pStgAnexo3a)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgAnexo3a.id);                                    


    				StgAnexo3a o = SqlMapper.QueryFirstOrDefault<StgAnexo3a>(con, "API.PA_StgAnexo3aGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgAnexo3a  ->" + ex.Message);
				}
			}

			public List<StgAnexo3a> GetAll()
			{
				try 
                {
                        List<StgAnexo3a> l = SqlMapper.Query<StgAnexo3a>(con, "API.PA_StgAnexo3aGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgAnexo3a  ->" + ex.Message);
				}
			}

			public List<StgAnexo3a> GetAllFull()
			{
				try 
				{
                    List<StgAnexo3a> l = SqlMapper.Query<StgAnexo3a>(con, "API.PA_StgAnexo3aGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgAnexo3a  ->" + ex.Message);
				}
			}
			
			public List<StgAnexo3a> GetAllByWithRelation()
			{
				try 
                {
                    List<StgAnexo3a> l = SqlMapper.Query<StgAnexo3a>(con, "API.PA_StgAnexo3aGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgAnexo3a  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgAnexo3a> GetByFilter(StgAnexo3a pStgAnexo3a, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ANNO_INF",(pStgAnexo3a.ANNO_INF== null) ? vintNUll :pStgAnexo3a.ANNO_INF);
                    p.Add("@NRO_DOCUMENTO",(pStgAnexo3a.NRO_DOCUMENTO== null) ? vintNUll :pStgAnexo3a.NRO_DOCUMENTO);
                    p.Add("@TIPO_DOCUMENTO",(pStgAnexo3a.TIPO_DOCUMENTO== null) ? vintNUll :pStgAnexo3a.TIPO_DOCUMENTO);
                    p.Add("@APELLIDO1",(pStgAnexo3a.APELLIDO1== null) ? vintNUll :pStgAnexo3a.APELLIDO1);
                    p.Add("@APELLIDO2",(pStgAnexo3a.APELLIDO2== null) ? vintNUll :pStgAnexo3a.APELLIDO2);
                    p.Add("@NOMBRE1",(pStgAnexo3a.NOMBRE1== null) ? vintNUll :pStgAnexo3a.NOMBRE1);
                    p.Add("@NOMBRE2",(pStgAnexo3a.NOMBRE2== null) ? vintNUll :pStgAnexo3a.NOMBRE2);
                    p.Add("@NOMBRE_CARGO",(pStgAnexo3a.NOMBRE_CARGO== null) ? vintNUll :pStgAnexo3a.NOMBRE_CARGO);
                    p.Add("@EMAIL",(pStgAnexo3a.EMAIL== null) ? vintNUll :pStgAnexo3a.EMAIL);
                    p.Add("@TELEFONO",(pStgAnexo3a.TELEFONO== null) ? vintNUll :pStgAnexo3a.TELEFONO);
                    p.Add("@CODIGO_DANE",(pStgAnexo3a.CODIGO_DANE== null) ? vintNUll :pStgAnexo3a.CODIGO_DANE);
                    p.Add("@CODIGO_DANE_SEDE",(pStgAnexo3a.CODIGO_DANE_SEDE== null) ? vintNUll :pStgAnexo3a.CODIGO_DANE_SEDE);
                    p.Add("@id",(pStgAnexo3a.id== null || pStgAnexo3a.id==0) ? vintNUll :pStgAnexo3a.id);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgAnexo3a> l = SqlMapper.Query<StgAnexo3a>(con, "API.PA_StgAnexo3aGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgAnexo3a  ->" + ex.Message);
				}
			}

			public StgAnexo3a Add(StgAnexo3a pStgAnexo3a)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ANNO_INF",pStgAnexo3a.ANNO_INF==null ? 0 : pStgAnexo3a.ANNO_INF);
                    p.Add("@NRO_DOCUMENTO", pStgAnexo3a.NRO_DOCUMENTO);
p.Add("@TIPO_DOCUMENTO",pStgAnexo3a.TIPO_DOCUMENTO==null ? 0 : pStgAnexo3a.TIPO_DOCUMENTO);
                    p.Add("@APELLIDO1", pStgAnexo3a.APELLIDO1);
                    p.Add("@APELLIDO2", pStgAnexo3a.APELLIDO2);
                    p.Add("@NOMBRE1", pStgAnexo3a.NOMBRE1);
                    p.Add("@NOMBRE2", pStgAnexo3a.NOMBRE2);
p.Add("@NOMBRE_CARGO",pStgAnexo3a.NOMBRE_CARGO==null ? 0 : pStgAnexo3a.NOMBRE_CARGO);
                    p.Add("@EMAIL", pStgAnexo3a.EMAIL);
                    p.Add("@TELEFONO", pStgAnexo3a.TELEFONO);
                    p.Add("@CODIGO_DANE", pStgAnexo3a.CODIGO_DANE);
                    p.Add("@CODIGO_DANE_SEDE", pStgAnexo3a.CODIGO_DANE_SEDE);
p.Add("@id",pStgAnexo3a.id==null ? 0 : pStgAnexo3a.id);
                    p.Add("@auditoria", pStgAnexo3a.auditoria);

                         


                    StgAnexo3a o = SqlMapper.QueryFirstOrDefault<StgAnexo3a>(con, "API.PA_StgAnexo3aAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgAnexo3a  ->" + ex.Message);
				}
			}

			public StgAnexo3a  Update(StgAnexo3a pStgAnexo3a)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ANNO_INF",pStgAnexo3a.ANNO_INF==null ? 0 : pStgAnexo3a.ANNO_INF);
                    p.Add("@NRO_DOCUMENTO", pStgAnexo3a.NRO_DOCUMENTO);
p.Add("@TIPO_DOCUMENTO",pStgAnexo3a.TIPO_DOCUMENTO==null ? 0 : pStgAnexo3a.TIPO_DOCUMENTO);
                    p.Add("@APELLIDO1", pStgAnexo3a.APELLIDO1);
                    p.Add("@APELLIDO2", pStgAnexo3a.APELLIDO2);
                    p.Add("@NOMBRE1", pStgAnexo3a.NOMBRE1);
                    p.Add("@NOMBRE2", pStgAnexo3a.NOMBRE2);
p.Add("@NOMBRE_CARGO",pStgAnexo3a.NOMBRE_CARGO==null ? 0 : pStgAnexo3a.NOMBRE_CARGO);
                    p.Add("@EMAIL", pStgAnexo3a.EMAIL);
                    p.Add("@TELEFONO", pStgAnexo3a.TELEFONO);
                    p.Add("@CODIGO_DANE", pStgAnexo3a.CODIGO_DANE);
                    p.Add("@CODIGO_DANE_SEDE", pStgAnexo3a.CODIGO_DANE_SEDE);
p.Add("@id",pStgAnexo3a.id==null ? 0 : pStgAnexo3a.id);
                    p.Add("@auditoria", pStgAnexo3a.auditoria);

                         


                    StgAnexo3a o = SqlMapper.QueryFirstOrDefault<StgAnexo3a>(con, "API.PA_StgAnexo3aUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgAnexo3a  ->" + ex.Message);
				}
			}

			public bool Delete(StgAnexo3a pStgAnexo3a)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgAnexo3a.id);
                    p.Add("@auditoria", pStgAnexo3a.auditoria);

                

 

					StgAnexo3a o = SqlMapper.QueryFirstOrDefault<StgAnexo3a>(con, "API.PA_StgAnexo3aDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgAnexo3a  ->" + ex.Message);
				}
			}

		



            public List<StgAnexo3a> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgAnexo3a> StgAnexo3aList = new List<StgAnexo3a>();

                    StgAnexo3aList = SqlMapper.Query<StgAnexo3a>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgAnexo3aList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgAnexo3a  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgAnexo3a> b)
            {
                DapperPlusManager.Entity<StgAnexo3a>().Table("StgAnexo3a");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}