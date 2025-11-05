
using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations;

namespace SISPAE.WebAPI.Model
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


        }

    }
