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
     /// Clase Abstracta para  StgMatriculasConsolidado
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgMatriculasConsolidadoRepository : DataObject , IStgMatriculasConsolidado 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgMatriculasConsolidadoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgMatriculasConsolidadoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgMatriculasConsolidado GetById(StgMatriculasConsolidado pStgMatriculasConsolidado)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@ID",pStgMatriculasConsolidado.ID);                                    


    				StgMatriculasConsolidado o = SqlMapper.QueryFirstOrDefault<StgMatriculasConsolidado>(con, "API.PA_StgMatriculasConsolidadoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgMatriculasConsolidado  ->" + ex.Message);
				}
			}

			public List<StgMatriculasConsolidado> GetAll()
			{
				try 
                {
                        List<StgMatriculasConsolidado> l = SqlMapper.Query<StgMatriculasConsolidado>(con, "API.PA_StgMatriculasConsolidadoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgMatriculasConsolidado  ->" + ex.Message);
				}
			}

			public List<StgMatriculasConsolidado> GetAllFull()
			{
				try 
				{
                    List<StgMatriculasConsolidado> l = SqlMapper.Query<StgMatriculasConsolidado>(con, "API.PA_StgMatriculasConsolidadoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgMatriculasConsolidado  ->" + ex.Message);
				}
			}
			
			public List<StgMatriculasConsolidado> GetAllByWithRelation()
			{
				try 
                {
                    List<StgMatriculasConsolidado> l = SqlMapper.Query<StgMatriculasConsolidado>(con, "API.PA_StgMatriculasConsolidadoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgMatriculasConsolidado  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgMatriculasConsolidado> GetByFilter(StgMatriculasConsolidado pStgMatriculasConsolidado, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ID",(pStgMatriculasConsolidado.ID== null || pStgMatriculasConsolidado.ID==0) ? vintNUll :pStgMatriculasConsolidado.ID);
                    p.Add("@NRO_FILA",(pStgMatriculasConsolidado.NRO_FILA== null) ? vintNUll :pStgMatriculasConsolidado.NRO_FILA);
                    p.Add("@ID_ProcesoCargue",(pStgMatriculasConsolidado.ID_ProcesoCargue== null || pStgMatriculasConsolidado.ID_ProcesoCargue==0) ? vintNUll :pStgMatriculasConsolidado.ID_ProcesoCargue);
                    p.Add("@ID_TipoProcesoCargue",(pStgMatriculasConsolidado.ID_TipoProcesoCargue== null || pStgMatriculasConsolidado.ID_TipoProcesoCargue==0) ? vintNUll :pStgMatriculasConsolidado.ID_TipoProcesoCargue);
                    p.Add("@ANNO_INF",(pStgMatriculasConsolidado.ANNO_INF== null) ? vintNUll :pStgMatriculasConsolidado.ANNO_INF);
                    p.Add("@MUN_CODIGO",(pStgMatriculasConsolidado.MUN_CODIGO== null) ? vintNUll :pStgMatriculasConsolidado.MUN_CODIGO);
                    p.Add("@CODIGO_DANE",(pStgMatriculasConsolidado.CODIGO_DANE== null) ? vintNUll :pStgMatriculasConsolidado.CODIGO_DANE);
                    p.Add("@CODIGO_DANE_SEDE",(pStgMatriculasConsolidado.CODIGO_DANE_SEDE== null) ? vintNUll :pStgMatriculasConsolidado.CODIGO_DANE_SEDE);
                    p.Add("@TIPO_DOCUMENTO",(pStgMatriculasConsolidado.TIPO_DOCUMENTO== null) ? vintNUll :pStgMatriculasConsolidado.TIPO_DOCUMENTO);
                    p.Add("@NRO_DOCUMENTO",(pStgMatriculasConsolidado.NRO_DOCUMENTO== null) ? vintNUll :pStgMatriculasConsolidado.NRO_DOCUMENTO);
                    p.Add("@APELLIDO1",(pStgMatriculasConsolidado.APELLIDO1== null) ? vintNUll :pStgMatriculasConsolidado.APELLIDO1);
                    p.Add("@APELLIDO2",(pStgMatriculasConsolidado.APELLIDO2== null) ? vintNUll :pStgMatriculasConsolidado.APELLIDO2);
                    p.Add("@NOMBRE1",(pStgMatriculasConsolidado.NOMBRE1== null) ? vintNUll :pStgMatriculasConsolidado.NOMBRE1);
                    p.Add("@NOMBRE2",(pStgMatriculasConsolidado.NOMBRE2== null) ? vintNUll :pStgMatriculasConsolidado.NOMBRE2);
                    p.Add("@FECHA_NACIMIENTO",(pStgMatriculasConsolidado.FECHA_NACIMIENTO== null) ? vintNUll :pStgMatriculasConsolidado.FECHA_NACIMIENTO);
                    p.Add("@GENERO",(pStgMatriculasConsolidado.GENERO== null) ? vintNUll :pStgMatriculasConsolidado.GENERO);
                    p.Add("@TIPO_JORNADA",(pStgMatriculasConsolidado.TIPO_JORNADA== null) ? vintNUll :pStgMatriculasConsolidado.TIPO_JORNADA);
                    p.Add("@ESPECIALIDAD",(pStgMatriculasConsolidado.ESPECIALIDAD== null) ? vintNUll :pStgMatriculasConsolidado.ESPECIALIDAD);
                    p.Add("@GRADO",(pStgMatriculasConsolidado.GRADO== null) ? vintNUll :pStgMatriculasConsolidado.GRADO);
                    p.Add("@GRUPO",(pStgMatriculasConsolidado.GRUPO== null) ? vintNUll :pStgMatriculasConsolidado.GRUPO);
                    p.Add("@PER_ID",(pStgMatriculasConsolidado.PER_ID== null) ? vintNUll :pStgMatriculasConsolidado.PER_ID);
                    p.Add("@CODIGO_SED",(pStgMatriculasConsolidado.CODIGO_SED== null) ? vintNUll :pStgMatriculasConsolidado.CODIGO_SED);
                    p.Add("@DPTO_CARGA",(pStgMatriculasConsolidado.DPTO_CARGA== null) ? vintNUll :pStgMatriculasConsolidado.DPTO_CARGA);
                    p.Add("@NOMBRE_ESTABLECIMIENTO",(pStgMatriculasConsolidado.NOMBRE_ESTABLECIMIENTO== null) ? vintNUll :pStgMatriculasConsolidado.NOMBRE_ESTABLECIMIENTO);
                    p.Add("@CTE_ID_SECTOR",(pStgMatriculasConsolidado.CTE_ID_SECTOR== null) ? vintNUll :pStgMatriculasConsolidado.CTE_ID_SECTOR);
                    p.Add("@NOMBRE_SEDE",(pStgMatriculasConsolidado.NOMBRE_SEDE== null) ? vintNUll :pStgMatriculasConsolidado.NOMBRE_SEDE);
                    p.Add("@CTE_ID_ZONA",(pStgMatriculasConsolidado.CTE_ID_ZONA== null) ? vintNUll :pStgMatriculasConsolidado.CTE_ID_ZONA);
                    p.Add("@Divipola_MUNICIPIO",(pStgMatriculasConsolidado.Divipola_MUNICIPIO== null) ? vintNUll :pStgMatriculasConsolidado.Divipola_MUNICIPIO);
                    p.Add("@EDAD",(pStgMatriculasConsolidado.EDAD== null) ? vintNUll :pStgMatriculasConsolidado.EDAD);
                    p.Add("@NIV_CONPES",(pStgMatriculasConsolidado.NIV_CONPES== null) ? vintNUll :pStgMatriculasConsolidado.NIV_CONPES);
                    p.Add("@CODIGO_PAIS_ORIGEN",(pStgMatriculasConsolidado.CODIGO_PAIS_ORIGEN== null) ? vintNUll :pStgMatriculasConsolidado.CODIGO_PAIS_ORIGEN);
                    p.Add("@NOMBRE_PAIS_ORIGEN",(pStgMatriculasConsolidado.NOMBRE_PAIS_ORIGEN== null) ? vintNUll :pStgMatriculasConsolidado.NOMBRE_PAIS_ORIGEN);
                    p.Add("@SISBEN",(pStgMatriculasConsolidado.SISBEN== null) ? vintNUll :pStgMatriculasConsolidado.SISBEN);
                    p.Add("@POB_VICT_CONF",(pStgMatriculasConsolidado.POB_VICT_CONF== null) ? vintNUll :pStgMatriculasConsolidado.POB_VICT_CONF);
                    p.Add("@DISCAPACIDAD_HOMOLGADA_2021",(pStgMatriculasConsolidado.DISCAPACIDAD_HOMOLGADA_2021== null) ? vintNUll :pStgMatriculasConsolidado.DISCAPACIDAD_HOMOLGADA_2021);
                    p.Add("@ETNIA",(pStgMatriculasConsolidado.ETNIA== null) ? vintNUll :pStgMatriculasConsolidado.ETNIA);
                    p.Add("@ID_ETC",(pStgMatriculasConsolidado.ID_ETC== null) ? vintNUll :pStgMatriculasConsolidado.ID_ETC);
                    p.Add("@ESTADO_SEDE",(pStgMatriculasConsolidado.ESTADO_SEDE== null) ? vintNUll :pStgMatriculasConsolidado.ESTADO_SEDE);
                    p.Add("@NOMBRE_CARGO",(pStgMatriculasConsolidado.NOMBRE_CARGO== null) ? vintNUll :pStgMatriculasConsolidado.NOMBRE_CARGO);
                    p.Add("@EMAIL",(pStgMatriculasConsolidado.EMAIL== null) ? vintNUll :pStgMatriculasConsolidado.EMAIL);
                    p.Add("@TEL_CELULAR",(pStgMatriculasConsolidado.TEL_CELULAR== null) ? vintNUll :pStgMatriculasConsolidado.TEL_CELULAR);
                    p.Add("@TEL_FIJO",(pStgMatriculasConsolidado.TEL_FIJO== null) ? vintNUll :pStgMatriculasConsolidado.TEL_FIJO);
                    p.Add("@Estatus",(pStgMatriculasConsolidado.Estatus== null) ? vintNUll :pStgMatriculasConsolidado.Estatus);
                    p.Add("@Error",(pStgMatriculasConsolidado.Error== null) ? vintNUll :pStgMatriculasConsolidado.Error);
                    p.Add("@FECHA_VINCULACION",(pStgMatriculasConsolidado.FECHA_VINCULACION== null) ? vintNUll :pStgMatriculasConsolidado.FECHA_VINCULACION);
                    p.Add("@NIVEL_EDUCATIVO_APROBADO",(pStgMatriculasConsolidado.NIVEL_EDUCATIVO_APROBADO== null) ? vintNUll :pStgMatriculasConsolidado.NIVEL_EDUCATIVO_APROBADO);
                    p.Add("@UBICACION",(pStgMatriculasConsolidado.UBICACION== null) ? vintNUll :pStgMatriculasConsolidado.UBICACION);
                    p.Add("@TIPO_VINCULACION",(pStgMatriculasConsolidado.TIPO_VINCULACION== null) ? vintNUll :pStgMatriculasConsolidado.TIPO_VINCULACION);
                    p.Add("@NIVEL_ENSENANZA",(pStgMatriculasConsolidado.NIVEL_ENSENANZA== null) ? vintNUll :pStgMatriculasConsolidado.NIVEL_ENSENANZA);
                    p.Add("@ESTADO_CIVIL",(pStgMatriculasConsolidado.ESTADO_CIVIL== null) ? vintNUll :pStgMatriculasConsolidado.ESTADO_CIVIL);
                    p.Add("@ESTATUTO",(pStgMatriculasConsolidado.ESTATUTO== null) ? vintNUll :pStgMatriculasConsolidado.ESTATUTO);
                    p.Add("@PARENTESCO",(pStgMatriculasConsolidado.PARENTESCO== null) ? vintNUll :pStgMatriculasConsolidado.PARENTESCO);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgMatriculasConsolidado> l = SqlMapper.Query<StgMatriculasConsolidado>(con, "API.PA_StgMatriculasConsolidadoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgMatriculasConsolidado  ->" + ex.Message);
				}
			}

			public StgMatriculasConsolidado Add(StgMatriculasConsolidado pStgMatriculasConsolidado)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ID",pStgMatriculasConsolidado.ID==null ? 0 : pStgMatriculasConsolidado.ID);
p.Add("@NRO_FILA",pStgMatriculasConsolidado.NRO_FILA==null ? 0 : pStgMatriculasConsolidado.NRO_FILA);
p.Add("@ID_ProcesoCargue",pStgMatriculasConsolidado.ID_ProcesoCargue==null ? 0 : pStgMatriculasConsolidado.ID_ProcesoCargue);
p.Add("@ID_TipoProcesoCargue",pStgMatriculasConsolidado.ID_TipoProcesoCargue==null ? 0 : pStgMatriculasConsolidado.ID_TipoProcesoCargue);
                    p.Add("@ANNO_INF", pStgMatriculasConsolidado.ANNO_INF);
                    p.Add("@MUN_CODIGO", pStgMatriculasConsolidado.MUN_CODIGO);
                    p.Add("@CODIGO_DANE", pStgMatriculasConsolidado.CODIGO_DANE);
                    p.Add("@CODIGO_DANE_SEDE", pStgMatriculasConsolidado.CODIGO_DANE_SEDE);
                    p.Add("@TIPO_DOCUMENTO", pStgMatriculasConsolidado.TIPO_DOCUMENTO);
                    p.Add("@NRO_DOCUMENTO", pStgMatriculasConsolidado.NRO_DOCUMENTO);
                    p.Add("@APELLIDO1", pStgMatriculasConsolidado.APELLIDO1);
                    p.Add("@APELLIDO2", pStgMatriculasConsolidado.APELLIDO2);
                    p.Add("@NOMBRE1", pStgMatriculasConsolidado.NOMBRE1);
                    p.Add("@NOMBRE2", pStgMatriculasConsolidado.NOMBRE2);
                    p.Add("@FECHA_NACIMIENTO", pStgMatriculasConsolidado.FECHA_NACIMIENTO);
                    p.Add("@GENERO", pStgMatriculasConsolidado.GENERO);
                    p.Add("@TIPO_JORNADA", pStgMatriculasConsolidado.TIPO_JORNADA);
                    p.Add("@ESPECIALIDAD", pStgMatriculasConsolidado.ESPECIALIDAD);
                    p.Add("@GRADO", pStgMatriculasConsolidado.GRADO);
                    p.Add("@GRUPO", pStgMatriculasConsolidado.GRUPO);
                    p.Add("@PER_ID", pStgMatriculasConsolidado.PER_ID);
                    p.Add("@CODIGO_SED", pStgMatriculasConsolidado.CODIGO_SED);
                    p.Add("@DPTO_CARGA", pStgMatriculasConsolidado.DPTO_CARGA);
                    p.Add("@NOMBRE_ESTABLECIMIENTO", pStgMatriculasConsolidado.NOMBRE_ESTABLECIMIENTO);
                    p.Add("@CTE_ID_SECTOR", pStgMatriculasConsolidado.CTE_ID_SECTOR);
                    p.Add("@NOMBRE_SEDE", pStgMatriculasConsolidado.NOMBRE_SEDE);
                    p.Add("@CTE_ID_ZONA", pStgMatriculasConsolidado.CTE_ID_ZONA);
                    p.Add("@Divipola_MUNICIPIO", pStgMatriculasConsolidado.Divipola_MUNICIPIO);
                    p.Add("@EDAD", pStgMatriculasConsolidado.EDAD);
                    p.Add("@NIV_CONPES", pStgMatriculasConsolidado.NIV_CONPES);
                    p.Add("@CODIGO_PAIS_ORIGEN", pStgMatriculasConsolidado.CODIGO_PAIS_ORIGEN);
                    p.Add("@NOMBRE_PAIS_ORIGEN", pStgMatriculasConsolidado.NOMBRE_PAIS_ORIGEN);
                    p.Add("@SISBEN", pStgMatriculasConsolidado.SISBEN);
                    p.Add("@POB_VICT_CONF", pStgMatriculasConsolidado.POB_VICT_CONF);
                    p.Add("@DISCAPACIDAD_HOMOLGADA_2021", pStgMatriculasConsolidado.DISCAPACIDAD_HOMOLGADA_2021);
                    p.Add("@ETNIA", pStgMatriculasConsolidado.ETNIA);
                    p.Add("@ID_ETC", pStgMatriculasConsolidado.ID_ETC);
                    p.Add("@ESTADO_SEDE", pStgMatriculasConsolidado.ESTADO_SEDE);
                    p.Add("@NOMBRE_CARGO", pStgMatriculasConsolidado.NOMBRE_CARGO);
                    p.Add("@EMAIL", pStgMatriculasConsolidado.EMAIL);
                    p.Add("@TEL_CELULAR", pStgMatriculasConsolidado.TEL_CELULAR);
                    p.Add("@TEL_FIJO", pStgMatriculasConsolidado.TEL_FIJO);
                    p.Add("@Estatus", pStgMatriculasConsolidado.Estatus);
                    p.Add("@Error", pStgMatriculasConsolidado.Error);
                    p.Add("@FECHA_VINCULACION", pStgMatriculasConsolidado.FECHA_VINCULACION);
                    p.Add("@NIVEL_EDUCATIVO_APROBADO", pStgMatriculasConsolidado.NIVEL_EDUCATIVO_APROBADO);
                    p.Add("@UBICACION", pStgMatriculasConsolidado.UBICACION);
                    p.Add("@TIPO_VINCULACION", pStgMatriculasConsolidado.TIPO_VINCULACION);
                    p.Add("@NIVEL_ENSENANZA", pStgMatriculasConsolidado.NIVEL_ENSENANZA);
                    p.Add("@ESTADO_CIVIL", pStgMatriculasConsolidado.ESTADO_CIVIL);
                    p.Add("@ESTATUTO", pStgMatriculasConsolidado.ESTATUTO);
                    p.Add("@PARENTESCO", pStgMatriculasConsolidado.PARENTESCO);
                    p.Add("@auditoria", pStgMatriculasConsolidado.Auditoria);

                         


                    StgMatriculasConsolidado o = SqlMapper.QueryFirstOrDefault<StgMatriculasConsolidado>(con, "API.PA_StgMatriculasConsolidadoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgMatriculasConsolidado  ->" + ex.Message);
				}
			}

			public StgMatriculasConsolidado  Update(StgMatriculasConsolidado pStgMatriculasConsolidado)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ID",pStgMatriculasConsolidado.ID==null ? 0 : pStgMatriculasConsolidado.ID);
p.Add("@NRO_FILA",pStgMatriculasConsolidado.NRO_FILA==null ? 0 : pStgMatriculasConsolidado.NRO_FILA);
p.Add("@ID_ProcesoCargue",pStgMatriculasConsolidado.ID_ProcesoCargue==null ? 0 : pStgMatriculasConsolidado.ID_ProcesoCargue);
p.Add("@ID_TipoProcesoCargue",pStgMatriculasConsolidado.ID_TipoProcesoCargue==null ? 0 : pStgMatriculasConsolidado.ID_TipoProcesoCargue);
                    p.Add("@ANNO_INF", pStgMatriculasConsolidado.ANNO_INF);
                    p.Add("@MUN_CODIGO", pStgMatriculasConsolidado.MUN_CODIGO);
                    p.Add("@CODIGO_DANE", pStgMatriculasConsolidado.CODIGO_DANE);
                    p.Add("@CODIGO_DANE_SEDE", pStgMatriculasConsolidado.CODIGO_DANE_SEDE);
                    p.Add("@TIPO_DOCUMENTO", pStgMatriculasConsolidado.TIPO_DOCUMENTO);
                    p.Add("@NRO_DOCUMENTO", pStgMatriculasConsolidado.NRO_DOCUMENTO);
                    p.Add("@APELLIDO1", pStgMatriculasConsolidado.APELLIDO1);
                    p.Add("@APELLIDO2", pStgMatriculasConsolidado.APELLIDO2);
                    p.Add("@NOMBRE1", pStgMatriculasConsolidado.NOMBRE1);
                    p.Add("@NOMBRE2", pStgMatriculasConsolidado.NOMBRE2);
                    p.Add("@FECHA_NACIMIENTO", pStgMatriculasConsolidado.FECHA_NACIMIENTO);
                    p.Add("@GENERO", pStgMatriculasConsolidado.GENERO);
                    p.Add("@TIPO_JORNADA", pStgMatriculasConsolidado.TIPO_JORNADA);
                    p.Add("@ESPECIALIDAD", pStgMatriculasConsolidado.ESPECIALIDAD);
                    p.Add("@GRADO", pStgMatriculasConsolidado.GRADO);
                    p.Add("@GRUPO", pStgMatriculasConsolidado.GRUPO);
                    p.Add("@PER_ID", pStgMatriculasConsolidado.PER_ID);
                    p.Add("@CODIGO_SED", pStgMatriculasConsolidado.CODIGO_SED);
                    p.Add("@DPTO_CARGA", pStgMatriculasConsolidado.DPTO_CARGA);
                    p.Add("@NOMBRE_ESTABLECIMIENTO", pStgMatriculasConsolidado.NOMBRE_ESTABLECIMIENTO);
                    p.Add("@CTE_ID_SECTOR", pStgMatriculasConsolidado.CTE_ID_SECTOR);
                    p.Add("@NOMBRE_SEDE", pStgMatriculasConsolidado.NOMBRE_SEDE);
                    p.Add("@CTE_ID_ZONA", pStgMatriculasConsolidado.CTE_ID_ZONA);
                    p.Add("@Divipola_MUNICIPIO", pStgMatriculasConsolidado.Divipola_MUNICIPIO);
                    p.Add("@EDAD", pStgMatriculasConsolidado.EDAD);
                    p.Add("@NIV_CONPES", pStgMatriculasConsolidado.NIV_CONPES);
                    p.Add("@CODIGO_PAIS_ORIGEN", pStgMatriculasConsolidado.CODIGO_PAIS_ORIGEN);
                    p.Add("@NOMBRE_PAIS_ORIGEN", pStgMatriculasConsolidado.NOMBRE_PAIS_ORIGEN);
                    p.Add("@SISBEN", pStgMatriculasConsolidado.SISBEN);
                    p.Add("@POB_VICT_CONF", pStgMatriculasConsolidado.POB_VICT_CONF);
                    p.Add("@DISCAPACIDAD_HOMOLGADA_2021", pStgMatriculasConsolidado.DISCAPACIDAD_HOMOLGADA_2021);
                    p.Add("@ETNIA", pStgMatriculasConsolidado.ETNIA);
                    p.Add("@ID_ETC", pStgMatriculasConsolidado.ID_ETC);
                    p.Add("@ESTADO_SEDE", pStgMatriculasConsolidado.ESTADO_SEDE);
                    p.Add("@NOMBRE_CARGO", pStgMatriculasConsolidado.NOMBRE_CARGO);
                    p.Add("@EMAIL", pStgMatriculasConsolidado.EMAIL);
                    p.Add("@TEL_CELULAR", pStgMatriculasConsolidado.TEL_CELULAR);
                    p.Add("@TEL_FIJO", pStgMatriculasConsolidado.TEL_FIJO);
                    p.Add("@Estatus", pStgMatriculasConsolidado.Estatus);
                    p.Add("@Error", pStgMatriculasConsolidado.Error);
                    p.Add("@FECHA_VINCULACION", pStgMatriculasConsolidado.FECHA_VINCULACION);
                    p.Add("@NIVEL_EDUCATIVO_APROBADO", pStgMatriculasConsolidado.NIVEL_EDUCATIVO_APROBADO);
                    p.Add("@UBICACION", pStgMatriculasConsolidado.UBICACION);
                    p.Add("@TIPO_VINCULACION", pStgMatriculasConsolidado.TIPO_VINCULACION);
                    p.Add("@NIVEL_ENSENANZA", pStgMatriculasConsolidado.NIVEL_ENSENANZA);
                    p.Add("@ESTADO_CIVIL", pStgMatriculasConsolidado.ESTADO_CIVIL);
                    p.Add("@ESTATUTO", pStgMatriculasConsolidado.ESTATUTO);
                    p.Add("@PARENTESCO", pStgMatriculasConsolidado.PARENTESCO);
                    p.Add("@auditoria", pStgMatriculasConsolidado.Auditoria);

                         


                    StgMatriculasConsolidado o = SqlMapper.QueryFirstOrDefault<StgMatriculasConsolidado>(con, "API.PA_StgMatriculasConsolidadoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgMatriculasConsolidado  ->" + ex.Message);
				}
			}

			public bool Delete(StgMatriculasConsolidado pStgMatriculasConsolidado)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@ID",pStgMatriculasConsolidado.ID);
                    p.Add("@auditoria", pStgMatriculasConsolidado.Auditoria);

                

 

					StgMatriculasConsolidado o = SqlMapper.QueryFirstOrDefault<StgMatriculasConsolidado>(con, "API.PA_StgMatriculasConsolidadoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgMatriculasConsolidado  ->" + ex.Message);
				}
			}

		



            public List<StgMatriculasConsolidado> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgMatriculasConsolidado> StgMatriculasConsolidadoList = new List<StgMatriculasConsolidado>();

                    StgMatriculasConsolidadoList = SqlMapper.Query<StgMatriculasConsolidado>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgMatriculasConsolidadoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgMatriculasConsolidado  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgMatriculasConsolidado> b)
            {
                DapperPlusManager.Entity<StgMatriculasConsolidado>().Table("StgMatriculasConsolidado");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}