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
     /// Clase Model Base para  PA_MatrizRiesgosSedeDetalleDimension
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_MatrizRiesgosSedeDetalleDimensionModelBase : ModelObject
    {
		    public PA_MatrizRiesgosSedeDetalleDimensionModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_sede 
        /// </Resumen> 
        [Display(Name = "sede")] 
        public int? id_sede{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_Dimension 
        /// </Resumen> 
        [Display(Name = "Dimension")] 
        public int? id_Dimension{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: RacPreparadaSitio 
        /// </Resumen> 
        [Display(Name = "Rac Preparada Sitio")] 
        public Decimal? RacPreparadaSitio{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: RacIndustrializada 
        /// </Resumen> 
        [Display(Name = "Rac Industrializada")] 
        public Decimal? RacIndustrializada{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Catering 
        /// </Resumen> 
        [Display(Name = "Catering")] 
        public Decimal? Catering{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ColorRacPreparadaSitio 
        /// </Resumen> 
        [Display(Name = "Color Rac Preparada Sitio")] 
        [DataType (DataType.MultilineText)]   
        public String? ColorRacPreparadaSitio{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ColorRacIndustrializada 
        /// </Resumen> 
        [Display(Name = "Color Rac Industrializada")] 
        [DataType (DataType.MultilineText)]   
        public String? ColorRacIndustrializada{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: colorCatering 
        /// </Resumen> 
        [Display(Name = "color Catering")] 
        [DataType (DataType.MultilineText)]   
        public String? colorCatering{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NombreDimension 
        /// </Resumen> 
        [Display(Name = "Nombre Dimension")] 
        [DataType (DataType.MultilineText)]   
        public String? NombreDimension{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





