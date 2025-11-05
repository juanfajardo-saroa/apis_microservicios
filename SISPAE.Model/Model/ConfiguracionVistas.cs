/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano			    :2022
/// Arquitectura	:Patron MVC ASP Net Core, Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa			:MODEL (Model Entity Layer) - Capa Model (Source: MVC7_DAL_ModelBase.CS)  Partial Interface 
/// </Derechos_Reservados>


using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISPAE.Model
{
     /// <Resumen>
     /// Clase Model Base para  ConfiguracionVistas
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class ConfiguracionVistasModelBase : ModelObject
    {
		    public ConfiguracionVistasModelBase() 
    {  
    }  
        

		

        ///Definicion de miembros o metodos privados    
#region Private Members 
#endregion Private Members    


        ///Definicion de miembros o metodos publicos  - Property Declarations  
#region Public Members 
 
        ///  Estas son las propiedades Base de esta clase  
        ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id 
        /// </Resumen> 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id 
        /// </Resumen> 
        [Display(Name = "SinNombre")] 
                         
        public string? sID  
                {
                     get;
                     set;
                }
        [Display(Name = "SinNombre")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int id{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Nombre 
        /// </Resumen> 
        [Display(Name = "Nombre")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String Nombre{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TipoContratoId 
        /// </Resumen> 
        [Display(Name = "Tipo Contrato Id")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int TipoContratoId{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SubTipoContratoId 
        /// </Resumen> 
        [Display(Name = "Sub Tipo Contrato Id")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int SubTipoContratoId{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Seccion1 
        /// </Resumen> 
        [Display(Name = "Seccion1")] 
        public Boolean? Seccion1{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Seccion2 
        /// </Resumen> 
        [Display(Name = "Seccion2")] 
        public Boolean? Seccion2{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Seccion3 
        /// </Resumen> 
        [Display(Name = "Seccion3")] 
        public Boolean? Seccion3{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Seccion4 
        /// </Resumen> 
        [Display(Name = "Seccion4")] 
        public Boolean? Seccion4{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Seccion5 
        /// </Resumen> 
        [Display(Name = "Seccion5")] 
        public Boolean? Seccion5{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Seccion6 
        /// </Resumen> 
        [Display(Name = "Seccion6")] 
        public Boolean? Seccion6{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Seccion7 
        /// </Resumen> 
        [Display(Name = "Seccion7")] 
        public Boolean? Seccion7{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Seccion8 
        /// </Resumen> 
        [Display(Name = "Seccion8")] 
        public Boolean? Seccion8{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Seccion9 
        /// </Resumen> 
        [Display(Name = "Seccion9")] 
        public Boolean? Seccion9{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Seccion10 
        /// </Resumen> 
        [Display(Name = "Seccion10")] 
        public Boolean? Seccion10{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Seccion11 
        /// </Resumen> 
        [Display(Name = "Seccion11")] 
        public Boolean? Seccion11{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Seccion12 
        /// </Resumen> 
        [Display(Name = "Seccion12")] 
        public Boolean? Seccion12{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Seccion13 
        /// </Resumen> 
        [Display(Name = "Seccion13")] 
        public Boolean? Seccion13{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Seccion14 
        /// </Resumen> 
        [Display(Name = "Seccion14")] 
        public Boolean? Seccion14{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Seccion15 
        /// </Resumen> 
        [Display(Name = "Seccion15")] 
        public Boolean? Seccion15{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Seccion16 
        /// </Resumen> 
        [Display(Name = "Seccion16")] 
        public Boolean? Seccion16{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumSec1 
        /// </Resumen> 
        [Display(Name = "Num Sec1")] 
        public int? NumSec1{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumSec2 
        /// </Resumen> 
        [Display(Name = "Num Sec2")] 
        public int? NumSec2{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumSec3 
        /// </Resumen> 
        [Display(Name = "Num Sec3")] 
        public int? NumSec3{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumSec4 
        /// </Resumen> 
        [Display(Name = "Num Sec4")] 
        public int? NumSec4{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumSec5 
        /// </Resumen> 
        [Display(Name = "Num Sec5")] 
        public int? NumSec5{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumSec6 
        /// </Resumen> 
        [Display(Name = "Num Sec6")] 
        public int? NumSec6{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumSec7 
        /// </Resumen> 
        [Display(Name = "Num Sec7")] 
        public int? NumSec7{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumSec8 
        /// </Resumen> 
        [Display(Name = "Num Sec8")] 
        public int? NumSec8{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumSec9 
        /// </Resumen> 
        [Display(Name = "Num Sec9")] 
        public int? NumSec9{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumSec10 
        /// </Resumen> 
        [Display(Name = "Num Sec10")] 
        public int? NumSec10{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumSec11 
        /// </Resumen> 
        [Display(Name = "Num Sec11")] 
        public int? NumSec11{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumSec12 
        /// </Resumen> 
        [Display(Name = "Num Sec12")] 
        public int? NumSec12{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumSec13 
        /// </Resumen> 
        [Display(Name = "Num Sec13")] 
        public int? NumSec13{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumSec14 
        /// </Resumen> 
        [Display(Name = "Num Sec14")] 
        public int? NumSec14{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumSec15 
        /// </Resumen> 
        [Display(Name = "Num Sec15")] 
        public int? NumSec15{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumSec16 
        /// </Resumen> 
        [Display(Name = "Num Sec16")] 
        public int? NumSec16{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





