using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class DetalleVenta
    {
        public int Id { get; set; }
        public int IdVenta { get; set; }
        public int IdArticulo { get; set; }
        public decimal Costo { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        //public decimal Descuento { get; set; }

        public virtual Articulo Articulo { get; set; }

        public virtual Venta Venta { get; set; }
    }
}
