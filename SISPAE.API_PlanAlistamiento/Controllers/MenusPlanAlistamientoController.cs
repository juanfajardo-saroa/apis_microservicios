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

namespace SISPAE_API_PlanAlistamiento.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de MenusPlanAlistamiento .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class MenusPlanAlistamientoController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad MenusPlanAlistamiento --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  MenusPlanAlistamiento!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MenusPlanAlistamiento</param>
        /// <response code="200">MenusPlanAlistamiento Consulto los registros exitosamente</response>
        /// <response code="400">MenusPlanAlistamiento tiene valores invalidos </response>
        /// <response code="401">MenusPlanAlistamiento No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MenusPlanAlistamiento en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new MenusPlanAlistamientoMs().GetAll().Cast<MenusPlanAlistamiento>().AsQueryable();
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
        /// CRUD de la entidad MenusPlanAlistamiento --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  MenusPlanAlistamiento!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MenusPlanAlistamiento</param>
        /// <response code="200">MenusPlanAlistamiento Consulto los registros exitosamente</response>
        /// <response code="400">MenusPlanAlistamiento tiene valores invalidos </response>
        /// <response code="401">MenusPlanAlistamiento No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MenusPlanAlistamiento en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new MenusPlanAlistamientoMs().GetAllFull().Cast<MenusPlanAlistamiento>().AsQueryable();
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
        /// CRUD de la entidad MenusPlanAlistamiento --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  MenusPlanAlistamiento!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MenusPlanAlistamiento</param>
        /// <response code="200">MenusPlanAlistamiento Consulto los registros exitosamente</response>
        /// <response code="400">MenusPlanAlistamiento tiene valores invalidos </response>
        /// <response code="401">MenusPlanAlistamiento No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar MenusPlanAlistamiento en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new MenusPlanAlistamientoMs().GetById(new MenusPlanAlistamiento() { ID = id });
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
        /// CRUD de la entidad MenusPlanAlistamiento --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  MenusPlanAlistamiento!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de MenusPlanAlistamiento</param>
        /// <response code="200">MenusPlanAlistamiento Creado</response>
        /// <response code="400">MenusPlanAlistamiento tiene valores invalidos </response>
        /// <response code="401">MenusPlanAlistamiento No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear MenusPlanAlistamiento en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] MenusPlanAlistamiento obj)
        {
            try
            {

                var result = new MenusPlanAlistamientoMs().Add(obj);
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
        /// CRUD de la entidad MenusPlanAlistamiento --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  MenusPlanAlistamiento!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de MenusPlanAlistamiento</param>
        /// <response code="200">MenusPlanAlistamiento Actualizado</response>
        /// <response code="400">MenusPlanAlistamiento tiene valores invalidos </response>
        /// <response code="401">MenusPlanAlistamiento No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar MenusPlanAlistamiento en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] MenusPlanAlistamiento obj)
        {
            try
            {
                var result = new MenusPlanAlistamientoMs().Update(obj);
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
        /// CRUD de la entidad MenusPlanAlistamiento --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  MenusPlanAlistamiento!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de MenusPlanAlistamiento</param>
        /// <response code="200">MenusPlanAlistamiento Eliminado</response>
        /// <response code="400">MenusPlanAlistamiento tiene valores invalidos </response>
        /// <response code="401">MenusPlanAlistamiento No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar MenusPlanAlistamiento en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] MenusPlanAlistamiento obj)
        {
           try
            {
                new MenusPlanAlistamientoMs().Delete(obj);
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
        /// DataTable de la entidad MenusPlanAlistamiento --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  MenusPlanAlistamiento!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de MenusPlanAlistamiento</param>
        /// <response code="200">MenusPlanAlistamiento Resultado</response>
        /// <response code="400">MenusPlanAlistamiento tiene valores invalidos </response>
        /// <response code="401">MenusPlanAlistamiento No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  MenusPlanAlistamiento en este momento</response>
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

                var result = new MenusPlanAlistamientoMs().GetAllByWithRelation().Cast<MenusPlanAlistamiento>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="ID") result = result.OrderBy(p => p.ID).Cast <MenusPlanAlistamiento>().ToList();  
                if (orderCriteria == "ID_EstadoValidacion") result = result.OrderBy(p => p.ID_EstadoValidacion).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "sID_EstadosValidacion") result = result.OrderBy(p => p.sID_EstadoValidacion).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "ID_UsuarioEntidad") result = result.OrderBy(p => p.ID_UsuarioEntidad).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "sID_UsuariosEntidades") result = result.OrderBy(p => p.sID_UsuarioEntidad).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "ID_CiclosMenu") result = result.OrderBy(p => p.ID_CiclosMenu).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "sID_CiclosMenus") result = result.OrderBy(p => p.sID_CiclosMenu).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "ID_PlanesAlistamiento") result = result.OrderBy(p => p.ID_PlanesAlistamiento).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "sID_PlanesAlistamientos") result = result.OrderBy(p => p.sID_PlanesAlistamiento).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "ID_TipoModalidadComplemento") result = result.OrderBy(p => p.ID_TipoModalidadComplemento).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "sID_TipoModalidadComplemento") result = result.OrderBy(p => p.sID_TipoModalidadComplemento).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "ID_NivelEducativo") result = result.OrderBy(p => p.ID_NivelEducativo).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "sID_NivelEducativo") result = result.OrderBy(p => p.sID_NivelEducativo).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "ID_TipoComplemento") result = result.OrderBy(p => p.ID_TipoComplemento).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderBy(p => p.sID_TipoComplemento).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "ID_Jornada") result = result.OrderBy(p => p.ID_Jornada).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "ID_ModeloOperacion") result = result.OrderBy(p => p.ID_ModeloOperacion).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "NumeroMenu") result = result.OrderBy(p => p.NumeroMenu).Cast <MenusPlanAlistamiento>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "ID") result = result.OrderByDescending(p => p.ID).Cast <MenusPlanAlistamiento>().ToList();  
                if (orderCriteria == "ID_EstadoValidacion") result = result.OrderByDescending(p => p.ID_EstadoValidacion).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "sID_EstadosValidacion") result = result.OrderByDescending(p => p.sID_EstadoValidacion).Cast<MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "ID_UsuarioEntidad") result = result.OrderByDescending(p => p.ID_UsuarioEntidad).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "sID_UsuariosEntidades") result = result.OrderByDescending(p => p.sID_UsuarioEntidad).Cast<MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "ID_CiclosMenu") result = result.OrderByDescending(p => p.ID_CiclosMenu).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "sID_CiclosMenus") result = result.OrderByDescending(p => p.sID_CiclosMenu).Cast<MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "ID_PlanesAlistamiento") result = result.OrderByDescending(p => p.ID_PlanesAlistamiento).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "sID_PlanesAlistamientos") result = result.OrderByDescending(p => p.sID_PlanesAlistamiento).Cast<MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "ID_TipoModalidadComplemento") result = result.OrderByDescending(p => p.ID_TipoModalidadComplemento).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "sID_TipoModalidadComplemento") result = result.OrderByDescending(p => p.sID_TipoModalidadComplemento).Cast<MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "ID_NivelEducativo") result = result.OrderByDescending(p => p.ID_NivelEducativo).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "sID_NivelEducativo") result = result.OrderByDescending(p => p.sID_NivelEducativo).Cast<MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "ID_TipoComplemento") result = result.OrderByDescending(p => p.ID_TipoComplemento).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderByDescending(p => p.sID_TipoComplemento).Cast<MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "ID_Jornada") result = result.OrderByDescending(p => p.ID_Jornada).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "ID_ModeloOperacion") result = result.OrderByDescending(p => p.ID_ModeloOperacion).Cast <MenusPlanAlistamiento>().ToList(); 
                 if (orderCriteria == "NumeroMenu") result = result.OrderByDescending(p => p.NumeroMenu).Cast <MenusPlanAlistamiento>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.ID != null && r.ID.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_EstadoValidacion != null && r.ID_EstadoValidacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_EstadoValidacion != null && r.sID_EstadoValidacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_UsuarioEntidad != null && r.ID_UsuarioEntidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_UsuarioEntidad != null && r.sID_UsuarioEntidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_CiclosMenu != null && r.ID_CiclosMenu.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_CiclosMenu != null && r.sID_CiclosMenu.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_PlanesAlistamiento != null && r.ID_PlanesAlistamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_PlanesAlistamiento != null && r.sID_PlanesAlistamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoModalidadComplemento != null && r.ID_TipoModalidadComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoModalidadComplemento != null && r.sID_TipoModalidadComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_NivelEducativo != null && r.ID_NivelEducativo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_NivelEducativo != null && r.sID_NivelEducativo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoComplemento != null && r.ID_TipoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoComplemento != null && r.sID_TipoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Jornada != null && r.ID_Jornada.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_ModeloOperacion != null && r.ID_ModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumeroMenu != null && r.NumeroMenu.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad MenusPlanAlistamiento --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  MenusPlanAlistamiento!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MenusPlanAlistamiento</param>
        /// <response code="200">MenusPlanAlistamiento Consulto los registros exitosamente</response>
        /// <response code="400">MenusPlanAlistamiento tiene valores invalidos </response>
        /// <response code="401">MenusPlanAlistamiento No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MenusPlanAlistamiento en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new MenusPlanAlistamientoMs().GetAllByWithRelation().Cast<MenusPlanAlistamiento>().AsQueryable();
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
