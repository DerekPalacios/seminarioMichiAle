using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Models
{
    public class ArticuloModel
    {
        public int IdArticulo { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Codigo { get; set; }

        [Required(ErrorMessage ="Campo Obligatorio")]
        [MinLength(5, ErrorMessage = "Minimo 5 caracteres")]
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public decimal PrecioCompra { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public decimal PrecioVenta { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public int TA_IdCategoria { get; set; }
        public int TA_IdTalla_Medida { get; set; }
        public int TA_IdEtapa { get; set; }
        public int TA_IdGenero { get; set; }
        public int TA_IdMaterial { get; set; }

        public decimal? Margen => (PrecioVenta - PrecioCompra);
    }
}
