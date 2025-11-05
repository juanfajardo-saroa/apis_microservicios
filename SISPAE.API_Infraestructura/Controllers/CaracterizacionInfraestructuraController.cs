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

namespace SISPAE_API_Infraestructura.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de CaracterizacionInfraestructura .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class CaracterizacionInfraestructuraController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad CaracterizacionInfraestructura --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Infraestructura de la entidad  CaracterizacionInfraestructura!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de CaracterizacionInfraestructura</param>
        /// <response code="200">CaracterizacionInfraestructura Consulto los registros exitosamente</response>
        /// <response code="400">CaracterizacionInfraestructura tiene valores invalidos </response>
        /// <response code="401">CaracterizacionInfraestructura No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar CaracterizacionInfraestructura en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new CaracterizacionInfraestructuraMs().GetAll().Cast<CaracterizacionInfraestructura>().AsQueryable();
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
        /// CRUD de la entidad CaracterizacionInfraestructura --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Infraestructura de la entidad  CaracterizacionInfraestructura!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de CaracterizacionInfraestructura</param>
        /// <response code="200">CaracterizacionInfraestructura Consulto los registros exitosamente</response>
        /// <response code="400">CaracterizacionInfraestructura tiene valores invalidos </response>
        /// <response code="401">CaracterizacionInfraestructura No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar CaracterizacionInfraestructura en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new CaracterizacionInfraestructuraMs().GetAllFull().Cast<CaracterizacionInfraestructura>().AsQueryable();
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
        /// CRUD de la entidad CaracterizacionInfraestructura --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Infraestructura de la entidad  CaracterizacionInfraestructura!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de CaracterizacionInfraestructura</param>
        /// <response code="200">CaracterizacionInfraestructura Consulto los registros exitosamente</response>
        /// <response code="400">CaracterizacionInfraestructura tiene valores invalidos </response>
        /// <response code="401">CaracterizacionInfraestructura No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar CaracterizacionInfraestructura en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new CaracterizacionInfraestructuraMs().GetById(new CaracterizacionInfraestructura() { id = id });
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
        /// CRUD de la entidad CaracterizacionInfraestructura --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Infraestructura de la entidad  CaracterizacionInfraestructura!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de CaracterizacionInfraestructura</param>
        /// <response code="200">CaracterizacionInfraestructura Creado</response>
        /// <response code="400">CaracterizacionInfraestructura tiene valores invalidos </response>
        /// <response code="401">CaracterizacionInfraestructura No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear CaracterizacionInfraestructura en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] CaracterizacionInfraestructura obj)
        {

            try
            {
                var result = new CaracterizacionInfraestructuraMs().Add(obj);
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
        /// CRUD de la entidad CaracterizacionInfraestructura --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Infraestructura de la entidad  CaracterizacionInfraestructura!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de CaracterizacionInfraestructura</param>
        /// <response code="200">CaracterizacionInfraestructura Actualizado</response>
        /// <response code="400">CaracterizacionInfraestructura tiene valores invalidos </response>
        /// <response code="401">CaracterizacionInfraestructura No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar CaracterizacionInfraestructura en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] CaracterizacionInfraestructura obj)
        {
            try
            {
                var result = new CaracterizacionInfraestructuraMs().Update(obj);
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
        /// CRUD de la entidad CaracterizacionInfraestructura --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Infraestructura de la entidad  CaracterizacionInfraestructura!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de CaracterizacionInfraestructura</param>
        /// <response code="200">CaracterizacionInfraestructura Eliminado</response>
        /// <response code="400">CaracterizacionInfraestructura tiene valores invalidos </response>
        /// <response code="401">CaracterizacionInfraestructura No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar CaracterizacionInfraestructura en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] CaracterizacionInfraestructura obj)
        {
           try
            {
                new CaracterizacionInfraestructuraMs().Delete(obj);
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
        /// DataTable de la entidad CaracterizacionInfraestructura --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  CaracterizacionInfraestructura!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de CaracterizacionInfraestructura</param>
        /// <response code="200">CaracterizacionInfraestructura Resultado</response>
        /// <response code="400">CaracterizacionInfraestructura tiene valores invalidos </response>
        /// <response code="401">CaracterizacionInfraestructura No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  CaracterizacionInfraestructura en este momento</response>
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

                var result = new CaracterizacionInfraestructuraMs().GetAllByWithRelation().Cast<CaracterizacionInfraestructura>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <CaracterizacionInfraestructura>().ToList();  
                if (orderCriteria == "ID_Sede") result = result.OrderBy(p => p.ID_Sede).Cast <CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "sID_Sedes") result = result.OrderBy(p => p.sID_Sede).Cast <CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "ID_Inventario") result = result.OrderBy(p => p.ID_Inventario).Cast <CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "sID_Inventario") result = result.OrderBy(p => p.sID_Inventario).Cast <CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "FechaCaracterizacion") result = result.OrderBy(p => p.FechaCaracterizacion).Cast <CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "FechaModificacion") result = result.OrderBy(p => p.FechaModificacion).Cast <CaracterizacionInfraestructura>().ToList(); 
                   if (orderCriteria == "CHS_Fecha") result = result.OrderBy(p => p.CHS_Fecha).Cast <CaracterizacionInfraestructura>().ToList(); 
                       if (orderCriteria == "SuficienciaDotacion") result = result.OrderBy(p => p.SuficienciaDotacion).Cast <CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "Id_TipoEstadoCaracterizacion") result = result.OrderBy(p => p.Id_TipoEstadoCaracterizacion).Cast <CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "sID_TipoEstadoCaracterizacion") result = result.OrderBy(p => p.sId_TipoEstadoCaracterizacion).Cast <CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "id_TipoModalidadComplementoSugerida") result = result.OrderBy(p => p.id_TipoModalidadComplementoSugerida).Cast <CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "sID_TiposModalidadComplemento") result = result.OrderBy(p => p.sid_TipoModalidadComplementoSugerida).Cast <CaracterizacionInfraestructura>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <CaracterizacionInfraestructura>().ToList();  
                if (orderCriteria == "ID_Sede") result = result.OrderByDescending(p => p.ID_Sede).Cast <CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "sID_Sedes") result = result.OrderByDescending(p => p.sID_Sede).Cast<CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "ID_Inventario") result = result.OrderByDescending(p => p.ID_Inventario).Cast <CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "sID_Inventario") result = result.OrderByDescending(p => p.sID_Inventario).Cast<CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "FechaCaracterizacion") result = result.OrderByDescending(p => p.FechaCaracterizacion).Cast <CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "FechaModificacion") result = result.OrderByDescending(p => p.FechaModificacion).Cast <CaracterizacionInfraestructura>().ToList(); 
                   if (orderCriteria == "CHS_Fecha") result = result.OrderByDescending(p => p.CHS_Fecha).Cast <CaracterizacionInfraestructura>().ToList(); 
                       if (orderCriteria == "SuficienciaDotacion") result = result.OrderByDescending(p => p.SuficienciaDotacion).Cast <CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "Id_TipoEstadoCaracterizacion") result = result.OrderByDescending(p => p.Id_TipoEstadoCaracterizacion).Cast <CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "sID_TipoEstadoCaracterizacion") result = result.OrderByDescending(p => p.sId_TipoEstadoCaracterizacion).Cast<CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "id_TipoModalidadComplementoSugerida") result = result.OrderByDescending(p => p.id_TipoModalidadComplementoSugerida).Cast <CaracterizacionInfraestructura>().ToList(); 
                 if (orderCriteria == "sID_TiposModalidadComplemento") result = result.OrderByDescending(p => p.sid_TipoModalidadComplementoSugerida).Cast<CaracterizacionInfraestructura>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Sede != null && r.ID_Sede.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Sede != null && r.sID_Sede.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Inventario != null && r.ID_Inventario.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Inventario != null && r.sID_Inventario.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaCaracterizacion != null && r.FechaCaracterizacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaModificacion != null && r.FechaModificacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.CHS_Fecha != null && r.CHS_Fecha.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                       || r.SuficienciaDotacion != null && r.SuficienciaDotacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Id_TipoEstadoCaracterizacion != null && r.Id_TipoEstadoCaracterizacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sId_TipoEstadoCaracterizacion != null && r.sId_TipoEstadoCaracterizacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.id_TipoModalidadComplementoSugerida != null && r.id_TipoModalidadComplementoSugerida.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                || r.sid_TipoModalidadComplementoSugerida != null && r.sid_TipoModalidadComplementoSugerida.ToString().ToUpper().Contains(searchBy.ToUpper()) 
  
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
        /// CRUD de la entidad CaracterizacionInfraestructura --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Infraestructura de la entidad  CaracterizacionInfraestructura!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de CaracterizacionInfraestructura</param>
        /// <response code="200">CaracterizacionInfraestructura Consulto los registros exitosamente</response>
        /// <response code="400">CaracterizacionInfraestructura tiene valores invalidos </response>
        /// <response code="401">CaracterizacionInfraestructura No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar CaracterizacionInfraestructura en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new CaracterizacionInfraestructuraMs().GetAllByWithRelation().Cast<CaracterizacionInfraestructura>().AsQueryable();
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
