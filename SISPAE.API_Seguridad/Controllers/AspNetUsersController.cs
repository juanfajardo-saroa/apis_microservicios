/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano				:2022
/// Arquitectura	:Patron MVC ASP Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa			:WEBAPI (WEBAPI Entity Layer) - Capa WEB API (Source: MVC7_ControllersAPI_Base.cs)    
/// </Derechos_Reservados>


using ElmahCore;

using EmailService;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using ElmahCore;
using Microsoft.AspNetCore.WebUtilities;

using SISPAE.Business;
using SISPAE.Model;
using SISPAE.WebAPI.Model;

using Swashbuckle.AspNetCore.Annotations;

using System.IdentityModel.Tokens.Jwt;
using System.Text;




// create, index, delete, update , read
//  details, listall, 

namespace SISPAE.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de AspNetUsers .")]
    [Route("api/[controller]/[Action]")]
    [ApiController]

    public partial class AspNetUsersController : ControllerBase
    {

        private readonly UserManager<User> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly JwtHandler _jwtHandler;
        //private readonly ITokenService _tokenService;

        public AspNetUsersController(UserManager<User> userManager, IEmailSender emailSender, JwtHandler jwtHandler)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _jwtHandler = jwtHandler;
        }


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad AspNetUsers --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  AspNetUsers!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AspNetUsers</param>
        /// <response code="200">AspNetUsers Consulto los registros exitosamente</response>
        /// <response code="400">AspNetUsers tiene valores invalidos </response>
        /// <response code="401">AspNetUsers No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AspNetUsers en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                var u = new AspNetUsersMs().GetAll().Cast<AspNetUsers>().AsQueryable();
                //var ur= new AspNetUserRolesMs().GetAll().Cast<AspNetUserRoles>().AsQueryable();

                //var q =
                //    from u in new AspNetUsersMs().GetAll().Cast<AspNetUsers>().AsQueryable()
                //    join ur in new AspNetUserRolesMs().GetAll().Cast<AspNetUserRoles>().AsQueryable()
                //    on u.Id equals ur.UserId
                //    //where u.ID == "ddd"
                //    select new { u, ur.RoleId};

                //return Ok(q);
                return Ok(u);
            }
            catch (System.Exception ex)
            {
                HttpContext.RaiseError(new InvalidOperationException(ex.Message));
                return BadRequest(ex.Message);
            }
        }


        // GET api/values/
        /// <summary>
        /// CRUD de la entidad AspNetUsers --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  AspNetUsers!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AspNetUsers</param>
        /// <response code="200">AspNetUsers Consulto los registros exitosamente</response>
        /// <response code="400">AspNetUsers tiene valores invalidos </response>
        /// <response code="401">AspNetUsers No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AspNetUsers en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllFull()
        {
            try
            {
                var result = new AspNetUsersMs().GetAllFull().Cast<AspNetUsers>().AsQueryable();
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                ; HttpContext.RaiseError(new InvalidOperationException(ex.Message));
                return BadRequest(ex.Message);
            }
        }



        // GET api/values/5
        /// <summary>
        /// CRUD de la entidad AspNetUsers --> Consultar los registros con parametro de ID
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  AspNetUsers!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta o el ID
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AspNetUsers</param>
        /// <response code="200">AspNetUsers Consulto los registros exitosamente</response>
        /// <response code="400">AspNetUsers tiene valores invalidos </response>
        /// <response code="401">AspNetUsers No tiene permisos o el token es invalido o caducó </response>
        /// <response code="500">Oops! No puede consultar AspNetUsers en este momento</response>
        //[HttpGet("{id}")]
        //[EnableQuery()]
        //[Authorize]
        //public IActionResult GetById(int id)
        //{
        //    try
        //    {
        //        var result = new AspNetUsersMs().GetById(new AspNetUsers() { Id = id });
        //        return Ok(result);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        ;  HttpContext.RaiseError(new InvalidOperationException(ex.Message)); 
        //    }
        //}



        // POST api/values
        /// <summary>
        /// CRUD de la entidad AspNetUsers --> Crear un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite crear los registros existentes en SISPAE de la entidad  AspNetUsers!!</remarks>
        /// <example>Ejemplo Creación</example>
        /// <param name="id" example="123">el ID de AspNetUsers</param>
        /// <response code="200">AspNetUsers Creado</response>
        /// <response code="400">AspNetUsers tiene valores invalidos </response>
        /// <response code="401">AspNetUsers No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede crear AspNetUsers en este momento</response>
        [EnableQuery()]
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserDTO obj)
        {

            if (obj == null || !ModelState.IsValid)
            {
                return BadRequest(string.Join(" | ", ModelState.Values
                                            .SelectMany(v => v.Errors)
                                            .Select(e => e.ErrorMessage)));
            }

            List<AspNetRoles> lr = new AspNetRolesMs().GetAll().Cast<AspNetRoles>().Where(r => r.Id == obj.idRol).ToList();

            if (lr.Count() == 0)
            {
                return BadRequest("No existe el rol");
                HttpContext.RaiseError(new InvalidOperationException("No existe el rol"));
            }


            try
            {
                var user = new User
                {
                    UserName = obj.UserName,
                    Email = obj.Email.ToLower(),
                    id_TipoDocumentoIden = obj.id_TipoDocumentoIden,
                    DocumentoIden = obj.DocumentoIden,
                    PrimerApellido = obj.PrimerApellido,
                    PrimerNombre = obj.PrimerNombre,
                    PhoneNumber = obj.NumeroTelefono,
                    PasswordHash = obj.Password,

                    SegundoApellido = obj.SegundoApellido ?? "",
                    SegundoNombre = obj.SegundoNombre ?? "",
                    Cargo = obj.Cargo,
                    id_TipoActor = obj.id_TipoActor,
                    UbicacionBase = obj.UbicacionBase,
                    id_Ubicacion = obj.id_Ubicacion,
                    RespuestaSeguridad = obj.RespuestaSeguridad,
                    UsuarioAD = obj.UsuarioAD
                };

                //Buscamos el mail para saber si ya existe sin impotar el estado
                var c = await _userManager.FindByEmailAsync(obj.Email);

                //aca busca solo los activos
                var uExisAct = new AspNetUsersMs().GetAll().Cast<AspNetUsers>().Where(u => u.Email.Contains(obj.Email)).FirstOrDefault();

                Task<IdentityResult> userNew;

                //El mail existe y esta inactivo porque el getAll solo trae lo activo
                if ((c != null && c.Id != null) && (uExisAct == null))
                {

                    //Como el mail ya existe creamos uno como temporal
                    int atIndex = user.Email.IndexOf('@');
                    string emailPrefix = user.Email.Substring(0, atIndex);
                    string newEmail = emailPrefix + "temporal" + DateTime.Now.Millisecond + user.Email.Substring(atIndex);
                    user.Email = newEmail;
                    user.UserName = newEmail;
                    userNew = _userManager.CreateAsync(user, obj.Password);
                    IdentityResult resultNewUSer = await userNew;
                    if (resultNewUSer != null)
                    {
                        if (!resultNewUSer.Succeeded)
                        {
                            var errors = resultNewUSer.Errors.Select(e => e.Description);

                            return BadRequest(errors);
                        }
                    }
                    obj.Id = user.Id;


                    int iANT = c.Email.IndexOf('@');
                    string ePreANT = c.Email.Substring(0, iANT);
                    string newEANT = ePreANT + "Ant" + DateTime.Now.Millisecond + obj.Email.Substring(iANT);

                    await UpdateUserEmailAndUsernameAsync(c.Id, newEANT, newEANT);

                    await UpdateUserEmailAndUsernameAsync(obj.Id, obj.Email, obj.UserName);
                }
                else
                {
                    userNew = _userManager.CreateAsync(user, obj.Password);
                    // Espera a que la tarea se complete y obtén el resultado
                    IdentityResult result = await userNew;
                    if (result != null)
                    {
                        if (!result.Succeeded)
                        {
                            var errors = result.Errors.Select(e => e.Description);
                            return BadRequest(errors);
                        }
                        obj.Id = user.Id;
                    }
                }


                new AspNetUserRolesMs().Add(new AspNetUserRoles() { UserId = user.Id, RoleId = obj.idRol });
                if (!string.IsNullOrEmpty(obj.idRolTempo))
                {
                    new AspNetUserRolesMs().Add(new AspNetUserRoles() { UserId = user.Id, RoleId = obj.idRolTempo });
                }



                StringBuilder sb = new StringBuilder();
                sb.Append("<div>");
                sb.Append(" <div style='padding: 1px; border:#36c solid 1px; border-radius: 20px;'>");
                sb.Append("     <div class='text-center'>");
                // sb.Append($"         <img alt = 'homepage' src='data:image/jpeg;base64,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'");
                sb.Append("     </div>");
                sb.Append("     <div style = 'text-align: center;color: #36c; padding: 10px 5px;'>");
                sb.Append("         <strong> Bienvenido al ECOSISTEMA de información SIPAE<br>");
                sb.Append("             Su registro ha sido exitoso, a continuación está su usuario y contraseña:");
                sb.Append("         </strong>");
                sb.Append("     </div>");
                sb.Append("     <div style='text-align: center;color: #36c; padding: 10px 5px;'>");
                sb.Append($"     <div><strong> Usuario:</strong>{obj.DocumentoIden}</div>");
                sb.Append($"     <div><strong>Contraseña:</strong>{obj.Password}</div>");
                sb.Append("     </div>");
                sb.Append(" </div>");
                sb.Append(" <div style = 'text-align: center;color: #36c; padding: 10px 5px; font-size: 12px;'>");
                sb.Append("     <small> Este correo ha sido enviado a través del servicio automático de la Oficina Postal Electrónica. <br> Por favor no RESPONDER este correo. </small>");
                sb.Append(" </div>");
                sb.Append("</div>");

                string ast = "Respuesta solicitud creación usuario";

                var message = new Message(new string[] { user.Email }, ast, sb.ToString(), null);

                new EnvioCorreoMs().Add(new EnvioCorreo()
                { fecha = DateTime.Now, remitente = "smtp local", destinatario = user.Email, asunto = ast, cuerpo = sb.ToString(), status = "Insert User" });

                await _emailSender.SendEmailAsync(message);

                return Ok();

            }
            catch (System.Exception ex)
            {
                HttpContext.RaiseError(new InvalidOperationException(ex.Message));
                return BadRequest(ex.Message);
            }
        }

        private async Task<IdentityResult> UpdateUserEmailAndUsernameAsync(string userId, string newEmail, string newUsername)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "User not found" });
            }

            var emailUpdateResult = await _userManager.SetEmailAsync(user, newEmail);
            if (!emailUpdateResult.Succeeded)
            {
                return emailUpdateResult;
            }

            var usernameUpdateResult = await _userManager.SetUserNameAsync(user, newUsername);
            if (!usernameUpdateResult.Succeeded)
            {
                return usernameUpdateResult;
            }

            return IdentityResult.Success;
        }

        [HttpPut()]
        [Authorize]
        public IActionResult updateInactiveToActive([FromBody] ActivarDto obj)
        {
            if (obj == null || !ModelState.IsValid)
            {
                return BadRequest(string.Join(" | ", ModelState.Values
                                            .SelectMany(v => v.Errors)
                                            .Select(e => e.ErrorMessage)));
            }


            var result = new AspNetUsersMs().updateInactiveToActive(obj.Email);
            return Ok(result);

        }

        // PUT api/values/5
        /// <summary>
        /// CRUD de la entidad AspNetUsers --> Actuaiza un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite actualizar los registros existentes en SISPAE de la entidad  AspNetUsers!!</remarks>
        /// <example>Ejemplo Actualización</example>
        /// <param name="id" example="123">el ID de AspNetUsers</param>
        /// <response code="200">AspNetUsers Actualizado</response>
        /// <response code="400">AspNetUsers tiene valores invalidos </response>
        /// <response code="401">AspNetUsers No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede Actualizar AspNetUsers en este momento</response>        
        [HttpPut()]
        [Authorize]
        public IActionResult Put([FromBody] UserDTO obj)
        {
            try
            {
                if (obj == null || !ModelState.IsValid)
                {
                    return BadRequest(string.Join(" | ", ModelState.Values
                                                .SelectMany(v => v.Errors)
                                                .Select(e => e.ErrorMessage)));
                }

                var r = (AspNetUsers)new AspNetUsersMs().GetById(new AspNetUsers() { Id = obj.Id });

                r.UserName = r.Email != obj.Email ? obj.Email : r.Email;
                r.Email = r.Email != obj.Email ? obj.Email : r.Email;
                r.EmailConfirmed = true;
                r.NormalizedEmail = r.Email != obj.Email ? obj.Email : r.Email;
                r.NormalizedUserName = r.Email != obj.Email ? obj.Email : r.Email;

                r.PrimerNombre = r.PrimerNombre != obj.PrimerNombre ? obj.PrimerNombre : r.PrimerNombre;
                r.SegundoNombre = r.SegundoNombre != obj.SegundoNombre ? obj.SegundoNombre : r.SegundoNombre;
                r.PrimerApellido = r.PrimerApellido != obj.PrimerApellido ? obj.PrimerApellido : r.PrimerApellido;
                r.SegundoApellido = r.SegundoApellido != obj.SegundoApellido ? obj.SegundoApellido : r.SegundoApellido;
                r.PhoneNumber = r.PhoneNumber != obj.NumeroTelefono ? obj.NumeroTelefono : r.PhoneNumber;
                r.Cargo = r.Cargo != obj.Cargo ? obj.Cargo : r.Cargo;
                r.RespuestaSeguridad = r.RespuestaSeguridad != obj.RespuestaSeguridad ? obj.RespuestaSeguridad : r.RespuestaSeguridad;
                r.UsuarioAD = r.UsuarioAD != obj.UsuarioAD ? obj.UsuarioAD : r.UsuarioAD;
                r.PhotoPath = r.PhotoPath != obj.PhotoPath ? obj.PhotoPath : r.PhotoPath;
                r.id_Ubicacion = r.id_Ubicacion != obj.id_Ubicacion ? obj.id_Ubicacion : r.id_Ubicacion;
                r.UbicacionBase = r.UbicacionBase != obj.UbicacionBase ? obj.UbicacionBase : r.UbicacionBase;
                r.id_TipoActor = r.id_TipoActor != obj.id_TipoActor ? obj.id_TipoActor : r.id_TipoActor;
                r.sid_TipoActor = r.sid_TipoActor != obj.sid_TipoActor ? obj.sid_TipoActor : r.sid_TipoActor; ;
                r.DocumentoIden = r.DocumentoIden != obj.DocumentoIden ? obj.DocumentoIden : r.DocumentoIden;
                r.id_TipoDocumentoIden = r.id_TipoDocumentoIden != obj.id_TipoDocumentoIden ? obj.id_TipoDocumentoIden : r.id_TipoDocumentoIden;


                var result = new AspNetUsersMs().Update(r);


                new AspNetUserRolesMs().Update(new AspNetUserRoles() { UserId = obj.Id, RoleId = obj.idRol, id = obj.idAspNetUserRolesBase });



                if (!string.IsNullOrEmpty(obj.idRolTempo))
                {
                    if (obj.idAspNetUserRolesTempo != null && obj.idAspNetUserRolesTempo > 0)
                    {
                        new AspNetUserRolesMs().Update(new AspNetUserRoles() { UserId = obj.Id, RoleId = obj.idRolTempo, id = obj.idAspNetUserRolesTempo.Value });
                    }
                    else
                    {
                        new AspNetUserRolesMs().Add(new AspNetUserRoles() { UserId = obj.Id, RoleId = obj.idRolTempo, id = obj.idAspNetUserRolesTempo.Value });
                    }

                }

                return Ok(result);
            }
            catch (System.Exception ex)
            {
                ;
                HttpContext.RaiseError(new InvalidOperationException(ex.Message));
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/values/5
        /// <summary>
        /// CRUD de la entidad AspNetUsers --> Eliminar un registro 
        /// </summary>
        /// <remarks>Esta WebAPI permite eliminar los registros existentes en SISPAE de la entidad  AspNetUsers!!</remarks>
        /// <example>Ejemplo Eliminar</example>
        /// <param name="id" example="123">el ID de AspNetUsers</param>
        /// <response code="200">AspNetUsers Eliminado</response>
        /// <response code="400">AspNetUsers tiene valores invalidos </response>
        /// <response code="401">AspNetUsers No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede eliminar AspNetUsers en este momento</response>
        [HttpPost]
        [Authorize]
        public IActionResult Delete([FromBody] string id)
        {
            try
            {

                var o = new AspNetUsersMs().GetById(new AspNetUsers() { Id = id });
                ; new AspNetUsersMs().Delete(o);
                return Ok();
            }
            catch (System.Exception ex)
            {
                ; HttpContext.RaiseError(new InvalidOperationException(ex.Message));
                return BadRequest(ex.Message);
            }
        }




        // POST: api/TP_Proceso/LoadTable
        /// <summary>
        /// DataTable de la entidad AspNetUsers --> Cargue de regsitros
        /// </summary>
        /// <remarks>Esta WebAPI permite es soporte poara la Ejecución de los DataTables del Objeto  AspNetUsers!!</remarks>
        /// <remarks>la función LoadTable con la etiqueta HttPost y que recibe un objeto DtParameters, lo primero que se configura es si tiene alguna valor en búsqueda y el orden</remarks>
        /// <example>Ejemplo Buscar en todo el Datatable</example>
        /// <param name="dtParameters" example="Objeto_JSON"> los datos de AspNetUsers</param>
        /// <response code="200">AspNetUsers Resultado</response>
        /// <response code="400">AspNetUsers tiene valores invalidos </response>
        /// <response code="401">AspNetUsers No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede dar rersulktados el objeto  AspNetUsers en este momento</response>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LoadTable([FromBody] DtParameters dtParameters)
        {
            var searchBy = dtParameters.Search?.Value;

            var orderCriteria = "Id";
            var orderAscendingDirection = true;

            try
            {

                if (dtParameters.Order != null)
                {
                    // in this example we just default sort on the 1st column
                    orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
                    orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == "asc";
                }
                var result = new AspNetUsersMs().GetAllByWithRelation().Cast<AspNetUsers>().ToList();

                var filteredResultsCount = result.Count();
                var totalResultsCount = result.Count();

                if (orderAscendingDirection)
                {
                    if (orderCriteria == "Id") result = result.OrderBy(p => p.Id).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "UserName") result = result.OrderBy(p => p.UserName).Cast<AspNetUsers>().ToList();

                    //if (orderCriteria == "NormalizedUserName") result = result.OrderBy(p => p.NormalizedUserName).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "Email") result = result.OrderBy(p => p.Email).Cast<AspNetUsers>().ToList();
                    // if (orderCriteria == "NormalizedEmail") result = result.OrderBy(p => p.NormalizedEmail).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "EmailConfirmed") result = result.OrderBy(p => p.EmailConfirmed).Cast<AspNetUsers>().ToList();
                    // if (orderCriteria == "PasswordHash") result = result.OrderBy(p => p.PasswordHash).Cast<AspNetUsers>().ToList();
                    // if (orderCriteria == "SecurityStamp") result = result.OrderBy(p => p.SecurityStamp).Cast<AspNetUsers>().ToList();
                    // if (orderCriteria == "ConcurrencyStamp") result = result.OrderBy(p => p.ConcurrencyStamp).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "PhoneNumber") result = result.OrderBy(p => p.PhoneNumber).Cast<AspNetUsers>().ToList();
                    // if (orderCriteria == "PhoneNumberConfirmed") result = result.OrderBy(p => p.PhoneNumberConfirmed).Cast<AspNetUsers>().ToList();
                    // if (orderCriteria == "TwoFactorEnabled") result = result.OrderBy(p => p.TwoFactorEnabled).Cast<AspNetUsers>().ToList();
                    //if (orderCriteria == "LockoutEnd") result = result.OrderBy(p => p.LockoutEnd).Cast<AspNetUsers>().ToList();
                    //if (orderCriteria == "LockoutEnabled") result = result.OrderBy(p => p.LockoutEnabled).Cast<AspNetUsers>().ToList();
                    //if (orderCriteria == "AccessFailedCount") result = result.OrderBy(p => p.AccessFailedCount).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "PrimerNombre") result = result.OrderBy(p => p.PrimerNombre).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "SegundoNombre") result = result.OrderBy(p => p.SegundoNombre).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "PrimerApellido") result = result.OrderBy(p => p.PrimerApellido).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "SegundoApellido") result = result.OrderBy(p => p.SegundoApellido).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "Cargo") result = result.OrderBy(p => p.Cargo).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "RespuestaSeguridad") result = result.OrderBy(p => p.RespuestaSeguridad).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "UsuarioAD") result = result.OrderBy(p => p.UsuarioAD).Cast<AspNetUsers>().ToList();
                    //if (orderCriteria == "GUID") result = result.OrderBy(p => p.GUID).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "FechaCreacion") result = result.OrderBy(p => p.FechaCreacion).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "id_Ubicacion") result = result.OrderBy(p => p.id_Ubicacion).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "UbicacionBase") result = result.OrderBy(p => p.UbicacionBase).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "id_TipoActor") result = result.OrderBy(p => p.id_TipoActor).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "sID_TipoActor") result = result.OrderBy(p => p.sid_TipoActor).Cast<AspNetUsers>().ToList();
                }
                else
                {
                    if (orderCriteria == "Id") result = result.OrderByDescending(p => p.Id).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "UserName") result = result.OrderByDescending(p => p.UserName).Cast<AspNetUsers>().ToList();

                    //if (orderCriteria == "NormalizedUserName") result = result.OrderByDescending(p => p.NormalizedUserName).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "Email") result = result.OrderByDescending(p => p.Email).Cast<AspNetUsers>().ToList();
                    //if (orderCriteria == "NormalizedEmail") result = result.OrderByDescending(p => p.NormalizedEmail).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "EmailConfirmed") result = result.OrderByDescending(p => p.EmailConfirmed).Cast<AspNetUsers>().ToList();
                    //if (orderCriteria == "PasswordHash") result = result.OrderByDescending(p => p.PasswordHash).Cast<AspNetUsers>().ToList();
                    //if (orderCriteria == "SecurityStamp") result = result.OrderByDescending(p => p.SecurityStamp).Cast<AspNetUsers>().ToList();
                    //if (orderCriteria == "ConcurrencyStamp") result = result.OrderByDescending(p => p.ConcurrencyStamp).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "PhoneNumber") result = result.OrderByDescending(p => p.PhoneNumber).Cast<AspNetUsers>().ToList();
                    //if (orderCriteria == "PhoneNumberConfirmed") result = result.OrderByDescending(p => p.PhoneNumberConfirmed).Cast<AspNetUsers>().ToList();
                    //if (orderCriteria == "TwoFactorEnabled") result = result.OrderByDescending(p => p.TwoFactorEnabled).Cast<AspNetUsers>().ToList();
                    //if (orderCriteria == "LockoutEnd") result = result.OrderByDescending(p => p.LockoutEnd).Cast<AspNetUsers>().ToList();
                    //if (orderCriteria == "LockoutEnabled") result = result.OrderByDescending(p => p.LockoutEnabled).Cast<AspNetUsers>().ToList();
                    //if (orderCriteria == "AccessFailedCount") result = result.OrderByDescending(p => p.AccessFailedCount).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "PrimerNombre") result = result.OrderByDescending(p => p.PrimerNombre).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "SegundoNombre") result = result.OrderByDescending(p => p.SegundoNombre).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "PrimerApellido") result = result.OrderByDescending(p => p.PrimerApellido).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "SegundoApellido") result = result.OrderByDescending(p => p.SegundoApellido).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "Cargo") result = result.OrderByDescending(p => p.Cargo).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "RespuestaSeguridad") result = result.OrderByDescending(p => p.RespuestaSeguridad).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "UsuarioAD") result = result.OrderByDescending(p => p.UsuarioAD).Cast<AspNetUsers>().ToList();
                    //if (orderCriteria == "GUID") result = result.OrderByDescending(p => p.GUID).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "FechaCreacion") result = result.OrderByDescending(p => p.FechaCreacion).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "id_Ubicacion") result = result.OrderByDescending(p => p.id_Ubicacion).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "UbicacionBase") result = result.OrderByDescending(p => p.UbicacionBase).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "id_TipoActor") result = result.OrderByDescending(p => p.id_TipoActor).Cast<AspNetUsers>().ToList();
                    if (orderCriteria == "sID_TipoActor") result = result.OrderByDescending(p => p.sid_TipoActor).Cast<AspNetUsers>().ToList();
                }
                var data = result.ToList();

                if (!string.IsNullOrEmpty(searchBy))
                {
                    data = data.Where(
                                                              r => r.Id != null && r.Id.ToString().Contains(searchBy.ToUpper())
                   || r.UserName != null && r.UserName.ToString().ToUpper().Contains(searchBy.ToUpper())

                   // || r.NormalizedUserName != null && r.NormalizedUserName.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.Email != null && r.Email.ToString().ToUpper().Contains(searchBy.ToUpper())
                   //|| r.NormalizedEmail != null && r.NormalizedEmail.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.EmailConfirmed != null && r.EmailConfirmed.ToString().ToUpper().Contains(searchBy.ToUpper())
                   //|| r.PasswordHash != null && r.PasswordHash.ToString().ToUpper().Contains(searchBy.ToUpper())
                   //|| r.SecurityStamp != null && r.SecurityStamp.ToString().ToUpper().Contains(searchBy.ToUpper())
                   //|| r.ConcurrencyStamp != null && r.ConcurrencyStamp.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.PhoneNumber != null && r.PhoneNumber.ToString().ToUpper().Contains(searchBy.ToUpper())
                   //|| r.PhoneNumberConfirmed != null && r.PhoneNumberConfirmed.ToString().ToUpper().Contains(searchBy.ToUpper())
                   //|| r.TwoFactorEnabled != null && r.TwoFactorEnabled.ToString().ToUpper().Contains(searchBy.ToUpper())
                   //|| r.LockoutEnd != null && r.LockoutEnd.ToString().ToUpper().Contains(searchBy.ToUpper())
                   //|| r.LockoutEnabled != null && r.LockoutEnabled.ToString().ToUpper().Contains(searchBy.ToUpper())
                   //|| r.AccessFailedCount != null && r.AccessFailedCount.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.PrimerNombre != null && r.PrimerNombre.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.SegundoNombre != null && r.SegundoNombre.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.PrimerApellido != null && r.PrimerApellido.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.SegundoApellido != null && r.SegundoApellido.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.Cargo != null && r.Cargo.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.RespuestaSeguridad != null && r.RespuestaSeguridad.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.UsuarioAD != null && r.UsuarioAD.ToString().ToUpper().Contains(searchBy.ToUpper())
                     //|| r.GUID != null && r.GUID.ToString().ToUpper().Contains(searchBy.ToUpper())
                     //  || r.FechaCreacion != null && r.FechaCreacion.ToString().ToUpper().Contains(searchBy.ToUpper())
                     || r.id_Ubicacion != null && r.id_Ubicacion.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.UbicacionBase != null && r.UbicacionBase.ToString().ToUpper().Contains(searchBy.ToUpper())
                   || r.id_TipoActor != null && r.id_TipoActor.ToString().ToUpper().Contains(searchBy.ToUpper())
                  || r.sid_TipoActor != null && r.sid_TipoActor.ToString().ToUpper().Contains(searchBy.ToUpper())

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

                // jcb no tiene id
                //for (int i = 0; i < data.Count; i++)
                //{
                //    data[i].sID = SISPAE.Common.Utilidades.Encrypt($"id={data[i].Id.ToString()}");
                //}

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
                ; HttpContext.RaiseError(new InvalidOperationException(ex.Message));
                return BadRequest(ex.Message);
            }
        }


        // GET api/GetAllRelation/
        /// <summary>
        /// CRUD de la entidad AspNetUsers --> Consultar los registros 
        /// </summary>
        /// <remarks>
        /// Esta WebAPI permite consultar los registros existentes en SISPAE de la entidad  AspNetUsers!
        /// Puede usar los métodos de filtrado de Odata Query para su consulta 
        /// !</remarks>
        /// <example>Ejemplo Consulta</example>
        /// <param name="id" example="123">el ID de AspNetUsers</param>
        /// <response code="200">AspNetUsers Consulto los registros exitosamente</response>
        /// <response code="400">AspNetUsers tiene valores invalidos </response>
        /// <response code="401">AspNetUsers No tiene permisos o el token es invalido o caducó </response>        
        /// <response code="500">Oops! No puede consultar AspNetUsers en este momento</response>
        [HttpGet()]
        [EnableQuery()]
        [Authorize]
        public IActionResult GetAllRelation()
        {
            try
            {
                var result = new AspNetUsersMs().GetAllByWithRelation().Cast<AspNetUsers>().AsQueryable();
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                ;
                HttpContext.RaiseError(new InvalidOperationException(ex.Message));
                return BadRequest(ex.Message);
            }
        }



        [HttpPost()]
        [EnableQuery()]
        //[Authorize]   //
        public async Task<IActionResult> Login([FromBody] UserForAuthenticationDto userForAuthentication)
        {

            //HttpContext.RaiseError(new InvalidOperationException("Test"));
            try
            {

                var u = new AspNetUsersMs().GetAll().Cast<AspNetUsers>()
                    .Where(r => r.id_TipoDocumentoIden == userForAuthentication.TipoDocumento && r.DocumentoIden == userForAuthentication.Documento).ToList();

                if (u.Count() == 0)
                {
                    return Unauthorized(new AuthResponseDto { ErrorMessage = "Invalid Authentication" });
                }
                else
                {

                    var user = await _userManager.FindByNameAsync(u.First().Email);

                    RegistroIngreso ri = new RegistroIngreso();
                    ri.Aplicacion = "PAE";
                    ri.Fecha = DateTime.Now;
                    ri.Direccionip = "";
                    ri.HostNameUsuario = "";
                    ri.IPDetrasProxy = "";
                    ri.Browser = "";
                    ri.auditoria = "PAE";
                    ri.UserId = user.Id;


                    if (user == null || !await _userManager.CheckPasswordAsync(user, userForAuthentication.Password))
                    {

                        ri.Accion = $"Ingreso Fallido - usuario o password invalido";
                        new RegistroIngresoMs().Add(ri);
                        return Unauthorized(new AuthResponseDto { ErrorMessage = "Invalid Authentication" });
                    }


                    var signingCredentials = _jwtHandler.GetSigningCredentials();
                    var claims = _jwtHandler.GetClaims(user);
                    var tokenOptions = _jwtHandler.GenerateTokenOptions(signingCredentials, claims);
                    var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

                    var refreshToken = _jwtHandler.GenerateRefreshToken();


                    ri.Accion = "Ingreso al Sistema";
                    new RegistroIngresoMs().Add(ri);

                    return Ok(new AuthResponseDto { IsAuthSuccessful = true, Token = token, RefreshToken = refreshToken });
                }
            }
            catch (Exception ex)
            {
                ;
                HttpContext.RaiseError(new InvalidOperationException(ex.Message));
                return BadRequest(ex.Message);
            }
        }

        [HttpPost()]
        [Authorize]
        public async Task<IActionResult> LogOut([FromBody] string id)
        {

            RegistroIngreso ri = new RegistroIngreso();

            ri.Aplicacion = "PAE";
            ri.UserId = id;
            ri.Fecha = DateTime.Now;
            ri.Direccionip = "";
            ri.HostNameUsuario = "";
            ri.IPDetrasProxy = "";
            ri.Browser = "";
            ri.auditoria = "PAE";

            ri.Accion = "Cierre del Sistema";
            new RegistroIngresoMs().Add(ri);
            return Ok();
        }


        [HttpPost()]
        [EnableQuery()]
        //[Authorize]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDto forgotPasswordDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                var user = await _userManager.FindByEmailAsync(forgotPasswordDto.Email);

                if (user == null)
                {
                    Response.StatusCode = 400;
                    //return BadRequest("Usuario no existe");
                    return Ok(new AuthResponseDto { IsAuthSuccessful = false, ErrorMessage = "No se encontro el usuario" });
                }

                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var param = new Dictionary<string, string> { { "token", token }, { "email", forgotPasswordDto.Email } };

                string ast = "Restablecer contraseña";


                forgotPasswordDto.ClientURI = forgotPasswordDto.ClientURI.Replace("#", "|");
                var callback = QueryHelpers.AddQueryString(forgotPasswordDto.ClientURI, param);
                callback = callback.Replace("|", "#");

                //var callback = forgotPasswordDto.ClientURI + "?token=" + token + "&email=" + forgotPasswordDto.Email;


                StringBuilder sb = new StringBuilder();
                sb.Append("<div>");
                sb.Append("<div style='padding: 1px; border:#36c solid 1px; border-radius: 20px;'>");
                sb.Append("<div class='text-center'>");
                //sb.Append($"         <img alt = 'homepage' src='data:image/jpeg;base64,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'");
                sb.Append("</div>");
                sb.Append("<div style='text-align: center;color: #36c; padding: 10px 5px;'>");
                sb.Append("<strong> Bienvenido(a) al ECOSISTEMA de información SIPAE<br>");
                sb.Append("A continuación ingrese al siguiente link para restablecer su contraseña:");
                sb.Append("</strong>");
                sb.Append("</div>");
                sb.Append("<div style='text-align: center;color: #36c; padding: 10px 5px;'>");
                sb.Append($"<div><a href= '{callback}' style= 'color: #47B9A4;'><strong> Link para cambio de contraseña</strong></a> </div>");
                sb.Append("</div>");
                sb.Append("</div>");
                sb.Append("<div style='text-align: center;color: #36c; padding: 10px 5px; font-size: 12px;'>");
                sb.Append("<small> Este correo ha sido enviado a través del servicio Automático de la Oficina Postal Electrónica. <br> Por favor no RESPONDER este correo. </small>");
                sb.Append("</div>");
                sb.Append("</div>");

                var message = new Message(new string[] { user.Email }, ast, sb.ToString(), null);


                await _emailSender.SendEmailAsync(message);

                new EnvioCorreoMs().Add(new EnvioCorreo()
                { fecha = DateTime.Now, remitente = "smtp local", destinatario = forgotPasswordDto.Email, asunto = ast, cuerpo = sb.ToString(), status = "" });

                return Ok();
            }
            catch (Exception ex)
            {

                ;
                HttpContext.RaiseError(new InvalidOperationException(ex.Message));
                return BadRequest(ex.Message);
            }
        }



        [HttpPost()]
        [EnableQuery()]
        //[Authorize]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDto resetPasswordDto)
        {

            if (!ModelState.IsValid)
                return BadRequest();

            try
            {

                var user = await _userManager.FindByEmailAsync(resetPasswordDto.Email);
                if (user == null)
                    return BadRequest("Invalid Request");
                var resetPassResult = await _userManager.ResetPasswordAsync(user, resetPasswordDto.Token, resetPasswordDto.Password);

                if (!resetPassResult.Succeeded)
                {
                    var errors = resetPassResult.Errors.Select(e => e.Description);
                    return BadRequest(new { Errors = errors });
                }
                return Ok();
            }
            catch (Exception ex)
            {
                HttpContext.RaiseError(new InvalidOperationException(ex.Message));
                return BadRequest(ex.Message);
            }
        }





        //[HttpPost]
        //[Route("refresh")]
        //public IActionResult Refresh(TokenApiModel tokenApiModel)
        //{
        //    if (tokenApiModel is null)
        //        return BadRequest("Invalid client request");
        //    string accessToken = tokenApiModel.AccessToken;
        //    string refreshToken = tokenApiModel.RefreshToken;
        //    var principal = _jwtHandler.GetPrincipalFromExpiredToken(accessToken);
        //    var username = principal.Identity.Name; //this is mapped to the Name claim by default

        //    //var user = _userContext.LoginModels.SingleOrDefault(u => u.UserName == username);

        //    var user = new AspNetUsersMs().GetAll().Cast<AspNetUsers>()
        //      .Where(r => r.id_TipoDocumentoIden == userForAuthentication.TipoDocumento && r.DocumentoIden == userForAuthentication.Documento).ToList();


        //    if (user is null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
        //        return BadRequest("Invalid client request");

        //    var newAccessToken = _jwtHandler.GenerateAccessToken(principal.Claims);
        //    var newRefreshToken = _jwtHandler.GenerateRefreshToken();

        //    user.RefreshToken = newRefreshToken;

        //    //_userContext.SaveChanges();
        //    //return Ok(new AuthenticatedResponse()
        //    //{
        //    //    Token = newAccessToken,
        //    //    RefreshToken = newRefreshToken
        //    //});

        //    return Ok(new AuthResponseDto { IsAuthSuccessful = true, Token = newAccessToken, RefreshToken = refreshToken });

        //}

        //[HttpPost, Authorize]
        //[Route("revoke")]
        //public IActionResult Revoke()
        //{
        //    var username = User.Identity.Name;
        //    var user = _userManager.LoginModels.SingleOrDefault(u => u.UserName == username);
        //    if (user == null) return BadRequest();
        //    user.RefreshToken = null;
        //    _userManager.SaveChanges();
        //    return NoContent();
        //}



        //[HttpPost]
        //[Route("refresh-token")]
        //public async Task<IActionResult> RefreshToken(tokenModelDTO tokenModel)
        //{
        //    if (tokenModel is null)
        //    {
        //        return BadRequest("Invalid client request");
        //    }

        //    string? accessToken = tokenModel.AccessToken;
        //    string? refreshToken = tokenModel.RefreshToken;

        //    var principal = GetPrincipalFromExpiredToken(accessToken);
        //    if (principal == null)
        //    {
        //        return BadRequest("Invalid access token or refresh token");
        //    }

        //    string username = principal.Identity.Name;
        //    var user = await _userManager.FindByNameAsync(username);

        //    if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
        //    {
        //        return BadRequest("Invalid access token or refresh token");
        //    }

        //    var newAccessToken = CreateToken(principal.Claims.ToList());
        //    var newRefreshToken = GenerateRefreshToken();

        //    user.RefreshToken = newRefreshToken;
        //    await _userManager.UpdateAsync(user);

        //    return new ObjectResult(new
        //    {
        //        accessToken = new JwtSecurityTokenHandler().WriteToken(newAccessToken),
        //        refreshToken = newRefreshToken
        //    });
        //}


    }
}
