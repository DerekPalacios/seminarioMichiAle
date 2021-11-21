using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombe_Empresa { get; set; }
         public string Nombe_Contacto { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
      
    }
}
