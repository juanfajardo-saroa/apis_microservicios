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

namespace SISPAE_API_PlaneacionFinanciera.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de Pagos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PagosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Pagos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  Pagos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Pagos</param>
        /// <response code="200">Pagos Consulto los registros exitosamente</response>
        /// <response code="400">Pagos tiene valores invalidos </response>
        /// <response code="401">Pagos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Pagos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new PagosMs().GetAll().Cast<Pagos>().AsQueryable();
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
        /// CRUD de la entidad Pagos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  Pagos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Pagos</param>
        /// <response code="200">Pagos Consulto los registros exitosamente</response>
        /// <response code="400">Pagos tiene valores invalidos </response>
        /// <response code="401">Pagos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Pagos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new PagosMs().GetAllFull().Cast<Pagos>().AsQueryable();
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
        /// CRUD de la entidad Pagos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  Pagos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Pagos</param>
        /// <response code="200">Pagos Consulto los registros exitosamente</response>
        /// <response code="400">Pagos tiene valores invalidos </response>
        /// <response code="401">Pagos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Pagos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new PagosMs().GetById(new Pagos() { id = id });
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
        /// CRUD de la entidad Pagos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  Pagos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Pagos</param>
        /// <response code="200">Pagos Creado</response>
        /// <response code="400">Pagos tiene valores invalidos </response>
        /// <response code="401">Pagos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Pagos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Pagos obj)
        {
            try
            {
                var result = new PagosMs().Add(obj);
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
        /// CRUD de la entidad Pagos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  Pagos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Pagos</param>
        /// <response code="200">Pagos Actualizado</response>
        /// <response code="400">Pagos tiene valores invalidos </response>
        /// <response code="401">Pagos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Pagos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Pagos obj)
        {
            try
            {
                var result = new PagosMs().Update(obj);
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
        /// CRUD de la entidad Pagos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  Pagos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Pagos</param>
        /// <response code="200">Pagos Eliminado</response>
        /// <response code="400">Pagos tiene valores invalidos </response>
        /// <response code="401">Pagos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Pagos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Pagos obj)
        {
           try
            {
                new PagosMs().Delete(obj);
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
        /// DataTable de la entidad Pagos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Pagos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Pagos</param>
        /// <response code="200">Pagos Resultado</response>
        /// <response code="400">Pagos tiene valores invalidos </response>
        /// <response code="401">Pagos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Pagos en este momento</response>
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

                var result = new PagosMs().GetAllByWithRelation().Cast<Pagos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Pagos>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderBy(p => p.ID_Contrato).Cast <Pagos>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderBy(p => p.sID_Contrato).Cast <Pagos>().ToList(); 
                 if (orderCriteria == "FechaPago") result = result.OrderBy(p => p.FechaPago).Cast <Pagos>().ToList(); 
                   if (orderCriteria == "ValorTotalPago") result = result.OrderBy(p => p.ValorTotalPago).Cast <Pagos>().ToList(); 
                   if (orderCriteria == "MesPago") result = result.OrderBy(p => p.MesPago).Cast <Pagos>().ToList(); 
                 if (orderCriteria == "ID_TiposEstadosPago") result = result.OrderBy(p => p.ID_TiposEstadosPago).Cast <Pagos>().ToList(); 
                 if (orderCriteria == "sID_TiposEstadoPagos") result = result.OrderBy(p => p.sID_TiposEstadosPago).Cast <Pagos>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Pagos>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderByDescending(p => p.ID_Contrato).Cast <Pagos>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderByDescending(p => p.sID_Contrato).Cast<Pagos>().ToList(); 
                 if (orderCriteria == "FechaPago") result = result.OrderByDescending(p => p.FechaPago).Cast <Pagos>().ToList(); 
                   if (orderCriteria == "ValorTotalPago") result = result.OrderByDescending(p => p.ValorTotalPago).Cast <Pagos>().ToList(); 
                   if (orderCriteria == "MesPago") result = result.OrderByDescending(p => p.MesPago).Cast <Pagos>().ToList(); 
                 if (orderCriteria == "ID_TiposEstadosPago") result = result.OrderByDescending(p => p.ID_TiposEstadosPago).Cast <Pagos>().ToList(); 
                 if (orderCriteria == "sID_TiposEstadoPagos") result = result.OrderByDescending(p => p.sID_TiposEstadosPago).Cast<Pagos>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Contrato != null && r.ID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Contrato != null && r.sID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaPago != null && r.FechaPago.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ValorTotalPago != null && r.ValorTotalPago.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.MesPago != null && r.MesPago.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TiposEstadosPago != null && r.ID_TiposEstadosPago.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TiposEstadosPago != null && r.sID_TiposEstadosPago.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad Pagos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  Pagos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Pagos</param>
        /// <response code="200">Pagos Consulto los registros exitosamente</response>
        /// <response code="400">Pagos tiene valores invalidos </response>
        /// <response code="401">Pagos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Pagos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new PagosMs().GetAllByWithRelation().Cast<Pagos>().AsQueryable();
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
