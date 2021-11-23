using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Models
{
    public class VentaModel
    {
        public int IdVenta { get; set; }
        public string NumVenta { get; set; }
        public int TV_IdCliente { get; set; }
        //public int TV_IdUsuario { get; set; }
        public DateTime FechaVenta { get; set; }
        public string NombreCliente { get; set; }

        //public float IVA { get; set; }
        //public decimal Total { get; set; }


        public List<ItemFacturaModel> Items { get; set; }
        public decimal Total => Items.Sum(x => x.Subtotal);
        public decimal Ganancia => Items.Sum(x => x.Margen);
    }
    public class ItemFacturaModel
    {
        public int IdDetalleVenta { get; set; }
        public int TDV_IdVenta { get; set; }
        public string Codigo { get; set; }
        public int TDV_IdArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public decimal PrecioCompra { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public decimal Subtotal => Cantidad * PrecioUnidad;
        public decimal Margen => (PrecioUnidad - PrecioCompra) * Cantidad;
    }
}
