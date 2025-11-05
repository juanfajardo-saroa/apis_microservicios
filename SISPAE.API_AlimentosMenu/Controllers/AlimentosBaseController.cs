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
    [SwaggerTag("Web API para CRUD de AlimentosBase .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class AlimentosBaseController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad AlimentosBase --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosBase!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AlimentosBase</param>
        /// <response code="200">AlimentosBase Consulto los registros exitosamente</response>
        /// <response code="400">AlimentosBase tiene valores invalidos </response>
        /// <response code="401">AlimentosBase No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AlimentosBase en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new AlimentosBaseMs().GetAll().Cast<AlimentosBase>().AsQueryable();
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
        /// CRUD de la entidad AlimentosBase --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosBase!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AlimentosBase</param>
        /// <response code="200">AlimentosBase Consulto los registros exitosamente</response>
        /// <response code="400">AlimentosBase tiene valores invalidos </response>
        /// <response code="401">AlimentosBase No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AlimentosBase en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new AlimentosBaseMs().GetAllFull().Cast<AlimentosBase>().AsQueryable();
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
        /// CRUD de la entidad AlimentosBase --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosBase!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AlimentosBase</param>
        /// <response code="200">AlimentosBase Consulto los registros exitosamente</response>
        /// <response code="400">AlimentosBase tiene valores invalidos </response>
        /// <response code="401">AlimentosBase No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar AlimentosBase en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new AlimentosBaseMs().GetById(new AlimentosBase() { id = id });
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
        /// CRUD de la entidad AlimentosBase --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosBase!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de AlimentosBase</param>
        /// <response code="200">AlimentosBase Creado</response>
        /// <response code="400">AlimentosBase tiene valores invalidos </response>
        /// <response code="401">AlimentosBase No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear AlimentosBase en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] AlimentosBase obj)
        {
            try
            {
                var result = new AlimentosBaseMs().Add(obj);
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
        /// CRUD de la entidad AlimentosBase --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosBase!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de AlimentosBase</param>
        /// <response code="200">AlimentosBase Actualizado</response>
        /// <response code="400">AlimentosBase tiene valores invalidos </response>
        /// <response code="401">AlimentosBase No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar AlimentosBase en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] AlimentosBase obj)
        {
            try
            {
                var result = new AlimentosBaseMs().Update(obj);
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
        /// CRUD de la entidad AlimentosBase --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosBase!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de AlimentosBase</param>
        /// <response code="200">AlimentosBase Eliminado</response>
        /// <response code="400">AlimentosBase tiene valores invalidos </response>
        /// <response code="401">AlimentosBase No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar AlimentosBase en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] AlimentosBase obj)
        {
           try
            {
                new AlimentosBaseMs().Delete(obj);
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
        /// DataTable de la entidad AlimentosBase --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  AlimentosBase!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de AlimentosBase</param>
        /// <response code="200">AlimentosBase Resultado</response>
        /// <response code="400">AlimentosBase tiene valores invalidos </response>
        /// <response code="401">AlimentosBase No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  AlimentosBase en este momento</response>
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

                var result = new AlimentosBaseMs().GetAllByWithRelation().Cast<AlimentosBase>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <AlimentosBase>().ToList();  
                if (orderCriteria == "ID_TipoComponente") result = result.OrderBy(p => p.ID_TipoComponente).Cast <AlimentosBase>().ToList(); 
                 if (orderCriteria == "sID_TiposComponente") result = result.OrderBy(p => p.sID_TipoComponente).Cast <AlimentosBase>().ToList(); 
                 if (orderCriteria == "ID_TipoComplemento") result = result.OrderBy(p => p.ID_TipoComplemento).Cast <AlimentosBase>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderBy(p => p.sID_TipoComplemento).Cast <AlimentosBase>().ToList(); 
                 if (orderCriteria == "ID_AlimentoSIPSA") result = result.OrderBy(p => p.ID_AlimentoSIPSA).Cast <AlimentosBase>().ToList(); 
                 if (orderCriteria == "sID_AlimentosSIPSA") result = result.OrderBy(p => p.sID_AlimentoSIPSA).Cast <AlimentosBase>().ToList(); 
                 if (orderCriteria == "ID_AlimentoNoSIPSA") result = result.OrderBy(p => p.ID_AlimentoNoSIPSA).Cast <AlimentosBase>().ToList(); 
                 if (orderCriteria == "sID_AlimentosNoSIPSA") result = result.OrderBy(p => p.sID_AlimentoNoSIPSA).Cast <AlimentosBase>().ToList(); 
                 if (orderCriteria == "Precio") result = result.OrderBy(p => p.Precio).Cast <AlimentosBase>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <AlimentosBase>().ToList();  
                if (orderCriteria == "ID_TipoComponente") result = result.OrderByDescending(p => p.ID_TipoComponente).Cast <AlimentosBase>().ToList(); 
                 if (orderCriteria == "sID_TiposComponente") result = result.OrderByDescending(p => p.sID_TipoComponente).Cast<AlimentosBase>().ToList(); 
                 if (orderCriteria == "ID_TipoComplemento") result = result.OrderByDescending(p => p.ID_TipoComplemento).Cast <AlimentosBase>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderByDescending(p => p.sID_TipoComplemento).Cast<AlimentosBase>().ToList(); 
                 if (orderCriteria == "ID_AlimentoSIPSA") result = result.OrderByDescending(p => p.ID_AlimentoSIPSA).Cast <AlimentosBase>().ToList(); 
                 if (orderCriteria == "sID_AlimentosSIPSA") result = result.OrderByDescending(p => p.sID_AlimentoSIPSA).Cast<AlimentosBase>().ToList(); 
                 if (orderCriteria == "ID_AlimentoNoSIPSA") result = result.OrderByDescending(p => p.ID_AlimentoNoSIPSA).Cast <AlimentosBase>().ToList(); 
                 if (orderCriteria == "sID_AlimentosNoSIPSA") result = result.OrderByDescending(p => p.sID_AlimentoNoSIPSA).Cast<AlimentosBase>().ToList(); 
                 if (orderCriteria == "Precio") result = result.OrderByDescending(p => p.Precio).Cast <AlimentosBase>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoComponente != null && r.ID_TipoComponente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoComponente != null && r.sID_TipoComponente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoComplemento != null && r.ID_TipoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoComplemento != null && r.sID_TipoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_AlimentoSIPSA != null && r.ID_AlimentoSIPSA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_AlimentoSIPSA != null && r.sID_AlimentoSIPSA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_AlimentoNoSIPSA != null && r.ID_AlimentoNoSIPSA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_AlimentoNoSIPSA != null && r.sID_AlimentoNoSIPSA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Precio != null && r.Precio.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad AlimentosBase --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosBase!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AlimentosBase</param>
        /// <response code="200">AlimentosBase Consulto los registros exitosamente</response>
        /// <response code="400">AlimentosBase tiene valores invalidos </response>
        /// <response code="401">AlimentosBase No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AlimentosBase en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new AlimentosBaseMs().GetAllByWithRelation().Cast<AlimentosBase>().AsQueryable();
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
