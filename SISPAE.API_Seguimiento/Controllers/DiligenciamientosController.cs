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
    [SwaggerTag("Web API para CRUD de Diligenciamientos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class DiligenciamientosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Diligenciamientos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Diligenciamientos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Diligenciamientos</param>
        /// <response code="200">Diligenciamientos Consulto los registros exitosamente</response>
        /// <response code="400">Diligenciamientos tiene valores invalidos </response>
        /// <response code="401">Diligenciamientos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Diligenciamientos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new DiligenciamientosMs().GetAll().Cast<Diligenciamientos>().AsQueryable();
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
        /// CRUD de la entidad Diligenciamientos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Diligenciamientos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Diligenciamientos</param>
        /// <response code="200">Diligenciamientos Consulto los registros exitosamente</response>
        /// <response code="400">Diligenciamientos tiene valores invalidos </response>
        /// <response code="401">Diligenciamientos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Diligenciamientos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new DiligenciamientosMs().GetAllFull().Cast<Diligenciamientos>().AsQueryable();
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
        /// CRUD de la entidad Diligenciamientos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Diligenciamientos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Diligenciamientos</param>
        /// <response code="200">Diligenciamientos Consulto los registros exitosamente</response>
        /// <response code="400">Diligenciamientos tiene valores invalidos </response>
        /// <response code="401">Diligenciamientos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Diligenciamientos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new DiligenciamientosMs().GetById(new Diligenciamientos() { id = id });
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
        /// CRUD de la entidad Diligenciamientos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Seguimiento de la entidad  Diligenciamientos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Diligenciamientos</param>
        /// <response code="200">Diligenciamientos Creado</response>
        /// <response code="400">Diligenciamientos tiene valores invalidos </response>
        /// <response code="401">Diligenciamientos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Diligenciamientos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Diligenciamientos obj)
        {
            try
            {
                var result = new DiligenciamientosMs().Add(obj);
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
        /// CRUD de la entidad Diligenciamientos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Seguimiento de la entidad  Diligenciamientos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Diligenciamientos</param>
        /// <response code="200">Diligenciamientos Actualizado</response>
        /// <response code="400">Diligenciamientos tiene valores invalidos </response>
        /// <response code="401">Diligenciamientos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Diligenciamientos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Diligenciamientos obj)
        {
            try
            {
                var result = new DiligenciamientosMs().Update(obj);
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
        /// CRUD de la entidad Diligenciamientos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Seguimiento de la entidad  Diligenciamientos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Diligenciamientos</param>
        /// <response code="200">Diligenciamientos Eliminado</response>
        /// <response code="400">Diligenciamientos tiene valores invalidos </response>
        /// <response code="401">Diligenciamientos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Diligenciamientos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Diligenciamientos obj)
        {
           try
            {
                new DiligenciamientosMs().Delete(obj);
                return Ok();
            }
            catch (System.Exception ex)
            {
                  return BadRequest(ex.Message);
            }
        }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad Diligenciamientos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Diligenciamientos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Diligenciamientos</param>
        /// <response code="200">Diligenciamientos Resultado</response>
        /// <response code="400">Diligenciamientos tiene valores invalidos </response>
        /// <response code="401">Diligenciamientos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Diligenciamientos en este momento</response>
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
                var result = new DiligenciamientosMs().GetAllByWithRelation().Cast<Diligenciamientos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                  if (orderAscendingDirection)                  {                  if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Diligenciamientos>().ToList();  
                  if (orderCriteria == "ID_TipoDiligenciamiento") result = result.OrderBy(p => p.ID_TipoDiligenciamiento).Cast <Diligenciamientos>().ToList(); 
                   if (orderCriteria == "ID_Cuestionario") result = result.OrderBy(p => p.ID_Cuestionario).Cast <Diligenciamientos>().ToList(); 
                   if (orderCriteria == "sID_Cuestionarios") result = result.OrderBy(p => p.sID_Cuestionario).Cast <Diligenciamientos>().ToList(); 
                   if (orderCriteria == "ID_VisitaControlSocial") result = result.OrderBy(p => p.ID_VisitaControlSocial).Cast <Diligenciamientos>().ToList(); 
                   if (orderCriteria == "sID_VisitasControlSocial") result = result.OrderBy(p => p.sID_VisitaControlSocial).Cast <Diligenciamientos>().ToList(); 
                   if (orderCriteria == "ID_Visita") result = result.OrderBy(p => p.ID_Visita).Cast <Diligenciamientos>().ToList(); 
                   if (orderCriteria == "sID_Visitas") result = result.OrderBy(p => p.sID_Visita).Cast <Diligenciamientos>().ToList(); 
                   if (orderCriteria == "ID_EstadoDiligenciamiento") result = result.OrderBy(p => p.ID_EstadoDiligenciamiento).Cast <Diligenciamientos>().ToList(); 
                   if (orderCriteria == "sID_TiposEstadosDiligenciamiento") result = result.OrderBy(p => p.sID_EstadoDiligenciamiento).Cast <Diligenciamientos>().ToList(); 
                     }
  else 
                    {                  if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Diligenciamientos>().ToList();  
                  if (orderCriteria == "ID_TipoDiligenciamiento") result = result.OrderByDescending(p => p.ID_TipoDiligenciamiento).Cast <Diligenciamientos>().ToList(); 
                   if (orderCriteria == "ID_Cuestionario") result = result.OrderByDescending(p => p.ID_Cuestionario).Cast <Diligenciamientos>().ToList(); 
                   if (orderCriteria == "sID_Cuestionarios") result = result.OrderByDescending(p => p.sID_Cuestionario).Cast<Diligenciamientos>().ToList(); 
                   if (orderCriteria == "ID_VisitaControlSocial") result = result.OrderByDescending(p => p.ID_VisitaControlSocial).Cast <Diligenciamientos>().ToList(); 
                   if (orderCriteria == "sID_VisitasControlSocial") result = result.OrderByDescending(p => p.sID_VisitaControlSocial).Cast<Diligenciamientos>().ToList(); 
                   if (orderCriteria == "ID_Visita") result = result.OrderByDescending(p => p.ID_Visita).Cast <Diligenciamientos>().ToList(); 
                   if (orderCriteria == "sID_Visitas") result = result.OrderByDescending(p => p.sID_Visita).Cast<Diligenciamientos>().ToList(); 
                   if (orderCriteria == "ID_EstadoDiligenciamiento") result = result.OrderByDescending(p => p.ID_EstadoDiligenciamiento).Cast <Diligenciamientos>().ToList(); 
                   if (orderCriteria == "sID_TiposEstadosDiligenciamiento") result = result.OrderByDescending(p => p.sID_EstadoDiligenciamiento).Cast<Diligenciamientos>().ToList(); 
                     }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                   || r.ID_TipoDiligenciamiento != null && r.ID_TipoDiligenciamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_Cuestionario != null && r.ID_Cuestionario.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_Cuestionario != null && r.sID_Cuestionario.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_VisitaControlSocial != null && r.ID_VisitaControlSocial.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_VisitaControlSocial != null && r.sID_VisitaControlSocial.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_Visita != null && r.ID_Visita.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_Visita != null && r.sID_Visita.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_EstadoDiligenciamiento != null && r.ID_EstadoDiligenciamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_EstadoDiligenciamiento != null && r.sID_EstadoDiligenciamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad Diligenciamientos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Diligenciamientos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Diligenciamientos</param>
        /// <response code="200">Diligenciamientos Consulto los registros exitosamente</response>
        /// <response code="400">Diligenciamientos tiene valores invalidos </response>
        /// <response code="401">Diligenciamientos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Diligenciamientos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new DiligenciamientosMs().GetAllByWithRelation().Cast<Diligenciamientos>().AsQueryable();
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
