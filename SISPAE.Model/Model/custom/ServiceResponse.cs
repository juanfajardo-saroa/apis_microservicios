namespace SISPAE.Model
{
    public class ServiceResponse
    {
        public bool success { get; set; }
        public string code { get; set; } = "";
        public string message { get; set; }
        public dynamic data { get; set; }
        public bool exception { get; set; } = false;
    }
}