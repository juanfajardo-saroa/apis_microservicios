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

namespace SISPAE_API_ETC.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de PAC .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PACController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PAC --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_ETC de la entidad  PAC!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PAC</param>
        /// <response code="200">PAC Consulto los registros exitosamente</response>
        /// <response code="400">PAC tiene valores invalidos </response>
        /// <response code="401">PAC No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PAC en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new PACMs().GetAll().Cast<PAC>().AsQueryable();
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
        /// CRUD de la entidad PAC --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_ETC de la entidad  PAC!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PAC</param>
        /// <response code="200">PAC Consulto los registros exitosamente</response>
        /// <response code="400">PAC tiene valores invalidos </response>
        /// <response code="401">PAC No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PAC en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new PACMs().GetAllFull().Cast<PAC>().AsQueryable();
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
        /// CRUD de la entidad PAC --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_ETC de la entidad  PAC!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PAC</param>
        /// <response code="200">PAC Consulto los registros exitosamente</response>
        /// <response code="400">PAC tiene valores invalidos </response>
        /// <response code="401">PAC No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar PAC en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new PACMs().GetById(new PAC() { id = id });
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
        /// CRUD de la entidad PAC --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_ETC de la entidad  PAC!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de PAC</param>
        /// <response code="200">PAC Creado</response>
        /// <response code="400">PAC tiene valores invalidos </response>
        /// <response code="401">PAC No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear PAC en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] PAC obj)
        {
            try
            {
                var result = new PACMs().Add(obj);
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
        /// CRUD de la entidad PAC --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_ETC de la entidad  PAC!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de PAC</param>
        /// <response code="200">PAC Actualizado</response>
        /// <response code="400">PAC tiene valores invalidos </response>
        /// <response code="401">PAC No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar PAC en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] PAC obj)
        {
            try
            {
                var result = new PACMs().Update(obj);
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
        /// CRUD de la entidad PAC --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_ETC de la entidad  PAC!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de PAC</param>
        /// <response code="200">PAC Eliminado</response>
        /// <response code="400">PAC tiene valores invalidos </response>
        /// <response code="401">PAC No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar PAC en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] PAC obj)
        {
           try
            {
                new PACMs().Delete(obj);
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
        /// DataTable de la entidad PAC --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  PAC!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de PAC</param>
        /// <response code="200">PAC Resultado</response>
        /// <response code="400">PAC tiene valores invalidos </response>
        /// <response code="401">PAC No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  PAC en este momento</response>
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

                var result = new PACMs().GetAllByWithRelation().Cast<PAC>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <PAC>().ToList();  
                if (orderCriteria == "ID_ETC") result = result.OrderBy(p => p.ID_ETC).Cast <PAC>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderBy(p => p.sID_ETC).Cast <PAC>().ToList(); 
                 if (orderCriteria == "ID_Vigencia") result = result.OrderBy(p => p.ID_Vigencia).Cast <PAC>().ToList(); 
                 if (orderCriteria == "sID_Vigencias") result = result.OrderBy(p => p.sID_Vigencia).Cast <PAC>().ToList(); 
                 if (orderCriteria == "Mes") result = result.OrderBy(p => p.Mes).Cast <PAC>().ToList(); 
                 if (orderCriteria == "sID_Meses") result = result.OrderBy(p => p.sMes).Cast <PAC>().ToList(); 
                 if (orderCriteria == "GiroProyectado") result = result.OrderBy(p => p.GiroProyectado).Cast <PAC>().ToList(); 
                 if (orderCriteria == "GiroConfirmado") result = result.OrderBy(p => p.GiroConfirmado).Cast <PAC>().ToList(); 
                 if (orderCriteria == "DocumentoGiro") result = result.OrderBy(p => p.DocumentoGiro).Cast <PAC>().ToList(); 
                 if (orderCriteria == "FechaGiro") result = result.OrderBy(p => p.FechaGiro).Cast <PAC>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <PAC>().ToList();  
                if (orderCriteria == "ID_ETC") result = result.OrderByDescending(p => p.ID_ETC).Cast <PAC>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderByDescending(p => p.sID_ETC).Cast<PAC>().ToList(); 
                 if (orderCriteria == "ID_Vigencia") result = result.OrderByDescending(p => p.ID_Vigencia).Cast <PAC>().ToList(); 
                 if (orderCriteria == "sID_Vigencias") result = result.OrderByDescending(p => p.sID_Vigencia).Cast<PAC>().ToList(); 
                 if (orderCriteria == "Mes") result = result.OrderByDescending(p => p.Mes).Cast <PAC>().ToList(); 
                 if (orderCriteria == "sID_Meses") result = result.OrderByDescending(p => p.sMes).Cast<PAC>().ToList(); 
                 if (orderCriteria == "GiroProyectado") result = result.OrderByDescending(p => p.GiroProyectado).Cast <PAC>().ToList(); 
                 if (orderCriteria == "GiroConfirmado") result = result.OrderByDescending(p => p.GiroConfirmado).Cast <PAC>().ToList(); 
                 if (orderCriteria == "DocumentoGiro") result = result.OrderByDescending(p => p.DocumentoGiro).Cast <PAC>().ToList(); 
                 if (orderCriteria == "FechaGiro") result = result.OrderByDescending(p => p.FechaGiro).Cast <PAC>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_ETC != null && r.ID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ETC != null && r.sID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Vigencia != null && r.ID_Vigencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Vigencia != null && r.sID_Vigencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Mes != null && r.Mes.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sMes != null && r.sMes.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.GiroProyectado != null && r.GiroProyectado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.GiroConfirmado != null && r.GiroConfirmado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.DocumentoGiro != null && r.DocumentoGiro.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaGiro != null && r.FechaGiro.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad PAC --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_ETC de la entidad  PAC!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PAC</param>
        /// <response code="200">PAC Consulto los registros exitosamente</response>
        /// <response code="400">PAC tiene valores invalidos </response>
        /// <response code="401">PAC No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PAC en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new PACMs().GetAllByWithRelation().Cast<PAC>().AsQueryable();
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
