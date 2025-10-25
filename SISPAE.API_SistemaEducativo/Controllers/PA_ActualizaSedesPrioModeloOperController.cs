
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

namespace SISPAE_API_SistemaEducativo.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de PA_ActualizaSedesPrioModeloOper .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PA_ActualizaSedesPrioModeloOperController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PA_ActualizaSedesPrioModeloOper --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  PA_ActualizaSedesPrioModeloOper!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PA_ActualizaSedesPrioModeloOper</param>
        /// <response code="200">PA_ActualizaSedesPrioModeloOper Consulto los registros exitosamente</response>
        /// <response code="400">PA_ActualizaSedesPrioModeloOper tiene valores invalidos </response>
        /// <response code="401">PA_ActualizaSedesPrioModeloOper No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PA_ActualizaSedesPrioModeloOper en este momento</response>

            [EnableQuery()]
            [Authorize]
             [HttpGet]
            public IActionResult GetAll( int? Id_ETC,int? Id_TipoMunicipio,int? Id_Divipola,int? ID_IE,int? id_sede,int? jor,int? nivel,int? zona,Decimal? Vulnerabilidad,int? id_EstadoPriorizacion,int? PrioPAE,int? ModeloOper,String? auditoria)
            {

                try
                {
                    var result = new PA_ActualizaSedesPrioModeloOperMs().GetPA_ActualizaSedesPrioModeloOper(Id_ETC,Id_TipoMunicipio,Id_Divipola,ID_IE,id_sede,jor,nivel,zona,Vulnerabilidad,id_EstadoPriorizacion,PrioPAE,ModeloOper,auditoria).Cast<PA_ActualizaSedesPrioModeloOper>().AsQueryable();
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
