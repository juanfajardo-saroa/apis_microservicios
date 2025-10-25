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
    [SwaggerTag("Web API para CRUD de Menus .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class MenusController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Menus --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Menus!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Menus</param>
        /// <response code="200">Menus Consulto los registros exitosamente</response>
        /// <response code="400">Menus tiene valores invalidos </response>
        /// <response code="401">Menus No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Menus en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new MenusMs().GetAll().Cast<Menus>().AsQueryable();
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
        /// CRUD de la entidad Menus --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Menus!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Menus</param>
        /// <response code="200">Menus Consulto los registros exitosamente</response>
        /// <response code="400">Menus tiene valores invalidos </response>
        /// <response code="401">Menus No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Menus en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new MenusMs().GetAllFull().Cast<Menus>().AsQueryable();
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
        /// CRUD de la entidad Menus --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Menus!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Menus</param>
        /// <response code="200">Menus Consulto los registros exitosamente</response>
        /// <response code="400">Menus tiene valores invalidos </response>
        /// <response code="401">Menus No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Menus en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new MenusMs().GetById(new Menus() { id = id });
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
        /// CRUD de la entidad Menus --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Menus!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Menus</param>
        /// <response code="200">Menus Creado</response>
        /// <response code="400">Menus tiene valores invalidos </response>
        /// <response code="401">Menus No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Menus en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Menus obj)
        {
            try
            {
                var result = new MenusMs().Add(obj);
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
        /// CRUD de la entidad Menus --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Menus!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Menus</param>
        /// <response code="200">Menus Actualizado</response>
        /// <response code="400">Menus tiene valores invalidos </response>
        /// <response code="401">Menus No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Menus en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Menus obj)
        {
            try
            {
                var result = new MenusMs().Update(obj);
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
        /// CRUD de la entidad Menus --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Menus!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Menus</param>
        /// <response code="200">Menus Eliminado</response>
        /// <response code="400">Menus tiene valores invalidos </response>
        /// <response code="401">Menus No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Menus en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Menus obj)
        {
           try
            {
                new MenusMs().Delete(obj);
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
        /// DataTable de la entidad Menus --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Menus!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Menus</param>
        /// <response code="200">Menus Resultado</response>
        /// <response code="400">Menus tiene valores invalidos </response>
        /// <response code="401">Menus No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Menus en este momento</response>
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

                var result = new MenusMs().GetAllByWithRelation().Cast<Menus>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Menus>().ToList();  
                if (orderCriteria == "ID_TipoMenu") result = result.OrderBy(p => p.ID_TipoMenu).Cast <Menus>().ToList(); 
                 if (orderCriteria == "sID_TiposMenu") result = result.OrderBy(p => p.sID_TipoMenu).Cast <Menus>().ToList(); 
                 if (orderCriteria == "ID_TipoComplemento") result = result.OrderBy(p => p.ID_TipoComplemento).Cast <Menus>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderBy(p => p.sID_TipoComplemento).Cast <Menus>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderBy(p => p.ID_ETC).Cast <Menus>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderBy(p => p.sID_ETC).Cast <Menus>().ToList(); 
                 if (orderCriteria == "TotalCostoMenu") result = result.OrderBy(p => p.TotalCostoMenu).Cast <Menus>().ToList(); 
                 if (orderCriteria == "CostoTransporte") result = result.OrderBy(p => p.CostoTransporte).Cast <Menus>().ToList(); 
                 if (orderCriteria == "CostoAlimentos") result = result.OrderBy(p => p.CostoAlimentos).Cast <Menus>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Menus>().ToList();  
                if (orderCriteria == "ID_TipoMenu") result = result.OrderByDescending(p => p.ID_TipoMenu).Cast <Menus>().ToList(); 
                 if (orderCriteria == "sID_TiposMenu") result = result.OrderByDescending(p => p.sID_TipoMenu).Cast<Menus>().ToList(); 
                 if (orderCriteria == "ID_TipoComplemento") result = result.OrderByDescending(p => p.ID_TipoComplemento).Cast <Menus>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderByDescending(p => p.sID_TipoComplemento).Cast<Menus>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderByDescending(p => p.ID_ETC).Cast <Menus>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderByDescending(p => p.sID_ETC).Cast<Menus>().ToList(); 
                 if (orderCriteria == "TotalCostoMenu") result = result.OrderByDescending(p => p.TotalCostoMenu).Cast <Menus>().ToList(); 
                 if (orderCriteria == "CostoTransporte") result = result.OrderByDescending(p => p.CostoTransporte).Cast <Menus>().ToList(); 
                 if (orderCriteria == "CostoAlimentos") result = result.OrderByDescending(p => p.CostoAlimentos).Cast <Menus>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoMenu != null && r.ID_TipoMenu.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoMenu != null && r.sID_TipoMenu.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoComplemento != null && r.ID_TipoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoComplemento != null && r.sID_TipoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_ETC != null && r.ID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ETC != null && r.sID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TotalCostoMenu != null && r.TotalCostoMenu.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CostoTransporte != null && r.CostoTransporte.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CostoAlimentos != null && r.CostoAlimentos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad Menus --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Menus!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Menus</param>
        /// <response code="200">Menus Consulto los registros exitosamente</response>
        /// <response code="400">Menus tiene valores invalidos </response>
        /// <response code="401">Menus No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Menus en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new MenusMs().GetAllByWithRelation().Cast<Menus>().AsQueryable();
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
