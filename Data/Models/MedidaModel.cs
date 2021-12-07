using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Models
{
    public class MedidaModel
    {
        public int Id { get; set; }
        public string Nombre_Medida { get; set; }
        public int? CantidadArticulos { get; set; }
    }
}
