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
using Microsoft.AspNetCore.OData.Query; using ElmahCore;




// create, index, delete, update , read
//  details, listall, 

namespace SISPAE_API_Seguimiento.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de Proveedores .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class ProveedoresController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Proveedores --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Proveedores!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Proveedores</param>
        /// <response code="200">Proveedores Consulto los registros exitosamente</response>
        /// <response code="400">Proveedores tiene valores invalidos </response>
        /// <response code="401">Proveedores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Proveedores en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new ProveedoresMs().GetAll().Cast<Proveedores>().AsQueryable();
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
        /// CRUD de la entidad Proveedores --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Proveedores!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Proveedores</param>
        /// <response code="200">Proveedores Consulto los registros exitosamente</response>
        /// <response code="400">Proveedores tiene valores invalidos </response>
        /// <response code="401">Proveedores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Proveedores en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new ProveedoresMs().GetAllFull().Cast<Proveedores>().AsQueryable();
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
        /// CRUD de la entidad Proveedores --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Proveedores!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Proveedores</param>
        /// <response code="200">Proveedores Consulto los registros exitosamente</response>
        /// <response code="400">Proveedores tiene valores invalidos </response>
        /// <response code="401">Proveedores No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Proveedores en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new ProveedoresMs().GetById(new Proveedores() { id = id });
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
        /// CRUD de la entidad Proveedores --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Seguimiento de la entidad  Proveedores!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Proveedores</param>
        /// <response code="200">Proveedores Creado</response>
        /// <response code="400">Proveedores tiene valores invalidos </response>
        /// <response code="401">Proveedores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Proveedores en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Proveedores obj)
        {
            try
            {
                var result = new ProveedoresMs().Add(obj);
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
        /// CRUD de la entidad Proveedores --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Seguimiento de la entidad  Proveedores!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Proveedores</param>
        /// <response code="200">Proveedores Actualizado</response>
        /// <response code="400">Proveedores tiene valores invalidos </response>
        /// <response code="401">Proveedores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Proveedores en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Proveedores obj)
        {
            try
            {
                var result = new ProveedoresMs().Update(obj);
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
        /// CRUD de la entidad Proveedores --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Seguimiento de la entidad  Proveedores!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Proveedores</param>
        /// <response code="200">Proveedores Eliminado</response>
        /// <response code="400">Proveedores tiene valores invalidos </response>
        /// <response code="401">Proveedores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Proveedores en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Proveedores obj)
        {
           try
            {
                new ProveedoresMs().Delete(obj);
                return Ok();
            }
            catch (System.Exception ex)
            {
                  return BadRequest(ex.Message);
            }
        }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad Proveedores --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Proveedores!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Proveedores</param>
        /// <response code="200">Proveedores Resultado</response>
        /// <response code="400">Proveedores tiene valores invalidos </response>
        /// <response code="401">Proveedores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Proveedores en este momento</response>
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
                var result = new ProveedoresMs().GetAllByWithRelation().Cast<Proveedores>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                  if (orderAscendingDirection)                  {                  if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <Proveedores>().ToList();  
                  if (orderCriteria == "ID_DivipolasProveedor") result = result.OrderBy(p => p.ID_DivipolasProveedor).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "sID_DivipolasProveedor") result = result.OrderBy(p => p.sID_DivipolasProveedor).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "NombreRazonSocial") result = result.OrderBy(p => p.NombreRazonSocial).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "Nit") result = result.OrderBy(p => p.Nit).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "NumeroCedula") result = result.OrderBy(p => p.NumeroCedula).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "ImagenCedulaPATH") result = result.OrderBy(p => p.ImagenCedulaPATH).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "Correo") result = result.OrderBy(p => p.Correo).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "Telefono") result = result.OrderBy(p => p.Telefono).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "Direccion") result = result.OrderBy(p => p.Direccion).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "ImagenRUTPath") result = result.OrderBy(p => p.ImagenRUTPath).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "NombreRepresentantelegalId") result = result.OrderBy(p => p.NombreRepresentantelegalId).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "ApellidoRepresentantelegalId") result = result.OrderBy(p => p.ApellidoRepresentantelegalId).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "NumeroIdentificacion") result = result.OrderBy(p => p.NumeroIdentificacion).Cast <Proveedores>().ToList(); 
                     }
  else 
                    {                  if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <Proveedores>().ToList();  
                  if (orderCriteria == "ID_DivipolasProveedor") result = result.OrderByDescending(p => p.ID_DivipolasProveedor).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "sID_DivipolasProveedor") result = result.OrderByDescending(p => p.sID_DivipolasProveedor).Cast<Proveedores>().ToList(); 
                   if (orderCriteria == "NombreRazonSocial") result = result.OrderByDescending(p => p.NombreRazonSocial).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "Nit") result = result.OrderByDescending(p => p.Nit).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "NumeroCedula") result = result.OrderByDescending(p => p.NumeroCedula).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "ImagenCedulaPATH") result = result.OrderByDescending(p => p.ImagenCedulaPATH).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "Correo") result = result.OrderByDescending(p => p.Correo).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "Telefono") result = result.OrderByDescending(p => p.Telefono).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "Direccion") result = result.OrderByDescending(p => p.Direccion).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "ImagenRUTPath") result = result.OrderByDescending(p => p.ImagenRUTPath).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "NombreRepresentantelegalId") result = result.OrderByDescending(p => p.NombreRepresentantelegalId).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "ApellidoRepresentantelegalId") result = result.OrderByDescending(p => p.ApellidoRepresentantelegalId).Cast <Proveedores>().ToList(); 
                   if (orderCriteria == "NumeroIdentificacion") result = result.OrderByDescending(p => p.NumeroIdentificacion).Cast <Proveedores>().ToList(); 
                     }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                   || r.ID_DivipolasProveedor != null && r.ID_DivipolasProveedor.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.sID_DivipolasProveedor != null && r.sID_DivipolasProveedor.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.NombreRazonSocial != null && r.NombreRazonSocial.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Nit != null && r.Nit.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.NumeroCedula != null && r.NumeroCedula.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ImagenCedulaPATH != null && r.ImagenCedulaPATH.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Correo != null && r.Correo.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Telefono != null && r.Telefono.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.Direccion != null && r.Direccion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ImagenRUTPath != null && r.ImagenRUTPath.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.NombreRepresentantelegalId != null && r.NombreRepresentantelegalId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ApellidoRepresentantelegalId != null && r.ApellidoRepresentantelegalId.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.NumeroIdentificacion != null && r.NumeroIdentificacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad Proveedores --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Seguimiento de la entidad  Proveedores!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Proveedores</param>
        /// <response code="200">Proveedores Consulto los registros exitosamente</response>
        /// <response code="400">Proveedores tiene valores invalidos </response>
        /// <response code="401">Proveedores No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Proveedores en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new ProveedoresMs().GetAllByWithRelation().Cast<Proveedores>().AsQueryable();
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
