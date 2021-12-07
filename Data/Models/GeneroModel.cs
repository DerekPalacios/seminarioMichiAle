using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Models
{
    public class GeneroModel
    {
        public int Id { get; set; }
        public string Nombre_Genero { get; set; }
        public int? CantidadProductos { get; set; }
    }
}
