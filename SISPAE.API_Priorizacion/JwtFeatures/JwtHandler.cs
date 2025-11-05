using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

using SISPAE.Business;
using SISPAE.Model;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
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

        foreach(var ur in urs)
            {
            var r = (AspNetRoles)new AspNetRolesMs().GetById(new AspNetRoles() { Id = ur.RoleId });

            if(r.id_TipoRoles == 1)
                {
                esrolBase = true;
                rolbase = r.Name;
                }

            if(r.id_TipoRoles == 2)
                {
                esrolTemporal = true;
                rolTemporal = r.Name;
                }
            }

        claims.Add(new Claim("RolBase", rolbase));
        claims.Add(new Claim("RolPersonalizado", rolTemporal));


        //Rol de ubicacion base
        if(string.IsNullOrEmpty(u.UbicacionBase))
            u.UbicacionBase = "";


        Boolean ie = u.UbicacionBase.Contains("InstitucionEducativa", StringComparison.CurrentCultureIgnoreCase);
        Boolean etc = u.UbicacionBase.Contains("ETC", StringComparison.CurrentCultureIgnoreCase);

        if(ie && u.id_Ubicacion != null)
            {
            var siu = (InstitucionEducativa)new InstitucionEducativaMs().GetById(new InstitucionEducativa() { id = u.id_Ubicacion.Value });
            claims.Add(new Claim("Ubicacion", $"InstitucionEducativa {siu.Nombre}"));
            }
        else if(etc && u.id_Ubicacion != null)
            {
            var sETC = (ETC)new ETCMs().GetById(new ETC() { id = u.id_Ubicacion.Value });
            claims.Add(new Claim("Ubicacion", $" ETC {sETC.Nombre}"));
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
    }