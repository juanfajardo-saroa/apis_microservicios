
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

namespace SISPAE_API_PTN.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de PA_CicloMenuAportesNutricionalesPivSem .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PA_CicloMenuAportesNutricionalesPivSemController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PA_CicloMenuAportesNutricionalesPivSem --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  PA_CicloMenuAportesNutricionalesPivSem!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PA_CicloMenuAportesNutricionalesPivSem</param>
        /// <response code="200">PA_CicloMenuAportesNutricionalesPivSem Consulto los registros exitosamente</response>
        /// <response code="400">PA_CicloMenuAportesNutricionalesPivSem tiene valores invalidos </response>
        /// <response code="401">PA_CicloMenuAportesNutricionalesPivSem No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PA_CicloMenuAportesNutricionalesPivSem en este momento</response>

            [EnableQuery()]
            [Authorize]
             [HttpGet]
            public IActionResult GetAll( int? ID_Etc,int? ID_TipoModeloOperacion,int? ID_TipoComplemento,int? ID_TipoModalidadComplemento,int? ID_MinutaPatronAlimento,int? ID_CiclosMenuReferencia,int? ID_TipoNivelEducativo,int? ID_Zona,int? ID_CicloMenu,int? ID_Preparacion,int? ID_Semana)
            {

                try
                {
                    var result = new PA_CicloMenuAportesNutricionalesPivSemMs().GetPA_CicloMenuAportesNutricionalesPivSem(ID_Etc,ID_TipoModeloOperacion,ID_TipoComplemento,ID_TipoModalidadComplemento,ID_MinutaPatronAlimento,ID_CiclosMenuReferencia,ID_TipoNivelEducativo,ID_Zona,ID_CicloMenu,ID_Preparacion,ID_Semana).Cast<PA_CicloMenuAportesNutricionalesPivSem>().AsQueryable();
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
