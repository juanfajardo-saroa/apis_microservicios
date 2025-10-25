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

namespace SISPAE_API_SistemaEducativo.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de GradosSedesJornadas .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class GradosSedesJornadasController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad GradosSedesJornadas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  GradosSedesJornadas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de GradosSedesJornadas</param>
        /// <response code="200">GradosSedesJornadas Consulto los registros exitosamente</response>
        /// <response code="400">GradosSedesJornadas tiene valores invalidos </response>
        /// <response code="401">GradosSedesJornadas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar GradosSedesJornadas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new GradosSedesJornadasMs().GetAll().Cast<GradosSedesJornadas>().AsQueryable();
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
        /// CRUD de la entidad GradosSedesJornadas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  GradosSedesJornadas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de GradosSedesJornadas</param>
        /// <response code="200">GradosSedesJornadas Consulto los registros exitosamente</response>
        /// <response code="400">GradosSedesJornadas tiene valores invalidos </response>
        /// <response code="401">GradosSedesJornadas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar GradosSedesJornadas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new GradosSedesJornadasMs().GetAllFull().Cast<GradosSedesJornadas>().AsQueryable();
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
        /// CRUD de la entidad GradosSedesJornadas --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  GradosSedesJornadas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de GradosSedesJornadas</param>
        /// <response code="200">GradosSedesJornadas Consulto los registros exitosamente</response>
        /// <response code="400">GradosSedesJornadas tiene valores invalidos </response>
        /// <response code="401">GradosSedesJornadas No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar GradosSedesJornadas en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new GradosSedesJornadasMs().GetById(new GradosSedesJornadas() { id = id });
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
        /// CRUD de la entidad GradosSedesJornadas --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_SistemaEducativo de la entidad  GradosSedesJornadas!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de GradosSedesJornadas</param>
        /// <response code="200">GradosSedesJornadas Creado</response>
        /// <response code="400">GradosSedesJornadas tiene valores invalidos </response>
        /// <response code="401">GradosSedesJornadas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear GradosSedesJornadas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] GradosSedesJornadas obj)
        {
            try
            {
                var result = new GradosSedesJornadasMs().Add(obj);
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
        /// CRUD de la entidad GradosSedesJornadas --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  GradosSedesJornadas!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de GradosSedesJornadas</param>
        /// <response code="200">GradosSedesJornadas Actualizado</response>
        /// <response code="400">GradosSedesJornadas tiene valores invalidos </response>
        /// <response code="401">GradosSedesJornadas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar GradosSedesJornadas en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] GradosSedesJornadas obj)
        {
            try
            {
                var result = new GradosSedesJornadasMs().Update(obj);
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
        /// CRUD de la entidad GradosSedesJornadas --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  GradosSedesJornadas!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de GradosSedesJornadas</param>
        /// <response code="200">GradosSedesJornadas Eliminado</response>
        /// <response code="400">GradosSedesJornadas tiene valores invalidos </response>
        /// <response code="401">GradosSedesJornadas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar GradosSedesJornadas en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] GradosSedesJornadas obj)
        {
           try
            {
                new GradosSedesJornadasMs().Delete(obj);
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
        /// DataTable de la entidad GradosSedesJornadas --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  GradosSedesJornadas!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de GradosSedesJornadas</param>
        /// <response code="200">GradosSedesJornadas Resultado</response>
        /// <response code="400">GradosSedesJornadas tiene valores invalidos </response>
        /// <response code="401">GradosSedesJornadas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  GradosSedesJornadas en este momento</response>
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

                var result = new GradosSedesJornadasMs().GetAllByWithRelation().Cast<GradosSedesJornadas>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <GradosSedesJornadas>().ToList();  
                if (orderCriteria == "ID_SedeJornada") result = result.OrderBy(p => p.ID_SedeJornada).Cast <GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "sID_SedesJornada") result = result.OrderBy(p => p.sID_SedeJornada).Cast <GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "ID_Grado") result = result.OrderBy(p => p.ID_Grado).Cast <GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "sID_Grados") result = result.OrderBy(p => p.sID_Grado).Cast <GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "Matricula") result = result.OrderBy(p => p.Matricula).Cast <GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "CantlndigVicDis") result = result.OrderBy(p => p.CantlndigVicDis).Cast <GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "CantSisbenAB") result = result.OrderBy(p => p.CantSisbenAB).Cast <GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "CantDiscapacitados") result = result.OrderBy(p => p.CantDiscapacitados).Cast <GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "CantIndigenasDiscapacidad") result = result.OrderBy(p => p.CantIndigenasDiscapacidad).Cast <GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "CambioMatricula") result = result.OrderBy(p => p.CambioMatricula).Cast <GradosSedesJornadas>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <GradosSedesJornadas>().ToList();  
                if (orderCriteria == "ID_SedeJornada") result = result.OrderByDescending(p => p.ID_SedeJornada).Cast <GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "sID_SedesJornada") result = result.OrderByDescending(p => p.sID_SedeJornada).Cast<GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "ID_Grado") result = result.OrderByDescending(p => p.ID_Grado).Cast <GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "sID_Grados") result = result.OrderByDescending(p => p.sID_Grado).Cast<GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "Matricula") result = result.OrderByDescending(p => p.Matricula).Cast <GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "CantlndigVicDis") result = result.OrderByDescending(p => p.CantlndigVicDis).Cast <GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "CantSisbenAB") result = result.OrderByDescending(p => p.CantSisbenAB).Cast <GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "CantDiscapacitados") result = result.OrderByDescending(p => p.CantDiscapacitados).Cast <GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "CantIndigenasDiscapacidad") result = result.OrderByDescending(p => p.CantIndigenasDiscapacidad).Cast <GradosSedesJornadas>().ToList(); 
                 if (orderCriteria == "CambioMatricula") result = result.OrderByDescending(p => p.CambioMatricula).Cast <GradosSedesJornadas>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_SedeJornada != null && r.ID_SedeJornada.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_SedeJornada != null && r.sID_SedeJornada.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Grado != null && r.ID_Grado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Grado != null && r.sID_Grado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Matricula != null && r.Matricula.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CantlndigVicDis != null && r.CantlndigVicDis.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CantSisbenAB != null && r.CantSisbenAB.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CantDiscapacitados != null && r.CantDiscapacitados.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CantIndigenasDiscapacidad != null && r.CantIndigenasDiscapacidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CambioMatricula != null && r.CambioMatricula.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad GradosSedesJornadas --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_SistemaEducativo de la entidad  GradosSedesJornadas!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de GradosSedesJornadas</param>
        /// <response code="200">GradosSedesJornadas Consulto los registros exitosamente</response>
        /// <response code="400">GradosSedesJornadas tiene valores invalidos </response>
        /// <response code="401">GradosSedesJornadas No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar GradosSedesJornadas en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new GradosSedesJornadasMs().GetAllByWithRelation().Cast<GradosSedesJornadas>().AsQueryable();
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
