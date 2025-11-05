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
    [SwaggerTag("Web API para CRUD de EntregaProductos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class EntregaProductosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad EntregaProductos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  EntregaProductos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de EntregaProductos</param>
        /// <response code="200">EntregaProductos Consulto los registros exitosamente</response>
        /// <response code="400">EntregaProductos tiene valores invalidos </response>
        /// <response code="401">EntregaProductos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar EntregaProductos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new EntregaProductosMs().GetAll().Cast<EntregaProductos>().AsQueryable();
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
        /// CRUD de la entidad EntregaProductos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  EntregaProductos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de EntregaProductos</param>
        /// <response code="200">EntregaProductos Consulto los registros exitosamente</response>
        /// <response code="400">EntregaProductos tiene valores invalidos </response>
        /// <response code="401">EntregaProductos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar EntregaProductos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new EntregaProductosMs().GetAllFull().Cast<EntregaProductos>().AsQueryable();
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
        /// CRUD de la entidad EntregaProductos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  EntregaProductos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de EntregaProductos</param>
        /// <response code="200">EntregaProductos Consulto los registros exitosamente</response>
        /// <response code="400">EntregaProductos tiene valores invalidos </response>
        /// <response code="401">EntregaProductos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar EntregaProductos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new EntregaProductosMs().GetById(new EntregaProductos() { id = id });
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
        /// CRUD de la entidad EntregaProductos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  EntregaProductos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de EntregaProductos</param>
        /// <response code="200">EntregaProductos Creado</response>
        /// <response code="400">EntregaProductos tiene valores invalidos </response>
        /// <response code="401">EntregaProductos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear EntregaProductos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] EntregaProductos obj)
        {
            try
            {
                var result = new EntregaProductosMs().Add(obj);
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
        /// CRUD de la entidad EntregaProductos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  EntregaProductos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de EntregaProductos</param>
        /// <response code="200">EntregaProductos Actualizado</response>
        /// <response code="400">EntregaProductos tiene valores invalidos </response>
        /// <response code="401">EntregaProductos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar EntregaProductos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] EntregaProductos obj)
        {
            try
            {
                var result = new EntregaProductosMs().Update(obj);
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
        /// CRUD de la entidad EntregaProductos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  EntregaProductos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de EntregaProductos</param>
        /// <response code="200">EntregaProductos Eliminado</response>
        /// <response code="400">EntregaProductos tiene valores invalidos </response>
        /// <response code="401">EntregaProductos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar EntregaProductos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] EntregaProductos obj)
        {
           try
            {
                new EntregaProductosMs().Delete(obj);
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
        /// DataTable de la entidad EntregaProductos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  EntregaProductos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de EntregaProductos</param>
        /// <response code="200">EntregaProductos Resultado</response>
        /// <response code="400">EntregaProductos tiene valores invalidos </response>
        /// <response code="401">EntregaProductos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  EntregaProductos en este momento</response>
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

                var result = new EntregaProductosMs().GetAllByWithRelation().Cast<EntregaProductos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <EntregaProductos>().ToList();  
                if (orderCriteria == "ID_Ruta") result = result.OrderBy(p => p.ID_Ruta).Cast <EntregaProductos>().ToList(); 
                 if (orderCriteria == "sID_Rutas") result = result.OrderBy(p => p.sID_Ruta).Cast <EntregaProductos>().ToList(); 
                 if (orderCriteria == "ID_TipoPeriocidad") result = result.OrderBy(p => p.ID_TipoPeriocidad).Cast <EntregaProductos>().ToList(); 
                 if (orderCriteria == "sID_TiposPeriodicidad") result = result.OrderBy(p => p.sID_TipoPeriocidad).Cast <EntregaProductos>().ToList(); 
                 if (orderCriteria == "ID_TipoDiaSemanaEntrega1") result = result.OrderBy(p => p.ID_TipoDiaSemanaEntrega1).Cast <EntregaProductos>().ToList(); 
                 if (orderCriteria == "sID_TiposDiaSemana") result = result.OrderBy(p => p.sID_TipoDiaSemanaEntrega1).Cast <EntregaProductos>().ToList(); 
                 if (orderCriteria == "ID_TipoDiaSemanaEntrega2") result = result.OrderBy(p => p.ID_TipoDiaSemanaEntrega2).Cast <EntregaProductos>().ToList(); 
                 if (orderCriteria == "sID_TiposDiaSemana") result = result.OrderBy(p => p.sID_TipoDiaSemanaEntrega2).Cast <EntregaProductos>().ToList(); 
                 if (orderCriteria == "ID_TipoProductoRuta") result = result.OrderBy(p => p.ID_TipoProductoRuta).Cast <EntregaProductos>().ToList(); 
                 if (orderCriteria == "sID_TiposProductoRutas") result = result.OrderBy(p => p.sID_TipoProductoRuta).Cast <EntregaProductos>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <EntregaProductos>().ToList();  
                if (orderCriteria == "ID_Ruta") result = result.OrderByDescending(p => p.ID_Ruta).Cast <EntregaProductos>().ToList(); 
                 if (orderCriteria == "sID_Rutas") result = result.OrderByDescending(p => p.sID_Ruta).Cast<EntregaProductos>().ToList(); 
                 if (orderCriteria == "ID_TipoPeriocidad") result = result.OrderByDescending(p => p.ID_TipoPeriocidad).Cast <EntregaProductos>().ToList(); 
                 if (orderCriteria == "sID_TiposPeriodicidad") result = result.OrderByDescending(p => p.sID_TipoPeriocidad).Cast<EntregaProductos>().ToList(); 
                 if (orderCriteria == "ID_TipoDiaSemanaEntrega1") result = result.OrderByDescending(p => p.ID_TipoDiaSemanaEntrega1).Cast <EntregaProductos>().ToList(); 
                 if (orderCriteria == "sID_TiposDiaSemana") result = result.OrderByDescending(p => p.sID_TipoDiaSemanaEntrega1).Cast<EntregaProductos>().ToList(); 
                 if (orderCriteria == "ID_TipoDiaSemanaEntrega2") result = result.OrderByDescending(p => p.ID_TipoDiaSemanaEntrega2).Cast <EntregaProductos>().ToList(); 
                 if (orderCriteria == "sID_TiposDiaSemana") result = result.OrderByDescending(p => p.sID_TipoDiaSemanaEntrega2).Cast<EntregaProductos>().ToList(); 
                 if (orderCriteria == "ID_TipoProductoRuta") result = result.OrderByDescending(p => p.ID_TipoProductoRuta).Cast <EntregaProductos>().ToList(); 
                 if (orderCriteria == "sID_TiposProductoRutas") result = result.OrderByDescending(p => p.sID_TipoProductoRuta).Cast<EntregaProductos>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Ruta != null && r.ID_Ruta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Ruta != null && r.sID_Ruta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoPeriocidad != null && r.ID_TipoPeriocidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoPeriocidad != null && r.sID_TipoPeriocidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoDiaSemanaEntrega1 != null && r.ID_TipoDiaSemanaEntrega1.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoDiaSemanaEntrega1 != null && r.sID_TipoDiaSemanaEntrega1.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoDiaSemanaEntrega2 != null && r.ID_TipoDiaSemanaEntrega2.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoDiaSemanaEntrega2 != null && r.sID_TipoDiaSemanaEntrega2.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoProductoRuta != null && r.ID_TipoProductoRuta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoProductoRuta != null && r.sID_TipoProductoRuta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad EntregaProductos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  EntregaProductos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de EntregaProductos</param>
        /// <response code="200">EntregaProductos Consulto los registros exitosamente</response>
        /// <response code="400">EntregaProductos tiene valores invalidos </response>
        /// <response code="401">EntregaProductos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar EntregaProductos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new EntregaProductosMs().GetAllByWithRelation().Cast<EntregaProductos>().AsQueryable();
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
