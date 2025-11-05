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
     /// Clase Model Base para  PA_QuincenaEntregaRacionesGetDatosCompletos
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_QuincenaEntregaRacionesGetDatosCompletosModelBase : ModelObject
    {
		    public PA_QuincenaEntregaRacionesGetDatosCompletosModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: quincena 
        /// </Resumen> 
        [Display(Name = "quincena")] 
        [DataType (DataType.MultilineText)]   
        public String? quincena{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalRacionesProgramadas 
        /// </Resumen> 
        [Display(Name = "Total Raciones Programadas")] 
        public int? TotalRacionesProgramadas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: RacionesDiariasAsignadas 
        /// </Resumen> 
        [Display(Name = "Raciones Diarias Asignadas")] 
        public int? RacionesDiariasAsignadas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: RacionesDiariasaPreparar 
        /// </Resumen> 
        [Display(Name = "Raciones Diariasa Preparar")] 
        public int? RacionesDiariasaPreparar{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: RacionesDiariasAlmuerzo 
        /// </Resumen> 
        [Display(Name = "Raciones Diarias Almuerzo")] 
        public int? RacionesDiariasAlmuerzo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: RacionesDiariasComplemento 
        /// </Resumen> 
        [Display(Name = "Raciones Diarias Complemento")] 
        public int? RacionesDiariasComplemento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalRacionesPreparadas 
        /// </Resumen> 
        [Display(Name = "Total Raciones Preparadas")] 
        public int? TotalRacionesPreparadas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalRacionesNoPreparadas 
        /// </Resumen> 
        [Display(Name = "Total Raciones No Preparadas")] 
        public int? TotalRacionesNoPreparadas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: estadoQuincena 
        /// </Resumen> 
        [Display(Name = "estado Quincena")] 
        [DataType (DataType.MultilineText)]   
        public String? estadoQuincena{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





