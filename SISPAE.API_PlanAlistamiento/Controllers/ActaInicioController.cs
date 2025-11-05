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
    [SwaggerTag("Web API para CRUD de ActaInicio .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class ActaInicioController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad ActaInicio --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  ActaInicio!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ActaInicio</param>
        /// <response code="200">ActaInicio Consulto los registros exitosamente</response>
        /// <response code="400">ActaInicio tiene valores invalidos </response>
        /// <response code="401">ActaInicio No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ActaInicio en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new ActaInicioMs().GetAll().Cast<ActaInicio>().AsQueryable();
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
        /// CRUD de la entidad ActaInicio --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  ActaInicio!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ActaInicio</param>
        /// <response code="200">ActaInicio Consulto los registros exitosamente</response>
        /// <response code="400">ActaInicio tiene valores invalidos </response>
        /// <response code="401">ActaInicio No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ActaInicio en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new ActaInicioMs().GetAllFull().Cast<ActaInicio>().AsQueryable();
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
        /// CRUD de la entidad ActaInicio --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  ActaInicio!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ActaInicio</param>
        /// <response code="200">ActaInicio Consulto los registros exitosamente</response>
        /// <response code="400">ActaInicio tiene valores invalidos </response>
        /// <response code="401">ActaInicio No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar ActaInicio en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new ActaInicioMs().GetById(new ActaInicio() { id = id });
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
        /// CRUD de la entidad ActaInicio --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE de la entidad  ActaInicio!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de ActaInicio</param>
        /// <response code="200">ActaInicio Creado</response>
        /// <response code="400">ActaInicio tiene valores invalidos </response>
        /// <response code="401">ActaInicio No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear ActaInicio en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] ActaInicio obj)
        {
            try
            {
                var result = new ActaInicioMs().Add(obj);
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
        /// CRUD de la entidad ActaInicio --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE de la entidad  ActaInicio!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de ActaInicio</param>
        /// <response code="200">ActaInicio Actualizado</response>
        /// <response code="400">ActaInicio tiene valores invalidos </response>
        /// <response code="401">ActaInicio No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar ActaInicio en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] ActaInicio obj)
        {
            try
            {
                var result = new ActaInicioMs().Update(obj);
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
        /// CRUD de la entidad ActaInicio --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE de la entidad  ActaInicio!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de ActaInicio</param>
        /// <response code="200">ActaInicio Eliminado</response>
        /// <response code="400">ActaInicio tiene valores invalidos </response>
        /// <response code="401">ActaInicio No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar ActaInicio en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] ActaInicio obj)
        {
           try
            {
                new ActaInicioMs().Delete(obj);
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
        /// DataTable de la entidad ActaInicio --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  ActaInicio!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de ActaInicio</param>
        /// <response code="200">ActaInicio Resultado</response>
        /// <response code="400">ActaInicio tiene valores invalidos </response>
        /// <response code="401">ActaInicio No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  ActaInicio en este momento</response>
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

                var result = new ActaInicioMs().GetAllByWithRelation().Cast<ActaInicio>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                  if (orderAscendingDirection)                  {                  if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <ActaInicio>().ToList();  
                  if (orderCriteria == "ID_PlanAlistamiento") result = result.OrderBy(p => p.ID_PlanAlistamiento).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "sID_PlanesAlistamientos") result = result.OrderBy(p => p.sID_PlanAlistamiento).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "ID_Contrato") result = result.OrderBy(p => p.ID_Contrato).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "ID_CicloMenu") result = result.OrderBy(p => p.ID_CicloMenu).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "FechaActa") result = result.OrderBy(p => p.FechaActa).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "NombreSupervisor") result = result.OrderBy(p => p.NombreSupervisor).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "CedulaSupervisor") result = result.OrderBy(p => p.CedulaSupervisor).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "LugarCedulaSupervisor") result = result.OrderBy(p => p.LugarCedulaSupervisor).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "NombreRepresentanteLegalOperador") result = result.OrderBy(p => p.NombreRepresentanteLegalOperador).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "CedulaRepresentanteOperador") result = result.OrderBy(p => p.CedulaRepresentanteOperador).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "LugarCedulaRepresentante") result = result.OrderBy(p => p.LugarCedulaRepresentante).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "FechaInicioOPeracionAutorizada") result = result.OrderBy(p => p.FechaInicioOPeracionAutorizada).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "EstadoInicioOperacion") result = result.OrderBy(p => p.EstadoInicioOperacion).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "Menu1") result = result.OrderBy(p => p.Menu1).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "Menu2") result = result.OrderBy(p => p.Menu2).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "Menu3") result = result.OrderBy(p => p.Menu3).Cast <ActaInicio>().ToList(); 
                     }
  else 
                    {                  if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <ActaInicio>().ToList();  
                  if (orderCriteria == "ID_PlanAlistamiento") result = result.OrderByDescending(p => p.ID_PlanAlistamiento).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "sID_PlanesAlistamientos") result = result.OrderByDescending(p => p.sID_PlanAlistamiento).Cast<ActaInicio>().ToList(); 
                   if (orderCriteria == "ID_Contrato") result = result.OrderByDescending(p => p.ID_Contrato).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "ID_CicloMenu") result = result.OrderByDescending(p => p.ID_CicloMenu).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "FechaActa") result = result.OrderByDescending(p => p.FechaActa).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "NombreSupervisor") result = result.OrderByDescending(p => p.NombreSupervisor).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "CedulaSupervisor") result = result.OrderByDescending(p => p.CedulaSupervisor).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "LugarCedulaSupervisor") result = result.OrderByDescending(p => p.LugarCedulaSupervisor).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "NombreRepresentanteLegalOperador") result = result.OrderByDescending(p => p.NombreRepresentanteLegalOperador).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "CedulaRepresentanteOperador") result = result.OrderByDescending(p => p.CedulaRepresentanteOperador).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "LugarCedulaRepresentante") result = result.OrderByDescending(p => p.LugarCedulaRepresentante).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "FechaInicioOPeracionAutorizada") result = result.OrderByDescending(p => p.FechaInicioOPeracionAutorizada).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "EstadoInicioOperacion") result = result.OrderByDescending(p => p.EstadoInicioOperacion).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "Menu1") result = result.OrderByDescending(p => p.Menu1).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "Menu2") result = result.OrderByDescending(p => p.Menu2).Cast <ActaInicio>().ToList(); 
                   if (orderCriteria == "Menu3") result = result.OrderByDescending(p => p.Menu3).Cast <ActaInicio>().ToList(); 
                     }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                   || r.ID_PlanAlistamiento != null && r.ID_PlanAlistamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_PlanAlistamiento != null && r.sID_PlanAlistamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_Contrato != null && r.ID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_CicloMenu != null && r.ID_CicloMenu.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.FechaActa != null && r.FechaActa.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.NombreSupervisor != null && r.NombreSupervisor.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.CedulaSupervisor != null && r.CedulaSupervisor.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.LugarCedulaSupervisor != null && r.LugarCedulaSupervisor.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.NombreRepresentanteLegalOperador != null && r.NombreRepresentanteLegalOperador.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.CedulaRepresentanteOperador != null && r.CedulaRepresentanteOperador.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.LugarCedulaRepresentante != null && r.LugarCedulaRepresentante.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.FechaInicioOPeracionAutorizada != null && r.FechaInicioOPeracionAutorizada.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.EstadoInicioOperacion != null && r.EstadoInicioOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Menu1 != null && r.Menu1.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Menu2 != null && r.Menu2.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Menu3 != null && r.Menu3.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad ActaInicio --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  ActaInicio!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ActaInicio</param>
        /// <response code="200">ActaInicio Consulto los registros exitosamente</response>
        /// <response code="400">ActaInicio tiene valores invalidos </response>
        /// <response code="401">ActaInicio No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ActaInicio en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new ActaInicioMs().GetAllByWithRelation().Cast<ActaInicio>().AsQueryable();
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
