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
     /// Clase Model Base para  PA_QuincenaEntregaRacionesGetxGrado
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_QuincenaEntregaRacionesGetxGradoModelBase : ModelObject
    {
		private DateTime _createdFechaEntrega; 
    public PA_QuincenaEntregaRacionesGetxGradoModelBase() 
    {  
    _createdFechaEntrega= DateTime.MinValue; 
    }  
        

		

        ///Definicion de miembros o metodos privados    
#region Private Members 
#endregion Private Members    


        ///Definicion de miembros o metodos publicos  - Property Declarations  
#region Public Members 
 
        ///  Estas son las propiedades Base de esta clase  
        ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FechaEntrega 
        /// </Resumen> 
        [Display(Name = "Fecha Entrega")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? FechaEntrega

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: racionesDiarias 
        /// </Resumen> 
        [Display(Name = "raciones Diarias")] 
        public int? racionesDiarias{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: RacionesPreparadas 
        /// </Resumen> 
        [Display(Name = "Raciones Preparadas")] 
        public int? RacionesPreparadas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoReporteEntrega 
        /// </Resumen> 
        [Display(Name = "Tipo Reporte Entrega")] 
        public int? ID_TipoReporteEntrega{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Justificacion 
        /// </Resumen> 
        [Display(Name = "Justificacion")] 
        [DataType (DataType.MultilineText)]   
        public String? Justificacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_QuincenaEntregaRacion 
        /// </Resumen> 
        [Display(Name = "Quincena Entrega Racion")] 
        public int? ID_QuincenaEntregaRacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: pathDocumentoContrato 
        /// </Resumen> 
        [Display(Name = "path Documento Contrato")] 
        [DataType (DataType.MultilineText)]   
        public String? pathDocumentoContrato{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id 
        /// </Resumen> 
        [Display(Name = "SinNombre")] 
        public int? id{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: nombreTipoReporte 
        /// </Resumen> 
        [Display(Name = "nombre Tipo Reporte")] 
        [DataType (DataType.MultilineText)]   
        public String? nombreTipoReporte{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





