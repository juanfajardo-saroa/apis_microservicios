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

namespace SISPAE_API_Contratos.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de CRPs .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class CRPsController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad CRPs --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  CRPs!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de CRPs</param>
        /// <response code="200">CRPs Consulto los registros exitosamente</response>
        /// <response code="400">CRPs tiene valores invalidos </response>
        /// <response code="401">CRPs No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar CRPs en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new CRPsMs().GetAll().Cast<CRPs>().AsQueryable();
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
        /// CRUD de la entidad CRPs --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  CRPs!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de CRPs</param>
        /// <response code="200">CRPs Consulto los registros exitosamente</response>
        /// <response code="400">CRPs tiene valores invalidos </response>
        /// <response code="401">CRPs No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar CRPs en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new CRPsMs().GetAllFull().Cast<CRPs>().AsQueryable();
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
        /// CRUD de la entidad CRPs --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  CRPs!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de CRPs</param>
        /// <response code="200">CRPs Consulto los registros exitosamente</response>
        /// <response code="400">CRPs tiene valores invalidos </response>
        /// <response code="401">CRPs No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar CRPs en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new CRPsMs().GetById(new CRPs() { id = id });
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
        /// CRUD de la entidad CRPs --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  CRPs!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de CRPs</param>
        /// <response code="200">CRPs Creado</response>
        /// <response code="400">CRPs tiene valores invalidos </response>
        /// <response code="401">CRPs No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear CRPs en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] CRPs obj)
        {
            try
            {
                var result = new CRPsMs().Add(obj);
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
        /// CRUD de la entidad CRPs --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  CRPs!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de CRPs</param>
        /// <response code="200">CRPs Actualizado</response>
        /// <response code="400">CRPs tiene valores invalidos </response>
        /// <response code="401">CRPs No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar CRPs en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] CRPs obj)
        {
            try
            {
                var result = new CRPsMs().Update(obj);
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
        /// CRUD de la entidad CRPs --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  CRPs!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de CRPs</param>
        /// <response code="200">CRPs Eliminado</response>
        /// <response code="400">CRPs tiene valores invalidos </response>
        /// <response code="401">CRPs No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar CRPs en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] CRPs obj)
        {
           try
            {
                new CRPsMs().Delete(obj);
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
        /// DataTable de la entidad CRPs --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  CRPs!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de CRPs</param>
        /// <response code="200">CRPs Resultado</response>
        /// <response code="400">CRPs tiene valores invalidos </response>
        /// <response code="401">CRPs No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  CRPs en este momento</response>
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

                var result = new CRPsMs().GetAllByWithRelation().Cast<CRPs>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <CRPs>().ToList();  
                if (orderCriteria == "ID_CDP") result = result.OrderBy(p => p.ID_CDP).Cast <CRPs>().ToList(); 
                 if (orderCriteria == "sID_CDPs") result = result.OrderBy(p => p.sID_CDP).Cast <CRPs>().ToList(); 
                 if (orderCriteria == "NumeroCRP") result = result.OrderBy(p => p.NumeroCRP).Cast <CRPs>().ToList(); 
                 if (orderCriteria == "FechaCRP") result = result.OrderBy(p => p.FechaCRP).Cast <CRPs>().ToList(); 
                 if (orderCriteria == "ValorCRP") result = result.OrderBy(p => p.ValorCRP).Cast <CRPs>().ToList(); 
                 if (orderCriteria == "PathArchivoCRP") result = result.OrderBy(p => p.PathArchivoCRP).Cast <CRPs>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <CRPs>().ToList();  
                if (orderCriteria == "ID_CDP") result = result.OrderByDescending(p => p.ID_CDP).Cast <CRPs>().ToList(); 
                 if (orderCriteria == "sID_CDPs") result = result.OrderByDescending(p => p.sID_CDP).Cast<CRPs>().ToList(); 
                 if (orderCriteria == "NumeroCRP") result = result.OrderByDescending(p => p.NumeroCRP).Cast <CRPs>().ToList(); 
                 if (orderCriteria == "FechaCRP") result = result.OrderByDescending(p => p.FechaCRP).Cast <CRPs>().ToList(); 
                 if (orderCriteria == "ValorCRP") result = result.OrderByDescending(p => p.ValorCRP).Cast <CRPs>().ToList(); 
                 if (orderCriteria == "PathArchivoCRP") result = result.OrderByDescending(p => p.PathArchivoCRP).Cast <CRPs>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_CDP != null && r.ID_CDP.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_CDP != null && r.sID_CDP.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumeroCRP != null && r.NumeroCRP.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaCRP != null && r.FechaCRP.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ValorCRP != null && r.ValorCRP.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PathArchivoCRP != null && r.PathArchivoCRP.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad CRPs --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  CRPs!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de CRPs</param>
        /// <response code="200">CRPs Consulto los registros exitosamente</response>
        /// <response code="400">CRPs tiene valores invalidos </response>
        /// <response code="401">CRPs No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar CRPs en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new CRPsMs().GetAllByWithRelation().Cast<CRPs>().AsQueryable();
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
