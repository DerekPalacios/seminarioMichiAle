using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Nombre_Categoria { get; set; }

        public virtual ICollection<Articulo>Articulos { get; set; }
    }
}
