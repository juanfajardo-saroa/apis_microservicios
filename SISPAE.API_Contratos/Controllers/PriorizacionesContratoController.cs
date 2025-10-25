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
    [SwaggerTag("Web API para CRUD de PriorizacionesContrato .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class PriorizacionesContratoController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad PriorizacionesContrato --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  PriorizacionesContrato!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PriorizacionesContrato</param>
        /// <response code="200">PriorizacionesContrato Consulto los registros exitosamente</response>
        /// <response code="400">PriorizacionesContrato tiene valores invalidos </response>
        /// <response code="401">PriorizacionesContrato No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PriorizacionesContrato en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new PriorizacionesContratoMs().GetAll().Cast<PriorizacionesContrato>().AsQueryable();
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
        /// CRUD de la entidad PriorizacionesContrato --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  PriorizacionesContrato!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PriorizacionesContrato</param>
        /// <response code="200">PriorizacionesContrato Consulto los registros exitosamente</response>
        /// <response code="400">PriorizacionesContrato tiene valores invalidos </response>
        /// <response code="401">PriorizacionesContrato No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PriorizacionesContrato en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new PriorizacionesContratoMs().GetAllFull().Cast<PriorizacionesContrato>().AsQueryable();
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
        /// CRUD de la entidad PriorizacionesContrato --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  PriorizacionesContrato!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PriorizacionesContrato</param>
        /// <response code="200">PriorizacionesContrato Consulto los registros exitosamente</response>
        /// <response code="400">PriorizacionesContrato tiene valores invalidos </response>
        /// <response code="401">PriorizacionesContrato No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar PriorizacionesContrato en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new PriorizacionesContratoMs().GetById(new PriorizacionesContrato() { id = id });
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
        /// CRUD de la entidad PriorizacionesContrato --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  PriorizacionesContrato!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de PriorizacionesContrato</param>
        /// <response code="200">PriorizacionesContrato Creado</response>
        /// <response code="400">PriorizacionesContrato tiene valores invalidos </response>
        /// <response code="401">PriorizacionesContrato No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear PriorizacionesContrato en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] PriorizacionesContrato obj)
        {
            try
            {
                var result = new PriorizacionesContratoMs().Add(obj);
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
        /// CRUD de la entidad PriorizacionesContrato --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  PriorizacionesContrato!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de PriorizacionesContrato</param>
        /// <response code="200">PriorizacionesContrato Actualizado</response>
        /// <response code="400">PriorizacionesContrato tiene valores invalidos </response>
        /// <response code="401">PriorizacionesContrato No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar PriorizacionesContrato en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] PriorizacionesContrato obj)
        {
            try
            {
                var result = new PriorizacionesContratoMs().Update(obj);
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
        /// CRUD de la entidad PriorizacionesContrato --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  PriorizacionesContrato!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de PriorizacionesContrato</param>
        /// <response code="200">PriorizacionesContrato Eliminado</response>
        /// <response code="400">PriorizacionesContrato tiene valores invalidos </response>
        /// <response code="401">PriorizacionesContrato No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar PriorizacionesContrato en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] PriorizacionesContrato obj)
        {
           try
            {
                new PriorizacionesContratoMs().Delete(obj);
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
        /// DataTable de la entidad PriorizacionesContrato --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  PriorizacionesContrato!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de PriorizacionesContrato</param>
        /// <response code="200">PriorizacionesContrato Resultado</response>
        /// <response code="400">PriorizacionesContrato tiene valores invalidos </response>
        /// <response code="401">PriorizacionesContrato No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  PriorizacionesContrato en este momento</response>
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

                var result = new PriorizacionesContratoMs().GetAllByWithRelation().Cast<PriorizacionesContrato>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <PriorizacionesContrato>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderBy(p => p.ID_Contrato).Cast <PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderBy(p => p.sID_Contrato).Cast <PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "ID_GradoSedeJornada") result = result.OrderBy(p => p.ID_GradoSedeJornada).Cast <PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "sID_GradosSedesJornadas") result = result.OrderBy(p => p.sID_GradoSedeJornada).Cast <PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "ID_TipoModelooperacion") result = result.OrderBy(p => p.ID_TipoModelooperacion).Cast <PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderBy(p => p.sID_TipoModelooperacion).Cast <PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "ID_TipoModalidadComplemento") result = result.OrderBy(p => p.ID_TipoModalidadComplemento).Cast <PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "sID_TiposModalidadComplemento") result = result.OrderBy(p => p.sID_TipoModalidadComplemento).Cast <PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "ID_TipoComplemento") result = result.OrderBy(p => p.ID_TipoComplemento).Cast <PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderBy(p => p.sID_TipoComplemento).Cast <PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "NumeroComplementos") result = result.OrderBy(p => p.NumeroComplementos).Cast <PriorizacionesContrato>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <PriorizacionesContrato>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderByDescending(p => p.ID_Contrato).Cast <PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderByDescending(p => p.sID_Contrato).Cast<PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "ID_GradoSedeJornada") result = result.OrderByDescending(p => p.ID_GradoSedeJornada).Cast <PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "sID_GradosSedesJornadas") result = result.OrderByDescending(p => p.sID_GradoSedeJornada).Cast<PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "ID_TipoModelooperacion") result = result.OrderByDescending(p => p.ID_TipoModelooperacion).Cast <PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderByDescending(p => p.sID_TipoModelooperacion).Cast<PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "ID_TipoModalidadComplemento") result = result.OrderByDescending(p => p.ID_TipoModalidadComplemento).Cast <PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "sID_TiposModalidadComplemento") result = result.OrderByDescending(p => p.sID_TipoModalidadComplemento).Cast<PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "ID_TipoComplemento") result = result.OrderByDescending(p => p.ID_TipoComplemento).Cast <PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderByDescending(p => p.sID_TipoComplemento).Cast<PriorizacionesContrato>().ToList(); 
                 if (orderCriteria == "NumeroComplementos") result = result.OrderByDescending(p => p.NumeroComplementos).Cast <PriorizacionesContrato>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Contrato != null && r.ID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Contrato != null && r.sID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_GradoSedeJornada != null && r.ID_GradoSedeJornada.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_GradoSedeJornada != null && r.sID_GradoSedeJornada.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoModelooperacion != null && r.ID_TipoModelooperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoModelooperacion != null && r.sID_TipoModelooperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoModalidadComplemento != null && r.ID_TipoModalidadComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoModalidadComplemento != null && r.sID_TipoModalidadComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoComplemento != null && r.ID_TipoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoComplemento != null && r.sID_TipoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NumeroComplementos != null && r.NumeroComplementos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad PriorizacionesContrato --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  PriorizacionesContrato!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de PriorizacionesContrato</param>
        /// <response code="200">PriorizacionesContrato Consulto los registros exitosamente</response>
        /// <response code="400">PriorizacionesContrato tiene valores invalidos </response>
        /// <response code="401">PriorizacionesContrato No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar PriorizacionesContrato en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new PriorizacionesContratoMs().GetAllByWithRelation().Cast<PriorizacionesContrato>().AsQueryable();
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
