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

namespace SISPAE_API_GestionExcedentes.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de Comite .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class ComiteController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Comite --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_GestionExcedentes de la entidad  Comite!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Comite</param>
        /// <response code="200">Comite Consulto los registros exitosamente</response>
        /// <response code="400">Comite tiene valores invalidos </response>
        /// <response code="401">Comite No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Comite en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new ComiteMs().GetAll().Cast<Comite>().AsQueryable();
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
        /// CRUD de la entidad Comite --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_GestionExcedentes de la entidad  Comite!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Comite</param>
        /// <response code="200">Comite Consulto los registros exitosamente</response>
        /// <response code="400">Comite tiene valores invalidos </response>
        /// <response code="401">Comite No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Comite en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new ComiteMs().GetAllFull().Cast<Comite>().AsQueryable();
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
        /// CRUD de la entidad Comite --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_GestionExcedentes de la entidad  Comite!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Comite</param>
        /// <response code="200">Comite Consulto los registros exitosamente</response>
        /// <response code="400">Comite tiene valores invalidos </response>
        /// <response code="401">Comite No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Comite en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new ComiteMs().GetById(new Comite() { id = id });
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
        /// CRUD de la entidad Comite --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_GestionExcedentes de la entidad  Comite!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Comite</param>
        /// <response code="200">Comite Creado</response>
        /// <response code="400">Comite tiene valores invalidos </response>
        /// <response code="401">Comite No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Comite en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Comite obj)
        {
            try
            {
                var result = new ComiteMs().Add(obj);
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
        /// CRUD de la entidad Comite --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_GestionExcedentes de la entidad  Comite!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Comite</param>
        /// <response code="200">Comite Actualizado</response>
        /// <response code="400">Comite tiene valores invalidos </response>
        /// <response code="401">Comite No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Comite en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Comite obj)
        {
            try
            {
                var result = new ComiteMs().Update(obj);
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
        /// CRUD de la entidad Comite --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_GestionExcedentes de la entidad  Comite!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Comite</param>
        /// <response code="200">Comite Eliminado</response>
        /// <response code="400">Comite tiene valores invalidos </response>
        /// <response code="401">Comite No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Comite en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Comite obj)
        {
           try
            {
                new ComiteMs().Delete(obj);
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
        /// DataTable de la entidad Comite --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Comite!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Comite</param>
        /// <response code="200">Comite Resultado</response>
        /// <response code="400">Comite tiene valores invalidos </response>
        /// <response code="401">Comite No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Comite en este momento</response>
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

                var result = new ComiteMs().GetAllByWithRelation().Cast<Comite>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Comite>().ToList();  
                if (orderCriteria == "ID_lE") result = result.OrderBy(p => p.ID_lE).Cast <Comite>().ToList(); 
                 if (orderCriteria == "sID_InstitucionEducativa") result = result.OrderBy(p => p.sID_lE).Cast <Comite>().ToList(); 
                 if (orderCriteria == "ID_Rector") result = result.OrderBy(p => p.ID_Rector).Cast <Comite>().ToList(); 
                 if (orderCriteria == "sID_Rectores") result = result.OrderBy(p => p.sID_Rector).Cast <Comite>().ToList(); 
                 if (orderCriteria == "NombreComite") result = result.OrderBy(p => p.NombreComite).Cast <Comite>().ToList(); 
                 if (orderCriteria == "Fecha") result = result.OrderBy(p => p.Fecha).Cast <Comite>().ToList(); 
                 if (orderCriteria == "DecisionesTomadas") result = result.OrderBy(p => p.DecisionesTomadas).Cast <Comite>().ToList(); 
                 if (orderCriteria == "ActaFormalizacionPath") result = result.OrderBy(p => p.ActaFormalizacionPath).Cast <Comite>().ToList(); 
                 if (orderCriteria == "PlanTrabajoPath") result = result.OrderBy(p => p.PlanTrabajoPath).Cast <Comite>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Comite>().ToList();  
                if (orderCriteria == "ID_lE") result = result.OrderByDescending(p => p.ID_lE).Cast <Comite>().ToList(); 
                 if (orderCriteria == "sID_InstitucionEducativa") result = result.OrderByDescending(p => p.sID_lE).Cast<Comite>().ToList(); 
                 if (orderCriteria == "ID_Rector") result = result.OrderByDescending(p => p.ID_Rector).Cast <Comite>().ToList(); 
                 if (orderCriteria == "sID_Rectores") result = result.OrderByDescending(p => p.sID_Rector).Cast<Comite>().ToList(); 
                 if (orderCriteria == "NombreComite") result = result.OrderByDescending(p => p.NombreComite).Cast <Comite>().ToList(); 
                 if (orderCriteria == "Fecha") result = result.OrderByDescending(p => p.Fecha).Cast <Comite>().ToList(); 
                 if (orderCriteria == "DecisionesTomadas") result = result.OrderByDescending(p => p.DecisionesTomadas).Cast <Comite>().ToList(); 
                 if (orderCriteria == "ActaFormalizacionPath") result = result.OrderByDescending(p => p.ActaFormalizacionPath).Cast <Comite>().ToList(); 
                 if (orderCriteria == "PlanTrabajoPath") result = result.OrderByDescending(p => p.PlanTrabajoPath).Cast <Comite>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_lE != null && r.ID_lE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_lE != null && r.sID_lE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Rector != null && r.ID_Rector.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Rector != null && r.sID_Rector.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NombreComite != null && r.NombreComite.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Fecha != null && r.Fecha.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.DecisionesTomadas != null && r.DecisionesTomadas.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ActaFormalizacionPath != null && r.ActaFormalizacionPath.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PlanTrabajoPath != null && r.PlanTrabajoPath.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad Comite --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_GestionExcedentes de la entidad  Comite!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Comite</param>
        /// <response code="200">Comite Consulto los registros exitosamente</response>
        /// <response code="400">Comite tiene valores invalidos </response>
        /// <response code="401">Comite No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Comite en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new ComiteMs().GetAllByWithRelation().Cast<Comite>().AsQueryable();
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
