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
    [SwaggerTag("Web API para CRUD de AuditoriaMinutas .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class AuditoriaMinutasController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad AuditoriaMinutas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Auditoria de la entidad  AuditoriaMinutas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AuditoriaMinutas</param>
        /// <response code="200">AuditoriaMinutas Consulto los registros exitosamente</response>
        /// <response code="400">AuditoriaMinutas tiene valores invalidos </response>
        /// <response code="401">AuditoriaMinutas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AuditoriaMinutas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new AuditoriaMinutasMs().GetAll().Cast<AuditoriaMinutas>().AsQueryable();
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
        /// CRUD de la entidad AuditoriaMinutas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Auditoria de la entidad  AuditoriaMinutas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AuditoriaMinutas</param>
        /// <response code="200">AuditoriaMinutas Consulto los registros exitosamente</response>
        /// <response code="400">AuditoriaMinutas tiene valores invalidos </response>
        /// <response code="401">AuditoriaMinutas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AuditoriaMinutas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new AuditoriaMinutasMs().GetAllFull().Cast<AuditoriaMinutas>().AsQueryable();
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
        /// CRUD de la entidad AuditoriaMinutas --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Auditoria de la entidad  AuditoriaMinutas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AuditoriaMinutas</param>
        /// <response code="200">AuditoriaMinutas Consulto los registros exitosamente</response>
        /// <response code="400">AuditoriaMinutas tiene valores invalidos </response>
        /// <response code="401">AuditoriaMinutas No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar AuditoriaMinutas en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new AuditoriaMinutasMs().GetById(new AuditoriaMinutas() { id = id });
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
        /// CRUD de la entidad AuditoriaMinutas --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Auditoria de la entidad  AuditoriaMinutas!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de AuditoriaMinutas</param>
        /// <response code="200">AuditoriaMinutas Creado</response>
        /// <response code="400">AuditoriaMinutas tiene valores invalidos </response>
        /// <response code="401">AuditoriaMinutas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear AuditoriaMinutas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] AuditoriaMinutas obj)
        {
            try
            {
                var result = new AuditoriaMinutasMs().Add(obj);
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
        /// CRUD de la entidad AuditoriaMinutas --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Auditoria de la entidad  AuditoriaMinutas!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de AuditoriaMinutas</param>
        /// <response code="200">AuditoriaMinutas Actualizado</response>
        /// <response code="400">AuditoriaMinutas tiene valores invalidos </response>
        /// <response code="401">AuditoriaMinutas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar AuditoriaMinutas en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] AuditoriaMinutas obj)
        {
            try
            {
                var result = new AuditoriaMinutasMs().Update(obj);
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
        /// CRUD de la entidad AuditoriaMinutas --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Auditoria de la entidad  AuditoriaMinutas!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de AuditoriaMinutas</param>
        /// <response code="200">AuditoriaMinutas Eliminado</response>
        /// <response code="400">AuditoriaMinutas tiene valores invalidos </response>
        /// <response code="401">AuditoriaMinutas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar AuditoriaMinutas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] AuditoriaMinutas obj)
        {
           try
            {
                new AuditoriaMinutasMs().Delete(obj);
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
        /// DataTable de la entidad AuditoriaMinutas --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  AuditoriaMinutas!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de AuditoriaMinutas</param>
        /// <response code="200">AuditoriaMinutas Resultado</response>
        /// <response code="400">AuditoriaMinutas tiene valores invalidos </response>
        /// <response code="401">AuditoriaMinutas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  AuditoriaMinutas en este momento</response>
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

                var result = new AuditoriaMinutasMs().GetAllByWithRelation().Cast<AuditoriaMinutas>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <AuditoriaMinutas>().ToList();  
                if (orderCriteria == "ID_User") result = result.OrderBy(p => p.ID_User).Cast <AuditoriaMinutas>().ToList(); 
                 if (orderCriteria == "ID_MinutaPatronAlimento") result = result.OrderBy(p => p.ID_MinutaPatronAlimento).Cast <AuditoriaMinutas>().ToList(); 
                 if (orderCriteria == "ID_TipoOperacion") result = result.OrderBy(p => p.ID_TipoOperacion).Cast <AuditoriaMinutas>().ToList(); 
                 if (orderCriteria == "sID_TiposOperacion") result = result.OrderBy(p => p.sID_TipoOperacion).Cast <AuditoriaMinutas>().ToList(); 
                 if (orderCriteria == "FechaCambio") result = result.OrderBy(p => p.FechaCambio).Cast <AuditoriaMinutas>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <AuditoriaMinutas>().ToList();  
                if (orderCriteria == "ID_User") result = result.OrderByDescending(p => p.ID_User).Cast <AuditoriaMinutas>().ToList(); 
                 if (orderCriteria == "ID_MinutaPatronAlimento") result = result.OrderByDescending(p => p.ID_MinutaPatronAlimento).Cast <AuditoriaMinutas>().ToList(); 
                 if (orderCriteria == "ID_TipoOperacion") result = result.OrderByDescending(p => p.ID_TipoOperacion).Cast <AuditoriaMinutas>().ToList(); 
                 if (orderCriteria == "sID_TiposOperacion") result = result.OrderByDescending(p => p.sID_TipoOperacion).Cast<AuditoriaMinutas>().ToList(); 
                 if (orderCriteria == "FechaCambio") result = result.OrderByDescending(p => p.FechaCambio).Cast <AuditoriaMinutas>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_User != null && r.ID_User.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_MinutaPatronAlimento != null && r.ID_MinutaPatronAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoOperacion != null && r.ID_TipoOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoOperacion != null && r.sID_TipoOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaCambio != null && r.FechaCambio.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad AuditoriaMinutas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Auditoria de la entidad  AuditoriaMinutas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AuditoriaMinutas</param>
        /// <response code="200">AuditoriaMinutas Consulto los registros exitosamente</response>
        /// <response code="400">AuditoriaMinutas tiene valores invalidos </response>
        /// <response code="401">AuditoriaMinutas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AuditoriaMinutas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new AuditoriaMinutasMs().GetAllByWithRelation().Cast<AuditoriaMinutas>().AsQueryable();
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
