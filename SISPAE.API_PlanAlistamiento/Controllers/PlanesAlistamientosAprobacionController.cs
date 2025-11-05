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

namespace SISPAE.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de PlanesAlistamientosAprobacion .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PlanesAlistamientosAprobacionController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PlanesAlistamientosAprobacion --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  PlanesAlistamientosAprobacion!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlanesAlistamientosAprobacion</param>
        /// <response code="200">PlanesAlistamientosAprobacion Consulto los registros exitosamente</response>
        /// <response code="400">PlanesAlistamientosAprobacion tiene valores invalidos </response>
        /// <response code="401">PlanesAlistamientosAprobacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlanesAlistamientosAprobacion en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new PlanesAlistamientosAprobacionMs().GetAll().Cast<PlanesAlistamientosAprobacion>().AsQueryable();
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
        /// CRUD de la entidad PlanesAlistamientosAprobacion --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  PlanesAlistamientosAprobacion!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlanesAlistamientosAprobacion</param>
        /// <response code="200">PlanesAlistamientosAprobacion Consulto los registros exitosamente</response>
        /// <response code="400">PlanesAlistamientosAprobacion tiene valores invalidos </response>
        /// <response code="401">PlanesAlistamientosAprobacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlanesAlistamientosAprobacion en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new PlanesAlistamientosAprobacionMs().GetAllFull().Cast<PlanesAlistamientosAprobacion>().AsQueryable();
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
        /// CRUD de la entidad PlanesAlistamientosAprobacion --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  PlanesAlistamientosAprobacion!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlanesAlistamientosAprobacion</param>
        /// <response code="200">PlanesAlistamientosAprobacion Consulto los registros exitosamente</response>
        /// <response code="400">PlanesAlistamientosAprobacion tiene valores invalidos </response>
        /// <response code="401">PlanesAlistamientosAprobacion No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar PlanesAlistamientosAprobacion en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new PlanesAlistamientosAprobacionMs().GetById(new PlanesAlistamientosAprobacion() { id = id });
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
        /// CRUD de la entidad PlanesAlistamientosAprobacion --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE de la entidad  PlanesAlistamientosAprobacion!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de PlanesAlistamientosAprobacion</param>
        /// <response code="200">PlanesAlistamientosAprobacion Creado</response>
        /// <response code="400">PlanesAlistamientosAprobacion tiene valores invalidos </response>
        /// <response code="401">PlanesAlistamientosAprobacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear PlanesAlistamientosAprobacion en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] PlanesAlistamientosAprobacion obj)
        {
            try
            {
                var result = new PlanesAlistamientosAprobacionMs().Add(obj);
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
        /// CRUD de la entidad PlanesAlistamientosAprobacion --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE de la entidad  PlanesAlistamientosAprobacion!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de PlanesAlistamientosAprobacion</param>
        /// <response code="200">PlanesAlistamientosAprobacion Actualizado</response>
        /// <response code="400">PlanesAlistamientosAprobacion tiene valores invalidos </response>
        /// <response code="401">PlanesAlistamientosAprobacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar PlanesAlistamientosAprobacion en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] PlanesAlistamientosAprobacion obj)
        {
            try
            {
                var result = new PlanesAlistamientosAprobacionMs().Update(obj);
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
        /// CRUD de la entidad PlanesAlistamientosAprobacion --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE de la entidad  PlanesAlistamientosAprobacion!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de PlanesAlistamientosAprobacion</param>
        /// <response code="200">PlanesAlistamientosAprobacion Eliminado</response>
        /// <response code="400">PlanesAlistamientosAprobacion tiene valores invalidos </response>
        /// <response code="401">PlanesAlistamientosAprobacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar PlanesAlistamientosAprobacion en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] PlanesAlistamientosAprobacion obj)
        {
           try
            {
                new PlanesAlistamientosAprobacionMs().Delete(obj);
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
        /// DataTable de la entidad PlanesAlistamientosAprobacion --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  PlanesAlistamientosAprobacion!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de PlanesAlistamientosAprobacion</param>
        /// <response code="200">PlanesAlistamientosAprobacion Resultado</response>
        /// <response code="400">PlanesAlistamientosAprobacion tiene valores invalidos </response>
        /// <response code="401">PlanesAlistamientosAprobacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  PlanesAlistamientosAprobacion en este momento</response>
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

                var result = new PlanesAlistamientosAprobacionMs().GetAllByWithRelation().Cast<PlanesAlistamientosAprobacion>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <PlanesAlistamientosAprobacion>().ToList();  
                if (orderCriteria == "ID_PlanAlistamiento") result = result.OrderBy(p => p.ID_PlanAlistamiento).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "sID_PlanesAlistamientos") result = result.OrderBy(p => p.sID_PlanAlistamiento).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "ID_EstadoAlistamiento") result = result.OrderBy(p => p.ID_EstadoAlistamiento).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "FechaAprobacion") result = result.OrderBy(p => p.FechaAprobacion).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "ID_EstadoDocumento") result = result.OrderBy(p => p.ID_EstadoDocumento).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "sID_EstadoDocumento") result = result.OrderBy(p => p.sID_EstadoDocumento).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "Responsable") result = result.OrderBy(p => p.Responsable).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "RolResponsable") result = result.OrderBy(p => p.RolResponsable).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "Accion") result = result.OrderBy(p => p.Accion).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "Observaciones") result = result.OrderBy(p => p.Observaciones).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <PlanesAlistamientosAprobacion>().ToList();  
                if (orderCriteria == "ID_PlanAlistamiento") result = result.OrderByDescending(p => p.ID_PlanAlistamiento).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "sID_PlanesAlistamientos") result = result.OrderByDescending(p => p.sID_PlanAlistamiento).Cast<PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "ID_EstadoAlistamiento") result = result.OrderByDescending(p => p.ID_EstadoAlistamiento).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "FechaAprobacion") result = result.OrderByDescending(p => p.FechaAprobacion).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "ID_EstadoDocumento") result = result.OrderByDescending(p => p.ID_EstadoDocumento).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "sID_EstadoDocumento") result = result.OrderByDescending(p => p.sID_EstadoDocumento).Cast<PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "Responsable") result = result.OrderByDescending(p => p.Responsable).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "RolResponsable") result = result.OrderByDescending(p => p.RolResponsable).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "Accion") result = result.OrderByDescending(p => p.Accion).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                 if (orderCriteria == "Observaciones") result = result.OrderByDescending(p => p.Observaciones).Cast <PlanesAlistamientosAprobacion>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_PlanAlistamiento != null && r.ID_PlanAlistamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_PlanAlistamiento != null && r.sID_PlanAlistamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_EstadoAlistamiento != null && r.ID_EstadoAlistamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaAprobacion != null && r.FechaAprobacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_EstadoDocumento != null && r.ID_EstadoDocumento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_EstadoDocumento != null && r.sID_EstadoDocumento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Responsable != null && r.Responsable.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.RolResponsable != null && r.RolResponsable.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Accion != null && r.Accion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Observaciones != null && r.Observaciones.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad PlanesAlistamientosAprobacion --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  PlanesAlistamientosAprobacion!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlanesAlistamientosAprobacion</param>
        /// <response code="200">PlanesAlistamientosAprobacion Consulto los registros exitosamente</response>
        /// <response code="400">PlanesAlistamientosAprobacion tiene valores invalidos </response>
        /// <response code="401">PlanesAlistamientosAprobacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlanesAlistamientosAprobacion en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new PlanesAlistamientosAprobacionMs().GetAllByWithRelation().Cast<PlanesAlistamientosAprobacion>().AsQueryable();
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
