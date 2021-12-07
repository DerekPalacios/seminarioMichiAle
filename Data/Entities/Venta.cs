using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class Venta
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        //public int TV_IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        //public float IVA { get; set; }
        //public decimal Total { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<DetalleVenta> DetalleVentas { get; set; }
    }
}
