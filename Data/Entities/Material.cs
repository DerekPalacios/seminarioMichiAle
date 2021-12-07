using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class Material
    {
        public int Id { get; set; }
        public string Nombre_Material { get; set; }
        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}
