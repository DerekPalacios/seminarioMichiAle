using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Models
{
    public class ArticuloModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Codigo { get; set; }
        public int IdCategoria { get; set; }

        [Required(ErrorMessage ="Campo Obligatorio")]
        [MinLength(5, ErrorMessage = "Minimo 5 caracteres")]
        public string Nombre { get; set; }
        public int IdTalla { get; set; }
        public int IdMedida { get; set; }
        public int IdEtapa { get; set; }
        public int IdGenero { get; set; }
        public int IdMaterial { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public decimal Costo { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
     

        public decimal? Margen => (Precio - Costo);
    }
}
