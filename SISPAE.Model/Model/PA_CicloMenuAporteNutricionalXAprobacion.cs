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
     /// Clase Model Base para  PA_CicloMenuAporteNutricionalXAprobacion
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_CicloMenuAporteNutricionalXAprobacionModelBase : ModelObject
    {
		    public PA_CicloMenuAporteNutricionalXAprobacionModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Columna 
        /// </Resumen> 
        [Display(Name = "Columna")] 
        [DataType (DataType.MultilineText)]   
        public String? Columna{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Componente 
        /// </Resumen> 
        [Display(Name = "Componente")] 
        public int? Componente{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: En_Energia 
        /// </Resumen> 
        [Display(Name = "En Energia")] 
        public Decimal? En_Energia{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Ma_Proteina 
        /// </Resumen> 
        [Display(Name = "Ma Proteina")] 
        public Decimal? Ma_Proteina{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Ma_CarbohidratosTotales 
        /// </Resumen> 
        [Display(Name = "Ma Carbohidratos Totales")] 
        public Decimal? Ma_CarbohidratosTotales{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Ma_GrasasTotales 
        /// </Resumen> 
        [Display(Name = "Ma Grasas Totales")] 
        public Decimal? Ma_GrasasTotales{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Mi_Calcio 
        /// </Resumen> 
        [Display(Name = "Mi Calcio")] 
        public Decimal? Mi_Calcio{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Mi_Hierro 
        /// </Resumen> 
        [Display(Name = "Mi Hierro")] 
        public Decimal? Mi_Hierro{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Mi_Sodio 
        /// </Resumen> 
        [Display(Name = "Mi Sodio")] 
        public Decimal? Mi_Sodio{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Mi_VitaminaA 
        /// </Resumen> 
        [Display(Name = "Mi Vitamina A")] 
        public Decimal? Mi_VitaminaA{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Mi_Zinc 
        /// </Resumen> 
        [Display(Name = "Mi Zinc")] 
        public Decimal? Mi_Zinc{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Ma_GrasasSaturadas 
        /// </Resumen> 
        [Display(Name = "Ma Grasas Saturadas")] 
        public Decimal? Ma_GrasasSaturadas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_NivelEducativo 
        /// </Resumen> 
        [Display(Name = "Nivel Educativo")] 
        public int? ID_NivelEducativo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NivelEducativo 
        /// </Resumen> 
        [Display(Name = "Nivel Educativo")] 
        [DataType (DataType.MultilineText)]   
        public String? NivelEducativo{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





