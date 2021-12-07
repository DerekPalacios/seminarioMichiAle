﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        public int IdRol { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es requerido")]
        public string Nombre_Usuario { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        [MinLength(5, ErrorMessage = "Mínimo 5 caracteres")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres")]
        public string Clave { get; set; }

        [Required(ErrorMessage = "La confirmación de la contraseña es requerida")]
        [MinLength(5, ErrorMessage = "Mínimo 5 caracteres")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres")]
        [Compare(otherProperty: "Clave", ErrorMessage = "La confirmación no coincide con la contraseña")]
        public string ConfirmarClave { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
