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

namespace SISPAE_API_Infraestructura.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de ValorCaracteristicas .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class ValorCaracteristicasController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad ValorCaracteristicas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Infraestructura de la entidad  ValorCaracteristicas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ValorCaracteristicas</param>
        /// <response code="200">ValorCaracteristicas Consulto los registros exitosamente</response>
        /// <response code="400">ValorCaracteristicas tiene valores invalidos </response>
        /// <response code="401">ValorCaracteristicas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ValorCaracteristicas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new ValorCaracteristicasMs().GetAll().Cast<ValorCaracteristicas>().AsQueryable();
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
        /// CRUD de la entidad ValorCaracteristicas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Infraestructura de la entidad  ValorCaracteristicas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ValorCaracteristicas</param>
        /// <response code="200">ValorCaracteristicas Consulto los registros exitosamente</response>
        /// <response code="400">ValorCaracteristicas tiene valores invalidos </response>
        /// <response code="401">ValorCaracteristicas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ValorCaracteristicas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new ValorCaracteristicasMs().GetAllFull().Cast<ValorCaracteristicas>().AsQueryable();
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
        /// CRUD de la entidad ValorCaracteristicas --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Infraestructura de la entidad  ValorCaracteristicas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ValorCaracteristicas</param>
        /// <response code="200">ValorCaracteristicas Consulto los registros exitosamente</response>
        /// <response code="400">ValorCaracteristicas tiene valores invalidos </response>
        /// <response code="401">ValorCaracteristicas No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar ValorCaracteristicas en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new ValorCaracteristicasMs().GetById(new ValorCaracteristicas() { id = id });
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
        /// CRUD de la entidad ValorCaracteristicas --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Infraestructura de la entidad  ValorCaracteristicas!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de ValorCaracteristicas</param>
        /// <response code="200">ValorCaracteristicas Creado</response>
        /// <response code="400">ValorCaracteristicas tiene valores invalidos </response>
        /// <response code="401">ValorCaracteristicas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear ValorCaracteristicas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] ValorCaracteristicas obj)
        {

            try
            {
                var result = new ValorCaracteristicasMs().Add(obj);
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
        /// CRUD de la entidad ValorCaracteristicas --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Infraestructura de la entidad  ValorCaracteristicas!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de ValorCaracteristicas</param>
        /// <response code="200">ValorCaracteristicas Actualizado</response>
        /// <response code="400">ValorCaracteristicas tiene valores invalidos </response>
        /// <response code="401">ValorCaracteristicas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar ValorCaracteristicas en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] ValorCaracteristicas obj)
        {
            try
            {
                var result = new ValorCaracteristicasMs().Update(obj);
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
        /// CRUD de la entidad ValorCaracteristicas --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Infraestructura de la entidad  ValorCaracteristicas!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de ValorCaracteristicas</param>
        /// <response code="200">ValorCaracteristicas Eliminado</response>
        /// <response code="400">ValorCaracteristicas tiene valores invalidos </response>
        /// <response code="401">ValorCaracteristicas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar ValorCaracteristicas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] ValorCaracteristicas obj)
        {
           try
            {
                new ValorCaracteristicasMs().Delete(obj);
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
        /// DataTable de la entidad ValorCaracteristicas --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  ValorCaracteristicas!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de ValorCaracteristicas</param>
        /// <response code="200">ValorCaracteristicas Resultado</response>
        /// <response code="400">ValorCaracteristicas tiene valores invalidos </response>
        /// <response code="401">ValorCaracteristicas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  ValorCaracteristicas en este momento</response>
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

                var result = new ValorCaracteristicasMs().GetAllByWithRelation().Cast<ValorCaracteristicas>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <ValorCaracteristicas>().ToList();  
                if (orderCriteria == "ID_Caracterizacion") result = result.OrderBy(p => p.ID_Caracterizacion).Cast <ValorCaracteristicas>().ToList(); 
                 if (orderCriteria == "sID_CaracterizacionInfraestructura") result = result.OrderBy(p => p.sID_Caracterizacion).Cast <ValorCaracteristicas>().ToList(); 
                 if (orderCriteria == "ID_ValorEscala") result = result.OrderBy(p => p.ID_ValorEscala).Cast <ValorCaracteristicas>().ToList(); 
                 if (orderCriteria == "sID_ValorEscalas") result = result.OrderBy(p => p.sID_ValorEscala).Cast <ValorCaracteristicas>().ToList(); 
                   if (orderCriteria == "ID_Caracteristica") result = result.OrderBy(p => p.ID_Caracteristica).Cast <ValorCaracteristicas>().ToList(); 
                 if (orderCriteria == "sID_Caracteristicas") result = result.OrderBy(p => p.sID_Caracteristica).Cast <ValorCaracteristicas>().ToList(); 
                 if (orderCriteria == "Valor") result = result.OrderBy(p => p.Valor).Cast <ValorCaracteristicas>().ToList(); 
                 if (orderCriteria == "fecha") result = result.OrderBy(p => p.fecha).Cast <ValorCaracteristicas>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <ValorCaracteristicas>().ToList();  
                if (orderCriteria == "ID_Caracterizacion") result = result.OrderByDescending(p => p.ID_Caracterizacion).Cast <ValorCaracteristicas>().ToList(); 
                 if (orderCriteria == "sID_CaracterizacionInfraestructura") result = result.OrderByDescending(p => p.sID_Caracterizacion).Cast<ValorCaracteristicas>().ToList(); 
                 if (orderCriteria == "ID_ValorEscala") result = result.OrderByDescending(p => p.ID_ValorEscala).Cast <ValorCaracteristicas>().ToList(); 
                 if (orderCriteria == "sID_ValorEscalas") result = result.OrderByDescending(p => p.sID_ValorEscala).Cast<ValorCaracteristicas>().ToList(); 
                   if (orderCriteria == "ID_Caracteristica") result = result.OrderByDescending(p => p.ID_Caracteristica).Cast <ValorCaracteristicas>().ToList(); 
                 if (orderCriteria == "sID_Caracteristicas") result = result.OrderByDescending(p => p.sID_Caracteristica).Cast<ValorCaracteristicas>().ToList(); 
                 if (orderCriteria == "Valor") result = result.OrderByDescending(p => p.Valor).Cast <ValorCaracteristicas>().ToList(); 
                 if (orderCriteria == "fecha") result = result.OrderByDescending(p => p.fecha).Cast <ValorCaracteristicas>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Caracterizacion != null && r.ID_Caracterizacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Caracterizacion != null && r.sID_Caracterizacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_ValorEscala != null && r.ID_ValorEscala.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ValorEscala != null && r.sID_ValorEscala.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_Caracteristica != null && r.ID_Caracteristica.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Caracteristica != null && r.sID_Caracteristica.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Valor != null && r.Valor.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.fecha != null && r.fecha.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
        /// CRUD de la entidad ValorCaracteristicas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Infraestructura de la entidad  ValorCaracteristicas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ValorCaracteristicas</param>
        /// <response code="200">ValorCaracteristicas Consulto los registros exitosamente</response>
        /// <response code="400">ValorCaracteristicas tiene valores invalidos </response>
        /// <response code="401">ValorCaracteristicas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ValorCaracteristicas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new ValorCaracteristicasMs().GetAllByWithRelation().Cast<ValorCaracteristicas>().AsQueryable();
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
