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
     /// Clase Model Base para  PA_AportesComponentePreparacionDet
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_AportesComponentePreparacionDetModelBase : ModelObject
    {
		    public PA_AportesComponentePreparacionDetModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_GrupoAlimentos 
        /// </Resumen> 
        [Display(Name = "Grupo Alimentos")] 
        public int? ID_GrupoAlimentos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: GrupoAlimentos 
        /// </Resumen> 
        [Display(Name = "Grupo Alimentos")] 
        [DataType (DataType.MultilineText)]   
        public String? GrupoAlimentos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_SubGrupoAlimentos 
        /// </Resumen> 
        [Display(Name = "Sub Grupo Alimentos")] 
        public int? ID_SubGrupoAlimentos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SubGrupoAlimentos 
        /// </Resumen> 
        [Display(Name = "Sub Grupo Alimentos")] 
        [DataType (DataType.MultilineText)]   
        public String? SubGrupoAlimentos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PesoNetoPreparacion 
        /// </Resumen> 
        [Display(Name = "Peso Neto Preparacion")] 
        public Double? PesoNetoPreparacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Estado 
        /// </Resumen> 
        [Display(Name = "Estado")] 
        public int? Estado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoComplemento 
        /// </Resumen> 
        [Display(Name = "Tipo Complemento")] 
        public int? ID_TipoComplemento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_NivelEducativo 
        /// </Resumen> 
        [Display(Name = "Nivel Educativo")] 
        public int? ID_NivelEducativo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TipoComplemento 
        /// </Resumen> 
        [Display(Name = "Tipo Complemento")] 
        [DataType (DataType.MultilineText)]   
        public String? TipoComplemento{ get; set; }

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





