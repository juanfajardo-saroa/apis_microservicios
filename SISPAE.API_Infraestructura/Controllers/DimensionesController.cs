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

namespace SISPAE_API_Infraestructura.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de Dimensiones .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class DimensionesController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Dimensiones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Infraestructura de la entidad  Dimensiones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Dimensiones</param>
        /// <response code="200">Dimensiones Consulto los registros exitosamente</response>
        /// <response code="400">Dimensiones tiene valores invalidos </response>
        /// <response code="401">Dimensiones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Dimensiones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new DimensionesMs().GetAll().Cast<Dimensiones>().AsQueryable();
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
        /// CRUD de la entidad Dimensiones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Infraestructura de la entidad  Dimensiones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Dimensiones</param>
        /// <response code="200">Dimensiones Consulto los registros exitosamente</response>
        /// <response code="400">Dimensiones tiene valores invalidos </response>
        /// <response code="401">Dimensiones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Dimensiones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new DimensionesMs().GetAllFull().Cast<Dimensiones>().AsQueryable();
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
        /// CRUD de la entidad Dimensiones --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Infraestructura de la entidad  Dimensiones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Dimensiones</param>
        /// <response code="200">Dimensiones Consulto los registros exitosamente</response>
        /// <response code="400">Dimensiones tiene valores invalidos </response>
        /// <response code="401">Dimensiones No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Dimensiones en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new DimensionesMs().GetById(new Dimensiones() { id = id });
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
        /// CRUD de la entidad Dimensiones --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Infraestructura de la entidad  Dimensiones!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Dimensiones</param>
        /// <response code="200">Dimensiones Creado</response>
        /// <response code="400">Dimensiones tiene valores invalidos </response>
        /// <response code="401">Dimensiones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Dimensiones en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Dimensiones obj)
        {
            try
            {
                var result = new DimensionesMs().Add(obj);
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
        /// CRUD de la entidad Dimensiones --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Infraestructura de la entidad  Dimensiones!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Dimensiones</param>
        /// <response code="200">Dimensiones Actualizado</response>
        /// <response code="400">Dimensiones tiene valores invalidos </response>
        /// <response code="401">Dimensiones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Dimensiones en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Dimensiones obj)
        {
            try
            {
                var result = new DimensionesMs().Update(obj);
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
        /// CRUD de la entidad Dimensiones --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Infraestructura de la entidad  Dimensiones!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Dimensiones</param>
        /// <response code="200">Dimensiones Eliminado</response>
        /// <response code="400">Dimensiones tiene valores invalidos </response>
        /// <response code="401">Dimensiones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Dimensiones en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Dimensiones obj)
        {
           try
            {
                new DimensionesMs().Delete(obj);
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
        /// DataTable de la entidad Dimensiones --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Dimensiones!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Dimensiones</param>
        /// <response code="200">Dimensiones Resultado</response>
        /// <response code="400">Dimensiones tiene valores invalidos </response>
        /// <response code="401">Dimensiones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Dimensiones en este momento</response>
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

                var result = new DimensionesMs().GetAllByWithRelation().Cast<Dimensiones>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Dimensiones>().ToList();  
                if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <Dimensiones>().ToList(); 
                   if (orderCriteria == "icono") result = result.OrderBy(p => p.icono).Cast <Dimensiones>().ToList(); 
                 if (orderCriteria == "PonderacionRps") result = result.OrderBy(p => p.PonderacionRps).Cast <Dimensiones>().ToList(); 
                 if (orderCriteria == "PonderacionRi") result = result.OrderBy(p => p.PonderacionRi).Cast <Dimensiones>().ToList(); 
                 if (orderCriteria == "PonderacionCatering") result = result.OrderBy(p => p.PonderacionCatering).Cast <Dimensiones>().ToList(); 
                 if (orderCriteria == "Orden") result = result.OrderBy(p => p.Orden).Cast <Dimensiones>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Dimensiones>().ToList();  
                if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <Dimensiones>().ToList(); 
                   if (orderCriteria == "icono") result = result.OrderByDescending(p => p.icono).Cast <Dimensiones>().ToList(); 
                 if (orderCriteria == "PonderacionRps") result = result.OrderByDescending(p => p.PonderacionRps).Cast <Dimensiones>().ToList(); 
                 if (orderCriteria == "PonderacionRi") result = result.OrderByDescending(p => p.PonderacionRi).Cast <Dimensiones>().ToList(); 
                 if (orderCriteria == "PonderacionCatering") result = result.OrderByDescending(p => p.PonderacionCatering).Cast <Dimensiones>().ToList(); 
                 if (orderCriteria == "Orden") result = result.OrderByDescending(p => p.Orden).Cast <Dimensiones>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.icono != null && r.icono.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PonderacionRps != null && r.PonderacionRps.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PonderacionRi != null && r.PonderacionRi.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PonderacionCatering != null && r.PonderacionCatering.ToString().ToUpper().Contains(searchBy.ToUpper()) 
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
        /// CRUD de la entidad Dimensiones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Infraestructura de la entidad  Dimensiones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Dimensiones</param>
        /// <response code="200">Dimensiones Consulto los registros exitosamente</response>
        /// <response code="400">Dimensiones tiene valores invalidos </response>
        /// <response code="401">Dimensiones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Dimensiones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new DimensionesMs().GetAllByWithRelation().Cast<Dimensiones>().AsQueryable();
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
