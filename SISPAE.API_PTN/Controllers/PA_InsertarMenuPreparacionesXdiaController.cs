
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




// create, index, delete, update , read
//  details, listall, 

namespace SISPAE_API_PTN.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de PA_InsertarMenuPreparacionesXdiaController .")]
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public partial class PA_InsertarMenuPreparacionesXdiaController : ControllerBase
    {


        [EnableQuery()]
        [Authorize]
        [HttpGet]
        public IActionResult GetAll(int ID_CiclosMenu, int ID_Preparacion, int id_Semana, int Nrodia, string?  auditoria = null)
        {

            try
            {
                var result = new PA_InsertarMenuPreparacionesXdiaMs().GetPA_InsertarMenuPreparacionesXdia(ID_CiclosMenu,ID_Preparacion,id_Semana,Nrodia,auditoria).Cast<PA_InsertarMenuPreparacionesXdia>().AsQueryable();
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
