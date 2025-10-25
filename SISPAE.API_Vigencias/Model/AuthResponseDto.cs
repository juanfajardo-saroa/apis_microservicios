namespace SISPAE_API_Vigencias.WebAPI.Model
{
    public class AuthResponseDto
    {
        public bool IsAuthSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string Token { get; set; }

        public string? RefreshToken { get; set; }
    }
}
