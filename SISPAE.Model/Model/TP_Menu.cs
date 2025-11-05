/// <Derechos_Reservados>
/// Aplicacion      :Doc4Us 
/// Autor           :Oscar Mauricio Cortes Pinzon
/// Generacion      :Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano             :2018
/// Arquitectura    :Patron MVC ASP Net Core, Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa            :MODEL (Model Entity Layer) - Capa Model (Source: MVC7_DAL_ModelBase.CS)  Partial Interface 
/// </Derechos_Reservados>


using System;
using System.ComponentModel.DataAnnotations;

namespace SISPAE.Model
{
    /// <Resumen>
    /// Clase Model Base para  TP_Menu
    /// No haga cambios sobre esta clase,
    /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
    /// esta es una clase abstracta que decora la clase principal
    /// </Resumen>


    public class TP_MenuModelBase : ModelObject
    {
        public TP_MenuModelBase()
        {
        }




        ///Definicion de miembros o metodos privados    
        #region Private Members 
        #endregion Private Members    
        ///    

        ///Definicion de miembros o metodos publicos  - Property Declarations  
        #region Public Members 


       ///  Estas son las propiedades Base de esta clase  
        ///    
        [Display(Name = "SinNombre")]

        public string sID

            {
            get;
            set;

            }

        ///  Estas son las propiedades Base de esta clase  
        ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id 
        /// </Resumen> 
        [Display(Name = ".")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        public int Id { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Nombre 
        /// </Resumen> 
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        [StringLength(160, ErrorMessage = " El campo {0} no debe tener mas de 160 caracteres.")]
        [DataType(DataType.MultilineText)]
        public String Nombre { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Controlador 
        /// </Resumen> 
        [Display(Name = "Controlador")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        [StringLength(160, ErrorMessage = " El campo {0} no debe tener mas de 160 caracteres.")]
        [DataType(DataType.MultilineText)]
        public String Controlador { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Accion 
        /// </Resumen> 
        [Display(Name = "Accion")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        [StringLength(160, ErrorMessage = " El campo {0} no debe tener mas de 160 caracteres.")]
        [DataType(DataType.MultilineText)]
        public String Accion { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: GrupoEsquema 
        /// </Resumen> 
        [Display(Name = "Grupo Esquema")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        [StringLength(160, ErrorMessage = " El campo {0} no debe tener mas de 160 caracteres.")]
        [DataType(DataType.MultilineText)]
        public String GrupoEsquema { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Link 
        /// </Resumen> 
        [Display(Name = "Link")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        [StringLength(160, ErrorMessage = " El campo {0} no debe tener mas de 160 caracteres.")]
        [DataType(DataType.MultilineText)]
        public String Link { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Orden 
        /// </Resumen> 
        [Display(Name = "Orden")]
        public int? Orden { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: OrdenPadre 
        /// </Resumen> 
        [Display(Name = "Orden Padre")]
        public int? OrdenPadre { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Padre 
        /// </Resumen> 
        [Display(Name = "Padre")]
        public int? Padre { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Icono 
        /// </Resumen> 
        [Display(Name = "Icono")]
        [StringLength(50, ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")]
        [DataType(DataType.Text)]
        public String Icono { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: MenuRol 
        /// </Resumen> 
        [Display(Name = "Menu Rol")]
        [StringLength(150, ErrorMessage = " El campo {0} no debe tener mas de 150 caracteres.")]
        [DataType(DataType.MultilineText)]
        public String MenuRol { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Estado 
        /// </Resumen> 
        [Display(Name = "Estado")]
        [Required(ErrorMessage = " El Campo {0} es obligatorio, no puede estar vacio !")]
        public Boolean Estado { get; set; }
		
		
		 /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Estado 
        /// </Resumen> 
        [Display(Name = "Estado Menu")]
        public Boolean EstadoMenu { get; set; }
		

        public String filtro { get; set; }
        #endregion Public Members    
        ///    


    }
}
