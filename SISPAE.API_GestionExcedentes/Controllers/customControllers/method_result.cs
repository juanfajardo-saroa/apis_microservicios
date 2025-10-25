namespace SISPAE_API_GestionExcedentes.WebAPI.Controllers.customControllers
{
    public class method_result
    {

        public bool success { get; set; } = false;
        public string message { get; set; } = "";
        public dynamic data { get; set; } = null;
    }
}