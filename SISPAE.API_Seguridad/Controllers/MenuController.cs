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

namespace SISPAE_API_Seguridad.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de Menu .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class MenuController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Menu --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguridad de la entidad  Menu!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Menu</param>
        /// <response code="200">Menu Consulto los registros exitosamente</response>
        /// <response code="400">Menu tiene valores invalidos </response>
        /// <response code="401">Menu No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Menu en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new MenuMs().GetAll().Cast<Menu>().AsQueryable();
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
        /// CRUD de la entidad Menu --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguridad de la entidad  Menu!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Menu</param>
        /// <response code="200">Menu Consulto los registros exitosamente</response>
        /// <response code="400">Menu tiene valores invalidos </response>
        /// <response code="401">Menu No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Menu en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new MenuMs().GetAllFull().Cast<Menu>().AsQueryable();
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
        /// CRUD de la entidad Menu --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguridad de la entidad  Menu!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Menu</param>
        /// <response code="200">Menu Consulto los registros exitosamente</response>
        /// <response code="400">Menu tiene valores invalidos </response>
        /// <response code="401">Menu No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Menu en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new MenuMs().GetById(new Menu() { id = id });
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
        /// CRUD de la entidad Menu --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Seguridad de la entidad  Menu!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Menu</param>
        /// <response code="200">Menu Creado</response>
        /// <response code="400">Menu tiene valores invalidos </response>
        /// <response code="401">Menu No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Menu en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Menu obj)
        {
            try
            {
                var result = new MenuMs().Add(obj);
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
        /// CRUD de la entidad Menu --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Seguridad de la entidad  Menu!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Menu</param>
        /// <response code="200">Menu Actualizado</response>
        /// <response code="400">Menu tiene valores invalidos </response>
        /// <response code="401">Menu No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Menu en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Menu obj)
        {
            try
            {
                var result = new MenuMs().Update(obj);
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
        /// CRUD de la entidad Menu --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Seguridad de la entidad  Menu!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Menu</param>
        /// <response code="200">Menu Eliminado</response>
        /// <response code="400">Menu tiene valores invalidos </response>
        /// <response code="401">Menu No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Menu en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Menu obj)
        {
           try
            {
                new MenuMs().Delete(obj);
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
        /// DataTable de la entidad Menu --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Menu!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Menu</param>
        /// <response code="200">Menu Resultado</response>
        /// <response code="400">Menu tiene valores invalidos </response>
        /// <response code="401">Menu No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Menu en este momento</response>
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

                var result = new MenuMs().GetAllByWithRelation().Cast<Menu>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Menu>().ToList();  
                if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <Menu>().ToList(); 
                 if (orderCriteria == "Controlador") result = result.OrderBy(p => p.Controlador).Cast <Menu>().ToList(); 
                 if (orderCriteria == "Accion") result = result.OrderBy(p => p.Accion).Cast <Menu>().ToList(); 
                 if (orderCriteria == "GrupoEsquema") result = result.OrderBy(p => p.GrupoEsquema).Cast <Menu>().ToList(); 
                 if (orderCriteria == "Link") result = result.OrderBy(p => p.Link).Cast <Menu>().ToList(); 
                 if (orderCriteria == "Orden") result = result.OrderBy(p => p.Orden).Cast <Menu>().ToList(); 
                 if (orderCriteria == "OrdenPadre") result = result.OrderBy(p => p.OrdenPadre).Cast <Menu>().ToList(); 
                 if (orderCriteria == "Padre") result = result.OrderBy(p => p.Padre).Cast <Menu>().ToList(); 
                 if (orderCriteria == "Icono") result = result.OrderBy(p => p.Icono).Cast <Menu>().ToList(); 
                 if (orderCriteria == "IconoPAE") result = result.OrderBy(p => p.IconoPAE).Cast <Menu>().ToList(); 
                 if (orderCriteria == "EstadoMenu") result = result.OrderBy(p => p.EstadoMenu).Cast <Menu>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Menu>().ToList();  
                if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <Menu>().ToList(); 
                 if (orderCriteria == "Controlador") result = result.OrderByDescending(p => p.Controlador).Cast <Menu>().ToList(); 
                 if (orderCriteria == "Accion") result = result.OrderByDescending(p => p.Accion).Cast <Menu>().ToList(); 
                 if (orderCriteria == "GrupoEsquema") result = result.OrderByDescending(p => p.GrupoEsquema).Cast <Menu>().ToList(); 
                 if (orderCriteria == "Link") result = result.OrderByDescending(p => p.Link).Cast <Menu>().ToList(); 
                 if (orderCriteria == "Orden") result = result.OrderByDescending(p => p.Orden).Cast <Menu>().ToList(); 
                 if (orderCriteria == "OrdenPadre") result = result.OrderByDescending(p => p.OrdenPadre).Cast <Menu>().ToList(); 
                 if (orderCriteria == "Padre") result = result.OrderByDescending(p => p.Padre).Cast <Menu>().ToList(); 
                 if (orderCriteria == "Icono") result = result.OrderByDescending(p => p.Icono).Cast <Menu>().ToList(); 
                 if (orderCriteria == "IconoPAE") result = result.OrderByDescending(p => p.IconoPAE).Cast <Menu>().ToList(); 
                 if (orderCriteria == "EstadoMenu") result = result.OrderByDescending(p => p.EstadoMenu).Cast <Menu>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Controlador != null && r.Controlador.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Accion != null && r.Accion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.GrupoEsquema != null && r.GrupoEsquema.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Link != null && r.Link.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Orden != null && r.Orden.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.OrdenPadre != null && r.OrdenPadre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Padre != null && r.Padre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Icono != null && r.Icono.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.IconoPAE != null && r.IconoPAE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.EstadoMenu != null && r.EstadoMenu.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad Menu --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguridad de la entidad  Menu!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Menu</param>
        /// <response code="200">Menu Consulto los registros exitosamente</response>
        /// <response code="400">Menu tiene valores invalidos </response>
        /// <response code="401">Menu No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Menu en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new MenuMs().GetAllByWithRelation().Cast<Menu>().AsQueryable();
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
