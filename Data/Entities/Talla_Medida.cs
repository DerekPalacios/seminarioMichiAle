using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class Talla_Medida
    {
        public int IdTalla_Medida { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }

    }
}
