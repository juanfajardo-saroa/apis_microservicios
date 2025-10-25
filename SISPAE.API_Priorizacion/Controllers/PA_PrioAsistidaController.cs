
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
    [SwaggerTag("Web API para CRUD de PA_PrioAsistida .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PA_PrioAsistidaController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PA_PrioAsistida --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Priorizacion de la entidad  PA_PrioAsistida!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PA_PrioAsistida</param>
        /// <response code="200">PA_PrioAsistida Consulto los registros exitosamente</response>
        /// <response code="400">PA_PrioAsistida tiene valores invalidos </response>
        /// <response code="401">PA_PrioAsistida No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PA_PrioAsistida en este momento</response>

            [EnableQuery()]
            [Authorize]
             [HttpGet]
            public IActionResult GetAll( int? Id_ETC,int? Id_Vingencia,int? Id_TipoMunicipio,int? Id_Divipola,int? id_gradosedejornada,int? jor,int? nivel,int? zona,Decimal? Vulnerabilidad,int? modelo,int? modalidad,int? tipoRac,int? relleno,String? auditoria)
            {

                try
                {
                    var result = new PA_PrioAsistidaMs().GetPA_PrioAsistida(Id_ETC,Id_Vingencia,Id_TipoMunicipio,Id_Divipola,id_gradosedejornada,jor,nivel,zona,Vulnerabilidad,modelo,modalidad,tipoRac,relleno,auditoria).Cast<PA_PrioAsistida>().AsQueryable();
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
