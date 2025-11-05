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

namespace SISPAE.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de AspNetRoles .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class AspNetRolesController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad AspNetRoles --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  AspNetRoles!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AspNetRoles</param>
        /// <response code="200">AspNetRoles Consulto los registros exitosamente</response>
        /// <response code="400">AspNetRoles tiene valores invalidos </response>
        /// <response code="401">AspNetRoles No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AspNetRoles en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new AspNetRolesMs().GetAll().Cast<AspNetRoles>().AsQueryable();
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
        /// CRUD de la entidad AspNetRoles --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  AspNetRoles!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AspNetRoles</param>
        /// <response code="200">AspNetRoles Consulto los registros exitosamente</response>
        /// <response code="400">AspNetRoles tiene valores invalidos </response>
        /// <response code="401">AspNetRoles No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AspNetRoles en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {

            try
            {
                var result = new AspNetRolesMs().GetAllFull().Cast<AspNetRoles>().AsQueryable();
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
        /// CRUD de la entidad AspNetRoles --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  AspNetRoles!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AspNetRoles</param>
        /// <response code="200">AspNetRoles Consulto los registros exitosamente</response>
        /// <response code="400">AspNetRoles tiene valores invalidos </response>
        /// <response code="401">AspNetRoles No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar AspNetRoles en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(string id)
        {
            try
            {
                var result = new AspNetRolesMs().GetById(new AspNetRoles() { Id = id });
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
        /// CRUD de la entidad AspNetRoles --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE de la entidad  AspNetRoles!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de AspNetRoles</param>
        /// <response code="200">AspNetRoles Creado</response>
        /// <response code="400">AspNetRoles tiene valores invalidos </response>
        /// <response code="401">AspNetRoles No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear AspNetRoles en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] AspNetRoles obj)
        {
            try
            {
                //IdentityResult roleResult;
                //bool adminRoleExists = _roleManager.RoleExistsAsync("Admin").Result;
                //                if (!adminRoleExists)
                //                {
                //                    //IdentityResult rr = _roleManager.CreateAsync(new IdentityRole("name"));

                //                    var id = new Microsoft.AspNetCore.Identity.IdentityRole("Admin").Id;
                ////                    roleResult =  _roleManager.CreateAsync(new Microsoft.AspNetCore.Identity.IdentityRole("Admin").Id);
                //                }

                List<AspNetRoles> lr = new AspNetRolesMs().GetAll().Cast<AspNetRoles>().Where(r => r.Name.ToLower() == obj.Name.ToLower()).ToList();

                if (lr.Count() > 0)
                    return BadRequest("El rol ya existe");


                obj.Id = Guid.NewGuid().ToString();
                var result = new AspNetRolesMs().Add(obj);
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
        /// CRUD de la entidad AspNetRoles --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE de la entidad  AspNetRoles!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de AspNetRoles</param>
        /// <response code="200">AspNetRoles Actualizado</response>
        /// <response code="400">AspNetRoles tiene valores invalidos </response>
        /// <response code="401">AspNetRoles No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar AspNetRoles en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] AspNetRoles obj)
        {
            try
            {
                var result = new AspNetRolesMs().Update(obj);
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
        /// CRUD de la entidad AspNetRoles --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE de la entidad  AspNetRoles!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de AspNetRoles</param>
        /// <response code="200">AspNetRoles Eliminado</response>
        /// <response code="400">AspNetRoles tiene valores invalidos </response>
        /// <response code="401">AspNetRoles No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar AspNetRoles en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] AspNetRoles obj)
        {
            try
            {
                new AspNetRolesMs().Delete(obj);
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
        /// DataTable de la entidad AspNetRoles --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  AspNetRoles!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de AspNetRoles</param>
        /// <response code="200">AspNetRoles Resultado</response>
        /// <response code="400">AspNetRoles tiene valores invalidos </response>
        /// <response code="401">AspNetRoles No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  AspNetRoles en este momento</response>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LoadTable([FromBody] DtParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;

            var orderCriteria = "Id";
            var orderAscendingDirection = true;

             try
 {
			
	if (dtParameters.Order != null)
	{
	// in this example we just default sort on the 1st column
	orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
	orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
	}
                var result = new AspNetRolesMs().GetAllByWithRelation().Cast<AspNetRoles>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                if (orderAscendingDirection)
                {
                    if (orderCriteria == "Id") result = result.OrderBy(p => p.Id).Cast<AspNetRoles>().ToList();
                    if (orderCriteria == "Name") result = result.OrderBy(p => p.Name).Cast<AspNetRoles>().ToList();
                    if (orderCriteria == "NormalizedName") result = result.OrderBy(p => p.NormalizedName).Cast<AspNetRoles>().ToList();
                    if (orderCriteria == "ConcurrencyStamp") result = result.OrderBy(p => p.ConcurrencyStamp).Cast<AspNetRoles>().ToList();
                    if (orderCriteria == "id_TipoRoles") result = result.OrderBy(p => p.id_TipoRoles).Cast<AspNetRoles>().ToList();
                    if (orderCriteria == "sID_TipoRoles") result = result.OrderBy(p => p.sid_TipoRoles).Cast<AspNetRoles>().ToList();
                }
                else
                {
                    if (orderCriteria == "Id") result = result.OrderByDescending(p => p.Id).Cast<AspNetRoles>().ToList();
                    if (orderCriteria == "Name") result = result.OrderByDescending(p => p.Name).Cast<AspNetRoles>().ToList();
                    if (orderCriteria == "NormalizedName") result = result.OrderByDescending(p => p.NormalizedName).Cast<AspNetRoles>().ToList();
                    if (orderCriteria == "ConcurrencyStamp") result = result.OrderByDescending(p => p.ConcurrencyStamp).Cast<AspNetRoles>().ToList();
                    if (orderCriteria == "id_TipoRoles") result = result.OrderByDescending(p => p.id_TipoRoles).Cast<AspNetRoles>().ToList();
                    if (orderCriteria == "sID_TipoRoles") result = result.OrderByDescending(p => p.sid_TipoRoles).Cast<AspNetRoles>().ToList();
                }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r => r.Id != null && r.Id.ToString().Contains(searchBy.ToUpper())
                   || r.Name != null && r.Name.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.NormalizedName != null && r.NormalizedName.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.ConcurrencyStamp != null && r.ConcurrencyStamp.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.id_TipoRoles != null && r.id_TipoRoles.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.sid_TipoRoles != null && r.sid_TipoRoles.ToString().ToUpper().Contains(searchBy.ToUpper())

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


                //for (int i = 0; i < data.Count; i++)
                //{
                //    data[i].sID = SISPAE.Common.Utilidades.Encrypt($"id={data[i].Id.ToString()}");

                //}

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
        /// CRUD de la entidad AspNetRoles --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  AspNetRoles!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AspNetRoles</param>
        /// <response code="200">AspNetRoles Consulto los registros exitosamente</response>
        /// <response code="400">AspNetRoles tiene valores invalidos </response>
        /// <response code="401">AspNetRoles No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AspNetRoles en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new AspNetRolesMs().GetAllByWithRelation().Cast<AspNetRoles>().AsQueryable();
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
