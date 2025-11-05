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
    [SwaggerTag("Web API para CRUD de TipoCompGrupoSubgrupoAli .")]
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public partial class TipoCompGrupoSubgrupoAliController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad TipoCompGrupoSubgrupoAli --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  TipoCompGrupoSubgrupoAli!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de TipoCompGrupoSubgrupoAli</param>
        /// <response code="200">TipoCompGrupoSubgrupoAli Consulto los registros exitosamente</response>
        /// <response code="400">TipoCompGrupoSubgrupoAli tiene valores invalidos </response>
        /// <response code="401">TipoCompGrupoSubgrupoAli No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar TipoCompGrupoSubgrupoAli en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new TipoCompGrupoSubgrupoAliMs().GetAll().Cast<TipoCompGrupoSubgrupoAli>().AsQueryable();
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
        /// CRUD de la entidad TipoCompGrupoSubgrupoAli --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  TipoCompGrupoSubgrupoAli!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de TipoCompGrupoSubgrupoAli</param>
        /// <response code="200">TipoCompGrupoSubgrupoAli Consulto los registros exitosamente</response>
        /// <response code="400">TipoCompGrupoSubgrupoAli tiene valores invalidos </response>
        /// <response code="401">TipoCompGrupoSubgrupoAli No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar TipoCompGrupoSubgrupoAli en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new TipoCompGrupoSubgrupoAliMs().GetAllFull().Cast<TipoCompGrupoSubgrupoAli>().AsQueryable();
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
        /// CRUD de la entidad TipoCompGrupoSubgrupoAli --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  TipoCompGrupoSubgrupoAli!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de TipoCompGrupoSubgrupoAli</param>
        /// <response code="200">TipoCompGrupoSubgrupoAli Consulto los registros exitosamente</response>
        /// <response code="400">TipoCompGrupoSubgrupoAli tiene valores invalidos </response>
        /// <response code="401">TipoCompGrupoSubgrupoAli No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar TipoCompGrupoSubgrupoAli en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new TipoCompGrupoSubgrupoAliMs().GetById(new TipoCompGrupoSubgrupoAli() { id = id });
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
        /// CRUD de la entidad TipoCompGrupoSubgrupoAli --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_AlimentosMenu de la entidad  TipoCompGrupoSubgrupoAli!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de TipoCompGrupoSubgrupoAli</param>
        /// <response code="200">TipoCompGrupoSubgrupoAli Creado</response>
        /// <response code="400">TipoCompGrupoSubgrupoAli tiene valores invalidos </response>
        /// <response code="401">TipoCompGrupoSubgrupoAli No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear TipoCompGrupoSubgrupoAli en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] TipoCompGrupoSubgrupoAli obj)
        {
            try
            {
                var result = new TipoCompGrupoSubgrupoAliMs().Add(obj);
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
        /// CRUD de la entidad TipoCompGrupoSubgrupoAli --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  TipoCompGrupoSubgrupoAli!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de TipoCompGrupoSubgrupoAli</param>
        /// <response code="200">TipoCompGrupoSubgrupoAli Actualizado</response>
        /// <response code="400">TipoCompGrupoSubgrupoAli tiene valores invalidos </response>
        /// <response code="401">TipoCompGrupoSubgrupoAli No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar TipoCompGrupoSubgrupoAli en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] TipoCompGrupoSubgrupoAli obj)
        {
            try
            {
                var result = new TipoCompGrupoSubgrupoAliMs().Update(obj);
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
        /// CRUD de la entidad TipoCompGrupoSubgrupoAli --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  TipoCompGrupoSubgrupoAli!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de TipoCompGrupoSubgrupoAli</param>
        /// <response code="200">TipoCompGrupoSubgrupoAli Eliminado</response>
        /// <response code="400">TipoCompGrupoSubgrupoAli tiene valores invalidos </response>
        /// <response code="401">TipoCompGrupoSubgrupoAli No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar TipoCompGrupoSubgrupoAli en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] TipoCompGrupoSubgrupoAli obj)
        {
           try
            {
                new TipoCompGrupoSubgrupoAliMs().Delete(obj);
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
        /// DataTable de la entidad TipoCompGrupoSubgrupoAli --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  TipoCompGrupoSubgrupoAli!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de TipoCompGrupoSubgrupoAli</param>
        /// <response code="200">TipoCompGrupoSubgrupoAli Resultado</response>
        /// <response code="400">TipoCompGrupoSubgrupoAli tiene valores invalidos </response>
        /// <response code="401">TipoCompGrupoSubgrupoAli No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  TipoCompGrupoSubgrupoAli en este momento</response>
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

                var result = new TipoCompGrupoSubgrupoAliMs().GetAllByWithRelation().Cast<TipoCompGrupoSubgrupoAli>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <TipoCompGrupoSubgrupoAli>().ToList();  
                if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderBy(p => p.ID_TipoModeloOperacion).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderBy(p => p.sID_TipoModeloOperacion).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "ID_TipoComponente") result = result.OrderBy(p => p.ID_TipoComponente).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "sID_TiposComponente") result = result.OrderBy(p => p.sID_TipoComponente).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "ID_GrupoAlimento") result = result.OrderBy(p => p.ID_GrupoAlimento).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "sID_GrupoAlimentos") result = result.OrderBy(p => p.sID_GrupoAlimento).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "ID_SubGrupoAlimento") result = result.OrderBy(p => p.ID_SubGrupoAlimento).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "sID_SubGrupoAlimentos") result = result.OrderBy(p => p.sID_SubGrupoAlimento).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                   if (orderCriteria == "MinVisible") result = result.OrderBy(p => p.MinVisible).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "MaxVisible") result = result.OrderBy(p => p.MaxVisible).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "SubgrupoManejaValor") result = result.OrderBy(p => p.SubgrupoManejaValor).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "SubgrupoFrecuencia") result = result.OrderBy(p => p.SubgrupoFrecuencia).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "UnidadMedida") result = result.OrderBy(p => p.UnidadMedida).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "ID_TipoComplemento") result = result.OrderBy(p => p.ID_TipoComplemento).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderBy(p => p.sID_TipoComplemento).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "ID_ModalidadComplemento") result = result.OrderBy(p => p.ID_ModalidadComplemento).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "sID_TiposModalidadComplemento") result = result.OrderBy(p => p.sID_ModalidadComplemento).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "TextoMsg") result = result.OrderBy(p => p.TextoMsg).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "ID_TipoSentidoValidacion") result = result.OrderBy(p => p.ID_TipoSentidoValidacion).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "sID_TiposSentidoValidacionMinutas") result = result.OrderBy(p => p.sID_TipoSentidoValidacion).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <TipoCompGrupoSubgrupoAli>().ToList();  
                if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderByDescending(p => p.ID_TipoModeloOperacion).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderByDescending(p => p.sID_TipoModeloOperacion).Cast<TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "ID_TipoComponente") result = result.OrderByDescending(p => p.ID_TipoComponente).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "sID_TiposComponente") result = result.OrderByDescending(p => p.sID_TipoComponente).Cast<TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "ID_GrupoAlimento") result = result.OrderByDescending(p => p.ID_GrupoAlimento).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "sID_GrupoAlimentos") result = result.OrderByDescending(p => p.sID_GrupoAlimento).Cast<TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "ID_SubGrupoAlimento") result = result.OrderByDescending(p => p.ID_SubGrupoAlimento).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "sID_SubGrupoAlimentos") result = result.OrderByDescending(p => p.sID_SubGrupoAlimento).Cast<TipoCompGrupoSubgrupoAli>().ToList(); 
                   if (orderCriteria == "MinVisible") result = result.OrderByDescending(p => p.MinVisible).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "MaxVisible") result = result.OrderByDescending(p => p.MaxVisible).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "SubgrupoManejaValor") result = result.OrderByDescending(p => p.SubgrupoManejaValor).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "SubgrupoFrecuencia") result = result.OrderByDescending(p => p.SubgrupoFrecuencia).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "UnidadMedida") result = result.OrderByDescending(p => p.UnidadMedida).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "ID_TipoComplemento") result = result.OrderByDescending(p => p.ID_TipoComplemento).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderByDescending(p => p.sID_TipoComplemento).Cast<TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "ID_ModalidadComplemento") result = result.OrderByDescending(p => p.ID_ModalidadComplemento).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "sID_TiposModalidadComplemento") result = result.OrderByDescending(p => p.sID_ModalidadComplemento).Cast<TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "TextoMsg") result = result.OrderByDescending(p => p.TextoMsg).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "ID_TipoSentidoValidacion") result = result.OrderByDescending(p => p.ID_TipoSentidoValidacion).Cast <TipoCompGrupoSubgrupoAli>().ToList(); 
                 if (orderCriteria == "sID_TiposSentidoValidacionMinutas") result = result.OrderByDescending(p => p.sID_TipoSentidoValidacion).Cast<TipoCompGrupoSubgrupoAli>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoModeloOperacion != null && r.ID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoModeloOperacion != null && r.sID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoComponente != null && r.ID_TipoComponente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoComponente != null && r.sID_TipoComponente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_GrupoAlimento != null && r.ID_GrupoAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_GrupoAlimento != null && r.sID_GrupoAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_SubGrupoAlimento != null && r.ID_SubGrupoAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_SubGrupoAlimento != null && r.sID_SubGrupoAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.MinVisible != null && r.MinVisible.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.MaxVisible != null && r.MaxVisible.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.SubgrupoManejaValor != null && r.SubgrupoManejaValor.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.SubgrupoFrecuencia != null && r.SubgrupoFrecuencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.UnidadMedida != null && r.UnidadMedida.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoComplemento != null && r.ID_TipoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoComplemento != null && r.sID_TipoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_ModalidadComplemento != null && r.ID_ModalidadComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ModalidadComplemento != null && r.sID_ModalidadComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TextoMsg != null && r.TextoMsg.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoSentidoValidacion != null && r.ID_TipoSentidoValidacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                || r.sID_TipoSentidoValidacion != null && r.sID_TipoSentidoValidacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
  
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
        /// CRUD de la entidad TipoCompGrupoSubgrupoAli --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  TipoCompGrupoSubgrupoAli!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de TipoCompGrupoSubgrupoAli</param>
        /// <response code="200">TipoCompGrupoSubgrupoAli Consulto los registros exitosamente</response>
        /// <response code="400">TipoCompGrupoSubgrupoAli tiene valores invalidos </response>
        /// <response code="401">TipoCompGrupoSubgrupoAli No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar TipoCompGrupoSubgrupoAli en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new TipoCompGrupoSubgrupoAliMs().GetAllByWithRelation().Cast<TipoCompGrupoSubgrupoAli>().AsQueryable();
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
