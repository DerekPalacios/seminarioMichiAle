using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Models
{
    public class TallaMedidaModel
    {
        public int IdTalla_Medida { get; set; }
        public string Descripcion { get; set; }
        public int? CantidadArticulos { get; set; }
    }
}
