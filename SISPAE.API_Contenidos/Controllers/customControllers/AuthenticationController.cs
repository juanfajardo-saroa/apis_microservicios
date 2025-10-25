using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SISPAE.Business.custom;
using SISPAE.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SISPAE.Business;

namespace SISPAE_API_Contenidos.WebAPI.Controllers.customControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController] 
    public class AuthenticationController : ControllerBase
    {


        private readonly IAuthenticationServices _authenticationServices;
        private readonly IConfiguration _config;
        private string generatedToken = null;

        public AuthenticationController(IAuthenticationServices authenticationServices, IConfiguration config)
        {
            _authenticationServices = authenticationServices;
            _config = config;
        }


        /// <summary>
        /// Create authentication key to user
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(typeof(ServiceResponse), 200)]
        [ProducesResponseType(typeof(ServiceResponse), 401)]
        [ProducesResponseType(typeof(ServiceResponse), 500)]
        public async Task<IActionResult> Login(AuthCredentials credentials)
        {

            if (string.IsNullOrEmpty(credentials.userName) || string.IsNullOrEmpty(credentials.password))
            {
                return Unauthorized(new ServiceResponse()
                {
                    success = false,
                    code = "WRONG_AUTHENTICATION",
                    message = "Wrong Username or password",
                    data = null
                });
            }

            IActionResult response = Unauthorized();

            var validUser = new AplicacionMs().GetAll().Cast<Aplicacion>().Where(u => u.Aplicacion == credentials.userName && u.Password == credentials.password);
            //var validUser = await _signInManager.PasswordSignInAsync(credentials.userName, credentials.password, true, lockoutOnFailure: false);
            //if (validUser.Succeeded)

            if (validUser.Count() > 0)
            {
                generatedToken = _authenticationServices.BuildToken(_config["Jwt:Key"].ToString(), _config["Jwt:Issuer"].ToString(), credentials.userName,"Admon");
                if (generatedToken != null)
                {
                    //HttpContext.Session.SetString("Token", generatedToken);

                    var result = new ServiceResponse()
                    {
                        success = true,
                        message = "",
                        code = "AUTH_OK",
                        data = generatedToken
                    };
                    return result.success ? new ObjectResult(result) : Unauthorized(result);
                }
                else
                {
                    return Unauthorized(new ServiceResponse()
                    {
                        success = false,
                        code = "WRONG_AUTHENTICATION",
                        message = "Invalid Token",
                        data = null
                    });
                }
            }
            else
            {
                return Unauthorized(new ServiceResponse()
                {
                    success = false,
                    code = "WRONG_AUTHENTICATION",
                    message = "Wrong Username or password",
                    data = null
                });
            }
        }

        
    }



    public class AuthCredentials
    {
        public string userName { get; set; }

        public string password { get; set; }
    }



}