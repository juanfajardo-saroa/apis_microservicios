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
     /// Clase Model Base para  Proveedores
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class ProveedoresModelBase : ModelObject
    {
		    public ProveedoresModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_DivipolasProveedor 
        /// </Resumen> 
        [Display(Name = "Divipolas Proveedor")] 
        public int? ID_DivipolasProveedor{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sID_DivipolasProveedor { get; set; }
        /// 
 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NombreRazonSocial 
        /// </Resumen> 
        [Display(Name = "Nombre Razon Social")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(500 , ErrorMessage = " El campo {0} no debe tener mas de 500 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String NombreRazonSocial{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Nit 
        /// </Resumen> 
        [Display(Name = "Nit")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(250 , ErrorMessage = " El campo {0} no debe tener mas de 250 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String Nit{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumeroCedula 
        /// </Resumen> 
        [Display(Name = "Numero Cedula")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NumeroCedula{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ImagenCedulaPATH 
        /// </Resumen> 
        [Display(Name = "Imagen Cedula P A T H")] 
        [StringLength(150 , ErrorMessage = " El campo {0} no debe tener mas de 150 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? ImagenCedulaPATH{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Correo 
        /// </Resumen> 
        [Display(Name = "Correo")] 
        [StringLength(150 , ErrorMessage = " El campo {0} no debe tener mas de 150 caracteres.")] 
        [EmailAddress(ErrorMessage = "Invalida la direción de correo electróncio ")] 
        public String? Correo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Telefono 
        /// </Resumen> 
        [Display(Name = "Telefono")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType(DataType.PhoneNumber)] 
        public String? Telefono{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Direccion 
        /// </Resumen> 
        [Display(Name = "Direccion")] 
        [StringLength(250 , ErrorMessage = " El campo {0} no debe tener mas de 250 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? Direccion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ImagenRUTPath 
        /// </Resumen> 
        [Display(Name = "Imagen R U T Path")] 
        [StringLength(150 , ErrorMessage = " El campo {0} no debe tener mas de 150 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? ImagenRUTPath{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NombreRepresentantelegalId 
        /// </Resumen> 
        [Display(Name = "Nombre Representantelegal Id")] 
        public int? NombreRepresentantelegalId{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ApellidoRepresentantelegalId 
        /// </Resumen> 
        [Display(Name = "Apellido Representantelegal Id")] 
        public int? ApellidoRepresentantelegalId{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumeroIdentificacion 
        /// </Resumen> 
        [Display(Name = "Numero Identificacion")] 
        public Double? NumeroIdentificacion{ get; set; }

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





