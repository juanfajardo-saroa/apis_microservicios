using System.ComponentModel.DataAnnotations;

namespace SISPAE_API_PTN.WebAPI.Model
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
