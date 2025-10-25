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
    [SwaggerTag("Web API para CRUD de PesoNetoPreparacion .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PesoNetoPreparacionController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PesoNetoPreparacion --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  PesoNetoPreparacion!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PesoNetoPreparacion</param>
        /// <response code="200">PesoNetoPreparacion Consulto los registros exitosamente</response>
        /// <response code="400">PesoNetoPreparacion tiene valores invalidos </response>
        /// <response code="401">PesoNetoPreparacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PesoNetoPreparacion en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new PesoNetoPreparacionMs().GetAll().Cast<PesoNetoPreparacion>().AsQueryable();
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
        /// CRUD de la entidad PesoNetoPreparacion --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  PesoNetoPreparacion!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PesoNetoPreparacion</param>
        /// <response code="200">PesoNetoPreparacion Consulto los registros exitosamente</response>
        /// <response code="400">PesoNetoPreparacion tiene valores invalidos </response>
        /// <response code="401">PesoNetoPreparacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PesoNetoPreparacion en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new PesoNetoPreparacionMs().GetAllFull().Cast<PesoNetoPreparacion>().AsQueryable();
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
        /// CRUD de la entidad PesoNetoPreparacion --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  PesoNetoPreparacion!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PesoNetoPreparacion</param>
        /// <response code="200">PesoNetoPreparacion Consulto los registros exitosamente</response>
        /// <response code="400">PesoNetoPreparacion tiene valores invalidos </response>
        /// <response code="401">PesoNetoPreparacion No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar PesoNetoPreparacion en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new PesoNetoPreparacionMs().GetById(new PesoNetoPreparacion() { id = id });
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
        /// CRUD de la entidad PesoNetoPreparacion --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PTN de la entidad  PesoNetoPreparacion!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de PesoNetoPreparacion</param>
        /// <response code="200">PesoNetoPreparacion Creado</response>
        /// <response code="400">PesoNetoPreparacion tiene valores invalidos </response>
        /// <response code="401">PesoNetoPreparacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear PesoNetoPreparacion en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] PesoNetoPreparacion obj)
        {
            try
            {
                var result = new PesoNetoPreparacionMs().Add(obj);
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
        /// CRUD de la entidad PesoNetoPreparacion --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PTN de la entidad  PesoNetoPreparacion!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de PesoNetoPreparacion</param>
        /// <response code="200">PesoNetoPreparacion Actualizado</response>
        /// <response code="400">PesoNetoPreparacion tiene valores invalidos </response>
        /// <response code="401">PesoNetoPreparacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar PesoNetoPreparacion en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] PesoNetoPreparacion obj)
        {

            try
            {
                var result = new PesoNetoPreparacionMs().Update(obj);
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
        /// CRUD de la entidad PesoNetoPreparacion --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PTN de la entidad  PesoNetoPreparacion!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de PesoNetoPreparacion</param>
        /// <response code="200">PesoNetoPreparacion Eliminado</response>
        /// <response code="400">PesoNetoPreparacion tiene valores invalidos </response>
        /// <response code="401">PesoNetoPreparacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar PesoNetoPreparacion en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] PesoNetoPreparacion obj)
        {
           try
            {
                new PesoNetoPreparacionMs().Delete(obj);
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
        /// DataTable de la entidad PesoNetoPreparacion --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  PesoNetoPreparacion!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de PesoNetoPreparacion</param>
        /// <response code="200">PesoNetoPreparacion Resultado</response>
        /// <response code="400">PesoNetoPreparacion tiene valores invalidos </response>
        /// <response code="401">PesoNetoPreparacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  PesoNetoPreparacion en este momento</response>
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

                var result = new PesoNetoPreparacionMs().GetAllByWithRelation().Cast<PesoNetoPreparacion>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <PesoNetoPreparacion>().ToList();  
                if (orderCriteria == "ID_TipoComponente") result = result.OrderBy(p => p.ID_TipoComponente).Cast <PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "sID_TiposComponente") result = result.OrderBy(p => p.sID_TipoComponente).Cast <PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "ID_TipoNivelEducativo") result = result.OrderBy(p => p.ID_TipoNivelEducativo).Cast <PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "sID_NivelEducativo") result = result.OrderBy(p => p.sID_TipoNivelEducativo).Cast <PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "ID_Preparacion") result = result.OrderBy(p => p.ID_Preparacion).Cast <PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "sID_Preparaciones") result = result.OrderBy(p => p.sID_Preparacion).Cast <PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "PesoNeto") result = result.OrderBy(p => p.PesoNeto).Cast <PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "ID_SubGrupoAlimentos") result = result.OrderBy(p => p.ID_SubGrupoAlimentos).Cast <PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "sID_SubGrupoAlimentos") result = result.OrderBy(p => p.sID_SubGrupoAlimentos).Cast <PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "ID_TipoComplemento") result = result.OrderBy(p => p.ID_TipoComplemento).Cast <PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderBy(p => p.sID_TipoComplemento).Cast <PesoNetoPreparacion>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <PesoNetoPreparacion>().ToList();  
                if (orderCriteria == "ID_TipoComponente") result = result.OrderByDescending(p => p.ID_TipoComponente).Cast <PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "sID_TiposComponente") result = result.OrderByDescending(p => p.sID_TipoComponente).Cast<PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "ID_TipoNivelEducativo") result = result.OrderByDescending(p => p.ID_TipoNivelEducativo).Cast <PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "sID_NivelEducativo") result = result.OrderByDescending(p => p.sID_TipoNivelEducativo).Cast<PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "ID_Preparacion") result = result.OrderByDescending(p => p.ID_Preparacion).Cast <PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "sID_Preparaciones") result = result.OrderByDescending(p => p.sID_Preparacion).Cast<PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "PesoNeto") result = result.OrderByDescending(p => p.PesoNeto).Cast <PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "ID_SubGrupoAlimentos") result = result.OrderByDescending(p => p.ID_SubGrupoAlimentos).Cast <PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "sID_SubGrupoAlimentos") result = result.OrderByDescending(p => p.sID_SubGrupoAlimentos).Cast<PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "ID_TipoComplemento") result = result.OrderByDescending(p => p.ID_TipoComplemento).Cast <PesoNetoPreparacion>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderByDescending(p => p.sID_TipoComplemento).Cast<PesoNetoPreparacion>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoComponente != null && r.ID_TipoComponente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoComponente != null && r.sID_TipoComponente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoNivelEducativo != null && r.ID_TipoNivelEducativo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoNivelEducativo != null && r.sID_TipoNivelEducativo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Preparacion != null && r.ID_Preparacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Preparacion != null && r.sID_Preparacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PesoNeto != null && r.PesoNeto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_SubGrupoAlimentos != null && r.ID_SubGrupoAlimentos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_SubGrupoAlimentos != null && r.sID_SubGrupoAlimentos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoComplemento != null && r.ID_TipoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoComplemento != null && r.sID_TipoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad PesoNetoPreparacion --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  PesoNetoPreparacion!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PesoNetoPreparacion</param>
        /// <response code="200">PesoNetoPreparacion Consulto los registros exitosamente</response>
        /// <response code="400">PesoNetoPreparacion tiene valores invalidos </response>
        /// <response code="401">PesoNetoPreparacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PesoNetoPreparacion en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new PesoNetoPreparacionMs().GetAllByWithRelation().Cast<PesoNetoPreparacion>().AsQueryable();
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
