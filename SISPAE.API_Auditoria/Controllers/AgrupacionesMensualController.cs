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

namespace SISPAE_API_Auditoria.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de AgrupacionesMensual .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class AgrupacionesMensualController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad AgrupacionesMensual --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Auditoria de la entidad  AgrupacionesMensual!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AgrupacionesMensual</param>
        /// <response code="200">AgrupacionesMensual Consulto los registros exitosamente</response>
        /// <response code="400">AgrupacionesMensual tiene valores invalidos </response>
        /// <response code="401">AgrupacionesMensual No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AgrupacionesMensual en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new AgrupacionesMensualMs().GetAll().Cast<AgrupacionesMensual>().AsQueryable();
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
        /// CRUD de la entidad AgrupacionesMensual --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Auditoria de la entidad  AgrupacionesMensual!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AgrupacionesMensual</param>
        /// <response code="200">AgrupacionesMensual Consulto los registros exitosamente</response>
        /// <response code="400">AgrupacionesMensual tiene valores invalidos </response>
        /// <response code="401">AgrupacionesMensual No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AgrupacionesMensual en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new AgrupacionesMensualMs().GetAllFull().Cast<AgrupacionesMensual>().AsQueryable();
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
        /// CRUD de la entidad AgrupacionesMensual --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Auditoria de la entidad  AgrupacionesMensual!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AgrupacionesMensual</param>
        /// <response code="200">AgrupacionesMensual Consulto los registros exitosamente</response>
        /// <response code="400">AgrupacionesMensual tiene valores invalidos </response>
        /// <response code="401">AgrupacionesMensual No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar AgrupacionesMensual en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new AgrupacionesMensualMs().GetById(new AgrupacionesMensual() { id = id });
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
        /// CRUD de la entidad AgrupacionesMensual --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Auditoria de la entidad  AgrupacionesMensual!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de AgrupacionesMensual</param>
        /// <response code="200">AgrupacionesMensual Creado</response>
        /// <response code="400">AgrupacionesMensual tiene valores invalidos </response>
        /// <response code="401">AgrupacionesMensual No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear AgrupacionesMensual en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] AgrupacionesMensual obj)
        {
            try
            {
                var result = new AgrupacionesMensualMs().Add(obj);
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
        /// CRUD de la entidad AgrupacionesMensual --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Auditoria de la entidad  AgrupacionesMensual!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de AgrupacionesMensual</param>
        /// <response code="200">AgrupacionesMensual Actualizado</response>
        /// <response code="400">AgrupacionesMensual tiene valores invalidos </response>
        /// <response code="401">AgrupacionesMensual No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar AgrupacionesMensual en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] AgrupacionesMensual obj)
        {
            try
            {
                var result = new AgrupacionesMensualMs().Update(obj);
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
        /// CRUD de la entidad AgrupacionesMensual --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Auditoria de la entidad  AgrupacionesMensual!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de AgrupacionesMensual</param>
        /// <response code="200">AgrupacionesMensual Eliminado</response>
        /// <response code="400">AgrupacionesMensual tiene valores invalidos </response>
        /// <response code="401">AgrupacionesMensual No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar AgrupacionesMensual en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] AgrupacionesMensual obj)
        {
           try
            {
                new AgrupacionesMensualMs().Delete(obj);
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
        /// DataTable de la entidad AgrupacionesMensual --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  AgrupacionesMensual!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de AgrupacionesMensual</param>
        /// <response code="200">AgrupacionesMensual Resultado</response>
        /// <response code="400">AgrupacionesMensual tiene valores invalidos </response>
        /// <response code="401">AgrupacionesMensual No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  AgrupacionesMensual en este momento</response>
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

                var result = new AgrupacionesMensualMs().GetAllByWithRelation().Cast<AgrupacionesMensual>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <AgrupacionesMensual>().ToList();  
                if (orderCriteria == "ID_TipoEstadoValidacionEntrega") result = result.OrderBy(p => p.ID_TipoEstadoValidacionEntrega).Cast <AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "sID_TiposEstadoValidacionEntrega") result = result.OrderBy(p => p.sID_TipoEstadoValidacionEntrega).Cast <AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "ID_Rector") result = result.OrderBy(p => p.ID_Rector).Cast <AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "sID_Rectores") result = result.OrderBy(p => p.sID_Rector).Cast <AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "ID_SedeJornada") result = result.OrderBy(p => p.ID_SedeJornada).Cast <AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "sID_SedesJornada") result = result.OrderBy(p => p.sID_SedeJornada).Cast <AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "ID_Operador") result = result.OrderBy(p => p.ID_Operador).Cast <AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "sID_Operadores") result = result.OrderBy(p => p.sID_Operador).Cast <AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "ID_Contrato") result = result.OrderBy(p => p.ID_Contrato).Cast <AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderBy(p => p.sID_Contrato).Cast <AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "Mes") result = result.OrderBy(p => p.Mes).Cast <AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "SoporteEntrega") result = result.OrderBy(p => p.SoporteEntrega).Cast <AgrupacionesMensual>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <AgrupacionesMensual>().ToList();  
                if (orderCriteria == "ID_TipoEstadoValidacionEntrega") result = result.OrderByDescending(p => p.ID_TipoEstadoValidacionEntrega).Cast <AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "sID_TiposEstadoValidacionEntrega") result = result.OrderByDescending(p => p.sID_TipoEstadoValidacionEntrega).Cast<AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "ID_Rector") result = result.OrderByDescending(p => p.ID_Rector).Cast <AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "sID_Rectores") result = result.OrderByDescending(p => p.sID_Rector).Cast<AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "ID_SedeJornada") result = result.OrderByDescending(p => p.ID_SedeJornada).Cast <AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "sID_SedesJornada") result = result.OrderByDescending(p => p.sID_SedeJornada).Cast<AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "ID_Operador") result = result.OrderByDescending(p => p.ID_Operador).Cast <AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "sID_Operadores") result = result.OrderByDescending(p => p.sID_Operador).Cast<AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "ID_Contrato") result = result.OrderByDescending(p => p.ID_Contrato).Cast <AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderByDescending(p => p.sID_Contrato).Cast<AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "Mes") result = result.OrderByDescending(p => p.Mes).Cast <AgrupacionesMensual>().ToList(); 
                 if (orderCriteria == "SoporteEntrega") result = result.OrderByDescending(p => p.SoporteEntrega).Cast <AgrupacionesMensual>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoEstadoValidacionEntrega != null && r.ID_TipoEstadoValidacionEntrega.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoEstadoValidacionEntrega != null && r.sID_TipoEstadoValidacionEntrega.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Rector != null && r.ID_Rector.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Rector != null && r.sID_Rector.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_SedeJornada != null && r.ID_SedeJornada.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_SedeJornada != null && r.sID_SedeJornada.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Operador != null && r.ID_Operador.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Operador != null && r.sID_Operador.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Contrato != null && r.ID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Contrato != null && r.sID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Mes != null && r.Mes.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.SoporteEntrega != null && r.SoporteEntrega.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad AgrupacionesMensual --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Auditoria de la entidad  AgrupacionesMensual!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AgrupacionesMensual</param>
        /// <response code="200">AgrupacionesMensual Consulto los registros exitosamente</response>
        /// <response code="400">AgrupacionesMensual tiene valores invalidos </response>
        /// <response code="401">AgrupacionesMensual No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AgrupacionesMensual en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new AgrupacionesMensualMs().GetAllByWithRelation().Cast<AgrupacionesMensual>().AsQueryable();
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
