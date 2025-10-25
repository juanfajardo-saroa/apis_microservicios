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
     /// Clase Model Base para  PA_SedesGetAllWithRelation
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_SedesGetAllWithRelationModelBase : ModelObject
    {
		    public PA_SedesGetAllWithRelationModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_lE 
        /// </Resumen> 
        [Display(Name = "l E")] 
        public int? ID_lE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Zona 
        /// </Resumen> 
        [Display(Name = "Zona")] 
        public int? ID_Zona{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_GrupoAnalisis 
        /// </Resumen> 
        [Display(Name = "Grupo Analisis")] 
        public int? ID_GrupoAnalisis{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_ETC 
        /// </Resumen> 
        [Display(Name = "E T C")] 
        public int? ID_ETC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Divipola 
        /// </Resumen> 
        [Display(Name = "Divipola")] 
        public int? ID_Divipola{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoAcceso 
        /// </Resumen> 
        [Display(Name = "Tipo Acceso")] 
        public int? ID_TipoAcceso{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CodigoDane 
        /// </Resumen> 
        [Display(Name = "Codigo Dane")] 
        [DataType (DataType.MultilineText)]   
        public String? CodigoDane{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Nombre 
        /// </Resumen> 
        [Display(Name = "Nombre")] 
        [DataType (DataType.MultilineText)]   
        public String? Nombre{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Direccion 
        /// </Resumen> 
        [Display(Name = "Direccion")] 
        [DataType (DataType.MultilineText)]   
        public String? Direccion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Telefono 
        /// </Resumen> 
        [Display(Name = "Telefono")] 
        [DataType(DataType.PhoneNumber)] 
        public String? Telefono{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Etnico 
        /// </Resumen> 
        [Display(Name = "Etnico")] 
        [DataType (DataType.MultilineText)]   
        public String? Etnico{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PriorizacionPAE 
        /// </Resumen> 
        [Display(Name = "Priorizacion P A E")] 
        public Boolean? PriorizacionPAE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_Divipola 
        /// </Resumen> 
        [Display(Name = "s Divipola")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_Divipola{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_ETC 
        /// </Resumen> 
        [Display(Name = "s E T C")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_ETC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_GrupoAnalisis 
        /// </Resumen> 
        [Display(Name = "s Grupo Analisis")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_GrupoAnalisis{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_lE 
        /// </Resumen> 
        [Display(Name = "sl E")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_lE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_Zona 
        /// </Resumen> 
        [Display(Name = "s Zona")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_Zona{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_TipoAcceso 
        /// </Resumen> 
        [Display(Name = "s Tipo Acceso")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_TipoAcceso{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





