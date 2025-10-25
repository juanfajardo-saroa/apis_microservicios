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
     /// Clase Model Base para  TP_Empresa
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class TP_EmpresaModelBase : ModelObject
    {
		    public TP_EmpresaModelBase() 
    {  
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
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String Nombre{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Slogan 
        /// </Resumen> 
        [Display(Name = "Slogan")] 
        [StringLength(250 , ErrorMessage = " El campo {0} no debe tener mas de 250 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String Slogan{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Logo 
        /// </Resumen> 
        [Display(Name = "Logo")] 
        public Byte[] Logo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ZeroFill 
        /// </Resumen> 
        [Display(Name = "Zero Fill")] 
        public int? ZeroFill{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: HostMail 
        /// </Resumen> 
        [Display(Name = "Host Mail")] 
        [StringLength(255 , ErrorMessage = " El campo {0} no debe tener mas de 255 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String HostMail{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: UserFrom 
        /// </Resumen> 
        [Display(Name = "User From")] 
        [StringLength(255 , ErrorMessage = " El campo {0} no debe tener mas de 255 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String UserFrom{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FromPassword 
        /// </Resumen> 
        [Display(Name = "From Password")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String FromPassword{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PuertoMail 
        /// </Resumen> 
        [Display(Name = "Puerto Mail")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String PuertoMail{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PlantillaAsignacion 
        /// </Resumen> 
        [Display(Name = "Plantilla Asignacion")] 
        [DataType (DataType.MultilineText)]   
        public String PlantillaAsignacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PlantillaFinProceso 
        /// </Resumen> 
        [Display(Name = "Plantilla Fin Proceso")] 
        [DataType (DataType.MultilineText)]   
        public String PlantillaFinProceso{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PlantillaAlerta 
        /// </Resumen> 
        [Display(Name = "Plantilla Alerta")] 
        [DataType (DataType.MultilineText)]   
        public String PlantillaAlerta{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: urlDrive 
        /// </Resumen> 
        [Display(Name = "url Drive")] 
        [DataType (DataType.MultilineText)]   
        public String urlDrive{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: keyDrive 
        /// </Resumen> 
        [Display(Name = "key Drive")] 
        [StringLength(255 , ErrorMessage = " El campo {0} no debe tener mas de 255 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String keyDrive{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: usrDrive 
        /// </Resumen> 
        [Display(Name = "usr Drive")] 
        [StringLength(255 , ErrorMessage = " El campo {0} no debe tener mas de 255 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String usrDrive{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: pwdDrive 
        /// </Resumen> 
        [Display(Name = "pwd Drive")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String pwdDrive{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SSLEnabled 
        /// </Resumen> 
        [Display(Name = "S S L Enabled")] 
        public Boolean SSLEnabled{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TieneDoc4us 
        /// </Resumen> 
        [Display(Name = "Tiene Doc4us")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public Boolean TieneDoc4us{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TieneOpe 
        /// </Resumen> 
        [Display(Name = "Tiene Ope")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public Boolean TieneOpe{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TieneFirma 
        /// </Resumen> 
        [Display(Name = "Tiene Firma")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public Boolean TieneFirma{ get; set; }

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





