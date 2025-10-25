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
    [SwaggerTag("Web API para CRUD de StgMatriculasConsolidado .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class StgMatriculasConsolidadoController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad StgMatriculasConsolidado --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgMatriculasConsolidado!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgMatriculasConsolidado</param>
        /// <response code="200">StgMatriculasConsolidado Consulto los registros exitosamente</response>
        /// <response code="400">StgMatriculasConsolidado tiene valores invalidos </response>
        /// <response code="401">StgMatriculasConsolidado No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar StgMatriculasConsolidado en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new StgMatriculasConsolidadoMs().GetAll().Cast<StgMatriculasConsolidado>().AsQueryable();
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
        /// CRUD de la entidad StgMatriculasConsolidado --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgMatriculasConsolidado!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgMatriculasConsolidado</param>
        /// <response code="200">StgMatriculasConsolidado Consulto los registros exitosamente</response>
        /// <response code="400">StgMatriculasConsolidado tiene valores invalidos </response>
        /// <response code="401">StgMatriculasConsolidado No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar StgMatriculasConsolidado en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new StgMatriculasConsolidadoMs().GetAllFull().Cast<StgMatriculasConsolidado>().AsQueryable();
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
        /// CRUD de la entidad StgMatriculasConsolidado --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgMatriculasConsolidado!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgMatriculasConsolidado</param>
        /// <response code="200">StgMatriculasConsolidado Consulto los registros exitosamente</response>
        /// <response code="400">StgMatriculasConsolidado tiene valores invalidos </response>
        /// <response code="401">StgMatriculasConsolidado No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar StgMatriculasConsolidado en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new StgMatriculasConsolidadoMs().GetById(new StgMatriculasConsolidado() { ID = id });
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
        /// CRUD de la entidad StgMatriculasConsolidado --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Staging de la entidad  StgMatriculasConsolidado!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de StgMatriculasConsolidado</param>
        /// <response code="200">StgMatriculasConsolidado Creado</response>
        /// <response code="400">StgMatriculasConsolidado tiene valores invalidos </response>
        /// <response code="401">StgMatriculasConsolidado No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear StgMatriculasConsolidado en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] StgMatriculasConsolidado obj)
        {
            try
            {
                var result = new StgMatriculasConsolidadoMs().Add(obj);
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
        /// CRUD de la entidad StgMatriculasConsolidado --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Staging de la entidad  StgMatriculasConsolidado!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de StgMatriculasConsolidado</param>
        /// <response code="200">StgMatriculasConsolidado Actualizado</response>
        /// <response code="400">StgMatriculasConsolidado tiene valores invalidos </response>
        /// <response code="401">StgMatriculasConsolidado No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar StgMatriculasConsolidado en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] StgMatriculasConsolidado obj)
        {
            try
            {
                var result = new StgMatriculasConsolidadoMs().Update(obj);
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
        /// CRUD de la entidad StgMatriculasConsolidado --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Staging de la entidad  StgMatriculasConsolidado!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de StgMatriculasConsolidado</param>
        /// <response code="200">StgMatriculasConsolidado Eliminado</response>
        /// <response code="400">StgMatriculasConsolidado tiene valores invalidos </response>
        /// <response code="401">StgMatriculasConsolidado No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar StgMatriculasConsolidado en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] StgMatriculasConsolidado obj)
        {
           try
            {
                new StgMatriculasConsolidadoMs().Delete(obj);
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
        /// DataTable de la entidad StgMatriculasConsolidado --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  StgMatriculasConsolidado!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de StgMatriculasConsolidado</param>
        /// <response code="200">StgMatriculasConsolidado Resultado</response>
        /// <response code="400">StgMatriculasConsolidado tiene valores invalidos </response>
        /// <response code="401">StgMatriculasConsolidado No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  StgMatriculasConsolidado en este momento</response>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LoadTable([FromBody] DtParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;

            var orderCriteria = "ID";
            var orderAscendingDirection = true;

            try
            {

                if (dtParameters.Order != null)
                {
                    // in this example we just default sort on the 1st column
                    orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                    orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
                }

                var result = new StgMatriculasConsolidadoMs().GetAllByWithRelation().Cast<StgMatriculasConsolidado>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="ID") result = result.OrderBy(p => p.ID).Cast <StgMatriculasConsolidado>().ToList();  
                if (orderCriteria == "NRO_FILA") result = result.OrderBy(p => p.NRO_FILA).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ID_ProcesoCargue") result = result.OrderBy(p => p.ID_ProcesoCargue).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ID_TipoProcesoCargue") result = result.OrderBy(p => p.ID_TipoProcesoCargue).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ANNO_INF") result = result.OrderBy(p => p.ANNO_INF).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "MUN_CODIGO") result = result.OrderBy(p => p.MUN_CODIGO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "CODIGO_DANE") result = result.OrderBy(p => p.CODIGO_DANE).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "CODIGO_DANE_SEDE") result = result.OrderBy(p => p.CODIGO_DANE_SEDE).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "TIPO_DOCUMENTO") result = result.OrderBy(p => p.TIPO_DOCUMENTO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "NRO_DOCUMENTO") result = result.OrderBy(p => p.NRO_DOCUMENTO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "APELLIDO1") result = result.OrderBy(p => p.APELLIDO1).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "APELLIDO2") result = result.OrderBy(p => p.APELLIDO2).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "NOMBRE1") result = result.OrderBy(p => p.NOMBRE1).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "NOMBRE2") result = result.OrderBy(p => p.NOMBRE2).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "FECHA_NACIMIENTO") result = result.OrderBy(p => p.FECHA_NACIMIENTO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "GENERO") result = result.OrderBy(p => p.GENERO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "TIPO_JORNADA") result = result.OrderBy(p => p.TIPO_JORNADA).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ESPECIALIDAD") result = result.OrderBy(p => p.ESPECIALIDAD).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "GRADO") result = result.OrderBy(p => p.GRADO).Cast <StgMatriculasConsolidado>().ToList(); 
                       if (orderCriteria == "DPTO_CARGA") result = result.OrderBy(p => p.DPTO_CARGA).Cast <StgMatriculasConsolidado>().ToList(); 
                   if (orderCriteria == "CTE_ID_SECTOR") result = result.OrderBy(p => p.CTE_ID_SECTOR).Cast <StgMatriculasConsolidado>().ToList(); 
                   if (orderCriteria == "CTE_ID_ZONA") result = result.OrderBy(p => p.CTE_ID_ZONA).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "Divipola_MUNICIPIO") result = result.OrderBy(p => p.Divipola_MUNICIPIO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "EDAD") result = result.OrderBy(p => p.EDAD).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "NIV_CONPES") result = result.OrderBy(p => p.NIV_CONPES).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "CODIGO_PAIS_ORIGEN") result = result.OrderBy(p => p.CODIGO_PAIS_ORIGEN).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "NOMBRE_PAIS_ORIGEN") result = result.OrderBy(p => p.NOMBRE_PAIS_ORIGEN).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "SISBEN") result = result.OrderBy(p => p.SISBEN).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "POB_VICT_CONF") result = result.OrderBy(p => p.POB_VICT_CONF).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "DISCAPACIDAD_HOMOLGADA_2021") result = result.OrderBy(p => p.DISCAPACIDAD_HOMOLGADA_2021).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ETNIA") result = result.OrderBy(p => p.ETNIA).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderBy(p => p.ID_ETC).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ESTADO_SEDE") result = result.OrderBy(p => p.ESTADO_SEDE).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "NOMBRE_CARGO") result = result.OrderBy(p => p.NOMBRE_CARGO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "EMAIL") result = result.OrderBy(p => p.EMAIL).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "TEL_CELULAR") result = result.OrderBy(p => p.TEL_CELULAR).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "TEL_FIJO") result = result.OrderBy(p => p.TEL_FIJO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "Estatus") result = result.OrderBy(p => p.Estatus).Cast <StgMatriculasConsolidado>().ToList(); 
                     if (orderCriteria == "FECHA_VINCULACION") result = result.OrderBy(p => p.FECHA_VINCULACION).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "NIVEL_EDUCATIVO_APROBADO") result = result.OrderBy(p => p.NIVEL_EDUCATIVO_APROBADO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "UBICACION") result = result.OrderBy(p => p.UBICACION).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "TIPO_VINCULACION") result = result.OrderBy(p => p.TIPO_VINCULACION).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "NIVEL_ENSENANZA") result = result.OrderBy(p => p.NIVEL_ENSENANZA).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ESTADO_CIVIL") result = result.OrderBy(p => p.ESTADO_CIVIL).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ESTATUTO") result = result.OrderBy(p => p.ESTATUTO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "PARENTESCO") result = result.OrderBy(p => p.PARENTESCO).Cast <StgMatriculasConsolidado>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "ID") result = result.OrderByDescending(p => p.ID).Cast <StgMatriculasConsolidado>().ToList();  
                if (orderCriteria == "NRO_FILA") result = result.OrderByDescending(p => p.NRO_FILA).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ID_ProcesoCargue") result = result.OrderByDescending(p => p.ID_ProcesoCargue).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ID_TipoProcesoCargue") result = result.OrderByDescending(p => p.ID_TipoProcesoCargue).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ANNO_INF") result = result.OrderByDescending(p => p.ANNO_INF).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "MUN_CODIGO") result = result.OrderByDescending(p => p.MUN_CODIGO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "CODIGO_DANE") result = result.OrderByDescending(p => p.CODIGO_DANE).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "CODIGO_DANE_SEDE") result = result.OrderByDescending(p => p.CODIGO_DANE_SEDE).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "TIPO_DOCUMENTO") result = result.OrderByDescending(p => p.TIPO_DOCUMENTO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "NRO_DOCUMENTO") result = result.OrderByDescending(p => p.NRO_DOCUMENTO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "APELLIDO1") result = result.OrderByDescending(p => p.APELLIDO1).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "APELLIDO2") result = result.OrderByDescending(p => p.APELLIDO2).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "NOMBRE1") result = result.OrderByDescending(p => p.NOMBRE1).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "NOMBRE2") result = result.OrderByDescending(p => p.NOMBRE2).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "FECHA_NACIMIENTO") result = result.OrderByDescending(p => p.FECHA_NACIMIENTO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "GENERO") result = result.OrderByDescending(p => p.GENERO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "TIPO_JORNADA") result = result.OrderByDescending(p => p.TIPO_JORNADA).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ESPECIALIDAD") result = result.OrderByDescending(p => p.ESPECIALIDAD).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "GRADO") result = result.OrderByDescending(p => p.GRADO).Cast <StgMatriculasConsolidado>().ToList(); 
                       if (orderCriteria == "DPTO_CARGA") result = result.OrderByDescending(p => p.DPTO_CARGA).Cast <StgMatriculasConsolidado>().ToList(); 
                   if (orderCriteria == "CTE_ID_SECTOR") result = result.OrderByDescending(p => p.CTE_ID_SECTOR).Cast <StgMatriculasConsolidado>().ToList(); 
                   if (orderCriteria == "CTE_ID_ZONA") result = result.OrderByDescending(p => p.CTE_ID_ZONA).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "Divipola_MUNICIPIO") result = result.OrderByDescending(p => p.Divipola_MUNICIPIO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "EDAD") result = result.OrderByDescending(p => p.EDAD).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "NIV_CONPES") result = result.OrderByDescending(p => p.NIV_CONPES).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "CODIGO_PAIS_ORIGEN") result = result.OrderByDescending(p => p.CODIGO_PAIS_ORIGEN).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "NOMBRE_PAIS_ORIGEN") result = result.OrderByDescending(p => p.NOMBRE_PAIS_ORIGEN).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "SISBEN") result = result.OrderByDescending(p => p.SISBEN).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "POB_VICT_CONF") result = result.OrderByDescending(p => p.POB_VICT_CONF).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "DISCAPACIDAD_HOMOLGADA_2021") result = result.OrderByDescending(p => p.DISCAPACIDAD_HOMOLGADA_2021).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ETNIA") result = result.OrderByDescending(p => p.ETNIA).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderByDescending(p => p.ID_ETC).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ESTADO_SEDE") result = result.OrderByDescending(p => p.ESTADO_SEDE).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "NOMBRE_CARGO") result = result.OrderByDescending(p => p.NOMBRE_CARGO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "EMAIL") result = result.OrderByDescending(p => p.EMAIL).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "TEL_CELULAR") result = result.OrderByDescending(p => p.TEL_CELULAR).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "TEL_FIJO") result = result.OrderByDescending(p => p.TEL_FIJO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "Estatus") result = result.OrderByDescending(p => p.Estatus).Cast <StgMatriculasConsolidado>().ToList(); 
                     if (orderCriteria == "FECHA_VINCULACION") result = result.OrderByDescending(p => p.FECHA_VINCULACION).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "NIVEL_EDUCATIVO_APROBADO") result = result.OrderByDescending(p => p.NIVEL_EDUCATIVO_APROBADO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "UBICACION") result = result.OrderByDescending(p => p.UBICACION).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "TIPO_VINCULACION") result = result.OrderByDescending(p => p.TIPO_VINCULACION).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "NIVEL_ENSENANZA") result = result.OrderByDescending(p => p.NIVEL_ENSENANZA).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ESTADO_CIVIL") result = result.OrderByDescending(p => p.ESTADO_CIVIL).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "ESTATUTO") result = result.OrderByDescending(p => p.ESTATUTO).Cast <StgMatriculasConsolidado>().ToList(); 
                 if (orderCriteria == "PARENTESCO") result = result.OrderByDescending(p => p.PARENTESCO).Cast <StgMatriculasConsolidado>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.ID != null && r.ID.ToString().Contains(searchBy.ToUpper())  
                 || r.NRO_FILA != null && r.NRO_FILA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_ProcesoCargue != null && r.ID_ProcesoCargue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoProcesoCargue != null && r.ID_TipoProcesoCargue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ANNO_INF != null && r.ANNO_INF.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.MUN_CODIGO != null && r.MUN_CODIGO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CODIGO_DANE != null && r.CODIGO_DANE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CODIGO_DANE_SEDE != null && r.CODIGO_DANE_SEDE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TIPO_DOCUMENTO != null && r.TIPO_DOCUMENTO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NRO_DOCUMENTO != null && r.NRO_DOCUMENTO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.APELLIDO1 != null && r.APELLIDO1.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.APELLIDO2 != null && r.APELLIDO2.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NOMBRE1 != null && r.NOMBRE1.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NOMBRE2 != null && r.NOMBRE2.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FECHA_NACIMIENTO != null && r.FECHA_NACIMIENTO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.GENERO != null && r.GENERO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TIPO_JORNADA != null && r.TIPO_JORNADA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ESPECIALIDAD != null && r.ESPECIALIDAD.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.GRADO != null && r.GRADO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                       || r.DPTO_CARGA != null && r.DPTO_CARGA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.CTE_ID_SECTOR != null && r.CTE_ID_SECTOR.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.CTE_ID_ZONA != null && r.CTE_ID_ZONA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Divipola_MUNICIPIO != null && r.Divipola_MUNICIPIO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.EDAD != null && r.EDAD.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NIV_CONPES != null && r.NIV_CONPES.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CODIGO_PAIS_ORIGEN != null && r.CODIGO_PAIS_ORIGEN.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NOMBRE_PAIS_ORIGEN != null && r.NOMBRE_PAIS_ORIGEN.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.SISBEN != null && r.SISBEN.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.POB_VICT_CONF != null && r.POB_VICT_CONF.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.DISCAPACIDAD_HOMOLGADA_2021 != null && r.DISCAPACIDAD_HOMOLGADA_2021.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ETNIA != null && r.ETNIA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_ETC != null && r.ID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ESTADO_SEDE != null && r.ESTADO_SEDE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NOMBRE_CARGO != null && r.NOMBRE_CARGO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.EMAIL != null && r.EMAIL.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TEL_CELULAR != null && r.TEL_CELULAR.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TEL_FIJO != null && r.TEL_FIJO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Estatus != null && r.Estatus.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                     || r.FECHA_VINCULACION != null && r.FECHA_VINCULACION.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NIVEL_EDUCATIVO_APROBADO != null && r.NIVEL_EDUCATIVO_APROBADO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.UBICACION != null && r.UBICACION.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TIPO_VINCULACION != null && r.TIPO_VINCULACION.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NIVEL_ENSENANZA != null && r.NIVEL_ENSENANZA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ESTADO_CIVIL != null && r.ESTADO_CIVIL.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ESTATUTO != null && r.ESTATUTO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PARENTESCO != null && r.PARENTESCO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
                    data[i].sID = SISPAE.Common.Utilidades.Encrypt($"id={data[i].ID.ToString()}");
                   
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
        /// CRUD de la entidad StgMatriculasConsolidado --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgMatriculasConsolidado!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgMatriculasConsolidado</param>
        /// <response code="200">StgMatriculasConsolidado Consulto los registros exitosamente</response>
        /// <response code="400">StgMatriculasConsolidado tiene valores invalidos </response>
        /// <response code="401">StgMatriculasConsolidado No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar StgMatriculasConsolidado en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new StgMatriculasConsolidadoMs().GetAllByWithRelation().Cast<StgMatriculasConsolidado>().AsQueryable();
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
