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
     /// Clase Model Base para  PA_AporteNutricionalAlimentoICBF
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_AporteNutricionalAlimentoICBFModelBase : ModelObject
    {
		    public PA_AporteNutricionalAlimentoICBFModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Nombre 
        /// </Resumen> 
        [Display(Name = "Nombre")] 
        [DataType (DataType.MultilineText)]   
        public String? Nombre{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PesoBruto 
        /// </Resumen> 
        [Display(Name = "Peso Bruto")] 
        public Double? PesoBruto{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PorcentajeComestible 
        /// </Resumen> 
        [Display(Name = "Porcentaje Comestible")] 
        public Double? PorcentajeComestible{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: IntercambioEstandarizado 
        /// </Resumen> 
        [Display(Name = "Intercambio Estandarizado")] 
        public Double? IntercambioEstandarizado{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





