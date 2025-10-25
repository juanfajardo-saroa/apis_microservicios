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
     /// Clase Model Base para  TP_Departamento
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class TP_DepartamentoModelBase : ModelObject
    {
		    public TP_DepartamentoModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: nombre 
        /// </Resumen> 
        [Display(Name = "nombre")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(255 , ErrorMessage = " El campo {0} no debe tener mas de 255 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String nombre{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: codigo 
        /// </Resumen> 
        [Display(Name = "codigo")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(2 , ErrorMessage = " El campo {0} no debe tener mas de 2 caracteres.")] 
        [DataType (DataType.Text)]   
        public String codigo{ get; set; }

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





