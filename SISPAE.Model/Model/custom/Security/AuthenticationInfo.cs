namespace SISPAE.Model.Security
{
    public sealed class AuthenticationInfo
    {
        public string username { get; set; }

        public string token { get; set; }

        public bool authenticated { get; set; } = true;

        public int expiresIn { get; set; }

    }
}