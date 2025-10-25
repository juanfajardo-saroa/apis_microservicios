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
    [SwaggerTag("Web API para CRUD de DetallesSumMaPriOperador .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class DetallesSumMaPriOperadorController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad DetallesSumMaPriOperador --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumMaPriOperador!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DetallesSumMaPriOperador</param>
        /// <response code="200">DetallesSumMaPriOperador Consulto los registros exitosamente</response>
        /// <response code="400">DetallesSumMaPriOperador tiene valores invalidos </response>
        /// <response code="401">DetallesSumMaPriOperador No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DetallesSumMaPriOperador en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new DetallesSumMaPriOperadorMs().GetAll().Cast<DetallesSumMaPriOperador>().AsQueryable();
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
        /// CRUD de la entidad DetallesSumMaPriOperador --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumMaPriOperador!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DetallesSumMaPriOperador</param>
        /// <response code="200">DetallesSumMaPriOperador Consulto los registros exitosamente</response>
        /// <response code="400">DetallesSumMaPriOperador tiene valores invalidos </response>
        /// <response code="401">DetallesSumMaPriOperador No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DetallesSumMaPriOperador en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new DetallesSumMaPriOperadorMs().GetAllFull().Cast<DetallesSumMaPriOperador>().AsQueryable();
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
        /// CRUD de la entidad DetallesSumMaPriOperador --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumMaPriOperador!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DetallesSumMaPriOperador</param>
        /// <response code="200">DetallesSumMaPriOperador Consulto los registros exitosamente</response>
        /// <response code="400">DetallesSumMaPriOperador tiene valores invalidos </response>
        /// <response code="401">DetallesSumMaPriOperador No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar DetallesSumMaPriOperador en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new DetallesSumMaPriOperadorMs().GetById(new DetallesSumMaPriOperador() { id = id });
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
        /// CRUD de la entidad DetallesSumMaPriOperador --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumMaPriOperador!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de DetallesSumMaPriOperador</param>
        /// <response code="200">DetallesSumMaPriOperador Creado</response>
        /// <response code="400">DetallesSumMaPriOperador tiene valores invalidos </response>
        /// <response code="401">DetallesSumMaPriOperador No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear DetallesSumMaPriOperador en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] DetallesSumMaPriOperador obj)
        {
            try
            {
                var result = new DetallesSumMaPriOperadorMs().Add(obj);
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
        /// CRUD de la entidad DetallesSumMaPriOperador --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumMaPriOperador!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de DetallesSumMaPriOperador</param>
        /// <response code="200">DetallesSumMaPriOperador Actualizado</response>
        /// <response code="400">DetallesSumMaPriOperador tiene valores invalidos </response>
        /// <response code="401">DetallesSumMaPriOperador No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar DetallesSumMaPriOperador en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] DetallesSumMaPriOperador obj)
        {
            try
            {
                var result = new DetallesSumMaPriOperadorMs().Update(obj);
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
        /// CRUD de la entidad DetallesSumMaPriOperador --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumMaPriOperador!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de DetallesSumMaPriOperador</param>
        /// <response code="200">DetallesSumMaPriOperador Eliminado</response>
        /// <response code="400">DetallesSumMaPriOperador tiene valores invalidos </response>
        /// <response code="401">DetallesSumMaPriOperador No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar DetallesSumMaPriOperador en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] DetallesSumMaPriOperador obj)
        {
           try
            {
                new DetallesSumMaPriOperadorMs().Delete(obj);
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
        /// DataTable de la entidad DetallesSumMaPriOperador --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  DetallesSumMaPriOperador!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de DetallesSumMaPriOperador</param>
        /// <response code="200">DetallesSumMaPriOperador Resultado</response>
        /// <response code="400">DetallesSumMaPriOperador tiene valores invalidos </response>
        /// <response code="401">DetallesSumMaPriOperador No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  DetallesSumMaPriOperador en este momento</response>
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

                var result = new DetallesSumMaPriOperadorMs().GetAllByWithRelation().Cast<DetallesSumMaPriOperador>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <DetallesSumMaPriOperador>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderBy(p => p.ID_Contrato).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderBy(p => p.sID_Contrato).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "ID_GrupoAlimento") result = result.OrderBy(p => p.ID_GrupoAlimento).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "ID_TipoGrupoEtario") result = result.OrderBy(p => p.ID_TipoGrupoEtario).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "ID_TipoUnidad") result = result.OrderBy(p => p.ID_TipoUnidad).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "DiasSuministro") result = result.OrderBy(p => p.DiasSuministro).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "NombreAlimento") result = result.OrderBy(p => p.NombreAlimento).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "Gramaje") result = result.OrderBy(p => p.Gramaje).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "UnidadesContratadas") result = result.OrderBy(p => p.UnidadesContratadas).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "ValorUnitario") result = result.OrderBy(p => p.ValorUnitario).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "ValorTotal") result = result.OrderBy(p => p.ValorTotal).Cast <DetallesSumMaPriOperador>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <DetallesSumMaPriOperador>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderByDescending(p => p.ID_Contrato).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderByDescending(p => p.sID_Contrato).Cast<DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "ID_GrupoAlimento") result = result.OrderByDescending(p => p.ID_GrupoAlimento).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "ID_TipoGrupoEtario") result = result.OrderByDescending(p => p.ID_TipoGrupoEtario).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "ID_TipoUnidad") result = result.OrderByDescending(p => p.ID_TipoUnidad).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "DiasSuministro") result = result.OrderByDescending(p => p.DiasSuministro).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "NombreAlimento") result = result.OrderByDescending(p => p.NombreAlimento).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "Gramaje") result = result.OrderByDescending(p => p.Gramaje).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "UnidadesContratadas") result = result.OrderByDescending(p => p.UnidadesContratadas).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "ValorUnitario") result = result.OrderByDescending(p => p.ValorUnitario).Cast <DetallesSumMaPriOperador>().ToList(); 
                 if (orderCriteria == "ValorTotal") result = result.OrderByDescending(p => p.ValorTotal).Cast <DetallesSumMaPriOperador>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Contrato != null && r.ID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Contrato != null && r.sID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_GrupoAlimento != null && r.ID_GrupoAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoGrupoEtario != null && r.ID_TipoGrupoEtario.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoUnidad != null && r.ID_TipoUnidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.DiasSuministro != null && r.DiasSuministro.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NombreAlimento != null && r.NombreAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Gramaje != null && r.Gramaje.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.UnidadesContratadas != null && r.UnidadesContratadas.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ValorUnitario != null && r.ValorUnitario.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ValorTotal != null && r.ValorTotal.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad DetallesSumMaPriOperador --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumMaPriOperador!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DetallesSumMaPriOperador</param>
        /// <response code="200">DetallesSumMaPriOperador Consulto los registros exitosamente</response>
        /// <response code="400">DetallesSumMaPriOperador tiene valores invalidos </response>
        /// <response code="401">DetallesSumMaPriOperador No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DetallesSumMaPriOperador en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new DetallesSumMaPriOperadorMs().GetAllByWithRelation().Cast<DetallesSumMaPriOperador>().AsQueryable();
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
