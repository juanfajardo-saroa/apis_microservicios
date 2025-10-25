/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano			    :2022
/// Arquitectura	:Patron MVC ASP Net Core, Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa			:MODEL (Model Entity Layer) - Capa Model (Source: MVC7_DAL_ModelBase.CS)  Partial Interface 
/// </Derechos_Reservados>


using System;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace SISPAE.Model
{
     /// <Resumen>
     /// Clase Model Base para  AuditoriaIngreso
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class AuditoriaIngresoModelBase : ModelObject
    {
		private DateTime _createdFecha; 
    public AuditoriaIngresoModelBase() 
    {  
    _createdFecha= DateTime.MinValue; 
    }  
        

		

                 ///Definicion de miembros o metodos privados    
#region Private Members 
#endregion Private Members    
             ///    
 
            ///Definicion de miembros o metodos publicos  - Property Declarations  
#region Public Members 
 
///  Estas son las propiedades Base de esta clase  
             ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID 
        /// </Resumen> 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID 
        /// </Resumen> 
        [Display(Name = "I D")] 
                         
        public string? sID  

                {
                     get;
                     set;

                }
        [Display(Name = "I D")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int ID{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Empresa 
        /// </Resumen> 
        [Display(Name = "Empresa")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(4 , ErrorMessage = " El campo {0} no debe tener mas de 4 caracteres.")] 
        [DataType (DataType.Text)]   
        public String Empresa{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NombreUsuario 
        /// </Resumen> 
        [Display(Name = "Nombre Usuario")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int NombreUsuario{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Fecha 
        /// </Resumen> 
        [Display(Name = "Fecha")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime Fecha

                {
                     get
                     { return (_createdFecha== DateTime.MinValue) ? DateTime.Now : _createdFecha;
                     }
                     set { _createdFecha = value; }

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Direccionip 
        /// </Resumen> 
        [Display(Name = "Direccionip")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String Direccionip{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: HostNameUsuario 
        /// </Resumen> 
        [Display(Name = "Host Name Usuario")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String HostNameUsuario{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: IPDetrasProxy 
        /// </Resumen> 
        [Display(Name = "I P Detras Proxy")] 
        [StringLength(250 , ErrorMessage = " El campo {0} no debe tener mas de 250 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String IPDetrasProxy{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Browser 
        /// </Resumen> 
        [Display(Name = "Browser")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String Browser{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NombreMaquina 
        /// </Resumen> 
        [Display(Name = "Nombre Maquina")] 
        [StringLength(200 , ErrorMessage = " El campo {0} no debe tener mas de 200 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String NombreMaquina{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Accion 
        /// </Resumen> 
        [Display(Name = "Accion")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String Accion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: auditoria 
        /// </Resumen> 
        [Display(Name = "auditoria")] 
        [DataType (DataType.MultilineText)]   
        public String auditoria{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    
///    


    }
}





