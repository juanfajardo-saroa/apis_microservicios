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
     /// Clase Model Base para  AspNetRoles
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class AspNetRolesModelBase : ModelObject
    {
		    public AspNetRolesModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id 
        /// </Resumen> 
        [Display(Name = "SinNombre")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(450 , ErrorMessage = " El campo {0} no debe tener mas de 450 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String Id{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Name 
        /// </Resumen> 
        [Display(Name = "Name")] 
        [StringLength(256 , ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? Name{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NormalizedName 
        /// </Resumen> 
        [Display(Name = "Normalized Name")] 
        [StringLength(256 , ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? NormalizedName{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ConcurrencyStamp 
        /// </Resumen> 
        [Display(Name = "Concurrency Stamp")] 
        [DataType (DataType.MultilineText)]   
        public String? ConcurrencyStamp{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_TipoRoles 
        /// </Resumen> 
        [Display(Name = "Tipo Roles")] 
        public int? id_TipoRoles{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sid_TipoRoles { get; set; }
		/// 


		public Boolean? RolUapa { get; set; }

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





