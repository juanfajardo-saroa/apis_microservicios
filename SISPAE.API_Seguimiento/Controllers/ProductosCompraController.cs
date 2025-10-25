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
using Microsoft.AspNetCore.OData.Query; using ElmahCore;




// create, index, delete, update , read
//  details, listall, 

namespace SISPAE_API_Seguimiento.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de ProductosCompra .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class ProductosCompraController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad ProductosCompra --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  ProductosCompra!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ProductosCompra</param>
        /// <response code="200">ProductosCompra Consulto los registros exitosamente</response>
        /// <response code="400">ProductosCompra tiene valores invalidos </response>
        /// <response code="401">ProductosCompra No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ProductosCompra en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new ProductosCompraMs().GetAll().Cast<ProductosCompra>().AsQueryable();
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
        /// CRUD de la entidad ProductosCompra --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  ProductosCompra!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ProductosCompra</param>
        /// <response code="200">ProductosCompra Consulto los registros exitosamente</response>
        /// <response code="400">ProductosCompra tiene valores invalidos </response>
        /// <response code="401">ProductosCompra No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ProductosCompra en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new ProductosCompraMs().GetAllFull().Cast<ProductosCompra>().AsQueryable();
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
        /// CRUD de la entidad ProductosCompra --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  ProductosCompra!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ProductosCompra</param>
        /// <response code="200">ProductosCompra Consulto los registros exitosamente</response>
        /// <response code="400">ProductosCompra tiene valores invalidos </response>
        /// <response code="401">ProductosCompra No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar ProductosCompra en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new ProductosCompraMs().GetById(new ProductosCompra() { id = id });
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
        /// CRUD de la entidad ProductosCompra --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Seguimiento de la entidad  ProductosCompra!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de ProductosCompra</param>
        /// <response code="200">ProductosCompra Creado</response>
        /// <response code="400">ProductosCompra tiene valores invalidos </response>
        /// <response code="401">ProductosCompra No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear ProductosCompra en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] ProductosCompra obj)
        {
            try
            {
                var result = new ProductosCompraMs().Add(obj);
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
        /// CRUD de la entidad ProductosCompra --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Seguimiento de la entidad  ProductosCompra!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de ProductosCompra</param>
        /// <response code="200">ProductosCompra Actualizado</response>
        /// <response code="400">ProductosCompra tiene valores invalidos </response>
        /// <response code="401">ProductosCompra No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar ProductosCompra en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] ProductosCompra obj)
        {
            try
            {
                var result = new ProductosCompraMs().Update(obj);
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
        /// CRUD de la entidad ProductosCompra --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Seguimiento de la entidad  ProductosCompra!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de ProductosCompra</param>
        /// <response code="200">ProductosCompra Eliminado</response>
        /// <response code="400">ProductosCompra tiene valores invalidos </response>
        /// <response code="401">ProductosCompra No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar ProductosCompra en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] ProductosCompra obj)
        {
           try
            {
                new ProductosCompraMs().Delete(obj);
                return Ok();
            }
            catch (System.Exception ex)
            {
                  return BadRequest(ex.Message);
            }
        }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad ProductosCompra --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  ProductosCompra!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de ProductosCompra</param>
        /// <response code="200">ProductosCompra Resultado</response>
        /// <response code="400">ProductosCompra tiene valores invalidos </response>
        /// <response code="401">ProductosCompra No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  ProductosCompra en este momento</response>
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
                var result = new ProductosCompraMs().GetAllByWithRelation().Cast<ProductosCompra>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                  if (orderAscendingDirection)                  {                  if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <ProductosCompra>().ToList();  
                  if (orderCriteria == "ID_CompraLocal") result = result.OrderBy(p => p.ID_CompraLocal).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "sID_CompraLocales") result = result.OrderBy(p => p.sID_CompraLocal).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "ID_TipoProductoCompraLocal") result = result.OrderBy(p => p.ID_TipoProductoCompraLocal).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "sID_TiposProductosCompraLocal") result = result.OrderBy(p => p.sID_TipoProductoCompraLocal).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "ID_Alimento") result = result.OrderBy(p => p.ID_Alimento).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "sID_AlimentosBase") result = result.OrderBy(p => p.sID_Alimento).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "ID_TipoAlimento") result = result.OrderBy(p => p.ID_TipoAlimento).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "sID_TiposAlimentos") result = result.OrderBy(p => p.sID_TipoAlimento).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "ID_SubTipoAlimento") result = result.OrderBy(p => p.ID_SubTipoAlimento).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "sID_SubTiposAlimento") result = result.OrderBy(p => p.sID_SubTipoAlimento).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "ID_MunicipioAdquiereServicio") result = result.OrderBy(p => p.ID_MunicipioAdquiereServicio).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "sID_MunicipioAdquiereServicio") result = result.OrderBy(p => p.sID_MunicipioAdquiereServicio).Cast <ProductosCompra>().ToList(); 
                       if (orderCriteria == "CantidadComprada") result = result.OrderBy(p => p.CantidadComprada).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "PrecioUnidad") result = result.OrderBy(p => p.PrecioUnidad).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "PrecioTotal") result = result.OrderBy(p => p.PrecioTotal).Cast <ProductosCompra>().ToList(); 
                     }
  else 
                    {                  if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <ProductosCompra>().ToList();  
                  if (orderCriteria == "ID_CompraLocal") result = result.OrderByDescending(p => p.ID_CompraLocal).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "sID_CompraLocales") result = result.OrderByDescending(p => p.sID_CompraLocal).Cast<ProductosCompra>().ToList(); 
                   if (orderCriteria == "ID_TipoProductoCompraLocal") result = result.OrderByDescending(p => p.ID_TipoProductoCompraLocal).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "sID_TiposProductosCompraLocal") result = result.OrderByDescending(p => p.sID_TipoProductoCompraLocal).Cast<ProductosCompra>().ToList(); 
                   if (orderCriteria == "ID_Alimento") result = result.OrderByDescending(p => p.ID_Alimento).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "sID_AlimentosBase") result = result.OrderByDescending(p => p.sID_Alimento).Cast<ProductosCompra>().ToList(); 
                   if (orderCriteria == "ID_TipoAlimento") result = result.OrderByDescending(p => p.ID_TipoAlimento).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "sID_TiposAlimentos") result = result.OrderByDescending(p => p.sID_TipoAlimento).Cast<ProductosCompra>().ToList(); 
                   if (orderCriteria == "ID_SubTipoAlimento") result = result.OrderByDescending(p => p.ID_SubTipoAlimento).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "sID_SubTiposAlimento") result = result.OrderByDescending(p => p.sID_SubTipoAlimento).Cast<ProductosCompra>().ToList(); 
                   if (orderCriteria == "ID_MunicipioAdquiereServicio") result = result.OrderByDescending(p => p.ID_MunicipioAdquiereServicio).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "sID_MunicipioAdquiereServicio") result = result.OrderByDescending(p => p.sID_MunicipioAdquiereServicio).Cast<ProductosCompra>().ToList(); 
                       if (orderCriteria == "CantidadComprada") result = result.OrderByDescending(p => p.CantidadComprada).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "PrecioUnidad") result = result.OrderByDescending(p => p.PrecioUnidad).Cast <ProductosCompra>().ToList(); 
                   if (orderCriteria == "PrecioTotal") result = result.OrderByDescending(p => p.PrecioTotal).Cast <ProductosCompra>().ToList(); 
                     }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                   || r.ID_CompraLocal != null && r.ID_CompraLocal.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_CompraLocal != null && r.sID_CompraLocal.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_TipoProductoCompraLocal != null && r.ID_TipoProductoCompraLocal.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_TipoProductoCompraLocal != null && r.sID_TipoProductoCompraLocal.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_Alimento != null && r.ID_Alimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_Alimento != null && r.sID_Alimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_TipoAlimento != null && r.ID_TipoAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_TipoAlimento != null && r.sID_TipoAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_SubTipoAlimento != null && r.ID_SubTipoAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_SubTipoAlimento != null && r.sID_SubTipoAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_MunicipioAdquiereServicio != null && r.ID_MunicipioAdquiereServicio.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_MunicipioAdquiereServicio != null && r.sID_MunicipioAdquiereServicio.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                       || r.CantidadComprada != null && r.CantidadComprada.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.PrecioUnidad != null && r.PrecioUnidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.PrecioTotal != null && r.PrecioTotal.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad ProductosCompra --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  ProductosCompra!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ProductosCompra</param>
        /// <response code="200">ProductosCompra Consulto los registros exitosamente</response>
        /// <response code="400">ProductosCompra tiene valores invalidos </response>
        /// <response code="401">ProductosCompra No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ProductosCompra en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new ProductosCompraMs().GetAllByWithRelation().Cast<ProductosCompra>().AsQueryable();
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
