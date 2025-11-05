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
     /// Clase Model Base para  PA_RiesgoETCModeloOper
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_RiesgoETCModeloOperModelBase : ModelObject
    {
		    public PA_RiesgoETCModeloOperModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_ETC 
        /// </Resumen> 
        [Display(Name = "E T C")] 
        public int? id_ETC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_ModeloOper 
        /// </Resumen> 
        [Display(Name = "Modelo Oper")] 
        public int? id_ModeloOper{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ModeloOperativo 
        /// </Resumen> 
        [Display(Name = "Modelo Operativo")] 
        [DataType (DataType.MultilineText)]   
        public String? ModeloOperativo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CantidadSede 
        /// </Resumen> 
        [Display(Name = "Cantidad Sede")] 
        [DataType (DataType.MultilineText)]   
        public String? CantidadSede{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PriorizadaPAE 
        /// </Resumen> 
        [Display(Name = "Priorizada P A E")] 
        public Boolean? PriorizadaPAE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PorcentajeRPS 
        /// </Resumen> 
        [Display(Name = "Porcentaje R P S")] 
        public Decimal? PorcentajeRPS{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PorcentajeRI 
        /// </Resumen> 
        [Display(Name = "Porcentaje R I")] 
        public Decimal? PorcentajeRI{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PorcentajeCatering 
        /// </Resumen> 
        [Display(Name = "Porcentaje Catering")] 
        public Decimal? PorcentajeCatering{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ColorRPS 
        /// </Resumen> 
        [Display(Name = "Color R P S")] 
        [DataType (DataType.MultilineText)]   
        public String? ColorRPS{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ColorRI 
        /// </Resumen> 
        [Display(Name = "Color R I")] 
        [DataType (DataType.MultilineText)]   
        public String? ColorRI{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ColorCatering 
        /// </Resumen> 
        [Display(Name = "Color Catering")] 
        [DataType (DataType.MultilineText)]   
        public String? ColorCatering{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





