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

namespace SISPAE_API_PlanAlistamiento.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de PlanesAlistamientos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PlanesAlistamientosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PlanesAlistamientos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlanesAlistamientos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlanesAlistamientos</param>
        /// <response code="200">PlanesAlistamientos Consulto los registros exitosamente</response>
        /// <response code="400">PlanesAlistamientos tiene valores invalidos </response>
        /// <response code="401">PlanesAlistamientos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlanesAlistamientos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new PlanesAlistamientosMs().GetAll().Cast<PlanesAlistamientos>().AsQueryable();
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
        /// CRUD de la entidad PlanesAlistamientos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlanesAlistamientos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlanesAlistamientos</param>
        /// <response code="200">PlanesAlistamientos Consulto los registros exitosamente</response>
        /// <response code="400">PlanesAlistamientos tiene valores invalidos </response>
        /// <response code="401">PlanesAlistamientos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlanesAlistamientos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new PlanesAlistamientosMs().GetAllFull().Cast<PlanesAlistamientos>().AsQueryable();
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
        /// CRUD de la entidad PlanesAlistamientos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlanesAlistamientos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlanesAlistamientos</param>
        /// <response code="200">PlanesAlistamientos Consulto los registros exitosamente</response>
        /// <response code="400">PlanesAlistamientos tiene valores invalidos </response>
        /// <response code="401">PlanesAlistamientos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar PlanesAlistamientos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new PlanesAlistamientosMs().GetById(new PlanesAlistamientos() { ID = id });
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
        /// CRUD de la entidad PlanesAlistamientos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlanesAlistamientos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de PlanesAlistamientos</param>
        /// <response code="200">PlanesAlistamientos Creado</response>
        /// <response code="400">PlanesAlistamientos tiene valores invalidos </response>
        /// <response code="401">PlanesAlistamientos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear PlanesAlistamientos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] PlanesAlistamientos obj)
        {
            try
            {
                var result = new PlanesAlistamientosMs().Add(obj);
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
        /// CRUD de la entidad PlanesAlistamientos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlanesAlistamientos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de PlanesAlistamientos</param>
        /// <response code="200">PlanesAlistamientos Actualizado</response>
        /// <response code="400">PlanesAlistamientos tiene valores invalidos </response>
        /// <response code="401">PlanesAlistamientos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar PlanesAlistamientos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] PlanesAlistamientos obj)
        {
            try
            {
                var result = new PlanesAlistamientosMs().Update(obj);
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
        /// CRUD de la entidad PlanesAlistamientos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlanesAlistamientos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de PlanesAlistamientos</param>
        /// <response code="200">PlanesAlistamientos Eliminado</response>
        /// <response code="400">PlanesAlistamientos tiene valores invalidos </response>
        /// <response code="401">PlanesAlistamientos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar PlanesAlistamientos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] PlanesAlistamientos obj)
        {
           try
            {
                new PlanesAlistamientosMs().Delete(obj);
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
        /// DataTable de la entidad PlanesAlistamientos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  PlanesAlistamientos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de PlanesAlistamientos</param>
        /// <response code="200">PlanesAlistamientos Resultado</response>
        /// <response code="400">PlanesAlistamientos tiene valores invalidos </response>
        /// <response code="401">PlanesAlistamientos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  PlanesAlistamientos en este momento</response>
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

                var result = new PlanesAlistamientosMs().GetAllByWithRelation().Cast<PlanesAlistamientos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="ID") result = result.OrderBy(p => p.ID).Cast <PlanesAlistamientos>().ToList();  
                if (orderCriteria == "ID_EstadoBodegas") result = result.OrderBy(p => p.ID_EstadoBodegas).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "ID_EstadoDocumentacion") result = result.OrderBy(p => p.ID_EstadoDocumentacion).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "ID_EstadoMenus") result = result.OrderBy(p => p.ID_EstadoMenus).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "sID_EstadosValidacion") result = result.OrderBy(p => p.sID_EstadoMenus).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "ID_EstadoRutas") result = result.OrderBy(p => p.ID_EstadoRutas).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "ID_EstadoActaInicio") result = result.OrderBy(p => p.ID_EstadoActaInicio).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "sID_EstadosValidacion") result = result.OrderBy(p => p.sID_EstadoActaInicio).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "ID_TipoEstadoAlistamiento") result = result.OrderBy(p => p.ID_TipoEstadoAlistamiento).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "sID_TiposEstadosAlistamiento") result = result.OrderBy(p => p.sID_TipoEstadoAlistamiento).Cast <PlanesAlistamientos>().ToList(); 
                   if (orderCriteria == "RutasporModeloOperacion") result = result.OrderBy(p => p.RutasporModeloOperacion).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "id_contrato") result = result.OrderBy(p => p.id_contrato).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderBy(p => p.sid_contrato).Cast <PlanesAlistamientos>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "ID") result = result.OrderByDescending(p => p.ID).Cast <PlanesAlistamientos>().ToList();  
                if (orderCriteria == "ID_EstadoBodegas") result = result.OrderByDescending(p => p.ID_EstadoBodegas).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "ID_EstadoDocumentacion") result = result.OrderByDescending(p => p.ID_EstadoDocumentacion).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "ID_EstadoMenus") result = result.OrderByDescending(p => p.ID_EstadoMenus).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "sID_EstadosValidacion") result = result.OrderByDescending(p => p.sID_EstadoMenus).Cast<PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "ID_EstadoRutas") result = result.OrderByDescending(p => p.ID_EstadoRutas).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "ID_EstadoActaInicio") result = result.OrderByDescending(p => p.ID_EstadoActaInicio).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "sID_EstadosValidacion") result = result.OrderByDescending(p => p.sID_EstadoActaInicio).Cast<PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "ID_TipoEstadoAlistamiento") result = result.OrderByDescending(p => p.ID_TipoEstadoAlistamiento).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "sID_TiposEstadosAlistamiento") result = result.OrderByDescending(p => p.sID_TipoEstadoAlistamiento).Cast<PlanesAlistamientos>().ToList(); 
                   if (orderCriteria == "RutasporModeloOperacion") result = result.OrderByDescending(p => p.RutasporModeloOperacion).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "id_contrato") result = result.OrderByDescending(p => p.id_contrato).Cast <PlanesAlistamientos>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderByDescending(p => p.sid_contrato).Cast<PlanesAlistamientos>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.ID != null && r.ID.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_EstadoBodegas != null && r.ID_EstadoBodegas.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_EstadoDocumentacion != null && r.ID_EstadoDocumentacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_EstadoMenus != null && r.ID_EstadoMenus.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_EstadoMenus != null && r.sID_EstadoMenus.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_EstadoRutas != null && r.ID_EstadoRutas.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_EstadoActaInicio != null && r.ID_EstadoActaInicio.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_EstadoActaInicio != null && r.sID_EstadoActaInicio.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoEstadoAlistamiento != null && r.ID_TipoEstadoAlistamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoEstadoAlistamiento != null && r.sID_TipoEstadoAlistamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.RutasporModeloOperacion != null && r.RutasporModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.id_contrato != null && r.id_contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                || r.sid_contrato != null && r.sid_contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
  
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
        /// CRUD de la entidad PlanesAlistamientos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlanesAlistamientos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlanesAlistamientos</param>
        /// <response code="200">PlanesAlistamientos Consulto los registros exitosamente</response>
        /// <response code="400">PlanesAlistamientos tiene valores invalidos </response>
        /// <response code="401">PlanesAlistamientos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlanesAlistamientos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new PlanesAlistamientosMs().GetAllByWithRelation().Cast<PlanesAlistamientos>().AsQueryable();
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
