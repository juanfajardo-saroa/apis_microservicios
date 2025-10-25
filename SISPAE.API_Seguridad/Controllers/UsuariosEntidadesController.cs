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

namespace SISPAE_API_Seguridad.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de UsuariosEntidades .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class UsuariosEntidadesController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad UsuariosEntidades --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguridad de la entidad  UsuariosEntidades!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de UsuariosEntidades</param>
        /// <response code="200">UsuariosEntidades Consulto los registros exitosamente</response>
        /// <response code="400">UsuariosEntidades tiene valores invalidos </response>
        /// <response code="401">UsuariosEntidades No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar UsuariosEntidades en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new UsuariosEntidadesMs().GetAll().Cast<UsuariosEntidades>().AsQueryable();
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
        /// CRUD de la entidad UsuariosEntidades --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguridad de la entidad  UsuariosEntidades!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de UsuariosEntidades</param>
        /// <response code="200">UsuariosEntidades Consulto los registros exitosamente</response>
        /// <response code="400">UsuariosEntidades tiene valores invalidos </response>
        /// <response code="401">UsuariosEntidades No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar UsuariosEntidades en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new UsuariosEntidadesMs().GetAllFull().Cast<UsuariosEntidades>().AsQueryable();
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
        /// CRUD de la entidad UsuariosEntidades --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguridad de la entidad  UsuariosEntidades!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de UsuariosEntidades</param>
        /// <response code="200">UsuariosEntidades Consulto los registros exitosamente</response>
        /// <response code="400">UsuariosEntidades tiene valores invalidos </response>
        /// <response code="401">UsuariosEntidades No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar UsuariosEntidades en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new UsuariosEntidadesMs().GetById(new UsuariosEntidades() { id = id });
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
        /// CRUD de la entidad UsuariosEntidades --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Seguridad de la entidad  UsuariosEntidades!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de UsuariosEntidades</param>
        /// <response code="200">UsuariosEntidades Creado</response>
        /// <response code="400">UsuariosEntidades tiene valores invalidos </response>
        /// <response code="401">UsuariosEntidades No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear UsuariosEntidades en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] UsuariosEntidades obj)
        {
            try
            {
                var result = new UsuariosEntidadesMs().Add(obj);
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
        /// CRUD de la entidad UsuariosEntidades --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Seguridad de la entidad  UsuariosEntidades!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de UsuariosEntidades</param>
        /// <response code="200">UsuariosEntidades Actualizado</response>
        /// <response code="400">UsuariosEntidades tiene valores invalidos </response>
        /// <response code="401">UsuariosEntidades No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar UsuariosEntidades en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] UsuariosEntidades obj)
        {
            try
            {
                var result = new UsuariosEntidadesMs().Update(obj);
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
        /// CRUD de la entidad UsuariosEntidades --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Seguridad de la entidad  UsuariosEntidades!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de UsuariosEntidades</param>
        /// <response code="200">UsuariosEntidades Eliminado</response>
        /// <response code="400">UsuariosEntidades tiene valores invalidos </response>
        /// <response code="401">UsuariosEntidades No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar UsuariosEntidades en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] UsuariosEntidades obj)
        {
           try
            {
                new UsuariosEntidadesMs().Delete(obj);
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
        /// DataTable de la entidad UsuariosEntidades --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  UsuariosEntidades!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de UsuariosEntidades</param>
        /// <response code="200">UsuariosEntidades Resultado</response>
        /// <response code="400">UsuariosEntidades tiene valores invalidos </response>
        /// <response code="401">UsuariosEntidades No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  UsuariosEntidades en este momento</response>
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

                var result = new UsuariosEntidadesMs().GetAllByWithRelation().Cast<UsuariosEntidades>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <UsuariosEntidades>().ToList();  
                if (orderCriteria == "ID_TipoEstadoUsuario") result = result.OrderBy(p => p.ID_TipoEstadoUsuario).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "sID_TiposEstadoUsuario") result = result.OrderBy(p => p.sID_TipoEstadoUsuario).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "ID_User") result = result.OrderBy(p => p.ID_User).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "sID_AspNetUsers") result = result.OrderBy(p => p.sID_User).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "ID_Roles") result = result.OrderBy(p => p.ID_Roles).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "sID_AspNetRoles") result = result.OrderBy(p => p.sID_Roles).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderBy(p => p.ID_ETC).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderBy(p => p.sID_ETC).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "ID_ET") result = result.OrderBy(p => p.ID_ET).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "sID_ET") result = result.OrderBy(p => p.sID_ET).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "Apellido") result = result.OrderBy(p => p.Apellido).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "Cedula") result = result.OrderBy(p => p.Cedula).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "Celular") result = result.OrderBy(p => p.Celular).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "Correo") result = result.OrderBy(p => p.Correo).Cast <UsuariosEntidades>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <UsuariosEntidades>().ToList();  
                if (orderCriteria == "ID_TipoEstadoUsuario") result = result.OrderByDescending(p => p.ID_TipoEstadoUsuario).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "sID_TiposEstadoUsuario") result = result.OrderByDescending(p => p.sID_TipoEstadoUsuario).Cast<UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "ID_User") result = result.OrderByDescending(p => p.ID_User).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "sID_AspNetUsers") result = result.OrderByDescending(p => p.sID_User).Cast<UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "ID_Roles") result = result.OrderByDescending(p => p.ID_Roles).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "sID_AspNetRoles") result = result.OrderByDescending(p => p.sID_Roles).Cast<UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderByDescending(p => p.ID_ETC).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderByDescending(p => p.sID_ETC).Cast<UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "ID_ET") result = result.OrderByDescending(p => p.ID_ET).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "sID_ET") result = result.OrderByDescending(p => p.sID_ET).Cast<UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "Apellido") result = result.OrderByDescending(p => p.Apellido).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "Cedula") result = result.OrderByDescending(p => p.Cedula).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "Celular") result = result.OrderByDescending(p => p.Celular).Cast <UsuariosEntidades>().ToList(); 
                 if (orderCriteria == "Correo") result = result.OrderByDescending(p => p.Correo).Cast <UsuariosEntidades>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoEstadoUsuario != null && r.ID_TipoEstadoUsuario.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoEstadoUsuario != null && r.sID_TipoEstadoUsuario.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_User != null && r.ID_User.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_User != null && r.sID_User.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Roles != null && r.ID_Roles.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Roles != null && r.sID_Roles.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_ETC != null && r.ID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ETC != null && r.sID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_ET != null && r.ID_ET.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ET != null && r.sID_ET.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Apellido != null && r.Apellido.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Cedula != null && r.Cedula.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Celular != null && r.Celular.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Correo != null && r.Correo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad UsuariosEntidades --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguridad de la entidad  UsuariosEntidades!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de UsuariosEntidades</param>
        /// <response code="200">UsuariosEntidades Consulto los registros exitosamente</response>
        /// <response code="400">UsuariosEntidades tiene valores invalidos </response>
        /// <response code="401">UsuariosEntidades No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar UsuariosEntidades en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new UsuariosEntidadesMs().GetAllByWithRelation().Cast<UsuariosEntidades>().AsQueryable();
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
