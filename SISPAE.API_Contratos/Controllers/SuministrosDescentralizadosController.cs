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
    [SwaggerTag("Web API para CRUD de SuministrosDescentralizados .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class SuministrosDescentralizadosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad SuministrosDescentralizados --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  SuministrosDescentralizados!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de SuministrosDescentralizados</param>
        /// <response code="200">SuministrosDescentralizados Consulto los registros exitosamente</response>
        /// <response code="400">SuministrosDescentralizados tiene valores invalidos </response>
        /// <response code="401">SuministrosDescentralizados No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar SuministrosDescentralizados en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new SuministrosDescentralizadosMs().GetAll().Cast<SuministrosDescentralizados>().AsQueryable();
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
        /// CRUD de la entidad SuministrosDescentralizados --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  SuministrosDescentralizados!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de SuministrosDescentralizados</param>
        /// <response code="200">SuministrosDescentralizados Consulto los registros exitosamente</response>
        /// <response code="400">SuministrosDescentralizados tiene valores invalidos </response>
        /// <response code="401">SuministrosDescentralizados No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar SuministrosDescentralizados en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new SuministrosDescentralizadosMs().GetAllFull().Cast<SuministrosDescentralizados>().AsQueryable();
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
        /// CRUD de la entidad SuministrosDescentralizados --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  SuministrosDescentralizados!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de SuministrosDescentralizados</param>
        /// <response code="200">SuministrosDescentralizados Consulto los registros exitosamente</response>
        /// <response code="400">SuministrosDescentralizados tiene valores invalidos </response>
        /// <response code="401">SuministrosDescentralizados No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar SuministrosDescentralizados en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new SuministrosDescentralizadosMs().GetById(new SuministrosDescentralizados() { Id = id });
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
        /// CRUD de la entidad SuministrosDescentralizados --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  SuministrosDescentralizados!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de SuministrosDescentralizados</param>
        /// <response code="200">SuministrosDescentralizados Creado</response>
        /// <response code="400">SuministrosDescentralizados tiene valores invalidos </response>
        /// <response code="401">SuministrosDescentralizados No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear SuministrosDescentralizados en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] SuministrosDescentralizados obj)
        {
            try
            {
                var result = new SuministrosDescentralizadosMs().Add(obj);
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
        /// CRUD de la entidad SuministrosDescentralizados --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  SuministrosDescentralizados!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de SuministrosDescentralizados</param>
        /// <response code="200">SuministrosDescentralizados Actualizado</response>
        /// <response code="400">SuministrosDescentralizados tiene valores invalidos </response>
        /// <response code="401">SuministrosDescentralizados No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar SuministrosDescentralizados en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] SuministrosDescentralizados obj)
        {
            try
            {
                var result = new SuministrosDescentralizadosMs().Update(obj);
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
        /// CRUD de la entidad SuministrosDescentralizados --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  SuministrosDescentralizados!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de SuministrosDescentralizados</param>
        /// <response code="200">SuministrosDescentralizados Eliminado</response>
        /// <response code="400">SuministrosDescentralizados tiene valores invalidos </response>
        /// <response code="401">SuministrosDescentralizados No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar SuministrosDescentralizados en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] SuministrosDescentralizados obj)
        {
           try
            {
                new SuministrosDescentralizadosMs().Delete(obj);
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
        /// DataTable de la entidad SuministrosDescentralizados --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  SuministrosDescentralizados!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de SuministrosDescentralizados</param>
        /// <response code="200">SuministrosDescentralizados Resultado</response>
        /// <response code="400">SuministrosDescentralizados tiene valores invalidos </response>
        /// <response code="401">SuministrosDescentralizados No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  SuministrosDescentralizados en este momento</response>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LoadTable([FromBody] DtParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;

            var orderCriteria = "Id";
            var orderAscendingDirection = true;

            try
            {

                if (dtParameters.Order != null)
                {
                    // in this example we just default sort on the 1st column
                    orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                    orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
                }

                var result = new SuministrosDescentralizadosMs().GetAllByWithRelation().Cast<SuministrosDescentralizados>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="Id") result = result.OrderBy(p => p.Id).Cast <SuministrosDescentralizados>().ToList();  
                if (orderCriteria == "Id_Contrato") result = result.OrderBy(p => p.Id_Contrato).Cast <SuministrosDescentralizados>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderBy(p => p.sId_Contrato).Cast <SuministrosDescentralizados>().ToList(); 
                 if (orderCriteria == "Id_ContratoAsociado") result = result.OrderBy(p => p.Id_ContratoAsociado).Cast <SuministrosDescentralizados>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderBy(p => p.sId_ContratoAsociado).Cast <SuministrosDescentralizados>().ToList(); 
                 if (orderCriteria == "ValorContrato") result = result.OrderBy(p => p.ValorContrato).Cast <SuministrosDescentralizados>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "Id") result = result.OrderByDescending(p => p.Id).Cast <SuministrosDescentralizados>().ToList();  
                if (orderCriteria == "Id_Contrato") result = result.OrderByDescending(p => p.Id_Contrato).Cast <SuministrosDescentralizados>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderByDescending(p => p.sId_Contrato).Cast<SuministrosDescentralizados>().ToList(); 
                 if (orderCriteria == "Id_ContratoAsociado") result = result.OrderByDescending(p => p.Id_ContratoAsociado).Cast <SuministrosDescentralizados>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderByDescending(p => p.sId_ContratoAsociado).Cast<SuministrosDescentralizados>().ToList(); 
                 if (orderCriteria == "ValorContrato") result = result.OrderByDescending(p => p.ValorContrato).Cast <SuministrosDescentralizados>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.Id != null && r.Id.ToString().Contains(searchBy.ToUpper())  
                 || r.Id_Contrato != null && r.Id_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sId_Contrato != null && r.sId_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Id_ContratoAsociado != null && r.Id_ContratoAsociado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sId_ContratoAsociado != null && r.sId_ContratoAsociado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ValorContrato != null && r.ValorContrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
                    data[i].sID = SISPAE.Common.Utilidades.Encrypt($"id={data[i].Id.ToString()}");
                   
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
        /// CRUD de la entidad SuministrosDescentralizados --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  SuministrosDescentralizados!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de SuministrosDescentralizados</param>
        /// <response code="200">SuministrosDescentralizados Consulto los registros exitosamente</response>
        /// <response code="400">SuministrosDescentralizados tiene valores invalidos </response>
        /// <response code="401">SuministrosDescentralizados No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar SuministrosDescentralizados en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new SuministrosDescentralizadosMs().GetAllByWithRelation().Cast<SuministrosDescentralizados>().AsQueryable();
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
