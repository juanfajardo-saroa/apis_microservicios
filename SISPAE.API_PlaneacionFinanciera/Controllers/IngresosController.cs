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
    [SwaggerTag("Web API para CRUD de Ingresos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class IngresosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Ingresos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  Ingresos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Ingresos</param>
        /// <response code="200">Ingresos Consulto los registros exitosamente</response>
        /// <response code="400">Ingresos tiene valores invalidos </response>
        /// <response code="401">Ingresos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Ingresos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new IngresosMs().GetAll().Cast<Ingresos>().AsQueryable();
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
        /// CRUD de la entidad Ingresos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  Ingresos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Ingresos</param>
        /// <response code="200">Ingresos Consulto los registros exitosamente</response>
        /// <response code="400">Ingresos tiene valores invalidos </response>
        /// <response code="401">Ingresos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Ingresos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new IngresosMs().GetAllFull().Cast<Ingresos>().AsQueryable();
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
        /// CRUD de la entidad Ingresos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  Ingresos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Ingresos</param>
        /// <response code="200">Ingresos Consulto los registros exitosamente</response>
        /// <response code="400">Ingresos tiene valores invalidos </response>
        /// <response code="401">Ingresos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Ingresos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new IngresosMs().GetById(new Ingresos() { id = id });
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
        /// CRUD de la entidad Ingresos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  Ingresos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Ingresos</param>
        /// <response code="200">Ingresos Creado</response>
        /// <response code="400">Ingresos tiene valores invalidos </response>
        /// <response code="401">Ingresos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Ingresos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Ingresos obj)
        {
            try
            {
                var result = new IngresosMs().Add(obj);
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
        /// CRUD de la entidad Ingresos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  Ingresos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Ingresos</param>
        /// <response code="200">Ingresos Actualizado</response>
        /// <response code="400">Ingresos tiene valores invalidos </response>
        /// <response code="401">Ingresos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Ingresos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Ingresos obj)
        {
            try
            {
                var result = new IngresosMs().Update(obj);
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
        /// CRUD de la entidad Ingresos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  Ingresos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Ingresos</param>
        /// <response code="200">Ingresos Eliminado</response>
        /// <response code="400">Ingresos tiene valores invalidos </response>
        /// <response code="401">Ingresos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Ingresos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Ingresos obj)
        {
           try
            {
                new IngresosMs().Delete(obj);
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
        /// DataTable de la entidad Ingresos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Ingresos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Ingresos</param>
        /// <response code="200">Ingresos Resultado</response>
        /// <response code="400">Ingresos tiene valores invalidos </response>
        /// <response code="401">Ingresos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Ingresos en este momento</response>
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

                var result = new IngresosMs().GetAllByWithRelation().Cast<Ingresos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Ingresos>().ToList();  
                if (orderCriteria == "ID_ETC") result = result.OrderBy(p => p.ID_ETC).Cast <Ingresos>().ToList(); 
                 if (orderCriteria == "ID_TipoIngreso") result = result.OrderBy(p => p.ID_TipoIngreso).Cast <Ingresos>().ToList(); 
                 if (orderCriteria == "sID_TiposIngreso") result = result.OrderBy(p => p.sID_TipoIngreso).Cast <Ingresos>().ToList(); 
                 if (orderCriteria == "ID_FuenteIngreso") result = result.OrderBy(p => p.ID_FuenteIngreso).Cast <Ingresos>().ToList(); 
                 if (orderCriteria == "sID_FuenteIngresos") result = result.OrderBy(p => p.sID_FuenteIngreso).Cast <Ingresos>().ToList(); 
                 if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderBy(p => p.ID_TipoModeloOperacion).Cast <Ingresos>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderBy(p => p.sID_TipoModeloOperacion).Cast <Ingresos>().ToList(); 
                 if (orderCriteria == "ID_Vigencia") result = result.OrderBy(p => p.ID_Vigencia).Cast <Ingresos>().ToList(); 
                 if (orderCriteria == "sID_Vigencias") result = result.OrderBy(p => p.sID_Vigencia).Cast <Ingresos>().ToList(); 
                 if (orderCriteria == "Valor") result = result.OrderBy(p => p.Valor).Cast <Ingresos>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Ingresos>().ToList();  
                if (orderCriteria == "ID_ETC") result = result.OrderByDescending(p => p.ID_ETC).Cast <Ingresos>().ToList(); 
                 if (orderCriteria == "ID_TipoIngreso") result = result.OrderByDescending(p => p.ID_TipoIngreso).Cast <Ingresos>().ToList(); 
                 if (orderCriteria == "sID_TiposIngreso") result = result.OrderByDescending(p => p.sID_TipoIngreso).Cast<Ingresos>().ToList(); 
                 if (orderCriteria == "ID_FuenteIngreso") result = result.OrderByDescending(p => p.ID_FuenteIngreso).Cast <Ingresos>().ToList(); 
                 if (orderCriteria == "sID_FuenteIngresos") result = result.OrderByDescending(p => p.sID_FuenteIngreso).Cast<Ingresos>().ToList(); 
                 if (orderCriteria == "ID_TipoModeloOperacion") result = result.OrderByDescending(p => p.ID_TipoModeloOperacion).Cast <Ingresos>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderByDescending(p => p.sID_TipoModeloOperacion).Cast<Ingresos>().ToList(); 
                 if (orderCriteria == "ID_Vigencia") result = result.OrderByDescending(p => p.ID_Vigencia).Cast <Ingresos>().ToList(); 
                 if (orderCriteria == "sID_Vigencias") result = result.OrderByDescending(p => p.sID_Vigencia).Cast<Ingresos>().ToList(); 
                 if (orderCriteria == "Valor") result = result.OrderByDescending(p => p.Valor).Cast <Ingresos>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_ETC != null && r.ID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoIngreso != null && r.ID_TipoIngreso.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoIngreso != null && r.sID_TipoIngreso.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_FuenteIngreso != null && r.ID_FuenteIngreso.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_FuenteIngreso != null && r.sID_FuenteIngreso.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoModeloOperacion != null && r.ID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoModeloOperacion != null && r.sID_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Vigencia != null && r.ID_Vigencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Vigencia != null && r.sID_Vigencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Valor != null && r.Valor.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad Ingresos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  Ingresos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Ingresos</param>
        /// <response code="200">Ingresos Consulto los registros exitosamente</response>
        /// <response code="400">Ingresos tiene valores invalidos </response>
        /// <response code="401">Ingresos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Ingresos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new IngresosMs().GetAllByWithRelation().Cast<Ingresos>().AsQueryable();
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
