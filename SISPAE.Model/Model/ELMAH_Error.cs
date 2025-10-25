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
     /// Clase Model Base para  ELMAH_Error
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class ELMAH_ErrorModelBase : ModelObject
    {
		private DateTime _createdTimeUtc; 
    public ELMAH_ErrorModelBase() 
    {  
    _createdTimeUtc= DateTime.MinValue; 
    }




        ///Definicion de miembros o metodos privados    
        #region Private Members 
        #endregion Private Members    


        ///Definicion de miembros o metodos publicos  - Property Declarations  
        #region Public Members 


        ///  Estas son las propiedades Base de esta clase  
        ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Application 
        /// </Resumen> 
        [Display(Name = "Application")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        [DataType(DataType.Text)]
        public String ErrorId { get; set; }


        ///  Estas son las propiedades Base de esta clase  
        ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Application 
        /// </Resumen> 
        [Display(Name = "Application")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(60 , ErrorMessage = " El campo {0} no debe tener mas de 60 caracteres.")] 
        [DataType (DataType.Text)]   
        public String Application{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Host 
        /// </Resumen> 
        [Display(Name = "Host")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String Host{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Type 
        /// </Resumen> 
        [Display(Name = "Type")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String Type{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Source 
        /// </Resumen> 
        [Display(Name = "Source")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(60 , ErrorMessage = " El campo {0} no debe tener mas de 60 caracteres.")] 
        [DataType (DataType.Text)]   
        public String Source{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Message 
        /// </Resumen> 
        [Display(Name = "Message")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(500 , ErrorMessage = " El campo {0} no debe tener mas de 500 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String Message{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: User 
        /// </Resumen> 
        [Display(Name = "User")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String User{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: StatusCode 
        /// </Resumen> 
        [Display(Name = "Status Code")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int StatusCode{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TimeUtc 
        /// </Resumen> 
        [Display(Name = "Time Utc")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime TimeUtc
                {
                     get
                     { return (_createdTimeUtc== DateTime.MinValue) ? DateTime.Now : _createdTimeUtc;
                     }
                     set { _createdTimeUtc = value; }

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Sequence 
        /// </Resumen> 
        [Display(Name = "Sequence")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int Sequence{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: AllXml 
        /// </Resumen> 
        [Display(Name = "All Xml")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [DataType (DataType.MultilineText)]   
        public String AllXml{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Data 
        /// </Resumen> 
        [Display(Name = "Data")] 
        [DataType (DataType.MultilineText)]   
        public String? Data{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: auditoria 
        /// </Resumen> 
        [Display(Name = "auditoria")] 
        [DataType (DataType.MultilineText)]   
        public String? auditoria{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





