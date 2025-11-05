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
     /// Clase Model Base para  AspNetUserLogins
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class AspNetUserLoginsModelBase : ModelObject
    {
		    public AspNetUserLoginsModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: LoginProvider 
        /// </Resumen> 
        [Display(Name = "Login Provider")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(128 , ErrorMessage = " El campo {0} no debe tener mas de 128 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String LoginProvider{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ProviderKey 
        /// </Resumen> 
        [Display(Name = "Provider Key")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(128 , ErrorMessage = " El campo {0} no debe tener mas de 128 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String ProviderKey{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ProviderDisplayName 
        /// </Resumen> 
        [Display(Name = "Provider Display Name")] 
        [DataType (DataType.MultilineText)]   
        public String? ProviderDisplayName{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: UserId 
        /// </Resumen> 
        [Display(Name = "User Id")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(450 , ErrorMessage = " El campo {0} no debe tener mas de 450 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String UserId{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sUserId { get; set; }
        /// 
 
        public String? filtro { get; set; }
#endregion Public Members    



    }
}





