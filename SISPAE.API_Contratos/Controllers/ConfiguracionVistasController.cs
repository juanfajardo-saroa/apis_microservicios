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

namespace SISPAE_API_Contratos.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de ConfiguracionVistas .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class ConfiguracionVistasController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad ConfiguracionVistas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  ConfiguracionVistas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ConfiguracionVistas</param>
        /// <response code="200">ConfiguracionVistas Consulto los registros exitosamente</response>
        /// <response code="400">ConfiguracionVistas tiene valores invalidos </response>
        /// <response code="401">ConfiguracionVistas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ConfiguracionVistas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new ConfiguracionVistasMs().GetAll().Cast<ConfiguracionVistas>().AsQueryable();
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
        /// CRUD de la entidad ConfiguracionVistas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  ConfiguracionVistas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ConfiguracionVistas</param>
        /// <response code="200">ConfiguracionVistas Consulto los registros exitosamente</response>
        /// <response code="400">ConfiguracionVistas tiene valores invalidos </response>
        /// <response code="401">ConfiguracionVistas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ConfiguracionVistas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new ConfiguracionVistasMs().GetAllFull().Cast<ConfiguracionVistas>().AsQueryable();
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
        /// CRUD de la entidad ConfiguracionVistas --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  ConfiguracionVistas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ConfiguracionVistas</param>
        /// <response code="200">ConfiguracionVistas Consulto los registros exitosamente</response>
        /// <response code="400">ConfiguracionVistas tiene valores invalidos </response>
        /// <response code="401">ConfiguracionVistas No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar ConfiguracionVistas en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new ConfiguracionVistasMs().GetById(new ConfiguracionVistas() { id = id });
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
        /// CRUD de la entidad ConfiguracionVistas --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  ConfiguracionVistas!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de ConfiguracionVistas</param>
        /// <response code="200">ConfiguracionVistas Creado</response>
        /// <response code="400">ConfiguracionVistas tiene valores invalidos </response>
        /// <response code="401">ConfiguracionVistas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear ConfiguracionVistas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] ConfiguracionVistas obj)
        {
            try
            {
                var result = new ConfiguracionVistasMs().Add(obj);
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
        /// CRUD de la entidad ConfiguracionVistas --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  ConfiguracionVistas!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de ConfiguracionVistas</param>
        /// <response code="200">ConfiguracionVistas Actualizado</response>
        /// <response code="400">ConfiguracionVistas tiene valores invalidos </response>
        /// <response code="401">ConfiguracionVistas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar ConfiguracionVistas en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] ConfiguracionVistas obj)
        {
            try
            {
                var result = new ConfiguracionVistasMs().Update(obj);
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
        /// CRUD de la entidad ConfiguracionVistas --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  ConfiguracionVistas!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de ConfiguracionVistas</param>
        /// <response code="200">ConfiguracionVistas Eliminado</response>
        /// <response code="400">ConfiguracionVistas tiene valores invalidos </response>
        /// <response code="401">ConfiguracionVistas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar ConfiguracionVistas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] ConfiguracionVistas obj)
        {
           try
            {
                new ConfiguracionVistasMs().Delete(obj);
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
        /// DataTable de la entidad ConfiguracionVistas --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  ConfiguracionVistas!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de ConfiguracionVistas</param>
        /// <response code="200">ConfiguracionVistas Resultado</response>
        /// <response code="400">ConfiguracionVistas tiene valores invalidos </response>
        /// <response code="401">ConfiguracionVistas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  ConfiguracionVistas en este momento</response>
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

                var result = new ConfiguracionVistasMs().GetAllByWithRelation().Cast<ConfiguracionVistas>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <ConfiguracionVistas>().ToList();  
                if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "TipoContratoId") result = result.OrderBy(p => p.TipoContratoId).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "SubTipoContratoId") result = result.OrderBy(p => p.SubTipoContratoId).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion1") result = result.OrderBy(p => p.Seccion1).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion2") result = result.OrderBy(p => p.Seccion2).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion3") result = result.OrderBy(p => p.Seccion3).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion4") result = result.OrderBy(p => p.Seccion4).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion5") result = result.OrderBy(p => p.Seccion5).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion6") result = result.OrderBy(p => p.Seccion6).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion7") result = result.OrderBy(p => p.Seccion7).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion8") result = result.OrderBy(p => p.Seccion8).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion9") result = result.OrderBy(p => p.Seccion9).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion10") result = result.OrderBy(p => p.Seccion10).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion11") result = result.OrderBy(p => p.Seccion11).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion12") result = result.OrderBy(p => p.Seccion12).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion13") result = result.OrderBy(p => p.Seccion13).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion14") result = result.OrderBy(p => p.Seccion14).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion15") result = result.OrderBy(p => p.Seccion15).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion16") result = result.OrderBy(p => p.Seccion16).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec1") result = result.OrderBy(p => p.NumSec1).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec2") result = result.OrderBy(p => p.NumSec2).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec3") result = result.OrderBy(p => p.NumSec3).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec4") result = result.OrderBy(p => p.NumSec4).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec5") result = result.OrderBy(p => p.NumSec5).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec6") result = result.OrderBy(p => p.NumSec6).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec7") result = result.OrderBy(p => p.NumSec7).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec8") result = result.OrderBy(p => p.NumSec8).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec9") result = result.OrderBy(p => p.NumSec9).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec10") result = result.OrderBy(p => p.NumSec10).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec11") result = result.OrderBy(p => p.NumSec11).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec12") result = result.OrderBy(p => p.NumSec12).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec13") result = result.OrderBy(p => p.NumSec13).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec14") result = result.OrderBy(p => p.NumSec14).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec15") result = result.OrderBy(p => p.NumSec15).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec16") result = result.OrderBy(p => p.NumSec16).Cast <ConfiguracionVistas>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <ConfiguracionVistas>().ToList();  
                if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "TipoContratoId") result = result.OrderByDescending(p => p.TipoContratoId).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "SubTipoContratoId") result = result.OrderByDescending(p => p.SubTipoContratoId).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion1") result = result.OrderByDescending(p => p.Seccion1).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion2") result = result.OrderByDescending(p => p.Seccion2).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion3") result = result.OrderByDescending(p => p.Seccion3).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion4") result = result.OrderByDescending(p => p.Seccion4).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion5") result = result.OrderByDescending(p => p.Seccion5).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion6") result = result.OrderByDescending(p => p.Seccion6).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion7") result = result.OrderByDescending(p => p.Seccion7).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion8") result = result.OrderByDescending(p => p.Seccion8).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion9") result = result.OrderByDescending(p => p.Seccion9).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion10") result = result.OrderByDescending(p => p.Seccion10).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion11") result = result.OrderByDescending(p => p.Seccion11).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion12") result = result.OrderByDescending(p => p.Seccion12).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion13") result = result.OrderByDescending(p => p.Seccion13).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion14") result = result.OrderByDescending(p => p.Seccion14).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion15") result = result.OrderByDescending(p => p.Seccion15).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "Seccion16") result = result.OrderByDescending(p => p.Seccion16).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec1") result = result.OrderByDescending(p => p.NumSec1).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec2") result = result.OrderByDescending(p => p.NumSec2).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec3") result = result.OrderByDescending(p => p.NumSec3).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec4") result = result.OrderByDescending(p => p.NumSec4).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec5") result = result.OrderByDescending(p => p.NumSec5).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec6") result = result.OrderByDescending(p => p.NumSec6).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec7") result = result.OrderByDescending(p => p.NumSec7).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec8") result = result.OrderByDescending(p => p.NumSec8).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec9") result = result.OrderByDescending(p => p.NumSec9).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec10") result = result.OrderByDescending(p => p.NumSec10).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec11") result = result.OrderByDescending(p => p.NumSec11).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec12") result = result.OrderByDescending(p => p.NumSec12).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec13") result = result.OrderByDescending(p => p.NumSec13).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec14") result = result.OrderByDescending(p => p.NumSec14).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec15") result = result.OrderByDescending(p => p.NumSec15).Cast <ConfiguracionVistas>().ToList(); 
                 if (orderCriteria == "NumSec16") result = result.OrderByDescending(p => p.NumSec16).Cast <ConfiguracionVistas>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TipoContratoId != null && r.TipoContratoId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.SubTipoContratoId != null && r.SubTipoContratoId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Seccion1 != null && r.Seccion1.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Seccion2 != null && r.Seccion2.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Seccion3 != null && r.Seccion3.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Seccion4 != null && r.Seccion4.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Seccion5 != null && r.Seccion5.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Seccion6 != null && r.Seccion6.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Seccion7 != null && r.Seccion7.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Seccion8 != null && r.Seccion8.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Seccion9 != null && r.Seccion9.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Seccion10 != null && r.Seccion10.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Seccion11 != null && r.Seccion11.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Seccion12 != null && r.Seccion12.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Seccion13 != null && r.Seccion13.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Seccion14 != null && r.Seccion14.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Seccion15 != null && r.Seccion15.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Seccion16 != null && r.Seccion16.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumSec1 != null && r.NumSec1.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumSec2 != null && r.NumSec2.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumSec3 != null && r.NumSec3.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumSec4 != null && r.NumSec4.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumSec5 != null && r.NumSec5.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumSec6 != null && r.NumSec6.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumSec7 != null && r.NumSec7.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumSec8 != null && r.NumSec8.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumSec9 != null && r.NumSec9.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumSec10 != null && r.NumSec10.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumSec11 != null && r.NumSec11.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumSec12 != null && r.NumSec12.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumSec13 != null && r.NumSec13.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumSec14 != null && r.NumSec14.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumSec15 != null && r.NumSec15.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumSec16 != null && r.NumSec16.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
        /// CRUD de la entidad ConfiguracionVistas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  ConfiguracionVistas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ConfiguracionVistas</param>
        /// <response code="200">ConfiguracionVistas Consulto los registros exitosamente</response>
        /// <response code="400">ConfiguracionVistas tiene valores invalidos </response>
        /// <response code="401">ConfiguracionVistas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ConfiguracionVistas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new ConfiguracionVistasMs().GetAllByWithRelation().Cast<ConfiguracionVistas>().AsQueryable();
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
