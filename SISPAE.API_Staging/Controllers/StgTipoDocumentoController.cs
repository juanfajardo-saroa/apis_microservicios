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
    [SwaggerTag("Web API para CRUD de StgTipoDocumento .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class StgTipoDocumentoController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad StgTipoDocumento --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgTipoDocumento!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgTipoDocumento</param>
        /// <response code="200">StgTipoDocumento Consulto los registros exitosamente</response>
        /// <response code="400">StgTipoDocumento tiene valores invalidos </response>
        /// <response code="401">StgTipoDocumento No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar StgTipoDocumento en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new StgTipoDocumentoMs().GetAll().Cast<StgTipoDocumento>().AsQueryable();
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
        /// CRUD de la entidad StgTipoDocumento --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgTipoDocumento!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgTipoDocumento</param>
        /// <response code="200">StgTipoDocumento Consulto los registros exitosamente</response>
        /// <response code="400">StgTipoDocumento tiene valores invalidos </response>
        /// <response code="401">StgTipoDocumento No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar StgTipoDocumento en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new StgTipoDocumentoMs().GetAllFull().Cast<StgTipoDocumento>().AsQueryable();
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
        /// CRUD de la entidad StgTipoDocumento --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgTipoDocumento!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgTipoDocumento</param>
        /// <response code="200">StgTipoDocumento Consulto los registros exitosamente</response>
        /// <response code="400">StgTipoDocumento tiene valores invalidos </response>
        /// <response code="401">StgTipoDocumento No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar StgTipoDocumento en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new StgTipoDocumentoMs().GetById(new StgTipoDocumento() { id = id });
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
        /// CRUD de la entidad StgTipoDocumento --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Staging de la entidad  StgTipoDocumento!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de StgTipoDocumento</param>
        /// <response code="200">StgTipoDocumento Creado</response>
        /// <response code="400">StgTipoDocumento tiene valores invalidos </response>
        /// <response code="401">StgTipoDocumento No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear StgTipoDocumento en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] StgTipoDocumento obj)
        {
            try
            {
                var result = new StgTipoDocumentoMs().Add(obj);
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
        /// CRUD de la entidad StgTipoDocumento --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Staging de la entidad  StgTipoDocumento!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de StgTipoDocumento</param>
        /// <response code="200">StgTipoDocumento Actualizado</response>
        /// <response code="400">StgTipoDocumento tiene valores invalidos </response>
        /// <response code="401">StgTipoDocumento No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar StgTipoDocumento en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] StgTipoDocumento obj)
        {
            try
            {
                var result = new StgTipoDocumentoMs().Update(obj);
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
        /// CRUD de la entidad StgTipoDocumento --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Staging de la entidad  StgTipoDocumento!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de StgTipoDocumento</param>
        /// <response code="200">StgTipoDocumento Eliminado</response>
        /// <response code="400">StgTipoDocumento tiene valores invalidos </response>
        /// <response code="401">StgTipoDocumento No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar StgTipoDocumento en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] StgTipoDocumento obj)
        {
           try
            {
                new StgTipoDocumentoMs().Delete(obj);
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
        /// DataTable de la entidad StgTipoDocumento --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  StgTipoDocumento!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de StgTipoDocumento</param>
        /// <response code="200">StgTipoDocumento Resultado</response>
        /// <response code="400">StgTipoDocumento tiene valores invalidos </response>
        /// <response code="401">StgTipoDocumento No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  StgTipoDocumento en este momento</response>
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

                var result = new StgTipoDocumentoMs().GetAllByWithRelation().Cast<StgTipoDocumento>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <StgTipoDocumento>().ToList();  
                if (orderCriteria == "IdTipoDocumento") result = result.OrderBy(p => p.IdTipoDocumento).Cast <StgTipoDocumento>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <StgTipoDocumento>().ToList(); 
                 if (orderCriteria == "FechaCreacion") result = result.OrderBy(p => p.FechaCreacion).Cast <StgTipoDocumento>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <StgTipoDocumento>().ToList();  
                if (orderCriteria == "IdTipoDocumento") result = result.OrderByDescending(p => p.IdTipoDocumento).Cast <StgTipoDocumento>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <StgTipoDocumento>().ToList(); 
                 if (orderCriteria == "FechaCreacion") result = result.OrderByDescending(p => p.FechaCreacion).Cast <StgTipoDocumento>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.IdTipoDocumento != null && r.IdTipoDocumento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaCreacion != null && r.FechaCreacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad StgTipoDocumento --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgTipoDocumento!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgTipoDocumento</param>
        /// <response code="200">StgTipoDocumento Consulto los registros exitosamente</response>
        /// <response code="400">StgTipoDocumento tiene valores invalidos </response>
        /// <response code="401">StgTipoDocumento No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar StgTipoDocumento en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new StgTipoDocumentoMs().GetAllByWithRelation().Cast<StgTipoDocumento>().AsQueryable();
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
