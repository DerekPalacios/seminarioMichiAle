using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public int IdTalla{ get; set; }
        public int IdMedida { get; set; }
        public int IdEtapa { get; set; }
        public int IdGenero { get; set; }
        public int IdMaterial { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual Talla Talla { get; set; }
        public virtual Etapa Etapa { get; set; }
        public virtual Medida Medida { get; set; }
        public virtual Genero Genero { get; set; }
        public virtual Material Material { get; set; }
        public virtual ICollection<DetalleVenta>DetalleVentas { get; set; }


    }
}
