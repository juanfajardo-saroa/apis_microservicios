using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using SISPAE.Business;
using SISPAE.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

public class JwtHandler
{
    private readonly IConfiguration _configuration;
    private readonly IConfigurationSection _jwtSettings;

    public JwtHandler(IConfiguration configuration)
    {
        _configuration = configuration;
        _jwtSettings = _configuration.GetSection("Jwt");
    }

    public SigningCredentials GetSigningCredentials()
    {
        var key = Encoding.UTF8.GetBytes(_jwtSettings.GetSection("Key").Value);
        var secret = new SymmetricSecurityKey(key);

        return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
    }

    public List<Claim> GetClaims(IdentityUser user)
    {
        var u = (AspNetUsers)new AspNetUsersMs().GetById(new AspNetUsers() { Id = user.Id });
        var urs = new AspNetUserRolesMs().GetAll().Cast<AspNetUserRoles>().Where(r => r.UserId == user.Id).ToList();


        var claims = new List<Claim>();
        claims.Add(new Claim("KeyMaster", $"{u.Id}"));
        claims.Add(new Claim("NombreUsuario", $"{u.PrimerNombre} {u.SegundoNombre} {u.PrimerApellido} {u.SegundoApellido}"));
        claims.Add(new Claim("Cargo", $"{u.Cargo}"));


        bool esrolBase = false, esrolTemporal = false;
        string rolbase = string.Empty; string rolTemporal = string.Empty;
        string keybase = string.Empty; string keyTemporal = string.Empty;
        int tienealgunRolUapa = 0;

        foreach (var ur in urs)
        {
            var r = (AspNetRoles)new AspNetRolesMs().GetById(new AspNetRoles() { Id = ur.RoleId });

            if (r.id_TipoRoles == 1)
            {
                esrolBase = true;
                rolbase = r.Name;
                keybase = r.Id;
            }

            if (r.id_TipoRoles == 2)
            {
                esrolTemporal = true;
                rolTemporal = r.Name;
                keyTemporal = r.Id;
            }

            r.RolUapa = r.RolUapa == null ? false : r.RolUapa;

            if (r.RolUapa.Value)
            {
                tienealgunRolUapa++;
            }
        }

        claims.Add(new Claim("RolBase", rolbase));
        claims.Add(new Claim("KeyBase", keybase));

        claims.Add(new Claim("RolPersonalizado", rolTemporal));
        claims.Add(new Claim("KeyPersonalizado", keyTemporal));


        //Rol de ubicacion base
        if (string.IsNullOrEmpty(u.UbicacionBase))
            u.UbicacionBase = "";



        Boolean ie = u.UbicacionBase.Contains("InstitucionEducativa", StringComparison.CurrentCultureIgnoreCase);
        Boolean etc = u.UbicacionBase.Contains("ETC", StringComparison.CurrentCultureIgnoreCase);
        Boolean et = u.UbicacionBase.ToString().ToLower() == "et" ? true : false;
        Boolean Operadores = u.UbicacionBase.Contains("Operadores", StringComparison.CurrentCultureIgnoreCase);



        string vu = u.id_Ubicacion == null ? "0" : u.id_Ubicacion.Value.ToString();

        claims.Add(new Claim("IdUbicacion", vu));
        claims.Add(new Claim("RolUapa", (tienealgunRolUapa > 0 ? "SI" : "NO")));


        if (ie && u.id_Ubicacion != null)
        {
            var siu = (InstitucionEducativa)new InstitucionEducativaMs().GetById(new InstitucionEducativa() { id = u.id_Ubicacion.Value });
            claims.Add(new Claim("Ubicacion", $"Institucion Educativa | {siu.Nombre}"));
        }
        else if (etc && u.id_Ubicacion != null)
        {
            var sETC = (ETC)new ETCMs().GetById(new ETC() { id = u.id_Ubicacion.Value });
            claims.Add(new Claim("Ubicacion", $"ETC |{sETC.Nombre}"));
        }

        else if (et && u.id_Ubicacion != null)
        {
            var sET = (ET)new ETMs().GetById(new ET() { id = u.id_Ubicacion.Value });
            claims.Add(new Claim("Ubicacion", $"ET |{sET.Nombre}"));
        }

        else if (Operadores && u.id_Ubicacion != null)
        {
            var sOPE = (Operadores)new OperadoresMs().GetById(new Operadores() { id = u.id_Ubicacion.Value });
            claims.Add(new Claim("Ubicacion", $"Operadores |{sOPE.NombreRazonSocial}"));
        }
        else
        {
            claims.Add(new Claim("Ubicacion", $"Sin definir | Sin Ubicaci�n"));

        }





        return claims;
    }

    public JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
    {

        var tokenOptions = new JwtSecurityToken(
            issuer: _jwtSettings.GetSection("validIssuer").Value,
            audience: _jwtSettings.GetSection("validAudience").Value,


            claims: claims,
            expires: DateTime.Now.AddMinutes(Convert.ToDouble(_jwtSettings.GetSection("Expire_Minutes").Value)),
            signingCredentials: signingCredentials);

        return tokenOptions;
    }

    public string GenerateAccessToken(IEnumerable<Claim> claims)
    {
        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.GetSection("Key").Value));
        var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
        var tokeOptions = new JwtSecurityToken(
            //issuer: "https://localhost:5001",
            //audience: "https://localhost:5001",
            claims: claims,
            expires: DateTime.Now.AddMinutes(60),
            signingCredentials: signinCredentials
        );
        var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
        return tokenString;
    }


    public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
    {
        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = _jwtSettings.GetSection("validIssuer").Value,
            ValidAudience = _jwtSettings.GetSection("validAudience").Value,

            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.GetSection("Key").Value)),//_configuration["JWT:Secret"]
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
        if (securityToken is not JwtSecurityToken jwtSecurityToken || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            throw new SecurityTokenException("Invalid token");

        return principal;

    }

    public string GenerateRefreshToken()
    {
        var randomNumber = new byte[32];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }
    }




}