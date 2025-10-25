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
    [SwaggerTag("Web API para CRUD de PoblacionAtendida .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PoblacionAtendidaController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PoblacionAtendida --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  PoblacionAtendida!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PoblacionAtendida</param>
        /// <response code="200">PoblacionAtendida Consulto los registros exitosamente</response>
        /// <response code="400">PoblacionAtendida tiene valores invalidos </response>
        /// <response code="401">PoblacionAtendida No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PoblacionAtendida en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new PoblacionAtendidaMs().GetAll().Cast<PoblacionAtendida>().AsQueryable();
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
        /// CRUD de la entidad PoblacionAtendida --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  PoblacionAtendida!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PoblacionAtendida</param>
        /// <response code="200">PoblacionAtendida Consulto los registros exitosamente</response>
        /// <response code="400">PoblacionAtendida tiene valores invalidos </response>
        /// <response code="401">PoblacionAtendida No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PoblacionAtendida en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new PoblacionAtendidaMs().GetAllFull().Cast<PoblacionAtendida>().AsQueryable();
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
        /// CRUD de la entidad PoblacionAtendida --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  PoblacionAtendida!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PoblacionAtendida</param>
        /// <response code="200">PoblacionAtendida Consulto los registros exitosamente</response>
        /// <response code="400">PoblacionAtendida tiene valores invalidos </response>
        /// <response code="401">PoblacionAtendida No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar PoblacionAtendida en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new PoblacionAtendidaMs().GetById(new PoblacionAtendida() { id = id });
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
        /// CRUD de la entidad PoblacionAtendida --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Seguimiento de la entidad  PoblacionAtendida!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de PoblacionAtendida</param>
        /// <response code="200">PoblacionAtendida Creado</response>
        /// <response code="400">PoblacionAtendida tiene valores invalidos </response>
        /// <response code="401">PoblacionAtendida No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear PoblacionAtendida en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] PoblacionAtendida obj)
        {
            try
            {
                var result = new PoblacionAtendidaMs().Add(obj);
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
        /// CRUD de la entidad PoblacionAtendida --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Seguimiento de la entidad  PoblacionAtendida!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de PoblacionAtendida</param>
        /// <response code="200">PoblacionAtendida Actualizado</response>
        /// <response code="400">PoblacionAtendida tiene valores invalidos </response>
        /// <response code="401">PoblacionAtendida No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar PoblacionAtendida en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] PoblacionAtendida obj)
        {
            try
            {
                var result = new PoblacionAtendidaMs().Update(obj);
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
        /// CRUD de la entidad PoblacionAtendida --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Seguimiento de la entidad  PoblacionAtendida!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de PoblacionAtendida</param>
        /// <response code="200">PoblacionAtendida Eliminado</response>
        /// <response code="400">PoblacionAtendida tiene valores invalidos </response>
        /// <response code="401">PoblacionAtendida No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar PoblacionAtendida en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] PoblacionAtendida obj)
        {
           try
            {
                new PoblacionAtendidaMs().Delete(obj);
                return Ok();
            }
            catch (System.Exception ex)
            {
                  return BadRequest(ex.Message);
            }
        }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad PoblacionAtendida --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  PoblacionAtendida!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de PoblacionAtendida</param>
        /// <response code="200">PoblacionAtendida Resultado</response>
        /// <response code="400">PoblacionAtendida tiene valores invalidos </response>
        /// <response code="401">PoblacionAtendida No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  PoblacionAtendida en este momento</response>
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
                var result = new PoblacionAtendidaMs().GetAllByWithRelation().Cast<PoblacionAtendida>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                  if (orderAscendingDirection)                  {                  if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <PoblacionAtendida>().ToList();  
                  if (orderCriteria == "ID_TipoPoblacionAtendida") result = result.OrderBy(p => p.ID_TipoPoblacionAtendida).Cast <PoblacionAtendida>().ToList(); 
                   if (orderCriteria == "sID_TiposPoblacionAtendida") result = result.OrderBy(p => p.sID_TipoPoblacionAtendida).Cast <PoblacionAtendida>().ToList(); 
                   if (orderCriteria == "ID_TipoPoblacionEtnica") result = result.OrderBy(p => p.ID_TipoPoblacionEtnica).Cast <PoblacionAtendida>().ToList(); 
                   if (orderCriteria == "sID_TiposPoblacionEtnica") result = result.OrderBy(p => p.sID_TipoPoblacionEtnica).Cast <PoblacionAtendida>().ToList(); 
                   if (orderCriteria == "ID_AgrupacionMensual") result = result.OrderBy(p => p.ID_AgrupacionMensual).Cast <PoblacionAtendida>().ToList(); 
                   if (orderCriteria == "sID_AgrupacionesMensual") result = result.OrderBy(p => p.sID_AgrupacionMensual).Cast <PoblacionAtendida>().ToList(); 
                   if (orderCriteria == "CantidadTitul") result = result.OrderBy(p => p.CantidadTitul).Cast <PoblacionAtendida>().ToList(); 
                   if (orderCriteria == "CantidadVictima") result = result.OrderBy(p => p.CantidadVictima).Cast <PoblacionAtendida>().ToList(); 
                   if (orderCriteria == "Cantidad") result = result.OrderBy(p => p.Cantidad).Cast <PoblacionAtendida>().ToList(); 
                     }
  else 
                    {                  if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <PoblacionAtendida>().ToList();  
                  if (orderCriteria == "ID_TipoPoblacionAtendida") result = result.OrderByDescending(p => p.ID_TipoPoblacionAtendida).Cast <PoblacionAtendida>().ToList(); 
                   if (orderCriteria == "sID_TiposPoblacionAtendida") result = result.OrderByDescending(p => p.sID_TipoPoblacionAtendida).Cast<PoblacionAtendida>().ToList(); 
                   if (orderCriteria == "ID_TipoPoblacionEtnica") result = result.OrderByDescending(p => p.ID_TipoPoblacionEtnica).Cast <PoblacionAtendida>().ToList(); 
                   if (orderCriteria == "sID_TiposPoblacionEtnica") result = result.OrderByDescending(p => p.sID_TipoPoblacionEtnica).Cast<PoblacionAtendida>().ToList(); 
                   if (orderCriteria == "ID_AgrupacionMensual") result = result.OrderByDescending(p => p.ID_AgrupacionMensual).Cast <PoblacionAtendida>().ToList(); 
                   if (orderCriteria == "sID_AgrupacionesMensual") result = result.OrderByDescending(p => p.sID_AgrupacionMensual).Cast<PoblacionAtendida>().ToList(); 
                   if (orderCriteria == "CantidadTitul") result = result.OrderByDescending(p => p.CantidadTitul).Cast <PoblacionAtendida>().ToList(); 
                   if (orderCriteria == "CantidadVictima") result = result.OrderByDescending(p => p.CantidadVictima).Cast <PoblacionAtendida>().ToList(); 
                   if (orderCriteria == "Cantidad") result = result.OrderByDescending(p => p.Cantidad).Cast <PoblacionAtendida>().ToList(); 
                     }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                   || r.ID_TipoPoblacionAtendida != null && r.ID_TipoPoblacionAtendida.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_TipoPoblacionAtendida != null && r.sID_TipoPoblacionAtendida.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_TipoPoblacionEtnica != null && r.ID_TipoPoblacionEtnica.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_TipoPoblacionEtnica != null && r.sID_TipoPoblacionEtnica.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_AgrupacionMensual != null && r.ID_AgrupacionMensual.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_AgrupacionMensual != null && r.sID_AgrupacionMensual.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.CantidadTitul != null && r.CantidadTitul.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.CantidadVictima != null && r.CantidadVictima.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Cantidad != null && r.Cantidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad PoblacionAtendida --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  PoblacionAtendida!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PoblacionAtendida</param>
        /// <response code="200">PoblacionAtendida Consulto los registros exitosamente</response>
        /// <response code="400">PoblacionAtendida tiene valores invalidos </response>
        /// <response code="401">PoblacionAtendida No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PoblacionAtendida en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new PoblacionAtendidaMs().GetAllByWithRelation().Cast<PoblacionAtendida>().AsQueryable();
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
