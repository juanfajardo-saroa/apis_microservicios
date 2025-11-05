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

namespace SISPAE_API_ModuloUApa.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de PlanGiros .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PlanGirosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PlanGiros --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_ModuloUApa de la entidad  PlanGiros!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlanGiros</param>
        /// <response code="200">PlanGiros Consulto los registros exitosamente</response>
        /// <response code="400">PlanGiros tiene valores invalidos </response>
        /// <response code="401">PlanGiros No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlanGiros en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new PlanGirosMs().GetAll().Cast<PlanGiros>().AsQueryable();
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
        /// CRUD de la entidad PlanGiros --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_ModuloUApa de la entidad  PlanGiros!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlanGiros</param>
        /// <response code="200">PlanGiros Consulto los registros exitosamente</response>
        /// <response code="400">PlanGiros tiene valores invalidos </response>
        /// <response code="401">PlanGiros No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlanGiros en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new PlanGirosMs().GetAllFull().Cast<PlanGiros>().AsQueryable();
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
        /// CRUD de la entidad PlanGiros --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_ModuloUApa de la entidad  PlanGiros!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlanGiros</param>
        /// <response code="200">PlanGiros Consulto los registros exitosamente</response>
        /// <response code="400">PlanGiros tiene valores invalidos </response>
        /// <response code="401">PlanGiros No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar PlanGiros en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new PlanGirosMs().GetById(new PlanGiros() { id = id });
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
        /// CRUD de la entidad PlanGiros --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_ModuloUApa de la entidad  PlanGiros!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de PlanGiros</param>
        /// <response code="200">PlanGiros Creado</response>
        /// <response code="400">PlanGiros tiene valores invalidos </response>
        /// <response code="401">PlanGiros No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear PlanGiros en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] PlanGiros obj)
        {
            try
            {
                var result = new PlanGirosMs().Add(obj);
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
        /// CRUD de la entidad PlanGiros --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_ModuloUApa de la entidad  PlanGiros!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de PlanGiros</param>
        /// <response code="200">PlanGiros Actualizado</response>
        /// <response code="400">PlanGiros tiene valores invalidos </response>
        /// <response code="401">PlanGiros No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar PlanGiros en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] PlanGiros obj)
        {
            try
            {
                var result = new PlanGirosMs().Update(obj);
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
        /// CRUD de la entidad PlanGiros --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_ModuloUApa de la entidad  PlanGiros!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de PlanGiros</param>
        /// <response code="200">PlanGiros Eliminado</response>
        /// <response code="400">PlanGiros tiene valores invalidos </response>
        /// <response code="401">PlanGiros No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar PlanGiros en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] PlanGiros obj)
        {
           try
            {
                new PlanGirosMs().Delete(obj);
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
        /// DataTable de la entidad PlanGiros --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  PlanGiros!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de PlanGiros</param>
        /// <response code="200">PlanGiros Resultado</response>
        /// <response code="400">PlanGiros tiene valores invalidos </response>
        /// <response code="401">PlanGiros No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  PlanGiros en este momento</response>
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

                var result = new PlanGirosMs().GetAllByWithRelation().Cast<PlanGiros>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <PlanGiros>().ToList();  
                if (orderCriteria == "ID_ETC") result = result.OrderBy(p => p.ID_ETC).Cast <PlanGiros>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderBy(p => p.sID_ETC).Cast <PlanGiros>().ToList(); 
                 if (orderCriteria == "Mes") result = result.OrderBy(p => p.Mes).Cast <PlanGiros>().ToList(); 
                 if (orderCriteria == "sID_Meses") result = result.OrderBy(p => p.sMes).Cast <PlanGiros>().ToList(); 
                 if (orderCriteria == "GiroProyectado") result = result.OrderBy(p => p.GiroProyectado).Cast <PlanGiros>().ToList(); 
                 if (orderCriteria == "GiroConfirmado") result = result.OrderBy(p => p.GiroConfirmado).Cast <PlanGiros>().ToList(); 
                   if (orderCriteria == "idVigencia") result = result.OrderBy(p => p.idVigencia).Cast <PlanGiros>().ToList(); 
                 if (orderCriteria == "sID_Vigencias") result = result.OrderBy(p => p.sidVigencia).Cast <PlanGiros>().ToList(); 
                 if (orderCriteria == "FechaTransferencia") result = result.OrderBy(p => p.FechaTransferencia).Cast <PlanGiros>().ToList(); 
                 if (orderCriteria == "NumeroOrden") result = result.OrderBy(p => p.NumeroOrden).Cast <PlanGiros>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <PlanGiros>().ToList();  
                if (orderCriteria == "ID_ETC") result = result.OrderByDescending(p => p.ID_ETC).Cast <PlanGiros>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderByDescending(p => p.sID_ETC).Cast<PlanGiros>().ToList(); 
                 if (orderCriteria == "Mes") result = result.OrderByDescending(p => p.Mes).Cast <PlanGiros>().ToList(); 
                 if (orderCriteria == "sID_Meses") result = result.OrderByDescending(p => p.sMes).Cast<PlanGiros>().ToList(); 
                 if (orderCriteria == "GiroProyectado") result = result.OrderByDescending(p => p.GiroProyectado).Cast <PlanGiros>().ToList(); 
                 if (orderCriteria == "GiroConfirmado") result = result.OrderByDescending(p => p.GiroConfirmado).Cast <PlanGiros>().ToList(); 
                   if (orderCriteria == "idVigencia") result = result.OrderByDescending(p => p.idVigencia).Cast <PlanGiros>().ToList(); 
                 if (orderCriteria == "sID_Vigencias") result = result.OrderByDescending(p => p.sidVigencia).Cast<PlanGiros>().ToList(); 
                 if (orderCriteria == "FechaTransferencia") result = result.OrderByDescending(p => p.FechaTransferencia).Cast <PlanGiros>().ToList(); 
                 if (orderCriteria == "NumeroOrden") result = result.OrderByDescending(p => p.NumeroOrden).Cast <PlanGiros>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_ETC != null && r.ID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ETC != null && r.sID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Mes != null && r.Mes.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sMes != null && r.sMes.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.GiroProyectado != null && r.GiroProyectado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.GiroConfirmado != null && r.GiroConfirmado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.idVigencia != null && r.idVigencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sidVigencia != null && r.sidVigencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaTransferencia != null && r.FechaTransferencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumeroOrden != null && r.NumeroOrden.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad PlanGiros --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_ModuloUApa de la entidad  PlanGiros!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PlanGiros</param>
        /// <response code="200">PlanGiros Consulto los registros exitosamente</response>
        /// <response code="400">PlanGiros tiene valores invalidos </response>
        /// <response code="401">PlanGiros No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PlanGiros en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new PlanGirosMs().GetAllByWithRelation().Cast<PlanGiros>().AsQueryable();
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
