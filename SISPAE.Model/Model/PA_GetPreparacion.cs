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
     /// Clase Model Base para  PA_GetPreparacion
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_GetPreparacionModelBase : ModelObject
    {
		    public PA_GetPreparacionModelBase() 
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
        public int? Id{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Preparacion 
        /// </Resumen> 
        [Display(Name = "Preparacion")] 
        [DataType (DataType.MultilineText)]   
        public String? Preparacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PreparacionMixta 
        /// </Resumen> 
        [Display(Name = "Preparacion Mixta")] 
        public int? PreparacionMixta{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PreparacionBebida 
        /// </Resumen> 
        [Display(Name = "Preparacion Bebida")] 
        public int? PreparacionBebida{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ModeloOperacion 
        /// </Resumen> 
        [Display(Name = "Modelo Operacion")] 
        public int? ModeloOperacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ModalidadTipoRacion 
        /// </Resumen> 
        [Display(Name = "Modalidad Tipo Racion")] 
        public int? ModalidadTipoRacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TipoRacion 
        /// </Resumen> 
        [Display(Name = "Tipo Racion")] 
        public int? TipoRacion{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





