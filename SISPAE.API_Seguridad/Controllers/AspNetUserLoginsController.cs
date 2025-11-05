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
using ElmahCore; using ElmahCore;
using ElmahCore;



// create, index, delete, update , read
//  details, listall, 

namespace SISPAE.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de AspNetUserLogins .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class AspNetUserLoginsController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad AspNetUserLogins --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  AspNetUserLogins!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AspNetUserLogins</param>
        /// <response code="200">AspNetUserLogins Consulto los registros exitosamente</response>
        /// <response code="400">AspNetUserLogins tiene valores invalidos </response>
        /// <response code="401">AspNetUserLogins No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AspNetUserLogins en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new AspNetUserLoginsMs().GetAll().Cast<AspNetUserLogins>().AsQueryable();
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
        /// CRUD de la entidad AspNetUserLogins --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  AspNetUserLogins!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AspNetUserLogins</param>
        /// <response code="200">AspNetUserLogins Consulto los registros exitosamente</response>
        /// <response code="400">AspNetUserLogins tiene valores invalidos </response>
        /// <response code="401">AspNetUserLogins No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AspNetUserLogins en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new AspNetUserLoginsMs().GetAllFull().Cast<AspNetUserLogins>().AsQueryable();
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
        /// CRUD de la entidad AspNetUserLogins --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  AspNetUserLogins!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AspNetUserLogins</param>
        /// <response code="200">AspNetUserLogins Consulto los registros exitosamente</response>
        /// <response code="400">AspNetUserLogins tiene valores invalidos </response>
        /// <response code="401">AspNetUserLogins No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar AspNetUserLogins en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(string id)
        {
            try
            {
                var result = new AspNetUserLogins();//.GetById(new AspNetUserLogins() { LoginProvider = id });
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
        /// CRUD de la entidad AspNetUserLogins --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE de la entidad  AspNetUserLogins!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de AspNetUserLogins</param>
        /// <response code="200">AspNetUserLogins Creado</response>
        /// <response code="400">AspNetUserLogins tiene valores invalidos </response>
        /// <response code="401">AspNetUserLogins No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear AspNetUserLogins en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] AspNetUserLogins obj)
        {
            try
            {
                var result = new AspNetUserLoginsMs().Add(obj);
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
        /// CRUD de la entidad AspNetUserLogins --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE de la entidad  AspNetUserLogins!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de AspNetUserLogins</param>
        /// <response code="200">AspNetUserLogins Actualizado</response>
        /// <response code="400">AspNetUserLogins tiene valores invalidos </response>
        /// <response code="401">AspNetUserLogins No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar AspNetUserLogins en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] AspNetUserLogins obj)
        {
            try
            {
                var result = new AspNetUserLoginsMs().Update(obj);
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
        /// CRUD de la entidad AspNetUserLogins --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE de la entidad  AspNetUserLogins!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de AspNetUserLogins</param>
        /// <response code="200">AspNetUserLogins Eliminado</response>
        /// <response code="400">AspNetUserLogins tiene valores invalidos </response>
        /// <response code="401">AspNetUserLogins No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar AspNetUserLogins en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] AspNetUserLogins obj)
        {
           try
            {
                new AspNetUserLoginsMs().Delete(obj);
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
        /// DataTable de la entidad AspNetUserLogins --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  AspNetUserLogins!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de AspNetUserLogins</param>
        /// <response code="200">AspNetUserLogins Resultado</response>
        /// <response code="400">AspNetUserLogins tiene valores invalidos </response>
        /// <response code="401">AspNetUserLogins No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  AspNetUserLogins en este momento</response>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LoadTable([FromBody] DtParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;

            var orderCriteria = "LoginProvider";
            var orderAscendingDirection = true;

             try
 {
			
	if (dtParameters.Order != null)
	{
	// in this example we just default sort on the 1st column
	orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
	orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
	}
                var result = new AspNetUserLoginsMs().GetAllByWithRelation().Cast<AspNetUserLogins>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                  if (orderAscendingDirection)                  {                  if (orderCriteria == "LoginProvider") result = result.OrderBy(p => p.LoginProvider).Cast <AspNetUserLogins>().ToList(); 
                   if (orderCriteria == "ProviderKey") result = result.OrderBy(p => p.ProviderKey).Cast <AspNetUserLogins>().ToList(); 
                   if (orderCriteria == "ProviderDisplayName") result = result.OrderBy(p => p.ProviderDisplayName).Cast <AspNetUserLogins>().ToList(); 
                   if (orderCriteria == "UserId") result = result.OrderBy(p => p.UserId).Cast <AspNetUserLogins>().ToList(); 
                   if (orderCriteria == "sID_AspNetUsers") result = result.OrderBy(p => p.sUserId).Cast <AspNetUserLogins>().ToList(); 
                   }
  else 
                    {                  if (orderCriteria == "LoginProvider") result = result.OrderByDescending(p => p.LoginProvider).Cast <AspNetUserLogins>().ToList(); 
                   if (orderCriteria == "ProviderKey") result = result.OrderByDescending(p => p.ProviderKey).Cast <AspNetUserLogins>().ToList(); 
                   if (orderCriteria == "ProviderDisplayName") result = result.OrderByDescending(p => p.ProviderDisplayName).Cast <AspNetUserLogins>().ToList(); 
                   if (orderCriteria == "UserId") result = result.OrderByDescending(p => p.UserId).Cast <AspNetUserLogins>().ToList(); 
                   if (orderCriteria == "sID_AspNetUsers") result = result.OrderByDescending(p => p.sUserId).Cast<AspNetUserLogins>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r=> r.LoginProvider != null && r.LoginProvider.ToString().Contains(searchBy.ToUpper())  
                   || r.ProviderKey != null && r.ProviderKey.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ProviderDisplayName != null && r.ProviderDisplayName.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.UserId != null && r.UserId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                  || r.sUserId != null && r.sUserId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
  
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
                //    data[i].sID = SISPAE.Common.Utilidades.Encrypt($"id={data[i].LoginProvider.ToString()}");
                   
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
        /// CRUD de la entidad AspNetUserLogins --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  AspNetUserLogins!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AspNetUserLogins</param>
        /// <response code="200">AspNetUserLogins Consulto los registros exitosamente</response>
        /// <response code="400">AspNetUserLogins tiene valores invalidos </response>
        /// <response code="401">AspNetUserLogins No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AspNetUserLogins en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new AspNetUserLoginsMs().GetAllByWithRelation().Cast<AspNetUserLogins>().AsQueryable();
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
