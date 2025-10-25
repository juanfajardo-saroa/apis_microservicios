
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

namespace SISPAE_API_Infraestructura.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de PA_DiagnosticoInfraEst .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PA_DiagnosticoInfraEstController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PA_DiagnosticoInfraEst --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Infraestructura de la entidad  PA_DiagnosticoInfraEst!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PA_DiagnosticoInfraEst</param>
        /// <response code="200">PA_DiagnosticoInfraEst Consulto los registros exitosamente</response>
        /// <response code="400">PA_DiagnosticoInfraEst tiene valores invalidos </response>
        /// <response code="401">PA_DiagnosticoInfraEst No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PA_DiagnosticoInfraEst en este momento</response>

            [EnableQuery()]
            [Authorize]
             [HttpGet]
            public IActionResult GetAll( int? id_ETC,String? auditoria, int? Id_institucionEducativa)
            {


                try
                {
                    var result = new PA_DiagnosticoInfraEstMs().GetPA_DiagnosticoInfraEst(id_ETC,auditoria,Id_institucionEducativa).Cast<PA_DiagnosticoInfraEst>().AsQueryable();
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
