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
    [SwaggerTag("Web API para CRUD de PlantaBodegas .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PlantaBodegasController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PlantaBodegas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlantaBodegas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlantaBodegas</param>
        /// <response code="200">PlantaBodegas Consulto los registros exitosamente</response>
        /// <response code="400">PlantaBodegas tiene valores invalidos </response>
        /// <response code="401">PlantaBodegas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlantaBodegas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new PlantaBodegasMs().GetAll().Cast<PlantaBodegas>().AsQueryable();
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
        /// CRUD de la entidad PlantaBodegas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlantaBodegas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlantaBodegas</param>
        /// <response code="200">PlantaBodegas Consulto los registros exitosamente</response>
        /// <response code="400">PlantaBodegas tiene valores invalidos </response>
        /// <response code="401">PlantaBodegas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlantaBodegas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new PlantaBodegasMs().GetAllFull().Cast<PlantaBodegas>().AsQueryable();
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
        /// CRUD de la entidad PlantaBodegas --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlantaBodegas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlantaBodegas</param>
        /// <response code="200">PlantaBodegas Consulto los registros exitosamente</response>
        /// <response code="400">PlantaBodegas tiene valores invalidos </response>
        /// <response code="401">PlantaBodegas No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar PlantaBodegas en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new PlantaBodegasMs().GetById(new PlantaBodegas() { id = id });
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
        /// CRUD de la entidad PlantaBodegas --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlantaBodegas!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de PlantaBodegas</param>
        /// <response code="200">PlantaBodegas Creado</response>
        /// <response code="400">PlantaBodegas tiene valores invalidos </response>
        /// <response code="401">PlantaBodegas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear PlantaBodegas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] PlantaBodegas obj)
        {
            try
            {
                var result = new PlantaBodegasMs().Add(obj);
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
        /// CRUD de la entidad PlantaBodegas --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlantaBodegas!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de PlantaBodegas</param>
        /// <response code="200">PlantaBodegas Actualizado</response>
        /// <response code="400">PlantaBodegas tiene valores invalidos </response>
        /// <response code="401">PlantaBodegas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar PlantaBodegas en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] PlantaBodegas obj)
        {
            try
            {
                var result = new PlantaBodegasMs().Update(obj);
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
        /// CRUD de la entidad PlantaBodegas --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlantaBodegas!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de PlantaBodegas</param>
        /// <response code="200">PlantaBodegas Eliminado</response>
        /// <response code="400">PlantaBodegas tiene valores invalidos </response>
        /// <response code="401">PlantaBodegas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar PlantaBodegas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] PlantaBodegas obj)
        {
           try
            {
                new PlantaBodegasMs().Delete(obj);
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
        /// DataTable de la entidad PlantaBodegas --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  PlantaBodegas!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de PlantaBodegas</param>
        /// <response code="200">PlantaBodegas Resultado</response>
        /// <response code="400">PlantaBodegas tiene valores invalidos </response>
        /// <response code="401">PlantaBodegas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  PlantaBodegas en este momento</response>
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

                var result = new PlantaBodegasMs().GetAllByWithRelation().Cast<PlantaBodegas>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <PlantaBodegas>().ToList();  
                if (orderCriteria == "ID_TipoPlantaBodega") result = result.OrderBy(p => p.ID_TipoPlantaBodega).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "sID_TiposPlantaBodega") result = result.OrderBy(p => p.sID_TipoPlantaBodega).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "ID_PlanAlistamiento") result = result.OrderBy(p => p.ID_PlanAlistamiento).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "sID_PlanesAlistamientos") result = result.OrderBy(p => p.sID_PlanAlistamiento).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "ID_Divipola") result = result.OrderBy(p => p.ID_Divipola).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "sID_Divipolas") result = result.OrderBy(p => p.sID_Divipola).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "ID_EstadoPlantaBodega") result = result.OrderBy(p => p.ID_EstadoPlantaBodega).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "sID_EstadoPlantaBodega") result = result.OrderBy(p => p.sID_EstadoPlantaBodega).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "Direccion") result = result.OrderBy(p => p.Direccion).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "Celular") result = result.OrderBy(p => p.Celular).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "NombreContacto") result = result.OrderBy(p => p.NombreContacto).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "ApellidoContacto") result = result.OrderBy(p => p.ApellidoContacto).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "Correo") result = result.OrderBy(p => p.Correo).Cast <PlantaBodegas>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <PlantaBodegas>().ToList();  
                if (orderCriteria == "ID_TipoPlantaBodega") result = result.OrderByDescending(p => p.ID_TipoPlantaBodega).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "sID_TiposPlantaBodega") result = result.OrderByDescending(p => p.sID_TipoPlantaBodega).Cast<PlantaBodegas>().ToList(); 
                 if (orderCriteria == "ID_PlanAlistamiento") result = result.OrderByDescending(p => p.ID_PlanAlistamiento).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "sID_PlanesAlistamientos") result = result.OrderByDescending(p => p.sID_PlanAlistamiento).Cast<PlantaBodegas>().ToList(); 
                 if (orderCriteria == "ID_Divipola") result = result.OrderByDescending(p => p.ID_Divipola).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "sID_Divipolas") result = result.OrderByDescending(p => p.sID_Divipola).Cast<PlantaBodegas>().ToList(); 
                 if (orderCriteria == "ID_EstadoPlantaBodega") result = result.OrderByDescending(p => p.ID_EstadoPlantaBodega).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "sID_EstadoPlantaBodega") result = result.OrderByDescending(p => p.sID_EstadoPlantaBodega).Cast<PlantaBodegas>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "Direccion") result = result.OrderByDescending(p => p.Direccion).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "Celular") result = result.OrderByDescending(p => p.Celular).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "NombreContacto") result = result.OrderByDescending(p => p.NombreContacto).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "ApellidoContacto") result = result.OrderByDescending(p => p.ApellidoContacto).Cast <PlantaBodegas>().ToList(); 
                 if (orderCriteria == "Correo") result = result.OrderByDescending(p => p.Correo).Cast <PlantaBodegas>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoPlantaBodega != null && r.ID_TipoPlantaBodega.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoPlantaBodega != null && r.sID_TipoPlantaBodega.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_PlanAlistamiento != null && r.ID_PlanAlistamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_PlanAlistamiento != null && r.sID_PlanAlistamiento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Divipola != null && r.ID_Divipola.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Divipola != null && r.sID_Divipola.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_EstadoPlantaBodega != null && r.ID_EstadoPlantaBodega.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_EstadoPlantaBodega != null && r.sID_EstadoPlantaBodega.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Direccion != null && r.Direccion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Celular != null && r.Celular.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NombreContacto != null && r.NombreContacto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ApellidoContacto != null && r.ApellidoContacto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Correo != null && r.Correo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad PlantaBodegas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  PlantaBodegas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlantaBodegas</param>
        /// <response code="200">PlantaBodegas Consulto los registros exitosamente</response>
        /// <response code="400">PlantaBodegas tiene valores invalidos </response>
        /// <response code="401">PlantaBodegas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlantaBodegas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new PlantaBodegasMs().GetAllByWithRelation().Cast<PlantaBodegas>().AsQueryable();
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
