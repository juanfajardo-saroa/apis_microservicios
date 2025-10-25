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
     /// Clase Model Base para  PA_AprobacionesGetAllWithRel
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_AprobacionesGetAllWithRelModelBase : ModelObject
    {
		private DateTime _createdFechaAprobacion; 
private DateTime _createdFecha; 
    public PA_AprobacionesGetAllWithRelModelBase() 
    {  
    _createdFechaAprobacion= DateTime.MinValue; 
    _createdFecha= DateTime.MinValue; 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_ETC 
        /// </Resumen> 
        [Display(Name = "E T C")] 
        public int? ID_ETC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_User 
        /// </Resumen> 
        [Display(Name = "User")] 
        [DataType (DataType.MultilineText)]   
        public String? ID_User{ get; set; }

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
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? FechaAprobacion

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Fecha 
        /// </Resumen> 
        [Display(Name = "Fecha")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? Fecha

                {
                     get;
                     set;

                }
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_AccionAprobacion 
        /// </Resumen> 
        [Display(Name = "s Accion Aprobacion")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_AccionAprobacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sId_Secciones 
        /// </Resumen> 
        [Display(Name = "s Secciones")] 
        [DataType (DataType.MultilineText)]   
        public String? sId_Secciones{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sId_Ubicacion 
        /// </Resumen> 
        [Display(Name = "s Ubicacion")] 
        [DataType (DataType.MultilineText)]   
        public String? sId_Ubicacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_ETC 
        /// </Resumen> 
        [Display(Name = "s E T C")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_ETC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_User 
        /// </Resumen> 
        [Display(Name = "s User")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_User{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_Submodulos 
        /// </Resumen> 
        [Display(Name = "s Submodulos")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_Submodulos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_Subsistemas 
        /// </Resumen> 
        [Display(Name = "s Subsistemas")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_Subsistemas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Submodulos 
        /// </Resumen> 
        [Display(Name = "Submodulos")] 
        public int? ID_Submodulos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Subsistemas 
        /// </Resumen> 
        [Display(Name = "Subsistemas")] 
        public int? ID_Subsistemas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_Rol 
        /// </Resumen> 
        [Display(Name = "Rol")] 
        [DataType (DataType.MultilineText)]   
        public String? id_Rol{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_rol 
        /// </Resumen> 
        [Display(Name = "srol")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_rol{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





