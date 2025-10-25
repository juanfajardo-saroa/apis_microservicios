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
    [SwaggerTag("Web API para CRUD de MenuPTN .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class MenuPTNController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad MenuPTN --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  MenuPTN!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MenuPTN</param>
        /// <response code="200">MenuPTN Consulto los registros exitosamente</response>
        /// <response code="400">MenuPTN tiene valores invalidos </response>
        /// <response code="401">MenuPTN No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MenuPTN en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new MenuPTNMs().GetAll().Cast<MenuPTN>().AsQueryable();
                return Ok(result);
            }
            catch (System.Exception ex)
            {
	        HttpContext.RaiseError(new InvalidOperationException(ex.Message)); 
                return BadRequest(ex.Message);
            }
        }


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad MenuPTN --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  MenuPTN!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MenuPTN</param>
        /// <response code="200">MenuPTN Consulto los registros exitosamente</response>
        /// <response code="400">MenuPTN tiene valores invalidos </response>
        /// <response code="401">MenuPTN No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MenuPTN en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new MenuPTNMs().GetAllFull().Cast<MenuPTN>().AsQueryable();
                return Ok(result);
            }
            catch (System.Exception ex)
            {
	        HttpContext.RaiseError(new InvalidOperationException(ex.Message)); 
                return BadRequest(ex.Message);
            }
        }



        // GET api/values/5
        /// <summary>
        /// CRUD de la entidad MenuPTN --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  MenuPTN!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MenuPTN</param>
        /// <response code="200">MenuPTN Consulto los registros exitosamente</response>
        /// <response code="400">MenuPTN tiene valores invalidos </response>
        /// <response code="401">MenuPTN No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar MenuPTN en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new MenuPTNMs().GetById(new MenuPTN() { id = id });
                return Ok(result);
            }
            catch (System.Exception ex)
            {
	        HttpContext.RaiseError(new InvalidOperationException(ex.Message)); 
                return BadRequest(ex.Message);
            }
        }



        // POST api/values
        /// <summary>
        /// CRUD de la entidad MenuPTN --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PTN de la entidad  MenuPTN!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de MenuPTN</param>
        /// <response code="200">MenuPTN Creado</response>
        /// <response code="400">MenuPTN tiene valores invalidos </response>
        /// <response code="401">MenuPTN No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear MenuPTN en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] MenuPTN obj)   
        {
            try
            {
                var result = new MenuPTNMs().Add(obj);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
	        HttpContext.RaiseError(new InvalidOperationException(ex.Message)); 
                return BadRequest(ex.Message);
            }
        }

        // PUT api/values/5
        /// <summary>
        /// CRUD de la entidad MenuPTN --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PTN de la entidad  MenuPTN!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de MenuPTN</param>
        /// <response code="200">MenuPTN Actualizado</response>
        /// <response code="400">MenuPTN tiene valores invalidos </response>
        /// <response code="401">MenuPTN No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar MenuPTN en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] MenuPTN obj)
        {
            try
            {
                var result = new MenuPTNMs().Update(obj);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
	        HttpContext.RaiseError(new InvalidOperationException(ex.Message)); 
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/values/5
          /// <summary>
        /// CRUD de la entidad MenuPTN --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PTN de la entidad  MenuPTN!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de MenuPTN</param>
        /// <response code="200">MenuPTN Eliminado</response>
        /// <response code="400">MenuPTN tiene valores invalidos </response>
        /// <response code="401">MenuPTN No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar MenuPTN en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] MenuPTN obj)
        {
           try
            {
                new MenuPTNMs().Delete(obj);
                return Ok();
            }
            catch (System.Exception ex)
            {
	        HttpContext.RaiseError(new InvalidOperationException(ex.Message)); 
                return BadRequest(ex.Message);
            }
        }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad MenuPTN --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  MenuPTN!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de MenuPTN</param>
        /// <response code="200">MenuPTN Resultado</response>
        /// <response code="400">MenuPTN tiene valores invalidos </response>
        /// <response code="401">MenuPTN No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  MenuPTN en este momento</response>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LoadTable([FromBody] DtParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;

            var orderCriteria = "id";
            var orderAscendingDirection = true;

            try
            {

                if (dtParameters.Order != null)
                {
                    // in this example we just default sort on the 1st column
                    orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                    orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
                }

                var result = new MenuPTNMs().GetAllByWithRelation().Cast<MenuPTN>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <MenuPTN>().ToList();  
                if (orderCriteria == "ID_Semana") result = result.OrderBy(p => p.ID_Semana).Cast <MenuPTN>().ToList(); 
                 if (orderCriteria == "sID_SemanasPTN") result = result.OrderBy(p => p.sID_Semana).Cast <MenuPTN>().ToList(); 
                 if (orderCriteria == "ID_TipoNivelEducativo") result = result.OrderBy(p => p.ID_TipoNivelEducativo).Cast <MenuPTN>().ToList(); 
                 if (orderCriteria == "sID_NivelEducativo") result = result.OrderBy(p => p.sID_TipoNivelEducativo).Cast <MenuPTN>().ToList(); 
                 if (orderCriteria == "NumeroDia") result = result.OrderBy(p => p.NumeroDia).Cast <MenuPTN>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <MenuPTN>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <MenuPTN>().ToList();  
                if (orderCriteria == "ID_Semana") result = result.OrderByDescending(p => p.ID_Semana).Cast <MenuPTN>().ToList(); 
                 if (orderCriteria == "sID_SemanasPTN") result = result.OrderByDescending(p => p.sID_Semana).Cast<MenuPTN>().ToList(); 
                 if (orderCriteria == "ID_TipoNivelEducativo") result = result.OrderByDescending(p => p.ID_TipoNivelEducativo).Cast <MenuPTN>().ToList(); 
                 if (orderCriteria == "sID_NivelEducativo") result = result.OrderByDescending(p => p.sID_TipoNivelEducativo).Cast<MenuPTN>().ToList(); 
                 if (orderCriteria == "NumeroDia") result = result.OrderByDescending(p => p.NumeroDia).Cast <MenuPTN>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <MenuPTN>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Semana != null && r.ID_Semana.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Semana != null && r.sID_Semana.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoNivelEducativo != null && r.ID_TipoNivelEducativo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoNivelEducativo != null && r.sID_TipoNivelEducativo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumeroDia != null && r.NumeroDia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
                                            ).ToList();
                }

                filteredResultsCount = data.Count();

                if (dtParameters.Length > 0)
                {
                    data = data.Skip(dtParameters.Start)
                                .Take(dtParameters.Length)
                                .ToList();
                }
                else
                {
                    data = data.Skip(dtParameters.Start)
                                .ToList();
                }

 
                for (int i = 0; i < data.Count; i++)
                {
                    data[i].sID = SISPAE.Common.Utilidades.Encrypt($"id={data[i].id.ToString()}");
                   
                }

                return Ok(new
                {
                    Draw = dtParameters.Draw,
                    RecordsTotal = totalResultsCount,
                    RecordsFiltered = filteredResultsCount,
                    Data = data
                });
            }
            catch (System.Exception ex)
            {
	        HttpContext.RaiseError(new InvalidOperationException(ex.Message)); 
                return BadRequest(ex.Message);
            }
        }


        // GET api/GetAllRelation/
        /// <summary>
        /// CRUD de la entidad MenuPTN --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  MenuPTN!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MenuPTN</param>
        /// <response code="200">MenuPTN Consulto los registros exitosamente</response>
        /// <response code="400">MenuPTN tiene valores invalidos </response>
        /// <response code="401">MenuPTN No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MenuPTN en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new MenuPTNMs().GetAllByWithRelation().Cast<MenuPTN>().AsQueryable();
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
