
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
    [SwaggerTag("Web API para CRUD de PA_SedeGetbyETC .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PA_SedeGetbyETCController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PA_SedeGetbyETC --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Priorizacion de la entidad  PA_SedeGetbyETC!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PA_SedeGetbyETC</param>
        /// <response code="200">PA_SedeGetbyETC Consulto los registros exitosamente</response>
        /// <response code="400">PA_SedeGetbyETC tiene valores invalidos </response>
        /// <response code="401">PA_SedeGetbyETC No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PA_SedeGetbyETC en este momento</response>

            [EnableQuery()]
            [Authorize]
             [HttpGet]
            public IActionResult GetAll( int? id_ETC,int? id_tipoMunicipio,int? id_Divipola,int? id_IE)
            {

                try
                {
                    var result = new PA_SedeGetbyETCMs().GetPA_SedeGetbyETC(id_ETC,id_tipoMunicipio,id_Divipola,id_IE).Cast<PA_SedeGetbyETC>().AsQueryable();
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
