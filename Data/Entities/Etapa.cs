using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class Etapa
    {
        public int IdEtapa { get; set; }
        public string Nombre_Etapa { get; set; }
        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}
