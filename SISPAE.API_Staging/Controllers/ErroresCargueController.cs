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
    [SwaggerTag("Web API para CRUD de ErroresCargue .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class ErroresCargueController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad ErroresCargue --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  ErroresCargue!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ErroresCargue</param>
        /// <response code="200">ErroresCargue Consulto los registros exitosamente</response>
        /// <response code="400">ErroresCargue tiene valores invalidos </response>
        /// <response code="401">ErroresCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ErroresCargue en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new ErroresCargueMs().GetAll().Cast<ErroresCargue>().AsQueryable();
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
        /// CRUD de la entidad ErroresCargue --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  ErroresCargue!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ErroresCargue</param>
        /// <response code="200">ErroresCargue Consulto los registros exitosamente</response>
        /// <response code="400">ErroresCargue tiene valores invalidos </response>
        /// <response code="401">ErroresCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ErroresCargue en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new ErroresCargueMs().GetAllFull().Cast<ErroresCargue>().AsQueryable();
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
        /// CRUD de la entidad ErroresCargue --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  ErroresCargue!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ErroresCargue</param>
        /// <response code="200">ErroresCargue Consulto los registros exitosamente</response>
        /// <response code="400">ErroresCargue tiene valores invalidos </response>
        /// <response code="401">ErroresCargue No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar ErroresCargue en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new ErroresCargueMs().GetById(new ErroresCargue() { id = id });
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
        /// CRUD de la entidad ErroresCargue --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Staging de la entidad  ErroresCargue!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de ErroresCargue</param>
        /// <response code="200">ErroresCargue Creado</response>
        /// <response code="400">ErroresCargue tiene valores invalidos </response>
        /// <response code="401">ErroresCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear ErroresCargue en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] ErroresCargue obj)
        {
            try
            {
                var result = new ErroresCargueMs().Add(obj);
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
        /// CRUD de la entidad ErroresCargue --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Staging de la entidad  ErroresCargue!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de ErroresCargue</param>
        /// <response code="200">ErroresCargue Actualizado</response>
        /// <response code="400">ErroresCargue tiene valores invalidos </response>
        /// <response code="401">ErroresCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar ErroresCargue en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] ErroresCargue obj)
        {
            try
            {
                var result = new ErroresCargueMs().Update(obj);
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
        /// CRUD de la entidad ErroresCargue --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Staging de la entidad  ErroresCargue!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de ErroresCargue</param>
        /// <response code="200">ErroresCargue Eliminado</response>
        /// <response code="400">ErroresCargue tiene valores invalidos </response>
        /// <response code="401">ErroresCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar ErroresCargue en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] ErroresCargue obj)
        {
           try
            {
                new ErroresCargueMs().Delete(obj);
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
        /// DataTable de la entidad ErroresCargue --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  ErroresCargue!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de ErroresCargue</param>
        /// <response code="200">ErroresCargue Resultado</response>
        /// <response code="400">ErroresCargue tiene valores invalidos </response>
        /// <response code="401">ErroresCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  ErroresCargue en este momento</response>
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

                var result = new ErroresCargueMs().GetAllByWithRelation().Cast<ErroresCargue>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <ErroresCargue>().ToList();  
                if (orderCriteria == "ID_ProcesosCargue") result = result.OrderBy(p => p.ID_ProcesosCargue).Cast <ErroresCargue>().ToList(); 
                 if (orderCriteria == "sID_ProcesosCargue") result = result.OrderBy(p => p.sID_ProcesosCargue).Cast <ErroresCargue>().ToList(); 
                 if (orderCriteria == "ID_TipoProcesoCargue") result = result.OrderBy(p => p.ID_TipoProcesoCargue).Cast <ErroresCargue>().ToList(); 
                 if (orderCriteria == "sID_TipoProcesosCargue") result = result.OrderBy(p => p.sID_TipoProcesoCargue).Cast <ErroresCargue>().ToList(); 
                 if (orderCriteria == "ID_TipoErroresCargue") result = result.OrderBy(p => p.ID_TipoErroresCargue).Cast <ErroresCargue>().ToList(); 
                 if (orderCriteria == "sID_TipoErroresCargue") result = result.OrderBy(p => p.sID_TipoErroresCargue).Cast <ErroresCargue>().ToList(); 
                 if (orderCriteria == "PER_ID") result = result.OrderBy(p => p.PER_ID).Cast <ErroresCargue>().ToList(); 
                 if (orderCriteria == "Fila") result = result.OrderBy(p => p.Fila).Cast <ErroresCargue>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <ErroresCargue>().ToList();  
                if (orderCriteria == "ID_ProcesosCargue") result = result.OrderByDescending(p => p.ID_ProcesosCargue).Cast <ErroresCargue>().ToList(); 
                 if (orderCriteria == "sID_ProcesosCargue") result = result.OrderByDescending(p => p.sID_ProcesosCargue).Cast<ErroresCargue>().ToList(); 
                 if (orderCriteria == "ID_TipoProcesoCargue") result = result.OrderByDescending(p => p.ID_TipoProcesoCargue).Cast <ErroresCargue>().ToList(); 
                 if (orderCriteria == "sID_TipoProcesosCargue") result = result.OrderByDescending(p => p.sID_TipoProcesoCargue).Cast<ErroresCargue>().ToList(); 
                 if (orderCriteria == "ID_TipoErroresCargue") result = result.OrderByDescending(p => p.ID_TipoErroresCargue).Cast <ErroresCargue>().ToList(); 
                 if (orderCriteria == "sID_TipoErroresCargue") result = result.OrderByDescending(p => p.sID_TipoErroresCargue).Cast<ErroresCargue>().ToList(); 
                 if (orderCriteria == "PER_ID") result = result.OrderByDescending(p => p.PER_ID).Cast <ErroresCargue>().ToList(); 
                 if (orderCriteria == "Fila") result = result.OrderByDescending(p => p.Fila).Cast <ErroresCargue>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_ProcesosCargue != null && r.ID_ProcesosCargue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ProcesosCargue != null && r.sID_ProcesosCargue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoProcesoCargue != null && r.ID_TipoProcesoCargue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoProcesoCargue != null && r.sID_TipoProcesoCargue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoErroresCargue != null && r.ID_TipoErroresCargue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoErroresCargue != null && r.sID_TipoErroresCargue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PER_ID != null && r.PER_ID.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Fila != null && r.Fila.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad ErroresCargue --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  ErroresCargue!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ErroresCargue</param>
        /// <response code="200">ErroresCargue Consulto los registros exitosamente</response>
        /// <response code="400">ErroresCargue tiene valores invalidos </response>
        /// <response code="401">ErroresCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ErroresCargue en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new ErroresCargueMs().GetAllByWithRelation().Cast<ErroresCargue>().AsQueryable();
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
