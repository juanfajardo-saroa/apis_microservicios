
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




// create, index, delete, update , read
//  details, listall, 

namespace SISPAE_API_Aprobaciones.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de PA_AprobacionesGetAllFull .")]
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public partial class PA_AprobacionesGetAllFullController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PA_AprobacionesGetAllFull --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Aprobaciones de la entidad  PA_AprobacionesGetAllFull!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PA_AprobacionesGetAllFull</param>
        /// <response code="200">PA_AprobacionesGetAllFull Consulto los registros exitosamente</response>
        /// <response code="400">PA_AprobacionesGetAllFull tiene valores invalidos </response>
        /// <response code="401">PA_AprobacionesGetAllFull No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PA_AprobacionesGetAllFull en este momento</response>

            [EnableQuery()]
            [Authorize]
             [HttpGet]
            public IActionResult GetAll( int? Id_Secciones)
            {

                try
                {
                    var result = new PA_AprobacionesGetAllFullMs().GetPA_AprobacionesGetAllFull(Id_Secciones).Cast<PA_AprobacionesGetAllFull>().AsQueryable();
                    return Ok(result);
                }
                catch (System.Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
    }
}
