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

namespace SISPAE_API_Auditoria.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de LogErrores .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class LogErroresController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad LogErrores --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Auditoria de la entidad  LogErrores!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de LogErrores</param>
        /// <response code="200">LogErrores Consulto los registros exitosamente</response>
        /// <response code="400">LogErrores tiene valores invalidos </response>
        /// <response code="401">LogErrores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar LogErrores en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new LogErroresMs().GetAll().Cast<LogErrores>().AsQueryable();
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
        /// CRUD de la entidad LogErrores --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Auditoria de la entidad  LogErrores!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de LogErrores</param>
        /// <response code="200">LogErrores Consulto los registros exitosamente</response>
        /// <response code="400">LogErrores tiene valores invalidos </response>
        /// <response code="401">LogErrores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar LogErrores en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new LogErroresMs().GetAllFull().Cast<LogErrores>().AsQueryable();
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
        /// CRUD de la entidad LogErrores --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Auditoria de la entidad  LogErrores!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de LogErrores</param>
        /// <response code="200">LogErrores Consulto los registros exitosamente</response>
        /// <response code="400">LogErrores tiene valores invalidos </response>
        /// <response code="401">LogErrores No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar LogErrores en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new LogErroresMs().GetById(new LogErrores() { id = id });
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
        /// CRUD de la entidad LogErrores --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Auditoria de la entidad  LogErrores!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de LogErrores</param>
        /// <response code="200">LogErrores Creado</response>
        /// <response code="400">LogErrores tiene valores invalidos </response>
        /// <response code="401">LogErrores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear LogErrores en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] LogErrores obj)
        {
            try
            {
                var result = new LogErroresMs().Add(obj);
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
        /// CRUD de la entidad LogErrores --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Auditoria de la entidad  LogErrores!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de LogErrores</param>
        /// <response code="200">LogErrores Actualizado</response>
        /// <response code="400">LogErrores tiene valores invalidos </response>
        /// <response code="401">LogErrores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar LogErrores en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] LogErrores obj)
        {
            try
            {
                var result = new LogErroresMs().Update(obj);
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
        /// CRUD de la entidad LogErrores --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Auditoria de la entidad  LogErrores!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de LogErrores</param>
        /// <response code="200">LogErrores Eliminado</response>
        /// <response code="400">LogErrores tiene valores invalidos </response>
        /// <response code="401">LogErrores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar LogErrores en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] LogErrores obj)
        {
           try
            {
                new LogErroresMs().Delete(obj);
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
        /// DataTable de la entidad LogErrores --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  LogErrores!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de LogErrores</param>
        /// <response code="200">LogErrores Resultado</response>
        /// <response code="400">LogErrores tiene valores invalidos </response>
        /// <response code="401">LogErrores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  LogErrores en este momento</response>
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

                var result = new LogErroresMs().GetAllByWithRelation().Cast<LogErrores>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <LogErrores>().ToList();  
                if (orderCriteria == "ID_User") result = result.OrderBy(p => p.ID_User).Cast <LogErrores>().ToList(); 
                 if (orderCriteria == "sID_AspNetUsers") result = result.OrderBy(p => p.sID_User).Cast <LogErrores>().ToList(); 
                 if (orderCriteria == "Fecha") result = result.OrderBy(p => p.Fecha).Cast <LogErrores>().ToList(); 
                 if (orderCriteria == "Operacion") result = result.OrderBy(p => p.Operacion).Cast <LogErrores>().ToList(); 
                       }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <LogErrores>().ToList();  
                if (orderCriteria == "ID_User") result = result.OrderByDescending(p => p.ID_User).Cast <LogErrores>().ToList(); 
                 if (orderCriteria == "sID_AspNetUsers") result = result.OrderByDescending(p => p.sID_User).Cast<LogErrores>().ToList(); 
                 if (orderCriteria == "Fecha") result = result.OrderByDescending(p => p.Fecha).Cast <LogErrores>().ToList(); 
                 if (orderCriteria == "Operacion") result = result.OrderByDescending(p => p.Operacion).Cast <LogErrores>().ToList(); 
                       }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_User != null && r.ID_User.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_User != null && r.sID_User.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Fecha != null && r.Fecha.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Operacion != null && r.Operacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
        
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
        /// CRUD de la entidad LogErrores --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Auditoria de la entidad  LogErrores!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de LogErrores</param>
        /// <response code="200">LogErrores Consulto los registros exitosamente</response>
        /// <response code="400">LogErrores tiene valores invalidos </response>
        /// <response code="401">LogErrores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar LogErrores en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new LogErroresMs().GetAllByWithRelation().Cast<LogErrores>().AsQueryable();
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
