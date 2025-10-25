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
     /// Clase Model Base para  PA_InstitucionEducativaGetAllWithRelation
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_InstitucionEducativaGetAllWithRelationModelBase : ModelObject
    {
		    public PA_InstitucionEducativaGetAllWithRelationModelBase() 
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
        [Display(Name = "SinNombre")] 
        public int? id{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Rector 
        /// </Resumen> 
        [Display(Name = "Rector")] 
        public int? ID_Rector{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_ETC 
        /// </Resumen> 
        [Display(Name = "E T C")] 
        public int? ID_ETC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_ET 
        /// </Resumen> 
        [Display(Name = "E T")] 
        public int? ID_ET{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_DiviPola 
        /// </Resumen> 
        [Display(Name = "Divi Pola")] 
        public int? ID_DiviPola{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CodigoDane 
        /// </Resumen> 
        [Display(Name = "Codigo Dane")] 
        [DataType (DataType.MultilineText)]   
        public String? CodigoDane{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Nombre 
        /// </Resumen> 
        [Display(Name = "Nombre")] 
        [DataType (DataType.MultilineText)]   
        public String? Nombre{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Correo 
        /// </Resumen> 
        [Display(Name = "Correo")] 
        [EmailAddress(ErrorMessage = "Invalida la direción de correo electróncio ")] 
        public String? Correo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_Divipolas 
        /// </Resumen> 
        [Display(Name = "s Divipolas")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_Divipolas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_ET 
        /// </Resumen> 
        [Display(Name = "s E T")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_ET{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_ETC 
        /// </Resumen> 
        [Display(Name = "s E T C")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_ETC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_Rectores 
        /// </Resumen> 
        [Display(Name = "s Rectores")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_Rectores{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





