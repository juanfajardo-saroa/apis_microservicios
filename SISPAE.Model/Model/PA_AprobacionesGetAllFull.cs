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
     /// Clase Model Base para  PA_AprobacionesGetAllFull
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_AprobacionesGetAllFullModelBase : ModelObject
    {
		    public PA_AprobacionesGetAllFullModelBase() 
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
        public int id{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_ETC 
        /// </Resumen> 
        [Display(Name = "E T C")] 
        public int? ID_ETC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_User 
        /// </Resumen> 
        [Display(Name = "User")] 
        public string? ID_User{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_AccionAprobacion 
        /// </Resumen> 
        [Display(Name = "Accion Aprobacion")] 
        public int? ID_AccionAprobacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id_Secciones 
        /// </Resumen> 
        [Display(Name = "Secciones")] 
        public int? Id_Secciones{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: DocumentoParaAprobar 
        /// </Resumen> 
        [Display(Name = "Documento Para Aprobar")] 
        [DataType (DataType.MultilineText)]   
        public String? DocumentoParaAprobar{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FechaAprobacion 
        /// </Resumen> 
        [Display(Name = "Fecha Aprobacion")] 
        [DataType (DataType.MultilineText)]   
        public String? FechaAprobacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Fecha 
        /// </Resumen> 
        [Display(Name = "Fecha")] 
        [DataType (DataType.MultilineText)]   
        public String? Fecha{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Accion 
        /// </Resumen> 
        [Display(Name = "Accion")] 
        [DataType (DataType.MultilineText)]   
        public String? Accion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Observaciones 
        /// </Resumen> 
        [Display(Name = "Observaciones")] 
        [DataType (DataType.MultilineText)]   
        public String? Observaciones{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id_Ubicacion 
        /// </Resumen> 
        [Display(Name = "Ubicacion")] 
        public int? Id_Ubicacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: UbicacionOrigen 
        /// </Resumen> 
        [Display(Name = "Ubicacion Origen")] 
        [DataType (DataType.MultilineText)]   
        public String? UbicacionOrigen{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: plazoPorAprobar 
        /// </Resumen> 
        [Display(Name = "plazo Por Aprobar")] 
        [DataType (DataType.MultilineText)]   
        public String? plazoPorAprobar{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: auditoria 
        /// </Resumen> 
        [Display(Name = "auditoria")] 
        [DataType (DataType.MultilineText)]   
        public String? auditoria{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





