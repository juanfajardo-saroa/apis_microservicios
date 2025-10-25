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

namespace SISPAE_API_PlaneacionFinanciera.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de AsignacionRecursos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class AsignacionRecursosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad AsignacionRecursos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  AsignacionRecursos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AsignacionRecursos</param>
        /// <response code="200">AsignacionRecursos Consulto los registros exitosamente</response>
        /// <response code="400">AsignacionRecursos tiene valores invalidos </response>
        /// <response code="401">AsignacionRecursos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AsignacionRecursos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new AsignacionRecursosMs().GetAll().Cast<AsignacionRecursos>().AsQueryable();
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
        /// CRUD de la entidad AsignacionRecursos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  AsignacionRecursos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AsignacionRecursos</param>
        /// <response code="200">AsignacionRecursos Consulto los registros exitosamente</response>
        /// <response code="400">AsignacionRecursos tiene valores invalidos </response>
        /// <response code="401">AsignacionRecursos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AsignacionRecursos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new AsignacionRecursosMs().GetAllFull().Cast<AsignacionRecursos>().AsQueryable();
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
        /// CRUD de la entidad AsignacionRecursos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  AsignacionRecursos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AsignacionRecursos</param>
        /// <response code="200">AsignacionRecursos Consulto los registros exitosamente</response>
        /// <response code="400">AsignacionRecursos tiene valores invalidos </response>
        /// <response code="401">AsignacionRecursos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar AsignacionRecursos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new AsignacionRecursosMs().GetById(new AsignacionRecursos() { Id = id });
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
        /// CRUD de la entidad AsignacionRecursos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  AsignacionRecursos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de AsignacionRecursos</param>
        /// <response code="200">AsignacionRecursos Creado</response>
        /// <response code="400">AsignacionRecursos tiene valores invalidos </response>
        /// <response code="401">AsignacionRecursos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear AsignacionRecursos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] AsignacionRecursos obj)
        {
            try
            {
                var result = new AsignacionRecursosMs().Add(obj);
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
        /// CRUD de la entidad AsignacionRecursos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  AsignacionRecursos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de AsignacionRecursos</param>
        /// <response code="200">AsignacionRecursos Actualizado</response>
        /// <response code="400">AsignacionRecursos tiene valores invalidos </response>
        /// <response code="401">AsignacionRecursos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar AsignacionRecursos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] AsignacionRecursos obj)
        {
            try
            {
                var result = new AsignacionRecursosMs().Update(obj);
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
        /// CRUD de la entidad AsignacionRecursos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  AsignacionRecursos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de AsignacionRecursos</param>
        /// <response code="200">AsignacionRecursos Eliminado</response>
        /// <response code="400">AsignacionRecursos tiene valores invalidos </response>
        /// <response code="401">AsignacionRecursos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar AsignacionRecursos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] AsignacionRecursos obj)
        {
           try
            {
                new AsignacionRecursosMs().Delete(obj);
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
        /// DataTable de la entidad AsignacionRecursos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  AsignacionRecursos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de AsignacionRecursos</param>
        /// <response code="200">AsignacionRecursos Resultado</response>
        /// <response code="400">AsignacionRecursos tiene valores invalidos </response>
        /// <response code="401">AsignacionRecursos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  AsignacionRecursos en este momento</response>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LoadTable([FromBody] DtParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;

            var orderCriteria = "Id";
            var orderAscendingDirection = true;

            try
            {

                if (dtParameters.Order != null)
                {
                    // in this example we just default sort on the 1st column
                    orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                    orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
                }

                var result = new AsignacionRecursosMs().GetAllByWithRelation().Cast<AsignacionRecursos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="Id") result = result.OrderBy(p => p.Id).Cast <AsignacionRecursos>().ToList();  
                if (orderCriteria == "ID_FuenteFinanciacion") result = result.OrderBy(p => p.ID_FuenteFinanciacion).Cast <AsignacionRecursos>().ToList(); 
                 if (orderCriteria == "sID_FuentesFinanciacion") result = result.OrderBy(p => p.sID_FuenteFinanciacion).Cast <AsignacionRecursos>().ToList(); 
                 if (orderCriteria == "ID_FuenteIngreso") result = result.OrderBy(p => p.ID_FuenteIngreso).Cast <AsignacionRecursos>().ToList(); 
                 if (orderCriteria == "NombreResolucion") result = result.OrderBy(p => p.NombreResolucion).Cast <AsignacionRecursos>().ToList(); 
                 if (orderCriteria == "ValorPresupuestal") result = result.OrderBy(p => p.ValorPresupuestal).Cast <AsignacionRecursos>().ToList(); 
                 if (orderCriteria == "ArchivoResolucion") result = result.OrderBy(p => p.ArchivoResolucion).Cast <AsignacionRecursos>().ToList(); 
                 if (orderCriteria == "ID_EstadoResolucion") result = result.OrderBy(p => p.ID_EstadoResolucion).Cast <AsignacionRecursos>().ToList(); 
                 if (orderCriteria == "Vigencia") result = result.OrderBy(p => p.Vigencia).Cast <AsignacionRecursos>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "Id") result = result.OrderByDescending(p => p.Id).Cast <AsignacionRecursos>().ToList();  
                if (orderCriteria == "ID_FuenteFinanciacion") result = result.OrderByDescending(p => p.ID_FuenteFinanciacion).Cast <AsignacionRecursos>().ToList(); 
                 if (orderCriteria == "sID_FuentesFinanciacion") result = result.OrderByDescending(p => p.sID_FuenteFinanciacion).Cast<AsignacionRecursos>().ToList(); 
                 if (orderCriteria == "ID_FuenteIngreso") result = result.OrderByDescending(p => p.ID_FuenteIngreso).Cast <AsignacionRecursos>().ToList(); 
                 if (orderCriteria == "NombreResolucion") result = result.OrderByDescending(p => p.NombreResolucion).Cast <AsignacionRecursos>().ToList(); 
                 if (orderCriteria == "ValorPresupuestal") result = result.OrderByDescending(p => p.ValorPresupuestal).Cast <AsignacionRecursos>().ToList(); 
                 if (orderCriteria == "ArchivoResolucion") result = result.OrderByDescending(p => p.ArchivoResolucion).Cast <AsignacionRecursos>().ToList(); 
                 if (orderCriteria == "ID_EstadoResolucion") result = result.OrderByDescending(p => p.ID_EstadoResolucion).Cast <AsignacionRecursos>().ToList(); 
                 if (orderCriteria == "Vigencia") result = result.OrderByDescending(p => p.Vigencia).Cast <AsignacionRecursos>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.Id != null && r.Id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_FuenteFinanciacion != null && r.ID_FuenteFinanciacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_FuenteFinanciacion != null && r.sID_FuenteFinanciacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_FuenteIngreso != null && r.ID_FuenteIngreso.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NombreResolucion != null && r.NombreResolucion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ValorPresupuestal != null && r.ValorPresupuestal.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ArchivoResolucion != null && r.ArchivoResolucion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_EstadoResolucion != null && r.ID_EstadoResolucion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Vigencia != null && r.Vigencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
                    data[i].sID = SISPAE.Common.Utilidades.Encrypt($"id={data[i].Id.ToString()}");
                   
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
        /// CRUD de la entidad AsignacionRecursos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  AsignacionRecursos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AsignacionRecursos</param>
        /// <response code="200">AsignacionRecursos Consulto los registros exitosamente</response>
        /// <response code="400">AsignacionRecursos tiene valores invalidos </response>
        /// <response code="401">AsignacionRecursos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AsignacionRecursos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new AsignacionRecursosMs().GetAllByWithRelation().Cast<AsignacionRecursos>().AsQueryable();
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
