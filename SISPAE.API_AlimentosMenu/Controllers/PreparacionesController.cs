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

namespace SISPAE_API_AlimentosMenu.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de Preparaciones .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PreparacionesController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Preparaciones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Preparaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Preparaciones</param>
        /// <response code="200">Preparaciones Consulto los registros exitosamente</response>
        /// <response code="400">Preparaciones tiene valores invalidos </response>
        /// <response code="401">Preparaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Preparaciones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new PreparacionesMs().GetAll().Cast<Preparaciones>().AsQueryable();
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
        /// CRUD de la entidad Preparaciones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Preparaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Preparaciones</param>
        /// <response code="200">Preparaciones Consulto los registros exitosamente</response>
        /// <response code="400">Preparaciones tiene valores invalidos </response>
        /// <response code="401">Preparaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Preparaciones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new PreparacionesMs().GetAllFull().Cast<Preparaciones>().AsQueryable();
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
        /// CRUD de la entidad Preparaciones --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Preparaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Preparaciones</param>
        /// <response code="200">Preparaciones Consulto los registros exitosamente</response>
        /// <response code="400">Preparaciones tiene valores invalidos </response>
        /// <response code="401">Preparaciones No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Preparaciones en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new PreparacionesMs().GetById(new Preparaciones() { id = id });
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
        /// CRUD de la entidad Preparaciones --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Preparaciones!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Preparaciones</param>
        /// <response code="200">Preparaciones Creado</response>
        /// <response code="400">Preparaciones tiene valores invalidos </response>
        /// <response code="401">Preparaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Preparaciones en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Preparaciones obj)
        {

            try
            {
                var result = new PreparacionesMs().Add(obj);
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
        /// CRUD de la entidad Preparaciones --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Preparaciones!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Preparaciones</param>
        /// <response code="200">Preparaciones Actualizado</response>
        /// <response code="400">Preparaciones tiene valores invalidos </response>
        /// <response code="401">Preparaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Preparaciones en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Preparaciones obj)
        {

            try
            {
                var result = new PreparacionesMs().Update(obj);
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
        /// CRUD de la entidad Preparaciones --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Preparaciones!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Preparaciones</param>
        /// <response code="200">Preparaciones Eliminado</response>
        /// <response code="400">Preparaciones tiene valores invalidos </response>
        /// <response code="401">Preparaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Preparaciones en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Preparaciones obj)
        {
           try
            {
                new PreparacionesMs().Delete(obj);
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
        /// DataTable de la entidad Preparaciones --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Preparaciones!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Preparaciones</param>
        /// <response code="200">Preparaciones Resultado</response>
        /// <response code="400">Preparaciones tiene valores invalidos </response>
        /// <response code="401">Preparaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Preparaciones en este momento</response>
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

                var result = new PreparacionesMs().GetAllByWithRelation().Cast<Preparaciones>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Preparaciones>().ToList();  
                if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderBy(p => p.ID_TipoModeloOperacion).Cast <Preparaciones>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderBy(p => p.sID_TipoModeloOperacion).Cast <Preparaciones>().ToList(); 
                 if (orderCriteria == "ID_MinutaPatron") result = result.OrderBy(p => p.ID_MinutaPatron).Cast <Preparaciones>().ToList(); 
                 if (orderCriteria == "sID_MinutaPatronAlimentos") result = result.OrderBy(p => p.sID_MinutaPatron).Cast <Preparaciones>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderBy(p => p.ID_ETC).Cast <Preparaciones>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderBy(p => p.sID_ETC).Cast <Preparaciones>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <Preparaciones>().ToList(); 
                 if (orderCriteria == "PreparacionMixta") result = result.OrderBy(p => p.PreparacionMixta).Cast <Preparaciones>().ToList(); 
                 if (orderCriteria == "PreparacionBebida") result = result.OrderBy(p => p.PreparacionBebida).Cast <Preparaciones>().ToList(); 
                   if (orderCriteria == "FechaPreparacion") result = result.OrderBy(p => p.FechaPreparacion).Cast <Preparaciones>().ToList(); 
                 if (orderCriteria == "PathGuia") result = result.OrderBy(p => p.PathGuia).Cast <Preparaciones>().ToList(); 
                   if (orderCriteria == "ID_TipoEstado") result = result.OrderBy(p => p.ID_TipoEstado).Cast <Preparaciones>().ToList(); 
                 if (orderCriteria == "sID_EstadosRegistro") result = result.OrderBy(p => p.sID_TipoEstado).Cast <Preparaciones>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Preparaciones>().ToList();  
                if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderByDescending(p => p.ID_TipoModeloOperacion).Cast <Preparaciones>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderByDescending(p => p.sID_TipoModeloOperacion).Cast<Preparaciones>().ToList(); 
                 if (orderCriteria == "ID_MinutaPatron") result = result.OrderByDescending(p => p.ID_MinutaPatron).Cast <Preparaciones>().ToList(); 
                 if (orderCriteria == "sID_MinutaPatronAlimentos") result = result.OrderByDescending(p => p.sID_MinutaPatron).Cast<Preparaciones>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderByDescending(p => p.ID_ETC).Cast <Preparaciones>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderByDescending(p => p.sID_ETC).Cast<Preparaciones>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <Preparaciones>().ToList(); 
                 if (orderCriteria == "PreparacionMixta") result = result.OrderByDescending(p => p.PreparacionMixta).Cast <Preparaciones>().ToList(); 
                 if (orderCriteria == "PreparacionBebida") result = result.OrderByDescending(p => p.PreparacionBebida).Cast <Preparaciones>().ToList(); 
                   if (orderCriteria == "FechaPreparacion") result = result.OrderByDescending(p => p.FechaPreparacion).Cast <Preparaciones>().ToList(); 
                 if (orderCriteria == "PathGuia") result = result.OrderByDescending(p => p.PathGuia).Cast <Preparaciones>().ToList(); 
                   if (orderCriteria == "ID_TipoEstado") result = result.OrderByDescending(p => p.ID_TipoEstado).Cast <Preparaciones>().ToList(); 
                 if (orderCriteria == "sID_EstadosRegistro") result = result.OrderByDescending(p => p.sID_TipoEstado).Cast<Preparaciones>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoModeloOperacion != null && r.ID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoModeloOperacion != null && r.sID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_MinutaPatron != null && r.ID_MinutaPatron.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_MinutaPatron != null && r.sID_MinutaPatron.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_ETC != null && r.ID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ETC != null && r.sID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PreparacionMixta != null && r.PreparacionMixta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PreparacionBebida != null && r.PreparacionBebida.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.FechaPreparacion != null && r.FechaPreparacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PathGuia != null && r.PathGuia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_TipoEstado != null && r.ID_TipoEstado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                || r.sID_TipoEstado != null && r.sID_TipoEstado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
  
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
        /// CRUD de la entidad Preparaciones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Preparaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Preparaciones</param>
        /// <response code="200">Preparaciones Consulto los registros exitosamente</response>
        /// <response code="400">Preparaciones tiene valores invalidos </response>
        /// <response code="401">Preparaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Preparaciones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new PreparacionesMs().GetAllByWithRelation().Cast<Preparaciones>().AsQueryable();
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
