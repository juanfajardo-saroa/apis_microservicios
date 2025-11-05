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
    /// Clase Model Base para  Users
    /// No haga cambios sobre esta clase,
    /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
    /// esta es una clase abstracta que decora la clase principal
    /// </Resumen>


    public class UsersModelBase : ModelObject
        {
        public UsersModelBase()
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
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        [StringLength(450, ErrorMessage = " El campo {0} no debe tener mas de 450 caracteres.")]
        [DataType(DataType.MultilineText)]




        ///  Estas son las propiedades Base de esta clase  
        ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id 
        /// </Resumen> 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el 
        /// 
        /// de la propiedad: id 
        /// </Resumen> 

        public string? sID
            {
            get;
            set;
            }
        public String id { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Email 
        /// </Resumen> 
        [Display(Name = "Email")]
        [StringLength(100, ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")]
        [EmailAddress(ErrorMessage = "Invalida la direción de correo electróncio ")]
        public String? Email { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Passwordhash 
        /// </Resumen> 
        [Display(Name = "Passwordhash")]
        [DataType(DataType.MultilineText)]
        public String? Passwordhash { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SegurityStamp 
        /// </Resumen> 
        [Display(Name = "Segurity Stamp")]
        [DataType(DataType.MultilineText)]
        public String? SegurityStamp { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: UserName 
        /// </Resumen> 
        [Display(Name = "User Name")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        [StringLength(100, ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")]
        [DataType(DataType.Text)]
        public String UserName { get; set; }

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





