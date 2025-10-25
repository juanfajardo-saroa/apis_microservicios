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
     /// Clase Model Base para  PA_NutrientesAlimentosGetAllWithRelation
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_NutrientesAlimentosGetAllWithRelationModelBase : ModelObject
    {
		    public PA_NutrientesAlimentosGetAllWithRelationModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Nutriente 
        /// </Resumen> 
        [Display(Name = "Nutriente")] 
        public int? ID_Nutriente{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_AlimentosICBF 
        /// </Resumen> 
        [Display(Name = "Alimentos I C B F")] 
        public int? ID_AlimentosICBF{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Aporte 
        /// </Resumen> 
        [Display(Name = "Aporte")] 
        [DataType (DataType.MultilineText)]   
        public String? Aporte{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_AlimentosICBF 
        /// </Resumen> 
        [Display(Name = "s Alimentos I C B F")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_AlimentosICBF{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad:  sID_Nutriente 
        /// </Resumen> 
        [Display(Name = "s Nutriente")] 
        [DataType (DataType.MultilineText)]   
        public String?  sID_Nutriente{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





