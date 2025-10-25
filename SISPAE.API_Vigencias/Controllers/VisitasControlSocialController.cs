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

namespace SISPAE_API_Vigencias.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de VisitasControlSocial .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class VisitasControlSocialController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad VisitasControlSocial --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Vigencias de la entidad  VisitasControlSocial!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de VisitasControlSocial</param>
        /// <response code="200">VisitasControlSocial Consulto los registros exitosamente</response>
        /// <response code="400">VisitasControlSocial tiene valores invalidos </response>
        /// <response code="401">VisitasControlSocial No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar VisitasControlSocial en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new VisitasControlSocialMs().GetAll().Cast<VisitasControlSocial>().AsQueryable();
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
        /// CRUD de la entidad VisitasControlSocial --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Vigencias de la entidad  VisitasControlSocial!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de VisitasControlSocial</param>
        /// <response code="200">VisitasControlSocial Consulto los registros exitosamente</response>
        /// <response code="400">VisitasControlSocial tiene valores invalidos </response>
        /// <response code="401">VisitasControlSocial No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar VisitasControlSocial en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new VisitasControlSocialMs().GetAllFull().Cast<VisitasControlSocial>().AsQueryable();
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
        /// CRUD de la entidad VisitasControlSocial --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Vigencias de la entidad  VisitasControlSocial!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de VisitasControlSocial</param>
        /// <response code="200">VisitasControlSocial Consulto los registros exitosamente</response>
        /// <response code="400">VisitasControlSocial tiene valores invalidos </response>
        /// <response code="401">VisitasControlSocial No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar VisitasControlSocial en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new VisitasControlSocialMs().GetById(new VisitasControlSocial() { id = id });
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
        /// CRUD de la entidad VisitasControlSocial --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Vigencias de la entidad  VisitasControlSocial!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de VisitasControlSocial</param>
        /// <response code="200">VisitasControlSocial Creado</response>
        /// <response code="400">VisitasControlSocial tiene valores invalidos </response>
        /// <response code="401">VisitasControlSocial No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear VisitasControlSocial en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] VisitasControlSocial obj)
        {
            try
            {
                var result = new VisitasControlSocialMs().Add(obj);
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
        /// CRUD de la entidad VisitasControlSocial --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Vigencias de la entidad  VisitasControlSocial!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de VisitasControlSocial</param>
        /// <response code="200">VisitasControlSocial Actualizado</response>
        /// <response code="400">VisitasControlSocial tiene valores invalidos </response>
        /// <response code="401">VisitasControlSocial No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar VisitasControlSocial en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] VisitasControlSocial obj)
        {
            try
            {
                var result = new VisitasControlSocialMs().Update(obj);
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
        /// CRUD de la entidad VisitasControlSocial --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Vigencias de la entidad  VisitasControlSocial!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de VisitasControlSocial</param>
        /// <response code="200">VisitasControlSocial Eliminado</response>
        /// <response code="400">VisitasControlSocial tiene valores invalidos </response>
        /// <response code="401">VisitasControlSocial No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar VisitasControlSocial en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] VisitasControlSocial obj)
        {
           try
            {
                new VisitasControlSocialMs().Delete(obj);
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
        /// DataTable de la entidad VisitasControlSocial --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  VisitasControlSocial!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de VisitasControlSocial</param>
        /// <response code="200">VisitasControlSocial Resultado</response>
        /// <response code="400">VisitasControlSocial tiene valores invalidos </response>
        /// <response code="401">VisitasControlSocial No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  VisitasControlSocial en este momento</response>
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

                var result = new VisitasControlSocialMs().GetAllByWithRelation().Cast<VisitasControlSocial>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <VisitasControlSocial>().ToList();  
                if (orderCriteria == "ID_TipoActorControlSocial") result = result.OrderBy(p => p.ID_TipoActorControlSocial).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "ID_Divipola") result = result.OrderBy(p => p.ID_Divipola).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "sID_Divipolas") result = result.OrderBy(p => p.sID_Divipola).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "ID_TipoEntidad") result = result.OrderBy(p => p.ID_TipoEntidad).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "ID_Sede") result = result.OrderBy(p => p.ID_Sede).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "sID_Sedes") result = result.OrderBy(p => p.sID_Sede).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "ID_Vigencia") result = result.OrderBy(p => p.ID_Vigencia).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "sID_Vigencias") result = result.OrderBy(p => p.sID_Vigencia).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "ID_TipoCargoControlSocial") result = result.OrderBy(p => p.ID_TipoCargoControlSocial).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "cargoControlSocialOtros") result = result.OrderBy(p => p.cargoControlSocialOtros).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "ID_TipolnstitucionControlSocial") result = result.OrderBy(p => p.ID_TipolnstitucionControlSocial).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "InstitucionControlSocialOtros") result = result.OrderBy(p => p.InstitucionControlSocialOtros).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "Correo") result = result.OrderBy(p => p.Correo).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "Apellido") result = result.OrderBy(p => p.Apellido).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "Cedula") result = result.OrderBy(p => p.Cedula).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "Celular") result = result.OrderBy(p => p.Celular).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "FechaHoraVisita") result = result.OrderBy(p => p.FechaHoraVisita).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "FechaReporte") result = result.OrderBy(p => p.FechaReporte).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "FotoComplementoEvidenciaPath") result = result.OrderBy(p => p.FotoComplementoEvidenciaPath).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "DescripcionFoto") result = result.OrderBy(p => p.DescripcionFoto).Cast <VisitasControlSocial>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <VisitasControlSocial>().ToList();  
                if (orderCriteria == "ID_TipoActorControlSocial") result = result.OrderByDescending(p => p.ID_TipoActorControlSocial).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "ID_Divipola") result = result.OrderByDescending(p => p.ID_Divipola).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "sID_Divipolas") result = result.OrderByDescending(p => p.sID_Divipola).Cast<VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "ID_TipoEntidad") result = result.OrderByDescending(p => p.ID_TipoEntidad).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "ID_Sede") result = result.OrderByDescending(p => p.ID_Sede).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "sID_Sedes") result = result.OrderByDescending(p => p.sID_Sede).Cast<VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "ID_Vigencia") result = result.OrderByDescending(p => p.ID_Vigencia).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "sID_Vigencias") result = result.OrderByDescending(p => p.sID_Vigencia).Cast<VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "ID_TipoCargoControlSocial") result = result.OrderByDescending(p => p.ID_TipoCargoControlSocial).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "cargoControlSocialOtros") result = result.OrderByDescending(p => p.cargoControlSocialOtros).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "ID_TipolnstitucionControlSocial") result = result.OrderByDescending(p => p.ID_TipolnstitucionControlSocial).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "InstitucionControlSocialOtros") result = result.OrderByDescending(p => p.InstitucionControlSocialOtros).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "Correo") result = result.OrderByDescending(p => p.Correo).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "Apellido") result = result.OrderByDescending(p => p.Apellido).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "Cedula") result = result.OrderByDescending(p => p.Cedula).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "Celular") result = result.OrderByDescending(p => p.Celular).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "FechaHoraVisita") result = result.OrderByDescending(p => p.FechaHoraVisita).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "FechaReporte") result = result.OrderByDescending(p => p.FechaReporte).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "FotoComplementoEvidenciaPath") result = result.OrderByDescending(p => p.FotoComplementoEvidenciaPath).Cast <VisitasControlSocial>().ToList(); 
                 if (orderCriteria == "DescripcionFoto") result = result.OrderByDescending(p => p.DescripcionFoto).Cast <VisitasControlSocial>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoActorControlSocial != null && r.ID_TipoActorControlSocial.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Divipola != null && r.ID_Divipola.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Divipola != null && r.sID_Divipola.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoEntidad != null && r.ID_TipoEntidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Sede != null && r.ID_Sede.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Sede != null && r.sID_Sede.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Vigencia != null && r.ID_Vigencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Vigencia != null && r.sID_Vigencia.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoCargoControlSocial != null && r.ID_TipoCargoControlSocial.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.cargoControlSocialOtros != null && r.cargoControlSocialOtros.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipolnstitucionControlSocial != null && r.ID_TipolnstitucionControlSocial.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.InstitucionControlSocialOtros != null && r.InstitucionControlSocialOtros.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Correo != null && r.Correo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Apellido != null && r.Apellido.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Cedula != null && r.Cedula.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Celular != null && r.Celular.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaHoraVisita != null && r.FechaHoraVisita.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaReporte != null && r.FechaReporte.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FotoComplementoEvidenciaPath != null && r.FotoComplementoEvidenciaPath.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.DescripcionFoto != null && r.DescripcionFoto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad VisitasControlSocial --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Vigencias de la entidad  VisitasControlSocial!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de VisitasControlSocial</param>
        /// <response code="200">VisitasControlSocial Consulto los registros exitosamente</response>
        /// <response code="400">VisitasControlSocial tiene valores invalidos </response>
        /// <response code="401">VisitasControlSocial No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar VisitasControlSocial en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new VisitasControlSocialMs().GetAllByWithRelation().Cast<VisitasControlSocial>().AsQueryable();
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
