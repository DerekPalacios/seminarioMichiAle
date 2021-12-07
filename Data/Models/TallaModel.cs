using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Models
{
    public class TallaModel
    {
        public int Id { get; set; }
        public string Nombre_Talla { get; set; }
        public int? CantidadArticulos { get; set; }
    }
}
