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
     /// Clase Model Base para  PA_PlanAlistamientoDocumentosPAGetAllWithRelation
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_PlanAlistamientoDocumentosPAGetAllWithRelationModelBase : ModelObject
    {
		private DateTime _createdFechaVersion; 
    public PA_PlanAlistamientoDocumentosPAGetAllWithRelationModelBase() 
    {  
    _createdFechaVersion= DateTime.MinValue; 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_PlanAlistamiento 
        /// </Resumen> 
        [Display(Name = "Plan Alistamiento")] 
        public int? ID_PlanAlistamiento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Vigencia 
        /// </Resumen> 
        [Display(Name = "Vigencia")] 
        public int? ID_Vigencia{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Estado 
        /// </Resumen> 
        [Display(Name = "Estado")] 
        public int? ID_Estado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PathDocumento 
        /// </Resumen> 
        [Display(Name = "Path Documento")] 
        [DataType (DataType.MultilineText)]   
        public String? PathDocumento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FechaVersion 
        /// </Resumen> 
        [Display(Name = "Fecha Version")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? FechaVersion

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NombreArchivo 
        /// </Resumen> 
        [Display(Name = "Nombre Archivo")] 
        [DataType (DataType.MultilineText)]   
        public String? NombreArchivo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_DocumentoPA 
        /// </Resumen> 
        [Display(Name = "s Documento P A")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_DocumentoPA{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





