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

namespace SISPAE_API_Seguimiento.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de SemanaEntregaRaciones .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class SemanaEntregaRacionesController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad SemanaEntregaRaciones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE2_API_Seguimiento de la entidad  SemanaEntregaRaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de SemanaEntregaRaciones</param>
        /// <response code="200">SemanaEntregaRaciones Consulto los registros exitosamente</response>
        /// <response code="400">SemanaEntregaRaciones tiene valores invalidos </response>
        /// <response code="401">SemanaEntregaRaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar SemanaEntregaRaciones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new SemanaEntregaComplementosMs().GetAll().Cast<SemanaEntregaRaciones>().AsQueryable();
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
        /// CRUD de la entidad SemanaEntregaRaciones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE2_API_Seguimiento de la entidad  SemanaEntregaRaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de SemanaEntregaRaciones</param>
        /// <response code="200">SemanaEntregaRaciones Consulto los registros exitosamente</response>
        /// <response code="400">SemanaEntregaRaciones tiene valores invalidos </response>
        /// <response code="401">SemanaEntregaRaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar SemanaEntregaRaciones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new SemanaEntregaComplementosMs().GetAllFull().Cast<SemanaEntregaRaciones>().AsQueryable();
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
        /// CRUD de la entidad SemanaEntregaRaciones --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE2_API_Seguimiento de la entidad  SemanaEntregaRaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de SemanaEntregaRaciones</param>
        /// <response code="200">SemanaEntregaRaciones Consulto los registros exitosamente</response>
        /// <response code="400">SemanaEntregaRaciones tiene valores invalidos </response>
        /// <response code="401">SemanaEntregaRaciones No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar SemanaEntregaRaciones en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new SemanaEntregaComplementosMs().GetById(new SemanaEntregaRaciones() { id = id });
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
        /// CRUD de la entidad SemanaEntregaRaciones --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE2_API_Seguimiento de la entidad  SemanaEntregaRaciones!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de SemanaEntregaRaciones</param>
        /// <response code="200">SemanaEntregaRaciones Creado</response>
        /// <response code="400">SemanaEntregaRaciones tiene valores invalidos </response>
        /// <response code="401">SemanaEntregaRaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear SemanaEntregaRaciones en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] SemanaEntregaRaciones obj)
        {
            try
            {
                var result = new SemanaEntregaComplementosMs().Add(obj);
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
        /// CRUD de la entidad SemanaEntregaRaciones --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE2_API_Seguimiento de la entidad  SemanaEntregaRaciones!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de SemanaEntregaRaciones</param>
        /// <response code="200">SemanaEntregaRaciones Actualizado</response>
        /// <response code="400">SemanaEntregaRaciones tiene valores invalidos </response>
        /// <response code="401">SemanaEntregaRaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar SemanaEntregaRaciones en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] SemanaEntregaRaciones obj)
        {
            try
            {
                var result = new SemanaEntregaComplementosMs().Update(obj);
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
        /// CRUD de la entidad SemanaEntregaRaciones --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE2_API_Seguimiento de la entidad  SemanaEntregaRaciones!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de SemanaEntregaRaciones</param>
        /// <response code="200">SemanaEntregaRaciones Eliminado</response>
        /// <response code="400">SemanaEntregaRaciones tiene valores invalidos </response>
        /// <response code="401">SemanaEntregaRaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar SemanaEntregaRaciones en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] SemanaEntregaRaciones obj)
        {
           try
            {
                new SemanaEntregaComplementosMs().Delete(obj);
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
        /// DataTable de la entidad SemanaEntregaRaciones --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  SemanaEntregaRaciones!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de SemanaEntregaRaciones</param>
        /// <response code="200">SemanaEntregaRaciones Resultado</response>
        /// <response code="400">SemanaEntregaRaciones tiene valores invalidos </response>
        /// <response code="401">SemanaEntregaRaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  SemanaEntregaRaciones en este momento</response>
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

                var result = new SemanaEntregaComplementosMs().GetAllByWithRelation().Cast<SemanaEntregaRaciones>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                  if (orderAscendingDirection)                  {                  if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <SemanaEntregaRaciones>().ToList();  
                  if (orderCriteria == "ID_EstadoSemana") result = result.OrderBy(p => p.ID_EstadoSemana).Cast <SemanaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "sID_EstadoSemana") result = result.OrderBy(p => p.sID_EstadoSemana).Cast <SemanaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "ID_Contrato") result = result.OrderBy(p => p.ID_Contrato).Cast <SemanaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "sID_Contratos") result = result.OrderBy(p => p.sID_Contrato).Cast <SemanaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "ID_GradoSedeJornada") result = result.OrderBy(p => p.ID_GradoSedeJornada).Cast <SemanaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "sID_GradosSedesJornadas") result = result.OrderBy(p => p.sID_GradoSedeJornada).Cast <SemanaEntregaRaciones>().ToList(); 
                     if (orderCriteria == "pathReporteSemanal") result = result.OrderBy(p => p.pathReporteSemanal).Cast <SemanaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "fechaCarga") result = result.OrderBy(p => p.fechaCarga).Cast <SemanaEntregaRaciones>().ToList(); 
                   }
  else 
                    {                  if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <SemanaEntregaRaciones>().ToList();  
                  if (orderCriteria == "ID_EstadoSemana") result = result.OrderByDescending(p => p.ID_EstadoSemana).Cast <SemanaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "sID_EstadoSemana") result = result.OrderByDescending(p => p.sID_EstadoSemana).Cast<SemanaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "ID_Contrato") result = result.OrderByDescending(p => p.ID_Contrato).Cast <SemanaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "sID_Contratos") result = result.OrderByDescending(p => p.sID_Contrato).Cast<SemanaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "ID_GradoSedeJornada") result = result.OrderByDescending(p => p.ID_GradoSedeJornada).Cast <SemanaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "sID_GradosSedesJornadas") result = result.OrderByDescending(p => p.sID_GradoSedeJornada).Cast<SemanaEntregaRaciones>().ToList(); 
                     if (orderCriteria == "pathReporteSemanal") result = result.OrderByDescending(p => p.pathReporteSemanal).Cast <SemanaEntregaRaciones>().ToList(); 
                   if (orderCriteria == "fechaCarga") result = result.OrderByDescending(p => p.fechaCarga).Cast <SemanaEntregaRaciones>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                   || r.ID_EstadoSemana != null && r.ID_EstadoSemana.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_EstadoSemana != null && r.sID_EstadoSemana.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_Contrato != null && r.ID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_Contrato != null && r.sID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_GradoSedeJornada != null && r.ID_GradoSedeJornada.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_GradoSedeJornada != null && r.sID_GradoSedeJornada.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                     || r.pathReporteSemanal != null && r.pathReporteSemanal.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.fechaCarga != null && r.fechaCarga.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
        /// CRUD de la entidad SemanaEntregaRaciones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE2_API_Seguimiento de la entidad  SemanaEntregaRaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de SemanaEntregaRaciones</param>
        /// <response code="200">SemanaEntregaRaciones Consulto los registros exitosamente</response>
        /// <response code="400">SemanaEntregaRaciones tiene valores invalidos </response>
        /// <response code="401">SemanaEntregaRaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar SemanaEntregaRaciones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new SemanaEntregaComplementosMs().GetAllByWithRelation().Cast<SemanaEntregaRaciones>().AsQueryable();
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
