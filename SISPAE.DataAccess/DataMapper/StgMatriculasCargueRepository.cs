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
     /// Clase Abstracta para  StgMatriculasCargue
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class StgMatriculasCargueRepository : DataObject , IStgMatriculasCargue 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public StgMatriculasCargueRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public StgMatriculasCargueRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public StgMatriculasCargue GetById(StgMatriculasCargue pStgMatriculasCargue)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgMatriculasCargue.id);                                    


    				StgMatriculasCargue o = SqlMapper.QueryFirstOrDefault<StgMatriculasCargue>(con, "API.PA_StgMatriculasCargueGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  StgMatriculasCargue  ->" + ex.Message);
				}
			}

			public List<StgMatriculasCargue> GetAll()
			{
				try 
                {
                        List<StgMatriculasCargue> l = SqlMapper.Query<StgMatriculasCargue>(con, "API.PA_StgMatriculasCargueGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  StgMatriculasCargue  ->" + ex.Message);
				}
			}

			public List<StgMatriculasCargue> GetAllFull()
			{
				try 
				{
                    List<StgMatriculasCargue> l = SqlMapper.Query<StgMatriculasCargue>(con, "API.PA_StgMatriculasCargueGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  StgMatriculasCargue  ->" + ex.Message);
				}
			}
			
			public List<StgMatriculasCargue> GetAllByWithRelation()
			{
				try 
                {
                    List<StgMatriculasCargue> l = SqlMapper.Query<StgMatriculasCargue>(con, "API.PA_StgMatriculasCargueGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  StgMatriculasCargue  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<StgMatriculasCargue> GetByFilter(StgMatriculasCargue pStgMatriculasCargue, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ANO_INF",(pStgMatriculasCargue.ANO_INF== null) ? vintNUll :pStgMatriculasCargue.ANO_INF);
                    p.Add("@MUN_CODIGO",(pStgMatriculasCargue.MUN_CODIGO== null) ? vintNUll :pStgMatriculasCargue.MUN_CODIGO);
                    p.Add("@CODIGO_DANE",(pStgMatriculasCargue.CODIGO_DANE== null) ? vintNUll :pStgMatriculasCargue.CODIGO_DANE);
                    p.Add("@CODIGO_DANE_SEDE",(pStgMatriculasCargue.CODIGO_DANE_SEDE== null) ? vintNUll :pStgMatriculasCargue.CODIGO_DANE_SEDE);
                    p.Add("@CONS_SEDE",(pStgMatriculasCargue.CONS_SEDE== null) ? vintNUll :pStgMatriculasCargue.CONS_SEDE);
                    p.Add("@TIPO_DOCUMENTO",(pStgMatriculasCargue.TIPO_DOCUMENTO== null) ? vintNUll :pStgMatriculasCargue.TIPO_DOCUMENTO);
                    p.Add("@NRO_DOCUMENTO",(pStgMatriculasCargue.NRO_DOCUMENTO== null) ? vintNUll :pStgMatriculasCargue.NRO_DOCUMENTO);
                    p.Add("@EXP_DEPTO",(pStgMatriculasCargue.EXP_DEPTO== null) ? vintNUll :pStgMatriculasCargue.EXP_DEPTO);
                    p.Add("@EXP_MUN",(pStgMatriculasCargue.EXP_MUN== null) ? vintNUll :pStgMatriculasCargue.EXP_MUN);
                    p.Add("@APELLIDO1",(pStgMatriculasCargue.APELLIDO1== null) ? vintNUll :pStgMatriculasCargue.APELLIDO1);
                    p.Add("@APELLIDO2",(pStgMatriculasCargue.APELLIDO2== null) ? vintNUll :pStgMatriculasCargue.APELLIDO2);
                    p.Add("@NOMBRE1",(pStgMatriculasCargue.NOMBRE1== null) ? vintNUll :pStgMatriculasCargue.NOMBRE1);
                    p.Add("@NOMBRE2",(pStgMatriculasCargue.NOMBRE2== null) ? vintNUll :pStgMatriculasCargue.NOMBRE2);
                    p.Add("@DIRECCION_RESIDENCIA",(pStgMatriculasCargue.DIRECCION_RESIDENCIA== null) ? vintNUll :pStgMatriculasCargue.DIRECCION_RESIDENCIA);
                    p.Add("@TEL",(pStgMatriculasCargue.TEL== null) ? vintNUll :pStgMatriculasCargue.TEL);
                    p.Add("@RES_DEPTO",(pStgMatriculasCargue.RES_DEPTO== null) ? vintNUll :pStgMatriculasCargue.RES_DEPTO);
                    p.Add("@RES_MUN",(pStgMatriculasCargue.RES_MUN== null) ? vintNUll :pStgMatriculasCargue.RES_MUN);
                    p.Add("@ESTRATO",(pStgMatriculasCargue.ESTRATO== null) ? vintNUll :pStgMatriculasCargue.ESTRATO);
                    p.Add("@SISBEN",(pStgMatriculasCargue.SISBEN== null) ? vintNUll :pStgMatriculasCargue.SISBEN);
                    p.Add("@FECHA_NACIMIENTO",(pStgMatriculasCargue.FECHA_NACIMIENTO== null) ? vintNUll :pStgMatriculasCargue.FECHA_NACIMIENTO);
                    p.Add("@NAC_DEPTO",(pStgMatriculasCargue.NAC_DEPTO== null) ? vintNUll :pStgMatriculasCargue.NAC_DEPTO);
                    p.Add("@NAC_MUN",(pStgMatriculasCargue.NAC_MUN== null) ? vintNUll :pStgMatriculasCargue.NAC_MUN);
                    p.Add("@GENERO",(pStgMatriculasCargue.GENERO== null) ? vintNUll :pStgMatriculasCargue.GENERO);
                    p.Add("@POB_VICT_CONF",(pStgMatriculasCargue.POB_VICT_CONF== null) ? vintNUll :pStgMatriculasCargue.POB_VICT_CONF);
                    p.Add("@DPTO_EXP",(pStgMatriculasCargue.DPTO_EXP== null) ? vintNUll :pStgMatriculasCargue.DPTO_EXP);
                    p.Add("@MUN_EXP",(pStgMatriculasCargue.MUN_EXP== null) ? vintNUll :pStgMatriculasCargue.MUN_EXP);
                    p.Add("@PROVIENE_SECTOR_PRIV",(pStgMatriculasCargue.PROVIENE_SECTOR_PRIV== null) ? vintNUll :pStgMatriculasCargue.PROVIENE_SECTOR_PRIV);
                    p.Add("@PROVIENE_OTRO_MUN",(pStgMatriculasCargue.PROVIENE_OTRO_MUN== null) ? vintNUll :pStgMatriculasCargue.PROVIENE_OTRO_MUN);
                    p.Add("@TIPO_DISCAPACIDAD",(pStgMatriculasCargue.TIPO_DISCAPACIDAD== null) ? vintNUll :pStgMatriculasCargue.TIPO_DISCAPACIDAD);
                    p.Add("@CAP_EXC",(pStgMatriculasCargue.CAP_EXC== null) ? vintNUll :pStgMatriculasCargue.CAP_EXC);
                    p.Add("@ETNIA",(pStgMatriculasCargue.ETNIA== null) ? vintNUll :pStgMatriculasCargue.ETNIA);
                    p.Add("@RES",(pStgMatriculasCargue.RES== null) ? vintNUll :pStgMatriculasCargue.RES);
                    p.Add("@INS_FAMILIAR",(pStgMatriculasCargue.INS_FAMILIAR== null) ? vintNUll :pStgMatriculasCargue.INS_FAMILIAR);
                    p.Add("@TIPO_JORNADA",(pStgMatriculasCargue.TIPO_JORNADA== null) ? vintNUll :pStgMatriculasCargue.TIPO_JORNADA);
                    p.Add("@CARACTER",(pStgMatriculasCargue.CARACTER== null) ? vintNUll :pStgMatriculasCargue.CARACTER);
                    p.Add("@ESPECIALIDAD",(pStgMatriculasCargue.ESPECIALIDAD== null) ? vintNUll :pStgMatriculasCargue.ESPECIALIDAD);
                    p.Add("@GRADO",(pStgMatriculasCargue.GRADO== null) ? vintNUll :pStgMatriculasCargue.GRADO);
                    p.Add("@GRUPO",(pStgMatriculasCargue.GRUPO== null) ? vintNUll :pStgMatriculasCargue.GRUPO);
                    p.Add("@METODOLOGIA",(pStgMatriculasCargue.METODOLOGIA== null) ? vintNUll :pStgMatriculasCargue.METODOLOGIA);
                    p.Add("@SUBSIDIADO",(pStgMatriculasCargue.SUBSIDIADO== null) ? vintNUll :pStgMatriculasCargue.SUBSIDIADO);
                    p.Add("@REPITENTE",(pStgMatriculasCargue.REPITENTE== null) ? vintNUll :pStgMatriculasCargue.REPITENTE);
                    p.Add("@NUEVO",(pStgMatriculasCargue.NUEVO== null) ? vintNUll :pStgMatriculasCargue.NUEVO);
                    p.Add("@SIT_ACAD_ANO_ANT",(pStgMatriculasCargue.SIT_ACAD_ANO_ANT== null) ? vintNUll :pStgMatriculasCargue.SIT_ACAD_ANO_ANT);
                    p.Add("@CON_ALUM_ANO_ANT",(pStgMatriculasCargue.CON_ALUM_ANO_ANT== null) ? vintNUll :pStgMatriculasCargue.CON_ALUM_ANO_ANT);
                    p.Add("@FUE_RECU",(pStgMatriculasCargue.FUE_RECU== null) ? vintNUll :pStgMatriculasCargue.FUE_RECU);
                    p.Add("@ZON_ALU",(pStgMatriculasCargue.ZON_ALU== null) ? vintNUll :pStgMatriculasCargue.ZON_ALU);
                    p.Add("@CAB_FAMILIA",(pStgMatriculasCargue.CAB_FAMILIA== null) ? vintNUll :pStgMatriculasCargue.CAB_FAMILIA);
                    p.Add("@BEN_MAD_FLIA",(pStgMatriculasCargue.BEN_MAD_FLIA== null) ? vintNUll :pStgMatriculasCargue.BEN_MAD_FLIA);
                    p.Add("@BEN_VET_FP",(pStgMatriculasCargue.BEN_VET_FP== null) ? vintNUll :pStgMatriculasCargue.BEN_VET_FP);
                    p.Add("@BEN_HER_NAC",(pStgMatriculasCargue.BEN_HER_NAC== null) ? vintNUll :pStgMatriculasCargue.BEN_HER_NAC);
                    p.Add("@INTERNADO",(pStgMatriculasCargue.INTERNADO== null) ? vintNUll :pStgMatriculasCargue.INTERNADO);
                    p.Add("@VAL_DES_PERIODO1",(pStgMatriculasCargue.VAL_DES_PERIODO1== null) ? vintNUll :pStgMatriculasCargue.VAL_DES_PERIODO1);
                    p.Add("@VAL_DES_PERIODO2",(pStgMatriculasCargue.VAL_DES_PERIODO2== null) ? vintNUll :pStgMatriculasCargue.VAL_DES_PERIODO2);
                    p.Add("@NUM_CONVENIO",(pStgMatriculasCargue.NUM_CONVENIO== null) ? vintNUll :pStgMatriculasCargue.NUM_CONVENIO);
                    p.Add("@NOMBRE_CONTRATIST",(pStgMatriculasCargue.NOMBRE_CONTRATIST== null) ? vintNUll :pStgMatriculasCargue.NOMBRE_CONTRATIST);
                    p.Add("@CTE_MOD_CONTRATO",(pStgMatriculasCargue.CTE_MOD_CONTRATO== null) ? vintNUll :pStgMatriculasCargue.CTE_MOD_CONTRATO);
                    p.Add("@CTE_TIPO_DOCENTE",(pStgMatriculasCargue.CTE_TIPO_DOCENTE== null) ? vintNUll :pStgMatriculasCargue.CTE_TIPO_DOCENTE);
                    p.Add("@PAIS_ORIGEN",(pStgMatriculasCargue.PAIS_ORIGEN== null) ? vintNUll :pStgMatriculasCargue.PAIS_ORIGEN);
                    p.Add("@id",(pStgMatriculasCargue.id== null || pStgMatriculasCargue.id==0) ? vintNUll :pStgMatriculasCargue.id);
                    p.Add("@sector",(pStgMatriculasCargue.sector== null) ? vintNUll :pStgMatriculasCargue.sector);
                    p.Add("@calendario",(pStgMatriculasCargue.calendario== null) ? vintNUll :pStgMatriculasCargue.calendario);
                    p.Add("@id_Encabezado",(pStgMatriculasCargue.id_Encabezado== null || pStgMatriculasCargue.id_Encabezado==0) ? vintNUll :pStgMatriculasCargue.id_Encabezado);
                    p.Add("@Estatus",(pStgMatriculasCargue.Estatus== null) ? vintNUll :pStgMatriculasCargue.Estatus);
                    p.Add("@Error",(pStgMatriculasCargue.Error== null) ? vintNUll :pStgMatriculasCargue.Error);
                    p.Add("@TipoAnexo",(pStgMatriculasCargue.TipoAnexo== null) ? vintNUll :pStgMatriculasCargue.TipoAnexo);
                    p.Add("@NOMBRE_ESTABLECIMIENTO",(pStgMatriculasCargue.NOMBRE_ESTABLECIMIENTO== null) ? vintNUll :pStgMatriculasCargue.NOMBRE_ESTABLECIMIENTO);
                    p.Add("@NOMBRE_SEDE",(pStgMatriculasCargue.NOMBRE_SEDE== null) ? vintNUll :pStgMatriculasCargue.NOMBRE_SEDE);
                    p.Add("@CTE_ID_ZONA",(pStgMatriculasCargue.CTE_ID_ZONA== null) ? vintNUll :pStgMatriculasCargue.CTE_ID_ZONA);
                    p.Add("@PER_ID",(pStgMatriculasCargue.PER_ID== null) ? vintNUll :pStgMatriculasCargue.PER_ID);
                    p.Add("@Edad",(pStgMatriculasCargue.Edad== null) ? vintNUll :pStgMatriculasCargue.Edad);
                    p.Add("@NIV_CONPES",(pStgMatriculasCargue.NIV_CONPES== null) ? vintNUll :pStgMatriculasCargue.NIV_CONPES);
                    p.Add("@DISCAPACIDAD_HOMOLGADA_",(pStgMatriculasCargue.DISCAPACIDAD_HOMOLGADA_== null) ? vintNUll :pStgMatriculasCargue.DISCAPACIDAD_HOMOLGADA_);
                    p.Add("@CORREO",(pStgMatriculasCargue.CORREO== null) ? vintNUll :pStgMatriculasCargue.CORREO);
                    p.Add("@NOMBRE_CARGO",(pStgMatriculasCargue.NOMBRE_CARGO== null) ? vintNUll :pStgMatriculasCargue.NOMBRE_CARGO);
                    p.Add("@FechaCarga",(pStgMatriculasCargue.FechaCarga== null) ? vintNUll :pStgMatriculasCargue.FechaCarga);
                    p.Add("@id_cargue",(pStgMatriculasCargue.id_cargue== null || pStgMatriculasCargue.id_cargue==0) ? vintNUll :pStgMatriculasCargue.id_cargue);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<StgMatriculasCargue> l = SqlMapper.Query<StgMatriculasCargue>(con, "API.PA_StgMatriculasCargueGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  StgMatriculasCargue  ->" + ex.Message);
				}
			}

			public StgMatriculasCargue Add(StgMatriculasCargue pStgMatriculasCargue)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					                    p.Add("@ANO_INF", pStgMatriculasCargue.ANO_INF);
                    p.Add("@MUN_CODIGO", pStgMatriculasCargue.MUN_CODIGO);
                    p.Add("@CODIGO_DANE", pStgMatriculasCargue.CODIGO_DANE);
                    p.Add("@CODIGO_DANE_SEDE", pStgMatriculasCargue.CODIGO_DANE_SEDE);
                    p.Add("@CONS_SEDE", pStgMatriculasCargue.CONS_SEDE);
                    p.Add("@TIPO_DOCUMENTO", pStgMatriculasCargue.TIPO_DOCUMENTO);
                    p.Add("@NRO_DOCUMENTO", pStgMatriculasCargue.NRO_DOCUMENTO);
                    p.Add("@EXP_DEPTO", pStgMatriculasCargue.EXP_DEPTO);
                    p.Add("@EXP_MUN", pStgMatriculasCargue.EXP_MUN);
                    p.Add("@APELLIDO1", pStgMatriculasCargue.APELLIDO1);
                    p.Add("@APELLIDO2", pStgMatriculasCargue.APELLIDO2);
                    p.Add("@NOMBRE1", pStgMatriculasCargue.NOMBRE1);
                    p.Add("@NOMBRE2", pStgMatriculasCargue.NOMBRE2);
                    p.Add("@DIRECCION_RESIDENCIA", pStgMatriculasCargue.DIRECCION_RESIDENCIA);
                    p.Add("@TEL", pStgMatriculasCargue.TEL);
                    p.Add("@RES_DEPTO", pStgMatriculasCargue.RES_DEPTO);
                    p.Add("@RES_MUN", pStgMatriculasCargue.RES_MUN);
                    p.Add("@ESTRATO", pStgMatriculasCargue.ESTRATO);
                    p.Add("@SISBEN", pStgMatriculasCargue.SISBEN);
                    p.Add("@FECHA_NACIMIENTO", pStgMatriculasCargue.FECHA_NACIMIENTO);
                    p.Add("@NAC_DEPTO", pStgMatriculasCargue.NAC_DEPTO);
                    p.Add("@NAC_MUN", pStgMatriculasCargue.NAC_MUN);
                    p.Add("@GENERO", pStgMatriculasCargue.GENERO);
                    p.Add("@POB_VICT_CONF", pStgMatriculasCargue.POB_VICT_CONF);
                    p.Add("@DPTO_EXP", pStgMatriculasCargue.DPTO_EXP);
                    p.Add("@MUN_EXP", pStgMatriculasCargue.MUN_EXP);
                    p.Add("@PROVIENE_SECTOR_PRIV", pStgMatriculasCargue.PROVIENE_SECTOR_PRIV);
                    p.Add("@PROVIENE_OTRO_MUN", pStgMatriculasCargue.PROVIENE_OTRO_MUN);
                    p.Add("@TIPO_DISCAPACIDAD", pStgMatriculasCargue.TIPO_DISCAPACIDAD);
                    p.Add("@CAP_EXC", pStgMatriculasCargue.CAP_EXC);
                    p.Add("@ETNIA", pStgMatriculasCargue.ETNIA);
                    p.Add("@RES", pStgMatriculasCargue.RES);
                    p.Add("@INS_FAMILIAR", pStgMatriculasCargue.INS_FAMILIAR);
                    p.Add("@TIPO_JORNADA", pStgMatriculasCargue.TIPO_JORNADA);
                    p.Add("@CARACTER", pStgMatriculasCargue.CARACTER);
                    p.Add("@ESPECIALIDAD", pStgMatriculasCargue.ESPECIALIDAD);
                    p.Add("@GRADO", pStgMatriculasCargue.GRADO);
                    p.Add("@GRUPO", pStgMatriculasCargue.GRUPO);
                    p.Add("@METODOLOGIA", pStgMatriculasCargue.METODOLOGIA);
                    p.Add("@SUBSIDIADO", pStgMatriculasCargue.SUBSIDIADO);
                    p.Add("@REPITENTE", pStgMatriculasCargue.REPITENTE);
                    p.Add("@NUEVO", pStgMatriculasCargue.NUEVO);
                    p.Add("@SIT_ACAD_ANO_ANT", pStgMatriculasCargue.SIT_ACAD_ANO_ANT);
                    p.Add("@CON_ALUM_ANO_ANT", pStgMatriculasCargue.CON_ALUM_ANO_ANT);
                    p.Add("@FUE_RECU", pStgMatriculasCargue.FUE_RECU);
                    p.Add("@ZON_ALU", pStgMatriculasCargue.ZON_ALU);
                    p.Add("@CAB_FAMILIA", pStgMatriculasCargue.CAB_FAMILIA);
                    p.Add("@BEN_MAD_FLIA", pStgMatriculasCargue.BEN_MAD_FLIA);
                    p.Add("@BEN_VET_FP", pStgMatriculasCargue.BEN_VET_FP);
                    p.Add("@BEN_HER_NAC", pStgMatriculasCargue.BEN_HER_NAC);
                    p.Add("@INTERNADO", pStgMatriculasCargue.INTERNADO);
                    p.Add("@VAL_DES_PERIODO1", pStgMatriculasCargue.VAL_DES_PERIODO1);
                    p.Add("@VAL_DES_PERIODO2", pStgMatriculasCargue.VAL_DES_PERIODO2);
                    p.Add("@NUM_CONVENIO", pStgMatriculasCargue.NUM_CONVENIO);
                    p.Add("@NOMBRE_CONTRATIST", pStgMatriculasCargue.NOMBRE_CONTRATIST);
                    p.Add("@CTE_MOD_CONTRATO", pStgMatriculasCargue.CTE_MOD_CONTRATO);
                    p.Add("@CTE_TIPO_DOCENTE", pStgMatriculasCargue.CTE_TIPO_DOCENTE);
                    p.Add("@PAIS_ORIGEN", pStgMatriculasCargue.PAIS_ORIGEN);
p.Add("@id",pStgMatriculasCargue.id==null ? 0 : pStgMatriculasCargue.id);
                    p.Add("@sector", pStgMatriculasCargue.sector);
                    p.Add("@calendario", pStgMatriculasCargue.calendario);
p.Add("@id_Encabezado",pStgMatriculasCargue.id_Encabezado== null ? 0: pStgMatriculasCargue.id_Encabezado);
                    p.Add("@Estatus", pStgMatriculasCargue.Estatus);
                    p.Add("@Error", pStgMatriculasCargue.Error);
                    p.Add("@TipoAnexo", pStgMatriculasCargue.TipoAnexo);
                    p.Add("@NOMBRE_ESTABLECIMIENTO", pStgMatriculasCargue.NOMBRE_ESTABLECIMIENTO);
                    p.Add("@NOMBRE_SEDE", pStgMatriculasCargue.NOMBRE_SEDE);
p.Add("@CTE_ID_ZONA",pStgMatriculasCargue.CTE_ID_ZONA==null ? 0 : pStgMatriculasCargue.CTE_ID_ZONA);
p.Add("@PER_ID",pStgMatriculasCargue.PER_ID==null ? 0 : pStgMatriculasCargue.PER_ID);
p.Add("@Edad",pStgMatriculasCargue.Edad==null ? 0 : pStgMatriculasCargue.Edad);
p.Add("@NIV_CONPES",pStgMatriculasCargue.NIV_CONPES==null ? 0 : pStgMatriculasCargue.NIV_CONPES);
p.Add("@DISCAPACIDAD_HOMOLGADA_",pStgMatriculasCargue.DISCAPACIDAD_HOMOLGADA_==null ? 0 : pStgMatriculasCargue.DISCAPACIDAD_HOMOLGADA_);
                    p.Add("@CORREO", pStgMatriculasCargue.CORREO);
                    p.Add("@NOMBRE_CARGO", pStgMatriculasCargue.NOMBRE_CARGO);
                    p.Add("@FechaCarga", pStgMatriculasCargue.FechaCarga);
p.Add("@id_cargue",pStgMatriculasCargue.id_cargue== null ? 0: pStgMatriculasCargue.id_cargue);
                    p.Add("@auditoria", pStgMatriculasCargue.auditoria);

                         


                    StgMatriculasCargue o = SqlMapper.QueryFirstOrDefault<StgMatriculasCargue>(con, "API.PA_StgMatriculasCargueAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  StgMatriculasCargue  ->" + ex.Message);
				}
			}

			public StgMatriculasCargue  Update(StgMatriculasCargue pStgMatriculasCargue)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					                    p.Add("@ANO_INF", pStgMatriculasCargue.ANO_INF);
                    p.Add("@MUN_CODIGO", pStgMatriculasCargue.MUN_CODIGO);
                    p.Add("@CODIGO_DANE", pStgMatriculasCargue.CODIGO_DANE);
                    p.Add("@CODIGO_DANE_SEDE", pStgMatriculasCargue.CODIGO_DANE_SEDE);
                    p.Add("@CONS_SEDE", pStgMatriculasCargue.CONS_SEDE);
                    p.Add("@TIPO_DOCUMENTO", pStgMatriculasCargue.TIPO_DOCUMENTO);
                    p.Add("@NRO_DOCUMENTO", pStgMatriculasCargue.NRO_DOCUMENTO);
                    p.Add("@EXP_DEPTO", pStgMatriculasCargue.EXP_DEPTO);
                    p.Add("@EXP_MUN", pStgMatriculasCargue.EXP_MUN);
                    p.Add("@APELLIDO1", pStgMatriculasCargue.APELLIDO1);
                    p.Add("@APELLIDO2", pStgMatriculasCargue.APELLIDO2);
                    p.Add("@NOMBRE1", pStgMatriculasCargue.NOMBRE1);
                    p.Add("@NOMBRE2", pStgMatriculasCargue.NOMBRE2);
                    p.Add("@DIRECCION_RESIDENCIA", pStgMatriculasCargue.DIRECCION_RESIDENCIA);
                    p.Add("@TEL", pStgMatriculasCargue.TEL);
                    p.Add("@RES_DEPTO", pStgMatriculasCargue.RES_DEPTO);
                    p.Add("@RES_MUN", pStgMatriculasCargue.RES_MUN);
                    p.Add("@ESTRATO", pStgMatriculasCargue.ESTRATO);
                    p.Add("@SISBEN", pStgMatriculasCargue.SISBEN);
                    p.Add("@FECHA_NACIMIENTO", pStgMatriculasCargue.FECHA_NACIMIENTO);
                    p.Add("@NAC_DEPTO", pStgMatriculasCargue.NAC_DEPTO);
                    p.Add("@NAC_MUN", pStgMatriculasCargue.NAC_MUN);
                    p.Add("@GENERO", pStgMatriculasCargue.GENERO);
                    p.Add("@POB_VICT_CONF", pStgMatriculasCargue.POB_VICT_CONF);
                    p.Add("@DPTO_EXP", pStgMatriculasCargue.DPTO_EXP);
                    p.Add("@MUN_EXP", pStgMatriculasCargue.MUN_EXP);
                    p.Add("@PROVIENE_SECTOR_PRIV", pStgMatriculasCargue.PROVIENE_SECTOR_PRIV);
                    p.Add("@PROVIENE_OTRO_MUN", pStgMatriculasCargue.PROVIENE_OTRO_MUN);
                    p.Add("@TIPO_DISCAPACIDAD", pStgMatriculasCargue.TIPO_DISCAPACIDAD);
                    p.Add("@CAP_EXC", pStgMatriculasCargue.CAP_EXC);
                    p.Add("@ETNIA", pStgMatriculasCargue.ETNIA);
                    p.Add("@RES", pStgMatriculasCargue.RES);
                    p.Add("@INS_FAMILIAR", pStgMatriculasCargue.INS_FAMILIAR);
                    p.Add("@TIPO_JORNADA", pStgMatriculasCargue.TIPO_JORNADA);
                    p.Add("@CARACTER", pStgMatriculasCargue.CARACTER);
                    p.Add("@ESPECIALIDAD", pStgMatriculasCargue.ESPECIALIDAD);
                    p.Add("@GRADO", pStgMatriculasCargue.GRADO);
                    p.Add("@GRUPO", pStgMatriculasCargue.GRUPO);
                    p.Add("@METODOLOGIA", pStgMatriculasCargue.METODOLOGIA);
                    p.Add("@SUBSIDIADO", pStgMatriculasCargue.SUBSIDIADO);
                    p.Add("@REPITENTE", pStgMatriculasCargue.REPITENTE);
                    p.Add("@NUEVO", pStgMatriculasCargue.NUEVO);
                    p.Add("@SIT_ACAD_ANO_ANT", pStgMatriculasCargue.SIT_ACAD_ANO_ANT);
                    p.Add("@CON_ALUM_ANO_ANT", pStgMatriculasCargue.CON_ALUM_ANO_ANT);
                    p.Add("@FUE_RECU", pStgMatriculasCargue.FUE_RECU);
                    p.Add("@ZON_ALU", pStgMatriculasCargue.ZON_ALU);
                    p.Add("@CAB_FAMILIA", pStgMatriculasCargue.CAB_FAMILIA);
                    p.Add("@BEN_MAD_FLIA", pStgMatriculasCargue.BEN_MAD_FLIA);
                    p.Add("@BEN_VET_FP", pStgMatriculasCargue.BEN_VET_FP);
                    p.Add("@BEN_HER_NAC", pStgMatriculasCargue.BEN_HER_NAC);
                    p.Add("@INTERNADO", pStgMatriculasCargue.INTERNADO);
                    p.Add("@VAL_DES_PERIODO1", pStgMatriculasCargue.VAL_DES_PERIODO1);
                    p.Add("@VAL_DES_PERIODO2", pStgMatriculasCargue.VAL_DES_PERIODO2);
                    p.Add("@NUM_CONVENIO", pStgMatriculasCargue.NUM_CONVENIO);
                    p.Add("@NOMBRE_CONTRATIST", pStgMatriculasCargue.NOMBRE_CONTRATIST);
                    p.Add("@CTE_MOD_CONTRATO", pStgMatriculasCargue.CTE_MOD_CONTRATO);
                    p.Add("@CTE_TIPO_DOCENTE", pStgMatriculasCargue.CTE_TIPO_DOCENTE);
                    p.Add("@PAIS_ORIGEN", pStgMatriculasCargue.PAIS_ORIGEN);
p.Add("@id",pStgMatriculasCargue.id==null ? 0 : pStgMatriculasCargue.id);
                    p.Add("@sector", pStgMatriculasCargue.sector);
                    p.Add("@calendario", pStgMatriculasCargue.calendario);
p.Add("@id_Encabezado",pStgMatriculasCargue.id_Encabezado== null ? 0: pStgMatriculasCargue.id_Encabezado);
                    p.Add("@Estatus", pStgMatriculasCargue.Estatus);
                    p.Add("@Error", pStgMatriculasCargue.Error);
                    p.Add("@TipoAnexo", pStgMatriculasCargue.TipoAnexo);
                    p.Add("@NOMBRE_ESTABLECIMIENTO", pStgMatriculasCargue.NOMBRE_ESTABLECIMIENTO);
                    p.Add("@NOMBRE_SEDE", pStgMatriculasCargue.NOMBRE_SEDE);
p.Add("@CTE_ID_ZONA",pStgMatriculasCargue.CTE_ID_ZONA==null ? 0 : pStgMatriculasCargue.CTE_ID_ZONA);
p.Add("@PER_ID",pStgMatriculasCargue.PER_ID==null ? 0 : pStgMatriculasCargue.PER_ID);
p.Add("@Edad",pStgMatriculasCargue.Edad==null ? 0 : pStgMatriculasCargue.Edad);
p.Add("@NIV_CONPES",pStgMatriculasCargue.NIV_CONPES==null ? 0 : pStgMatriculasCargue.NIV_CONPES);
p.Add("@DISCAPACIDAD_HOMOLGADA_",pStgMatriculasCargue.DISCAPACIDAD_HOMOLGADA_==null ? 0 : pStgMatriculasCargue.DISCAPACIDAD_HOMOLGADA_);
                    p.Add("@CORREO", pStgMatriculasCargue.CORREO);
                    p.Add("@NOMBRE_CARGO", pStgMatriculasCargue.NOMBRE_CARGO);
                    p.Add("@FechaCarga", pStgMatriculasCargue.FechaCarga);
p.Add("@id_cargue",pStgMatriculasCargue.id_cargue== null ? 0: pStgMatriculasCargue.id_cargue);
                    p.Add("@auditoria", pStgMatriculasCargue.auditoria);

                         


                    StgMatriculasCargue o = SqlMapper.QueryFirstOrDefault<StgMatriculasCargue>(con, "API.PA_StgMatriculasCargueUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  StgMatriculasCargue  ->" + ex.Message);
				}
			}

			public bool Delete(StgMatriculasCargue pStgMatriculasCargue)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pStgMatriculasCargue.id);
                    p.Add("@auditoria", pStgMatriculasCargue.auditoria);

                

 

					StgMatriculasCargue o = SqlMapper.QueryFirstOrDefault<StgMatriculasCargue>(con, "API.PA_StgMatriculasCargueDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) StgMatriculasCargue  ->" + ex.Message);
				}
			}

		



            public List<StgMatriculasCargue> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<StgMatriculasCargue> StgMatriculasCargueList = new List<StgMatriculasCargue>();

                    StgMatriculasCargueList = SqlMapper.Query<StgMatriculasCargue>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return StgMatriculasCargueList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) StgMatriculasCargue  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<StgMatriculasCargue> b)
            {
                DapperPlusManager.Entity<StgMatriculasCargue>().Table("StgMatriculasCargue");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}