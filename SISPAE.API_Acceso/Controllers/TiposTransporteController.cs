/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano				:2022
/// Arquitectura	:Patron MVC ASP Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa			:WEBAPI (WEBAPI Entity Layer) - Capa WEB API (Source: MVC7_ControllersAPI_Base.cs)    
/// </Derechos_Reservados>


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

using SISPAE.Business;
using SISPAE.Model;

using Swashbuckle.AspNetCore.Annotations;




// create, index, delete, update , read
//  details, listall, 

namespace SISPAE_API_Acceso.WebAPI.Controllers
    {
    [SwaggerTag("Web API para CRUD de TiposTransporte .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class TiposTransporteController : ControllerBase
        {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad TiposTransporte --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Trayectos de la entidad  TiposTransporte!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de TiposTransporte</param>
        /// <response code="200">TiposTransporte Consulto los registros exitosamente</response>
        /// <response code="400">TiposTransporte tiene valores invalidos </response>
        /// <response code="401">TiposTransporte No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar TiposTransporte en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
            {
            try
                {
                var result = new TiposTransporteMs().GetAll().Cast<TiposTransporte>().AsQueryable();
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad TiposTransporte --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Trayectos de la entidad  TiposTransporte!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de TiposTransporte</param>
        /// <response code="200">TiposTransporte Consulto los registros exitosamente</response>
        /// <response code="400">TiposTransporte tiene valores invalidos </response>
        /// <response code="401">TiposTransporte No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar TiposTransporte en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
            {
            try
                {
                var result = new TiposTransporteMs().GetAllFull().Cast<TiposTransporte>().AsQueryable();
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }



        // GET api/values/5
        /// <summary>
        /// CRUD de la entidad TiposTransporte --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Trayectos de la entidad  TiposTransporte!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de TiposTransporte</param>
        /// <response code="200">TiposTransporte Consulto los registros exitosamente</response>
        /// <response code="400">TiposTransporte tiene valores invalidos </response>
        /// <response code="401">TiposTransporte No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar TiposTransporte en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
            {
            try
                {
                var result = new TiposTransporteMs().GetById(new TiposTransporte() { TipoTransporteId = id });
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }



        // POST api/values
        /// <summary>
        /// CRUD de la entidad TiposTransporte --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Trayectos de la entidad  TiposTransporte!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de TiposTransporte</param>
        /// <response code="200">TiposTransporte Creado</response>
        /// <response code="400">TiposTransporte tiene valores invalidos </response>
        /// <response code="401">TiposTransporte No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear TiposTransporte en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] TiposTransporte obj)
            {
            try
                {
                var result = new TiposTransporteMs().Add(obj);
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }

        // PUT api/values/5
        /// <summary>
        /// CRUD de la entidad TiposTransporte --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Trayectos de la entidad  TiposTransporte!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de TiposTransporte</param>
        /// <response code="200">TiposTransporte Actualizado</response>
        /// <response code="400">TiposTransporte tiene valores invalidos </response>
        /// <response code="401">TiposTransporte No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar TiposTransporte en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] TiposTransporte obj)
            {
            try
                {
                var result = new TiposTransporteMs().Update(obj);
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }

        // DELETE api/values/5
        /// <summary>
        /// CRUD de la entidad TiposTransporte --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Trayectos de la entidad  TiposTransporte!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de TiposTransporte</param>
        /// <response code="200">TiposTransporte Eliminado</response>
        /// <response code="400">TiposTransporte tiene valores invalidos </response>
        /// <response code="401">TiposTransporte No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar TiposTransporte en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] TiposTransporte obj)
            {
            try
                {
                new TiposTransporteMs().Delete(obj);
                return Ok();
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad TiposTransporte --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  TiposTransporte!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de TiposTransporte</param>
        /// <response code="200">TiposTransporte Resultado</response>
        /// <response code="400">TiposTransporte tiene valores invalidos </response>
        /// <response code="401">TiposTransporte No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  TiposTransporte en este momento</response>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LoadTable([FromBody] DtParameters dtParameters)
            {
            var searchBy = dtParameters.Search?.Value;

            var orderCriteria = "TipoTransporteId";
            var orderAscendingDirection = true;

            try
                {

                if(dtParameters.Order != null)
                    {
                    // in this example we just default sort on the 1st column
                    orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                    orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
                    }

                var result = new TiposTransporteMs().GetAllByWithRelation().Cast<TiposTransporte>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                if(orderAscendingDirection)
                    {
                    if(orderCriteria == "TipoTransporteId") result = result.OrderBy(p => p.TipoTransporteId).Cast<TiposTransporte>().ToList();
                    if(orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast<TiposTransporte>().ToList();
                    }
                else
                    {
                    if(orderCriteria == "TipoTransporteId") result = result.OrderByDescending(p => p.TipoTransporteId).Cast<TiposTransporte>().ToList();
                    if(orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast<TiposTransporte>().ToList();
                    }
                var data = result.ToList();

                if(!string.IsNullOrEmpty(searchBy))
                    {
                    data = data.Where(
                                                            r => r.TipoTransporteId != null && r.TipoTransporteId.ToString().Contains(searchBy.ToUpper())
                 || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper())

                                            ).ToList();
                    }

                filteredResultsCount = data.Count();

                if(dtParameters.Length > 0)
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


                //for (int i = 0; i < data.Count; i++)
                //{
                //    data[i].sTIPOTRANSPORTEID = SISPAE.Common.Utilidades.Encrypt($"id={data[i].TipoTransporteId.ToString()}");

                //}

                return Ok(new
                    {
                    Draw = dtParameters.Draw,
                    RecordsTotal = totalResultsCount,
                    RecordsFiltered = filteredResultsCount,
                    Data = data
                    });
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }


        // GET api/GetAllRelation/
        /// <summary>
        /// CRUD de la entidad TiposTransporte --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Trayectos de la entidad  TiposTransporte!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de TiposTransporte</param>
        /// <response code="200">TiposTransporte Consulto los registros exitosamente</response>
        /// <response code="400">TiposTransporte tiene valores invalidos </response>
        /// <response code="401">TiposTransporte No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar TiposTransporte en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
            {
            try
                {
                var result = new TiposTransporteMs().GetAllByWithRelation().Cast<TiposTransporte>().AsQueryable();
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }


        }
    }
