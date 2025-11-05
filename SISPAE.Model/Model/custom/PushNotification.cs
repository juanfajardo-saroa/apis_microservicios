using System;
using System.Collections.Generic;
using System.Text;

namespace SISPAE.Model
{
    public class PushNotification
    {
        public int idActividad { get; set; }
        
        public string NombreActividad { get; set; }
        public string NombreCaso { get; set; }

        public DateTime Inicio { get; set; }
        public DateTime? Fin { get; set; }
    }
}
