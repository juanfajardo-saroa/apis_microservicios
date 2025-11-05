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
     /// Clase Model Base para  PA_AporteNutricionalProductoDet
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_AporteNutricionalProductoDetModelBase : ModelObject
    {
		    public PA_AporteNutricionalProductoDetModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoNutriente 
        /// </Resumen> 
        [Display(Name = "Tipo Nutriente")] 
        public int? ID_TipoNutriente{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TipoNutriente 
        /// </Resumen> 
        [Display(Name = "Tipo Nutriente")] 
        [DataType (DataType.MultilineText)]   
        public String? TipoNutriente{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Nutriente 
        /// </Resumen> 
        [Display(Name = "Nutriente")] 
        public int? ID_Nutriente{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Nutriente 
        /// </Resumen> 
        [Display(Name = "Nutriente")] 
        [DataType (DataType.MultilineText)]   
        public String? Nutriente{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Aporte 
        /// </Resumen> 
        [Display(Name = "Aporte")] 
        public Double? Aporte{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Grupo 
        /// </Resumen> 
        [Display(Name = "Grupo")] 
        [DataType (DataType.MultilineText)]   
        public String? Grupo{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





