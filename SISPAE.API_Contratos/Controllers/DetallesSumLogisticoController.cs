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
    [SwaggerTag("Web API para CRUD de DetallesSumLogistico .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class DetallesSumLogisticoController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad DetallesSumLogistico --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumLogistico!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DetallesSumLogistico</param>
        /// <response code="200">DetallesSumLogistico Consulto los registros exitosamente</response>
        /// <response code="400">DetallesSumLogistico tiene valores invalidos </response>
        /// <response code="401">DetallesSumLogistico No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DetallesSumLogistico en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new DetallesSumLogisticoMs().GetAll().Cast<DetallesSumLogistico>().AsQueryable();
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
        /// CRUD de la entidad DetallesSumLogistico --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumLogistico!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DetallesSumLogistico</param>
        /// <response code="200">DetallesSumLogistico Consulto los registros exitosamente</response>
        /// <response code="400">DetallesSumLogistico tiene valores invalidos </response>
        /// <response code="401">DetallesSumLogistico No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DetallesSumLogistico en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new DetallesSumLogisticoMs().GetAllFull().Cast<DetallesSumLogistico>().AsQueryable();
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
        /// CRUD de la entidad DetallesSumLogistico --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumLogistico!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DetallesSumLogistico</param>
        /// <response code="200">DetallesSumLogistico Consulto los registros exitosamente</response>
        /// <response code="400">DetallesSumLogistico tiene valores invalidos </response>
        /// <response code="401">DetallesSumLogistico No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar DetallesSumLogistico en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new DetallesSumLogisticoMs().GetById(new DetallesSumLogistico() { id = id });
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
        /// CRUD de la entidad DetallesSumLogistico --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumLogistico!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de DetallesSumLogistico</param>
        /// <response code="200">DetallesSumLogistico Creado</response>
        /// <response code="400">DetallesSumLogistico tiene valores invalidos </response>
        /// <response code="401">DetallesSumLogistico No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear DetallesSumLogistico en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] DetallesSumLogistico obj)
        {
            try
            {
                var result = new DetallesSumLogisticoMs().Add(obj);
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
        /// CRUD de la entidad DetallesSumLogistico --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumLogistico!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de DetallesSumLogistico</param>
        /// <response code="200">DetallesSumLogistico Actualizado</response>
        /// <response code="400">DetallesSumLogistico tiene valores invalidos </response>
        /// <response code="401">DetallesSumLogistico No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar DetallesSumLogistico en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] DetallesSumLogistico obj)
        {
            try
            {
                var result = new DetallesSumLogisticoMs().Update(obj);
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
        /// CRUD de la entidad DetallesSumLogistico --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumLogistico!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de DetallesSumLogistico</param>
        /// <response code="200">DetallesSumLogistico Eliminado</response>
        /// <response code="400">DetallesSumLogistico tiene valores invalidos </response>
        /// <response code="401">DetallesSumLogistico No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar DetallesSumLogistico en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] DetallesSumLogistico obj)
        {
           try
            {
                new DetallesSumLogisticoMs().Delete(obj);
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
        /// DataTable de la entidad DetallesSumLogistico --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  DetallesSumLogistico!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de DetallesSumLogistico</param>
        /// <response code="200">DetallesSumLogistico Resultado</response>
        /// <response code="400">DetallesSumLogistico tiene valores invalidos </response>
        /// <response code="401">DetallesSumLogistico No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  DetallesSumLogistico en este momento</response>
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

                var result = new DetallesSumLogisticoMs().GetAllByWithRelation().Cast<DetallesSumLogistico>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <DetallesSumLogistico>().ToList();  
                if (orderCriteria == "ID_contrato") result = result.OrderBy(p => p.ID_contrato).Cast <DetallesSumLogistico>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderBy(p => p.sID_contrato).Cast <DetallesSumLogistico>().ToList(); 
                 if (orderCriteria == "NumeroDiasSuministro") result = result.OrderBy(p => p.NumeroDiasSuministro).Cast <DetallesSumLogistico>().ToList(); 
                 if (orderCriteria == "TotalComplementosContratadas") result = result.OrderBy(p => p.TotalComplementosContratadas).Cast <DetallesSumLogistico>().ToList(); 
                 if (orderCriteria == "CostoUnitarioEnsambleOperacion") result = result.OrderBy(p => p.CostoUnitarioEnsambleOperacion).Cast <DetallesSumLogistico>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <DetallesSumLogistico>().ToList();  
                if (orderCriteria == "ID_contrato") result = result.OrderByDescending(p => p.ID_contrato).Cast <DetallesSumLogistico>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderByDescending(p => p.sID_contrato).Cast<DetallesSumLogistico>().ToList(); 
                 if (orderCriteria == "NumeroDiasSuministro") result = result.OrderByDescending(p => p.NumeroDiasSuministro).Cast <DetallesSumLogistico>().ToList(); 
                 if (orderCriteria == "TotalComplementosContratadas") result = result.OrderByDescending(p => p.TotalComplementosContratadas).Cast <DetallesSumLogistico>().ToList(); 
                 if (orderCriteria == "CostoUnitarioEnsambleOperacion") result = result.OrderByDescending(p => p.CostoUnitarioEnsambleOperacion).Cast <DetallesSumLogistico>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_contrato != null && r.ID_contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_contrato != null && r.sID_contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumeroDiasSuministro != null && r.NumeroDiasSuministro.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TotalComplementosContratadas != null && r.TotalComplementosContratadas.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CostoUnitarioEnsambleOperacion != null && r.CostoUnitarioEnsambleOperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad DetallesSumLogistico --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumLogistico!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DetallesSumLogistico</param>
        /// <response code="200">DetallesSumLogistico Consulto los registros exitosamente</response>
        /// <response code="400">DetallesSumLogistico tiene valores invalidos </response>
        /// <response code="401">DetallesSumLogistico No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DetallesSumLogistico en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new DetallesSumLogisticoMs().GetAllByWithRelation().Cast<DetallesSumLogistico>().AsQueryable();
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
