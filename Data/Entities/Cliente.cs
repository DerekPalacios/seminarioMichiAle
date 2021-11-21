using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombe_Apellido { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }

        public virtual ICollection<Venta> Ventas { get; set; }
    }
}
