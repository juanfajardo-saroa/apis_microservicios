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
    [SwaggerTag("Web API para CRUD de DescuentosPagos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class DescuentosPagosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad DescuentosPagos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  DescuentosPagos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DescuentosPagos</param>
        /// <response code="200">DescuentosPagos Consulto los registros exitosamente</response>
        /// <response code="400">DescuentosPagos tiene valores invalidos </response>
        /// <response code="401">DescuentosPagos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DescuentosPagos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new DescuentosPagosMs().GetAll().Cast<DescuentosPagos>().AsQueryable();
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
        /// CRUD de la entidad DescuentosPagos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  DescuentosPagos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DescuentosPagos</param>
        /// <response code="200">DescuentosPagos Consulto los registros exitosamente</response>
        /// <response code="400">DescuentosPagos tiene valores invalidos </response>
        /// <response code="401">DescuentosPagos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DescuentosPagos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new DescuentosPagosMs().GetAllFull().Cast<DescuentosPagos>().AsQueryable();
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
        /// CRUD de la entidad DescuentosPagos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  DescuentosPagos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DescuentosPagos</param>
        /// <response code="200">DescuentosPagos Consulto los registros exitosamente</response>
        /// <response code="400">DescuentosPagos tiene valores invalidos </response>
        /// <response code="401">DescuentosPagos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar DescuentosPagos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new DescuentosPagosMs().GetById(new DescuentosPagos() { id = id });
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
        /// CRUD de la entidad DescuentosPagos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  DescuentosPagos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de DescuentosPagos</param>
        /// <response code="200">DescuentosPagos Creado</response>
        /// <response code="400">DescuentosPagos tiene valores invalidos </response>
        /// <response code="401">DescuentosPagos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear DescuentosPagos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] DescuentosPagos obj)
        {
            try
            {
                var result = new DescuentosPagosMs().Add(obj);
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
        /// CRUD de la entidad DescuentosPagos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  DescuentosPagos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de DescuentosPagos</param>
        /// <response code="200">DescuentosPagos Actualizado</response>
        /// <response code="400">DescuentosPagos tiene valores invalidos </response>
        /// <response code="401">DescuentosPagos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar DescuentosPagos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] DescuentosPagos obj)
        {
            try
            {
                var result = new DescuentosPagosMs().Update(obj);
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
        /// CRUD de la entidad DescuentosPagos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  DescuentosPagos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de DescuentosPagos</param>
        /// <response code="200">DescuentosPagos Eliminado</response>
        /// <response code="400">DescuentosPagos tiene valores invalidos </response>
        /// <response code="401">DescuentosPagos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar DescuentosPagos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] DescuentosPagos obj)
        {
           try
            {
                new DescuentosPagosMs().Delete(obj);
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
        /// DataTable de la entidad DescuentosPagos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  DescuentosPagos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de DescuentosPagos</param>
        /// <response code="200">DescuentosPagos Resultado</response>
        /// <response code="400">DescuentosPagos tiene valores invalidos </response>
        /// <response code="401">DescuentosPagos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  DescuentosPagos en este momento</response>
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

                var result = new DescuentosPagosMs().GetAllByWithRelation().Cast<DescuentosPagos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <DescuentosPagos>().ToList();  
                if (orderCriteria == "ID_TipoDescuento") result = result.OrderBy(p => p.ID_TipoDescuento).Cast <DescuentosPagos>().ToList(); 
                 if (orderCriteria == "sID_TipoDescuento") result = result.OrderBy(p => p.sID_TipoDescuento).Cast <DescuentosPagos>().ToList(); 
                 if (orderCriteria == "Valor") result = result.OrderBy(p => p.Valor).Cast <DescuentosPagos>().ToList(); 
                 if (orderCriteria == "ID_Pagos") result = result.OrderBy(p => p.ID_Pagos).Cast <DescuentosPagos>().ToList(); 
                 if (orderCriteria == "sID_Pagos") result = result.OrderBy(p => p.sID_Pagos).Cast <DescuentosPagos>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <DescuentosPagos>().ToList();  
                if (orderCriteria == "ID_TipoDescuento") result = result.OrderByDescending(p => p.ID_TipoDescuento).Cast <DescuentosPagos>().ToList(); 
                 if (orderCriteria == "sID_TipoDescuento") result = result.OrderByDescending(p => p.sID_TipoDescuento).Cast<DescuentosPagos>().ToList(); 
                 if (orderCriteria == "Valor") result = result.OrderByDescending(p => p.Valor).Cast <DescuentosPagos>().ToList(); 
                 if (orderCriteria == "ID_Pagos") result = result.OrderByDescending(p => p.ID_Pagos).Cast <DescuentosPagos>().ToList(); 
                 if (orderCriteria == "sID_Pagos") result = result.OrderByDescending(p => p.sID_Pagos).Cast<DescuentosPagos>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoDescuento != null && r.ID_TipoDescuento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoDescuento != null && r.sID_TipoDescuento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Valor != null && r.Valor.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Pagos != null && r.ID_Pagos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Pagos != null && r.sID_Pagos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad DescuentosPagos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  DescuentosPagos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DescuentosPagos</param>
        /// <response code="200">DescuentosPagos Consulto los registros exitosamente</response>
        /// <response code="400">DescuentosPagos tiene valores invalidos </response>
        /// <response code="401">DescuentosPagos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DescuentosPagos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new DescuentosPagosMs().GetAllByWithRelation().Cast<DescuentosPagos>().AsQueryable();
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
