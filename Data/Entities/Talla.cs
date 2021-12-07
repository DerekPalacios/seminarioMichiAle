using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class Talla
    {
        public int Id { get; set; }
        public string Nombre_Talla { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }

    }
}
