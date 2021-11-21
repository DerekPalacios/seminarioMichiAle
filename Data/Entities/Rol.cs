using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class Rol
    {
        public int IdRol { get; set; }
        public string Nombre_Rol { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
