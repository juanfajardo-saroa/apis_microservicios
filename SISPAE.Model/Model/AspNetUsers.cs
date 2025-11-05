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
     /// Clase Model Base para  AspNetUsers
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class AspNetUsersModelBase : ModelObject
    {
		private DateTime _createdFechaCreacion; 
    public AspNetUsersModelBase() 
    {  
    _createdFechaCreacion= DateTime.MinValue; 
    }  
        

		

        ///Definicion de miembros o metodos privados    
#region Private Members 
#endregion Private Members    


        ///Definicion de miembros o metodos publicos  - Property Declarations  
#region Public Members 
 
        ///  Estas son las propiedades Base de esta clase  
        ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id 
        /// </Resumen> 
        [Display(Name = "SinNombre")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(450 , ErrorMessage = " El campo {0} no debe tener mas de 450 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String Id{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: UserName 
        /// </Resumen> 
        [Display(Name = "User Name")] 
        [StringLength(256 , ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? UserName{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NormalizedUserName 
        /// </Resumen> 
        [Display(Name = "Normalized User Name")] 
        [StringLength(256 , ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? NormalizedUserName{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Email 
        /// </Resumen> 
        [Display(Name = "Email")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(256 , ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")] 
        [EmailAddress(ErrorMessage = "Invalida la direción de correo electróncio ")] 
        public String Email{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NormalizedEmail 
        /// </Resumen> 
        [Display(Name = "Normalized Email")] 
        [StringLength(256 , ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? NormalizedEmail{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EmailConfirmed 
        /// </Resumen> 
        [Display(Name = "Email Confirmed")] 
        public Boolean? EmailConfirmed{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PasswordHash 
        /// </Resumen> 
        [Display(Name = "Password Hash")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [DataType (DataType.MultilineText)]   
        public String PasswordHash{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SecurityStamp 
        /// </Resumen> 
        [Display(Name = "Security Stamp")] 
        [DataType (DataType.MultilineText)]   
        public String? SecurityStamp{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ConcurrencyStamp 
        /// </Resumen> 
        [Display(Name = "Concurrency Stamp")] 
        [DataType (DataType.MultilineText)]   
        public String? ConcurrencyStamp{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PhoneNumber 
        /// </Resumen> 
        [Display(Name = "Phone Number")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [DataType (DataType.MultilineText)]   
        public String PhoneNumber{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PhoneNumberConfirmed 
        /// </Resumen> 
        [Display(Name = "Phone Number Confirmed")] 
        public Boolean? PhoneNumberConfirmed{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TwoFactorEnabled 
        /// </Resumen> 
        [Display(Name = "Two Factor Enabled")] 
        public Boolean? TwoFactorEnabled{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: LockoutEnd 
        /// </Resumen> 
        [Display(Name = "Lockout End")] 
        [DataType (DataType.MultilineText)]   
        public String? LockoutEnd{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: LockoutEnabled 
        /// </Resumen> 
        [Display(Name = "Lockout Enabled")] 
        public Boolean? LockoutEnabled{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: AccessFailedCount 
        /// </Resumen> 
        [Display(Name = "Access Failed Count")] 
        public int? AccessFailedCount{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PrimerNombre 
        /// </Resumen> 
        [Display(Name = "Primer Nombre")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(256 , ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String PrimerNombre{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SegundoNombre 
        /// </Resumen> 
        [Display(Name = "Segundo Nombre")] 
        [StringLength(256 , ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? SegundoNombre{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PrimerApellido 
        /// </Resumen> 
        [Display(Name = "Primer Apellido")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(256 , ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String PrimerApellido{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SegundoApellido 
        /// </Resumen> 
        [Display(Name = "Segundo Apellido")] 
        [StringLength(256 , ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? SegundoApellido{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Cargo 
        /// </Resumen> 
        [Display(Name = "Cargo")] 
        [StringLength(256 , ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? Cargo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: RespuestaSeguridad 
        /// </Resumen> 
        [Display(Name = "Respuesta Seguridad")] 
        [StringLength(256 , ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? RespuestaSeguridad{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: UsuarioAD 
        /// </Resumen> 
        [Display(Name = "Usuario A D")] 
        [StringLength(256 , ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? UsuarioAD{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: GUID 
        /// </Resumen> 
        [Display(Name = "G U I D")] 
        [StringLength(256 , ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? GUID{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PhotoPath 
        /// </Resumen> 
        [Display(Name = "Photo Path")] 
        [StringLength(1000 , ErrorMessage = " El campo {0} no debe tener mas de 1000 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? PhotoPath{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FechaCreacion 
        /// </Resumen> 
        [Display(Name = "Fecha Creacion")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? FechaCreacion

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: auditoria 
        /// </Resumen> 
        [Display(Name = "auditoria")] 
        [DataType (DataType.MultilineText)]   
        public String? auditoria{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_Ubicacion 
        /// </Resumen> 
        [Display(Name = "Ubicacion")] 
        public int? id_Ubicacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: UbicacionBase 
        /// </Resumen> 
        [Display(Name = "Ubicacion Base")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? UbicacionBase{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_TipoActor 
        /// </Resumen> 
        [Display(Name = "Tipo Actor")] 
        public int? id_TipoActor{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sid_TipoActor { get; set; }
        /// 
 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: DocumentoIden 
        /// </Resumen> 
        [Display(Name = "Documento Iden")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(15 , ErrorMessage = " El campo {0} no debe tener mas de 15 caracteres.")] 
        [DataType (DataType.Text)]   
        public String DocumentoIden{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_TipoDocumentoIden 
        /// </Resumen> 
        [Display(Name = "Tipo Documento Iden")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int id_TipoDocumentoIden{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sid_TipoDocumentoIden { get; set; }
        /// 
 
        public String? filtro { get; set; }
#endregion Public Members    



    }
}





