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
    [SwaggerTag("Web API para CRUD de Contratos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class ContratosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Contratos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  Contratos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Contratos</param>
        /// <response code="200">Contratos Consulto los registros exitosamente</response>
        /// <response code="400">Contratos tiene valores invalidos </response>
        /// <response code="401">Contratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Contratos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new ContratosMs().GetAll().Cast<Contratos>().AsQueryable();
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
        /// CRUD de la entidad Contratos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  Contratos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Contratos</param>
        /// <response code="200">Contratos Consulto los registros exitosamente</response>
        /// <response code="400">Contratos tiene valores invalidos </response>
        /// <response code="401">Contratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Contratos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new ContratosMs().GetAllFull().Cast<Contratos>().AsQueryable();
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
        /// CRUD de la entidad Contratos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  Contratos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Contratos</param>
        /// <response code="200">Contratos Consulto los registros exitosamente</response>
        /// <response code="400">Contratos tiene valores invalidos </response>
        /// <response code="401">Contratos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Contratos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new ContratosMs().GetById(new Contratos() { id = id });
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
        /// CRUD de la entidad Contratos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  Contratos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Contratos</param>
        /// <response code="200">Contratos Creado</response>
        /// <response code="400">Contratos tiene valores invalidos </response>
        /// <response code="401">Contratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Contratos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Contratos obj)
        {
            try
            {
                var result = new ContratosMs().Add(obj);
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
        /// CRUD de la entidad Contratos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  Contratos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Contratos</param>
        /// <response code="200">Contratos Actualizado</response>
        /// <response code="400">Contratos tiene valores invalidos </response>
        /// <response code="401">Contratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Contratos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Contratos obj)
        {
            try
            {
                var result = new ContratosMs().Update(obj);
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
        /// CRUD de la entidad Contratos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  Contratos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Contratos</param>
        /// <response code="200">Contratos Eliminado</response>
        /// <response code="400">Contratos tiene valores invalidos </response>
        /// <response code="401">Contratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Contratos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Contratos obj)
        {
           try
            {
                new ContratosMs().Delete(obj);
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
        /// DataTable de la entidad Contratos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Contratos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Contratos</param>
        /// <response code="200">Contratos Resultado</response>
        /// <response code="400">Contratos tiene valores invalidos </response>
        /// <response code="401">Contratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Contratos en este momento</response>
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

                var result = new ContratosMs().GetAllByWithRelation().Cast<Contratos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Contratos>().ToList();  
                if (orderCriteria == "ID_TipoContratoCHIP") result = result.OrderBy(p => p.ID_TipoContratoCHIP).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_TipoConceptoGasto") result = result.OrderBy(p => p.ID_TipoConceptoGasto).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderBy(p => p.ID_ETC).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_ET") result = result.OrderBy(p => p.ID_ET).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_MinutaPatronAlimento") result = result.OrderBy(p => p.ID_MinutaPatronAlimento).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_Operador") result = result.OrderBy(p => p.ID_Operador).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_TipoCategoriaContrato") result = result.OrderBy(p => p.ID_TipoCategoriaContrato).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_EstadoContrato") result = result.OrderBy(p => p.ID_EstadoContrato).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "sID_TiposEstadosContrato") result = result.OrderBy(p => p.sID_EstadoContrato).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_UTConsorcio") result = result.OrderBy(p => p.ID_UTConsorcio).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_PlanAlistamiento") result = result.OrderBy(p => p.ID_PlanAlistamiento).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_Vigencia") result = result.OrderBy(p => p.ID_Vigencia).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "NumeroContrato") result = result.OrderBy(p => p.NumeroContrato).Cast <Contratos>().ToList(); 
                   if (orderCriteria == "ConAnticipo") result = result.OrderBy(p => p.ConAnticipo).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "FechalnicioContrato") result = result.OrderBy(p => p.FechalnicioContrato).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "FechaFinalContrato") result = result.OrderBy(p => p.FechaFinalContrato).Cast <Contratos>().ToList(); 
                   if (orderCriteria == "ValorTotalContrato") result = result.OrderBy(p => p.ValorTotalContrato).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "TipoContratoId") result = result.OrderBy(p => p.TipoContratoId).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "SubTipoContratoId") result = result.OrderBy(p => p.SubTipoContratoId).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "SuministroDesentralizadoId") result = result.OrderBy(p => p.SuministroDesentralizadoId).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderBy(p => p.ID_TipoModeloOperacion).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ManejaPAEC") result = result.OrderBy(p => p.ManejaPAEC).Cast <Contratos>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Contratos>().ToList();  
                if (orderCriteria == "ID_TipoContratoCHIP") result = result.OrderByDescending(p => p.ID_TipoContratoCHIP).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_TipoConceptoGasto") result = result.OrderByDescending(p => p.ID_TipoConceptoGasto).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderByDescending(p => p.ID_ETC).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_ET") result = result.OrderByDescending(p => p.ID_ET).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_MinutaPatronAlimento") result = result.OrderByDescending(p => p.ID_MinutaPatronAlimento).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_Operador") result = result.OrderByDescending(p => p.ID_Operador).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_TipoCategoriaContrato") result = result.OrderByDescending(p => p.ID_TipoCategoriaContrato).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_EstadoContrato") result = result.OrderByDescending(p => p.ID_EstadoContrato).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "sID_TiposEstadosContrato") result = result.OrderByDescending(p => p.sID_EstadoContrato).Cast<Contratos>().ToList(); 
                 if (orderCriteria == "ID_UTConsorcio") result = result.OrderByDescending(p => p.ID_UTConsorcio).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_PlanAlistamiento") result = result.OrderByDescending(p => p.ID_PlanAlistamiento).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_Vigencia") result = result.OrderByDescending(p => p.ID_Vigencia).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "NumeroContrato") result = result.OrderByDescending(p => p.NumeroContrato).Cast <Contratos>().ToList(); 
                   if (orderCriteria == "ConAnticipo") result = result.OrderByDescending(p => p.ConAnticipo).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "FechalnicioContrato") result = result.OrderByDescending(p => p.FechalnicioContrato).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "FechaFinalContrato") result = result.OrderByDescending(p => p.FechaFinalContrato).Cast <Contratos>().ToList(); 
                   if (orderCriteria == "ValorTotalContrato") result = result.OrderByDescending(p => p.ValorTotalContrato).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "TipoContratoId") result = result.OrderByDescending(p => p.TipoContratoId).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "SubTipoContratoId") result = result.OrderByDescending(p => p.SubTipoContratoId).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "SuministroDesentralizadoId") result = result.OrderByDescending(p => p.SuministroDesentralizadoId).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderByDescending(p => p.ID_TipoModeloOperacion).Cast <Contratos>().ToList(); 
                 if (orderCriteria == "ManejaPAEC") result = result.OrderByDescending(p => p.ManejaPAEC).Cast <Contratos>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoContratoCHIP != null && r.ID_TipoContratoCHIP.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoConceptoGasto != null && r.ID_TipoConceptoGasto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_ETC != null && r.ID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_ET != null && r.ID_ET.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_MinutaPatronAlimento != null && r.ID_MinutaPatronAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Operador != null && r.ID_Operador.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoCategoriaContrato != null && r.ID_TipoCategoriaContrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_EstadoContrato != null && r.ID_EstadoContrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_EstadoContrato != null && r.sID_EstadoContrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_UTConsorcio != null && r.ID_UTConsorcio.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_PlanAlistamiento != null && r.ID_PlanAlistamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Vigencia != null && r.ID_Vigencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumeroContrato != null && r.NumeroContrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ConAnticipo != null && r.ConAnticipo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechalnicioContrato != null && r.FechalnicioContrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaFinalContrato != null && r.FechaFinalContrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ValorTotalContrato != null && r.ValorTotalContrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TipoContratoId != null && r.TipoContratoId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.SubTipoContratoId != null && r.SubTipoContratoId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.SuministroDesentralizadoId != null && r.SuministroDesentralizadoId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoModeloOperacion != null && r.ID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ManejaPAEC != null && r.ManejaPAEC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
        /// CRUD de la entidad Contratos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  Contratos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Contratos</param>
        /// <response code="200">Contratos Consulto los registros exitosamente</response>
        /// <response code="400">Contratos tiene valores invalidos </response>
        /// <response code="401">Contratos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Contratos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new ContratosMs().GetAllByWithRelation().Cast<Contratos>().AsQueryable();
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
