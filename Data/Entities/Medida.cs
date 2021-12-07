using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class Medida
    {
        public int Id { get; set; }
        public string Nombre_Medida { get; set; }
        public virtual ICollection<Articulo> Articulos { get; set; }

    }
}
