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

namespace SISPAE_API_Contratos.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de FuentesFinanciacionContratos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class FuentesFinanciacionContratosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad FuentesFinanciacionContratos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  FuentesFinanciacionContratos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de FuentesFinanciacionContratos</param>
        /// <response code="200">FuentesFinanciacionContratos Consulto los registros exitosamente</response>
        /// <response code="400">FuentesFinanciacionContratos tiene valores invalidos </response>
        /// <response code="401">FuentesFinanciacionContratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar FuentesFinanciacionContratos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new FuentesFinanciacionContratosMs().GetAll().Cast<FuentesFinanciacionContratos>().AsQueryable();
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
        /// CRUD de la entidad FuentesFinanciacionContratos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  FuentesFinanciacionContratos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de FuentesFinanciacionContratos</param>
        /// <response code="200">FuentesFinanciacionContratos Consulto los registros exitosamente</response>
        /// <response code="400">FuentesFinanciacionContratos tiene valores invalidos </response>
        /// <response code="401">FuentesFinanciacionContratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar FuentesFinanciacionContratos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new FuentesFinanciacionContratosMs().GetAllFull().Cast<FuentesFinanciacionContratos>().AsQueryable();
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
        /// CRUD de la entidad FuentesFinanciacionContratos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  FuentesFinanciacionContratos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de FuentesFinanciacionContratos</param>
        /// <response code="200">FuentesFinanciacionContratos Consulto los registros exitosamente</response>
        /// <response code="400">FuentesFinanciacionContratos tiene valores invalidos </response>
        /// <response code="401">FuentesFinanciacionContratos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar FuentesFinanciacionContratos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new FuentesFinanciacionContratosMs().GetById(new FuentesFinanciacionContratos() { id = id });
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
        /// CRUD de la entidad FuentesFinanciacionContratos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  FuentesFinanciacionContratos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de FuentesFinanciacionContratos</param>
        /// <response code="200">FuentesFinanciacionContratos Creado</response>
        /// <response code="400">FuentesFinanciacionContratos tiene valores invalidos </response>
        /// <response code="401">FuentesFinanciacionContratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear FuentesFinanciacionContratos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] FuentesFinanciacionContratos obj)
        {
            try
            {
                var result = new FuentesFinanciacionContratosMs().Add(obj);
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
        /// CRUD de la entidad FuentesFinanciacionContratos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  FuentesFinanciacionContratos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de FuentesFinanciacionContratos</param>
        /// <response code="200">FuentesFinanciacionContratos Actualizado</response>
        /// <response code="400">FuentesFinanciacionContratos tiene valores invalidos </response>
        /// <response code="401">FuentesFinanciacionContratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar FuentesFinanciacionContratos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] FuentesFinanciacionContratos obj)
        {
            try
            {
                var result = new FuentesFinanciacionContratosMs().Update(obj);
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
        /// CRUD de la entidad FuentesFinanciacionContratos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  FuentesFinanciacionContratos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de FuentesFinanciacionContratos</param>
        /// <response code="200">FuentesFinanciacionContratos Eliminado</response>
        /// <response code="400">FuentesFinanciacionContratos tiene valores invalidos </response>
        /// <response code="401">FuentesFinanciacionContratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar FuentesFinanciacionContratos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] FuentesFinanciacionContratos obj)
        {
           try
            {
                new FuentesFinanciacionContratosMs().Delete(obj);
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
        /// DataTable de la entidad FuentesFinanciacionContratos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  FuentesFinanciacionContratos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de FuentesFinanciacionContratos</param>
        /// <response code="200">FuentesFinanciacionContratos Resultado</response>
        /// <response code="400">FuentesFinanciacionContratos tiene valores invalidos </response>
        /// <response code="401">FuentesFinanciacionContratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  FuentesFinanciacionContratos en este momento</response>
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

                var result = new FuentesFinanciacionContratosMs().GetAllByWithRelation().Cast<FuentesFinanciacionContratos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <FuentesFinanciacionContratos>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderBy(p => p.ID_Contrato).Cast <FuentesFinanciacionContratos>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderBy(p => p.sID_Contrato).Cast <FuentesFinanciacionContratos>().ToList(); 
                 if (orderCriteria == "ID_FuenteFinanciacion") result = result.OrderBy(p => p.ID_FuenteFinanciacion).Cast <FuentesFinanciacionContratos>().ToList(); 
                 if (orderCriteria == "sID_FuentesFinanciacion") result = result.OrderBy(p => p.sID_FuenteFinanciacion).Cast <FuentesFinanciacionContratos>().ToList(); 
                 if (orderCriteria == "ID_FuenteIngresos") result = result.OrderBy(p => p.ID_FuenteIngresos).Cast <FuentesFinanciacionContratos>().ToList(); 
                 if (orderCriteria == "sID_FuenteIngresos") result = result.OrderBy(p => p.sID_FuenteIngresos).Cast <FuentesFinanciacionContratos>().ToList(); 
                 if (orderCriteria == "Valor") result = result.OrderBy(p => p.Valor).Cast <FuentesFinanciacionContratos>().ToList(); 
                   if (orderCriteria == "Id_Modificacion") result = result.OrderBy(p => p.Id_Modificacion).Cast <FuentesFinanciacionContratos>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <FuentesFinanciacionContratos>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderByDescending(p => p.ID_Contrato).Cast <FuentesFinanciacionContratos>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderByDescending(p => p.sID_Contrato).Cast<FuentesFinanciacionContratos>().ToList(); 
                 if (orderCriteria == "ID_FuenteFinanciacion") result = result.OrderByDescending(p => p.ID_FuenteFinanciacion).Cast <FuentesFinanciacionContratos>().ToList(); 
                 if (orderCriteria == "sID_FuentesFinanciacion") result = result.OrderByDescending(p => p.sID_FuenteFinanciacion).Cast<FuentesFinanciacionContratos>().ToList(); 
                 if (orderCriteria == "ID_FuenteIngresos") result = result.OrderByDescending(p => p.ID_FuenteIngresos).Cast <FuentesFinanciacionContratos>().ToList(); 
                 if (orderCriteria == "sID_FuenteIngresos") result = result.OrderByDescending(p => p.sID_FuenteIngresos).Cast<FuentesFinanciacionContratos>().ToList(); 
                 if (orderCriteria == "Valor") result = result.OrderByDescending(p => p.Valor).Cast <FuentesFinanciacionContratos>().ToList(); 
                   if (orderCriteria == "Id_Modificacion") result = result.OrderByDescending(p => p.Id_Modificacion).Cast <FuentesFinanciacionContratos>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Contrato != null && r.ID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Contrato != null && r.sID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_FuenteFinanciacion != null && r.ID_FuenteFinanciacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_FuenteFinanciacion != null && r.sID_FuenteFinanciacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_FuenteIngresos != null && r.ID_FuenteIngresos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_FuenteIngresos != null && r.sID_FuenteIngresos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Valor != null && r.Valor.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Id_Modificacion != null && r.Id_Modificacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
        /// CRUD de la entidad FuentesFinanciacionContratos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  FuentesFinanciacionContratos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de FuentesFinanciacionContratos</param>
        /// <response code="200">FuentesFinanciacionContratos Consulto los registros exitosamente</response>
        /// <response code="400">FuentesFinanciacionContratos tiene valores invalidos </response>
        /// <response code="401">FuentesFinanciacionContratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar FuentesFinanciacionContratos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new FuentesFinanciacionContratosMs().GetAllByWithRelation().Cast<FuentesFinanciacionContratos>().AsQueryable();
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
