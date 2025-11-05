
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
    [SwaggerTag("Web API para CRUD de PA_PrioSedeAsignaRacion .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PA_PrioSedeAsignaRacionController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PA_PrioSedeAsignaRacion --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Priorizacion de la entidad  PA_PrioSedeAsignaRacion!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PA_PrioSedeAsignaRacion</param>
        /// <response code="200">PA_PrioSedeAsignaRacion Consulto los registros exitosamente</response>
        /// <response code="400">PA_PrioSedeAsignaRacion tiene valores invalidos </response>
        /// <response code="401">PA_PrioSedeAsignaRacion No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PA_PrioSedeAsignaRacion en este momento</response>

            [EnableQuery()]
            [Authorize]
             [HttpGet]
            public IActionResult GetAll( int? id_ETC,int? Id_Vigencia,int? Id_TipoMunicipio,int? Id_Municipio,int? Id_InstEducativa,int? Id_sede,int? Id_Jornada,int? Id_NivelEducativo,int? Id_Zona,int? Id_CriterioVul,int? Id_EstadoPrio,int? id_Grado)
            {

                try
                {
                    var result = new PA_PrioSedeAsignaRacionMs().GetPA_PrioSedeAsignaRacion(id_ETC,Id_Vigencia,Id_TipoMunicipio,Id_Municipio,Id_InstEducativa,Id_sede,Id_Jornada,Id_NivelEducativo,Id_Zona,Id_CriterioVul,Id_EstadoPrio,id_Grado).Cast<PA_PrioSedeAsignaRacion>().AsQueryable();
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
