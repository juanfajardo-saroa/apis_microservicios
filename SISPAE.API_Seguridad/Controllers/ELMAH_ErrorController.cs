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




// create, index, delete, update , read
//  details, listall, 

namespace SISPAE_API_Seguridad.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de ELMAH_Error .")]
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public partial class ELMAH_ErrorController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad ELMAH_Error --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  ELMAH_Error!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ELMAH_Error</param>
        /// <response code="200">ELMAH_Error Consulto los registros exitosamente</response>
        /// <response code="400">ELMAH_Error tiene valores invalidos </response>
        /// <response code="401">ELMAH_Error No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ELMAH_Error en este momento</response>
        [HttpGet()]
        [EnableQuery()]

        public IActionResult GetAll()
        {
            try
            {
                var result = new ELMAH_ErrorMs().GetAll().Cast<ELMAH_Error>().AsQueryable();
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad ELMAH_Error --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  ELMAH_Error!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ELMAH_Error</param>
        /// <response code="200">ELMAH_Error Consulto los registros exitosamente</response>
        /// <response code="400">ELMAH_Error tiene valores invalidos </response>
        /// <response code="401">ELMAH_Error No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ELMAH_Error en este momento</response>
        [HttpGet()]
        [EnableQuery()]

        public IActionResult GetAllFull()
        {
            try
            {
                var result = new ELMAH_ErrorMs().GetAllFull().Cast<ELMAH_Error>().AsQueryable();
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        // GET api/values/5
        /// <summary>
        /// CRUD de la entidad ELMAH_Error --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  ELMAH_Error!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ELMAH_Error</param>
        /// <response code="200">ELMAH_Error Consulto los registros exitosamente</response>
        /// <response code="400">ELMAH_Error tiene valores invalidos </response>
        /// <response code="401">ELMAH_Error No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar ELMAH_Error en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        public IActionResult GetById(string id)
        {
            try
            {
                var result = new ELMAH_ErrorMs().GetById(new ELMAH_Error() { ErrorId = id });
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        // POST api/values
        /// <summary>
        /// CRUD de la entidad ELMAH_Error --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE de la entidad  ELMAH_Error!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de ELMAH_Error</param>
        /// <response code="200">ELMAH_Error Creado</response>
        /// <response code="400">ELMAH_Error tiene valores invalidos </response>
        /// <response code="401">ELMAH_Error No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear ELMAH_Error en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] ELMAH_Error obj)
        {
            try
            {
                var result = new ELMAH_ErrorMs().Add(obj);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/values/5
        /// <summary>
        /// CRUD de la entidad ELMAH_Error --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE de la entidad  ELMAH_Error!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de ELMAH_Error</param>
        /// <response code="200">ELMAH_Error Actualizado</response>
        /// <response code="400">ELMAH_Error tiene valores invalidos </response>
        /// <response code="401">ELMAH_Error No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar ELMAH_Error en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] ELMAH_Error obj)
        {
            try
            {
                var result = new ELMAH_ErrorMs().Update(obj);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/values/5
        /// <summary>
        /// CRUD de la entidad ELMAH_Error --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE de la entidad  ELMAH_Error!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de ELMAH_Error</param>
        /// <response code="200">ELMAH_Error Eliminado</response>
        /// <response code="400">ELMAH_Error tiene valores invalidos </response>
        /// <response code="401">ELMAH_Error No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar ELMAH_Error en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] ELMAH_Error obj)
        {
            try
            {
                new ELMAH_ErrorMs().Delete(obj);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad ELMAH_Error --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  ELMAH_Error!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de ELMAH_Error</param>
        /// <response code="200">ELMAH_Error Resultado</response>
        /// <response code="400">ELMAH_Error tiene valores invalidos </response>
        /// <response code="401">ELMAH_Error No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  ELMAH_Error en este momento</response>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LoadTable([FromBody] DtParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;

            var orderCriteria = "ErrorId";
            var orderAscendingDirection = true;

            try
            {

                if (dtParameters.Order != null)
                {
                    // in this example we just default sort on the 1st column
                    orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                    orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
                }

                var result = new ELMAH_ErrorMs().GetAllByWithRelation().Cast<ELMAH_Error>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                if (orderAscendingDirection)
                {
                    if (orderCriteria == "Application") result = result.OrderBy(p => p.Application).Cast<ELMAH_Error>().ToList();
                    if (orderCriteria == "Host") result = result.OrderBy(p => p.Host).Cast<ELMAH_Error>().ToList();
                    if (orderCriteria == "Type") result = result.OrderBy(p => p.Type).Cast<ELMAH_Error>().ToList();
                    if (orderCriteria == "Source") result = result.OrderBy(p => p.Source).Cast<ELMAH_Error>().ToList();
                    if (orderCriteria == "Message") result = result.OrderBy(p => p.Message).Cast<ELMAH_Error>().ToList();
                    if (orderCriteria == "User") result = result.OrderBy(p => p.User).Cast<ELMAH_Error>().ToList();
                    if (orderCriteria == "StatusCode") result = result.OrderBy(p => p.StatusCode).Cast<ELMAH_Error>().ToList();
                    if (orderCriteria == "TimeUtc") result = result.OrderBy(p => p.TimeUtc).Cast<ELMAH_Error>().ToList();
                    if (orderCriteria == "Sequence") result = result.OrderBy(p => p.Sequence).Cast<ELMAH_Error>().ToList();
                }
                else
                {
                    if (orderCriteria == "Application") result = result.OrderByDescending(p => p.Application).Cast<ELMAH_Error>().ToList();
                    if (orderCriteria == "Host") result = result.OrderByDescending(p => p.Host).Cast<ELMAH_Error>().ToList();
                    if (orderCriteria == "Type") result = result.OrderByDescending(p => p.Type).Cast<ELMAH_Error>().ToList();
                    if (orderCriteria == "Source") result = result.OrderByDescending(p => p.Source).Cast<ELMAH_Error>().ToList();
                    if (orderCriteria == "Message") result = result.OrderByDescending(p => p.Message).Cast<ELMAH_Error>().ToList();
                    if (orderCriteria == "User") result = result.OrderByDescending(p => p.User).Cast<ELMAH_Error>().ToList();
                    if (orderCriteria == "StatusCode") result = result.OrderByDescending(p => p.StatusCode).Cast<ELMAH_Error>().ToList();
                    if (orderCriteria == "TimeUtc") result = result.OrderByDescending(p => p.TimeUtc).Cast<ELMAH_Error>().ToList();
                    if (orderCriteria == "Sequence") result = result.OrderByDescending(p => p.Sequence).Cast<ELMAH_Error>().ToList();
                }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r => r.Application != null && r.Application.ToString().Contains(searchBy.ToUpper())
                 || r.Host != null && r.Host.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.Type != null && r.Type.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.Source != null && r.Source.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.Message != null && r.Message.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.User != null && r.User.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.StatusCode != null && r.StatusCode.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.TimeUtc != null && r.TimeUtc.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.Sequence != null && r.Sequence.ToString().ToUpper().Contains(searchBy.ToUpper())

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
                    data[i].ErrorId = SISPAE.Common.Utilidades.Encrypt($"id={data[i].ErrorId.ToString()}");

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
                return BadRequest(ex.Message);
            }
        }


        // GET api/GetAllRelation/
        /// <summary>
        /// CRUD de la entidad ELMAH_Error --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  ELMAH_Error!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ELMAH_Error</param>
        /// <response code="200">ELMAH_Error Consulto los registros exitosamente</response>
        /// <response code="400">ELMAH_Error tiene valores invalidos </response>
        /// <response code="401">ELMAH_Error No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ELMAH_Error en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new ELMAH_ErrorMs().GetAllByWithRelation().Cast<ELMAH_Error>().AsQueryable();
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
