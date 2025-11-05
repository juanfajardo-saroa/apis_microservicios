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
    [SwaggerTag("Web API para CRUD de DivipolasComprasLocales .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class DivipolasComprasLocalesController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad DivipolasComprasLocales --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DivipolasComprasLocales!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DivipolasComprasLocales</param>
        /// <response code="200">DivipolasComprasLocales Consulto los registros exitosamente</response>
        /// <response code="400">DivipolasComprasLocales tiene valores invalidos </response>
        /// <response code="401">DivipolasComprasLocales No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DivipolasComprasLocales en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new DivipolasComprasLocalesMs().GetAll().Cast<DivipolasComprasLocales>().AsQueryable();
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
        /// CRUD de la entidad DivipolasComprasLocales --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DivipolasComprasLocales!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DivipolasComprasLocales</param>
        /// <response code="200">DivipolasComprasLocales Consulto los registros exitosamente</response>
        /// <response code="400">DivipolasComprasLocales tiene valores invalidos </response>
        /// <response code="401">DivipolasComprasLocales No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DivipolasComprasLocales en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new DivipolasComprasLocalesMs().GetAllFull().Cast<DivipolasComprasLocales>().AsQueryable();
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
        /// CRUD de la entidad DivipolasComprasLocales --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DivipolasComprasLocales!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DivipolasComprasLocales</param>
        /// <response code="200">DivipolasComprasLocales Consulto los registros exitosamente</response>
        /// <response code="400">DivipolasComprasLocales tiene valores invalidos </response>
        /// <response code="401">DivipolasComprasLocales No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar DivipolasComprasLocales en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new DivipolasComprasLocalesMs().GetById(new DivipolasComprasLocales() { id = id });
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
        /// CRUD de la entidad DivipolasComprasLocales --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  DivipolasComprasLocales!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de DivipolasComprasLocales</param>
        /// <response code="200">DivipolasComprasLocales Creado</response>
        /// <response code="400">DivipolasComprasLocales tiene valores invalidos </response>
        /// <response code="401">DivipolasComprasLocales No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear DivipolasComprasLocales en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] DivipolasComprasLocales obj)
        {
            try
            {
                var result = new DivipolasComprasLocalesMs().Add(obj);
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
        /// CRUD de la entidad DivipolasComprasLocales --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  DivipolasComprasLocales!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de DivipolasComprasLocales</param>
        /// <response code="200">DivipolasComprasLocales Actualizado</response>
        /// <response code="400">DivipolasComprasLocales tiene valores invalidos </response>
        /// <response code="401">DivipolasComprasLocales No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar DivipolasComprasLocales en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] DivipolasComprasLocales obj)
        {
            try
            {
                var result = new DivipolasComprasLocalesMs().Update(obj);
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
        /// CRUD de la entidad DivipolasComprasLocales --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  DivipolasComprasLocales!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de DivipolasComprasLocales</param>
        /// <response code="200">DivipolasComprasLocales Eliminado</response>
        /// <response code="400">DivipolasComprasLocales tiene valores invalidos </response>
        /// <response code="401">DivipolasComprasLocales No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar DivipolasComprasLocales en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] DivipolasComprasLocales obj)
        {
           try
            {
                new DivipolasComprasLocalesMs().Delete(obj);
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
        /// DataTable de la entidad DivipolasComprasLocales --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  DivipolasComprasLocales!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de DivipolasComprasLocales</param>
        /// <response code="200">DivipolasComprasLocales Resultado</response>
        /// <response code="400">DivipolasComprasLocales tiene valores invalidos </response>
        /// <response code="401">DivipolasComprasLocales No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  DivipolasComprasLocales en este momento</response>
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

                var result = new DivipolasComprasLocalesMs().GetAllByWithRelation().Cast<DivipolasComprasLocales>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <DivipolasComprasLocales>().ToList();  
                if (orderCriteria == "ID_ComprasLocales") result = result.OrderBy(p => p.ID_ComprasLocales).Cast <DivipolasComprasLocales>().ToList(); 
                 if (orderCriteria == "sID_CompraLocalesContrato") result = result.OrderBy(p => p.sID_ComprasLocales).Cast <DivipolasComprasLocales>().ToList(); 
                 if (orderCriteria == "ID_divipola") result = result.OrderBy(p => p.ID_divipola).Cast <DivipolasComprasLocales>().ToList(); 
                 if (orderCriteria == "sID_Divipolas") result = result.OrderBy(p => p.sID_divipola).Cast <DivipolasComprasLocales>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <DivipolasComprasLocales>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <DivipolasComprasLocales>().ToList();  
                if (orderCriteria == "ID_ComprasLocales") result = result.OrderByDescending(p => p.ID_ComprasLocales).Cast <DivipolasComprasLocales>().ToList(); 
                 if (orderCriteria == "sID_CompraLocalesContrato") result = result.OrderByDescending(p => p.sID_ComprasLocales).Cast<DivipolasComprasLocales>().ToList(); 
                 if (orderCriteria == "ID_divipola") result = result.OrderByDescending(p => p.ID_divipola).Cast <DivipolasComprasLocales>().ToList(); 
                 if (orderCriteria == "sID_Divipolas") result = result.OrderByDescending(p => p.sID_divipola).Cast<DivipolasComprasLocales>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <DivipolasComprasLocales>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_ComprasLocales != null && r.ID_ComprasLocales.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ComprasLocales != null && r.sID_ComprasLocales.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_divipola != null && r.ID_divipola.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_divipola != null && r.sID_divipola.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad DivipolasComprasLocales --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DivipolasComprasLocales!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DivipolasComprasLocales</param>
        /// <response code="200">DivipolasComprasLocales Consulto los registros exitosamente</response>
        /// <response code="400">DivipolasComprasLocales tiene valores invalidos </response>
        /// <response code="401">DivipolasComprasLocales No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DivipolasComprasLocales en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new DivipolasComprasLocalesMs().GetAllByWithRelation().Cast<DivipolasComprasLocales>().AsQueryable();
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
