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
    [SwaggerTag("Web API para CRUD de ProcesosCargue .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class ProcesosCargueController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad ProcesosCargue --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  ProcesosCargue!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ProcesosCargue</param>
        /// <response code="200">ProcesosCargue Consulto los registros exitosamente</response>
        /// <response code="400">ProcesosCargue tiene valores invalidos </response>
        /// <response code="401">ProcesosCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ProcesosCargue en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new ProcesosCargueMs().GetAll().Cast<ProcesosCargue>().AsQueryable();
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
        /// CRUD de la entidad ProcesosCargue --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  ProcesosCargue!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ProcesosCargue</param>
        /// <response code="200">ProcesosCargue Consulto los registros exitosamente</response>
        /// <response code="400">ProcesosCargue tiene valores invalidos </response>
        /// <response code="401">ProcesosCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ProcesosCargue en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new ProcesosCargueMs().GetAllFull().Cast<ProcesosCargue>().AsQueryable();
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
        /// CRUD de la entidad ProcesosCargue --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  ProcesosCargue!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ProcesosCargue</param>
        /// <response code="200">ProcesosCargue Consulto los registros exitosamente</response>
        /// <response code="400">ProcesosCargue tiene valores invalidos </response>
        /// <response code="401">ProcesosCargue No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar ProcesosCargue en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new ProcesosCargueMs().GetById(new ProcesosCargue() { id = id });
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
        /// CRUD de la entidad ProcesosCargue --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Staging de la entidad  ProcesosCargue!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de ProcesosCargue</param>
        /// <response code="200">ProcesosCargue Creado</response>
        /// <response code="400">ProcesosCargue tiene valores invalidos </response>
        /// <response code="401">ProcesosCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear ProcesosCargue en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] ProcesosCargue obj)
        {
            try
            {
                var result = new ProcesosCargueMs().Add(obj);
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
        /// CRUD de la entidad ProcesosCargue --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Staging de la entidad  ProcesosCargue!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de ProcesosCargue</param>
        /// <response code="200">ProcesosCargue Actualizado</response>
        /// <response code="400">ProcesosCargue tiene valores invalidos </response>
        /// <response code="401">ProcesosCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar ProcesosCargue en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] ProcesosCargue obj)
        {
            try
            {
                var result = new ProcesosCargueMs().Update(obj);
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
        /// CRUD de la entidad ProcesosCargue --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Staging de la entidad  ProcesosCargue!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de ProcesosCargue</param>
        /// <response code="200">ProcesosCargue Eliminado</response>
        /// <response code="400">ProcesosCargue tiene valores invalidos </response>
        /// <response code="401">ProcesosCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar ProcesosCargue en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] ProcesosCargue obj)
        {
           try
            {
                new ProcesosCargueMs().Delete(obj);
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
        /// DataTable de la entidad ProcesosCargue --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  ProcesosCargue!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de ProcesosCargue</param>
        /// <response code="200">ProcesosCargue Resultado</response>
        /// <response code="400">ProcesosCargue tiene valores invalidos </response>
        /// <response code="401">ProcesosCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  ProcesosCargue en este momento</response>
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

                var result = new ProcesosCargueMs().GetAllByWithRelation().Cast<ProcesosCargue>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <ProcesosCargue>().ToList();  
                if (orderCriteria == "ID_TipoProcesoCargue") result = result.OrderBy(p => p.ID_TipoProcesoCargue).Cast <ProcesosCargue>().ToList(); 
                 if (orderCriteria == "sID_TipoProcesosCargue") result = result.OrderBy(p => p.sID_TipoProcesoCargue).Cast <ProcesosCargue>().ToList(); 
                 if (orderCriteria == "ID_EstadoProcesoCargue") result = result.OrderBy(p => p.ID_EstadoProcesoCargue).Cast <ProcesosCargue>().ToList(); 
                 if (orderCriteria == "sID_EstadoProcesoCargue") result = result.OrderBy(p => p.sID_EstadoProcesoCargue).Cast <ProcesosCargue>().ToList(); 
                 if (orderCriteria == "FechaCargue") result = result.OrderBy(p => p.FechaCargue).Cast <ProcesosCargue>().ToList(); 
                 if (orderCriteria == "NombreArchivoProcesado") result = result.OrderBy(p => p.NombreArchivoProcesado).Cast <ProcesosCargue>().ToList(); 
                 if (orderCriteria == "Porcentaje") result = result.OrderBy(p => p.Porcentaje).Cast <ProcesosCargue>().ToList(); 
                 if (orderCriteria == "Procesados") result = result.OrderBy(p => p.Procesados).Cast <ProcesosCargue>().ToList(); 
                 if (orderCriteria == "Errores") result = result.OrderBy(p => p.Errores).Cast <ProcesosCargue>().ToList(); 
                 if (orderCriteria == "Cargado") result = result.OrderBy(p => p.Cargado).Cast <ProcesosCargue>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <ProcesosCargue>().ToList();  
                if (orderCriteria == "ID_TipoProcesoCargue") result = result.OrderByDescending(p => p.ID_TipoProcesoCargue).Cast <ProcesosCargue>().ToList(); 
                 if (orderCriteria == "sID_TipoProcesosCargue") result = result.OrderByDescending(p => p.sID_TipoProcesoCargue).Cast<ProcesosCargue>().ToList(); 
                 if (orderCriteria == "ID_EstadoProcesoCargue") result = result.OrderByDescending(p => p.ID_EstadoProcesoCargue).Cast <ProcesosCargue>().ToList(); 
                 if (orderCriteria == "sID_EstadoProcesoCargue") result = result.OrderByDescending(p => p.sID_EstadoProcesoCargue).Cast<ProcesosCargue>().ToList(); 
                 if (orderCriteria == "FechaCargue") result = result.OrderByDescending(p => p.FechaCargue).Cast <ProcesosCargue>().ToList(); 
                 if (orderCriteria == "NombreArchivoProcesado") result = result.OrderByDescending(p => p.NombreArchivoProcesado).Cast <ProcesosCargue>().ToList(); 
                 if (orderCriteria == "Porcentaje") result = result.OrderByDescending(p => p.Porcentaje).Cast <ProcesosCargue>().ToList(); 
                 if (orderCriteria == "Procesados") result = result.OrderByDescending(p => p.Procesados).Cast <ProcesosCargue>().ToList(); 
                 if (orderCriteria == "Errores") result = result.OrderByDescending(p => p.Errores).Cast <ProcesosCargue>().ToList(); 
                 if (orderCriteria == "Cargado") result = result.OrderByDescending(p => p.Cargado).Cast <ProcesosCargue>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoProcesoCargue != null && r.ID_TipoProcesoCargue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoProcesoCargue != null && r.sID_TipoProcesoCargue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_EstadoProcesoCargue != null && r.ID_EstadoProcesoCargue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_EstadoProcesoCargue != null && r.sID_EstadoProcesoCargue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaCargue != null && r.FechaCargue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NombreArchivoProcesado != null && r.NombreArchivoProcesado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Porcentaje != null && r.Porcentaje.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Procesados != null && r.Procesados.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Errores != null && r.Errores.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Cargado != null && r.Cargado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad ProcesosCargue --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  ProcesosCargue!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ProcesosCargue</param>
        /// <response code="200">ProcesosCargue Consulto los registros exitosamente</response>
        /// <response code="400">ProcesosCargue tiene valores invalidos </response>
        /// <response code="401">ProcesosCargue No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ProcesosCargue en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new ProcesosCargueMs().GetAllByWithRelation().Cast<ProcesosCargue>().AsQueryable();
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
