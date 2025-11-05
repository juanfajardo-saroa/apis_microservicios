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
    [SwaggerTag("Web API para CRUD de QuincenaEntregaRaciones .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class QuincenaEntregaRacionesController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad QuincenaEntregaRaciones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  QuincenaEntregaRaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de QuincenaEntregaRaciones</param>
        /// <response code="200">QuincenaEntregaRaciones Consulto los registros exitosamente</response>
        /// <response code="400">QuincenaEntregaRaciones tiene valores invalidos </response>
        /// <response code="401">QuincenaEntregaRaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar QuincenaEntregaRaciones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new QuincenaEntregaRacionesMs().GetAll().Cast<QuincenaEntregaRaciones>().AsQueryable();
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
        /// CRUD de la entidad QuincenaEntregaRaciones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  QuincenaEntregaRaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de QuincenaEntregaRaciones</param>
        /// <response code="200">QuincenaEntregaRaciones Consulto los registros exitosamente</response>
        /// <response code="400">QuincenaEntregaRaciones tiene valores invalidos </response>
        /// <response code="401">QuincenaEntregaRaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar QuincenaEntregaRaciones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new QuincenaEntregaRacionesMs().GetAllFull().Cast<QuincenaEntregaRaciones>().AsQueryable();
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
        /// CRUD de la entidad QuincenaEntregaRaciones --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  QuincenaEntregaRaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de QuincenaEntregaRaciones</param>
        /// <response code="200">QuincenaEntregaRaciones Consulto los registros exitosamente</response>
        /// <response code="400">QuincenaEntregaRaciones tiene valores invalidos </response>
        /// <response code="401">QuincenaEntregaRaciones No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar QuincenaEntregaRaciones en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new QuincenaEntregaRacionesMs().GetById(new QuincenaEntregaRaciones() { id = id });
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
        /// CRUD de la entidad QuincenaEntregaRaciones --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Seguimiento de la entidad  QuincenaEntregaRaciones!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de QuincenaEntregaRaciones</param>
        /// <response code="200">QuincenaEntregaRaciones Creado</response>
        /// <response code="400">QuincenaEntregaRaciones tiene valores invalidos </response>
        /// <response code="401">QuincenaEntregaRaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear QuincenaEntregaRaciones en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] QuincenaEntregaRaciones obj)
        {
            try
            {
                var result = new QuincenaEntregaRacionesMs().Add(obj);
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
        /// CRUD de la entidad QuincenaEntregaRaciones --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Seguimiento de la entidad  QuincenaEntregaRaciones!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de QuincenaEntregaRaciones</param>
        /// <response code="200">QuincenaEntregaRaciones Actualizado</response>
        /// <response code="400">QuincenaEntregaRaciones tiene valores invalidos </response>
        /// <response code="401">QuincenaEntregaRaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar QuincenaEntregaRaciones en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] QuincenaEntregaRaciones obj)
        {
            try
            {
                var result = new QuincenaEntregaRacionesMs().Update(obj);
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
        /// CRUD de la entidad QuincenaEntregaRaciones --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Seguimiento de la entidad  QuincenaEntregaRaciones!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de QuincenaEntregaRaciones</param>
        /// <response code="200">QuincenaEntregaRaciones Eliminado</response>
        /// <response code="400">QuincenaEntregaRaciones tiene valores invalidos </response>
        /// <response code="401">QuincenaEntregaRaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar QuincenaEntregaRaciones en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] QuincenaEntregaRaciones obj)
        {
           try
            {
                new QuincenaEntregaRacionesMs().Delete(obj);
                return Ok();
            }
            catch (System.Exception ex)
            {
                  return BadRequest(ex.Message);
            }
        }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad QuincenaEntregaRaciones --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  QuincenaEntregaRaciones!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de QuincenaEntregaRaciones</param>
        /// <response code="200">QuincenaEntregaRaciones Resultado</response>
        /// <response code="400">QuincenaEntregaRaciones tiene valores invalidos </response>
        /// <response code="401">QuincenaEntregaRaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  QuincenaEntregaRaciones en este momento</response>
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
                var result = new QuincenaEntregaRacionesMs().GetAllByWithRelation().Cast<QuincenaEntregaRaciones>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                  if (orderAscendingDirection)                  {                  if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <QuincenaEntregaRaciones>().ToList();  
                  if (orderCriteria == "ID_EstadoQuincena") result = result.OrderBy(p => p.ID_EstadoQuincena).Cast <QuincenaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "sID_EstadoQuincena") result = result.OrderBy(p => p.sID_EstadoQuincena).Cast <QuincenaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "ID_Contrato") result = result.OrderBy(p => p.ID_Contrato).Cast <QuincenaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "sID_Contratos") result = result.OrderBy(p => p.sID_Contrato).Cast <QuincenaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "ID_GradoSedeJornada") result = result.OrderBy(p => p.ID_GradoSedeJornada).Cast <QuincenaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "sID_GradosSedesJornadas") result = result.OrderBy(p => p.sID_GradoSedeJornada).Cast <QuincenaEntregaRaciones>().ToList(); 
                     if (orderCriteria == "pathReporteQuincenal") result = result.OrderBy(p => p.pathReporteQuincenal).Cast <QuincenaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "fechaCarga") result = result.OrderBy(p => p.fechaCarga).Cast <QuincenaEntregaRaciones>().ToList(); 
                   }
  else 
                    {                  if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <QuincenaEntregaRaciones>().ToList();  
                  if (orderCriteria == "ID_EstadoQuincena") result = result.OrderByDescending(p => p.ID_EstadoQuincena).Cast <QuincenaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "sID_EstadoQuincena") result = result.OrderByDescending(p => p.sID_EstadoQuincena).Cast<QuincenaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "ID_Contrato") result = result.OrderByDescending(p => p.ID_Contrato).Cast <QuincenaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "sID_Contratos") result = result.OrderByDescending(p => p.sID_Contrato).Cast<QuincenaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "ID_GradoSedeJornada") result = result.OrderByDescending(p => p.ID_GradoSedeJornada).Cast <QuincenaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "sID_GradosSedesJornadas") result = result.OrderByDescending(p => p.sID_GradoSedeJornada).Cast<QuincenaEntregaRaciones>().ToList(); 
                     if (orderCriteria == "pathReporteQuincenal") result = result.OrderByDescending(p => p.pathReporteQuincenal).Cast <QuincenaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "fechaCarga") result = result.OrderByDescending(p => p.fechaCarga).Cast <QuincenaEntregaRaciones>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                   || r.ID_EstadoQuincena != null && r.ID_EstadoQuincena.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_EstadoQuincena != null && r.sID_EstadoQuincena.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_Contrato != null && r.ID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_Contrato != null && r.sID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_GradoSedeJornada != null && r.ID_GradoSedeJornada.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_GradoSedeJornada != null && r.sID_GradoSedeJornada.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                     || r.pathReporteQuincenal != null && r.pathReporteQuincenal.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.fechaCarga != null && r.fechaCarga.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
        /// CRUD de la entidad QuincenaEntregaRaciones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  QuincenaEntregaRaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de QuincenaEntregaRaciones</param>
        /// <response code="200">QuincenaEntregaRaciones Consulto los registros exitosamente</response>
        /// <response code="400">QuincenaEntregaRaciones tiene valores invalidos </response>
        /// <response code="401">QuincenaEntregaRaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar QuincenaEntregaRaciones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new QuincenaEntregaRacionesMs().GetAllByWithRelation().Cast<QuincenaEntregaRaciones>().AsQueryable();
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
