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

namespace SISPAE_API_PlanAlistamiento.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de PlantasBodegasDocumentosPA .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PlantasBodegasDocumentosPAController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PlantasBodegasDocumentosPA --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlantasBodegasDocumentosPA!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlantasBodegasDocumentosPA</param>
        /// <response code="200">PlantasBodegasDocumentosPA Consulto los registros exitosamente</response>
        /// <response code="400">PlantasBodegasDocumentosPA tiene valores invalidos </response>
        /// <response code="401">PlantasBodegasDocumentosPA No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlantasBodegasDocumentosPA en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new PlantasBodegasDocumentosPAMs().GetAll().Cast<PlantasBodegasDocumentosPA>().AsQueryable();
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
        /// CRUD de la entidad PlantasBodegasDocumentosPA --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlantasBodegasDocumentosPA!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlantasBodegasDocumentosPA</param>
        /// <response code="200">PlantasBodegasDocumentosPA Consulto los registros exitosamente</response>
        /// <response code="400">PlantasBodegasDocumentosPA tiene valores invalidos </response>
        /// <response code="401">PlantasBodegasDocumentosPA No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlantasBodegasDocumentosPA en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new PlantasBodegasDocumentosPAMs().GetAllFull().Cast<PlantasBodegasDocumentosPA>().AsQueryable();
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
        /// CRUD de la entidad PlantasBodegasDocumentosPA --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlantasBodegasDocumentosPA!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlantasBodegasDocumentosPA</param>
        /// <response code="200">PlantasBodegasDocumentosPA Consulto los registros exitosamente</response>
        /// <response code="400">PlantasBodegasDocumentosPA tiene valores invalidos </response>
        /// <response code="401">PlantasBodegasDocumentosPA No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar PlantasBodegasDocumentosPA en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new PlantasBodegasDocumentosPAMs().GetById(new PlantasBodegasDocumentosPA() { id = id });
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
        /// CRUD de la entidad PlantasBodegasDocumentosPA --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlantasBodegasDocumentosPA!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de PlantasBodegasDocumentosPA</param>
        /// <response code="200">PlantasBodegasDocumentosPA Creado</response>
        /// <response code="400">PlantasBodegasDocumentosPA tiene valores invalidos </response>
        /// <response code="401">PlantasBodegasDocumentosPA No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear PlantasBodegasDocumentosPA en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] PlantasBodegasDocumentosPA obj)
        {
            try
            {
                var result = new PlantasBodegasDocumentosPAMs().Add(obj);
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
        /// CRUD de la entidad PlantasBodegasDocumentosPA --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlantasBodegasDocumentosPA!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de PlantasBodegasDocumentosPA</param>
        /// <response code="200">PlantasBodegasDocumentosPA Actualizado</response>
        /// <response code="400">PlantasBodegasDocumentosPA tiene valores invalidos </response>
        /// <response code="401">PlantasBodegasDocumentosPA No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar PlantasBodegasDocumentosPA en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] PlantasBodegasDocumentosPA obj)
        {
            try
            {
                var result = new PlantasBodegasDocumentosPAMs().Update(obj);
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
        /// CRUD de la entidad PlantasBodegasDocumentosPA --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlantasBodegasDocumentosPA!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de PlantasBodegasDocumentosPA</param>
        /// <response code="200">PlantasBodegasDocumentosPA Eliminado</response>
        /// <response code="400">PlantasBodegasDocumentosPA tiene valores invalidos </response>
        /// <response code="401">PlantasBodegasDocumentosPA No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar PlantasBodegasDocumentosPA en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] PlantasBodegasDocumentosPA obj)
        {
           try
            {
                new PlantasBodegasDocumentosPAMs().Delete(obj);
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
        /// DataTable de la entidad PlantasBodegasDocumentosPA --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  PlantasBodegasDocumentosPA!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de PlantasBodegasDocumentosPA</param>
        /// <response code="200">PlantasBodegasDocumentosPA Resultado</response>
        /// <response code="400">PlantasBodegasDocumentosPA tiene valores invalidos </response>
        /// <response code="401">PlantasBodegasDocumentosPA No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  PlantasBodegasDocumentosPA en este momento</response>
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

                var result = new PlantasBodegasDocumentosPAMs().GetAllByWithRelation().Cast<PlantasBodegasDocumentosPA>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <PlantasBodegasDocumentosPA>().ToList();  
                if (orderCriteria == "ID_PlantaBodegas") result = result.OrderBy(p => p.ID_PlantaBodegas).Cast <PlantasBodegasDocumentosPA>().ToList(); 
                 if (orderCriteria == "sID_PlantaBodegas") result = result.OrderBy(p => p.sID_PlantaBodegas).Cast <PlantasBodegasDocumentosPA>().ToList(); 
                 if (orderCriteria == "ID_DocumentoPA") result = result.OrderBy(p => p.ID_DocumentoPA).Cast <PlantasBodegasDocumentosPA>().ToList(); 
                 if (orderCriteria == "sID_DocumentosPA") result = result.OrderBy(p => p.sID_DocumentoPA).Cast <PlantasBodegasDocumentosPA>().ToList(); 
                 if (orderCriteria == "ID_Estado") result = result.OrderBy(p => p.ID_Estado).Cast <PlantasBodegasDocumentosPA>().ToList(); 
                 if (orderCriteria == "sID_EstadoDocumento") result = result.OrderBy(p => p.sID_Estado).Cast <PlantasBodegasDocumentosPA>().ToList(); 
                 if (orderCriteria == "idVigencia") result = result.OrderBy(p => p.idVigencia).Cast <PlantasBodegasDocumentosPA>().ToList(); 
                     if (orderCriteria == "FechaVersion") result = result.OrderBy(p => p.FechaVersion).Cast <PlantasBodegasDocumentosPA>().ToList(); 
                 if (orderCriteria == "NombreArchivo") result = result.OrderBy(p => p.NombreArchivo).Cast <PlantasBodegasDocumentosPA>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <PlantasBodegasDocumentosPA>().ToList();  
                if (orderCriteria == "ID_PlantaBodegas") result = result.OrderByDescending(p => p.ID_PlantaBodegas).Cast <PlantasBodegasDocumentosPA>().ToList(); 
                 if (orderCriteria == "sID_PlantaBodegas") result = result.OrderByDescending(p => p.sID_PlantaBodegas).Cast<PlantasBodegasDocumentosPA>().ToList(); 
                 if (orderCriteria == "ID_DocumentoPA") result = result.OrderByDescending(p => p.ID_DocumentoPA).Cast <PlantasBodegasDocumentosPA>().ToList(); 
                 if (orderCriteria == "sID_DocumentosPA") result = result.OrderByDescending(p => p.sID_DocumentoPA).Cast<PlantasBodegasDocumentosPA>().ToList(); 
                 if (orderCriteria == "ID_Estado") result = result.OrderByDescending(p => p.ID_Estado).Cast <PlantasBodegasDocumentosPA>().ToList(); 
                 if (orderCriteria == "sID_EstadoDocumento") result = result.OrderByDescending(p => p.sID_Estado).Cast<PlantasBodegasDocumentosPA>().ToList(); 
                 if (orderCriteria == "idVigencia") result = result.OrderByDescending(p => p.idVigencia).Cast <PlantasBodegasDocumentosPA>().ToList(); 
                     if (orderCriteria == "FechaVersion") result = result.OrderByDescending(p => p.FechaVersion).Cast <PlantasBodegasDocumentosPA>().ToList(); 
                 if (orderCriteria == "NombreArchivo") result = result.OrderByDescending(p => p.NombreArchivo).Cast <PlantasBodegasDocumentosPA>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_PlantaBodegas != null && r.ID_PlantaBodegas.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_PlantaBodegas != null && r.sID_PlantaBodegas.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_DocumentoPA != null && r.ID_DocumentoPA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_DocumentoPA != null && r.sID_DocumentoPA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Estado != null && r.ID_Estado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Estado != null && r.sID_Estado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.idVigencia != null && r.idVigencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                     || r.FechaVersion != null && r.FechaVersion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NombreArchivo != null && r.NombreArchivo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
        /// CRUD de la entidad PlantasBodegasDocumentosPA --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlantasBodegasDocumentosPA!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlantasBodegasDocumentosPA</param>
        /// <response code="200">PlantasBodegasDocumentosPA Consulto los registros exitosamente</response>
        /// <response code="400">PlantasBodegasDocumentosPA tiene valores invalidos </response>
        /// <response code="401">PlantasBodegasDocumentosPA No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlantasBodegasDocumentosPA en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new PlantasBodegasDocumentosPAMs().GetAllByWithRelation().Cast<PlantasBodegasDocumentosPA>().AsQueryable();
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
