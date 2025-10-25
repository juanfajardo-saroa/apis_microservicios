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
    [SwaggerTag("Web API para CRUD de SuficienciaEquiposMenaje .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class SuficienciaEquiposMenajeController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad SuficienciaEquiposMenaje --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Infraestructura de la entidad  SuficienciaEquiposMenaje!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de SuficienciaEquiposMenaje</param>
        /// <response code="200">SuficienciaEquiposMenaje Consulto los registros exitosamente</response>
        /// <response code="400">SuficienciaEquiposMenaje tiene valores invalidos </response>
        /// <response code="401">SuficienciaEquiposMenaje No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar SuficienciaEquiposMenaje en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new SuficienciaEquiposMenajeMs().GetAll().Cast<SuficienciaEquiposMenaje>().AsQueryable();
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
        /// CRUD de la entidad SuficienciaEquiposMenaje --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Infraestructura de la entidad  SuficienciaEquiposMenaje!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de SuficienciaEquiposMenaje</param>
        /// <response code="200">SuficienciaEquiposMenaje Consulto los registros exitosamente</response>
        /// <response code="400">SuficienciaEquiposMenaje tiene valores invalidos </response>
        /// <response code="401">SuficienciaEquiposMenaje No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar SuficienciaEquiposMenaje en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new SuficienciaEquiposMenajeMs().GetAllFull().Cast<SuficienciaEquiposMenaje>().AsQueryable();
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
        /// CRUD de la entidad SuficienciaEquiposMenaje --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Infraestructura de la entidad  SuficienciaEquiposMenaje!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de SuficienciaEquiposMenaje</param>
        /// <response code="200">SuficienciaEquiposMenaje Consulto los registros exitosamente</response>
        /// <response code="400">SuficienciaEquiposMenaje tiene valores invalidos </response>
        /// <response code="401">SuficienciaEquiposMenaje No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar SuficienciaEquiposMenaje en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new SuficienciaEquiposMenajeMs().GetById(new SuficienciaEquiposMenaje() { id = id });
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
        /// CRUD de la entidad SuficienciaEquiposMenaje --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Infraestructura de la entidad  SuficienciaEquiposMenaje!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de SuficienciaEquiposMenaje</param>
        /// <response code="200">SuficienciaEquiposMenaje Creado</response>
        /// <response code="400">SuficienciaEquiposMenaje tiene valores invalidos </response>
        /// <response code="401">SuficienciaEquiposMenaje No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear SuficienciaEquiposMenaje en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] SuficienciaEquiposMenaje obj)
        {
            try
            {
                var result = new SuficienciaEquiposMenajeMs().Add(obj);
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
        /// CRUD de la entidad SuficienciaEquiposMenaje --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Infraestructura de la entidad  SuficienciaEquiposMenaje!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de SuficienciaEquiposMenaje</param>
        /// <response code="200">SuficienciaEquiposMenaje Actualizado</response>
        /// <response code="400">SuficienciaEquiposMenaje tiene valores invalidos </response>
        /// <response code="401">SuficienciaEquiposMenaje No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar SuficienciaEquiposMenaje en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] SuficienciaEquiposMenaje obj)
        {
            try
            {
                var result = new SuficienciaEquiposMenajeMs().Update(obj);
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
        /// CRUD de la entidad SuficienciaEquiposMenaje --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Infraestructura de la entidad  SuficienciaEquiposMenaje!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de SuficienciaEquiposMenaje</param>
        /// <response code="200">SuficienciaEquiposMenaje Eliminado</response>
        /// <response code="400">SuficienciaEquiposMenaje tiene valores invalidos </response>
        /// <response code="401">SuficienciaEquiposMenaje No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar SuficienciaEquiposMenaje en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] SuficienciaEquiposMenaje obj)
        {
           try
            {
                new SuficienciaEquiposMenajeMs().Delete(obj);
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
        /// DataTable de la entidad SuficienciaEquiposMenaje --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  SuficienciaEquiposMenaje!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de SuficienciaEquiposMenaje</param>
        /// <response code="200">SuficienciaEquiposMenaje Resultado</response>
        /// <response code="400">SuficienciaEquiposMenaje tiene valores invalidos </response>
        /// <response code="401">SuficienciaEquiposMenaje No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  SuficienciaEquiposMenaje en este momento</response>
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

                var result = new SuficienciaEquiposMenajeMs().GetAllByWithRelation().Cast<SuficienciaEquiposMenaje>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <SuficienciaEquiposMenaje>().ToList();  
                if (orderCriteria == "elemento") result = result.OrderBy(p => p.elemento).Cast <SuficienciaEquiposMenaje>().ToList(); 
                 if (orderCriteria == "id_caracteristica") result = result.OrderBy(p => p.id_caracteristica).Cast <SuficienciaEquiposMenaje>().ToList(); 
                 if (orderCriteria == "CantidadInicial") result = result.OrderBy(p => p.CantidadInicial).Cast <SuficienciaEquiposMenaje>().ToList(); 
                 if (orderCriteria == "CantidadFinal") result = result.OrderBy(p => p.CantidadFinal).Cast <SuficienciaEquiposMenaje>().ToList(); 
                 if (orderCriteria == "ComplementoInicalInsuficiente") result = result.OrderBy(p => p.ComplementoInicalInsuficiente).Cast <SuficienciaEquiposMenaje>().ToList(); 
                 if (orderCriteria == "ComplementoIncialAceptable") result = result.OrderBy(p => p.ComplementoIncialAceptable).Cast <SuficienciaEquiposMenaje>().ToList(); 
                 if (orderCriteria == "ComplementoFinalAceptable") result = result.OrderBy(p => p.ComplementoFinalAceptable).Cast <SuficienciaEquiposMenaje>().ToList(); 
                 if (orderCriteria == "ComplementoInicialSuficiente") result = result.OrderBy(p => p.ComplementoInicialSuficiente).Cast <SuficienciaEquiposMenaje>().ToList(); 
                 if (orderCriteria == "ComplementoFinalSuficiente") result = result.OrderBy(p => p.ComplementoFinalSuficiente).Cast <SuficienciaEquiposMenaje>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <SuficienciaEquiposMenaje>().ToList();  
                if (orderCriteria == "elemento") result = result.OrderByDescending(p => p.elemento).Cast <SuficienciaEquiposMenaje>().ToList(); 
                 if (orderCriteria == "id_caracteristica") result = result.OrderByDescending(p => p.id_caracteristica).Cast <SuficienciaEquiposMenaje>().ToList(); 
                 if (orderCriteria == "CantidadInicial") result = result.OrderByDescending(p => p.CantidadInicial).Cast <SuficienciaEquiposMenaje>().ToList(); 
                 if (orderCriteria == "CantidadFinal") result = result.OrderByDescending(p => p.CantidadFinal).Cast <SuficienciaEquiposMenaje>().ToList(); 
                 if (orderCriteria == "ComplementoInicalInsuficiente") result = result.OrderByDescending(p => p.ComplementoInicalInsuficiente).Cast <SuficienciaEquiposMenaje>().ToList(); 
                 if (orderCriteria == "ComplementoIncialAceptable") result = result.OrderByDescending(p => p.ComplementoIncialAceptable).Cast <SuficienciaEquiposMenaje>().ToList(); 
                 if (orderCriteria == "ComplementoFinalAceptable") result = result.OrderByDescending(p => p.ComplementoFinalAceptable).Cast <SuficienciaEquiposMenaje>().ToList(); 
                 if (orderCriteria == "ComplementoInicialSuficiente") result = result.OrderByDescending(p => p.ComplementoInicialSuficiente).Cast <SuficienciaEquiposMenaje>().ToList(); 
                 if (orderCriteria == "ComplementoFinalSuficiente") result = result.OrderByDescending(p => p.ComplementoFinalSuficiente).Cast <SuficienciaEquiposMenaje>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.elemento != null && r.elemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.id_caracteristica != null && r.id_caracteristica.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CantidadInicial != null && r.CantidadInicial.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CantidadFinal != null && r.CantidadFinal.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ComplementoInicalInsuficiente != null && r.ComplementoInicalInsuficiente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ComplementoIncialAceptable != null && r.ComplementoIncialAceptable.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ComplementoFinalAceptable != null && r.ComplementoFinalAceptable.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ComplementoInicialSuficiente != null && r.ComplementoInicialSuficiente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ComplementoFinalSuficiente != null && r.ComplementoFinalSuficiente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad SuficienciaEquiposMenaje --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Infraestructura de la entidad  SuficienciaEquiposMenaje!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de SuficienciaEquiposMenaje</param>
        /// <response code="200">SuficienciaEquiposMenaje Consulto los registros exitosamente</response>
        /// <response code="400">SuficienciaEquiposMenaje tiene valores invalidos </response>
        /// <response code="401">SuficienciaEquiposMenaje No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar SuficienciaEquiposMenaje en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new SuficienciaEquiposMenajeMs().GetAllByWithRelation().Cast<SuficienciaEquiposMenaje>().AsQueryable();
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
