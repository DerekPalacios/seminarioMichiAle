﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Models
{
    public class CategoriaModel
    {
        public int Id { get; set; }
        public string Nombre_Categoria { get; set; }
        public int? CantidadProductos { get; set; }
    }
}
