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

namespace SISPAE_API_Staging.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de StgAnexoEstructuraFamiliar .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class StgAnexoEstructuraFamiliarController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad StgAnexoEstructuraFamiliar --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgAnexoEstructuraFamiliar!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgAnexoEstructuraFamiliar</param>
        /// <response code="200">StgAnexoEstructuraFamiliar Consulto los registros exitosamente</response>
        /// <response code="400">StgAnexoEstructuraFamiliar tiene valores invalidos </response>
        /// <response code="401">StgAnexoEstructuraFamiliar No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar StgAnexoEstructuraFamiliar en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new StgAnexoEstructuraFamiliarMs().GetAll().Cast<StgAnexoEstructuraFamiliar>().AsQueryable();
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
        /// CRUD de la entidad StgAnexoEstructuraFamiliar --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgAnexoEstructuraFamiliar!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgAnexoEstructuraFamiliar</param>
        /// <response code="200">StgAnexoEstructuraFamiliar Consulto los registros exitosamente</response>
        /// <response code="400">StgAnexoEstructuraFamiliar tiene valores invalidos </response>
        /// <response code="401">StgAnexoEstructuraFamiliar No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar StgAnexoEstructuraFamiliar en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new StgAnexoEstructuraFamiliarMs().GetAllFull().Cast<StgAnexoEstructuraFamiliar>().AsQueryable();
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
        /// CRUD de la entidad StgAnexoEstructuraFamiliar --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgAnexoEstructuraFamiliar!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgAnexoEstructuraFamiliar</param>
        /// <response code="200">StgAnexoEstructuraFamiliar Consulto los registros exitosamente</response>
        /// <response code="400">StgAnexoEstructuraFamiliar tiene valores invalidos </response>
        /// <response code="401">StgAnexoEstructuraFamiliar No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar StgAnexoEstructuraFamiliar en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new StgAnexoEstructuraFamiliarMs().GetById(new StgAnexoEstructuraFamiliar() { id = id });
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
        /// CRUD de la entidad StgAnexoEstructuraFamiliar --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Staging de la entidad  StgAnexoEstructuraFamiliar!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de StgAnexoEstructuraFamiliar</param>
        /// <response code="200">StgAnexoEstructuraFamiliar Creado</response>
        /// <response code="400">StgAnexoEstructuraFamiliar tiene valores invalidos </response>
        /// <response code="401">StgAnexoEstructuraFamiliar No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear StgAnexoEstructuraFamiliar en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] StgAnexoEstructuraFamiliar obj)
        {
            try
            {
                var result = new StgAnexoEstructuraFamiliarMs().Add(obj);
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
        /// CRUD de la entidad StgAnexoEstructuraFamiliar --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Staging de la entidad  StgAnexoEstructuraFamiliar!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de StgAnexoEstructuraFamiliar</param>
        /// <response code="200">StgAnexoEstructuraFamiliar Actualizado</response>
        /// <response code="400">StgAnexoEstructuraFamiliar tiene valores invalidos </response>
        /// <response code="401">StgAnexoEstructuraFamiliar No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar StgAnexoEstructuraFamiliar en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] StgAnexoEstructuraFamiliar obj)
        {
            try
            {
                var result = new StgAnexoEstructuraFamiliarMs().Update(obj);
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
        /// CRUD de la entidad StgAnexoEstructuraFamiliar --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Staging de la entidad  StgAnexoEstructuraFamiliar!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de StgAnexoEstructuraFamiliar</param>
        /// <response code="200">StgAnexoEstructuraFamiliar Eliminado</response>
        /// <response code="400">StgAnexoEstructuraFamiliar tiene valores invalidos </response>
        /// <response code="401">StgAnexoEstructuraFamiliar No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar StgAnexoEstructuraFamiliar en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] StgAnexoEstructuraFamiliar obj)
        {
           try
            {
                new StgAnexoEstructuraFamiliarMs().Delete(obj);
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
        /// DataTable de la entidad StgAnexoEstructuraFamiliar --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  StgAnexoEstructuraFamiliar!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de StgAnexoEstructuraFamiliar</param>
        /// <response code="200">StgAnexoEstructuraFamiliar Resultado</response>
        /// <response code="400">StgAnexoEstructuraFamiliar tiene valores invalidos </response>
        /// <response code="401">StgAnexoEstructuraFamiliar No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  StgAnexoEstructuraFamiliar en este momento</response>
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

                var result = new StgAnexoEstructuraFamiliarMs().GetAllByWithRelation().Cast<StgAnexoEstructuraFamiliar>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria == "PER_ID") result = result.OrderBy(p => p.PER_ID).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "APELLIDO1") result = result.OrderBy(p => p.APELLIDO1).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "APELLIDO2") result = result.OrderBy(p => p.APELLIDO2).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "NOMBRE1") result = result.OrderBy(p => p.NOMBRE1).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "NOMBRE2") result = result.OrderBy(p => p.NOMBRE2).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "TIPO_DOCUMENTO") result = result.OrderBy(p => p.TIPO_DOCUMENTO).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "NRO_DOCUMENTO") result = result.OrderBy(p => p.NRO_DOCUMENTO).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "PARENTESCO") result = result.OrderBy(p => p.PARENTESCO).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "CORREO") result = result.OrderBy(p => p.CORREO).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "TELEFONO") result = result.OrderBy(p => p.TELEFONO).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "CODIGO_DANE") result = result.OrderBy(p => p.CODIGO_DANE).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "CODIGO_DANE_SEDE") result = result.OrderBy(p => p.CODIGO_DANE_SEDE).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <StgAnexoEstructuraFamiliar>().ToList();  
                  }
                else 
                {                if (orderCriteria == "PER_ID") result = result.OrderByDescending(p => p.PER_ID).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "APELLIDO1") result = result.OrderByDescending(p => p.APELLIDO1).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "APELLIDO2") result = result.OrderByDescending(p => p.APELLIDO2).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "NOMBRE1") result = result.OrderByDescending(p => p.NOMBRE1).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "NOMBRE2") result = result.OrderByDescending(p => p.NOMBRE2).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "TIPO_DOCUMENTO") result = result.OrderByDescending(p => p.TIPO_DOCUMENTO).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "NRO_DOCUMENTO") result = result.OrderByDescending(p => p.NRO_DOCUMENTO).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "PARENTESCO") result = result.OrderByDescending(p => p.PARENTESCO).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "CORREO") result = result.OrderByDescending(p => p.CORREO).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "TELEFONO") result = result.OrderByDescending(p => p.TELEFONO).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "CODIGO_DANE") result = result.OrderByDescending(p => p.CODIGO_DANE).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "CODIGO_DANE_SEDE") result = result.OrderByDescending(p => p.CODIGO_DANE_SEDE).Cast <StgAnexoEstructuraFamiliar>().ToList(); 
                 if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <StgAnexoEstructuraFamiliar>().ToList();  
                  }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.PER_ID != null && r.PER_ID.ToString().Contains(searchBy.ToUpper())  
                 || r.APELLIDO1 != null && r.APELLIDO1.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.APELLIDO2 != null && r.APELLIDO2.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NOMBRE1 != null && r.NOMBRE1.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NOMBRE2 != null && r.NOMBRE2.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TIPO_DOCUMENTO != null && r.TIPO_DOCUMENTO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NRO_DOCUMENTO != null && r.NRO_DOCUMENTO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PARENTESCO != null && r.PARENTESCO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CORREO != null && r.CORREO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TELEFONO != null && r.TELEFONO.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CODIGO_DANE != null && r.CODIGO_DANE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CODIGO_DANE_SEDE != null && r.CODIGO_DANE_SEDE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.id != null && r.id.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad StgAnexoEstructuraFamiliar --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Staging de la entidad  StgAnexoEstructuraFamiliar!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de StgAnexoEstructuraFamiliar</param>
        /// <response code="200">StgAnexoEstructuraFamiliar Consulto los registros exitosamente</response>
        /// <response code="400">StgAnexoEstructuraFamiliar tiene valores invalidos </response>
        /// <response code="401">StgAnexoEstructuraFamiliar No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar StgAnexoEstructuraFamiliar en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new StgAnexoEstructuraFamiliarMs().GetAllByWithRelation().Cast<StgAnexoEstructuraFamiliar>().AsQueryable();
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
