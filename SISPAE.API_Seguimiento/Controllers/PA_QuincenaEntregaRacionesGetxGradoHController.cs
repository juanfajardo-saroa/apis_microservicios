
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
using Microsoft.AspNetCore.OData.Query; using ElmahCore;




// create, index, delete, update , read
//  details, listall, 

namespace SISPAE.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de PA_QuincenaEntregaRacionesGetxGradoH .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PA_QuincenaEntregaRacionesGetxGradoHController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PA_QuincenaEntregaRacionesGetxGradoH --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  PA_QuincenaEntregaRacionesGetxGradoH!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PA_QuincenaEntregaRacionesGetxGradoH</param>
        /// <response code="200">PA_QuincenaEntregaRacionesGetxGradoH Consulto los registros exitosamente</response>
        /// <response code="400">PA_QuincenaEntregaRacionesGetxGradoH tiene valores invalidos </response>
        /// <response code="401">PA_QuincenaEntregaRacionesGetxGradoH No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PA_QuincenaEntregaRacionesGetxGradoH en este momento</response>

            [EnableQuery()]
            [Authorize]
             [HttpGet]
            public IActionResult GetAll( int? Id_Contrato,int? Id_Operador,int? Id_Grado,int? racionesDiarias,int? Id_SedeJornada,DateTime? Fecha_Ini,DateTime? Fecha_Fin)
            {

                try
                {
                    var result = new PA_QuincenaEntregaRacionesGetxGradoHMs().GetPA_QuincenaEntregaRacionesGetxGradoH(Id_Contrato,Id_Operador,Id_Grado,racionesDiarias,Id_SedeJornada,Fecha_Ini,Fecha_Fin).Cast<PA_QuincenaEntregaRacionesGetxGradoH>().AsQueryable();
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
