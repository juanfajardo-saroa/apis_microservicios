/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano				:2023
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
    [SwaggerTag("Web API para CRUD de DetallesSumComplementos .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class DetallesSumComplementosController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad DetallesSumComplementos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumComplementos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DetallesSumComplementos</param>
        /// <response code="200">DetallesSumComplementos Consulto los registros exitosamente</response>
        /// <response code="400">DetallesSumComplementos tiene valores invalidos </response>
        /// <response code="401">DetallesSumComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DetallesSumComplementos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new DetallesSumComplementosMs().GetAll().Cast<DetallesSumComplementos>().AsQueryable();
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
        /// CRUD de la entidad DetallesSumComplementos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumComplementos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DetallesSumComplementos</param>
        /// <response code="200">DetallesSumComplementos Consulto los registros exitosamente</response>
        /// <response code="400">DetallesSumComplementos tiene valores invalidos </response>
        /// <response code="401">DetallesSumComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DetallesSumComplementos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new DetallesSumComplementosMs().GetAllFull().Cast<DetallesSumComplementos>().AsQueryable();
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
        /// CRUD de la entidad DetallesSumComplementos --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumComplementos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DetallesSumComplementos</param>
        /// <response code="200">DetallesSumComplementos Consulto los registros exitosamente</response>
        /// <response code="400">DetallesSumComplementos tiene valores invalidos </response>
        /// <response code="401">DetallesSumComplementos No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar DetallesSumComplementos en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new DetallesSumComplementosMs().GetById(new DetallesSumComplementos() { id = id });
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
        /// CRUD de la entidad DetallesSumComplementos --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumComplementos!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de DetallesSumComplementos</param>
        /// <response code="200">DetallesSumComplementos Creado</response>
        /// <response code="400">DetallesSumComplementos tiene valores invalidos </response>
        /// <response code="401">DetallesSumComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear DetallesSumComplementos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] DetallesSumComplementos obj)
        {
            try
            {
                var result = new DetallesSumComplementosMs().Add(obj);
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
        /// CRUD de la entidad DetallesSumComplementos --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumComplementos!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de DetallesSumComplementos</param>
        /// <response code="200">DetallesSumComplementos Actualizado</response>
        /// <response code="400">DetallesSumComplementos tiene valores invalidos </response>
        /// <response code="401">DetallesSumComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar DetallesSumComplementos en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] DetallesSumComplementos obj)
        {
            try
            {
                var result = new DetallesSumComplementosMs().Update(obj);
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
        /// CRUD de la entidad DetallesSumComplementos --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumComplementos!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de DetallesSumComplementos</param>
        /// <response code="200">DetallesSumComplementos Eliminado</response>
        /// <response code="400">DetallesSumComplementos tiene valores invalidos </response>
        /// <response code="401">DetallesSumComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar DetallesSumComplementos en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] DetallesSumComplementos obj)
        {
           try
            {
                new DetallesSumComplementosMs().Delete(obj);
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
        /// DataTable de la entidad DetallesSumComplementos --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  DetallesSumComplementos!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de DetallesSumComplementos</param>
        /// <response code="200">DetallesSumComplementos Resultado</response>
        /// <response code="400">DetallesSumComplementos tiene valores invalidos </response>
        /// <response code="401">DetallesSumComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  DetallesSumComplementos en este momento</response>
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

                var result = new DetallesSumComplementosMs().GetAllByWithRelation().Cast<DetallesSumComplementos>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <DetallesSumComplementos>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderBy(p => p.ID_Contrato).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderBy(p => p.sID_Contrato).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "ID_TipoModelooperacion") result = result.OrderBy(p => p.ID_TipoModelooperacion).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderBy(p => p.sID_TipoModelooperacion).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "ID_TipoModalidadComplemento") result = result.OrderBy(p => p.ID_TipoModalidadComplemento).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "sID_TiposModalidadComplemento") result = result.OrderBy(p => p.sID_TipoModalidadComplemento).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "ID_TipoComplemento") result = result.OrderBy(p => p.ID_TipoComplemento).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderBy(p => p.sID_TipoComplemento).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "ID_Jornada") result = result.OrderBy(p => p.ID_Jornada).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "sID_Jornada") result = result.OrderBy(p => p.sID_Jornada).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "Complementos") result = result.OrderBy(p => p.Complementos).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "DiasSuministro") result = result.OrderBy(p => p.DiasSuministro).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "MesesSuministro") result = result.OrderBy(p => p.MesesSuministro).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "ContratoPAEC") result = result.OrderBy(p => p.ContratoPAEC).Cast <DetallesSumComplementos>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <DetallesSumComplementos>().ToList();  
                if (orderCriteria == "ID_Contrato") result = result.OrderByDescending(p => p.ID_Contrato).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderByDescending(p => p.sID_Contrato).Cast<DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "ID_TipoModelooperacion") result = result.OrderByDescending(p => p.ID_TipoModelooperacion).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "sID_TiposModeloOperacion") result = result.OrderByDescending(p => p.sID_TipoModelooperacion).Cast<DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "ID_TipoModalidadComplemento") result = result.OrderByDescending(p => p.ID_TipoModalidadComplemento).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "sID_TiposModalidadComplemento") result = result.OrderByDescending(p => p.sID_TipoModalidadComplemento).Cast<DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "ID_TipoComplemento") result = result.OrderByDescending(p => p.ID_TipoComplemento).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "sID_TiposComplemento") result = result.OrderByDescending(p => p.sID_TipoComplemento).Cast<DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "ID_Jornada") result = result.OrderByDescending(p => p.ID_Jornada).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "sID_Jornada") result = result.OrderByDescending(p => p.sID_Jornada).Cast<DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "Complementos") result = result.OrderByDescending(p => p.Complementos).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "DiasSuministro") result = result.OrderByDescending(p => p.DiasSuministro).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "MesesSuministro") result = result.OrderByDescending(p => p.MesesSuministro).Cast <DetallesSumComplementos>().ToList(); 
                 if (orderCriteria == "ContratoPAEC") result = result.OrderByDescending(p => p.ContratoPAEC).Cast <DetallesSumComplementos>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Contrato != null && r.ID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Contrato != null && r.sID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoModelooperacion != null && r.ID_TipoModelooperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoModelooperacion != null && r.sID_TipoModelooperacion.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoModalidadComplemento != null && r.ID_TipoModalidadComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoModalidadComplemento != null && r.sID_TipoModalidadComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_TipoComplemento != null && r.ID_TipoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_TipoComplemento != null && r.sID_TipoComplemento.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Jornada != null && r.ID_Jornada.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Jornada != null && r.sID_Jornada.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.Complementos != null && r.Complementos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.DiasSuministro != null && r.DiasSuministro.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.MesesSuministro != null && r.MesesSuministro.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ContratoPAEC != null && r.ContratoPAEC.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad DetallesSumComplementos --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  DetallesSumComplementos!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de DetallesSumComplementos</param>
        /// <response code="200">DetallesSumComplementos Consulto los registros exitosamente</response>
        /// <response code="400">DetallesSumComplementos tiene valores invalidos </response>
        /// <response code="401">DetallesSumComplementos No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar DetallesSumComplementos en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new DetallesSumComplementosMs().GetAllByWithRelation().Cast<DetallesSumComplementos>().AsQueryable();
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
