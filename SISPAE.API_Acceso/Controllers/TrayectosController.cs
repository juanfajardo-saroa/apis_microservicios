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
    [SwaggerTag("Web API para CRUD de Trayectos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class TrayectosController : ControllerBase
        {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Trayectos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Trayectos de la entidad  Trayectos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Trayectos</param>
        /// <response code="200">Trayectos Consulto los registros exitosamente</response>
        /// <response code="400">Trayectos tiene valores invalidos </response>
        /// <response code="401">Trayectos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Trayectos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
            {
            try
                {
                var result = new TrayectosMs().GetAll().Cast<Trayectos>().AsQueryable();
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad Trayectos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Trayectos de la entidad  Trayectos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Trayectos</param>
        /// <response code="200">Trayectos Consulto los registros exitosamente</response>
        /// <response code="400">Trayectos tiene valores invalidos </response>
        /// <response code="401">Trayectos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Trayectos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
            {
            try
                {
                var result = new TrayectosMs().GetAllFull().Cast<Trayectos>().AsQueryable();
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }



        // GET api/values/5
        /// <summary>
        /// CRUD de la entidad Trayectos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Trayectos de la entidad  Trayectos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Trayectos</param>
        /// <response code="200">Trayectos Consulto los registros exitosamente</response>
        /// <response code="400">Trayectos tiene valores invalidos </response>
        /// <response code="401">Trayectos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar Trayectos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
            {
            try
                {
                var result = new TrayectosMs().GetById(new Trayectos() { TrayectoId = id });
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }



        // POST api/values
        /// <summary>
        /// CRUD de la entidad Trayectos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Trayectos de la entidad  Trayectos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de Trayectos</param>
        /// <response code="200">Trayectos Creado</response>
        /// <response code="400">Trayectos tiene valores invalidos </response>
        /// <response code="401">Trayectos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear Trayectos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Trayectos obj)
            {
            try
                {
                var result = new TrayectosMs().Add(obj);
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }

        // PUT api/values/5
        /// <summary>
        /// CRUD de la entidad Trayectos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Trayectos de la entidad  Trayectos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de Trayectos</param>
        /// <response code="200">Trayectos Actualizado</response>
        /// <response code="400">Trayectos tiene valores invalidos </response>
        /// <response code="401">Trayectos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar Trayectos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] Trayectos obj)
            {
            try
                {
                var result = new TrayectosMs().Update(obj);
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }

        // DELETE api/values/5
        /// <summary>
        /// CRUD de la entidad Trayectos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Trayectos de la entidad  Trayectos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de Trayectos</param>
        /// <response code="200">Trayectos Eliminado</response>
        /// <response code="400">Trayectos tiene valores invalidos </response>
        /// <response code="401">Trayectos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar Trayectos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] Trayectos obj)
            {
            try
                {
                new TrayectosMs().Delete(obj);
                return Ok();
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad Trayectos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  Trayectos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de Trayectos</param>
        /// <response code="200">Trayectos Resultado</response>
        /// <response code="400">Trayectos tiene valores invalidos </response>
        /// <response code="401">Trayectos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  Trayectos en este momento</response>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LoadTable([FromBody] DtParameters dtParameters)
            {
            var searchBy = dtParameters.Search?.Value;

            var orderCriteria = "TrayectoId";
            var orderAscendingDirection = true;

            try
                {

                if(dtParameters.Order != null)
                    {
                    // in this example we just default sort on the 1st column
                    orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                    orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
                    }

                var result = new TrayectosMs().GetAllByWithRelation().Cast<Trayectos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                if(orderAscendingDirection)
                    {
                    if(orderCriteria == "TrayectoId") result = result.OrderBy(p => p.TrayectoId).Cast<Trayectos>().ToList();
                    if(orderCriteria == "TipoTransporteId") result = result.OrderBy(p => p.TipoTransporteId).Cast<Trayectos>().ToList();
                    if(orderCriteria == "sID_TiposTransporte") result = result.OrderBy(p => p.sTipoTransporteId).Cast<Trayectos>().ToList();
                    if(orderCriteria == "MedioTransporteId") result = result.OrderBy(p => p.MedioTransporteId).Cast<Trayectos>().ToList();
                    if(orderCriteria == "sID_MedioTransporte") result = result.OrderBy(p => p.sMedioTransporteId).Cast<Trayectos>().ToList();
                    if(orderCriteria == "SedeId") result = result.OrderBy(p => p.SedeId).Cast<Trayectos>().ToList();
                    if(orderCriteria == "sID_Sedes") result = result.OrderBy(p => p.sSedeId).Cast<Trayectos>().ToList();
                    if(orderCriteria == "NumPosicion") result = result.OrderBy(p => p.NumPosicion).Cast<Trayectos>().ToList();
                    if(orderCriteria == "Costo") result = result.OrderBy(p => p.Costo).Cast<Trayectos>().ToList();
                    if(orderCriteria == "Kilometros") result = result.OrderBy(p => p.Kilometros).Cast<Trayectos>().ToList();
                    if(orderCriteria == "Horas") result = result.OrderBy(p => p.Horas).Cast<Trayectos>().ToList();
                    if(orderCriteria == "Destino") result = result.OrderBy(p => p.Destino).Cast<Trayectos>().ToList();
                    if(orderCriteria == "CabeceraMunicipal") result = result.OrderBy(p => p.CabeceraMunicipal).Cast<Trayectos>().ToList();
                    if(orderCriteria == "CentroAcopio") result = result.OrderBy(p => p.CentroAcopio).Cast<Trayectos>().ToList();
                    }
                else
                    {
                    if(orderCriteria == "TrayectoId") result = result.OrderByDescending(p => p.TrayectoId).Cast<Trayectos>().ToList();
                    if(orderCriteria == "TipoTransporteId") result = result.OrderByDescending(p => p.TipoTransporteId).Cast<Trayectos>().ToList();
                    if(orderCriteria == "sID_TiposTransporte") result = result.OrderByDescending(p => p.sTipoTransporteId).Cast<Trayectos>().ToList();
                    if(orderCriteria == "MedioTransporteId") result = result.OrderByDescending(p => p.MedioTransporteId).Cast<Trayectos>().ToList();
                    if(orderCriteria == "sID_MedioTransporte") result = result.OrderByDescending(p => p.sMedioTransporteId).Cast<Trayectos>().ToList();
                    if(orderCriteria == "SedeId") result = result.OrderByDescending(p => p.SedeId).Cast<Trayectos>().ToList();
                    if(orderCriteria == "sID_Sedes") result = result.OrderByDescending(p => p.sSedeId).Cast<Trayectos>().ToList();
                    if(orderCriteria == "NumPosicion") result = result.OrderByDescending(p => p.NumPosicion).Cast<Trayectos>().ToList();
                    if(orderCriteria == "Costo") result = result.OrderByDescending(p => p.Costo).Cast<Trayectos>().ToList();
                    if(orderCriteria == "Kilometros") result = result.OrderByDescending(p => p.Kilometros).Cast<Trayectos>().ToList();
                    if(orderCriteria == "Horas") result = result.OrderByDescending(p => p.Horas).Cast<Trayectos>().ToList();
                    if(orderCriteria == "Destino") result = result.OrderByDescending(p => p.Destino).Cast<Trayectos>().ToList();
                    if(orderCriteria == "CabeceraMunicipal") result = result.OrderByDescending(p => p.CabeceraMunicipal).Cast<Trayectos>().ToList();
                    if(orderCriteria == "CentroAcopio") result = result.OrderByDescending(p => p.CentroAcopio).Cast<Trayectos>().ToList();
                    }
                var data = result.ToList();

                if(!string.IsNullOrEmpty(searchBy))
                    {
                    data = data.Where(
                                                            r => r.TrayectoId != null && r.TrayectoId.ToString().Contains(searchBy.ToUpper())
                 || r.TipoTransporteId != null && r.TipoTransporteId.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.sTipoTransporteId != null && r.sTipoTransporteId.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.MedioTransporteId != null && r.MedioTransporteId.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.sMedioTransporteId != null && r.sMedioTransporteId.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.SedeId != null && r.SedeId.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.sSedeId != null && r.sSedeId.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.NumPosicion != null && r.NumPosicion.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.Costo != null && r.Costo.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.Kilometros != null && r.Kilometros.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.Horas != null && r.Horas.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.Destino != null && r.Destino.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.CabeceraMunicipal != null && r.CabeceraMunicipal.ToString().ToUpper().Contains(searchBy.ToUpper())
                 || r.CentroAcopio != null && r.CentroAcopio.ToString().ToUpper().Contains(searchBy.ToUpper())

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
                //    data[i].sTRAYECTOID = SISPAE.Common.Utilidades.Encrypt($"id={data[i].TrayectoId.ToString()}");

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
        /// CRUD de la entidad Trayectos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Trayectos de la entidad  Trayectos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de Trayectos</param>
        /// <response code="200">Trayectos Consulto los registros exitosamente</response>
        /// <response code="400">Trayectos tiene valores invalidos </response>
        /// <response code="401">Trayectos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar Trayectos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
            {
            try
                {
                var result = new TrayectosMs().GetAllByWithRelation().Cast<Trayectos>().AsQueryable();
                return Ok(result);
                }
            catch(System.Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }


        }
    }
