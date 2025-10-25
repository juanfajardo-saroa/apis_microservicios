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
using SISPAE.Business.Services;

namespace SISPAE_API_Priorizacion.WebAPI.Controllers
{

    [SwaggerTag("Web API para CRUD de A_PriorizaUpdateEstadoPrio .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PA_PriorizaUpdateEstadoPrioController : Controller
    {
        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PA_Paso1Fin --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  PA_Paso1Fin!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PA_Paso1Fin</param>
        /// <response code="200">PA_Paso1Fin Consulto los registros exitosamente</response>
        /// <response code="400">PA_Paso1Fin tiene valores invalidos </response>
        /// <response code="401">PA_Paso1Fin No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PA_Paso1Fin en este momento</response>

        [EnableQuery()]
        [Authorize]
        [HttpGet]
        public IActionResult GetAll(int id_Sede, int id_Vigencia, int ID_TipoEstadoPriorizacion, string auditoria)
        {

            try
            {
                var result = new PA_PriorizaUpdateEstadoPrioMs().GetPA_PriorizaUpdateEstadoPrio(id_Sede, id_Vigencia,ID_TipoEstadoPriorizacion, auditoria);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                ;
                return BadRequest(ex.Message);
            }
        }
    }
}
