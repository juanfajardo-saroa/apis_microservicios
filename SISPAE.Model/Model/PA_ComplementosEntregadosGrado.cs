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
     /// Clase Model Base para  PA_ComplementosEntregadosGrado
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_ComplementosEntregadosGradoModelBase : ModelObject
    {
		private DateTime _createdfecha; 
    public PA_ComplementosEntregadosGradoModelBase() 
    {  
    _createdfecha= DateTime.MinValue; 
    }  
        

		

        ///Definicion de miembros o metodos privados    
#region Private Members 
#endregion Private Members    


        ///Definicion de miembros o metodos publicos  - Property Declarations  
#region Public Members 
 
        ///  Estas son las propiedades Base de esta clase  
        ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_EntregaRacion 
        /// </Resumen> 
        [Display(Name = "Entrega Racion")] 
        public int? id_EntregaRacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: fecha 
        /// </Resumen> 
        [Display(Name = "fecha")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? fecha

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: complementosAsignados 
        /// </Resumen> 
        [Display(Name = "complementos Asignados")] 
        public int? complementosAsignados{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: complementosPreparados 
        /// </Resumen> 
        [Display(Name = "complementos Preparados")] 
        public int? complementosPreparados{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EstadoReporte 
        /// </Resumen> 
        [Display(Name = "Estado Reporte")] 
        [DataType (DataType.MultilineText)]   
        public String? EstadoReporte{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: colorEstado 
        /// </Resumen> 
        [Display(Name = "color Estado")] 
        [DataType (DataType.MultilineText)]   
        public String? colorEstado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: justificacion 
        /// </Resumen> 
        [Display(Name = "justificacion")] 
        [DataType (DataType.MultilineText)]   
        public String? justificacion{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





