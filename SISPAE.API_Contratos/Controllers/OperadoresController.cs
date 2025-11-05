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
    [SwaggerTag("Web API para CRUD de Operadores .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class OperadoresController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Operadores --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  Operadores!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Operadores</param>
        /// <response code="200">Operadores Consulto los registros exitosamente</response>
        /// <response code="400">Operadores tiene valores invalidos </response>
        /// <response code="401">Operadores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Operadores en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new OperadoresMs().GetAll().Cast<Operadores>().AsQueryable();
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
        /// CRUD de la entidad Operadores --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  Operadores!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Operadores</param>
        /// <response code="200">Operadores Consulto los registros exitosamente</response>
        /// <response code="400">Operadores tiene valores invalidos </response>
        /// <response code="401">Operadores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Operadores en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new OperadoresMs().GetAllFull().Cast<Operadores>().AsQueryable();
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
        /// CRUD de la entidad Operadores --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  Operadores!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Operadores</param>
        /// <response code="200">Operadores Consulto los registros exitosamente</response>
        /// <response code="400">Operadores tiene valores invalidos </response>
        /// <response code="401">Operadores No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Operadores en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new OperadoresMs().GetById(new Operadores() { id = id });
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
        /// CRUD de la entidad Operadores --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  Operadores!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Operadores</param>
        /// <response code="200">Operadores Creado</response>
        /// <response code="400">Operadores tiene valores invalidos </response>
        /// <response code="401">Operadores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Operadores en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Operadores obj)
        {
            try
            {
                var result = new OperadoresMs().Add(obj);
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
        /// CRUD de la entidad Operadores --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  Operadores!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Operadores</param>
        /// <response code="200">Operadores Actualizado</response>
        /// <response code="400">Operadores tiene valores invalidos </response>
        /// <response code="401">Operadores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Operadores en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Operadores obj)
        {
            try
            {
                var result = new OperadoresMs().Update(obj);
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
        /// CRUD de la entidad Operadores --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  Operadores!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Operadores</param>
        /// <response code="200">Operadores Eliminado</response>
        /// <response code="400">Operadores tiene valores invalidos </response>
        /// <response code="401">Operadores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Operadores en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Operadores obj)
        {
           try
            {
                new OperadoresMs().Delete(obj);
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
        /// DataTable de la entidad Operadores --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Operadores!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Operadores</param>
        /// <response code="200">Operadores Resultado</response>
        /// <response code="400">Operadores tiene valores invalidos </response>
        /// <response code="401">Operadores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Operadores en este momento</response>
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

                var result = new OperadoresMs().GetAllByWithRelation().Cast<Operadores>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Operadores>().ToList();  
                if (orderCriteria == "ID_TipoEstadoOperador") result = result.OrderBy(p => p.ID_TipoEstadoOperador).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "sID_TiposEstadoOperador") result = result.OrderBy(p => p.sID_TipoEstadoOperador).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "ID_SubTipoRegistroMercantil") result = result.OrderBy(p => p.ID_SubTipoRegistroMercantil).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "sID_SubTiposRegistroMercantil") result = result.OrderBy(p => p.sID_SubTipoRegistroMercantil).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "ID_Divipola") result = result.OrderBy(p => p.ID_Divipola).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "sID_Divipolas") result = result.OrderBy(p => p.sID_Divipola).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "ID_UsuarioEntidad") result = result.OrderBy(p => p.ID_UsuarioEntidad).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "ID_Tipoldentificacion") result = result.OrderBy(p => p.ID_Tipoldentificacion).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "sID_Tiposidentificacion") result = result.OrderBy(p => p.sID_Tipoldentificacion).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "NombreRazonSocial") result = result.OrderBy(p => p.NombreRazonSocial).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "Nit") result = result.OrderBy(p => p.Nit).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "DV") result = result.OrderBy(p => p.DV).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "RUTPath") result = result.OrderBy(p => p.RUTPath).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "NombreRepresentanteLegal") result = result.OrderBy(p => p.NombreRepresentanteLegal).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "ApellidoRepresentanteLegal") result = result.OrderBy(p => p.ApellidoRepresentanteLegal).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "Numeroldentificacion") result = result.OrderBy(p => p.Numeroldentificacion).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "Correo") result = result.OrderBy(p => p.Correo).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "Telefono") result = result.OrderBy(p => p.Telefono).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "Direccion") result = result.OrderBy(p => p.Direccion).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "ProveedorPAE") result = result.OrderBy(p => p.ProveedorPAE).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "OperadorMAER") result = result.OrderBy(p => p.OperadorMAER).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "CertificadoMAERPath") result = result.OrderBy(p => p.CertificadoMAERPath).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "OperadorMAIP") result = result.OrderBy(p => p.OperadorMAIP).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "OperadorMAEM") result = result.OrderBy(p => p.OperadorMAEM).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "OperadorPAEC") result = result.OrderBy(p => p.OperadorPAEC).Cast <Operadores>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Operadores>().ToList();  
                if (orderCriteria == "ID_TipoEstadoOperador") result = result.OrderByDescending(p => p.ID_TipoEstadoOperador).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "sID_TiposEstadoOperador") result = result.OrderByDescending(p => p.sID_TipoEstadoOperador).Cast<Operadores>().ToList(); 
                 if (orderCriteria == "ID_SubTipoRegistroMercantil") result = result.OrderByDescending(p => p.ID_SubTipoRegistroMercantil).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "sID_SubTiposRegistroMercantil") result = result.OrderByDescending(p => p.sID_SubTipoRegistroMercantil).Cast<Operadores>().ToList(); 
                 if (orderCriteria == "ID_Divipola") result = result.OrderByDescending(p => p.ID_Divipola).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "sID_Divipolas") result = result.OrderByDescending(p => p.sID_Divipola).Cast<Operadores>().ToList(); 
                 if (orderCriteria == "ID_UsuarioEntidad") result = result.OrderByDescending(p => p.ID_UsuarioEntidad).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "ID_Tipoldentificacion") result = result.OrderByDescending(p => p.ID_Tipoldentificacion).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "sID_Tiposidentificacion") result = result.OrderByDescending(p => p.sID_Tipoldentificacion).Cast<Operadores>().ToList(); 
                 if (orderCriteria == "NombreRazonSocial") result = result.OrderByDescending(p => p.NombreRazonSocial).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "Nit") result = result.OrderByDescending(p => p.Nit).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "DV") result = result.OrderByDescending(p => p.DV).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "RUTPath") result = result.OrderByDescending(p => p.RUTPath).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "NombreRepresentanteLegal") result = result.OrderByDescending(p => p.NombreRepresentanteLegal).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "ApellidoRepresentanteLegal") result = result.OrderByDescending(p => p.ApellidoRepresentanteLegal).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "Numeroldentificacion") result = result.OrderByDescending(p => p.Numeroldentificacion).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "Correo") result = result.OrderByDescending(p => p.Correo).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "Telefono") result = result.OrderByDescending(p => p.Telefono).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "Direccion") result = result.OrderByDescending(p => p.Direccion).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "ProveedorPAE") result = result.OrderByDescending(p => p.ProveedorPAE).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "OperadorMAER") result = result.OrderByDescending(p => p.OperadorMAER).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "CertificadoMAERPath") result = result.OrderByDescending(p => p.CertificadoMAERPath).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "OperadorMAIP") result = result.OrderByDescending(p => p.OperadorMAIP).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "OperadorMAEM") result = result.OrderByDescending(p => p.OperadorMAEM).Cast <Operadores>().ToList(); 
                 if (orderCriteria == "OperadorPAEC") result = result.OrderByDescending(p => p.OperadorPAEC).Cast <Operadores>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_TipoEstadoOperador != null && r.ID_TipoEstadoOperador.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoEstadoOperador != null && r.sID_TipoEstadoOperador.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_SubTipoRegistroMercantil != null && r.ID_SubTipoRegistroMercantil.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_SubTipoRegistroMercantil != null && r.sID_SubTipoRegistroMercantil.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Divipola != null && r.ID_Divipola.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Divipola != null && r.sID_Divipola.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_UsuarioEntidad != null && r.ID_UsuarioEntidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Tipoldentificacion != null && r.ID_Tipoldentificacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Tipoldentificacion != null && r.sID_Tipoldentificacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NombreRazonSocial != null && r.NombreRazonSocial.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Nit != null && r.Nit.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.DV != null && r.DV.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.RUTPath != null && r.RUTPath.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.NombreRepresentanteLegal != null && r.NombreRepresentanteLegal.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ApellidoRepresentanteLegal != null && r.ApellidoRepresentanteLegal.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Numeroldentificacion != null && r.Numeroldentificacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Correo != null && r.Correo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Telefono != null && r.Telefono.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Direccion != null && r.Direccion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ProveedorPAE != null && r.ProveedorPAE.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.OperadorMAER != null && r.OperadorMAER.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CertificadoMAERPath != null && r.CertificadoMAERPath.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.OperadorMAIP != null && r.OperadorMAIP.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.OperadorMAEM != null && r.OperadorMAEM.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.OperadorPAEC != null && r.OperadorPAEC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad Operadores --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  Operadores!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Operadores</param>
        /// <response code="200">Operadores Consulto los registros exitosamente</response>
        /// <response code="400">Operadores tiene valores invalidos </response>
        /// <response code="401">Operadores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Operadores en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new OperadoresMs().GetAllByWithRelation().Cast<Operadores>().AsQueryable();
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
