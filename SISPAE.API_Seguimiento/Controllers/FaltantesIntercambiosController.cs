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
    [SwaggerTag("Web API para CRUD de FaltantesIntercambios .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class FaltantesIntercambiosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad FaltantesIntercambios --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  FaltantesIntercambios!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de FaltantesIntercambios</param>
        /// <response code="200">FaltantesIntercambios Consulto los registros exitosamente</response>
        /// <response code="400">FaltantesIntercambios tiene valores invalidos </response>
        /// <response code="401">FaltantesIntercambios No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar FaltantesIntercambios en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new FaltantesIntercambiosMs().GetAll().Cast<FaltantesIntercambios>().AsQueryable();
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
        /// CRUD de la entidad FaltantesIntercambios --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  FaltantesIntercambios!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de FaltantesIntercambios</param>
        /// <response code="200">FaltantesIntercambios Consulto los registros exitosamente</response>
        /// <response code="400">FaltantesIntercambios tiene valores invalidos </response>
        /// <response code="401">FaltantesIntercambios No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar FaltantesIntercambios en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new FaltantesIntercambiosMs().GetAllFull().Cast<FaltantesIntercambios>().AsQueryable();
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
        /// CRUD de la entidad FaltantesIntercambios --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  FaltantesIntercambios!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de FaltantesIntercambios</param>
        /// <response code="200">FaltantesIntercambios Consulto los registros exitosamente</response>
        /// <response code="400">FaltantesIntercambios tiene valores invalidos </response>
        /// <response code="401">FaltantesIntercambios No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar FaltantesIntercambios en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new FaltantesIntercambiosMs().GetById(new FaltantesIntercambios() { id = id });
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
        /// CRUD de la entidad FaltantesIntercambios --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Seguimiento de la entidad  FaltantesIntercambios!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de FaltantesIntercambios</param>
        /// <response code="200">FaltantesIntercambios Creado</response>
        /// <response code="400">FaltantesIntercambios tiene valores invalidos </response>
        /// <response code="401">FaltantesIntercambios No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear FaltantesIntercambios en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] FaltantesIntercambios obj)
        {
            try
            {
                var result = new FaltantesIntercambiosMs().Add(obj);
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
        /// CRUD de la entidad FaltantesIntercambios --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Seguimiento de la entidad  FaltantesIntercambios!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de FaltantesIntercambios</param>
        /// <response code="200">FaltantesIntercambios Actualizado</response>
        /// <response code="400">FaltantesIntercambios tiene valores invalidos </response>
        /// <response code="401">FaltantesIntercambios No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar FaltantesIntercambios en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] FaltantesIntercambios obj)
        {
            try
            {
                var result = new FaltantesIntercambiosMs().Update(obj);
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
        /// CRUD de la entidad FaltantesIntercambios --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Seguimiento de la entidad  FaltantesIntercambios!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de FaltantesIntercambios</param>
        /// <response code="200">FaltantesIntercambios Eliminado</response>
        /// <response code="400">FaltantesIntercambios tiene valores invalidos </response>
        /// <response code="401">FaltantesIntercambios No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar FaltantesIntercambios en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] FaltantesIntercambios obj)
        {
           try
            {
                new FaltantesIntercambiosMs().Delete(obj);
                return Ok();
            }
            catch (System.Exception ex)
            {
                  return BadRequest(ex.Message);
            }
        }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad FaltantesIntercambios --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  FaltantesIntercambios!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de FaltantesIntercambios</param>
        /// <response code="200">FaltantesIntercambios Resultado</response>
        /// <response code="400">FaltantesIntercambios tiene valores invalidos </response>
        /// <response code="401">FaltantesIntercambios No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  FaltantesIntercambios en este momento</response>
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
                var result = new FaltantesIntercambiosMs().GetAllByWithRelation().Cast<FaltantesIntercambios>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                  if (orderAscendingDirection)                  {                  if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <FaltantesIntercambios>().ToList();  
                  if (orderCriteria == "ID_ProductoIntercambio") result = result.OrderBy(p => p.ID_ProductoIntercambio).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "sID_Productos") result = result.OrderBy(p => p.sID_ProductoIntercambio).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "ID_EntregaViveres") result = result.OrderBy(p => p.ID_EntregaViveres).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "sID_EntregaViveres") result = result.OrderBy(p => p.sID_EntregaViveres).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "CantidadRecibida") result = result.OrderBy(p => p.CantidadRecibida).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "CantidadNoCoincidePor") result = result.OrderBy(p => p.CantidadNoCoincidePor).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "CantidadFaltante") result = result.OrderBy(p => p.CantidadFaltante).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "CantidadDevuelta") result = result.OrderBy(p => p.CantidadDevuelta).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "FechaEntregaFaltante") result = result.OrderBy(p => p.FechaEntregaFaltante).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "BuenEstado") result = result.OrderBy(p => p.BuenEstado).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "BuenEmpacado") result = result.OrderBy(p => p.BuenEmpacado).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "SinContaminacion") result = result.OrderBy(p => p.SinContaminacion).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "SinExpirar") result = result.OrderBy(p => p.SinExpirar).Cast <FaltantesIntercambios>().ToList(); 
                     }
  else 
                    {                  if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <FaltantesIntercambios>().ToList();  
                  if (orderCriteria == "ID_ProductoIntercambio") result = result.OrderByDescending(p => p.ID_ProductoIntercambio).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "sID_Productos") result = result.OrderByDescending(p => p.sID_ProductoIntercambio).Cast<FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "ID_EntregaViveres") result = result.OrderByDescending(p => p.ID_EntregaViveres).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "sID_EntregaViveres") result = result.OrderByDescending(p => p.sID_EntregaViveres).Cast<FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "CantidadRecibida") result = result.OrderByDescending(p => p.CantidadRecibida).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "CantidadNoCoincidePor") result = result.OrderByDescending(p => p.CantidadNoCoincidePor).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "CantidadFaltante") result = result.OrderByDescending(p => p.CantidadFaltante).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "CantidadDevuelta") result = result.OrderByDescending(p => p.CantidadDevuelta).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "FechaEntregaFaltante") result = result.OrderByDescending(p => p.FechaEntregaFaltante).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "BuenEstado") result = result.OrderByDescending(p => p.BuenEstado).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "BuenEmpacado") result = result.OrderByDescending(p => p.BuenEmpacado).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "SinContaminacion") result = result.OrderByDescending(p => p.SinContaminacion).Cast <FaltantesIntercambios>().ToList(); 
                   if (orderCriteria == "SinExpirar") result = result.OrderByDescending(p => p.SinExpirar).Cast <FaltantesIntercambios>().ToList(); 
                     }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                   || r.ID_ProductoIntercambio != null && r.ID_ProductoIntercambio.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_ProductoIntercambio != null && r.sID_ProductoIntercambio.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_EntregaViveres != null && r.ID_EntregaViveres.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_EntregaViveres != null && r.sID_EntregaViveres.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.CantidadRecibida != null && r.CantidadRecibida.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.CantidadNoCoincidePor != null && r.CantidadNoCoincidePor.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.CantidadFaltante != null && r.CantidadFaltante.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.CantidadDevuelta != null && r.CantidadDevuelta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.FechaEntregaFaltante != null && r.FechaEntregaFaltante.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.BuenEstado != null && r.BuenEstado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.BuenEmpacado != null && r.BuenEmpacado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.SinContaminacion != null && r.SinContaminacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.SinExpirar != null && r.SinExpirar.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad FaltantesIntercambios --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  FaltantesIntercambios!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de FaltantesIntercambios</param>
        /// <response code="200">FaltantesIntercambios Consulto los registros exitosamente</response>
        /// <response code="400">FaltantesIntercambios tiene valores invalidos </response>
        /// <response code="401">FaltantesIntercambios No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar FaltantesIntercambios en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new FaltantesIntercambiosMs().GetAllByWithRelation().Cast<FaltantesIntercambios>().AsQueryable();
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
