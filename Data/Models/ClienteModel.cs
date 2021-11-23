using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Models
{
    public class ClienteModel
    {
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Apellidos { get; set; }

        public string NombreCompleto=> $"{Nombres} {Apellidos}";
        public string Identificacion { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Email no valido")]
        public string Correo { get; set; }

  
    }
}
