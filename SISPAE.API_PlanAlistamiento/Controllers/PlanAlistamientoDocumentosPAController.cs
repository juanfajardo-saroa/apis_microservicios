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

namespace SISPAE.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de PlanAlistamientoDocumentosPA .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PlanAlistamientoDocumentosPAController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PlanAlistamientoDocumentosPA --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  PlanAlistamientoDocumentosPA!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlanAlistamientoDocumentosPA</param>
        /// <response code="200">PlanAlistamientoDocumentosPA Consulto los registros exitosamente</response>
        /// <response code="400">PlanAlistamientoDocumentosPA tiene valores invalidos </response>
        /// <response code="401">PlanAlistamientoDocumentosPA No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlanAlistamientoDocumentosPA en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new PlanAlistamientoDocumentosPAMs().GetAll().Cast<PlanAlistamientoDocumentosPA>().AsQueryable();
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
        /// CRUD de la entidad PlanAlistamientoDocumentosPA --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  PlanAlistamientoDocumentosPA!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlanAlistamientoDocumentosPA</param>
        /// <response code="200">PlanAlistamientoDocumentosPA Consulto los registros exitosamente</response>
        /// <response code="400">PlanAlistamientoDocumentosPA tiene valores invalidos </response>
        /// <response code="401">PlanAlistamientoDocumentosPA No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlanAlistamientoDocumentosPA en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new PlanAlistamientoDocumentosPAMs().GetAllFull().Cast<PlanAlistamientoDocumentosPA>().AsQueryable();
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
        /// CRUD de la entidad PlanAlistamientoDocumentosPA --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  PlanAlistamientoDocumentosPA!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlanAlistamientoDocumentosPA</param>
        /// <response code="200">PlanAlistamientoDocumentosPA Consulto los registros exitosamente</response>
        /// <response code="400">PlanAlistamientoDocumentosPA tiene valores invalidos </response>
        /// <response code="401">PlanAlistamientoDocumentosPA No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar PlanAlistamientoDocumentosPA en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new PlanAlistamientoDocumentosPAMs().GetById(new PlanAlistamientoDocumentosPA() { id = id });
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
        /// CRUD de la entidad PlanAlistamientoDocumentosPA --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE de la entidad  PlanAlistamientoDocumentosPA!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de PlanAlistamientoDocumentosPA</param>
        /// <response code="200">PlanAlistamientoDocumentosPA Creado</response>
        /// <response code="400">PlanAlistamientoDocumentosPA tiene valores invalidos </response>
        /// <response code="401">PlanAlistamientoDocumentosPA No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear PlanAlistamientoDocumentosPA en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] PlanAlistamientoDocumentosPA obj)
        {
            try
            {
                var result = new PlanAlistamientoDocumentosPAMs().Add(obj);
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
        /// CRUD de la entidad PlanAlistamientoDocumentosPA --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE de la entidad  PlanAlistamientoDocumentosPA!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de PlanAlistamientoDocumentosPA</param>
        /// <response code="200">PlanAlistamientoDocumentosPA Actualizado</response>
        /// <response code="400">PlanAlistamientoDocumentosPA tiene valores invalidos </response>
        /// <response code="401">PlanAlistamientoDocumentosPA No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar PlanAlistamientoDocumentosPA en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] PlanAlistamientoDocumentosPA obj)
        {
            try
            {
                var result = new PlanAlistamientoDocumentosPAMs().Update(obj);
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
        /// CRUD de la entidad PlanAlistamientoDocumentosPA --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE de la entidad  PlanAlistamientoDocumentosPA!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de PlanAlistamientoDocumentosPA</param>
        /// <response code="200">PlanAlistamientoDocumentosPA Eliminado</response>
        /// <response code="400">PlanAlistamientoDocumentosPA tiene valores invalidos </response>
        /// <response code="401">PlanAlistamientoDocumentosPA No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar PlanAlistamientoDocumentosPA en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] PlanAlistamientoDocumentosPA obj)
        {
           try
            {
                new PlanAlistamientoDocumentosPAMs().Delete(obj);
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
        /// DataTable de la entidad PlanAlistamientoDocumentosPA --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  PlanAlistamientoDocumentosPA!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de PlanAlistamientoDocumentosPA</param>
        /// <response code="200">PlanAlistamientoDocumentosPA Resultado</response>
        /// <response code="400">PlanAlistamientoDocumentosPA tiene valores invalidos </response>
        /// <response code="401">PlanAlistamientoDocumentosPA No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  PlanAlistamientoDocumentosPA en este momento</response>
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

                var result = new PlanAlistamientoDocumentosPAMs().GetAllByWithRelation().Cast<PlanAlistamientoDocumentosPA>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <PlanAlistamientoDocumentosPA>().ToList();  
                if (orderCriteria == "ID_PlanAlistamiento") result = result.OrderBy(p => p.ID_PlanAlistamiento).Cast <PlanAlistamientoDocumentosPA>().ToList(); 
                 if (orderCriteria == "sID_PlanesAlistamientos") result = result.OrderBy(p => p.sID_PlanAlistamiento).Cast <PlanAlistamientoDocumentosPA>().ToList(); 
                 if (orderCriteria == "ID_DocumentoPA") result = result.OrderBy(p => p.ID_DocumentoPA).Cast <PlanAlistamientoDocumentosPA>().ToList(); 
                 if (orderCriteria == "sID_DocumentosPA") result = result.OrderBy(p => p.sID_DocumentoPA).Cast <PlanAlistamientoDocumentosPA>().ToList(); 
                 if (orderCriteria == "ID_Vigencia") result = result.OrderBy(p => p.ID_Vigencia).Cast <PlanAlistamientoDocumentosPA>().ToList(); 
                 if (orderCriteria == "sID_Vigencias") result = result.OrderBy(p => p.ID_Vigencia).Cast <PlanAlistamientoDocumentosPA>().ToList(); 
                 if (orderCriteria == "ID_Estado") result = result.OrderBy(p => p.ID_Estado).Cast <PlanAlistamientoDocumentosPA>().ToList(); 
                     }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <PlanAlistamientoDocumentosPA>().ToList();  
                if (orderCriteria == "ID_PlanAlistamiento") result = result.OrderByDescending(p => p.ID_PlanAlistamiento).Cast <PlanAlistamientoDocumentosPA>().ToList(); 
                 if (orderCriteria == "sID_PlanesAlistamientos") result = result.OrderByDescending(p => p.sID_PlanAlistamiento).Cast<PlanAlistamientoDocumentosPA>().ToList(); 
                 if (orderCriteria == "ID_DocumentoPA") result = result.OrderByDescending(p => p.ID_DocumentoPA).Cast <PlanAlistamientoDocumentosPA>().ToList(); 
                 if (orderCriteria == "sID_DocumentosPA") result = result.OrderByDescending(p => p.sID_DocumentoPA).Cast<PlanAlistamientoDocumentosPA>().ToList(); 
                 if (orderCriteria == "ID_Vigencia") result = result.OrderByDescending(p => p.ID_Vigencia).Cast <PlanAlistamientoDocumentosPA>().ToList(); 
                 if (orderCriteria == "sID_Vigencias") result = result.OrderByDescending(p => p.ID_Vigencia).Cast<PlanAlistamientoDocumentosPA>().ToList(); 
                 if (orderCriteria == "ID_Estado") result = result.OrderByDescending(p => p.ID_Estado).Cast <PlanAlistamientoDocumentosPA>().ToList(); 
                     }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_PlanAlistamiento != null && r.ID_PlanAlistamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_PlanAlistamiento != null && r.sID_PlanAlistamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_DocumentoPA != null && r.ID_DocumentoPA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_DocumentoPA != null && r.sID_DocumentoPA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Vigencia != null && r.ID_Vigencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Vigencia != null && r.ID_Vigencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Estado != null && r.ID_Estado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
      
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
        /// CRUD de la entidad PlanAlistamientoDocumentosPA --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  PlanAlistamientoDocumentosPA!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlanAlistamientoDocumentosPA</param>
        /// <response code="200">PlanAlistamientoDocumentosPA Consulto los registros exitosamente</response>
        /// <response code="400">PlanAlistamientoDocumentosPA tiene valores invalidos </response>
        /// <response code="401">PlanAlistamientoDocumentosPA No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlanAlistamientoDocumentosPA en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new PlanAlistamientoDocumentosPAMs().GetAllByWithRelation().Cast<PlanAlistamientoDocumentosPA>().AsQueryable();
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
