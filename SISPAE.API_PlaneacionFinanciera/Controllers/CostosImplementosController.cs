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

namespace SISPAE_API_PlaneacionFinanciera.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de CostosImplementos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class CostosImplementosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad CostosImplementos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  CostosImplementos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de CostosImplementos</param>
        /// <response code="200">CostosImplementos Consulto los registros exitosamente</response>
        /// <response code="400">CostosImplementos tiene valores invalidos </response>
        /// <response code="401">CostosImplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar CostosImplementos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new CostosImplementosMs().GetAll().Cast<CostosImplementos>().AsQueryable();
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
        /// CRUD de la entidad CostosImplementos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  CostosImplementos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de CostosImplementos</param>
        /// <response code="200">CostosImplementos Consulto los registros exitosamente</response>
        /// <response code="400">CostosImplementos tiene valores invalidos </response>
        /// <response code="401">CostosImplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar CostosImplementos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new CostosImplementosMs().GetAllFull().Cast<CostosImplementos>().AsQueryable();
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
        /// CRUD de la entidad CostosImplementos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  CostosImplementos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de CostosImplementos</param>
        /// <response code="200">CostosImplementos Consulto los registros exitosamente</response>
        /// <response code="400">CostosImplementos tiene valores invalidos </response>
        /// <response code="401">CostosImplementos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar CostosImplementos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new CostosImplementosMs().GetById(new CostosImplementos() { id = id });
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
        /// CRUD de la entidad CostosImplementos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  CostosImplementos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de CostosImplementos</param>
        /// <response code="200">CostosImplementos Creado</response>
        /// <response code="400">CostosImplementos tiene valores invalidos </response>
        /// <response code="401">CostosImplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear CostosImplementos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] CostosImplementos obj)
        {
            try
            {
                var result = new CostosImplementosMs().Add(obj);
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
        /// CRUD de la entidad CostosImplementos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  CostosImplementos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de CostosImplementos</param>
        /// <response code="200">CostosImplementos Actualizado</response>
        /// <response code="400">CostosImplementos tiene valores invalidos </response>
        /// <response code="401">CostosImplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar CostosImplementos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] CostosImplementos obj)
        {
            try
            {
                var result = new CostosImplementosMs().Update(obj);
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
        /// CRUD de la entidad CostosImplementos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  CostosImplementos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de CostosImplementos</param>
        /// <response code="200">CostosImplementos Eliminado</response>
        /// <response code="400">CostosImplementos tiene valores invalidos </response>
        /// <response code="401">CostosImplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar CostosImplementos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] CostosImplementos obj)
        {
           try
            {
                new CostosImplementosMs().Delete(obj);
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
        /// DataTable de la entidad CostosImplementos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  CostosImplementos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de CostosImplementos</param>
        /// <response code="200">CostosImplementos Resultado</response>
        /// <response code="400">CostosImplementos tiene valores invalidos </response>
        /// <response code="401">CostosImplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  CostosImplementos en este momento</response>
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

                var result = new CostosImplementosMs().GetAllByWithRelation().Cast<CostosImplementos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <CostosImplementos>().ToList();  
                if (orderCriteria == "ID_ETC") result = result.OrderBy(p => p.ID_ETC).Cast <CostosImplementos>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderBy(p => p.sID_ETC).Cast <CostosImplementos>().ToList(); 
                 if (orderCriteria == "MenajeCocina") result = result.OrderBy(p => p.MenajeCocina).Cast <CostosImplementos>().ToList(); 
                 if (orderCriteria == "MenajeComedor") result = result.OrderBy(p => p.MenajeComedor).Cast <CostosImplementos>().ToList(); 
                 if (orderCriteria == "DotacionComedor") result = result.OrderBy(p => p.DotacionComedor).Cast <CostosImplementos>().ToList(); 
                 if (orderCriteria == "ProductosLimpieza") result = result.OrderBy(p => p.ProductosLimpieza).Cast <CostosImplementos>().ToList(); 
                 if (orderCriteria == "ImplementosAseo") result = result.OrderBy(p => p.ImplementosAseo).Cast <CostosImplementos>().ToList(); 
                 if (orderCriteria == "CostoImplementos") result = result.OrderBy(p => p.CostoImplementos).Cast <CostosImplementos>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <CostosImplementos>().ToList();  
                if (orderCriteria == "ID_ETC") result = result.OrderByDescending(p => p.ID_ETC).Cast <CostosImplementos>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderByDescending(p => p.sID_ETC).Cast<CostosImplementos>().ToList(); 
                 if (orderCriteria == "MenajeCocina") result = result.OrderByDescending(p => p.MenajeCocina).Cast <CostosImplementos>().ToList(); 
                 if (orderCriteria == "MenajeComedor") result = result.OrderByDescending(p => p.MenajeComedor).Cast <CostosImplementos>().ToList(); 
                 if (orderCriteria == "DotacionComedor") result = result.OrderByDescending(p => p.DotacionComedor).Cast <CostosImplementos>().ToList(); 
                 if (orderCriteria == "ProductosLimpieza") result = result.OrderByDescending(p => p.ProductosLimpieza).Cast <CostosImplementos>().ToList(); 
                 if (orderCriteria == "ImplementosAseo") result = result.OrderByDescending(p => p.ImplementosAseo).Cast <CostosImplementos>().ToList(); 
                 if (orderCriteria == "CostoImplementos") result = result.OrderByDescending(p => p.CostoImplementos).Cast <CostosImplementos>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_ETC != null && r.ID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ETC != null && r.sID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.MenajeCocina != null && r.MenajeCocina.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.MenajeComedor != null && r.MenajeComedor.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.DotacionComedor != null && r.DotacionComedor.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ProductosLimpieza != null && r.ProductosLimpieza.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ImplementosAseo != null && r.ImplementosAseo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CostoImplementos != null && r.CostoImplementos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad CostosImplementos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_PlaneacionFinanciera de la entidad  CostosImplementos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de CostosImplementos</param>
        /// <response code="200">CostosImplementos Consulto los registros exitosamente</response>
        /// <response code="400">CostosImplementos tiene valores invalidos </response>
        /// <response code="401">CostosImplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar CostosImplementos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new CostosImplementosMs().GetAllByWithRelation().Cast<CostosImplementos>().AsQueryable();
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
