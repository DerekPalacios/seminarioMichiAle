using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Models
{
    public class VentaModel
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
         public int Telefono { get; set; }
        public string Correo { get; set; }
        //public int TV_IdUsuario { get; set; }
        //public float IVA { get; set; }
        //public decimal Total { get; set; }


        public List<ItemFacturaModel> Items { get; set; } = new List<ItemFacturaModel>();
        public decimal Total => Items.Sum(x => x.Subtotal);
        public decimal Ganancia => Items.Sum(x => x.Margen);
        public int Cantidad => Items.Sum(x => x.Cantidad);
        public int Resultado => Items.Sum(x => x.Resultado);

    }
    public class ItemFacturaModel
    {
        public int Id { get; set; }
        public int IdVenta { get; set; }
        public int IdArticulo { get; set; }
        public decimal Costo { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "Por favor seleccione un articulo")]
        public string Codigo { get; set; }

       
        public string NombreArticulo { get; set; }
        public int Stock { get; set; }

        public int Resultado => Stock - Cantidad;
        public decimal Subtotal => Cantidad * Precio;
      
        public decimal Margen => (Precio - Costo) * Cantidad;
    }
}
