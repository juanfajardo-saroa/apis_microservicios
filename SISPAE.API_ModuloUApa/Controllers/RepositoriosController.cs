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

namespace SISPAE_API_ModuloUApa.WebAPI.Controllers
    {
    [SwaggerTag("Web API para CRUD de Repositorios .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class RepositoriosController : ControllerBase
        {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Repositorios --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_ModuloUApa de la entidad  Repositorios!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Repositorios</param>
        /// <response code="200">Repositorios Consulto los registros exitosamente</response>
        /// <response code="400">Repositorios tiene valores invalidos </response>
        /// <response code="401">Repositorios No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Repositorios en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
            {
            try
                {
                var result = new RepositoriosMs().GetAll().Cast<Repositorios>().AsQueryable();
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Repositorios --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_ModuloUApa de la entidad  Repositorios!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Repositorios</param>
        /// <response code="200">Repositorios Consulto los registros exitosamente</response>
        /// <response code="400">Repositorios tiene valores invalidos </response>
        /// <response code="401">Repositorios No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Repositorios en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
            {
            try
                {
                var result = new RepositoriosMs().GetAllFull().Cast<Repositorios>().AsQueryable();
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }



        // GET api/values/5
        /// <summary>
        /// CRUD de la entidad Repositorios --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_ModuloUApa de la entidad  Repositorios!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Repositorios</param>
        /// <response code="200">Repositorios Consulto los registros exitosamente</response>
        /// <response code="400">Repositorios tiene valores invalidos </response>
        /// <response code="401">Repositorios No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Repositorios en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
            {
            try
                {
                var result = new RepositoriosMs().GetById(new Repositorios() { id = id });
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }



        // POST api/values
        /// <summary>
        /// CRUD de la entidad Repositorios --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_ModuloUApa de la entidad  Repositorios!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Repositorios</param>
        /// <response code="200">Repositorios Creado</response>
        /// <response code="400">Repositorios tiene valores invalidos </response>
        /// <response code="401">Repositorios No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Repositorios en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Repositorios obj)
            {
            try
                {
                var result = new RepositoriosMs().Add(obj);
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }

        // PUT api/values/5
        /// <summary>
        /// CRUD de la entidad Repositorios --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_ModuloUApa de la entidad  Repositorios!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Repositorios</param>
        /// <response code="200">Repositorios Actualizado</response>
        /// <response code="400">Repositorios tiene valores invalidos </response>
        /// <response code="401">Repositorios No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Repositorios en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Repositorios obj)
            {
            try
                {
                var result = new RepositoriosMs().Update(obj);
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }

        // DELETE api/values/5
        /// <summary>
        /// CRUD de la entidad Repositorios --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_ModuloUApa de la entidad  Repositorios!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Repositorios</param>
        /// <response code="200">Repositorios Eliminado</response>
        /// <response code="400">Repositorios tiene valores invalidos </response>
        /// <response code="401">Repositorios No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Repositorios en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Repositorios obj)
            {
            try
                {
                new RepositoriosMs().Delete(obj);
                return Ok();
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad Repositorios --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Repositorios!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Repositorios</param>
        /// <response code="200">Repositorios Resultado</response>
        /// <response code="400">Repositorios tiene valores invalidos </response>
        /// <response code="401">Repositorios No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Repositorios en este momento</response>
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

                var result = new RepositoriosMs().GetAllByWithRelation().Cast<Repositorios>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                if(orderAscendingDirection)
                    {
                    if(orderCriteria == "id") result = result.OrderBy(p => p.id).Cast<Repositorios>().ToList();
                    if(orderCriteria == "idTipoArchivo") result = result.OrderBy(p => p.idTipoArchivo).Cast<Repositorios>().ToList();
                    if(orderCriteria == "sID_TipoArchivo") result = result.OrderBy(p => p.sidTipoArchivo).Cast<Repositorios>().ToList();
                    if(orderCriteria == "idCategoria") result = result.OrderBy(p => p.idCategoria).Cast<Repositorios>().ToList();
                    if(orderCriteria == "sID_Categorias") result = result.OrderBy(p => p.sidCategoria).Cast<Repositorios>().ToList();
                    if(orderCriteria == "idVigencia") result = result.OrderBy(p => p.idVigencia).Cast<Repositorios>().ToList();
                    if(orderCriteria == "sID_Vigencias") result = result.OrderBy(p => p.sidVigencia).Cast<Repositorios>().ToList();
                    if(orderCriteria == "Nombre") result = result.OrderBy(p => p.Nombre).Cast<Repositorios>().ToList();
                    if(orderCriteria == "fechaArchivo") result = result.OrderBy(p => p.fechaArchivo).Cast<Repositorios>().ToList();
                    if(orderCriteria == "fechaCarga") result = result.OrderBy(p => p.fechaCarga).Cast<Repositorios>().ToList();
                    if(orderCriteria == "id_TipoModeloOperacion") result = result.OrderBy(p => p.id_TipoModeloOperacion).Cast<Repositorios>().ToList();
                    if(orderCriteria == "sID_TiposModeloOperacion") result = result.OrderBy(p => p.sidTipoModeloOperacion).Cast<Repositorios>().ToList();
                    if(orderCriteria == "NombreResolucion") result = result.OrderBy(p => p.NombreResolucion).Cast<Repositorios>().ToList();
                    if(orderCriteria == "tamanoArchivo") result = result.OrderBy(p => p.tamanoArchivo).Cast<Repositorios>().ToList();
                    }
                else
                    {
                    if(orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast<Repositorios>().ToList();
                    if(orderCriteria == "idTipoArchivo") result = result.OrderByDescending(p => p.idTipoArchivo).Cast<Repositorios>().ToList();
                    if(orderCriteria == "sID_TipoArchivo") result = result.OrderByDescending(p => p.sidTipoArchivo).Cast<Repositorios>().ToList();
                    if(orderCriteria == "idCategoria") result = result.OrderByDescending(p => p.idCategoria).Cast<Repositorios>().ToList();
                    if(orderCriteria == "sID_Categorias") result = result.OrderByDescending(p => p.sidCategoria).Cast<Repositorios>().ToList();
                    if(orderCriteria == "idVigencia") result = result.OrderByDescending(p => p.idVigencia).Cast<Repositorios>().ToList();
                    if(orderCriteria == "sID_Vigencias") result = result.OrderByDescending(p => p.sidVigencia).Cast<Repositorios>().ToList();
                    if(orderCriteria == "Nombre") result = result.OrderByDescending(p => p.Nombre).Cast<Repositorios>().ToList();
                    if(orderCriteria == "fechaArchivo") result = result.OrderByDescending(p => p.fechaArchivo).Cast<Repositorios>().ToList();
                    if(orderCriteria == "fechaCarga") result = result.OrderByDescending(p => p.fechaCarga).Cast<Repositorios>().ToList();
                    if(orderCriteria == "id_TipoModeloOperacion") result = result.OrderByDescending(p => p.id_TipoModeloOperacion).Cast<Repositorios>().ToList();
                    if(orderCriteria == "sID_TiposModeloOperacion") result = result.OrderByDescending(p => p.sidTipoModeloOperacion).Cast<Repositorios>().ToList();
                    if(orderCriteria == "NombreResolucion") result = result.OrderByDescending(p => p.NombreResolucion).Cast<Repositorios>().ToList();
                    if(orderCriteria == "tamanoArchivo") result = result.OrderByDescending(p => p.tamanoArchivo).Cast<Repositorios>().ToList();
                    }
                var data = result.ToList();

                if(!string.IsNullOrEmpty(searchBy))
                    {
                    data = data.Where(
                                                            r => r.id != null && r.id.ToString().Contains(searchBy.ToUpper())
                 || r.idTipoArchivo != null && r.idTipoArchivo.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.sidTipoArchivo != null && r.sidTipoArchivo.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.idCategoria != null && r.idCategoria.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.sidCategoria != null && r.sidCategoria.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.idVigencia != null && r.idVigencia.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.sidVigencia != null && r.sidVigencia.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.Nombre != null && r.Nombre.ToString().ToUpper().Contains(searchBy.ToUpper())
                     || r.fechaArchivo != null && r.fechaArchivo.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.fechaCarga != null && r.fechaCarga.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.id_TipoModeloOperacion != null && r.id_TipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.sidTipoModeloOperacion != null && r.sidTipoModeloOperacion.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.NombreResolucion != null && r.NombreResolucion.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.tamanoArchivo != null && r.tamanoArchivo.ToString().ToUpper().Contains(searchBy.ToUpper())

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
        /// CRUD de la entidad Repositorios --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_ModuloUApa de la entidad  Repositorios!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Repositorios</param>
        /// <response code="200">Repositorios Consulto los registros exitosamente</response>
        /// <response code="400">Repositorios tiene valores invalidos </response>
        /// <response code="401">Repositorios No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Repositorios en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
            {
            try
                {
                var result = new RepositoriosMs().GetAllByWithRelation().Cast<Repositorios>().AsQueryable();
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }


        }
    }
