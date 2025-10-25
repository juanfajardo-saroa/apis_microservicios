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

namespace SISPAE_API_PlaneacionFinanciera.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de FuenteIngresos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class FuenteIngresosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad FuenteIngresos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  FuenteIngresos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de FuenteIngresos</param>
        /// <response code="200">FuenteIngresos Consulto los registros exitosamente</response>
        /// <response code="400">FuenteIngresos tiene valores invalidos </response>
        /// <response code="401">FuenteIngresos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar FuenteIngresos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new FuenteIngresosMs().GetAll().Cast<FuenteIngresos>().AsQueryable();
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
        /// CRUD de la entidad FuenteIngresos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  FuenteIngresos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de FuenteIngresos</param>
        /// <response code="200">FuenteIngresos Consulto los registros exitosamente</response>
        /// <response code="400">FuenteIngresos tiene valores invalidos </response>
        /// <response code="401">FuenteIngresos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar FuenteIngresos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new FuenteIngresosMs().GetAllFull().Cast<FuenteIngresos>().AsQueryable();
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
        /// CRUD de la entidad FuenteIngresos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  FuenteIngresos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de FuenteIngresos</param>
        /// <response code="200">FuenteIngresos Consulto los registros exitosamente</response>
        /// <response code="400">FuenteIngresos tiene valores invalidos </response>
        /// <response code="401">FuenteIngresos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar FuenteIngresos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new FuenteIngresosMs().GetById(new FuenteIngresos() { id = id });
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
        /// CRUD de la entidad FuenteIngresos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  FuenteIngresos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de FuenteIngresos</param>
        /// <response code="200">FuenteIngresos Creado</response>
        /// <response code="400">FuenteIngresos tiene valores invalidos </response>
        /// <response code="401">FuenteIngresos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear FuenteIngresos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] FuenteIngresos obj)
        {
            try
            {
                var result = new FuenteIngresosMs().Add(obj);
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
        /// CRUD de la entidad FuenteIngresos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  FuenteIngresos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de FuenteIngresos</param>
        /// <response code="200">FuenteIngresos Actualizado</response>
        /// <response code="400">FuenteIngresos tiene valores invalidos </response>
        /// <response code="401">FuenteIngresos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar FuenteIngresos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] FuenteIngresos obj)
        {
            try
            {
                var result = new FuenteIngresosMs().Update(obj);
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
        /// CRUD de la entidad FuenteIngresos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  FuenteIngresos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de FuenteIngresos</param>
        /// <response code="200">FuenteIngresos Eliminado</response>
        /// <response code="400">FuenteIngresos tiene valores invalidos </response>
        /// <response code="401">FuenteIngresos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar FuenteIngresos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] FuenteIngresos obj)
        {
           try
            {
                new FuenteIngresosMs().Delete(obj);
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
        /// DataTable de la entidad FuenteIngresos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  FuenteIngresos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de FuenteIngresos</param>
        /// <response code="200">FuenteIngresos Resultado</response>
        /// <response code="400">FuenteIngresos tiene valores invalidos </response>
        /// <response code="401">FuenteIngresos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  FuenteIngresos en este momento</response>
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

                var result = new FuenteIngresosMs().GetAllByWithRelation().Cast<FuenteIngresos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <FuenteIngresos>().ToList();  
                if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <FuenteIngresos>().ToList(); 
                 if (orderCriteria == "FuenteSIGEPAE") result = result.OrderBy(p => p.FuenteSIGEPAE).Cast <FuenteIngresos>().ToList(); 
                   if (orderCriteria == "IdFuentesFinanciacion") result = result.OrderBy(p => p.IdFuentesFinanciacion).Cast <FuenteIngresos>().ToList(); 
                 if (orderCriteria == "Id_FuenteCHIP") result = result.OrderBy(p => p.Id_FuenteCHIP).Cast <FuenteIngresos>().ToList(); 
                 if (orderCriteria == "sID_FuentesCHIP") result = result.OrderBy(p => p.sId_FuenteCHIP).Cast <FuenteIngresos>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <FuenteIngresos>().ToList();  
                if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <FuenteIngresos>().ToList(); 
                 if (orderCriteria == "FuenteSIGEPAE") result = result.OrderByDescending(p => p.FuenteSIGEPAE).Cast <FuenteIngresos>().ToList(); 
                   if (orderCriteria == "IdFuentesFinanciacion") result = result.OrderByDescending(p => p.IdFuentesFinanciacion).Cast <FuenteIngresos>().ToList(); 
                 if (orderCriteria == "Id_FuenteCHIP") result = result.OrderByDescending(p => p.Id_FuenteCHIP).Cast <FuenteIngresos>().ToList(); 
                 if (orderCriteria == "sID_FuentesCHIP") result = result.OrderByDescending(p => p.sId_FuenteCHIP).Cast<FuenteIngresos>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FuenteSIGEPAE != null && r.FuenteSIGEPAE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.IdFuentesFinanciacion != null && r.IdFuentesFinanciacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Id_FuenteCHIP != null && r.Id_FuenteCHIP.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                || r.sId_FuenteCHIP != null && r.sId_FuenteCHIP.ToString().ToUpper().Contains(searchBy.ToUpper()) 
  
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
        /// CRUD de la entidad FuenteIngresos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  FuenteIngresos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de FuenteIngresos</param>
        /// <response code="200">FuenteIngresos Consulto los registros exitosamente</response>
        /// <response code="400">FuenteIngresos tiene valores invalidos </response>
        /// <response code="401">FuenteIngresos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar FuenteIngresos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new FuenteIngresosMs().GetAllByWithRelation().Cast<FuenteIngresos>().AsQueryable();
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
