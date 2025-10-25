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
    [SwaggerTag("Web API para CRUD de Rutas .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class RutasController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Rutas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Rutas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Rutas</param>
        /// <response code="200">Rutas Consulto los registros exitosamente</response>
        /// <response code="400">Rutas tiene valores invalidos </response>
        /// <response code="401">Rutas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Rutas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new RutasMs().GetAll().Cast<Rutas>().AsQueryable();
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
        /// CRUD de la entidad Rutas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Rutas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Rutas</param>
        /// <response code="200">Rutas Consulto los registros exitosamente</response>
        /// <response code="400">Rutas tiene valores invalidos </response>
        /// <response code="401">Rutas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Rutas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new RutasMs().GetAllFull().Cast<Rutas>().AsQueryable();
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
        /// CRUD de la entidad Rutas --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Rutas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Rutas</param>
        /// <response code="200">Rutas Consulto los registros exitosamente</response>
        /// <response code="400">Rutas tiene valores invalidos </response>
        /// <response code="401">Rutas No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Rutas en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new RutasMs().GetById(new Rutas() { id = id });
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
        /// CRUD de la entidad Rutas --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Rutas!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Rutas</param>
        /// <response code="200">Rutas Creado</response>
        /// <response code="400">Rutas tiene valores invalidos </response>
        /// <response code="401">Rutas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Rutas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Rutas obj)
        {
            try
            {
                var result = new RutasMs().Add(obj);
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
        /// CRUD de la entidad Rutas --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Rutas!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Rutas</param>
        /// <response code="200">Rutas Actualizado</response>
        /// <response code="400">Rutas tiene valores invalidos </response>
        /// <response code="401">Rutas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Rutas en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Rutas obj)
        {
            try
            {
                var result = new RutasMs().Update(obj);
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
        /// CRUD de la entidad Rutas --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Rutas!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Rutas</param>
        /// <response code="200">Rutas Eliminado</response>
        /// <response code="400">Rutas tiene valores invalidos </response>
        /// <response code="401">Rutas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Rutas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Rutas obj)
        {
           try
            {
                new RutasMs().Delete(obj);
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
        /// DataTable de la entidad Rutas --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Rutas!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Rutas</param>
        /// <response code="200">Rutas Resultado</response>
        /// <response code="400">Rutas tiene valores invalidos </response>
        /// <response code="401">Rutas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Rutas en este momento</response>
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

                var result = new RutasMs().GetAllByWithRelation().Cast<Rutas>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Rutas>().ToList();  
                if (orderCriteria == "ID_PlanAlistamiento") result = result.OrderBy(p => p.ID_PlanAlistamiento).Cast <Rutas>().ToList(); 
                 if (orderCriteria == "sID_PlanesAlistamientos") result = result.OrderBy(p => p.sID_PlanAlistamiento).Cast <Rutas>().ToList(); 
                 if (orderCriteria == "ID_UsuarioEntidad") result = result.OrderBy(p => p.ID_UsuarioEntidad).Cast <Rutas>().ToList(); 
                 if (orderCriteria == "sID_UsuariosEntidades") result = result.OrderBy(p => p.sID_UsuarioEntidad).Cast <Rutas>().ToList(); 
                 if (orderCriteria == "ID_EstadoValidacion") result = result.OrderBy(p => p.ID_EstadoValidacion).Cast <Rutas>().ToList(); 
                 if (orderCriteria == "sID_EstadosValidacion") result = result.OrderBy(p => p.sID_EstadoValidacion).Cast <Rutas>().ToList(); 
                 if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderBy(p => p.ID_TipoModeloOperacion).Cast <Rutas>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderBy(p => p.sID_TipoModeloOperacion).Cast <Rutas>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Rutas>().ToList();  
                if (orderCriteria == "ID_PlanAlistamiento") result = result.OrderByDescending(p => p.ID_PlanAlistamiento).Cast <Rutas>().ToList(); 
                 if (orderCriteria == "sID_PlanesAlistamientos") result = result.OrderByDescending(p => p.sID_PlanAlistamiento).Cast<Rutas>().ToList(); 
                 if (orderCriteria == "ID_UsuarioEntidad") result = result.OrderByDescending(p => p.ID_UsuarioEntidad).Cast <Rutas>().ToList(); 
                 if (orderCriteria == "sID_UsuariosEntidades") result = result.OrderByDescending(p => p.sID_UsuarioEntidad).Cast<Rutas>().ToList(); 
                 if (orderCriteria == "ID_EstadoValidacion") result = result.OrderByDescending(p => p.ID_EstadoValidacion).Cast <Rutas>().ToList(); 
                 if (orderCriteria == "sID_EstadosValidacion") result = result.OrderByDescending(p => p.sID_EstadoValidacion).Cast<Rutas>().ToList(); 
                 if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderByDescending(p => p.ID_TipoModeloOperacion).Cast <Rutas>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderByDescending(p => p.sID_TipoModeloOperacion).Cast<Rutas>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_PlanAlistamiento != null && r.ID_PlanAlistamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_PlanAlistamiento != null && r.sID_PlanAlistamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_UsuarioEntidad != null && r.ID_UsuarioEntidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_UsuarioEntidad != null && r.sID_UsuarioEntidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_EstadoValidacion != null && r.ID_EstadoValidacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_EstadoValidacion != null && r.sID_EstadoValidacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoModeloOperacion != null && r.ID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoModeloOperacion != null && r.sID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad Rutas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Rutas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Rutas</param>
        /// <response code="200">Rutas Consulto los registros exitosamente</response>
        /// <response code="400">Rutas tiene valores invalidos </response>
        /// <response code="401">Rutas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Rutas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new RutasMs().GetAllByWithRelation().Cast<Rutas>().AsQueryable();
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
