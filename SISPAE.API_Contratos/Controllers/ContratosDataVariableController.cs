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
    [SwaggerTag("Web API para CRUD de ContratosDataVariable .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class ContratosDataVariableController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad ContratosDataVariable --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  ContratosDataVariable!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ContratosDataVariable</param>
        /// <response code="200">ContratosDataVariable Consulto los registros exitosamente</response>
        /// <response code="400">ContratosDataVariable tiene valores invalidos </response>
        /// <response code="401">ContratosDataVariable No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ContratosDataVariable en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new ContratosDataVariableMs().GetAll().Cast<ContratosDataVariable>().AsQueryable();
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
        /// CRUD de la entidad ContratosDataVariable --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  ContratosDataVariable!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ContratosDataVariable</param>
        /// <response code="200">ContratosDataVariable Consulto los registros exitosamente</response>
        /// <response code="400">ContratosDataVariable tiene valores invalidos </response>
        /// <response code="401">ContratosDataVariable No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ContratosDataVariable en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new ContratosDataVariableMs().GetAllFull().Cast<ContratosDataVariable>().AsQueryable();
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
        /// CRUD de la entidad ContratosDataVariable --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  ContratosDataVariable!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ContratosDataVariable</param>
        /// <response code="200">ContratosDataVariable Consulto los registros exitosamente</response>
        /// <response code="400">ContratosDataVariable tiene valores invalidos </response>
        /// <response code="401">ContratosDataVariable No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar ContratosDataVariable en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new ContratosDataVariableMs().GetById(new ContratosDataVariable() { id = id });
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
        /// CRUD de la entidad ContratosDataVariable --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  ContratosDataVariable!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de ContratosDataVariable</param>
        /// <response code="200">ContratosDataVariable Creado</response>
        /// <response code="400">ContratosDataVariable tiene valores invalidos </response>
        /// <response code="401">ContratosDataVariable No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear ContratosDataVariable en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] ContratosDataVariable obj)
        {
            try
            {
                var result = new ContratosDataVariableMs().Add(obj);
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
        /// CRUD de la entidad ContratosDataVariable --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  ContratosDataVariable!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de ContratosDataVariable</param>
        /// <response code="200">ContratosDataVariable Actualizado</response>
        /// <response code="400">ContratosDataVariable tiene valores invalidos </response>
        /// <response code="401">ContratosDataVariable No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar ContratosDataVariable en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] ContratosDataVariable obj)
        {
            try
            {
                var result = new ContratosDataVariableMs().Update(obj);
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
        /// CRUD de la entidad ContratosDataVariable --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  ContratosDataVariable!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de ContratosDataVariable</param>
        /// <response code="200">ContratosDataVariable Eliminado</response>
        /// <response code="400">ContratosDataVariable tiene valores invalidos </response>
        /// <response code="401">ContratosDataVariable No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar ContratosDataVariable en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] ContratosDataVariable obj)
        {
           try
            {
                new ContratosDataVariableMs().Delete(obj);
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
        /// DataTable de la entidad ContratosDataVariable --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  ContratosDataVariable!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de ContratosDataVariable</param>
        /// <response code="200">ContratosDataVariable Resultado</response>
        /// <response code="400">ContratosDataVariable tiene valores invalidos </response>
        /// <response code="401">ContratosDataVariable No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  ContratosDataVariable en este momento</response>
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

                var result = new ContratosDataVariableMs().GetAllByWithRelation().Cast<ContratosDataVariable>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <ContratosDataVariable>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderBy(p => p.ID_Contrato).Cast <ContratosDataVariable>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderBy(p => p.sID_Contrato).Cast <ContratosDataVariable>().ToList(); 
                 if (orderCriteria == "ID_Modificacion") result = result.OrderBy(p => p.ID_Modificacion).Cast <ContratosDataVariable>().ToList(); 
                 if (orderCriteria == "sID_Modificaciones") result = result.OrderBy(p => p.sID_Modificacion).Cast <ContratosDataVariable>().ToList(); 
                 if (orderCriteria == "Actual") result = result.OrderBy(p => p.Actual).Cast <ContratosDataVariable>().ToList(); 
                 if (orderCriteria == "FechaTerminacionContrato") result = result.OrderBy(p => p.FechaTerminacionContrato).Cast <ContratosDataVariable>().ToList(); 
                 if (orderCriteria == "ValorTotalContrato") result = result.OrderBy(p => p.ValorTotalContrato).Cast <ContratosDataVariable>().ToList(); 
                 if (orderCriteria == "NumeroDiasSuministro") result = result.OrderBy(p => p.NumeroDiasSuministro).Cast <ContratosDataVariable>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <ContratosDataVariable>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderByDescending(p => p.ID_Contrato).Cast <ContratosDataVariable>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderByDescending(p => p.sID_Contrato).Cast<ContratosDataVariable>().ToList(); 
                 if (orderCriteria == "ID_Modificacion") result = result.OrderByDescending(p => p.ID_Modificacion).Cast <ContratosDataVariable>().ToList(); 
                 if (orderCriteria == "sID_Modificaciones") result = result.OrderByDescending(p => p.sID_Modificacion).Cast<ContratosDataVariable>().ToList(); 
                 if (orderCriteria == "Actual") result = result.OrderByDescending(p => p.Actual).Cast <ContratosDataVariable>().ToList(); 
                 if (orderCriteria == "FechaTerminacionContrato") result = result.OrderByDescending(p => p.FechaTerminacionContrato).Cast <ContratosDataVariable>().ToList(); 
                 if (orderCriteria == "ValorTotalContrato") result = result.OrderByDescending(p => p.ValorTotalContrato).Cast <ContratosDataVariable>().ToList(); 
                 if (orderCriteria == "NumeroDiasSuministro") result = result.OrderByDescending(p => p.NumeroDiasSuministro).Cast <ContratosDataVariable>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Contrato != null && r.ID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Contrato != null && r.sID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Modificacion != null && r.ID_Modificacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Modificacion != null && r.sID_Modificacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Actual != null && r.Actual.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaTerminacionContrato != null && r.FechaTerminacionContrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ValorTotalContrato != null && r.ValorTotalContrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumeroDiasSuministro != null && r.NumeroDiasSuministro.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad ContratosDataVariable --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  ContratosDataVariable!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ContratosDataVariable</param>
        /// <response code="200">ContratosDataVariable Consulto los registros exitosamente</response>
        /// <response code="400">ContratosDataVariable tiene valores invalidos </response>
        /// <response code="401">ContratosDataVariable No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ContratosDataVariable en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new ContratosDataVariableMs().GetAllByWithRelation().Cast<ContratosDataVariable>().AsQueryable();
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
