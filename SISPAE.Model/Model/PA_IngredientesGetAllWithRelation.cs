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
     /// Clase Model Base para  PA_IngredientesGetAllWithRelation
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_IngredientesGetAllWithRelationModelBase : ModelObject
    {
		    public PA_IngredientesGetAllWithRelationModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_AlimentosICBF 
        /// </Resumen> 
        [Display(Name = "Alimentos I C B F")] 
        public int? ID_AlimentosICBF{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoNivelEducativo 
        /// </Resumen> 
        [Display(Name = "Tipo Nivel Educativo")] 
        public int? ID_TipoNivelEducativo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Preparacion 
        /// </Resumen> 
        [Display(Name = "Preparacion")] 
        public int? ID_Preparacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoComplemento 
        /// </Resumen> 
        [Display(Name = "Tipo Complemento")] 
        [DataType (DataType.MultilineText)]   
        public String? ID_TipoComplemento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PesoBruto 
        /// </Resumen> 
        [Display(Name = "Peso Bruto")] 
        [DataType (DataType.MultilineText)]   
        public String? PesoBruto{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PesoNeto 
        /// </Resumen> 
        [Display(Name = "Peso Neto")] 
        [DataType (DataType.MultilineText)]   
        public String? PesoNeto{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PorcentajeComestible 
        /// </Resumen> 
        [Display(Name = "Porcentaje Comestible")] 
        [DataType (DataType.MultilineText)]   
        public String? PorcentajeComestible{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: IntercambioEstandarizado 
        /// </Resumen> 
        [Display(Name = "Intercambio Estandarizado")] 
        [DataType (DataType.MultilineText)]   
        public String? IntercambioEstandarizado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_AlimentosICBF 
        /// </Resumen> 
        [Display(Name = "s Alimentos I C B F")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_AlimentosICBF{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_TipoNivelEducativo 
        /// </Resumen> 
        [Display(Name = "s Tipo Nivel Educativo")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_TipoNivelEducativo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_Preparacion 
        /// </Resumen> 
        [Display(Name = "s Preparacion")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_Preparacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_TipoComplemento 
        /// </Resumen> 
        [Display(Name = "s Tipo Complemento")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_TipoComplemento{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





