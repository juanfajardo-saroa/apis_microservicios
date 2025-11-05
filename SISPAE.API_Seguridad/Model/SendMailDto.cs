namespace SISPAE.WebAPI.Model
{
    public class SendMailDto
    {

        public string idUser { get; set; }
        public string asunto { get; set; }
        public string mensaje { get; set; }
        public string sistema { get; set; }
    }
}
