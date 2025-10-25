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
    [SwaggerTag("Web API para CRUD de Presentaciones .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PresentacionesController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Presentaciones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Presentaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Presentaciones</param>
        /// <response code="200">Presentaciones Consulto los registros exitosamente</response>
        /// <response code="400">Presentaciones tiene valores invalidos </response>
        /// <response code="401">Presentaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Presentaciones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new PresentacionesMs().GetAll().Cast<Presentaciones>().AsQueryable();
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
        /// CRUD de la entidad Presentaciones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Presentaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Presentaciones</param>
        /// <response code="200">Presentaciones Consulto los registros exitosamente</response>
        /// <response code="400">Presentaciones tiene valores invalidos </response>
        /// <response code="401">Presentaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Presentaciones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new PresentacionesMs().GetAllFull().Cast<Presentaciones>().AsQueryable();
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
        /// CRUD de la entidad Presentaciones --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Presentaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Presentaciones</param>
        /// <response code="200">Presentaciones Consulto los registros exitosamente</response>
        /// <response code="400">Presentaciones tiene valores invalidos </response>
        /// <response code="401">Presentaciones No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Presentaciones en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new PresentacionesMs().GetById(new Presentaciones() { id = id });
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
        /// CRUD de la entidad Presentaciones --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Presentaciones!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Presentaciones</param>
        /// <response code="200">Presentaciones Creado</response>
        /// <response code="400">Presentaciones tiene valores invalidos </response>
        /// <response code="401">Presentaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Presentaciones en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Presentaciones obj)
        {
            try
            {
                var result = new PresentacionesMs().Add(obj);
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
        /// CRUD de la entidad Presentaciones --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Presentaciones!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Presentaciones</param>
        /// <response code="200">Presentaciones Actualizado</response>
        /// <response code="400">Presentaciones tiene valores invalidos </response>
        /// <response code="401">Presentaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Presentaciones en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Presentaciones obj)
        {
            try
            {
                var result = new PresentacionesMs().Update(obj);
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
        /// CRUD de la entidad Presentaciones --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Presentaciones!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Presentaciones</param>
        /// <response code="200">Presentaciones Eliminado</response>
        /// <response code="400">Presentaciones tiene valores invalidos </response>
        /// <response code="401">Presentaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Presentaciones en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Presentaciones obj)
        {
           try
            {
                new PresentacionesMs().Delete(obj);
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
        /// DataTable de la entidad Presentaciones --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Presentaciones!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Presentaciones</param>
        /// <response code="200">Presentaciones Resultado</response>
        /// <response code="400">Presentaciones tiene valores invalidos </response>
        /// <response code="401">Presentaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Presentaciones en este momento</response>
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

                var result = new PresentacionesMs().GetAllByWithRelation().Cast<Presentaciones>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Presentaciones>().ToList();  
                if (orderCriteria == "ID_Producto") result = result.OrderBy(p => p.ID_Producto).Cast <Presentaciones>().ToList(); 
                 if (orderCriteria == "sID_Productos") result = result.OrderBy(p => p.sID_Producto).Cast <Presentaciones>().ToList(); 
                 if (orderCriteria == "ID_TipoGrupoEtareo") result = result.OrderBy(p => p.ID_TipoGrupoEtareo).Cast <Presentaciones>().ToList(); 
                 if (orderCriteria == "sID_TiposGrupoEtario") result = result.OrderBy(p => p.sID_TipoGrupoEtareo).Cast <Presentaciones>().ToList(); 
                 if (orderCriteria == "PesoNeto") result = result.OrderBy(p => p.PesoNeto).Cast <Presentaciones>().ToList(); 
                 if (orderCriteria == "PesoBruto") result = result.OrderBy(p => p.PesoBruto).Cast <Presentaciones>().ToList(); 
                 if (orderCriteria == "PesoServido") result = result.OrderBy(p => p.PesoServido).Cast <Presentaciones>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Presentaciones>().ToList();  
                if (orderCriteria == "ID_Producto") result = result.OrderByDescending(p => p.ID_Producto).Cast <Presentaciones>().ToList(); 
                 if (orderCriteria == "sID_Productos") result = result.OrderByDescending(p => p.sID_Producto).Cast<Presentaciones>().ToList(); 
                 if (orderCriteria == "ID_TipoGrupoEtareo") result = result.OrderByDescending(p => p.ID_TipoGrupoEtareo).Cast <Presentaciones>().ToList(); 
                 if (orderCriteria == "sID_TiposGrupoEtario") result = result.OrderByDescending(p => p.sID_TipoGrupoEtareo).Cast<Presentaciones>().ToList(); 
                 if (orderCriteria == "PesoNeto") result = result.OrderByDescending(p => p.PesoNeto).Cast <Presentaciones>().ToList(); 
                 if (orderCriteria == "PesoBruto") result = result.OrderByDescending(p => p.PesoBruto).Cast <Presentaciones>().ToList(); 
                 if (orderCriteria == "PesoServido") result = result.OrderByDescending(p => p.PesoServido).Cast <Presentaciones>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Producto != null && r.ID_Producto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Producto != null && r.sID_Producto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoGrupoEtareo != null && r.ID_TipoGrupoEtareo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoGrupoEtareo != null && r.sID_TipoGrupoEtareo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PesoNeto != null && r.PesoNeto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PesoBruto != null && r.PesoBruto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PesoServido != null && r.PesoServido.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad Presentaciones --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  Presentaciones!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Presentaciones</param>
        /// <response code="200">Presentaciones Consulto los registros exitosamente</response>
        /// <response code="400">Presentaciones tiene valores invalidos </response>
        /// <response code="401">Presentaciones No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Presentaciones en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new PresentacionesMs().GetAllByWithRelation().Cast<Presentaciones>().AsQueryable();
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
