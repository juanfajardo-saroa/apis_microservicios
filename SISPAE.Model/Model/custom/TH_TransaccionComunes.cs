using System;
using System.Collections.Generic;
using System.Text;

namespace SISPAE.Model
{
    public class TH_TransaccionComunes
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public string TipoOperacion { get; set; }

        public int status { get; set; }

        public string Transaccion{ get; set; }

        public int idExterno { get; set; }

    }
}
