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
     /// Clase Model Base para  PA_SedeJornadaMesSemana
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_SedeJornadaMesSemanaModelBase : ModelObject
    {
		    public PA_SedeJornadaMesSemanaModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_Municipio 
        /// </Resumen> 
        [Display(Name = "Municipio")] 
        public int? id_Municipio{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Municipio 
        /// </Resumen> 
        [Display(Name = "Municipio")] 
        [DataType (DataType.MultilineText)]   
        public String? Municipio{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_InstEducativa 
        /// </Resumen> 
        [Display(Name = "Inst Educativa")] 
        public int? id_InstEducativa{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: InstitEducativa 
        /// </Resumen> 
        [Display(Name = "Instit Educativa")] 
        [DataType (DataType.MultilineText)]   
        public String? InstitEducativa{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_sede 
        /// </Resumen> 
        [Display(Name = "sede")] 
        public int? id_sede{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Sede 
        /// </Resumen> 
        [Display(Name = "Sede")] 
        [DataType (DataType.MultilineText)]   
        public String? Sede{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id_Jornada 
        /// </Resumen> 
        [Display(Name = "Jornada")] 
        public int? Id_Jornada{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Jornada 
        /// </Resumen> 
        [Display(Name = "Jornada")] 
        [DataType (DataType.MultilineText)]   
        public String? Jornada{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumeroSemanas 
        /// </Resumen> 
        [Display(Name = "Numero Semanas")] 
        public int? NumeroSemanas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Semana_1 
        /// </Resumen> 
        [Display(Name = "Semana 1")] 
        [DataType (DataType.MultilineText)]   
        public String? Semana_1{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Semana_2 
        /// </Resumen> 
        [Display(Name = "Semana 2")] 
        [DataType (DataType.MultilineText)]   
        public String? Semana_2{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Semana_3 
        /// </Resumen> 
        [Display(Name = "Semana 3")] 
        [DataType (DataType.MultilineText)]   
        public String? Semana_3{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Semana_4 
        /// </Resumen> 
        [Display(Name = "Semana 4")] 
        [DataType (DataType.MultilineText)]   
        public String? Semana_4{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Semana_5 
        /// </Resumen> 
        [Display(Name = "Semana 5")] 
        [DataType (DataType.MultilineText)]   
        public String? Semana_5{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Semana_6 
        /// </Resumen> 
        [Display(Name = "Semana 6")] 
        [DataType (DataType.MultilineText)]   
        public String? Semana_6{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





