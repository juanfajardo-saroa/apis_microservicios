using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SISPAE.Model
{
    public class TA_INGRESO
    {

        [Required]
        [Display(Name = "ID")]
        public Int32 ID { get; set; }

        [Required]
        [Display(Name = "CODIGOEMPRESA")]
        public String CODIGOEMPRESA { get; set; }

        [Required]
        [Display(Name = "USUARIO")]
        public string USUARIO { get; set; }

        [Required]
        [Display(Name = "FECHA")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
       
        public DateTime FECHA { get; set; }
 
        public String MES { get; set; }
        public Int32? ANIO { get; set; }



        [Display(Name = "Direccion IP")]
        public String DireccionIP { get; set; }

        [Display(Name = "Nombre de la Maquina (HostName)")]
        public String HostNameUsuario { get; set; }

        [Display(Name = "Dirección IP Detras del Proxy")]
        public String IPDetrasProxy { get; set; }

        [Display(Name = "Browser Usado por el Usaurio")]
        public String Browser { get; set; }

        [Display(Name = "Accion Realizada por el Usaurio")]
        public String Accion { get; set; }

    }
}
