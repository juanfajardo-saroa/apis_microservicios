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
    [SwaggerTag("Web API para CRUD de AspNetRoleClaims .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class AspNetRoleClaimsController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad AspNetRoleClaims --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguridad de la entidad  AspNetRoleClaims!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AspNetRoleClaims</param>
        /// <response code="200">AspNetRoleClaims Consulto los registros exitosamente</response>
        /// <response code="400">AspNetRoleClaims tiene valores invalidos </response>
        /// <response code="401">AspNetRoleClaims No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AspNetRoleClaims en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new AspNetRoleClaimsMs().GetAll().Cast<AspNetRoleClaims>().AsQueryable();
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
        /// CRUD de la entidad AspNetRoleClaims --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguridad de la entidad  AspNetRoleClaims!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AspNetRoleClaims</param>
        /// <response code="200">AspNetRoleClaims Consulto los registros exitosamente</response>
        /// <response code="400">AspNetRoleClaims tiene valores invalidos </response>
        /// <response code="401">AspNetRoleClaims No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AspNetRoleClaims en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new AspNetRoleClaimsMs().GetAllFull().Cast<AspNetRoleClaims>().AsQueryable();
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
        /// CRUD de la entidad AspNetRoleClaims --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguridad de la entidad  AspNetRoleClaims!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AspNetRoleClaims</param>
        /// <response code="200">AspNetRoleClaims Consulto los registros exitosamente</response>
        /// <response code="400">AspNetRoleClaims tiene valores invalidos </response>
        /// <response code="401">AspNetRoleClaims No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar AspNetRoleClaims en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new AspNetRoleClaimsMs().GetById(new AspNetRoleClaims() { Id = id });
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
        /// CRUD de la entidad AspNetRoleClaims --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Seguridad de la entidad  AspNetRoleClaims!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de AspNetRoleClaims</param>
        /// <response code="200">AspNetRoleClaims Creado</response>
        /// <response code="400">AspNetRoleClaims tiene valores invalidos </response>
        /// <response code="401">AspNetRoleClaims No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear AspNetRoleClaims en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] AspNetRoleClaims obj)
        {
            try
            {
                var result = new AspNetRoleClaimsMs().Add(obj);
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
        /// CRUD de la entidad AspNetRoleClaims --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Seguridad de la entidad  AspNetRoleClaims!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de AspNetRoleClaims</param>
        /// <response code="200">AspNetRoleClaims Actualizado</response>
        /// <response code="400">AspNetRoleClaims tiene valores invalidos </response>
        /// <response code="401">AspNetRoleClaims No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar AspNetRoleClaims en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] AspNetRoleClaims obj)
        {
            try
            {
                var result = new AspNetRoleClaimsMs().Update(obj);
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
        /// CRUD de la entidad AspNetRoleClaims --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Seguridad de la entidad  AspNetRoleClaims!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de AspNetRoleClaims</param>
        /// <response code="200">AspNetRoleClaims Eliminado</response>
        /// <response code="400">AspNetRoleClaims tiene valores invalidos </response>
        /// <response code="401">AspNetRoleClaims No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar AspNetRoleClaims en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] AspNetRoleClaims obj)
        {
           try
            {
                new AspNetRoleClaimsMs().Delete(obj);
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
        /// DataTable de la entidad AspNetRoleClaims --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  AspNetRoleClaims!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de AspNetRoleClaims</param>
        /// <response code="200">AspNetRoleClaims Resultado</response>
        /// <response code="400">AspNetRoleClaims tiene valores invalidos </response>
        /// <response code="401">AspNetRoleClaims No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  AspNetRoleClaims en este momento</response>
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

                var result = new AspNetRoleClaimsMs().GetAllByWithRelation().Cast<AspNetRoleClaims>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="Id") result = result.OrderBy(p => p.Id).Cast <AspNetRoleClaims>().ToList();  
                if (orderCriteria == "RoleId") result = result.OrderBy(p => p.RoleId).Cast <AspNetRoleClaims>().ToList(); 
                 if (orderCriteria == "sID_AspNetRoles") result = result.OrderBy(p => p.sRoleId).Cast <AspNetRoleClaims>().ToList(); 
                 if (orderCriteria == "ClaimType") result = result.OrderBy(p => p.ClaimType).Cast <AspNetRoleClaims>().ToList(); 
                 if (orderCriteria == "ClaimValue") result = result.OrderBy(p => p.ClaimValue).Cast <AspNetRoleClaims>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "Id") result = result.OrderByDescending(p => p.Id).Cast <AspNetRoleClaims>().ToList();  
                if (orderCriteria == "RoleId") result = result.OrderByDescending(p => p.RoleId).Cast <AspNetRoleClaims>().ToList(); 
                 if (orderCriteria == "sID_AspNetRoles") result = result.OrderByDescending(p => p.sRoleId).Cast<AspNetRoleClaims>().ToList(); 
                 if (orderCriteria == "ClaimType") result = result.OrderByDescending(p => p.ClaimType).Cast <AspNetRoleClaims>().ToList(); 
                 if (orderCriteria == "ClaimValue") result = result.OrderByDescending(p => p.ClaimValue).Cast <AspNetRoleClaims>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.Id != null && r.Id.ToString().Contains(searchBy.ToUpper())  
                 || r.RoleId != null && r.RoleId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sRoleId != null && r.sRoleId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ClaimType != null && r.ClaimType.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ClaimValue != null && r.ClaimValue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
                    data[i].sID = SISPAE.Common.Utilidades.Encrypt($"id={data[i].Id.ToString()}");
                   
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
        /// CRUD de la entidad AspNetRoleClaims --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguridad de la entidad  AspNetRoleClaims!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AspNetRoleClaims</param>
        /// <response code="200">AspNetRoleClaims Consulto los registros exitosamente</response>
        /// <response code="400">AspNetRoleClaims tiene valores invalidos </response>
        /// <response code="401">AspNetRoleClaims No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AspNetRoleClaims en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new AspNetRoleClaimsMs().GetAllByWithRelation().Cast<AspNetRoleClaims>().AsQueryable();
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
