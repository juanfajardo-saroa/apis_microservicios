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
    [SwaggerTag("Web API para CRUD de ProductosMinuta .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class ProductosMinutaController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad ProductosMinuta --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  ProductosMinuta!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ProductosMinuta</param>
        /// <response code="200">ProductosMinuta Consulto los registros exitosamente</response>
        /// <response code="400">ProductosMinuta tiene valores invalidos </response>
        /// <response code="401">ProductosMinuta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ProductosMinuta en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new ProductosMinutaMs().GetAll().Cast<ProductosMinuta>().AsQueryable();
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
        /// CRUD de la entidad ProductosMinuta --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  ProductosMinuta!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ProductosMinuta</param>
        /// <response code="200">ProductosMinuta Consulto los registros exitosamente</response>
        /// <response code="400">ProductosMinuta tiene valores invalidos </response>
        /// <response code="401">ProductosMinuta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ProductosMinuta en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new ProductosMinutaMs().GetAllFull().Cast<ProductosMinuta>().AsQueryable();
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
        /// CRUD de la entidad ProductosMinuta --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  ProductosMinuta!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ProductosMinuta</param>
        /// <response code="200">ProductosMinuta Consulto los registros exitosamente</response>
        /// <response code="400">ProductosMinuta tiene valores invalidos </response>
        /// <response code="401">ProductosMinuta No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar ProductosMinuta en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new ProductosMinutaMs().GetById(new ProductosMinuta() { id = id });
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
        /// CRUD de la entidad ProductosMinuta --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  ProductosMinuta!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de ProductosMinuta</param>
        /// <response code="200">ProductosMinuta Creado</response>
        /// <response code="400">ProductosMinuta tiene valores invalidos </response>
        /// <response code="401">ProductosMinuta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear ProductosMinuta en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] ProductosMinuta obj)
        {
            try
            {
                var result = new ProductosMinutaMs().Add(obj);
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
        /// CRUD de la entidad ProductosMinuta --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  ProductosMinuta!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de ProductosMinuta</param>
        /// <response code="200">ProductosMinuta Actualizado</response>
        /// <response code="400">ProductosMinuta tiene valores invalidos </response>
        /// <response code="401">ProductosMinuta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar ProductosMinuta en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] ProductosMinuta obj)
        {
            try
            {
                var result = new ProductosMinutaMs().Update(obj);
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
        /// CRUD de la entidad ProductosMinuta --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  ProductosMinuta!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de ProductosMinuta</param>
        /// <response code="200">ProductosMinuta Eliminado</response>
        /// <response code="400">ProductosMinuta tiene valores invalidos </response>
        /// <response code="401">ProductosMinuta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar ProductosMinuta en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] ProductosMinuta obj)
        {
           try
            {
                new ProductosMinutaMs().Delete(obj);
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
        /// DataTable de la entidad ProductosMinuta --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  ProductosMinuta!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de ProductosMinuta</param>
        /// <response code="200">ProductosMinuta Resultado</response>
        /// <response code="400">ProductosMinuta tiene valores invalidos </response>
        /// <response code="401">ProductosMinuta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  ProductosMinuta en este momento</response>
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

                var result = new ProductosMinutaMs().GetAllByWithRelation().Cast<ProductosMinuta>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <ProductosMinuta>().ToList();  
                if (orderCriteria == "ID_MinutaPatronProducto") result = result.OrderBy(p => p.ID_MinutaPatronProducto).Cast <ProductosMinuta>().ToList(); 
                 if (orderCriteria == "sID_MinutaPatronProductos") result = result.OrderBy(p => p.sID_MinutaPatronProducto).Cast <ProductosMinuta>().ToList(); 
                 if (orderCriteria == "ID_TipoComponente") result = result.OrderBy(p => p.ID_TipoComponente).Cast <ProductosMinuta>().ToList(); 
                 if (orderCriteria == "sID_TiposComponente") result = result.OrderBy(p => p.sID_TipoComponente).Cast <ProductosMinuta>().ToList(); 
                 if (orderCriteria == "ID_GrupoAlimento") result = result.OrderBy(p => p.ID_GrupoAlimento).Cast <ProductosMinuta>().ToList(); 
                 if (orderCriteria == "sID_GrupoAlimentos") result = result.OrderBy(p => p.sID_GrupoAlimento).Cast <ProductosMinuta>().ToList(); 
                 if (orderCriteria == "frecuencia") result = result.OrderBy(p => p.frecuencia).Cast <ProductosMinuta>().ToList(); 
                 if (orderCriteria == "gramoPesoNeto") result = result.OrderBy(p => p.gramoPesoNeto).Cast <ProductosMinuta>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <ProductosMinuta>().ToList();  
                if (orderCriteria == "ID_MinutaPatronProducto") result = result.OrderByDescending(p => p.ID_MinutaPatronProducto).Cast <ProductosMinuta>().ToList(); 
                 if (orderCriteria == "sID_MinutaPatronProductos") result = result.OrderByDescending(p => p.sID_MinutaPatronProducto).Cast<ProductosMinuta>().ToList(); 
                 if (orderCriteria == "ID_TipoComponente") result = result.OrderByDescending(p => p.ID_TipoComponente).Cast <ProductosMinuta>().ToList(); 
                 if (orderCriteria == "sID_TiposComponente") result = result.OrderByDescending(p => p.sID_TipoComponente).Cast<ProductosMinuta>().ToList(); 
                 if (orderCriteria == "ID_GrupoAlimento") result = result.OrderByDescending(p => p.ID_GrupoAlimento).Cast <ProductosMinuta>().ToList(); 
                 if (orderCriteria == "sID_GrupoAlimentos") result = result.OrderByDescending(p => p.sID_GrupoAlimento).Cast<ProductosMinuta>().ToList(); 
                 if (orderCriteria == "frecuencia") result = result.OrderByDescending(p => p.frecuencia).Cast <ProductosMinuta>().ToList(); 
                 if (orderCriteria == "gramoPesoNeto") result = result.OrderByDescending(p => p.gramoPesoNeto).Cast <ProductosMinuta>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_MinutaPatronProducto != null && r.ID_MinutaPatronProducto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_MinutaPatronProducto != null && r.sID_MinutaPatronProducto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoComponente != null && r.ID_TipoComponente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoComponente != null && r.sID_TipoComponente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_GrupoAlimento != null && r.ID_GrupoAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_GrupoAlimento != null && r.sID_GrupoAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.frecuencia != null && r.frecuencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.gramoPesoNeto != null && r.gramoPesoNeto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad ProductosMinuta --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlanAlistamiento de la entidad  ProductosMinuta!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ProductosMinuta</param>
        /// <response code="200">ProductosMinuta Consulto los registros exitosamente</response>
        /// <response code="400">ProductosMinuta tiene valores invalidos </response>
        /// <response code="401">ProductosMinuta No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ProductosMinuta en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new ProductosMinutaMs().GetAllByWithRelation().Cast<ProductosMinuta>().AsQueryable();
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
