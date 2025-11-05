
/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano				:2022
/// Arquitectura	:Patron MVC ASP Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa			:WEBAPI (WEBAPI Entity Layer) - Capa WEB API (Source: MVC7_ControllersAPI_Base.cs)    
/// </Derechos_Reservados>


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

using SISPAE.Business;
using SISPAE.Model;

using Swashbuckle.AspNetCore.Annotations;




// create, index, delete, update , read
//  details, listall, 

namespace SISPAE_API_GestionExcedentes.WebAPI.Controllers
    {
    [SwaggerTag("Web API para CRUD de PA_ReporteExcedentes .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PA_ReporteExcedentesController : ControllerBase
        {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PA_ReporteExcedentes --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_GestionExcedentes de la entidad  PA_ReporteExcedentes!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PA_ReporteExcedentes</param>
        /// <response code="200">PA_ReporteExcedentes Consulto los registros exitosamente</response>
        /// <response code="400">PA_ReporteExcedentes tiene valores invalidos </response>
        /// <response code="401">PA_ReporteExcedentes No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PA_ReporteExcedentes en este momento</response>

        [EnableQuery()]
        [Authorize]
        [HttpGet]
        public IActionResult GetAll(int? Id_ETC)
            {

            try
                {
                var result = new PA_ReporteExcedentesMs().GetPA_ReporteExcedentes(Id_ETC).Cast<PA_ReporteExcedentes>().AsQueryable();
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }
        }
    }
