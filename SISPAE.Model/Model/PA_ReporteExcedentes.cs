/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano			    :2022
/// Arquitectura	:Patron MVC ASP Net Core, Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa			:MODEL (Model Entity Layer) - Capa Model (Source: MVC7_DAL_ModelBase.CS)  Partial Interface 
/// </Derechos_Reservados>


using System.ComponentModel.DataAnnotations;

namespace SISPAE.Model
    {
    /// <Resumen>
    /// Clase Model Base para  PA_ReporteExcedentes
    /// No haga cambios sobre esta clase,
    /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
    /// esta es una clase abstracta que decora la clase principal
    /// </Resumen>


    public class PA_ReporteExcedentesModelBase : ModelObject
        {
        private DateTime _createdFechaReporte;
        public PA_ReporteExcedentesModelBase()
            {
            _createdFechaReporte = DateTime.MinValue;
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
        public int? id { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_sede 
        /// </Resumen> 
        [Display(Name = "sede")]
        public int? id_sede { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Sede 
        /// </Resumen> 
        [Display(Name = "Sede")]
        [DataType(DataType.MultilineText)]
        public String? Sede { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_GradoSedeJornada 
        /// </Resumen> 
        [Display(Name = "Grado Sede Jornada")]
        public int? id_GradoSedeJornada { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_Grado 
        /// </Resumen> 
        [Display(Name = "Grado")]
        public int? id_Grado { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Grado 
        /// </Resumen> 
        [Display(Name = "Grado")]
        [DataType(DataType.MultilineText)]
        public String? Grado { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CantExcedentes 
        /// </Resumen> 
        [Display(Name = "Cant Excedentes")]
        public int? CantExcedentes { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoDestinoRacion 
        /// </Resumen> 
        [Display(Name = "Tipo Destino Complemento")]
        public int? ID_TipoDestinoComplemento { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: DestinoRacion 
        /// </Resumen> 
        [Display(Name = "Destino Complemento")]
        [DataType(DataType.MultilineText)]
        public String? DestinoComplemento { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id_TipoEstadoExcedentesRaciones 
        /// </Resumen> 
        [Display(Name = "Tipo Estado Excedentes Complemento")]
        public int? Id_TipoEstadoExcedentesComplementos { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EstadoExcedentesRaciones 
        /// </Resumen> 
        [Display(Name = "Estado Excedentes Complemento")]
        [DataType(DataType.MultilineText)]
        public String? EstadoExcedentesComplementos { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Justificacion 
        /// </Resumen> 
        [Display(Name = "Justificacion")]
        [DataType(DataType.MultilineText)]
        public String? Justificacion { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FechaReporte 
        /// </Resumen> 
        [Display(Name = "Fecha Reporte")]
        [DataType(DataType.Date, ErrorMessage = "En el campo  {0} debe ingresar una fecha valida !")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? FechaReporte

            {
            get;
            set;

            }
        public String? filtro { get; set; }
        #endregion Public Members    



        }
    }





