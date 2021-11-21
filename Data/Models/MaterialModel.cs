using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Models
{
    public class MaterialModel
    {
        public int IdMaterial { get; set; }
        public string Nombre_Material { get; set; }

        public int? CantidadProductos { get; set; }
    }
}
