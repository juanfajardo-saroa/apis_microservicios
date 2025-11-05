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
    [SwaggerTag("Web API para CRUD de RolPermisos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class RolPermisosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad RolPermisos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguridad de la entidad  RolPermisos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de RolPermisos</param>
        /// <response code="200">RolPermisos Consulto los registros exitosamente</response>
        /// <response code="400">RolPermisos tiene valores invalidos </response>
        /// <response code="401">RolPermisos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar RolPermisos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new RolPermisosMs().GetAll().Cast<RolPermisos>().AsQueryable();
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
        /// CRUD de la entidad RolPermisos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguridad de la entidad  RolPermisos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de RolPermisos</param>
        /// <response code="200">RolPermisos Consulto los registros exitosamente</response>
        /// <response code="400">RolPermisos tiene valores invalidos </response>
        /// <response code="401">RolPermisos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar RolPermisos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new RolPermisosMs().GetAllFull().Cast<RolPermisos>().AsQueryable();
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
        /// CRUD de la entidad RolPermisos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguridad de la entidad  RolPermisos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de RolPermisos</param>
        /// <response code="200">RolPermisos Consulto los registros exitosamente</response>
        /// <response code="400">RolPermisos tiene valores invalidos </response>
        /// <response code="401">RolPermisos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar RolPermisos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new RolPermisosMs().GetById(new RolPermisos() { id = id });
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
        /// CRUD de la entidad RolPermisos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Seguridad de la entidad  RolPermisos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de RolPermisos</param>
        /// <response code="200">RolPermisos Creado</response>
        /// <response code="400">RolPermisos tiene valores invalidos </response>
        /// <response code="401">RolPermisos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear RolPermisos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] RolPermisos obj)
        {
            try
            {
                var result = new RolPermisosMs().Add(obj);
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
        /// CRUD de la entidad RolPermisos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Seguridad de la entidad  RolPermisos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de RolPermisos</param>
        /// <response code="200">RolPermisos Actualizado</response>
        /// <response code="400">RolPermisos tiene valores invalidos </response>
        /// <response code="401">RolPermisos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar RolPermisos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] RolPermisos obj)
        {
            try
            {
                var result = new RolPermisosMs().Update(obj);
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
        /// CRUD de la entidad RolPermisos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Seguridad de la entidad  RolPermisos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de RolPermisos</param>
        /// <response code="200">RolPermisos Eliminado</response>
        /// <response code="400">RolPermisos tiene valores invalidos </response>
        /// <response code="401">RolPermisos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar RolPermisos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] RolPermisos obj)
        {
           try
            {
                new RolPermisosMs().Delete(obj);
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
        /// DataTable de la entidad RolPermisos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  RolPermisos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de RolPermisos</param>
        /// <response code="200">RolPermisos Resultado</response>
        /// <response code="400">RolPermisos tiene valores invalidos </response>
        /// <response code="401">RolPermisos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  RolPermisos en este momento</response>
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

                var result = new RolPermisosMs().GetAllByWithRelation().Cast<RolPermisos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <RolPermisos>().ToList();  
                if (orderCriteria == "id_Rol") result = result.OrderBy(p => p.id_Rol).Cast <RolPermisos>().ToList(); 
                 if (orderCriteria == "sID_AspNetRoles") result = result.OrderBy(p => p.sid_Rol).Cast <RolPermisos>().ToList(); 
                 if (orderCriteria == "id_Modulo") result = result.OrderBy(p => p.id_Modulo).Cast <RolPermisos>().ToList(); 
                 if (orderCriteria == "sID_Modulo") result = result.OrderBy(p => p.sid_Modulo).Cast <RolPermisos>().ToList(); 
                 if (orderCriteria == "Ver") result = result.OrderBy(p => p.Ver).Cast <RolPermisos>().ToList(); 
                 if (orderCriteria == "Crear") result = result.OrderBy(p => p.Crear).Cast <RolPermisos>().ToList(); 
                 if (orderCriteria == "Editar") result = result.OrderBy(p => p.Editar).Cast <RolPermisos>().ToList(); 
                 if (orderCriteria == "Eliminar") result = result.OrderBy(p => p.Eliminar).Cast <RolPermisos>().ToList(); 
                 if (orderCriteria == "Aprobar") result = result.OrderBy(p => p.Aprobar).Cast <RolPermisos>().ToList(); 
                 if (orderCriteria == "Imprimir") result = result.OrderBy(p => p.Imprimir).Cast <RolPermisos>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <RolPermisos>().ToList();  
                if (orderCriteria == "id_Rol") result = result.OrderByDescending(p => p.id_Rol).Cast <RolPermisos>().ToList(); 
                 if (orderCriteria == "sID_AspNetRoles") result = result.OrderByDescending(p => p.sid_Rol).Cast<RolPermisos>().ToList(); 
                 if (orderCriteria == "id_Modulo") result = result.OrderByDescending(p => p.id_Modulo).Cast <RolPermisos>().ToList(); 
                 if (orderCriteria == "sID_Modulo") result = result.OrderByDescending(p => p.sid_Modulo).Cast<RolPermisos>().ToList(); 
                 if (orderCriteria == "Ver") result = result.OrderByDescending(p => p.Ver).Cast <RolPermisos>().ToList(); 
                 if (orderCriteria == "Crear") result = result.OrderByDescending(p => p.Crear).Cast <RolPermisos>().ToList(); 
                 if (orderCriteria == "Editar") result = result.OrderByDescending(p => p.Editar).Cast <RolPermisos>().ToList(); 
                 if (orderCriteria == "Eliminar") result = result.OrderByDescending(p => p.Eliminar).Cast <RolPermisos>().ToList(); 
                 if (orderCriteria == "Aprobar") result = result.OrderByDescending(p => p.Aprobar).Cast <RolPermisos>().ToList(); 
                 if (orderCriteria == "Imprimir") result = result.OrderByDescending(p => p.Imprimir).Cast <RolPermisos>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.id_Rol != null && r.id_Rol.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sid_Rol != null && r.sid_Rol.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.id_Modulo != null && r.id_Modulo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sid_Modulo != null && r.sid_Modulo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Ver != null && r.Ver.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Crear != null && r.Crear.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Editar != null && r.Editar.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Eliminar != null && r.Eliminar.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Aprobar != null && r.Aprobar.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Imprimir != null && r.Imprimir.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad RolPermisos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguridad de la entidad  RolPermisos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de RolPermisos</param>
        /// <response code="200">RolPermisos Consulto los registros exitosamente</response>
        /// <response code="400">RolPermisos tiene valores invalidos </response>
        /// <response code="401">RolPermisos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar RolPermisos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new RolPermisosMs().GetAllByWithRelation().Cast<RolPermisos>().AsQueryable();
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
