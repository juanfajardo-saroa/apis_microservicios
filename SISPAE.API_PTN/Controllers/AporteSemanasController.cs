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

namespace SISPAE_API_PTN.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de AporteSemanas .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class AporteSemanasController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad AporteSemanas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  AporteSemanas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AporteSemanas</param>
        /// <response code="200">AporteSemanas Consulto los registros exitosamente</response>
        /// <response code="400">AporteSemanas tiene valores invalidos </response>
        /// <response code="401">AporteSemanas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AporteSemanas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new AporteSemanasMs().GetAll().Cast<AporteSemanas>().AsQueryable();
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
        /// CRUD de la entidad AporteSemanas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  AporteSemanas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AporteSemanas</param>
        /// <response code="200">AporteSemanas Consulto los registros exitosamente</response>
        /// <response code="400">AporteSemanas tiene valores invalidos </response>
        /// <response code="401">AporteSemanas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AporteSemanas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new AporteSemanasMs().GetAllFull().Cast<AporteSemanas>().AsQueryable();
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
        /// CRUD de la entidad AporteSemanas --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  AporteSemanas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AporteSemanas</param>
        /// <response code="200">AporteSemanas Consulto los registros exitosamente</response>
        /// <response code="400">AporteSemanas tiene valores invalidos </response>
        /// <response code="401">AporteSemanas No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar AporteSemanas en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new AporteSemanasMs().GetById(new AporteSemanas() { id = id });
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
        /// CRUD de la entidad AporteSemanas --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PTN de la entidad  AporteSemanas!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de AporteSemanas</param>
        /// <response code="200">AporteSemanas Creado</response>
        /// <response code="400">AporteSemanas tiene valores invalidos </response>
        /// <response code="401">AporteSemanas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear AporteSemanas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] AporteSemanas obj)
        {
            try
            {
                var result = new AporteSemanasMs().Add(obj);
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
        /// CRUD de la entidad AporteSemanas --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PTN de la entidad  AporteSemanas!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de AporteSemanas</param>
        /// <response code="200">AporteSemanas Actualizado</response>
        /// <response code="400">AporteSemanas tiene valores invalidos </response>
        /// <response code="401">AporteSemanas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar AporteSemanas en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] AporteSemanas obj)
        {
            try
            {
                var result = new AporteSemanasMs().Update(obj);
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
        /// CRUD de la entidad AporteSemanas --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PTN de la entidad  AporteSemanas!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de AporteSemanas</param>
        /// <response code="200">AporteSemanas Eliminado</response>
        /// <response code="400">AporteSemanas tiene valores invalidos </response>
        /// <response code="401">AporteSemanas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar AporteSemanas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] AporteSemanas obj)
        {
           try
            {
                new AporteSemanasMs().Delete(obj);
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
        /// DataTable de la entidad AporteSemanas --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  AporteSemanas!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de AporteSemanas</param>
        /// <response code="200">AporteSemanas Resultado</response>
        /// <response code="400">AporteSemanas tiene valores invalidos </response>
        /// <response code="401">AporteSemanas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  AporteSemanas en este momento</response>
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

                var result = new AporteSemanasMs().GetAllByWithRelation().Cast<AporteSemanas>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <AporteSemanas>().ToList();  
                if (orderCriteria == "ID_Semana") result = result.OrderBy(p => p.ID_Semana).Cast <AporteSemanas>().ToList(); 
                 if (orderCriteria == "sID_SemanasPTN") result = result.OrderBy(p => p.sID_Semana).Cast <AporteSemanas>().ToList(); 
                 if (orderCriteria == "ID_Nutriente") result = result.OrderBy(p => p.ID_Nutriente).Cast <AporteSemanas>().ToList(); 
                 if (orderCriteria == "ID_TipoNivelEducativo") result = result.OrderBy(p => p.ID_TipoNivelEducativo).Cast <AporteSemanas>().ToList(); 
                 if (orderCriteria == "PorcentajeAdecuacion") result = result.OrderBy(p => p.PorcentajeAdecuacion).Cast <AporteSemanas>().ToList(); 
                 if (orderCriteria == "AporteEstimado") result = result.OrderBy(p => p.AporteEstimado).Cast <AporteSemanas>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <AporteSemanas>().ToList();  
                if (orderCriteria == "ID_Semana") result = result.OrderByDescending(p => p.ID_Semana).Cast <AporteSemanas>().ToList(); 
                 if (orderCriteria == "sID_SemanasPTN") result = result.OrderByDescending(p => p.sID_Semana).Cast<AporteSemanas>().ToList(); 
                 if (orderCriteria == "ID_Nutriente") result = result.OrderByDescending(p => p.ID_Nutriente).Cast <AporteSemanas>().ToList(); 
                 if (orderCriteria == "ID_TipoNivelEducativo") result = result.OrderByDescending(p => p.ID_TipoNivelEducativo).Cast <AporteSemanas>().ToList(); 
                 if (orderCriteria == "PorcentajeAdecuacion") result = result.OrderByDescending(p => p.PorcentajeAdecuacion).Cast <AporteSemanas>().ToList(); 
                 if (orderCriteria == "AporteEstimado") result = result.OrderByDescending(p => p.AporteEstimado).Cast <AporteSemanas>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Semana != null && r.ID_Semana.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Semana != null && r.sID_Semana.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Nutriente != null && r.ID_Nutriente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoNivelEducativo != null && r.ID_TipoNivelEducativo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PorcentajeAdecuacion != null && r.PorcentajeAdecuacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.AporteEstimado != null && r.AporteEstimado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad AporteSemanas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  AporteSemanas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AporteSemanas</param>
        /// <response code="200">AporteSemanas Consulto los registros exitosamente</response>
        /// <response code="400">AporteSemanas tiene valores invalidos </response>
        /// <response code="401">AporteSemanas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AporteSemanas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new AporteSemanasMs().GetAllByWithRelation().Cast<AporteSemanas>().AsQueryable();
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
