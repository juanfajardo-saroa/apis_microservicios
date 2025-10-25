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
    [SwaggerTag("Web API para CRUD de MunicipioAdquiereServicio .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class MunicipioAdquiereServicioController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad MunicipioAdquiereServicio --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  MunicipioAdquiereServicio!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MunicipioAdquiereServicio</param>
        /// <response code="200">MunicipioAdquiereServicio Consulto los registros exitosamente</response>
        /// <response code="400">MunicipioAdquiereServicio tiene valores invalidos </response>
        /// <response code="401">MunicipioAdquiereServicio No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MunicipioAdquiereServicio en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new MunicipioAdquiereServicioMs().GetAll().Cast<MunicipioAdquiereServicio>().AsQueryable();
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
        /// CRUD de la entidad MunicipioAdquiereServicio --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  MunicipioAdquiereServicio!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MunicipioAdquiereServicio</param>
        /// <response code="200">MunicipioAdquiereServicio Consulto los registros exitosamente</response>
        /// <response code="400">MunicipioAdquiereServicio tiene valores invalidos </response>
        /// <response code="401">MunicipioAdquiereServicio No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MunicipioAdquiereServicio en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new MunicipioAdquiereServicioMs().GetAllFull().Cast<MunicipioAdquiereServicio>().AsQueryable();
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
        /// CRUD de la entidad MunicipioAdquiereServicio --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  MunicipioAdquiereServicio!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MunicipioAdquiereServicio</param>
        /// <response code="200">MunicipioAdquiereServicio Consulto los registros exitosamente</response>
        /// <response code="400">MunicipioAdquiereServicio tiene valores invalidos </response>
        /// <response code="401">MunicipioAdquiereServicio No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar MunicipioAdquiereServicio en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new MunicipioAdquiereServicioMs().GetById(new MunicipioAdquiereServicio() { id = id });
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
        /// CRUD de la entidad MunicipioAdquiereServicio --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Seguimiento de la entidad  MunicipioAdquiereServicio!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de MunicipioAdquiereServicio</param>
        /// <response code="200">MunicipioAdquiereServicio Creado</response>
        /// <response code="400">MunicipioAdquiereServicio tiene valores invalidos </response>
        /// <response code="401">MunicipioAdquiereServicio No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear MunicipioAdquiereServicio en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] MunicipioAdquiereServicio obj)
        {
            try
            {
                var result = new MunicipioAdquiereServicioMs().Add(obj);
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
        /// CRUD de la entidad MunicipioAdquiereServicio --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Seguimiento de la entidad  MunicipioAdquiereServicio!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de MunicipioAdquiereServicio</param>
        /// <response code="200">MunicipioAdquiereServicio Actualizado</response>
        /// <response code="400">MunicipioAdquiereServicio tiene valores invalidos </response>
        /// <response code="401">MunicipioAdquiereServicio No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar MunicipioAdquiereServicio en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] MunicipioAdquiereServicio obj)
        {
            try
            {
                var result = new MunicipioAdquiereServicioMs().Update(obj);
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
        /// CRUD de la entidad MunicipioAdquiereServicio --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Seguimiento de la entidad  MunicipioAdquiereServicio!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de MunicipioAdquiereServicio</param>
        /// <response code="200">MunicipioAdquiereServicio Eliminado</response>
        /// <response code="400">MunicipioAdquiereServicio tiene valores invalidos </response>
        /// <response code="401">MunicipioAdquiereServicio No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar MunicipioAdquiereServicio en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] MunicipioAdquiereServicio obj)
        {
           try
            {
                new MunicipioAdquiereServicioMs().Delete(obj);
                return Ok();
            }
            catch (System.Exception ex)
            {
                  return BadRequest(ex.Message);
            }
        }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad MunicipioAdquiereServicio --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  MunicipioAdquiereServicio!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de MunicipioAdquiereServicio</param>
        /// <response code="200">MunicipioAdquiereServicio Resultado</response>
        /// <response code="400">MunicipioAdquiereServicio tiene valores invalidos </response>
        /// <response code="401">MunicipioAdquiereServicio No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  MunicipioAdquiereServicio en este momento</response>
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
                var result = new MunicipioAdquiereServicioMs().GetAllByWithRelation().Cast<MunicipioAdquiereServicio>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                  if (orderAscendingDirection)                  {                  if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <MunicipioAdquiereServicio>().ToList();  
                  if (orderCriteria == "ID_Divipolas") result = result.OrderBy(p => p.ID_Divipolas).Cast <MunicipioAdquiereServicio>().ToList(); 
                   if (orderCriteria == "sID_Divipolas") result = result.OrderBy(p => p.sID_Divipolas).Cast <MunicipioAdquiereServicio>().ToList(); 
                   if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <MunicipioAdquiereServicio>().ToList(); 
                     }
  else 
                    {                  if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <MunicipioAdquiereServicio>().ToList();  
                  if (orderCriteria == "ID_Divipolas") result = result.OrderByDescending(p => p.ID_Divipolas).Cast <MunicipioAdquiereServicio>().ToList(); 
                   if (orderCriteria == "sID_Divipolas") result = result.OrderByDescending(p => p.sID_Divipolas).Cast<MunicipioAdquiereServicio>().ToList(); 
                   if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <MunicipioAdquiereServicio>().ToList(); 
                     }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                   || r.ID_Divipolas != null && r.ID_Divipolas.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_Divipolas != null && r.sID_Divipolas.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad MunicipioAdquiereServicio --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  MunicipioAdquiereServicio!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MunicipioAdquiereServicio</param>
        /// <response code="200">MunicipioAdquiereServicio Consulto los registros exitosamente</response>
        /// <response code="400">MunicipioAdquiereServicio tiene valores invalidos </response>
        /// <response code="401">MunicipioAdquiereServicio No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MunicipioAdquiereServicio en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new MunicipioAdquiereServicioMs().GetAllByWithRelation().Cast<MunicipioAdquiereServicio>().AsQueryable();
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
