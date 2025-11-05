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

namespace SISPAE_API_AlimentosMenu.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de AlimentosMinuta .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class AlimentosMinutaController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad AlimentosMinuta --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosMinuta!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AlimentosMinuta</param>
        /// <response code="200">AlimentosMinuta Consulto los registros exitosamente</response>
        /// <response code="400">AlimentosMinuta tiene valores invalidos </response>
        /// <response code="401">AlimentosMinuta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AlimentosMinuta en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new AlimentosMinutaMs().GetAll().Cast<AlimentosMinuta>().AsQueryable();
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
        /// CRUD de la entidad AlimentosMinuta --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosMinuta!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AlimentosMinuta</param>
        /// <response code="200">AlimentosMinuta Consulto los registros exitosamente</response>
        /// <response code="400">AlimentosMinuta tiene valores invalidos </response>
        /// <response code="401">AlimentosMinuta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AlimentosMinuta en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new AlimentosMinutaMs().GetAllFull().Cast<AlimentosMinuta>().AsQueryable();
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
        /// CRUD de la entidad AlimentosMinuta --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosMinuta!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AlimentosMinuta</param>
        /// <response code="200">AlimentosMinuta Consulto los registros exitosamente</response>
        /// <response code="400">AlimentosMinuta tiene valores invalidos </response>
        /// <response code="401">AlimentosMinuta No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar AlimentosMinuta en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new AlimentosMinutaMs().GetById(new AlimentosMinuta() { id = id });
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
        /// CRUD de la entidad AlimentosMinuta --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosMinuta!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de AlimentosMinuta</param>
        /// <response code="200">AlimentosMinuta Creado</response>
        /// <response code="400">AlimentosMinuta tiene valores invalidos </response>
        /// <response code="401">AlimentosMinuta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear AlimentosMinuta en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] AlimentosMinuta obj)
        {
            try
            {
                var result = new AlimentosMinutaMs().Add(obj);
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
        /// CRUD de la entidad AlimentosMinuta --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosMinuta!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de AlimentosMinuta</param>
        /// <response code="200">AlimentosMinuta Actualizado</response>
        /// <response code="400">AlimentosMinuta tiene valores invalidos </response>
        /// <response code="401">AlimentosMinuta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar AlimentosMinuta en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] AlimentosMinuta obj)
        {
            try
            {
                var result = new AlimentosMinutaMs().Update(obj);
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
        /// CRUD de la entidad AlimentosMinuta --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosMinuta!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de AlimentosMinuta</param>
        /// <response code="200">AlimentosMinuta Eliminado</response>
        /// <response code="400">AlimentosMinuta tiene valores invalidos </response>
        /// <response code="401">AlimentosMinuta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar AlimentosMinuta en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] AlimentosMinuta obj)
        {
           try
            {
                new AlimentosMinutaMs().Delete(obj);
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
        /// DataTable de la entidad AlimentosMinuta --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  AlimentosMinuta!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de AlimentosMinuta</param>
        /// <response code="200">AlimentosMinuta Resultado</response>
        /// <response code="400">AlimentosMinuta tiene valores invalidos </response>
        /// <response code="401">AlimentosMinuta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  AlimentosMinuta en este momento</response>
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

                var result = new AlimentosMinutaMs().GetAllByWithRelation().Cast<AlimentosMinuta>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <AlimentosMinuta>().ToList();  
                if (orderCriteria == "ID_MinutaPatronAlimento") result = result.OrderBy(p => p.ID_MinutaPatronAlimento).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "sID_MinutaPatronAlimentos") result = result.OrderBy(p => p.sID_MinutaPatronAlimento).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "ID_TipoComponente") result = result.OrderBy(p => p.ID_TipoComponente).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "sID_TiposComponente") result = result.OrderBy(p => p.sID_TipoComponente).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "ID_GrupoAlimento") result = result.OrderBy(p => p.ID_GrupoAlimento).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "sID_GrupoAlimentos") result = result.OrderBy(p => p.sID_GrupoAlimento).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "frecuencia") result = result.OrderBy(p => p.frecuencia).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "MingramoPesoBruto") result = result.OrderBy(p => p.MingramoPesoBruto).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "MaxgramoPesoBruto") result = result.OrderBy(p => p.MaxgramoPesoBruto).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "MingramoPesoNeto") result = result.OrderBy(p => p.MingramoPesoNeto).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "MaxgramoPesoNeto") result = result.OrderBy(p => p.MaxgramoPesoNeto).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "MingramoPesoPorcionServida") result = result.OrderBy(p => p.MingramoPesoPorcionServida).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "MaxgramoPesoPorcionServida") result = result.OrderBy(p => p.MaxgramoPesoPorcionServida).Cast <AlimentosMinuta>().ToList(); 
                     if (orderCriteria == "ID_SubGrupoAlimento") result = result.OrderBy(p => p.ID_SubGrupoAlimento).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "NumIntercambios") result = result.OrderBy(p => p.NumIntercambios).Cast <AlimentosMinuta>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <AlimentosMinuta>().ToList();  
                if (orderCriteria == "ID_MinutaPatronAlimento") result = result.OrderByDescending(p => p.ID_MinutaPatronAlimento).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "sID_MinutaPatronAlimentos") result = result.OrderByDescending(p => p.sID_MinutaPatronAlimento).Cast<AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "ID_TipoComponente") result = result.OrderByDescending(p => p.ID_TipoComponente).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "sID_TiposComponente") result = result.OrderByDescending(p => p.sID_TipoComponente).Cast<AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "ID_GrupoAlimento") result = result.OrderByDescending(p => p.ID_GrupoAlimento).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "sID_GrupoAlimentos") result = result.OrderByDescending(p => p.sID_GrupoAlimento).Cast<AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "frecuencia") result = result.OrderByDescending(p => p.frecuencia).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "MingramoPesoBruto") result = result.OrderByDescending(p => p.MingramoPesoBruto).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "MaxgramoPesoBruto") result = result.OrderByDescending(p => p.MaxgramoPesoBruto).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "MingramoPesoNeto") result = result.OrderByDescending(p => p.MingramoPesoNeto).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "MaxgramoPesoNeto") result = result.OrderByDescending(p => p.MaxgramoPesoNeto).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "MingramoPesoPorcionServida") result = result.OrderByDescending(p => p.MingramoPesoPorcionServida).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "MaxgramoPesoPorcionServida") result = result.OrderByDescending(p => p.MaxgramoPesoPorcionServida).Cast <AlimentosMinuta>().ToList(); 
                     if (orderCriteria == "ID_SubGrupoAlimento") result = result.OrderByDescending(p => p.ID_SubGrupoAlimento).Cast <AlimentosMinuta>().ToList(); 
                 if (orderCriteria == "NumIntercambios") result = result.OrderByDescending(p => p.NumIntercambios).Cast <AlimentosMinuta>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_MinutaPatronAlimento != null && r.ID_MinutaPatronAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_MinutaPatronAlimento != null && r.sID_MinutaPatronAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoComponente != null && r.ID_TipoComponente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoComponente != null && r.sID_TipoComponente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_GrupoAlimento != null && r.ID_GrupoAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_GrupoAlimento != null && r.sID_GrupoAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.frecuencia != null && r.frecuencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.MingramoPesoBruto != null && r.MingramoPesoBruto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.MaxgramoPesoBruto != null && r.MaxgramoPesoBruto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.MingramoPesoNeto != null && r.MingramoPesoNeto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.MaxgramoPesoNeto != null && r.MaxgramoPesoNeto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.MingramoPesoPorcionServida != null && r.MingramoPesoPorcionServida.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.MaxgramoPesoPorcionServida != null && r.MaxgramoPesoPorcionServida.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                     || r.ID_SubGrupoAlimento != null && r.ID_SubGrupoAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumIntercambios != null && r.NumIntercambios.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
        /// CRUD de la entidad AlimentosMinuta --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosMinuta!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AlimentosMinuta</param>
        /// <response code="200">AlimentosMinuta Consulto los registros exitosamente</response>
        /// <response code="400">AlimentosMinuta tiene valores invalidos </response>
        /// <response code="401">AlimentosMinuta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AlimentosMinuta en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new AlimentosMinutaMs().GetAllByWithRelation().Cast<AlimentosMinuta>().AsQueryable();
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
