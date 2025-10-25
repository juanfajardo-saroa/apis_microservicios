/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano				:2023
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

namespace SISPAE_API_Configuracion.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de ExcedentesComplementos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class ExcedentesComplementosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad ExcedentesComplementos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Configuracion de la entidad  ExcedentesComplementos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ExcedentesComplementos</param>
        /// <response code="200">ExcedentesComplementos Consulto los registros exitosamente</response>
        /// <response code="400">ExcedentesComplementos tiene valores invalidos </response>
        /// <response code="401">ExcedentesComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ExcedentesComplementos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new ExcedentesComplementosMs().GetAll().Cast<ExcedentesComplementos>().AsQueryable();
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
        /// CRUD de la entidad ExcedentesComplementos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Configuracion de la entidad  ExcedentesComplementos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ExcedentesComplementos</param>
        /// <response code="200">ExcedentesComplementos Consulto los registros exitosamente</response>
        /// <response code="400">ExcedentesComplementos tiene valores invalidos </response>
        /// <response code="401">ExcedentesComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ExcedentesComplementos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new ExcedentesComplementosMs().GetAllFull().Cast<ExcedentesComplementos>().AsQueryable();
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
        /// CRUD de la entidad ExcedentesComplementos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Configuracion de la entidad  ExcedentesComplementos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ExcedentesComplementos</param>
        /// <response code="200">ExcedentesComplementos Consulto los registros exitosamente</response>
        /// <response code="400">ExcedentesComplementos tiene valores invalidos </response>
        /// <response code="401">ExcedentesComplementos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar ExcedentesComplementos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new ExcedentesComplementosMs().GetById(new ExcedentesComplementos() { id = id });
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
        /// CRUD de la entidad ExcedentesComplementos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Configuracion de la entidad  ExcedentesComplementos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de ExcedentesComplementos</param>
        /// <response code="200">ExcedentesComplementos Creado</response>
        /// <response code="400">ExcedentesComplementos tiene valores invalidos </response>
        /// <response code="401">ExcedentesComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear ExcedentesComplementos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] ExcedentesComplementos obj)
        {
            try

            {
                var result = new ExcedentesComplementosMs().Add(obj);
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
        /// CRUD de la entidad ExcedentesComplementos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Configuracion de la entidad  ExcedentesComplementos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de ExcedentesComplementos</param>
        /// <response code="200">ExcedentesComplementos Actualizado</response>
        /// <response code="400">ExcedentesComplementos tiene valores invalidos </response>
        /// <response code="401">ExcedentesComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar ExcedentesComplementos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] ExcedentesComplementos obj)
        {
            try
            {
                var result = new ExcedentesComplementosMs().Update(obj);
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
        /// CRUD de la entidad ExcedentesComplementos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Configuracion de la entidad  ExcedentesComplementos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de ExcedentesComplementos</param>
        /// <response code="200">ExcedentesComplementos Eliminado</response>
        /// <response code="400">ExcedentesComplementos tiene valores invalidos </response>
        /// <response code="401">ExcedentesComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar ExcedentesComplementos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] ExcedentesComplementos obj)
        {
           try
            {
                new ExcedentesComplementosMs().Delete(obj);
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
        /// DataTable de la entidad ExcedentesComplementos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  ExcedentesComplementos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de ExcedentesComplementos</param>
        /// <response code="200">ExcedentesComplementos Resultado</response>
        /// <response code="400">ExcedentesComplementos tiene valores invalidos </response>
        /// <response code="401">ExcedentesComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  ExcedentesComplementos en este momento</response>
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

                var result = new ExcedentesComplementosMs().GetAllByWithRelation().Cast<ExcedentesComplementos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <ExcedentesComplementos>().ToList();  
                if (orderCriteria == "ID_Comite") result = result.OrderBy(p => p.ID_Comite).Cast <ExcedentesComplementos>().ToList(); 
                 if (orderCriteria == "sID_Comite") result = result.OrderBy(p => p.sID_Comite).Cast <ExcedentesComplementos>().ToList(); 
                 if (orderCriteria == "ID_GradoSedeJornada") result = result.OrderBy(p => p.ID_GradoSedeJornada).Cast <ExcedentesComplementos>().ToList(); 
                 if (orderCriteria == "sID_GradosSedesJornadas") result = result.OrderBy(p => p.sID_GradoSedeJornada).Cast <ExcedentesComplementos>().ToList(); 
                 if (orderCriteria == "ID_TipoDestinoComplemento") result = result.OrderBy(p => p.ID_TipoDestinoComplemento).Cast <ExcedentesComplementos>().ToList(); 
                 if (orderCriteria == "sID_TiposDestinosComplementos") result = result.OrderBy(p => p.sID_TipoDestinoComplemento).Cast <ExcedentesComplementos>().ToList(); 
                 if (orderCriteria == "FechaReporte") result = result.OrderBy(p => p.FechaReporte).Cast <ExcedentesComplementos>().ToList(); 
                 if (orderCriteria == "CantExcedentes") result = result.OrderBy(p => p.CantExcedentes).Cast <ExcedentesComplementos>().ToList(); 
                     if (orderCriteria == "Id_TipoEstadoExcedentesComplementos") result = result.OrderBy(p => p.Id_TipoEstadoExcedentesComplementos).Cast <ExcedentesComplementos>().ToList(); 
                 if (orderCriteria == "sID_TipoEstadoExcedentesComplementos") result = result.OrderBy(p => p.sId_TipoEstadoExcedentesComplementos).Cast <ExcedentesComplementos>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <ExcedentesComplementos>().ToList();  
                if (orderCriteria == "ID_Comite") result = result.OrderByDescending(p => p.ID_Comite).Cast <ExcedentesComplementos>().ToList(); 
                 if (orderCriteria == "sID_Comite") result = result.OrderByDescending(p => p.sID_Comite).Cast<ExcedentesComplementos>().ToList(); 
                 if (orderCriteria == "ID_GradoSedeJornada") result = result.OrderByDescending(p => p.ID_GradoSedeJornada).Cast <ExcedentesComplementos>().ToList(); 
                 if (orderCriteria == "sID_GradosSedesJornadas") result = result.OrderByDescending(p => p.sID_GradoSedeJornada).Cast<ExcedentesComplementos>().ToList(); 
                 if (orderCriteria == "ID_TipoDestinoComplemento") result = result.OrderByDescending(p => p.ID_TipoDestinoComplemento).Cast <ExcedentesComplementos>().ToList(); 
                 if (orderCriteria == "sID_TiposDestinosComplementos") result = result.OrderByDescending(p => p.sID_TipoDestinoComplemento).Cast<ExcedentesComplementos>().ToList(); 
                 if (orderCriteria == "FechaReporte") result = result.OrderByDescending(p => p.FechaReporte).Cast <ExcedentesComplementos>().ToList(); 
                 if (orderCriteria == "CantExcedentes") result = result.OrderByDescending(p => p.CantExcedentes).Cast <ExcedentesComplementos>().ToList(); 
                     if (orderCriteria == "Id_TipoEstadoExcedentesComplementos") result = result.OrderByDescending(p => p.Id_TipoEstadoExcedentesComplementos).Cast <ExcedentesComplementos>().ToList(); 
                 if (orderCriteria == "sID_TipoEstadoExcedentesComplementos") result = result.OrderByDescending(p => p.sId_TipoEstadoExcedentesComplementos).Cast<ExcedentesComplementos>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Comite != null && r.ID_Comite.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Comite != null && r.sID_Comite.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_GradoSedeJornada != null && r.ID_GradoSedeJornada.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_GradoSedeJornada != null && r.sID_GradoSedeJornada.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoDestinoComplemento != null && r.ID_TipoDestinoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoDestinoComplemento != null && r.sID_TipoDestinoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaReporte != null && r.FechaReporte.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CantExcedentes != null && r.CantExcedentes.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                     || r.Id_TipoEstadoExcedentesComplementos != null && r.Id_TipoEstadoExcedentesComplementos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                || r.sId_TipoEstadoExcedentesComplementos != null && r.sId_TipoEstadoExcedentesComplementos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
  
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
        /// CRUD de la entidad ExcedentesComplementos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Configuracion de la entidad  ExcedentesComplementos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ExcedentesComplementos</param>
        /// <response code="200">ExcedentesComplementos Consulto los registros exitosamente</response>
        /// <response code="400">ExcedentesComplementos tiene valores invalidos </response>
        /// <response code="401">ExcedentesComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ExcedentesComplementos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new ExcedentesComplementosMs().GetAllByWithRelation().Cast<ExcedentesComplementos>().AsQueryable();
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
