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
    /// Clase Model Base para  Repositorios
    /// No haga cambios sobre esta clase,
    /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
    /// esta es una clase abstracta que decora la clase principal
    /// </Resumen>


    public class RepositoriosModelBase : ModelObject
    {
        private DateTime _createdfechaArchivo;
        private DateTime _createdfechaCarga;
        public RepositoriosModelBase()
        {
            _createdfechaArchivo = DateTime.MinValue;
            _createdfechaCarga = DateTime.MinValue;
        }




        ///Definicion de miembros o metodos privados    
        #region Private Members 
        #endregion Private Members    
        ///    

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
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        public int id { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: idTipoArchivo 
        /// </Resumen> 
        [Display(Name = "id Tipo Archivo")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        public int idTipoArchivo { get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sidTipoArchivo { get; set; }
        /// 

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: idCategoria 
        /// </Resumen> 
        [Display(Name = "id Categoria")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        public int idCategoria { get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sidCategoria { get; set; }
        /// 

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: idVigencia 
        /// </Resumen> 
        [Display(Name = "id Vigencia")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        public int idVigencia { get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sidVigencia { get; set; }
        /// 

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PAHTArchivo 
        /// </Resumen> 
        [Display(Name = "P A H T Archivo")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        [StringLength(4000, ErrorMessage = " El campo {0} no debe tener mas de 4000 caracteres.")]
        [DataType(DataType.MultilineText)]
        public String PAHTArchivo { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Nombre 
        /// </Resumen> 
        [Display(Name = "Nombre")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? Nombre{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Descripcion 
        /// </Resumen> 
        [Display(Name = "Descripcion")] 
        [StringLength(8000 , ErrorMessage = " El campo {0} no debe tener mas de 8000 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? Descripcion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: fechaArchivo 
        /// </Resumen> 
        [Display(Name = "fecha Archivo")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        [DataType(DataType.Date, ErrorMessage = "En el campo  {0} debe ingresar una fecha valida !")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime fechaArchivo

        {
            get
            {
                return (_createdfechaArchivo == DateTime.MinValue) ? DateTime.Now : _createdfechaArchivo;
            }
            set { _createdfechaArchivo = value; }

        }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: fechaCarga 
        /// </Resumen> 
        [Display(Name = "fecha Carga")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        [DataType(DataType.Date, ErrorMessage = "En el campo  {0} debe ingresar una fecha valida !")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime fechaCarga

        {
            get
            {
                return (_createdfechaCarga == DateTime.MinValue) ? DateTime.Now : _createdfechaCarga;
            }
            set { _createdfechaCarga = value; }

        }


        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_TipoModeloOperacion 
        /// </Resumen> 
        [Display(Name = "Tipo Modelo Operacion")] 
        public int? id_TipoModeloOperacion{ get; set; }


        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sidTipoModeloOperacion { get; set; }
        /// 

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NombreResolucion 
        /// </Resumen> 
        [Display(Name = "Nombre Resolucion")] 
        [StringLength(200 , ErrorMessage = " El campo {0} no debe tener mas de 200 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? NombreResolucion{ get; set; }




        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Descripcion 
        /// </Resumen> 
        [Display(Name = "Tamano Archivo")]
        public String tamanoArchivo { get; set; }

        public int DiferenciaHoras { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: auditoria 
        /// </Resumen> 
        [Display(Name = "auditoria")]
        [DataType(DataType.MultilineText)]
        public String auditoria { get; set; }

       
        public String? filtro { get; set; }




      


        #endregion Public Members    



    }
}





