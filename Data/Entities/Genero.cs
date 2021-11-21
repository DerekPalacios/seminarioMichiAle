using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class Genero
    {
        public int IdGenero { get; set; }
        public string Nombre_Genero { get; set; }
        public virtual ICollection<Articulo> Articulos { get; set; }

    }
}
