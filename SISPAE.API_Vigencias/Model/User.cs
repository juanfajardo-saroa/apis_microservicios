
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SISPAE_API_Vigencias.WebAPI.Model
{


    public class User : IdentityUser
        {

        //[StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        //public String UserName { get; set; }

        //[StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        //[EmailAddress(ErrorMessage = "Invalida la direción de correo electróncio ")]
        //public String Email { get; set; }


        [StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        public String PrimerNombre { get; set; }

        [StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        public String? SegundoNombre { get; set; }

        [StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        public String PrimerApellido { get; set; }

        [StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        public String? SegundoApellido { get; set; }

        [StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        public String? Cargo { get; set; }

        [StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        public String? RespuestaSeguridad { get; set; }

        [StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        public String? UsuarioAD { get; set; }

        [StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        public String? GUID { get; set; }

        [StringLength(1000, ErrorMessage = " El campo {0} no debe tener mas de 1000 caracteres.")]
        public String? PhotoPath { get; set; }


        public int? id_Ubicacion { get; set; }

        [StringLength(100, ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")]
        public String? UbicacionBase { get; set; }

        public int? id_TipoActor { get; set; }

        public String DocumentoIden { get; set; }

        public int id_TipoDocumentoIden { get; set; }

        public String? auditoria { get; set; }
        }

    public class UserDTO
        {

        public String? Id { get; set; }

        [StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        public String UserName { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        [EmailAddress(ErrorMessage = "Invalida la direción de correo electróncio ")]
        public String Email { get; set; }

        //[Required]
        public String Password { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        public String PrimerNombre { get; set; }

        [StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        public String SegundoNombre { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        public String PrimerApellido { get; set; }

        [StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        public String SegundoApellido { get; set; }

        [Required]
        public String NumeroTelefono { get; set; }


        [StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        [DataType(DataType.MultilineText)]
        public String Cargo { get; set; }

        [StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        public String RespuestaSeguridad { get; set; }

        [StringLength(256, ErrorMessage = " El campo {0} no debe tener mas de 256 caracteres.")]
        public String UsuarioAD { get; set; }

        [StringLength(1000, ErrorMessage = " El campo {0} no debe tener mas de 1000 caracteres.")]
        public String PhotoPath { get; set; }


        public int? id_Ubicacion { get; set; }

        public String UbicacionBase { get; set; }

        public int? id_TipoActor { get; set; }

        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sid_TipoActor { get; set; }

        [Required]
        public String DocumentoIden { get; set; }

        [Required]
        public int id_TipoDocumentoIden { get; set; }

        [Required]
        public string idRol { get; set; }


        }

    }
