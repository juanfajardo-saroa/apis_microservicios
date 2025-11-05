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

namespace SISPAE_API_SistemaEducativo.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de Sedes .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class SedesController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Sedes --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  Sedes!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Sedes</param>
        /// <response code="200">Sedes Consulto los registros exitosamente</response>
        /// <response code="400">Sedes tiene valores invalidos </response>
        /// <response code="401">Sedes No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Sedes en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new SedesMs().GetAll().Cast<Sedes>().AsQueryable();
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
        /// CRUD de la entidad Sedes --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  Sedes!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Sedes</param>
        /// <response code="200">Sedes Consulto los registros exitosamente</response>
        /// <response code="400">Sedes tiene valores invalidos </response>
        /// <response code="401">Sedes No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Sedes en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new SedesMs().GetAllFull().Cast<Sedes>().AsQueryable();
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
        /// CRUD de la entidad Sedes --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  Sedes!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Sedes</param>
        /// <response code="200">Sedes Consulto los registros exitosamente</response>
        /// <response code="400">Sedes tiene valores invalidos </response>
        /// <response code="401">Sedes No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Sedes en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new SedesMs().GetById(new Sedes() { id = id });
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
        /// CRUD de la entidad Sedes --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_SistemaEducativo de la entidad  Sedes!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Sedes</param>
        /// <response code="200">Sedes Creado</response>
        /// <response code="400">Sedes tiene valores invalidos </response>
        /// <response code="401">Sedes No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Sedes en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Sedes obj)
        {
            try
            {
                var result = new SedesMs().Add(obj);
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
        /// CRUD de la entidad Sedes --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  Sedes!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Sedes</param>
        /// <response code="200">Sedes Actualizado</response>
        /// <response code="400">Sedes tiene valores invalidos </response>
        /// <response code="401">Sedes No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Sedes en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Sedes obj)
        {
            try
            {
                var result = new SedesMs().Update(obj);
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
        /// CRUD de la entidad Sedes --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  Sedes!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Sedes</param>
        /// <response code="200">Sedes Eliminado</response>
        /// <response code="400">Sedes tiene valores invalidos </response>
        /// <response code="401">Sedes No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Sedes en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Sedes obj)
        {
           try
            {
                new SedesMs().Delete(obj);
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
        /// DataTable de la entidad Sedes --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Sedes!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Sedes</param>
        /// <response code="200">Sedes Resultado</response>
        /// <response code="400">Sedes tiene valores invalidos </response>
        /// <response code="401">Sedes No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Sedes en este momento</response>
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

                var result = new SedesMs().GetAllByWithRelation().Cast<Sedes>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Sedes>().ToList();  
                if (orderCriteria == "ID_lE") result = result.OrderBy(p => p.ID_lE).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "sID_InstitucionEducativa") result = result.OrderBy(p => p.sID_lE).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "ID_Zona") result = result.OrderBy(p => p.ID_Zona).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "sID_Zonas") result = result.OrderBy(p => p.sID_Zona).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "ID_GrupoAnalisis") result = result.OrderBy(p => p.ID_GrupoAnalisis).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "sID_GruposAnalisis") result = result.OrderBy(p => p.sID_GrupoAnalisis).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderBy(p => p.ID_ETC).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderBy(p => p.sID_ETC).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "ID_Divipola") result = result.OrderBy(p => p.ID_Divipola).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "sID_Divipolas") result = result.OrderBy(p => p.sID_Divipola).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "ID_TipoAcceso") result = result.OrderBy(p => p.ID_TipoAcceso).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "sID_TiposAcceso") result = result.OrderBy(p => p.sID_TipoAcceso).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "CodigoDane") result = result.OrderBy(p => p.CodigoDane).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "Direccion") result = result.OrderBy(p => p.Direccion).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "Telefono") result = result.OrderBy(p => p.Telefono).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "Etnico") result = result.OrderBy(p => p.Etnico).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "PriorizacionPAE") result = result.OrderBy(p => p.PriorizacionPAE).Cast <Sedes>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Sedes>().ToList();  
                if (orderCriteria == "ID_lE") result = result.OrderByDescending(p => p.ID_lE).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "sID_InstitucionEducativa") result = result.OrderByDescending(p => p.sID_lE).Cast<Sedes>().ToList(); 
                 if (orderCriteria == "ID_Zona") result = result.OrderByDescending(p => p.ID_Zona).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "sID_Zonas") result = result.OrderByDescending(p => p.sID_Zona).Cast<Sedes>().ToList(); 
                 if (orderCriteria == "ID_GrupoAnalisis") result = result.OrderByDescending(p => p.ID_GrupoAnalisis).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "sID_GruposAnalisis") result = result.OrderByDescending(p => p.sID_GrupoAnalisis).Cast<Sedes>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderByDescending(p => p.ID_ETC).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderByDescending(p => p.sID_ETC).Cast<Sedes>().ToList(); 
                 if (orderCriteria == "ID_Divipola") result = result.OrderByDescending(p => p.ID_Divipola).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "sID_Divipolas") result = result.OrderByDescending(p => p.sID_Divipola).Cast<Sedes>().ToList(); 
                 if (orderCriteria == "ID_TipoAcceso") result = result.OrderByDescending(p => p.ID_TipoAcceso).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "sID_TiposAcceso") result = result.OrderByDescending(p => p.sID_TipoAcceso).Cast<Sedes>().ToList(); 
                 if (orderCriteria == "CodigoDane") result = result.OrderByDescending(p => p.CodigoDane).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "Direccion") result = result.OrderByDescending(p => p.Direccion).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "Telefono") result = result.OrderByDescending(p => p.Telefono).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "Etnico") result = result.OrderByDescending(p => p.Etnico).Cast <Sedes>().ToList(); 
                 if (orderCriteria == "PriorizacionPAE") result = result.OrderByDescending(p => p.PriorizacionPAE).Cast <Sedes>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_lE != null && r.ID_lE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_lE != null && r.sID_lE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Zona != null && r.ID_Zona.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Zona != null && r.sID_Zona.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_GrupoAnalisis != null && r.ID_GrupoAnalisis.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_GrupoAnalisis != null && r.sID_GrupoAnalisis.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_ETC != null && r.ID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ETC != null && r.sID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Divipola != null && r.ID_Divipola.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Divipola != null && r.sID_Divipola.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoAcceso != null && r.ID_TipoAcceso.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoAcceso != null && r.sID_TipoAcceso.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CodigoDane != null && r.CodigoDane.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Direccion != null && r.Direccion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Telefono != null && r.Telefono.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Etnico != null && r.Etnico.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PriorizacionPAE != null && r.PriorizacionPAE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad Sedes --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  Sedes!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Sedes</param>
        /// <response code="200">Sedes Consulto los registros exitosamente</response>
        /// <response code="400">Sedes tiene valores invalidos </response>
        /// <response code="401">Sedes No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Sedes en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new SedesMs().GetAllByWithRelation().Cast<Sedes>().AsQueryable();
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
