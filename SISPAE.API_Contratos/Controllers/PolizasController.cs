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
    [SwaggerTag("Web API para CRUD de Polizas .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PolizasController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Polizas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  Polizas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Polizas</param>
        /// <response code="200">Polizas Consulto los registros exitosamente</response>
        /// <response code="400">Polizas tiene valores invalidos </response>
        /// <response code="401">Polizas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Polizas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new PolizasMs().GetAll().Cast<Polizas>().AsQueryable();
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
        /// CRUD de la entidad Polizas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  Polizas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Polizas</param>
        /// <response code="200">Polizas Consulto los registros exitosamente</response>
        /// <response code="400">Polizas tiene valores invalidos </response>
        /// <response code="401">Polizas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Polizas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new PolizasMs().GetAllFull().Cast<Polizas>().AsQueryable();
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
        /// CRUD de la entidad Polizas --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  Polizas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Polizas</param>
        /// <response code="200">Polizas Consulto los registros exitosamente</response>
        /// <response code="400">Polizas tiene valores invalidos </response>
        /// <response code="401">Polizas No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Polizas en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new PolizasMs().GetById(new Polizas() { id = id });
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
        /// CRUD de la entidad Polizas --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  Polizas!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Polizas</param>
        /// <response code="200">Polizas Creado</response>
        /// <response code="400">Polizas tiene valores invalidos </response>
        /// <response code="401">Polizas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Polizas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Polizas obj)
        {
            try
            {
                var result = new PolizasMs().Add(obj);
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
        /// CRUD de la entidad Polizas --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  Polizas!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Polizas</param>
        /// <response code="200">Polizas Actualizado</response>
        /// <response code="400">Polizas tiene valores invalidos </response>
        /// <response code="401">Polizas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Polizas en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Polizas obj)
        {
            try
            {
                var result = new PolizasMs().Update(obj);
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
        /// CRUD de la entidad Polizas --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  Polizas!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Polizas</param>
        /// <response code="200">Polizas Eliminado</response>
        /// <response code="400">Polizas tiene valores invalidos </response>
        /// <response code="401">Polizas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Polizas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Polizas obj)
        {
           try
            {
                new PolizasMs().Delete(obj);
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
        /// DataTable de la entidad Polizas --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Polizas!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Polizas</param>
        /// <response code="200">Polizas Resultado</response>
        /// <response code="400">Polizas tiene valores invalidos </response>
        /// <response code="401">Polizas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Polizas en este momento</response>
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

                var result = new PolizasMs().GetAllByWithRelation().Cast<Polizas>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Polizas>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderBy(p => p.ID_Contrato).Cast <Polizas>().ToList(); 
                 if (orderCriteria == "ID_TipoPoliza") result = result.OrderBy(p => p.ID_TipoPoliza).Cast <Polizas>().ToList(); 
                 if (orderCriteria == "FechaAprobacion") result = result.OrderBy(p => p.FechaAprobacion).Cast <Polizas>().ToList(); 
                 if (orderCriteria == "Numero") result = result.OrderBy(p => p.Numero).Cast <Polizas>().ToList(); 
                 if (orderCriteria == "ValorTotal") result = result.OrderBy(p => p.ValorTotal).Cast <Polizas>().ToList(); 
                   if (orderCriteria == "FechaPoliza") result = result.OrderBy(p => p.FechaPoliza).Cast <Polizas>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Polizas>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderByDescending(p => p.ID_Contrato).Cast <Polizas>().ToList(); 
                 if (orderCriteria == "ID_TipoPoliza") result = result.OrderByDescending(p => p.ID_TipoPoliza).Cast <Polizas>().ToList(); 
                 if (orderCriteria == "FechaAprobacion") result = result.OrderByDescending(p => p.FechaAprobacion).Cast <Polizas>().ToList(); 
                 if (orderCriteria == "Numero") result = result.OrderByDescending(p => p.Numero).Cast <Polizas>().ToList(); 
                 if (orderCriteria == "ValorTotal") result = result.OrderByDescending(p => p.ValorTotal).Cast <Polizas>().ToList(); 
                   if (orderCriteria == "FechaPoliza") result = result.OrderByDescending(p => p.FechaPoliza).Cast <Polizas>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Contrato != null && r.ID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoPoliza != null && r.ID_TipoPoliza.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaAprobacion != null && r.FechaAprobacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Numero != null && r.Numero.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ValorTotal != null && r.ValorTotal.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.FechaPoliza != null && r.FechaPoliza.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
        /// CRUD de la entidad Polizas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  Polizas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Polizas</param>
        /// <response code="200">Polizas Consulto los registros exitosamente</response>
        /// <response code="400">Polizas tiene valores invalidos </response>
        /// <response code="401">Polizas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Polizas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new PolizasMs().GetAllByWithRelation().Cast<Polizas>().AsQueryable();
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
