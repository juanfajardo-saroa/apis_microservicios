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
     /// Clase Model Base para  PA_ValidaFrecuencia
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_ValidaFrecuenciaModelBase : ModelObject
    {
		    public PA_ValidaFrecuenciaModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_SubGrupoAlimento 
        /// </Resumen> 
        [Display(Name = "Sub Grupo Alimento")] 
        public int? ID_SubGrupoAlimento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: frecuencia 
        /// </Resumen> 
        [Display(Name = "frecuencia")] 
        public int? frecuencia{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: prestados 
        /// </Resumen> 
        [Display(Name = "prestados")] 
        public int? prestados{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: pasa 
        /// </Resumen> 
        [Display(Name = "pasa")] 
        [DataType (DataType.MultilineText)]   
        public String? pasa{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PasaTodo 
        /// </Resumen> 
        [Display(Name = "Pasa Todo")] 
        [DataType (DataType.MultilineText)]   
        public String? PasaTodo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SubGrupo 
        /// </Resumen> 
        [Display(Name = "Sub Grupo")] 
        [DataType (DataType.MultilineText)]   
        public String? SubGrupo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: idComponente 
        /// </Resumen> 
        [Display(Name = "id Componente")] 
        public int? idComponente{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Componente 
        /// </Resumen> 
        [Display(Name = "Componente")] 
        [DataType (DataType.MultilineText)]   
        public String? Componente{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





