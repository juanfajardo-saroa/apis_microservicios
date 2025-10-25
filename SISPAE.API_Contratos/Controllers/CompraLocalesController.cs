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
    [SwaggerTag("Web API para CRUD de CompraLocales .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 
    public partial class CompraLocalesController : ControllerBase
    {


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad CompraLocales --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  CompraLocales!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de CompraLocales</param>
        /// <response code="200">CompraLocales Consulto los registros exitosamente</response>
        /// <response code="400">CompraLocales tiene valores invalidos </response>
        /// <response code="401">CompraLocales No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar CompraLocales en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var result = new CompraLocalesMs().GetAll().Cast<CompraLocales>().AsQueryable();
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
        /// CRUD de la entidad CompraLocales --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  CompraLocales!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de CompraLocales</param>
        /// <response code="200">CompraLocales Consulto los registros exitosamente</response>
        /// <response code="400">CompraLocales tiene valores invalidos </response>
        /// <response code="401">CompraLocales No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar CompraLocales en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new CompraLocalesMs().GetAllFull().Cast<CompraLocales>().AsQueryable();
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
        /// CRUD de la entidad CompraLocales --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  CompraLocales!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de CompraLocales</param>
        /// <response code="200">CompraLocales Consulto los registros exitosamente</response>
        /// <response code="400">CompraLocales tiene valores invalidos </response>
        /// <response code="401">CompraLocales No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar CompraLocales en este momento</response>
        [HttpGet("{id}")]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = new CompraLocalesMs().GetById(new CompraLocales() { id = id });
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
        /// CRUD de la entidad CompraLocales --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE_API_Contratos de la entidad  CompraLocales!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de CompraLocales</param>
        /// <response code="200">CompraLocales Creado</response>
        /// <response code="400">CompraLocales tiene valores invalidos </response>
        /// <response code="401">CompraLocales No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear CompraLocales en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] CompraLocales obj)
        {
            try
            {
                var result = new CompraLocalesMs().Add(obj);
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
        /// CRUD de la entidad CompraLocales --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE_API_Contratos de la entidad  CompraLocales!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de CompraLocales</param>
        /// <response code="200">CompraLocales Actualizado</response>
        /// <response code="400">CompraLocales tiene valores invalidos </response>
        /// <response code="401">CompraLocales No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar CompraLocales en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] CompraLocales obj)
        {
            try
            {
                var result = new CompraLocalesMs().Update(obj);
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
        /// CRUD de la entidad CompraLocales --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE_API_Contratos de la entidad  CompraLocales!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de CompraLocales</param>
        /// <response code="200">CompraLocales Eliminado</response>
        /// <response code="400">CompraLocales tiene valores invalidos </response>
        /// <response code="401">CompraLocales No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar CompraLocales en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] CompraLocales obj)
        {
           try
            {
                new CompraLocalesMs().Delete(obj);
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
        /// DataTable de la entidad CompraLocales --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  CompraLocales!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de CompraLocales</param>
        /// <response code="200">CompraLocales Resultado</response>
        /// <response code="400">CompraLocales tiene valores invalidos </response>
        /// <response code="401">CompraLocales No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  CompraLocales en este momento</response>
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

                var result = new CompraLocalesMs().GetAllByWithRelation().Cast<CompraLocales>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                                if (orderAscendingDirection) 
                { 
                if (orderCriteria =="id") result = result.OrderBy(p => p.id).Cast <CompraLocales>().ToList();  
                if (orderCriteria == "ID_Proveedor") result = result.OrderBy(p => p.ID_Proveedor).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "sID_Proveedores") result = result.OrderBy(p => p.sID_Proveedor).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "ID_Operador") result = result.OrderBy(p => p.ID_Operador).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "sID_Operadores") result = result.OrderBy(p => p.sID_Operador).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "ID_Contrato") result = result.OrderBy(p => p.ID_Contrato).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderBy(p => p.sID_Contrato).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "ID_AgrupacionMensual") result = result.OrderBy(p => p.ID_AgrupacionMensual).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "sID_AgrupacionesMensual") result = result.OrderBy(p => p.sID_AgrupacionMensual).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "TotalKg") result = result.OrderBy(p => p.TotalKg).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "TotalProductos") result = result.OrderBy(p => p.TotalProductos).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "ValorFactura") result = result.OrderBy(p => p.ValorFactura).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "FacturaPDFPATH") result = result.OrderBy(p => p.FacturaPDFPATH).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "CumpleCriterio") result = result.OrderBy(p => p.CumpleCriterio).Cast <CompraLocales>().ToList(); 
                   }
                else 
                {                if (orderCriteria == "id") result = result.OrderByDescending(p => p.id).Cast <CompraLocales>().ToList();  
                if (orderCriteria == "ID_Proveedor") result = result.OrderByDescending(p => p.ID_Proveedor).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "sID_Proveedores") result = result.OrderByDescending(p => p.sID_Proveedor).Cast<CompraLocales>().ToList(); 
                 if (orderCriteria == "ID_Operador") result = result.OrderByDescending(p => p.ID_Operador).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "sID_Operadores") result = result.OrderByDescending(p => p.sID_Operador).Cast<CompraLocales>().ToList(); 
                 if (orderCriteria == "ID_Contrato") result = result.OrderByDescending(p => p.ID_Contrato).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "sID_Contratos") result = result.OrderByDescending(p => p.sID_Contrato).Cast<CompraLocales>().ToList(); 
                 if (orderCriteria == "ID_AgrupacionMensual") result = result.OrderByDescending(p => p.ID_AgrupacionMensual).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "sID_AgrupacionesMensual") result = result.OrderByDescending(p => p.sID_AgrupacionMensual).Cast<CompraLocales>().ToList(); 
                 if (orderCriteria == "TotalKg") result = result.OrderByDescending(p => p.TotalKg).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "TotalProductos") result = result.OrderByDescending(p => p.TotalProductos).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "ValorFactura") result = result.OrderByDescending(p => p.ValorFactura).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "FacturaPDFPATH") result = result.OrderByDescending(p => p.FacturaPDFPATH).Cast <CompraLocales>().ToList(); 
                 if (orderCriteria == "CumpleCriterio") result = result.OrderByDescending(p => p.CumpleCriterio).Cast <CompraLocales>().ToList(); 
                   }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                            r=> r.id != null && r.id.ToString().Contains(searchBy.ToUpper())  
                 || r.ID_Proveedor != null && r.ID_Proveedor.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Proveedor != null && r.sID_Proveedor.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Operador != null && r.ID_Operador.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Operador != null && r.sID_Operador.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_Contrato != null && r.ID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_Contrato != null && r.sID_Contrato.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ID_AgrupacionMensual != null && r.ID_AgrupacionMensual.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.sID_AgrupacionMensual != null && r.sID_AgrupacionMensual.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TotalKg != null && r.TotalKg.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.TotalProductos != null && r.TotalProductos.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.ValorFactura != null && r.ValorFactura.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.FacturaPDFPATH != null && r.FacturaPDFPATH.ToString().ToUpper().Contains(searchBy.ToUpper()) 
                 || r.CumpleCriterio != null && r.CumpleCriterio.ToString().ToUpper().Contains(searchBy.ToUpper()) 
    
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
        /// CRUD de la entidad CompraLocales --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE_API_Contratos de la entidad  CompraLocales!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de CompraLocales</param>
        /// <response code="200">CompraLocales Consulto los registros exitosamente</response>
        /// <response code="400">CompraLocales tiene valores invalidos </response>
        /// <response code="401">CompraLocales No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar CompraLocales en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new CompraLocalesMs().GetAllByWithRelation().Cast<CompraLocales>().AsQueryable();
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
