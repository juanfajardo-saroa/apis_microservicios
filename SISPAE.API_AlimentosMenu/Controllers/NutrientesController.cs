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

namespace SISPAE_API_AlimentosMenu.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de Nutrientes .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class NutrientesController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Nutrientes --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Nutrientes!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Nutrientes</param>
        /// <response code="200">Nutrientes Consulto los registros exitosamente</response>
        /// <response code="400">Nutrientes tiene valores invalidos </response>
        /// <response code="401">Nutrientes No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Nutrientes en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new NutrientesMs().GetAll().Cast<Nutrientes>().AsQueryable();
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
        /// CRUD de la entidad Nutrientes --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Nutrientes!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Nutrientes</param>
        /// <response code="200">Nutrientes Consulto los registros exitosamente</response>
        /// <response code="400">Nutrientes tiene valores invalidos </response>
        /// <response code="401">Nutrientes No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Nutrientes en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new NutrientesMs().GetAllFull().Cast<Nutrientes>().AsQueryable();
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
        /// CRUD de la entidad Nutrientes --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Nutrientes!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Nutrientes</param>
        /// <response code="200">Nutrientes Consulto los registros exitosamente</response>
        /// <response code="400">Nutrientes tiene valores invalidos </response>
        /// <response code="401">Nutrientes No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Nutrientes en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new NutrientesMs().GetById(new Nutrientes() { id = id });
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
        /// CRUD de la entidad Nutrientes --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Nutrientes!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Nutrientes</param>
        /// <response code="200">Nutrientes Creado</response>
        /// <response code="400">Nutrientes tiene valores invalidos </response>
        /// <response code="401">Nutrientes No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Nutrientes en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Nutrientes obj)
        {
            try
            {
                var result = new NutrientesMs().Add(obj);
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
        /// CRUD de la entidad Nutrientes --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Nutrientes!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Nutrientes</param>
        /// <response code="200">Nutrientes Actualizado</response>
        /// <response code="400">Nutrientes tiene valores invalidos </response>
        /// <response code="401">Nutrientes No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Nutrientes en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Nutrientes obj)
        {
            try
            {
                var result = new NutrientesMs().Update(obj);
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
        /// CRUD de la entidad Nutrientes --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Nutrientes!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Nutrientes</param>
        /// <response code="200">Nutrientes Eliminado</response>
        /// <response code="400">Nutrientes tiene valores invalidos </response>
        /// <response code="401">Nutrientes No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Nutrientes en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Nutrientes obj)
        {
           try
            {
                new NutrientesMs().Delete(obj);
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
        /// DataTable de la entidad Nutrientes --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Nutrientes!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Nutrientes</param>
        /// <response code="200">Nutrientes Resultado</response>
        /// <response code="400">Nutrientes tiene valores invalidos </response>
        /// <response code="401">Nutrientes No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Nutrientes en este momento</response>
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

                var result = new NutrientesMs().GetAllByWithRelation().Cast<Nutrientes>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Nutrientes>().ToList();  
                if (orderCriteria == "ID_TipoNutriente") result = result.OrderBy(p => p.ID_TipoNutriente).Cast <Nutrientes>().ToList(); 
                 if (orderCriteria == "sID_TiposNutrientes") result = result.OrderBy(p => p.sID_TipoNutriente).Cast <Nutrientes>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <Nutrientes>().ToList(); 
                   if (orderCriteria == "Calculado") result = result.OrderBy(p => p.Calculado).Cast <Nutrientes>().ToList(); 
                 if (orderCriteria == "Porcentaje") result = result.OrderBy(p => p.Porcentaje).Cast <Nutrientes>().ToList(); 
                 if (orderCriteria == "ValorConstante") result = result.OrderBy(p => p.ValorConstante).Cast <Nutrientes>().ToList(); 
                 if (orderCriteria == "Id_NutrienteBase") result = result.OrderBy(p => p.Id_NutrienteBase).Cast <Nutrientes>().ToList(); 
                 if (orderCriteria == "orden") result = result.OrderBy(p => p.orden).Cast <Nutrientes>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Nutrientes>().ToList();  
                if (orderCriteria == "ID_TipoNutriente") result = result.OrderByDescending(p => p.ID_TipoNutriente).Cast <Nutrientes>().ToList(); 
                 if (orderCriteria == "sID_TiposNutrientes") result = result.OrderByDescending(p => p.sID_TipoNutriente).Cast<Nutrientes>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <Nutrientes>().ToList(); 
                   if (orderCriteria == "Calculado") result = result.OrderByDescending(p => p.Calculado).Cast <Nutrientes>().ToList(); 
                 if (orderCriteria == "Porcentaje") result = result.OrderByDescending(p => p.Porcentaje).Cast <Nutrientes>().ToList(); 
                 if (orderCriteria == "ValorConstante") result = result.OrderByDescending(p => p.ValorConstante).Cast <Nutrientes>().ToList(); 
                 if (orderCriteria == "Id_NutrienteBase") result = result.OrderByDescending(p => p.Id_NutrienteBase).Cast <Nutrientes>().ToList(); 
                 if (orderCriteria == "orden") result = result.OrderByDescending(p => p.orden).Cast <Nutrientes>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoNutriente != null && r.ID_TipoNutriente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoNutriente != null && r.sID_TipoNutriente.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Calculado != null && r.Calculado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Porcentaje != null && r.Porcentaje.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ValorConstante != null && r.ValorConstante.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Id_NutrienteBase != null && r.Id_NutrienteBase.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.orden != null && r.orden.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
        /// CRUD de la entidad Nutrientes --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  Nutrientes!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Nutrientes</param>
        /// <response code="200">Nutrientes Consulto los registros exitosamente</response>
        /// <response code="400">Nutrientes tiene valores invalidos </response>
        /// <response code="401">Nutrientes No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Nutrientes en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new NutrientesMs().GetAllByWithRelation().Cast<Nutrientes>().AsQueryable();
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
