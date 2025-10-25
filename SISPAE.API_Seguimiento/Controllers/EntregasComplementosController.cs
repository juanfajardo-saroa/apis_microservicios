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

namespace SISPAE_API_Seguimiento.WebAPI.Controllers
    {
    [SwaggerTag("Web API para CRUD de EntregasComplementos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class EntregasComplementosController : ControllerBase
        {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad EntregasComplementos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  EntregasComplementos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de EntregasComplementos</param>
        /// <response code="200">EntregasComplementos Consulto los registros exitosamente</response>
        /// <response code="400">EntregasComplementos tiene valores invalidos </response>
        /// <response code="401">EntregasComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar EntregasComplementos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
            {
            try
                {
                var result = new EntregasComplementosMs().GetAll().Cast<EntregasComplementos>().AsQueryable();
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad EntregasComplementos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  EntregasComplementos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de EntregasComplementos</param>
        /// <response code="200">EntregasComplementos Consulto los registros exitosamente</response>
        /// <response code="400">EntregasComplementos tiene valores invalidos </response>
        /// <response code="401">EntregasComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar EntregasComplementos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
            {
            try
                {
                var result = new EntregasComplementosMs().GetAllFull().Cast<EntregasComplementos>().AsQueryable();
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }



        // GET api/values/5
        /// <summary>
        /// CRUD de la entidad EntregasComplementos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  EntregasComplementos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de EntregasComplementos</param>
        /// <response code="200">EntregasComplementos Consulto los registros exitosamente</response>
        /// <response code="400">EntregasComplementos tiene valores invalidos </response>
        /// <response code="401">EntregasComplementos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar EntregasComplementos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
            {
            try
                {
                var result = new EntregasComplementosMs().GetById(new EntregasComplementos() { id = id });
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }



        // POST api/values
        /// <summary>
        /// CRUD de la entidad EntregasComplementos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE de la entidad  EntregasComplementos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de EntregasComplementos</param>
        /// <response code="200">EntregasComplementos Creado</response>
        /// <response code="400">EntregasComplementos tiene valores invalidos </response>
        /// <response code="401">EntregasComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear EntregasComplementos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] EntregasComplementos obj)
            {
            try
                {
                var result = new EntregasComplementosMs().Add(obj);
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }

        // PUT api/values/5
        /// <summary>
        /// CRUD de la entidad EntregasComplementos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE de la entidad  EntregasComplementos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de EntregasComplementos</param>
        /// <response code="200">EntregasComplementos Actualizado</response>
        /// <response code="400">EntregasComplementos tiene valores invalidos </response>
        /// <response code="401">EntregasComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar EntregasComplementos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] EntregasComplementos obj)
            {
            try
                {
                var result = new EntregasComplementosMs().Update(obj);
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }

        // DELETE api/values/5
        /// <summary>
        /// CRUD de la entidad EntregasComplementos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE de la entidad  EntregasComplementos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de EntregasComplementos</param>
        /// <response code="200">EntregasComplementos Eliminado</response>
        /// <response code="400">EntregasComplementos tiene valores invalidos </response>
        /// <response code="401">EntregasComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar EntregasComplementos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] EntregasComplementos obj)
            {
            try
                {
                new EntregasComplementosMs().Delete(obj);
                return Ok();
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad EntregasComplementos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  EntregasComplementos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de EntregasComplementos</param>
        /// <response code="200">EntregasComplementos Resultado</response>
        /// <response code="400">EntregasComplementos tiene valores invalidos </response>
        /// <response code="401">EntregasComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  EntregasComplementos en este momento</response>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LoadTable([FromBody] DtParameters dtParameters)
            {
            var searchBy = dtParameters.Search?.Value;

            var orderCriteria = "id";
            var orderAscendingDirection = true;

            try
                {

                if(dtParameters.Order != null)
                    {
                    // in this example we just default sort on the 1st column
                    orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                    orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
                    }

                var result = new EntregasComplementosMs().GetAllByWithRelation().Cast<EntregasComplementos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                if(orderAscendingDirection)
                    {
                    if(orderCriteria == "id") result = result.OrderBy(p => p.id).Cast<EntregasComplementos>().ToList();
                    if(orderCriteria == "ID_SemanaEntregaComplemento") result = result.OrderBy(p => p.ID_SemanaEntregaComplemento).Cast<EntregasComplementos>().ToList();
                    if(orderCriteria == "sID_SemanaEntregaComplementos") result = result.OrderBy(p => p.sID_SemanaEntregaComplemento).Cast<EntregasComplementos>().ToList();
                    if(orderCriteria == "ID_TipoReporteEntrega") result = result.OrderBy(p => p.ID_TipoReporteEntrega).Cast<EntregasComplementos>().ToList();
                    if(orderCriteria == "sID_TiposReporteEntrega") result = result.OrderBy(p => p.sID_TipoReporteEntrega).Cast<EntregasComplementos>().ToList();
                    if(orderCriteria == "FechaEntrega") result = result.OrderBy(p => p.FechaEntrega).Cast<EntregasComplementos>().ToList();
                    if(orderCriteria == "ComplementosPreparadas") result = result.OrderBy(p => p.ComplementosPreparadas).Cast<EntregasComplementos>().ToList();
                    }
                else
                    {
                    if(orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast<EntregasComplementos>().ToList();
                    if(orderCriteria == "ID_SemanaEntregaComplemento") result = result.OrderByDescending(p => p.ID_SemanaEntregaComplemento).Cast<EntregasComplementos>().ToList();
                    if(orderCriteria == "sID_SemanaEntregaComplementos") result = result.OrderByDescending(p => p.sID_SemanaEntregaComplemento).Cast<EntregasComplementos>().ToList();
                    if(orderCriteria == "ID_TipoReporteEntrega") result = result.OrderByDescending(p => p.ID_TipoReporteEntrega).Cast<EntregasComplementos>().ToList();
                    if(orderCriteria == "sID_TiposReporteEntrega") result = result.OrderByDescending(p => p.sID_TipoReporteEntrega).Cast<EntregasComplementos>().ToList();
                    if(orderCriteria == "FechaEntrega") result = result.OrderByDescending(p => p.FechaEntrega).Cast<EntregasComplementos>().ToList();
                    if(orderCriteria == "ComplementosPreparadas") result = result.OrderByDescending(p => p.ComplementosPreparadas).Cast<EntregasComplementos>().ToList();
                    }
                var data = result.ToList();

                if(!string.IsNullOrEmpty(searchBy))
                    {
                    data = data.Where(
                                                            r => r.id != null && r.id.ToString().Contains(searchBy.ToUpper())
                 || r.ID_SemanaEntregaComplemento != null && r.ID_SemanaEntregaComplemento.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.sID_SemanaEntregaComplemento != null && r.sID_SemanaEntregaComplemento.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.ID_TipoReporteEntrega != null && r.ID_TipoReporteEntrega.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.sID_TipoReporteEntrega != null && r.sID_TipoReporteEntrega.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.FechaEntrega != null && r.FechaEntrega.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.ComplementosPreparadas != null && r.ComplementosPreparadas.ToString().ToUpper().Contains(searchBy.ToUpper())

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


                for(int i = 0; i < data.Count; i++)
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
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }


        // GET api/GetAllRelation/
        /// <summary>
        /// CRUD de la entidad EntregasComplementos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  EntregasComplementos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de EntregasComplementos</param>
        /// <response code="200">EntregasComplementos Consulto los registros exitosamente</response>
        /// <response code="400">EntregasComplementos tiene valores invalidos </response>
        /// <response code="401">EntregasComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar EntregasComplementos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
            {
            try
                {
                var result = new EntregasComplementosMs().GetAllByWithRelation().Cast<EntregasComplementos>().AsQueryable();
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }


        }
    }
