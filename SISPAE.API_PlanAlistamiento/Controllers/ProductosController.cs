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

namespace SISPAE_API_PlanAlistamiento.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de Productos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class ProductosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Productos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Productos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Productos</param>
        /// <response code="200">Productos Consulto los registros exitosamente</response>
        /// <response code="400">Productos tiene valores invalidos </response>
        /// <response code="401">Productos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Productos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new ProductosMs().GetAll().Cast<Productos>().AsQueryable();
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
        /// CRUD de la entidad Productos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Productos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Productos</param>
        /// <response code="200">Productos Consulto los registros exitosamente</response>
        /// <response code="400">Productos tiene valores invalidos </response>
        /// <response code="401">Productos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Productos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new ProductosMs().GetAllFull().Cast<Productos>().AsQueryable();
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
        /// CRUD de la entidad Productos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Productos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Productos</param>
        /// <response code="200">Productos Consulto los registros exitosamente</response>
        /// <response code="400">Productos tiene valores invalidos </response>
        /// <response code="401">Productos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Productos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new ProductosMs().GetById(new Productos() { id = id });
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
        /// CRUD de la entidad Productos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Productos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Productos</param>
        /// <response code="200">Productos Creado</response>
        /// <response code="400">Productos tiene valores invalidos </response>
        /// <response code="401">Productos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Productos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Productos obj)
        {
            try
            {
                var result = new ProductosMs().Add(obj);
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
        /// CRUD de la entidad Productos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Productos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Productos</param>
        /// <response code="200">Productos Actualizado</response>
        /// <response code="400">Productos tiene valores invalidos </response>
        /// <response code="401">Productos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Productos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Productos obj)
        {
            try
            {
                var result = new ProductosMs().Update(obj);
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
        /// CRUD de la entidad Productos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Productos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Productos</param>
        /// <response code="200">Productos Eliminado</response>
        /// <response code="400">Productos tiene valores invalidos </response>
        /// <response code="401">Productos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Productos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Productos obj)
        {
           try
            {
                new ProductosMs().Delete(obj);
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
        /// DataTable de la entidad Productos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Productos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Productos</param>
        /// <response code="200">Productos Resultado</response>
        /// <response code="400">Productos tiene valores invalidos </response>
        /// <response code="401">Productos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Productos en este momento</response>
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

                var result = new ProductosMs().GetAllByWithRelation().Cast<Productos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Productos>().ToList();  
                if (orderCriteria == "ID_SubGrupoAlimentos") result = result.OrderBy(p => p.ID_SubGrupoAlimentos).Cast <Productos>().ToList(); 
                 if (orderCriteria == "sID_SubGrupoAlimentos") result = result.OrderBy(p => p.sID_SubGrupoAlimentos).Cast <Productos>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderBy(p => p.ID_ETC).Cast <Productos>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderBy(p => p.sID_ETC).Cast <Productos>().ToList(); 
                 if (orderCriteria == "ID_TiposAlimentos") result = result.OrderBy(p => p.ID_TiposAlimentos).Cast <Productos>().ToList(); 
                 if (orderCriteria == "sID_TiposAlimentos") result = result.OrderBy(p => p.sID_TiposAlimentos).Cast <Productos>().ToList(); 
                 if (orderCriteria == "ID_TiposUnidad") result = result.OrderBy(p => p.ID_TiposUnidad).Cast <Productos>().ToList(); 
                 if (orderCriteria == "ID_EstadoRegistro") result = result.OrderBy(p => p.ID_EstadoRegistro).Cast <Productos>().ToList(); 
                 if (orderCriteria == "sID_EstadosRegistro") result = result.OrderBy(p => p.sID_EstadoRegistro).Cast <Productos>().ToList(); 
                 if (orderCriteria == "ID_RegistroINVIMA") result = result.OrderBy(p => p.ID_RegistroINVIMA).Cast <Productos>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <Productos>().ToList(); 
                 if (orderCriteria == "NumeroRegistroInvima") result = result.OrderBy(p => p.NumeroRegistroInvima).Cast <Productos>().ToList(); 
                 if (orderCriteria == "PathlmagenProducto") result = result.OrderBy(p => p.PathlmagenProducto).Cast <Productos>().ToList(); 
                 if (orderCriteria == "PathlmagenRegistroSanitario") result = result.OrderBy(p => p.PathlmagenRegistroSanitario).Cast <Productos>().ToList(); 
                 if (orderCriteria == "BaseFruta") result = result.OrderBy(p => p.BaseFruta).Cast <Productos>().ToList(); 
                   if (orderCriteria == "PathImagenInformacionNutricional") result = result.OrderBy(p => p.PathImagenInformacionNutricional).Cast <Productos>().ToList(); 
                 if (orderCriteria == "FechaRegistro") result = result.OrderBy(p => p.FechaRegistro).Cast <Productos>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Productos>().ToList();  
                if (orderCriteria == "ID_SubGrupoAlimentos") result = result.OrderByDescending(p => p.ID_SubGrupoAlimentos).Cast <Productos>().ToList(); 
                 if (orderCriteria == "sID_SubGrupoAlimentos") result = result.OrderByDescending(p => p.sID_SubGrupoAlimentos).Cast<Productos>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderByDescending(p => p.ID_ETC).Cast <Productos>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderByDescending(p => p.sID_ETC).Cast<Productos>().ToList(); 
                 if (orderCriteria == "ID_TiposAlimentos") result = result.OrderByDescending(p => p.ID_TiposAlimentos).Cast <Productos>().ToList(); 
                 if (orderCriteria == "sID_TiposAlimentos") result = result.OrderByDescending(p => p.sID_TiposAlimentos).Cast<Productos>().ToList(); 
                 if (orderCriteria == "ID_TiposUnidad") result = result.OrderByDescending(p => p.ID_TiposUnidad).Cast <Productos>().ToList(); 
                 if (orderCriteria == "ID_EstadoRegistro") result = result.OrderByDescending(p => p.ID_EstadoRegistro).Cast <Productos>().ToList(); 
                 if (orderCriteria == "sID_EstadosRegistro") result = result.OrderByDescending(p => p.sID_EstadoRegistro).Cast<Productos>().ToList(); 
                 if (orderCriteria == "ID_RegistroINVIMA") result = result.OrderByDescending(p => p.ID_RegistroINVIMA).Cast <Productos>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <Productos>().ToList(); 
                 if (orderCriteria == "NumeroRegistroInvima") result = result.OrderByDescending(p => p.NumeroRegistroInvima).Cast <Productos>().ToList(); 
                 if (orderCriteria == "PathlmagenProducto") result = result.OrderByDescending(p => p.PathlmagenProducto).Cast <Productos>().ToList(); 
                 if (orderCriteria == "PathlmagenRegistroSanitario") result = result.OrderByDescending(p => p.PathlmagenRegistroSanitario).Cast <Productos>().ToList(); 
                 if (orderCriteria == "BaseFruta") result = result.OrderByDescending(p => p.BaseFruta).Cast <Productos>().ToList(); 
                   if (orderCriteria == "PathImagenInformacionNutricional") result = result.OrderByDescending(p => p.PathImagenInformacionNutricional).Cast <Productos>().ToList(); 
                 if (orderCriteria == "FechaRegistro") result = result.OrderByDescending(p => p.FechaRegistro).Cast <Productos>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_SubGrupoAlimentos != null && r.ID_SubGrupoAlimentos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_SubGrupoAlimentos != null && r.sID_SubGrupoAlimentos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_ETC != null && r.ID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ETC != null && r.sID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TiposAlimentos != null && r.ID_TiposAlimentos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TiposAlimentos != null && r.sID_TiposAlimentos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TiposUnidad != null && r.ID_TiposUnidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_EstadoRegistro != null && r.ID_EstadoRegistro.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_EstadoRegistro != null && r.sID_EstadoRegistro.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_RegistroINVIMA != null && r.ID_RegistroINVIMA.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumeroRegistroInvima != null && r.NumeroRegistroInvima.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PathlmagenProducto != null && r.PathlmagenProducto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PathlmagenRegistroSanitario != null && r.PathlmagenRegistroSanitario.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.BaseFruta != null && r.BaseFruta.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.PathImagenInformacionNutricional != null && r.PathImagenInformacionNutricional.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaRegistro != null && r.FechaRegistro.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
        /// CRUD de la entidad Productos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Productos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Productos</param>
        /// <response code="200">Productos Consulto los registros exitosamente</response>
        /// <response code="400">Productos tiene valores invalidos </response>
        /// <response code="401">Productos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Productos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new ProductosMs().GetAllByWithRelation().Cast<Productos>().AsQueryable();
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
