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
    [SwaggerTag("Web API para CRUD de MinutaAprobacionLeveHistorico .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class MinutaAprobacionLeveHistoricoController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad MinutaAprobacionLeveHistorico --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaAprobacionLeveHistorico!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaAprobacionLeveHistorico</param>
        /// <response code="200">MinutaAprobacionLeveHistorico Consulto los registros exitosamente</response>
        /// <response code="400">MinutaAprobacionLeveHistorico tiene valores invalidos </response>
        /// <response code="401">MinutaAprobacionLeveHistorico No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaAprobacionLeveHistorico en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new MinutaAprobacionLeveHistoricoMs().GetAll().Cast<MinutaAprobacionLeveHistorico>().AsQueryable();
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
        /// CRUD de la entidad MinutaAprobacionLeveHistorico --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaAprobacionLeveHistorico!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaAprobacionLeveHistorico</param>
        /// <response code="200">MinutaAprobacionLeveHistorico Consulto los registros exitosamente</response>
        /// <response code="400">MinutaAprobacionLeveHistorico tiene valores invalidos </response>
        /// <response code="401">MinutaAprobacionLeveHistorico No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaAprobacionLeveHistorico en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new MinutaAprobacionLeveHistoricoMs().GetAllFull().Cast<MinutaAprobacionLeveHistorico>().AsQueryable();
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
        /// CRUD de la entidad MinutaAprobacionLeveHistorico --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaAprobacionLeveHistorico!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaAprobacionLeveHistorico</param>
        /// <response code="200">MinutaAprobacionLeveHistorico Consulto los registros exitosamente</response>
        /// <response code="400">MinutaAprobacionLeveHistorico tiene valores invalidos </response>
        /// <response code="401">MinutaAprobacionLeveHistorico No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar MinutaAprobacionLeveHistorico en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new MinutaAprobacionLeveHistoricoMs().GetById(new MinutaAprobacionLeveHistorico() { id = id });
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
        /// CRUD de la entidad MinutaAprobacionLeveHistorico --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaAprobacionLeveHistorico!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de MinutaAprobacionLeveHistorico</param>
        /// <response code="200">MinutaAprobacionLeveHistorico Creado</response>
        /// <response code="400">MinutaAprobacionLeveHistorico tiene valores invalidos </response>
        /// <response code="401">MinutaAprobacionLeveHistorico No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear MinutaAprobacionLeveHistorico en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] MinutaAprobacionLeveHistorico obj)
        {
            try
            {
                var result = new MinutaAprobacionLeveHistoricoMs().Add(obj);
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
        /// CRUD de la entidad MinutaAprobacionLeveHistorico --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaAprobacionLeveHistorico!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de MinutaAprobacionLeveHistorico</param>
        /// <response code="200">MinutaAprobacionLeveHistorico Actualizado</response>
        /// <response code="400">MinutaAprobacionLeveHistorico tiene valores invalidos </response>
        /// <response code="401">MinutaAprobacionLeveHistorico No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar MinutaAprobacionLeveHistorico en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] MinutaAprobacionLeveHistorico obj)
        {
            try
            {
                var result = new MinutaAprobacionLeveHistoricoMs().Update(obj);
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
        /// CRUD de la entidad MinutaAprobacionLeveHistorico --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaAprobacionLeveHistorico!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de MinutaAprobacionLeveHistorico</param>
        /// <response code="200">MinutaAprobacionLeveHistorico Eliminado</response>
        /// <response code="400">MinutaAprobacionLeveHistorico tiene valores invalidos </response>
        /// <response code="401">MinutaAprobacionLeveHistorico No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar MinutaAprobacionLeveHistorico en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] MinutaAprobacionLeveHistorico obj)
        {
           try
            {
                new MinutaAprobacionLeveHistoricoMs().Delete(obj);
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
        /// DataTable de la entidad MinutaAprobacionLeveHistorico --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  MinutaAprobacionLeveHistorico!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de MinutaAprobacionLeveHistorico</param>
        /// <response code="200">MinutaAprobacionLeveHistorico Resultado</response>
        /// <response code="400">MinutaAprobacionLeveHistorico tiene valores invalidos </response>
        /// <response code="401">MinutaAprobacionLeveHistorico No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  MinutaAprobacionLeveHistorico en este momento</response>
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

                var result = new MinutaAprobacionLeveHistoricoMs().GetAllByWithRelation().Cast<MinutaAprobacionLeveHistorico>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <MinutaAprobacionLeveHistorico>().ToList();  
                if (orderCriteria == "ID_MinutaLeve") result = result.OrderBy(p => p.ID_MinutaLeve).Cast <MinutaAprobacionLeveHistorico>().ToList(); 
                 if (orderCriteria == "FechaAprobacion") result = result.OrderBy(p => p.FechaAprobacion).Cast <MinutaAprobacionLeveHistorico>().ToList(); 
                 if (orderCriteria == "ID_TipoEstadoMinuta") result = result.OrderBy(p => p.ID_TipoEstadoMinuta).Cast <MinutaAprobacionLeveHistorico>().ToList(); 
                 if (orderCriteria == "Responsable") result = result.OrderBy(p => p.Responsable).Cast <MinutaAprobacionLeveHistorico>().ToList(); 
                 if (orderCriteria == "RolResponsable") result = result.OrderBy(p => p.RolResponsable).Cast <MinutaAprobacionLeveHistorico>().ToList(); 
                 if (orderCriteria == "Accion") result = result.OrderBy(p => p.Accion).Cast <MinutaAprobacionLeveHistorico>().ToList(); 
                 if (orderCriteria == "Observaciones") result = result.OrderBy(p => p.Observaciones).Cast <MinutaAprobacionLeveHistorico>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <MinutaAprobacionLeveHistorico>().ToList();  
                if (orderCriteria == "ID_MinutaLeve") result = result.OrderByDescending(p => p.ID_MinutaLeve).Cast <MinutaAprobacionLeveHistorico>().ToList(); 
                 if (orderCriteria == "FechaAprobacion") result = result.OrderByDescending(p => p.FechaAprobacion).Cast <MinutaAprobacionLeveHistorico>().ToList(); 
                 if (orderCriteria == "ID_TipoEstadoMinuta") result = result.OrderByDescending(p => p.ID_TipoEstadoMinuta).Cast <MinutaAprobacionLeveHistorico>().ToList(); 
                 if (orderCriteria == "Responsable") result = result.OrderByDescending(p => p.Responsable).Cast <MinutaAprobacionLeveHistorico>().ToList(); 
                 if (orderCriteria == "RolResponsable") result = result.OrderByDescending(p => p.RolResponsable).Cast <MinutaAprobacionLeveHistorico>().ToList(); 
                 if (orderCriteria == "Accion") result = result.OrderByDescending(p => p.Accion).Cast <MinutaAprobacionLeveHistorico>().ToList(); 
                 if (orderCriteria == "Observaciones") result = result.OrderByDescending(p => p.Observaciones).Cast <MinutaAprobacionLeveHistorico>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_MinutaLeve != null && r.ID_MinutaLeve.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaAprobacion != null && r.FechaAprobacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoEstadoMinuta != null && r.ID_TipoEstadoMinuta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Responsable != null && r.Responsable.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.RolResponsable != null && r.RolResponsable.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Accion != null && r.Accion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Observaciones != null && r.Observaciones.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad MinutaAprobacionLeveHistorico --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaAprobacionLeveHistorico!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaAprobacionLeveHistorico</param>
        /// <response code="200">MinutaAprobacionLeveHistorico Consulto los registros exitosamente</response>
        /// <response code="400">MinutaAprobacionLeveHistorico tiene valores invalidos </response>
        /// <response code="401">MinutaAprobacionLeveHistorico No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaAprobacionLeveHistorico en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new MinutaAprobacionLeveHistoricoMs().GetAllByWithRelation().Cast<MinutaAprobacionLeveHistorico>().AsQueryable();
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
