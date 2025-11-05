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

namespace SISPAE_API_Priorizacion.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de ModalidadModelo .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class ModalidadModeloController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad ModalidadModelo --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Priorizacion de la entidad  ModalidadModelo!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ModalidadModelo</param>
        /// <response code="200">ModalidadModelo Consulto los registros exitosamente</response>
        /// <response code="400">ModalidadModelo tiene valores invalidos </response>
        /// <response code="401">ModalidadModelo No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ModalidadModelo en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new ModalidadModeloMs().GetAll().Cast<ModalidadModelo>().AsQueryable();
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
        /// CRUD de la entidad ModalidadModelo --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Priorizacion de la entidad  ModalidadModelo!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ModalidadModelo</param>
        /// <response code="200">ModalidadModelo Consulto los registros exitosamente</response>
        /// <response code="400">ModalidadModelo tiene valores invalidos </response>
        /// <response code="401">ModalidadModelo No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ModalidadModelo en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new ModalidadModeloMs().GetAllFull().Cast<ModalidadModelo>().AsQueryable();
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
        /// CRUD de la entidad ModalidadModelo --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Priorizacion de la entidad  ModalidadModelo!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ModalidadModelo</param>
        /// <response code="200">ModalidadModelo Consulto los registros exitosamente</response>
        /// <response code="400">ModalidadModelo tiene valores invalidos </response>
        /// <response code="401">ModalidadModelo No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar ModalidadModelo en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new ModalidadModeloMs().GetById(new ModalidadModelo() { ID = id });
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
        /// CRUD de la entidad ModalidadModelo --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Priorizacion de la entidad  ModalidadModelo!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de ModalidadModelo</param>
        /// <response code="200">ModalidadModelo Creado</response>
        /// <response code="400">ModalidadModelo tiene valores invalidos </response>
        /// <response code="401">ModalidadModelo No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear ModalidadModelo en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] ModalidadModelo obj)
        {
            try
            {
                var result = new ModalidadModeloMs().Add(obj);
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
        /// CRUD de la entidad ModalidadModelo --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Priorizacion de la entidad  ModalidadModelo!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de ModalidadModelo</param>
        /// <response code="200">ModalidadModelo Actualizado</response>
        /// <response code="400">ModalidadModelo tiene valores invalidos </response>
        /// <response code="401">ModalidadModelo No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar ModalidadModelo en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] ModalidadModelo obj)
        {
            try
            {
                var result = new ModalidadModeloMs().Update(obj);
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
        /// CRUD de la entidad ModalidadModelo --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Priorizacion de la entidad  ModalidadModelo!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de ModalidadModelo</param>
        /// <response code="200">ModalidadModelo Eliminado</response>
        /// <response code="400">ModalidadModelo tiene valores invalidos </response>
        /// <response code="401">ModalidadModelo No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar ModalidadModelo en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] ModalidadModelo obj)
        {
           try
            {
                new ModalidadModeloMs().Delete(obj);
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
        /// DataTable de la entidad ModalidadModelo --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  ModalidadModelo!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de ModalidadModelo</param>
        /// <response code="200">ModalidadModelo Resultado</response>
        /// <response code="400">ModalidadModelo tiene valores invalidos </response>
        /// <response code="401">ModalidadModelo No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  ModalidadModelo en este momento</response>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LoadTable([FromBody] DtParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;

            var orderCriteria = "ID";
            var orderAscendingDirection = true;

            try
            {

                if (dtParameters.Order != null)
                {
                    // in this example we just default sort on the 1st column
                    orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                    orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
                }

                var result = new ModalidadModeloMs().GetAllByWithRelation().Cast<ModalidadModelo>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="ID") result = result.OrderBy(p => p.ID).Cast <ModalidadModelo>().ToList();  
                if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderBy(p => p.ID_TipoModeloOperacion).Cast <ModalidadModelo>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderBy(p => p.sID_TipoModeloOperacion).Cast <ModalidadModelo>().ToList(); 
                 if (orderCriteria == "ID_TipoModalidadComplemento") result = result.OrderBy(p => p.ID_TipoModalidadComplemento).Cast <ModalidadModelo>().ToList(); 
                 if (orderCriteria == "sID_TiposModalidadComplemento") result = result.OrderBy(p => p.sID_TipoModalidadComplemento).Cast <ModalidadModelo>().ToList(); 
                 if (orderCriteria == "ID_TipoComplemento") result = result.OrderBy(p => p.ID_TipoComplemento).Cast <ModalidadModelo>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderBy(p => p.sID_TipoComplemento).Cast <ModalidadModelo>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "ID") result = result.OrderByDescending(p => p.ID).Cast <ModalidadModelo>().ToList();  
                if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderByDescending(p => p.ID_TipoModeloOperacion).Cast <ModalidadModelo>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderByDescending(p => p.sID_TipoModeloOperacion).Cast<ModalidadModelo>().ToList(); 
                 if (orderCriteria == "ID_TipoModalidadComplemento") result = result.OrderByDescending(p => p.ID_TipoModalidadComplemento).Cast <ModalidadModelo>().ToList(); 
                 if (orderCriteria == "sID_TiposModalidadComplemento") result = result.OrderByDescending(p => p.sID_TipoModalidadComplemento).Cast<ModalidadModelo>().ToList(); 
                 if (orderCriteria == "ID_TipoComplemento") result = result.OrderByDescending(p => p.ID_TipoComplemento).Cast <ModalidadModelo>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderByDescending(p => p.sID_TipoComplemento).Cast<ModalidadModelo>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.ID != null && r.ID.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoModeloOperacion != null && r.ID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoModeloOperacion != null && r.sID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoModalidadComplemento != null && r.ID_TipoModalidadComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoModalidadComplemento != null && r.sID_TipoModalidadComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoComplemento != null && r.ID_TipoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoComplemento != null && r.sID_TipoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
                    data[i].sID = SISPAE.Common.Utilidades.Encrypt($"id={data[i].ID.ToString()}");
                   
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
        /// CRUD de la entidad ModalidadModelo --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Priorizacion de la entidad  ModalidadModelo!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ModalidadModelo</param>
        /// <response code="200">ModalidadModelo Consulto los registros exitosamente</response>
        /// <response code="400">ModalidadModelo tiene valores invalidos </response>
        /// <response code="401">ModalidadModelo No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ModalidadModelo en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new ModalidadModeloMs().GetAllByWithRelation().Cast<ModalidadModelo>().AsQueryable();
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
