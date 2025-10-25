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
     /// Clase Model Base para  CaracterizacionInfraestructura
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class CaracterizacionInfraestructuraModelBase : ModelObject
    {
		private DateTime _createdFechaCaracterizacion; 
private DateTime _createdFechaModificacion; 
private DateTime _createdCHS_Fecha; 
    public CaracterizacionInfraestructuraModelBase() 
    {  
    _createdFechaCaracterizacion= DateTime.MinValue; 
    _createdFechaModificacion= DateTime.MinValue; 
    _createdCHS_Fecha= DateTime.MinValue; 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Sede 
        /// </Resumen> 
        [Display(Name = "Sede")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int ID_Sede{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sID_Sede { get; set; }
        /// 
 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Inventario 
        /// </Resumen> 
        [Display(Name = "Inventario")] 
        public int? ID_Inventario{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sID_Inventario { get; set; }
        /// 
 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FechaCaracterizacion 
        /// </Resumen> 
        [Display(Name = "Fecha Caracterizacion")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime FechaCaracterizacion
                {
                     get
                     { return (_createdFechaCaracterizacion== DateTime.MinValue) ? DateTime.Now : _createdFechaCaracterizacion;
                     }
                     set { _createdFechaCaracterizacion = value; }

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FechaModificacion 
        /// </Resumen> 
        [Display(Name = "Fecha Modificacion")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime FechaModificacion
                {
                     get
                     { return (_createdFechaModificacion== DateTime.MinValue) ? DateTime.Now : _createdFechaModificacion;
                     }
                     set { _createdFechaModificacion = value; }

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Descripcion 
        /// </Resumen> 
        [Display(Name = "Descripcion")] 
        [StringLength(2000 , ErrorMessage = " El campo {0} no debe tener mas de 2000 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? Descripcion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CHS_Fecha 
        /// </Resumen> 
        [Display(Name = "C H S Fecha")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? CHS_Fecha

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CHS_Documento 
        /// </Resumen> 
        [Display(Name = "C H S Documento")] 
        public Byte[]? CHS_Documento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: RutaArchivo 
        /// </Resumen> 
        [Display(Name = "Ruta Archivo")] 
        [StringLength(1000 , ErrorMessage = " El campo {0} no debe tener mas de 1000 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? RutaArchivo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: auditoria 
        /// </Resumen> 
        [Display(Name = "auditoria")] 
        [DataType (DataType.MultilineText)]   
        public String? auditoria{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SuficienciaDotacion 
        /// </Resumen> 
        [Display(Name = "Suficiencia Dotacion")] 
        public Decimal? SuficienciaDotacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id_TipoEstadoCaracterizacion 
        /// </Resumen> 
        [Display(Name = "Tipo Estado Caracterizacion")] 
        public int? Id_TipoEstadoCaracterizacion{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sId_TipoEstadoCaracterizacion { get; set; }
        /// 
 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_TipoModalidadComplementoSugerida 
        /// </Resumen> 
        [Display(Name = "Tipo Modalidad Complemento Sugerida")] 
        public int? id_TipoModalidadComplementoSugerida{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sid_TipoModalidadComplementoSugerida { get; set; }
        /// 
 
        public String? filtro { get; set; }
#endregion Public Members    



    }
}





