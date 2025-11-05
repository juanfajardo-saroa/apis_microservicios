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
    [SwaggerTag("Web API para CRUD de AlimentosICBF .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class AlimentosICBFController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad AlimentosICBF --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosICBF!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AlimentosICBF</param>
        /// <response code="200">AlimentosICBF Consulto los registros exitosamente</response>
        /// <response code="400">AlimentosICBF tiene valores invalidos </response>
        /// <response code="401">AlimentosICBF No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AlimentosICBF en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new AlimentosICBFMs().GetAll().Cast<AlimentosICBF>().AsQueryable();
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
        /// CRUD de la entidad AlimentosICBF --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosICBF!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AlimentosICBF</param>
        /// <response code="200">AlimentosICBF Consulto los registros exitosamente</response>
        /// <response code="400">AlimentosICBF tiene valores invalidos </response>
        /// <response code="401">AlimentosICBF No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AlimentosICBF en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new AlimentosICBFMs().GetAllFull().Cast<AlimentosICBF>().AsQueryable();
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
        /// CRUD de la entidad AlimentosICBF --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosICBF!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AlimentosICBF</param>
        /// <response code="200">AlimentosICBF Consulto los registros exitosamente</response>
        /// <response code="400">AlimentosICBF tiene valores invalidos </response>
        /// <response code="401">AlimentosICBF No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar AlimentosICBF en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new AlimentosICBFMs().GetById(new AlimentosICBF() { id = id });
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
        /// CRUD de la entidad AlimentosICBF --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosICBF!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de AlimentosICBF</param>
        /// <response code="200">AlimentosICBF Creado</response>
        /// <response code="400">AlimentosICBF tiene valores invalidos </response>
        /// <response code="401">AlimentosICBF No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear AlimentosICBF en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] AlimentosICBF obj)
        {
            try
            {
                var result = new AlimentosICBFMs().Add(obj);
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
        /// CRUD de la entidad AlimentosICBF --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosICBF!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de AlimentosICBF</param>
        /// <response code="200">AlimentosICBF Actualizado</response>
        /// <response code="400">AlimentosICBF tiene valores invalidos </response>
        /// <response code="401">AlimentosICBF No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar AlimentosICBF en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] AlimentosICBF obj)
        {
            try
            {
                var result = new AlimentosICBFMs().Update(obj);
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
        /// CRUD de la entidad AlimentosICBF --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosICBF!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de AlimentosICBF</param>
        /// <response code="200">AlimentosICBF Eliminado</response>
        /// <response code="400">AlimentosICBF tiene valores invalidos </response>
        /// <response code="401">AlimentosICBF No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar AlimentosICBF en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] AlimentosICBF obj)
        {
           try
            {
                new AlimentosICBFMs().Delete(obj);
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
        /// DataTable de la entidad AlimentosICBF --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  AlimentosICBF!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de AlimentosICBF</param>
        /// <response code="200">AlimentosICBF Resultado</response>
        /// <response code="400">AlimentosICBF tiene valores invalidos </response>
        /// <response code="401">AlimentosICBF No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  AlimentosICBF en este momento</response>
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

                var result = new AlimentosICBFMs().GetAllByWithRelation().Cast<AlimentosICBF>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <AlimentosICBF>().ToList();  
                if (orderCriteria == "ID_SubGrupoAlimentos") result = result.OrderBy(p => p.ID_SubGrupoAlimentos).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "sID_SubGrupoAlimentos") result = result.OrderBy(p => p.sID_SubGrupoAlimentos).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "ID_TipoAlimento") result = result.OrderBy(p => p.ID_TipoAlimento).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "sID_TiposAlimentos") result = result.OrderBy(p => p.sID_TipoAlimento).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderBy(p => p.ID_ETC).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderBy(p => p.sID_ETC).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "ID_TipoFuenteNutricional") result = result.OrderBy(p => p.ID_TipoFuenteNutricional).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "sID_TipoFuenteNutricional") result = result.OrderBy(p => p.sID_TipoFuenteNutricional).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "CodigoICBF") result = result.OrderBy(p => p.CodigoICBF).Cast <AlimentosICBF>().ToList(); 
                   if (orderCriteria == "PathlmagenAlimento") result = result.OrderBy(p => p.PathlmagenAlimento).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "PathImagenInformacionNutricional") result = result.OrderBy(p => p.PathImagenInformacionNutricional).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "PorcentajeComestible") result = result.OrderBy(p => p.PorcentajeComestible).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "IntercambioEstandarizado") result = result.OrderBy(p => p.IntercambioEstandarizado).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "PesoBruto") result = result.OrderBy(p => p.PesoBruto).Cast <AlimentosICBF>().ToList(); 
                   if (orderCriteria == "ID_TiposUnidad") result = result.OrderBy(p => p.ID_TiposUnidad).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "sID_TiposUnidad") result = result.OrderBy(p => p.sID_TiposUnidad).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "ID_EstadoRegistro") result = result.OrderBy(p => p.ID_EstadoRegistro).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "sID_EstadosRegistro") result = result.OrderBy(p => p.sID_EstadoRegistro).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "FechaRegistro") result = result.OrderBy(p => p.FechaRegistro).Cast <AlimentosICBF>().ToList(); 
                 }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <AlimentosICBF>().ToList();  
                if (orderCriteria == "ID_SubGrupoAlimentos") result = result.OrderByDescending(p => p.ID_SubGrupoAlimentos).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "sID_SubGrupoAlimentos") result = result.OrderByDescending(p => p.sID_SubGrupoAlimentos).Cast<AlimentosICBF>().ToList(); 
                 if (orderCriteria == "ID_TipoAlimento") result = result.OrderByDescending(p => p.ID_TipoAlimento).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "sID_TiposAlimentos") result = result.OrderByDescending(p => p.sID_TipoAlimento).Cast<AlimentosICBF>().ToList(); 
                 if (orderCriteria == "ID_ETC") result = result.OrderByDescending(p => p.ID_ETC).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "sID_ETC") result = result.OrderByDescending(p => p.sID_ETC).Cast<AlimentosICBF>().ToList(); 
                 if (orderCriteria == "ID_TipoFuenteNutricional") result = result.OrderByDescending(p => p.ID_TipoFuenteNutricional).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "sID_TipoFuenteNutricional") result = result.OrderByDescending(p => p.sID_TipoFuenteNutricional).Cast<AlimentosICBF>().ToList(); 
                 if (orderCriteria == "CodigoICBF") result = result.OrderByDescending(p => p.CodigoICBF).Cast <AlimentosICBF>().ToList(); 
                   if (orderCriteria == "PathlmagenAlimento") result = result.OrderByDescending(p => p.PathlmagenAlimento).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "PathImagenInformacionNutricional") result = result.OrderByDescending(p => p.PathImagenInformacionNutricional).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "PorcentajeComestible") result = result.OrderByDescending(p => p.PorcentajeComestible).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "IntercambioEstandarizado") result = result.OrderByDescending(p => p.IntercambioEstandarizado).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "PesoBruto") result = result.OrderByDescending(p => p.PesoBruto).Cast <AlimentosICBF>().ToList(); 
                   if (orderCriteria == "ID_TiposUnidad") result = result.OrderByDescending(p => p.ID_TiposUnidad).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "sID_TiposUnidad") result = result.OrderByDescending(p => p.sID_TiposUnidad).Cast<AlimentosICBF>().ToList(); 
                 if (orderCriteria == "ID_EstadoRegistro") result = result.OrderByDescending(p => p.ID_EstadoRegistro).Cast <AlimentosICBF>().ToList(); 
                 if (orderCriteria == "sID_EstadosRegistro") result = result.OrderByDescending(p => p.sID_EstadoRegistro).Cast<AlimentosICBF>().ToList(); 
                 if (orderCriteria == "FechaRegistro") result = result.OrderByDescending(p => p.FechaRegistro).Cast <AlimentosICBF>().ToList(); 
                 }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_SubGrupoAlimentos != null && r.ID_SubGrupoAlimentos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_SubGrupoAlimentos != null && r.sID_SubGrupoAlimentos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoAlimento != null && r.ID_TipoAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoAlimento != null && r.sID_TipoAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_ETC != null && r.ID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_ETC != null && r.sID_ETC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoFuenteNutricional != null && r.ID_TipoFuenteNutricional.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoFuenteNutricional != null && r.sID_TipoFuenteNutricional.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CodigoICBF != null && r.CodigoICBF.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.PathlmagenAlimento != null && r.PathlmagenAlimento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PathImagenInformacionNutricional != null && r.PathImagenInformacionNutricional.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PorcentajeComestible != null && r.PorcentajeComestible.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.IntercambioEstandarizado != null && r.IntercambioEstandarizado.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.PesoBruto != null && r.PesoBruto.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                   || r.ID_TiposUnidad != null && r.ID_TiposUnidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TiposUnidad != null && r.sID_TiposUnidad.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_EstadoRegistro != null && r.ID_EstadoRegistro.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_EstadoRegistro != null && r.sID_EstadoRegistro.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FechaRegistro != null && r.FechaRegistro.ToString().ToUpper().Contains(searchBy.ToUpper()) 
 
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
        /// CRUD de la entidad AlimentosICBF --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_AlimentosMenu de la entidad  AlimentosICBF!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AlimentosICBF</param>
        /// <response code="200">AlimentosICBF Consulto los registros exitosamente</response>
        /// <response code="400">AlimentosICBF tiene valores invalidos </response>
        /// <response code="401">AlimentosICBF No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AlimentosICBF en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new AlimentosICBFMs().GetAllByWithRelation().Cast<AlimentosICBF>().AsQueryable();
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
