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
    [SwaggerTag("Web API para CRUD de MinutaPatronProductos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class MinutaPatronProductosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad MinutaPatronProductos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  MinutaPatronProductos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaPatronProductos</param>
        /// <response code="200">MinutaPatronProductos Consulto los registros exitosamente</response>
        /// <response code="400">MinutaPatronProductos tiene valores invalidos </response>
        /// <response code="401">MinutaPatronProductos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaPatronProductos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new MinutaPatronProductosMs().GetAll().Cast<MinutaPatronProductos>().AsQueryable();
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
        /// CRUD de la entidad MinutaPatronProductos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  MinutaPatronProductos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaPatronProductos</param>
        /// <response code="200">MinutaPatronProductos Consulto los registros exitosamente</response>
        /// <response code="400">MinutaPatronProductos tiene valores invalidos </response>
        /// <response code="401">MinutaPatronProductos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaPatronProductos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new MinutaPatronProductosMs().GetAllFull().Cast<MinutaPatronProductos>().AsQueryable();
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
        /// CRUD de la entidad MinutaPatronProductos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  MinutaPatronProductos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaPatronProductos</param>
        /// <response code="200">MinutaPatronProductos Consulto los registros exitosamente</response>
        /// <response code="400">MinutaPatronProductos tiene valores invalidos </response>
        /// <response code="401">MinutaPatronProductos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar MinutaPatronProductos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new MinutaPatronProductosMs().GetById(new MinutaPatronProductos() { ID = id });
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
        /// CRUD de la entidad MinutaPatronProductos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  MinutaPatronProductos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de MinutaPatronProductos</param>
        /// <response code="200">MinutaPatronProductos Creado</response>
        /// <response code="400">MinutaPatronProductos tiene valores invalidos </response>
        /// <response code="401">MinutaPatronProductos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear MinutaPatronProductos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] MinutaPatronProductos obj)
        {
            try
            {
                var result = new MinutaPatronProductosMs().Add(obj);
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
        /// CRUD de la entidad MinutaPatronProductos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  MinutaPatronProductos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de MinutaPatronProductos</param>
        /// <response code="200">MinutaPatronProductos Actualizado</response>
        /// <response code="400">MinutaPatronProductos tiene valores invalidos </response>
        /// <response code="401">MinutaPatronProductos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar MinutaPatronProductos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] MinutaPatronProductos obj)
        {
            try
            {
                var result = new MinutaPatronProductosMs().Update(obj);
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
        /// CRUD de la entidad MinutaPatronProductos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  MinutaPatronProductos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de MinutaPatronProductos</param>
        /// <response code="200">MinutaPatronProductos Eliminado</response>
        /// <response code="400">MinutaPatronProductos tiene valores invalidos </response>
        /// <response code="401">MinutaPatronProductos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar MinutaPatronProductos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] MinutaPatronProductos obj)
        {
           try
            {
                new MinutaPatronProductosMs().Delete(obj);
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
        /// DataTable de la entidad MinutaPatronProductos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  MinutaPatronProductos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de MinutaPatronProductos</param>
        /// <response code="200">MinutaPatronProductos Resultado</response>
        /// <response code="400">MinutaPatronProductos tiene valores invalidos </response>
        /// <response code="401">MinutaPatronProductos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  MinutaPatronProductos en este momento</response>
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

                var result = new MinutaPatronProductosMs().GetAllByWithRelation().Cast<MinutaPatronProductos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="ID") result = result.OrderBy(p => p.ID).Cast <MinutaPatronProductos>().ToList();  
                if (orderCriteria == "ID_TipoGrupoEtario") result = result.OrderBy(p => p.ID_TipoGrupoEtario).Cast <MinutaPatronProductos>().ToList(); 
                 if (orderCriteria == "sID_TiposGrupoEtario") result = result.OrderBy(p => p.sID_TipoGrupoEtario).Cast <MinutaPatronProductos>().ToList(); 
                 if (orderCriteria == "ID_Nutriente") result = result.OrderBy(p => p.ID_Nutriente).Cast <MinutaPatronProductos>().ToList(); 
                 if (orderCriteria == "sID_Nutrientes") result = result.OrderBy(p => p.sID_Nutriente).Cast <MinutaPatronProductos>().ToList(); 
                 if (orderCriteria == "Aporte") result = result.OrderBy(p => p.Aporte).Cast <MinutaPatronProductos>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "ID") result = result.OrderByDescending(p => p.ID).Cast <MinutaPatronProductos>().ToList();  
                if (orderCriteria == "ID_TipoGrupoEtario") result = result.OrderByDescending(p => p.ID_TipoGrupoEtario).Cast <MinutaPatronProductos>().ToList(); 
                 if (orderCriteria == "sID_TiposGrupoEtario") result = result.OrderByDescending(p => p.sID_TipoGrupoEtario).Cast<MinutaPatronProductos>().ToList(); 
                 if (orderCriteria == "ID_Nutriente") result = result.OrderByDescending(p => p.ID_Nutriente).Cast <MinutaPatronProductos>().ToList(); 
                 if (orderCriteria == "sID_Nutrientes") result = result.OrderByDescending(p => p.sID_Nutriente).Cast<MinutaPatronProductos>().ToList(); 
                 if (orderCriteria == "Aporte") result = result.OrderByDescending(p => p.Aporte).Cast <MinutaPatronProductos>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.ID != null && r.ID.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoGrupoEtario != null && r.ID_TipoGrupoEtario.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoGrupoEtario != null && r.sID_TipoGrupoEtario.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Nutriente != null && r.ID_Nutriente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Nutriente != null && r.sID_Nutriente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Aporte != null && r.Aporte.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad MinutaPatronProductos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  MinutaPatronProductos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de MinutaPatronProductos</param>
        /// <response code="200">MinutaPatronProductos Consulto los registros exitosamente</response>
        /// <response code="400">MinutaPatronProductos tiene valores invalidos </response>
        /// <response code="401">MinutaPatronProductos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar MinutaPatronProductos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new MinutaPatronProductosMs().GetAllByWithRelation().Cast<MinutaPatronProductos>().AsQueryable();
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
