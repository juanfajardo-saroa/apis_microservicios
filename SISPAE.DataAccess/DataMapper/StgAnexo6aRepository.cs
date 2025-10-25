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
     /// Clase Abstracta para  StgAnexo6a
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgAnexo6aRepository : DataObject , IStgAnexo6a 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgAnexo6aRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgAnexo6aRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgAnexo6a GetById(StgAnexo6a pStgAnexo6a)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgAnexo6a.id);                                    


    				StgAnexo6a o = SqlMapper.QueryFirstOrDefault<StgAnexo6a>(con, "API.PA_StgAnexo6aGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgAnexo6a  ->" + ex.Message);
				}
			}

			public List<StgAnexo6a> GetAll()
			{
				try 
                {
                        List<StgAnexo6a> l = SqlMapper.Query<StgAnexo6a>(con, "API.PA_StgAnexo6aGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgAnexo6a  ->" + ex.Message);
				}
			}

			public List<StgAnexo6a> GetAllFull()
			{
				try 
				{
                    List<StgAnexo6a> l = SqlMapper.Query<StgAnexo6a>(con, "API.PA_StgAnexo6aGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgAnexo6a  ->" + ex.Message);
				}
			}
			
			public List<StgAnexo6a> GetAllByWithRelation()
			{
				try 
                {
                    List<StgAnexo6a> l = SqlMapper.Query<StgAnexo6a>(con, "API.PA_StgAnexo6aGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgAnexo6a  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgAnexo6a> GetByFilter(StgAnexo6a pStgAnexo6a, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ANNO_INF",(pStgAnexo6a.ANNO_INF== null) ? vintNUll :pStgAnexo6a.ANNO_INF);
                    p.Add("@PER_ID",(pStgAnexo6a.PER_ID== null) ? vintNUll :pStgAnexo6a.PER_ID);
                    p.Add("@TIPO_DOCUMENTO",(pStgAnexo6a.TIPO_DOCUMENTO== null) ? vintNUll :pStgAnexo6a.TIPO_DOCUMENTO);
                    p.Add("@NRO_DOCUMENTO",(pStgAnexo6a.NRO_DOCUMENTO== null) ? vintNUll :pStgAnexo6a.NRO_DOCUMENTO);
                    p.Add("@APELLIDO1",(pStgAnexo6a.APELLIDO1== null) ? vintNUll :pStgAnexo6a.APELLIDO1);
                    p.Add("@APELLIDO2",(pStgAnexo6a.APELLIDO2== null) ? vintNUll :pStgAnexo6a.APELLIDO2);
                    p.Add("@NOMBRE1",(pStgAnexo6a.NOMBRE1== null) ? vintNUll :pStgAnexo6a.NOMBRE1);
                    p.Add("@NOMBRE2",(pStgAnexo6a.NOMBRE2== null) ? vintNUll :pStgAnexo6a.NOMBRE2);
                    p.Add("@EDAD",(pStgAnexo6a.EDAD== null) ? vintNUll :pStgAnexo6a.EDAD);
                    p.Add("@FECHA_NACIMIENTO",(pStgAnexo6a.FECHA_NACIMIENTO== null) ? vintNUll :pStgAnexo6a.FECHA_NACIMIENTO);
                    p.Add("@NIV_CONPES",(pStgAnexo6a.NIV_CONPES== null) ? vintNUll :pStgAnexo6a.NIV_CONPES);
                    p.Add("@JORNADA",(pStgAnexo6a.JORNADA== null) ? vintNUll :pStgAnexo6a.JORNADA);
                    p.Add("@GRADO",(pStgAnexo6a.GRADO== null) ? vintNUll :pStgAnexo6a.GRADO);
                    p.Add("@ID_ETC",(pStgAnexo6a.ID_ETC== null || pStgAnexo6a.ID_ETC==0) ? vintNUll :pStgAnexo6a.ID_ETC);
                    p.Add("@CODIGO_DANE",(pStgAnexo6a.CODIGO_DANE== null) ? vintNUll :pStgAnexo6a.CODIGO_DANE);
                    p.Add("@NOMBRE_ESTABLECIMIENTO",(pStgAnexo6a.NOMBRE_ESTABLECIMIENTO== null) ? vintNUll :pStgAnexo6a.NOMBRE_ESTABLECIMIENTO);
                    p.Add("@CODIGO_DANE_SEDE",(pStgAnexo6a.CODIGO_DANE_SEDE== null) ? vintNUll :pStgAnexo6a.CODIGO_DANE_SEDE);
                    p.Add("@NOMBRE_SEDE",(pStgAnexo6a.NOMBRE_SEDE== null) ? vintNUll :pStgAnexo6a.NOMBRE_SEDE);
                    p.Add("@ESTADO_SEDE",(pStgAnexo6a.ESTADO_SEDE== null) ? vintNUll :pStgAnexo6a.ESTADO_SEDE);
                    p.Add("@CTE_ID_ZONA",(pStgAnexo6a.CTE_ID_ZONA== null) ? vintNUll :pStgAnexo6a.CTE_ID_ZONA);
                    p.Add("@Divipola_MUNICIPIO",(pStgAnexo6a.Divipola_MUNICIPIO== null) ? vintNUll :pStgAnexo6a.Divipola_MUNICIPIO);
                    p.Add("@POB_VICT_CONF",(pStgAnexo6a.POB_VICT_CONF== null) ? vintNUll :pStgAnexo6a.POB_VICT_CONF);
                    p.Add("@DISCAPACIDAD_HOMOLGADA_2021",(pStgAnexo6a.DISCAPACIDAD_HOMOLGADA_2021== null) ? vintNUll :pStgAnexo6a.DISCAPACIDAD_HOMOLGADA_2021);
                    p.Add("@GRUPO_ETNICO",(pStgAnexo6a.GRUPO_ETNICO== null) ? vintNUll :pStgAnexo6a.GRUPO_ETNICO);
                    p.Add("@SISBEN",(pStgAnexo6a.SISBEN== null) ? vintNUll :pStgAnexo6a.SISBEN);
                    p.Add("@GENERO",(pStgAnexo6a.GENERO== null) ? vintNUll :pStgAnexo6a.GENERO);
                    p.Add("@CODIGO_PAIS_ORIGEN",(pStgAnexo6a.CODIGO_PAIS_ORIGEN== null) ? vintNUll :pStgAnexo6a.CODIGO_PAIS_ORIGEN);
                    p.Add("@NOMBRE_PAIS_ORIGEN",(pStgAnexo6a.NOMBRE_PAIS_ORIGEN== null) ? vintNUll :pStgAnexo6a.NOMBRE_PAIS_ORIGEN);
                    p.Add("@id",(pStgAnexo6a.id== null || pStgAnexo6a.id==0) ? vintNUll :pStgAnexo6a.id);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgAnexo6a> l = SqlMapper.Query<StgAnexo6a>(con, "API.PA_StgAnexo6aGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgAnexo6a  ->" + ex.Message);
				}
			}

			public StgAnexo6a Add(StgAnexo6a pStgAnexo6a)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ANNO_INF",pStgAnexo6a.ANNO_INF==null ? 0 : pStgAnexo6a.ANNO_INF);
p.Add("@PER_ID",pStgAnexo6a.PER_ID==null ? 0 : pStgAnexo6a.PER_ID);
p.Add("@TIPO_DOCUMENTO",pStgAnexo6a.TIPO_DOCUMENTO==null ? 0 : pStgAnexo6a.TIPO_DOCUMENTO);
                    p.Add("@NRO_DOCUMENTO", pStgAnexo6a.NRO_DOCUMENTO);
                    p.Add("@APELLIDO1", pStgAnexo6a.APELLIDO1);
                    p.Add("@APELLIDO2", pStgAnexo6a.APELLIDO2);
                    p.Add("@NOMBRE1", pStgAnexo6a.NOMBRE1);
                    p.Add("@NOMBRE2", pStgAnexo6a.NOMBRE2);
p.Add("@EDAD",pStgAnexo6a.EDAD==null ? 0 : pStgAnexo6a.EDAD);
                    p.Add("@FECHA_NACIMIENTO", pStgAnexo6a.FECHA_NACIMIENTO);
p.Add("@NIV_CONPES",pStgAnexo6a.NIV_CONPES==null ? 0 : pStgAnexo6a.NIV_CONPES);
p.Add("@JORNADA",pStgAnexo6a.JORNADA==null ? 0 : pStgAnexo6a.JORNADA);
p.Add("@GRADO",pStgAnexo6a.GRADO==null ? 0 : pStgAnexo6a.GRADO);
p.Add("@ID_ETC",pStgAnexo6a.ID_ETC==null ? 0 : pStgAnexo6a.ID_ETC);
                    p.Add("@CODIGO_DANE", pStgAnexo6a.CODIGO_DANE);
                    p.Add("@NOMBRE_ESTABLECIMIENTO", pStgAnexo6a.NOMBRE_ESTABLECIMIENTO);
                    p.Add("@CODIGO_DANE_SEDE", pStgAnexo6a.CODIGO_DANE_SEDE);
                    p.Add("@NOMBRE_SEDE", pStgAnexo6a.NOMBRE_SEDE);
p.Add("@ESTADO_SEDE",pStgAnexo6a.ESTADO_SEDE==null ? 0 : pStgAnexo6a.ESTADO_SEDE);
p.Add("@CTE_ID_ZONA",pStgAnexo6a.CTE_ID_ZONA==null ? 0 : pStgAnexo6a.CTE_ID_ZONA);
p.Add("@Divipola_MUNICIPIO",pStgAnexo6a.Divipola_MUNICIPIO==null ? 0 : pStgAnexo6a.Divipola_MUNICIPIO);
p.Add("@POB_VICT_CONF",pStgAnexo6a.POB_VICT_CONF==null ? 0 : pStgAnexo6a.POB_VICT_CONF);
p.Add("@DISCAPACIDAD_HOMOLGADA_2021",pStgAnexo6a.DISCAPACIDAD_HOMOLGADA_2021==null ? 0 : pStgAnexo6a.DISCAPACIDAD_HOMOLGADA_2021);
p.Add("@GRUPO_ETNICO",pStgAnexo6a.GRUPO_ETNICO==null ? 0 : pStgAnexo6a.GRUPO_ETNICO);
p.Add("@SISBEN",pStgAnexo6a.SISBEN==null ? 0 : pStgAnexo6a.SISBEN);
                    p.Add("@GENERO", pStgAnexo6a.GENERO);
p.Add("@CODIGO_PAIS_ORIGEN",pStgAnexo6a.CODIGO_PAIS_ORIGEN==null ? 0 : pStgAnexo6a.CODIGO_PAIS_ORIGEN);
                    p.Add("@NOMBRE_PAIS_ORIGEN", pStgAnexo6a.NOMBRE_PAIS_ORIGEN);
p.Add("@id",pStgAnexo6a.id==null ? 0 : pStgAnexo6a.id);
                    p.Add("@auditoria", pStgAnexo6a.auditoria);

                         


                    StgAnexo6a o = SqlMapper.QueryFirstOrDefault<StgAnexo6a>(con, "API.PA_StgAnexo6aAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgAnexo6a  ->" + ex.Message);
				}
			}

			public StgAnexo6a  Update(StgAnexo6a pStgAnexo6a)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ANNO_INF",pStgAnexo6a.ANNO_INF==null ? 0 : pStgAnexo6a.ANNO_INF);
p.Add("@PER_ID",pStgAnexo6a.PER_ID==null ? 0 : pStgAnexo6a.PER_ID);
p.Add("@TIPO_DOCUMENTO",pStgAnexo6a.TIPO_DOCUMENTO==null ? 0 : pStgAnexo6a.TIPO_DOCUMENTO);
                    p.Add("@NRO_DOCUMENTO", pStgAnexo6a.NRO_DOCUMENTO);
                    p.Add("@APELLIDO1", pStgAnexo6a.APELLIDO1);
                    p.Add("@APELLIDO2", pStgAnexo6a.APELLIDO2);
                    p.Add("@NOMBRE1", pStgAnexo6a.NOMBRE1);
                    p.Add("@NOMBRE2", pStgAnexo6a.NOMBRE2);
p.Add("@EDAD",pStgAnexo6a.EDAD==null ? 0 : pStgAnexo6a.EDAD);
                    p.Add("@FECHA_NACIMIENTO", pStgAnexo6a.FECHA_NACIMIENTO);
p.Add("@NIV_CONPES",pStgAnexo6a.NIV_CONPES==null ? 0 : pStgAnexo6a.NIV_CONPES);
p.Add("@JORNADA",pStgAnexo6a.JORNADA==null ? 0 : pStgAnexo6a.JORNADA);
p.Add("@GRADO",pStgAnexo6a.GRADO==null ? 0 : pStgAnexo6a.GRADO);
p.Add("@ID_ETC",pStgAnexo6a.ID_ETC==null ? 0 : pStgAnexo6a.ID_ETC);
                    p.Add("@CODIGO_DANE", pStgAnexo6a.CODIGO_DANE);
                    p.Add("@NOMBRE_ESTABLECIMIENTO", pStgAnexo6a.NOMBRE_ESTABLECIMIENTO);
                    p.Add("@CODIGO_DANE_SEDE", pStgAnexo6a.CODIGO_DANE_SEDE);
                    p.Add("@NOMBRE_SEDE", pStgAnexo6a.NOMBRE_SEDE);
p.Add("@ESTADO_SEDE",pStgAnexo6a.ESTADO_SEDE==null ? 0 : pStgAnexo6a.ESTADO_SEDE);
p.Add("@CTE_ID_ZONA",pStgAnexo6a.CTE_ID_ZONA==null ? 0 : pStgAnexo6a.CTE_ID_ZONA);
p.Add("@Divipola_MUNICIPIO",pStgAnexo6a.Divipola_MUNICIPIO==null ? 0 : pStgAnexo6a.Divipola_MUNICIPIO);
p.Add("@POB_VICT_CONF",pStgAnexo6a.POB_VICT_CONF==null ? 0 : pStgAnexo6a.POB_VICT_CONF);
p.Add("@DISCAPACIDAD_HOMOLGADA_2021",pStgAnexo6a.DISCAPACIDAD_HOMOLGADA_2021==null ? 0 : pStgAnexo6a.DISCAPACIDAD_HOMOLGADA_2021);
p.Add("@GRUPO_ETNICO",pStgAnexo6a.GRUPO_ETNICO==null ? 0 : pStgAnexo6a.GRUPO_ETNICO);
p.Add("@SISBEN",pStgAnexo6a.SISBEN==null ? 0 : pStgAnexo6a.SISBEN);
                    p.Add("@GENERO", pStgAnexo6a.GENERO);
p.Add("@CODIGO_PAIS_ORIGEN",pStgAnexo6a.CODIGO_PAIS_ORIGEN==null ? 0 : pStgAnexo6a.CODIGO_PAIS_ORIGEN);
                    p.Add("@NOMBRE_PAIS_ORIGEN", pStgAnexo6a.NOMBRE_PAIS_ORIGEN);
p.Add("@id",pStgAnexo6a.id==null ? 0 : pStgAnexo6a.id);
                    p.Add("@auditoria", pStgAnexo6a.auditoria);

                         


                    StgAnexo6a o = SqlMapper.QueryFirstOrDefault<StgAnexo6a>(con, "API.PA_StgAnexo6aUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgAnexo6a  ->" + ex.Message);
				}
			}

			public bool Delete(StgAnexo6a pStgAnexo6a)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgAnexo6a.id);
                    p.Add("@auditoria", pStgAnexo6a.auditoria);

                

 

					StgAnexo6a o = SqlMapper.QueryFirstOrDefault<StgAnexo6a>(con, "API.PA_StgAnexo6aDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgAnexo6a  ->" + ex.Message);
				}
			}

		



            public List<StgAnexo6a> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgAnexo6a> StgAnexo6aList = new List<StgAnexo6a>();

                    StgAnexo6aList = SqlMapper.Query<StgAnexo6a>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgAnexo6aList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgAnexo6a  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgAnexo6a> b)
            {
                DapperPlusManager.Entity<StgAnexo6a>().Table("StgAnexo6a");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}