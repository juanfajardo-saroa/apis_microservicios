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

namespace SISPAE_API_PTN.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de AporteProducto .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class AporteProductoController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad AporteProducto --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  AporteProducto!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AporteProducto</param>
        /// <response code="200">AporteProducto Consulto los registros exitosamente</response>
        /// <response code="400">AporteProducto tiene valores invalidos </response>
        /// <response code="401">AporteProducto No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AporteProducto en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new AporteProductoMs().GetAll().Cast<AporteProducto>().AsQueryable();
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
        /// CRUD de la entidad AporteProducto --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  AporteProducto!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AporteProducto</param>
        /// <response code="200">AporteProducto Consulto los registros exitosamente</response>
        /// <response code="400">AporteProducto tiene valores invalidos </response>
        /// <response code="401">AporteProducto No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AporteProducto en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new AporteProductoMs().GetAllFull().Cast<AporteProducto>().AsQueryable();
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
        /// CRUD de la entidad AporteProducto --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  AporteProducto!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AporteProducto</param>
        /// <response code="200">AporteProducto Consulto los registros exitosamente</response>
        /// <response code="400">AporteProducto tiene valores invalidos </response>
        /// <response code="401">AporteProducto No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar AporteProducto en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new AporteProductoMs().GetById(new AporteProducto() { id = id });
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
        /// CRUD de la entidad AporteProducto --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PTN de la entidad  AporteProducto!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de AporteProducto</param>
        /// <response code="200">AporteProducto Creado</response>
        /// <response code="400">AporteProducto tiene valores invalidos </response>
        /// <response code="401">AporteProducto No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear AporteProducto en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] AporteProducto obj)
        {
            try
            {
                var result = new AporteProductoMs().Add(obj);
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
        /// CRUD de la entidad AporteProducto --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PTN de la entidad  AporteProducto!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de AporteProducto</param>
        /// <response code="200">AporteProducto Actualizado</response>
        /// <response code="400">AporteProducto tiene valores invalidos </response>
        /// <response code="401">AporteProducto No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar AporteProducto en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] AporteProducto obj)
        {
            try
            {
                var result = new AporteProductoMs().Update(obj);
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
        /// CRUD de la entidad AporteProducto --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PTN de la entidad  AporteProducto!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de AporteProducto</param>
        /// <response code="200">AporteProducto Eliminado</response>
        /// <response code="400">AporteProducto tiene valores invalidos </response>
        /// <response code="401">AporteProducto No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar AporteProducto en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] AporteProducto obj)
        {
           try
            {
                new AporteProductoMs().Delete(obj);
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
        /// DataTable de la entidad AporteProducto --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  AporteProducto!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de AporteProducto</param>
        /// <response code="200">AporteProducto Resultado</response>
        /// <response code="400">AporteProducto tiene valores invalidos </response>
        /// <response code="401">AporteProducto No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  AporteProducto en este momento</response>
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

                var result = new AporteProductoMs().GetAllByWithRelation().Cast<AporteProducto>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <AporteProducto>().ToList();  
                if (orderCriteria == "ID_Producto") result = result.OrderBy(p => p.ID_Producto).Cast <AporteProducto>().ToList(); 
                 if (orderCriteria == "sID_Productos") result = result.OrderBy(p => p.sID_Producto).Cast <AporteProducto>().ToList(); 
                 if (orderCriteria == "ID_TipoNivelEducativo") result = result.OrderBy(p => p.ID_TipoNivelEducativo).Cast <AporteProducto>().ToList(); 
                 if (orderCriteria == "sID_NivelEducativo") result = result.OrderBy(p => p.sID_TipoNivelEducativo).Cast <AporteProducto>().ToList(); 
                 if (orderCriteria == "PesoBruto") result = result.OrderBy(p => p.PesoBruto).Cast <AporteProducto>().ToList(); 
                 if (orderCriteria == "PesoNeto") result = result.OrderBy(p => p.PesoNeto).Cast <AporteProducto>().ToList(); 
                 if (orderCriteria == "PorcentajeComestible") result = result.OrderBy(p => p.PorcentajeComestible).Cast <AporteProducto>().ToList(); 
                 if (orderCriteria == "IntercambioEstandarizado") result = result.OrderBy(p => p.IntercambioEstandarizado).Cast <AporteProducto>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <AporteProducto>().ToList();  
                if (orderCriteria == "ID_Producto") result = result.OrderByDescending(p => p.ID_Producto).Cast <AporteProducto>().ToList(); 
                 if (orderCriteria == "sID_Productos") result = result.OrderByDescending(p => p.sID_Producto).Cast<AporteProducto>().ToList(); 
                 if (orderCriteria == "ID_TipoNivelEducativo") result = result.OrderByDescending(p => p.ID_TipoNivelEducativo).Cast <AporteProducto>().ToList(); 
                 if (orderCriteria == "sID_NivelEducativo") result = result.OrderByDescending(p => p.sID_TipoNivelEducativo).Cast<AporteProducto>().ToList(); 
                 if (orderCriteria == "PesoBruto") result = result.OrderByDescending(p => p.PesoBruto).Cast <AporteProducto>().ToList(); 
                 if (orderCriteria == "PesoNeto") result = result.OrderByDescending(p => p.PesoNeto).Cast <AporteProducto>().ToList(); 
                 if (orderCriteria == "PorcentajeComestible") result = result.OrderByDescending(p => p.PorcentajeComestible).Cast <AporteProducto>().ToList(); 
                 if (orderCriteria == "IntercambioEstandarizado") result = result.OrderByDescending(p => p.IntercambioEstandarizado).Cast <AporteProducto>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Producto != null && r.ID_Producto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Producto != null && r.sID_Producto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoNivelEducativo != null && r.ID_TipoNivelEducativo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoNivelEducativo != null && r.sID_TipoNivelEducativo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PesoBruto != null && r.PesoBruto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PesoNeto != null && r.PesoNeto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PorcentajeComestible != null && r.PorcentajeComestible.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.IntercambioEstandarizado != null && r.IntercambioEstandarizado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad AporteProducto --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PTN de la entidad  AporteProducto!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AporteProducto</param>
        /// <response code="200">AporteProducto Consulto los registros exitosamente</response>
        /// <response code="400">AporteProducto tiene valores invalidos </response>
        /// <response code="401">AporteProducto No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AporteProducto en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new AporteProductoMs().GetAllByWithRelation().Cast<AporteProducto>().AsQueryable();
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
