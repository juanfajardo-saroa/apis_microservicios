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

namespace SISPAE_API_Contratos.WebAPI.Controllers
    {
    [SwaggerTag("Web API para CRUD de ContratosModelos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class ContratosModelosController : ControllerBase
        {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad ContratosModelos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  ContratosModelos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ContratosModelos</param>
        /// <response code="200">ContratosModelos Consulto los registros exitosamente</response>
        /// <response code="400">ContratosModelos tiene valores invalidos </response>
        /// <response code="401">ContratosModelos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ContratosModelos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
            {
            try
                {
                var result = new ContratosModelosMs().GetAll().Cast<ContratosModelos>().AsQueryable();
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad ContratosModelos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  ContratosModelos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ContratosModelos</param>
        /// <response code="200">ContratosModelos Consulto los registros exitosamente</response>
        /// <response code="400">ContratosModelos tiene valores invalidos </response>
        /// <response code="401">ContratosModelos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ContratosModelos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
            {
            try
                {
                var result = new ContratosModelosMs().GetAllFull().Cast<ContratosModelos>().AsQueryable();
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }



        // GET api/values/5
        /// <summary>
        /// CRUD de la entidad ContratosModelos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  ContratosModelos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ContratosModelos</param>
        /// <response code="200">ContratosModelos Consulto los registros exitosamente</response>
        /// <response code="400">ContratosModelos tiene valores invalidos </response>
        /// <response code="401">ContratosModelos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar ContratosModelos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
            {
            try
                {
                var result = new ContratosModelosMs().GetById(new ContratosModelos() { ContratoId = id });
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }



        // POST api/values
        /// <summary>
        /// CRUD de la entidad ContratosModelos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  ContratosModelos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de ContratosModelos</param>
        /// <response code="200">ContratosModelos Creado</response>
        /// <response code="400">ContratosModelos tiene valores invalidos </response>
        /// <response code="401">ContratosModelos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear ContratosModelos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] ContratosModelos obj)
            {
            try
                {
                var result = new ContratosModelosMs().Add(obj);
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }

        // PUT api/values/5
        /// <summary>
        /// CRUD de la entidad ContratosModelos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  ContratosModelos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de ContratosModelos</param>
        /// <response code="200">ContratosModelos Actualizado</response>
        /// <response code="400">ContratosModelos tiene valores invalidos </response>
        /// <response code="401">ContratosModelos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar ContratosModelos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] ContratosModelos obj)
            {
            try
                {
                var result = new ContratosModelosMs().Update(obj);
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }

        // DELETE api/values/5
        /// <summary>
        /// CRUD de la entidad ContratosModelos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  ContratosModelos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de ContratosModelos</param>
        /// <response code="200">ContratosModelos Eliminado</response>
        /// <response code="400">ContratosModelos tiene valores invalidos </response>
        /// <response code="401">ContratosModelos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar ContratosModelos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] ContratosModelos obj)
            {
            try
                {
                new ContratosModelosMs().Delete(obj);
                return Ok();
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad ContratosModelos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  ContratosModelos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de ContratosModelos</param>
        /// <response code="200">ContratosModelos Resultado</response>
        /// <response code="400">ContratosModelos tiene valores invalidos </response>
        /// <response code="401">ContratosModelos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  ContratosModelos en este momento</response>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LoadTable([FromBody] DtParameters dtParameters)
            {
            var searchBy = dtParameters.Search?.Value;

            var orderCriteria = "ContratoId";
            var orderAscendingDirection = true;

            try
                {

                if(dtParameters.Order != null)
                    {
                    // in this example we just default sort on the 1st column
                    orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                    orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
                    }

                var result = new ContratosModelosMs().GetAllByWithRelation().Cast<ContratosModelos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                if(orderAscendingDirection)
                    {
                    if(orderCriteria == "ContratoId") result = result.OrderBy(p => p.ContratoId).Cast<ContratosModelos>().ToList();
                    if(orderCriteria == "TipoModeloOperacionId") result = result.OrderBy(p => p.TipoModeloOperacionId).Cast<ContratosModelos>().ToList();
                    if(orderCriteria == "PreciosZona") result = result.OrderBy(p => p.PreciosZona).Cast<ContratosModelos>().ToList();
                    if(orderCriteria == "PreciosNivelEducativo") result = result.OrderBy(p => p.PreciosNivelEducativo).Cast<ContratosModelos>().ToList();
                    }
                else
                    {
                    if(orderCriteria == "ContratoId") result = result.OrderByDescending(p => p.ContratoId).Cast<ContratosModelos>().ToList();
                    if(orderCriteria == "TipoModeloOperacionId") result = result.OrderByDescending(p => p.TipoModeloOperacionId).Cast<ContratosModelos>().ToList();
                    if(orderCriteria == "PreciosZona") result = result.OrderByDescending(p => p.PreciosZona).Cast<ContratosModelos>().ToList();
                    if(orderCriteria == "PreciosNivelEducativo") result = result.OrderByDescending(p => p.PreciosNivelEducativo).Cast<ContratosModelos>().ToList();
                    }
                var data = result.ToList();

                if(!string.IsNullOrEmpty(searchBy))
                    {
                    data = data.Where(
                                                            r => r.ContratoId != null && r.ContratoId.ToString().Contains(searchBy.ToUpper())
                 || r.TipoModeloOperacionId != null && r.TipoModeloOperacionId.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.PreciosZona != null && r.PreciosZona.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.PreciosNivelEducativo != null && r.PreciosNivelEducativo.ToString().ToUpper().Contains(searchBy.ToUpper())

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
                //    data[i].sCONTRATOID = SISPAE.Common.Utilidades.Encrypt($"id={data[i].ContratoId.ToString()}");

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
        /// CRUD de la entidad ContratosModelos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  ContratosModelos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de ContratosModelos</param>
        /// <response code="200">ContratosModelos Consulto los registros exitosamente</response>
        /// <response code="400">ContratosModelos tiene valores invalidos </response>
        /// <response code="401">ContratosModelos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar ContratosModelos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
            {
            try
                {
                var result = new ContratosModelosMs().GetAllByWithRelation().Cast<ContratosModelos>().AsQueryable();
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }


        }
    }
