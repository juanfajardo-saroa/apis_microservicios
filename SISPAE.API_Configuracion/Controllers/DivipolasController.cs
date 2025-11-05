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

namespace SISPAE_API_Configuracion.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de Divipolas .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class DivipolasController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Divipolas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Configuracion de la entidad  Divipolas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Divipolas</param>
        /// <response code="200">Divipolas Consulto los registros exitosamente</response>
        /// <response code="400">Divipolas tiene valores invalidos </response>
        /// <response code="401">Divipolas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Divipolas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new DivipolasMs().GetAll().Cast<Divipolas>().AsQueryable();
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
        /// CRUD de la entidad Divipolas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Configuracion de la entidad  Divipolas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Divipolas</param>
        /// <response code="200">Divipolas Consulto los registros exitosamente</response>
        /// <response code="400">Divipolas tiene valores invalidos </response>
        /// <response code="401">Divipolas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Divipolas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new DivipolasMs().GetAllFull().Cast<Divipolas>().AsQueryable();
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
        /// CRUD de la entidad Divipolas --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Configuracion de la entidad  Divipolas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Divipolas</param>
        /// <response code="200">Divipolas Consulto los registros exitosamente</response>
        /// <response code="400">Divipolas tiene valores invalidos </response>
        /// <response code="401">Divipolas No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Divipolas en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new DivipolasMs().GetById(new Divipolas() { id = id });
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
        /// CRUD de la entidad Divipolas --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Configuracion de la entidad  Divipolas!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Divipolas</param>
        /// <response code="200">Divipolas Creado</response>
        /// <response code="400">Divipolas tiene valores invalidos </response>
        /// <response code="401">Divipolas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Divipolas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Divipolas obj)
        {
            try
            {
                var result = new DivipolasMs().Add(obj);
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
        /// CRUD de la entidad Divipolas --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Configuracion de la entidad  Divipolas!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Divipolas</param>
        /// <response code="200">Divipolas Actualizado</response>
        /// <response code="400">Divipolas tiene valores invalidos </response>
        /// <response code="401">Divipolas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Divipolas en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Divipolas obj)
        {
            try
            {
                var result = new DivipolasMs().Update(obj);
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
        /// CRUD de la entidad Divipolas --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Configuracion de la entidad  Divipolas!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Divipolas</param>
        /// <response code="200">Divipolas Eliminado</response>
        /// <response code="400">Divipolas tiene valores invalidos </response>
        /// <response code="401">Divipolas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Divipolas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Divipolas obj)
        {
           try
            {
                new DivipolasMs().Delete(obj);
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
        /// DataTable de la entidad Divipolas --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Divipolas!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Divipolas</param>
        /// <response code="200">Divipolas Resultado</response>
        /// <response code="400">Divipolas tiene valores invalidos </response>
        /// <response code="401">Divipolas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Divipolas en este momento</response>
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

                var result = new DivipolasMs().GetAllByWithRelation().Cast<Divipolas>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Divipolas>().ToList();  
                if (orderCriteria == "DepartamentoCode") result = result.OrderBy(p => p.DepartamentoCode).Cast <Divipolas>().ToList(); 
                 if (orderCriteria == "MunicipioCode") result = result.OrderBy(p => p.MunicipioCode).Cast <Divipolas>().ToList(); 
                 if (orderCriteria == "CentroPobladoCode") result = result.OrderBy(p => p.CentroPobladoCode).Cast <Divipolas>().ToList(); 
                 if (orderCriteria == "DepartamentoNombre") result = result.OrderBy(p => p.DepartamentoNombre).Cast <Divipolas>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <Divipolas>().ToList(); 
                 if (orderCriteria == "CentroPobladoNombre") result = result.OrderBy(p => p.CentroPobladoNombre).Cast <Divipolas>().ToList(); 
                   if (orderCriteria == "Id_TipoMunicipio") result = result.OrderBy(p => p.Id_TipoMunicipio).Cast <Divipolas>().ToList(); 
                 if (orderCriteria == "sID_TipoMunicipio") result = result.OrderBy(p => p.sId_TipoMunicipio).Cast <Divipolas>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Divipolas>().ToList();  
                if (orderCriteria == "DepartamentoCode") result = result.OrderByDescending(p => p.DepartamentoCode).Cast <Divipolas>().ToList(); 
                 if (orderCriteria == "MunicipioCode") result = result.OrderByDescending(p => p.MunicipioCode).Cast <Divipolas>().ToList(); 
                 if (orderCriteria == "CentroPobladoCode") result = result.OrderByDescending(p => p.CentroPobladoCode).Cast <Divipolas>().ToList(); 
                 if (orderCriteria == "DepartamentoNombre") result = result.OrderByDescending(p => p.DepartamentoNombre).Cast <Divipolas>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <Divipolas>().ToList(); 
                 if (orderCriteria == "CentroPobladoNombre") result = result.OrderByDescending(p => p.CentroPobladoNombre).Cast <Divipolas>().ToList(); 
                   if (orderCriteria == "Id_TipoMunicipio") result = result.OrderByDescending(p => p.Id_TipoMunicipio).Cast <Divipolas>().ToList(); 
                 if (orderCriteria == "sID_TipoMunicipio") result = result.OrderByDescending(p => p.sId_TipoMunicipio).Cast<Divipolas>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.DepartamentoCode != null && r.DepartamentoCode.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.MunicipioCode != null && r.MunicipioCode.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CentroPobladoCode != null && r.CentroPobladoCode.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.DepartamentoNombre != null && r.DepartamentoNombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CentroPobladoNombre != null && r.CentroPobladoNombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Id_TipoMunicipio != null && r.Id_TipoMunicipio.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                || r.sId_TipoMunicipio != null && r.sId_TipoMunicipio.ToString().ToUpper().Contains(searchBy.ToUpper()) 
  
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
        /// CRUD de la entidad Divipolas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Configuracion de la entidad  Divipolas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Divipolas</param>
        /// <response code="200">Divipolas Consulto los registros exitosamente</response>
        /// <response code="400">Divipolas tiene valores invalidos </response>
        /// <response code="401">Divipolas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Divipolas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new DivipolasMs().GetAllByWithRelation().Cast<Divipolas>().AsQueryable();
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
