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

namespace SISPAE_API_Priorizacion.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de Novedades .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class NovedadesController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Novedades --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Priorizacion de la entidad  Novedades!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Novedades</param>
        /// <response code="200">Novedades Consulto los registros exitosamente</response>
        /// <response code="400">Novedades tiene valores invalidos </response>
        /// <response code="401">Novedades No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Novedades en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new NovedadesMs().GetAll().Cast<Novedades>().AsQueryable();
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
        /// CRUD de la entidad Novedades --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Priorizacion de la entidad  Novedades!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Novedades</param>
        /// <response code="200">Novedades Consulto los registros exitosamente</response>
        /// <response code="400">Novedades tiene valores invalidos </response>
        /// <response code="401">Novedades No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Novedades en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new NovedadesMs().GetAllFull().Cast<Novedades>().AsQueryable();
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
        /// CRUD de la entidad Novedades --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Priorizacion de la entidad  Novedades!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Novedades</param>
        /// <response code="200">Novedades Consulto los registros exitosamente</response>
        /// <response code="400">Novedades tiene valores invalidos </response>
        /// <response code="401">Novedades No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Novedades en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new NovedadesMs().GetById(new Novedades() { id = id });
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
        /// CRUD de la entidad Novedades --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Priorizacion de la entidad  Novedades!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Novedades</param>
        /// <response code="200">Novedades Creado</response>
        /// <response code="400">Novedades tiene valores invalidos </response>
        /// <response code="401">Novedades No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Novedades en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Novedades obj)
        {
            try
            {
                var result = new NovedadesMs().Add(obj);
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
        /// CRUD de la entidad Novedades --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Priorizacion de la entidad  Novedades!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Novedades</param>
        /// <response code="200">Novedades Actualizado</response>
        /// <response code="400">Novedades tiene valores invalidos </response>
        /// <response code="401">Novedades No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Novedades en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Novedades obj)
        {
            try
            {
                var result = new NovedadesMs().Update(obj);
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
        /// CRUD de la entidad Novedades --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Priorizacion de la entidad  Novedades!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Novedades</param>
        /// <response code="200">Novedades Eliminado</response>
        /// <response code="400">Novedades tiene valores invalidos </response>
        /// <response code="401">Novedades No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Novedades en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Novedades obj)
        {
           try
            {
                new NovedadesMs().Delete(obj);
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
        /// DataTable de la entidad Novedades --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Novedades!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Novedades</param>
        /// <response code="200">Novedades Resultado</response>
        /// <response code="400">Novedades tiene valores invalidos </response>
        /// <response code="401">Novedades No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Novedades en este momento</response>
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

                var result = new NovedadesMs().GetAllByWithRelation().Cast<Novedades>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Novedades>().ToList();  
                if (orderCriteria == "ID_Sede") result = result.OrderBy(p => p.ID_Sede).Cast <Novedades>().ToList(); 
                 if (orderCriteria == "sID_Sedes") result = result.OrderBy(p => p.sID_Sede).Cast <Novedades>().ToList(); 
                 if (orderCriteria == "ID_Vigencia") result = result.OrderBy(p => p.ID_Vigencia).Cast <Novedades>().ToList(); 
                 if (orderCriteria == "sID_Vigencias") result = result.OrderBy(p => p.sID_Vigencia).Cast <Novedades>().ToList(); 
                 if (orderCriteria == "Fecha") result = result.OrderBy(p => p.Fecha).Cast <Novedades>().ToList(); 
                       }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Novedades>().ToList();  
                if (orderCriteria == "ID_Sede") result = result.OrderByDescending(p => p.ID_Sede).Cast <Novedades>().ToList(); 
                 if (orderCriteria == "sID_Sedes") result = result.OrderByDescending(p => p.sID_Sede).Cast<Novedades>().ToList(); 
                 if (orderCriteria == "ID_Vigencia") result = result.OrderByDescending(p => p.ID_Vigencia).Cast <Novedades>().ToList(); 
                 if (orderCriteria == "sID_Vigencias") result = result.OrderByDescending(p => p.sID_Vigencia).Cast<Novedades>().ToList(); 
                 if (orderCriteria == "Fecha") result = result.OrderByDescending(p => p.Fecha).Cast <Novedades>().ToList(); 
                       }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Sede != null && r.ID_Sede.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Sede != null && r.sID_Sede.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Vigencia != null && r.ID_Vigencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Vigencia != null && r.sID_Vigencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Fecha != null && r.Fecha.ToString().ToUpper().Contains(searchBy.ToUpper()) 
        
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
        /// CRUD de la entidad Novedades --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Priorizacion de la entidad  Novedades!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Novedades</param>
        /// <response code="200">Novedades Consulto los registros exitosamente</response>
        /// <response code="400">Novedades tiene valores invalidos </response>
        /// <response code="401">Novedades No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Novedades en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new NovedadesMs().GetAllByWithRelation().Cast<Novedades>().AsQueryable();
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
