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
    [SwaggerTag("Web API para CRUD de MinutaPatronAlimentos_Cuarentena .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class MinutaPatronAlimentos_CuarentenaController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad MinutaPatronAlimentos_Cuarentena --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  MinutaPatronAlimentos_Cuarentena!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaPatronAlimentos_Cuarentena</param>
        /// <response code="200">MinutaPatronAlimentos_Cuarentena Consulto los registros exitosamente</response>
        /// <response code="400">MinutaPatronAlimentos_Cuarentena tiene valores invalidos </response>
        /// <response code="401">MinutaPatronAlimentos_Cuarentena No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaPatronAlimentos_Cuarentena en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new MinutaPatronAlimentos_CuarentenaMs().GetAll().Cast<MinutaPatronAlimentos_Cuarentena>().AsQueryable();
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
        /// CRUD de la entidad MinutaPatronAlimentos_Cuarentena --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  MinutaPatronAlimentos_Cuarentena!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaPatronAlimentos_Cuarentena</param>
        /// <response code="200">MinutaPatronAlimentos_Cuarentena Consulto los registros exitosamente</response>
        /// <response code="400">MinutaPatronAlimentos_Cuarentena tiene valores invalidos </response>
        /// <response code="401">MinutaPatronAlimentos_Cuarentena No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaPatronAlimentos_Cuarentena en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new MinutaPatronAlimentos_CuarentenaMs().GetAllFull().Cast<MinutaPatronAlimentos_Cuarentena>().AsQueryable();
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
        /// CRUD de la entidad MinutaPatronAlimentos_Cuarentena --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  MinutaPatronAlimentos_Cuarentena!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaPatronAlimentos_Cuarentena</param>
        /// <response code="200">MinutaPatronAlimentos_Cuarentena Consulto los registros exitosamente</response>
        /// <response code="400">MinutaPatronAlimentos_Cuarentena tiene valores invalidos </response>
        /// <response code="401">MinutaPatronAlimentos_Cuarentena No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar MinutaPatronAlimentos_Cuarentena en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new MinutaPatronAlimentos_CuarentenaMs().GetById(new MinutaPatronAlimentos_Cuarentena() { id = id });
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
        /// CRUD de la entidad MinutaPatronAlimentos_Cuarentena --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  MinutaPatronAlimentos_Cuarentena!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de MinutaPatronAlimentos_Cuarentena</param>
        /// <response code="200">MinutaPatronAlimentos_Cuarentena Creado</response>
        /// <response code="400">MinutaPatronAlimentos_Cuarentena tiene valores invalidos </response>
        /// <response code="401">MinutaPatronAlimentos_Cuarentena No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear MinutaPatronAlimentos_Cuarentena en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] MinutaPatronAlimentos_Cuarentena obj)
        {
            try
            {
                var result = new MinutaPatronAlimentos_CuarentenaMs().Add(obj);
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
        /// CRUD de la entidad MinutaPatronAlimentos_Cuarentena --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  MinutaPatronAlimentos_Cuarentena!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de MinutaPatronAlimentos_Cuarentena</param>
        /// <response code="200">MinutaPatronAlimentos_Cuarentena Actualizado</response>
        /// <response code="400">MinutaPatronAlimentos_Cuarentena tiene valores invalidos </response>
        /// <response code="401">MinutaPatronAlimentos_Cuarentena No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar MinutaPatronAlimentos_Cuarentena en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] MinutaPatronAlimentos_Cuarentena obj)
        {
            try
            {
                var result = new MinutaPatronAlimentos_CuarentenaMs().Update(obj);
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
        /// CRUD de la entidad MinutaPatronAlimentos_Cuarentena --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  MinutaPatronAlimentos_Cuarentena!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de MinutaPatronAlimentos_Cuarentena</param>
        /// <response code="200">MinutaPatronAlimentos_Cuarentena Eliminado</response>
        /// <response code="400">MinutaPatronAlimentos_Cuarentena tiene valores invalidos </response>
        /// <response code="401">MinutaPatronAlimentos_Cuarentena No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar MinutaPatronAlimentos_Cuarentena en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] MinutaPatronAlimentos_Cuarentena obj)
        {
           try
            {
                new MinutaPatronAlimentos_CuarentenaMs().Delete(obj);
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
        /// DataTable de la entidad MinutaPatronAlimentos_Cuarentena --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  MinutaPatronAlimentos_Cuarentena!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de MinutaPatronAlimentos_Cuarentena</param>
        /// <response code="200">MinutaPatronAlimentos_Cuarentena Resultado</response>
        /// <response code="400">MinutaPatronAlimentos_Cuarentena tiene valores invalidos </response>
        /// <response code="401">MinutaPatronAlimentos_Cuarentena No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  MinutaPatronAlimentos_Cuarentena en este momento</response>
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

                var result = new MinutaPatronAlimentos_CuarentenaMs().GetAllByWithRelation().Cast<MinutaPatronAlimentos_Cuarentena>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <MinutaPatronAlimentos_Cuarentena>().ToList();  
                if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "ID_TipoMinutaPatron") result = result.OrderBy(p => p.ID_TipoMinutaPatron).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "sID_TiposMinutaPatron") result = result.OrderBy(p => p.sID_TipoMinutaPatron).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "ID_TipoEstadoMinuta") result = result.OrderBy(p => p.ID_TipoEstadoMinuta).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "sID_TiposEstadoMinuta") result = result.OrderBy(p => p.sID_TipoEstadoMinuta).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "ID_UsuarioEntidad") result = result.OrderBy(p => p.ID_UsuarioEntidad).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "sID_UsuariosEntidades") result = result.OrderBy(p => p.sID_UsuarioEntidad).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderBy(p => p.ID_TipoModeloOperacion).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderBy(p => p.sID_TipoModeloOperacion).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderBy(p => p.ID_ETC).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderBy(p => p.sID_ETC).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "ID_TipoGrupoEtario") result = result.OrderBy(p => p.ID_TipoGrupoEtario).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "sID_TiposGrupoEtario") result = result.OrderBy(p => p.sID_TipoGrupoEtario).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <MinutaPatronAlimentos_Cuarentena>().ToList();  
                if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "ID_TipoMinutaPatron") result = result.OrderByDescending(p => p.ID_TipoMinutaPatron).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "sID_TiposMinutaPatron") result = result.OrderByDescending(p => p.sID_TipoMinutaPatron).Cast<MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "ID_TipoEstadoMinuta") result = result.OrderByDescending(p => p.ID_TipoEstadoMinuta).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "sID_TiposEstadoMinuta") result = result.OrderByDescending(p => p.sID_TipoEstadoMinuta).Cast<MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "ID_UsuarioEntidad") result = result.OrderByDescending(p => p.ID_UsuarioEntidad).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "sID_UsuariosEntidades") result = result.OrderByDescending(p => p.sID_UsuarioEntidad).Cast<MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderByDescending(p => p.ID_TipoModeloOperacion).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderByDescending(p => p.sID_TipoModeloOperacion).Cast<MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderByDescending(p => p.ID_ETC).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderByDescending(p => p.sID_ETC).Cast<MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "ID_TipoGrupoEtario") result = result.OrderByDescending(p => p.ID_TipoGrupoEtario).Cast <MinutaPatronAlimentos_Cuarentena>().ToList(); 
                 if (orderCriteria == "sID_TiposGrupoEtario") result = result.OrderByDescending(p => p.sID_TipoGrupoEtario).Cast<MinutaPatronAlimentos_Cuarentena>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoMinutaPatron != null && r.ID_TipoMinutaPatron.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoMinutaPatron != null && r.sID_TipoMinutaPatron.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoEstadoMinuta != null && r.ID_TipoEstadoMinuta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoEstadoMinuta != null && r.sID_TipoEstadoMinuta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_UsuarioEntidad != null && r.ID_UsuarioEntidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_UsuarioEntidad != null && r.sID_UsuarioEntidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoModeloOperacion != null && r.ID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoModeloOperacion != null && r.sID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_ETC != null && r.ID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ETC != null && r.sID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoGrupoEtario != null && r.ID_TipoGrupoEtario.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoGrupoEtario != null && r.sID_TipoGrupoEtario.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad MinutaPatronAlimentos_Cuarentena --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  MinutaPatronAlimentos_Cuarentena!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaPatronAlimentos_Cuarentena</param>
        /// <response code="200">MinutaPatronAlimentos_Cuarentena Consulto los registros exitosamente</response>
        /// <response code="400">MinutaPatronAlimentos_Cuarentena tiene valores invalidos </response>
        /// <response code="401">MinutaPatronAlimentos_Cuarentena No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaPatronAlimentos_Cuarentena en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new MinutaPatronAlimentos_CuarentenaMs().GetAllByWithRelation().Cast<MinutaPatronAlimentos_Cuarentena>().AsQueryable();
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
