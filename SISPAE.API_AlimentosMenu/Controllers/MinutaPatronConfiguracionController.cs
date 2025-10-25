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

namespace SISPAE_API_AlimentosMenu.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de MinutaPatronConfiguracion .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class MinutaPatronConfiguracionController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad MinutaPatronConfiguracion --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaPatronConfiguracion!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaPatronConfiguracion</param>
        /// <response code="200">MinutaPatronConfiguracion Consulto los registros exitosamente</response>
        /// <response code="400">MinutaPatronConfiguracion tiene valores invalidos </response>
        /// <response code="401">MinutaPatronConfiguracion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaPatronConfiguracion en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new MinutaPatronConfiguracionMs().GetAll().Cast<MinutaPatronConfiguracion>().AsQueryable();
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
        /// CRUD de la entidad MinutaPatronConfiguracion --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaPatronConfiguracion!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaPatronConfiguracion</param>
        /// <response code="200">MinutaPatronConfiguracion Consulto los registros exitosamente</response>
        /// <response code="400">MinutaPatronConfiguracion tiene valores invalidos </response>
        /// <response code="401">MinutaPatronConfiguracion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaPatronConfiguracion en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new MinutaPatronConfiguracionMs().GetAllFull().Cast<MinutaPatronConfiguracion>().AsQueryable();
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
        /// CRUD de la entidad MinutaPatronConfiguracion --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaPatronConfiguracion!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaPatronConfiguracion</param>
        /// <response code="200">MinutaPatronConfiguracion Consulto los registros exitosamente</response>
        /// <response code="400">MinutaPatronConfiguracion tiene valores invalidos </response>
        /// <response code="401">MinutaPatronConfiguracion No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar MinutaPatronConfiguracion en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new MinutaPatronConfiguracionMs().GetById(new MinutaPatronConfiguracion() { id = id });
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
        /// CRUD de la entidad MinutaPatronConfiguracion --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaPatronConfiguracion!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de MinutaPatronConfiguracion</param>
        /// <response code="200">MinutaPatronConfiguracion Creado</response>
        /// <response code="400">MinutaPatronConfiguracion tiene valores invalidos </response>
        /// <response code="401">MinutaPatronConfiguracion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear MinutaPatronConfiguracion en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] MinutaPatronConfiguracion obj)
        {
            try
            {
                var result = new MinutaPatronConfiguracionMs().Add(obj);
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
        /// CRUD de la entidad MinutaPatronConfiguracion --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaPatronConfiguracion!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de MinutaPatronConfiguracion</param>
        /// <response code="200">MinutaPatronConfiguracion Actualizado</response>
        /// <response code="400">MinutaPatronConfiguracion tiene valores invalidos </response>
        /// <response code="401">MinutaPatronConfiguracion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar MinutaPatronConfiguracion en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] MinutaPatronConfiguracion obj)
        {
            try
            {
                var result = new MinutaPatronConfiguracionMs().Update(obj);
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
        /// CRUD de la entidad MinutaPatronConfiguracion --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaPatronConfiguracion!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de MinutaPatronConfiguracion</param>
        /// <response code="200">MinutaPatronConfiguracion Eliminado</response>
        /// <response code="400">MinutaPatronConfiguracion tiene valores invalidos </response>
        /// <response code="401">MinutaPatronConfiguracion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar MinutaPatronConfiguracion en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] MinutaPatronConfiguracion obj)
        {
           try
            {
                new MinutaPatronConfiguracionMs().Delete(obj);
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
        /// DataTable de la entidad MinutaPatronConfiguracion --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  MinutaPatronConfiguracion!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de MinutaPatronConfiguracion</param>
        /// <response code="200">MinutaPatronConfiguracion Resultado</response>
        /// <response code="400">MinutaPatronConfiguracion tiene valores invalidos </response>
        /// <response code="401">MinutaPatronConfiguracion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  MinutaPatronConfiguracion en este momento</response>
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

                var result = new MinutaPatronConfiguracionMs().GetAllByWithRelation().Cast<MinutaPatronConfiguracion>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <MinutaPatronConfiguracion>().ToList();  
                if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderBy(p => p.ID_TipoModeloOperacion).Cast <MinutaPatronConfiguracion>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderBy(p => p.sID_TipoModeloOperacion).Cast <MinutaPatronConfiguracion>().ToList(); 
                 if (orderCriteria == "ModalidadComplementoId") result = result.OrderBy(p => p.ModalidadComplementoId).Cast <MinutaPatronConfiguracion>().ToList(); 
                 if (orderCriteria == "sID_TiposModalidadComplemento") result = result.OrderBy(p => p.sModalidadComplementoId).Cast <MinutaPatronConfiguracion>().ToList(); 
                 if (orderCriteria == "TipoComplementoId") result = result.OrderBy(p => p.TipoComplementoId).Cast <MinutaPatronConfiguracion>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderBy(p => p.sTipoComplementoId).Cast <MinutaPatronConfiguracion>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <MinutaPatronConfiguracion>().ToList();  
                if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderByDescending(p => p.ID_TipoModeloOperacion).Cast <MinutaPatronConfiguracion>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderByDescending(p => p.sID_TipoModeloOperacion).Cast<MinutaPatronConfiguracion>().ToList(); 
                 if (orderCriteria == "ModalidadComplementoId") result = result.OrderByDescending(p => p.ModalidadComplementoId).Cast <MinutaPatronConfiguracion>().ToList(); 
                 if (orderCriteria == "sID_TiposModalidadComplemento") result = result.OrderByDescending(p => p.sModalidadComplementoId).Cast<MinutaPatronConfiguracion>().ToList(); 
                 if (orderCriteria == "TipoComplementoId") result = result.OrderByDescending(p => p.TipoComplementoId).Cast <MinutaPatronConfiguracion>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderByDescending(p => p.sTipoComplementoId).Cast<MinutaPatronConfiguracion>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoModeloOperacion != null && r.ID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoModeloOperacion != null && r.sID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ModalidadComplementoId != null && r.ModalidadComplementoId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sModalidadComplementoId != null && r.sModalidadComplementoId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TipoComplementoId != null && r.TipoComplementoId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sTipoComplementoId != null && r.sTipoComplementoId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad MinutaPatronConfiguracion --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  MinutaPatronConfiguracion!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaPatronConfiguracion</param>
        /// <response code="200">MinutaPatronConfiguracion Consulto los registros exitosamente</response>
        /// <response code="400">MinutaPatronConfiguracion tiene valores invalidos </response>
        /// <response code="401">MinutaPatronConfiguracion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaPatronConfiguracion en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new MinutaPatronConfiguracionMs().GetAllByWithRelation().Cast<MinutaPatronConfiguracion>().AsQueryable();
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
