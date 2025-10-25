using System.ComponentModel.DataAnnotations;

namespace SISPAE_API_Vigencias.WebAPI.Model
{
    public class ForgotPasswordDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string ClientURI { get; set; }

    }
}
