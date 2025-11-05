/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano				:2022
/// Arquitectura	:Patron MVC ASP Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa			:WEBAPI (WEBAPI Entity Layer) - Capa WEB API (Source: MVC7_ControllersAPI_Base.cs)    
/// </Derechos_Reservados>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using SISPAE.Business;
using SISPAE.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.OData.Query;
using ElmahCore;




// create, index, delete, update , read
//  details, listall, 

namespace SISPAE_API_Staging.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de StgMatriculasCargue .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class StgMatriculasCargueController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad StgMatriculasCargue --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgMatriculasCargue!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgMatriculasCargue</param>
        /// <response code="200">StgMatriculasCargue Consulto los registros exitosamente</response>
        /// <response code="400">StgMatriculasCargue tiene valores invalidos </response>
        /// <response code="401">StgMatriculasCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar StgMatriculasCargue en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new StgMatriculasCargueMs().GetAll().Cast<StgMatriculasCargue>().AsQueryable();
                return Ok(result);
            }
            catch (System.Exception ex)
            {
	        HttpContext.RaiseError(new InvalidOperationException(ex.Message)); 
                return BadRequest(ex.Message);
            }
        }


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad StgMatriculasCargue --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgMatriculasCargue!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgMatriculasCargue</param>
        /// <response code="200">StgMatriculasCargue Consulto los registros exitosamente</response>
        /// <response code="400">StgMatriculasCargue tiene valores invalidos </response>
        /// <response code="401">StgMatriculasCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar StgMatriculasCargue en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new StgMatriculasCargueMs().GetAllFull().Cast<StgMatriculasCargue>().AsQueryable();
                return Ok(result);
            }
            catch (System.Exception ex)
            {
	        HttpContext.RaiseError(new InvalidOperationException(ex.Message)); 
                return BadRequest(ex.Message);
            }
        }



        // GET api/values/5
        /// <summary>
        /// CRUD de la entidad StgMatriculasCargue --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgMatriculasCargue!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgMatriculasCargue</param>
        /// <response code="200">StgMatriculasCargue Consulto los registros exitosamente</response>
        /// <response code="400">StgMatriculasCargue tiene valores invalidos </response>
        /// <response code="401">StgMatriculasCargue No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar StgMatriculasCargue en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new StgMatriculasCargueMs().GetById(new StgMatriculasCargue() { id = id });
                return Ok(result);
            }
            catch (System.Exception ex)
            {
	        HttpContext.RaiseError(new InvalidOperationException(ex.Message)); 
                return BadRequest(ex.Message);
            }
        }



        // POST api/values
        /// <summary>
        /// CRUD de la entidad StgMatriculasCargue --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Staging de la entidad  StgMatriculasCargue!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de StgMatriculasCargue</param>
        /// <response code="200">StgMatriculasCargue Creado</response>
        /// <response code="400">StgMatriculasCargue tiene valores invalidos </response>
        /// <response code="401">StgMatriculasCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear StgMatriculasCargue en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] StgMatriculasCargue obj)
        {
            try
            {
                var result = new StgMatriculasCargueMs().Add(obj);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
	        HttpContext.RaiseError(new InvalidOperationException(ex.Message)); 
                return BadRequest(ex.Message);
            }
        }

        // PUT api/values/5
        /// <summary>
        /// CRUD de la entidad StgMatriculasCargue --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Staging de la entidad  StgMatriculasCargue!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de StgMatriculasCargue</param>
        /// <response code="200">StgMatriculasCargue Actualizado</response>
        /// <response code="400">StgMatriculasCargue tiene valores invalidos </response>
        /// <response code="401">StgMatriculasCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar StgMatriculasCargue en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] StgMatriculasCargue obj)
        {
            try
            {
                var result = new StgMatriculasCargueMs().Update(obj);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
	        HttpContext.RaiseError(new InvalidOperationException(ex.Message)); 
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/values/5
          /// <summary>
        /// CRUD de la entidad StgMatriculasCargue --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Staging de la entidad  StgMatriculasCargue!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de StgMatriculasCargue</param>
        /// <response code="200">StgMatriculasCargue Eliminado</response>
        /// <response code="400">StgMatriculasCargue tiene valores invalidos </response>
        /// <response code="401">StgMatriculasCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar StgMatriculasCargue en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] StgMatriculasCargue obj)
        {
           try
            {
                new StgMatriculasCargueMs().Delete(obj);
                return Ok();
            }
            catch (System.Exception ex)
            {
	        HttpContext.RaiseError(new InvalidOperationException(ex.Message)); 
                return BadRequest(ex.Message);
            }
        }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad StgMatriculasCargue --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  StgMatriculasCargue!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de StgMatriculasCargue</param>
        /// <response code="200">StgMatriculasCargue Resultado</response>
        /// <response code="400">StgMatriculasCargue tiene valores invalidos </response>
        /// <response code="401">StgMatriculasCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  StgMatriculasCargue en este momento</response>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LoadTable([FromBody] DtParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;

            var orderCriteria = "id";
            var orderAscendingDirection = true;

            try
            {

                if (dtParameters.Order != null)
                {
                    // in this example we just default sort on the 1st column
                    orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                    orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
                }

                var result = new StgMatriculasCargueMs().GetAllByWithRelation().Cast<StgMatriculasCargue>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria == "ANO_INF") result = result.OrderBy(p => p.ANO_INF).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "MUN_CODIGO") result = result.OrderBy(p => p.MUN_CODIGO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CODIGO_DANE") result = result.OrderBy(p => p.CODIGO_DANE).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CODIGO_DANE_SEDE") result = result.OrderBy(p => p.CODIGO_DANE_SEDE).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CONS_SEDE") result = result.OrderBy(p => p.CONS_SEDE).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "TIPO_DOCUMENTO") result = result.OrderBy(p => p.TIPO_DOCUMENTO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NRO_DOCUMENTO") result = result.OrderBy(p => p.NRO_DOCUMENTO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "EXP_DEPTO") result = result.OrderBy(p => p.EXP_DEPTO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "EXP_MUN") result = result.OrderBy(p => p.EXP_MUN).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "APELLIDO1") result = result.OrderBy(p => p.APELLIDO1).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "APELLIDO2") result = result.OrderBy(p => p.APELLIDO2).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NOMBRE1") result = result.OrderBy(p => p.NOMBRE1).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NOMBRE2") result = result.OrderBy(p => p.NOMBRE2).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "DIRECCION_RESIDENCIA") result = result.OrderBy(p => p.DIRECCION_RESIDENCIA).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "TEL") result = result.OrderBy(p => p.TEL).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "RES_DEPTO") result = result.OrderBy(p => p.RES_DEPTO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "RES_MUN") result = result.OrderBy(p => p.RES_MUN).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "ESTRATO") result = result.OrderBy(p => p.ESTRATO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "SISBEN") result = result.OrderBy(p => p.SISBEN).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "FECHA_NACIMIENTO") result = result.OrderBy(p => p.FECHA_NACIMIENTO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NAC_DEPTO") result = result.OrderBy(p => p.NAC_DEPTO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NAC_MUN") result = result.OrderBy(p => p.NAC_MUN).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "GENERO") result = result.OrderBy(p => p.GENERO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "POB_VICT_CONF") result = result.OrderBy(p => p.POB_VICT_CONF).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "DPTO_EXP") result = result.OrderBy(p => p.DPTO_EXP).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "MUN_EXP") result = result.OrderBy(p => p.MUN_EXP).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "PROVIENE_SECTOR_PRIV") result = result.OrderBy(p => p.PROVIENE_SECTOR_PRIV).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "PROVIENE_OTRO_MUN") result = result.OrderBy(p => p.PROVIENE_OTRO_MUN).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "TIPO_DISCAPACIDAD") result = result.OrderBy(p => p.TIPO_DISCAPACIDAD).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CAP_EXC") result = result.OrderBy(p => p.CAP_EXC).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "ETNIA") result = result.OrderBy(p => p.ETNIA).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "RES") result = result.OrderBy(p => p.RES).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "INS_FAMILIAR") result = result.OrderBy(p => p.INS_FAMILIAR).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "TIPO_JORNADA") result = result.OrderBy(p => p.TIPO_JORNADA).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CARACTER") result = result.OrderBy(p => p.CARACTER).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "ESPECIALIDAD") result = result.OrderBy(p => p.ESPECIALIDAD).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "GRADO") result = result.OrderBy(p => p.GRADO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "GRUPO") result = result.OrderBy(p => p.GRUPO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "METODOLOGIA") result = result.OrderBy(p => p.METODOLOGIA).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "SUBSIDIADO") result = result.OrderBy(p => p.SUBSIDIADO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "REPITENTE") result = result.OrderBy(p => p.REPITENTE).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NUEVO") result = result.OrderBy(p => p.NUEVO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "SIT_ACAD_ANO_ANT") result = result.OrderBy(p => p.SIT_ACAD_ANO_ANT).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CON_ALUM_ANO_ANT") result = result.OrderBy(p => p.CON_ALUM_ANO_ANT).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "FUE_RECU") result = result.OrderBy(p => p.FUE_RECU).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "ZON_ALU") result = result.OrderBy(p => p.ZON_ALU).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CAB_FAMILIA") result = result.OrderBy(p => p.CAB_FAMILIA).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "BEN_MAD_FLIA") result = result.OrderBy(p => p.BEN_MAD_FLIA).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "BEN_VET_FP") result = result.OrderBy(p => p.BEN_VET_FP).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "BEN_HER_NAC") result = result.OrderBy(p => p.BEN_HER_NAC).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "INTERNADO") result = result.OrderBy(p => p.INTERNADO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "VAL_DES_PERIODO1") result = result.OrderBy(p => p.VAL_DES_PERIODO1).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "VAL_DES_PERIODO2") result = result.OrderBy(p => p.VAL_DES_PERIODO2).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NUM_CONVENIO") result = result.OrderBy(p => p.NUM_CONVENIO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NOMBRE_CONTRATIST") result = result.OrderBy(p => p.NOMBRE_CONTRATIST).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CTE_MOD_CONTRATO") result = result.OrderBy(p => p.CTE_MOD_CONTRATO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CTE_TIPO_DOCENTE") result = result.OrderBy(p => p.CTE_TIPO_DOCENTE).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "PAIS_ORIGEN") result = result.OrderBy(p => p.PAIS_ORIGEN).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <StgMatriculasCargue>().ToList();  
                if (orderCriteria == "sector") result = result.OrderBy(p => p.sector).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "calendario") result = result.OrderBy(p => p.calendario).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "id_Encabezado") result = result.OrderBy(p => p.id_Encabezado).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "Estatus") result = result.OrderBy(p => p.Estatus).Cast <StgMatriculasCargue>().ToList(); 
                     if (orderCriteria == "TipoAnexo") result = result.OrderBy(p => p.TipoAnexo).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NOMBRE_ESTABLECIMIENTO") result = result.OrderBy(p => p.NOMBRE_ESTABLECIMIENTO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NOMBRE_SEDE") result = result.OrderBy(p => p.NOMBRE_SEDE).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CTE_ID_ZONA") result = result.OrderBy(p => p.CTE_ID_ZONA).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "PER_ID") result = result.OrderBy(p => p.PER_ID).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "Edad") result = result.OrderBy(p => p.Edad).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NIV_CONPES") result = result.OrderBy(p => p.NIV_CONPES).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "DISCAPACIDAD_HOMOLGADA_") result = result.OrderBy(p => p.DISCAPACIDAD_HOMOLGADA_).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CORREO") result = result.OrderBy(p => p.CORREO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NOMBRE_CARGO") result = result.OrderBy(p => p.NOMBRE_CARGO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "FechaCarga") result = result.OrderBy(p => p.FechaCarga).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "id_cargue") result = result.OrderBy(p => p.id_cargue).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "sID_EncabezadoMatricula") result = result.OrderBy(p => p.sid_cargue).Cast <StgMatriculasCargue>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "ANO_INF") result = result.OrderByDescending(p => p.ANO_INF).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "MUN_CODIGO") result = result.OrderByDescending(p => p.MUN_CODIGO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CODIGO_DANE") result = result.OrderByDescending(p => p.CODIGO_DANE).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CODIGO_DANE_SEDE") result = result.OrderByDescending(p => p.CODIGO_DANE_SEDE).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CONS_SEDE") result = result.OrderByDescending(p => p.CONS_SEDE).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "TIPO_DOCUMENTO") result = result.OrderByDescending(p => p.TIPO_DOCUMENTO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NRO_DOCUMENTO") result = result.OrderByDescending(p => p.NRO_DOCUMENTO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "EXP_DEPTO") result = result.OrderByDescending(p => p.EXP_DEPTO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "EXP_MUN") result = result.OrderByDescending(p => p.EXP_MUN).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "APELLIDO1") result = result.OrderByDescending(p => p.APELLIDO1).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "APELLIDO2") result = result.OrderByDescending(p => p.APELLIDO2).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NOMBRE1") result = result.OrderByDescending(p => p.NOMBRE1).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NOMBRE2") result = result.OrderByDescending(p => p.NOMBRE2).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "DIRECCION_RESIDENCIA") result = result.OrderByDescending(p => p.DIRECCION_RESIDENCIA).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "TEL") result = result.OrderByDescending(p => p.TEL).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "RES_DEPTO") result = result.OrderByDescending(p => p.RES_DEPTO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "RES_MUN") result = result.OrderByDescending(p => p.RES_MUN).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "ESTRATO") result = result.OrderByDescending(p => p.ESTRATO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "SISBEN") result = result.OrderByDescending(p => p.SISBEN).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "FECHA_NACIMIENTO") result = result.OrderByDescending(p => p.FECHA_NACIMIENTO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NAC_DEPTO") result = result.OrderByDescending(p => p.NAC_DEPTO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NAC_MUN") result = result.OrderByDescending(p => p.NAC_MUN).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "GENERO") result = result.OrderByDescending(p => p.GENERO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "POB_VICT_CONF") result = result.OrderByDescending(p => p.POB_VICT_CONF).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "DPTO_EXP") result = result.OrderByDescending(p => p.DPTO_EXP).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "MUN_EXP") result = result.OrderByDescending(p => p.MUN_EXP).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "PROVIENE_SECTOR_PRIV") result = result.OrderByDescending(p => p.PROVIENE_SECTOR_PRIV).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "PROVIENE_OTRO_MUN") result = result.OrderByDescending(p => p.PROVIENE_OTRO_MUN).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "TIPO_DISCAPACIDAD") result = result.OrderByDescending(p => p.TIPO_DISCAPACIDAD).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CAP_EXC") result = result.OrderByDescending(p => p.CAP_EXC).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "ETNIA") result = result.OrderByDescending(p => p.ETNIA).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "RES") result = result.OrderByDescending(p => p.RES).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "INS_FAMILIAR") result = result.OrderByDescending(p => p.INS_FAMILIAR).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "TIPO_JORNADA") result = result.OrderByDescending(p => p.TIPO_JORNADA).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CARACTER") result = result.OrderByDescending(p => p.CARACTER).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "ESPECIALIDAD") result = result.OrderByDescending(p => p.ESPECIALIDAD).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "GRADO") result = result.OrderByDescending(p => p.GRADO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "GRUPO") result = result.OrderByDescending(p => p.GRUPO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "METODOLOGIA") result = result.OrderByDescending(p => p.METODOLOGIA).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "SUBSIDIADO") result = result.OrderByDescending(p => p.SUBSIDIADO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "REPITENTE") result = result.OrderByDescending(p => p.REPITENTE).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NUEVO") result = result.OrderByDescending(p => p.NUEVO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "SIT_ACAD_ANO_ANT") result = result.OrderByDescending(p => p.SIT_ACAD_ANO_ANT).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CON_ALUM_ANO_ANT") result = result.OrderByDescending(p => p.CON_ALUM_ANO_ANT).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "FUE_RECU") result = result.OrderByDescending(p => p.FUE_RECU).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "ZON_ALU") result = result.OrderByDescending(p => p.ZON_ALU).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CAB_FAMILIA") result = result.OrderByDescending(p => p.CAB_FAMILIA).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "BEN_MAD_FLIA") result = result.OrderByDescending(p => p.BEN_MAD_FLIA).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "BEN_VET_FP") result = result.OrderByDescending(p => p.BEN_VET_FP).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "BEN_HER_NAC") result = result.OrderByDescending(p => p.BEN_HER_NAC).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "INTERNADO") result = result.OrderByDescending(p => p.INTERNADO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "VAL_DES_PERIODO1") result = result.OrderByDescending(p => p.VAL_DES_PERIODO1).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "VAL_DES_PERIODO2") result = result.OrderByDescending(p => p.VAL_DES_PERIODO2).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NUM_CONVENIO") result = result.OrderByDescending(p => p.NUM_CONVENIO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NOMBRE_CONTRATIST") result = result.OrderByDescending(p => p.NOMBRE_CONTRATIST).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CTE_MOD_CONTRATO") result = result.OrderByDescending(p => p.CTE_MOD_CONTRATO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CTE_TIPO_DOCENTE") result = result.OrderByDescending(p => p.CTE_TIPO_DOCENTE).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "PAIS_ORIGEN") result = result.OrderByDescending(p => p.PAIS_ORIGEN).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <StgMatriculasCargue>().ToList();  
                if (orderCriteria == "sector") result = result.OrderByDescending(p => p.sector).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "calendario") result = result.OrderByDescending(p => p.calendario).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "id_Encabezado") result = result.OrderByDescending(p => p.id_Encabezado).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "Estatus") result = result.OrderByDescending(p => p.Estatus).Cast <StgMatriculasCargue>().ToList(); 
                     if (orderCriteria == "TipoAnexo") result = result.OrderByDescending(p => p.TipoAnexo).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NOMBRE_ESTABLECIMIENTO") result = result.OrderByDescending(p => p.NOMBRE_ESTABLECIMIENTO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NOMBRE_SEDE") result = result.OrderByDescending(p => p.NOMBRE_SEDE).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CTE_ID_ZONA") result = result.OrderByDescending(p => p.CTE_ID_ZONA).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "PER_ID") result = result.OrderByDescending(p => p.PER_ID).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "Edad") result = result.OrderByDescending(p => p.Edad).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NIV_CONPES") result = result.OrderByDescending(p => p.NIV_CONPES).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "DISCAPACIDAD_HOMOLGADA_") result = result.OrderByDescending(p => p.DISCAPACIDAD_HOMOLGADA_).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "CORREO") result = result.OrderByDescending(p => p.CORREO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "NOMBRE_CARGO") result = result.OrderByDescending(p => p.NOMBRE_CARGO).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "FechaCarga") result = result.OrderByDescending(p => p.FechaCarga).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "id_cargue") result = result.OrderByDescending(p => p.id_cargue).Cast <StgMatriculasCargue>().ToList(); 
                 if (orderCriteria == "sID_EncabezadoMatricula") result = result.OrderByDescending(p => p.sid_cargue).Cast<StgMatriculasCargue>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.ANO_INF != null && r.ANO_INF.ToString().Contains(searchBy.ToUpper())  
                 || r.MUN_CODIGO != null && r.MUN_CODIGO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CODIGO_DANE != null && r.CODIGO_DANE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CODIGO_DANE_SEDE != null && r.CODIGO_DANE_SEDE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CONS_SEDE != null && r.CONS_SEDE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TIPO_DOCUMENTO != null && r.TIPO_DOCUMENTO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NRO_DOCUMENTO != null && r.NRO_DOCUMENTO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.EXP_DEPTO != null && r.EXP_DEPTO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.EXP_MUN != null && r.EXP_MUN.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.APELLIDO1 != null && r.APELLIDO1.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.APELLIDO2 != null && r.APELLIDO2.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NOMBRE1 != null && r.NOMBRE1.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NOMBRE2 != null && r.NOMBRE2.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.DIRECCION_RESIDENCIA != null && r.DIRECCION_RESIDENCIA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TEL != null && r.TEL.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.RES_DEPTO != null && r.RES_DEPTO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.RES_MUN != null && r.RES_MUN.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ESTRATO != null && r.ESTRATO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.SISBEN != null && r.SISBEN.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FECHA_NACIMIENTO != null && r.FECHA_NACIMIENTO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NAC_DEPTO != null && r.NAC_DEPTO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NAC_MUN != null && r.NAC_MUN.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.GENERO != null && r.GENERO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.POB_VICT_CONF != null && r.POB_VICT_CONF.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.DPTO_EXP != null && r.DPTO_EXP.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.MUN_EXP != null && r.MUN_EXP.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PROVIENE_SECTOR_PRIV != null && r.PROVIENE_SECTOR_PRIV.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PROVIENE_OTRO_MUN != null && r.PROVIENE_OTRO_MUN.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TIPO_DISCAPACIDAD != null && r.TIPO_DISCAPACIDAD.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CAP_EXC != null && r.CAP_EXC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ETNIA != null && r.ETNIA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.RES != null && r.RES.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.INS_FAMILIAR != null && r.INS_FAMILIAR.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TIPO_JORNADA != null && r.TIPO_JORNADA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CARACTER != null && r.CARACTER.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ESPECIALIDAD != null && r.ESPECIALIDAD.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.GRADO != null && r.GRADO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.GRUPO != null && r.GRUPO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.METODOLOGIA != null && r.METODOLOGIA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.SUBSIDIADO != null && r.SUBSIDIADO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.REPITENTE != null && r.REPITENTE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NUEVO != null && r.NUEVO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.SIT_ACAD_ANO_ANT != null && r.SIT_ACAD_ANO_ANT.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CON_ALUM_ANO_ANT != null && r.CON_ALUM_ANO_ANT.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FUE_RECU != null && r.FUE_RECU.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ZON_ALU != null && r.ZON_ALU.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CAB_FAMILIA != null && r.CAB_FAMILIA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.BEN_MAD_FLIA != null && r.BEN_MAD_FLIA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.BEN_VET_FP != null && r.BEN_VET_FP.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.BEN_HER_NAC != null && r.BEN_HER_NAC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.INTERNADO != null && r.INTERNADO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.VAL_DES_PERIODO1 != null && r.VAL_DES_PERIODO1.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.VAL_DES_PERIODO2 != null && r.VAL_DES_PERIODO2.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NUM_CONVENIO != null && r.NUM_CONVENIO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NOMBRE_CONTRATIST != null && r.NOMBRE_CONTRATIST.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CTE_MOD_CONTRATO != null && r.CTE_MOD_CONTRATO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CTE_TIPO_DOCENTE != null && r.CTE_TIPO_DOCENTE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PAIS_ORIGEN != null && r.PAIS_ORIGEN.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.id != null && r.id.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sector != null && r.sector.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.calendario != null && r.calendario.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.id_Encabezado != null && r.id_Encabezado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Estatus != null && r.Estatus.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                     || r.TipoAnexo != null && r.TipoAnexo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NOMBRE_ESTABLECIMIENTO != null && r.NOMBRE_ESTABLECIMIENTO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NOMBRE_SEDE != null && r.NOMBRE_SEDE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CTE_ID_ZONA != null && r.CTE_ID_ZONA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PER_ID != null && r.PER_ID.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Edad != null && r.Edad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NIV_CONPES != null && r.NIV_CONPES.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.DISCAPACIDAD_HOMOLGADA_ != null && r.DISCAPACIDAD_HOMOLGADA_.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CORREO != null && r.CORREO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NOMBRE_CARGO != null && r.NOMBRE_CARGO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaCarga != null && r.FechaCarga.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.id_cargue != null && r.id_cargue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                || r.sid_cargue != null && r.sid_cargue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
  
                                            ).ToList();
                }

                filteredResultsCount = data.Count();

                if (dtParameters.Length > 0)
                {
                    data = data.Skip(dtParameters.Start)
                                .Take(dtParameters.Length)
                                .ToList();
                }
                else
                {
                    data = data.Skip(dtParameters.Start)
                                .ToList();
                }

 
                for (int i = 0; i < data.Count; i++)
                {
                    data[i].sID = SISPAE.Common.Utilidades.Encrypt($"id={data[i].id.ToString()}");
                   
                }

                return Ok(new
                {
                    Draw = dtParameters.Draw,
                    RecordsTotal = totalResultsCount,
                    RecordsFiltered = filteredResultsCount,
                    Data = data
                });
            }
            catch (System.Exception ex)
            {
	        HttpContext.RaiseError(new InvalidOperationException(ex.Message)); 
                return BadRequest(ex.Message);
            }
        }


        // GET api/GetAllRelation/
        /// <summary>
        /// CRUD de la entidad StgMatriculasCargue --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgMatriculasCargue!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgMatriculasCargue</param>
        /// <response code="200">StgMatriculasCargue Consulto los registros exitosamente</response>
        /// <response code="400">StgMatriculasCargue tiene valores invalidos </response>
        /// <response code="401">StgMatriculasCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar StgMatriculasCargue en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new StgMatriculasCargueMs().GetAllByWithRelation().Cast<StgMatriculasCargue>().AsQueryable();
                return Ok(result);
            }
            catch (System.Exception ex)
            {
	        HttpContext.RaiseError(new InvalidOperationException(ex.Message)); 
                return BadRequest(ex.Message);
            }
        }


    }
}
