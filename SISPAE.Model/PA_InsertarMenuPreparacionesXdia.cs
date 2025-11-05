using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace SISPAE.Model
{
    public class PA_InsertarMenuPreparacionesXdia : ModelObject
    {
        public PA_InsertarMenuPreparacionesXdia()
        {
        }

        [Display(Name = "Nro Registros")]
        public int NroRegistros { get; set; }

    }
}
