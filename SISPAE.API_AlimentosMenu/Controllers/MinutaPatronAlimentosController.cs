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

namespace SISPAE_API_AlimentosMenu.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de MinutaPatronAlimentos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class MinutaPatronAlimentosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad MinutaPatronAlimentos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaPatronAlimentos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaPatronAlimentos</param>
        /// <response code="200">MinutaPatronAlimentos Consulto los registros exitosamente</response>
        /// <response code="400">MinutaPatronAlimentos tiene valores invalidos </response>
        /// <response code="401">MinutaPatronAlimentos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaPatronAlimentos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new MinutaPatronAlimentosMs().GetAll().Cast<MinutaPatronAlimentos>().AsQueryable();
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
        /// CRUD de la entidad MinutaPatronAlimentos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaPatronAlimentos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaPatronAlimentos</param>
        /// <response code="200">MinutaPatronAlimentos Consulto los registros exitosamente</response>
        /// <response code="400">MinutaPatronAlimentos tiene valores invalidos </response>
        /// <response code="401">MinutaPatronAlimentos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaPatronAlimentos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new MinutaPatronAlimentosMs().GetAllFull().Cast<MinutaPatronAlimentos>().AsQueryable();
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
        /// CRUD de la entidad MinutaPatronAlimentos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaPatronAlimentos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaPatronAlimentos</param>
        /// <response code="200">MinutaPatronAlimentos Consulto los registros exitosamente</response>
        /// <response code="400">MinutaPatronAlimentos tiene valores invalidos </response>
        /// <response code="401">MinutaPatronAlimentos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar MinutaPatronAlimentos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new MinutaPatronAlimentosMs().GetById(new MinutaPatronAlimentos() { id = id });
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
        /// CRUD de la entidad MinutaPatronAlimentos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaPatronAlimentos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de MinutaPatronAlimentos</param>
        /// <response code="200">MinutaPatronAlimentos Creado</response>
        /// <response code="400">MinutaPatronAlimentos tiene valores invalidos </response>
        /// <response code="401">MinutaPatronAlimentos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear MinutaPatronAlimentos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] MinutaPatronAlimentos obj)
        {
            try
            {
                var result = new MinutaPatronAlimentosMs().Add(obj);
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
        /// CRUD de la entidad MinutaPatronAlimentos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaPatronAlimentos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de MinutaPatronAlimentos</param>
        /// <response code="200">MinutaPatronAlimentos Actualizado</response>
        /// <response code="400">MinutaPatronAlimentos tiene valores invalidos </response>
        /// <response code="401">MinutaPatronAlimentos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar MinutaPatronAlimentos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] MinutaPatronAlimentos obj)
        {
            try
            {
                var result = new MinutaPatronAlimentosMs().Update(obj);
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
        /// CRUD de la entidad MinutaPatronAlimentos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaPatronAlimentos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de MinutaPatronAlimentos</param>
        /// <response code="200">MinutaPatronAlimentos Eliminado</response>
        /// <response code="400">MinutaPatronAlimentos tiene valores invalidos </response>
        /// <response code="401">MinutaPatronAlimentos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar MinutaPatronAlimentos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] MinutaPatronAlimentos obj)
        {
           try
            {
                new MinutaPatronAlimentosMs().Delete(obj);
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
        /// DataTable de la entidad MinutaPatronAlimentos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  MinutaPatronAlimentos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de MinutaPatronAlimentos</param>
        /// <response code="200">MinutaPatronAlimentos Resultado</response>
        /// <response code="400">MinutaPatronAlimentos tiene valores invalidos </response>
        /// <response code="401">MinutaPatronAlimentos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  MinutaPatronAlimentos en este momento</response>
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

                var result = new MinutaPatronAlimentosMs().GetAllByWithRelation().Cast<MinutaPatronAlimentos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <MinutaPatronAlimentos>().ToList();  
                if (orderCriteria == "ID_ETC") result = result.OrderBy(p => p.ID_ETC).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "ID_TipoMinutaPatron") result = result.OrderBy(p => p.ID_TipoMinutaPatron).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "sID_TiposMinutaPatron") result = result.OrderBy(p => p.sID_TipoMinutaPatron).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "ID_TipoEstadoMinuta") result = result.OrderBy(p => p.ID_TipoEstadoMinuta).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "sID_TiposEstadoMinuta") result = result.OrderBy(p => p.sID_TipoEstadoMinuta).Cast <MinutaPatronAlimentos>().ToList(); 
                   if (orderCriteria == "ModalidadComplementoId") result = result.OrderBy(p => p.ModalidadComplementoId).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "sID_TiposModalidadComplemento") result = result.OrderBy(p => p.sModalidadComplementoId).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "TipoComplementoId") result = result.OrderBy(p => p.TipoComplementoId).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderBy(p => p.sTipoComplementoId).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "TipoNivelEducativoId") result = result.OrderBy(p => p.TipoNivelEducativoId).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "sID_NivelEducativo") result = result.OrderBy(p => p.sTipoNivelEducativoId).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "TipoActividadFisicaId") result = result.OrderBy(p => p.TipoActividadFisicaId).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "sID_TiposActividadFisica") result = result.OrderBy(p => p.sTipoActividadFisicaId).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "Recomendaciones") result = result.OrderBy(p => p.Recomendaciones).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "Justificacion") result = result.OrderBy(p => p.Justificacion).Cast <MinutaPatronAlimentos>().ToList(); 
                   if (orderCriteria == "Rechazado") result = result.OrderBy(p => p.Rechazado).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "Id_Vigencia") result = result.OrderBy(p => p.Id_Vigencia).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "ID_MinutaAprobacion") result = result.OrderBy(p => p.ID_MinutaAprobacion).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderBy(p => p.ID_TipoModeloOperacion).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "ID_TipoModeloOperacionBase") result = result.OrderBy(p => p.ID_TipoModeloOperacionBase).Cast <MinutaPatronAlimentos>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <MinutaPatronAlimentos>().ToList();  
                if (orderCriteria == "ID_ETC") result = result.OrderByDescending(p => p.ID_ETC).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "ID_TipoMinutaPatron") result = result.OrderByDescending(p => p.ID_TipoMinutaPatron).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "sID_TiposMinutaPatron") result = result.OrderByDescending(p => p.sID_TipoMinutaPatron).Cast<MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "ID_TipoEstadoMinuta") result = result.OrderByDescending(p => p.ID_TipoEstadoMinuta).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "sID_TiposEstadoMinuta") result = result.OrderByDescending(p => p.sID_TipoEstadoMinuta).Cast<MinutaPatronAlimentos>().ToList(); 
                   if (orderCriteria == "ModalidadComplementoId") result = result.OrderByDescending(p => p.ModalidadComplementoId).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "sID_TiposModalidadComplemento") result = result.OrderByDescending(p => p.sModalidadComplementoId).Cast<MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "TipoComplementoId") result = result.OrderByDescending(p => p.TipoComplementoId).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderByDescending(p => p.sTipoComplementoId).Cast<MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "TipoNivelEducativoId") result = result.OrderByDescending(p => p.TipoNivelEducativoId).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "sID_NivelEducativo") result = result.OrderByDescending(p => p.sTipoNivelEducativoId).Cast<MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "TipoActividadFisicaId") result = result.OrderByDescending(p => p.TipoActividadFisicaId).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "sID_TiposActividadFisica") result = result.OrderByDescending(p => p.sTipoActividadFisicaId).Cast<MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "Recomendaciones") result = result.OrderByDescending(p => p.Recomendaciones).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "Justificacion") result = result.OrderByDescending(p => p.Justificacion).Cast <MinutaPatronAlimentos>().ToList(); 
                   if (orderCriteria == "Rechazado") result = result.OrderByDescending(p => p.Rechazado).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "Id_Vigencia") result = result.OrderByDescending(p => p.Id_Vigencia).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "ID_MinutaAprobacion") result = result.OrderByDescending(p => p.ID_MinutaAprobacion).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderByDescending(p => p.ID_TipoModeloOperacion).Cast <MinutaPatronAlimentos>().ToList(); 
                 if (orderCriteria == "ID_TipoModeloOperacionBase") result = result.OrderByDescending(p => p.ID_TipoModeloOperacionBase).Cast <MinutaPatronAlimentos>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_ETC != null && r.ID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoMinutaPatron != null && r.ID_TipoMinutaPatron.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoMinutaPatron != null && r.sID_TipoMinutaPatron.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoEstadoMinuta != null && r.ID_TipoEstadoMinuta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoEstadoMinuta != null && r.sID_TipoEstadoMinuta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ModalidadComplementoId != null && r.ModalidadComplementoId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sModalidadComplementoId != null && r.sModalidadComplementoId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TipoComplementoId != null && r.TipoComplementoId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sTipoComplementoId != null && r.sTipoComplementoId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TipoNivelEducativoId != null && r.TipoNivelEducativoId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sTipoNivelEducativoId != null && r.sTipoNivelEducativoId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TipoActividadFisicaId != null && r.TipoActividadFisicaId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sTipoActividadFisicaId != null && r.sTipoActividadFisicaId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Recomendaciones != null && r.Recomendaciones.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Justificacion != null && r.Justificacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Rechazado != null && r.Rechazado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Id_Vigencia != null && r.Id_Vigencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_MinutaAprobacion != null && r.ID_MinutaAprobacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoModeloOperacion != null && r.ID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoModeloOperacionBase != null && r.ID_TipoModeloOperacionBase.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
        /// CRUD de la entidad MinutaPatronAlimentos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaPatronAlimentos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaPatronAlimentos</param>
        /// <response code="200">MinutaPatronAlimentos Consulto los registros exitosamente</response>
        /// <response code="400">MinutaPatronAlimentos tiene valores invalidos </response>
        /// <response code="401">MinutaPatronAlimentos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaPatronAlimentos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new MinutaPatronAlimentosMs().GetAllByWithRelation().Cast<MinutaPatronAlimentos>().AsQueryable();
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
