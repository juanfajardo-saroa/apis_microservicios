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
    [SwaggerTag("Web API para CRUD de AccionesMejora .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class AccionesMejoraController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad AccionesMejora --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  AccionesMejora!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AccionesMejora</param>
        /// <response code="200">AccionesMejora Consulto los registros exitosamente</response>
        /// <response code="400">AccionesMejora tiene valores invalidos </response>
        /// <response code="401">AccionesMejora No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AccionesMejora en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new AccionesMejoraMs().GetAll().Cast<AccionesMejora>().AsQueryable();
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
        /// CRUD de la entidad AccionesMejora --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  AccionesMejora!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AccionesMejora</param>
        /// <response code="200">AccionesMejora Consulto los registros exitosamente</response>
        /// <response code="400">AccionesMejora tiene valores invalidos </response>
        /// <response code="401">AccionesMejora No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AccionesMejora en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new AccionesMejoraMs().GetAllFull().Cast<AccionesMejora>().AsQueryable();
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
        /// CRUD de la entidad AccionesMejora --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  AccionesMejora!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AccionesMejora</param>
        /// <response code="200">AccionesMejora Consulto los registros exitosamente</response>
        /// <response code="400">AccionesMejora tiene valores invalidos </response>
        /// <response code="401">AccionesMejora No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar AccionesMejora en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new AccionesMejoraMs().GetById(new AccionesMejora() { ID = id });
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
        /// CRUD de la entidad AccionesMejora --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Seguimiento de la entidad  AccionesMejora!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de AccionesMejora</param>
        /// <response code="200">AccionesMejora Creado</response>
        /// <response code="400">AccionesMejora tiene valores invalidos </response>
        /// <response code="401">AccionesMejora No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear AccionesMejora en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] AccionesMejora obj)
        {
            try
            {
                var result = new AccionesMejoraMs().Add(obj);
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
        /// CRUD de la entidad AccionesMejora --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Seguimiento de la entidad  AccionesMejora!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de AccionesMejora</param>
        /// <response code="200">AccionesMejora Actualizado</response>
        /// <response code="400">AccionesMejora tiene valores invalidos </response>
        /// <response code="401">AccionesMejora No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar AccionesMejora en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] AccionesMejora obj)
        {
            try
            {
                var result = new AccionesMejoraMs().Update(obj);
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
        /// CRUD de la entidad AccionesMejora --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Seguimiento de la entidad  AccionesMejora!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de AccionesMejora</param>
        /// <response code="200">AccionesMejora Eliminado</response>
        /// <response code="400">AccionesMejora tiene valores invalidos </response>
        /// <response code="401">AccionesMejora No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar AccionesMejora en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] AccionesMejora obj)
        {
           try
            {
                new AccionesMejoraMs().Delete(obj);
                return Ok();
            }
            catch (System.Exception ex)
            {
                  return BadRequest(ex.Message);
            }
        }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad AccionesMejora --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  AccionesMejora!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de AccionesMejora</param>
        /// <response code="200">AccionesMejora Resultado</response>
        /// <response code="400">AccionesMejora tiene valores invalidos </response>
        /// <response code="401">AccionesMejora No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  AccionesMejora en este momento</response>
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
                var result = new AccionesMejoraMs().GetAllByWithRelation().Cast<AccionesMejora>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                  if (orderAscendingDirection)                  {                  if (orderCriteria =="ID") result = result.OrderBy(p => p.ID).Cast <AccionesMejora>().ToList();  
                  if (orderCriteria == "ID_Area") result = result.OrderBy(p => p.ID_Area).Cast <AccionesMejora>().ToList(); 
                   if (orderCriteria == "sID_AreasIdentificadas") result = result.OrderBy(p => p.sID_Area).Cast <AccionesMejora>().ToList(); 
                   if (orderCriteria == "ID_Visita") result = result.OrderBy(p => p.ID_Visita).Cast <AccionesMejora>().ToList(); 
                   if (orderCriteria == "sID_Visitas") result = result.OrderBy(p => p.sID_Visita).Cast <AccionesMejora>().ToList(); 
                   if (orderCriteria == "ID_TipoEstadoAccionMejora") result = result.OrderBy(p => p.ID_TipoEstadoAccionMejora).Cast <AccionesMejora>().ToList(); 
                   if (orderCriteria == "sID_TiposEstadoAccionMejora") result = result.OrderBy(p => p.sID_TipoEstadoAccionMejora).Cast <AccionesMejora>().ToList(); 
                   if (orderCriteria == "FechaLimite") result = result.OrderBy(p => p.FechaLimite).Cast <AccionesMejora>().ToList(); 
                       }
  else 
                    {                  if (orderCriteria == "ID") result = result.OrderByDescending(p => p.ID).Cast <AccionesMejora>().ToList();  
                  if (orderCriteria == "ID_Area") result = result.OrderByDescending(p => p.ID_Area).Cast <AccionesMejora>().ToList(); 
                   if (orderCriteria == "sID_AreasIdentificadas") result = result.OrderByDescending(p => p.sID_Area).Cast<AccionesMejora>().ToList(); 
                   if (orderCriteria == "ID_Visita") result = result.OrderByDescending(p => p.ID_Visita).Cast <AccionesMejora>().ToList(); 
                   if (orderCriteria == "sID_Visitas") result = result.OrderByDescending(p => p.sID_Visita).Cast<AccionesMejora>().ToList(); 
                   if (orderCriteria == "ID_TipoEstadoAccionMejora") result = result.OrderByDescending(p => p.ID_TipoEstadoAccionMejora).Cast <AccionesMejora>().ToList(); 
                   if (orderCriteria == "sID_TiposEstadoAccionMejora") result = result.OrderByDescending(p => p.sID_TipoEstadoAccionMejora).Cast<AccionesMejora>().ToList(); 
                   if (orderCriteria == "FechaLimite") result = result.OrderByDescending(p => p.FechaLimite).Cast <AccionesMejora>().ToList(); 
                       }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r=> r.ID != null && r.ID.ToString().Contains(searchBy.ToUpper())  
                   || r.ID_Area != null && r.ID_Area.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_Area != null && r.sID_Area.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_Visita != null && r.ID_Visita.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_Visita != null && r.sID_Visita.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_TipoEstadoAccionMejora != null && r.ID_TipoEstadoAccionMejora.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_TipoEstadoAccionMejora != null && r.sID_TipoEstadoAccionMejora.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.FechaLimite != null && r.FechaLimite.ToString().ToUpper().Contains(searchBy.ToUpper()) 
      
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
        /// CRUD de la entidad AccionesMejora --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  AccionesMejora!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AccionesMejora</param>
        /// <response code="200">AccionesMejora Consulto los registros exitosamente</response>
        /// <response code="400">AccionesMejora tiene valores invalidos </response>
        /// <response code="401">AccionesMejora No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AccionesMejora en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new AccionesMejoraMs().GetAllByWithRelation().Cast<AccionesMejora>().AsQueryable();
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
