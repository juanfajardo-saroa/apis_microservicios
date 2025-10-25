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
     /// Clase Model Base para  Aprobaciones
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class AprobacionesModelBase : ModelObject
    {
		private DateTime _createdFechaAprobacion; 
private DateTime _createdFecha; 
private DateTime _createdplazoPorAprobar; 
    public AprobacionesModelBase() 
    {  
    _createdFechaAprobacion= DateTime.MinValue; 
    _createdFecha= DateTime.MinValue; 
    _createdplazoPorAprobar= DateTime.MinValue; 
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
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id 
        /// </Resumen> 
        [Display(Name = "SinNombre")] 
                         
        public string? sID  
                {
                     get;
                     set;
                }
        [Display(Name = "SinNombre")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int id{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_ETC 
        /// </Resumen> 
        [Display(Name = "E T C")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int ID_ETC{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sID_ETC { get; set; }
        /// 
 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_User 
        /// </Resumen> 
        [Display(Name = "User")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(450 , ErrorMessage = " El campo {0} no debe tener mas de 450 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String ID_User{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sID_User { get; set; }
        /// 
 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_AccionAprobacion 
        /// </Resumen> 
        [Display(Name = "Accion Aprobacion")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int ID_AccionAprobacion{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sID_AccionAprobacion { get; set; }
        /// 
 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id_Secciones 
        /// </Resumen> 
        [Display(Name = "Secciones")] 
        public int? Id_Secciones{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sId_Secciones { get; set; }
        /// 
 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: DocumentoParaAprobar 
        /// </Resumen> 
        [Display(Name = "Documento Para Aprobar")] 
        [StringLength(500 , ErrorMessage = " El campo {0} no debe tener mas de 500 caracteres.")] 
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
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime Fecha
                {
                     get
                     { return (_createdFecha== DateTime.MinValue) ? DateTime.Now : _createdFecha;
                     }
                     set { _createdFecha = value; }

                }
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
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [DataType (DataType.MultilineText)]   
        public String Observaciones{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id_Ubicacion 
        /// </Resumen> 
        [Display(Name = "Ubicacion")] 
        public int? Id_Ubicacion{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sId_Ubicacion { get; set; }
        /// 
 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: UbicacionOrigen 
        /// </Resumen> 
        [Display(Name = "Ubicacion Origen")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? UbicacionOrigen{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: auditoria 
        /// </Resumen> 
        [Display(Name = "auditoria")] 
        [DataType (DataType.MultilineText)]   
        public String? auditoria{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: plazoPorAprobar 
        /// </Resumen> 
        [Display(Name = "plazo Por Aprobar")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime plazoPorAprobar
                {
                     get
                     { return (_createdplazoPorAprobar== DateTime.MinValue) ? DateTime.Now : _createdplazoPorAprobar;
                     }
                     set { _createdplazoPorAprobar = value; }

                }
        public String? filtro { get; set; }
#endregion Public Members    



    }
}





