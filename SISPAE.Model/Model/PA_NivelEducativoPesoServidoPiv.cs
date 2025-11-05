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
     /// Clase Model Base para  PA_NivelEducativoPesoServidoPiv
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_NivelEducativoPesoServidoPivModelBase : ModelObject
    {
		    public PA_NivelEducativoPesoServidoPivModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoNivelEducativo 
        /// </Resumen> 
        [Display(Name = "Tipo Nivel Educativo")] 
        public int? ID_TipoNivelEducativo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NivelEducativo 
        /// </Resumen> 
        [Display(Name = "Nivel Educativo")] 
        [DataType (DataType.MultilineText)]   
        public String? NivelEducativo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ComplementoAlmuerzo 
        /// </Resumen> 
        [Display(Name = "Complemento Almuerzo")] 
        public Decimal? ComplementoAlmuerzo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ComplementoAM_PM 
        /// </Resumen> 
        [Display(Name = "Complemento A M P M")] 
        public Decimal? ComplementoAM_PM{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ComplementoAlmuerzoCualificado 
        /// </Resumen> 
        [Display(Name = "Complemento Almuerzo Cualificado")] 
        public Decimal? ComplementoAlmuerzoCualificado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SinComplemento 
        /// </Resumen> 
        [Display(Name = "Sin Complemento")] 
        public Decimal? SinComplemento{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





