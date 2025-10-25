
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
    [SwaggerTag("Web API para CRUD de PA_Departamentos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public partial class PA_DepartamentosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PA_Departamentos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  PA_Departamentos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PA_Departamentos</param>
        /// <response code="200">PA_Departamentos Consulto los registros exitosamente</response>
        /// <response code="400">PA_Departamentos tiene valores invalidos </response>
        /// <response code="401">PA_Departamentos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PA_Departamentos en este momento</response>

        [EnableQuery()]
        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {

            try
            {
                var result = new PA_DepartamentosMs().GetPA_Departamentos().Cast<PA_Departamentos>().AsQueryable();
                //return Ok(result);

                // de acuerdo a los readme  33257 y y 33196, se dejan los departamentos quemados
                var departamentos = new List<object>
                {
                    new { DepartamentoCode = 91, DepartamentoNombre = "AMAZONAS" },
                    new { DepartamentoCode = 5, DepartamentoNombre = "ANTIOQUIA" },
                    new { DepartamentoCode = 81, DepartamentoNombre = "ARAUCA" },
                    new { DepartamentoCode = 88, DepartamentoNombre = "ARCHIPIÉLAGO DE SAN ANDRÉS, PROVDepartamentoCodeENCIA Y SANTA CATALINA" },
                    new { DepartamentoCode = 8, DepartamentoNombre = "ATLÁNTICO" },
                    new { DepartamentoCode = 11, DepartamentoNombre = "BOGOTÁ, D.C." },
                    new { DepartamentoCode = 13, DepartamentoNombre = "BOLÍVAR" },
                    new { DepartamentoCode = 15, DepartamentoNombre = "BOYACÁ" },
                    new { DepartamentoCode = 17, DepartamentoNombre = "CALDAS" },
                    new { DepartamentoCode = 18, DepartamentoNombre = "CAQUETÁ" },
                    new { DepartamentoCode = 85, DepartamentoNombre = "CASANARE" },
                    new { DepartamentoCode = 19, DepartamentoNombre = "CAUCA" },
                    new { DepartamentoCode = 20, DepartamentoNombre = "CESAR" },
                    new { DepartamentoCode = 27, DepartamentoNombre = "CHOCÓ" },
                    new { DepartamentoCode = 23, DepartamentoNombre = "CÓRDOBA" },
                    new { DepartamentoCode = 25, DepartamentoNombre = "CUNDINAMARCA" },
                    new { DepartamentoCode = 94, DepartamentoNombre = "GUAINÍA" },
                    new { DepartamentoCode = 95, DepartamentoNombre = "GUAVIARE" },
                    new { DepartamentoCode = 41, DepartamentoNombre = "HUILA" },
                    new { DepartamentoCode = 44, DepartamentoNombre = "LA GUAJIRA" },
                    new { DepartamentoCode = 47, DepartamentoNombre = "MAGDALENA" },
                    new { DepartamentoCode = 50, DepartamentoNombre = "META" },
                    new { DepartamentoCode = 52, DepartamentoNombre = "NARIÑO" },
                    new { DepartamentoCode = 54, DepartamentoNombre = "NORTE DE SANTANDER" },
                    new { DepartamentoCode = 86, DepartamentoNombre = "PUTUMAYO" },
                    new { DepartamentoCode = 63, DepartamentoNombre = "QUINDÍO" },
                    new { DepartamentoCode = 66, DepartamentoNombre = "RISARALDA" },
                    new { DepartamentoCode = 68, DepartamentoNombre = "SANTANDER" },
                    new { DepartamentoCode = 70, DepartamentoNombre = "SUCRE" },
                    new { DepartamentoCode = 73, DepartamentoNombre = "TOLIMA" },
                    new { DepartamentoCode = 76, DepartamentoNombre = "VALLE DEL CAUCA" },
                    new { DepartamentoCode = 97, DepartamentoNombre = "VAUPÉS" },
                    new { DepartamentoCode = 99, DepartamentoNombre = "VICHADA" }

                };

                return Ok(departamentos);
            }
            catch (System.Exception ex)
            {
                HttpContext.RaiseError(new InvalidOperationException(ex.Message));
                return BadRequest(ex.Message);
            }
        }
    }
}
