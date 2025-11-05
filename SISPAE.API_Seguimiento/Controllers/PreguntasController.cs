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
    [SwaggerTag("Web API para CRUD de Preguntas .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PreguntasController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Preguntas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Preguntas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Preguntas</param>
        /// <response code="200">Preguntas Consulto los registros exitosamente</response>
        /// <response code="400">Preguntas tiene valores invalidos </response>
        /// <response code="401">Preguntas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Preguntas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new PreguntasMs().GetAll().Cast<Preguntas>().AsQueryable();
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
        /// CRUD de la entidad Preguntas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Preguntas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Preguntas</param>
        /// <response code="200">Preguntas Consulto los registros exitosamente</response>
        /// <response code="400">Preguntas tiene valores invalidos </response>
        /// <response code="401">Preguntas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Preguntas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new PreguntasMs().GetAllFull().Cast<Preguntas>().AsQueryable();
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
        /// CRUD de la entidad Preguntas --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Preguntas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Preguntas</param>
        /// <response code="200">Preguntas Consulto los registros exitosamente</response>
        /// <response code="400">Preguntas tiene valores invalidos </response>
        /// <response code="401">Preguntas No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Preguntas en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new PreguntasMs().GetById(new Preguntas() { id = id });
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
        /// CRUD de la entidad Preguntas --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Seguimiento de la entidad  Preguntas!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Preguntas</param>
        /// <response code="200">Preguntas Creado</response>
        /// <response code="400">Preguntas tiene valores invalidos </response>
        /// <response code="401">Preguntas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Preguntas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Preguntas obj)
        {
            try
            {
                var result = new PreguntasMs().Add(obj);
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
        /// CRUD de la entidad Preguntas --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Seguimiento de la entidad  Preguntas!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Preguntas</param>
        /// <response code="200">Preguntas Actualizado</response>
        /// <response code="400">Preguntas tiene valores invalidos </response>
        /// <response code="401">Preguntas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Preguntas en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Preguntas obj)
        {
            try
            {
                var result = new PreguntasMs().Update(obj);
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
        /// CRUD de la entidad Preguntas --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Seguimiento de la entidad  Preguntas!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Preguntas</param>
        /// <response code="200">Preguntas Eliminado</response>
        /// <response code="400">Preguntas tiene valores invalidos </response>
        /// <response code="401">Preguntas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Preguntas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Preguntas obj)
        {
           try
            {
                new PreguntasMs().Delete(obj);
                return Ok();
            }
            catch (System.Exception ex)
            {
                  return BadRequest(ex.Message);
            }
        }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad Preguntas --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Preguntas!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Preguntas</param>
        /// <response code="200">Preguntas Resultado</response>
        /// <response code="400">Preguntas tiene valores invalidos </response>
        /// <response code="401">Preguntas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Preguntas en este momento</response>
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
                var result = new PreguntasMs().GetAllByWithRelation().Cast<Preguntas>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                  if (orderAscendingDirection)                  {                  if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Preguntas>().ToList();  
                  if (orderCriteria == "ID_Cuestionario") result = result.OrderBy(p => p.ID_Cuestionario).Cast <Preguntas>().ToList(); 
                   if (orderCriteria == "sID_Cuestionarios") result = result.OrderBy(p => p.sID_Cuestionario).Cast <Preguntas>().ToList(); 
                   if (orderCriteria == "ID_ETC") result = result.OrderBy(p => p.ID_ETC).Cast <Preguntas>().ToList(); 
                   if (orderCriteria == "sID_ETC") result = result.OrderBy(p => p.sID_ETC).Cast <Preguntas>().ToList(); 
                   if (orderCriteria == "Enunciado") result = result.OrderBy(p => p.Enunciado).Cast <Preguntas>().ToList(); 
                   if (orderCriteria == "Orden") result = result.OrderBy(p => p.Orden).Cast <Preguntas>().ToList(); 
                     }
  else 
                    {                  if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Preguntas>().ToList();  
                  if (orderCriteria == "ID_Cuestionario") result = result.OrderByDescending(p => p.ID_Cuestionario).Cast <Preguntas>().ToList(); 
                   if (orderCriteria == "sID_Cuestionarios") result = result.OrderByDescending(p => p.sID_Cuestionario).Cast<Preguntas>().ToList(); 
                   if (orderCriteria == "ID_ETC") result = result.OrderByDescending(p => p.ID_ETC).Cast <Preguntas>().ToList(); 
                   if (orderCriteria == "sID_ETC") result = result.OrderByDescending(p => p.sID_ETC).Cast<Preguntas>().ToList(); 
                   if (orderCriteria == "Enunciado") result = result.OrderByDescending(p => p.Enunciado).Cast <Preguntas>().ToList(); 
                   if (orderCriteria == "Orden") result = result.OrderByDescending(p => p.Orden).Cast <Preguntas>().ToList(); 
                     }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                   || r.ID_Cuestionario != null && r.ID_Cuestionario.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_Cuestionario != null && r.sID_Cuestionario.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_ETC != null && r.ID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_ETC != null && r.sID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Enunciado != null && r.Enunciado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Orden != null && r.Orden.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad Preguntas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Preguntas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Preguntas</param>
        /// <response code="200">Preguntas Consulto los registros exitosamente</response>
        /// <response code="400">Preguntas tiene valores invalidos </response>
        /// <response code="401">Preguntas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Preguntas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new PreguntasMs().GetAllByWithRelation().Cast<Preguntas>().AsQueryable();
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
