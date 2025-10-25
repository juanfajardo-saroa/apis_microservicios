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

namespace SISPAE_API_Contratos.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de Modificaciones .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class ModificacionesController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Modificaciones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  Modificaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Modificaciones</param>
        /// <response code="200">Modificaciones Consulto los registros exitosamente</response>
        /// <response code="400">Modificaciones tiene valores invalidos </response>
        /// <response code="401">Modificaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Modificaciones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new ModificacionesMs().GetAll().Cast<Modificaciones>().AsQueryable();
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
        /// CRUD de la entidad Modificaciones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  Modificaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Modificaciones</param>
        /// <response code="200">Modificaciones Consulto los registros exitosamente</response>
        /// <response code="400">Modificaciones tiene valores invalidos </response>
        /// <response code="401">Modificaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Modificaciones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new ModificacionesMs().GetAllFull().Cast<Modificaciones>().AsQueryable();
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
        /// CRUD de la entidad Modificaciones --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  Modificaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Modificaciones</param>
        /// <response code="200">Modificaciones Consulto los registros exitosamente</response>
        /// <response code="400">Modificaciones tiene valores invalidos </response>
        /// <response code="401">Modificaciones No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Modificaciones en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new ModificacionesMs().GetById(new Modificaciones() { id = id });
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
        /// CRUD de la entidad Modificaciones --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  Modificaciones!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Modificaciones</param>
        /// <response code="200">Modificaciones Creado</response>
        /// <response code="400">Modificaciones tiene valores invalidos </response>
        /// <response code="401">Modificaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Modificaciones en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Modificaciones obj)
        {
            try
            {
                var result = new ModificacionesMs().Add(obj);
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
        /// CRUD de la entidad Modificaciones --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  Modificaciones!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Modificaciones</param>
        /// <response code="200">Modificaciones Actualizado</response>
        /// <response code="400">Modificaciones tiene valores invalidos </response>
        /// <response code="401">Modificaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Modificaciones en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Modificaciones obj)
        {
            try
            {
                var result = new ModificacionesMs().Update(obj);
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
        /// CRUD de la entidad Modificaciones --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  Modificaciones!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Modificaciones</param>
        /// <response code="200">Modificaciones Eliminado</response>
        /// <response code="400">Modificaciones tiene valores invalidos </response>
        /// <response code="401">Modificaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Modificaciones en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Modificaciones obj)
        {
           try
            {
                new ModificacionesMs().Delete(obj);
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
        /// DataTable de la entidad Modificaciones --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Modificaciones!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Modificaciones</param>
        /// <response code="200">Modificaciones Resultado</response>
        /// <response code="400">Modificaciones tiene valores invalidos </response>
        /// <response code="401">Modificaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Modificaciones en este momento</response>
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

                var result = new ModificacionesMs().GetAllByWithRelation().Cast<Modificaciones>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Modificaciones>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderBy(p => p.ID_Contrato).Cast <Modificaciones>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderBy(p => p.sID_Contrato).Cast <Modificaciones>().ToList(); 
                 if (orderCriteria == "ID_TipoModificacion") result = result.OrderBy(p => p.ID_TipoModificacion).Cast <Modificaciones>().ToList(); 
                 if (orderCriteria == "sID_TipoModificacionContrato") result = result.OrderBy(p => p.sID_TipoModificacion).Cast <Modificaciones>().ToList(); 
                 if (orderCriteria == "NumeroDiasProrroga") result = result.OrderBy(p => p.NumeroDiasProrroga).Cast <Modificaciones>().ToList(); 
                 if (orderCriteria == "FechaTerminacionProrroga") result = result.OrderBy(p => p.FechaTerminacionProrroga).Cast <Modificaciones>().ToList(); 
                 if (orderCriteria == "ValorAdicionReduccion") result = result.OrderBy(p => p.ValorAdicionReduccion).Cast <Modificaciones>().ToList(); 
                 if (orderCriteria == "SoporteModificacionPath") result = result.OrderBy(p => p.SoporteModificacionPath).Cast <Modificaciones>().ToList(); 
                   if (orderCriteria == "Descripcion") result = result.OrderBy(p => p.Descripcion).Cast <Modificaciones>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Modificaciones>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderByDescending(p => p.ID_Contrato).Cast <Modificaciones>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderByDescending(p => p.sID_Contrato).Cast<Modificaciones>().ToList(); 
                 if (orderCriteria == "ID_TipoModificacion") result = result.OrderByDescending(p => p.ID_TipoModificacion).Cast <Modificaciones>().ToList(); 
                 if (orderCriteria == "sID_TipoModificacionContrato") result = result.OrderByDescending(p => p.sID_TipoModificacion).Cast<Modificaciones>().ToList(); 
                 if (orderCriteria == "NumeroDiasProrroga") result = result.OrderByDescending(p => p.NumeroDiasProrroga).Cast <Modificaciones>().ToList(); 
                 if (orderCriteria == "FechaTerminacionProrroga") result = result.OrderByDescending(p => p.FechaTerminacionProrroga).Cast <Modificaciones>().ToList(); 
                 if (orderCriteria == "ValorAdicionReduccion") result = result.OrderByDescending(p => p.ValorAdicionReduccion).Cast <Modificaciones>().ToList(); 
                 if (orderCriteria == "SoporteModificacionPath") result = result.OrderByDescending(p => p.SoporteModificacionPath).Cast <Modificaciones>().ToList(); 
                   if (orderCriteria == "Descripcion") result = result.OrderByDescending(p => p.Descripcion).Cast <Modificaciones>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Contrato != null && r.ID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Contrato != null && r.sID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoModificacion != null && r.ID_TipoModificacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoModificacion != null && r.sID_TipoModificacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumeroDiasProrroga != null && r.NumeroDiasProrroga.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaTerminacionProrroga != null && r.FechaTerminacionProrroga.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ValorAdicionReduccion != null && r.ValorAdicionReduccion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.SoporteModificacionPath != null && r.SoporteModificacionPath.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Descripcion != null && r.Descripcion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
        /// CRUD de la entidad Modificaciones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  Modificaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Modificaciones</param>
        /// <response code="200">Modificaciones Consulto los registros exitosamente</response>
        /// <response code="400">Modificaciones tiene valores invalidos </response>
        /// <response code="401">Modificaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Modificaciones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new ModificacionesMs().GetAllByWithRelation().Cast<Modificaciones>().AsQueryable();
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
