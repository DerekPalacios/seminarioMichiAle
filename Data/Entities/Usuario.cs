using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public int TU_IdRol { get; set; }

        [Required(ErrorMessage = "Los nombres y apellidos son requeridos")]
        public string Nombre_Apellido { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es requerido")]
        public string Nombre_Usuario { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        [MinLength(5, ErrorMessage = "Mínimo 5 caracteres")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres")]
        public string Clave { get; set; }

        [Required(ErrorMessage = "La confirmación de la contraseña es requerida")]
        //[MinLength(5, ErrorMessage = "Mínimo 5 caracteres")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres")]
        [Compare(otherProperty: "Clave", ErrorMessage = "La confirmación no coincide con la contraseña")]
        public string ConfirmarClave { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
