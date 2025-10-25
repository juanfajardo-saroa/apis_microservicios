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
    [SwaggerTag("Web API para CRUD de EntregaViveres .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class EntregaViveresController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad EntregaViveres --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  EntregaViveres!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de EntregaViveres</param>
        /// <response code="200">EntregaViveres Consulto los registros exitosamente</response>
        /// <response code="400">EntregaViveres tiene valores invalidos </response>
        /// <response code="401">EntregaViveres No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar EntregaViveres en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new EntregaViveresMs().GetAll().Cast<EntregaViveres>().AsQueryable();
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
        /// CRUD de la entidad EntregaViveres --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  EntregaViveres!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de EntregaViveres</param>
        /// <response code="200">EntregaViveres Consulto los registros exitosamente</response>
        /// <response code="400">EntregaViveres tiene valores invalidos </response>
        /// <response code="401">EntregaViveres No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar EntregaViveres en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new EntregaViveresMs().GetAllFull().Cast<EntregaViveres>().AsQueryable();
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
        /// CRUD de la entidad EntregaViveres --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  EntregaViveres!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de EntregaViveres</param>
        /// <response code="200">EntregaViveres Consulto los registros exitosamente</response>
        /// <response code="400">EntregaViveres tiene valores invalidos </response>
        /// <response code="401">EntregaViveres No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar EntregaViveres en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new EntregaViveresMs().GetById(new EntregaViveres() { id = id });
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
        /// CRUD de la entidad EntregaViveres --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Seguimiento de la entidad  EntregaViveres!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de EntregaViveres</param>
        /// <response code="200">EntregaViveres Creado</response>
        /// <response code="400">EntregaViveres tiene valores invalidos </response>
        /// <response code="401">EntregaViveres No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear EntregaViveres en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] EntregaViveres obj)
        {
            try
            {
                var result = new EntregaViveresMs().Add(obj);
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
        /// CRUD de la entidad EntregaViveres --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Seguimiento de la entidad  EntregaViveres!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de EntregaViveres</param>
        /// <response code="200">EntregaViveres Actualizado</response>
        /// <response code="400">EntregaViveres tiene valores invalidos </response>
        /// <response code="401">EntregaViveres No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar EntregaViveres en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] EntregaViveres obj)
        {
            try
            {
                var result = new EntregaViveresMs().Update(obj);
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
        /// CRUD de la entidad EntregaViveres --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Seguimiento de la entidad  EntregaViveres!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de EntregaViveres</param>
        /// <response code="200">EntregaViveres Eliminado</response>
        /// <response code="400">EntregaViveres tiene valores invalidos </response>
        /// <response code="401">EntregaViveres No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar EntregaViveres en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] EntregaViveres obj)
        {
           try
            {
                new EntregaViveresMs().Delete(obj);
                return Ok();
            }
            catch (System.Exception ex)
            {
                  return BadRequest(ex.Message);
            }
        }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad EntregaViveres --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  EntregaViveres!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de EntregaViveres</param>
        /// <response code="200">EntregaViveres Resultado</response>
        /// <response code="400">EntregaViveres tiene valores invalidos </response>
        /// <response code="401">EntregaViveres No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  EntregaViveres en este momento</response>
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
                var result = new EntregaViveresMs().GetAllByWithRelation().Cast<EntregaViveres>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                  if (orderAscendingDirection)                  {                  if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <EntregaViveres>().ToList();  
                  if (orderCriteria == "ID_AgrupacionMensual") result = result.OrderBy(p => p.ID_AgrupacionMensual).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "sID_AgrupacionesMensual") result = result.OrderBy(p => p.sID_AgrupacionMensual).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "ID_Producto") result = result.OrderBy(p => p.ID_Producto).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "sID_Productos") result = result.OrderBy(p => p.sID_Producto).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "ID_EstadoEntrega") result = result.OrderBy(p => p.ID_EstadoEntrega).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "sID_EstadosEntrega") result = result.OrderBy(p => p.sID_EstadoEntrega).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "ID_TipoTiempoEntrega") result = result.OrderBy(p => p.ID_TipoTiempoEntrega).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "sID_TiposTiemposEntrega") result = result.OrderBy(p => p.sID_TipoTiempoEntrega).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "ID_AlimentoPlan") result = result.OrderBy(p => p.ID_AlimentoPlan).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "sID_AlimentosPlan") result = result.OrderBy(p => p.sID_AlimentoPlan).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "CantidadRecibir") result = result.OrderBy(p => p.CantidadRecibir).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "FechaEntrega") result = result.OrderBy(p => p.FechaEntrega).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "AlimentoPlanld") result = result.OrderBy(p => p.AlimentoPlanld).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "ID_FaltanteIntercambio") result = result.OrderBy(p => p.ID_FaltanteIntercambio).Cast <EntregaViveres>().ToList(); 
                     }
  else 
                    {                  if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <EntregaViveres>().ToList();  
                  if (orderCriteria == "ID_AgrupacionMensual") result = result.OrderByDescending(p => p.ID_AgrupacionMensual).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "sID_AgrupacionesMensual") result = result.OrderByDescending(p => p.sID_AgrupacionMensual).Cast<EntregaViveres>().ToList(); 
                   if (orderCriteria == "ID_Producto") result = result.OrderByDescending(p => p.ID_Producto).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "sID_Productos") result = result.OrderByDescending(p => p.sID_Producto).Cast<EntregaViveres>().ToList(); 
                   if (orderCriteria == "ID_EstadoEntrega") result = result.OrderByDescending(p => p.ID_EstadoEntrega).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "sID_EstadosEntrega") result = result.OrderByDescending(p => p.sID_EstadoEntrega).Cast<EntregaViveres>().ToList(); 
                   if (orderCriteria == "ID_TipoTiempoEntrega") result = result.OrderByDescending(p => p.ID_TipoTiempoEntrega).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "sID_TiposTiemposEntrega") result = result.OrderByDescending(p => p.sID_TipoTiempoEntrega).Cast<EntregaViveres>().ToList(); 
                   if (orderCriteria == "ID_AlimentoPlan") result = result.OrderByDescending(p => p.ID_AlimentoPlan).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "sID_AlimentosPlan") result = result.OrderByDescending(p => p.sID_AlimentoPlan).Cast<EntregaViveres>().ToList(); 
                   if (orderCriteria == "CantidadRecibir") result = result.OrderByDescending(p => p.CantidadRecibir).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "FechaEntrega") result = result.OrderByDescending(p => p.FechaEntrega).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "AlimentoPlanld") result = result.OrderByDescending(p => p.AlimentoPlanld).Cast <EntregaViveres>().ToList(); 
                   if (orderCriteria == "ID_FaltanteIntercambio") result = result.OrderByDescending(p => p.ID_FaltanteIntercambio).Cast <EntregaViveres>().ToList(); 
                     }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                   || r.ID_AgrupacionMensual != null && r.ID_AgrupacionMensual.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_AgrupacionMensual != null && r.sID_AgrupacionMensual.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_Producto != null && r.ID_Producto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_Producto != null && r.sID_Producto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_EstadoEntrega != null && r.ID_EstadoEntrega.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_EstadoEntrega != null && r.sID_EstadoEntrega.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_TipoTiempoEntrega != null && r.ID_TipoTiempoEntrega.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_TipoTiempoEntrega != null && r.sID_TipoTiempoEntrega.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_AlimentoPlan != null && r.ID_AlimentoPlan.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_AlimentoPlan != null && r.sID_AlimentoPlan.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.CantidadRecibir != null && r.CantidadRecibir.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.FechaEntrega != null && r.FechaEntrega.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.AlimentoPlanld != null && r.AlimentoPlanld.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_FaltanteIntercambio != null && r.ID_FaltanteIntercambio.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad EntregaViveres --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  EntregaViveres!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de EntregaViveres</param>
        /// <response code="200">EntregaViveres Consulto los registros exitosamente</response>
        /// <response code="400">EntregaViveres tiene valores invalidos </response>
        /// <response code="401">EntregaViveres No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar EntregaViveres en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new EntregaViveresMs().GetAllByWithRelation().Cast<EntregaViveres>().AsQueryable();
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
