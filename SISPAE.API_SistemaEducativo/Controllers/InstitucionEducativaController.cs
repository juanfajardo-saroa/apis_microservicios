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
    [SwaggerTag("Web API para CRUD de InstitucionEducativa .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class InstitucionEducativaController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad InstitucionEducativa --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  InstitucionEducativa!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de InstitucionEducativa</param>
        /// <response code="200">InstitucionEducativa Consulto los registros exitosamente</response>
        /// <response code="400">InstitucionEducativa tiene valores invalidos </response>
        /// <response code="401">InstitucionEducativa No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar InstitucionEducativa en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new InstitucionEducativaMs().GetAll().Cast<InstitucionEducativa>().AsQueryable();
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
        /// CRUD de la entidad InstitucionEducativa --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  InstitucionEducativa!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de InstitucionEducativa</param>
        /// <response code="200">InstitucionEducativa Consulto los registros exitosamente</response>
        /// <response code="400">InstitucionEducativa tiene valores invalidos </response>
        /// <response code="401">InstitucionEducativa No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar InstitucionEducativa en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new InstitucionEducativaMs().GetAllFull().Cast<InstitucionEducativa>().AsQueryable();
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
        /// CRUD de la entidad InstitucionEducativa --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  InstitucionEducativa!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de InstitucionEducativa</param>
        /// <response code="200">InstitucionEducativa Consulto los registros exitosamente</response>
        /// <response code="400">InstitucionEducativa tiene valores invalidos </response>
        /// <response code="401">InstitucionEducativa No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar InstitucionEducativa en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new InstitucionEducativaMs().GetById(new InstitucionEducativa() { id = id });
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
        /// CRUD de la entidad InstitucionEducativa --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_SistemaEducativo de la entidad  InstitucionEducativa!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de InstitucionEducativa</param>
        /// <response code="200">InstitucionEducativa Creado</response>
        /// <response code="400">InstitucionEducativa tiene valores invalidos </response>
        /// <response code="401">InstitucionEducativa No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear InstitucionEducativa en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] InstitucionEducativa obj)
        {
            try
            {
                var result = new InstitucionEducativaMs().Add(obj);
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
        /// CRUD de la entidad InstitucionEducativa --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  InstitucionEducativa!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de InstitucionEducativa</param>
        /// <response code="200">InstitucionEducativa Actualizado</response>
        /// <response code="400">InstitucionEducativa tiene valores invalidos </response>
        /// <response code="401">InstitucionEducativa No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar InstitucionEducativa en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] InstitucionEducativa obj)
        {
            try
            {
                var result = new InstitucionEducativaMs().Update(obj);
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
        /// CRUD de la entidad InstitucionEducativa --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  InstitucionEducativa!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de InstitucionEducativa</param>
        /// <response code="200">InstitucionEducativa Eliminado</response>
        /// <response code="400">InstitucionEducativa tiene valores invalidos </response>
        /// <response code="401">InstitucionEducativa No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar InstitucionEducativa en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] InstitucionEducativa obj)
        {
           try
            {
                new InstitucionEducativaMs().Delete(obj);
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
        /// DataTable de la entidad InstitucionEducativa --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  InstitucionEducativa!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de InstitucionEducativa</param>
        /// <response code="200">InstitucionEducativa Resultado</response>
        /// <response code="400">InstitucionEducativa tiene valores invalidos </response>
        /// <response code="401">InstitucionEducativa No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  InstitucionEducativa en este momento</response>
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

                var result = new InstitucionEducativaMs().GetAllByWithRelation().Cast<InstitucionEducativa>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <InstitucionEducativa>().ToList();  
                if (orderCriteria == "ID_Rector") result = result.OrderBy(p => p.ID_Rector).Cast <InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "sID_Rectores") result = result.OrderBy(p => p.sID_Rector).Cast <InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderBy(p => p.ID_ETC).Cast <InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderBy(p => p.sID_ETC).Cast <InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "ID_ET") result = result.OrderBy(p => p.ID_ET).Cast <InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "sID_ET") result = result.OrderBy(p => p.sID_ET).Cast <InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "ID_DiviPola") result = result.OrderBy(p => p.ID_DiviPola).Cast <InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "sID_Divipolas") result = result.OrderBy(p => p.sID_DiviPola).Cast <InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "CodigoDane") result = result.OrderBy(p => p.CodigoDane).Cast <InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "Correo") result = result.OrderBy(p => p.Correo).Cast <InstitucionEducativa>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <InstitucionEducativa>().ToList();  
                if (orderCriteria == "ID_Rector") result = result.OrderByDescending(p => p.ID_Rector).Cast <InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "sID_Rectores") result = result.OrderByDescending(p => p.sID_Rector).Cast<InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderByDescending(p => p.ID_ETC).Cast <InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderByDescending(p => p.sID_ETC).Cast<InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "ID_ET") result = result.OrderByDescending(p => p.ID_ET).Cast <InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "sID_ET") result = result.OrderByDescending(p => p.sID_ET).Cast<InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "ID_DiviPola") result = result.OrderByDescending(p => p.ID_DiviPola).Cast <InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "sID_Divipolas") result = result.OrderByDescending(p => p.sID_DiviPola).Cast<InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "CodigoDane") result = result.OrderByDescending(p => p.CodigoDane).Cast <InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <InstitucionEducativa>().ToList(); 
                 if (orderCriteria == "Correo") result = result.OrderByDescending(p => p.Correo).Cast <InstitucionEducativa>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Rector != null && r.ID_Rector.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Rector != null && r.sID_Rector.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_ETC != null && r.ID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ETC != null && r.sID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_ET != null && r.ID_ET.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ET != null && r.sID_ET.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_DiviPola != null && r.ID_DiviPola.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_DiviPola != null && r.sID_DiviPola.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CodigoDane != null && r.CodigoDane.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
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
        /// CRUD de la entidad InstitucionEducativa --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  InstitucionEducativa!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de InstitucionEducativa</param>
        /// <response code="200">InstitucionEducativa Consulto los registros exitosamente</response>
        /// <response code="400">InstitucionEducativa tiene valores invalidos </response>
        /// <response code="401">InstitucionEducativa No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar InstitucionEducativa en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new InstitucionEducativaMs().GetAllByWithRelation().Cast<InstitucionEducativa>().AsQueryable();
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
