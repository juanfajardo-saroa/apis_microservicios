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
    /// Clase Model Base para  AuditoriaSegRaciones
    /// No haga cambios sobre esta clase,
    /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
    /// esta es una clase abstracta que decora la clase principal
    /// </Resumen>


    public class AuditoriaSegRacionesModelBase : ModelObject
        {
        private DateTime _createdFechaCambio;
        public AuditoriaSegRacionesModelBase()
            {
            _createdFechaCambio = DateTime.MinValue;
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
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        public int id { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_User 
        /// </Resumen> 
        [Display(Name = "User")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        [StringLength(128, ErrorMessage = " El campo {0} no debe tener mas de 128 caracteres.")]
        [DataType(DataType.MultilineText)]
        public String ID_User { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_QuincenaEntregaRacion 
        /// </Resumen> 
        [Display(Name = "Quincena Entrega Racion")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        public int ID_QuincenaEntregaRacion { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoOperacion 
        /// </Resumen> 
        [Display(Name = "Tipo Operacion")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        public int ID_TipoOperacion { get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sID_TipoOperacion { get; set; }
        /// 



        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sID_QuincenaEntregaRacion { get; set; }
        /// 



        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FechaCambio 
        /// </Resumen> 
        [Display(Name = "Fecha Cambio")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        [DataType(DataType.Date, ErrorMessage = "En el campo  {0} debe ingresar una fecha valida !")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime FechaCambio
            {
            get
                {
                return (_createdFechaCambio == DateTime.MinValue) ? DateTime.Now : _createdFechaCambio;
                }
            set { _createdFechaCambio = value; }

            }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Valor 
        /// </Resumen> 
        [Display(Name = "Valor")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        [StringLength(100, ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")]
        [DataType(DataType.Text)]
        public String Valor { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: auditoria 
        /// </Resumen> 
        [Display(Name = "auditoria")]
        [DataType(DataType.MultilineText)]
        public String? auditoria { get; set; }

        public String? filtro { get; set; }
        #endregion Public Members    



        }
    }





