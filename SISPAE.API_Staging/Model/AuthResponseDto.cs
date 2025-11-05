namespace SISPAE_API_Staging.WebAPI.Model
{
    public class AuthResponseDto
    {
        public bool IsAuthSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string Token { get; set; }

        public string? RefreshToken { get; set; }
    }
}
