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
using Microsoft.AspNetCore.OData.Query; using ElmahCore;




// create, index, delete, update , read
//  details, listall, 

namespace SISPAE_API_Seguimiento.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de Visitas .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class VisitasController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Visitas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Visitas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Visitas</param>
        /// <response code="200">Visitas Consulto los registros exitosamente</response>
        /// <response code="400">Visitas tiene valores invalidos </response>
        /// <response code="401">Visitas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Visitas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new VisitasMs().GetAll().Cast<Visitas>().AsQueryable();
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
        /// CRUD de la entidad Visitas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Visitas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Visitas</param>
        /// <response code="200">Visitas Consulto los registros exitosamente</response>
        /// <response code="400">Visitas tiene valores invalidos </response>
        /// <response code="401">Visitas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Visitas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new VisitasMs().GetAllFull().Cast<Visitas>().AsQueryable();
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
        /// CRUD de la entidad Visitas --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Visitas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Visitas</param>
        /// <response code="200">Visitas Consulto los registros exitosamente</response>
        /// <response code="400">Visitas tiene valores invalidos </response>
        /// <response code="401">Visitas No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Visitas en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new VisitasMs().GetById(new Visitas() { id = id });
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
        /// CRUD de la entidad Visitas --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Seguimiento de la entidad  Visitas!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Visitas</param>
        /// <response code="200">Visitas Creado</response>
        /// <response code="400">Visitas tiene valores invalidos </response>
        /// <response code="401">Visitas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Visitas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Visitas obj)
        {
            try
            {
                var result = new VisitasMs().Add(obj);
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
        /// CRUD de la entidad Visitas --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Seguimiento de la entidad  Visitas!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Visitas</param>
        /// <response code="200">Visitas Actualizado</response>
        /// <response code="400">Visitas tiene valores invalidos </response>
        /// <response code="401">Visitas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Visitas en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Visitas obj)
        {
            try
            {
                var result = new VisitasMs().Update(obj);
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
        /// CRUD de la entidad Visitas --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Seguimiento de la entidad  Visitas!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Visitas</param>
        /// <response code="200">Visitas Eliminado</response>
        /// <response code="400">Visitas tiene valores invalidos </response>
        /// <response code="401">Visitas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Visitas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Visitas obj)
        {
           try
            {
                new VisitasMs().Delete(obj);
                return Ok();
            }
            catch (System.Exception ex)
            {
                  return BadRequest(ex.Message);
            }
        }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad Visitas --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Visitas!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Visitas</param>
        /// <response code="200">Visitas Resultado</response>
        /// <response code="400">Visitas tiene valores invalidos </response>
        /// <response code="401">Visitas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Visitas en este momento</response>
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
                var result = new VisitasMs().GetAllByWithRelation().Cast<Visitas>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                  if (orderAscendingDirection)                  {                  if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Visitas>().ToList();  
                  if (orderCriteria == "ID_Contrato") result = result.OrderBy(p => p.ID_Contrato).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "sID_Contratos") result = result.OrderBy(p => p.sID_Contrato).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "ID_Sede") result = result.OrderBy(p => p.ID_Sede).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "sID_Sedes") result = result.OrderBy(p => p.sID_Sede).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderBy(p => p.ID_TipoModeloOperacion).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderBy(p => p.sID_TipoModeloOperacion).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "ID_UsuarioEntidad") result = result.OrderBy(p => p.ID_UsuarioEntidad).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "sID_UsuariosEntidades") result = result.OrderBy(p => p.sID_UsuarioEntidad).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "ID_PlantaBodega") result = result.OrderBy(p => p.ID_PlantaBodega).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "sID_PlantaBodegas") result = result.OrderBy(p => p.sID_PlantaBodega).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "ID_EstadoVisita") result = result.OrderBy(p => p.ID_EstadoVisita).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "sID_TiposEstadosVisitas") result = result.OrderBy(p => p.sID_EstadoVisita).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "ID_TipoVisita") result = result.OrderBy(p => p.ID_TipoVisita).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "sID_TiposVisita") result = result.OrderBy(p => p.sID_TipoVisita).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "Fecha") result = result.OrderBy(p => p.Fecha).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "Horalnicio") result = result.OrderBy(p => p.Horalnicio).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "HoraFin") result = result.OrderBy(p => p.HoraFin).Cast <Visitas>().ToList(); 
                     }
  else 
                    {                  if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Visitas>().ToList();  
                  if (orderCriteria == "ID_Contrato") result = result.OrderByDescending(p => p.ID_Contrato).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "sID_Contratos") result = result.OrderByDescending(p => p.sID_Contrato).Cast<Visitas>().ToList(); 
                   if (orderCriteria == "ID_Sede") result = result.OrderByDescending(p => p.ID_Sede).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "sID_Sedes") result = result.OrderByDescending(p => p.sID_Sede).Cast<Visitas>().ToList(); 
                   if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderByDescending(p => p.ID_TipoModeloOperacion).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderByDescending(p => p.sID_TipoModeloOperacion).Cast<Visitas>().ToList(); 
                   if (orderCriteria == "ID_UsuarioEntidad") result = result.OrderByDescending(p => p.ID_UsuarioEntidad).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "sID_UsuariosEntidades") result = result.OrderByDescending(p => p.sID_UsuarioEntidad).Cast<Visitas>().ToList(); 
                   if (orderCriteria == "ID_PlantaBodega") result = result.OrderByDescending(p => p.ID_PlantaBodega).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "sID_PlantaBodegas") result = result.OrderByDescending(p => p.sID_PlantaBodega).Cast<Visitas>().ToList(); 
                   if (orderCriteria == "ID_EstadoVisita") result = result.OrderByDescending(p => p.ID_EstadoVisita).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "sID_TiposEstadosVisitas") result = result.OrderByDescending(p => p.sID_EstadoVisita).Cast<Visitas>().ToList(); 
                   if (orderCriteria == "ID_TipoVisita") result = result.OrderByDescending(p => p.ID_TipoVisita).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "sID_TiposVisita") result = result.OrderByDescending(p => p.sID_TipoVisita).Cast<Visitas>().ToList(); 
                   if (orderCriteria == "Fecha") result = result.OrderByDescending(p => p.Fecha).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "Horalnicio") result = result.OrderByDescending(p => p.Horalnicio).Cast <Visitas>().ToList(); 
                   if (orderCriteria == "HoraFin") result = result.OrderByDescending(p => p.HoraFin).Cast <Visitas>().ToList(); 
                     }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                   || r.ID_Contrato != null && r.ID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_Contrato != null && r.sID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_Sede != null && r.ID_Sede.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_Sede != null && r.sID_Sede.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_TipoModeloOperacion != null && r.ID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_TipoModeloOperacion != null && r.sID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_UsuarioEntidad != null && r.ID_UsuarioEntidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_UsuarioEntidad != null && r.sID_UsuarioEntidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_PlantaBodega != null && r.ID_PlantaBodega.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_PlantaBodega != null && r.sID_PlantaBodega.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_EstadoVisita != null && r.ID_EstadoVisita.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_EstadoVisita != null && r.sID_EstadoVisita.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_TipoVisita != null && r.ID_TipoVisita.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_TipoVisita != null && r.sID_TipoVisita.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Fecha != null && r.Fecha.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Horalnicio != null && r.Horalnicio.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.HoraFin != null && r.HoraFin.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad Visitas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Visitas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Visitas</param>
        /// <response code="200">Visitas Consulto los registros exitosamente</response>
        /// <response code="400">Visitas tiene valores invalidos </response>
        /// <response code="401">Visitas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Visitas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new VisitasMs().GetAllByWithRelation().Cast<Visitas>().AsQueryable();
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
