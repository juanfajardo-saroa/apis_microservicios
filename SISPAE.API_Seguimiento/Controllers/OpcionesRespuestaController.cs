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
    [SwaggerTag("Web API para CRUD de OpcionesRespuesta .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class OpcionesRespuestaController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad OpcionesRespuesta --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  OpcionesRespuesta!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de OpcionesRespuesta</param>
        /// <response code="200">OpcionesRespuesta Consulto los registros exitosamente</response>
        /// <response code="400">OpcionesRespuesta tiene valores invalidos </response>
        /// <response code="401">OpcionesRespuesta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar OpcionesRespuesta en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new OpcionesRespuestaMs().GetAll().Cast<OpcionesRespuesta>().AsQueryable();
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
        /// CRUD de la entidad OpcionesRespuesta --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  OpcionesRespuesta!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de OpcionesRespuesta</param>
        /// <response code="200">OpcionesRespuesta Consulto los registros exitosamente</response>
        /// <response code="400">OpcionesRespuesta tiene valores invalidos </response>
        /// <response code="401">OpcionesRespuesta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar OpcionesRespuesta en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new OpcionesRespuestaMs().GetAllFull().Cast<OpcionesRespuesta>().AsQueryable();
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
        /// CRUD de la entidad OpcionesRespuesta --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  OpcionesRespuesta!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de OpcionesRespuesta</param>
        /// <response code="200">OpcionesRespuesta Consulto los registros exitosamente</response>
        /// <response code="400">OpcionesRespuesta tiene valores invalidos </response>
        /// <response code="401">OpcionesRespuesta No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar OpcionesRespuesta en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new OpcionesRespuestaMs().GetById(new OpcionesRespuesta() { id = id });
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
        /// CRUD de la entidad OpcionesRespuesta --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Seguimiento de la entidad  OpcionesRespuesta!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de OpcionesRespuesta</param>
        /// <response code="200">OpcionesRespuesta Creado</response>
        /// <response code="400">OpcionesRespuesta tiene valores invalidos </response>
        /// <response code="401">OpcionesRespuesta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear OpcionesRespuesta en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] OpcionesRespuesta obj)
        {
            try
            {
                var result = new OpcionesRespuestaMs().Add(obj);
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
        /// CRUD de la entidad OpcionesRespuesta --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Seguimiento de la entidad  OpcionesRespuesta!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de OpcionesRespuesta</param>
        /// <response code="200">OpcionesRespuesta Actualizado</response>
        /// <response code="400">OpcionesRespuesta tiene valores invalidos </response>
        /// <response code="401">OpcionesRespuesta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar OpcionesRespuesta en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] OpcionesRespuesta obj)
        {
            try
            {
                var result = new OpcionesRespuestaMs().Update(obj);
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
        /// CRUD de la entidad OpcionesRespuesta --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Seguimiento de la entidad  OpcionesRespuesta!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de OpcionesRespuesta</param>
        /// <response code="200">OpcionesRespuesta Eliminado</response>
        /// <response code="400">OpcionesRespuesta tiene valores invalidos </response>
        /// <response code="401">OpcionesRespuesta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar OpcionesRespuesta en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] OpcionesRespuesta obj)
        {
           try
            {
                new OpcionesRespuestaMs().Delete(obj);
                return Ok();
            }
            catch (System.Exception ex)
            {
                  return BadRequest(ex.Message);
            }
        }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad OpcionesRespuesta --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  OpcionesRespuesta!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de OpcionesRespuesta</param>
        /// <response code="200">OpcionesRespuesta Resultado</response>
        /// <response code="400">OpcionesRespuesta tiene valores invalidos </response>
        /// <response code="401">OpcionesRespuesta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  OpcionesRespuesta en este momento</response>
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
                var result = new OpcionesRespuestaMs().GetAllByWithRelation().Cast<OpcionesRespuesta>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                  if (orderAscendingDirection)                  {                  if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <OpcionesRespuesta>().ToList();  
                  if (orderCriteria == "ID_lndicador") result = result.OrderBy(p => p.ID_lndicador).Cast <OpcionesRespuesta>().ToList(); 
                   if (orderCriteria == "sID_Indicadores") result = result.OrderBy(p => p.sID_lndicador).Cast <OpcionesRespuesta>().ToList(); 
                   if (orderCriteria == "ID_Pregunta") result = result.OrderBy(p => p.ID_Pregunta).Cast <OpcionesRespuesta>().ToList(); 
                   if (orderCriteria == "sID_Preguntas") result = result.OrderBy(p => p.sID_Pregunta).Cast <OpcionesRespuesta>().ToList(); 
                   if (orderCriteria == "Opcion") result = result.OrderBy(p => p.Opcion).Cast <OpcionesRespuesta>().ToList(); 
                   if (orderCriteria == "ValorPorcentrual") result = result.OrderBy(p => p.ValorPorcentrual).Cast <OpcionesRespuesta>().ToList(); 
                   if (orderCriteria == "RespuestaPositiva") result = result.OrderBy(p => p.RespuestaPositiva).Cast <OpcionesRespuesta>().ToList(); 
                     }
  else 
                    {                  if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <OpcionesRespuesta>().ToList();  
                  if (orderCriteria == "ID_lndicador") result = result.OrderByDescending(p => p.ID_lndicador).Cast <OpcionesRespuesta>().ToList(); 
                   if (orderCriteria == "sID_Indicadores") result = result.OrderByDescending(p => p.sID_lndicador).Cast<OpcionesRespuesta>().ToList(); 
                   if (orderCriteria == "ID_Pregunta") result = result.OrderByDescending(p => p.ID_Pregunta).Cast <OpcionesRespuesta>().ToList(); 
                   if (orderCriteria == "sID_Preguntas") result = result.OrderByDescending(p => p.sID_Pregunta).Cast<OpcionesRespuesta>().ToList(); 
                   if (orderCriteria == "Opcion") result = result.OrderByDescending(p => p.Opcion).Cast <OpcionesRespuesta>().ToList(); 
                   if (orderCriteria == "ValorPorcentrual") result = result.OrderByDescending(p => p.ValorPorcentrual).Cast <OpcionesRespuesta>().ToList(); 
                   if (orderCriteria == "RespuestaPositiva") result = result.OrderByDescending(p => p.RespuestaPositiva).Cast <OpcionesRespuesta>().ToList(); 
                     }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                   || r.ID_lndicador != null && r.ID_lndicador.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_lndicador != null && r.sID_lndicador.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_Pregunta != null && r.ID_Pregunta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_Pregunta != null && r.sID_Pregunta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Opcion != null && r.Opcion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ValorPorcentrual != null && r.ValorPorcentrual.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.RespuestaPositiva != null && r.RespuestaPositiva.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad OpcionesRespuesta --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  OpcionesRespuesta!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de OpcionesRespuesta</param>
        /// <response code="200">OpcionesRespuesta Consulto los registros exitosamente</response>
        /// <response code="400">OpcionesRespuesta tiene valores invalidos </response>
        /// <response code="401">OpcionesRespuesta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar OpcionesRespuesta en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new OpcionesRespuestaMs().GetAllByWithRelation().Cast<OpcionesRespuesta>().AsQueryable();
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
