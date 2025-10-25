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
    [SwaggerTag("Web API para CRUD de MinutaAprobacion .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class MinutaAprobacionController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad MinutaAprobacion --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaAprobacion!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaAprobacion</param>
        /// <response code="200">MinutaAprobacion Consulto los registros exitosamente</response>
        /// <response code="400">MinutaAprobacion tiene valores invalidos </response>
        /// <response code="401">MinutaAprobacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaAprobacion en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new MinutaAprobacionMs().GetAll().Cast<MinutaAprobacion>().AsQueryable();
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
        /// CRUD de la entidad MinutaAprobacion --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaAprobacion!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaAprobacion</param>
        /// <response code="200">MinutaAprobacion Consulto los registros exitosamente</response>
        /// <response code="400">MinutaAprobacion tiene valores invalidos </response>
        /// <response code="401">MinutaAprobacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaAprobacion en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new MinutaAprobacionMs().GetAllFull().Cast<MinutaAprobacion>().AsQueryable();
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
        /// CRUD de la entidad MinutaAprobacion --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaAprobacion!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaAprobacion</param>
        /// <response code="200">MinutaAprobacion Consulto los registros exitosamente</response>
        /// <response code="400">MinutaAprobacion tiene valores invalidos </response>
        /// <response code="401">MinutaAprobacion No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar MinutaAprobacion en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new MinutaAprobacionMs().GetById(new MinutaAprobacion() { id = id });
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
        /// CRUD de la entidad MinutaAprobacion --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaAprobacion!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de MinutaAprobacion</param>
        /// <response code="200">MinutaAprobacion Creado</response>
        /// <response code="400">MinutaAprobacion tiene valores invalidos </response>
        /// <response code="401">MinutaAprobacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear MinutaAprobacion en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] MinutaAprobacion obj)
        {
            try
            {
                var result = new MinutaAprobacionMs().Add(obj);
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
        /// CRUD de la entidad MinutaAprobacion --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaAprobacion!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de MinutaAprobacion</param>
        /// <response code="200">MinutaAprobacion Actualizado</response>
        /// <response code="400">MinutaAprobacion tiene valores invalidos </response>
        /// <response code="401">MinutaAprobacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar MinutaAprobacion en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] MinutaAprobacion obj)
        {
            try
            {
                var result = new MinutaAprobacionMs().Update(obj);
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
        /// CRUD de la entidad MinutaAprobacion --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaAprobacion!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de MinutaAprobacion</param>
        /// <response code="200">MinutaAprobacion Eliminado</response>
        /// <response code="400">MinutaAprobacion tiene valores invalidos </response>
        /// <response code="401">MinutaAprobacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar MinutaAprobacion en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] MinutaAprobacion obj)
        {
           try
            {
                new MinutaAprobacionMs().Delete(obj);
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
        /// DataTable de la entidad MinutaAprobacion --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  MinutaAprobacion!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de MinutaAprobacion</param>
        /// <response code="200">MinutaAprobacion Resultado</response>
        /// <response code="400">MinutaAprobacion tiene valores invalidos </response>
        /// <response code="401">MinutaAprobacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  MinutaAprobacion en este momento</response>
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

                var result = new MinutaAprobacionMs().GetAllByWithRelation().Cast<MinutaAprobacion>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <MinutaAprobacion>().ToList();  
                if (orderCriteria == "ID_TipoEstadoMinuta") result = result.OrderBy(p => p.ID_TipoEstadoMinuta).Cast <MinutaAprobacion>().ToList(); 
                 if (orderCriteria == "Recomendaciones") result = result.OrderBy(p => p.Recomendaciones).Cast <MinutaAprobacion>().ToList(); 
                     if (orderCriteria == "Rechazado") result = result.OrderBy(p => p.Rechazado).Cast <MinutaAprobacion>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <MinutaAprobacion>().ToList();  
                if (orderCriteria == "ID_TipoEstadoMinuta") result = result.OrderByDescending(p => p.ID_TipoEstadoMinuta).Cast <MinutaAprobacion>().ToList(); 
                 if (orderCriteria == "Recomendaciones") result = result.OrderByDescending(p => p.Recomendaciones).Cast <MinutaAprobacion>().ToList(); 
                     if (orderCriteria == "Rechazado") result = result.OrderByDescending(p => p.Rechazado).Cast <MinutaAprobacion>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoEstadoMinuta != null && r.ID_TipoEstadoMinuta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Recomendaciones != null && r.Recomendaciones.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                     || r.Rechazado != null && r.Rechazado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad MinutaAprobacion --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaAprobacion!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaAprobacion</param>
        /// <response code="200">MinutaAprobacion Consulto los registros exitosamente</response>
        /// <response code="400">MinutaAprobacion tiene valores invalidos </response>
        /// <response code="401">MinutaAprobacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaAprobacion en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new MinutaAprobacionMs().GetAllByWithRelation().Cast<MinutaAprobacion>().AsQueryable();
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
