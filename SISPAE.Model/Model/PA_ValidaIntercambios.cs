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
     /// Clase Model Base para  PA_ValidaIntercambios
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_ValidaIntercambiosModelBase : ModelObject
    {
		    public PA_ValidaIntercambiosModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_GrupoAlimento 
        /// </Resumen> 
        [Display(Name = "Grupo Alimento")] 
        public int? ID_GrupoAlimento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Grupo 
        /// </Resumen> 
        [Display(Name = "Grupo")] 
        [DataType (DataType.MultilineText)]   
        public String? Grupo{ get; set; }

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

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: minIntercambios 
        /// </Resumen> 
        [Display(Name = "min Intercambios")] 
        public Decimal? minIntercambios{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: MaxIntercambios 
        /// </Resumen> 
        [Display(Name = "Max Intercambios")] 
        public Decimal? MaxIntercambios{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: prestados 
        /// </Resumen> 
        [Display(Name = "prestados")] 
        public Decimal? prestados{ get; set; }

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

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





