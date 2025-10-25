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

namespace SISPAE_API_Staging.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de EncabezadoMatricula .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class EncabezadoMatriculaController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad EncabezadoMatricula --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  EncabezadoMatricula!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de EncabezadoMatricula</param>
        /// <response code="200">EncabezadoMatricula Consulto los registros exitosamente</response>
        /// <response code="400">EncabezadoMatricula tiene valores invalidos </response>
        /// <response code="401">EncabezadoMatricula No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar EncabezadoMatricula en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new EncabezadoMatriculaMs().GetAll().Cast<EncabezadoMatricula>().AsQueryable();
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
        /// CRUD de la entidad EncabezadoMatricula --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  EncabezadoMatricula!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de EncabezadoMatricula</param>
        /// <response code="200">EncabezadoMatricula Consulto los registros exitosamente</response>
        /// <response code="400">EncabezadoMatricula tiene valores invalidos </response>
        /// <response code="401">EncabezadoMatricula No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar EncabezadoMatricula en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new EncabezadoMatriculaMs().GetAllFull().Cast<EncabezadoMatricula>().AsQueryable();
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
        /// CRUD de la entidad EncabezadoMatricula --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  EncabezadoMatricula!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de EncabezadoMatricula</param>
        /// <response code="200">EncabezadoMatricula Consulto los registros exitosamente</response>
        /// <response code="400">EncabezadoMatricula tiene valores invalidos </response>
        /// <response code="401">EncabezadoMatricula No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar EncabezadoMatricula en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new EncabezadoMatriculaMs().GetById(new EncabezadoMatricula() { ID = id });
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
        /// CRUD de la entidad EncabezadoMatricula --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Staging de la entidad  EncabezadoMatricula!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de EncabezadoMatricula</param>
        /// <response code="200">EncabezadoMatricula Creado</response>
        /// <response code="400">EncabezadoMatricula tiene valores invalidos </response>
        /// <response code="401">EncabezadoMatricula No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear EncabezadoMatricula en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] EncabezadoMatricula obj)
        {
            try
            {
                var result = new EncabezadoMatriculaMs().Add(obj);
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
        /// CRUD de la entidad EncabezadoMatricula --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Staging de la entidad  EncabezadoMatricula!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de EncabezadoMatricula</param>
        /// <response code="200">EncabezadoMatricula Actualizado</response>
        /// <response code="400">EncabezadoMatricula tiene valores invalidos </response>
        /// <response code="401">EncabezadoMatricula No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar EncabezadoMatricula en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] EncabezadoMatricula obj)
        {
            try
            {
                var result = new EncabezadoMatriculaMs().Update(obj);
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
        /// CRUD de la entidad EncabezadoMatricula --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Staging de la entidad  EncabezadoMatricula!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de EncabezadoMatricula</param>
        /// <response code="200">EncabezadoMatricula Eliminado</response>
        /// <response code="400">EncabezadoMatricula tiene valores invalidos </response>
        /// <response code="401">EncabezadoMatricula No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar EncabezadoMatricula en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] EncabezadoMatricula obj)
        {
           try
            {
                new EncabezadoMatriculaMs().Delete(obj);
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
        /// DataTable de la entidad EncabezadoMatricula --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  EncabezadoMatricula!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de EncabezadoMatricula</param>
        /// <response code="200">EncabezadoMatricula Resultado</response>
        /// <response code="400">EncabezadoMatricula tiene valores invalidos </response>
        /// <response code="401">EncabezadoMatricula No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  EncabezadoMatricula en este momento</response>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LoadTable([FromBody] DtParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;

            var orderCriteria = "ID";
            var orderAscendingDirection = true;

            try
            {

                if (dtParameters.Order != null)
                {
                    // in this example we just default sort on the 1st column
                    orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                    orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
                }

                var result = new EncabezadoMatriculaMs().GetAllByWithRelation().Cast<EncabezadoMatricula>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="ID") result = result.OrderBy(p => p.ID).Cast <EncabezadoMatricula>().ToList();  
                if (orderCriteria == "ID_ETC") result = result.OrderBy(p => p.ID_ETC).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderBy(p => p.sID_ETC).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "ID_TipoProcesoCarga") result = result.OrderBy(p => p.ID_TipoProcesoCarga).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "sID_TipoProcesosCargue") result = result.OrderBy(p => p.sID_TipoProcesoCarga).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "ID_EstadoCargue") result = result.OrderBy(p => p.ID_EstadoCargue).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "sID_EstadoProcesoCargue") result = result.OrderBy(p => p.sID_EstadoCargue).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "Fecha") result = result.OrderBy(p => p.Fecha).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "Agno") result = result.OrderBy(p => p.Agno).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "Mes") result = result.OrderBy(p => p.Mes).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "NombreArchivo") result = result.OrderBy(p => p.NombreArchivo).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "TotalRegistros") result = result.OrderBy(p => p.TotalRegistros).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "TotalRegistroOK") result = result.OrderBy(p => p.TotalRegistroOK).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "TotalResgistroError") result = result.OrderBy(p => p.TotalResgistroError).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "MatriculaSectorOficial") result = result.OrderBy(p => p.MatriculaSectorOficial).Cast <EncabezadoMatricula>().ToList(); 
                     }
                else 
                {                if (orderCriteria == "ID") result = result.OrderByDescending(p => p.ID).Cast <EncabezadoMatricula>().ToList();  
                if (orderCriteria == "ID_ETC") result = result.OrderByDescending(p => p.ID_ETC).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderByDescending(p => p.sID_ETC).Cast<EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "ID_TipoProcesoCarga") result = result.OrderByDescending(p => p.ID_TipoProcesoCarga).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "sID_TipoProcesosCargue") result = result.OrderByDescending(p => p.sID_TipoProcesoCarga).Cast<EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "ID_EstadoCargue") result = result.OrderByDescending(p => p.ID_EstadoCargue).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "sID_EstadoProcesoCargue") result = result.OrderByDescending(p => p.sID_EstadoCargue).Cast<EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "Fecha") result = result.OrderByDescending(p => p.Fecha).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "Agno") result = result.OrderByDescending(p => p.Agno).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "Mes") result = result.OrderByDescending(p => p.Mes).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "NombreArchivo") result = result.OrderByDescending(p => p.NombreArchivo).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "TotalRegistros") result = result.OrderByDescending(p => p.TotalRegistros).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "TotalRegistroOK") result = result.OrderByDescending(p => p.TotalRegistroOK).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "TotalResgistroError") result = result.OrderByDescending(p => p.TotalResgistroError).Cast <EncabezadoMatricula>().ToList(); 
                 if (orderCriteria == "MatriculaSectorOficial") result = result.OrderByDescending(p => p.MatriculaSectorOficial).Cast <EncabezadoMatricula>().ToList(); 
                     }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.ID != null && r.ID.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_ETC != null && r.ID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ETC != null && r.sID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoProcesoCarga != null && r.ID_TipoProcesoCarga.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoProcesoCarga != null && r.sID_TipoProcesoCarga.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_EstadoCargue != null && r.ID_EstadoCargue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_EstadoCargue != null && r.sID_EstadoCargue.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Fecha != null && r.Fecha.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Agno != null && r.Agno.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Mes != null && r.Mes.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NombreArchivo != null && r.NombreArchivo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TotalRegistros != null && r.TotalRegistros.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TotalRegistroOK != null && r.TotalRegistroOK.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TotalResgistroError != null && r.TotalResgistroError.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.MatriculaSectorOficial != null && r.MatriculaSectorOficial.ToString().ToUpper().Contains(searchBy.ToUpper()) 
      
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
                    data[i].sID = SISPAE.Common.Utilidades.Encrypt($"id={data[i].ID.ToString()}");
                   
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
        /// CRUD de la entidad EncabezadoMatricula --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  EncabezadoMatricula!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de EncabezadoMatricula</param>
        /// <response code="200">EncabezadoMatricula Consulto los registros exitosamente</response>
        /// <response code="400">EncabezadoMatricula tiene valores invalidos </response>
        /// <response code="401">EncabezadoMatricula No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar EncabezadoMatricula en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new EncabezadoMatriculaMs().GetAllByWithRelation().Cast<EncabezadoMatricula>().AsQueryable();
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
