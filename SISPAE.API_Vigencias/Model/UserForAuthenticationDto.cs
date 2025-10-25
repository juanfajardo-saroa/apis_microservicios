using System.ComponentModel.DataAnnotations;

namespace SISPAE_API_Vigencias.WebAPI.Model
{
    public class UserForAuthenticationDto
    {


        [Required(ErrorMessage = "Documento")]
        public string Documento { get; set; }

        [Required(ErrorMessage = "Tipo Documento")]
        public int TipoDocumento { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }


        }
    }
