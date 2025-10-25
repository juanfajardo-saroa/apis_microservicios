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
    [SwaggerTag("Web API para CRUD de StgPaises .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class StgPaisesController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad StgPaises --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgPaises!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgPaises</param>
        /// <response code="200">StgPaises Consulto los registros exitosamente</response>
        /// <response code="400">StgPaises tiene valores invalidos </response>
        /// <response code="401">StgPaises No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar StgPaises en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new StgPaisesMs().GetAll().Cast<StgPaises>().AsQueryable();
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
        /// CRUD de la entidad StgPaises --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgPaises!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgPaises</param>
        /// <response code="200">StgPaises Consulto los registros exitosamente</response>
        /// <response code="400">StgPaises tiene valores invalidos </response>
        /// <response code="401">StgPaises No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar StgPaises en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new StgPaisesMs().GetAllFull().Cast<StgPaises>().AsQueryable();
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
        /// CRUD de la entidad StgPaises --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgPaises!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgPaises</param>
        /// <response code="200">StgPaises Consulto los registros exitosamente</response>
        /// <response code="400">StgPaises tiene valores invalidos </response>
        /// <response code="401">StgPaises No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar StgPaises en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new StgPaisesMs().GetById(new StgPaises() { id = id });
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
        /// CRUD de la entidad StgPaises --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Staging de la entidad  StgPaises!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de StgPaises</param>
        /// <response code="200">StgPaises Creado</response>
        /// <response code="400">StgPaises tiene valores invalidos </response>
        /// <response code="401">StgPaises No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear StgPaises en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] StgPaises obj)
        {
            try
            {
                var result = new StgPaisesMs().Add(obj);
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
        /// CRUD de la entidad StgPaises --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Staging de la entidad  StgPaises!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de StgPaises</param>
        /// <response code="200">StgPaises Actualizado</response>
        /// <response code="400">StgPaises tiene valores invalidos </response>
        /// <response code="401">StgPaises No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar StgPaises en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] StgPaises obj)
        {
            try
            {
                var result = new StgPaisesMs().Update(obj);
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
        /// CRUD de la entidad StgPaises --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Staging de la entidad  StgPaises!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de StgPaises</param>
        /// <response code="200">StgPaises Eliminado</response>
        /// <response code="400">StgPaises tiene valores invalidos </response>
        /// <response code="401">StgPaises No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar StgPaises en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] StgPaises obj)
        {
           try
            {
                new StgPaisesMs().Delete(obj);
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
        /// DataTable de la entidad StgPaises --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  StgPaises!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de StgPaises</param>
        /// <response code="200">StgPaises Resultado</response>
        /// <response code="400">StgPaises tiene valores invalidos </response>
        /// <response code="401">StgPaises No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  StgPaises en este momento</response>
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

                var result = new StgPaisesMs().GetAllByWithRelation().Cast<StgPaises>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <StgPaises>().ToList();  
                if (orderCriteria == "IdPais") result = result.OrderBy(p => p.IdPais).Cast <StgPaises>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <StgPaises>().ToList(); 
                 if (orderCriteria == "Cod") result = result.OrderBy(p => p.Cod).Cast <StgPaises>().ToList(); 
                 if (orderCriteria == "FechaCreacion") result = result.OrderBy(p => p.FechaCreacion).Cast <StgPaises>().ToList(); 
                 if (orderCriteria == "auditoria") result = result.OrderBy(p => p.auditoria).Cast <StgPaises>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <StgPaises>().ToList();  
                if (orderCriteria == "IdPais") result = result.OrderByDescending(p => p.IdPais).Cast <StgPaises>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <StgPaises>().ToList(); 
                 if (orderCriteria == "Cod") result = result.OrderByDescending(p => p.Cod).Cast <StgPaises>().ToList(); 
                 if (orderCriteria == "FechaCreacion") result = result.OrderByDescending(p => p.FechaCreacion).Cast <StgPaises>().ToList(); 
                 if (orderCriteria == "auditoria") result = result.OrderByDescending(p => p.auditoria).Cast <StgPaises>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.IdPais != null && r.IdPais.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Cod != null && r.Cod.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaCreacion != null && r.FechaCreacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.auditoria != null && r.auditoria.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
        /// CRUD de la entidad StgPaises --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgPaises!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgPaises</param>
        /// <response code="200">StgPaises Consulto los registros exitosamente</response>
        /// <response code="400">StgPaises tiene valores invalidos </response>
        /// <response code="401">StgPaises No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar StgPaises en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new StgPaisesMs().GetAllByWithRelation().Cast<StgPaises>().AsQueryable();
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
