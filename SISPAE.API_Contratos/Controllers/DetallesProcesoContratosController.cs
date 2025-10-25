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
    [SwaggerTag("Web API para CRUD de DetallesProcesoContratos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class DetallesProcesoContratosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad DetallesProcesoContratos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesProcesoContratos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DetallesProcesoContratos</param>
        /// <response code="200">DetallesProcesoContratos Consulto los registros exitosamente</response>
        /// <response code="400">DetallesProcesoContratos tiene valores invalidos </response>
        /// <response code="401">DetallesProcesoContratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DetallesProcesoContratos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new DetallesProcesoContratosMs().GetAll().Cast<DetallesProcesoContratos>().AsQueryable();
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
        /// CRUD de la entidad DetallesProcesoContratos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesProcesoContratos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DetallesProcesoContratos</param>
        /// <response code="200">DetallesProcesoContratos Consulto los registros exitosamente</response>
        /// <response code="400">DetallesProcesoContratos tiene valores invalidos </response>
        /// <response code="401">DetallesProcesoContratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DetallesProcesoContratos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new DetallesProcesoContratosMs().GetAllFull().Cast<DetallesProcesoContratos>().AsQueryable();
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
        /// CRUD de la entidad DetallesProcesoContratos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesProcesoContratos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DetallesProcesoContratos</param>
        /// <response code="200">DetallesProcesoContratos Consulto los registros exitosamente</response>
        /// <response code="400">DetallesProcesoContratos tiene valores invalidos </response>
        /// <response code="401">DetallesProcesoContratos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar DetallesProcesoContratos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new DetallesProcesoContratosMs().GetById(new DetallesProcesoContratos() { id = id });
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
        /// CRUD de la entidad DetallesProcesoContratos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  DetallesProcesoContratos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de DetallesProcesoContratos</param>
        /// <response code="200">DetallesProcesoContratos Creado</response>
        /// <response code="400">DetallesProcesoContratos tiene valores invalidos </response>
        /// <response code="401">DetallesProcesoContratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear DetallesProcesoContratos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] DetallesProcesoContratos obj)
        {
            try
            {
                var result = new DetallesProcesoContratosMs().Add(obj);
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
        /// CRUD de la entidad DetallesProcesoContratos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesProcesoContratos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de DetallesProcesoContratos</param>
        /// <response code="200">DetallesProcesoContratos Actualizado</response>
        /// <response code="400">DetallesProcesoContratos tiene valores invalidos </response>
        /// <response code="401">DetallesProcesoContratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar DetallesProcesoContratos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] DetallesProcesoContratos obj)
        {
            try
            {
                var result = new DetallesProcesoContratosMs().Update(obj);
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
        /// CRUD de la entidad DetallesProcesoContratos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesProcesoContratos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de DetallesProcesoContratos</param>
        /// <response code="200">DetallesProcesoContratos Eliminado</response>
        /// <response code="400">DetallesProcesoContratos tiene valores invalidos </response>
        /// <response code="401">DetallesProcesoContratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar DetallesProcesoContratos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] DetallesProcesoContratos obj)
        {
           try
            {
                new DetallesProcesoContratosMs().Delete(obj);
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
        /// DataTable de la entidad DetallesProcesoContratos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  DetallesProcesoContratos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de DetallesProcesoContratos</param>
        /// <response code="200">DetallesProcesoContratos Resultado</response>
        /// <response code="400">DetallesProcesoContratos tiene valores invalidos </response>
        /// <response code="401">DetallesProcesoContratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  DetallesProcesoContratos en este momento</response>
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

                var result = new DetallesProcesoContratosMs().GetAllByWithRelation().Cast<DetallesProcesoContratos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <DetallesProcesoContratos>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderBy(p => p.ID_Contrato).Cast <DetallesProcesoContratos>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderBy(p => p.sID_Contrato).Cast <DetallesProcesoContratos>().ToList(); 
                 if (orderCriteria == "ID_TipoContratacion") result = result.OrderBy(p => p.ID_TipoContratacion).Cast <DetallesProcesoContratos>().ToList(); 
                 if (orderCriteria == "sID_TiposContratacion") result = result.OrderBy(p => p.sID_TipoContratacion).Cast <DetallesProcesoContratos>().ToList(); 
                 if (orderCriteria == "ID_PlataformaContrato") result = result.OrderBy(p => p.ID_PlataformaContrato).Cast <DetallesProcesoContratos>().ToList(); 
                 if (orderCriteria == "PublicadorSECOP") result = result.OrderBy(p => p.PublicadorSECOP).Cast <DetallesProcesoContratos>().ToList(); 
                 if (orderCriteria == "NumeroProcesoRegistradoSECOP") result = result.OrderBy(p => p.NumeroProcesoRegistradoSECOP).Cast <DetallesProcesoContratos>().ToList(); 
                   if (orderCriteria == "FechaAdjudicacion") result = result.OrderBy(p => p.FechaAdjudicacion).Cast <DetallesProcesoContratos>().ToList(); 
                   if (orderCriteria == "FechaSuscripcion") result = result.OrderBy(p => p.FechaSuscripcion).Cast <DetallesProcesoContratos>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <DetallesProcesoContratos>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderByDescending(p => p.ID_Contrato).Cast <DetallesProcesoContratos>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderByDescending(p => p.sID_Contrato).Cast<DetallesProcesoContratos>().ToList(); 
                 if (orderCriteria == "ID_TipoContratacion") result = result.OrderByDescending(p => p.ID_TipoContratacion).Cast <DetallesProcesoContratos>().ToList(); 
                 if (orderCriteria == "sID_TiposContratacion") result = result.OrderByDescending(p => p.sID_TipoContratacion).Cast<DetallesProcesoContratos>().ToList(); 
                 if (orderCriteria == "ID_PlataformaContrato") result = result.OrderByDescending(p => p.ID_PlataformaContrato).Cast <DetallesProcesoContratos>().ToList(); 
                 if (orderCriteria == "PublicadorSECOP") result = result.OrderByDescending(p => p.PublicadorSECOP).Cast <DetallesProcesoContratos>().ToList(); 
                 if (orderCriteria == "NumeroProcesoRegistradoSECOP") result = result.OrderByDescending(p => p.NumeroProcesoRegistradoSECOP).Cast <DetallesProcesoContratos>().ToList(); 
                   if (orderCriteria == "FechaAdjudicacion") result = result.OrderByDescending(p => p.FechaAdjudicacion).Cast <DetallesProcesoContratos>().ToList(); 
                   if (orderCriteria == "FechaSuscripcion") result = result.OrderByDescending(p => p.FechaSuscripcion).Cast <DetallesProcesoContratos>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Contrato != null && r.ID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Contrato != null && r.sID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoContratacion != null && r.ID_TipoContratacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoContratacion != null && r.sID_TipoContratacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_PlataformaContrato != null && r.ID_PlataformaContrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PublicadorSECOP != null && r.PublicadorSECOP.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumeroProcesoRegistradoSECOP != null && r.NumeroProcesoRegistradoSECOP.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.FechaAdjudicacion != null && r.FechaAdjudicacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.FechaSuscripcion != null && r.FechaSuscripcion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
        /// CRUD de la entidad DetallesProcesoContratos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesProcesoContratos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DetallesProcesoContratos</param>
        /// <response code="200">DetallesProcesoContratos Consulto los registros exitosamente</response>
        /// <response code="400">DetallesProcesoContratos tiene valores invalidos </response>
        /// <response code="401">DetallesProcesoContratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DetallesProcesoContratos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new DetallesProcesoContratosMs().GetAllByWithRelation().Cast<DetallesProcesoContratos>().AsQueryable();
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
