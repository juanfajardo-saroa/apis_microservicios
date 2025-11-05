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
using Microsoft.AspNetCore.OData.Query; using ElmahCore;




// create, index, delete, update , read
//  details, listall, 

namespace SISPAE_API_Seguimiento.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de Respuestas .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class RespuestasController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Respuestas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Respuestas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Respuestas</param>
        /// <response code="200">Respuestas Consulto los registros exitosamente</response>
        /// <response code="400">Respuestas tiene valores invalidos </response>
        /// <response code="401">Respuestas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Respuestas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new RespuestasMs().GetAll().Cast<Respuestas>().AsQueryable();
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
        /// CRUD de la entidad Respuestas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Respuestas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Respuestas</param>
        /// <response code="200">Respuestas Consulto los registros exitosamente</response>
        /// <response code="400">Respuestas tiene valores invalidos </response>
        /// <response code="401">Respuestas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Respuestas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new RespuestasMs().GetAllFull().Cast<Respuestas>().AsQueryable();
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
        /// CRUD de la entidad Respuestas --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Respuestas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Respuestas</param>
        /// <response code="200">Respuestas Consulto los registros exitosamente</response>
        /// <response code="400">Respuestas tiene valores invalidos </response>
        /// <response code="401">Respuestas No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Respuestas en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new RespuestasMs().GetById(new Respuestas() { id = id });
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
        /// CRUD de la entidad Respuestas --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Seguimiento de la entidad  Respuestas!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Respuestas</param>
        /// <response code="200">Respuestas Creado</response>
        /// <response code="400">Respuestas tiene valores invalidos </response>
        /// <response code="401">Respuestas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Respuestas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Respuestas obj)
        {
            try
            {
                var result = new RespuestasMs().Add(obj);
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
        /// CRUD de la entidad Respuestas --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Seguimiento de la entidad  Respuestas!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Respuestas</param>
        /// <response code="200">Respuestas Actualizado</response>
        /// <response code="400">Respuestas tiene valores invalidos </response>
        /// <response code="401">Respuestas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Respuestas en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Respuestas obj)
        {
            try
            {
                var result = new RespuestasMs().Update(obj);
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
        /// CRUD de la entidad Respuestas --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Seguimiento de la entidad  Respuestas!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Respuestas</param>
        /// <response code="200">Respuestas Eliminado</response>
        /// <response code="400">Respuestas tiene valores invalidos </response>
        /// <response code="401">Respuestas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Respuestas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Respuestas obj)
        {
           try
            {
                new RespuestasMs().Delete(obj);
                return Ok();
            }
            catch (System.Exception ex)
            {
                  return BadRequest(ex.Message);
            }
        }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad Respuestas --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Respuestas!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Respuestas</param>
        /// <response code="200">Respuestas Resultado</response>
        /// <response code="400">Respuestas tiene valores invalidos </response>
        /// <response code="401">Respuestas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Respuestas en este momento</response>
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
                var result = new RespuestasMs().GetAllByWithRelation().Cast<Respuestas>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                  if (orderAscendingDirection)                  {                  if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Respuestas>().ToList();  
                  if (orderCriteria == "ID_OpcionRespuesta") result = result.OrderBy(p => p.ID_OpcionRespuesta).Cast <Respuestas>().ToList(); 
                   if (orderCriteria == "sID_OpcionesRespuesta") result = result.OrderBy(p => p.sID_OpcionRespuesta).Cast <Respuestas>().ToList(); 
                   if (orderCriteria == "ID_Diligenciamiento") result = result.OrderBy(p => p.ID_Diligenciamiento).Cast <Respuestas>().ToList(); 
                   if (orderCriteria == "sID_Diligenciamientos") result = result.OrderBy(p => p.sID_Diligenciamiento).Cast <Respuestas>().ToList(); 
                   if (orderCriteria == "Respuesta") result = result.OrderBy(p => p.Respuesta).Cast <Respuestas>().ToList(); 
                     }
  else 
                    {                  if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Respuestas>().ToList();  
                  if (orderCriteria == "ID_OpcionRespuesta") result = result.OrderByDescending(p => p.ID_OpcionRespuesta).Cast <Respuestas>().ToList(); 
                   if (orderCriteria == "sID_OpcionesRespuesta") result = result.OrderByDescending(p => p.sID_OpcionRespuesta).Cast<Respuestas>().ToList(); 
                   if (orderCriteria == "ID_Diligenciamiento") result = result.OrderByDescending(p => p.ID_Diligenciamiento).Cast <Respuestas>().ToList(); 
                   if (orderCriteria == "sID_Diligenciamientos") result = result.OrderByDescending(p => p.sID_Diligenciamiento).Cast<Respuestas>().ToList(); 
                   if (orderCriteria == "Respuesta") result = result.OrderByDescending(p => p.Respuesta).Cast <Respuestas>().ToList(); 
                     }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                   || r.ID_OpcionRespuesta != null && r.ID_OpcionRespuesta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_OpcionRespuesta != null && r.sID_OpcionRespuesta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_Diligenciamiento != null && r.ID_Diligenciamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_Diligenciamiento != null && r.sID_Diligenciamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Respuesta != null && r.Respuesta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad Respuestas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Respuestas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Respuestas</param>
        /// <response code="200">Respuestas Consulto los registros exitosamente</response>
        /// <response code="400">Respuestas tiene valores invalidos </response>
        /// <response code="401">Respuestas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Respuestas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new RespuestasMs().GetAllByWithRelation().Cast<Respuestas>().AsQueryable();
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
