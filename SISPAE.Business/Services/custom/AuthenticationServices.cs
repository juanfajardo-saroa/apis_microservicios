/// <Derechos_Reservados>
/// Aplicacion      :Doc4Us 
/// Autor           :Oscar Mauricio Cortes Pinzon
/// Generacion      :Este archivo es generado automaticamente mediante generador :GeneraApp.
/// Ano             :2018
/// Arquitectura    :Patron MVC ASP Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa            :Business (Business Access Layer) - Capa del DataMapper, Esta clase implementa la interface presentada, 
///                  aca desarrolla los metodos del CRUD para cada Objeto que representa los metodos que deben ser implementados 
///                  (Source: MVC7_Business_Base.Cs)   clase 
/// </Derechos_Reservados>


using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using SISPAE.Model;
using SISPAE.Model.Security;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.IdentityModel.Tokens;


namespace SISPAE.Business.custom
{
    public class AuthenticationServices : IAuthenticationServices
    {


        private const double EXPIRY_DURATION_MINUTES = 30;
        private async Task<AuthenticationInfo> SetAuthToken(string username)
        {

            var secretKey = Environment.GetEnvironmentVariable("API_MANAGEMENT_JWT_KEY");
            dynamic expiryTime = Environment.GetEnvironmentVariable("API_MANAGEMENT_EXPIRY_TOKEN_KEY_MINUTES");
            expiryTime = expiryTime == null ? 5 : int.Parse(expiryTime);

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, username)
                }),
                Expires = DateTime.UtcNow.AddMinutes(expiryTime),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            var result = new AuthenticationInfo { username = username, token = tokenHandler.WriteToken(token), expiresIn = expiryTime * 60 };
            return result;

        }

        public async Task<ServiceResponse> Login(string credentialsUserName, string credentialsPassword)
        {
            //credentialsPassword = EncryptPassword(credentialsPassword);

            //var currentUser = await _userRepository.GetUserByUsername(credentialsUserName);
            //if (currentUser == null || credentialsUserName != currentUser.UserName ||
            //    credentialsPassword != currentUser.Password)
            //{
            //    var code = "";
            //    if (currentUser == null)
            //    {
            //        _logger.LogInformation($"Login user {credentialsUserName} does not exists");
            //        code = "USER_NOT_EXISTS";
            //    }
            //    else
            //    {
            //        _logger.LogInformation($"Error Logging in user {credentialsUserName} Wrong Username or password");
            //        code = "WRONG_PASSWORD";
            //    }



               
            //}


            if (credentialsUserName == "prueba" && credentialsPassword == "password")
            {
                var authResponse = await SetAuthToken(credentialsUserName);
                return new ServiceResponse()
                {

                    success = true,
                    message = "",
                    code = "AUTH_OK",
                    data = authResponse
                };
            }
            else
            {
                return new ServiceResponse()
                {
                    success = false,
                    code = "WRONG_AUTHENTICATION",
                    message = "Wrong Username or password",
                    data = null
                };
            }
            

        }


        private static string EncryptPassword(string password)
        {


            var saltString = Environment.GetEnvironmentVariable("API_MANAGEMENT_SALT_KEY");

            byte[] salt = Encoding.UTF8.GetBytes(saltString);

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            var hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            return hashed;
        }

        public string BuildToken(string key, string issuer, string user, string role)
        {
            var claims = new[] {
            new Claim(ClaimTypes.Name, user),
            new Claim(ClaimTypes.Role, role),
            new Claim(ClaimTypes.NameIdentifier,
            Guid.NewGuid().ToString())
            };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new JwtSecurityToken(issuer, issuer, claims, expires: DateTime.Now.AddMinutes(EXPIRY_DURATION_MINUTES), signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }

        public bool IsTokenValid(string key, string issuer, string token)
        {
            var mySecret = Encoding.UTF8.GetBytes(key);
            var mySecurityKey = new SymmetricSecurityKey(mySecret);
            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                tokenHandler.ValidateToken(token,
                new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = issuer,
                    ValidAudience = issuer,
                    IssuerSigningKey = mySecurityKey,
                }, out SecurityToken validatedToken);
            }
            catch
            {
                return false;
            }
            return true;
        }


    }

    public interface IAuthenticationServices
    {
        Task<ServiceResponse> Login(string credentialsUserName, string credentialsPassword);
        string BuildToken(string key, string issuer, string user, string role);
        bool IsTokenValid(string key, string issuer, string token);

    }
}